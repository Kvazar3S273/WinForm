using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hospital;

namespace Hospital.WindowsForms
{
    public partial class BazaForm : Form
    {
        bool isAuth = false;
        private Doctor DoctorAuth { get; set; }
        public BazaForm()
        {
            FormLogin login_dlg = new FormLogin();
            if (login_dlg.ShowDialog()==DialogResult.OK)
            {
                DoctorAuth = login_dlg.DoctorAuth;
                isAuth = true;
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye!");
        }

        private void BazaForm_Load(object sender, EventArgs e)
        {
            if (!isAuth)
            {
                Application.Exit();
            }
            else
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
                pbImage.Image = Image.FromFile($"images/{DoctorAuth.Image}");
            }
        }
    }
}
