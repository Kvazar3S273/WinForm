using PhoneBook.DAL;
using PhoneBook.WindowsForms.Models;
using PhoneBook.WindowsForms.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook.WindowsForms
{
    public partial class MainForm : Form
    {
        private readonly MyContext _context;
        public MainForm()
        {
            _context = new MyContext();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SearchHuman();
        }

        private void SearchHuman(SearchHuman search = null)
        {
            search ??= new SearchHuman();
            var list = HumanService.Search(_context, null);
            foreach (var item in list)
            {
                object[] row =
                {
                    item.Surname,
                    item.Name,
                    item.Gender,
                    item.Phone
                };
                dataGridView1.Rows.Add(row);
            }
            lblCount.Text = list.Count().ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchHuman search = new SearchHuman();
            SearchHuman(search);
        }
    }
}
