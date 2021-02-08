using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.DAL
{
    public class MyContext : DbContext
    {
        public DbSet<QuestionAudit> Questions { get; set; }
        public DbSet<AnswerAudit> Answers { get; set; }
        public DbSet<UserAudit> Users { get; set; }
        public DbSet<SessionAudit> Sessions { get; set; }
        public DbSet<ResultAudit> Results { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=95.214.10.36;Port=5432;Database=ba2hdb;Username=ba2h;Password=$544$B77w**G)K$t!ba2h22}");
        }


    }
}
