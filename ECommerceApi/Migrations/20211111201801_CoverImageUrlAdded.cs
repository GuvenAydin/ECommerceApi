using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceApi.Migrations
{
    public partial class CoverImageUrlAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverImageUrl",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegularPrice",
                value: 3.5m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "DiscountedPrice", "Name", "RegularPrice" },
                values: new object[] { "Kamyon", 1.5m, "Kamyon", 6.5m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CoverImageUrl", "Description", "DiscountedPrice", "Name", "RegularPrice" },
                values: new object[,]
                {
                    { 4, null, "Dododo", 1.5m, "Laptop", 15.5m },
                    { 5, null, "Consultant", 3.5m, "Gemi", 33.5m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "CoverImageUrl",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegularPrice",
                value: 5.5m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "DiscountedPrice", "Name", "RegularPrice" },
                values: new object[] { "Consultant", 3.5m, "Gemi", 3.5m });
        }
    }
}
