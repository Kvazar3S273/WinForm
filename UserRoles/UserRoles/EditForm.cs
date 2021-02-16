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
    public partial class EditForm : Form
    {
        private readonly int _id;
        private readonly EFContext _context;

        public EditForm(int id)
        {
            InitializeComponent();
            _id = id;
            _context = new EFContext();
            initDataEdit();
        }
        private void initDataEdit()
        {
            var user = _context.UserRoles
                .SingleOrDefault(u => u.Id == _id);
            foreach (var item in _context.Roles)
            {
                cbRole.Items.Add(item);
                if (item.Id == user.RoleId)
                {
                    cbRole.SelectedItem = item;
                }
            }
            var res = _context.Users.Where(p => p.Id == user.UserId);
            foreach (var item in res)
            {
                tbName.Text = item.Name;
                tbEmail.Text = item.Email;
                tbPhoneNumber.Text = item.PhoneNumber;
                tbPassword.Text = item.Password;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var post = _context.UserRoles
               .SingleOrDefault(p => p.Id == _id);
            post.RoleId = (cbRole.SelectedItem as Role).Id;
            post.User.Name = tbName.Text;
            post.User.Email = tbEmail.Text;
            post.User.PhoneNumber = tbPhoneNumber.Text;
            post.User.Password = tbPassword.Text;

            //if (!string.IsNullOrEmpty(fileSelected))
            //{
            //    string ext = Path.GetExtension(fileSelected);
            //    string fileName = Path.GetRandomFileName() + ext;
            //    string fileSavePath = Path.Combine(Directory.GetCurrentDirectory(),
            //        "images", fileName);
            //    var bmp = ResizeImage.ResizeOrigImg(
            //        new Bitmap(Image.FromFile(fileSelected)), 75, 75);

            //    bmp.Save(fileSavePath, ImageFormat.Jpeg);

            //    post.User.Image = fileName;
            //}
            _context.SaveChanges();
            DialogResult = DialogResult.OK;
        }
    }
}
