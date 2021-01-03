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
        static int count = 0;
        public bool process = false;
        static int pageSize = 20;
        public BazaForm()
        {
            InitializeComponent();
        }
        public void ShowOnePage(int countPage, MyContext context)
        {
            var collection = context.Doctors.Include(x => x.Department);
            dataGridView1.Rows.Clear();
            var result = collection.Skip(countPage * pageSize).Take(pageSize);
            foreach (var item in result)
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
        private void BazaForm_Load(object sender, EventArgs e)
        {
            //варіант 2
            MyContext context = new MyContext();
            do
            {
                ShowOnePage(count, context);

                //var collection = context.Doctors.Include("Department").ToList();
                //if (count >= 0 && count <= (collection.Count() / pageSize))
                //{
                //    dataGridView1.Rows.Clear();
                //    count++;
                //    int index = (count - 1) * pageSize;
                //    var result = collection.Skip(index).Take(pageSize);

                //    foreach (var item in result)
                //    {
                //        object[] row = {
                //    $"{item.LastName}",
                //    $"{item.FirstName}",
                //    $"{item.Stage}",
                //    $"{item.Login}"

                //    };
                //        dataGridView1.Rows.Add(row);
                //    }
                //}
            } while (process);



            //робочий варіант!!!!!!!!!!!!
            //MyContext context = new MyContext();
            //do
            //{
            //    var collection = context.Doctors.Include("Department").ToList();
            //    if (count >= 0 && count <= (collection.Count() / pageSize))
            //    {
            //        dataGridView1.Rows.Clear();
            //        count++;
            //        int index = (count - 1) * pageSize;
            //        var result = collection.Skip(index).Take(pageSize);

            //        foreach (var item in result)
            //        {
            //            object[] row = {
            //        $"{item.LastName}",
            //        $"{item.FirstName}",
            //        $"{item.Stage}",
            //        $"{item.Login}"

            //        };
            //            dataGridView1.Rows.Add(row);
            //        }
            //    }
            //} while (process);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            count++;
            //process = true;
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            count--;
            //process = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Show();
        }
    }
}
