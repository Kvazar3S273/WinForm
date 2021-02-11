using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UserRoles.Entities;

namespace UserRoles
{
    public partial class ReadForm : Form
    {
        public ReadForm()
        {
            InitializeComponent();
        }

        private void ReadForm_Load(object sender, EventArgs e)
        {
            EFContext context = new EFContext();
            var data = context.UserRoles.Include(x => x.User).Include(y => y.Role).AsQueryable();
            var list = data.Select(x => new
            {
                Id = x.User.Id,
                Name = x.User.Name,
                Email = x.User.Email,
                PhoneNumber = x.User.PhoneNumber,
                Role = x.Role.Title
            }).AsQueryable();

            foreach (var n in list)
            {
                object[] row =
                {
                    $"{n.Id}",
                    $"{n.Name}",
                    $"{n.Email}",
                    $"{n.PhoneNumber}",
                    $"{n.Role}"
                };
                dataGridView.Rows.Add(row);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
