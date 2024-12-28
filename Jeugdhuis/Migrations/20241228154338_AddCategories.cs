using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class AddCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Color", "Name" },
                values: new object[] { 6, "#3285a8", "andere" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38fb903f-158e-4fc4-958e-2cf71f3f9a57", "AQAAAAIAAYagAAAAEDbkVNkxwmigQhHTO0Yux6hpc4hzvs+x2qLwOh51Yc24IAQB8c8EbmgDzNc+vYqyhA==", "f7d0ecf1-c8dd-4f7c-bd81-95ed7f3cd01d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "235f721e-b836-47b5-a7fd-8ce3726fff17", "AQAAAAIAAYagAAAAEBk0eKWBteCr93b1PmI7OlhRSFWnMsrITOn/JV23a9rfLgqf8yz0xNjs4H09/dR1yQ==", "2386c1fc-7853-4370-8e11-31952c2e00bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae112103-a6b0-493f-864e-67eeabf48613", "AQAAAAIAAYagAAAAEK29QsHiq4yruTox4HdmwKpmL1r2Rc6shOCZCkaBzA1Y+MKPjPCPjuYI/99XJTZ+cQ==", "c6f195f5-214a-43fd-ab1c-743e18b75a4c" });
        }
    }
}
