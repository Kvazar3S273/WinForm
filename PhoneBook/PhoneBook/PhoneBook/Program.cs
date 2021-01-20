using PhoneBook.DAL;
using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Generate generate = new Generate();
            generate.GenerateUser(new MyContext());
            Console.WriteLine("Додано 1000 абонентів");
        }
    }
}
