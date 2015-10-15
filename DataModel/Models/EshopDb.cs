﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class EshopDb : DbContext
    {
        public DbSet<Prekes> Prekes { get; set; }
        public DbSet<Uzsakymas> Uzsakymas { get; set; }
        public DbSet<Krepselis> Krepselis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //one-to-many 
            modelBuilder.Entity<Uzsakymas>()
                .HasMany<Krepselis>(m => m.Krepselis)
                .WithMany();
        }
    }
}