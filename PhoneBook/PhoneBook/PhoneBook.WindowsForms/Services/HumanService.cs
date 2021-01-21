using PhoneBook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook.WindowsForms.Models.Services
{
    public class HumanService
    {
        public static List<HumanView> Search(MyContext context, SearchHuman search)
        {
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
            var list = query
                .Select(x => new HumanView
                {
                    Surname = x.Surname,
                    Name = x.Name,
                    Gender = x.Gender,
                    Phone = x.Phone
                }).ToList();

            return list;
        }
    }
}
