using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class AddLidPhoneNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35fe316c-06a7-4b80-a6bb-c84c50a05248", "AQAAAAIAAYagAAAAEPokb2wgK3xnynTB6x+0gfsuQkOuV++hba7NtwrXzIVtow3Bf1/3BcK5jQsIM311kw==", "c140d403-c425-46f8-a9d4-e42842aadce5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "caf5d8d2-80d8-4989-8444-51e7da000507", "AQAAAAIAAYagAAAAELSciYaLsT8PV4nYjsmncYvgRj9kmx9uB156h3uAfYXBuGuqN750Gv7b2zlRES9TUw==", "8510b940-fa5f-4d41-999a-fa3fcf205b68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "416d941e-c9bd-4f1b-b84d-f89ffff5883e", "AQAAAAIAAYagAAAAEHMzqsMBNS/PQWf6jj+78CYhwFv+zyIGdOnOZA8TGOrah/YMgqfwg2GrXTKOdIgkgQ==", "313930da-9251-404d-beff-e8960adb7c94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "123456789");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhoneNumber",
                value: "123456789");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhoneNumber",
                value: "123456789");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

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
    }
}
