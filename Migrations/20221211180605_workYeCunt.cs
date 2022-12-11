using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class workYeCunt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d738363-8daa-414d-a9de-c30e4a69cb0c", "AQAAAAIAAYagAAAAENeGNFu6SOIchRXQ68R1IevgYI62OzsaGpeStHaBhwO0X1oaLS8x4vuzolJFwmvcKA==", "571bebd6-e8dc-4346-96c2-7de02389312c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5836514-c282-4801-80c2-cf67460e4c9c", "AQAAAAIAAYagAAAAELS/2gYa1WCWKBIFItfq/rSCqfzFTlVcb2cxnlDXMzU/cY5mf0ZWOOYJ4mI434ffDw==", "e6eb46ce-1499-47a5-b254-1a51ee76457c" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 687654,
                column: "Created",
                value: new DateTime(2022, 12, 11, 19, 6, 5, 800, DateTimeKind.Local).AddTicks(2401));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7079e817-f87c-417a-a48f-a039aa286f19", "AQAAAAIAAYagAAAAEDkoW8gf4J5sQyiJtCj52QM12VPDenpd/P4BdTZAqhHin0I2/jl3JhasQ5bEOGUo1Q==", "3f71d10d-dc82-414f-b0e4-4ab82bc0648a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83fc0e69-961f-4ef0-96f4-e69a607a2da3", "AQAAAAIAAYagAAAAENfpUNZQoH5pTcsy3vR1N8LKIQ3GpQDuuDGmCey+ElAKM4vXtn3BX+N+K3A5pR9Tzw==", "f30caa40-66ef-41a3-aca1-06df4d716b65" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 687654,
                column: "Created",
                value: new DateTime(2022, 12, 11, 19, 4, 57, 668, DateTimeKind.Local).AddTicks(6902));
        }
    }
}
