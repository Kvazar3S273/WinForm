using Hospital;
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

namespace NEWHospital.WindowsForms
{
    public partial class LoginForm : Form
    {
        private readonly MyContext context;

        public LoginForm()
        {
            context = new MyContext();
            InitializeComponent();
            DbSeeder.SeedAll(context);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            var doctor = context.Doctors.FirstOrDefault(x => x.Login == login && x.Password == password);
            if (doctor != null)
            {
                var passwordHash = doctor.Password;
                if(PasswordManager.Verify(password,passwordHash))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Помилка при введенні логіну або паролю");
            }
            else
                MessageBox.Show("Помилка при введенні логіну або паролю");
        }
    }
}
