using Hospital;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace NEWHospital.WindowsForms
{
    public partial class BazaForm : Form
    {
        public BazaForm()
        {
            InitializeComponent();
        }

        private void BazaForm_Load(object sender, EventArgs e)
        {
            MyContext context = new MyContext();
            foreach (var item in context.Doctors.Include(x=>x.Department))
            {
                object[] row =
                {
                    $"{item.LastName}",
                    $"{item.FirstName}",
                    $"{item.Stage}",
                    $"{item.Login}"
                };
                dataGridView1.Rows.Add(row);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
