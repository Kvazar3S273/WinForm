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

        private void LoadSearchDataAndBindGrid()
        {
            MyContext context = new MyContext();
            getLastName = this.textBoxLastName.Text;

            List<Doctor> searchByLastName = context.Doctors.Include("Department")
                .Where(x => x.LastName == getLastName).ToList();

            List<Doctor> searchByStage = context.Doctors.Include("Department")
                .Where(x => x.Stage == int.Parse(getStage)).ToList();

            List<Doctor> searchByDepartment = context.Doctors.Include("Department")
                .Where(x => x.Department.Name == getDepartment).ToList();

            var collectionLastName = searchByLastName
                .Skip(currentPageNumber * pageSize).Take(pageSize).ToList();

            var collectionStage = searchByStage
                .Skip(currentPageNumber * pageSize).Take(pageSize).ToList();

            var collectionDepartment = searchByDepartment
                .Skip(currentPageNumber * pageSize).Take(pageSize).ToList();

            dataGridView1.Rows.Clear();

            //if (rbtnLastName.Checked)
            //{
            //    getLastName = this.textBoxLastName.Text;
            //    foreach (var item in collectionLastName)
            //    {
            //        object[] row = {
            //    $"{item.LastName}",
            //    $"{item.FirstName}",
            //    $"{item.Stage}",
            //    $"{item.Department.Name}"
            //    };
            //        dataGridView1.Rows.Add(row);
            //    }
            //}
            //if (rbtnStage.Checked)
            //{
            //    getStage = this.textBoxStage.Text;
            //    foreach (var item in collectionStage)
            //    {
            //        object[] row = {
            //    $"{item.LastName}",
            //    $"{item.FirstName}",
            //    $"{item.Stage}",
            //    $"{item.Department.Name}"
            //    };
            //        dataGridView1.Rows.Add(row);
            //    }
            //}
            //if (rbtnDepartment.Checked)
            //{
            //    getDepartment = this.textBoxDepartment.Text;
            //    foreach (var item in collectionDepartment)
            //    {
            //        object[] row = {
            //    $"{item.LastName}",
            //    $"{item.FirstName}",
            //    $"{item.Stage}",
            //    $"{item.Department.Name}"
            //    };
            //        dataGridView1.Rows.Add(row);
            //    }
            //}
            //int sizeList = collectionLastName.Count();
            //double total = sizeList / pageSize;
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
            LoadSearchDataAndBindGrid();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            //getLastName = this.textBoxLastName.Text;
            //getStage = this.textBoxStage.Text;
            //getDepartment = this.textBoxDepartment.Text;

        }

        private void SearchForm_Click(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnLastName_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtnLastName = (RadioButton)sender;
            if (rbtnLastName.Checked)
                getLastName = this.textBoxLastName.Text;
        }

        private void rbtnStage_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtnStage = (RadioButton)sender;
            if (rbtnStage.Checked)
                getStage = this.textBoxStage.Text;
        }

        private void rbtnDepartment_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtnDepartment = (RadioButton)sender;
            if (rbtnDepartment.Checked)
                getDepartment = this.textBoxDepartment.Text;
        }

        private void btnSearchPrev_Click(object sender, EventArgs e)
        {
            currentPageNumber--;
            if (currentPageNumber < 0) currentPageNumber = 0;
            LoadSearchDataAndBindGrid();
        }

        private void btnSearchNext_Click(object sender, EventArgs e)
        {
            MyContext context = new MyContext();
            getLastName = this.textBoxLastName.Text;

            List<Doctor> searchByLastName = context.Doctors.Include("Department")
                .Where(x => x.LastName == getLastName).ToList();
            
            var collectionLastName = searchByLastName
                .Skip(currentPageNumber * pageSize).Take(pageSize).ToList();

            
            int totalRowsCount = searchByLastName.Count();
            int totalPagesCount = totalRowsCount / pageSize;
            // остання сторінка може бути неповна, додаємо одиничку, якщо є остача від ділення
            if (totalRowsCount % pageSize > 0) totalPagesCount++;
            currentPageNumber++;
            if (currentPageNumber >= totalPagesCount) currentPageNumber = totalPagesCount - 1;
            if (currentPageNumber < 0) currentPageNumber = 0;
            LoadSearchDataAndBindGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearchDataAndBindGrid();
        }
    }
}
