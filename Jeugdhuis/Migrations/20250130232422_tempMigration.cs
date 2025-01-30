using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class tempMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TotalAmount = table.Column<double>(type: "double", nullable: false),
                    UserId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaymentType = table.Column<int>(type: "int", nullable: false),
                    CardId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BuyerName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DrinkId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PriceAtPurchase = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Drinks_DrinkId",
                        column: x => x.DrinkId,
                        principalTable: "Drinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db0cef50-8956-4268-81a6-1de4faee8278", "AQAAAAIAAYagAAAAEArx2jMGhO9JTJQJNxuES/Kkasef28HotVgYpAqhX1xQwVKawYLwE7MreYPp9VcwPw==", "63e5c458-ef41-4ecf-86e8-3bc40b1cc985" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43430332-6f4e-4863-8585-dd9c2f622d4e", "AQAAAAIAAYagAAAAEO7Nh7K0sRgQOSRI2ybxoyoK0ibExRDJtvzzJCqF2zf1IeZnmhirdUwQmY4b2E49zQ==", "7db1c811-0cba-4819-ab24-0d2ac8a55cdf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3588321e-cfa7-49f4-9c88-cd6f23b2797b", "AQAAAAIAAYagAAAAEJgBoXkCzGipiE1OMQxzceOeXfvQSLoFwD+jxDTzdvp0ajo3NyrapzDorkasoekGNw==", "eee87b80-5849-4c11-8ef5-a9d6f3e27c05" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BuyerName", "CardId", "OrderDate", "PaymentType", "TotalAmount", "UserId" },
                values: new object[,]
                {
                    { 1, "Lewis", "", new DateTime(2025, 1, 27, 23, 24, 21, 857, DateTimeKind.Utc).AddTicks(5002), 0, 7.5, "Dries" },
                    { 2, "Willie", "321", new DateTime(2025, 1, 28, 23, 24, 21, 857, DateTimeKind.Utc).AddTicks(5011), 2, 24.0, "Vincent" },
                    { 3, "Peters", "31", new DateTime(2025, 1, 29, 23, 24, 21, 857, DateTimeKind.Utc).AddTicks(5013), 2, 4.5, "Simon" },
                    { 4, "Doe", "", new DateTime(2025, 1, 30, 18, 24, 21, 857, DateTimeKind.Utc).AddTicks(5014), 1, 7.5, "Dries" },
                    { 5, "Jhon", "", new DateTime(2025, 1, 30, 21, 24, 21, 857, DateTimeKind.Utc).AddTicks(5016), 0, 21.0, "Vincent" }
                });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "Id", "DrinkId", "OrderId", "PriceAtPurchase", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 3.0, 2 },
                    { 2, 7, 1, 1.5, 1 },
                    { 3, 5, 2, 3.0, 3 },
                    { 4, 12, 2, 15.0, 1 },
                    { 5, 30, 3, 1.5, 2 },
                    { 6, 20, 3, 1.5, 1 },
                    { 7, 2, 4, 3.0, 2 },
                    { 8, 3, 4, 1.5, 1 },
                    { 9, 12, 5, 15.0, 1 },
                    { 10, 13, 5, 3.0, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_DrinkId",
                table: "OrderItem",
                column: "DrinkId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22c61f62-b2fb-4727-b4b9-d6fadb85a8a9", "AQAAAAIAAYagAAAAEBCj44w9dVW9IhXOJO88yBCuoD26vP6GmBobL0ycNhjYBL/+KY36adSY3vl3vLVkCw==", "d34e05c8-eda4-4c33-9d95-01f24a07da13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9696758e-e387-4625-a1c0-3c43d42ea1b8", "AQAAAAIAAYagAAAAEJyqMhwAmFs7GP6yJXLTdASng1KGpvxg2MtDm5vkoYi/4KLaJTICt3b+PTkzcd3D0w==", "8a575d27-0abb-4875-a7e6-f1e321e35b41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "535168f3-f45f-4f1c-a52b-b095adb21781", "AQAAAAIAAYagAAAAEO1/GSMfN2tTCYJtN1Hsod17S7CRyOEAYDxuWPCPqgOzg+Pq8G0aa1gMggzx++WIVg==", "bce6cd1e-78de-41d3-8830-e18291076194" });
        }
    }
}
