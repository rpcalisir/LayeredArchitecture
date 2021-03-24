using LayeredArchitecture.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayeredArchitecture.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
