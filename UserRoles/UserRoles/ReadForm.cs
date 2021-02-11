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
using UserRoles.Models;

namespace UserRoles
{
    public partial class ReadForm : Form
    {
        private readonly EFContext _context = new EFContext();

        public ReadForm()
        {
            InitializeComponent();
        }

        private void ReadForm_Load(object sender, EventArgs e)
        {
            var data = _context.UserRoles.Include(x => x.User).Include(y => y.Role).AsQueryable();
            var list = data.Select(x => new
            {
                Name = x.User.Name,
                Email = x.User.Email,
                PhoneNumber = x.User.PhoneNumber,
                Role = x.Role.Title
            }).AsQueryable();

            foreach (var n in list)
            {
                object[] row =
                {
                    $"{n.Name}",
                    $"{n.Email}",
                    $"{n.PhoneNumber}",
                    $"{n.Role}"
                };
                dataGridView.Rows.Add(row);
            }
        }

        private void SearchUser(SearchUser search = null)
        {
            dataGridView.Rows.Clear();
            search ??= new SearchUser();
            var result = UserService.Search(_context, search);
            foreach (var n in result.Users)
            {
                object[] row =
                {
                    n.Name,
                    n.Email,
                    n.PhoneNumber,
                    n.Role
                };
                dataGridView.Rows.Add(row);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUser(GetSearchInputValue());
        }

        private SearchUser GetSearchInputValue()
        {
            SearchUser search = new SearchUser();
            search.Name = tbName.Text;
            search.Email = tbEmail.Text;
            search.PhoneNumber = tbPhoneNumber.Text;
            search.Role = tbRole.Text;

            return search;
        }
    }
}
