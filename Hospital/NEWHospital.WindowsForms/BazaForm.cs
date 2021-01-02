using Hospital;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace NEWHospital.WindowsForms
{
    public partial class BazaForm : Form
    {
        public BazaForm()
        {
            InitializeComponent();
        }

        private int PgSize = 20;
        private int CurrentPageIndex = 1;
        private int TotalPage = 0;

        private void CalculateTotalPages()
        {
            MyContext context = new MyContext();
            int rowCount = ds.Tables["Customers"].Rows.Count;
            int rowCount=context.Doctors.
            TotalPage = rowCount / PgSize;
            // if any row left after calculated pages, add one more page 
            if (rowCount % PgSize > 0)
                TotalPage += 1;
        }
        private void BazaForm_Load(object sender, EventArgs e)
        {
            MyContext context = new MyContext();
            foreach (var item in context.Doctors.Include(x=>x.Department))
            {
                object[] row =
                {
                    $"{item.LastName}",
                    $"{item.FirstName}",
                    $"{item.Stage}",
                    $"{item.Login}"
                };
                dataGridView1.Rows.Add(row);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
