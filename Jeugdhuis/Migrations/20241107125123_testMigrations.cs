using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class testMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be0011a7-a2f5-4657-9fc8-fe2ed41c0507", "AQAAAAIAAYagAAAAECHbtslcTOW6JbIkWrPRVwNL+O1GAu2tdMI11CNRTshvnrLDOZxE2r9FqxPkWmq9LQ==", "f4ccd357-bffb-4dae-ab64-0b7621902902" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "328162ff-afd9-4bdd-8bc0-b9cea105abe5", "AQAAAAIAAYagAAAAEAxjaJL2Rjx1lFvCUQ/1SN9mZ2gRZQIbZDvzFmlLURQj0Ps0vG3Nh+V7OUQlyz7srw==", "aef76a7a-46ca-4f74-90ca-47998415250e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfc77e2b-94b5-467e-9ff0-7a26cc9fb831", "AQAAAAIAAYagAAAAEDS3n7nH3tHl4NZHvzV75OQ1CkfLO9iiT9tSNQl4PQZpQ01yb69IFyOv6p9nLmJY9A==", "479f8efc-c411-410f-ae37-ccd39984b716" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e70073f-29a0-48bd-aab6-623f95c40e97", "AQAAAAIAAYagAAAAEPcXKC8VqQvaib4C1qLzbidFJ76LRynn1iveaDJ99MZuZ65ECUccokeBMtlVR6n2yg==", "b1a70587-f522-4332-b19a-2f6cca2f4a34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ae39bb9-a02d-4330-bce8-2467182579f0", "AQAAAAIAAYagAAAAEIXpYEZSKbItUPrqUlxdFdDtYq1491JFadtqbvBSZj2/K0OjiZy/FX01BEyr2LDdcQ==", "44d3fefb-55d3-46c7-a3d2-eb3eb09dee7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "519d895b-57d4-4e54-9464-0940bcdfba16", "AQAAAAIAAYagAAAAEEWTRE3QKDEex8Er4t/8J+ef42aWFF49QYxlgc1fEriOTUYwwWRXgBAkfddsHHYl7Q==", "0f39dfca-db49-4d90-b98e-69a8d8172765" });
        }
    }
}
