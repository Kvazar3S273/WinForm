using System;
using System.Collections.Generic;
using System.Text;

namespace UserRoles.Models
{
    /// <summary>
    /// Для додавання значень в комбобокс
    /// </summary>
    public class ComboBoxItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
