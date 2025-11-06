using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeightLogs_Admins_adminId",
                table: "WeightLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeightLogs",
                table: "WeightLogs");

            migrationBuilder.RenameTable(
                name: "WeightLogs",
                newName: "WeightLog");

            migrationBuilder.RenameIndex(
                name: "IX_WeightLogs_adminId",
                table: "WeightLog",
                newName: "IX_WeightLog_adminId");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentWeight",
                table: "WeightLog",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "WeightLog",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeightLog",
                table: "WeightLog",
                column: "weightLogId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeightLog_Admins_adminId",
                table: "WeightLog",
                column: "adminId",
                principalTable: "Admins",
                principalColumn: "adminId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeightLog_Admins_adminId",
                table: "WeightLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeightLog",
                table: "WeightLog");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "WeightLog");

            migrationBuilder.RenameTable(
                name: "WeightLog",
                newName: "WeightLogs");

            migrationBuilder.RenameIndex(
                name: "IX_WeightLog_adminId",
                table: "WeightLogs",
                newName: "IX_WeightLogs_adminId");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentWeight",
                table: "WeightLogs",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeightLogs",
                table: "WeightLogs",
                column: "weightLogId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeightLogs_Admins_adminId",
                table: "WeightLogs",
                column: "adminId",
                principalTable: "Admins",
                principalColumn: "adminId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
