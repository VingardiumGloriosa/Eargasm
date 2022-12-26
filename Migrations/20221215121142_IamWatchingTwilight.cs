using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class IamWatchingTwilight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Playlist",
                columns: new[] { "Id", "Created", "Title", "Url", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 12, 15, 13, 11, 42, 288, DateTimeKind.Local).AddTicks(4114), "plalylist no 2", "This is playlist 2", "9bd1471a-b7db-4578-92f9-81fa4346f6d4" },
                    { 687654, new DateTime(2022, 12, 15, 13, 11, 42, 288, DateTimeKind.Local).AddTicks(4048), "plalylist no 1", "This is playlist 1", "9bd1471a-b7db-4578-92f9-81fa4346f6d4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 687654);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90d51a2a-68e1-491a-9961-c3b9c32452ba", "AQAAAAIAAYagAAAAEDkcSURc3Biez9F54p7/L0MEJdCPJi30qR5460fW2PUXlpS1q2fKC9k8NfsBJtJIjg==", "2dffbefc-b09b-4123-8885-538d0d910809" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5106f74-1211-4e9a-b811-0b42127a9787", "AQAAAAIAAYagAAAAEE8EM2YYERFlIc4gd+16B/BqvIcakK9/pyF2q4UP0XU6zgLMUB7K5GQR+RE/rEF+SA==", "d5fbcfbf-1d13-44d7-8d2f-1ab653e10269" });
        }
    }
}
