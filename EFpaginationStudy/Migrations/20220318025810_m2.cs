using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFpaginationStudy.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "The Hitchhiker's Guide to the Galaxy" },
                    { 2, "Ready Player One" },
                    { 3, "1984" },
                    { 4, "The Matrix Resurrections" },
                    { 5, "Diablo 2: Resurrected" },
                    { 6, "Super Nintendo Entertainment System" },
                    { 7, "Day of the Tentacle" },
                    { 8, "Back to the Future" },
                    { 9, "Toy Story" },
                    { 10, "Brave New World" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
