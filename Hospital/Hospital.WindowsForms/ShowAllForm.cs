using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital.WindowsForms
{
    public partial class ShowAllForm : Form
    {
        public ShowAllForm()
        {
            InitializeComponent();
        }

        private void ShowAllForm_Load(object sender, EventArgs e)
        {
            MyContext context = new MyContext();
            foreach (var item in context.Doctors.Include(x=>x.Department))
            {
                object[] row =
                {
                    $"{item.FirstName}",
                    $"{item.LastName}",
                    $"{item.Stage}",
                    $"{item.Department.Name}"
                };
                dataGridView1.Rows.Add(row);
            }

        }

    }
}
