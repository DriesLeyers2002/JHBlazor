using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class AddDisplayRoleOnBoardmember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
