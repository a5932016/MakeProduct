using Microsoft.EntityFrameworkCore.Migrations;

namespace MakeProduct.Migrations
{
    public partial class AlterProductSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "PhotoPath", "ProductClass", "ProductCount", "ProductName" },
                values: new object[] { 4, null, 3, 4, "鞋子" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
