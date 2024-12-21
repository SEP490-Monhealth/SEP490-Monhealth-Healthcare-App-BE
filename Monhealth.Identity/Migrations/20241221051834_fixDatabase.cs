using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class fixDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VipStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VipExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "DailyStats",
                columns: table => new
                {
                    DailyStatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonthlyStatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCaloriesIntake = table.Column<float>(type: "real", nullable: false),
                    TotalCaloriesBurned = table.Column<float>(type: "real", nullable: false),
                    TotalWaterIntake = table.Column<float>(type: "real", nullable: false),
                    TotalProteins = table.Column<float>(type: "real", nullable: false),
                    TotalCarbs = table.Column<float>(type: "real", nullable: false),
                    TotalFat = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyStats", x => x.DailyStatId);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
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
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portions", x => x.PortionId);
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
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortionSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortionWeight = table.Column<float>(type: "real", nullable: false),
                    MeasurementUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                });

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    GoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                name: "InterestFoods",
                columns: table => new
                {
                    InterestFoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Categories = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foods = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nutrition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Allergies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestFoods", x => x.InterestFoodId);
                    table.ForeignKey(
                        name: "FK_InterestFoods_AspNetUsers_UserId",
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
                    MetricName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    ActivityLevel = table.Column<float>(type: "real", nullable: false),
                    Bmi = table.Column<float>(type: "real", nullable: false),
                    Bmr = table.Column<float>(type: "real", nullable: false),
                    Tdee = table.Column<float>(type: "real", nullable: false),
                    Ibw = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                name: "Vitals",
                columns: table => new
                {
                    VitalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BloodPressure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeartRate = table.Column<int>(type: "int", nullable: false),
                    BloodGlucose = table.Column<float>(type: "real", nullable: false),
                    Allergies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vitals", x => x.VitalId);
                    table.ForeignKey(
                        name: "FK_Vitals_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DailyMeals",
                columns: table => new
                {
                    DailyMealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScheduleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DailyStatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MealDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCalories = table.Column<float>(type: "real", nullable: false),
                    TotalCarbs = table.Column<float>(type: "real", nullable: false),
                    TotalProteins = table.Column<float>(type: "real", nullable: false),
                    TotalFats = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyMeals", x => x.DailyMealId);
                    table.ForeignKey(
                        name: "FK_DailyMeals_DailyStats_DailyStatId",
                        column: x => x.DailyStatId,
                        principalTable: "DailyStats",
                        principalColumn: "DailyStatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consultants",
                columns: table => new
                {
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultants", x => x.ConsultantId);
                    table.ForeignKey(
                        name: "FK_Consultants_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultants_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    FoodCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.FoodCategoryId);
                    table.ForeignKey(
                        name: "FK_FoodCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodCategories_Foods_FoodId",
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
                    PortionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutritions", x => x.NutritionId);
                    table.ForeignKey(
                        name: "FK_Nutritions_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId");
                });

            migrationBuilder.CreateTable(
                name: "Targets",
                columns: table => new
                {
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    DailyCalories = table.Column<float>(type: "real", nullable: false),
                    DailyWater = table.Column<float>(type: "real", nullable: false),
                    ExerciseMinutes = table.Column<int>(type: "int", nullable: false),
                    DailySteps = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Targets", x => x.TargetId);
                    table.ForeignKey(
                        name: "FK_Targets_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "GoalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DailyMealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MealType = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealId);
                    table.ForeignKey(
                        name: "FK_Meals_DailyMeals_DailyMealId",
                        column: x => x.DailyMealId,
                        principalTable: "DailyMeals",
                        principalColumn: "DailyMealId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealFoods",
                columns: table => new
                {
                    MealFoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PortionSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "MealUserFoods",
                columns: table => new
                {
                    MealUserFoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PortionSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealUserFoods", x => x.MealUserFoodId);
                    table.ForeignKey(
                        name: "FK_MealUserFoods_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "MealId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), null, "Khách Hàng", "Customer", "CUSTOMER" },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), null, "Quản Lí", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Dob", "Email", "EmailConfirmed", "FullName", "Gender", "LastLoginDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName", "VipExpireDate", "VipStartDate" },
                values: new object[,]
                {
                    { new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 0, null, null, "1e8832be-2a98-40c1-ab0d-5d70f42b9b76", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "khanhpham@gmail.com", true, "Nguyen Pham Khanh", null, null, false, null, "KHANHPHAM@GMAIL.COM", "KUEM113", "AQAAAAIAAYagAAAAEKQf3D66wZH2YXXWEqouzalcm4h1qctm49qs6rKchSyoEprtOgDav1EqtPQfLtXycw==", "0969998878", false, null, null, "160ee2fc-c5e7-4fdf-90f1-7e4245e74e53", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "kuem113", null, null },
                    { new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), 0, null, null, "94f2d413-16bb-438e-8842-923601ac578b", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "duythunglungtinhiu@gmail.com", true, "Pham Hoai Duy", null, null, false, null, "DUYTHUNGLUNGTINHIU", "DUYPRO113", "AQAAAAIAAYagAAAAENjp5N6Pvnli/eciT7wzZQBXleKUu9IDxQpw6lunoRM9g040mn7wRwCSeW0LZLe6aQ==", "0555666612", false, null, null, "246fe14e-d96b-4d0f-ae46-3ee844001b70", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "duypro113", null, null },
                    { new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 0, null, null, "f6356c76-eda6-42fa-bfe6-f50d5fc1f68b", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "quocdai@gmail.com", true, "Nguyen Quoc Dai", null, null, false, null, "QUOCDAI@GMAIL.COM", "DAINQ115", "AQAAAAIAAYagAAAAEBO8I0+nMOXTCyAvlScLpDqi3F5sDF+KenO7JzdIbCaKAn1y+Rs39pdJw2JU9oT+bA==", "0932748924", false, null, null, "a7723236-3311-43c6-ad9a-0101b87d0309", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dainq115", null, null },
                    { new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"), 0, null, null, "18327a55-14d4-4b5b-b48e-5952682de6a5", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "khaitoi@gmail.com", true, "Phan Van Khai", null, null, false, null, "KHAITOI@GMAIL.COM", "XAUTRAI123", "AQAAAAIAAYagAAAAEMP1U1IZI6C9Q+09PeUdv/731K6wJiIcAEiNM6J60eLkeB9wFI0VJZB/LHrCh5g1Ig==", "0777444499", false, null, null, "124dd4bb-c809-497b-8bd3-46c7bcc1b5ec", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "xautrai123", null, null },
                    { new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 0, null, null, "56a9e949-7fe7-4a74-b6cb-3f6dab48aeb7", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "quangdalat@gmail.com", true, "Quang La Tui", null, null, false, null, "QUANGDALAT@GMAIL.COM", "QUANGSPA009", "AQAAAAIAAYagAAAAEGEB4pIoFiIKvzre5mz5NNGGZDdc5v7yZMeamh3gOjA0Y5+WLS0ddf9iOZRq1EyngA==", "0999777712", false, null, null, "db597951-95f2-4dee-b3c9-48c628cdafc4", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "quangspa09", null, null },
                    { new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 0, null, null, "748ea5b7-79f9-4ff4-939c-f45ed64a09b6", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "toanvan@gmail.com", true, "Van Huu Toan", null, null, false, null, "TOANVAN@GMAIL.COM", "VIPRO123", "AQAAAAIAAYagAAAAEKRofNARpYjcaNqKPOUv8XSDPCO4nbGai9EentZvzORP8CiyQu4+wP5lxf2bcw6TKg==", "0999998888", false, null, null, "ce13b708-f294-490f-a348-29907180ab5a", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "vipro123", null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), "Thực phẩm đã qua quá trình lên men, mang lại hương vị độc đáo và chứa probiotics, như kim chi hoặc sữa chua.", "Lên men", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), "Thực phẩm giàu protein, bao gồm thịt, đậu, trứng, và các loại hạt, cần thiết cho việc xây dựng và sửa chữa cơ bắp.", "Giàu protein", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), "Các bữa ăn không có thịt hoặc cá, tập trung vào rau củ và ngũ cốc.", "Đồ ăn chay", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), "Các món ăn đậm đà, cay nóng, thường được tăng cường với ớt và gia vị.", "Nhiều gia vị", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), "Thực phẩm có hàm lượng năng lượng (calo) thấp, thường được thiết kế để hỗ trợ kiểm soát cân nặng hoặc duy trì sức khỏe.", "Ít calo", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), "Thức ăn nhiều carbohydrate (carb) thường là những thực phẩm chứa hàm lượng tinh bột hoặc đường cao.", "Nhiều carbs", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), "Thực phẩm được trồng mà không sử dụng thuốc trừ sâu tổng hợp hoặc phân bón, tập trung vào tính bền vững và sức khỏe.", "Hữu cơ", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), "Thực phẩm đã qua xử lý để thay đổi trạng thái tự nhiên của chúng thông qua các phương pháp như đóng hộp, đông lạnh hoặc thêm chất bảo quản.", "Chế biến sẵn", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), "Các bữa ăn nhanh, tiện lợi, thường được phục vụ trong môi trường nhịp độ nhanh.", "Fast food", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), "Thực phẩm giàu chất xơ, giúp thúc đẩy sức khỏe tiêu hóa, chẳng hạn như trái cây, rau và ngũ cốc nguyên hạt.", "Giàu chất xơ", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), "Món tráng miệng hoặc đồ ăn giàu đường, mang lại hương vị ngọt ngào, thỏa mãn.", "Đồ ngọt", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), "Cá tươi, động vật có vỏ, và các sinh vật biển khác, mang lại hương vị đậm đà của đại dương.", "Hải sản", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "CreatedAt", "CreatedBy", "FoodDescription", "FoodName", "FoodType", "MeasurementUnit", "PortionSize", "PortionWeight", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("00a16b6c-9396-4389-95fd-205f72fe5164"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nem chua", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("3b372064-e2a9-4729-b725-635e54e11c5d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Bún tươi", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Tôm biển", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khoai tây", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("80c5e605-307f-4fef-bdf8-9967a800eab9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mãng cầu", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Chuối tây", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("a3be942d-a225-44fb-9c98-22a109995145"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Thịt heo nạc", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Sầu riêng", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Đậu phộng", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("b6fa82bc-715c-42da-af22-93290d3f2421"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Cơm trắng", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("c4f9e44d-b7f6-4530-8b2e-b64c8f993f2a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Thịt bò", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("c567f8a9-71e4-4167-839d-a839ece79427"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Bỏng ngô", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("c82a256d-5573-4d27-b045-a411db42e694"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Xúc xích", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("ced123e2-0b86-444b-ac83-7dba6860e354"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Chả giò", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("d4f8f2c7-5318-4f07-803d-2b093be4d6c7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Bưởi", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("d65bff7e-4a2d-498b-97b2-676d4dd92a90"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Bắp luộc", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("dd918def-34c2-4f5c-b402-6d51d8a1c604"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Bầu", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("e1b0767d-4b3b-42ea-820f-2154f7883ab9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nấm kim châm", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Giá đỗ", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("f789601f-8026-499b-98cb-0f189926094a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Rau muống", "", "", "", 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "FoodCategoryId", "CategoryId", "FoodId" },
                values: new object[,]
                {
                    { new Guid("008dbfb1-2fa6-4bb6-8313-0d15afb5a217"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new Guid("d65bff7e-4a2d-498b-97b2-676d4dd92a90") },
                    { new Guid("17d4b096-43fb-4ead-aa15-b4f3796a0095"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new Guid("b6fa82bc-715c-42da-af22-93290d3f2421") },
                    { new Guid("232587aa-9171-4816-80de-3f2ca21e7809"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new Guid("ced123e2-0b86-444b-ac83-7dba6860e354") },
                    { new Guid("2824c391-f2a7-4b96-b54d-72d49d224c6c"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new Guid("3b372064-e2a9-4729-b725-635e54e11c5d") },
                    { new Guid("2f71d694-34fa-4e27-9a45-c85636ae80c4"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new Guid("e1b0767d-4b3b-42ea-820f-2154f7883ab9") },
                    { new Guid("38e471a8-d7f3-4885-9873-8ace803a6e26"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new Guid("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9") },
                    { new Guid("400db0ab-1a3e-4de5-b0e0-68a01663c2e7"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new Guid("c567f8a9-71e4-4167-839d-a839ece79427") },
                    { new Guid("448b576b-aeb6-43ea-9040-09d47c5eaa42"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new Guid("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7") },
                    { new Guid("4528e935-231a-4069-b5ee-f07c99b14170"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new Guid("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91") },
                    { new Guid("4584e6b9-8c30-490f-af08-52f093f1d294"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new Guid("e1b0767d-4b3b-42ea-820f-2154f7883ab9") },
                    { new Guid("46f54659-1d67-4107-96a5-124a5302d873"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new Guid("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f") },
                    { new Guid("4f80dc13-5a25-48ae-8563-5c3e998aaf63"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new Guid("dd918def-34c2-4f5c-b402-6d51d8a1c604") },
                    { new Guid("542ed436-d4ab-44e9-971d-f3fd64b1d305"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new Guid("c567f8a9-71e4-4167-839d-a839ece79427") },
                    { new Guid("54f2de38-ce45-4168-80e7-74b1574f6401"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new Guid("80c5e605-307f-4fef-bdf8-9967a800eab9") },
                    { new Guid("714cb573-594e-47d0-a017-2f51d1588bf8"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new Guid("f789601f-8026-499b-98cb-0f189926094a") },
                    { new Guid("71cd5ed0-003e-4185-8001-ab4bfba3cd21"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new Guid("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91") },
                    { new Guid("7b42248c-c0c4-46b7-aa60-2bf7f7dcc2c7"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new Guid("d4f8f2c7-5318-4f07-803d-2b093be4d6c7") },
                    { new Guid("8dbd85a6-ab87-43db-a763-81ee66f10dd0"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new Guid("3b372064-e2a9-4729-b725-635e54e11c5d") },
                    { new Guid("a4927114-6501-4c79-a466-42ae40364b9d"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new Guid("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f") },
                    { new Guid("a82c5ca4-16d0-4f8c-aca7-0c8a8eb9c195"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new Guid("a3be942d-a225-44fb-9c98-22a109995145") },
                    { new Guid("b534c4d6-bd93-4825-8866-05a8d7a282cb"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new Guid("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db") },
                    { new Guid("b88c6718-9bbd-4efa-8cac-6aafdc1e27f8"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new Guid("dd918def-34c2-4f5c-b402-6d51d8a1c604") },
                    { new Guid("bdcd6f3c-4844-418b-9ed9-95a58fe9c518"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new Guid("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91") },
                    { new Guid("c412b3ae-23d1-4f64-9cb2-b4208f29c1c4"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new Guid("f789601f-8026-499b-98cb-0f189926094a") },
                    { new Guid("c4e7cbb0-fe65-4fee-bcce-bc43ef5aab15"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new Guid("d4f8f2c7-5318-4f07-803d-2b093be4d6c7") },
                    { new Guid("c8f19b8c-8487-4c74-acc9-5e6c1cf5a80b"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new Guid("00a16b6c-9396-4389-95fd-205f72fe5164") },
                    { new Guid("cab91050-7489-4967-93c7-62bd2cd64a9f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new Guid("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552") },
                    { new Guid("cc1a2489-196e-4f98-b68e-785f9842b4e5"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new Guid("d4f8f2c7-5318-4f07-803d-2b093be4d6c7") },
                    { new Guid("d340e3a2-f56c-48be-b33b-93e1c655abd4"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new Guid("c82a256d-5573-4d27-b045-a411db42e694") },
                    { new Guid("da9f39bb-9e03-447a-8874-220b14b2bea7"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new Guid("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9") },
                    { new Guid("e0ff9c14-ff0e-46ce-b1e2-b4eec545f188"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new Guid("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7") },
                    { new Guid("e7265736-1531-47b1-a665-bcecdac73bd2"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new Guid("c4f9e44d-b7f6-4530-8b2e-b64c8f993f2a") },
                    { new Guid("ecd2cc49-a429-4f77-b074-d5bdf407b720"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new Guid("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db") },
                    { new Guid("f6e1ebb2-9c7a-424a-803c-2b7cb7747fce"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new Guid("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552") },
                    { new Guid("ff7d6a78-5d2d-4475-910a-154e395c5426"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new Guid("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f") }
                });

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
                name: "IX_Consultants_DepartmentId",
                table: "Consultants",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultants_UserId",
                table: "Consultants",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DailyMeals_DailyStatId",
                table: "DailyMeals",
                column: "DailyStatId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategories_CategoryId",
                table: "FoodCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategories_FoodId",
                table: "FoodCategories",
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
                name: "IX_Foods_UserId",
                table: "Foods",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_UserId",
                table: "Goals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_InterestFoods_UserId",
                table: "InterestFoods",
                column: "UserId",
                unique: true);

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
                name: "IX_MealUserFoods_MealId",
                table: "MealUserFoods",
                column: "MealId");

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
                name: "IX_Targets_GoalId",
                table: "Targets",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Vitals_UserId",
                table: "Vitals",
                column: "UserId");
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
                name: "Consultants");

            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropTable(
                name: "FoodPortions");

            migrationBuilder.DropTable(
                name: "InterestFoods");

            migrationBuilder.DropTable(
                name: "MealFoods");

            migrationBuilder.DropTable(
                name: "MealUserFoods");

            migrationBuilder.DropTable(
                name: "Metrics");

            migrationBuilder.DropTable(
                name: "Nutritions");

            migrationBuilder.DropTable(
                name: "Targets");

            migrationBuilder.DropTable(
                name: "Vitals");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Portions");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "DailyMeals");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DailyStats");
        }
    }
}
