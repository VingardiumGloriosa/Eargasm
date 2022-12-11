using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eargasm.Migrations
{
    /// <inheritdoc />
    public partial class IWantToDie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7079e817-f87c-417a-a48f-a039aa286f19", "AQAAAAIAAYagAAAAEDkoW8gf4J5sQyiJtCj52QM12VPDenpd/P4BdTZAqhHin0I2/jl3JhasQ5bEOGUo1Q==", "3f71d10d-dc82-414f-b0e4-4ab82bc0648a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83fc0e69-961f-4ef0-96f4-e69a607a2da3", "AQAAAAIAAYagAAAAENfpUNZQoH5pTcsy3vR1N8LKIQ3GpQDuuDGmCey+ElAKM4vXtn3BX+N+K3A5pR9Tzw==", "f30caa40-66ef-41a3-aca1-06df4d716b65" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 687654,
                column: "Created",
                value: new DateTime(2022, 12, 11, 19, 4, 57, 668, DateTimeKind.Local).AddTicks(6902));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5502d0dd-cf79-4c97-87b9-72c61ff36e81", "AQAAAAIAAYagAAAAENsTzJZjGR/PzgkTH/gvV7sk8/TmAsEcL0jdkxDhnqskwSp5Uua7B2VgDfmn1L4RQg==", "be942194-b8ee-4150-bb76-20c0af25c3f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f43e4a9b-1d57-4807-880f-f31fd132a42a", "AQAAAAIAAYagAAAAEEV3eTK1NCkmyvZFCBeg91pudYWenWq5JNazVAE3ni7ZNSxEMuGu0nOTQXDEOFNVQA==", "9fdb4226-dd72-4535-a01e-06f5f16ac66b" });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: 687654,
                column: "Created",
                value: new DateTime(2022, 12, 11, 18, 56, 39, 666, DateTimeKind.Local).AddTicks(3807));
        }
    }
}
