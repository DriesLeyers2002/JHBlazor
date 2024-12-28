using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeugdhuis.Migrations
{
    /// <inheritdoc />
    public partial class AddBalance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71d0b81e-cf6f-4e63-8f4a-22f7f9b24f2d", "AQAAAAIAAYagAAAAEM4/zuhCjyu9hXE43+DraLdoeqAggfd4zK02wPTZqNKxtU/+PjKttgim/iCNK1PjWg==", "09c3ce57-5af0-4300-8f28-04676943eb77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc8537b6-8554-482c-9b29-48fb42b69315", "AQAAAAIAAYagAAAAEGe4ElLyyE67CnDYmfesE9iEhOcZr5LrI0nVCKr5vtdk1AwvZfqLARtjCWdk6695ng==", "40224fee-a419-4f76-8c7a-a3e39b2db0a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fe1e1d8-7b1c-4531-b43d-0965e0fd7fda", "AQAAAAIAAYagAAAAECIwXf0sUtjn9IimHZ7KA1bdQ7SICW/b4ubRgHqBefNV4vK5jZVkCXlyiILPmeu82A==", "cb71e7ca-db94-47c0-b0fc-418ab718353c" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Color", "Name" },
                values: new object[] { 7, "#13fc03", "balans" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e9852fc-c2e9-43eb-badf-09311b9100b3", "AQAAAAIAAYagAAAAEAuGwpdyn7BHgyFle8yxBYYtHdQXQOWVtN+LyWROOf2F0F1a3sEuKV6OE1TEU75BTw==", "0cc83152-da6e-4fd6-82c9-25013a0f33cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "450b563a-03ce-485b-9130-b601d0d35b8b", "AQAAAAIAAYagAAAAEMxSd0ZBAoul1XCkcX4NutoLXvHULnZ2sbqlZYMDx8xbCb8oL3SogN7286YDTZjrvQ==", "980bcd71-184f-44f7-87f9-dbd5c8f93cab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56e028cc-47c2-48b9-80ec-1f00cc1ed1da", "AQAAAAIAAYagAAAAEN7bvyGrFj6ropIiKVMT1brdEVK2vutuGPCFje3EacwbBqd9DOw7DDlRkkWt4eOn2Q==", "9ad8fa02-9c3e-4b36-85a4-a00b0b80f750" });
        }
    }
}
