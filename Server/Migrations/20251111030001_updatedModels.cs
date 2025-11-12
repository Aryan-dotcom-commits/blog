using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class updatedModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calories_Admins_adminId",
                table: "Calories");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseLogs_Admins_adminId",
                table: "ExerciseLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodLogs_Admins_adminId",
                table: "FoodLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_HeightLogs_Admins_adminId",
                table: "HeightLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_WeightLog_Admins_adminId",
                table: "WeightLog");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.RenameColumn(
                name: "adminId",
                table: "WeightLog",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_WeightLog_adminId",
                table: "WeightLog",
                newName: "IX_WeightLog_userId");

            migrationBuilder.RenameColumn(
                name: "adminId",
                table: "HeightLogs",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_HeightLogs_adminId",
                table: "HeightLogs",
                newName: "IX_HeightLogs_userId");

            migrationBuilder.RenameColumn(
                name: "adminId",
                table: "FoodLogs",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodLogs_adminId",
                table: "FoodLogs",
                newName: "IX_FoodLogs_userId");

            migrationBuilder.RenameColumn(
                name: "adminId",
                table: "ExerciseLogs",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseLogs_adminId",
                table: "ExerciseLogs",
                newName: "IX_ExerciseLogs_userId");

            migrationBuilder.RenameColumn(
                name: "adminId",
                table: "Calories",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Calories_adminId",
                table: "Calories",
                newName: "IX_Calories_userId");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<Guid>(type: "uuid", nullable: false),
                    userName = table.Column<string>(type: "text", nullable: false),
                    userMail = table.Column<string>(type: "text", nullable: false),
                    userPassword = table.Column<string>(type: "text", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DOB = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    TargetWeight = table.Column<int>(type: "integer", nullable: false),
                    ActivityLevel = table.Column<int>(type: "integer", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Calories_Users_userId",
                table: "Calories",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseLogs_Users_userId",
                table: "ExerciseLogs",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodLogs_Users_userId",
                table: "FoodLogs",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HeightLogs_Users_userId",
                table: "HeightLogs",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeightLog_Users_userId",
                table: "WeightLog",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calories_Users_userId",
                table: "Calories");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseLogs_Users_userId",
                table: "ExerciseLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodLogs_Users_userId",
                table: "FoodLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_HeightLogs_Users_userId",
                table: "HeightLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_WeightLog_Users_userId",
                table: "WeightLog");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "WeightLog",
                newName: "adminId");

            migrationBuilder.RenameIndex(
                name: "IX_WeightLog_userId",
                table: "WeightLog",
                newName: "IX_WeightLog_adminId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "HeightLogs",
                newName: "adminId");

            migrationBuilder.RenameIndex(
                name: "IX_HeightLogs_userId",
                table: "HeightLogs",
                newName: "IX_HeightLogs_adminId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "FoodLogs",
                newName: "adminId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodLogs_userId",
                table: "FoodLogs",
                newName: "IX_FoodLogs_adminId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "ExerciseLogs",
                newName: "adminId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseLogs_userId",
                table: "ExerciseLogs",
                newName: "IX_ExerciseLogs_adminId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Calories",
                newName: "adminId");

            migrationBuilder.RenameIndex(
                name: "IX_Calories_userId",
                table: "Calories",
                newName: "IX_Calories_adminId");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    adminId = table.Column<Guid>(type: "uuid", nullable: false),
                    ActivityLevel = table.Column<int>(type: "integer", nullable: false),
                    DOB = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    TargetWeight = table.Column<int>(type: "integer", nullable: false),
                    adminEmail = table.Column<string>(type: "text", nullable: false),
                    adminName = table.Column<string>(type: "text", nullable: false),
                    adminPassword = table.Column<string>(type: "text", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.adminId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Calories_Admins_adminId",
                table: "Calories",
                column: "adminId",
                principalTable: "Admins",
                principalColumn: "adminId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseLogs_Admins_adminId",
                table: "ExerciseLogs",
                column: "adminId",
                principalTable: "Admins",
                principalColumn: "adminId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodLogs_Admins_adminId",
                table: "FoodLogs",
                column: "adminId",
                principalTable: "Admins",
                principalColumn: "adminId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HeightLogs_Admins_adminId",
                table: "HeightLogs",
                column: "adminId",
                principalTable: "Admins",
                principalColumn: "adminId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeightLog_Admins_adminId",
                table: "WeightLog",
                column: "adminId",
                principalTable: "Admins",
                principalColumn: "adminId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
