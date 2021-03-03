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

        /// <summary>
        /// Початкова координата для першого фільтра (для першого чекбокса першого фільтра)
        /// </summary>
        public int positionY1 { get; set; }

        /// <summary>
        /// Зміщення по осі У для першого фільтра
        /// </summary>
        public int dy1 { get; set; } 

        /// <summary>
        /// Початкова координата для другого фільтра
        /// </summary>
        public int positionY2 { get; set; } = 200;

        /// <summary>
        /// Зміщення по осі У для другого фільтра
        /// </summary>
        public int dy2 { get; set; } = 8;

        /// <summary>
        /// Кількість дітей першого фільтра
        /// </summary>
        public int CountOfBrands { get; set; }

        /// <summary>
        /// Кількість дітей першого фільтра
        /// </summary>
        public int CountOfPowers { get; set; }

        /// <summary>
        /// Мітка чи розкритий перший фільтр
        /// </summary>
        public bool isOpenBrands { get; set; } = false;

        /// <summary>
        /// Мітка чи розкритий другий фільтр
        /// </summary>
        public bool isOpenPower { get; set; } = false;

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
        private void btnFilterBrand_Click(object sender, EventArgs e)
        {
            isOpenBrands = true;
            pnlFilterBrand.Controls.Clear();
            positionY1 = startY + btnFilterBrand.Height + interval;
            int checkBoxHeight = 15;
            dy1 = checkBoxHeight + interval;
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
            foreach (var item in checksBrand)
            {
                pnlFilterBrand.Height += dy1;
                CheckBox chb = new CheckBox();
                chb.AutoSize = true;
                chb.Location = new System.Drawing.Point(15, positionY1);
                chb.Size = new System.Drawing.Size(82, checkBoxHeight);
                chb.Text = item.ToString();
                chb.UseVisualStyleBackColor = true;
                pnlFilterBrand.Controls.Add(chb);
                positionY1 += dy1;
            }
            if (isOpenBrands && !isOpenPower)
            {
                //btnFilterPower.Location = new Point(15, btnFilterBrand.Height * CountOfBrands + dy1);
                //btnClosedPower.Location = new Point(btnFilterPower.Width + 32, btnFilterBrand.Height * CountOfBrands + dy1);
                //pnlFilterPower.Location = new Point(15, btnFilterBrand.Height + positionY1 + dy1);
                pnlFilterPower.Controls.Clear();
                pnlFilterPower.Height = 1;
            }
            if (isOpenBrands && isOpenPower)
            {
                btnFilterPower.Location = new Point(startX, startY + btnFilterBrand.Height + interval + CountOfBrands * checkBoxHeight + (CountOfBrands - 1) * interval + interval);
                btnClosedPower.Location = new Point(startX + btnFilterPower.Width + interval, startY + btnFilterBrand.Height + interval + CountOfBrands * checkBoxHeight + (CountOfBrands - 1) * interval + interval);
                pnlFilterPower.Location = new Point(startX, startY + btnFilterBrand.Height + interval + CountOfBrands * checkBoxHeight + (CountOfBrands - 1) * interval + interval);
            }
        }
        private void btnClosedBrand_Click(object sender, EventArgs e)
        {
            isOpenBrands = false;
            pnlFilterBrand.Controls.Clear();
            pnlFilterBrand.Height = 5;
            positionY1 = 10;
            btnFilterPower.Location = new Point(15, btnFilterBrand.Height + dy1);
            btnClosedPower.Location = new Point(btnFilterPower.Width + 32, btnFilterBrand.Height + dy1);
            if(!isOpenPower)
            {
                pnlFilterPower.Controls.Clear();
                pnlFilterPower.Height = 5;
            }
            pnlFilterPower.Location = new Point(15, btnFilterBrand.Height + btnFilterPower.Height + dy1);
        }
        private void btnFilterPower_Click(object sender, EventArgs e)
        {
            isOpenPower = true;
            List<string> power = new List<string>();
            var filters = GetListFilters();
            var result = from x in filters
                         where x.Name == btnFilterPower.Text
                         select x.Children;
            foreach (var items in result)
            {
                foreach (var it in items)
                {
                    power.Add(it.Value);
                }
            }
            //MessageBox.Show($"Всього {power.Count()} дітей");
            foreach (var item in power)
            {
                pnlFilterPower.Height += dy2;
                CheckBox chb = new CheckBox();
                chb.AutoSize = true;
                chb.Location = new System.Drawing.Point(15, positionY2);
                chb.Size = new System.Drawing.Size(82, 22);
                chb.Text = item.ToString();
                chb.UseVisualStyleBackColor = true;
                pnlFilterBrand.Controls.Add(chb);
                positionY2 += dy2;
            }
            if (!isOpenBrands && isOpenPower)
            {
                btnFilterPower.Location = new Point(15, btnFilterBrand.Height + dy1);
                btnClosedPower.Location = new Point(btnFilterPower.Width + 32, btnClosedBrand.Height + dy1);
                pnlFilterPower.Location = new Point(15, btnFilterBrand.Height + btnFilterPower.Height + dy1);
            }
            if (isOpenBrands && isOpenPower)
            {
                btnFilterPower.Location = new Point(15, btnFilterBrand.Height * CountOfPowers + dy1);
                btnClosedPower.Location = new Point(btnFilterPower.Width + 32, btnClosedBrand.Height * CountOfPowers + dy1);
                pnlFilterPower.Location = new Point(15, btnFilterBrand.Height * CountOfPowers + btnFilterPower.Height + dy1);
            }
        }
        private void btnClosedPower_Click(object sender, EventArgs e)
        {
            isOpenPower = false;
            pnlFilterPower.Controls.Clear();
            pnlFilterPower.Height = 5;
            positionY2 = 200;
            if(!isOpenBrands)
            {
                pnlFilterBrand.Controls.Clear();
                pnlFilterBrand.Height = 5;
            }
            else
            {
                btnFilterPower.Location = new Point(15, btnFilterBrand.Height * CountOfPowers + dy1);
                btnClosedPower.Location = new Point(btnFilterPower.Width + 32, btnClosedBrand.Height * CountOfPowers + dy1);
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

        
    }
}
