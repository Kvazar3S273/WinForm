using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Audit.DAL
{
    [Table("tblSessionsAudit")]
    public class SessionAudit
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public decimal Marks { get; set; }
        public virtual UserAudit User { get; set; }
        public virtual ICollection<ResultAudit> Results { get; set; }
    }
}
