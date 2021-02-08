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
        // Питання.
        private List<QuestionModel> _listQuestions;

        private readonly MyContext context;

        // Поточне питання.
        private int indexQuestion = 0;

        // Кількість всіх запитань у тестах
        int countQuestions = 0;

        // Масив правильних відповідей (true/false)
        private bool[] result;

        // Останя сесія користувача, який залогінився
        private readonly int lastSession;

        // Кількість правильних відповідей
        private int rightAnswer;

        // Інтервал секунд (для таймера)
        private int _tick;

        // Лічильник тіків таймера.
        private int tickCount = 0;

        // Залогінений користувач
        public UserAudit UserIsLogined { get; set; }

        // ID останньої сесії.
        public int SessionID
        {
            get
            {
                return lastSession;
            }
            set
            {
                value = lastSession;
            }
        }

        // Кількість тіків
        public int count_tick { get; set; }

        // Правильні відповіді
        public int RightAnswers
        {
            get
            {
                return rightAnswer;
            }
            set
            {
                value = RightAnswers;
            }
        }

        // Неправильні відповіді
        public int WrongAnswers
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
                UserIsLogined = login.User;

                var sess = new SessionAudit
                {
                    UserId = UserIsLogined.Id,
                    Begin = DateTime.Now,
                    Marks = 60M
                };
                context.Sessions.Add(sess);
                context.SaveChanges();
            }

            var info = context.Sessions.Max(x => x.Id);
            lastSession = info;

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
            countQuestions = context.Questions.Count();
            lbl2.Text = $" із {countQuestions}";
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
            rightAnswer = 0;

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
                        context.Results.Add(new ResultAudit { SessionId = SessionID, AnswerId = item.Id });
                        context.SaveChanges();
                    }
                }
            }

            foreach (var item in result)
            {
                if (item == true)
                {
                    rightAnswer++;
                }
            }

            indexQuestion++;

            if (_listQuestions.Count() == indexQuestion)
            {
                var total = context.Sessions.Where(x => x.Id == lastSession).ToList();
                foreach (var item in total)
                {
                    item.End = DateTime.Now.AddSeconds(count_tick);
                    context.SaveChanges();
                }
                count_tick = tickCount;
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
            tickCount++;
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            LoadQuestion();
        }
    }
}
