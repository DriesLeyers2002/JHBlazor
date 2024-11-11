using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Voorzitter", "VOORZITTER" },
                    { "3", null, "Drankmeester", "DRANKMEESTER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8114f420-6e3b-4e73-a3ac-3bd44af93bbc", "AQAAAAIAAYagAAAAEK4ogwgVONfqeQl0Hs0ztSV8Gs25ff+3X8tu3u6hunMTa3XtL4fg3jEcQyZVC1LYLg==", "503f2b44-ed1c-40f3-8255-e6289ae368b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30c4131e-94b9-49c6-9b2f-849125f629a4", "AQAAAAIAAYagAAAAEO1eBVFB85auBcii9iS20GaAsYcHBLyO6hrULd8kVMsrlY412T8jeufYnNXSGBwDOg==", "f3ba9cd7-97eb-46ea-9dba-f22c6c32d4ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "732b565a-09d5-46dc-ae9f-2437d18a797e", "AQAAAAIAAYagAAAAEFXRfs1J3curAATuBpK5cUmlsOuhghymIjoC2kPVPKhRfT9GwWH4tTFwqHmp5uUJzA==", "dd34c197-f524-4d35-a036-5703ee7e87a3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" },
                    { "1", "3" },
                    { "3", "3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Name", "PasswordHash", "Role", "SecurityStamp" },
                values: new object[] { "8ee7c208-b567-4817-9bb9-afdc5e0f5266", "Dries", "AQAAAAIAAYagAAAAEK5X3i9bLhVEAdp7SrM2+L+eDY6GcwbFBNOpAW0mzcP4x5Fp50AEokj25sH9TbVPrg==", "Admin", "14fca00c-071d-4f85-8923-9818af661d17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Name", "PasswordHash", "Role", "SecurityStamp" },
                values: new object[] { "32ae4d57-6c25-4005-9ce0-4640fa6b61c1", "Vincent", "AQAAAAIAAYagAAAAEKW66eJjL00wt4cpTld5EJNm4kN7QrNEvvJHvTbEq3ykfk1pwjyDqz4Iay+hSsQejg==", "Voorzitter", "12dd6a68-935c-4a25-9a48-7d8845075b98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Name", "PasswordHash", "Role", "SecurityStamp" },
                values: new object[] { "c7115e7b-5a08-4e7f-8f4b-6af0a239a504", "Simon", "AQAAAAIAAYagAAAAEMF+j4+qtWt4cF6BPPxyh64MCk3NHP+XV4Dw6p2WjQ6Sf0BraPqGoalxdfXsBuGdYQ==", "Drankmeester", "c705887b-7e59-4f60-aca2-b5c1c3101181" });
        }
    }
}
