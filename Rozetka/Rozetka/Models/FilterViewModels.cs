using System;
using System.Collections.Generic;
using System.Text;

namespace Rozetka.Models
{
    public class FilterValueModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsChecked { get; set; } = false;
        public override string ToString()
        {
            return Name.ToString();
        }
    }
    public class FNameViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsCollapsed { get; set; } = true;
        public List<FilterValueModel> Children { get; set; }
    }
}
