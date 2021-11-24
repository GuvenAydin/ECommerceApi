using System;
using ECommerceApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApi.Data
{
    public class ECommerceDbContext: DbContext
    {
        public ECommerceDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<User> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Iphone 15", Description = "Nice iphone 15 X PRO MAX", RegularPrice = (decimal)(890.5), DiscountedPrice = (decimal)(790.5), CoverImageUrl = "https://via.placeholder.com/335&text=Iphone_15_X" },
                new Product() { Id = 2, Name = "Macbook Pro", Description = "It is nice macbook 1TB hdd", RegularPrice = (decimal)(5000.0), DiscountedPrice = (decimal)(4899.9), CoverImageUrl = "https://via.placeholder.com/335&text=Macbook_Pro" },
                new Product() { Id = 3, Name = "Oculus Quest 2", Description = "Oculus Quest 2 is our newest, most advanced all-in-one VR system yet.", RegularPrice = (decimal)(550.0), DiscountedPrice = (decimal)(489.8), CoverImageUrl = "https://via.placeholder.com/335&text=Oculus_Quest_2" },
                new Product() { Id = 4, Name = "Apple Watch 7", Description = "Apple Watch is het ultieme device voor een gezond leven. ", RegularPrice = (decimal)(800.0), DiscountedPrice = (decimal)(749.9), CoverImageUrl = "https://via.placeholder.com/335&text=Apple_Watch_7" },
                new Product() { Id = 5, Name = "Sony Headset", Description = "Buy Gaming headset?", RegularPrice = (decimal)(99.9), CoverImageUrl = "https://via.placeholder.com/335&text=Sony_Headset" });

            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, FirstName = "Anki", LastName = "De Jong", Email = "anki@outlook.com", Phone = "0617363601",Password = "ncgEKxKdY+dMqZwLhTCJ6hXLw9qL9ARsXiy4lgz0uTo=" }, //Passwords 123456
                new User() { Id = 2, FirstName = "Dewitt", LastName = "Van de Berg", Email = "dewitt@outlook.com",Phone = "0655634616", Password = "ncgEKxKdY+dMqZwLhTCJ6hXLw9qL9ARsXiy4lgz0uTo=" },
                new User() { Id = 3, FirstName = "Dirck", LastName = "Bakker", Email = "dirck@outlook.com", Phone = "0621048961", Password = "ncgEKxKdY+dMqZwLhTCJ6hXLw9qL9ARsXiy4lgz0uTo=" },
                new User() { Id = 4, FirstName = "Gerritt", LastName = "Smit", Email = "gerritt@outlook.com",Phone = "0670902290", Password = "ncgEKxKdY+dMqZwLhTCJ6hXLw9qL9ARsXiy4lgz0uTo=" },
                new User() { Id = 5, FirstName = "Willem", LastName = "Meijer", Email = "willem@outlook.com",Phone = "0619116876", Password = "ncgEKxKdY+dMqZwLhTCJ6hXLw9qL9ARsXiy4lgz0uTo=" }
            );
        }


    }
}

