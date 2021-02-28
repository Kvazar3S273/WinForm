using Microsoft.EntityFrameworkCore;
using Rozetka.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rozetka
{
    public class EFContext : DbContext
    {
        public DbSet<FilterName> FilterNames { get; set; }
        public DbSet<FilterValue> FilterValues { get; set; }
        public DbSet<FilterNameGroup> FilterNameGroups { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.238.103.51; Port=5743; Database=ba2hdb; Username=ba2h; Password=$544$B77w**G)K$t!ba2h22}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FilterNameGroup>(filterNG =>
            {
                filterNG.HasKey(f => new { f.FilterValueId, f.FilterNameId });

                filterNG.HasOne(ur => ur.FilterNameOf)
                    .WithMany(r => r.FilterNameGroups)
                    .HasForeignKey(ur => ur.FilterNameId)
                    .IsRequired();

                filterNG.HasOne(ur => ur.FilterValueOf)
                    .WithMany(r => r.FilterNameGroups)
                    .HasForeignKey(ur => ur.FilterValueId)
                    .IsRequired();
            });

        }
    }
}
