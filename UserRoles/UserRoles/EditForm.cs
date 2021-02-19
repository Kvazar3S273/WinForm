using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UserRoles.Entities;
using UserRoles.Models;

namespace UserRoles
{
    public partial class EditForm : Form
    {
        private readonly int _id;
        private readonly EFContext _context;
        private string fileSelected = string.Empty;
        public string OldFile { get; set; }
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
            string dirImagePath = Path.Combine(Directory.GetCurrentDirectory(), "Images");
            
            if(!Directory.Exists(dirImagePath))
            {
                Directory.CreateDirectory(dirImagePath);
            }

            if (!string.IsNullOrEmpty(user.User.Image))
            {
                var dir = Path.Combine(Directory.GetCurrentDirectory(),
                    "Images", user.User.Image);
                var streamImage = File.OpenRead(dir);
                pbImage.Image = Image.FromStream(streamImage);
                OldFile = dir;
                streamImage.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var user = _context.UserRoles
               .SingleOrDefault(p => p.Id == _id);
            user.RoleId = (cbRole.SelectedItem as Role).Id;
            user.User.Name = tbName.Text;
            user.User.Email = tbEmail.Text;
            user.User.PhoneNumber = tbPhoneNumber.Text;
            user.User.Password = tbPassword.Text;

            if (!string.IsNullOrEmpty(fileSelected))
            {
                File.Delete(OldFile);
                string ext = Path.GetExtension(fileSelected);
                string fileName = Path.GetFileNameWithoutExtension(fileSelected) + ext;
                string fileSavePath = Path.Combine(Directory.GetCurrentDirectory(), "Images", fileName);

                var bmp = ResizeImage.ResizeOrigImg(
                    new Bitmap(Image.FromFile(fileSelected)), 100, 100);

                bmp.Save(fileSavePath, ImageFormat.Jpeg);
                user.User.Image = fileName;

            }

            _context.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) " +
                "| *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileSelected = dlg.FileName;
                pbImage.Image = Image.FromFile(dlg.FileName);
            }
        }
    }
}
