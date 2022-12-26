using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class amIdumb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69f12c64-7522-4219-94c6-e3f7e7e15673", "AQAAAAIAAYagAAAAEBS2NCeoDgGPkNGPDxeiUMv0K+ZBMBq2NP9oxInxwmP2bbbkGYilBFVRjGdV2maW1w==", "8eaaa952-c6fb-4e20-ba53-370c408c49ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12c75f3e-580e-4a9d-bde3-956c35a5981b", "AQAAAAIAAYagAAAAEN23QPGu8kG52jpNJFGCj9fi8n/bswTABnPGsnk+DuyPZwQ1YJFG3L6F8aLRJhGdjA==", "f37bf89a-e663-4d35-afca-44fab1c7d27c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
