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
        static int index = 0;
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
            MyContext context = new MyContext();
            if (count < 0)
            {
                count = 0;
            }
                ShowOnePage(count, context);





            //int pageSize = 20;
            //MyContext context = new MyContext();
            //List<Doctor> res = new List<Doctor>();

            //foreach (var item in context.Doctors.Include(x => x.Department))
            //{
            //    object[] row =
            //    {
            //        $"{item.LastName}",
            //        $"{item.FirstName}",
            //        $"{item.Stage}",
            //        $"{item.Login}"
            //    };
            //    dataGridView1.Rows.Add(row);
            //}
            //process = true;



            //var collection = context.Doctors.Include(x => x.Department);
            //while (btnBack.DialogResult != DialogResult.Cancel)
                //{
                //do
                //{
                    //dataGridView1.Rows.Clear();
                    //var result = collection.Skip(count * pageSize).Take(pageSize);
                    //if (result.Count() <= 0)
                    //{
                    //    count--;
                    //}
                    //foreach (var item in result)
                    //{
                    //    object[] row =
                    //    {
                    //    $"{item.LastName}",
                    //    $"{item.FirstName}",
                    //    $"{item.Stage}",
                    //    $"{item.Login}"
                    //    };
                    //    dataGridView1.Rows.Add(row);
                    //}
                //} while (process);
        }



        // Власюк Н.
        //do
        //{
        //    if (count >= 0)
        //    {
        //        dataGridView1.Rows.Clear();
        //        count++;
        //        int index = (count - 1) * pageSize;
        //        var departm = context.Doctors.Include("Department").ToList();
        //        var result = departm.Skip(index).Take(pageSize);

        //        foreach (var item in result)
        //        {
        //            object[] row = {
        //            $"{item.LastName}",
        //            $"{item.FirstName}",
        //            $"{item.Stage}",
        //            $"{item.Login}"

        //            };
        //            dataGridView1.Rows.Add(row);

        //        }

        //    }

        //} while (process);
    //}

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            count++;
            //process = true;
            this.DialogResult = DialogResult.OK;
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            count--;
            //process = true;
            this.DialogResult = DialogResult.OK;
        }
    }
}
