using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class Temp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockItem_Drinks_DrinkId",
                table: "StockItem");

            migrationBuilder.DropForeignKey(
                name: "FK_StockItem_Stocks_StockId",
                table: "StockItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockItem",
                table: "StockItem");

            migrationBuilder.RenameTable(
                name: "StockItem",
                newName: "StockItems");

            migrationBuilder.RenameIndex(
                name: "IX_StockItem_StockId",
                table: "StockItems",
                newName: "IX_StockItems_StockId");

            migrationBuilder.RenameIndex(
                name: "IX_StockItem_DrinkId",
                table: "StockItems",
                newName: "IX_StockItems_DrinkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockItems",
                table: "StockItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockItems_Drinks_DrinkId",
                table: "StockItems",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockItems_Stocks_StockId",
                table: "StockItems",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockItems_Drinks_DrinkId",
                table: "StockItems");

            migrationBuilder.DropForeignKey(
                name: "FK_StockItems_Stocks_StockId",
                table: "StockItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockItems",
                table: "StockItems");

            migrationBuilder.RenameTable(
                name: "StockItems",
                newName: "StockItem");

            migrationBuilder.RenameIndex(
                name: "IX_StockItems_StockId",
                table: "StockItem",
                newName: "IX_StockItem_StockId");

            migrationBuilder.RenameIndex(
                name: "IX_StockItems_DrinkId",
                table: "StockItem",
                newName: "IX_StockItem_DrinkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockItem",
                table: "StockItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockItem_Drinks_DrinkId",
                table: "StockItem",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockItem_Stocks_StockId",
                table: "StockItem",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
