using PhoneBook.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook.WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyContext context = new MyContext();
            foreach (var item in context.Humans)
            {
                object[] row =
                {
                    $"{item.Surname} {item.Name}",
                    $"{item.Gender}",
                    $"{item.Phone}"
                };
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
