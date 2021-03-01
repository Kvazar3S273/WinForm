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
        public MainForm()
        {
            InitializeComponent();
            _context = new EFContext();
            Seeder.SeedDatabase(_context);
            LoadForm();
        }
        private void LoadForm()
        {
            var filters = GetListFilters();

            var brand = (from x in filters
                          where x.Id == 1
                          select x.Children);
            foreach (var items in brand)
            {
                foreach (var it in items)
                {
                    chlbFilters.Items.Add(it.Value);
                }
            }
            //var power = (from y in filters
            //             where y.Id == 2
            //             select y.Children);
            //foreach (var items in power)
            //{
            //    foreach (var it in items)
            //    {
            //        chlbFilters.Items.Add(it.Value);
            //    }
            //}
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
