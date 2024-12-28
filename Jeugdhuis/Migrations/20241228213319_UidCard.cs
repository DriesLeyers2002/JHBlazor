using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class UidCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CardId",
                table: "NfcCards",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e9852fc-c2e9-43eb-badf-09311b9100b3", "AQAAAAIAAYagAAAAEAuGwpdyn7BHgyFle8yxBYYtHdQXQOWVtN+LyWROOf2F0F1a3sEuKV6OE1TEU75BTw==", "0cc83152-da6e-4fd6-82c9-25013a0f33cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "450b563a-03ce-485b-9130-b601d0d35b8b", "AQAAAAIAAYagAAAAEMxSd0ZBAoul1XCkcX4NutoLXvHULnZ2sbqlZYMDx8xbCb8oL3SogN7286YDTZjrvQ==", "980bcd71-184f-44f7-87f9-dbd5c8f93cab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56e028cc-47c2-48b9-80ec-1f00cc1ed1da", "AQAAAAIAAYagAAAAEN7bvyGrFj6ropIiKVMT1brdEVK2vutuGPCFje3EacwbBqd9DOw7DDlRkkWt4eOn2Q==", "9ad8fa02-9c3e-4b36-85a4-a00b0b80f750" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "CardId",
                table: "NfcCards",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
    }
}
