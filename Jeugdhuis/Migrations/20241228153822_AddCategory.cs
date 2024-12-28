using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class AddCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Color", "Name" },
                values: new object[] { 5, "#D85E5E", "cocktails" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4191c9e-8897-4605-ac12-63ed61b14004", "AQAAAAIAAYagAAAAEDcfg6CIdc+dG/JmZR0OU77ypLJlTC7ibL29OiY6icd3VUjnbSByaJ6xeeN2lshgZA==", "e01e8efc-f964-4309-a2fd-bf8f31877eea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b173c94-4387-4214-b33d-47864a275021", "AQAAAAIAAYagAAAAEBx9J0KD++z1TD+5/q/gPl0mdfiljAHfpaoBNu+VZtCatYIUbKDtF7fjw9vMNRUeIg==", "ffd9fc9f-a322-45a9-aec0-d06f0565322b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e907954c-a8d6-43bc-b5b0-c50e9f5d682c", "AQAAAAIAAYagAAAAED29mjKMnZn6nYN4K3Ks7tMPbd4FvJEppIBQnfLn3XlWOCVUBgfnsuHtqmO/PeVwbw==", "3991e2a1-b77d-4181-90f9-6be1be8f17fc" });
        }
    }
}
