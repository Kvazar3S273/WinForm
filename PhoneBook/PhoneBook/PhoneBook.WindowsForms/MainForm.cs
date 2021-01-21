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
        private int _page = 1;
        public MainForm()
        {
            _context = new MyContext();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SearchHuman();
            //CustomComboBoxItem item = new CustomComboBoxItem();
            cbCountShowOnePage.Items.AddRange(
                new List<CustomComboBoxItem> {
                        new CustomComboBoxItem { Id=1, Name="10" },
                        new CustomComboBoxItem { Id=2, Name="20" },
                        new CustomComboBoxItem { Id=3, Name="30" },
                        new CustomComboBoxItem { Id=4, Name="50" }
                   }.ToArray()
                );
            cbCountShowOnePage.SelectedIndex = 0;
        }

        private void SearchHuman(SearchHuman search = null)
        {
            dataGridView1.Rows.Clear();
            search ??= new SearchHuman();
            search.Page = _page;
            var result = HumanService.Search(_context, search);
            foreach (var item in result.Humans)
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
            int begin = (_page - 1) * search.CountShowOnePage + 1;
            int end = begin + (search.CountShowOnePage - 1);
            lblRange.Text = $"Показано: {begin} - {end}";
            lblCount.Text = "Знайдено: " + result.CountRows.ToString() + " позицій";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            _page = 1;
            SearchHuman(GetSearchInputValue());
        }

        private SearchHuman GetSearchInputValue()
        {
            SearchHuman search = new SearchHuman();
            search.Surname = tboxSurname.Text;
            search.Name = tboxName.Text;
            search.Phone = tboxPhone.Text;
            var countSelect = cbCountShowOnePage.SelectedItem as CustomComboBoxItem;
            search.CountShowOnePage = int.Parse(countSelect.Name);
            return search;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (_page > 1)
            {
                _page -= 1;
                SearchHuman(GetSearchInputValue());
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            _page += 1;
            SearchHuman(GetSearchInputValue());
        }
    }
}
