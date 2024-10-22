using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<double>(type: "double", nullable: false),
                    PriceAtParty = table.Column<double>(type: "double", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsOnlyAtPart = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Category = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StockItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DrinkId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockItem_Drinks_DrinkId",
                        column: x => x.DrinkId,
                        principalTable: "Drinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockItem_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "Category", "IsActive", "IsOnlyAtPart", "Name", "Price", "PriceAtParty" },
                values: new object[,]
                {
                    { 1, "snacks", true, false, "AirFryer snacks", 3.0, 0.0 },
                    { 2, "bier", true, false, "Bier van de maand", 3.0, 0.0 },
                    { 3, "frisdrank", true, false, "Bruiswater", 1.5, 0.0 },
                    { 4, "bier", true, false, "Buta ranzige Biru", 2.5, 0.0 },
                    { 5, "bier", true, false, "Chouffe", 3.0, 0.0 },
                    { 6, "bier", true, false, "Cherry Chouffe", 3.0, 0.0 },
                    { 7, "frisdrank", true, false, "Cola", 1.5, 0.0 },
                    { 8, "frisdrank", true, false, "Cola zero", 1.5, 0.0 },
                    { 9, "bier", true, false, "Cornet", 3.0, 0.0 },
                    { 10, "bier", true, false, "Duvel", 3.0, 0.0 },
                    { 11, "frisdrank", true, false, "Fanta", 1.5, 0.0 },
                    { 12, "wijn", true, false, "Fles Cava", 15.0, 0.0 },
                    { 13, "wijn", true, false, "Glas Cava", 3.0, 0.0 },
                    { 14, "wijn", true, false, "Glas Rosé", 3.0, 0.0 },
                    { 15, "wijn", true, false, "Glas witte wijn", 3.0, 0.0 },
                    { 16, "bier", true, false, "Gouden Carolus Classic", 3.0, 0.0 },
                    { 17, "bier", true, false, "Gouden Carolus tripel", 3.0, 0.0 },
                    { 18, "frisdrank", true, false, "Groene", 1.5, 0.0 },
                    { 19, "frisdrank", true, false, "Ice Tea", 1.5, 0.0 },
                    { 20, "Mietenbier", true, false, "Jupiler 0.0", 1.5, 0.0 },
                    { 21, "bier", true, false, "Kriek", 2.0, 0.0 },
                    { 22, "bier", true, false, "Maes fles", 1.5, 0.0 },
                    { 23, "bier", true, false, "Maes tap", 1.5, 0.0 },
                    { 24, "snacks", true, false, "Pizna baguette", 2.0, 0.0 },
                    { 25, "frisdrank", true, false, "Plat water", 1.5, 0.0 },
                    { 26, "frisdrank", true, false, "Sprite", 1.5, 0.0 },
                    { 27, "bier", true, false, "Stella fles", 1.5, 0.0 },
                    { 28, "bier", true, false, "Stella tap", 1.5, 0.0 },
                    { 29, "snacks", true, false, "Toogkletser", 5.0, 0.0 },
                    { 30, "snacks", true, false, "Zakje chips ouleh", 1.5, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "Year" },
                values: new object[,]
                {
                    { 1, "123 Main St", "john.doe@example.com", "John", "Doe", 2022 },
                    { 2, "456 Elm St", "jane.smith@example.com", "Jane", "Smith", 2023 },
                    { 3, "789 Maple St", "alice.johnson@example.com", "Alice", "Johnson", 2024 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockItem_DrinkId",
                table: "StockItem",
                column: "DrinkId");

            migrationBuilder.CreateIndex(
                name: "IX_StockItem_StockId",
                table: "StockItem",
                column: "StockId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockItem");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Stocks");
        }
    }
}
