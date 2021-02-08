using Audit.DAL;
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
    public partial class ResultForm : Form
    {
        public UserAudit UserSample { get; set; }

        public ResultForm(QuestionForm form)
        {
            InitializeComponent();
            lblRightAnswers.Text = $"Кількість правильних відповідей: {form.positive}";
            lblWrongAnswers.Text = $"Кількість неправильних відповідей: { form.negative - form.positive}";
            lblIQ.Text = $"Ваш IQ: {(form.positive * 100) / form.negative}";
            UserSample = form.LogInstancem;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            MyContext context = new MyContext();
            var info = context.Sessions
               .Where(x => x.UserId == UserSample.Id)
               .Select(x => new
               {
                   Id = x.Id,
                   Name = x.User.Name,
                   Surname = x.User.Surname,
                   Begin = x.Begin,
                   End = x.End,
               }).ToList();

            foreach (var item in info)
            {
                object[] row =
                       {$"{item.Id}",
                        $"{item.Name}",
                        $"{item.Surname}",
                        $"{item.Begin}",
                        $"{item.End}"

                    };

                dataGridView1.Rows.Add(row);

            }
        }
    }
}
