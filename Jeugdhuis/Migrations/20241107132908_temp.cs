using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class temp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c5bc195-9b5c-4080-bfac-e0283088b769", "AQAAAAIAAYagAAAAEGjOOmg4BLUt5Em1q7Cwmxf0bhonej4X8H8hB7f75FiZMk1Vu5HkmTKDwshLojFgoQ==", "2dd709db-9092-4f0f-a3ce-d745aed119a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3e9a97d-de64-465a-8d45-0deab6c36fe4", "AQAAAAIAAYagAAAAEDHOKDJ6nudZnt/D/C5o8lzi/gHhJY+xYm4uzhL8jKWuctIECQOMGQkEcaTMw8k48Q==", "4c08d8b6-ad1e-40fd-848c-6a2166d946d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f10ce15e-6e37-4d6c-8c91-71ce3a48de4f", "AQAAAAIAAYagAAAAEA2d32o5sV1EX/Js/BH75I0/FfMV8AC8ci96Hns68auM/jyt19O5x5zv0El5A474Mw==", "96a41fdd-cf60-49b1-a8e3-2c1ed58f876c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
