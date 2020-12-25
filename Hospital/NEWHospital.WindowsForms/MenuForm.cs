using Hospital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NEWHospital.WindowsForms
{
    public partial class MenuForm : Form
    {
        bool isAuth = false;
        public MenuForm()
        {
            LoginForm login_dlg = new LoginForm();
            if (login_dlg.ShowDialog() == DialogResult.OK)
            {
                isAuth = true;
            }
            InitializeComponent();
        }

        public Doctor DoctorAuth { get; internal set; }
        public Department DepartmentAuth { get; internal set; }

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
            pf.ShowDialog();
        }
    }
}
