using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UserRoles.Entities
{
    [Table("tblRolesR")]
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Title { get; set; }

        [StringLength(300)]
        public string ConcurrencyStamp { get; set; }
    }
}
