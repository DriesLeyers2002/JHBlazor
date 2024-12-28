using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class testikwordgek : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f89c2d68-a5d7-4fc0-be04-881914d8dc5b", "AQAAAAIAAYagAAAAEKHopSL9gO+mLisaSxRoS27k2vaDGBHuB6XJv5IkeLiaVGFrMVeYQEwZz/KOGsogMA==", "a76a1e77-9b2c-41ba-9ae5-70d8d092da5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e440fb02-22a6-4d9d-8e83-ad46cc21fd69", "AQAAAAIAAYagAAAAEE2H4YP2PT0AgurxFqO3D84aQQqS+tK85u96eWHm00EVEwZXVYPKmle/hiMvHyFdTQ==", "b81ba5a6-64cd-4eee-a20a-60dd205b8137" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "006d915a-5825-4dab-835c-8d4b3dd12eee", "AQAAAAIAAYagAAAAEHjjrHX6yD0pvmvbrnVP2PBPFwaKLDI6NppZq1B1abYgpgfqAQ1JXfVSkN9sGECc7w==", "05ff4248-a0d9-4c1f-b292-0ac971601ae7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
