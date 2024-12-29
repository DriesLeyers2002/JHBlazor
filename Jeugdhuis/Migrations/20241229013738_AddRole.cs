using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class AddRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02f407f8-9a5b-422d-8a66-d62589110bb8", "AQAAAAIAAYagAAAAEE0WCcH7kDoOx7PiGJFXy8ZAVDdY+moxfXQ0sSaILTMbJB29ET9ZoYPfJzqGRZ5L+Q==", "05e3918d-744e-44eb-8464-a1fd0691e25c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f097449-3843-4394-b95f-a8f08c4d7fdc", "AQAAAAIAAYagAAAAEA/3gTsG130zafPLjl+iZAWlxWatL59/3YWX6gNs8WhV0RKyV7HwiwvK4AAqMCNSpg==", "8a55e781-b22e-4270-ba1a-87a94025015a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d597771c-0d70-4c34-a904-cba2ec839932", "AQAAAAIAAYagAAAAEMv7AcL5A2Hx/v219W+m+ANwFZXSOuAQMwDXA4OUhcCo3N+YI1t2Loy2OzGHuJqijQ==", "fd46d2d0-ba11-43c7-b44f-34c9ca03d9b4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d09814a-22da-42de-8cf5-ba13be8973cb", "AQAAAAIAAYagAAAAEOfsmhhTTM2trB5dyewQ/yLyE8cAhwyiXgVnQ4dY3wEfynngQo03UOKSLtYcUUIneQ==", "6c0504ce-a1dc-480b-9ac6-52ec251a03bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c84816e5-6ce3-437a-bc51-c31936bbaa8d", "AQAAAAIAAYagAAAAEGq8Z9ba77b0ZvwkIA8kOjj8AljLmmWpLN9bM0Ia6Tf2MMUySWu2h+7Osykzl9m/yw==", "47e42b0b-7d26-488b-b152-5a07384675ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e80c875-0ac1-49d2-875b-f01fa163ded4", "AQAAAAIAAYagAAAAEKagRswAW7l/FvulFCpd3AGt9WKFBOBXcvvrP4O3QUugCNo0DUQzy8vKWUvoBxvuqw==", "6e746b12-cfa7-4524-8ddd-904eecf58322" });
        }
    }
}
