using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital.WindowsForms
{
    public partial class MenuForm : Form
    {
        bool isAuth = false;
        private Doctor DoctorAuth { get; set; }
        private Department DepartmentAuth { get; set; }
        public MenuForm()
        {
            FormLogin login_dlg = new FormLogin();
            if (login_dlg.ShowDialog() == DialogResult.OK)
            {
                DoctorAuth = login_dlg.DoctorAuth;
                DepartmentAuth = login_dlg.DepartmentAuth;
                isAuth = true;
            }
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllForm saf = new ShowAllForm();
            saf.ShowDialog();
            
            //this.DialogResult = DialogResult.OK;
            //Application.Run(new BazaForm());
            //bf.Show();
            //this.Hide();
        }
        
    }
}
