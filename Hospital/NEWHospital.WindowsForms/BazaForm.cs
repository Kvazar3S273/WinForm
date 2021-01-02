using Hospital;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NEWHospital.WindowsForms
{
    public partial class BazaForm : Form
    {
        static int count = 0;
        public static bool process = false;
        static int index = 0;
        public BazaForm()
        {
            InitializeComponent();
        }


        
        private void BazaForm_Load(object sender, EventArgs e)
        {
            MyContext context = new MyContext();
            int pageSize = 20;
            //do
            //{
            //    if( count >= 0)
            //    {
            //        dataGridView1.Rows.Clear();
            //        count++;
            //        index = (count - 1) * pageSize;
            //        var departm = context.Doctors.Include("Department").ToList();
            //        var result = departm.Skip(index).Take(pageSize);
            //        foreach (var item in result)
            //        {
            //            object[] row = {
            //            $"{item.LastName}",
            //            $"{item.FirstName}",
            //            $"{item.Stage}",
            //            $"{item.Department.NumberCabinet}",
            //            $"{item.Department.Name}"

            //            };
            //            dataGridView1.Rows.Add(row);

            //        }
            //    }
            //} while (process);


            foreach (var item in context.Doctors.Include(x => x.Department))
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

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            count++;
            process = true;
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (index > 0)
            count--;
            process = true;
        }
    }
}
