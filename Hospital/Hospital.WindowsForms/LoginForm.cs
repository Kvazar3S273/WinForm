using Hospital.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.WindowsForms
{
    public partial class FormLogin : Form
    {
        private readonly MyContext context;
        public FormLogin()
        {
            context = new MyContext();
            InitializeComponent();
            DbSeeder.SeedAll(context);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            var doctor = context.Doctors.FirstOrDefault(x => x.Login == login);

            if (doctor!=null)
            {
                var passwordHash = doctor.Password;
                if(PasswordManager.Verify(password,passwordHash))
                    this.DialogResult = DialogResult.OK;
                else
                    MessageBox.Show("Try again");
            }
            else
                MessageBox.Show("Try again");
        }
    }
}
