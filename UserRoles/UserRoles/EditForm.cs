using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserRoles
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            //string _name = dataGridView["ColName", dataGridView.CurrentRow.Index].Value.ToString();
            //string _email = dataGridView["ColEmail", dataGridView.CurrentRow.Index].Value.ToString();
            //string _phone = dataGridView["ColPhone", dataGridView.CurrentRow.Index].Value.ToString();

            //MessageBox.Show($"Ім'я  {_name}\nE-mail  {_email}\nPhone  {_phone}");

            //User user = _context.Users.SingleOrDefault(x => x.Name == _name);
            //if(user!=null)
            //{
            //    user.Name = "0000";
            //    _context.SaveChanges();
            //}


            //_context.SaveChanges();
        }
    }
}
