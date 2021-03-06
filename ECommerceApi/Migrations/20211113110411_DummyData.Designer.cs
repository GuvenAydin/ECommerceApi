// <auto-generated />
using System;
using ECommerceApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerceApi.Migrations
{
    [DbContext(typeof(ECommerceDbContext))]
    [Migration("20211113110411_DummyData")]
    partial class DummyData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ECommerceApi.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CoverImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal?>("DiscountedPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RegularPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CoverImageUrl = "https://via.placeholder.com/335&text=Iphone_15_X",
                            Description = "Nice iphone 15 X PRO MAX",
                            DiscountedPrice = 790.5m,
                            Name = "Iphone 15",
                            RegularPrice = 890.5m
                        },
                        new
                        {
                            Id = 2,
                            CoverImageUrl = "https://via.placeholder.com/335&text=Macbook_Pro",
                            Description = "It is nice macbook 1TB hdd",
                            DiscountedPrice = 4899.9m,
                            Name = "Macbook Pro",
                            RegularPrice = 5000m
                        },
                        new
                        {
                            Id = 3,
                            CoverImageUrl = "https://via.placeholder.com/335&text=Oculus_Quest_2",
                            Description = "Oculus Quest 2 is our newest, most advanced all-in-one VR system yet.",
                            DiscountedPrice = 489.8m,
                            Name = "Oculus Quest 2",
                            RegularPrice = 550m
                        },
                        new
                        {
                            Id = 4,
                            CoverImageUrl = "https://via.placeholder.com/335&text=Apple_Watch_7",
                            Description = "Apple Watch is het ultieme device voor een gezond leven. ",
                            DiscountedPrice = 749.9m,
                            Name = "Apple Watch 7",
                            RegularPrice = 800m
                        },
                        new
                        {
                            Id = 5,
                            CoverImageUrl = "https://via.placeholder.com/335&text=Sony_Headset",
                            Description = "Buy Gaming headset?",
                            DiscountedPrice = 89.9m,
                            Name = "Sony Headset",
                            RegularPrice = 99.9m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
