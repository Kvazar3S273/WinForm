using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Audit.DAL
{
    [Table("tblUsersAudit")]
    public class UserAudit
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, StringLength(150)]
        public string Surname { get; set; }

        [Required, StringLength(100)]
        public string Login { get; set; }

        [Required, StringLength(120)]
        public string Password { get; set; }
        public virtual ICollection<SessionAudit> Sessions { get; set; }
    }
}
