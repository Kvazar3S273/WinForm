﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreeView
{
    public class EFContext : DbContext
    {
        public DbSet<Breed> Breeds { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.238.103.51; Port=5743; Database=ba2hdb; Username=ba2h; Password=$544$B77w**G)K$t!ba2h22}");
        }
    }
}
