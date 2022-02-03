using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmCollectionMission4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    DirectorFirst = table.Column<string>(nullable: false),
                    DirectorLast = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_Responses_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Category" },
                values: new object[] { 1, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Category" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Category" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Category" },
                values: new object[] { 4, "Family" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Category" },
                values: new object[] { 5, "Horror/Suspense" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Category" },
                values: new object[] { 6, "Miscellaneous" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Category" },
                values: new object[] { 7, "Television" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Category" },
                values: new object[] { 8, "VHS" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "CategoryID", "DirectorFirst", "DirectorLast", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 1, "Joe", "Johnston", false, "", "", "PG-13", "Captain America: The First Avenger", 2011 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "CategoryID", "DirectorFirst", "DirectorLast", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 1, "Joe", "Russo", false, "", "", "PG-13", "Captain America: Civil War", 2016 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "CategoryID", "DirectorFirst", "DirectorLast", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 1, "Joe", "Russo", false, "", "", "PG-13", "Captain America: Winter Soldier", 2014 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_CategoryID",
                table: "Responses",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
