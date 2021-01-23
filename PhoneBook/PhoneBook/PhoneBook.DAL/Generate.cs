using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Bogus.DataSets.Name;

namespace PhoneBook.DAL
{
    public class Generate
    {
        // Створюємо перелік статей
        public enum Gender
        {
            Male,
            Female
        }

        // Метод для генерування абонентів через бібліотеку Богус
        public void GenerateUser(MyContext context)
        {
            Random rnd = new Random();
            List<Human> listHuman = new List<Human>();
            var human = new Faker<Human>("uk")
                .RuleFor(h => h.Gender, f => f.Person.Gender.ToString())
                .RuleFor(h => h.Surname, f => f.Name.LastName(f.Person.Gender))
                .RuleFor(h => h.Name, f => f.Name.FirstName(f.Person.Gender))
                .RuleFor(h => h.Phone, f => f.Phone.PhoneNumber());
            
            // Додаємо в список 1000 абонентів
            for (int i = 0; i < 1000; i++)
            {
                listHuman.Add(human.Generate());
            }

            // Якщо в таблиці пусто - здійснюємо заповнення таблиці згенерованими абонентами
            if(context.Humans.Count()==0)
            {
                foreach (var item in listHuman)
                {
                    context.Humans.Add(
                        new Human
                        {
                            Gender = item.Gender,
                            Surname = item.Surname,
                            Name = item.Name,
                            Phone = item.Phone
                        });
                }
            }
            context.SaveChanges();
        }
    }   
}
