using PhoneBook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook.WindowsForms.Models.Services
{
    public class HumanService
    {
        /// <summary>
        /// Сервіс пошуку згідно запитів
        /// </summary>
        /// <param name="context"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public static HumanViewGrid Search(MyContext context, SearchHuman search)
        {
            // Створюємо екземпляр класу нашої моделі для пошуку
            HumanViewGrid model = new HumanViewGrid();

            // Створюємо змінну-запит до БД
            var query = context.Humans.AsQueryable();

            // Назначаємо змінній те значення, яке відповідатиме параметрам пошуку
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

            // Кількість рядків, що будуть відображатись на 1 сторінці - вибирається в комбобоксі
            int showItems = search.CountShowOnePage;
            
            // Номер сторінки
            int page = search.Page - 1;

            // Визначаємо скільки всього записів отримали з БД в результаті пошуку по фільтру 
            model.CountRows = query.Count();

            // На основі запиту формуємо список отриманих даних з бази
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

            // Повертаємо список отриманих абонентів - як результат пошуку
            return model;
        }
    }
}
