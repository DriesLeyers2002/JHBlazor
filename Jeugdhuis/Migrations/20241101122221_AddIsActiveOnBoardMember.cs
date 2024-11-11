using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class AddIsActiveOnBoardMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e70073f-29a0-48bd-aab6-623f95c40e97", true, "AQAAAAIAAYagAAAAEPcXKC8VqQvaib4C1qLzbidFJ76LRynn1iveaDJ99MZuZ65ECUccokeBMtlVR6n2yg==", "b1a70587-f522-4332-b19a-2f6cca2f4a34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ae39bb9-a02d-4330-bce8-2467182579f0", true, "AQAAAAIAAYagAAAAEIXpYEZSKbItUPrqUlxdFdDtYq1491JFadtqbvBSZj2/K0OjiZy/FX01BEyr2LDdcQ==", "44d3fefb-55d3-46c7-a3d2-eb3eb09dee7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "519d895b-57d4-4e54-9464-0940bcdfba16", true, "AQAAAAIAAYagAAAAEEWTRE3QKDEex8Er4t/8J+ef42aWFF49QYxlgc1fEriOTUYwwWRXgBAkfddsHHYl7Q==", "0f39dfca-db49-4d90-b98e-69a8d8172765" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Email",
                value: "alica.johnson@example.com");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb227e36-1b50-4c3a-9cfe-f7b42ec27224", "AQAAAAIAAYagAAAAEDU1xR1HSLfg+k71IibP0meVfqmMLmN5Alf7hxAHUp3zwAtzvY3foO3wMXvmpo96Ig==", "652250ff-be08-4810-881f-652d092457ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c220e2b4-bc94-4bbd-b0a9-0a184b821b05", "AQAAAAIAAYagAAAAEOuy61tZmh9VJFTFV8HjQP/3P189oyX1rFIwIZipAXDUL5MnNhgfHak/vQXLaEMZ8g==", "ee88d35e-38a8-4ab2-9fad-cab4d2d08a3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a32f7e8-3a58-4867-ab02-b922b217e4f3", "AQAAAAIAAYagAAAAENy+HxTUODEncnE1xjAyO2DdaEh7BLhQXRsXkYUi38HM7gvAOE+6XjYGfiDbYAOavw==", "7105c039-97c4-42af-a792-eede1c5b3178" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Email",
                value: "alice.There is no entity type mapped to the table 'Boardmembers' which is used in a data operation. Either add the corresponding entity type to the model, or specify the column types in the data operation.ohnson@example.com");
        }
    }
}
