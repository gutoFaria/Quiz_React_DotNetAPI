using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class Questions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    AnswerOne = table.Column<string>(type: "TEXT", nullable: false),
                    AnswerTwo = table.Column<string>(type: "TEXT", nullable: false),
                    AnswerThree = table.Column<string>(type: "TEXT", nullable: false),
                    AnswerFour = table.Column<string>(type: "TEXT", nullable: false),
                    AnswerCorrect = table.Column<string>(type: "TEXT", nullable: false),
                    TemaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AnswerCorrect", "AnswerFour", "AnswerOne", "AnswerThree", "AnswerTwo", "TemaId", "Title" },
                values: new object[,]
                {
                    { 1, "9", "10", "7", "9", "8", 1, "Quanto é 5 + 4 = ? " },
                    { 2, "14", "14", "7", "15", "11", 1, "Quanto é 10 + 4 = ? " },
                    { 3, "6", "10", "6", "4", "8", 1, "Quanto é 3 + 3 = ? " },
                    { 4, "11", "18", "10", "29", "11", 1, "Quanto é 2 + 9 = ? " },
                    { 5, "2", "11", "3", "2", "4", 1, "Quanto é 1 + 1 = ? " },
                    { 6, "1", "6", "7", "9", "1", 2, "Quanto é 5 - 4 = ? " },
                    { 7, "2", "1", "12", "2", "3", 2, "Quanto é 7 - 5 = ? " },
                    { 8, "0", "8", "0", "5", "3", 2, "Quanto é 10 - 10 = ? " },
                    { 9, "4", "12", "2", "4", "6", 2, "Quanto é 8 - 4 = ? " },
                    { 10, "8", "10", "7", "9", "8", 2, "Quanto é 15 - 7 = ? " }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
