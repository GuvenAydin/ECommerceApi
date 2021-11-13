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
                new Product() { Id = 1, Name = "Iphone 15", Description = "Nice iphone 15 X PRO MAX", RegularPrice = (decimal)(890.5), DiscountedPrice = (decimal)(790.5), CoverImageUrl = "https://via.placeholder.com/335&text=Iphone_15_X" },
                new Product() { Id = 2, Name = "Macbook Pro", Description = "It is nice macbook 1TB hdd", RegularPrice = (decimal)(5000.0), DiscountedPrice = (decimal)(4899.9), CoverImageUrl = "https://via.placeholder.com/335&text=Macbook_Pro" },
                new Product() { Id = 3, Name = "Oculus Quest 2", Description = "Oculus Quest 2 is our newest, most advanced all-in-one VR system yet.", RegularPrice = (decimal)(550.0), DiscountedPrice = (decimal)(489.8), CoverImageUrl = "https://via.placeholder.com/335&text=Oculus_Quest_2" },
                new Product() { Id = 4, Name = "Apple Watch 7", Description = "Apple Watch is het ultieme device voor een gezond leven. ", RegularPrice = (decimal)(800.0), DiscountedPrice = (decimal)(749.9), CoverImageUrl = "https://via.placeholder.com/335&text=Apple_Watch_7" },
                new Product() { Id = 5, Name = "Sony Headset", Description = "Buy Gaming headset?", RegularPrice = (decimal)(99.9), DiscountedPrice = (decimal)(89.9), CoverImageUrl = "https://via.placeholder.com/335&text=Sony_Headset" });
        }
    }
}

