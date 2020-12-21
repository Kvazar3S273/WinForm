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
    public partial class BazaForm : Form
    {
        public BazaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye!");
        }

        private void BazaForm_Load(object sender, EventArgs e)
        {
            MyContext context = new MyContext();
            foreach (var item in context.Doctors.Include(x=>x.Department))
            {
                object[] row =
                {
                    $"{item.LastName} {item.FirstName}",
                    $"{item.Login}",
                    $"{item.Password}",
                    $"{item.Department.Name}",
                    $"{item.Stage}"
                };
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
