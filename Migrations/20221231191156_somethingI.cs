using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class somethingI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7810e43e-3f61-4751-8eb2-3298a05aaf6a", "AQAAAAIAAYagAAAAEDY8y1m101HOms9x9IEpx4ijFpdiYQrHdmsobuHoO91ohYq9Futc/9NrSJW3A+nFsA==", "07bb5a01-52e0-4484-9b09-dcb648eee581" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9773de71-1a77-45fa-a85e-5a9a6e23b544", "AQAAAAIAAYagAAAAEJlA4W5E4LBBstxAkz8IdmeA8w6IDkB9IIq2+zOtyTKz3v9zLK8jMoII0NF1w2CiFQ==", "d93b57a8-5345-4e83-962f-4aa6e50a5d5f" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 12, 31, 20, 11, 56, 288, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 12, 31, 20, 11, 56, 288, DateTimeKind.Local).AddTicks(1075));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
