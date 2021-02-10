using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UserRoles.Entities
{
    [Table("tblRoles")]
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Title { get; set; }

        [StringLength(300)]
        public string ConcurrencyStamp { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }

    }
}
