using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class addRoleHuurder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22c61f62-b2fb-4727-b4b9-d6fadb85a8a9", "AQAAAAIAAYagAAAAEBCj44w9dVW9IhXOJO88yBCuoD26vP6GmBobL0ycNhjYBL/+KY36adSY3vl3vLVkCw==", "d34e05c8-eda4-4c33-9d95-01f24a07da13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9696758e-e387-4625-a1c0-3c43d42ea1b8", "AQAAAAIAAYagAAAAEJyqMhwAmFs7GP6yJXLTdASng1KGpvxg2MtDm5vkoYi/4KLaJTICt3b+PTkzcd3D0w==", "8a575d27-0abb-4875-a7e6-f1e321e35b41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "535168f3-f45f-4f1c-a52b-b095adb21781", "AQAAAAIAAYagAAAAEO1/GSMfN2tTCYJtN1Hsod17S7CRyOEAYDxuWPCPqgOzg+Pq8G0aa1gMggzx++WIVg==", "bce6cd1e-78de-41d3-8830-e18291076194" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
