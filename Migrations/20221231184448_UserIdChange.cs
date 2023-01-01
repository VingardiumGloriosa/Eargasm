using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class UserIdChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlist_AspNetUsers_UserId",
                table: "Playlist");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Playlist",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4712b16a-e4f5-4685-9951-7ac26164fa25", "AQAAAAIAAYagAAAAELjJaOEiqIXGx5xAP0kfI4ud6Qc8Mm2X01yNws4ZXu5yMkqGEWPM3DQ5sAtsfAKHCw==", "990af3a7-bf92-4a9f-9969-de40a9376acd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2499102-04cf-4788-99e5-3665ffafbb6a", "AQAAAAIAAYagAAAAEI5jgAIOUtAGv/+MCH0kiWSxzpqRAxH/go6C+ALe8QKSn8zwKaD6gYd6+ghuO0++1A==", "6e73b043-f8da-4579-811b-db8bb4069b44" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 12, 31, 19, 44, 48, 592, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 12, 31, 19, 44, 48, 592, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.AddForeignKey(
                name: "FK_Playlist_AspNetUsers_UserId",
                table: "Playlist",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlist_AspNetUsers_UserId",
                table: "Playlist");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Playlist",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d027d01f-4466-4c9c-b21a-9022e16db6f8", "AQAAAAIAAYagAAAAEIz3W3wVkgkPnNbiM7FlrEnhiwcO4CvgnTtln3mlMKaCzZu2j7g7hesY8IOTsy8Ixw==", "e5fa61e0-c7e8-4db5-a97a-89dab7e7506f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0764f4e-b43d-47af-b155-83bf7b3af04e", "AQAAAAIAAYagAAAAELUm4YVx08Cs/6U/E9wWr1BeKpeiQQ4I/Kb7NuY7UfqXvOwYWsMo367/+VL8ONc7hA==", "68f26e9c-0d8c-492c-97a9-ad0e5dee8d8c" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 12, 26, 16, 10, 13, 259, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 12, 26, 16, 10, 13, 259, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.AddForeignKey(
                name: "FK_Playlist_AspNetUsers_UserId",
                table: "Playlist",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
