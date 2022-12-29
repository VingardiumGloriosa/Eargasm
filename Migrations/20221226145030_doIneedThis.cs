using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class doIneedThis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Playlist",
                columns: new[] { "Id", "Created", "Title", "Url", "UserId", "imageUrl" },
                values: new object[] { 3, new DateTime(2022, 12, 26, 15, 50, 30, 397, DateTimeKind.Local).AddTicks(1487), "Heavy Leg Day", "https://open.spotify.com/playlist/0az16dieCF3dhJZmsCCUSb?si=bc1d022017e54189", "9bd1471a-b7db-4578-92f9-81fa4346f6d4", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7114bfb4-d8e1-4c50-add6-fdfd18ac18bd", "AQAAAAIAAYagAAAAEC4Z4j5jKxYh8JQ8mzNdvE1NHYxcAinCLDkUQnPKDNChLV3f1GcT0RqTe7vOVI7jMg==", "732729fe-249c-4dc5-8ec0-cd693275f05b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b065559a-2fd4-4a66-9950-2fc0dd1d1408", "AQAAAAIAAYagAAAAEAiZ7aobXjrtiipwyF0UXlF5T2R/jh9dYzyesKAYGkHAafbhALfQfC2avBPRmXLP3w==", "8112a3a7-01d4-4a2f-95d4-c47864fa8340" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 12, 26, 15, 48, 33, 572, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 12, 26, 15, 48, 33, 572, DateTimeKind.Local).AddTicks(3475));
        }
    }
}
