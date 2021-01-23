using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.WindowsForms.Models
{
    /// <summary>
    /// Модель для здійснення пошуку
    /// </summary>
    public class SearchHuman
    {
        // Поля для пошуку
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public int Page { get; set; }
        /// <summary>
        /// Кількість записів на сторінці по замовчуванню
        /// </summary>
        public int CountShowOnePage { get; set; } = 10;
    }
}
