using System;
using System.Collections.Generic;
using System.Text;

namespace Rozetka.Models
{
    public class CustomComboboxItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
