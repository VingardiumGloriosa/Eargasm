using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class commooooooooooooon : Migration
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
                values: new object[] { "5ffe25be-ee25-46cb-a712-2a68058dae3c", "AQAAAAIAAYagAAAAEMyj368e3glZeyfKG8wWAJ3HA41hh9pniCfzCIruIpceUSTun5d+TkYMJ0ZaG4QYcw==", "2259378d-feff-4a79-b19e-539cb85c5edd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f529f9f2-0800-46e1-a77d-51dac9f571a4", "AQAAAAIAAYagAAAAEGLFh2S1wVS9i6B1LagBjToW27i/GOOCC4pIaJBiMNpPtBp1J8zvmQuFgm0D13ad4w==", "6ef5a771-0c97-4051-8d76-3145801dc632" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Playlist",
                columns: new[] { "Id", "Created", "Title", "Url", "UserId" },
                values: new object[] { 687654, new DateTime(2022, 12, 12, 22, 13, 11, 110, DateTimeKind.Local).AddTicks(4927), "plalylist no 1", "This is playlist 1", "9bd1471a-b7db-4578-92f9-81fa4346f6d4" });
        }
    }
}
