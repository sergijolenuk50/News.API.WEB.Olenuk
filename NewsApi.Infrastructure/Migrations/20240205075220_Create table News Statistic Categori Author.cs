using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NewsApi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreatetableNewsStatisticCategoriAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aucthors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aucthors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    CountNewsOpen = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrowserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cyti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Aucthors",
                columns: new[] { "Id", "City", "Email", "Name", "NewsId", "Surname" },
                values: new object[,]
                {
                    { 1, "Kyiv", "sara@ua", "Sara", 1, "Ivanova" },
                    { 2, "Kyiv", "dima@ua", "Dima", 2, "Dallas" },
                    { 3, "Kyiv", "ira@ua", "Ira", 3, "Dmitrivna" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Category about sport", "Sport" },
                    { 2, "Category about cience", "Cience" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "AuthorId", "CategoryId", "CountNewsOpen", "Information", "Name" },
                values: new object[,]
                {
                    { 1, 1, 1, 2L, "There is no time to hesitate", "New Kyiv" },
                    { 2, 2, 1, 0L, "Freud's conditioning", "New Kyiv" },
                    { 3, 2, 2, 0L, "Rebrov recently received an offer to head the club", "Sport Kyiv" }
                });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "BrowserName", "Cyti", "IP", "NewsId", "OS" },
                values: new object[,]
                {
                    { 1, "Chrome", "Rivne", "127.127.000.255", 1, "Windows" },
                    { 2, "Mazila", "Kyiv", "127.127.000.285", 1, "Windows" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aucthors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Statistics");
        }
    }
}
