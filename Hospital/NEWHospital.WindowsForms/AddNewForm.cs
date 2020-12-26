using Hospital;
using System;
using System.Linq;
using System.Windows.Forms;
using Hospital.Helpers;
using System.IO;

namespace NEWHospital.WindowsForms
{
    public partial class AddNewForm : Form
    {
        public string FileName0 { get; set; } = "D:\\0.jpg";
        MyContext context = new MyContext();
        public AddNewForm()
        {
            InitializeComponent();
            btnChoice.Click += btnChoice_Click;
            openFileDialog1.Filter = "Image files (*.jpg)|*.jpg";
        }

        private void AddNewForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            context.Doctors
                .Add(
                new Doctor
                {
                    LastName = textBoxLastName.Text,
                    FirstName = textBoxFirstName.Text,
                    Stage = int.Parse(textBoxStage.Text),
                    Department = context.Departments.FirstOrDefault(x=>x.Name=="Педіатрія"),
                    Login = textBoxLogin.Text,
                    Password = PasswordManager.HashPassword(textBoxPassword.Text),
                    Image = FileName0.Substring(2)
        });
            context.SaveChanges();
            this.Close();
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            FileName0 = openFileDialog1.FileName;
            string file = FileName0.Substring(2);
            File.Copy(FileName0, $"D:\\ШАГ\\0 Repository\\WinForm\\Hospital\\NEWHospital.WindowsForms\\bin\\Debug\\netcoreapp3.1\\images\\{file}");
        }

       
    }
}
