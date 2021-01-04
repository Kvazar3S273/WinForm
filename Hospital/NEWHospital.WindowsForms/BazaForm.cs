using Hospital;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NEWHospital.WindowsForms
{
    public partial class BazaForm : Form
    {
        static int pageSize = 20;
        private int currentPageNumber = 0;
        public BazaForm()
        {
            InitializeComponent();
        }

        private void LoadDataAndBindGrid()
        {
            MyContext context = new MyContext();
            
            var collection = context.Doctors.Include("Department").Skip(currentPageNumber * pageSize).Take(pageSize).ToList();

            dataGridView1.Rows.Clear();
            foreach (var item in collection)
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
    
        private void BazaForm_Load(object sender, EventArgs e)
        {
            LoadDataAndBindGrid();
            lblCurrentPage.Text = $"{currentPageNumber + 1}";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            MyContext context = new MyContext();

            int totalRowsCount = context.Doctors.Count();

            int totalPagesCount = totalRowsCount / pageSize;
            // остання сторінка може бути неповна, додаємо одиничку, якщо є остача від ділення
            if (totalRowsCount % pageSize > 0) totalPagesCount++;
            currentPageNumber++;
            if (currentPageNumber >= totalPagesCount) currentPageNumber = totalPagesCount - 1;
            if (currentPageNumber < 0) currentPageNumber = 0;
            LoadDataAndBindGrid();
            lblCurrentPage.Text = $"{currentPageNumber + 1}";

        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            currentPageNumber--;
            if (currentPageNumber < 0) currentPageNumber = 0;
            LoadDataAndBindGrid();
            lblCurrentPage.Text = $"{currentPageNumber + 1}";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Show();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPageNumber = 0;
            LoadDataAndBindGrid();
            lblCurrentPage.Text = $"{currentPageNumber + 1}";

        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            MyContext context = new MyContext();

            int totalRowsCount = context.Doctors.Count();
            int totalPagesCount = totalRowsCount / pageSize;
            // остання сторінка може бути неповна, додаємо одиничку, якщо є остача від ділення
            if (totalRowsCount % pageSize > 0) totalPagesCount++;
            currentPageNumber = totalPagesCount - 1;
            if (currentPageNumber < 0) currentPageNumber = 0;
            LoadDataAndBindGrid();
            lblCurrentPage.Text = $"{currentPageNumber + 1}";

        }
    }
}
