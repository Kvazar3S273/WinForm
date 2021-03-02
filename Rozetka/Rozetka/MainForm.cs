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
        public int positionY { get; set; } = 17;
        public int dy { get; set; } = 15;
        public MainForm()
        {
            InitializeComponent();
            _context = new EFContext();
            Seeder.SeedDatabase(_context);
            LoadForm();
        }
        private void LoadForm()
        {
            
        }
        private void btnFilterBrand_Click(object sender, EventArgs e)
        {
            
            List<string> checksBrand = new List<string>();
            pnlFilterBrand.Height = 1;
            pnlFilterBrand.Controls.Clear();
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
            //MessageBox.Show($"Всього {checksBrand.Count()} дітей");
            for (int i = 0; i < checksBrand.Count(); i++)
            {
                pnlFilterBrand.Height += dy;
                CheckBox chb = new CheckBox();
                chb.AutoSize = true;
                chb.Location = new System.Drawing.Point(45, positionY);
                chb.Name = $"checkBox{i}";
                chb.Size = new System.Drawing.Size(82, 19);
                chb.TabIndex = 3;
                chb.Text = $"{checksBrand[i].ToString()}";
                chb.UseVisualStyleBackColor = true;
                pnlFilterBrand.Controls.Add(chb);
                positionY += dy;
            }



           

        }
        private void btnClosedBrand_Click(object sender, EventArgs e)
        {
            pnlFilterBrand.Controls.Clear();
            positionY = 17;
        }
        private void btnFilterPower_Click(object sender, EventArgs e)
        {

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
