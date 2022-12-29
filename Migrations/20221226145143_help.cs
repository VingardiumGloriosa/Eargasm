using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class help : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "166dc545-1152-454c-a426-b98beeffbc52", "AQAAAAIAAYagAAAAENs/C27dhtqGDLb4Zn59dZy3q1t2PvfZ/IpcCSqNM8dGlml+dOKdRBSuvb+DWAEdfA==", "ab6eb28c-c899-4be9-8bf6-1679827e56c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc88f4b0-2cb5-4125-837c-cb7924ba1b02", "AQAAAAIAAYagAAAAEEcCjOLQbn8rSThpGHIQvwNnenlDdyHzT2jIn6hZjCOTZ1akkRAzEvTCpvPhpc39pQ==", "9f84cd21-08aa-4c1d-a2a4-004112af6bdc" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 12, 26, 15, 51, 42, 852, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 12, 26, 15, 51, 42, 852, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 12, 26, 15, 51, 42, 852, DateTimeKind.Local).AddTicks(4348));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61d600c4-1f40-4feb-8fd2-365c18c117ca", "AQAAAAIAAYagAAAAEM8IsnkWvnP3WHYYBEe7RCy8qIf6TV3+Mq9NWGGRvd5q52y0NZXU6PAfN8MdEoXjQQ==", "57ddef62-c9c0-4c3f-a3dd-8efb533c8a57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bb9d27a-0814-44c9-814c-c4bbe21a6418", "AQAAAAIAAYagAAAAEJNZ8apKgMN8NCtlLKytg2sYB11oeYyrjVovHFT2kBD9R7mqOqOEkVIZ8qeurNRJcw==", "7f2412dd-f7d2-4f03-94a0-7aecfa9b92a3" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 12, 26, 15, 50, 30, 397, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 12, 26, 15, 50, 30, 397, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 12, 26, 15, 50, 30, 397, DateTimeKind.Local).AddTicks(1487));
        }
    }
}
