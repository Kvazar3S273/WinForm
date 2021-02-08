using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Audit.DAL
{
    [Table("tblResultsAudit")]
    public class ResultAudit
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Session")]
        public int SessionId { get; set; }

        [ForeignKey("Answer")]
        public int AnswerId { get; set; }

        public virtual SessionAudit Session { get; set; }

        public virtual AnswerAudit Answer { get; set; }

    }
}
