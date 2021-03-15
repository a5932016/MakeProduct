using Microsoft.EntityFrameworkCore.Migrations;

namespace MakeProduct.Migrations
{
    public partial class SeedProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "PhotoPath", "ProductClass", "ProductCount", "ProductName" },
                values: new object[] { 1, null, 3, 1, "帽子" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "PhotoPath", "ProductClass", "ProductCount", "ProductName" },
                values: new object[] { 2, null, 1, 2, "衣服" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "PhotoPath", "ProductClass", "ProductCount", "ProductName" },
                values: new object[] { 3, null, 2, 3, "褲子" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
