using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class changesBestie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 687654);

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
                keyValue: 2,
                columns: new[] { "Created", "Title", "Url" },
                values: new object[] { new DateTime(2022, 12, 26, 15, 48, 33, 572, DateTimeKind.Local).AddTicks(3475), "Random Bangers", "https://open.spotify.com/playlist/5B7ufrrkY8vfaFIjCQSGDy?si=1094cf73fb954010" });

            migrationBuilder.InsertData(
                table: "Playlist",
                columns: new[] { "Id", "Created", "Title", "Url", "UserId", "imageUrl" },
                values: new object[] { 1, new DateTime(2022, 12, 26, 15, 48, 33, 572, DateTimeKind.Local).AddTicks(3407), "Feeling Cozy", "https://open.spotify.com/playlist/1t7Mlal8U3EkGA1KjVtWPg?si=0350ceb077104333x", "9bd1471a-b7db-4578-92f9-81fa4346f6d4", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec1f777c-4261-465f-9b5b-31fb796306bc", "AQAAAAIAAYagAAAAELj/siEUbGTCirZpkSQKzohrarKUyVxEZYEOb5X77la8QePdu6p+V1J5f3dEHNTsiA==", "1079a380-b691-4bfd-8212-0933173ec13d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f91ae033-a14e-4e10-b10d-4bb68188d59d", "AQAAAAIAAYagAAAAEKq+iXiyCnJULrk7Z2TZAYjlGqBvfPGbUFbtQUxI1VSAL5ZEgGBQjuv0bKTMPKuNHA==", "8853aed4-19d6-4089-8738-3c937fb3d0d7" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Title", "Url" },
                values: new object[] { new DateTime(2022, 12, 26, 15, 27, 8, 634, DateTimeKind.Local).AddTicks(1238), "plalylist no 2", "This is playlist 2" });

            migrationBuilder.InsertData(
                table: "Playlist",
                columns: new[] { "Id", "Created", "Title", "Url", "UserId", "imageUrl" },
                values: new object[] { 687654, new DateTime(2022, 12, 26, 15, 27, 8, 634, DateTimeKind.Local).AddTicks(1178), "plalylist no 1", "This is playlist 1", "9bd1471a-b7db-4578-92f9-81fa4346f6d4", null });
        }
    }
}
