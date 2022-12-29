using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class commoooondude : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4198d256-460f-4c98-9e17-a3a8faf32ccf", "AQAAAAIAAYagAAAAECSodbsFKAxoLKBtQTL9lCKE7rkZSPoKpFR3VWs6cz2b3uVqoNCkHsZ9kH+enjYZSA==", "cfb1bba5-a4d6-46a5-bd1f-783e6ce1c674" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e242ed4c-fdfe-4c97-8673-d357aece2f83", "AQAAAAIAAYagAAAAEDRzbPX517Xjtt7HjqE0cUh0IQHWK7yN6bW9+Ta10vZQncsNthcxrtAeMLFOxyqiJw==", "638ad42e-a2ef-442a-92b6-66eeeb5f60ea" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 12, 26, 15, 52, 41, 406, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 12, 26, 15, 52, 41, 406, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 12, 26, 15, 52, 41, 406, DateTimeKind.Local).AddTicks(4420));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "166dc545-1152-454c-a426-b98beeffbc52", "AQAAAAIAAYagAAAAENs/C27dhtqGDLb4Zn59dZy3q1t2PvfZ/IpcCSqNM8dGlml+dOKdRBSuvb+DWAEdfA==", "ab6eb28c-c899-4be9-8bf6-1679827e56c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc88f4b0-2cb5-4125-837c-cb7924ba1b02", "AQAAAAIAAYagAAAAEEcCjOLQbn8rSThpGHIQvwNnenlDdyHzT2jIn6hZjCOTZ1akkRAzEvTCpvPhpc39pQ==", "9f84cd21-08aa-4c1d-a2a4-004112af6bdc" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 12, 26, 15, 51, 42, 852, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 12, 26, 15, 51, 42, 852, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 12, 26, 15, 51, 42, 852, DateTimeKind.Local).AddTicks(4348));
        }
    }
}
