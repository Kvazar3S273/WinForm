using Hospital;
using System;
using System.Windows.Forms;

namespace NEWHospital.WindowsForms
{
    public partial class MenuForm : Form
    {
        bool isAuth = false;
        public Doctor DoctorAuth { get; set; }
        public Department DepartmentAuth { get; set; }
        public Doctor Doc { get; set; }
        public MenuForm()
        {
            LoginForm login_dlg = new LoginForm();
            if (login_dlg.ShowDialog() == DialogResult.OK)
            {
                DoctorAuth = login_dlg.DoctorAuth;
                DepartmentAuth = login_dlg.DepartmentAuth;
                isAuth = true;
            }
            InitializeComponent();
        }
        
        private void MenuForm_Load(object sender, EventArgs e)
        {
            if(!isAuth)
            {
                Application.Exit();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm pf = new ProfileForm();
            pf.Show();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            BazaForm bf = new BazaForm();
            bf.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewForm anf = new AddNewForm();
            anf.Show();
        }
    }
}
