using System;
using System.Collections.Generic;
using System.Text;

namespace UserRoles.Models
{
    public class UserViewGrid
    {
        /// <summary>
        /// Записи, які ми відображаємо по пошуку
        /// </summary>
        public List<UserView> Users { get; set; }

    }
    /// <summary>
    /// Дані про usera, які будемо показувати
    /// </summary>
    public class UserView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
    }
}
