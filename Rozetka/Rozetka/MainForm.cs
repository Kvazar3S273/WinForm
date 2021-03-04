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

        const int startX = 15;
        const int startY = 15;
        const int interval = 8;
        const int checkBoxHeight = 15;

        /// <summary>
        /// Зміщення по осі У для першого фільтра
        /// </summary>
        public int dy1 { get; set; } 

        /// <summary>
        /// Зміщення по осі У для другого фільтра
        /// </summary>
        public int dy2 { get; set; }

        /// <summary>
        /// Кількість дітей першого фільтра
        /// </summary>
        public int CountOfBrands { get; set; }

        /// <summary>
        /// Кількість дітей першого фільтра
        /// </summary>
        public int CountOfPowers { get; set; }

        public MainForm()
        {
            InitializeComponent();
            _context = new EFContext();
            Seeder.SeedDatabase(_context);
            LoadForm();
        }
        private void LoadForm()
        {
            
            GetListFilters();

            // Виводимо кнопки для фільтра брендів і для його очищення
            btnFilterBrand.Location = new Point(startX, startY);
            btnClosedBrand.Location = new Point(startX + btnFilterBrand.Width + interval, startY);

            // Виводимо панель фільтрів по бренду
            pnlFilterBrand.Location = new Point(startX, startY + btnFilterBrand.Height + interval / 2);
            pnlFilterBrand.Height = 1;

            // Виводимо кнопки для фільтра по потужності і для його очищення
            btnFilterPower.Location = new Point(startX, startY + btnFilterBrand.Height + interval);
            btnClosedPower.Location = new Point(startX + btnFilterPower.Width + interval, startY + btnClosedBrand.Height + interval);

            // Виводимо панель фільтрів по потужності
            pnlFilterPower.Location = new Point(startX, startY + btnFilterBrand.Height + interval + btnFilterPower.Height + interval / 2);
            pnlFilterPower.Height = 1;

        }
        private void MoveFilterPower(bool move)
        {
            if (move)
            {
                btnFilterPower.Location = new Point(startX, startY + btnFilterBrand.Height + interval + pnlFilterBrand.Height);
                btnClosedPower.Location = new Point(startX + btnFilterPower.Width + interval, startY + btnClosedBrand.Height + interval + pnlFilterBrand.Height);
                pnlFilterPower.Location = new Point(startX, startY + btnFilterBrand.Height + interval + pnlFilterBrand.Height + btnFilterPower.Height + interval / 2);
                pnlFilterPower.Height = 1;
            }
            else
            {
                btnFilterPower.Location = new Point(startX, startY + btnFilterBrand.Height + interval);
                btnClosedPower.Location = new Point(startX + btnFilterPower.Width + interval, startY + btnClosedBrand.Height + interval);
                pnlFilterPower.Location = new Point(startX, startY + btnFilterBrand.Height + interval + btnFilterPower.Height + interval / 2);
                pnlFilterPower.Height = 1;
            }

        }
        private void btnFilterBrand_Click(object sender, EventArgs e)
        {
            pnlFilterBrand.Controls.Clear();
            dy1 = 0;
            List<string> checksBrand = new List<string>();
            var filters = GetListFilters();
            var result = from x in filters
                         where x.Name == btnFilterBrand.Text
                         select x.Children;
            foreach (var item in result)
            {
                foreach (var it in item)
                {
                    checksBrand.Add(it.Value);
                }
            }
            CountOfBrands = checksBrand.Count();
            pnlFilterBrand.Height =  2 * checkBoxHeight * (CountOfBrands - 1);

            foreach (var item in checksBrand)
            {
                CheckBox chb = new CheckBox();
                chb.AutoSize = true;
                chb.Location = new System.Drawing.Point(1, dy1);
                chb.Size = new System.Drawing.Size(82, checkBoxHeight);
                chb.Text = item.ToString();
                chb.UseVisualStyleBackColor = true;
                pnlFilterBrand.Controls.Add(chb);
                dy1 = dy1 + checkBoxHeight + interval;
            }
            MoveFilterPower(true);
        }
        private void btnClosedBrand_Click(object sender, EventArgs e)
        {
            pnlFilterBrand.Controls.Clear();
            pnlFilterBrand.Height = 1;
            MoveFilterPower(false);
        }
        private void btnFilterPower_Click(object sender, EventArgs e)
        {
            pnlFilterPower.Controls.Clear();
            dy2 = 0;
            List<string> checksPower = new List<string>();
            var filters = GetListFilters();
            var result = from x in filters
                         where x.Name == btnFilterPower.Text
                         select x.Children;
            foreach (var items in result)
            {
                foreach (var it in items)
                {
                    checksPower.Add(it.Value);
                }
            }
            CountOfPowers = checksPower.Count();
            pnlFilterPower.Height = 2 * checkBoxHeight * (CountOfPowers - 1);
            foreach (var item in checksPower)
            {
                CheckBox chb = new CheckBox();
                chb.AutoSize = true;
                chb.Location = new System.Drawing.Point(1, dy2);
                chb.Size = new System.Drawing.Size(82, checkBoxHeight);
                chb.Text = item.ToString();
                chb.UseVisualStyleBackColor = true;
                pnlFilterPower.Controls.Add(chb);
                dy2 = dy2 + checkBoxHeight + interval;
            }
        }
        private void btnClosedPower_Click(object sender, EventArgs e)
        {
            pnlFilterPower.Controls.Clear();
            pnlFilterPower.Height = 1;
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
    }
}
