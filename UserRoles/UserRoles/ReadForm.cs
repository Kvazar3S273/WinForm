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
        public string TakeName { get; set; }
        public string TakeEmail { get; set; }
        public string TakePhoneNumber { get; set; }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //new EditForm().ShowDialog();
            dataGridView.ReadOnly = false;
            dataGridView.BeginEdit(true);
            
            //groupBox.Controls.Clear();

            // 
            // lbl
            // 
            lblName.AutoSize = true;
            lblEmail.AutoSize = true;
            lblPhoneNumber.AutoSize = true;

            lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            lblName.Location = new System.Drawing.Point(290, 422);
            lblEmail.Location = new System.Drawing.Point(290, 450);
            lblPhoneNumber.Location = new System.Drawing.Point(290, 478);

            lblName.Name = "lblName";
            lblEmail.Name = "lblEmail";
            lblPhoneNumber.Name = "lblPhoneNumber";

            lblName.Size = new System.Drawing.Size(30, 17);
            lblEmail.Size = new System.Drawing.Size(30, 17);
            lblPhoneNumber.Size = new System.Drawing.Size(30, 17);

            lblName.TabIndex = 5;
            lblEmail.TabIndex = 6;
            lblPhoneNumber.TabIndex = 7;

            lblName.Text = "Ім\'я";
            lblEmail.Text = "E-mail";
            lblPhoneNumber.Text = "Номер тел.";
            // 
            // tbName
            // 
            //TextBox tbName = new TextBox();
            tbName.Location = new System.Drawing.Point(365, 422);
            tbEmail.Location = new System.Drawing.Point(365, 450);
            tbPhoneNumber.Location = new System.Drawing.Point(365, 478);

            tbName.Name = "tbName";
            tbEmail.Name = "tbEmail";
            tbPhoneNumber.Name = "tbPhoneNumber";

            tbName.Size = new System.Drawing.Size(180, 23);
            tbEmail.Size = new System.Drawing.Size(180, 23);
            tbPhoneNumber.Size = new System.Drawing.Size(180, 23);

            tbName.TabIndex = 1;
            tbEmail.TabIndex = 2;
            tbPhoneNumber.TabIndex = 3;

            // 
            // btnSave
            // 
            //Button btnSave = new Button();
            btnSave.Location = new System.Drawing.Point(578, 422);
            btnSave.Name = "btnDelete";
            btnSave.Size = new System.Drawing.Size(97, 80);
            btnSave.TabIndex = 4;
            btnSave.Text = "Зберегти зміни";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += new System.EventHandler(this.btnSave_Click);

            string _name = dataGridView["ColName", dataGridView.CurrentRow.Index].Value.ToString();
            string _email = dataGridView["ColEmail", dataGridView.CurrentRow.Index].Value.ToString();
            string _phone = dataGridView["ColPhone", dataGridView.CurrentRow.Index].Value.ToString();

            TakeName = _name;
            TakeEmail = _email;
            TakePhoneNumber = _phone;

            //MessageBox.Show($"Ім'я  {_name}\nE-mail  {_email}\nPhone  {_phone}");
        }

        private void EditUser()
        {
            User userN = _context.Users.SingleOrDefault(x => x.Name == TakeName);
            if (userN != null)
            {
                userN.Name = tbName.Text;
                _context.SaveChanges();
            }
            //User userE = _context.Users.SingleOrDefault(y => y.Email == TakeEmail);
            //if (userE != null)
            //{
            //    userE.Email = tbEmail.Text;
            //    _context.SaveChanges();
            //}
            //User userP = _context.Users.SingleOrDefault(y => y.PhoneNumber == TakePhoneNumber);
            //if (userP != null)
            //{
            //    userP.PhoneNumber = tbPhoneNumber.Text;
            //    _context.SaveChanges();
            //}
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            EditUser();
        }
    }
}
