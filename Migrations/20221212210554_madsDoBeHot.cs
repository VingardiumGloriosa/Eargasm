using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class madsDoBeHot : Migration
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
                column: "Created",
                value: new DateTime(2022, 12, 12, 22, 3, 36, 690, DateTimeKind.Local).AddTicks(487));

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
