using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedingAdmins : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "adminId",
                keyValue: new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "adminId", "adminEmail", "adminName", "adminPassword", "createdAt" },
                values: new object[] { new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"), "aryanpradhan773@gmail.com", "Aryan", "aryan", new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Utc) });
        }
    }
}
