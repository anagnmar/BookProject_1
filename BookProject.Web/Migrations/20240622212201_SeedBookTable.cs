using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookProject.Web.Migrations
{
    public partial class SeedBookTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "ISBN", "Title" },
                values: new object[,]
                {
                    { 1, "James Patterson", "Biography", "359-0-9921-2413-7", "Thief Of The South" },
                    { 2, "Fyodor Dostoevsky", "Sci-fi", "823-0-5471-0259-1", "Titan Retreating" },
                    { 3, "Oscar Wilde", "Romance", "487-0-6398-9010-8", "He Stole My Knight" },
                    { 4, "James Joyce", "Mystery", "143-0-2581-2591-4", "Rescue At The Castle" },
                    { 5, "Ernest Hemingway", "Crime", "561-0-1795-1795-8", "Made for Duty" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
