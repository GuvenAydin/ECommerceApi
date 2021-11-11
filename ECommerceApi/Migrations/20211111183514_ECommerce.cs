using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceApi.Migrations
{
    public partial class ECommerce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegularPrice = table.Column<int>(type: "int", nullable: false),
                    DiscountedPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "DiscountedPrice", "Name", "RegularPrice" },
                values: new object[] { 1, "Developer", 1, "Telefon", 5 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "DiscountedPrice", "Name", "RegularPrice" },
                values: new object[] { 2, "Manager", 1, "Tablet", 5 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "DiscountedPrice", "Name", "RegularPrice" },
                values: new object[] { 3, "Consultant", 1, "Gemi", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
