using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserRoles.Entities;

namespace UserRoles.Models
{
    public class UserService
    {
        public static UserViewGrid Search(EFContext context, SearchUser search)
        {
            // Створюємо екземпляр класу нашої моделі для пошуку
            UserViewGrid model = new UserViewGrid();

            // Створюємо змінну-запит до БД
            var query = context.UserRoles.Include(x => x.User).Include(y => y.Role).AsQueryable();

            // Назначаємо змінній те значення, яке відповідатиме параметрам пошуку
            if(!string.IsNullOrEmpty(search.Name))
            {
                query = query.Where(x => x.User.Name.Contains(search.Name));
            }
            if(!string.IsNullOrEmpty(search.Email))
            {
                query = query.Where(x => x.User.Email.Contains(search.Email));
            }
            if(!string.IsNullOrEmpty(search.PhoneNumber))
            {
                query = query.Where(x => x.User.PhoneNumber.Contains(search.PhoneNumber));
            }  
            if(!string.IsNullOrEmpty(search.Role))
            {
                query = query.Where(x => x.Role.Title.Contains(search.Role));
            }

            // На основі запиту формуємо список отриманих даних з бази
            model.Users = query.Select(x =>
              new UserView
              {
                  Id = x.User.Id,
                  Name = x.User.Name,
                  Email = x.User.Email,
                  PhoneNumber = x.User.PhoneNumber,
                  Role = x.Role.Title
              }).ToList();
            
            // Повертаємо список отриманих user-ів - як результат пошуку
            return model;
        }

    }
}
