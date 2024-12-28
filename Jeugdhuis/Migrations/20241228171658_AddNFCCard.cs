using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class AddNFCCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NfcCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CardId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Balance = table.Column<double>(type: "double", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NfcCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NfcCards_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3bdad66-7961-480a-8b7f-20846667737f", "AQAAAAIAAYagAAAAEAdFZDDZfWoJMyJkWyvLzcukVDLqyt0gUaISS4etFv6ggPAm1mHPL9CVzKI2UK6YGw==", "99c92b24-5ce4-4b4b-a046-a7e1a60f8e36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e97998bd-01c8-4e41-bd56-7e81ae70e3f6", "AQAAAAIAAYagAAAAEITKkdyYq8eEOVHau72nnB+DD0QQSVBtxWrgpR4pbQhiHRmIOZo7V37uEE8CoZrtPQ==", "a758826c-5823-45a4-b6fd-131e56b9abbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0734bc4e-e7d3-42a0-baf5-f4501a28a383", "AQAAAAIAAYagAAAAEAV0gu1htyykQulO3uqsNzKLrx8edowvAoJwwKC2yM4/RWerQj1oInctvsycnXMt/Q==", "3e7cecc9-06f7-42f2-8b75-b9fdd091e665" });

            migrationBuilder.CreateIndex(
                name: "IX_NfcCards_UserId",
                table: "NfcCards",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NfcCards");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "244895b5-0216-49db-b2b7-7417f383b79e", "AQAAAAIAAYagAAAAEDXBWDHjl8+o7XagllDvGm39JlkcpG29th9ynUXSWeaH1FIQ1mM1Pje8nhC7JoObsw==", "be0ecf16-3005-43f1-85b4-eddf4e8a41bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09490ec7-2822-45cc-88bb-d62dd40de535", "AQAAAAIAAYagAAAAEGcBaXqB6MGGbNhZcZSuAKJg1esvJT2v+cBK0qXS/drH6xOwPHSpDl71+vNm/a/pCg==", "e9a9dd30-737e-4d5f-8003-7f779031416e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79d97013-fccb-4f64-aa2d-feec20afdf3f", "AQAAAAIAAYagAAAAEKFE9RbRY3ZbqUFBT9qS1QPDwRkMi63ozRbZlj2SJQLTuValTbP7Zc4fHtLYvsBUDg==", "c0c64d70-57d9-4603-8da3-63152820a508" });
        }
    }
}
