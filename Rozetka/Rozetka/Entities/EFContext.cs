﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<Product> Products { get; set; }
        public DbSet<Filter> Filters { get; set; }
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

            modelBuilder.Entity<Filter>(filter =>
            {
                filter.HasKey(f => new { f.ProductId, f.FilterValueId, f.FilterNameId });

                filter.HasOne(ur => ur.FilterNameOf)
                    .WithMany(r => r.Filters)
                    .HasForeignKey(ur => ur.FilterNameId)
                    .IsRequired();

                filter.HasOne(ur => ur.FilterValueOf)
                    .WithMany(r => r.Filters)
                    .HasForeignKey(ur => ur.FilterValueId)
                    .IsRequired();

                filter.HasOne(ur => ur.ProductOf)
                    .WithMany(r => r.Filters)
                    .HasForeignKey(ur => ur.ProductId)
                    .IsRequired();
            });
        }
    }
}
