using Hospital;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NEWHospital.WindowsForms
{
    public partial class SearchForm : Form
    {
        static int pageSize = 10;
        private int currentPageNumber = 0;
        public string getLastName { get; set; }
        public string getStage { get; set; }
        public string getDepartment { get; set; }
        public SearchForm()
        {
            InitializeComponent();
        }

        private void LoadSearchDataByLastName()
        {
            MyContext context = new MyContext();
            getLastName = this.textBoxLastName.Text;

            List<Doctor> searchByLastName = context.Doctors.Include("Department")
                .Where(x => x.LastName == getLastName).ToList();

            var collectionLastName = searchByLastName
                .Skip(currentPageNumber * pageSize).Take(pageSize).ToList();

            dataGridView1.Rows.Clear();

            foreach (var item in collectionLastName)
            {
                object[] row = {
                $"{item.LastName}",
                $"{item.FirstName}",
                $"{item.Stage}",
                $"{item.Department.Name}"
                };
                dataGridView1.Rows.Add(row);
            }
        }

        private void LoadSearchDataByDepartment()
        {
            MyContext context = new MyContext();
            getDepartment = this.textBoxDepartment.Text;

            List<Doctor> searchByDepartment = context.Doctors.Include("Department")
                .Where(x => x.Department.Name == getDepartment).ToList();

            var collectionDepartment = searchByDepartment
                .Skip(currentPageNumber * pageSize).Take(pageSize).ToList();
            
            dataGridView1.Rows.Clear();

            foreach (var item in collectionDepartment)
            {
                object[] row = {
                $"{item.LastName}",
                $"{item.FirstName}",
                $"{item.Stage}",
                $"{item.Department.Name}"
                };
                dataGridView1.Rows.Add(row);
            }
        }

        private void LoadSearchDataByStage()
        {
            MyContext context = new MyContext();
            getStage = this.textBoxStage.Text;

            List<Doctor> searchByStage = context.Doctors.Include("Department")
                .Where(x => x.Stage == int.Parse(getStage)).ToList();

            var collectionStage = searchByStage
                .Skip(currentPageNumber * pageSize).Take(pageSize).ToList();

            dataGridView1.Rows.Clear();

            foreach (var item in collectionStage)
            {
                object[] row = {
                $"{item.LastName}",
                $"{item.FirstName}",
                $"{item.Stage}",
                $"{item.Department.Name}"
                };
                dataGridView1.Rows.Add(row);
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchPrev_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSearchNext_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSearchLastName_Click(object sender, EventArgs e)
        {
            LoadSearchDataByLastName();
        }

        private void btnSearchDepartment_Click(object sender, EventArgs e)
        {
            LoadSearchDataByDepartment();
        }

        private void btnSearchStage_Click(object sender, EventArgs e)
        {
            LoadSearchDataByStage();
        }
    }
}
