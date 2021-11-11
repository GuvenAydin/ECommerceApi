using System;
using ECommerceApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApi.Data
{
    public class ECommerceDbContext: DbContext
    {
        public ECommerceDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Telefon", Description = "Developer", RegularPrice = (decimal)(5.5), DiscountedPrice = (decimal)(2.5) },
                new Product() { Id = 2, Name = "Tablet", Description = "Manager", RegularPrice = (decimal)(3.5), DiscountedPrice = (decimal)(1.5) },
                new Product() { Id = 3, Name = "Kamyon", Description = "Kamyon", RegularPrice = (decimal)(6.5), DiscountedPrice = (decimal)(1.5) },
                new Product() { Id = 4, Name = "Laptop", Description = "Dododo", RegularPrice = (decimal)(15.5), DiscountedPrice = (decimal)(1.5) },
                new Product() { Id = 5, Name = "Gemi", Description = "Consultant", RegularPrice = (decimal)(33.5), DiscountedPrice = (decimal)(3.5) });
        }



    }
}

