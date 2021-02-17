using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UserRoles.Entities
{
    [Table("tblUsers")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }
        
        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Required, StringLength(255)]
        public string Password { get; set; }
        
        [StringLength(255)]
        public string Image { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
