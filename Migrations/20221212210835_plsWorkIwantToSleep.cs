using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class plsWorkIwantToSleep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0028514a-76ee-493a-901f-6319a2196934", "AQAAAAIAAYagAAAAEAsC8mReTlD5MSKCqkNYJaX2iD3Y5O1NebjpdCqIqtgENwGvVUzOnfXEAIz4hyEtWQ==", "4d528af9-5add-482f-b8f0-c2a63b0e3a9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a9407a3-f0a8-40a4-a162-7db489472434", "AQAAAAIAAYagAAAAEO7cPbTUQJVsCEQk79/lIf2+qe1qVSK3CQ2M03QoOGyqKmdf0Z3GpKrcrjhXXC8pPw==", "e310a89b-b4f8-4e41-ab35-428602e7b1d6" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 687654,
                column: "Created",
                value: new DateTime(2022, 12, 12, 22, 5, 54, 793, DateTimeKind.Local).AddTicks(868));
        }
    }
}
