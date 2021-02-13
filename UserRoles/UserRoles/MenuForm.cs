using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserRoles.Entities;

namespace UserRoles
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            EFContext context = new EFContext();
            InitializeComponent();
            Seeder.SeedDataBase(context);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new CreateForm().ShowDialog();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            new ReadForm().ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{

        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
