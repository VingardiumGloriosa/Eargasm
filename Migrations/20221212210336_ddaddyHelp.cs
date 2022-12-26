using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class ddaddyHelp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Playlist",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a32622aa-1f4a-4563-9a14-6f3c86ac7e0b", "AQAAAAIAAYagAAAAEC21PynLgurDnId5lGiNJZeyo0oQblHtm4mK7OmAHF/zHGw3rdWoCM2MBhgopKZl+w==", "99663969-50f7-47ee-a832-f3401680ee78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee515b75-36a7-4914-8644-1ab3066e4c72", "AQAAAAIAAYagAAAAEBdUwUkBT2dlP0Fuw8II3CrzcabedJoxcD5s70yG/SV1FnZrQ5sc/o0qJWVvEdWoPw==", "0e7ad934-55c9-434c-95dd-1ebff4becf0d" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 687654,
                columns: new[] { "Created", "UserId" },
                values: new object[] { new DateTime(2022, 12, 12, 22, 3, 36, 690, DateTimeKind.Local).AddTicks(487), "9bd1471a-b7db-4578-92f9-81fa4346f6d4" });

            migrationBuilder.CreateIndex(
                name: "IX_Playlist_UserId",
                table: "Playlist",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Playlist_AspNetUsers_UserId",
                table: "Playlist",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlist_AspNetUsers_UserId",
                table: "Playlist");

            migrationBuilder.DropIndex(
                name: "IX_Playlist_UserId",
                table: "Playlist");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Playlist");

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
    }
}
