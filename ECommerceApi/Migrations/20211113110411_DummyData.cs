using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceApi.Migrations
{
    public partial class DummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoverImageUrl", "Description", "DiscountedPrice", "Name", "RegularPrice" },
                values: new object[] { "https://via.placeholder.com/335&text=Iphone_15_X", "Nice iphone 15 X PRO MAX", 790.5m, "Iphone 15", 890.5m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoverImageUrl", "Description", "DiscountedPrice", "Name", "RegularPrice" },
                values: new object[] { "https://via.placeholder.com/335&text=Macbook_Pro", "It is nice macbook 1TB hdd", 4899.9m, "Macbook Pro", 5000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoverImageUrl", "Description", "DiscountedPrice", "Name", "RegularPrice" },
                values: new object[] { "https://via.placeholder.com/335&text=Oculus_Quest_2", "Oculus Quest 2 is our newest, most advanced all-in-one VR system yet.", 489.8m, "Oculus Quest 2", 550m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoverImageUrl", "Description", "DiscountedPrice", "Name", "RegularPrice" },
                values: new object[] { "https://via.placeholder.com/335&text=Apple_Watch_7", "Apple Watch is het ultieme device voor een gezond leven. ", 749.9m, "Apple Watch 7", 800m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoverImageUrl", "Description", "DiscountedPrice", "Name", "RegularPrice" },
                values: new object[] { "https://via.placeholder.com/335&text=Sony_Headset", "Buy Gaming headset?", 89.9m, "Sony Headset", 99.9m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoverImageUrl", "Description", "DiscountedPrice", "Name", "RegularPrice" },
                values: new object[] { "https://via.placeholder.com/335&text=Product_1", "Developer", 2.5m, "Telefon", 5.5m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoverImageUrl", "Description", "DiscountedPrice", "Name", "RegularPrice" },
                values: new object[] { "https://via.placeholder.com/335&text=Product_2", "Manager", 1.5m, "Tablet", 3.5m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoverImageUrl", "Description", "DiscountedPrice", "Name", "RegularPrice" },
                values: new object[] { "https://via.placeholder.com/335&text=Product_3", "Kamyon", 1.5m, "Kamyon", 6.5m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoverImageUrl", "Description", "DiscountedPrice", "Name", "RegularPrice" },
                values: new object[] { "https://via.placeholder.com/335&text=Product_4", "Dododo", 1.5m, "Laptop", 15.5m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoverImageUrl", "Description", "DiscountedPrice", "Name", "RegularPrice" },
                values: new object[] { "https://via.placeholder.com/335&text=Product_5", "Consultant", 3.5m, "Gemi", 33.5m });
        }
    }
}
