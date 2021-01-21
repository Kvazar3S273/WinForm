using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.WindowsForms.Models
{
    public class HumanViewGrid
    {
        /// <summary>
        /// Записи, які ми відображаємо по пошуку
        /// </summary>
        public List<HumanView> Humans { get; set; }
        /// <summary>
        /// Загальна кількість записів, які ми знайшли
        /// </summary>
        public int CountRows { get; set; }
    }
    public class HumanView
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }

    }
}
