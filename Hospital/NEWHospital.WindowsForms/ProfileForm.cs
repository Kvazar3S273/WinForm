using Hospital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NEWHospital.WindowsForms
{
    public partial class ProfileForm : Form
    {
        public Doctor DoctorAuth { get; set; }
        public Department DepartmentAuth { get; set; }
        bool isAuth = false;
        public ProfileForm()
        {
            MenuForm mf = new MenuForm();
            DoctorAuth = mf.DoctorAuth;
            DepartmentAuth = mf.DepartmentAuth;
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            MyContext context = new MyContext();
            string login = DoctorAuth.Login;


            //string login = txtLogin.Text;

            //string password = txtPassword.Text;
            //var doctor = context.Doctors.FirstOrDefault(x => x.Login == login);
            //if (doctor != null)
            //{
            //    var passwordHash = doctor.Password;
            //    if (PasswordManager.Verify(password, passwordHash))
            //    {
            //        this.DialogResult = DialogResult.OK;
            //    }
            //    else
            //        MessageBox.Show("Помилка при введенні логіну або паролю");
            //}

            var doc = context.Doctors.FirstOrDefault(x => x.Login == login);
            var dep = context.Departments.FirstOrDefault(y => y.Id==doc.DepartmentId);

            //if(isAuth)
            //{
                pictAva.Image = Image.FromFile($"images/{doc.Image}");
                txtLastName.Text = "Прізвище: "+ doc.LastName;
                txtFirstName.Text = "Ім\'я: " + doc.FirstName;
                txtStage.Text = "Стаж: " + doc.Stage.ToString();
                txtDepartment.Text = "Відділення: " + dep.Name;
            //}
            

            
        }
    }
}
