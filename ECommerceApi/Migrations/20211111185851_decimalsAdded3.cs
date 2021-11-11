using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceApi.Migrations
{
    public partial class decimalsAdded3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DiscountedPrice", "RegularPrice" },
                values: new object[] { 2.5m, 5.5m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DiscountedPrice", "RegularPrice" },
                values: new object[] { 1.5m, 5.5m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DiscountedPrice", "RegularPrice" },
                values: new object[] { 3.5m, 3.5m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DiscountedPrice", "RegularPrice" },
                values: new object[] { 1m, 5m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DiscountedPrice", "RegularPrice" },
                values: new object[] { 1m, 5m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DiscountedPrice", "RegularPrice" },
                values: new object[] { 1m, 5m });
        }
    }
}
