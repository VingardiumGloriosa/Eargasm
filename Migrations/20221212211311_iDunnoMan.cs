using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class iDunnoMan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a95ef3b6-ecd4-4f05-96b2-14d608511f37", "AQAAAAIAAYagAAAAEAuP+hgKHi9sWbBNHWU6cqSTeOsKFIcjAgtrS1t5eukQKcGKle7vmMw11eOmS8hP+Q==", "27319aac-c915-4651-94f5-09e6627f9e50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbd6848a-b8a3-4aaa-98d7-e5368ffe75ec", "AQAAAAIAAYagAAAAEBIM8P6hlsreqo5+6o7Dys2qfqQwNhaET4LI9PN0ty0U7Ft3Q8AxWp6NEjeJ1tUKMg==", "3fdb522a-d6fb-47db-92e6-177cb9fbab41" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 687654,
                column: "Created",
                value: new DateTime(2022, 12, 12, 22, 13, 11, 110, DateTimeKind.Local).AddTicks(4927));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb46892c-8fba-441a-96e8-25d966060301", "AQAAAAIAAYagAAAAEHYNNt3+y0b9dyaodYzSMsEX+IdCvB6PAVwYRA/Rw7bLiLNVLp4fnKcAGLc7X/055g==", "98df0c3f-5a89-48e9-9467-c6d5635b1842" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92aeb78c-1336-425e-a6bb-317fe5165fcd", "AQAAAAIAAYagAAAAEOECPg79n6abi9l3uMrjI3gg5KGo9DXpgEH1dxxqnr9/mAw3Z8J5cxxl9j2so33vGw==", "8becd3fd-727b-4d56-ac5b-2676328d7fa8" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 687654,
                column: "Created",
                value: new DateTime(2022, 12, 12, 22, 8, 35, 251, DateTimeKind.Local).AddTicks(7907));
        }
    }
}
