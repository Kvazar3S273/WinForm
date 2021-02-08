using Audit.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Audit.WindowsForms
{
    public partial class LoginForm : Form
    {
        private readonly MyContext context;
        public UserAudit User { get; set; }

        public LoginForm()
        {
            context = new MyContext();
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string login = tboxLogin.Text;
            string pass = tboxPassword.Text;
            var user = context.Users.FirstOrDefault(u => u.Login == login);
            if(user!=null)
            {
                User = user;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Так діла не буде...");
            }
        }
    }
}
