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
                Id=x.User.Id,
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
            
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView.ReadOnly = true;
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
                    n.Id,
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
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Знаходимо ID запису в базі даних
            int index = int.Parse(dataGridView["ColId", dataGridView.CurrentRow.Index].Value.ToString());

            // Знаходимо номер рядка в датагріді, на якому стоїть курсор
            int indexInDGV = dataGridView.SelectedCells[0].RowIndex;

            // Визначаємо користувача, якого будемо видаляти по занйденому ID
            User user = _context.Users.SingleOrDefault(x => x.Id == index);

            // Видаляємо даний рядок також з відображення в датагріді
            dataGridView.Rows.RemoveAt(indexInDGV);

            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dataGridView.ReadOnly = false;
            dataGridView.BeginEdit(true);
            string _name = dataGridView["ColName", dataGridView.CurrentRow.Index].Value.ToString();
            string _email = dataGridView["ColEmail", dataGridView.CurrentRow.Index].Value.ToString();
            string _phone = dataGridView["ColPhone", dataGridView.CurrentRow.Index].Value.ToString();

            MessageBox.Show($"Ім'я  {_name}\nE-mail  {_email}\nPhone  {_phone}");

            //User user = _context.Users.SingleOrDefault(x => x.Name == _name);
            //if(user!=null)
            //{
            //    user.Name = "0000";
            //    _context.SaveChanges();
            //}


            _context.SaveChanges();
        }

        

    }
}
