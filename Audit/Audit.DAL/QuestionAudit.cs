using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Audit.DAL
{
    [Table("tblQuestionsAudit")]
    public class QuestionAudit
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(1000)]
        public string Text { get; set; }

        public virtual ICollection<AnswerAudit> Answers { get; set; }

    }
}
