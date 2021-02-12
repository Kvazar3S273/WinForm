using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UserRoles.Entities;
using UserRoles.Models;

namespace UserRoles
{
    public partial class CreateForm : Form
    {
        private readonly EFContext _context;
        public CreateForm()
        {
            _context = new EFContext();
            InitializeComponent();
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            cbRole.Items.AddRange(
                new List<ComboBoxItem>
                {
                    new ComboBoxItem{ Id=1, Name="HR" },
                    new ComboBoxItem{ Id=2, Name="Developer" },
                    new ComboBoxItem{ Id=3, Name="Designer" },
                    new ComboBoxItem{ Id=4, Name="System administrator" },
                    new ComboBoxItem{ Id=5, Name="Artist" }
                }.ToArray()
                );
            cbRole.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _context.Users.Add(
                new User
                {
                    Name = tbName.Text,
                    Password=tbPassword.Text,
                    Email = tbEmail.Text,
                    PhoneNumber = tbPhoneNumber.Text,
                });
            _context.SaveChanges();
            var maxId = _context.Users.Max(x => x.Id);
            var selectedComboBox = cbRole.SelectedItem;
            if (selectedComboBox != null)
            {
                var takeRole = cbRole.SelectedItem as ComboBoxItem;
                _context.UserRoles.Add(new UserRole
                {
                    UserId = maxId,
                    RoleId = takeRole.Id
                });
            }
            _context.SaveChanges();
            this.Close();
        }
    }
}
