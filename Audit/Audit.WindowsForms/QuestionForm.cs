using Audit.DAL;
using Audit.WindowsForms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Audit.WindowsForms
{
    public partial class QuestionForm : Form
    {
        /// <summary>
        /// Питання.
        /// </summary>
        private List<QuestionModel> _listQuestions;

        private readonly MyContext context;

        /// <summary>
        /// Поточне питання.
        /// </summary>
        private int indexQuestion = 0;

        /// <summary>
        /// Кількість питань у тестах
        /// </summary>
        int cou = 0;

        /// <summary>
        /// Масив булевих значень відповідей.
        /// </summary>
        private bool[] result;

        /// <summary>
        /// Айді останньої створеної сесії після логіна користувача.
        /// </summary>
        private readonly int sesmax;

        /// <summary>
        /// Лічильник правильних відповідей.
        /// </summary>
        private int q;

        /// <summary>
        /// Для таймера інтервал секунд.
        /// </summary>
        private int _tick;

        /// <summary>
        /// Лічильник тіків таймера.
        /// </summary>
        private int count = 0;

        /// <summary>
        /// Властивість,що містить айді користувача
        /// </summary>
        public UserAudit LogInstancem { get; set; }

        /// <summary>
        /// Властивіть,що містить айді останньої сесії.
        /// </summary>
        public int idsession
        {
            get
            {
                return sesmax;
            }

            set
            {
                value = sesmax;
            }
        }

        /// <summary>
        /// Властивість,кількість тіків.
        /// </summary>
        public int count_tick { get; set; }

        /// <summary>
        /// Правильні відповіді.
        /// </summary>
        public int positive
        {
            get
            {
                return q;
            }
            set
            {
                value = positive;
            }
        }


        /// <summary>
        /// Неправильні відповіді.
        /// </summary>
        public int negative
        {
            get
            {
                return _listQuestions.Count();
            }
            set
            {
                value = _listQuestions.Count();
            }
        }

        public QuestionForm()
        {
            context = new MyContext();
            LoginForm login = new LoginForm();
            if(login.ShowDialog()==DialogResult.OK)
            {
                LogInstancem = login.User;

                var sess = new SessionAudit
                {
                    UserId = LogInstancem.Id,
                    Begin = DateTime.Now,
                    Marks = 60M
                };
                context.Sessions.Add(sess);
                context.SaveChanges();
            }

            var info = context.Sessions.Max(x => x.Id);
            sesmax = info;

            _listQuestions = context.Questions.Select(x => new QuestionModel
            {
                Text = x.Text,
                Answers = x.Answers.Select(y => new QuestionAnswerModel
                {
                    Id = y.Id,
                    Text = y.Text,
                    IsTrue = y.IsTrue
                }).ToList()
            }).ToList();

            InitializeComponent();

            timer1.Start();
            cou = context.Questions.Count();
            lbl2.Text = $" із {cou}";
            result = new bool[_listQuestions.Count];
        }

        private void LoadQuestion()
        {
            lblQuestion.Text = _listQuestions[indexQuestion].Text;
            var answers = _listQuestions[indexQuestion].Answers;
            int dy = 25;
            int startPosition = 30;
            gbAnswers.Controls.Clear();
            for (int i = 0; i < answers.Count; i++)
            {
                RadioButton gb;
                gb = new System.Windows.Forms.RadioButton();
                gb.AutoSize = true;
                gb.Location = new System.Drawing.Point(25, startPosition);
                gb.Name = $"gbItem{i}";
                gb.Tag = answers[i];
                gb.Size = new System.Drawing.Size(67, 19);
                gb.TabIndex = 1;
                gb.TabStop = true;
                gb.Text = answers[i].Text;
                gb.UseVisualStyleBackColor = true;
                gbAnswers.Controls.Add(gb);
                startPosition += dy;
                lbl4.Text = $"Запитання:  {indexQuestion + 1}";
            }


        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Кількість правильних відповідей.
            q = 0;

            var radioButtons = gbAnswers.Controls.OfType<RadioButton>();
            foreach (RadioButton rb in radioButtons)
            {
                if (rb.Checked)
                {
                    var answer = rb.Tag as QuestionAnswerModel;
                    result[indexQuestion] = answer.IsTrue;

                    var infoid = context.Answers.Where(x => x.Id == answer.Id).ToList();
                    foreach (var item in infoid)
                    {
                        context.Results.Add(new ResultAudit { SessionId = idsession, AnswerId = item.Id });
                        context.SaveChanges();
                    }
                }
            }

            foreach (var item in result)
            {
                if (item == true)
                {
                    q++;
                }
            }

            indexQuestion++;

            if (_listQuestions.Count() == indexQuestion)
            {
                //Close();  
                var total = context.Sessions.Where(x => x.Id == sesmax).ToList();
                //Додала в таблицю Сесія,скільки часу було потрачено на тест і записала в базу.
                foreach (var item in total)
                {
                    item.End = DateTime.Now.AddSeconds(count_tick);
                    context.SaveChanges();
                }
                count_tick = count;
                new ResultForm(this).ShowDialog();
            }
            else
            {
                LoadQuestion();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ResultForm(this).ShowDialog();
        }

        private void QuestionForm_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _tick++;
            tBoxTimer.Text = _tick.ToString();
            count++;
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            LoadQuestion();
        }
    }
}
