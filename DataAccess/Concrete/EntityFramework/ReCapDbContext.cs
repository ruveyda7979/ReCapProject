﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = LAPTOP-HHNSAKJD\SQLEXPRESS;Database = ReCapDb; Trusted_Connection = true; TrustServerCertificate=true;MultipleActiveResultSets=true");

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet <User>Users { get; set; }
        public DbSet <Customer>Customers { get; set; }
        public DbSet <Rental>Rentals { get; set; }
    }
}
