using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class FixedTypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsOnlyAtPart",
                table: "Drinks",
                newName: "IsOnlyAtParty");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsOnlyAtParty",
                table: "Drinks",
                newName: "IsOnlyAtPart");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "198310fa-ca81-4b5f-b922-dd96ba71f0a2", "AQAAAAIAAYagAAAAELETKnI8fVbzkcVsPO5o3DmAKDamlNgPlm5kSq/ez+o7APPNk6p+ywXrcgDyMsOMqw==", "e9a7491f-1e8a-45af-a67b-c86ce77d4264" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96cf0ef4-d6f7-47c3-ac68-ebd8925246f9", "AQAAAAIAAYagAAAAEFnVY+OVRn7+zTZjayoDu4LvHZeEKeIeI2jg3cgk+zkQUqNQAriqCT7BFems2y+u2g==", "d1558f28-2931-476b-a121-8b31ccbbdcab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0cbc07a-7442-4a6c-b516-46d72593b527", "AQAAAAIAAYagAAAAEP8EUvleR6k5vfNjOGtpTchoW1o36B/A4tr/E/Swsdo2/k/t6CxAGX+OQfMaJ7Jgzw==", "00b595a2-8e1c-4d3a-94e5-8271a90f8e58" });
        }
    }
}
