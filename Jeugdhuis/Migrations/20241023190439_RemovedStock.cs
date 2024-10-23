using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class RemovedStock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockItems_Stocks_StockId",
                table: "StockItems");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_StockItems_StockId",
                table: "StockItems");

            migrationBuilder.DropColumn(
                name: "StockId",
                table: "StockItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ee7c208-b567-4817-9bb9-afdc5e0f5266", "AQAAAAIAAYagAAAAEK5X3i9bLhVEAdp7SrM2+L+eDY6GcwbFBNOpAW0mzcP4x5Fp50AEokj25sH9TbVPrg==", "14fca00c-071d-4f85-8923-9818af661d17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32ae4d57-6c25-4005-9ce0-4640fa6b61c1", "AQAAAAIAAYagAAAAEKW66eJjL00wt4cpTld5EJNm4kN7QrNEvvJHvTbEq3ykfk1pwjyDqz4Iay+hSsQejg==", "12dd6a68-935c-4a25-9a48-7d8845075b98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7115e7b-5a08-4e7f-8f4b-6af0a239a504", "AQAAAAIAAYagAAAAEMF+j4+qtWt4cF6BPPxyh64MCk3NHP+XV4Dw6p2WjQ6Sf0BraPqGoalxdfXsBuGdYQ==", "c705887b-7e59-4f60-aca2-b5c1c3101181" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockId",
                table: "StockItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2387b5d5-b30c-4567-95dc-d277516d0feb", "AQAAAAIAAYagAAAAEH1UY1oJ7ygOpO3iPKm7MSLjtfwT+3p4ZJxEqELfuf04/7vv6Jquhd/GtJAdUfoeOA==", "43d2d9c1-7aca-4ce2-a19b-619d6f8835ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9abf5b9-1555-4051-b1c6-cbe8134f8dfd", "AQAAAAIAAYagAAAAELP+Ge/C1bLzHCNguutbBUgikiZB4rsisN+51ppsL5/vSEomfzDSvzCAVWVpgswUzA==", "5e8f8d5c-b3a4-4eb0-9fa8-b02dc29de40c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b00d019d-e652-481a-b54f-cce121b7112d", "AQAAAAIAAYagAAAAEN841polZ7g3fUFq15G39XRNQazUkWHNq4tnUHFMo1/yvnricMmD09Uj2GvyKp25tg==", "5414376d-6c10-4db7-934a-8f3d7b0b5b9d" });

            migrationBuilder.CreateIndex(
                name: "IX_StockItems_StockId",
                table: "StockItems",
                column: "StockId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockItems_Stocks_StockId",
                table: "StockItems",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
