﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class AddDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allergies",
                columns: table => new
                {
                    AllergyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AllergyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllergyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergies", x => x.AllergyId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Portions",
                columns: table => new
                {
                    PortionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PortionSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortionWeight = table.Column<float>(type: "real", nullable: false),
                    MeasurementUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portions", x => x.PortionId);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    SubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriptionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.SubscriptionId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.RoleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    CertificateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CertificateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.CertificateId);
                    table.ForeignKey(
                        name: "FK_Certificates_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    GoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalType = table.Column<int>(type: "int", nullable: false),
                    WeightGoal = table.Column<int>(type: "int", nullable: false),
                    CaloriesGoal = table.Column<float>(type: "real", nullable: false),
                    ProteinGoal = table.Column<float>(type: "real", nullable: false),
                    CarbGoal = table.Column<float>(type: "real", nullable: false),
                    FatGoal = table.Column<float>(type: "real", nullable: false),
                    FiberGoal = table.Column<float>(type: "real", nullable: false),
                    SugarGoal = table.Column<float>(type: "real", nullable: false),
                    WaterGoal = table.Column<int>(type: "int", nullable: false),
                    ExerciseGoal = table.Column<float>(type: "real", nullable: false),
                    WaterIntakesGoal = table.Column<float>(type: "real", nullable: false),
                    ExerciseDurationGoal = table.Column<float>(type: "real", nullable: false),
                    ExerciseCaloriesGoal = table.Column<float>(type: "real", nullable: false),
                    StepsGoal = table.Column<float>(type: "real", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.GoalId);
                    table.ForeignKey(
                        name: "FK_Goals_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Metrics",
                columns: table => new
                {
                    MetricId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    ActivityLevel = table.Column<float>(type: "real", nullable: false),
                    Bmi = table.Column<float>(type: "real", nullable: false),
                    Bmr = table.Column<float>(type: "real", nullable: false),
                    Tdee = table.Column<float>(type: "real", nullable: false),
                    Ibw = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metrics", x => x.MetricId);
                    table.ForeignKey(
                        name: "FK_Metrics_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ScheduleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Time = table.Column<TimeOnly>(type: "time", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ScheduleId);
                    table.ForeignKey(
                        name: "FK_Schedules_AspNetUsers_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Services_AspNetUsers_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAllergies",
                columns: table => new
                {
                    UserAllergyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AllergyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAllergies", x => x.UserAllergyId);
                    table.ForeignKey(
                        name: "FK_UserAllergies_Allergies_AllergyId",
                        column: x => x.AllergyId,
                        principalTable: "Allergies",
                        principalColumn: "AllergyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAllergies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFoods",
                columns: table => new
                {
                    UserFoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Categories = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Allergies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFoods", x => x.UserFoodId);
                    table.ForeignKey(
                        name: "FK_UserFoods_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterReminders",
                columns: table => new
                {
                    WaterReminderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaterReminderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Volume = table.Column<float>(type: "real", nullable: false),
                    IsRecurring = table.Column<bool>(type: "bit", nullable: false),
                    IsDrunk = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterReminders", x => x.WaterReminderId);
                    table.ForeignKey(
                        name: "FK_WaterReminders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    WorkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkoutName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkoutDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Intensity = table.Column<int>(type: "int", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.WorkoutId);
                    table.ForeignKey(
                        name: "FK_Workouts_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    ExerciseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    CaloriesBurned = table.Column<float>(type: "real", nullable: false),
                    Difficulty = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.ExerciseId);
                    table.ForeignKey(
                        name: "FK_Exercises_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exercises_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MealType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DishType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_Foods_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "UserSubscriptions",
                columns: table => new
                {
                    UserSubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSubscriptions", x => x.UserSubscriptionId);
                    table.ForeignKey(
                        name: "FK_UserSubscriptions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSubscriptions_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "SubscriptionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CertificateImages",
                columns: table => new
                {
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CertificateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateImages", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_CertificateImages_Certificates_CertificateId",
                        column: x => x.CertificateId,
                        principalTable: "Certificates",
                        principalColumn: "CertificateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DailyActivities",
                columns: table => new
                {
                    DailyActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalDuration = table.Column<int>(type: "int", nullable: false),
                    TotalCaloriesBurned = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyActivities", x => x.DailyActivityId);
                    table.ForeignKey(
                        name: "FK_DailyActivities_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DailyActivities_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "GoalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DailyMeals",
                columns: table => new
                {
                    DailyMealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScheduleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TotalCalories = table.Column<float>(type: "real", nullable: false),
                    TotalProteins = table.Column<float>(type: "real", nullable: false),
                    TotalCarbs = table.Column<float>(type: "real", nullable: false),
                    TotalFats = table.Column<float>(type: "real", nullable: false),
                    TotalFibers = table.Column<float>(type: "real", nullable: false),
                    TotalSugars = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyMeals", x => x.DailyMealId);
                    table.ForeignKey(
                        name: "FK_DailyMeals_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "GoalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DailyWaterIntakes",
                columns: table => new
                {
                    DailyWaterIntakeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalVolume = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyWaterIntakes", x => x.DailyWaterIntakeId);
                    table.ForeignKey(
                        name: "FK_DailyWaterIntakes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DailyWaterIntakes_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "GoalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId");
                });

            migrationBuilder.CreateTable(
                name: "WorkoutExercises",
                columns: table => new
                {
                    WorkoutExerciseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutExercises", x => x.WorkoutExerciseId);
                    table.ForeignKey(
                        name: "FK_WorkoutExercises_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkoutExercises_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "WorkoutId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FoodAllergies",
                columns: table => new
                {
                    FoodAllergyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AllergyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodAllergies", x => x.FoodAllergyId);
                    table.ForeignKey(
                        name: "FK_FoodAllergies_Allergies_AllergyId",
                        column: x => x.AllergyId,
                        principalTable: "Allergies",
                        principalColumn: "AllergyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodAllergies_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodPortions",
                columns: table => new
                {
                    FoodPortionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PortionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodPortions", x => x.FoodPortionId);
                    table.ForeignKey(
                        name: "FK_FoodPortions_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodPortions_Portions_PortionId",
                        column: x => x.PortionId,
                        principalTable: "Portions",
                        principalColumn: "PortionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nutritions",
                columns: table => new
                {
                    NutritionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Calories = table.Column<float>(type: "real", nullable: false),
                    Protein = table.Column<float>(type: "real", nullable: false),
                    Carbs = table.Column<float>(type: "real", nullable: false),
                    Fat = table.Column<float>(type: "real", nullable: false),
                    Fiber = table.Column<float>(type: "real", nullable: false),
                    Sugar = table.Column<float>(type: "real", nullable: false),
                    SaturatedFat = table.Column<float>(type: "real", nullable: true),
                    UnsaturatedFat = table.Column<float>(type: "real", nullable: true),
                    Cholesterol = table.Column<float>(type: "real", nullable: true),
                    Sodium = table.Column<float>(type: "real", nullable: true),
                    Potassium = table.Column<float>(type: "real", nullable: true),
                    Calcium = table.Column<float>(type: "real", nullable: true),
                    Iron = table.Column<float>(type: "real", nullable: true),
                    VitaminA = table.Column<float>(type: "real", nullable: true),
                    VitaminB1 = table.Column<float>(type: "real", nullable: true),
                    VitaminB2 = table.Column<float>(type: "real", nullable: true),
                    VitaminC = table.Column<float>(type: "real", nullable: true),
                    VitaminD = table.Column<float>(type: "real", nullable: true),
                    VitaminE = table.Column<float>(type: "real", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutritions", x => x.NutritionId);
                    table.ForeignKey(
                        name: "FK_Nutritions_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DailyActivityWorkout",
                columns: table => new
                {
                    DailyActivityWorkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DailyActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyActivityWorkout", x => x.DailyActivityWorkoutId);
                    table.ForeignKey(
                        name: "FK_DailyActivityWorkout_DailyActivities_DailyActivityId",
                        column: x => x.DailyActivityId,
                        principalTable: "DailyActivities",
                        principalColumn: "DailyActivityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DailyActivityWorkout_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "WorkoutId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DailyMealId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MealType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealId);
                    table.ForeignKey(
                        name: "FK_Meals_DailyMeals_DailyMealId",
                        column: x => x.DailyMealId,
                        principalTable: "DailyMeals",
                        principalColumn: "DailyMealId");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealFoods",
                columns: table => new
                {
                    MealFoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PortionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealFoods", x => x.MealFoodId);
                    table.ForeignKey(
                        name: "FK_MealFoods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealFoods_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "MealId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyDescription", "AllergyName", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0d352b08-ada9-40f6-a23e-6f6f170a9cd4"), "Dị ứng với các loại động vật có vỏ như tôm, cua, và sò.", "Động vật có vỏ", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10127b02-786f-462b-8ee6-3df465903645"), "Dị ứng với hạt vừng(mè), thường gặp trong các món ăn châu Á và Trung Đông.", "Vừng (mè)", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("13008773-dadd-4053-b64c-500b6050b2aa"), "Dị ứng với các loại hạt cây như hạt óc chó, hạt hạnh nhân, và hạt điều.", "Hạt cây", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("16acfb07-feee-4bb9-ad2b-05e5b93d18e6"), "Dị ứng với lúa mì, thường gặp ở những người không dung nạp gluten.", "Lúa mì", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3cd5347e-d38d-425c-af19-e9c4ba2646c6"), "Dị ứng với đậu nành, thường gặp ở trẻ em nhưng cũng có thể xảy ra ở người lớn.", "Đậu nành", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("70fef89b-5b02-4d6c-81e0-40592eefcb2a"), "Dị ứng với trứng gà hoặc trứng của các loài gia cầm khác.", "Trứng", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b82f4697-2ad0-4777-a29b-094c99f46d10"), "Dị ứng với đậu phộng, một trong những nguyên nhân phổ biến nhất gây phản ứng dị ứng nghiêm trọng.", "Đậu phộng", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8f6417e-2aac-442e-aac4-de4d809c572c"), "Dị ứng với hải sản như tôm, cua, sò, ốc, và các loại động vật biển khác.", "Hải sản", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d0127ea2-7f55-4515-b5ea-3db55af5774e"), "Dị ứng với protein trong sữa bò, khác với không dung nạp lactose.", "Sữa bò", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb5cadbb-94e2-4bf9-8764-ddef8779ebd8"), "Dị ứng với cá, bao gồm cả cá biển và cá nước ngọt.", "Cá", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1975eaae-fd39-417e-bfcc-5e09f963b95f"), null, "Quản lí", "Manager", "MANAGER" },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), null, "Khách Hàng", "Member", "MEMBER" },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), null, "Người dùng", "User", "USER" },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), null, "Tư Vấn Viên", "Consultant", "CONSULTANT" },
                    { new Guid("d21edfd6-42d5-490a-a41c-43f7ef09c61f"), null, "Quản trị viên", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 0, null, "eac79c5b-db63-450c-99be-926c47a379a7", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khanhpham@gmail.com", true, "Nguyen Pham Khanh", false, null, "KHANHPHAM@GMAIL.COM", "KUEM113", "AQAAAAIAAYagAAAAEHul5nLx14xmqGtgrdYF2S3dOmg21XJdFCVH0cziM5RV61zvGo2mOMJKeQXftC/OAQ==", "0969998878", false, null, null, "04d6b14e-736d-486f-9d8f-898e0ec43b0b", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "kuem113" },
                    { new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), 0, null, "f2124fb1-9fcf-4809-a16b-f3abc5c1ae79", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "duythunglungtinhiu@gmail.com", true, "Pham Hoai Duy", false, null, "DUYTHUNGLUNGTINHIU", "DUYPRO113", "AQAAAAIAAYagAAAAECD6q3u5hALkXapNJr3ZE+tGviUQ2RwziRcXXLTXVuKSlts1eEbp3DpRkxyhbq6Wig==", "0555666612", false, null, null, "6b539b6a-71c9-4463-9381-ebb2b3f9e46d", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "duypro113" },
                    { new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 0, null, "e94c2fa5-b4c7-48f5-a062-1e00ddabb741", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "quocdai@gmail.com", true, "Nguyen Quoc Dai", false, null, "QUOCDAI@GMAIL.COM", "DAINQ115", "AQAAAAIAAYagAAAAEEy5500oC1Vt6lN7cTpz9sPdvsTujmnTx1ch2pyz8GHX/12uLJEBZcEqIYBeo9CY4Q==", "0932748924", false, null, null, "a090a5bb-2835-42eb-b33a-a70c9fcff6bb", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dainq115" },
                    { new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, null, "fab16f64-720b-4104-b1bc-9135400c0055", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "asd@gmail.com", true, "asd", false, null, "ASD@GMAIL.COM", "ASD", "AQAAAAIAAYagAAAAEIVZnzpBJZ/4IVsIzh0Z6zIlBXq+SvojtrStIoEq4Kbg6pFQrXMu4OXl/xXKMCFwhA==", "0123456789", false, null, null, "4be62f7e-55af-4d1c-8469-88e92a99d087", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "asd" },
                    { new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"), 0, null, "d30781cf-d703-4267-b7fb-cf162b3da911", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khaitoi@gmail.com", true, "Phan Van Khai", false, null, "KHAITOI@GMAIL.COM", "XAUTRAI123", "AQAAAAIAAYagAAAAEOyGQJgWfnu+NMRArtiLMv6oQGhOxcUlIGtg8COLC/o9C8jTczf4e7GXEyzWlpXNdw==", "0963122758", false, null, null, "60b948be-1915-4825-8e39-a8f6b054ec04", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "xautrai123" },
                    { new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 0, null, "a093b506-d9bb-4547-a1cd-e39e2b5aabc5", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "quangdalat@gmail.com", true, "Quang La Tui", false, null, "QUANGDALAT@GMAIL.COM", "QUANGSPA009", "AQAAAAIAAYagAAAAELpAlFioAnvrTdwQwDayW2nfzTe2vnC+ds4J9BjbM5TZdDsNcBw6LQ9ts45QVjePnA==", "0999777712", false, null, null, "7977d7c4-c60d-4187-a73c-5f1946d3f6b3", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "quangspa09" },
                    { new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 0, null, "fc0c3d17-e44c-43dd-bcb6-8534894c582d", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "toanvan@gmail.com", true, "Van Huu Toan", false, null, "TOANVAN@GMAIL.COM", "VIPRO123", "AQAAAAIAAYagAAAAEI2pTslSGq4ifUI7TMX2w1lzjdbsgdteDu18jYhKg9PU1O4XAZCtQkvgJSVR0bObTw==", "0792766979", false, null, null, "39d9be20-d18f-4a54-b9b2-568bc3635c6f", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "vipro123" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName", "CategoryType", "CreatedAt", "Image", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), "Hoa quả tươi hoặc chế biến như salad trái cây, nước ép, sinh tố, cung cấp vitamin và khoáng chất", "Trái cây", "Food", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fapple.png?alt=media&token=106a39ee-5c36-4c27-8bbe-c850ee19cb02", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), "Các món ăn từ thực vật, đậu phụ, và nguyên liệu không sử dụng thịt, phù hợp với người ăn chay hoặc muốn đổi vị thanh đạm", "Món chay", "Food", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fradish.png?alt=media&token=c27e26f3-3f39-42ec-bf40-94c9abb074d5", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("462eddbb-989c-4c39-8904-d9a54950f81b"), "Cải thiện sức mạnh và hình dáng cơ tay, vai và lưng trên.", "Upper Body", "Exercise", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fupper-body.png?alt=media&token=4010483d-fb22-4613-9070-0a2b2d57ce6a", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), "Gạo, mì, bánh mì, yến mạch, và các loại hạt ngũ cốc. Là nguồn cung cấp năng lượng chính trong ngày", "Ngũ cốc", "Food", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Frice.png?alt=media&token=1ef6ca23-003f-4415-9ce4-3a3f5cd8e65e", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), "Snack, khô gà, khô bò, bim bim, và các món ăn nhẹ lý tưởng cho những lúc giải trí hay nghỉ ngơi", "Đồ ăn vặt", "Food", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fpopcorn.png?alt=media&token=8aecf5e1-071f-4b0f-8e55-a2c47b289def", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), "Món ăn từ rau xanh, củ quả và nấm. Phù hợp cho những ai yêu thích thực phẩm tươi sạch, giàu dinh dưỡng", "Rau củ", "Food", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbroccoli.png?alt=media&token=6746e0eb-bcf0-44d1-830a-79821f735f84", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), "Bánh ngọt, kẹo, kem, và các món tráng miệng ngọt ngào, lý tưởng cho những ai yêu thích đồ ngọt", "Món ngọt", "Food", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcupcake.png?alt=media&token=8721bd49-186f-4ccf-a85a-64008e4c8e38", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7d730669-e718-4c17-ae6e-529636932e62"), "Tăng cường sức mạnh cho chân, đùi và mông, cải thiện khả năng di chuyển và sự bền bỉ.", "Lower Body", "Exercise", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Flower-body.png?alt=media&token=c5a737bf-767e-4db9-8c80-0c04812e11dd", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), "Kết hợp thăng bằng và sự dẻo dai, hỗ trợ kiểm soát cơ thể và giảm nguy cơ chấn thương.", "Flexibility", "Exercise", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fflexibility.png?alt=media&token=1850a9fe-7412-49b3-8660-81ef76194685", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), "Cải thiện hệ tim mạch, đốt cháy calo và tăng cường sức bền.", "Cardio", "Exercise", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcardio.png?alt=media&token=6c6c115c-db1f-4af2-96e0-188f38944f36", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), "Bao gồm các món ăn từ thịt bò, thịt gà, thịt lợn, thịt vịt và các loại thịt khác. Là lựa chọn phổ biến trong bữa ăn chính", "Thịt", "Food", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fsteak.png?alt=media&token=dfffb9c2-2964-40cc-8712-e83b4200e7af", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa7ac7df-8edb-431a-9fae-5b8520d7630d"), "Cải thiện khả năng thăng bằng và tăng cường sự ổn định của cơ thể.", "Balance", "Exercise", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbalance.png?alt=media&token=58094819-44bf-4d32-8075-5bccfd957201", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), "Pizza, burger, khoai tây chiên, gà rán, và các món ăn tiện lợi, phù hợp cho những ai bận rộn", "Đồ ăn nhanh", "Food", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fburger.png?alt=media&token=66dd457f-64d3-4b66-851c-10eba13fdc7d", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), "Tăng cường khả năng di chuyển của khớp và cơ, giúp cơ thể linh hoạt hơn.", "Mobility", "Exercise", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fmobility.png?alt=media&token=27e9733a-292e-4f15-9bfc-a37d9b7ea575", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), "Bánh mì, bánh ngọt, bánh mặn, bánh hấp, và các món bánh truyền thống hay hiện đại", "Bánh các loại", "Food", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbread.png?alt=media&token=decd5d8c-994f-4a71-ab9e-2096209515fc", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), "Các món ăn từ tôm, cá, cua, mực, hàu, sò và các loại hải sản khác. Thích hợp cho những ai yêu thích hương vị biển cả", "Hải sản", "Food", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcrab.png?alt=media&token=0cde2529-8e28-4b5e-80cf-660f27564de2", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), "Bao gồm nước ép, sinh tố, trà, cà phê, và các loại đồ uống giải khát khác", "Đồ uống", "Food", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcoffee-cup.png?alt=media&token=14155321-cd44-422b-a49f-3e34636d7f85", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"), "Tập trung vào cơ vùng bụng và lưng dưới, giúp cải thiện sức mạnh và sự ổn định.", "Core", "Exercise", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcore.png?alt=media&token=b3152e12-16dd-4ec4-944f-bf2c3434954b", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), "Kimchi, dưa chua, sữa chua, rượu vang và các món ăn lên men, tốt cho tiêu hóa và sức khỏe đường ruột", "Món lên men", "Food", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fpickles.png?alt=media&token=2a078ceb-40a9-403d-a68c-9682faf1b97f", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), "Các loại hạt (hạnh nhân, hạt chia, hạt điều) và đậu (đậu nành, đậu xanh, đậu đen). Giàu protein và chất xơ", "Hạt và đậu", "Food", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fgrain.png?alt=media&token=e224b22a-925e-4aa4-ab50-d74309ba71f4", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Portions",
                columns: new[] { "PortionId", "CreatedAt", "CreatedBy", "MeasurementUnit", "PortionSize", "PortionWeight", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1500876f-ef20-40de-baae-de0336bdc47b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "cốc", 240f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("1808de3e-ae43-41a6-b9ce-bfe89131be5a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "chén", 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("1b56833b-1ff5-4a90-aea9-074de2d0dd67"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả lớn", 136f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "miếng", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("22f0a09e-6816-410e-a5a2-c802103b089b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "đĩa", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("24a4ed15-69e4-4fb5-8dd2-1695de52c264"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cái", 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "trái", 164f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("28b06cf6-6367-4786-bccb-89c43dd3ce3a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả nhỏ", 81f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("31e9bda5-8ec3-4444-a23a-908e84da6a14"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "cốc", 240f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("399eee61-90b5-464f-b3f7-7ddc1077ab0d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "hộp", 110f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("3d7eafa9-9fcc-4f49-b8fb-2a5c629ae6eb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cái", 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("3f77fd90-591c-45f3-8bbc-87d0bb49e461"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("40991196-f258-43f1-ac84-0381afa83477"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("40bbc8c4-f383-4ae6-979a-3ac83c275881"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "cốc", 240f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("41ae956e-14fc-44af-bc6a-e5ba77661cee"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 350f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("4e9013c8-d6f7-4740-80d5-e95d318873b9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("5feca670-1f15-430d-9b04-7ac86a329a6c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "ly", 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("6792c392-3c86-4162-be91-4fc8646f861d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "ly", 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("698c67ad-a726-435b-b9d2-c5690a79eb5a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả lớn", 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("6f34350b-8f99-446e-9de9-e0c6277b10f3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "hộp", 180f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("749b288c-112b-4b7b-8750-0daff63d9ab3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 228f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("7be0e4d3-1e50-4de1-931d-08adb85f628b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả vừa", 44f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("8a81e20e-ea16-4073-957e-29508a8f7419"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("91524cc2-db22-4cab-abb7-700725232f1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả vừa", 118f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("92e149ff-8491-48cf-a4e8-8106b1e95c4c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "cốc", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("93984b54-2044-4ea9-8364-a03c6568e358"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 330f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a1589990-affa-4805-a1e0-73de1ffa8516"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "trái", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a33065fe-80ad-4879-9333-424aadc6734f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 350f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a88faa7c-6eab-4ecb-8a75-b078a9cf7834"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a9385e8a-e9b9-484f-beeb-bc35529cf91a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 330f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("b6623163-4c27-4d0c-99ef-12a67b87635f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 350f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c4fc900f-5a92-4228-ac03-57285fff159e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "đĩa vừa", 350f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c605aa91-495e-4977-9876-b2a198ce356e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả nhỏ", 38f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "hộp", 180f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("de5d78a3-c5b1-4e2a-b9eb-f3757c999024"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cái", 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("e4e4252f-ad38-4190-aba5-8989e3cca994"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "miếng", 114f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("eceaaa32-4023-4eab-abb6-9172c908f77c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f483bb75-84f0-4ecc-8a06-f366a488c6bf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "hộp", 116f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("faec7c41-2e11-4092-8ab9-cc9c152d858f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cây", 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "WorkoutId", "AppUserId", "CreatedAt", "Intensity", "UpdatedAt", "UserId", "Views", "WorkoutDescription", "WorkoutName" },
                values: new object[,]
                {
                    { new Guid("0b56cd61-ca2c-4bac-9127-2211cceecf80"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Nhẹ nhàng và dễ tiếp cận, phù hợp với người mới bắt đầu hoặc cần buổi tập nhẹ nhàng", "Người mới bắt đầu" },
                    { new Guid("1c7ded15-2d6e-45f3-8854-f9f12f84493c"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Phát triển cơ chân và mông, giúp tăng cường sức mạnh và sự linh hoạt", "Chân & mông khỏe mạnh" },
                    { new Guid("234104de-c069-401d-8b01-01fb47e2c03b"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Thư giãn cơ bắp và cải thiện sự linh hoạt với các bài tập giãn cơ nhẹ nhàng", "Linh hoạt và thư giãn" },
                    { new Guid("784c8491-28cd-478c-8101-63472dfda717"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Tăng cường sức mạnh thân trên với các bài tập tay, vai và ngực cường độ cao", "Cơ tay và ngực săn chắc" },
                    { new Guid("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Kết hợp toàn thân để tăng cường năng lượng và khởi động ngày mới hiệu quả", "Toàn thân năng động" },
                    { new Guid("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Đốt cháy calo và tăng sức bền với các bài tập cardio cường độ cao", "Tăng nhịp tim" },
                    { new Guid("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Tăng cường sức mạnh cơ bụng và vùng core để cải thiện tư thế và độ bền", "Cơ bụng vững chắc" }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2") },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b") },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e") },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d") },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87") }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "CaloriesBurned", "CategoryId", "CreatedAt", "CreatedBy", "Difficulty", "Duration", "ExerciseName", "Instructions", "Status", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("00355a5e-e30b-4770-a4e5-abf20671a049"), 4f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 45, "Pigeon Base", "Ngồi, một chân duỗi ra sau, một chân gập phía trước", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("04424053-69cc-4342-afcf-2b1a62a6dbf1"), 6f, new Guid("462eddbb-989c-4c39-8904-d9a54950f81b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Pulse Rows", "Ngồi thẳng lưng, gập tay về phía sau như chèo thuyền, giữ nhịp đều", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("05ece9e8-b50d-4269-acb5-023e839d1c42"), 9f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Pop Squats", "Nhảy sang tư thế squat, sau đó nhảy trở về", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("09d79e39-bbd9-4405-9fa6-8d5cd4fc8c7f"), 7f, new Guid("7d730669-e718-4c17-ae6e-529636932e62"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 45, "Ski Sit", "Dựa lưng vào tường trong tư thế ngồi, đùi song song với mặt đất", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("14399a61-ccab-4af5-91fb-04fdc1f92c20"), 4f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 45, "Bridges", "Nằm ngửa, nâng hông lên cao, giữ lưng thẳng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("14fe699e-4652-4250-968d-696223001cc9"), 3f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Chair Twist", "Ngồi xổm, xoay thân sang một bên, tay chắp trước ngực", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("15f6c0bf-f983-48c9-b030-863200a7d4eb"), 5f, new Guid("462eddbb-989c-4c39-8904-d9a54950f81b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "T Raise", "Đứng thẳng, nâng tay ngang vai thành hình chữ T, sau đó hạ xuống", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("15fe99fe-0ae1-4727-a104-5ce133c0c5e2"), 3f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Slow Box", "Di chuyển chậm trong tư thế squat, bước qua lại như hộp vuông", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1766c620-0c7f-4673-8767-bb5702d9e1f0"), 3f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Revolved Triangle", "Từ tư thế tam giác, xoay thân và tay hướng xuống chân trước", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1945eebf-2077-4c8c-b5ab-42736e5a2b4e"), 6f, new Guid("aa7ac7df-8edb-431a-9fae-5b8520d7630d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 20, "Standing Crawl Stroke", "Bơi sải nhưng đứng tại chỗ, di chuyển tay luân phiên.", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1d7e129b-30e5-4ca7-ade1-0ac2c2534332"), 10f, new Guid("7d730669-e718-4c17-ae6e-529636932e62"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Jump Squats", "Thực hiện động tác squat, sau đó nhảy lên mạnh mẽ", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("21e53e39-de13-43c1-ad22-f69ac024677a"), 2f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Step Touch", "Bước sang hai bên, chạm tay xuống chân mỗi lần bước", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("233892f9-f283-4084-a005-7b7121ecc4a1"), 5f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 45, "Accomplished Eagle", "Đứng, quấn tay và chân lại với nhau, giữ thăng bằng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("29336dc7-f70f-4ced-a225-dacc6007f912"), 4f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Inchworms", "Đứng, cúi người, đi tay ra phía trước thành tư thế plank, sau đó quay lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("297bf196-67ad-485f-a1a4-a15895074cce"), 10f, new Guid("aa7ac7df-8edb-431a-9fae-5b8520d7630d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 25, "One Leg Side Hops", "Đứng trên một chân, nhảy sang hai bên với khoảng cách ngắn, giữ thăng bằng.", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("29cffa47-f89b-43c9-ab0a-0eaded59a58d"), 8f, new Guid("aa7ac7df-8edb-431a-9fae-5b8520d7630d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Modified Side Plank", "Nằm nghiêng, chống tay và gập đầu gối dưới, giữ cơ thể thẳng trong tư thế plank nghiêng.", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("2ec9ee3b-2768-4ae4-9246-05cdac76a8a6"), 5f, new Guid("7d730669-e718-4c17-ae6e-529636932e62"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Single Calf Raises", "Đứng một chân, nâng gót chân lên xuống", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("2f3358f6-6e47-4a7e-8ab1-998a4f58386f"), 5f, new Guid("462eddbb-989c-4c39-8904-d9a54950f81b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Y Raise", "Đứng thẳng, nâng tay chéo ra trước thành hình chữ Y, sau đó hạ xuống", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("2f4c14b8-3207-40dc-8233-1ec310a47dd5"), 5f, new Guid("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 60, "Plank", "Nằm úp, nâng cơ thể bằng khuỷu tay và ngón chân. Giữ cơ thể thẳng. Giữ tư thế này", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("30515dc2-1295-4401-b204-2a27f00b7fd1"), 3f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 45, "Seated Spinal Twist", "Ngồi, xoay thân sang một bên, tay đặt lên đầu gối đối diện", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("31550981-bdb4-4f14-b209-dc1e9b9a568c"), 9f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Broad Kicks", "Đá chân rộng ra trước, xen kẽ hai bên", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("3195ac62-c7a7-41f4-8208-c1e5f7fecc47"), 3f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Goddess", "Đứng, chân rộng, squat nhẹ, tay giơ lên ngang vai", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("32989028-4533-4700-b454-a4df1cfa08a9"), 7f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Jumping Jacks", "Nhảy dang tay và chân, sau đó thu lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("34c98139-7bb7-44ad-94d9-0aedb473acb5"), 3f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Standing Backbend", "Đứng, uốn cong người ra sau, giữ thăng bằng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("44f7957f-4a06-420c-9c37-67251eac8688"), 5f, new Guid("aa7ac7df-8edb-431a-9fae-5b8520d7630d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 15, "Standing Side Bend", "Đứng thẳng, nghiêng người sang hai bên luân phiên, giữ thẳng lưng.", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("45049ee3-e43a-4395-ab5e-ada8b7bfbb3a"), 2f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Extended Arm Circles", "Đứng thẳng, xoay hai tay theo vòng tròn lớn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("4520be3b-5b4f-43e1-8e09-e10a2d3b3e3a"), 12f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 30, "Lunge Jumps", "Nhảy đổi chân trong tư thế lunge", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("466c1a67-f7bb-4203-affb-1fd19faf2e72"), 2f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Heel Touches", "Nằm ngửa, gập gối, chạm tay vào gót chân hai bên", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("4c2f77bb-3bb2-4348-b6cd-a5325f3b2214"), 5f, new Guid("7d730669-e718-4c17-ae6e-529636932e62"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Outer Thigh Raises", "Nằm nghiêng, nâng chân trên lên xuống", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("4da7a997-6d33-4034-912b-6f1dd1fdab3d"), 10f, new Guid("462eddbb-989c-4c39-8904-d9a54950f81b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 30, "Clap Push-Ups", "Chống đẩy, khi nâng lên vỗ tay trước ngực rồi trở về vị trí cũ", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("4ea81029-ce2f-4c13-928d-b2b576446283"), 3f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Windmill", "Đứng, cúi người, tay chạm ngón chân đối diện, luân phiên hai bên", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("53493645-f027-43ff-8d95-c8baff2fb02e"), 7f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Toe Taps", "Chạm mũi chân vào bậc thang hoặc bề mặt cao, đổi bên liên tục", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("53fabb8c-d213-4050-9c00-3d5cf4103635"), 8f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Side Shuffle Touch", "Chạy ngang qua lại, chạm tay xuống sàn mỗi lần", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("55fe0528-86d5-49ab-bb6e-a2345418b5de"), 10f, new Guid("7d730669-e718-4c17-ae6e-529636932e62"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 45, "Jump Squats with Pulse", "Thực hiện jump squat, giữ ở vị trí thấp trước khi nhảy", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("59514612-923b-46b5-85bb-96ead6cbe61f"), 5f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 60, "Shoulder Stand", "Nằm ngửa, nâng chân lên cao, hỗ trợ hông bằng tay", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("5ca4aa32-a164-4e51-b6d5-89db5c8fcc46"), 12f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 45, "Push-Up & Burpees", "Kết hợp chống đẩy và động tác burpee hoàn chỉnh", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("5e7c79b5-bbaa-4e8d-bace-3b36fc13960f"), 3f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "High Lunge", "Bước một chân về phía trước, chân sau duỗi thẳng, giữ tư thế lunge cao", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("67c5180f-978d-4cd7-ae1e-57fa80ac5e27"), 6f, new Guid("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Seated Core Twist", "Ngồi thẳng, xoay thân qua lại hai bên", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6b331c4b-71ad-4e2b-930f-64cff22abaf6"), 2f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Hip Circles", "Đứng, xoay hông theo vòng tròn lớn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6d976edf-2f6a-4d74-bbde-434385f55ced"), 3f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Seated Side Bend", "Ngồi, duỗi một tay qua đầu, cúi người sang một bên", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6ee8f18c-d1de-4899-8af9-8bc7341cb225"), 8f, new Guid("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Mason Twist", "Ngồi, co gối, nhấc chân khỏi sàn. Xoay thân từ bên này qua bên kia", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("712662bf-3def-4bad-83a7-58bd3c4e4f9e"), 3f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Humble Warrior", "Từ tư thế lunge, hạ thấp thân, tay chắp ra sau", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("7213c6ec-d1ea-4e7e-97b7-5f4cd675f7ba"), 9f, new Guid("7d730669-e718-4c17-ae6e-529636932e62"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 45, "Bridge Kicker", "Thực hiện động tác nâng hông, đá từng chân một", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("73ca30ef-84cf-4e3f-b360-ac33038cb597"), 4f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 45, "Half Frog", "Nằm sấp, co một chân, dùng tay kéo chân gần đầu", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("78e05e91-0d2a-4418-a363-281cfa7ced50"), 10f, new Guid("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 60, "Hundred Pike", "Nằm phẳng, nhấc chân thẳng lên, bơm tay hướng xuống đất", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("7910e21a-a190-4a6f-bd87-54b6f54cf5e3"), 8f, new Guid("7d730669-e718-4c17-ae6e-529636932e62"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Prisoner's Squat", "Squat với hai tay đặt sau đầu", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("7bc46c3f-a8df-499e-a6dc-fd1ed244592f"), 12f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 45, "Box Jumps", "Nhảy lên hộp hoặc bục cao, sau đó nhảy xuống", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("8482d5db-ee6e-473e-b156-500de0619dfc"), 8f, new Guid("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 45, "Abdominal Hip Raises", "Nằm ngửa, nâng hông lên trần nhà", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("86365264-7f1c-4bc2-8886-92a8523624b4"), 12f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 45, "Tuck Jumps", "Nhảy lên cao, kéo gối sát ngực, sau đó hạ xuống", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("8f7b3eaf-288e-47bd-8a37-94133fe25e62"), 7f, new Guid("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Elevated Crunches", "Đặt chân trên bề mặt nâng cao, thực hiện động tác gập bụng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("90aa224f-411a-4a5d-abbe-e6ed94b209c2"), 4f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Single Leg Runner", "Đứng một chân, nghiêng người về trước, đá chân sau ra sau", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("92c92e7d-5eab-491c-8d31-6721158eb1a9"), 8f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Running in Place", "Chạy tại chỗ, nâng cao gối một cách nhẹ nhàng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("9ac85a51-9155-40ef-a7eb-d5561c238c4f"), 2f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Triceps Roll", "Xoay nhẹ cánh tay để làm nóng cơ tam đầu", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("9ba0c68f-426b-4459-8b12-7eafc4b43f2b"), 9f, new Guid("462eddbb-989c-4c39-8904-d9a54950f81b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 45, "Push-Up & Rotation", "Thực hiện chống đẩy, sau đó xoay người và nâng một tay lên cao", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("9cadb2bc-6ae3-49a1-a094-c89039795ca3"), 8f, new Guid("7d730669-e718-4c17-ae6e-529636932e62"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Straight Leg Donkey Kick", "Đứng bốn chân, đá một chân thẳng ra sau và quay lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("a2be65b5-8135-4a29-a44c-b8f34418c537"), 7f, new Guid("7d730669-e718-4c17-ae6e-529636932e62"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Rear Lunges", "Bước một chân ra sau thành tư thế lunge, sau đó trở lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("aac12e14-eb0e-4921-9fee-8a72cc46f13e"), 8f, new Guid("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Sit-Ups", "Nằm ngửa, co gối, đặt tay sau đầu. Nâng thân lên hướng về gối, sau đó trở về. Lặp lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("ab679a82-97a1-4772-a824-69de7a8626d5"), 9f, new Guid("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 45, "Corkscrew", "Nằm ngửa, chân duỗi thẳng lên. Xoay chân theo vòng tròn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("ae68fd8e-0226-4368-824a-abe06fed86b3"), 8f, new Guid("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Russian Twist", "Ngồi, co gối, xoay thân qua lại hai bên", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("af2b9f55-ec76-4e40-8fb6-8854f101ee58"), 3f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Yoga Squat", "Ngồi xuống thấp, hai tay chắp trước ngực, giữ tư thế yoga", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("b0d4c89e-5ced-4782-b76a-0be207aa4725"), 2f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Shoulder Roll", "Đứng, xoay vai theo vòng tròn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("b39f7142-3d9b-4e80-9304-342de4ebe8d0"), 8f, new Guid("7d730669-e718-4c17-ae6e-529636932e62"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Sumo Chair Squats", "Đứng tư thế rộng, squat giữ lưng thẳng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("b3ba3cfc-34a3-4b31-9e1c-78df5bd7910a"), 6f, new Guid("462eddbb-989c-4c39-8904-d9a54950f81b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Tricep Press", "Ngồi, đặt tay sau lưng, nhấc thân lên bằng cơ tay sau, sau đó hạ xuống", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("b45baf25-682a-4de3-b5aa-15f4ea6e590d"), 6f, new Guid("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Side Crunches", "Nằm nghiêng, co chân. Nâng thân lên nghiêng về phía gối", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("b8d89172-aa14-4315-a7d9-49a44a7b06ca"), 8f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Butt Kickers", "Chạy tại chỗ, gót chân chạm vào mông", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("bd5485ee-c420-4af7-888f-5022127f4a42"), 10f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Star Jumps", "Nhảy lên, dang tay chân ra tạo hình ngôi sao, sau đó trở lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("befbdedd-8795-4f9a-842a-00ea9b770f55"), 7f, new Guid("462eddbb-989c-4c39-8904-d9a54950f81b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 45, "Roof Kickback", "Đứng gập người về trước, đẩy tay ra sau, giữ thẳng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c09b0b4e-dfad-4d62-b620-e3a348849393"), 6f, new Guid("7d730669-e718-4c17-ae6e-529636932e62"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Side Lunge March", "Bước sang bên thành tư thế lunge, sau đó trở lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c0d1b74c-521b-428b-9776-0f9e95bd0ef0"), 5f, new Guid("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Leg Lifts", "Nằm phẳng, nâng cả hai chân lên trần nhà, sau đó hạ xuống", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c26a95d0-b7b6-4654-b05a-768d078258bd"), 10f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 30, "One Leg Side Hops", "Nhảy ngang qua lại bằng một chân, đổi chân xen kẽ", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c37426f7-6e98-4dcd-85b5-49e9e75aa380"), 8f, new Guid("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Bicycle Crunches", "Nằm ngửa, luân phiên chạm khuỷu tay đối diện vào gối theo động tác đạp xe", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c48fb04a-0b63-4d5b-ad72-6c23a7b8267c"), 10f, new Guid("7d730669-e718-4c17-ae6e-529636932e62"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 45, "Side to Side Jump Squat", "Thực hiện jump squats trong khi di chuyển từ bên này qua bên kia", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c56d1ee0-3ea3-4128-9a35-7f97287e11af"), 5f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 60, "Tiger with Bow", "Từ tư thế bò, nắm một chân kéo lên gần đầu", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c7c451d2-c4ee-47b5-8caf-f09d0836ae78"), 2f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Toe Touch Walk", "Đi bộ, gập người chạm ngón tay vào ngón chân mỗi bước", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d2efc4c7-fa6e-45d8-a571-61d919650713"), 9f, new Guid("462eddbb-989c-4c39-8904-d9a54950f81b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 45, "Spiderman Push-Ups", "Chống đẩy, mỗi lần hạ xuống, đưa một gối lên gần cùi chỏ", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d409a2a7-e695-4696-94c3-41013d590887"), 7f, new Guid("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 45, "Dynamic Rollup", "Nằm phẳng, duỗi tay qua đầu. Cuộn lên tư thế ngồi, sau đó cuộn trở lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("deee2611-a087-4d0d-80f0-53e085a06a82"), 11f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 45, "Plank to Frogger", "Từ tư thế plank, nhảy chân lên gần tay, sau đó trở lại plank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("dfa2b796-d12d-4e7c-93bf-89f412b0d551"), 6f, new Guid("7d730669-e718-4c17-ae6e-529636932e62"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Squat & Reach", "Squat xuống, sau đó với tay lên trên", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e0176052-1ea9-4af4-8724-6b3b956acdf5"), 6f, new Guid("462eddbb-989c-4c39-8904-d9a54950f81b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Kneeled Narrow Push-Ups", "Chống đẩy gối xuống sàn, hai tay gần nhau", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e1092fc5-3c26-441c-9c3d-f281f17a5bc1"), 2f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Knee Circles", "Đứng, đặt tay lên gối, xoay gối theo vòng tròn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e202a749-5631-4436-aaec-95dc51b41201"), 7f, new Guid("aa7ac7df-8edb-431a-9fae-5b8520d7630d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 20, "Standing Butterfly Stroke", "Bơi bướm khi đứng tại chỗ, di chuyển cả hai tay đồng thời.", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e2afc25d-44b9-49da-93cd-ed028acd3581"), 5f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 60, "Bow Pose", "Nằm sấp, nắm hai cổ chân, kéo chân lên phía đầu để uốn cong cơ thể", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e37feb90-ad70-4da1-b274-809412dd808a"), 12f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 2, 60, "Burpees", "Nhảy lên, sau đó hạ xuống tư thế chống đẩy, lặp lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("ea43be6e-ed4f-47f2-a4fa-60e34e95f410"), 3f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Pyramid", "Đứng, bước một chân ra sau, cúi người xuống chân trước, giữ lưng thẳng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("eb69be55-8aa5-47b0-b633-12770fe6ac5a"), 3f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Jogging", "Chạy bộ nhẹ tại chỗ hoặc ngoài trời", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("ec2cfe0e-3949-4572-9c02-2c2f5dcc2f1d"), 3f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Supine Marching", "Nằm ngửa, gập gối, nâng từng chân lên xuống như đi bộ", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f2e4e45f-9514-452c-91ff-d5486243fb0d"), 6f, new Guid("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Reaching Crunch", "Nằm ngửa, co gối. Đưa tay về phía gối khi nâng thân lên", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f344b5e8-c338-4da7-a99c-78952ba2db9b"), 9f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "High Knees", "Chạy tại chỗ, nâng cao gối ngang hông", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f53ac445-0d94-46a0-ba3a-fbabf2eaa811"), 4f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 45, "Locust Pose", "Nằm sấp, nâng chân và tay lên khỏi mặt đất, giữ tư thế", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f8c6b372-1b43-45c3-93ca-99e6e9ab734b"), 2f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Teres Roll", "Xoay nhẹ cánh tay trên để khởi động cơ vai", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("fb102f19-2bf9-4ca1-8222-ea1c35b55f0e"), 3f, new Guid("80b51d77-fb33-4294-9903-7a151f12bcf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Peaceful Warrior", "Từ tư thế lunge, đưa tay sau về phía chân sau, tay trước hướng lên", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("fba9adfd-be77-4cf4-81b0-aeb21506cbbf"), 2f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 30, "Ankle Twist", "Ngồi, xoay cổ chân theo vòng tròn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("fc719720-6259-4e21-bec9-82b2949e35e2"), 10f, new Guid("983aabc5-29c7-48a9-9623-4cd37b9a5828"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Mountain Climbers", "Tư thế plank, kéo gối xen kẽ về phía ngực như leo núi", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("fe68c0ac-1b8e-4712-a0d1-a41ca15833e9"), 5f, new Guid("c3bff830-dad0-4489-95df-1d6ac52d5b3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 30, "Jump Rope", "Nhảy dây với nhịp độ ổn định", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "CategoryId", "CreatedAt", "CreatedBy", "DishType", "FoodDescription", "FoodName", "IsPublic", "MealType", "Status", "UpdatedAt", "UpdatedBy", "UserId", "Views" },
                values: new object[,]
                {
                    { new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Nguồn cung cấp beta-carotene tốt cho mắt và da", "Bí đỏ", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("016d6e20-bf8b-4b0e-9e0c-a1d6199f73d4"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Hải sản ngọt tự nhiên, cung cấp canxi và kẽm", "Cua hấp", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("01708b02-6cc1-41f6-ae4a-95c4085e1839"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cuốn bánh tráng với thịt, tôm, rau, chấm nước mắm chua ngọt", "Gỏi cuốn", true, "Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Thức uống giàu dinh dưỡng, bổ sung canxi, tốt cho sức khỏe xương và răng", "Sữa tươi không đường", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("02aad946-ee2f-45f8-8ce5-8ebc476ba631"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Giàu protein, ít béo, giúp xây dựng cơ bắp hiệu quả", "Ức gà tây", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt heo xay nhuyễn, dùng nấu canh, xào, hoặc làm nhân", "Thịt heo bằm", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("05cfce09-72b4-482d-adcd-c0718015be3d"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bánh bột vàng giòn, nhân thịt, tôm, ăn kèm rau sống", "Bánh xèo", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish,Snack", "Bánh vỏ giòn, ruột mềm, dùng kèm nhiều loại nhân như thịt, trứng, rau", "Bánh mì", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh thường luộc, xào hoặc làm gỏi, giàu chất xơ", "Rau muống", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0d3e0ef5-afcc-418a-a3f6-f2a24cfd3166"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Giàu omega-3, hỗ trợ trí não và sức khỏe tim mạch", "Hạt óc chó", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0dbbf1e0-031a-4342-bfde-c127644ebddf"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Ngọt béo tự nhiên, giàu năng lượng cho bữa sáng", "Bơ đậu phộng", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt gà vàng giòn, hương vị hấp dẫn, dễ ăn", "Thịt gà quay", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bột mỏng nhân thịt, hấp hoặc chiên, thường ăn kèm nước lèo", "Hoành thánh", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau củ màu đỏ, giàu sắt và hỗ trợ tuần hoàn máu", "Rau dền đỏ", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Chuối nhỏ, vị ngọt nhẹ, thường dùng làm món ăn nhẹ hoặc nấu chè", "Chuối tây", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây giòn, ngọt, nhiều chất xơ và vitamin, tốt cho hệ tiêu hóa", "Táo", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo từ đậu đỏ, ngọt dịu, bổ máu và mát gan", "Cháo đậu đỏ", true, "Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây nhỏ, vị ngọt thanh, dễ bóc vỏ, giàu vitamin C", "Quả quýt", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("189dadbe-caf2-4d83-bb01-5ffa8776fa20"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish,Snack", "Món ăn nhẹ phổ biến, giàu năng lượng và chất béo", "Đậu phộng rang", true, "Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Sản phẩm từ đậu nành, giàu protein thực vật, dùng trong nhiều món chay", "Đậu hũ", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây mọng nước, giàu chất chống oxy hóa và kali", "Nho", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Loại nấm nhỏ dài, thơm ngon, thường dùng trong lẩu hoặc xào", "Nấm kim châm", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh bao không nhân thịt, nhân rau củ hoặc đậu xanh", "Bánh bao chay", true, "Breakfast,Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Đậu hũ mềm mịn, thường dùng làm canh hoặc món tráng miệng", "Đậu hũ non", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,Snack", "Khoai lang luộc chín, ngọt bùi, giàu chất xơ", "Khoai lang luộc", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh giòn, thường dùng làm kim chi hoặc xào", "Cải thảo", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh hấp nhân thịt xá xíu, mềm, thơm ngọt", "Bánh bao xá xíu", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("27dd8629-4564-478a-b049-6c4b81ee3cf1"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,Snack", "Trứng vịt luộc, chứa phôi phát triển, ăn kèm rau răm và muối tiêu", "Trứng vịt lộn", true, "Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2da12ed2-3082-4374-807e-795372dfd1de"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt cá mềm, thơm, bổ sung dưỡng chất thiết yếu", "Cá bơn nướng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Quả ngọt mọng, giàu chất chống oxy hóa và tốt cho da", "Dâu tây", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Thức uống từ đậu nành, ít ngọt, tốt cho sức khỏe", "Sữa đậu nành", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo gạo nấu với lòng heo, thơm béo, ăn kèm rau thơm", "Cháo lòng", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,Snack", "Loại củ ngọt tự nhiên, dùng luộc, nướng hoặc chiên", "Khoai lang", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("304376d6-f9c5-48f0-985c-06080347b173"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món thanh nhẹ, chua ngọt, giàu omega-3", "Cá hồi sốt chanh", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Loại rau xanh thường dùng trong món xào hoặc luộc", "Cải thìa", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("341c53c9-7894-410c-ab04-0dca11ff6a80"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt trắng thơm ngọt, giàu dinh dưỡng, dễ tiêu hóa", "Cá tuyết hấp", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau củ khô giàu chất xơ, tiện lợi cho nhiều món ăn", "Măng khô", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Thức uống giải khát, làm từ chanh tươi, cung cấp nhiều vitamin C", "Nước chanh", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("37d1bd46-54c4-40ef-a1f0-7bd0883ad818"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Thực phẩm ăn nhẹ, cung cấp năng lượng và dưỡng chất", "Hạt dẻ", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3965d7c0-e550-497d-9b41-ea382c2bb83e"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Nước tăng lực vị dâu, ngọt và kích thích tinh thần", "Sting", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish,Snack", "Thực phẩm chay bổ dưỡng, giàu protein thực vật", "Đậu nành luộc", true, "Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("404a286a-90c5-4c54-8e27-3ddeba55ada3"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Giàu chất xơ và vitamin, tốt cho hệ tiêu hóa", "Hạt dẻ cười", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau quả giòn, nhiều nhớt, thường dùng nấu canh hoặc luộc", "Đậu bắp", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Loại quả đỏ mọng, thường dùng làm nước sốt, canh, hoặc ăn sống", "Cà chua", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("431b7ee6-7c63-43ac-ae7e-be93f7fb6647"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món đặc sản, thịt ngọt, giàu sắt và năng lượng", "Thịt nai nướng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("436d8364-15fd-47a2-9b72-c3841db0da2e"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Bánh bông lan mềm, nhân trứng muối và chà bông", "Bông lan trứng muối", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau quả mát, nhiều nước, thường ăn sống hoặc làm gỏi", "Dưa chuột", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("46b9f487-dc6d-4c1d-9729-9f707ac28202"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh mì tròn kẹp thịt, phô mai, rau, và nước sốt", "Hamburger", true, "Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bún ăn kèm thịt nướng, rau sống, và nước chấm chua ngọt", "Bún chả", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bún với nước lèo mắm cá, đậm đà, ăn kèm hải sản và rau", "Bún mắm", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Trái cây mọng nước, cung cấp hydrat và chất điện giải", "Dừa tươi", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món hải sản ít calo, bổ sung protein và khoáng chất", "Tôm hấp", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4d773186-20f8-42c2-839b-1ce1601280fa"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây nhiệt đới ngọt, giàu vitamin C và chất xơ", "Xoài", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4e46f955-4413-496f-97b4-968a38ee3e11"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Thực phẩm ăn nhẹ, giàu vitamin E và khoáng chất", "Hạt hướng dương", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Món chay giàu protein, dễ chế biến với nhiều gia vị", "Đậu hũ chiên", true, "Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("51061170-597d-4289-a021-1e7dde88331f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Loại thịt mềm, ngọt, chế biến thành món quay, hấp, hoặc nấu cháo", "Thịt vịt", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt bò mềm, hấp dẫn, thích hợp cho bữa tối cao cấp", "Bò bít tết", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("55cb9711-56aa-4efb-b31f-d034134cb1b8"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Hải sản đậm đà, thích hợp ăn kèm bánh mì", "Cá trích muối", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("56bb5be7-3a7f-4942-89c6-3c6af934adf3"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá biển thơm ngon, giàu dinh dưỡng tự nhiên", "Cá chim trắng nướng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Hải sản khô giàu iod, tốt cho chức năng tuyến giáp", "Rong biển khô", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau quả màu sắc, giòn ngọt, giàu vitamin, thường dùng làm salad", "Ớt chuông", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau lá xanh, chứa nhiều sắt và vitamin K", "Cải bó xôi", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("59988378-901f-4ec4-bd6c-9fdc28ca97a1"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Giàu kẽm, ăn nhẹ tốt cho sức khỏe và làn da", "Hạt bí ngô", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Gạo nấu chín, món ăn cơ bản trong bữa cơm hàng ngày của người Việt Nam", "Cơm", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây giàu chất chống oxy hóa, tốt cho tim mạch", "Lựu", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Tiện lợi, giàu dinh dưỡng, dễ chế biến nhiều món", "Cá ngừ đóng hộp", true, "Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món thịt nấu cùng trứng và nước mắm, vị ngọt mặn hấp dẫn", "Thịt kho trứng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6007962d-9bd0-43ce-8a83-6b5f9bed4156"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món ăn đậm đà, chua ngọt, hợp khẩu vị mọi người", "Cua biển sốt me", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Loại nấm to, thơm ngon, thích hợp xào hoặc nấu canh", "Nấm đùi gà", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("628fe894-0d9c-416f-866b-eb77f763ee62"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Giàu chất béo tốt, giúp nuôi dưỡng làn da và tóc", "Bơ", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("642480b4-22c9-4350-a6ce-c052f99e60e3"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Ngũ cốc giàu năng lượng, tốt cho tim mạch và tiêu hóa", "Lúa mạch", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh giúp bổ máu, hỗ trợ tiêu hóa tốt", "Rau mồng tơi", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh mì lát, dễ ăn, thích hợp cho bữa sáng nhanh", "Bánh mì sandwich", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("67f6b055-1abc-4a48-97ce-63aea2e5ef7b"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Nguồn năng lượng dồi dào, bổ sung nhiều vitamin", "Hạt lúa mì", true, "Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("68c8c4c4-e5d6-4e15-ad60-1c18f0c1cb4d"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Thực phẩm giàu protein thực vật, hỗ trợ tiêu hóa", "Hạt kê", true, "Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Thức uống đậm đà, kích thích tinh thần, uống nóng hoặc đá", "Cà phê", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish,Drink", "Rau xanh giàu chất chống oxy hóa, hỗ trợ thải độc", "Rau má", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món ăn miền Nam với sợi hủ tíu mềm, nước lèo thanh ngọt", "Hủ tíu", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6dfafffc-d4f7-4402-b585-37a1c8994663"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món cay hấp dẫn, giàu hương vị, hợp khẩu vị Việt", "Cà ri gà", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo gạo trắng nấu nhuyễn, thêm sườn heo mềm ngọt", "Cháo sườn", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bún nước dùng từ cua đồng, ăn kèm rau muống", "Canh bún", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Phần sườn heo mềm, ngon, thích hợp nấu canh hoặc kho", "Sườn non", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("731974ef-495e-4c08-ba95-20589d60c20c"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert,Snack", "Hạt thơm ngon, bổ sung dinh dưỡng và năng lượng", "Hạt mắc ca", true, "Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh hấp có nhân thịt, trứng, hoặc rau củ, mềm và thơm", "Bánh bao", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau củ màu cam, giàu vitamin A, tốt cho mắt và sức khỏe da", "Cà rốt", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh mì giòn kẹp thịt, trứng và rau, ăn sáng nhanh tiện lợi", "Bánh mì thịt trứng", true, "Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bún xào cùng rau củ và thịt, thơm ngon, dễ ăn", "Bún xào", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7729551a-e475-4079-aaa0-07c02efde2a5"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Giàu omega-3, tốt cho hệ tim mạch và não bộ", "Hạt lanh", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("77b9e248-971c-4292-8cd7-fd7ec55cf643"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Nguồn protein thực vật, bổ sung năng lượng bền vững", "Đậu lăng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món cơm từ gạo tấm, ăn kèm sườn nướng, đồ chua, và nước mắm", "Cơm tấm sườn", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7aee65aa-860d-48c2-ad47-2614e5e04998"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá nước ngọt giàu protein và khoáng chất thiết yếu", "Cá chép", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh giàu folate, tốt cho phụ nữ mang thai", "Măng tây", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây chua ngọt, giàu vitamin C và chất chống oxy hóa", "Kiwi", true, "Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b8500af-d730-4138-9617-cba352faed4a"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây nhỏ, ngọt, mọng nước, vỏ đỏ, hạt to", "Vải", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7cd76708-7312-445e-a392-14f0e806a786"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau củ ngọt tự nhiên, giàu vitamin và chất xơ", "Đậu Hà Lan", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún tươi kết hợp thịt nướng, rau sống, và nước mắm chua ngọt", "Bún thịt nướng", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7f55881d-f8f4-43aa-b4b6-5d56fd56cfde"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá đồng ngon ngọt, giàu chất dinh dưỡng", "Cá lóc hấp", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Loại quả dài, xanh, dùng nấu canh hoặc xào", "Bầu", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("81af247b-f112-4b7c-981c-d1ba1c3a3644"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau cải thảo lên men, cay nồng, thường ăn kèm món nướng", "Kim chi", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Loại cá giàu dinh dưỡng, thường làm salad hoặc áp chảo", "Cá ngừ", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh giàu vitamin C và chất chống oxy hóa", "Bông cải xanh", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món thịt heo nấu tiêu, nước mắm, thơm nồng, đậm đà", "Thịt kho tiêu", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Củ ngọt, ít calo, giúp làm mát cơ thể hiệu quả", "Củ cải trắng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Củ đỏ giàu dưỡng chất, hỗ trợ chức năng gan và máu", "Củ cải đường", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,Snack", "Món ăn nhanh từ thịt xay nhuyễn, thích hợp cho bữa ăn nhẹ", "Xúc xích", true, "Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Giàu protein, ít béo, phù hợp chế độ giảm cân", "Ức gà nướng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("86d88717-df08-4de6-b86d-870210864b46"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây mọng nước, thịt trắng hoặc đỏ, vị ngọt thanh mát", "Thanh long", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Phở bò kết hợp bò viên dai ngon, nước lèo đậm đà", "Phở bò viên", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Loại củ mềm, dùng làm khoai chiên, nghiền hoặc hầm", "Khoai tây", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8bcd1ea8-cf17-4457-bc32-65033e43e311"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Tiện lợi, giàu omega-3, bổ sung bữa ăn nhanh", "Cá mòi hộp dầu", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Thực phẩm bổ dưỡng, giàu tinh bột và khoáng chất", "Khoai môn", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món chay đơn giản, ngon miệng, giàu protein", "Đậu hũ sốt cà", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8ebd5a6e-b0af-42b6-af58-b681fceac1ef"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert,Snack", "Món chè ngọt làm từ đậu đen nấu mềm, nước cốt dừa thơm", "Chè đậu đen", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bún nước đậm đà từ Huế, nổi bật với hương sả, ớt, thịt bò", "Bún bò huế", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Nước trà kết hợp tắc, vị chua ngọt, giải khát", "Trà tắc", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9349fefa-ecbc-4afc-89f4-62c2f67eb441"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Nguồn protein thực vật, giàu chất xơ và khoáng chất", "Đậu đen", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món phở với nước dùng đậm đà, thịt bò tái mềm ngon", "Phở bò tái", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh giòn, thích hợp luộc, xào hoặc nấu canh", "Đậu que", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Nguồn canxi tự nhiên, tốt cho xương và cơ thể", "Sữa bò tươi", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh chứa nhiều sắt, giúp bổ máu và tăng sức khỏe", "Rau cải bó xôi", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh giàu folate, tốt cho hệ miễn dịch và máu", "Rau chân vịt", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Giàu chất xơ và vitamin, tốt cho sức khỏe tim mạch", "Gạo lứt", true, "Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert,Snack", "Món ăn lên men từ sữa, giúp hỗ trợ tiêu hóa và làm đẹp da", "Sữa chua", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Hương vị đậm đà, tiện lợi, tốt cho sức khỏe tim", "Cá hồi hun khói", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Cơm từ gạo lức, giàu chất xơ, tốt cho sức khỏe tim mạch", "Cơm gạo lức", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây nhiệt đới, thịt vàng, ngọt hoặc chua tùy giống", "Xoài", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bún với nước lèo cua đồng, ăn kèm rau sống và mắm tôm", "Bún riêu cua", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Thức uống giải khát tự nhiên, giàu khoáng chất", "Nước dừa", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Hải sản giòn, ngọt, chế biến nướng, hấp, hoặc chiên", "Mực", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Vị mặn đậm, dùng làm topping hoặc ăn sáng", "Thịt lợn xông khói", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a6b8e6e4-1e44-4626-a7d0-1cefefc4f613"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt ngọt, mềm, bổ dưỡng, tốt cho sức khỏe", "Cá chình nướng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt đỏ mềm, giàu dinh dưỡng, giúp phát triển cơ bắp", "Thịt bò nạc", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Phần trứng vàng, giàu dinh dưỡng và chất béo", "Lòng đỏ trứng gà", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a84ec8cd-f9d8-4723-8b9e-4ff4eee1685e"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Món ăn vặt từ cá xay, chiên giòn, chấm kèm tương ớt", "Cá viên chiên", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Siêu thực phẩm mọng nước, giàu chất xơ và vitamin", "Mâm xôi", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây ngọt, giàu năng lượng và chất dinh dưỡng, dễ dàng mang theo", "Chuối", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây ngọt, giàu vitamin C, thích hợp làm món tráng miệng", "Đào", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Sợi bún mềm, thường dùng trong các món nước hoặc xào", "Bún", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món giàu sắt, thích hợp cho bữa tiệc thịnh soạn", "Ức vịt nướng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Giàu omega-3, tốt cho trí não và sức khỏe tim mạch", "Cá thu nướng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert,Snack", "Trái cây ngọt mềm, màu cam, giàu vitamin A và chất xơ", "Đu đủ", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b0f051be-5972-4e7a-a77d-47ec28d58993"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert,Snack", "Thực phẩm nhẹ, cung cấp năng lượng và vitamin E", "Hạt hạnh nhân", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau củ giàu vitamin, hỗ trợ hệ miễn dịch", "Đậu hà lan luộc", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("bbd19c8e-c1b4-497f-aadb-ca584820c465"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Siêu thực phẩm, giàu protein và chất xơ", "Hạt diêm mạch", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c027a073-e154-4c78-821e-3588fcb4df03"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack,Dessert", "Siêu thực phẩm, giàu chất xơ và omega-3", "Hạt chia ngâm", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt gia cầm phổ biến, dùng trong nhiều món nướng, luộc, hầm", "Thịt gà", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bánh bột gạo nhỏ, ăn kèm tôm cháy và nước mắm", "Bánh bèo", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Món bắp nấu chín, ngọt tự nhiên, thích hợp ăn sáng hoặc ăn vặt", "Bắp luộc", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c3480e21-940b-4190-b07c-f3208ae96367"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thực phẩm nguyên hạt, bổ sung dinh dưỡng toàn diện", "Ngũ cốc nguyên hạt", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish,Snack", "Món ăn giàu protein, dễ chế biến, thường dùng trong bữa sáng hoặc ăn vặt", "Trứng gà luộc", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,Snack", "Giàu chất xơ, hỗ trợ tiêu hóa và tốt cho tim mạch", "Yến mạch", true, "Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c5822776-96df-4208-82b2-02f22594063b"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,Snack", "Bánh tròn chiên giòn, nhân đậu xanh, ngọt thanh", "Bánh cam", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c60b8720-2ced-426c-b39b-606757200893"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Nước ngọt có ga, vị cola đặc trưng, dùng kèm bữa ăn nhanh", "Pepsi", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c7e5ccea-ca0e-4c25-be0b-509bb51b38a2"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món cá vàng giòn, giàu omega-3, dễ chế biến", "Cá basa chiên", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c81a404a-ec10-428e-acec-dd56ec1d3607"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Thịt chua lên men, thường ăn kèm lá ổi và tương ớt", "Nem chua", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Mì giàu chất xơ, lựa chọn lành mạnh thay thế mì trắng", "Mì gạo lứt", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây nhiệt đới ngọt, giàu chất xơ và vitamin A", "Quả hồng xiêm", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("cf0fce11-3569-435b-8942-9c0ceb23d6dc"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá biển giàu omega-3, hỗ trợ trí não và sức khỏe tim", "Cá hồi áp chảo", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm chiên vàng với trứng gà, thêm hành phi thơm ngon", "Cơm chiên trứng", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert,Snack,Drink", "Giàu lợi khuẩn, hỗ trợ tiêu hóa và làm đẹp da", "Sữa chua Hy Lạp", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt trắng mềm, nguồn cung cấp sắt và protein", "Thịt lợn nạc", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá biển giàu omega-3, tăng cường sức khỏe tim mạch", "Cá thu", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món ăn với sợi bánh dày, ăn cùng nước lèo đậm đà", "Bánh canh", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,Snack", "Món bánh trong suốt, nhân tôm thịt, thường hấp hoặc luộc", "Bánh bột lọc", true, "Breakfast,Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d675513e-3be1-4c47-b0d2-0718f02ae93b"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Nhỏ gọn, giàu dưỡng chất, dùng trong món ăn châu Á", "Hạt mè", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d8216f25-d01e-48c6-a44f-0a1672862f53"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Hạt giàu chất béo không bão hòa, giúp kiểm soát cholesterol", "Hạt hồ đào", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d9fa8f03-5825-4e83-88d3-1a7c49e39a7d"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bánh truyền thống từ gạo nếp, thịt mỡ, đậu xanh", "Bánh chưng", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("da3b2de7-bfd2-4c5e-9958-f8a8368b158a"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Nhỏ gọn, giàu dưỡng chất, dùng trong món ăn châu Á", "Cá trắm hấp", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau cải muối lên men, chua nhẹ, ăn kèm món kho", "Dưa cải chua", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Phở nước lèo thanh ngọt, ăn kèm thịt gà và rau thơm", "Phở gà", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("db3cd633-2350-4143-ae1f-ccc853583755"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Hải sản cao cấp, thơm ngọt, giàu dinh dưỡng", "Sò điệp hấp", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dc49c7a4-cf6a-4b85-a5e0-5f923730464a"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Thức uống giải khát có ga, vị ngọt thanh", "Coca cola", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Loại rau củ thơm, thường dùng làm gia vị hoặc ăn sống", "Hành tây", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,Snack", "Giò heo hấp chín, mềm, thơm, thường dùng trong bánh mì, bánh cuốn", "Chả lụa", true, "Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Cá phơi khô, dùng nướng, chiên hoặc làm gỏi", "Cá khô", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Phần thịt gà trắng, giàu đạm, ít béo, tốt cho người tập gym", "Ức gà", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Thức uống tươi mát từ cam, cung cấp vitamin C tăng sức đề kháng", "Nước cam", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Cà phê kết hợp sữa đặc, vị ngọt béo hấp dẫn", "Cà phê sữa", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bánh canh với thịt cua, nước lèo đậm đà", "Bánh canh cua", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Xôi gạo nếp kết hợp bắp vàng ngọt, ăn kèm hành phi thơm", "Xôi bắp", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây mọng nước, giàu chất xơ và vitamin C", "Lê", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Hải sản giàu đạm, chế biến đa dạng: hấp, chiên, xào, hoặc nướng", "Tôm", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e8a16fb6-33a9-4a5a-85f8-ffa5a1465885"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Thực phẩm ăn nhẹ quen thuộc, giàu năng lượng", "Đậu phộng", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây nhiều nước, vị ngọt mát, thích hợp trong ngày nóng", "Dưa hấu", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Omega-3 dồi dào, tốt cho tim mạch và làn da khỏe mạnh", "Cá hồi nướng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ede931f5-092e-4e41-8ce1-5a95bff2772a"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Hải sản vỏ cứng, thịt ngọt, thường hấp hoặc nấu lẩu", "Cua", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh hấp nhân thịt, trứng cút, ăn sáng tiện lợi", "Bánh bao trứng cút", true, "Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh tráng mỏng cuộn nhân thịt, mộc nhĩ, ăn kèm nước mắm", "Bánh cuốn", true, "Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f412d88d-ce7e-4006-bc11-75af61438491"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Loại bánh chiên phồng, thơm mùi mè, ngọt nhẹ", "Bánh tiêu", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f41484a3-c7df-4530-b7d2-060390103985"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Phần trứng trắng, ít béo, giàu protein, thích hợp cho người ăn kiêng", "Lòng trắng trứng gà", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f44fd111-2744-406a-a706-abc9c0494502"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Chất ngọt tự nhiên từ ong, có lợi cho sức khỏe và làm đẹp", "Mật ong", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món xôi từ gạo nếp, ăn kèm thịt, trứng, chả, và hành phi", "Xôi mặn", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f70172ed-7784-47ec-8aa2-a862ee56a13a"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá biển thơm ngon, tốt cho trí não và tuần hoàn máu", "Cá trích", true, "Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Thức uống ca cao bổ dưỡng, thích hợp cho trẻ em", "Sữa hộp milo", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây nhiều vitamin C, giòn, ngọt hoặc chua nhẹ, ăn cả vỏ", "Ổi", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Sữa chua mịn kết hợp nha đam giòn, tốt cho tiêu hóa", "Sữa chua nha đam", true, "Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("face3a50-e5e6-41e3-83e8-f96e7c8c98d4"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,Snack", "Bánh bột gạo mềm, ăn kèm mắm tôm, thịt bằm", "Bánh đúc", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("faf19891-525a-4308-9222-992e83de7ce7"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Loại cá béo, giàu omega-3, thường ăn sống hoặc nướng", "Cá hồi", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh bột gạo tráng mỏng, ăn kèm chả, nước mắm", "Bánh ướt", true, "Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Loại quả xanh, mềm, thường nấu canh hoặc xào", "Mướp", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Loại chuối phổ biến, vỏ vàng, thơm, ngọt, dùng làm món tráng miệng", "Chuối tiêu", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Màu sắc hấp dẫn, giàu chất chống oxy hóa", "Bắp cải tím", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 }
                });

            migrationBuilder.InsertData(
                table: "FoodAllergies",
                columns: new[] { "FoodAllergyId", "AllergyId", "CreatedAt", "FoodId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("045893e3-36f1-4fbd-bdf5-0d0f15b03742"), new Guid("16acfb07-feee-4bb9-ad2b-05e5b93d18e6"), null, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), null },
                    { new Guid("06efb992-c2d6-4535-9c2d-1a0cb556df92"), new Guid("b8f6417e-2aac-442e-aac4-de4d809c572c"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), null },
                    { new Guid("12536007-f0ee-4103-ac40-596416fbb64c"), new Guid("16acfb07-feee-4bb9-ad2b-05e5b93d18e6"), null, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), null },
                    { new Guid("1603c0e4-e0db-4b89-9f85-d120e87f4a6e"), new Guid("3cd5347e-d38d-425c-af19-e9c4ba2646c6"), null, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), null },
                    { new Guid("1e61d22d-5a80-47a0-917c-c16b8df4b5b5"), new Guid("10127b02-786f-462b-8ee6-3df465903645"), null, new Guid("f412d88d-ce7e-4006-bc11-75af61438491"), null },
                    { new Guid("2bd755e1-7ea6-47a8-8d29-dc9357a17063"), new Guid("70fef89b-5b02-4d6c-81e0-40592eefcb2a"), null, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), null },
                    { new Guid("30192e2a-97ef-4398-87f2-5d4d31238e3a"), new Guid("b82f4697-2ad0-4777-a29b-094c99f46d10"), null, new Guid("c81a404a-ec10-428e-acec-dd56ec1d3607"), null },
                    { new Guid("32bc349f-caa3-4f23-90d1-15e174b56dae"), new Guid("10127b02-786f-462b-8ee6-3df465903645"), null, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), null },
                    { new Guid("4251a67b-d828-46c1-a1e2-2795e6f63a8d"), new Guid("eb5cadbb-94e2-4bf9-8764-ddef8779ebd8"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), null },
                    { new Guid("575bf09f-9d81-4931-a987-de015da6b6fa"), new Guid("70fef89b-5b02-4d6c-81e0-40592eefcb2a"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), null },
                    { new Guid("5d72b3a1-bcd8-4951-9f0a-6b73bca63aa3"), new Guid("b8f6417e-2aac-442e-aac4-de4d809c572c"), null, new Guid("ede931f5-092e-4e41-8ce1-5a95bff2772a"), null },
                    { new Guid("6b1f19c7-faa3-4926-bc45-d88bc44c99d5"), new Guid("13008773-dadd-4053-b64c-500b6050b2aa"), null, new Guid("01708b02-6cc1-41f6-ae4a-95c4085e1839"), null },
                    { new Guid("7f5ae68b-7e60-44f4-bd13-d8b251cdfa3d"), new Guid("b8f6417e-2aac-442e-aac4-de4d809c572c"), null, new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), null },
                    { new Guid("83143049-d2ba-4a1c-939c-ccba2cc7dec4"), new Guid("d0127ea2-7f55-4515-b5ea-3db55af5774e"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), null },
                    { new Guid("837dbd30-cb43-414b-b50f-cf5b32255681"), new Guid("eb5cadbb-94e2-4bf9-8764-ddef8779ebd8"), null, new Guid("faf19891-525a-4308-9222-992e83de7ce7"), null },
                    { new Guid("847f29d6-b7d1-4b6b-9e77-2a477b982dd2"), new Guid("16acfb07-feee-4bb9-ad2b-05e5b93d18e6"), null, new Guid("46b9f487-dc6d-4c1d-9729-9f707ac28202"), null },
                    { new Guid("9fa8b5d3-d20b-4c7e-a2b8-6b163d3a9d7e"), new Guid("70fef89b-5b02-4d6c-81e0-40592eefcb2a"), null, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), null },
                    { new Guid("ac7c4180-49d8-45c6-b12c-ec0b9f3cd37f"), new Guid("d0127ea2-7f55-4515-b5ea-3db55af5774e"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), null },
                    { new Guid("b7ff2e39-8c5b-4198-bfeb-b2fa23745f67"), new Guid("3cd5347e-d38d-425c-af19-e9c4ba2646c6"), null, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), null },
                    { new Guid("bb419ec6-79f7-4bd7-aee7-5b3edcc29b42"), new Guid("0d352b08-ada9-40f6-a23e-6f6f170a9cd4"), null, new Guid("ede931f5-092e-4e41-8ce1-5a95bff2772a"), null },
                    { new Guid("c5e7d22e-8b34-45de-bc87-020dcbeb307f"), new Guid("3cd5347e-d38d-425c-af19-e9c4ba2646c6"), null, new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), null },
                    { new Guid("ca49c0a5-53b7-47b4-8f12-6545b5098da4"), new Guid("70fef89b-5b02-4d6c-81e0-40592eefcb2a"), null, new Guid("f41484a3-c7df-4530-b7d2-060390103985"), null },
                    { new Guid("d3eaf6d0-073b-4385-9ff7-9c361f46a882"), new Guid("b8f6417e-2aac-442e-aac4-de4d809c572c"), null, new Guid("faf19891-525a-4308-9222-992e83de7ce7"), null },
                    { new Guid("dbf35b97-4316-4f1a-b897-6ae644ad01bc"), new Guid("70fef89b-5b02-4d6c-81e0-40592eefcb2a"), null, new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), null },
                    { new Guid("dcb56844-ea6b-4e54-9898-5d9c9723844b"), new Guid("b8f6417e-2aac-442e-aac4-de4d809c572c"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), null },
                    { new Guid("dcf2b60b-b08e-4c1b-96d0-0ae5af6202c3"), new Guid("eb5cadbb-94e2-4bf9-8764-ddef8779ebd8"), null, new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), null },
                    { new Guid("e8e22c46-7403-44a9-80f4-7c5d9af6da25"), new Guid("d0127ea2-7f55-4515-b5ea-3db55af5774e"), null, new Guid("436d8364-15fd-47a2-9b72-c3841db0da2e"), null },
                    { new Guid("eff52e10-2e5d-48ea-9c53-f276634379bc"), new Guid("16acfb07-feee-4bb9-ad2b-05e5b93d18e6"), null, new Guid("05cfce09-72b4-482d-adcd-c0718015be3d"), null },
                    { new Guid("fa719ef6-9cb6-4292-92a8-e7a82d4b48d1"), new Guid("0d352b08-ada9-40f6-a23e-6f6f170a9cd4"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), null }
                });

            migrationBuilder.InsertData(
                table: "FoodPortions",
                columns: new[] { "FoodPortionId", "CreatedAt", "FoodId", "PortionId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00b508dc-fd72-46b5-8fd0-71caa552cf8d"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("c605aa91-495e-4977-9876-b2a198ce356e"), null },
                    { new Guid("034c5f36-35f5-4fb4-b567-4631a20c99b6"), null, new Guid("d9fa8f03-5825-4e83-88d3-1a7c49e39a7d"), new Guid("e4e4252f-ad38-4190-aba5-8989e3cca994"), null },
                    { new Guid("05d20084-3157-48d2-bbdf-59bd4be2d7f9"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("a88faa7c-6eab-4ecb-8a75-b078a9cf7834"), null },
                    { new Guid("166bdafd-3440-45db-af3c-9f254f75381d"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("f483bb75-84f0-4ecc-8a06-f366a488c6bf"), null },
                    { new Guid("29be3e7f-31f6-459d-bcb5-2342e7e0a250"), null, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new Guid("31e9bda5-8ec3-4444-a23a-908e84da6a14"), null },
                    { new Guid("3cea29a7-afbb-4d5d-9755-6f514ae1a0a2"), null, new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new Guid("93984b54-2044-4ea9-8364-a03c6568e358"), null },
                    { new Guid("3dcc2c21-c974-4827-b8bf-224881a2af24"), null, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new Guid("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a"), null },
                    { new Guid("4601ad5c-3b27-4b7b-a4c1-4e2c0acbd844"), null, new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new Guid("8a81e20e-ea16-4073-957e-29508a8f7419"), null },
                    { new Guid("49e440ff-31d5-49a0-8f8b-98c9a9d95cf9"), null, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new Guid("de5d78a3-c5b1-4e2a-b9eb-f3757c999024"), null },
                    { new Guid("50cd88da-4abe-448a-bf7f-4c50bd4d1bc3"), null, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new Guid("eceaaa32-4023-4eab-abb6-9172c908f77c"), null },
                    { new Guid("55ed9075-67ec-4a5e-8d67-71b778fb480f"), null, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new Guid("a33065fe-80ad-4879-9333-424aadc6734f"), null },
                    { new Guid("624eeb3d-b90c-41de-aaac-82aac1278366"), null, new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new Guid("a9385e8a-e9b9-484f-beeb-bc35529cf91a"), null },
                    { new Guid("63c7b97d-ad3e-47c0-a294-fc74ae5c312e"), null, new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new Guid("a1589990-affa-4805-a1e0-73de1ffa8516"), null },
                    { new Guid("6488aed8-d811-4054-aa55-1419362b89f6"), null, new Guid("c5822776-96df-4208-82b2-02f22594063b"), new Guid("3d7eafa9-9fcc-4f49-b8fb-2a5c629ae6eb"), null },
                    { new Guid("689236b2-c41a-4581-97f4-9943a8bf619f"), null, new Guid("05cfce09-72b4-482d-adcd-c0718015be3d"), new Guid("24a4ed15-69e4-4fb5-8dd2-1695de52c264"), null },
                    { new Guid("6956e07b-da21-481e-ac76-65255fd9587f"), null, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("1808de3e-ae43-41a6-b9ce-bfe89131be5a"), null },
                    { new Guid("6dfc62b1-fc62-4aea-a8f4-aa93dcfb10fe"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("6f34350b-8f99-446e-9de9-e0c6277b10f3"), null },
                    { new Guid("77ff6660-2d5b-45db-bd7b-524a3eac0a98"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("faec7c41-2e11-4092-8ab9-cc9c152d858f"), null },
                    { new Guid("79f8e00a-8627-4c17-ad1b-1f2e30152cf7"), null, new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new Guid("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1"), null },
                    { new Guid("7a61797f-8c44-44f2-87d7-9d14946e91e0"), null, new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new Guid("4e9013c8-d6f7-4740-80d5-e95d318873b9"), null },
                    { new Guid("8c85d7a4-bace-4691-ab0f-e1628f24bfd3"), null, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("40991196-f258-43f1-ac84-0381afa83477"), null },
                    { new Guid("8d47ad59-d162-4777-81dc-c2bec9e72f22"), null, new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new Guid("92e149ff-8491-48cf-a4e8-8106b1e95c4c"), null },
                    { new Guid("99a56d5b-3a27-437b-b2dd-9ed46689be76"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("698c67ad-a726-435b-b9d2-c5690a79eb5a"), null },
                    { new Guid("9fcf8d40-47b2-45fb-8197-e77bf2071542"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("91524cc2-db22-4cab-abb7-700725232f1f"), null },
                    { new Guid("aac2bdea-12f2-4a18-970b-53f31238c765"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("7be0e4d3-1e50-4de1-931d-08adb85f628b"), null },
                    { new Guid("b38e1bf5-f34c-422f-bc6a-456eb9f1439f"), null, new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new Guid("41ae956e-14fc-44af-bc6a-e5ba77661cee"), null },
                    { new Guid("b915f9fe-df4f-4b9a-aeee-746a7206a297"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("399eee61-90b5-464f-b3f7-7ddc1077ab0d"), null },
                    { new Guid("bdfe0d61-37a3-4062-bff8-b1ab5d7959cc"), null, new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new Guid("3f77fd90-591c-45f3-8bbc-87d0bb49e461"), null },
                    { new Guid("c15e4bd1-ddaa-4330-8ae5-dbf1549a8f9c"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("28b06cf6-6367-4786-bccb-89c43dd3ce3a"), null },
                    { new Guid("c5c017a3-f52c-4e61-b3f5-d36fc3da9438"), null, new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new Guid("5feca670-1f15-430d-9b04-7ac86a329a6c"), null },
                    { new Guid("cfab2fdb-5a1a-4b4c-8e85-5247c64e3492"), null, new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new Guid("c4fc900f-5a92-4228-ac03-57285fff159e"), null },
                    { new Guid("d5d5889a-bbc4-408c-9884-d194e1f48346"), null, new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new Guid("6792c392-3c86-4162-be91-4fc8646f861d"), null },
                    { new Guid("da959267-1066-4a30-84a6-c5975af7c398"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("40bbc8c4-f383-4ae6-979a-3ac83c275881"), null },
                    { new Guid("db166416-f2d4-4e69-98b2-4b14ac28f725"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("1b56833b-1ff5-4a90-aea9-074de2d0dd67"), null },
                    { new Guid("e07e4ccc-de61-4564-a047-d5f29395e765"), null, new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new Guid("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649"), null },
                    { new Guid("e428756d-f4a5-4ea2-a168-409faa856d57"), null, new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new Guid("1500876f-ef20-40de-baae-de0336bdc47b"), null },
                    { new Guid("ea36ca31-4756-426f-8f30-116a401871ff"), null, new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new Guid("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52"), null },
                    { new Guid("eef1a8f0-25f1-4695-b6ff-c57662e845cd"), null, new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new Guid("749b288c-112b-4b7b-8750-0daff63d9ab3"), null },
                    { new Guid("ef7605fb-2047-4fd6-b9eb-bcaa4265dcfa"), null, new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new Guid("22f0a09e-6816-410e-a5a2-c802103b089b"), null },
                    { new Guid("ff83c895-9e7c-497d-ba90-48a0b27ac753"), null, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new Guid("b6623163-4c27-4d0c-99ef-12a67b87635f"), null }
                });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "NutritionId", "Calcium", "Calories", "Carbs", "Cholesterol", "CreatedAt", "CreatedBy", "Fat", "Fiber", "FoodId", "Iron", "Potassium", "Protein", "SaturatedFat", "Sodium", "Sugar", "UnsaturatedFat", "UpdatedAt", "UpdatedBy", "VitaminA", "VitaminB1", "VitaminB2", "VitaminC", "VitaminD", "VitaminE" },
                values: new object[,]
                {
                    { new Guid("020e964c-f99e-47f2-b12b-211df01556ea"), 30f, 120f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 4f, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), 1.2f, 200f, 3f, 1f, 50f, 10f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.03f, 0.02f, 0f, 0f, 0f },
                    { new Guid("02a5199d-2f55-4015-bb78-0161b473f87b"), 20f, 220f, 28f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 1f, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), 1f, 100f, 7f, 2f, 450f, 1f, 4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.04f, 0.05f, 2f, 0f, 0.1f },
                    { new Guid("0303db3c-64a2-450b-b807-0b2bb8fea2a8"), 27f, 132f, 23.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 8.7f, new Guid("9349fefa-ecbc-4afc-89f4-62c2f67eb441"), 2.1f, 355f, 8.9f, 0.1f, 5f, 0.3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 0.24f, 0.21f, 0f, 0f, 0.2f },
                    { new Guid("038f49ca-33e6-44b5-9709-29fbe196a026"), 20f, 150f, 30f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 2f, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), 1f, 100f, 5f, 0.5f, 300f, 2.5f, 1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.06f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("03e81e53-5d3b-4788-8649-1126abcf1c46"), 11f, 77f, 17f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 2.2f, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), 0.8f, 425f, 2f, 0f, 6f, 0.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.11f, 0.03f, 19.7f, 0f, 0.01f },
                    { new Guid("0420436a-aa95-4fdd-b86e-d9ce42fc9746"), 18f, 14f, 3.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.5f, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), 0.3f, 170f, 0.6f, 0f, 1f, 1.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.02f, 0.02f, 10f, 0f, 0.01f },
                    { new Guid("04e83169-5ab3-4b5d-b716-42b99ee48ea4"), 25f, 81f, 14.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 5.1f, new Guid("7cd76708-7312-445e-a392-14f0e806a786"), 1.5f, 244f, 5.4f, 0.1f, 5f, 5.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 765f, 0.27f, 0.15f, 40f, 0f, 0.1f },
                    { new Guid("067f40b0-b9f0-4bb7-900b-f3b6e9bd340d"), 13f, 215f, 1f, 68f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("304376d6-f9c5-48f0-985c-06080347b173"), 0.6f, 364f, 22f, 3.5f, 59f, 0f, 9.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.38f, 5f, 570f, 0.4f },
                    { new Guid("069ec9f7-4ef2-4264-af51-cb3aaae4c4e8"), 82f, 188f, 1.6f, 600f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("27dd8629-4564-478a-b049-6c4b81ee3cf1"), 2.5f, 160f, 13.6f, 4f, 140f, 0f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.65f, 0.1f, 0.5f, 0f, 0f, 0.3f },
                    { new Guid("06e223cf-0f44-46b1-bd33-10df70a0461e"), 7f, 30f, 7.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.4f, new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), 0.2f, 112f, 0.6f, 0f, 1f, 6.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.57f, 0.03f, 0.02f, 8.1f, 0f, 0.05f },
                    { new Guid("07240e21-d8f0-495b-a258-5a159e0cf6e0"), 21f, 26f, 6.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.1f, new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), 0.8f, 340f, 1f, 0f, 1f, 2.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8533f, 0.05f, 0.11f, 9f, 0f, 0.3f },
                    { new Guid("07b97860-12b5-41ae-b6fd-baadb0d1f637"), 47f, 34f, 6.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.6f, new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), 0.7f, 316f, 2.8f, 0f, 33f, 1.7f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 623f, 0.07f, 0.12f, 89.2f, 0f, 0.8f },
                    { new Guid("091a6364-90b6-4fe3-957c-2d8b1307a75c"), 20f, 150f, 30f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), 0.4f, 100f, 3f, 1f, 250f, 1.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.04f, 0.02f, 0f, 0f, 0.05f },
                    { new Guid("0941001b-4d50-4f35-b672-aedf872ea325"), 10f, 112f, 23.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.9f, 1.8f, new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), 0.4f, 86f, 2.6f, 0.2f, 1f, 0.4f, 0.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.14f, 0.02f, 0f, 0f, 0.1f },
                    { new Guid("096eb271-f92a-48b7-8238-c85913ed038e"), 105f, 13f, 2.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1f, new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), 0.8f, 176f, 1.5f, 0f, 65f, 0.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.6f, 0.04f, 0.07f, 45f, 0f, 0.15f },
                    { new Guid("09a360a0-45c8-432e-88a1-7440af7268f2"), 25f, 150f, 15f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 2f, new Guid("01708b02-6cc1-41f6-ae4a-95c4085e1839"), 0.8f, 120f, 10f, 1.5f, 400f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.02f, 0.02f, 5f, 0f, 0.1f },
                    { new Guid("09c52182-7cd0-4bf4-9c0f-1d4ed29b90db"), 10f, 180f, 30f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 1.5f, new Guid("f412d88d-ce7e-4006-bc11-75af61438491"), 1f, 50f, 4f, 2f, 200f, 8f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.06f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("0b3537f5-2bbb-4b0b-82c1-a57d44023a3e"), 20f, 184f, 0f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 0f, new Guid("a6b8e6e4-1e44-4626-a7d0-1cefefc4f613"), 1.1f, 350f, 18f, 2.8f, 60f, 0f, 9.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.15f, 0f, 0f, 0.4f },
                    { new Guid("0bcdbd43-5822-437a-afdf-b9eb07a78676"), 80f, 55f, 2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 0.5f, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), 1f, 150f, 5f, 0.5f, 15f, 0.5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.02f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("0dd9fb10-50cb-40f6-9a77-dbba9166de0e"), 10f, 20f, 4.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.5f, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), 0.3f, 175f, 0.9f, 0f, 3f, 2.4f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.93f, 0.05f, 0.04f, 80f, 0f, 0.37f },
                    { new Guid("0f507f0d-1519-4844-9b3d-1463d0f9f7f3"), 11f, 60f, 15f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 1.6f, new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), 0.2f, 168f, 0.8f, 0.1f, 1f, 13.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.54f, 0.03f, 0.04f, 36.4f, 0f, 0.9f },
                    { new Guid("10226d83-c689-436e-8551-2fcccec6b39b"), 50f, 400f, 60f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 3f, new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), 2f, 300f, 12f, 4f, 500f, 2.5f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.08f, 3f, 0f, 0.3f },
                    { new Guid("1071273a-384e-4d10-8997-7fc91ef7bf92"), 40f, 300f, 50f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 2f, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), 1.5f, 250f, 10f, 2f, 700f, 3f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.08f, 0.06f, 1f, 0f, 0.2f },
                    { new Guid("12b5b9d3-f1ed-4e35-9f3d-4213546e6de7"), 11f, 116f, 0f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), 0.5f, 200f, 25f, 0.2f, 300f, 0f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.09f, 0.2f, 0f, 200f, 0.4f },
                    { new Guid("13b7d0f2-110b-47ca-b579-1f89a3eb076c"), 5f, 66f, 16.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 1.3f, new Guid("7b8500af-d730-4138-9617-cba352faed4a"), 0.3f, 171f, 0.8f, 0f, 1f, 15.2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.01f, 0.07f, 71.5f, 0f, 0.1f },
                    { new Guid("13c985da-9447-4937-9d43-4932151fc3d8"), 18f, 68f, 14.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.9f, 5.4f, new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), 0.3f, 417f, 2.6f, 0.3f, 2f, 8.9f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.21f, 0.07f, 0.04f, 228.3f, 0f, 0.73f },
                    { new Guid("1473ba30-3e54-4000-9f60-fc5e68b30c8b"), 43f, 142f, 34.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 5.1f, new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), 0.6f, 484f, 0.5f, 0f, 13f, 0.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47f, 0.09f, 0.03f, 4.5f, 0f, 0.1f },
                    { new Guid("14be9dff-6b6b-4b57-8ba9-219193695091"), 40f, 410f, 50f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 3f, new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), 2f, 250f, 16f, 5f, 800f, 5f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.08f, 3f, 0f, 0.3f },
                    { new Guid("15f817fb-27c9-45b6-8d01-2bb8fc539421"), 12f, 160f, 8.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14.7f, 6.7f, new Guid("628fe894-0d9c-416f-866b-eb77f763ee62"), 0.6f, 485f, 2f, 2.1f, 7f, 0.7f, 12.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 146f, 0.07f, 0.13f, 10f, 0f, 2.1f },
                    { new Guid("16e7e423-ddfc-4e43-92ad-2f2cfd76308b"), 14f, 354f, 15.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33.5f, 9f, new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), 2.4f, 356f, 3.3f, 29.7f, 20f, 6.2f, 3.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.02f, 3.3f, 0f, 0.3f },
                    { new Guid("175c7c52-ce22-4bdd-a115-f824729f5f6e"), 45f, 102f, 2f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.1f, 0.5f, new Guid("6007962d-9bd0-43ce-8a83-6b5f9bed4156"), 0.7f, 300f, 18f, 0.5f, 250f, 1.5f, 1.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 0.04f, 0.09f, 4f, 0f, 1f },
                    { new Guid("1867907b-f5d1-44f4-859e-baa2724cd04f"), 33f, 354f, 73.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.3f, 17.3f, new Guid("642480b4-22c9-4350-a6ce-c052f99e60e3"), 3.6f, 452f, 12.5f, 0.5f, 9f, 0.8f, 1.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22f, 0.27f, 0.16f, 0f, 0f, 0.2f },
                    { new Guid("1a75b180-b31e-4fe3-8ac7-149003583a88"), 110f, 64f, 9.4f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 0.4f, new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), 0f, 140f, 3.4f, 1f, 35f, 7.5f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.04f, 0.14f, 0f, 0.02f, 0f },
                    { new Guid("1d11ea43-b4c2-47ad-9acb-33a1581df55b"), 46f, 559f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49f, 6f, new Guid("59988378-901f-4ec4-bd6c-9fdc28ca97a1"), 8.8f, 809f, 30f, 8.7f, 18f, 1.4f, 40.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.19f, 0.32f, 0f, 0f, 2.2f },
                    { new Guid("1e3470f7-ba09-479f-bfab-099c9a8f7e70"), 14f, 96f, 0f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 0f, new Guid("da3b2de7-bfd2-4c5e-9958-f8a8368b158a"), 0.6f, 320f, 20f, 0.6f, 55f, 0f, 1.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.05f, 0.2f, 0f, 0f, 0.4f },
                    { new Guid("1f0efba1-d79f-4589-9781-67d4e3832a49"), 16f, 27f, 5.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.2f, new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), 0.7f, 533f, 3f, 0f, 4f, 0.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("2294d934-ca9f-4095-a2ae-796dc4a93a15"), 30f, 86f, 20.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3f, new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), 0.6f, 337f, 1.6f, 0f, 55f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.96f, 0.08f, 0.03f, 2.4f, 0f, 0f },
                    { new Guid("22ae0d04-5c0d-4cc9-95ea-3a55d7ca686b"), 30f, 150f, 18f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 0.5f, new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), 1.5f, 200f, 8f, 2f, 500f, 1f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("23311b4d-29be-4d87-982a-2e2db501dd04"), 30f, 420f, 60f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), 1.5f, 200f, 12f, 4f, 500f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.06f, 1f, 0f, 0.3f },
                    { new Guid("234631b0-e115-4e6d-b3de-e83448a2340c"), 30f, 400f, 70f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 11f, new Guid("c3480e21-940b-4190-b07c-f3208ae96367"), 3f, 400f, 12f, 1.5f, 2f, 0.8f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.5f, 0.2f, 0f, 0f, 0.1f },
                    { new Guid("2594193a-4050-4c16-9492-b9f0d7583430"), 10f, 111f, 3.2f, 37f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.2f, 0f, new Guid("db3cd633-2350-4143-ae1f-ccc853583755"), 0.4f, 287f, 20f, 0.3f, 200f, 0f, 0.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 0.04f, 0.14f, 3f, 0f, 0.3f },
                    { new Guid("25ed5811-187c-4caf-bc27-6ff15182bcdb"), 37f, 53f, 13.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.8f, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), 0.1f, 166f, 0.8f, 0f, 2f, 10.6f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.34f, 0.06f, 0.03f, 26.7f, 0f, 0.2f },
                    { new Guid("26e78cb5-07a9-4cf9-9635-ae49f565002a"), 70f, 306f, 80f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.1f, 7f, new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), 2.3f, 1040f, 5.8f, 0.6f, 233f, 0.6f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 260f, 0.06f, 0.32f, 6f, 0f, 1f },
                    { new Guid("280eefda-68a9-4320-805c-a2f814df0ae7"), 92f, 567f, 16.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49.2f, 8.5f, new Guid("e8a16fb6-33a9-4a5a-85f8-ffa5a1465885"), 4.6f, 705f, 25.8f, 6.8f, 18f, 4.2f, 42.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.64f, 0.11f, 0f, 0f, 6.6f },
                    { new Guid("286e4e51-e6c6-40b9-b584-6c43dc41354f"), 350f, 145f, 5.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 1f, new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), 3f, 230f, 15f, 1f, 10f, 1.2f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 0.05f, 0.1f, 0.5f, 0f, 0.4f },
                    { new Guid("28a27e20-ed22-4dbd-9347-c4b44e48fad7"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("28f0f25f-36fa-4b27-9c06-705b460a50f6"), 11f, 165f, 0f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.6f, 0f, new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), 0.9f, 256f, 31f, 1f, 74f, 0f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.06f, 0.08f, 0f, 0f, 0.3f },
                    { new Guid("2a306022-b824-4ba1-80dd-953e3c315d29"), 10f, 290f, 0f, 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23f, 0f, new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), 1.5f, 200f, 20f, 9f, 75f, 0f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.05f, 0f, 0f, 0.1f },
                    { new Guid("2b274865-9739-4eba-9d35-468cbf0d012b"), 92f, 567f, 16f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49f, 8.5f, new Guid("189dadbe-caf2-4d83-bb01-5ffa8776fa20"), 4.6f, 705f, 26f, 6.8f, 18f, 4.2f, 42.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.64f, 0.11f, 0f, 0f, 6.6f },
                    { new Guid("2d054b02-0de6-4445-a261-0ec9795be969"), 5f, 89f, 22.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.6f, new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), 0.3f, 358f, 1.1f, 0.1f, 1f, 12.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("2e11edf9-3a0b-4c88-ac50-3e5022f383c7"), 13f, 105f, 0f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.8f, 0f, new Guid("341c53c9-7894-410c-ab04-0dca11ff6a80"), 0.3f, 293f, 23f, 0.2f, 54f, 0f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.07f, 0.26f, 0f, 144f, 0.2f },
                    { new Guid("2e77be32-b505-4c84-af6e-c2166e9622a7"), 25f, 52f, 11.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.6f, 6.5f, new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), 0.7f, 151f, 1.2f, 0f, 1f, 4.4f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33f, 0.03f, 0.04f, 26.2f, 0f, 0.9f },
                    { new Guid("31e868b9-09e6-4755-8d80-d23c40290901"), 15f, 190f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 0f, new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), 1.4f, 250f, 28f, 2.5f, 60f, 0f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.06f, 0.15f, 0f, 0f, 0.7f },
                    { new Guid("320899d0-0233-4c35-9226-25f18e9f8420"), 15f, 417f, 1.4f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39f, 0f, new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), 1f, 200f, 13f, 14.6f, 800f, 1.2f, 24.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.09f, 0f, 0f, 0.3f },
                    { new Guid("322c2cb9-e6e4-40da-bc07-ba199f5f608e"), 40f, 450f, 50f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 3f, new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), 2f, 250f, 20f, 5f, 700f, 5f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.12f, 0.1f, 3f, 0f, 0.5f },
                    { new Guid("3365c26f-d697-4286-8b1c-adc1124d71bf"), 98f, 654f, 13.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 65.2f, 6.7f, new Guid("0d3e0ef5-afcc-418a-a3f6-f2a24cfd3166"), 2.9f, 441f, 15.2f, 6.1f, 2f, 2.6f, 59.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0.34f, 0.15f, 1.3f, 0f, 0.7f },
                    { new Guid("33a32530-356d-4135-8f98-73c80bf301a3"), 110f, 59f, 4.7f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.6f, 0f, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), 0f, 141f, 3.5f, 1f, 36f, 4.7f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.04f, 0.14f, 0f, 0.02f, 0f },
                    { new Guid("3460a786-93a3-47a2-8ef8-871d2a8f48ca"), 8f, 378f, 72.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.2f, 8.5f, new Guid("68c8c4c4-e5d6-4e15-ad60-1c18f0c1cb4d"), 3f, 195f, 11f, 0.7f, 5f, 0.6f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.41f, 0.29f, 0f, 0f, 0.1f },
                    { new Guid("367709d2-284b-4a39-b7dd-4148bd6eb202"), 20f, 250f, 32f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 1f, new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), 1.5f, 150f, 10f, 3f, 480f, 1.5f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("37afe853-af91-43e0-995d-5b47c71f34e9"), 110f, 59f, 3.6f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 0f, new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), 0.1f, 141f, 10f, 0.2f, 36f, 3.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 0.04f, 0.14f, 0f, 0f, 0f },
                    { new Guid("37ddc9f0-736f-43a3-a127-160740e599e8"), 500f, 245f, 0f, 152f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.1f, 0f, new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), 2.8f, 684f, 57f, 0.3f, 702f, 0f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.12f, 0.1f, 0f, 0.6f, 0.2f },
                    { new Guid("380a74d8-eb21-4c3d-bcf4-d49488b4faa6"), 24f, 19f, 3.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0f, new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), 0.3f, 250f, 0.7f, 0f, 11f, 2.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.02f, 2.4f, 0f, 0f },
                    { new Guid("391824d1-8312-4e3d-88b6-840b67e05c1f"), 54f, 389f, 66.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6.9f, 10.6f, new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), 4.7f, 362f, 16.9f, 1.2f, 2f, 0.6f, 5.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.76f, 0.14f, 0f, 0f, 0.42f },
                    { new Guid("39ad233b-474d-4320-80b7-94babe2bc88e"), 20f, 350f, 50f, 15f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 3f, new Guid("d9fa8f03-5825-4e83-88d3-1a7c49e39a7d"), 1.2f, 120f, 8f, 4f, 450f, 1.5f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.08f, 0.05f, 1f, 0f, 0.2f },
                    { new Guid("3c0b20ab-c832-47c9-8ff7-34528e1ed1c8"), 9f, 57f, 15.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3.1f, new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), 0.2f, 116f, 0.4f, 0f, 1f, 9.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25f, 0.02f, 0.03f, 4.3f, 0f, 0.1f },
                    { new Guid("3d6391c3-73eb-42d1-b3d1-e8a3c6b7e995"), 29f, 339f, 71.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.5f, 12.2f, new Guid("67f6b055-1abc-4a48-97ce-63aea2e5ef7b"), 3.9f, 431f, 13.7f, 0.3f, 2f, 0.4f, 2.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.49f, 0.15f, 0f, 0f, 0.2f },
                    { new Guid("40f36f07-a829-4c0b-bbb1-497cdc5d7494"), 40f, 25f, 5.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.8f, new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), 0.5f, 252f, 1.3f, 0f, 13f, 1.4f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.37f, 0.04f, 0.04f, 36.6f, 0f, 0.12f },
                    { new Guid("415a9ba8-8e8c-48a8-adb7-5b6a5ab88892"), 12f, 189f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), 1.1f, 302f, 19f, 4.3f, 60f, 0f, 8.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.33f, 0f, 440f, 0.5f },
                    { new Guid("42238057-f7d3-4616-bc35-fb6de3e96ca3"), 18f, 271f, 0f, 82f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19f, 0f, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), 2.7f, 300f, 26f, 7.4f, 62f, 0f, 11.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.18f, 0f, 8f, 0.5f },
                    { new Guid("438f7428-5464-45b7-8011-6e112744c5aa"), 11f, 117f, 0f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.3f, 0f, new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), 0.4f, 265f, 20f, 0.7f, 670f, 0f, 3.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.09f, 0.2f, 0f, 200f, 0.6f },
                    { new Guid("43fd1c06-ca6f-45f4-bd25-309e86ff4e8c"), 114f, 19f, 3.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2f, new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), 2.1f, 554f, 2f, 0f, 30f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8100f, 0.08f, 0.16f, 51.9f, 0f, 1.9f },
                    { new Guid("48f62ff0-3017-4f15-a869-d25b229e44f9"), 21f, 92f, 3.1f, 233f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.4f, 0f, new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), 0.7f, 279f, 15.6f, 0.5f, 44f, 0f, 0.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.02f, 0.06f, 0f, 0f, 0.01f },
                    { new Guid("498f7782-db66-4b8e-bc10-9dd7ecbe2cc1"), 19f, 116f, 20.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 7.9f, new Guid("77b9e248-971c-4292-8cd7-fd7ec55cf643"), 3.3f, 369f, 9f, 0.1f, 2f, 1.8f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 0.17f, 0.21f, 1.5f, 0f, 0.1f },
                    { new Guid("4becd22b-623f-4171-a253-71860e713590"), 35f, 420f, 50f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2.5f, new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), 2.5f, 320f, 18f, 3f, 850f, 2f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.08f, 0.1f, 0.07f, 1f, 0f, 0.3f },
                    { new Guid("4c1369ea-163e-4975-be97-74547f3e9f60"), 16f, 43f, 9.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.8f, new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), 0.8f, 325f, 1.6f, 0f, 78f, 6.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33f, 0.05f, 0.03f, 4.9f, 0f, 0.1f },
                    { new Guid("4c6c4ed8-5e9d-4904-ba56-1de114a00a6f"), 16f, 15f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.5f, new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), 0.3f, 147f, 0.7f, 0f, 2f, 1.7f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.03f, 0.03f, 2.8f, 0f, 0.03f },
                    { new Guid("4de229b6-0e2f-431d-9201-41bf4a9e847f"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("4f7b350b-b3d1-42d7-ad5b-546604b20846"), 30f, 300f, 2f, 120f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25f, 0f, new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), 2.5f, 300f, 18f, 8f, 800f, 1f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("4f85fde0-9e9d-4731-8876-626704643cfd"), 30f, 86f, 20.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3f, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), 0.6f, 337f, 1.6f, 0f, 55f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.96f, 0.08f, 0.03f, 2.4f, 0f, 0.26f },
                    { new Guid("5164278e-0585-41be-b67f-bec3d7857740"), 25f, 54f, 6.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.6f, 0.4f, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), 0.7f, 118f, 3.3f, 0.2f, 51f, 1.2f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.03f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("519c497e-44bb-41c0-87eb-59f4ed5de68f"), 45f, 31f, 7.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.1f, new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), 0.6f, 216f, 1.4f, 0f, 27f, 3.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 993f, 0.05f, 0.06f, 36.6f, 0f, 0.1f },
                    { new Guid("52829ec6-f1fc-4eda-ab4b-55a4e5b1463d"), 20f, 230f, 40f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 1f, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), 1.2f, 100f, 7f, 2f, 300f, 5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("5639b4b0-1266-4566-ae9d-7a502354237e"), 20f, 158f, 0f, 77f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9.3f, 0f, new Guid("55cb9711-56aa-4efb-b31f-d034134cb1b8"), 1.6f, 327f, 18f, 2.3f, 570f, 0f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.07f, 0.23f, 0f, 600f, 1.1f },
                    { new Guid("578a7c16-1b10-47d7-a04b-9933eee3ccf9"), 21f, 83f, 19.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 5.3f, new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), 0.8f, 193f, 0.4f, 0.1f, 12f, 14.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 60f, 0.01f, 0.02f, 14.7f, 0f, 0.1f },
                    { new Guid("5abaf708-ccd8-4618-af45-14d2bf9d21a4"), 40f, 250f, 30f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 1f, new Guid("436d8364-15fd-47a2-9b72-c3841db0da2e"), 0.6f, 50f, 6f, 4f, 200f, 15f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.03f, 0.05f, 0f, 0f, 0.1f },
                    { new Guid("5bac507b-f44c-4c29-91b7-1d15c59a6449"), 10f, 132f, 0f, 51f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), 0.9f, 252f, 29f, 0.3f, 37f, 0f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.07f, 0.18f, 0f, 0.8f, 0.2f },
                    { new Guid("5c04c4bd-38f6-4df1-ab63-fae57aa591bd"), 3f, 11f, 3.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), 0.1f, 15f, 0.2f, 0f, 2f, 1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.02f, 20f, 0f, 0f },
                    { new Guid("5cc59833-5d75-46de-ac6d-1f695554912d"), 2f, 17f, 0.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0f, new Guid("f41484a3-c7df-4530-b7d2-060390103985"), 0f, 54f, 3.6f, 0f, 55f, 0.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.01f, 0.15f, 0f, 0f, 0f },
                    { new Guid("5d83f737-caf1-4c51-b34b-bb04f2554f53"), 10f, 110f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.9f, 1.8f, new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), 0.4f, 43f, 2.6f, 0.2f, 1f, 0.4f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.16f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("5e990885-3986-44d1-b4da-4f08dc54520e"), 277f, 172f, 8.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9f, 6f, new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), 2.5f, 620f, 18f, 1.3f, 15f, 3f, 7.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9f, 0.16f, 0.18f, 6f, 0f, 0.9f },
                    { new Guid("6072e9af-17be-4477-9612-6473e4aae6fe"), 10f, 188f, 0f, 65f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11f, 0f, new Guid("c7e5ccea-ca0e-4c25-be0b-509bb51b38a2"), 0.5f, 300f, 20f, 2f, 55f, 0f, 9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.05f, 0.12f, 0f, 0f, 0.4f },
                    { new Guid("6173c19a-0549-4066-bdca-bfc0e432e830"), 20f, 158f, 0f, 77f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9.3f, 0f, new Guid("f70172ed-7784-47ec-8aa2-a862ee56a13a"), 1.6f, 327f, 18f, 2.3f, 570f, 0f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.07f, 0.23f, 0f, 600f, 1.1f },
                    { new Guid("62d74ef0-fd81-4a5f-89f2-7ebb368e85ee"), 10f, 160f, 30f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), 0.4f, 100f, 5f, 1f, 250f, 1.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.02f, 0.02f, 0f, 0f, 0.1f },
                    { new Guid("6387bbb3-5d75-40f8-a48d-316fb7628ee0"), 39f, 20f, 3.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.2f, new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), 0.9f, 391f, 2f, 0f, 36f, 0.3f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 442f, 0.05f, 0.05f, 48.5f, 0f, 0.6f },
                    { new Guid("64013dfb-bfa6-4ce2-ad13-897b966acb9e"), 60f, 90f, 10f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 0f, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), 0.2f, 80f, 2f, 2f, 40f, 8f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.04f, 0.06f, 0f, 0f, 0.1f },
                    { new Guid("642b5a68-9e92-4e95-a273-35ff6791d0ab"), 15f, 239f, 0f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14f, 0f, new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), 0.8f, 260f, 27f, 4.1f, 70f, 0f, 9.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 0.06f, 0.11f, 0f, 0f, 0.3f },
                    { new Guid("66577f5e-803a-4494-910f-68afa1478176"), 20f, 200f, 35f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 1.5f, new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), 0.8f, 80f, 6f, 1f, 350f, 3f, 2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.02f, 0.02f, 1f, 0f, 0.1f },
                    { new Guid("66b7e498-4724-48ff-946f-7492f83ca015"), 23f, 40f, 9.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.7f, new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), 0.2f, 146f, 1.1f, 0f, 4f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.05f, 0.02f, 7.4f, 0f, 0.02f },
                    { new Guid("685b3bae-37b8-415e-ae1d-bfc2401ac6b9"), 17f, 120f, 21f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.9f, 2.8f, new Guid("bbd19c8e-c1b4-497f-aadb-ca584820c465"), 1.5f, 172f, 4.1f, 0.2f, 7f, 0.9f, 1.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14f, 0.11f, 0.09f, 0f, 0f, 0.6f },
                    { new Guid("68f0232c-daa3-4160-92b4-c9d2f48805a2"), 77f, 35f, 5.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 1.5f, new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), 1.5f, 312f, 3.6f, 0f, 113f, 0.5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6.3f, 0.04f, 0.09f, 55f, 0f, 1.5f },
                    { new Guid("69e88351-09f6-471d-be0a-a0976da5cedd"), 12f, 135f, 0f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 0f, new Guid("02aad946-ee2f-45f8-8ce5-8ebc476ba631"), 0.8f, 260f, 30f, 0.5f, 60f, 0f, 1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.07f, 0.1f, 0f, 0f, 0.3f },
                    { new Guid("6b20f666-1c8a-4f85-92cd-2f2f97ba206e"), 10f, 18f, 3.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.2f, new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), 0.3f, 237f, 0.9f, 0f, 5f, 2.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.85f, 0.04f, 0.02f, 13.7f, 0f, 0.5f },
                    { new Guid("6b3afd8f-cad3-4529-bac1-5f816c2287a5"), 2f, 2f, 0f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), 0f, 49f, 0.1f, 0f, 5f, 0f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, 0f, 0f, 0f, 0f },
                    { new Guid("6cca7fd0-1564-44ea-b2e6-0c7123a2c46f"), 25f, 81f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 5.7f, new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), 1.5f, 244f, 5.4f, 0.1f, 5f, 5.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 765f, 0.27f, 0.15f, 40f, 0f, 0.1f },
                    { new Guid("6d932f58-dd55-48f7-9e94-6be12a944ee2"), 107f, 562f, 27.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45.4f, 10.3f, new Guid("404a286a-90c5-4c54-8e27-3ddeba55ada3"), 4f, 1025f, 20.3f, 5.6f, 1f, 7.7f, 39.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26f, 0.87f, 0.16f, 5.4f, 0f, 2.9f },
                    { new Guid("6ed6b010-c774-4204-b5d7-9db739c50534"), 37f, 31f, 7.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3.4f, new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), 1f, 211f, 1.8f, 0f, 6f, 1.6f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.69f, 0.02f, 0.1f, 12.2f, 0f, 0.41f },
                    { new Guid("6f09345e-735c-4fd8-a222-3791ce358f65"), 10f, 40f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.5f, new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), 0.1f, 40f, 0.2f, 0f, 3f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.01f, 0.01f, 20f, 0f, 0f },
                    { new Guid("6f5e61ca-9b59-43e4-b1bd-8aa9accc9480"), 975f, 573f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 12f, new Guid("d675513e-3be1-4c47-b0d2-0718f02ae93b"), 14.6f, 468f, 18f, 6.9f, 11f, 0.3f, 43.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.79f, 0.25f, 0f, 0f, 0.2f },
                    { new Guid("70f2deb9-2a90-4c02-8488-1b351630c1ca"), 177f, 138f, 12.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8.7f, 10.6f, new Guid("c027a073-e154-4c78-821e-3588fcb4df03"), 2.2f, 116f, 4.7f, 0.9f, 5f, 0f, 7.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 54f, 0.16f, 0.17f, 0f, 0f, 0.4f },
                    { new Guid("73e992ee-249f-4580-b1d3-ae21e5c2b984"), 5f, 89f, 22.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.6f, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), 0.3f, 358f, 1.1f, 0.1f, 1f, 12.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("7603131c-28dd-4e9a-8a8b-e8d24a30e6a3"), 30f, 250f, 15f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 1f, new Guid("a84ec8cd-f9d8-4723-8b9e-4ff4eee1685e"), 0.5f, 150f, 10f, 5f, 700f, 0.5f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.02f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("78c064d5-1903-4845-bb09-a6e9b4652764"), 357f, 145f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 1.8f, new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), 2.8f, 240f, 12f, 1.1f, 15f, 2.3f, 5.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 0.08f, 0.16f, 5f, 0f, 0.5f },
                    { new Guid("78c68fe2-e3cf-4022-96cc-a3085aca85cf"), 15f, 350f, 70f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 3f, new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), 1f, 200f, 8f, 2f, 250f, 2f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.15f, 0.1f, 3f, 0f, 0.2f },
                    { new Guid("7a15075d-2280-420e-8053-ed9b266f793c"), 12f, 189f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), 1.1f, 302f, 19f, 4.3f, 60f, 0f, 8.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.33f, 0f, 440f, 0.5f },
                    { new Guid("7e687cdd-ff64-49ac-acf6-b6d3ba5cead6"), 44f, 87f, 0f, 42f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.4f, 0f, new Guid("016d6e20-bf8b-4b0e-9e0c-a1d6199f73d4"), 0.8f, 289f, 18f, 0.3f, 365f, 0f, 1.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 0.02f, 0.11f, 3.5f, 0f, 1f },
                    { new Guid("7ef18737-806e-4e66-ab2b-121a0ed87e95"), 70f, 99f, 0.2f, 189f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 0f, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), 0.4f, 264f, 24f, 0.1f, 111f, 0.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.1f, 0f, 0f, 1.3f },
                    { new Guid("81c240bc-77d1-4da5-b93b-40706cc90711"), 10f, 150f, 30f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 1f, new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), 0.5f, 50f, 3f, 0.5f, 300f, 2f, 1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.01f, 0.01f, 0f, 0f, 0.1f },
                    { new Guid("83d8e505-9186-4394-b3c0-b6f36bcd12f9"), 34f, 61f, 14.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 3f, new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), 0.3f, 312f, 1.1f, 0f, 3f, 8.9f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 87f, 0.02f, 0.05f, 92.7f, 0f, 1.5f },
                    { new Guid("8777dd83-1b4a-43f2-83dd-c4fb6834cb27"), 5f, 90f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.6f, new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), 0.3f, 360f, 1f, 0.1f, 1f, 12f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("87b1e95b-a7ad-4514-9f9a-001d54f6653b"), 22f, 265f, 49f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.2f, 2.7f, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), 2.4f, 115f, 8f, 0.5f, 491f, 5.6f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.2f, 0.12f, 0f, 0f, 0.1f },
                    { new Guid("8b8db2ca-66f8-4e7d-b69d-5ab31bc24475"), 10f, 120f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 0.5f, new Guid("face3a50-e5e6-41e3-83e8-f96e7c8c98d4"), 0.2f, 20f, 2f, 0.5f, 200f, 1f, 1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.01f, 0.02f, 0f, 0f, 0f },
                    { new Guid("8cecb3df-8f91-4fed-9f0d-e620f7beeb29"), 11f, 337f, 0f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28f, 0f, new Guid("51061170-597d-4289-a021-1e7dde88331f"), 2.7f, 205f, 19f, 8.5f, 63f, 0f, 12.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.06f, 0.15f, 0.23f, 0f, 0.02f, 0.3f },
                    { new Guid("8dba0332-68dd-447f-8f8d-cb3c86a79d6a"), 15f, 210f, 6f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 1.5f, new Guid("6dfafffc-d4f7-4402-b585-37a1c8994663"), 1f, 200f, 18f, 5f, 320f, 2f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 0.05f, 0.12f, 5f, 0f, 0.5f },
                    { new Guid("906ff341-e0db-4538-8965-be70bcc1a2bd"), 20f, 250f, 0f, 90f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 0f, new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), 2.5f, 280f, 26f, 6f, 75f, 0f, 9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.2f, 0f, 7f, 0.5f },
                    { new Guid("9121fc2e-232b-4820-8422-7f1b4d74d0d0"), 55f, 22f, 3.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.2f, new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), 1.8f, 500f, 2.1f, 0f, 15f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8890f, 0.05f, 0.18f, 37.5f, 0f, 0.4f },
                    { new Guid("9310a279-efc8-4f83-872a-742b4bbb3bb0"), 120f, 42f, 5f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), 0.1f, 150f, 3.4f, 0.6f, 44f, 5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47f, 0.02f, 0.18f, 0f, 2f, 0.1f },
                    { new Guid("963a6933-cb39-42e0-9dec-ce7c2bb696f1"), 9f, 206f, 0f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("faf19891-525a-4308-9222-992e83de7ce7"), 0.5f, 363f, 22f, 3.1f, 59f, 0f, 7.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.2f, 0.4f, 0f, 0.38f, 0.5f },
                    { new Guid("96760b52-ddb9-4e89-87eb-284ab5838132"), 201f, 76f, 1.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.8f, 0.3f, new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), 1.6f, 121f, 8f, 0.7f, 7f, 0.4f, 2.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.03f, 0f, 0f, 0.02f },
                    { new Guid("9a859f30-3316-4886-a1a8-ea3a5ff06913"), 264f, 576f, 22f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 12f, new Guid("b0f051be-5972-4e7a-a77d-47ec28d58993"), 3.7f, 705f, 21f, 3.8f, 1f, 3.9f, 46.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0.21f, 1.01f, 0f, 0f, 25.6f },
                    { new Guid("9af709dc-6fe9-4050-b83c-134ee2bc2802"), 30f, 260f, 42f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 1.5f, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), 1.2f, 120f, 9f, 2.5f, 350f, 6f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("9ccefcaf-d588-4357-bac4-54c4f0e0f361"), 4f, 110f, 24f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.5f, new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), 0.1f, 15f, 1.8f, 0.1f, 10f, 0.1f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.01f, 0.01f, 0f, 0f, 0f },
                    { new Guid("9f72e213-a220-4d5d-92de-04c44f4a6d2e"), 18f, 20f, 4.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1f, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), 0.2f, 140f, 1.2f, 0f, 3f, 2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.04f, 10f, 0f, 0.1f },
                    { new Guid("a21dfb54-4cc8-4345-bb9f-980e89b0d215"), 12f, 239f, 0f, 88f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14f, 0f, new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), 1.2f, 223f, 27f, 3.8f, 82f, 0f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.07f, 0.13f, 0f, 0.02f, 0.3f },
                    { new Guid("a3a71311-393b-48b9-80d9-164010a16388"), 20f, 250f, 45f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 2f, new Guid("c5822776-96df-4208-82b2-02f22594063b"), 1f, 50f, 4f, 2.5f, 200f, 20f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.04f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("a491a600-a88b-44c8-bc7b-70079aa09725"), 27f, 16f, 3.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.6f, new Guid("845454d0-967a-4e48-aef3-bd8458775500"), 0.3f, 233f, 0.6f, 0f, 9f, 1.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.03f, 14.8f, 0f, 0.2f },
                    { new Guid("a5d8a693-7e00-4968-ac24-2b59989c939c"), 40f, 140f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 5f, new Guid("8ebd5a6e-b0af-42b6-af58-b681fceac1ef"), 2f, 300f, 5f, 0.5f, 30f, 12f, 1.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("a8b5a680-61d1-4d93-addc-92e94556be72"), 30f, 300f, 3f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24f, 0.2f, new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), 2f, 400f, 20f, 9f, 900f, 1.5f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("aa894459-9f93-4e75-a127-35b0eae71957"), 10f, 69f, 18.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.9f, new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), 0.4f, 191f, 0.7f, 0f, 2f, 16.3f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 92f, 0.03f, 0.04f, 10.8f, 0f, 0.1f },
                    { new Guid("abd8e616-aa88-44bd-a005-9b27f53c21c8"), 85f, 718f, 13.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 75.8f, 8.6f, new Guid("731974ef-495e-4c08-ba95-20589d60c20c"), 2.5f, 363f, 7.9f, 12.1f, 5f, 4.6f, 63.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.21f, 0.16f, 1.1f, 0f, 0.6f },
                    { new Guid("ac737809-1aca-43de-88bb-b6f5fe42f87f"), 81f, 33f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 3.2f, new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), 0.8f, 299f, 1.9f, 0f, 7f, 1.5f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.36f, 0.02f, 0.04f, 21f, 0f, 0.27f },
                    { new Guid("aebf714c-276f-44a2-8182-8957a551c5f3"), 30f, 300f, 40f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2f, new Guid("05cfce09-72b4-482d-adcd-c0718015be3d"), 1.2f, 150f, 10f, 3f, 400f, 3f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.08f, 0.05f, 2f, 0f, 0.2f },
                    { new Guid("af359eea-3c29-4aa4-96d4-9655583de28a"), 2f, 96f, 21f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 2.4f, new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), 0.5f, 270f, 3.4f, 0.2f, 1f, 4.5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.15f, 0.1f, 6.8f, 0f, 0.2f },
                    { new Guid("b093fbee-db92-4031-b46b-f6528da9b6c7"), 12f, 206f, 0f, 63f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), 0.5f, 363f, 22f, 3.1f, 59f, 0f, 9.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.38f, 0f, 570f, 0.4f },
                    { new Guid("b609be21-9f88-4ae5-800d-de5cb067401a"), 0f, 41f, 11f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, new Guid("c60b8720-2ced-426c-b39b-606757200893"), 0f, 4f, 0f, 0f, 10f, 11f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, 0f, 0f, 0f, 0f },
                    { new Guid("b7982fb5-0e00-457f-a618-3aabbb7d13cb"), 20f, 296f, 1.7f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26f, 0f, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), 1.2f, 200f, 12f, 9f, 1020f, 0.2f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.3f, 0.12f, 0f, 0f, 0.4f },
                    { new Guid("b897b5d9-cada-44aa-967d-5c65d95e3346"), 99f, 83f, 0f, 97f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.3f, 0f, new Guid("ede931f5-092e-4e41-8ce1-5a95bff2772a"), 0.8f, 259f, 17.5f, 0.3f, 395f, 0f, 0.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.01f, 0.02f, 0f, 0f, 0.1f },
                    { new Guid("ba3d6c03-e3e5-41f5-afa9-d2d918339049"), 6f, 304f, 82.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, new Guid("f44fd111-2744-406a-a706-abc9c0494502"), 0.4f, 52f, 0.3f, 0f, 4f, 82.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.01f, 0.02f, 0.5f, 0f, 0f },
                    { new Guid("bafda235-4d19-4bfd-abe1-ccf2e8e642a0"), 120f, 120f, 18f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), 0.6f, 200f, 4f, 1f, 50f, 12f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.1f, 2f, 0.1f, 0.1f },
                    { new Guid("bf843bd9-a86c-4308-880f-803ac05c3948"), 125f, 42f, 5f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), 0f, 150f, 3.4f, 0.6f, 44f, 5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.04f, 0.18f, 0f, 0.02f, 0.03f },
                    { new Guid("c087ebac-77dd-40d0-bbc3-f12cc6ec458e"), 60f, 350f, 50f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2.5f, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), 1.5f, 300f, 12f, 3f, 700f, 2f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.08f, 0.06f, 2f, 0f, 0.2f },
                    { new Guid("c1f75dc1-46e3-4243-be43-1c3da379c0f3"), 20f, 200f, 25f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 1f, new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), 1.2f, 150f, 10f, 2f, 300f, 1f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("c2211387-2e4e-4988-b166-5b24670871af"), 70f, 691f, 13.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 72f, 9.6f, new Guid("d8216f25-d01e-48c6-a44f-0a1672862f53"), 2.5f, 410f, 9.2f, 6.2f, 0f, 4f, 65.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 56f, 0.66f, 0.13f, 1.1f, 0f, 0.7f },
                    { new Guid("c290176e-e79f-4f97-9a4f-9e5ef06c0d49"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("c4154bdd-4853-4e11-aeac-c92601d7d628"), 10f, 50f, 11f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 3f, new Guid("86d88717-df08-4de6-b86d-870210864b46"), 0.3f, 150f, 1.1f, 0.1f, 4f, 8f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.04f, 0.05f, 3f, 0f, 0.3f },
                    { new Guid("c8b18054-abb6-4f13-9825-0134a0252c78"), 3f, 37f, 7.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.5f, new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), 0.4f, 359f, 2.7f, 0f, 3f, 0.5f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.11f, 0.1f, 2.1f, 0f, 0.01f },
                    { new Guid("c8da0730-2735-4893-a5d0-b7e46424ca52"), 20f, 59f, 15f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2f, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), 0.3f, 257f, 0.9f, 0f, 3f, 9.8f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.95f, 0.03f, 0.04f, 61f, 0f, 0f },
                    { new Guid("c93af12e-5f12-424e-8f03-a6f865522017"), 18f, 131f, 28.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.4f, 4.2f, new Guid("37d1bd46-54c4-40ef-a1f0-7bd0883ad818"), 0.9f, 715f, 2.1f, 0.3f, 27f, 10.7f, 1.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 0.16f, 0.09f, 26f, 0f, 0.4f },
                    { new Guid("ca821e05-cfcc-4ea5-a544-734a88606c98"), 80f, 250f, 30f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9f, 1.5f, new Guid("46b9f487-dc6d-4c1d-9729-9f707ac28202"), 2f, 200f, 12f, 3f, 400f, 5f, 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.1f, 0.12f, 0f, 0f, 0.2f },
                    { new Guid("cb56c1e3-4966-4c4a-983e-71ca4f2a82d7"), 255f, 534f, 28.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42.2f, 27.3f, new Guid("7729551a-e475-4079-aaa0-07c02efde2a5"), 5.7f, 813f, 18.3f, 3.7f, 30f, 1.6f, 38.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.41f, 0.16f, 0.6f, 0f, 0.3f },
                    { new Guid("cc684c94-dc48-4e90-ad4a-dc01b1b585d8"), 382f, 208f, 0f, 61f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11f, 0f, new Guid("8bcd1ea8-cf17-4457-bc32-65033e43e311"), 2.9f, 397f, 24f, 1.5f, 282f, 0f, 9.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.22f, 0f, 177f, 2f },
                    { new Guid("cd9c9ed7-f40d-441a-952d-5a1b9cabf684"), 20f, 230f, 40f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 1.5f, new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), 1.2f, 100f, 7f, 2f, 300f, 3f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.05f, 0.03f, 0f, 0f, 0.2f },
                    { new Guid("cf188682-e681-49ac-9ac3-7aa1efce7075"), 30f, 440f, 50f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17f, 2f, new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), 2.5f, 320f, 21f, 6f, 650f, 3f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.15f, 0.08f, 2f, 0f, 0.4f },
                    { new Guid("cf45af51-23c9-49c6-b1a8-d4b42cad33a3"), 10f, 100f, 3f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 0f, new Guid("c81a404a-ec10-428e-acec-dd56ec1d3607"), 0.8f, 200f, 8f, 2f, 500f, 1f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.04f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("cf529ca8-a8f3-4ba9-937e-d3711cf963f3"), 10f, 130f, 28.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 0.4f, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), 0.2f, 35f, 2.7f, 0.1f, 1f, 0.1f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.01f, 0f, 0f, 0f },
                    { new Guid("d39e3f7e-2537-4fb8-ac97-853684714a29"), 16f, 32f, 7.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2f, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), 0.4f, 153f, 0.7f, 0f, 1f, 4.9f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 0.02f, 0.05f, 58.8f, 0f, 0.3f },
                    { new Guid("d4835dd1-0a29-4a71-baec-4ef0c3351aac"), 6f, 39f, 9.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.5f, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), 0.3f, 190f, 0.9f, 0f, 0f, 8.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 326f, 0.02f, 0.05f, 6.6f, 0f, 0.1f },
                    { new Guid("d5b77299-4ab8-4dfa-9e5d-54d668e708b4"), 40f, 450f, 50f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), 3f, 350f, 20f, 4f, 900f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.08f, 1f, 0f, 0.2f },
                    { new Guid("d9ec9f21-932f-4fde-878a-ca7e0b17790f"), 129f, 322f, 3.6f, 1085f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26.5f, 0f, new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), 2.7f, 109f, 15.9f, 8.7f, 48f, 0.6f, 11.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.53f, 0.08f, 0.37f, 0f, 2f, 2.7f },
                    { new Guid("da470c94-f90f-493e-bf4b-c01935c35e81"), 40f, 450f, 50f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2.5f, new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), 3f, 350f, 20f, 4f, 900f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.08f, 1f, 0f, 0.2f },
                    { new Guid("dbbe9095-73d4-40b6-bcc7-f507e61268ae"), 6f, 52f, 13.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.4f, new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), 0.1f, 107f, 0.3f, 0f, 1f, 10.4f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.02f, 0.03f, 4.6f, 0f, 0.18f },
                    { new Guid("dbf1befa-4698-4079-9ea2-68756469f4fb"), 0f, 39f, 10.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, new Guid("dc49c7a4-cf6a-4b85-a5e0-5f923730464a"), 0f, 1f, 0f, 0f, 5f, 10.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, 0f, 0f, 0f, 0f },
                    { new Guid("dd13cb3c-d1e4-42da-a4e0-453145148903"), 33f, 15f, 2.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.6f, new Guid("81af247b-f112-4b7c-981c-d1ba1c3a3644"), 0.5f, 175f, 1f, 0f, 498f, 1.1f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.35f, 0.03f, 0.04f, 20f, 0f, 0.1f },
                    { new Guid("de3ce9d7-1807-420f-b279-39156363bf7c"), 12f, 206f, 0f, 63f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("cf0fce11-3569-435b-8942-9c0ceb23d6dc"), 0.5f, 363f, 22f, 3.1f, 59f, 0f, 9.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.38f, 0f, 570f, 0.4f },
                    { new Guid("de579e51-44c1-485b-b775-7be82cafe4ed"), 8f, 110f, 23.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.6f, 1.9f, new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), 0.2f, 60f, 2.5f, 0.1f, 4f, 0.3f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("df3fac73-d9c5-4cc1-a478-c8a2fd7d5aa5"), 13f, 165f, 0f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.6f, 0f, new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), 1f, 256f, 31f, 1f, 70f, 0f, 2.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0.07f, 0.1f, 0f, 0f, 0.5f },
                    { new Guid("df7427c5-d01b-4e38-9830-3a170b5ef80b"), 80f, 380f, 50f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), 2f, 350f, 18f, 4f, 900f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("df8467cf-46a6-428a-9ffe-311514abe5b9"), 80f, 360f, 45f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 4f, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), 2.5f, 400f, 15f, 4f, 850f, 6f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.2f, 4f, 0f, 0.5f },
                    { new Guid("dfe2c54d-de32-461f-9da2-e27cbe29b735"), 50f, 380f, 45f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), 2f, 450f, 16f, 4f, 1200f, 4f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.2f, 2f, 0f, 0.4f },
                    { new Guid("e31deb48-285a-43f7-8ec5-9dd6e61b4e4b"), 59f, 588f, 20.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 6f, new Guid("0dbbf1e0-031a-4342-bfde-c127644ebddf"), 1.9f, 645f, 25.1f, 10f, 17f, 9f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.13f, 0.17f, 0f, 0f, 8f },
                    { new Guid("e31e069c-8e49-48a5-b50e-4672ec95a42d"), 40f, 15f, 2.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.5f, new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), 0.6f, 120f, 1.2f, 0f, 750f, 0.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.01f, 0.02f, 15f, 0f, 0.02f },
                    { new Guid("e389a501-335a-4bc4-b58c-7b461c80bf0f"), 7f, 242f, 0f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14f, 0f, new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), 0.9f, 370f, 27f, 5.2f, 65f, 0f, 8.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.6f, 0.15f, 0f, 0f, 0.2f },
                    { new Guid("e4ff8429-0e76-4817-8a59-d3bf5c27f8e3"), 70f, 99f, 0.2f, 189f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), 0.3f, 259f, 20.9f, 0.2f, 111f, 0f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.02f, 0.11f, 0f, 0f, 0.6f },
                    { new Guid("e54509ea-935c-4076-9187-b085565c9c24"), 78f, 584f, 20f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 51.5f, 8.6f, new Guid("4e46f955-4413-496f-97b4-968a38ee3e11"), 5.3f, 645f, 20.8f, 4.5f, 9f, 2.6f, 47f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 1.48f, 0.25f, 1.4f, 0f, 35.2f },
                    { new Guid("e63d956e-7965-4fce-a6b8-4b471d812174"), 11f, 45f, 10.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.2f, new Guid("de097440-db5c-4d91-bd55-76618d70599d"), 0.1f, 200f, 0.7f, 0f, 1f, 8.4f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.1f, 0.02f, 50f, 0f, 0.02f },
                    { new Guid("e6a620b4-6724-48d9-92d4-839ebbbfe1bb"), 0f, 50f, 13f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, new Guid("3965d7c0-e550-497d-9b41-ea382c2bb83e"), 0f, 10f, 0f, 0f, 5f, 13f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, 0f, 0f, 0f, 0f },
                    { new Guid("ea48100c-1775-4605-88ff-f25a40450a04"), 56f, 155f, 1.1f, 373f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10.6f, 0f, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), 1.8f, 126f, 13f, 3.3f, 124f, 1.1f, 3.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.52f, 0.04f, 0.5f, 0f, 1.1f, 0.5f },
                    { new Guid("ea5c7dc7-7502-4eba-a4c5-97e0735584dc"), 50f, 400f, 55f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 3f, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), 2f, 300f, 15f, 4f, 1200f, 4f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.08f, 0.1f, 4f, 0f, 0.2f },
                    { new Guid("ed061871-ac23-450d-8ff1-528d3fac3be8"), 15f, 158f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 0f, new Guid("431b7ee6-7c63-43ac-ae7e-be93f7fb6647"), 3.5f, 320f, 30f, 1.1f, 55f, 0f, 1.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.07f, 0.12f, 0f, 0f, 0.6f },
                    { new Guid("ef4e79eb-da6b-47a1-8710-989a64487de0"), 12f, 90f, 0f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 0f, new Guid("7f55881d-f8f4-43aa-b4b6-5d56fd56cfde"), 0.5f, 310f, 18f, 0.5f, 50f, 0f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.1f, 0f, 0f, 0.2f },
                    { new Guid("f10ffe60-7e1b-4e49-a238-521c8b8c0005"), 10f, 83f, 18.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.2f, 4f, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), 0.3f, 236f, 1.7f, 0.1f, 3f, 13.7f, 1.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.07f, 0.06f, 10.2f, 0f, 0.6f },
                    { new Guid("f1a312f4-c569-4427-9a4e-096f5a0d33ff"), 12f, 127f, 0f, 82f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5.6f, 0f, new Guid("7aee65aa-860d-48c2-ad47-2614e5e04998"), 0.6f, 275f, 17f, 1.2f, 79f, 0f, 4.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.2f, 0f, 24f, 0.2f },
                    { new Guid("f3c2112c-b631-403c-9a80-340ba0c205a3"), 40f, 249f, 1.5f, 80f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0f, new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), 1f, 180f, 16f, 7f, 850f, 0.5f, 9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("f4c9c7ca-a1db-41db-8def-9a819c3c5dde"), 5f, 28f, 4.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.2f, new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), 0.3f, 300f, 2.8f, 0f, 3f, 1f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.06f, 0.07f, 0.5f, 0.02f, 0.1f },
                    { new Guid("f5172f72-f249-4842-9a27-71656f044f9c"), 22f, 265f, 49f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.2f, 2.7f, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), 2.4f, 115f, 8f, 0.5f, 491f, 5.6f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.2f, 0.12f, 0f, 0f, 0.1f },
                    { new Guid("f5e817c1-6b7c-42ee-9fd3-e95735b78155"), 8f, 250f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0f, new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), 1.3f, 220f, 19f, 7f, 65f, 0f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.05f, 0f, 0f, 0.1f },
                    { new Guid("f5f1aa49-7b6f-4a25-a0ac-a9966394299a"), 30f, 400f, 45f, 80f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 3f, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), 2f, 200f, 15f, 5f, 600f, 3.5f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.1f, 0.08f, 2f, 0f, 0.3f },
                    { new Guid("f68975c6-d48b-4bf3-a1a3-0c8989d1c43f"), 24f, 20f, 3.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.1f, new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), 0.5f, 202f, 2.2f, 0f, 2f, 1.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 756f, 0.08f, 0.14f, 5.6f, 0f, 1.1f },
                    { new Guid("f76ab23b-9bf2-4ad3-9cca-7f5b247018a0"), 12f, 97f, 0f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.1f, 0f, new Guid("56bb5be7-3a7f-4942-89c6-3c6af934adf3"), 0.4f, 350f, 20f, 0.6f, 55f, 0f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.09f, 0f, 180f, 0.3f },
                    { new Guid("f8e9a827-2af6-46f3-9e02-0cebad334bd3"), 11f, 91f, 0f, 48f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.3f, 0f, new Guid("2da12ed2-3082-4374-807e-795372dfd1de"), 0.4f, 410f, 19f, 0.3f, 60f, 0f, 1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.18f, 0f, 180f, 0.3f },
                    { new Guid("f9bc8847-6168-402d-a1e0-c45d6166b817"), 11f, 60f, 14.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 1.6f, new Guid("4d773186-20f8-42c2-839b-1ce1601280fa"), 0.2f, 168f, 0.8f, 0.1f, 1f, 13.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 54f, 0.03f, 0.04f, 36.4f, 0f, 0.9f },
                    { new Guid("fd064d13-48cd-473f-9375-c46c79bc4eed"), 40f, 350f, 55f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 2.5f, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), 1.2f, 250f, 12f, 2.5f, 850f, 4f, 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.1f, 3f, 0f, 0.2f },
                    { new Guid("ff22f28d-22f4-4964-91ea-50619e603acd"), 33f, 41f, 9.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.8f, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), 0.3f, 320f, 0.9f, 0f, 69f, 4.7f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.69f, 0.04f, 0.03f, 5.9f, 0f, 0.66f }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "WorkoutExerciseId", "CreatedAt", "Duration", "ExerciseId", "Status", "UpdatedAt", "WorkoutId" },
                values: new object[] { new Guid("47ebfe4f-79ef-49a7-876e-cf29034bba52"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("1d7e129b-30e5-4ca7-ade1-0ac2c2534332"), true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7") });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRoles_UserId",
                table: "AppUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ConsultantId",
                table: "Bookings",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ServiceId",
                table: "Bookings",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CertificateImages_CertificateId",
                table: "CertificateImages",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_UserId",
                table: "Certificates",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyActivities_GoalId",
                table: "DailyActivities",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyActivities_UserId",
                table: "DailyActivities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyActivityWorkout_DailyActivityId",
                table: "DailyActivityWorkout",
                column: "DailyActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyActivityWorkout_WorkoutId",
                table: "DailyActivityWorkout",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyMeals_GoalId",
                table: "DailyMeals",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyWaterIntakes_GoalId",
                table: "DailyWaterIntakes",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyWaterIntakes_UserId",
                table: "DailyWaterIntakes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_CategoryId",
                table: "Exercises",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_UserId",
                table: "Exercises",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAllergies_AllergyId",
                table: "FoodAllergies",
                column: "AllergyId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAllergies_FoodId",
                table: "FoodAllergies",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodPortions_FoodId",
                table: "FoodPortions",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodPortions_PortionId",
                table: "FoodPortions",
                column: "PortionId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_UserId",
                table: "Foods",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_UserId",
                table: "Goals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MealFoods_FoodId",
                table: "MealFoods",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_MealFoods_MealId",
                table: "MealFoods",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_DailyMealId",
                table: "Meals",
                column: "DailyMealId");

            migrationBuilder.CreateIndex(
                name: "IX_Metrics_UserId",
                table: "Metrics",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Nutritions_FoodId",
                table: "Nutritions",
                column: "FoodId",
                unique: true,
                filter: "[FoodId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_BookingId",
                table: "Payments",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookingId",
                table: "Reviews",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ConsultantId",
                table: "Schedules",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ConsultantId",
                table: "Services",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAllergies_AllergyId",
                table: "UserAllergies",
                column: "AllergyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAllergies_UserId",
                table: "UserAllergies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFoods_UserId",
                table: "UserFoods",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_SubscriptionId",
                table: "UserSubscriptions",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_UserId",
                table: "UserSubscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterReminders_UserId",
                table: "WaterReminders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutExercises_ExerciseId",
                table: "WorkoutExercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutExercises_WorkoutId",
                table: "WorkoutExercises",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_AppUserId",
                table: "Workouts",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CertificateImages");

            migrationBuilder.DropTable(
                name: "DailyActivityWorkout");

            migrationBuilder.DropTable(
                name: "DailyWaterIntakes");

            migrationBuilder.DropTable(
                name: "FoodAllergies");

            migrationBuilder.DropTable(
                name: "FoodPortions");

            migrationBuilder.DropTable(
                name: "MealFoods");

            migrationBuilder.DropTable(
                name: "Metrics");

            migrationBuilder.DropTable(
                name: "Nutritions");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "UserAllergies");

            migrationBuilder.DropTable(
                name: "UserFoods");

            migrationBuilder.DropTable(
                name: "UserSubscriptions");

            migrationBuilder.DropTable(
                name: "WaterReminders");

            migrationBuilder.DropTable(
                name: "WorkoutExercises");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "DailyActivities");

            migrationBuilder.DropTable(
                name: "Portions");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Allergies");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropTable(
                name: "DailyMeals");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
