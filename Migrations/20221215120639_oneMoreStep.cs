using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class oneMoreStep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90d51a2a-68e1-491a-9961-c3b9c32452ba", "AQAAAAIAAYagAAAAEDkcSURc3Biez9F54p7/L0MEJdCPJi30qR5460fW2PUXlpS1q2fKC9k8NfsBJtJIjg==", "2dffbefc-b09b-4123-8885-538d0d910809" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5106f74-1211-4e9a-b811-0b42127a9787", "AQAAAAIAAYagAAAAEE8EM2YYERFlIc4gd+16B/BqvIcakK9/pyF2q4UP0XU6zgLMUB7K5GQR+RE/rEF+SA==", "d5fbcfbf-1d13-44d7-8d2f-1ab653e10269" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
