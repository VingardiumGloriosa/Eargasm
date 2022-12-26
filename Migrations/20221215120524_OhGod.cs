using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class OhGod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad71a070-3fb4-42b3-9867-68eb8e5d8333", "AQAAAAIAAYagAAAAEDvJUO/tisF7JbwTgdDR1fuktZzY2uboaFHo4D5qscNXEJWyWFqBNndvDnUGLikH7A==", "548b3167-44da-47ae-a66f-e1775f740a31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e03f6830-b4b9-4a6a-9cfa-f1f719dfd5a7", "AQAAAAIAAYagAAAAENtSJ+NalDYodB4Wwe/PNQ3XXyUDlmkzpP7xq5jeW+9NxRrjzDIg8wWAoQs+xl4/QQ==", "280698b4-ead7-4143-81c8-03404f362961" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
