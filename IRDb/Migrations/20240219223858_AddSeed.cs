using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IRDb.Migrations
{
    /// <inheritdoc />
    public partial class AddSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MovieModels",
                columns: new[] { "Id", "Director", "Duration", "Genre", "Rating", "Title", "Year" },
                values: new object[,]
                {
                    { -10, "Peter Jackson", 178, "Adventure, Drama, Fantasy", 8.8000000000000007, "The Lord of the Rings: The Fellowship of the Ring", 2001 },
                    { -9, "Christopher Nolan", 169, "Adventure, Drama, Sci-Fi", 8.5999999999999996, "Interstellar", 2014 },
                    { -8, "Lana Wachowski, Lilly Wachowski", 136, "Action, Sci-Fi", 8.6999999999999993, "The Matrix", 1999 },
                    { -7, "Christopher Nolan", 148, "Action, Adventure, Sci-Fi", 8.6999999999999993, "Inception", 2010 },
                    { -6, "Robert Zemeckis", 142, "Drama, Romance", 8.8000000000000007, "Forrest Gump", 1994 },
                    { -5, "David Fincher", 139, "Drama", 8.8000000000000007, "Fight Club", 1999 },
                    { -4, "Quentin Tarantino", 154, "Crime, Drama", 8.9000000000000004, "Pulp Fiction", 1994 },
                    { -3, "Christopher Nolan", 152, "Action, Crime, Drama", 9.0, "The Dark Knight", 2008 },
                    { -2, "Francis Ford Coppola", 175, "Crime, Drama", 9.1999999999999993, "The Godfather", 1972 },
                    { -1, "Frank Darabont", 142, "Drama", 9.3000000000000007, "The Shawshank Redemption", 1994 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieModels",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "MovieModels",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "MovieModels",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "MovieModels",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "MovieModels",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "MovieModels",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "MovieModels",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "MovieModels",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "MovieModels",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "MovieModels",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
