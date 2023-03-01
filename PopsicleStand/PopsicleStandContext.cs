using Microsoft.EntityFrameworkCore;
using PopsicleStand.Entities;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace PopsicleStand
{
    public class PopsicleStandContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        //public DbSet<Warehouse> Warehouses { get; set; }

        public string DbPath { get; }

        public PopsicleStandContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "popsiclestand.db");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = Guid.Parse("382f6336-f6ad-457e-b65f-7d7e9f3c06e6"),
                Name = "Onions",
                Price = 11.00
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = Guid.Parse("1bd3aea4-4c5a-4f19-b409-7cbca3fada73"),
                Name = "Limes",
                Price = 12.00
            });

        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}