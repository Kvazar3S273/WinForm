﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UserRoles.Models
{
    /// <summary>
    /// Модель для здійснення пошуку
    /// </summary>
    public class SearchUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
    }
}
