using LinqKit;
using Rozetka.Entities;
using Rozetka.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozetka
{
    public partial class MainForm : Form
    {
        private readonly EFContext _context;
        public IQueryable<FilterName> filter { get; set; }

        /// <summary>
        /// Інтервал між групбоксами
        /// </summary>
        const int gb_interval = 5;

        /// <summary>
        /// Кількість натискань миші (для розгортання фільтра)
        /// </summary>
        int kol = 0;

        /// <summary>
        /// Відступ по довжині між  групбокса і чекедлістбокса всередині нього
        /// </summary>
        public int checkHeight { get; set; } = 30;

        /// <summary>
        /// Відступ по ширині між шириною групбокса і чекедлістбокса всередині нього.
        /// </summary>
        public int chWidth { get; set; } = 20;
        public int height { get; set; } = 50;
        public int width { get; set; } = 220;

        /// <summary>
        /// Список обраних елементів
        /// </summary>
        private List<int> category { get; set; }

        public MainForm()
        {
            InitializeComponent();
            _context = new EFContext();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            AutoScroll = true;
            SuspendLayout();
            Seeder.SeedDatabase(_context);
            LoadForm();
        }
        private void LoadForm()
        {
            GroupBox gbNameFilter;
            CheckedListBox cbValuesFilter;

            var collection = GetListFilters();
            int hy = 15;

            //Отримуємо множину значень імен
            var result = from b in collection select b.Name;

            foreach (var item in collection)
            {
                gbNameFilter = new GroupBox();
                cbValuesFilter = new CheckedListBox();
                gbNameFilter.SuspendLayout();

                gbNameFilter.Controls.Add(cbValuesFilter);
                gbNameFilter.Location = new Point(10, hy);
                gbNameFilter.Name = $"gbNameFilter{item.Name}";
                gbNameFilter.Size = new Size(width, height);
                gbNameFilter.Text = item.Name;
                gbNameFilter.Tag = item;
                gbNameFilter.Click += new EventHandler(gbNameFilter_Click);

                cbValuesFilter.AutoSize = true;

                // Координати розміщення чекедлістбокса всередині групбокса
                cbValuesFilter.Location = new System.Drawing.Point(10, 25);
                
                foreach (var ch in item.Children)
                {
                    // Додаємо до чекедлістбокса назви дітей
                    cbValuesFilter.Items.Add(ch);
                };

                // Новий розмір групбокса
                gbNameFilter.Size = new Size(cbValuesFilter.Size.Width + chWidth, cbValuesFilter.Size.Height + checkHeight);

                // Інтервал по висоті між групбоксами
                hy += gbNameFilter.Height + gb_interval;

                // Додаємо групбокс на форму
                Controls.Add(gbNameFilter);
            }
        }

        void gbNameFilter_Click(object sender, EventArgs e)
        {
            var name = (sender as GroupBox);
            var res_list = name.Controls.OfType<CheckedListBox>().FirstOrDefault();

            //Лічильник натискань кнопки
            kol++;

            if (kol % 2 != 0)
            {
                var Height = res_list.Height + 25;
                name.Height = Height;
            }
            else
            {
                var Height = 25;
                name.Height = Height;
            }

            int item_y = 15;
            
            // Обхід по всім контролам типу Групбокс
            foreach (var item in Controls.OfType<GroupBox>())
            {
                // Нові координати для кожного групбокса
                item.Location = new Point(item.Location.X, item_y);
                // Зміна координати розміщення групбокса по осі Y,відповідно до висоти інших групбоксів
                item_y += item.Size.Height + 5;
            }
        }

        private List<FNameViewModel> GetListFilters()
        {
            var queryName = from f in _context.FilterNames.AsQueryable()
                            select f;
            var queryGroup = from g in _context.FilterNameGroups.AsQueryable()
                             select g;
            //Отримуємо загальну множину значень
            var query = from u in queryName
                        join g in queryGroup on u.Id equals g.FilterNameId into ua
                        from aEmp in ua.DefaultIfEmpty()
                        select new
                        {
                            FNameId = u.Id,
                            FName = u.Name,
                            FValueId = aEmp != null ? aEmp.FilterValueId : 0,
                            FValue = aEmp != null ? aEmp.FilterValueOf.Name : null,
                        };

            //Групуємо по іменам і сортуємо по спаданню імен
            var groupNames = query.AsEnumerable()
                      .GroupBy(f => new { Id = f.FNameId, Name = f.FName })
                      .Select(g => g)
                      .OrderByDescending(p => p.Key.Name);

            //По групах отримуємо
            var result = from fName in groupNames
                         select
                         new FNameViewModel
                         {
                             Id = fName.Key.Id,
                             Name = fName.Key.Name,
                             Children = fName.Select(x =>
                                   new FilterValueModel
                                   {
                                       Id = x.FValueId,
                                       Name = x.FValue
                                   }).OrderBy(l => l.Name).ToList()
                         };

            return result.ToList();
        }
        /// <summary>
        /// Додавання значення в фільтр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnAddFilterValue_Click(object sender, EventArgs e)
        {
            AddValueForm avf = new AddValueForm();
            avf.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            List<int> values = new List<int>();
            var list_items = Controls.OfType<GroupBox>();
            foreach (var groupBox in list_items)
            {
                var res_check = groupBox.Controls.OfType<CheckedListBox>().FirstOrDefault().CheckedItems;
                foreach (var listItem in res_check)
                {
                    var data = listItem as FilterValueModel;
                    values.Add(data.Id);
                }
            }

            var filter_list = GetListFilters();
            int[] filter_int = values.ToArray();

            var query = _context
                    .Products
                    .AsQueryable();

            foreach (var fName in filter_list)
            {
                int countFilter = 0;

                var predicate = PredicateBuilder.False<Product>();

                foreach (var fValue in fName.Children)
                {
                    for (int i = 0; i < filter_int.Length; i++)
                    {
                        var value_Id = fValue.Id;

                        if (filter_int[i] == value_Id)
                        {
                            predicate = predicate
                                .Or(p => p.Filters
                                    .Any(f => f.FilterValueId == value_Id));
                            countFilter++;
                        }
                    }
                }
                if (countFilter != 0)
                    query = query.Where(predicate);
            }

            var listProduct = query.ToList();
            dgvProducts.Rows.Clear();
            foreach (var p in listProduct)
            {
                object[] row =
                {
                    p.Id,
                    p.Name,
                    p.Price,
                    null
                };
                dgvProducts.Rows.Add(row);
            }
        }
    }
}
