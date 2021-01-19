using Bogus;
using System;
using System.Collections.Generic;
using System.Text;
using static Bogus.DataSets.Name;

namespace PhoneBook
{
    public class Generate
    {
        
        public void GenerateUser(MyContext context)
        {
            Random rnd = new Random();
            List<Human> listHuman = new List<Human>();
            var human = new Faker<Human>("uk")
                .RuleFor(h => h.gender, f => f.PickRandom<Gender>())
                .RuleFor(h => h.Surname, (f, h) => f.Name.LastName(h.gender))
                .RuleFor(h => h.Name, (f, h) => f.Name.FirstName(h.gender))
                .RuleFor(h => h.Phone, f => f.Phone.PhoneNumber());


        }
    }   
}
