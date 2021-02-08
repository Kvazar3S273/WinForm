using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.WindowsForms.Model
{
    /// <summary>
    /// Запитання
    /// </summary>
    public class QuestionModel
    {
        public string Text { get; set; }
        public List<QuestionAnswerModel> Answers { get; set; }
    }

    /// <summary>
    /// Варіанти відповіді
    /// </summary>
    public class QuestionAnswerModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsTrue { get; set; }
    }
}
