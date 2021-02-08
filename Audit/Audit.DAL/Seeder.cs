using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Audit.DAL
{
    public class Seeder
    {
        public static void SeedAll(MyContext context)
        {
            AddQuestion(context);
        }
        private static void AddQuestion(MyContext context)
        {
            if (context.Questions.Count() == 0)
            {
                var question = new QuestionAudit
                {
                    Text = "Куди діваються снігурі влітку?",
                };

                context.Questions.Add(question);
                context.SaveChanges();
                var answers = new List<AnswerAudit>
                {
                    new AnswerAudit {Text="Відлітають в холодні краї", IsTrue=false, QuestionId=question.Id},
                    new AnswerAudit {Text="Ховаються від людей, вилітають вночі", IsTrue=false, QuestionId=question.Id},
                    new AnswerAudit {Text="Відлітають в ліси", IsTrue=true, QuestionId=question.Id},
                    new AnswerAudit {Text="Міняють оперення і стають горобцями", IsTrue=false, QuestionId=question.Id}
                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                
                question = new QuestionAudit
                {
                    Text = "Про яку пору року написана пісня *На белом покрывале января*?",
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<AnswerAudit>
                {
                    new AnswerAudit {Text="Весна", IsTrue=false, QuestionId=question.Id},
                    new AnswerAudit {Text="Літо", IsTrue=true, QuestionId=question.Id},
                    new AnswerAudit {Text="Осінь", IsTrue=false, QuestionId=question.Id},
                    new AnswerAudit {Text="Зима", IsTrue=false, QuestionId=question.Id}
                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                
                question = new QuestionAudit
                {
                    Text = "Продовжіть приказку: *Чим далі в ліс, ...*",
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<AnswerAudit>
                {
                    new AnswerAudit {Text="тим зліші дятли", IsTrue=false, QuestionId=question.Id},
                    new AnswerAudit {Text="тим ближче виліз", IsTrue=false, QuestionId=question.Id},
                    new AnswerAudit {Text="тим грубші партизани", IsTrue=false, QuestionId=question.Id},
                    new AnswerAudit {Text="тим більше дров", IsTrue=true, QuestionId=question.Id}
                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                
                question = new QuestionAudit
                {
                    Text = "Чому зникли динозаври?",
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<AnswerAudit>
                {
                    new AnswerAudit {Text="Померли з голоду", IsTrue=true, QuestionId=question.Id},
                    new AnswerAudit {Text="Померли від пандемії", IsTrue=false, QuestionId=question.Id},
                    new AnswerAudit {Text="В них попав метеорит", IsTrue=false, QuestionId=question.Id},
                    new AnswerAudit {Text="Вони нікуди не зникли", IsTrue=false, QuestionId=question.Id}
                };
                context.Answers.AddRange(answers);
                context.SaveChanges();

                question = new QuestionAudit
                {
                    Text = "Хто такий *амбісіністр*?",
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<AnswerAudit>
                {
                    new AnswerAudit {Text="Людина, яка добре володіє обома руками", IsTrue=false, QuestionId=question.Id},
                    new AnswerAudit {Text="Людина, яка погано володіє обома руками", IsTrue=true, QuestionId=question.Id},
                    new AnswerAudit {Text="Людина, яка краще володіє лівою рукою", IsTrue=false, QuestionId=question.Id},
                    new AnswerAudit {Text="Людина, яка краще володіє правою рукою", IsTrue=false, QuestionId=question.Id}
                };
                context.Answers.AddRange(answers);
                context.SaveChanges();

            }

            if (context.Users.Count() == 0)
            {
                var user = new UserAudit
                {
                    Name = "Єгор",
                    Surname = "Кварц",
                    Login = "1",
                    Password = "1"
                };

                context.Users.Add(user);
                context.SaveChanges();

                var session = new List<SessionAudit>
                {
                    new SessionAudit
                    {
                        UserId=user.Id,
                        Begin=DateTime.Now,
                        End=DateTime.Now.AddMinutes(12),
                        Marks=50M}
                };
                context.Sessions.AddRange(session);
                context.SaveChanges();

                var res = new List<ResultAudit>
                {
                    new ResultAudit {SessionId=1,AnswerId=3},
                    new ResultAudit {SessionId=1,AnswerId=6},
                    new ResultAudit {SessionId=1,AnswerId=12},
                    new ResultAudit {SessionId=1,AnswerId=13},
                    new ResultAudit {SessionId=1,AnswerId=18}
                };
                context.Results.AddRange(res);
                context.SaveChanges();
            }
        }
    }
}
