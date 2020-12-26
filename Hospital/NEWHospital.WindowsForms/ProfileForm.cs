using Hospital;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NEWHospital.WindowsForms
{
    public partial class ProfileForm : Form
    {
        public Doctor DoctorAuth { get; set; }
        public Doctor Doc { get; set; }
        public Department DepartmentAuth { get; set; }
        public ProfileForm()
        {
            MenuForm mf = new MenuForm();
            DoctorAuth = mf.DoctorAuth;
            DepartmentAuth = mf.DepartmentAuth;
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            pictAva.Image = Image.FromFile($"images/{DoctorAuth.Image}");
            txtLastName.Text = DoctorAuth.LastName;
            txtFirstName.Text = DoctorAuth.FirstName;
            txtStage.Text = DoctorAuth.Stage.ToString();
            txtDepartment.Text = DepartmentAuth.Name;
            txtLogin.Text = DoctorAuth.Login;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
