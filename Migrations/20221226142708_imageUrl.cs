using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class imageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imageUrl",
                table: "Playlist",
                type: "TEXT",
                nullable: true);

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
                columns: new[] { "Created", "imageUrl" },
                values: new object[] { new DateTime(2022, 12, 26, 15, 27, 8, 634, DateTimeKind.Local).AddTicks(1238), null });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 687654,
                columns: new[] { "Created", "imageUrl" },
                values: new object[] { new DateTime(2022, 12, 26, 15, 27, 8, 634, DateTimeKind.Local).AddTicks(1178), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageUrl",
                table: "Playlist");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e11c3417-6a4f-46de-882f-d96a25177765", "AQAAAAIAAYagAAAAEAA3irX6JRv9gEIR0zpRjh/V7p8ILHTuSrTMp1Nkv3s8p0NSLDo+e2U/7j7BsjVXzA==", "69310e84-6699-487c-a4c1-25a63d7f737c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8eac1bf2-082d-4009-92d9-5948f271d813", "AQAAAAIAAYagAAAAEHLRrYwact+JldOR8O9t4WbgPsK97CoC4VsKp/zPX84sjN3/WtOPr/Oh021FI0aM5A==", "cde95d24-23fa-460d-af2b-100dbef6c6c6" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 12, 15, 13, 11, 42, 288, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 687654,
                column: "Created",
                value: new DateTime(2022, 12, 15, 13, 11, 42, 288, DateTimeKind.Local).AddTicks(4048));
        }
    }
}
