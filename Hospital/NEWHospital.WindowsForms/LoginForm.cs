using Hospital;
using Hospital.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NEWHospital.WindowsForms
{
    public partial class LoginForm : Form
    {
        private readonly MyContext context;
        public Doctor DoctorAuth { get; set; }
        public Department DepartmentAuth { get; set; }
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
            var doctor = context.Doctors.FirstOrDefault(x => x.Login == login);
            var department = context.Departments.FirstOrDefault(y => y.Id == doctor.DepartmentId);
            if (doctor != null)
            {
                var passwordHash = doctor.Password;
                if(PasswordManager.Verify(password,passwordHash))
                {
                    DoctorAuth = doctor;
                    DepartmentAuth = department;
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
