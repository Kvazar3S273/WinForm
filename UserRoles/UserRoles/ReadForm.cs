using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string fileSelected = string.Empty;

        public ReadForm()
        {
            InitializeComponent();
        }

        private void ReadForm_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            var query = _context.UserRoles
              .AsQueryable(); var list = query.Select(x => new
              {
                  Id = x.Id,
                  Image = x.User.Image,
                  Name = x.User.Name,
                  Email = x.User.Email,
                  PhoneNumber = x.User.PhoneNumber,
                  Role = x.Role.Title
              }).AsQueryable().ToList();

            foreach (var n in list)
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "Images", n.Image);
                using (var streamImage = File.OpenRead(path))
                {
                    object[] row =
                        {
                            n.Id,
                            n.Image == null ? null:Image.FromStream(streamImage),
                            n.Name,
                            n.Email,
                            n.PhoneNumber,
                            n.Role
                        };
                    dataGridView.Rows.Add(row);
                }
            }
        }

        private void SearchUser(SearchUser search = null)
        {
            dataGridView.Rows.Clear();
            search ??= new SearchUser();
            var result = UserService.Search(_context, search);
            foreach (var n in result.Users)
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "Images");
                object[] row =
                {
                    n.Id,
                    n.Image == null ? null:Image.FromFile(Path.Combine(path, n.Image)),
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
            if (dataGridView.CurrentRow != null)
            {
                int id = int.Parse(dataGridView["ColId", dataGridView.CurrentRow.Index].Value.ToString());
                new EditForm(id).ShowDialog();
            }
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int _id = int.Parse(dataGridView["ColId", dataGridView.CurrentRow.Index].Value.ToString());
                string _name = dataGridView["ColName", dataGridView.CurrentRow.Index].Value.ToString();
                string _email = dataGridView["ColEmail", dataGridView.CurrentRow.Index].Value.ToString();
                string _phone = dataGridView["ColPhone", dataGridView.CurrentRow.Index].Value.ToString();
                
                
                var user = _context.Users.SingleOrDefault(u => u.Id == _id);
                user.Name = _name;
                user.Email = _email;
                user.PhoneNumber = _phone;
                _context.SaveChanges();
                MessageBox.Show($"Значення змінено");
            }
            catch (Exception ex){}

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ReadForm_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
