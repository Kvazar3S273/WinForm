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
        /// Інтервал між графічними елементами в пікселях
        /// </summary>
        const int interval = 8;
        
        /// <summary>
        /// Зміщення по осі У для першого фільтра
        /// </summary>
        public int dy { get; set; } 
       
        /// <summary>
        /// Кількість елементів у Лісті значень імен(кількість імен фільтрів)
        /// </summary>
        public int count { get; set; }
        
        /// <summary>
        /// Кількість дочірніх елементів
        /// </summary>
        public int countChild { get; set; }

        /// <summary>
        /// Початкова координата по горизонталі
        /// </summary>
        int X { get; set; } = 10;

        /// <summary>
        /// Початкова координата по вертикалі
        /// </summary>
        int Y { get; set; } = 10;

        /// <summary>
        /// Висота одного чекбокса
        /// </summary>
        const int chbHeight = 15;

        /// <summary>
        /// Кількість натискань миші (для розгортання фільтра)
        /// </summary>
        int kol = 0;

        Panel pan;
        //Panel filterPanel;

        /// <summary>
        /// Висота кнопки
        /// </summary>
        public int btnHeight { get; set; } = 48;

        /// <summary>
        /// Ширина кнопки
        /// </summary>
        public int btnWidth { get; set; } = 125;

        /// <summary>
        /// Список обраних елементів
        /// </summary>
        private List<int> category = new List<int>();

        public MainForm()
        {
            InitializeComponent();
            _context = new EFContext();
            //Seeder.SeedDatabase(_context);
            LoadForm();
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
            var collection = GetListFilters();
            List<string> names = new List<string>();
            var result = from b in collection select b.Name;
            foreach (var item in result)
            {
                names.Add(item);
            }
            count = names.Count;

            Panel filterPanel = new Panel();
            filterPanel.Size = new Size(145, 460);
            filterPanel.Location = new Point(0, 0);
            filterPanel.BackColor = Color.Transparent;
            Controls.Add(filterPanel);

            for (int i = 0; i < count; i++)
            {

                Button[] btnNameFilter = new Button[count];
                btnNameFilter[i] = new Button();
                btnNameFilter[i].Location = new Point(X, Y + i * 50);
                btnNameFilter[i].Name = $"btnNameFilter{i}";
                btnNameFilter[i].Size = new Size(btnWidth, btnHeight);
                btnNameFilter[i].Text = names[i];
                filterPanel.Controls.Add(btnNameFilter[i]);
                btnNameFilter[i].Click += new EventHandler(btnNameFilter_Click);

                void btnNameFilter_Click(object sender, EventArgs e)
                {
                    kol++;

                    if (kol % 2 != 0)
                    {
                    //filterPanel.AutoScroll = true;
                        pan = new Panel();
                        List<string> child = new List<string>();
                        var res_child = from b in collection
                                        where b.Name == (sender as Button).Text
                                        select b.Children;

                        if(res_child == null)
                        {
                            MessageBox.Show("Відсутні елементи для відображення");
                        }

                        foreach (var item in res_child)
                        {
                            foreach (var it in item)
                            {
                                child.Add(it.Value);
                            }
                        }
                        countChild = child.Count();
                       
                        pan.Location = new Point(X, btnHeight * i + interval * 2);
                        pan.Size = new Size(btnWidth, 0);
                        pan.BackColor = Color.Transparent;
                        //pan.AutoScroll = true;

                        filterPanel.Controls.Add(pan);
                        pan.Visible = true;
                        dy = 0;
                        foreach (var item in child)
                        {
                            CheckBox chb = new CheckBox();
                            chb.AutoSize = true;
                            chb.Location = new System.Drawing.Point(1, dy);
                            chb.Size = new System.Drawing.Size(82, chbHeight);
                            chb.Text = item.ToString();
                            chb.CheckedChanged += CheckChangedHandler;
                            chb.Tag = item;
                            chb.UseVisualStyleBackColor = true;
                            pan.Controls.Add(chb);
                            // Зміщуємо виведення наступного чекбокса на його висоту + інтервал
                            dy = dy + chbHeight + interval;
                        }
                        var height = (chbHeight + interval) * countChild;
                        pan.Height = height;
                    }
                    else
                    {
                        pan.Controls.Clear();
                        for (int i = 0; i < pan.Controls.Count; i++)
                        {
                            pan.Controls[i].Enabled = false;
                            pan.Controls[i].Dispose();
                            i--;
                        }

                        if (pan.Controls.Count == 0)
                        {
                            Controls.Remove(pan);
                            pan.Dispose();
                        }
                    }
                }
            }

            //this.AutoScroll = true;
        }

        /// <summary>
        /// Список обраних елементів фільтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ea"></param>
        private void CheckChangedHandler(object sender, EventArgs ea)
        {

            CheckBox cb = sender as CheckBox;
            var cat2 = GetListFilters();
            var filterNameValue = from x in _context.FilterNameGroups.AsQueryable() select x;
            var res = from y in filterNameValue
                      where y.FilterValueOf.Name == cb.Text
                      select y.FilterValueId;

            foreach (var y in res)
            {
                category.Add(y);
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
                                   new FValueViewModel
                                   {
                                       Id = x.FValueId,
                                       Value = x.FValue
                                   }).OrderBy(l => l.Value).ToList()
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
            var filtersList = GetListFilters();
            int[] filterValueSearchList = category.ToArray();

            var query = _context
                    .Products
                    .AsQueryable();

            foreach (var fName in filtersList)
            {
                int countFilter = 0; //Кількість співпадінь у даній групі фільтрів
                var predicate = PredicateBuilder.False<Product>();
                foreach (var fValue in fName.Children)
                {
                    for (int i = 0; i < filterValueSearchList.Length; i++)
                    {
                        var idV = fValue.Id; //id - значення фільтра
                        if (filterValueSearchList[i] == idV) //маємо співпадіння
                        {
                            predicate = predicate
                                .Or(p => p.Filters
                                    .Any(f => f.FilterValueId == idV));
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
