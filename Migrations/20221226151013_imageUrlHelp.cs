using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class imageUrlHelp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 2);

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
                columns: new[] { "Created", "imageUrl" },
                values: new object[] { new DateTime(2022, 12, 26, 16, 10, 13, 259, DateTimeKind.Local).AddTicks(5400), "https://i.scdn.co/image/ab67706c0000bebb9e0a4f504a0c39f5452371df" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "imageUrl" },
                values: new object[] { new DateTime(2022, 12, 26, 16, 10, 13, 259, DateTimeKind.Local).AddTicks(5481), "https://mosaic.scdn.co/640/ab67616d0000b273b96b08f972a3f1e925a69fedab67616d0000b273bbdafec608fc5329ec2ad831ab67616d0000b273cd8176d1d53fb8c345375866ab67616d0000b273d2de49f423eb924c79a155d2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Created", "imageUrl" },
                values: new object[] { new DateTime(2022, 12, 26, 15, 52, 41, 406, DateTimeKind.Local).AddTicks(4261), null });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "imageUrl" },
                values: new object[] { new DateTime(2022, 12, 26, 15, 52, 41, 406, DateTimeKind.Local).AddTicks(4420), null });

            migrationBuilder.InsertData(
                table: "Playlist",
                columns: new[] { "Id", "Created", "Title", "Url", "UserId", "imageUrl" },
                values: new object[] { 2, new DateTime(2022, 12, 26, 15, 52, 41, 406, DateTimeKind.Local).AddTicks(4415), "Random Bangers", "https://open.spotify.com/playlist/5B7ufrrkY8vfaFIjCQSGDy?si=1094cf73fb954010", "9bd1471a-b7db-4578-92f9-81fa4346f6d4", null });
        }
    }
}
