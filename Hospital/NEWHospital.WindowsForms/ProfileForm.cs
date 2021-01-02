using Hospital;
using NEWHospital.WindowsForms.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NEWHospital.WindowsForms
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            using (MyContext context = new MyContext())
            {
                var doctor = context.Doctors.SingleOrDefault(x => x.Id == DoctorLogin.Id);
                txtLastName.Text = $"{doctor.LastName}";
                txtFirstName.Text = $"{doctor.FirstName}";
                txtStage.Text = $"{doctor.Stage.ToString()}";
                //txtDepartment.Text = $"{doctor.Department.Name}";
                txtLogin.Text = $"{doctor.Login}";
                pictAva.Image = Image.FromFile($"images/{doctor.Image}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
