using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhoneBook
{
    [Table("tblHuman")]
    public class Human
    {
        [Key]
        public int Id { get; set; }
    
        [Required, StringLength(100)]
        public string Surname { get; set; }
    
        [Required, StringLength(100)]
        public string Name { get; set; }
    
        [Required, StringLength(15)]
        public string Phone { get; set; }
        
        [Required, StringLength(10)]
        public string Sex { get; set; }
    }
}
