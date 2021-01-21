using PhoneBook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook.WindowsForms.Models.Services
{
    public class HumanService
    {
        public static HumanViewGrid Search(MyContext context, SearchHuman search)
        {
            HumanViewGrid model = new HumanViewGrid();
            var query = context.Humans.AsQueryable();
            if (!string.IsNullOrEmpty(search.Surname))
            {
                query = query.Where(x => x.Surname.Contains(search.Surname));
            }
            if (!string.IsNullOrEmpty(search.Name))
            {
                query = query.Where(x => x.Name.Contains(search.Name));
            }
            if (!string.IsNullOrEmpty(search.Phone))
            {
                query = query.Where(x => x.Phone.Contains(search.Phone));
            }
            int showItems = search.CountShowOnePage;
            int page = search.Page - 1;
            model.CountRows = query.Count();
            model.Humans = query
                .Skip(page * showItems)
                .Take(showItems)
                .Select(x => new HumanView
                {
                    Surname = x.Surname,
                    Name = x.Name,
                    Gender = x.Gender,
                    Phone = x.Phone
                }).ToList();

            return model;
        }
    }
}
