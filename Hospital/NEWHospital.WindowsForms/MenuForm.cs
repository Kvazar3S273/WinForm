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

        private void MenuForm_Load(object sender, EventArgs e)
        {
            if(!isAuth)
            {
                Application.Exit();
            }
        }
    }
}
