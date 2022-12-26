using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class iNeedToGetSum : Migration
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
                values: new object[] { "c137e702-2951-474f-931b-69e92734ab21", "AQAAAAIAAYagAAAAEGlOC9hb34dsSf22HGEbV82DlK45PVsysdtTtvOLQ4ssEU0N7GixQ4sPiQJob0OSvQ==", "03674fcc-896c-4cf7-b901-3919bee418b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c21c3f0d-14b7-4975-a2f0-05c361ba4b76", "AQAAAAIAAYagAAAAEJNsIT330Unq61b86QCRJAr1Z2tHlA9HmLS4eNLqq5bBZ5LH2SNvqW9lAPujdkCUfQ==", "4d4263ca-fc6f-4dd4-ad55-d55f7b08bb22" });

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
                values: new object[] { "5ffe25be-ee25-46cb-a712-2a68058dae3c", "AQAAAAIAAYagAAAAEMyj368e3glZeyfKG8wWAJ3HA41hh9pniCfzCIruIpceUSTun5d+TkYMJ0ZaG4QYcw==", "2259378d-feff-4a79-b19e-539cb85c5edd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f529f9f2-0800-46e1-a77d-51dac9f571a4", "AQAAAAIAAYagAAAAEGLFh2S1wVS9i6B1LagBjToW27i/GOOCC4pIaJBiMNpPtBp1J8zvmQuFgm0D13ad4w==", "6ef5a771-0c97-4051-8d76-3145801dc632" });

            migrationBuilder.AddForeignKey(
                name: "FK_Playlist_AspNetUsers_UserId",
                table: "Playlist",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
