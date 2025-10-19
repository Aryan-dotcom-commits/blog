using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    adminId = table.Column<Guid>(type: "uuid", nullable: false),
                    adminName = table.Column<string>(type: "text", nullable: false),
                    adminEmail = table.Column<string>(type: "text", nullable: false),
                    adminPassword = table.Column<string>(type: "text", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.adminId);
                });

            migrationBuilder.CreateTable(
                name: "AdminProfiles",
                columns: table => new
                {
                    profileId = table.Column<Guid>(type: "uuid", nullable: false),
                    adminId = table.Column<Guid>(type: "uuid", nullable: false),
                    DOB = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    TargetWeight = table.Column<int>(type: "integer", nullable: false),
                    ActivityLevel = table.Column<int>(type: "integer", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminProfiles", x => x.profileId);
                    table.ForeignKey(
                        name: "FK_AdminProfiles_Admins_adminId",
                        column: x => x.adminId,
                        principalTable: "Admins",
                        principalColumn: "adminId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Calories",
                columns: table => new
                {
                    CalorieId = table.Column<Guid>(type: "uuid", nullable: false),
                    TotalCaloriesConsumed = table.Column<int>(type: "integer", nullable: false),
                    TotalCaloriesBurned = table.Column<int>(type: "integer", nullable: false),
                    NetCalories = table.Column<int>(type: "integer", nullable: false),
                    logDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastCalorieUpdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    adminId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calories", x => x.CalorieId);
                    table.ForeignKey(
                        name: "FK_Calories_Admins_adminId",
                        column: x => x.adminId,
                        principalTable: "Admins",
                        principalColumn: "adminId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseLogs",
                columns: table => new
                {
                    exerciseLogId = table.Column<Guid>(type: "uuid", nullable: false),
                    exerciseName = table.Column<string>(type: "text", nullable: false),
                    bodyPart = table.Column<int>(type: "integer", nullable: false),
                    TotalSets = table.Column<int>(type: "integer", nullable: false),
                    RepsPerSet = table.Column<int>(type: "integer", nullable: false),
                    TotalReps = table.Column<int>(type: "integer", nullable: false),
                    DurationInMinues = table.Column<int>(type: "integer", nullable: false),
                    CaloriesBurned = table.Column<int>(type: "integer", nullable: false),
                    exerciseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    adminId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseLogs", x => x.exerciseLogId);
                    table.ForeignKey(
                        name: "FK_ExerciseLogs_Admins_adminId",
                        column: x => x.adminId,
                        principalTable: "Admins",
                        principalColumn: "adminId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodLogs",
                columns: table => new
                {
                    FoodId = table.Column<Guid>(type: "uuid", nullable: false),
                    FoodName = table.Column<string>(type: "text", nullable: false),
                    FoodCategory = table.Column<int>(type: "integer", nullable: false),
                    FoodQuantities = table.Column<int>(type: "integer", nullable: false),
                    CaloriesPerUnit = table.Column<int>(type: "integer", nullable: false),
                    TotalCalories = table.Column<int>(type: "integer", nullable: false),
                    Protein = table.Column<int>(type: "integer", nullable: true),
                    Carbs = table.Column<int>(type: "integer", nullable: true),
                    Fats = table.Column<int>(type: "integer", nullable: true),
                    LogDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    adminId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodLogs", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_FoodLogs_Admins_adminId",
                        column: x => x.adminId,
                        principalTable: "Admins",
                        principalColumn: "adminId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeightLogs",
                columns: table => new
                {
                    heightLogId = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrentHeight = table.Column<int>(type: "integer", nullable: false),
                    HeightUnit = table.Column<int>(type: "integer", nullable: false),
                    adminId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeightLogs", x => x.heightLogId);
                    table.ForeignKey(
                        name: "FK_HeightLogs_Admins_adminId",
                        column: x => x.adminId,
                        principalTable: "Admins",
                        principalColumn: "adminId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeightLogs",
                columns: table => new
                {
                    weightLogId = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrentWeight = table.Column<int>(type: "integer", nullable: false),
                    WeightUnit = table.Column<int>(type: "integer", nullable: false),
                    IsGoalAchieved = table.Column<bool>(type: "boolean", nullable: false),
                    loggedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    adminId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightLogs", x => x.weightLogId);
                    table.ForeignKey(
                        name: "FK_WeightLogs_Admins_adminId",
                        column: x => x.adminId,
                        principalTable: "Admins",
                        principalColumn: "adminId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminProfiles_adminId",
                table: "AdminProfiles",
                column: "adminId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calories_adminId",
                table: "Calories",
                column: "adminId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseLogs_adminId",
                table: "ExerciseLogs",
                column: "adminId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodLogs_adminId",
                table: "FoodLogs",
                column: "adminId");

            migrationBuilder.CreateIndex(
                name: "IX_HeightLogs_adminId",
                table: "HeightLogs",
                column: "adminId");

            migrationBuilder.CreateIndex(
                name: "IX_WeightLogs_adminId",
                table: "WeightLogs",
                column: "adminId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminProfiles");

            migrationBuilder.DropTable(
                name: "Calories");

            migrationBuilder.DropTable(
                name: "ExerciseLogs");

            migrationBuilder.DropTable(
                name: "FoodLogs");

            migrationBuilder.DropTable(
                name: "HeightLogs");

            migrationBuilder.DropTable(
                name: "WeightLogs");

            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
