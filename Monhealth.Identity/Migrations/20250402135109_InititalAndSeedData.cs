using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class InititalAndSeedData : Migration
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
                    AllergyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                name: "Banks",
                columns: table => new
                {
                    BankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.BankId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryType = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "DishTypes",
                columns: table => new
                {
                    DishTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DishTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishTypes", x => x.DishTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Expertise",
                columns: table => new
                {
                    ExpertiseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpertiseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertiseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expertise", x => x.ExpertiseId);
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
                    SubscriptionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    DurationDays = table.Column<int>(type: "int", nullable: false),
                    Features = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingAllowance = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
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
                name: "TimeSlots",
                columns: table => new
                {
                    TimeSlotId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlots", x => x.TimeSlotId);
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
                name: "Exercises",
                columns: table => new
                {
                    ExerciseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExerciseType = table.Column<int>(type: "int", nullable: false),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaloriesPerMinute = table.Column<float>(type: "real", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MealType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    GoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalType = table.Column<int>(type: "int", nullable: false),
                    WeightGoal = table.Column<float>(type: "real", nullable: false),
                    CaloriesRatio = table.Column<float>(type: "real", nullable: false),
                    CaloriesGoal = table.Column<float>(type: "real", nullable: false),
                    ProteinGoal = table.Column<float>(type: "real", nullable: false),
                    CarbsGoal = table.Column<float>(type: "real", nullable: false),
                    FatGoal = table.Column<float>(type: "real", nullable: false),
                    FiberGoal = table.Column<float>(type: "real", nullable: false),
                    SugarGoal = table.Column<float>(type: "real", nullable: false),
                    WaterIntakesGoal = table.Column<float>(type: "real", nullable: false),
                    WorkoutDurationGoal = table.Column<float>(type: "real", nullable: false),
                    CaloriesBurnedGoal = table.Column<float>(type: "real", nullable: false),
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                name: "UserCategories",
                columns: table => new
                {
                    UserCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCategories", x => x.UserCategoryId);
                    table.ForeignKey(
                        name: "FK_UserCategories_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    WorkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkoutType = table.Column<int>(type: "int", nullable: false),
                    WorkoutName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkoutDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DifficultyLevel = table.Column<int>(type: "int", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false),
                    DurationMinutes = table.Column<float>(type: "real", nullable: false),
                    CaloriesBurned = table.Column<float>(type: "real", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.WorkoutId);
                    table.ForeignKey(
                        name: "FK_Workouts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Workouts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consultants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpertiseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    BookingCount = table.Column<int>(type: "int", nullable: false),
                    RatingCount = table.Column<double>(type: "float", nullable: false),
                    AverageRating = table.Column<double>(type: "float", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consultants_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Consultants_Expertise_ExpertiseId",
                        column: x => x.ExpertiseId,
                        principalTable: "Expertise",
                        principalColumn: "ExpertiseId");
                });

            migrationBuilder.CreateTable(
                name: "UserSubscriptions",
                columns: table => new
                {
                    UserSubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RemainingBookings = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
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
                name: "CategoryFoods",
                columns: table => new
                {
                    CategoryFoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryFoods", x => x.CategoryFoodId);
                    table.ForeignKey(
                        name: "FK_CategoryFoods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryFoods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DishTypeFoods",
                columns: table => new
                {
                    DishTypeFoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DishTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishTypeFoods", x => x.DishTypeFoodId);
                    table.ForeignKey(
                        name: "FK_DishTypeFoods_DishTypes_DishTypeId",
                        column: x => x.DishTypeId,
                        principalTable: "DishTypes",
                        principalColumn: "DishTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DishTypeFoods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Nutrition",
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
                    table.PrimaryKey("PK_Nutrition", x => x.NutritionId);
                    table.ForeignKey(
                        name: "FK_Nutrition_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DailyActivities",
                columns: table => new
                {
                    DailyActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalCaloriesBurned = table.Column<float>(type: "real", nullable: false),
                    TotalDurationMinutes = table.Column<float>(type: "real", nullable: false),
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
                        name: "FK_DailyMeals_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DailyMeals_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "GoalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DailyWaterIntakes",
                columns: table => new
                {
                    DailyWaterIntakeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "WorkoutExercises",
                columns: table => new
                {
                    WorkoutExerciseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    DurationSeconds = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CancellationReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReviewed = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    CertificateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpertiseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CertificateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IssuedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.CertificateId);
                    table.ForeignKey(
                        name: "FK_Certificates_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.ChatId);
                    table.ForeignKey(
                        name: "FK_Chats_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chats_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsultantBanks",
                columns: table => new
                {
                    ConsultantBankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultantBanks", x => x.ConsultantBankId);
                    table.ForeignKey(
                        name: "FK_ConsultantBanks_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "BankId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsultantBanks_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ScheduleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScheduleType = table.Column<int>(type: "int", nullable: false),
                    RecurringDay = table.Column<int>(type: "int", nullable: true),
                    SpecificDate = table.Column<DateOnly>(type: "date", nullable: true),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ScheduleId);
                    table.ForeignKey(
                        name: "FK_Schedules_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Schedules_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    WalletId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Balance = table.Column<float>(type: "real", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.WalletId);
                    table.ForeignKey(
                        name: "FK_Wallets_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WithdrawalRequests",
                columns: table => new
                {
                    WithdrawalRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WithdrawalRequests", x => x.WithdrawalRequestId);
                    table.ForeignKey(
                        name: "FK_WithdrawalRequests_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserSubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_UserSubscriptions_UserSubscriptionId",
                        column: x => x.UserSubscriptionId,
                        principalTable: "UserSubscriptions",
                        principalColumn: "UserSubscriptionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DailyActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WorkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_Activities_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Activities_DailyActivities_DailyActivityId",
                        column: x => x.DailyActivityId,
                        principalTable: "DailyActivities",
                        principalColumn: "DailyActivityId");
                    table.ForeignKey(
                        name: "FK_Activities_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "WorkoutId");
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DailyMealId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MealType = table.Column<int>(type: "int", nullable: false),
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
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Messages_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "ChatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleExceptions",
                columns: table => new
                {
                    ScheduleExceptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScheduleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleExceptions", x => x.ScheduleExceptionId);
                    table.ForeignKey(
                        name: "FK_ScheduleExceptions_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "ScheduleId");
                });

            migrationBuilder.CreateTable(
                name: "ScheduleTimeSlots",
                columns: table => new
                {
                    ScheduleTimeSlotId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScheduleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TimeSlotId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleTimeSlots", x => x.ScheduleTimeSlotId);
                    table.ForeignKey(
                        name: "FK_ScheduleTimeSlots_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "ScheduleId");
                    table.ForeignKey(
                        name: "FK_ScheduleTimeSlots_TimeSlots_TimeSlotId",
                        column: x => x.TimeSlotId,
                        principalTable: "TimeSlots",
                        principalColumn: "TimeSlotId");
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WalletId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<float>(type: "real", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_Transactions_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId");
                    table.ForeignKey(
                        name: "FK_Transactions_Wallets_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallets",
                        principalColumn: "WalletId",
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
                    IsRecommended = table.Column<bool>(type: "bit", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
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
                columns: new[] { "AllergyId", "AllergyDescription", "AllergyName", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0eec9d43-391c-43c6-9635-01ca2d6fc66c"), "Dị ứng với các loại hạt như hạt điều, hạt hạnh nhân cũng có thể gây ra phản ứng mạnh, đặc biệt là đối với những người có cơ địa nhạy cảm", "Các loại hạt", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), "Dị ứng với lúa mì, thường gặp ở những người không dung nạp gluten", "Lúa mì", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("4d6270d3-69c6-4b9f-9c11-125369139775"), "Dị ứng với hạt vừng (mè) có thể gây phát ban, ngứa, và có thể nghiêm trọng nếu không được kiểm soát", "Hạt vừng", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), "Dị ứng với hải sản có vỏ như tôm, cua, sò, nghêu rất phổ biến ở Việt Nam và có thể gây phản ứng dị ứng nặng, từ phát ban đến khó thở", "Hải sản có vỏ", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("99b9eae6-f5e8-4b41-9394-6a8f2ca1062b"), "Dị ứng với đậu phộng khá phổ biến và có thể gây phản ứng nghiêm trọng như sưng tấy, phát ban, khó thở, hoặc sốc phản vệ", "Đậu phộng", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), "Dị ứng cá cũng khá phổ biến và có thể gây ra các phản ứng nghiêm trọng như phát ban, sưng, hoặc khó thở", "Cá", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), "Dị ứng sữa có thể gây ngứa, phát ban, hoặc tiêu chảy ở một số người, đặc biệt là trẻ em", "Sữa", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), "Dị ứng với đậu nành khá phổ biến và có thể gây phát ban, ngứa, hoặc khó thở. Đậu nành là thành phần chính trong nhiều món ăn và thực phẩm chế biến sẵn tại Việt Nam", "Đậu nành", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), "Dị ứng trứng là một trong những dị ứng thực phẩm phổ biến, đặc biệt là ở trẻ em. Triệu chứng có thể bao gồm phát ban, ngứa, hoặc khó thở", "Trứng", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), null, "Thành viên", "Subscription Member", "SUBSCRIPTION MEMBER" },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), null, "Người dùng", "Member", "MEMBER" },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), null, "Tư vấn viên", "Consultant", "CONSULTANT" },
                    { new Guid("d21edfd6-42d5-490a-a41c-43f7ef09c61f"), null, "Quản trị viên", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F9c0e576b-c736-4c13-8f21-aa0b1649fe5c.jpg?alt=media&token=236a11b7-836c-4735-b4c8-109a58b41e45", "7e3b9dfd-cff1-44e1-b0fb-defecdd3291b", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "khanhpham@gmail.com", true, "Nguyen Pham Khanh", false, null, "KHANHPHAM@GMAIL.COM", "KUEM113", "AQAAAAIAAYagAAAAEJpBNjBr5cBzkw5yKwy9DdChjxzAZ0YOVUFDZ7nFMpXpDefkVZGX1yh3229WUgwI4g==", "0368309526", false, null, null, "d3fc2cc1-2678-4281-9295-aaf63b8026af", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "kuem113" },
                    { new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F467b63b9-c4c2-42c2-ba5a-71f294681586.jpg?alt=media&token=89eb5119-1669-4515-9dc6-9130672d3d50", "2f957c26-3f3d-4efe-b585-dc9240a52a77", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "duythunglungtinhiu@gmail.com", true, "Pham Hoai Duy", false, null, "DUYTHUNGLUNGTINHIU", "DUYPRO113", "AQAAAAIAAYagAAAAEGq+MXwgRSZoW6RsPxybuIpHtNwigAoMN5+pzjK9XksWk1YdSqBNG0j+i4lHbm14yQ==", "0967588443", false, null, null, "0f09aec6-4285-4064-8ed8-c5fa6845db59", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "duypro113" },
                    { new Guid("20041d5b-01e4-443f-9652-e39beb9748e5"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F92077987-c716-4efc-b039-12268e8cb97d.jpg?alt=media&token=903adb9c-41c4-4482-a439-3c758b3c050d", "e872acde-a5eb-4b58-ba75-f771106f3063", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "consultant@gmail.com", true, "Van Huu Toan Con", false, null, "CONSULTANT@GMAIL.COM", "0987654321", "AQAAAAIAAYagAAAAEJ4svruRuijn+aI4uf6uC0u+Y9oaeNphtyTz2M+QUU7s0jn5sIKiOe7AIZFu2WhMkg==", "0987654321", false, null, null, "5ec45874-fa4d-4e39-98d8-0c007e71d49e", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "toanconsultant" },
                    { new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2Fef00731b-724a-4e80-8930-36b2abffbec6.jpg?alt=media&token=408e26ce-b249-4139-a919-5cac9082c35c", "ff4eaa8c-11ff-4eed-82ed-51c9dde8f3dd", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quocdai@gmail.com", true, "Nguyen Quoc Dai", false, null, "QUOCDAI@GMAIL.COM", "DAINQ115", "AQAAAAIAAYagAAAAENw4bFCS4AlAYSnLrXFUnunBFOSqewTH6rl2tj7udIMIcW/WM5BGvtxV45lwt47fmg==", "0932748924", false, null, null, "8fc3ead4-efa7-466d-9400-a21a521feb59", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "dainq115" },
                    { new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Ftests%2Fangrycat.jpg?alt=media&token=542becf5-173f-47c2-951b-b9f79578fa60", "bbca82d0-b6b6-487d-b4bc-a56c581d403e", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "asd@gmail.com", true, "asd", false, null, "ASD@GMAIL.COM", "ASD", "AQAAAAIAAYagAAAAEHT6iyYdyGC9AvQDquiKjvcGoc7lJorHD7lZJ5elbg44/hJo9ju8slRdoXyLo446Aw==", "0123456789", false, null, null, "e5f95f41-3d62-4820-9d24-5ed2cf478129", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "asd" },
                    { new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2Fcb927cfb-c88a-48c6-abf7-e77c9ca1982d.jpg?alt=media&token=e6cbb66c-6ecb-45ef-ac25-29511f9e7adb", "ee52cd75-8179-492c-a492-4cd024a9778b", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "khaitoi@gmail.com", true, "Phan Van Khai", false, null, "KHAITOI@GMAIL.COM", "XAUTRAI123", "AQAAAAIAAYagAAAAEDpkoML9TRWskY6V8KFNzTymtNoZZYdbJfEV8fLTl8qlFgAlOZtFxdOou5o5ZF+RNQ==", "0963122758", false, null, null, "1c70f766-960b-4ccb-b99c-a34320f24065", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "xautrai123" },
                    { new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F16296811-d53d-4415-a907-e899e206b492.jpg?alt=media&token=819eaa35-ae0f-4dc3-815d-4dc19ab22782", "98f5d1df-7380-4963-81d6-e2c6280bcb25", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quangdalat@gmail.com", true, "Quang La Tui", false, null, "QUANGDALAT@GMAIL.COM", "QUANGSPA009", "AQAAAAIAAYagAAAAEA+NAKtznCY9zyoqAgSmCjDl+voerWm9dnO168xMxzB2wyPS6gnldfBeDV6o8oFRSw==", "0999777712", false, null, null, "32e673f1-6e2f-4186-8b85-6ee2695d9b66", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quangspa09" },
                    { new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F92077987-c716-4efc-b039-12268e8cb97d.jpg?alt=media&token=903adb9c-41c4-4482-a439-3c758b3c050d", "39ebdbdd-238b-4dbf-8c6a-dd13a5399148", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "toanvan@gmail.com", true, "Van Huu Toan", false, null, "TOANVAN@GMAIL.COM", "VIPRO123", "AQAAAAIAAYagAAAAEICwOZUAK7niODb3aQTCiGK5GFRo+pD/q+52Kg8I2nbFVz5z7PHClHOfw09emWdJBA==", "0792766979", false, null, null, "8e0f4dba-b19e-4eb4-8198-1300a38b0308", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "vipro123" }
                });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "BankId", "BankCode", "BankName", "CreatedAt", "CreatedBy", "LogoUrl", "ShortName", "Status", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("009adde6-d708-46ae-8573-0d5be51036bf"), "VNPTMONEY", "VNPT Money", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VNPTMONEY.svg", "VNPTMoney", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("00de26cc-e81f-4ddf-993f-51110ac79169"), "SHBVN", "Ngân hàng TNHH MTV Shinhan Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SHBVN.svg", "ShinhanBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("035524ce-c085-4c2f-ae16-42b56fccfba9"), "WOO", "Ngân hàng TNHH MTV Woori Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/WVN.svg", "Woori", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("04d81ed6-6565-4aef-b1d2-f32a44a1b652"), "KBKHCM", "Ngân hàng Kookmin - Chi nhánh Thành phố Hồ Chí Minh", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/KBHCM.svg", "KookminHCM", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("099fb4a6-25a7-4345-ba68-bb16b8aebd07"), "PGB", "Ngân hàng TMCP Xăng dầu Petrolimex", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/PGB.svg", "PGBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("0c123c39-eba5-4a9d-9b46-33ce304e78ac"), "KB", "Ngân hàng Đại chúng TNHH Kasikornbank", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/KBank.svg", "Kasikornbank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("16d53d08-bb66-4208-81e4-dab7d946fa97"), "ACB", "Ngân hàng TMCP Á Châu", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/ACB.svg", "ACB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("18f079b1-8111-4a5b-b2f3-2d942b8743c8"), "PBVN", "Ngân hàng TNHH MTV Public Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/PBVN.svg", "PublicBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("1c9ddb41-cf1f-48ca-9522-32761844f8b2"), "TPB", "Ngân hàng TMCP Tiên Phong", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/TPB.svg", "TPBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("1ed70027-ab0b-484d-946d-e68e2bae4b2f"), "NCB", "Ngân hàng TMCP Quốc Dân", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/NCB.svg", "NCB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("20d66011-82a8-472f-9792-8bae86c7e3bd"), "SHB", "Ngân hàng TMCP Sài Gòn - Hà Nội", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SHB.svg", "SHB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("3037e7eb-84cb-4e9a-96bc-5d5e53e3dbf3"), "SCBVN", "Ngân hàng TNHH MTV Standard Chartered Bank Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SCVN.svg", "Standard Chartered VN", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("345b71ae-9e30-49da-adb2-9e84d7202f67"), "DAB", "Ngân hàng TNHH MTV Số Vikki", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/DOB.svg", "VikkiBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("38902e06-57bc-4ceb-b29a-a03f59946c8d"), "STB", "Ngân hàng TMCP Sài Gòn Thương Tín", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/STB.svg", "Sacombank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("3d3edefc-d773-4ed7-885a-520e8dc5437f"), "VCB", "Ngân hàng TMCP Ngoại thương Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VCB.svg", "Vietcombank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("4e85031a-67cb-45d1-b03e-905cc5e90610"), "HSBC", "Ngân hàng TNHH MTV HSBC (Việt Nam)", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/HSBC.svg", "HSBC", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("4f5980ec-80cb-461c-b49c-c816639b7312"), "HDB", "Ngân hàng TMCP Phát triển Thành phố Hồ Chí Minh", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/HDB.svg", "HDBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("51d0d8b4-256c-4bef-9a10-226fde21c0d1"), "IVB", "Ngân hàng TNHH Indovina", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/IVB.svg", "Indovina Bank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("57e2830a-4e10-4cd6-8e67-be5054b8dc00"), "VAB", "Ngân hàng TMCP Việt Á", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VAB.svg", "VietABank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("66936d52-f5db-404f-b090-6ba093dae3e2"), "NHB", "Ngân hàng Nonghyup - Chi nhánh Hà Nội", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/NHB HN.svg", "Nonghyup", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("68cb611a-7d92-4f9d-830f-a717f6909dd8"), "VTB", "Ngân hàng TMCP Công thương Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/ICB.svg", "VietinBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("6d2f2c39-16af-4395-8e37-313ef8d372b0"), "NAB", "Ngân hàng TMCP Nam Á", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/NAB.svg", "NamABank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("72e8cd9c-f6d6-4352-a04b-df3c6fb47bd5"), "DBS", "DBS Bank Ltd - Chi nhánh Thành phố Hồ Chí Minh", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/DBS.svg", "DBSBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("73a91cf1-a606-40fa-995f-1e0003a0f09d"), "UOB", "Ngân hàng United Overseas", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/UOB.svg", "United Overseas Bank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("747a186c-5f25-4c74-a1af-e1296ed35287"), "VARB", "Ngân hàng Nông nghiệp và Phát triển Nông thôn Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VBA.svg", "Agribank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("7994204d-0d6e-4f7e-86eb-a5a3ca5aaeb8"), "KLB", "Ngân hàng TMCP Kiên Long", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/KLB.svg", "KienLongBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("7d5a07a8-9d6c-42af-94ad-84f51dbd70ba"), "EIB", "Ngân hàng TMCP Xuất nhập khẩu Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/EIB.svg", "Eximbank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("82239a8d-0aa7-4656-a1ac-ade94a2fae1a"), "OJB", "Ngân hàng Thương mại TNHH MTV Đại Dương", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/Oceanbank.svg", "OceanBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("8398acf1-8d30-495a-b023-155bc60f7fc1"), "VB", "Ngân hàng TMCP Việt Nam Thương Tín", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VIETBANK.svg", "VietBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("876130fc-9136-4fc2-9d4b-6626b8279f6d"), "KBKHN", "Ngân hàng Kookmin - Chi nhánh Hà Nội", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/KBHN.svg", "KookminHN", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("89917c8f-008a-4224-ba24-3ce93e2dc4f8"), "CBB", "Ngân hàng Thương mại TNHH MTV Xây dựng Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/CBB.svg", "CBBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("901da6fb-3b0a-43c0-bc97-db77927e892c"), "BVB", "Ngân hàng TMCP Bảo Việt", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/BVB.svg", "BaoVietBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("936666c3-12f6-406b-9de9-8367233aa6ba"), "BIDV", "Ngân hàng TMCP Đầu tư và Phát triển Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/BIDV.svg", "BIDV", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("93701d4e-2c9e-4a5b-bd86-442a52a232e8"), "MSB", "Ngân hàng TMCP Hàng Hải", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/MSB.svg", "MSB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("99d7091d-5129-403d-991d-c2d563f2f849"), "VTLMONEY", "Viettel Money", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VTLMONEY.svg", "ViettelMoney", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("9f29e0b1-2036-4da3-a389-98c989624f16"), "SGCB", "Ngân hàng TMCP Sài Gòn", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SCB.svg", "SCB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("a26aeeef-eb06-4bc1-933b-6635cf4e0f5e"), "GPB", "Ngân hàng Thương mại TNHH MTV Dầu Khí Toàn Cầu", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/GPB.svg", "GPBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("abc33e6c-11c8-41c2-90fc-ffea67ab2dd8"), "VRB", "Ngân hàng Liên doanh Việt - Nga", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VRB.svg", "VRB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("b27ca424-2817-4aa9-a906-a0be5a3eb2da"), "VIB", "Ngân hàng TMCP Quốc tế Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VIB.svg", "VIB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("b40b93b8-37eb-449d-aa46-b1ac0a2314be"), "LPB", "Ngân hàng TMCP Lộc Phát Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/LPB.svg", "LPBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("bc859b72-c388-44f3-85f3-b31207187b16"), "IBKHCM", "Ngân hàng Công nghiệp Hàn Quốc - Chi nhánh TP. Hồ Chí Minh", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/IBK - HCM.svg", "IBKHCM", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("bfd79a5a-5f06-45ba-b2fa-12d69e85c8b1"), "COOPB", "Ngân hàng Hợp tác xã Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/COOPBANK.svg", "Co-op Bank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("c63ee167-ef7c-42e6-ba5b-68ebbddd5b47"), "SGB", "Ngân hàng TMCP Sài Gòn Công Thương", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SGICB.svg", "SaigonBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("ca6d9a8c-1f7c-407a-b08b-aba836481dc7"), "VPB", "Ngân hàng TMCP Việt Nam Thịnh Vượng", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VPB.svg", "VPBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("cd225e30-5dc2-44df-9669-5b58cce25d2f"), "SEAB", "Ngân hàng TMCP Đông Nam Á", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SEAB.svg", "SeABank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("d221e434-e687-4175-bc34-ff5b46ca927a"), "CAKE", "TMCP Việt Nam Thịnh Vượng - Ngân hàng số CAKE by VPBank", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/CAKE.svg", "CAKE", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("d260184d-9905-4587-8736-deb7ec5b283e"), "TCB", "Ngân hàng TMCP Kỹ thương Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/TCB.svg", "Techcombank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("d8ec328b-0587-4eb5-a1c3-88c6c80a6036"), "TIMO", "Ngân hàng số Timo", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/TIMO.svg", "Timo", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("d94a215c-74ac-49ad-a572-ba19bd393638"), "VCCB", "Ngân hàng TMCP Bản Việt", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VCCB.svg", "Ngân hàng Bản Việt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("de49ea97-b2c9-4393-9655-27c94e246519"), "UB", "TMCP Việt Nam Thịnh Vượng - Ngân hàng số Ubank by VPBank", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/Ubank.svg", "Ubank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("dfe24ec9-90ef-49c2-b6eb-7877532c0535"), "CIMB", "Ngân hàng TNHH MTV CIMB Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/CIMB.svg", "CIMB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("e2672dd1-6e7e-453d-a82a-ce87b6bc6cf5"), "OCB", "Ngân hàng TMCP Phương Đông", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/OCB.svg", "OCB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("e6806c80-4960-45d8-a726-8984f7fe0063"), "ABB", "Ngân hàng TMCP An Bình", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/ABB.svg", "ABBANK", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("edd76d4d-5faa-4010-b829-f1c0913e4e5f"), "BAB", "Ngân hàng TMCP Bắc Á", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/BAB.svg", "BacABank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("eefebf68-6467-407f-a4bb-ce1f59acdb93"), "IBKHN", "Ngân hàng Công nghiệp Hàn Quốc - Chi nhánh Hà Nội", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/IBK - HN.svg", "IBKHN", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("fcef7e56-0d2c-4a13-9628-f6ab61162623"), "PVCB", "Ngân hàng TMCP Đại Chúng Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/PVCB.svg", "PVcomBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("fe7d5da0-4de5-46f8-bc5c-9c301aa51ddc"), "HLB", "Ngân hàng TNHH MTV Hong Leong Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/HLBVN.svg", "Hong Leong Bank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("ffb2de4b-1ef7-40d3-b457-2e5bd610e4dd"), "MB", "Ngân hàng TMCP Quân đội", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/MB.svg", "MBBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName", "CategoryType", "CreatedAt", "CreatedBy", "ImageUrl", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), "Bài tập tập trung vào cơ bắp vai, ngực, lưng và tay.", "Thân trên", 1, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), "Hoa quả tươi hoặc chế biến như salad trái cây, nước ép, sinh tố, cung cấp vitamin và khoáng chất", "Trái cây", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fapple.png?alt=media&token=106a39ee-5c36-4c27-8bbe-c850ee19cb02", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), "Các món ăn từ thực vật, đậu phụ, và nguyên liệu không sử dụng thịt, phù hợp với người ăn chay hoặc muốn đổi vị thanh đạm", "Món chay", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fradish.png?alt=media&token=c27e26f3-3f39-42ec-bf40-94c9abb074d5", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), "Bài tập tập trung vào cơ bắp chân, mông, đùi và hông.", "Thân dưới", 1, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("4575699a-5bb6-42ec-9d52-ea19d1170187"), "Bài tập tăng cường cơ bụng, cải thiện sự săn chắc và thon gọn vùng bụng.", "Bụng", 1, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), "Gạo, mì, bánh mì, yến mạch, và các loại hạt ngũ cốc. Là nguồn cung cấp năng lượng chính trong ngày", "Ngũ cốc", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Frice.png?alt=media&token=1ef6ca23-003f-4415-9ce4-3a3f5cd8e65e", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), "Món ăn từ rau xanh, củ quả và nấm. Phù hợp cho những ai yêu thích thực phẩm tươi sạch, giàu dinh dưỡng", "Rau củ", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbroccoli.png?alt=media&token=6746e0eb-bcf0-44d1-830a-79821f735f84", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), "Bánh ngọt, kẹo, kem, và các món tráng miệng ngọt ngào, lý tưởng cho những ai yêu thích đồ ngọt", "Món ngọt", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcupcake.png?alt=media&token=8721bd49-186f-4ccf-a85a-64008e4c8e38", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), "Bao gồm các món ăn từ thịt bò, thịt gà, thịt lợn, thịt vịt và các loại thịt khác. Là lựa chọn phổ biến trong bữa ăn chính", "Thịt", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fsteak.png?alt=media&token=dfffb9c2-2964-40cc-8712-e83b4200e7af", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), "Pizza, burger, khoai tây chiên, gà rán, và các món ăn tiện lợi, phù hợp cho những ai bận rộn", "Đồ ăn nhanh", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fburger.png?alt=media&token=66dd457f-64d3-4b66-851c-10eba13fdc7d", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), "Các món ăn từ tôm, cá, cua, mực, hàu, sò và các loại hải sản khác. Thích hợp cho những ai yêu thích hương vị biển cả", "Hải sản", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcrab.png?alt=media&token=0cde2529-8e28-4b5e-80cf-660f27564de2", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), "Bao gồm nước ép, sinh tố, trà, cà phê, và các loại đồ uống giải khát khác", "Đồ uống", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcoffee-cup.png?alt=media&token=14155321-cd44-422b-a49f-3e34636d7f85", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), "Kimchi, dưa chua, sữa chua, rượu vang và các món ăn lên men, tốt cho tiêu hóa và sức khỏe đường ruột", "Món lên men", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fpickles.png?alt=media&token=2a078ceb-40a9-403d-a68c-9682faf1b97f", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), "Bài tập kết hợp nhiều nhóm cơ, tăng cường sức mạnh và sự linh hoạt cơ thể.", "Toàn thân", 1, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), "Các loại hạt (hạnh nhân, hạt chia, hạt điều) và đậu (đậu nành, đậu xanh, đậu đen). Giàu protein và chất xơ", "Hạt và đậu", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fgrain.png?alt=media&token=e224b22a-925e-4aa4-ab50-d74309ba71f4", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") }
                });

            migrationBuilder.InsertData(
                table: "DishTypes",
                columns: new[] { "DishTypeId", "CreatedAt", "CreatedBy", "DishTypeName", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("5bc13328-01b0-4f09-a32b-5c2f3384c98c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(1995), null, "Snack", new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(1996), null },
                    { new Guid("640474cb-2135-4648-b921-fca3a9219533"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(1944), null, "MainDish", new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(1985), null },
                    { new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(1989), null, "SideDish", new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(1989), null },
                    { new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(1991), null, "Soup", new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(1991), null },
                    { new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(1997), null, "Drink", new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(1998), null },
                    { new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(1993), null, "Dessert", new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(1994), null }
                });

            migrationBuilder.InsertData(
                table: "Expertise",
                columns: new[] { "ExpertiseId", "CreatedAt", "CreatedBy", "ExpertiseDescription", "ExpertiseName", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0131b574-2c27-477b-af1f-5abbb7dd08a4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn dinh dưỡng và thói quen giúp cải thiện chất lượng giấc ngủ.", "Quản lý giấc ngủ", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("44d9ffb3-a8b8-407b-975c-99e6f6146bc9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cung cấp chế độ ăn phù hợp cho vận động viên và người tập luyện.", "Dinh dưỡng thể thao", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("5912320d-f6ab-493a-8631-891048f965e7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn dinh dưỡng và phương pháp cải thiện chất lượng giấc ngủ.", "Rối loạn giấc ngủ", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("5fa7d647-9ede-4180-99d3-fc10f54dd459"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn chế độ ăn và phương pháp giúp giảm cân hiệu quả, duy trì vóc dáng.", "Giảm cân", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("63100127-6781-4385-a1df-b21cae459bdb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn chế độ ăn hỗ trợ sức khỏe mẹ và bé trước, sau sinh.", "Dinh dưỡng tiền sản và sau sinh", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("67188399-9f09-4b74-9eb3-31ff82734850"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn chế độ ăn hỗ trợ sức khỏe tim, phòng ngừa bệnh lý tim mạch.", "Tim mạch", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6c6a7d90-1c16-44ae-9b2a-b3addfe55dbc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sử dụng phương pháp trị liệu giúp phục hồi chức năng cơ thể sau chấn thương.", "Vật lý trị liệu", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("768178b4-2241-4914-9309-74f89462eddc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn dinh dưỡng hỗ trợ quá trình cai nghiện thuốc lá, rượu hiệu quả.", "Cai thuốc lá / rượu", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("7a61f09f-f999-44fd-8973-105e22df1401"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn dinh dưỡng giúp bệnh nhân phục hồi và duy trì sức khỏe.", "Dinh dưỡng lâm sàng", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("82e1e76a-99fb-43b4-84e1-d11376b487b8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn và xây dựng kế hoạch dinh dưỡng, luyện tập theo nhu cầu cá nhân.", "Huấn luyện cá nhân", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("8ad55299-b566-47e8-a9a0-1997e893e153"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn dinh dưỡng hỗ trợ cải thiện tâm trạng và sức khỏe tinh thần.", "Trầm cảm", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("939cf420-f669-464e-bb2d-74a2c61b1d6f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hướng dẫn dinh dưỡng và bài tập hỗ trợ cải thiện sức khỏe và linh hoạt cơ thể.", "Yoga / Pilates", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c32b7429-13df-4aa0-b32d-705d1050de5f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn chế độ ăn giúp phục hồi nhanh chóng và tối ưu sức khỏe.", "Phục hồi sau phẫu thuật", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c5d7a490-e25e-4ae6-a6db-2d637e6630de"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn chế độ ăn kiểm soát đường huyết và phòng ngừa biến chứng.", "Tiểu đường", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d762370d-3b36-45f6-ae15-bbe4c2b9bf8a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn chế độ ăn hỗ trợ điều trị, tăng cường sức khỏe cho bệnh nhân ung thư.", "Ung thư", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f28d1cdc-925e-4ff5-b6db-520de542bc0a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn chế độ ăn giúp tăng cân an toàn, duy trì sức khỏe.", "Tăng cân lành mạnh", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("fdb9b159-8cd5-4a4b-9879-1a140365c207"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn dinh dưỡng và phương pháp giảm căng thẳng, lo âu hiệu quả.", "Stress & Lo âu", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") }
                });

            migrationBuilder.InsertData(
                table: "Portions",
                columns: new[] { "PortionId", "CreatedAt", "CreatedBy", "MeasurementUnit", "PortionSize", "PortionWeight", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0336a88f-f5cd-4cc2-8478-980467aa91aa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "con", 550f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("03a92c0b-b7f6-4283-8109-a35898d5d3c5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả nhỏ", 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("113f6a04-87c4-43c6-8263-920bd099c8e0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "củ to", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("13672611-5453-40a0-9b58-33c2e552bf57"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả nhỏ", 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1500876f-ef20-40de-baae-de0336bdc47b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "ml", "cốc", 240f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("16dc894a-746e-497e-a2c5-2d58f7f83c4d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "ml", "ly", 180f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("17c9d30f-bd85-4e58-bfc0-6b6d70b2e5fe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "khúc vừa", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1802caa2-cfe0-48e7-8580-29165f84387d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả nhỏ", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1808de3e-ae43-41a6-b9ce-bfe89131be5a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "chén", 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("18809fb3-b78a-4f67-b9f9-8bb6ab95ab00"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "cái", 130f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1b56833b-1ff5-4a90-aea9-074de2d0dd67"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả lớn", 136f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "miếng", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1cddc91d-209a-4948-8e9f-9017252d5423"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "củ", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1cf439ce-a31b-4b95-b092-b7f6edf8d40f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả nhỏ", 220f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("218b9709-852d-4a1f-ad8b-c9410b49fea6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "củ vừa", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("21e32570-7d64-4cec-b711-873185c76523"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả to", 1500f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("222e1fa2-3910-42ac-9a5c-f371dded16eb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "lát", 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("22f0a09e-6816-410e-a5a2-c802103b089b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "đĩa", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("23ce32a0-6597-4b60-b35c-98073ff595c6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "con to", 500f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("24a4ed15-69e4-4fb5-8dd2-1695de52c264"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "cái", 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("255ba0f6-14cc-4049-add8-138f27055b49"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "đĩa", 220f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("26096793-894d-47c1-a06f-cf9133f8089d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "ml", "hộp", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "trái", 164f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("26dcc6e0-67aa-40ed-b3d1-8a009c60a62c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả nhỏ", 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("2892c25f-bd50-4bb4-a845-997395ef6693"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "gói", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("28b06cf6-6367-4786-bccb-89c43dd3ce3a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả nhỏ", 81f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("28f6a369-f694-437d-82eb-944b09d5e369"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "con to", 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("2b7a3473-9f67-4938-b419-7cafa8f72a41"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "hộp", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("2c7ac6ee-f7fe-4ec8-974f-11f62a5f60b9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "con", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("30f41ca6-c420-4f7d-9602-bf80735d5691"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "củ", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("31e9bda5-8ec3-4444-a23a-908e84da6a14"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "ml", "cốc", 240f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("36398f6d-0668-4d37-8850-9f9ee89b8b92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "cây vừa", 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("399eee61-90b5-464f-b3f7-7ddc1077ab0d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "ml", "hộp", 110f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("3c7d60d4-60da-4f51-9448-30877b126572"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả vừa", 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("3d6d946f-8d9f-479a-b27e-3d78dc354db0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "chén", 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("3d7eafa9-9fcc-4f49-b8fb-2a5c629ae6eb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "cái", 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("3f19ef5c-3c60-4a11-b1b3-5158859f1286"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả vừa", 900f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("3f77fd90-591c-45f3-8bbc-87d0bb49e461"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "tô", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("40991196-f258-43f1-ac84-0381afa83477"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "tô", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("40bbc8c4-f383-4ae6-979a-3ac83c275881"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "ml", "cốc", 240f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("41ae956e-14fc-44af-bc6a-e5ba77661cee"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "tô", 350f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("424ebe64-6570-4d88-9052-08c06dc0a2c8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "cái", 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("4e9013c8-d6f7-4740-80d5-e95d318873b9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "tô", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("509da3d8-ed0f-4cd0-be26-3a896b9500b3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "con nhỏ", 15f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("52c86d57-0909-41c3-b513-e770e6f6d104"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "khúc to", 600f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("5384aebd-4eab-4a44-8cbb-7ec2c04f1401"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "đĩa", 230f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("549d664a-eb1c-4b9a-8ad7-fab9e1482e5b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả nhỏ", 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("56681171-ccbd-4700-90bc-2233c1e661bb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "con to", 500f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("59589114-7d6a-4c80-8681-db5c554ab38f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "ổ", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("5a1bc1cb-ed0b-49bf-9c1a-5494db962d27"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "đĩa", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("5a9ac478-aa65-48ea-9387-1ad92f6c76b1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "củ vừa", 180f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("5adcb96d-70ef-403d-89c6-cc3aa807b6a7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "củ nhỏ", 110f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("5afaa147-398e-4be8-b0d1-8dcabe6ed18c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả nhỏ", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("5f7f859a-f20a-4f6c-8b8c-ecfbb1ff522e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả", 90f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("5feca670-1f15-430d-9b04-7ac86a329a6c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "ml", "ly", 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("63d10d95-7983-455e-b920-29c1f0c88d85"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả nhỏ", 120f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6792c392-3c86-4162-be91-4fc8646f861d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "ml", "ly", 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("698c67ad-a726-435b-b9d2-c5690a79eb5a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả lớn", 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6e98f2be-9196-4c4e-8279-b02010f853f1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "phần vừa", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6f34350b-8f99-446e-9de9-e0c6277b10f3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "ml", "hộp", 180f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("709578ca-672f-461e-995d-dc78aeda8c4c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "con nhỏ", 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("749b288c-112b-4b7b-8750-0daff63d9ab3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "tô", 228f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("7b138bd4-4d3a-426c-9ab0-d66699b762d2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả to", 350f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("7be0e4d3-1e50-4de1-931d-08adb85f628b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả vừa", 44f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("7e071bd6-6afa-483d-8688-28b31b9a8bef"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "hộp", 280f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("84793ef9-fcd0-42df-ab0d-9380dfa18630"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "ổ", 110f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("87409e4f-4bea-4bba-855d-a3bfbc2f9c20"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả to", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("8a81e20e-ea16-4073-957e-29508a8f7419"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "củ", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("8bffc4ad-afcc-436b-953c-444f1e8ce533"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "con vừa", 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("8c141b0b-f09b-486e-b75a-04fa194d412c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "củ nhỏ", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("8ecbc063-8d6e-450d-af39-0ba28bc572bf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "tô", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("91524cc2-db22-4cab-abb7-700725232f1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả vừa", 118f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("919c7f66-53e5-46bd-b181-558f6052b953"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả vừa", 170f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("92e149ff-8491-48cf-a4e8-8106b1e95c4c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "ml", "cốc", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("93984b54-2044-4ea9-8364-a03c6568e358"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "tô", 330f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("9c276c0b-84b6-4216-8dbb-ae2034ac2176"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "tô", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("9c3399d1-72db-4e86-a518-2575033bb6a8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả to", 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("a1589990-affa-4805-a1e0-73de1ffa8516"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "trái", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("a33065fe-80ad-4879-9333-424aadc6734f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "tô", 350f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("a43d7637-6fc7-421b-86f1-f83e691431a4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "phần nhỏ", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("a5dbb27a-4856-44be-a239-76eb073c3e41"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "củ vừa", 80f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("a7936b9f-b6f8-4295-8b6e-6fe1b096f437"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "củ to", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("a88faa7c-6eab-4ecb-8a75-b078a9cf7834"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "củ nhỏ", 110f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("a9385e8a-e9b9-484f-beeb-bc35529cf91a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "tô", 330f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("ad9ecd1e-40ec-414a-be69-b16e7013b377"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả to", 550f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("b6623163-4c27-4d0c-99ef-12a67b87635f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "tô", 350f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("b6b0faee-84e8-4a16-a8f7-4b8719787e8a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "củ to", 450f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("b9423874-3290-4fda-9996-7c13d7c61d96"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "cái", 90f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("bad70aff-4237-4c83-b412-460020a5ee44"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "hộp", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("bd16f0ec-5ae1-42f4-a302-b4bce8f0db28"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả to", 220f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("bdd1ee1e-3a93-421f-855e-0993c7e6f767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "đĩa", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("bf0f7ca4-9089-4800-95d7-8d037d98b7fc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "con vừa", 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "tô", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c4993d6a-a2e0-4ddd-821a-0629541e019c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "tô", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c4fc900f-5a92-4228-ac03-57285fff159e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "đĩa vừa", 350f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c605aa91-495e-4977-9876-b2a198ce356e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả nhỏ", 38f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c65d34ee-8c0c-43bb-9d4e-aa39955a4768"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả nhỏ", 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c6e853f0-06bd-4cda-8b43-cbe66fea98c8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "cây to", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "ml", "hộp", 180f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("cd0b1476-44a8-4350-a6a1-3de8747a5ebc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "cái", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d09266d3-9e7d-46a6-ad3a-7c608ec802d1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "tô", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d2e88505-bbd6-4af6-9a88-535896c5d587"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả nhỏ", 500f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d3850e1b-4780-490d-8c0c-ced1a9aa323b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả vừa", 220f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d6c41cdb-4735-4b9e-85ae-1f48f33b7d6c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "cây", 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d9dad801-145a-419d-bbe2-408acf97a273"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "con nhỏ", 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("da254ee7-d229-4769-bad5-a617d09676d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả to", 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("de5d78a3-c5b1-4e2a-b9eb-f3757c999024"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "cái", 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e00ed683-11ff-4c21-8b1c-576b448726c9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "phần to", 400f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e09c493c-5806-4b14-bbef-e26e19e1d8d5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả to", 400f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e23d4491-73d1-45b5-8010-0385d7185c98"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e45c2156-a98c-4121-90b4-25097e8a5cd1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả vừa", 170f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e4e4252f-ad38-4190-aba5-8989e3cca994"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "miếng", 114f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e5cc2785-6d62-4b5f-8fc1-e6ab45babd76"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "củ to", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("eceaaa32-4023-4eab-abb6-9172c908f77c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "tô", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("ef6b8c43-9ab5-497c-a9a8-e31f0a349527"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả", 220f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("eff728af-c8f0-4bb5-a985-d079cbadb6b5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "củ nhỏ", 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f01f8da7-9d7b-4893-999f-cf30e719e010"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả to", 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f0e8f9cd-d133-49cf-be7d-d427b630e05a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả", 120f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f359ba3c-6597-40ad-9dbd-6719ff302994"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "củ vừa", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f483bb75-84f0-4ecc-8a06-f366a488c6bf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "khúc nhỏ", 120f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f7b36043-9ca9-42c3-8a00-e9e235b56bb3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "ml", "ly", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f928b7a6-2558-478a-bc22-515516f4dc74"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "con vừa", 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f9bc9ae8-e42e-4e8b-84d3-f2bc36037552"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả vừa", 110f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("faec7c41-2e11-4092-8ab9-cc9c152d858f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "cây nhỏ", 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("fc245902-ef53-4363-b4ce-0e598e1dd4a4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "g", "quả vừa", 17f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "SubscriptionId", "BookingAllowance", "CreatedAt", "CreatedBy", "DurationDays", "Features", "Price", "Status", "SubscriptionDescription", "SubscriptionName", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3aca8009-92d5-4cc3-a7fb-ef6b4bd0e1d3"), 3, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 30, "[\"T\\u1EA5t c\\u1EA3 t\\u00EDnh n\\u0103ng c\\u1EE7a G\\u00F3i N\\u00E2ng Cao\\nTruy c\\u1EADp danh s\\u00E1ch chuy\\u00EAn vi\\u00EAn t\\u01B0 v\\u1EA5n ch\\u1ECDn l\\u1ECDc\\n\\u0110\\u1EB7t l\\u1ECBch t\\u01B0 v\\u1EA5n 1-1 v\\u1EDBi chuy\\u00EAn gia (3 bu\\u1ED5i/th\\u00E1ng)\\nNh\\u1EAFn tin tr\\u1EF1c ti\\u1EBFp v\\u1EDBi chuy\\u00EAn gia\\nK\\u1EBF ho\\u1EA1ch dinh d\\u01B0\\u1EE1ng v\\u00E0 t\\u1EADp luy\\u1EC7n c\\u00E1 nh\\u00E2n h\\u00F3a\\n\\u0110\\u00E1nh gi\\u00E1 v\\u00E0 ph\\u1EA3n h\\u1ED3i d\\u1ECBch v\\u1EE5 chi ti\\u1EBFt\"]", 899000, true, "Gói dịch vụ cao cấp bao gồm tư vấn cá nhân từ chuyên gia dinh dưỡng và thể hình", "Gói Cao Cấp", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e6e8f4a1-f8c1-478d-8a95-1032327914c6"), 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 30, "[\"T\\u1EA5t c\\u1EA3 t\\u00EDnh n\\u0103ng c\\u1EE7a G\\u00F3i C\\u01A1 B\\u1EA3n\\nG\\u1EE3i \\u00FD b\\u1EEFa \\u0103n h\\u00E0ng ng\\u00E0y theo m\\u1EE5c ti\\u00EAu\\nTruy c\\u1EADp \\u0111\\u1EA7y \\u0111\\u1EE7 th\\u01B0 vi\\u1EC7n b\\u00E0i t\\u1EADp\\nNh\\u1EADn th\\u00F4ng b\\u00E1o nh\\u1EAFc nh\\u1EDF theo l\\u1ECBch tr\\u00ECnh\\nPh\\u00E2n t\\u00EDch ch\\u1EC9 s\\u1ED1 dinh d\\u01B0\\u1EE1ng chi ti\\u1EBFt\"]", 249000, true, "Gói dịch vụ nâng cao với đầy đủ tính năng dinh dưỡng và tập luyện cá nhân hóa", "Gói Nâng Cao", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f8a5f2fa-af41-42d8-b8d9-41ff6564bad2"), 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "[\"Theo d\\u00F5i ch\\u1EC9 s\\u1ED1 s\\u1EE9c kh\\u1ECFe c\\u01A1 b\\u1EA3n\\nQu\\u1EA3n l\\u00FD m\\u1EE5c ti\\u00EAu c\\u00E1 nh\\u00E2n\\nTheo d\\u00F5i l\\u01B0\\u1EE3ng n\\u01B0\\u1EDBc u\\u1ED1ng h\\u00E0ng ng\\u00E0y\\nTruy c\\u1EADp danh s\\u00E1ch b\\u00E0i t\\u1EADp gi\\u1EDBi h\\u1EA1n\\nB\\u00E1o c\\u00E1o ti\\u1EBFn \\u0111\\u1ED9 h\\u00E0ng tu\\u1EA7n c\\u01A1 b\\u1EA3n\"]", 0, true, "Gói dịch vụ miễn phí với các tính năng cơ bản để theo dõi sức khỏe và dinh dưỡng", "Gói Cơ Bản", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") }
                });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "CreatedAt", "StartTime", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(14, 0, 0), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(10, 0, 0), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(8, 0, 0), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(11, 0, 0), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8b71edc-d48b-44ea-9dc3-b7d214c582c1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(16, 0, 0), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(9, 0, 0), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(15, 0, 0), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2") },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b") },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87") },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e") },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d") },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), new Guid("20041d5b-01e4-443f-9652-e39beb9748e5") },
                    { new Guid("d21edfd6-42d5-490a-a41c-43f7ef09c61f"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") }
                });

            migrationBuilder.InsertData(
                table: "Consultants",
                columns: new[] { "Id", "AverageRating", "Bio", "BookingCount", "CreatedAt", "Experience", "ExpertiseId", "IsVerified", "RatingCount", "Status", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), 4.5, "Với kinh nghiệm hơn 2 năm trong lĩnh vực tư vấn tâm lý, tôi chuyên hỗ trợ những người gặp phải các triệu chứng trầm cảm, lo âu và căng thẳng kéo dài. Tôi tin rằng mỗi người đều có khả năng tìm lại sự cân bằng và hạnh phúc trong cuộc sống. Thông qua phương pháp trị liệu cá nhân hóa và sự đồng hành tận tâm, tôi giúp khách hàng từng bước vượt qua khó khăn, cải thiện sức khỏe tinh thần và xây dựng một cuộc sống tích cực hơn", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("8ad55299-b566-47e8-a9a0-1997e893e153"), true, 100.0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("20041d5b-01e4-443f-9652-e39beb9748e5") });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "CaloriesPerMinute", "CreatedAt", "CreatedBy", "ExerciseName", "ExerciseType", "Instructions", "Status", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("01dc4c46-e1ef-44bc-9f19-ecb283bf27ce"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng chân sang ngang bên phải", 1, "Đứng thẳng và quấn dây kháng lực quanh chân của bạn\nGiữ thẳng lưng và siết chặt cơ bụng, sau đó nâng chân sang ngang\nThực hiện một hiệp đầy đủ với một chân, sau đó thực hiện một hiệp với chân kia", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("01e6141a-930e-4126-a2c6-7c32a2ccdd43"), 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Kéo vai bằng dây đàn hồi", 1, "Đảm bảo bạn có dây kháng lực phù hợp với sức mạnh của mình\nĐứng thẳng và đặt một đầu của dây dưới chân của bạn và nắm đầu kia bằng tay của bạn\nDuỗi thẳng tay của bạn xuống đất với lòng bàn tay hướng xuống dưới\nGiữ hai tay của bạn với nhau và kéo dây về phía cằm của bạn\nĐảm bảo nới lỏng vai của bạn trước khi bắt đầu bài tập\nGiữ cho bụng của bạn siết chặt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("05c931df-c828-442e-aee1-56432cb772c7"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Plank ngược", 0, "Mắt và cơ bụng hướng lên trần nhà\nLòng bàn tay và gót chân trên thảm\nCơ thể siết chặt và nằm trên một đường thẳng từ đầu đến chân\nGiữ vị trí này với chân, mông và cơ bụng của bạn co lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("07a4dbcd-635a-4a76-92d4-8127de619e6d"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Plank ngôi sao", 0, "Vị trí plank cổ điển: hai tay trên sàn, hai chân rộng bằng hông, đầu gối cong\nNâng chân của bạn lên trần nhà mà không cong lưng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("0a280d32-de67-4a38-8f21-923243489eef"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gập bụng và xoay người", 1, "Nằm ngửa với hai chân cong và hơi tách rời\nNâng ngực lên và xoay người khi bạn lên đến đỉnh\nBạn có thể bắt đầu bằng cách xoay sang bên phải và sau đó đưa ngực trở lại xuống\nKhi bạn đi lên trở lại, hãy xoay sang bên trái, v.v\nNhìn lên trần nhà và theo hướng bạn xoay người", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("0a9e1fb3-9abf-4775-a75e-2bb13009a29d"), 7.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Squat với tạ", 1, "Đứng thẳng với hai bàn chân rộng bằng vai và các ngón chân hơi hướng ra ngoài\nNắm một quả tạ giữa hai tay và nâng lên ngực với khuỷu tay cong\nNhìn thẳng về phía trước, hít một hơi thật sâu và siết chặt cơ bụng đồng thời đẩy hông ra sau và gập đầu gối để bắt đầu squat\nCột sống của bạn phải giữ ở vị trí trung lập\nGiữ lòng bàn chân đặt chắc chắn trên sàn và đảm bảo trọng lượng cơ thể và tạ được phân bổ đều trên bàn chân của bạn\nTrong khi squat, hạ mông xuống hơi quá điểm mà đùi của bạn song song với sàn nhà\nỞ dưới cùng của squat, khuỷu tay của bạn phải chạm vào bên trong đầu gối của bạn\nĐẩy gót chân để trở lại vị trí bắt đầu\nThở ra trong phần cuối cùng của bài tập này", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng tay sang ngang", 1, "Đứng thẳng và nắm một quả tạ ở mỗi tay\nGiữ lưng thẳng và bụng siết chặt\nNâng tạ sang ngang\nCổ tay của bạn không vượt quá chiều cao của vai trong khi nâng\nHạ tạ xuống cẩn thận", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("0c011f92-425a-477c-84d4-3d6dc883119b"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mở ngực", 1, "Nằm ngửa với đầu, vai và mông chạm sàn\nChân của bạn phải cong và bàn chân đặt trên sàn\nNắm một quả tạ ở mỗi tay với lòng bàn tay hướng về phía bàn chân của bạn\nNâng tạ trực tiếp lên trên ngực của bạn cho đến khi chúng chạm nhau\nHít vào và giữ hơi thở của bạn trong khi hạ tạ xuống\nKhuỷu tay của bạn sẽ di chuyển ra ngoài khi tạ đến gần hai bên của bạn\nLặp lại\nThở ra trong phần khó nhất của động tác nâng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("0d1e54fe-7a5f-4e0a-a59f-ee9f443718e0"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chạm mũi chân khi đứng", 0, "Đứng thẳng với cơ bụng siết chặt\nNâng chân trái của bạn ra phía sau đến chiều cao của hông hoặc cao hơn, nếu có thể\nBằng tay phải, chạm vào đỉnh bàn chân trái của bạn\nTrở lại vị trí bắt đầu và đổi chân", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("0d816828-8a94-4dcb-a87c-b70b295a39b6"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đá tay sau với tạ bên trái", 1, "Trong khi đứng, hạ ngực của bạn cho đến khi nó nằm ngang (hoặc gần như nằm ngang)\nNếu nó giúp ích, bạn có thể sử dụng lưng ghế để hỗ trợ cánh tay không hoạt động\nNắm một quả tạ bằng một tay với lòng bàn tay hướng vào cơ thể bạn\nGiữ cánh tay của bạn (cầm quả tạ) thẳng hàng với cơ thể của bạn\nGập khuỷu tay của bạn để cẳng tay của bạn thẳng đứng\nNâng quả tạ trong khi giữ cho cánh tay trên của bạn bất động\nTừ từ đưa quả tạ trở lại vị trí bắt đầu\nKhi cánh tay của bạn duỗi thẳng, nó phải thẳng hàng với ngực của bạn\nTiếp tục với tốc độ vừa phải mà không giật quả tạ lên trên\nSau khi bạn hoàn thành một hiệp với một tay, hãy đổi bên và thực hiện một hiệp với tay kia", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("13ca014d-8b75-414f-afe3-3d378ef7fa97"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bước lên", 1, "Đứng trước một bậc thang như ghế đẩu, ghế hoặc băng ghế\nĐứng thẳng và siết chặt cơ bụng và ngực của bạn\nBước lên vật thể, luân phiên chân", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1b2afb40-fb97-49ec-8fe3-81a17c6c9078"), 6.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư thế chiến binh", 0, "Đứng thẳng và bước một bước lớn về phía trước bằng cách gập chân cho đến khi đầu gối của bạn cong 90 độ\nĐầu gối của chân sau của bạn không được chạm vào\nNâng hai tay lên trên đầu\nĐảm bảo vai không chạm vào tai của bạn\nGiữ ở vị trí này trong vài giây\nĐổi chân", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1c5d2078-a923-4953-9677-ff890977ffcd"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Squat nhịp nhàng", 1, "Đứng thẳng với hai chân rộng bằng vai và hai tay duỗi thẳng và thẳng hàng với bàn chân\nHít vào và gập đầu gối cho đến khi đùi của bạn song song với sàn nhà\nGập đầu gối tới lui mà không đứng lên để bạn liên tục vận động cơ bắp của mình\nĐảm bảo giữ ngực thẳng và ưỡn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đá chân sau với dây kháng lực bên trái", 1, "Đứng thẳng và quấn dây kháng lực quanh chân của bạn\nGiữ thẳng lưng và siết chặt cơ bụng, sau đó nâng chân ra phía sau\nThực hiện một hiệp đầy đủ với một chân, sau đó thực hiện một hiệp với chân kia\nCẩn thận không cong lưng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1ff0ef05-4387-4483-8de3-0ef6d7724afd"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chống đẩy dốc", 1, "Đặt tay của bạn trên ghế hoặc băng ghế để dễ dàng chống đẩy hơn\nĐảm bảo lưng của bạn vẫn đẹp và thẳng\nKhi bạn đi xuống, khuỷu tay của bạn không nên vuông góc mà hơi gần với cơ thể của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("22af0171-257b-43bc-9013-8985472a8c84"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gập bụng chéo bên phải", 1, "Nằm ngửa với hai chân cong\nNâng chân phải của bạn lên để nó vuông góc với chân trái của bạn\nĐặt chân phải của bạn lên đầu gối trái của bạn\nNâng ngực của bạn và đưa khuỷu tay trái của bạn càng gần đầu gối phải của bạn càng tốt\nNhìn lên trần nhà để bạn vận động cơ bụng đúng cách và không làm căng cổ\nThực hiện một hiệp đầy đủ như thế này. sau đó đổi chân và thực hiện một hiệp trong khi đưa khuỷu tay phải của bạn lên đầu gối trái của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("235f7494-3e7d-45a5-a31a-6d5449b1322d"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bước lùi", 1, "Đứng thẳng và bước một bước lớn về phía sau bằng cách gập chân cho đến khi đầu gối của bạn cong 90°\nTrở lại vị trí bắt đầu\nLặp lại\nLuân phiên giữa chân phải và chân trái", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("23842121-4834-4483-bfe2-2c244f5ecf76"), 7.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Trượt băng", 0, "Đứng thẳng, sau đó gập đầu gối của bạn và bước nhanh, chéo về phía bên phải bằng chân trái của bạn\nTrở lại vị trí bắt đầu và ngay lập tức bước chéo về phía bên trái bằng chân phải của bạn\nTiếp tục luân phiên các bước bằng chân của bạn\nChuyển động của bạn nên năng động và giống như trượt băng\nĐảm bảo cơ bụng của bạn được siết chặt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("256e23fa-03b1-4328-a325-512f0860d9b0"), 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng chân", 1, "Nằm ngửa với hai chân duỗi thẳng và hai tay đặt dưới mông\nCố gắng nâng chân của bạn để chúng tạo thành một góc vuông với cơ thể của bạn\nTừ từ đưa chân của bạn trở lại xuống mà không để chúng chạm sàn, sau đó nâng chúng lên một lần nữa\nCực kỳ cẩn thận để bạn không mở rộng quá mức lưng của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("2696db05-e815-4c8b-870d-23c338479e95"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tựa lưng vào tường", 0, "Tựa lưng vào tường\nGập đầu gối của bạn để tạo thành một góc 90°\nGiữ tay của bạn ở hai bên hoặc phía trước cơ thể, hoặc trên đầu, nhưng không để chúng tựa vào chân của bạn\nGiữ ở vị trí này trong số giây yêu cầu", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Duỗi tay sau đầu bên phải", 1, "Đứng thẳng\nNắm một quả tạ bằng một tay. Giữ ngực thẳng và thẳng, và nhìn thẳng phía trước\nGập khuỷu tay của bạn và nâng cánh tay lên trên đầu với cẳng tay và quả tạ treo phía sau bạn để khuỷu tay của bạn hướng thẳng lên trần nhà\nNgón út của bạn phải chạm vào đỉnh tay cầm quả tạ\nHít một hơi thật sâu và giữ cánh tay trên của bạn bất động\nĐẩy quả tạ lên trên cho đến khi cánh tay của bạn duỗi thẳng hoàn toàn\nTừ từ đưa quả tạ trở lại vị trí bắt đầu", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ép tạ qua đầu khi ngồi", 1, "Nắm một quả tạ ở mỗi tay\nNgồi trên ghế hoặc băng ghế và đặt tạ lên đùi của bạn\nTựa lưng vào tựa lưng hoặc giữ cho mình cực kỳ thẳng với vai ra sau và ngực ưỡn ra\nBàn chân của bạn phải đặt trên sàn và chân của bạn phải hoàn toàn ổn định\nNâng tạ cho đến khi tay của bạn ngang tầm với vai trên của bạn và khuỷu tay của bạn cong xuống và thẳng hàng với cơ thể của bạn\nLòng bàn tay của bạn phải hướng về phía trước\nBây giờ nâng tạ lên trên đầu với cánh tay duỗi thẳng và không khóa khuỷu tay\nCẩn thận trở lại vị trí bắt đầu và hoàn thành hiệp của bạn\nNhìn thẳng về phía trước trong suốt bài tập", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("2e787245-7612-41bc-9b75-7a4857282350"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gập người lên và nâng hông", 1, "Nằm thẳng lưng\nHai tay của bạn phải duỗi thẳng ra sau đầu\nThực hiện động tác gập người hoàn toàn\nNgay lập tức vào tư thế bàn ngược bằng cách nâng hông của bạn lên trần nhà\nTrở lại vị trí bắt đầu và bắt đầu lại\nGiữ cho cơ bụng của bạn siết chặt trong suốt bài tập\nChuyển động của bạn phải chính xác\nGiữ ánh mắt của bạn hướng lên trần nhà\nVai của bạn phải thấp hơn tai", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Squat tĩnh", 0, "Đứng thẳng với hai chân rộng bằng vai và hai tay duỗi thẳng và thẳng hàng với bàn chân\nHít vào và gập đầu gối cho đến khi đùi của bạn song song với sàn nhà\nGiữ ở vị trí này", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("3100278d-eee7-4b89-b726-4b76daefabde"), 7.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Lắc vòng", 0, "Đứng thẳng với hai tay chống vào hông\nThực hiện các chuyển động tròn bằng xương chậu\nBài tập này cải thiện khả năng vận động của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cuốn tay với dây kháng lực", 1, "Đứng thẳng\nNắm một đầu của dây kháng lực bằng cả hai tay (rộng bằng hông với lòng bàn tay hướng lên trên) và đặt đầu kia dưới chân của bạn\nGiữ ngực thẳng và thẳng\nGập cánh tay của bạn để nâng dây về phía ngực của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("385f13f7-79bf-437b-acac-745b50485b9f"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng tay phía trước", 1, "Đứng thẳng và nắm một quả tạ ở mỗi tay\nGiữ lưng thẳng và cơ bụng siết chặt\nNâng tạ trực tiếp về phía trước bạn\nCổ tay của bạn không được vượt quá chiều cao của vai trong khi nâng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đi bộ gấu", 0, "Quỳ bốn chân\nBắt đầu với hai tay dưới vai, đầu gối dưới hông và lưng thẳng\nBước về phía trước, luân phiên giữa tay và chân", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("3f674891-2d75-42bf-af35-a89dff24ab22"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Deadlift với dây kháng lực", 1, "Đứng hai chân rộng bằng hông hoặc vai\nĐặt một đầu của dây kháng lực nhỏ dưới chân của bạn và nắm đầu kia bằng tay với lòng bàn tay hướng về phía bạn\nHít một hơi thật sâu và thở ra trong khi nghiêng người về phía trước và đẩy hông ra phía sau\nGiữ lưng thẳng hoặc lưng dưới (thắt lưng) hơi cong bằng cách đẩy hông ra phía sau, và nghiêng người về phía trước cho đến khi ngực của bạn song song với mặt đất hoặc hơi cao hơn\nGiữ đầu của bạn thẳng hàng với cột sống của bạn và trở lại vị trí bắt đầu", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("407ff857-d218-44a8-8d0f-0bfa5d53bf03"), 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gập bụng chéo", 0, "Nằm thẳng lưng\nGiữ hai tay sau đầu để nâng đỡ cổ, nhưng không bao giờ kéo nó\nNâng ngực lên và xoay sang bên phải, đưa khuỷu tay trái lên đầu gối phải đồng thời giữ chân trái thẳng\nChân phải của bạn duỗi thẳng về phía ngực\nĐổi bên, đưa khuỷu tay phải lên đầu gối trái, chân này duỗi thẳng về phía ngực khi chân phải của bạn nằm thẳng\nNhìn lên trần nhà để bạn vận động cơ bụng đúng cách và không làm căng cổ", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("439db970-c7c8-4b3b-9a35-127d31d920dc"), 7.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Plank nhảy", 0, "Vị trí plank cổ điển: hai tay trên sàn, hai chân rộng bằng hông, đầu gối cong\nDi chuyển bàn chân sang hai bên bằng các động tác nhảy\nTrở lại vị trí plank và thực hiện số lần lặp lại mong muốn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), 4.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Xoay vòng tay", 1, "Đứng thẳng và duỗi tay sang một bên với hai tay ngang tầm vai\nThực hiện các vòng tròn nhỏ bằng cánh tay theo một hướng rồi đổi hướng. Điều này sẽ làm ấm vai của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("4834f1ce-41dc-4161-ac51-e03ca78b62b8"), 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Siêu nhân tĩnh", 0, "Nằm sấp trên sàn. Giữ cho chân của bạn thẳng và khép lại\nDuỗi thẳng tay của bạn lên trên đầu để cơ thể bạn tạo thành một đường thẳng\nHít vào và nâng cánh tay, ngực và chân của bạn lên. Cơ thể của bạn phải tạo thành một vòng cung\nGiữ ở vị trí này với cơ bụng siết chặt và thở chậm", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Deadlift với tạ", 1, "Đứng hai chân rộng bằng vai hoặc hông và nắm một quả tạ ở mỗi tay với lòng bàn tay hướng xuống dưới\nHít một hơi thật sâu và thở ra trong khi nghiêng người về phía trước bằng hông của bạn\nGiữ lưng thẳng hoặc lưng dưới (thắt lưng) hơi cong bằng cách đẩy hông ra phía sau, và nghiêng người về phía trước cho đến khi ngực của bạn song song với mặt đất hoặc hơi thấp hơn\nGiữ đầu của bạn thẳng hàng với cột sống của bạn và đầu gối của bạn hơi cong\nNếu lưng của bạn bắt đầu cong khi bạn nghiêng người về phía trước, hãy dừng bài tập ngay lập tức\nKhi bạn đạt đến vị trí thấp nhất, hãy giữ cho cột sống của bạn thẳng và nâng ngực lên trong khi hít vào và đẩy hông về phía trước", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bước tới", 1, "Đứng thẳng và bước một bước lớn về phía trước bằng cách gập chân cho đến khi đầu gối của bạn cong 90 độ\nĐứng lên trở lại, sau đó bước một bước lớn khác bằng chân còn lại\nLặp lại\nTiếp tục bước tới vài bước\nTrong mỗi bước tới, giữ ngực thẳng và thẳng\nTập trung vào việc kéo giãn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 5.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chéo chân năng động", 1, "Nằm thẳng lưng với hai tay duỗi sang hai bên\nNâng chân phải về phía tay trái\nBây giờ nâng chân trái về phía tay phải\nGiữ lưng càng gần sàn càng tốt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Plank", 0, "Cẳng tay và ngón chân trên thảm\nCơ thể siết chặt và nằm trên một đường thẳng từ đầu đến chân\nGiữ vị trí này với chân, mông và bụng của bạn co lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("58878826-775e-4d4c-8e1b-d5c95afc214d"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chặt gỗ bên trái", 1, "Đặt một tay lên ghế hoặc băng ghế. Cúi người về phía trước cho đến khi ngực của bạn song song với sàn nhà, giữ lưng thẳng với đầu gối cong và lưng dưới hơi cong\nNắm một quả tạ bằng tay kia với lòng bàn tay hướng vào cơ thể bạn\nĐể tay cầm tạ hạ xuống sàn và thả lỏng vai của bạn\nHít một hơi thật sâu và kéo tạ lên trên\nTập trung vào việc kéo bằng vai và cơ lưng và nâng khuỷu tay của bạn càng cao càng tốt khi bạn thở ra\nGiữ tạ nâng lên trong một hoặc hai giây trước khi trở về vị trí bắt đầu\nSau khi bạn hoàn thành một hiệp với một tay, hãy đổi bên và thực hiện một hiệp với tay kia", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("5cbc396e-381a-4d9f-9ad6-42b764deee3e"), 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đá mông", 0, "Đứng thẳng và chạy tại chỗ\nGiữ ngực thẳng và siết chặt và đưa gót chân lên mông của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6749cbc6-0e28-4163-95e8-7fb2a27c54cf"), 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chim bay", 1, "Đối với bài tập này, hãy chọn một quả tạ tương đối nhẹ\nNgồi xuống với ngực nghiêng về phía đầu gối\nNắm một quả tạ ở mỗi tay với lòng bàn tay hướng xuống dưới\nNâng tạ bằng cách dang rộng hai tay ra ngoài và giữ cho khuỷu tay vuông góc với cơ thể", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 8.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Leo núi", 0, "Bắt đầu ở tư thế plank\nKéo một đầu gối vào gần ngực, sau đó đổi chân\nGiữ nhịp điệu ổn định", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6badb5b5-ad99-4b89-80c6-e52d0f7cd7ba"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng chân sang ngang bên trái", 1, "Đứng thẳng và quấn dây kháng lực quanh chân của bạn\nGiữ thẳng lưng và siết chặt cơ bụng, sau đó nâng chân sang ngang\nThực hiện một hiệp đầy đủ với một chân, sau đó thực hiện một hiệp với chân kia", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6d6b06e1-5ade-4dae-b442-7aa200661760"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Plank bắt đầu", 0, "Vị trí plank cổ điển: hai tay trên sàn, hai chân rộng bằng hông, đầu gối cong\nNâng chân của bạn lên trần nhà mà không cong lưng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6ef8ed78-0d00-4271-bf9b-edf27a55ecab"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đá tay sau với tạ bên phải", 1, "Trong khi đứng, hạ ngực của bạn cho đến khi nó nằm ngang (hoặc gần như nằm ngang)\nNếu nó giúp ích, bạn có thể sử dụng lưng ghế để hỗ trợ cánh tay không hoạt động\nNắm một quả tạ bằng một tay với lòng bàn tay hướng vào cơ thể bạn\nGiữ cánh tay của bạn (cầm quả tạ) thẳng hàng với cơ thể của bạn\nGập khuỷu tay của bạn để cẳng tay của bạn thẳng đứng\nNâng quả tạ trong khi giữ cho cánh tay trên của bạn bất động\nTừ từ đưa quả tạ trở lại vị trí bắt đầu\nKhi cánh tay của bạn duỗi thẳng, nó phải thẳng hàng với ngực của bạn\nTiếp tục với tốc độ vừa phải mà không giật quả tạ lên trên\nSau khi bạn hoàn thành một hiệp với một tay, hãy đổi bên và thực hiện một hiệp với tay kia", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 9.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nhảy dang tay", 0, "Đứng thẳng với hai tay đặt dọc theo thân người\nNhảy lên đồng thời dang hai chân và đưa hai tay lên cao cho đến khi hai bàn tay chạm nhau trên đỉnh đầu\nGiữ tư thế này trong một giây\nThực hiện cú nhảy thứ hai, lần này đưa tay và chân trở lại vị trí bắt đầu", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6ffea500-ca35-4483-b049-d8593b2c8680"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gập bụng chéo bên trái", 1, "Nằm ngửa với hai chân cong\nNâng chân trái của bạn lên để nó vuông góc với chân phải của bạn\nĐặt chân trái của bạn lên đầu gối phải của bạn\nNâng ngực của bạn và đưa khuỷu tay phải của bạn càng gần đầu gối trái của bạn càng tốt\nNhìn lên trần nhà để bạn vận động cơ bụng đúng cách và không làm căng cổ\nThực hiện một hiệp đầy đủ như thế này. Sau đó đổi chân và thực hiện một hiệp trong khi đưa khuỷu tay trái của bạn lên đầu gối phải của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("72206c5e-58f3-46f0-a8b1-031cbf599433"), 5.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Macarena", 0, "Đứng thẳng lưng\nNâng hai tay sang hai bên\nThực hiện các chuyển động bắt chéo\nTay phải của bạn vượt qua tay trái của bạn và ngược lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chặt gỗ bên phải", 1, "Đặt một tay lên ghế hoặc băng ghế. Cúi người về phía trước cho đến khi ngực của bạn song song với sàn nhà, giữ lưng thẳng với đầu gối cong và lưng dưới hơi cong\nNắm một quả tạ bằng tay kia với lòng bàn tay hướng vào cơ thể bạn\nĐể tay cầm tạ hạ xuống sàn và thả lỏng vai của bạn\nHít một hơi thật sâu và kéo tạ lên trên\nTập trung vào việc kéo bằng vai và cơ lưng và nâng khuỷu tay của bạn càng cao càng tốt khi bạn thở ra\nGiữ tạ nâng lên trong một hoặc hai giây trước khi trở về vị trí bắt đầu\nSau khi bạn hoàn thành một hiệp với một tay, hãy đổi bên và thực hiện một hiệp với tay kia", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("8619916d-a296-48a5-af89-f82a6a1cb26f"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đá mông bên trái", 1, "Quỳ bốn chân và chống khuỷu tay với lưng thẳng, cổ thẳng hàng với cột sống và mắt hướng xuống đất\nKhi bạn thở ra, hãy nâng một chân lên và siết chặt mông của bạn\nKhi bạn hít vào, hãy hạ chân xuống mà không chạm đất\nLặp lại\nĐể khó hơn, hãy sử dụng tạ mắt cá chân", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("8b93dbb2-fc2b-4627-b79a-3ec45a7c6238"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đá mông bên phải", 1, "Quỳ bốn chân và chống khuỷu tay với lưng thẳng, cổ thẳng hàng với cột sống và mắt hướng xuống đất\nKhi bạn thở ra, hãy nâng một chân lên và siết chặt mông của bạn\nKhi bạn hít vào, hãy hạ chân xuống mà không chạm đất\nLặp lại\nĐể khó hơn, hãy sử dụng tạ mắt cá chân", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chào buổi sáng", 1, "Đứng thẳng với hai tay chống vào eo\nHai chân rộng bằng vai\nNhẹ nhàng gập đầu gối trong khi giữ lưng thẳng hoặc hơi cong\nHít một hơi thật sâu và thở ra trong khi nghiêng người về phía trước\nĐẩy hông ra phía sau để ngực hạ xuống vị trí nằm ngang, sau đó hít vào và trở lại vị trí thẳng đứng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("90ce2a9f-d0be-4ca0-b3ca-8b6947a6b266"), 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Siêu nhân", 0, "Nằm sấp trên thảm. Giữ chân thẳng và khép lại\nDuỗi thẳng tay lên trên đầu, tạo thành một đường thẳng với cơ thể\nHít vào và nâng tay, ngực và chân lên. Cơ thể tạo thành hình vòng cung\nGiữ tư thế trong khoảng 4 giây, sau đó thở ra và trở về vị trí bắt đầu. Lặp lại bài tập", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 6.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Squats", 1, "Đứng thẳng với hai chân rộng bằng vai và hai tay duỗi thẳng và thẳng hàng với bàn chân\nHít vào và gập đầu gối cho đến khi đùi của bạn song song với sàn nhà\nGiữ ngực thẳng đứng và dành nhiều thời gian hơn để hạ mình xuống hơn là đứng lên", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("93e22c77-001f-4825-8983-4ec5b643b7bb"), 4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng bắp chân", 1, "Đứng thẳng với hai chân duỗi thẳng để bàn chân, hông và vai của bạn thẳng hàng\nNhấc gót chân lên khỏi sàn nhiều lần liên tiếp\nBạn sẽ cảm thấy hơi nóng rát ở bắp chân", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("9ba29558-e51b-4a1a-a1c4-b747967e32fb"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư thế con thuyền", 0, "Nằm ngửa với hai chân duỗi thẳng\nNâng chân và ngực của bạn cho đến khi cơ thể bạn có hình chữ V\nGiữ lưng thẳng và ngực siết chặt\nNếu bài tập quá khó, bạn có thể giữ chân bằng tay\nNếu không, hãy giữ thẳng tay và nâng nhẹ lên khỏi mặt đất", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gập chân", 1, "Bắt đầu bằng cách quấn tạ mắt cá chân quanh mắt cá chân của bạn\nQuỳ gối ở tư thế plank và nâng bàn chân lên về phía mông\nNâng cho đến khi đầu gối của bạn thẳng hàng hoàn hảo với đầu của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"), 7.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Squat với tạ", 1, "Đứng thẳng với hai bàn chân rộng bằng vai và các ngón chân hơi hướng ra ngoài\nNắm một quả tạ giữa hai tay và nâng lên ngực với khuỷu tay cong\nNhìn thẳng về phía trước, hít một hơi thật sâu và siết chặt cơ bụng đồng thời đẩy hông ra sau và gập đầu gối để bắt đầu squat\nCột sống của bạn phải giữ ở vị trí trung lập\nGiữ lòng bàn chân đặt chắc chắn trên sàn và đảm bảo trọng lượng cơ thể và tạ được phân bổ đều trên bàn chân của bạn\nTrong khi squat, hạ mông xuống hơi quá điểm mà đùi của bạn song song với sàn nhà\nỞ dưới cùng của squat, khuỷu tay của bạn phải chạm vào bên trong đầu gối của bạn\nĐẩy gót chân để trở lại vị trí bắt đầu\nThở ra trong phần cuối cùng của bài tập này", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Burpee dễ dàng", 1, "Bắt đầu bằng cách đứng, sau đó vào vị trí plank bằng cách di chuyển từng chân ra phía sau\nĐưa hai chân về phía trước (từng chân một) vào tư thế squat\nNhảy thẳng lên và giơ hai tay lên trên đầu\nTrở lại vị trí plank và lặp lại bài tập", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gập bụng", 1, "Nằm ngửa với hai chân hơi cong\nNâng ngực lên cho đến khi bạn đang ngồi\nNhìn lên trần nhà để bạn vận động cơ bụng đúng cách và không làm căng cổ", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cuốn tạ", 1, "Đứng hoặc ngồi với hai bàn chân đủ rộng để giữ cho bạn ở một vị trí ổn định\nNắm một quả tạ mỗi tay và giữ cánh tay của bạn ở hai bên với lòng bàn tay hướng vào trong về phía đùi của bạn\nGập cánh tay của bạn lên trên trong khi giữ ngực thẳng và ưỡn\nKhi cánh tay của bạn cong 90°, hãy xoay cẳng tay của bạn để lòng bàn tay của bạn hướng lên trên\nTiếp tục nâng cánh tay của bạn, sau đó trở lại vị trí bắt đầu bằng cách thực hiện các bước theo thứ tự ngược lại\nLuân phiên từ phải sang trái", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("ae6eaaa1-c8c4-4f97-afa4-4ceeea19d4b3"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Lunge và xoay ngực", 1, "Đứng thẳng và bước một bước lớn về phía trước bằng cách gập chân cho đến khi đầu gối của bạn cong 90 độ\nKhi bạn ở vị trí bước tới, hãy xoay ngực sang bên phải nếu chân phải của bạn ở phía trước\nXoay ngực sang bên trái nếu chân trái của bạn ở phía trước\nThực hiện vài lần lặp lại ở mỗi bên", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("b2e62599-1f8c-4fc2-9ca7-8ab7aa571d4e"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ép tạ qua đầu khi ngồi", 1, "Nắm tạ ở mỗi tay\nNgồi trên ghế hoặc băng ghế và đặt tạ lên đùi của bạn\nTựa lưng vào ghế cực kỳ thẳng với vai ra sau và ngực ưỡn ra\nBàn chân của bạn phải đặt trên sàn và chân của bạn phải hoàn toàn ổn định\nNâng tạ cho đến khi tay của bạn ngang tầm với vai trên của bạn và khuỷu tay của bạn cong xuống và thẳng hàng với cơ thể của bạn\nLòng bàn tay của bạn phải hướng về phía trước\nBây giờ nâng tạ lên trên đầu với cánh tay duỗi thẳng và không khóa khuỷu tay\nCẩn thận trở lại vị trí bắt đầu và hoàn thành hiệp của bạn\nNhìn thẳng về phía trước trong suốt bài tập", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Duỗi tay sau đầu bên trái", 1, "Đứng thẳng\nNắm một quả tạ bằng một tay. Giữ ngực thẳng và thẳng, và nhìn thẳng phía trước\nGập khuỷu tay của bạn và nâng cánh tay lên trên đầu với cẳng tay và quả tạ treo phía sau bạn để khuỷu tay của bạn hướng thẳng lên trần nhà\nNgón út của bạn phải chạm vào đỉnh tay cầm quả tạ\nHít một hơi thật sâu và giữ cánh tay trên của bạn bất động\nĐẩy quả tạ lên trên cho đến khi cánh tay của bạn duỗi thẳng hoàn toàn\nTừ từ đưa quả tạ trở lại vị trí bắt đầu", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("bd80fdd3-c46c-4410-b126-51a11a8a2f5b"), 6.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chuông lắc", 1, "Vào tư thế chống đẩy\nĐưa hai chân vào để chúng hơi cong với mông nâng lên trần nhà\nĐảm bảo lưng của bạn vẫn thẳng\nĐu chân phải của bạn sang bên phải, sau đó đưa nó trở lại vị trí bắt đầu\nLàm tương tự với chân trái của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nhảy dây", 0, "Nắm mỗi đầu của dây nhảy\nVung dây và nhảy nhiều lần qua nó\nNếu bạn không có dây nhảy, hãy bắt chước chuyển động bằng cổ tay của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), 6.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Squat kiểu sumo", 1, "Đứng thẳng với hai chân rộng hơn vai một chút\nHít vào và khuỵu gối xuống càng sâu càng tốt\nĐẩy hông và mông ra phía sau mà không cong lưng\nĐảm bảo giữ ngực thẳng và ưỡn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Xoay người kiểu Nga", 1, "Nằm ngửa, nâng chân và ngực của bạn lên như thể bạn đang vào tư thế con thuyền\nNgoại trừ ở đây, đầu gối của bạn không bị khóa mà hơi cong\nXoay từ trái sang phải như thể bạn đang di chuyển một vật từ bên này cơ thể sang bên kia. Giữ lưng thẳng và ngực siết chặt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d0dcad19-4c0c-447d-8e3c-092c6d4ad14c"), 7.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đi bộ kiểu zombie", 0, "Đứng thẳng, bước về phía trước với hai tay duỗi thẳng phía trước bạn, và nâng chân lên ngang tầm tay của bạn với mỗi bước\nGiữ ngực thẳng đứng và cơ bụng siết chặt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d3d944c4-947d-4910-bb6e-636390e5b8d5"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Plank nghiêng bên trái", 0, "Vào vị trí plank nghiêng\nCơ thể của bạn phải được nâng lên khỏi thảm và chỉ được hỗ trợ bởi cẳng tay và bàn chân của bạn\nThở chậm và giữ cho cơ bụng của bạn siết chặt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d4ebca3a-83ef-485b-9178-83d4eab9694c"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cây cầu", 1, "Nằm ngửa với hai tay ở hai bên, hai chân cong và bàn chân đặt trên sàn\nThở ra trong khi nâng mông lên khỏi sàn, đảm bảo không mở rộng quá mức lưng dưới của bạn\nHít vào trong khi hạ xương chậu xuống, đảm bảo mông của bạn không chạm sàn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d6b2c0d5-110f-4dff-9aa7-91da10a29dca"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng hông với dây kháng lực", 1, "Quấn dây kháng lực quanh chân của bạn, ngay trên đầu gối\nTựa lưng trên của bạn vào mép ghế sofa, ghế tựa hoặc băng ghế\nLưỡi vai dưới của bạn phải nằm trực tiếp trên mép\nĐầu gối của bạn phải thẳng hàng hoàn hảo với ngực trên của bạn\nBàn chân của bạn phải thẳng hàng với đầu gối của bạn\nGiữ cho đầu gối của bạn cong, đẩy gót chân để nâng hông lên\nNâng hông của bạn lên và xuống mà không để mông chạm sàn\nPhần dưới cơ thể của bạn - chứ không phải lưng của bạn - phải thực hiện công việc\nKhông khóa đầu gối của bạn khi đi lên\nTối đa hóa sức đề kháng của dây\nĐặt chân của bạn ở nhiều góc độ khác nhau để tìm vị trí phù hợp nhất với bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bước tới", 1, "Đứng thẳng và bước một bước lớn về phía trước bằng cách gập chân cho đến khi đầu gối của bạn cong 90°\nTrở lại vị trí bắt đầu\nLuân phiên giữa chân phải và chân trái", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chống đẩy trên đầu gối", 1, "Nằm sấp\nĐặt hai tay thẳng trên sàn sao cho thẳng hàng với vai và hơi rộng hơn vai một chút\nGiữ cho cơ thể thẳng\nNâng cơ thể lên bằng cách duỗi thẳng tay, đồng thời giữ cho cơ thể thẳng\nTránh cong lưng\nChỉ có tay và đầu gối của bạn chạm sàn và cơ thể của bạn phải nằm trên một đường thẳng\nKhông chạm sàn giữa các lần chống đẩy", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sâu đo", 1, "Cúi xuống và đặt hai tay của bạn trên sàn nhà trước bàn chân của bạn, với mông hướng lên trần nhà\nHơi cong đầu gối của bạn\nSử dụng tay của bạn để di chuyển về phía trước cho đến khi bạn đạt đến vị trí plank\nGiữ ở vị trí này trong một giây trước khi di chuyển trở lại (bằng tay của bạn) về vị trí ban đầu, sau đó đứng thẳng\nLặp lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"), 8.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng cao gối", 0, "Đứng thẳng và chạy tại chỗ\nGiữ ngực thẳng và siết chặt và nâng đầu gối lên ngực", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 7.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nhảy Squat", 1, "Thực hiện một động tác squat\nKhi bạn đứng lên, hãy nhảy lên không trung bằng cách duỗi thẳng chân và đẩy tay lên trần nhà\nTrở lại tư thế squat và bắt đầu lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"), 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chuyển động Arlaud", 1, "Nằm sấp (trên thảm để thoải mái hơn) với hai tay duỗi thẳng và hai chân khép lại\nNgực của bạn hơi nâng lên\nHít một hơi thật sâu, sau đó nhẹ nhàng đưa hai tay ra phía sau trong khi thở ra\nHai tay của bạn không được chạm sàn\nCố gắng chạm vào mông của bạn\nĐưa hai tay trở lại vị trí bắt đầu và lặp lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đá chân sau với dây kháng lực bên phải", 1, "Đứng thẳng và quấn dây kháng lực quanh chân của bạn\nGiữ thẳng lưng và siết chặt cơ bụng, sau đó nâng chân ra phía sau\nThực hiện một hiệp đầy đủ với một chân, sau đó thực hiện một hiệp với chân kia\nCẩn thận không cong lưng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f93d73ba-d1d6-4037-b51b-1fd005accff3"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Plank nghiêng bên phải", 0, "Vào vị trí plank nghiêng\nCơ thể của bạn phải được nâng lên khỏi thảm và chỉ được hỗ trợ bởi cẳng tay và bàn chân của bạn\nThở chậm và giữ cho cơ bụng của bạn siết chặt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("faebde03-bab9-457b-9b45-a9fabd4760aa"), 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Burpee", 1, "Bắt đầu bằng cách đứng, sau đó hạ xuống sàn nhà vào vị trí plank. Ngay lập tức thực hiện chống đẩy\nĐưa hai chân của bạn về phía trước vào tư thế squat\nNhảy thẳng lên và giơ hai tay lên trên đầu\nTrở lại vị trí chống đẩy và lặp lại bài tập", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "CreatedAt", "CreatedBy", "FoodDescription", "FoodName", "IsPublic", "MealType", "Status", "UpdatedAt", "UpdatedBy", "UserId", "Views" },
                values: new object[,]
                {
                    { new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bí đỏ là loại rau quả giàu vitamin A và C, giúp cải thiện thị lực và sức khỏe da. Bí đỏ có thể chế biến thành các món canh, xào, hoặc làm sinh tố, là món ăn bổ dưỡng cho cả gia đình", "Bí đỏ", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("00bc33fe-4cd5-47df-bd94-15ac9f93648c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp rau củ là món canh thanh đạm với các loại rau củ như cà rốt, khoai tây, đậu que, nấu trong nước dùng nhẹ nhàng. Món này bổ dưỡng, dễ tiêu hóa và thích hợp cho các bữa ăn thanh mát", "Súp rau củ", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("01e60ae4-ff69-44d6-b4fd-aaf916e3a7e5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm gà xối mỡ là món ăn đặc trưng với cơm trắng ăn kèm thịt gà chiên giòn, đậm đà với lớp mỡ giòn rụm. Món này thường được ăn kèm với dưa leo và rau sống", "Cơm gà xối mỡ", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa tươi không đường là nguồn cung cấp canxi và protein giúp xương chắc khỏe. Nó cũng hỗ trợ phát triển cơ bắp, cung cấp vitamin A và D. Sữa tươi là thức uống bổ dưỡng cho bữa sáng hoặc giữa các bữa ăn", "Sữa tươi không đường", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0292d477-d63b-4904-a83b-2cd8cac39c14"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh củ quả là món canh với nhiều loại rau củ như cà rốt, khoai tây, đậu hà lan, nấu trong nước dùng nhẹ nhàng. Món này cung cấp nhiều vitamin và chất xơ, rất tốt cho sức khỏe", "Canh củ quả", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt heo bằm là nguyên liệu dễ chế biến, thường được dùng trong các món như thịt heo bằm xào rau, làm nhân cho các món bánh bao hoặc canh. Món này có hương vị mềm mại và giàu dinh dưỡng", "Thịt heo bằm", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì là món ăn nhanh, phổ biến với lớp vỏ giòn và nhân phong phú như thịt nướng, pate, trứng. Đây là lựa chọn lý tưởng cho bữa sáng hoặc bữa ăn nhẹ, dễ dàng mang theo và rất tiện lợi", "Bánh mì", true, "Breakfast,Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau muống là loại rau lá xanh phổ biến ở Việt Nam, có thể xào, luộc hoặc làm canh. Rau muống giàu vitamin, khoáng chất và chất xơ, giúp hỗ trợ tiêu hóa và giải nhiệt", "Rau muống", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún chả cá là món ăn với bún, chả cá chiên hoặc hấp và nước dùng từ cá. Món ăn này có vị ngọt tự nhiên từ cá, rất phổ biến ở miền Trung và Nam Việt Nam", "Bún chả cá", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt gà quay là món ăn có lớp da giòn, thịt mềm, được ướp gia vị rồi quay chín. Món này thường được ăn kèm với cơm hoặc rau sống, rất ngon miệng và dễ ăn", "Thịt gà quay", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hoành thánh là món ăn từ bột mì, nhân thịt hoặc tôm, thường được nấu trong nước dùng thơm ngon. Món này có thể ăn trong các bữa sáng hoặc bữa tối, mang lại cảm giác ấm cúng và bổ dưỡng", "Hoành thánh", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau dền đỏ là loại rau xanh giàu vitamin C và chất xơ, giúp hỗ trợ tiêu hóa và tăng cường miễn dịch. Rau dền đỏ có thể xào, nấu canh hoặc làm món gỏi, rất bổ dưỡng", "Rau dền đỏ", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chuối tây là trái cây ngọt, dễ ăn, giàu kali và vitamin. Chuối tây thường được ăn trực tiếp hoặc làm tráng miệng, sinh tố, chè. Đây là món ăn bổ dưỡng và dễ tiêu hóa, thích hợp cho mọi lứa tuổi", "Chuối tây", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Táo là trái cây giàu vitamin C và chất xơ, tốt cho tiêu hóa và hệ tim mạch. Táo có thể ăn trực tiếp hoặc làm sinh tố, salad, giúp tăng cường sức khỏe và cung cấp năng lượng tự nhiên cho cơ thể", "Táo", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo đậu đỏ là món ăn nhẹ nhàng, làm từ đậu đỏ và gạo, có tác dụng bổ máu, thanh nhiệt. Món này có thể ăn vào buổi sáng hoặc tối, rất bổ dưỡng và dễ tiêu hóa", "Cháo đậu đỏ", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Quýt là trái cây ngọt, chứa nhiều vitamin C và giúp tăng cường hệ miễn dịch. Quýt có thể ăn trực tiếp hoặc làm nước ép, rất tốt cho sức khỏe, đặc biệt là giúp giải nhiệt trong mùa hè", "Quýt", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu hũ là món ăn được làm từ đậu nành, giàu protein thực vật. Đậu hũ có thể chế biến theo nhiều cách như chiên, nấu canh hoặc xào, mang lại hương vị thanh nhẹ và tốt cho sức khỏe", "Đậu hũ", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nho là trái cây ngọt, giàu vitamin C và chất chống oxy hóa, có tác dụng tăng cường sức đề kháng và làm đẹp da. Nho có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng", "Nho", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nấm kim châm là loại nấm có thân dài và mỏng, thường được dùng trong các món canh, xào hoặc salad. Nấm kim châm giàu chất xơ và khoáng chất, rất tốt cho sức khỏe, đặc biệt là hệ tiêu hóa", "Nấm kim châm", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2146faae-2e7c-4460-8d81-38f5d313012c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo đậu xanh là món ăn nhẹ, dễ tiêu hóa, được làm từ đậu xanh và gạo, có tác dụng bổ máu và thanh nhiệt. Món này có thể ăn vào bữa sáng hoặc tối, rất bổ dưỡng", "Cháo đậu xanh", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bao chay là món ăn làm từ bột mì, nhân là các loại rau củ, đậu hũ hoặc nấm. Đây là món ăn phù hợp cho những người ăn chay, với hương vị nhẹ nhàng và bổ dưỡng", "Bánh bao chay", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu hũ non là món ăn được làm từ đậu nành, có kết cấu mềm mịn. Đậu hũ non có thể chế biến thành các món xào, canh hoặc ăn kèm với siro, là món ăn dễ tiêu hóa và rất bổ dưỡng", "Đậu hũ non", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Khoai lang luộc là món ăn đơn giản nhưng giàu dinh dưỡng, cung cấp vitamin A, chất xơ và khoáng chất. Khoai lang có thể ăn trực tiếp hoặc dùng làm món ăn kèm trong các bữa chính", "Khoai lang luộc", true, "Breakfast,Snack,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2405ffc3-524e-4331-9e68-47a411d7b9b8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm chiên dương châu là món cơm chiên với các loại rau củ, tôm, thịt, trứng, mang đến hương vị đậm đà và đầy đủ dinh dưỡng. Món này thích hợp cho bữa trưa hoặc tối", "Cơm chiên dương châu", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cải thảo là loại rau xanh, thường được dùng trong các món xào, nấu canh hoặc làm gỏi. Cải thảo chứa nhiều vitamin và khoáng chất, giúp hỗ trợ tiêu hóa và cải thiện sức khỏe", "Cải thảo", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bao xá xíu là món bánh mềm mịn, với nhân thịt heo xá xíu thơm ngon. Món này rất phổ biến trong các bữa sáng hoặc bữa ăn nhanh gọn, giàu protein và dễ tiêu hóa", "Bánh bao xá xíu", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("29dfb5da-8818-40ff-bf66-7553521c2161"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bò kho là món ăn với thịt bò hầm mềm mịn, nước dùng đậm đà với gia vị thơm ngon. Món này thường ăn kèm với bánh mì hoặc bún, là bữa ăn đầy đủ và ấm áp", "Bò kho", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ae82bfd-34db-4928-bfee-b60f4aec4460"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh bí đỏ là món ăn thanh mát, giàu vitamin A và C. Canh bí đỏ có thể nấu với thịt heo hoặc tôm, mang lại hương vị ngọt tự nhiên, bổ dưỡng và dễ tiêu hóa", "Canh bí đỏ", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau cải xanh là loại rau giàu vitamin A, C và chất xơ, có thể chế biến thành các món xào, luộc hoặc nấu canh. Món rau cải xanh cung cấp nhiều dưỡng chất và giúp thanh nhiệt cho cơ thể", "Rau cải xanh", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì ốp la là món ăn sáng phổ biến với bánh mì giòn, nhân trứng ốp la và có thể kèm thịt, rau. Đây là món ăn nhanh gọn, dễ dàng và bổ dưỡng", "Bánh mì ốp la", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dâu tây là trái cây ngọt, chứa nhiều vitamin C và chất chống oxy hóa, giúp làm đẹp da và tăng cường sức đề kháng. Dâu tây có thể ăn trực tiếp, làm sinh tố, hoặc chế biến thành các món tráng miệng", "Dâu tây", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa đậu nành là thức uống từ đậu nành xay nhuyễn, giàu protein và vitamin. Đây là món ăn sáng phổ biến, bổ dưỡng, có thể uống nóng hoặc lạnh, đặc biệt tốt cho người ăn chay và những người muốn bổ sung dưỡng chất từ thực vật", "Sữa đậu nành", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ee163f7-4463-44ec-b9e2-8a409c112db4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau luộc là món ăn thanh mát, giúp bổ sung vitamin và khoáng chất, rất tốt cho sức khỏe. Các loại rau như rau muống, rau ngót thường được luộc và ăn kèm với nước mắm hoặc gia vị", "Rau luộc", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo lòng là món ăn sáng phổ biến, được làm từ cháo gạo nấu với các loại nội tạng heo như lòng, gan, dồi. Món này có vị đậm đà, thường ăn kèm với hành lá, rau thơm và gia vị", "Cháo lòng", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Khoai lang là một loại củ giàu vitamin và chất xơ, có thể chế biến thành các món như khoai lang luộc, chiên, hoặc làm món xào. Món này cung cấp năng lượng và rất tốt cho sức khỏe", "Khoai lang", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cải thìa là loại rau xanh giàu vitamin và khoáng chất, có thể chế biến theo nhiều cách như xào, luộc hoặc nấu canh. Cải thìa giúp giải nhiệt và tốt cho hệ tiêu hóa, thường dùng trong các bữa ăn gia đình", "Cải thìa", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp gà nấm là món ăn nhẹ nhàng với nước dùng từ gà và nấm, giúp thanh nhiệt và dễ tiêu hóa. Món này thường ăn vào bữa sáng hoặc khi cần bồi bổ cơ thể", "Súp gà nấm", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Măng khô là món ăn được làm từ măng tươi phơi khô, có thể chế biến thành các món canh hoặc xào. Măng khô có vị ngọt tự nhiên, giòn và là món ăn bổ dưỡng trong các bữa ăn gia đình", "Măng khô", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nước chanh là thức uống giải khát tuyệt vời, giúp cung cấp vitamin C, giải nhiệt và làm đẹp da. Món này có thể uống vào bất kỳ thời gian nào trong ngày, đặc biệt là trong mùa hè", "Nước chanh", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3d19d971-88d0-4108-a335-24ac9e1dec50"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Măng cụt là trái cây ngọt, mọng nước, chứa nhiều vitamin C và khoáng chất. Món này có thể ăn trực tiếp hoặc làm nước ép, mang lại cảm giác giải nhiệt và bổ sung dinh dưỡng", "Măng cụt", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3dc2fa80-ab87-4e26-907b-3516611371b8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh bầu là món canh thanh mát, với bầu nấu cùng nước dùng nhẹ nhàng từ xương hoặc thịt. Món canh này có tác dụng giải nhiệt, rất thích hợp trong những ngày hè nóng bức", "Canh bầu", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu nành luộc là món ăn nhẹ, giàu protein và vitamin. Đậu nành có thể ăn trực tiếp hoặc chế biến thành các món như đậu hũ, giúp bổ sung dinh dưỡng cho cơ thể", "Đậu nành luộc", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu bắp là loại rau quả giàu vitamin C và chất xơ, giúp hỗ trợ tiêu hóa và làm đẹp da. Đậu bắp có thể ăn luộc, xào hoặc làm canh, là món ăn bổ dưỡng cho các bữa ăn gia đình", "Đậu bắp", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cà chua là thực phẩm giàu vitamin C và chất xơ, có tác dụng làm đẹp da và hỗ trợ tiêu hóa. Cà chua có thể ăn sống, làm salad, hoặc chế biến thành các món xào, canh", "Cà chua", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("43d635e2-6f0c-4385-83d8-fedfd479d356"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt gà kho là món ăn đậm đà với thịt gà kho trong gia vị như nước mắm, tiêu, và gia vị khác. Món này có thể ăn kèm với cơm trắng, mang lại hương vị ngon miệng và bổ dưỡng", "Thịt gà kho", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dưa chuột là rau quả tươi mát, giúp giải nhiệt và làm đẹp da. Dưa chuột có thể ăn sống, làm salad, hoặc chế biến thành món xào và canh, rất thích hợp trong các bữa ăn hằng ngày để thanh lọc cơ thể", "Dưa chuột", true, "Breakfast,Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún chả là món ăn đặc sản Hà Nội, gồm bún, thịt chả nướng, và rau sống. Món ăn này có nước mắm pha chua ngọt, tạo thành bữa ăn ngon miệng, đậm đà và rất dễ ăn", "Bún chả", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún mắm là món ăn nổi bật với nước dùng từ mắm, kết hợp với bún và các loại hải sản như tôm, cá. Đây là món ăn đặc sản của miền Tây, mang lại hương vị đậm đà và rất thơm ngon", "Bún mắm", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dừa tươi là thức uống giải khát tuyệt vời, giàu vitamin C và khoáng chất. Nước dừa cung cấp độ ẩm và giúp thanh nhiệt, rất tốt cho làn da và sức khỏe hệ tiêu hóa", "Dừa tươi", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tôm hấp là món ăn đơn giản, dễ chế biến, giữ nguyên vị ngọt của tôm. Món này thường được ăn kèm với muối tiêu chanh hoặc nước mắm chua ngọt, thích hợp cho bữa ăn nhẹ", "Tôm hấp", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4edcae53-7e30-42bb-8526-7686355f2268"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh cải xanh là món canh nhẹ, giàu vitamin và khoáng chất, thường được nấu với thịt heo hoặc tôm. Đây là món ăn bổ dưỡng, dễ tiêu hóa và thích hợp cho các bữa ăn thanh đạm", "Canh cải xanh", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu hũ chiên là món ăn phổ biến trong các bữa ăn chay, có kết cấu giòn bên ngoài và mềm mịn bên trong. Món này có thể ăn kèm với các loại nước chấm hoặc xào với rau củ", "Đậu hũ chiên", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("51061170-597d-4289-a021-1e7dde88331f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt vịt là nguồn protein giàu chất dinh dưỡng, có thể chế biến thành nhiều món như vịt nướng, vịt kho hoặc vịt luộc. Món thịt vịt thường có hương vị đặc trưng, đậm đà và thích hợp cho các bữa ăn gia đình", "Thịt vịt", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bò bít tết là món ăn từ thịt bò nạc, được nướng hoặc áp chảo đến độ chín vừa phải. Món này thường được ăn kèm với khoai tây chiên hoặc rau sống, mang lại hương vị đậm đà, rất thích hợp cho bữa tối", "Bò bít tết", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh chua cá là món ăn đậm đà với nước dùng chua ngọt, thường làm từ cá và các loại rau như giá đỗ, ngò rí, ăn kèm với bún. Món này thanh mát, giải nhiệt và rất bổ dưỡng", "Canh chua cá", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rong biển khô là thực phẩm giàu vitamin, khoáng chất và chất xơ, rất tốt cho sức khỏe. Món rong biển có thể dùng làm salad, súp, hoặc làm nhân cho sushi, rất phổ biến trong ẩm thực châu Á", "Rong biển khô", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ớt chuông là loại rau quả giàu vitamin C, giúp tăng cường sức khỏe và làm đẹp da. Ớt chuông có thể ăn sống, xào, hoặc làm salad, mang lại hương vị tươi mát và màu sắc đẹp mắt cho bữa ăn", "Ớt chuông", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cải bó xôi là rau xanh giàu vitamin A, C và chất sắt. Món cải bó xôi có thể ăn sống trong salad, xào hoặc nấu canh, giúp tăng cường sức khỏe xương và cải thiện hệ miễn dịch", "Cải bó xôi", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm là món ăn chủ yếu trong bữa ăn Việt Nam, cung cấp tinh bột quan trọng. Cơm thường ăn kèm với các món mặn như thịt, cá và rau, tạo nên một bữa ăn đầy đủ dinh dưỡng, bổ sung năng lượng cho cơ thể", "Cơm", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Lựu là trái cây giàu vitamin C, chất chống oxy hóa và khoáng chất. Món này có thể ăn trực tiếp hoặc làm nước ép, giúp cải thiện hệ miễn dịch và làm đẹp da", "Lựu", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá ngừ đóng hộp là món ăn tiện lợi, giàu protein và omega-3. Món này có thể ăn trực tiếp, làm salad hoặc kèm với cơm, rất dễ chế biến và thích hợp cho bữa ăn nhanh", "Cá ngừ đóng hộp", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp cua là món ăn nhẹ với nước dùng từ cua, mang hương vị ngọt tự nhiên và bổ dưỡng. Món này thường được ăn vào bữa sáng hoặc bữa tối, rất giàu protein và khoáng chất", "Súp cua", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt kho trứng là món ăn quen thuộc với thịt heo kho cùng trứng luộc, mang hương vị mặn ngọt đậm đà. Món này thường ăn kèm với cơm trắng, rất ngon miệng và bổ dưỡng", "Thịt kho trứng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mì quảng là món đặc sản của miền Trung, gồm mì gạo, nước dùng đậm đà, tôm, thịt hoặc trứng, và rau sống. Món ăn này có vị đặc trưng và rất thích hợp cho bữa sáng hoặc trưa", "Mì quảng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nấm đùi gà có hình dạng giống đùi gà, thịt nấm mềm và thơm. Món này thường được dùng trong các món xào, nấu canh hoặc làm salad, rất giàu dinh dưỡng và dễ chế biến", "Nấm đùi gà", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh cua mồng tơi là món ăn dân dã, có vị ngọt từ cua và mồng tơi. Món này không chỉ thơm ngon mà còn rất bổ dưỡng, đặc biệt tốt cho hệ tiêu hóa và làn da", "Canh cua mồng tơi", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau mồng tơi là loại rau xanh giàu vitamin A và chất sắt, có thể chế biến thành các món xào, luộc hoặc canh. Món rau này giúp thanh nhiệt, giải độc và tốt cho hệ tiêu hóa", "Rau mồng tơi", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6487a532-ff5e-4b77-b408-46c789608de9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh bí đao là món canh mát, giúp giải nhiệt và thanh lọc cơ thể. Bí đao có thể nấu với tôm, thịt heo hoặc cá, mang lại hương vị thanh đạm và rất bổ dưỡng cho sức khỏe", "Canh bí đao", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh rau ngót là món canh thanh mát, có vị ngọt tự nhiên từ rau ngót. Món này thường được nấu với thịt hoặc tôm, giúp giải nhiệt và bổ sung dinh dưỡng cho cơ thể", "Canh rau ngót", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì sandwich là món ăn nhanh với lớp bánh mì mềm, nhân có thể là thịt, rau, trứng hoặc phô mai. Đây là lựa chọn lý tưởng cho bữa sáng hoặc bữa phụ, dễ dàng mang theo khi đi làm hoặc đi học", "Bánh mì sandwich", true, "Breakfast,Lunch,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cà phê là thức uống quen thuộc, có thể uống đen hoặc thêm sữa, với hương vị đậm đà và kích thích tinh thần. Cà phê thường được uống vào buổi sáng hoặc trong suốt cả ngày để duy trì sự tỉnh táo", "Cà phê", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau má là loại rau mát, giúp thanh nhiệt, giải độc và làm đẹp da. Rau má có thể ăn sống trong salad hoặc nấu canh, rất tốt cho sức khỏe và có tác dụng làm dịu cơ thể trong mùa hè", "Rau má", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hủ tiếu là món ăn gồm mì hoặc bún ăn kèm với nước dùng thơm ngon và các loại thịt như tôm, gà, hoặc heo. Món này phổ biến ở miền Nam Việt Nam và rất dễ ăn, thích hợp cho bữa sáng hoặc bữa tối", "Hủ tíu", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo sườn là món ăn sáng phổ biến, với cháo mềm mịn kết hợp cùng sườn heo kho hoặc hầm. Món này có vị ngọt tự nhiên từ xương, thường ăn kèm với hành lá, rau thơm và gia vị", "Cháo sườn", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7167f942-dc89-4f29-8022-588373aef45e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún gà là món ăn thanh mát với bún, thịt gà luộc hoặc xé nhỏ và nước dùng thơm ngon. Đây là món ăn nhẹ nhàng, thích hợp cho bữa sáng hoặc bữa trưa", "Bún gà", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh bún là món ăn nổi bật với nước dùng ngọt từ xương, kết hợp với bún, thịt heo hoặc tôm. Món này thường ăn kèm với rau sống và gia vị, mang lại hương vị đậm đà và dễ ăn", "Canh bún", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sườn non là phần thịt heo mềm, có thể chế biến thành nhiều món như sườn nướng, sườn kho hoặc sườn xào chua ngọt. Món sườn non rất thích hợp cho các bữa cơm gia đình, có vị đậm đà và dễ ăn", "Sườn non", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bao là món ăn đơn giản, với lớp vỏ mềm mịn và nhân thịt heo hoặc trứng. Đây là món ăn nhanh gọn, thường được ăn sáng hoặc làm món phụ trong các bữa ăn chính", "Bánh bao", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cà rốt là rau củ giàu vitamin A, giúp cải thiện thị lực và sức khỏe da. Cà rốt có thể ăn sống, làm salad, hoặc chế biến thành các món xào, canh hoặc nước ép", "Cà rốt", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì thịt trứng là món ăn nhanh, với bánh mì mềm, nhân thịt nướng và trứng chiên. Đây là món ăn sáng phổ biến, đơn giản nhưng đầy đủ dinh dưỡng, dễ ăn và tiện lợi", "Bánh mì thịt trứng", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún xào là món ăn ngon miệng với bún xào cùng các loại rau và thịt hoặc tôm. Món này thường được chế biến nhanh, có vị thơm, ngọt từ các nguyên liệu kết hợp, thường ăn vào bữa trưa hoặc tối", "Bún xào", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm tấm sườn là món ăn phổ biến ở miền Nam Việt Nam, bao gồm cơm tấm mềm mịn ăn kèm với sườn nướng và các loại rau sống. Món này mang lại hương vị đậm đà và đầy đủ dinh dưỡng", "Cơm tấm sườn", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Măng tây là loại rau giàu vitamin K và chất chống oxy hóa, tốt cho sức khỏe tim mạch và hệ xương. Măng tây có thể xào, nấu canh hoặc ăn sống, rất bổ dưỡng và dễ chế biến", "Măng tây", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Kiwi là trái cây giàu vitamin C, chất xơ và chất chống oxy hóa. Kiwi giúp cải thiện hệ tiêu hóa, tăng cường sức đề kháng và làm đẹp da. Món này có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng", "Kiwi", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp bò hầm là món ăn có nước dùng đậm đà từ xương bò, với thịt bò mềm và rau củ đi kèm. Món này cung cấp năng lượng và dưỡng chất, rất phù hợp cho bữa tối", "Súp bò hầm", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b8500af-d730-4138-9617-cba352faed4a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Vải là trái cây ngọt, chứa nhiều vitamin C và khoáng chất. Vải có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng, đặc biệt trong mùa hè", "Vải", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7cd76708-7312-445e-a392-14f0e806a786"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu Hà Lan là loại rau giàu vitamin, khoáng chất và chất xơ, giúp hỗ trợ hệ tiêu hóa và tăng cường miễn dịch. Đậu Hà Lan có thể ăn trực tiếp, làm salad hoặc nấu canh", "Đậu Hà Lan", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún thịt nướng là món ăn gồm bún mềm, thịt nướng thơm ngon và các loại rau sống. Món này có thể ăn kèm với nước mắm pha, tạo thành một bữa ăn vừa thanh mát vừa đầy đủ dinh dưỡng", "Bún thịt nướng", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bầu là loại rau quả mát, chứa nhiều vitamin và khoáng chất. Bầu có thể chế biến thành các món canh, xào hoặc làm gỏi, giúp thanh nhiệt và hỗ trợ tiêu hóa", "Bầu", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá ngừ là loại hải sản giàu omega-3 và protein, có thể chế biến thành nhiều món như cá ngừ nướng, cá ngừ kho hoặc làm sushi. Món này rất bổ dưỡng và dễ dàng chế biến", "Cá ngừ", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("827829bf-71cd-4865-80af-1457e0091456"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh nấm là món ăn nhẹ, bổ dưỡng, giàu vitamin và chất xơ. Nấm có thể kết hợp với rau củ hoặc thịt để tạo ra món canh thơm ngon, rất phù hợp cho bữa ăn thanh đạm", "Canh nấm", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bông cải xanh (súp lơ) là loại rau chứa nhiều vitamin C, vitamin K và chất chống oxy hóa. Bông cải xanh có thể xào, luộc hoặc làm món canh, là món ăn bổ dưỡng giúp cải thiện sức khỏe", "Bông cải xanh", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8382816f-1beb-4804-9698-3b486798b20a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì chả lụa là món ăn sáng phổ biến, với bánh mì giòn và nhân chả lụa thơm ngon. Món này đơn giản, dễ ăn và thích hợp cho bữa sáng hoặc bữa phụ", "Bánh mì chả lụa", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt kho tiêu là món ăn đơn giản nhưng thơm ngon, thường làm từ thịt ba chỉ hoặc thịt heo kho với tiêu, nước dừa và gia vị. Món này có vị mặn ngọt đậm đà, ăn cùng với cơm trắng rất hợp", "Thịt kho tiêu", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Củ cải trắng là loại rau củ giàu vitamin C và chất xơ, giúp thanh nhiệt và giải độc cơ thể. Món củ cải trắng có thể ăn sống, xào hoặc nấu canh, mang lại hương vị thanh mát và bổ dưỡng", "Củ cải trắng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Củ cải đường là loại củ chứa nhiều vitamin C và khoáng chất, giúp cải thiện sức khỏe tim mạch và huyết áp. Món củ cải đường có thể ăn sống, xào hoặc nấu canh, mang lại lợi ích cho cơ thể", "Củ cải đường", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Xúc xích là món ăn làm từ thịt xay (thường là thịt heo hoặc bò), tẩm gia vị và nhồi vào ruột lợn, sau đó luộc hoặc nướng. Xúc xích dễ dàng chế biến và là món ăn nhanh gọn cho bữa sáng hoặc bữa phụ", "Xúc xích", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("85e621ed-0e0c-4d20-8891-51d311cea4a3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh thịt bò hầm là món canh đậm đà, với thịt bò hầm mềm cùng các gia vị và rau củ. Món này bổ dưỡng, cung cấp nhiều protein và khoáng chất, thích hợp cho bữa tối hoặc bữa chính", "Canh thịt bò hầm", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ức gà nướng là món ăn ít mỡ, giàu protein, có thể được ướp gia vị và nướng chín. Món này thường được ăn kèm với rau củ hoặc cơm, là lựa chọn tốt cho bữa ăn nhẹ nhàng nhưng đầy đủ dinh dưỡng", "Ức gà nướng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("86d88717-df08-4de6-b86d-870210864b46"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thanh long là trái cây ngọt, mát, chứa nhiều vitamin C và khoáng chất, giúp tăng cường sức đề kháng và làm đẹp da. Thanh long có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng", "Thanh long", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Phở bò viên là món phở nổi tiếng với nước dùng trong, đậm đà từ xương bò, ăn kèm với bánh phở mềm và bò viên. Món này mang lại hương vị thơm ngon, phổ biến cho bữa sáng", "Phở bò viên", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh bí đỏ nấu tôm là món canh nhẹ, thanh mát, với bí đỏ nấu mềm kết hợp với tôm. Món canh này giàu vitamin A và protein, giúp bổ dưỡng và dễ tiêu hóa", "Canh bí đỏ nấu tôm", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh mùng tơi mướp là món canh mát, giải nhiệt, giúp bổ sung dưỡng chất và hỗ trợ tiêu hóa. Món này thường được nấu với thịt hoặc tôm, mang lại hương vị thanh đạm và bổ dưỡng", "Canh mùng tơi mướp", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Khoai tây là nguồn cung cấp tinh bột và vitamin C. Khoai tây có thể chế biến thành nhiều món như khoai tây chiên, luộc, nghiền hoặc nướng, rất phổ biến trong các bữa ăn gia đình", "Khoai tây", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh hỏi là món ăn với bánh phở mềm, thường được ăn kèm với thịt nướng hoặc chả, và nước mắm pha. Món này có vị thanh nhẹ, rất phổ biến trong các bữa ăn ở miền Trung", "Bánh hỏi", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Khoai môn là loại củ giàu tinh bột và vitamin C, có thể chế biến thành các món xào, luộc, làm chè hoặc làm nhân bánh. Món khoai môn rất bổ dưỡng và dễ tiêu hóa", "Khoai môn", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu hũ sốt cà là món ăn chay nhẹ nhàng, với đậu hũ mềm mịn ăn kèm với sốt cà chua đậm đà. Món này cung cấp protein thực vật và rất dễ chế biến, phù hợp cho các bữa ăn chay hoặc ăn kiêng", "Đậu hũ sốt cà", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8ed85dc2-7654-4c48-81f9-19946a73f71d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bắp cải luộc là món ăn thanh mát, dễ làm, chứa nhiều vitamin và khoáng chất. Bắp cải luộc có thể ăn kèm với nước mắm hoặc làm món ăn phụ trong bữa ăn chính", "Bắp cải luộc", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún bò Huế là món ăn nổi tiếng với nước dùng đậm đà từ xương bò, mắm ruốc, và gia vị đặc trưng. Món này kết hợp bún, thịt bò, giò heo và rau sống, tạo nên hương vị thơm ngon, hấp dẫn cho bữa ăn", "Bún bò huế", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún ốc là món ăn nổi bật với nước dùng chua ngọt từ ốc và gia vị, kết hợp với bún và các loại rau sống. Món này có vị thơm ngon, thích hợp cho bữa trưa hoặc tối", "Bún ốc", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("90a605b6-843d-4cc1-8fe7-a016c76ee29c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau muống luộc là món ăn đơn giản, dễ làm, rất phổ biến ở Việt Nam. Rau muống luộc có thể ăn kèm với nước mắm tỏi ớt hoặc làm món ăn phụ trong bữa cơm, giúp thanh nhiệt và bổ sung dưỡng chất", "Rau muống luộc", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Trà tắc là thức uống giải khát phổ biến, được làm từ trà xanh kết hợp với nước cốt chanh tươi và mật ong. Trà tắc giúp giải nhiệt, thanh lọc cơ thể và mang lại cảm giác sảng khoái", "Trà tắc", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Phở bò tái là món phở nổi tiếng với nước dùng trong, đậm đà từ xương bò, ăn kèm với thịt bò tái và bánh phở mềm. Món ăn này rất phổ biến vào buổi sáng ở Việt Nam, mang lại cảm giác ấm cúng và no lâu", "Phở bò tái", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì chả cá là món ăn sáng quen thuộc, với bánh mì mềm, nhân chả cá chiên thơm ngon và rau sống. Món này rất phổ biến ở Việt Nam, tiện lợi và dễ ăn", "Bánh mì chả cá", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu que là loại rau quả giàu vitamin và chất xơ, có thể chế biến thành các món xào, luộc hoặc nấu canh. Đậu que giúp tăng cường hệ tiêu hóa và cung cấp năng lượng cho cơ thể", "Đậu que", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("982d8f3e-f517-4bd2-87a8-48329fc9eb91"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh cải ngọt là món ăn nhẹ nhàng, với cải ngọt nấu trong nước dùng, có thể kết hợp với thịt heo hoặc tôm. Món canh này bổ dưỡng, dễ tiêu hóa và giúp thanh nhiệt", "Canh cải ngọt", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa bò tươi là thức uống bổ dưỡng, cung cấp canxi, vitamin D và protein. Sữa bò có thể uống trực tiếp hoặc làm nguyên liệu cho các món sinh tố, mang lại nhiều lợi ích cho sức khỏe xương", "Sữa bò tươi", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau cải bó xôi là loại rau xanh chứa nhiều vitamin A, C và chất sắt. Món cải bó xôi có thể ăn sống trong salad, xào hoặc nấu canh, rất bổ dưỡng và tốt cho sức khỏe xương", "Rau cải bó xôi", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau chân vịt (cải bó xôi) là loại rau giàu vitamin A, C và chất sắt, giúp tăng cường sức khỏe xương và hỗ trợ miễn dịch. Rau chân vịt có thể ăn sống trong salad, xào hoặc nấu canh", "Rau chân vịt", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau muống xào tỏi là món ăn phổ biến, với rau muống tươi xào cùng tỏi và gia vị. Món này có vị đậm đà, thơm ngon, rất thích hợp ăn kèm với cơm trắng", "Rau muống xào tỏi", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cải ngọt luộc là món rau luộc đơn giản, dễ làm, giàu vitamin và chất xơ. Món này thường ăn kèm với nước mắm chua ngọt hoặc làm món ăn phụ trong các bữa ăn chính", "Cải ngọt luộc", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gạo lứt là loại gạo nguyên hạt, giàu chất xơ, vitamin và khoáng chất. Món gạo lứt có thể ăn kèm với các món thịt hoặc rau, giúp duy trì năng lượng lâu dài và rất tốt cho hệ tiêu hóa", "Gạo lứt", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cam là trái cây giàu vitamin C, giúp tăng cường miễn dịch và làm đẹp da. Cam có thể ăn trực tiếp hoặc làm nước ép, giúp giải nhiệt và bổ sung dinh dưỡng cho cơ thể", "Cam", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa chua là món ăn từ sữa lên men, chứa nhiều vi khuẩn có lợi cho hệ tiêu hóa. Sữa chua có thể ăn trực tiếp hoặc làm thành các món tráng miệng, bổ dưỡng và dễ tiêu hóa", "Sữa chua", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá hồi hun khói là món ăn giàu omega-3, có hương vị đậm đà và thơm ngon từ quá trình hun khói. Món này thường được ăn kèm với bánh mì hoặc làm thành salad, rất bổ dưỡng và dễ ăn", "Cá hồi hun khói", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm gạo lức được làm từ gạo lức chưa xay xát hoàn toàn, giàu chất xơ và dinh dưỡng. Món này cung cấp năng lượng lâu dài, tốt cho sức khỏe và rất phổ biến trong các bữa ăn hàng ngày", "Cơm gạo lức", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Xoài là trái cây ngọt, thơm, giàu vitamin C và chất xơ. Xoài có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng", "Xoài", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a364353c-d589-4a94-9c3b-3038113ea249"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bò xào rau củ là món ăn ngon với thịt bò thái mỏng xào nhanh với các loại rau củ như ớt, hành tây, cà rốt. Món này cung cấp nhiều vitamin và protein, thích hợp cho bữa tối bổ dưỡng", "Bò xào rau củ", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún riêu cua là món ăn nổi tiếng với nước dùng chua ngọt, kết hợp với cua, bún và các loại rau sống. Món ăn này mang hương vị đặc trưng và bổ dưỡng, phù hợp cho bữa trưa hoặc tối", "Bún riêu cua", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nước dừa là thức uống mát từ nước bên trong quả dừa, giúp giải nhiệt và bổ sung khoáng chất. Nó cũng rất tốt cho làn da và hệ tiêu hóa, thích hợp để uống trong mùa hè", "Nước dừa", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a504d882-4f38-413e-bb28-fae1f2787150"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nhãn là trái cây ngọt, mọng nước, chứa nhiều vitamin C và giúp tăng cường sức đề kháng. Nhãn có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng, rất tốt cho sức khỏe", "Nhãn", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mực là hải sản giàu protein và khoáng chất, có thể chế biến thành các món xào, hấp, hoặc nướng. Mực có vị ngọt tự nhiên, giúp bổ sung dinh dưỡng và rất dễ ăn", "Mực", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 27 },
                    { new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt lợn xông khói có vị mặn ngọt, được chế biến bằng cách xông khói để tạo hương vị đặc trưng. Món này có thể ăn kèm với cơm, salad hoặc làm nhân cho bánh mì", "Thịt lợn xông khói", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt bò nạc là phần thịt ít mỡ, giàu protein và sắt, có thể chế biến thành các món như bò xào, nướng hoặc làm súp. Món ăn này cung cấp năng lượng và dưỡng chất cho cơ thể, thích hợp cho các bữa chính", "Thịt bò nạc", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mâm xôi là trái cây giàu vitamin C và chất chống oxy hóa, có tác dụng tốt cho hệ miễn dịch và làn da. Mâm xôi có thể ăn trực tiếp hoặc làm sinh tố, chè, tráng miệng", "Mâm xôi", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp khoai tây là món canh ngon và bổ dưỡng, với khoai tây nấu mềm trong nước dùng nhẹ nhàng. Món này thích hợp cho bữa tối, mang lại cảm giác ấm áp và dễ tiêu hóa", "Súp khoai tây", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a988cc73-072e-4af1-9b53-55fbf0f4fe79"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau xào là món ăn đơn giản với rau củ được xào nhanh với gia vị. Món này thường sử dụng các loại rau như cải thảo, cải ngọt, giúp cung cấp vitamin và khoáng chất cho cơ thể", "Rau xào", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chuối là trái cây ngọt, dễ ăn, cung cấp vitamin C và kali. Chuối rất tốt cho hệ tiêu hóa và tim mạch. Món này thường được ăn trực tiếp, làm sinh tố hoặc chế biến thành các món tráng miệng như chè", "Chuối", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đào là trái cây ngọt, mọng nước, chứa nhiều vitamin C và chất chống oxy hóa. Món này có thể ăn trực tiếp, làm sinh tố hoặc chế biến thành các món tráng miệng, giúp tăng cường sức đề kháng", "Đào", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún là món ăn phổ biến ở Việt Nam, được chế biến từ gạo. Bún có thể kết hợp với các loại thịt, cá, hoặc rau, tạo thành những món như bún riêu, bún chả, bún bò Huế, mang lại hương vị đặc trưng", "Bún", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ức vịt nướng là món ăn ngon miệng, thịt vịt mềm và mọng nước khi được ướp gia vị và nướng chín. Món này có thể ăn kèm với cơm hoặc rau sống, mang lại hương vị đậm đà", "Ức vịt nướng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá thu nướng là món ăn thơm ngon, giàu protein và omega-3. Cá thu thường được ướp gia vị rồi nướng, tạo nên món ăn đậm đà và bổ dưỡng cho bữa tối", "Cá thu nướng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("af036922-79f3-45a7-b562-a6279520c0e6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Miến gà là món ăn nhẹ với miến mềm, nước dùng thơm ngon từ gà, ăn kèm với thịt gà xé nhỏ. Món này rất dễ ăn, thích hợp cho bữa sáng hoặc bữa trưa nhẹ nhàng", "Miến gà", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đu đủ là trái cây ngọt, giàu vitamin C và enzym papain, giúp tiêu hóa tốt. Đu đủ có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng, rất tốt cho sức khỏe và làn da", "Đu đủ", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu hà lan luộc là món ăn giàu protein và chất xơ, có thể ăn trực tiếp hoặc chế biến thành salad. Món này có vị ngọt tự nhiên, rất bổ dưỡng và dễ chế biến", "Đậu Hà Lan luộc", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh rau dền là món ăn nhẹ nhàng, thanh mát, thường được nấu với thịt hoặc tôm. Rau dền chứa nhiều vitamin và khoáng chất, giúp cải thiện sức khỏe và hỗ trợ tiêu hóa", "Canh rau dền", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá kho là món ăn đậm đà với cá kho trong nước mắm, tiêu và các gia vị khác. Món này có thể ăn kèm với cơm trắng, mang lại hương vị mặn ngọt và rất bổ dưỡng", "Cá kho", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt heo kho là món ăn với thịt heo được kho mềm, thấm đẫm gia vị mặn ngọt. Món này thường ăn kèm với cơm trắng, tạo thành một bữa ăn đậm đà và bổ dưỡng", "Thịt heo kho", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm chiên là món ăn phổ biến, được làm từ cơm nguội chiên cùng với thịt, trứng và rau củ. Món này thường ăn kèm với dưa leo hoặc salad, rất dễ ăn và tiện lợi", "Cơm chiên", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt gà là nguồn protein nhẹ nhàng, giàu dinh dưỡng. Thịt gà có thể chế biến thành nhiều món như gà kho, gà luộc, hoặc gà xào. Đây là lựa chọn phổ biến trong các bữa ăn hàng ngày", "Thịt gà", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bèo là món ăn dân dã của miền Trung, gồm bánh làm từ bột gạo, thường được phủ lên trên các loại tôm, thịt hoặc mỡ hành. Món này có thể ăn kèm với nước mắm chua ngọt", "Bánh bèo", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bắp luộc là món ăn đơn giản nhưng bổ dưỡng, chứa nhiều chất xơ và vitamin. Bắp luộc có thể ăn trực tiếp hoặc làm món ăn kèm trong bữa ăn, đặc biệt là vào mùa hè", "Bắp luộc", true, "Snack,Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Trứng gà luộc là món ăn đơn giản, giàu protein, vitamin B12 và khoáng chất. Trứng gà thường được ăn sáng hoặc dùng làm món phụ trong bữa ăn chính, giúp cung cấp năng lượng và duy trì sức khỏe", "Trứng gà luộc", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Yến mạch là ngũ cốc giàu chất xơ và vitamin, giúp giảm cholesterol và hỗ trợ tiêu hóa. Món yến mạch có thể nấu cháo hoặc làm sinh tố, thích hợp cho bữa sáng bổ dưỡng", "Yến mạch", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c5e3e4ed-0164-4917-a1ce-99679b971a22"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo gà là món ăn nhẹ, với cháo mịn và thịt gà chín mềm, thường ăn kèm với hành lá, rau thơm và gia vị. Món này dễ tiêu hóa, phù hợp cho bữa sáng hoặc khi bạn cảm thấy mệt mỏi", "Cháo gà", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh rau củ là món ăn nhẹ nhàng, giàu vitamin và chất xơ, thích hợp cho các bữa ăn dinh dưỡng. Các loại rau như cà rốt, khoai tây, đậu que được nấu chung tạo thành món canh thơm ngon, dễ ăn", "Canh rau củ", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mì gạo lứt được làm từ gạo lứt nguyên hạt, giàu chất xơ và vitamin. Món mì này có thể chế biến thành các món xào, soup hoặc ăn kèm với thịt, rất tốt cho sức khỏe và giúp giảm cholesterol", "Mì gạo lứt", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chôm chôm là trái cây ngọt, có vỏ đỏ hoặc vàng, mọng nước và giàu vitamin C. Món này rất thích hợp trong mùa hè, giúp giải nhiệt và bổ sung dinh dưỡng", "Chôm chôm", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hồng xiêm là trái cây ngọt, có hương vị đặc trưng, giàu vitamin C và khoáng chất. Món này có thể ăn trực tiếp hoặc chế biến thành các món tráng miệng, sinh tố, rất tốt cho sức khỏe", "Hồng xiêm", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh hẹ tôm là món canh thanh mát, với tôm và hẹ nấu chung trong nước dùng thơm ngon. Món này giúp bổ sung protein và vitamin, rất dễ ăn và thích hợp cho các bữa ăn nhẹ", "Canh hẹ tôm", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm chiên trứng là món ăn đơn giản nhưng ngon miệng, được làm từ cơm nguội xào cùng trứng, có thể thêm các loại rau và thịt tùy thích. Món này phù hợp cho bữa trưa hoặc tối nhanh gọn và đầy đủ dinh dưỡng", "Cơm chiên trứng", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa chua Hy Lạp là loại sữa chua đặc, chứa nhiều probiotics giúp hỗ trợ tiêu hóa. Món này có thể ăn trực tiếp hoặc kết hợp với trái cây tươi, mang lại cảm giác ngon miệng và bổ dưỡng", "Sữa chua Hy Lạp", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt lợn nạc là phần thịt ít mỡ, dễ chế biến thành các món như xào, kho hoặc nướng. Món này cung cấp protein và chất sắt, thường được ăn trong các bữa chính", "Thịt lợn nạc", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá thu là loại hải sản giàu omega-3 và protein, rất tốt cho sức khỏe tim mạch. Cá thu có thể nướng, chiên hoặc kho, mang lại hương vị thơm ngon và bổ dưỡng cho bữa ăn", "Cá thu", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh canh là món ăn nổi bật với nước dùng đậm đà, có thể làm từ bún hoặc bánh canh, ăn kèm với các loại thịt như cua, tôm, hoặc giò heo. Món này rất phổ biến ở miền Trung và Nam Việt Nam", "Bánh canh", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bột lọc là món ăn đặc trưng của miền Trung, gồm vỏ bánh làm từ bột năng, nhân tôm hoặc thịt, sau đó hấp chín. Món này thường ăn kèm với nước mắm chua ngọt và rau sống", "Bánh bột lọc", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún hải sản là món ăn đậm đà với bún, nước dùng từ hải sản và các loại hải sản như tôm, cua, mực. Món này có hương vị đặc trưng và rất bổ dưỡng", "Bún hải sản", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dưa cải chua là món ăn lên men, được làm từ cải thảo hoặc cải bẹ, mang vị chua nhẹ. Món này thường ăn kèm với cơm, giúp hỗ trợ tiêu hóa và bổ sung lợi khuẩn cho hệ tiêu hóa", "Dưa cải chua", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Phở gà là món ăn nhẹ nhàng, nước dùng thơm từ gà, ăn kèm với bánh phở và thịt gà. Món này có thể ăn vào buổi sáng hoặc bữa tối, rất thanh đạm nhưng đầy đủ dinh dưỡng", "Phở gà", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hành tây là loại củ gia vị phổ biến, mang lại hương vị thơm ngon cho các món xào, canh hoặc salad. Hành tây có tác dụng tốt cho sức khỏe tim mạch và giúp cải thiện hệ tiêu hóa", "Hành tây", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chả lụa là món ăn được làm từ thịt heo xay nhuyễn, cuộn chặt và hấp chín. Món này thường dùng trong các bữa ăn chính, bánh mì hoặc cơm, mang lại hương vị ngọt mềm, thơm ngon", "Chả lụa", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá khô là món ăn truyền thống, có thể làm từ nhiều loại cá, chế biến bằng cách phơi khô. Cá khô có vị mặn, thơm, thường được ăn kèm với cơm trắng hoặc làm nguyên liệu cho các món canh", "Cá khô", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ức gà là phần thịt ít mỡ, giàu protein và dễ chế biến. Món ức gà có thể nướng, xào, hấp hoặc luộc, cung cấp năng lượng và dưỡng chất cho cơ thể, phù hợp với bữa trưa hoặc tối", "Ức gà", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nước cam là thức uống từ cam tươi, cung cấp vitamin C và chất chống oxy hóa. Nước cam là lựa chọn tuyệt vời để giải khát và bổ sung dưỡng chất cho cơ thể, đặc biệt trong mùa lạnh", "Nước cam", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cà phê sữa là thức uống phổ biến ở Việt Nam, được pha chế từ cà phê đen đặc kết hợp với sữa đặc ngọt. Món này có vị đắng nhẹ kết hợp với ngọt béo, thích hợp để uống vào buổi sáng để khởi đầu ngày mới", "Cà phê sữa", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh canh cua là món ăn đặc trưng với nước dùng đậm đà từ cua, ăn kèm với bánh canh mềm và các loại rau. Món này rất phổ biến ở miền Nam và mang lại hương vị thơm ngon, bổ dưỡng", "Bánh canh cua", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Xôi bắp là món ăn sáng đơn giản, được làm từ gạo nếp và bắp, có vị ngọt tự nhiên của ngô. Món này dễ ăn, cung cấp năng lượng cho cả ngày dài, thường được ăn kèm với thịt hoặc các món mặn khác", "Xôi bắp", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo vịt là món cháo nấu với thịt vịt, có vị ngọt tự nhiên từ thịt và xương vịt. Món này thường được ăn vào bữa sáng hoặc bữa tối, giúp cung cấp năng lượng và dưỡng chất", "Cháo vịt", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e370081a-c0a6-4c00-b01c-7c52f953b7f1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh mướp là món ăn thanh mát với mướp nấu trong nước dùng nhẹ nhàng từ xương hoặc thịt. Món canh này có tác dụng giải nhiệt, rất thích hợp vào mùa hè", "Canh mướp", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Lê là trái cây ngọt mát, giàu vitamin C và chất xơ, giúp cải thiện hệ tiêu hóa và làm đẹp da. Lê có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng", "Lê", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tôm là hải sản giàu protein, omega-3 và vitamin, rất tốt cho sức khỏe tim mạch. Tôm có thể chế biến thành nhiều món ăn như xào, hấp, hoặc nấu canh, tạo hương vị tươi ngon cho bữa ăn", "Tôm", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo sườn non là món ăn thơm ngon, với cháo được nấu từ xương sườn heo, có vị ngọt tự nhiên từ xương. Món này thường được ăn kèm với hành phi và gia vị, thích hợp cho bữa sáng", "Cháo sườn non", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp hải sản là món ăn đậm đà với nước dùng từ hải sản như tôm, cua, mực, nấu cùng với rau củ và gia vị. Món này rất bổ dưỡng và thích hợp cho các bữa ăn chính", "Súp hải sản", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dưa hấu là trái cây giải nhiệt, chứa nhiều nước và vitamin C. Đây là món ăn lý tưởng trong mùa hè, giúp cung cấp nước và dưỡng chất cho cơ thể, có thể ăn trực tiếp hoặc làm sinh tố", "Dưa hấu", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá hồi nướng là món ăn bổ dưỡng, giàu omega-3 và protein, thường được ướp gia vị trước khi nướng. Món này có hương vị ngọt tự nhiên, thích hợp ăn kèm với rau sống hoặc cơm", "Cá hồi nướng", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("eec3d874-6331-4e33-bbe6-bf0cc4335b29"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Salad rau là món ăn nhẹ, là sự kết hợp của các loại rau tươi như xà lách, cà chua, dưa leo, trộn với nước sốt chua ngọt hoặc dầu olive. Món này bổ dưỡng, giàu vitamin và chất xơ", "Salad rau", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bao trứng cút là món bánh bao với nhân thịt heo hoặc đậu xanh, kèm trứng cút. Bánh có vỏ mềm, nhân thơm ngon, thường được ăn sáng hoặc làm món ăn phụ trong các bữa ăn chính", "Bánh bao trứng cút", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh cuốn là món ăn làm từ bột gạo, nhân thường là thịt băm, nấm hoặc trứng. Bánh cuốn mềm mịn, ăn kèm với nước mắm và rau sống, thường được dùng trong bữa sáng hoặc bữa phụ", "Bánh cuốn", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mận là trái cây ngọt, mọng nước, chứa nhiều vitamin C và chất chống oxy hóa, giúp tăng cường sức đề kháng và làm đẹp da. Mận có thể ăn trực tiếp hoặc làm sinh tố, chè", "Mận", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Xôi mặn là món ăn từ gạo nếp, kết hợp với thịt, lạp xưởng hoặc trứng. Món này thường được ăn vào buổi sáng hoặc trong các dịp đặc biệt, rất bổ dưỡng và dễ ăn", "Xôi mặn", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa hộp Milo là thức uống bổ dưỡng chứa nhiều vitamin và khoáng chất, phù hợp cho trẻ em và người lớn. Milo có hương vị ngọt ngào, thường được uống vào bữa sáng hoặc giữa các bữa ăn", "Sữa hộp milo", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ổi là trái cây giàu vitamin C, giúp tăng cường hệ miễn dịch và làm đẹp da. Ổi có thể ăn trực tiếp hoặc làm sinh tố, nước ép, rất tốt cho sức khỏe, đặc biệt là trong việc hỗ trợ tiêu hóa", "Ổi", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo thịt bằm là món cháo có thịt heo xay nhuyễn, nấu cùng với gạo và gia vị. Món này bổ dưỡng, dễ ăn và dễ tiêu hóa, thích hợp cho bữa sáng hoặc bữa ăn nhẹ", "Cháo thịt bằm", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa chua nha đam là món tráng miệng được làm từ sữa chua và nha đam tươi, giúp làm đẹp da và hỗ trợ tiêu hóa. Món này mát, dễ ăn và rất tốt cho sức khỏe, đặc biệt là trong thời tiết nóng", "Sữa chua nha đam", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("faf19891-525a-4308-9222-992e83de7ce7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá hồi là loại hải sản giàu omega-3, tốt cho sức khỏe tim mạch. Cá hồi có thể chế biến thành nhiều món như nướng, hấp, hoặc làm sushi, mang lại hương vị tươi ngon và bổ dưỡng", "Cá hồi", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh ướt là món ăn nhẹ làm từ bột gạo, có kết cấu mềm mịn, thường được ăn kèm với thịt heo, chả lụa và rau sống. Món này có thể được rưới nước mắm chua ngọt, mang lại hương vị thơm ngon và thanh mát", "Bánh ướt", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mướp là loại rau quả mát, chứa nhiều nước và vitamin. Mướp có thể chế biến thành canh, xào hoặc làm món gỏi, giúp thanh nhiệt, giải độc và tốt cho hệ tiêu hóa", "Mướp", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chuối tiêu là trái cây ngọt nhẹ, giàu kali và vitamin C, giúp hỗ trợ tiêu hóa và cung cấp năng lượng. Chuối tiêu có thể ăn trực tiếp hoặc chế biến thành các món tráng miệng như chè chuối hấp", "Chuối tiêu", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bắp cải tím là loại rau giàu vitamin C và chất xơ, có thể chế biến thành salad, xào hoặc nấu canh. Món bắp cải tím giúp giải độc, hỗ trợ tiêu hóa và tốt cho sức khỏe tim mạch", "Bắp cải tím", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "WorkoutId", "CaloriesBurned", "CategoryId", "CreatedAt", "CreatedBy", "DifficultyLevel", "DurationMinutes", "IsPublic", "Status", "UpdatedAt", "UpdatedBy", "UserId", "Views", "WorkoutDescription", "WorkoutName", "WorkoutType" },
                values: new object[,]
                {
                    { new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf"), 68.64f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 3f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp khởi động toàn bộ cơ thể, làm nóng cơ bắp, giúp tăng cường lưu thông máu và chuẩn bị cho các bài tập tiếp theo", "Khởi động toàn thân", 0 },
                    { new Guid("032322a9-a232-4030-bed3-0ccf952d5cff"), 60.45f, new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 7.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập giúp làm dẻo dai các khớp chân, tăng cường độ linh hoạt và giảm thiểu nguy cơ chấn thương khi tập luyện", "Chân dẻo dai", 0 },
                    { new Guid("03741247-6b2d-49a9-a656-7fc8343747bd"), 83.61f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 11.01f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập toàn thân giúp kích thích các cơ lớn trong cơ thể, cải thiện sự dẻo dai và sức bền chung cho cơ thể", "Vận động toàn thân", 0 },
                    { new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13"), 123.26f, new Guid("4575699a-5bb6-42ec-9d52-ea19d1170187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 11f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập thể thao này giúp cải thiện sự phối hợp và tốc độ phản xạ của cơ thể, giúp bạn năng động và linh hoạt hơn", "Vũ điệu thể thao", 1 },
                    { new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1"), 152.96f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 12.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp làm mềm các khớp và cơ, tăng cường sự linh hoạt để sẵn sàng cho các hoạt động thể chất nặng hơn", "Khởi động linh hoạt", 1 },
                    { new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a"), 114.6f, new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 9.67f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập vũ điệu thể thao giúp cải thiện khả năng phối hợp và nhịp điệu của cơ thể, đồng thời tăng cường sức bền", "Vũ điệu thể thao", 1 },
                    { new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4"), 114.71f, new Guid("4575699a-5bb6-42ec-9d52-ea19d1170187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 10.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp săn chắc cơ thể, tăng cường sức mạnh và giảm mỡ hiệu quả", "Săn chắc và khỏe mạnh", 1 },
                    { new Guid("2308c57b-829b-4c6e-b362-5b4634af2877"), 172.6f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 15f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập giúp kích thích năng lượng cho cơ thể, giúp bạn cảm thấy tràn đầy sức sống và chuẩn bị tốt cho các hoạt động tiếp theo", "Năng lượng dồi dào", 1 },
                    { new Guid("28de23bb-07b9-4ebc-8f72-ead4d54a4883"), 68.64f, new Guid("4575699a-5bb6-42ec-9d52-ea19d1170187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 9f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp phát triển cơ bụng, làm bụng trở nên mạnh mẽ và săn chắc hơn", "Bụng săn chắc", 0 },
                    { new Guid("298502cf-ebdf-4044-9350-a14606ebe099"), 77.76f, new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 11.1f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp cơ bắp chân săn chắc và phát triển sức mạnh, đặc biệt là khi bạn cần cải thiện khả năng di chuyển", "Chân săn chắc", 0 },
                    { new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54"), 62.4f, new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 7.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp tăng cường sự linh hoạt và sức mạnh của cánh tay, hỗ trợ tốt cho các bài tập thể thao khác", "Tay linh hoạt", 0 },
                    { new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64"), 147f, new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 11f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này kết hợp giữa sức mạnh và khả năng duy trì sự cân bằng, giúp cải thiện sự ổn định cơ thể và khả năng phối hợp các nhóm cơ", "Sức mạnh và cân bằng", 1 },
                    { new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38"), 153.4f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 11.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp cơ thể dẻo dai và tăng cường năng lượng, thích hợp để nâng cao khả năng hoạt động lâu dài và bền bỉ", "Dẻo dai và năng lượng", 1 },
                    { new Guid("425fc485-239f-479e-a4da-b1fe6aed6822"), 136.6f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 11f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp cơ thể vừa khỏe mạnh vừa dẻo dai, thích hợp cho việc nâng cao độ linh hoạt và sức bền của các nhóm cơ", "Khỏe và dẻo dai", 1 },
                    { new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757"), 114.6f, new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 9.67f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp cải thiện sức khỏe toàn thân, tăng cường các nhóm cơ lớn và nhỏ", "Toàn thân khỏe mạnh", 1 },
                    { new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7"), 136.6f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 11f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp xây dựng sức mạnh cơ thể toàn diện, với các bài tập kết hợp giữa các nhóm cơ lớn và nhỏ", "Sức mạnh toàn diện", 1 },
                    { new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a"), 130.8f, new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 10.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp phát triển sức khỏe toàn diện, bao gồm sức mạnh, sức bền, sự linh hoạt và sự cân bằng của cơ thể", "Khỏe mạnh toàn diện", 1 },
                    { new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00"), 68.64f, new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 9f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp phát triển cơ bắp tay và bả vai, làm tay trở nên mạnh mẽ và săn chắc hơn", "Tay rắn chắc", 0 },
                    { new Guid("580069d7-9025-4864-adf2-3037608e9a22"), 43.6f, new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 6.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp tăng cường sự linh hoạt của khớp tay và vai, hỗ trợ cải thiện khả năng vận động của phần trên cơ thể", "Tay uyển chuyển", 0 },
                    { new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559"), 58.95f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 7.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập thử thách thể lực này giúp kiểm tra sức mạnh và sự bền bỉ của cơ thể thông qua các bài tập đòi hỏi sức lực cao", "Thử thách thể lực", 0 },
                    { new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc"), 178.6f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 14.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp nâng cao sức bền, cải thiện khả năng chịu đựng khi thực hiện các hoạt động thể thao kéo dài", "Luyện tập sức bền", 1 },
                    { new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3"), 76.95f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 10.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp làm nóng và kích thích tất cả các nhóm cơ trong cơ thể, chuẩn bị cho những bài tập nặng hơn", "Tập luyện toàn thân", 0 },
                    { new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b"), 114.71f, new Guid("4575699a-5bb6-42ec-9d52-ea19d1170187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 10.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp cải thiện sự nhịp nhàng trong chuyển động của cơ thể, nâng cao sức khỏe và sự linh hoạt", "Chuyển động nhịp nhàng", 1 },
                    { new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0"), 38.64f, new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 5.79f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập tăng cường sức mạnh cho tay và vai, giúp phát triển cơ bắp và cải thiện khả năng chống chịu với các bài tập nặng", "Tay cường độ cao", 0 },
                    { new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2"), 153.4f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 11.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập toàn thân giúp cải thiện sức khỏe chung, tăng cường khả năng vận động và phát triển cơ bắp đồng đều", "Tập luyện toàn thân", 1 },
                    { new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb"), 147f, new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 11f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập khởi động cơ bản giúp làm ấm cơ thể, giảm thiểu nguy cơ chấn thương và chuẩn bị cho các bài tập tiếp theo", "Khởi động cơ bản", 1 },
                    { new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0"), 108.9f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 6.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp tăng cường sự linh hoạt và sức mạnh của cơ thể, phù hợp với những người muốn nâng cao thể lực tổng thể", "Linh hoạt và mạnh mẽ", 1 },
                    { new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc"), 72.6f, new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 7.17f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này là sự kết hợp giữa vũ điệu và thể thao, giúp cải thiện khả năng vận động nhịp nhàng và tăng cường sức bền cho cơ thể", "Vũ điệu kết hợp", 1 },
                    { new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783"), 136.6f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 11f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp tăng cường sức mạnh cơ bắp đồng thời cải thiện tốc độ và độ phản xạ của cơ thể", "Luyện tập nhanh và mạnh", 1 },
                    { new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2"), 73.95f, new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 10.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp tăng cường sức mạnh cho các cơ chân, đặc biệt là các cơ bắp đùi và bắp chân", "Chân khỏe mạnh", 0 },
                    { new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788"), 178.6f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 14.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này kết hợp giữa sức mạnh và sự linh hoạt, giúp cải thiện khả năng vận động của cơ thể và nâng cao thể lực tổng thể", "Khỏe và linh hoạt", 1 },
                    { new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f"), 136.76f, new Guid("4575699a-5bb6-42ec-9d52-ea19d1170187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 12f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này kết hợp các động tác linh hoạt và sức mạnh, giúp cải thiện khả năng vận động và sự khỏe mạnh của cơ thể", "Linh hoạt và khỏe mạnh", 1 },
                    { new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563"), 114.6f, new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 10.17f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập với các động tác nhịp điệu giúp cải thiện sức bền và sự phối hợp giữa các nhóm cơ, đồng thời tăng cường năng lượng cho cơ thể", "Nhịp điệu sôi động", 1 },
                    { new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0"), 130.8f, new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 10.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập toàn thân giúp phát triển sức mạnh cơ bắp cho tất cả các nhóm cơ, đặc biệt là cơ lớn như ngực, lưng, và chân", "Toàn thân mạnh mẽ", 1 },
                    { new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7"), 114.71f, new Guid("4575699a-5bb6-42ec-9d52-ea19d1170187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 10.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập khởi động giúp cơ thể làm quen với các động tác nhẹ nhàng, tăng cường sự linh hoạt và giảm thiểu rủi ro chấn thương", "Khởi động cơ thể", 1 },
                    { new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5"), 147f, new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 10.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp săn chắc cơ bắp toàn thân, với trọng tâm là phát triển cơ bắp, đồng thời giảm mỡ và cải thiện hình thể", "Toàn thân săn chắc", 1 },
                    { new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3"), 153.4f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 11.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập giúp nâng cao sức mạnh và bền bỉ cho cơ thể, thích hợp cho những người muốn thử thách sức chịu đựng của mình", "Sức mạnh và bền bỉ", 1 },
                    { new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1"), 147f, new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 11f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp tăng cường sự bền bỉ cho cơ thể và cải thiện khả năng chịu đựng, rất hữu ích cho các hoạt động dài hạn", "Dẻo dai và bền bỉ", 1 },
                    { new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f"), 67.95f, new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 1, 9f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập giúp cải thiện sức bền cho đôi chân, thích hợp cho những người tập thể thao đòi hỏi di chuyển lâu dài và mạnh mẽ", "Chân bền bỉ", 0 },
                    { new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee"), 178.6f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 14.5f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp xây dựng cơ bắp và cải thiện sức mạnh tổng thể, phù hợp cho những ai muốn nâng cao khả năng thể chất", "Vươn tầm sức mạnh", 1 },
                    { new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08"), 109.6f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 9f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này có cường độ cao, giúp tăng cường sức mạnh cơ bắp và nâng cao khả năng chịu đựng cho cơ thể", "Thử thách cường độ cao", 1 },
                    { new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea"), 114.6f, new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 9.67f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập giúp phát triển sự linh hoạt và khả năng vận động của cơ thể, làm cho cơ thể mềm dẻo và dẻo dai hơn", "Chuyển động linh hoạt", 1 },
                    { new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270"), 164.5f, new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 17f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập giúp đốt cháy năng lượng và giảm mỡ hiệu quả, cải thiện sức khỏe tổng thể", "Đốt cháy năng lượng", 1 },
                    { new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69"), 199.67f, new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, 13.01f, true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập giúp phát triển sự linh hoạt và bền bỉ cho cơ thể, cải thiện khả năng hoạt động trong thời gian dài", "Luyện tập linh hoạt và bền bỉ", 1 }
                });

            migrationBuilder.InsertData(
                table: "CategoryFoods",
                columns: new[] { "CategoryFoodId", "CategoryId", "CreatedAt", "FoodId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0393fd73-372c-44de-b37b-a5965efc30d9"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d19d971-88d0-4108-a335-24ac9e1dec50"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("03bf8c58-d89e-4f8b-b153-2b52d1808117"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("faf19891-525a-4308-9222-992e83de7ce7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("049291c3-716e-4c9b-9418-a1db4b745bca"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("08ac3812-268e-4d53-b402-b9834d5d086d"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("08e98238-c5a4-4def-94f6-3407b56e23a0"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("86d88717-df08-4de6-b86d-870210864b46"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0e736505-6524-4fa0-9dc2-b19189ee5655"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0fdfb6c1-c87c-4f46-9918-2b13cf62548c"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0fef0ad7-2eb9-4eb0-9f55-87f192b5c7e2"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("101314e7-c5e4-4073-aa53-4e367cf4da3c"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("105e8755-e623-4db6-a04d-614a30117524"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("110f63d7-b4ab-419c-9190-cd989c04f300"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("11dec626-73fd-45b3-bd8b-6ca430dd90e3"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("146a2b82-977a-485b-abc9-0e892f12cf04"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("14dc829a-c042-4ca8-9740-8c4d2ec5adee"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("153c5a5d-882c-4a5b-9cda-9f0bd3f6d758"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17aa9c6b-9903-48ee-aa5f-36b9579a4558"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0292d477-d63b-4904-a83b-2cd8cac39c14"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("197cbf0f-0d72-4b03-9d74-9ad5f7dd820f"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1a9f52d5-93af-4bb1-91f0-1a83a6e8423f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1c905914-4fd1-418c-98f4-d2d0e8ac59f7"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1d7ebd92-a3f8-4ee1-b0f2-b943980e6007"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e8dfa61-e35b-4c3f-99ac-3a970e1bcad0"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("21f4fa7a-b4f9-4b6e-822b-8e6278acaf78"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22efc0ea-7718-41ff-ac60-395a655e1e08"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("24824325-0921-484a-a9ad-f04a5ee4e870"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("24879352-df0b-47c0-baed-d3644da58eaf"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6487a532-ff5e-4b77-b408-46c789608de9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("24bd5f72-1f86-4ba1-8af4-2d730417585b"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("25929749-3d92-4b2f-98de-e818a6c1993a"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("25a39d05-7c83-4810-93e4-6d87e2311c45"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("262394bf-fec5-433d-b267-4038d34b26ec"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("269ffd94-f723-4686-869f-0fc71b1b838d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("27be6edb-2c7b-41d3-ba05-4383eeea46bd"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("29124a9f-65ff-4386-a3f5-5423d326b46c"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2966b633-99b8-4b5e-a56d-60ccce8aa687"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2f7bb7a3-ff62-4588-aabe-9a7977aa730f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2ffbb369-33e0-4966-91ef-649fbfb13c09"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("32872689-f342-42d1-86b0-6aa55b760af5"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("349150d6-5fbe-41a8-9bf6-3dfa0a1c67f0"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("36bc6f8f-9d4a-4ab9-88b9-565ae10d4e61"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("38d957cd-dad3-4064-9cb6-76360c61d4eb"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a5c51a9-5ae4-4aa2-be9b-f00d5168d2a0"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3b00db0d-c4db-413c-8bf1-28bcd9a8b7d2"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c2df000-15d5-4585-96df-0d8c3615a8cf"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c504030-d351-4eb4-ac66-a0bd9562dbd5"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c5d627c-aded-464d-906c-235ce88fd67d"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("40ffef3d-3ab7-4e3f-b513-ca88b69af76f"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("42757920-ecb2-4594-a847-7332ee33ead2"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2146faae-2e7c-4460-8d81-38f5d313012c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4312472d-cf63-4885-b862-9810d981206d"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4568624a-5323-4ec5-a6a3-cb72cbdb9c5c"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("469131c5-d438-4e7d-a4b6-e1b36f93afc2"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("46f673f8-320d-45d0-a9d7-15cdafd37d7f"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("48ef75ca-add6-4364-a206-c8790da1388b"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b8500af-d730-4138-9617-cba352faed4a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49a6a12c-877e-454a-96f0-edd51b9eefbe"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b92b8c6-0ef1-43b7-a8ee-90b278e1937b"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4bc82ae2-1188-4191-b5e2-d10a3d708e9f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c5e11b6-dce0-4533-be4f-901c3431816c"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4d8ab8b1-ae43-4f03-8b80-1415d956c33d"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4e2f0622-1424-477a-9009-e3fa694e9f6c"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("500af14f-4149-41d0-adee-04a3d18e07d5"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5170ec06-81cf-48d8-be21-b1c74d10ba6f"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52b4c651-5880-42cd-8e58-335fc7760505"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5af00759-9bc3-4445-a0f5-938dc676b597"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b21e452-51e6-4fe7-ba15-6713e3d7ea52"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5cb23e5e-d64e-43a6-b308-e23304d9e719"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("601b1f5c-b948-4fd2-aaa8-79bab33aab9f"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("60faee78-da6d-4b80-91a9-92d9b7bc69b1"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("61175bd3-837e-4dd3-8468-8936b37cb08e"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("61d20a35-1585-4b8b-8e6d-ee561af76687"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("62558fb2-3aa5-4c22-8f07-80e53f65c278"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("641c3356-da92-4fdf-9db0-d0b4a7c5f217"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ed85dc2-7654-4c48-81f9-19946a73f71d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("64ccf502-8f50-4851-96aa-84183bbd19b5"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6511502f-5012-4105-9e74-70fe980b6598"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("68313c52-0460-408a-bb46-26d30d02672d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("688393ff-56ae-4ec6-bc2a-5858e964a962"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("68ea6334-ffde-49a6-ab4a-160ec2530ba2"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6abc1a80-a2c1-4af3-b5a0-beec932a39e6"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6bc07586-dccb-44f1-95e5-e1360d4d5918"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6db7a20e-b20e-44d7-a721-0f684d6f91a0"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f28b1b2-d7f8-4242-8d50-0dd4422a74f1"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f3384f1-d3e7-4df4-b4bc-577dd5f3f0dc"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f4df11d-43a8-4e3d-a8e1-c863a6f7e0c8"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("700dbaa0-5355-4437-8e34-318118041787"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("70cc78bd-4130-437b-8545-b0746e6b977c"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("728c01e7-10df-456c-8950-f709f7d52d2d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7290b3d8-5f86-4021-ada6-6a2016677503"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7383da35-000e-4dbb-a407-8186995ceb83"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("748bcac6-b219-4b0b-802d-38ca6bba69db"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("74bc4295-75d8-445e-a5dd-fb1de5ceebc5"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("761e2881-a672-418a-9a16-ceecbb340e21"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7641872a-f078-4a90-9e5c-33707be81676"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7799971a-0a02-43e6-b2c0-45669366c517"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00bc33fe-4cd5-47df-bd94-15ac9f93648c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("788ba72d-6a40-4881-9887-e995e6da361b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7af267fa-f49a-47b4-866c-c24a44f2af64"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7bdfb7ba-704b-403d-9811-7cccd4f5fcea"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("827829bf-71cd-4865-80af-1457e0091456"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7c71572f-fd47-4fb6-8cdf-9cd60710b7b4"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ca6f3ff-6bda-4845-baad-37814ffdc266"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("af036922-79f3-45a7-b562-a6279520c0e6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7d53cde6-8093-4a6b-9b5b-07a56ed26e98"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7df5fd49-1b52-4bc6-bfc6-380d21068f91"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7fbd3ae6-2a56-4bc6-89a0-01224fe1668a"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("80228382-cc26-48bc-bd20-0f2ab7737ac9"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("805643ae-490a-4ba0-bc10-6d5e22dafb33"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81235c5e-ff7f-4b16-99ff-47b5e644ac21"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81373fe6-b2ba-42ed-9ff9-3c0db9d03b7d"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("29dfb5da-8818-40ff-bf66-7553521c2161"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("83e6827f-74cb-4115-bae8-d7cfb8ac5c73"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8420e7ab-59ae-4252-8bda-3aba0385ffe1"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("846a9efe-c87a-4d9b-a44e-08a104ee095a"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("84b9368e-f336-4756-b17d-7f8c97df12d9"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("85ff95c8-0d58-4cb2-a092-4bd5d37c009a"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("878b5ead-aed6-490a-aa02-7383de16ae89"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("87d420e3-c92a-4622-a1da-5a0b6cd21694"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a137cfe-09c2-4227-a7bc-90da55caba76"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c7e165f-c7cf-4eb9-aea3-dfd847a51fd8"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d0b07cf-ee83-4883-b7e4-bd85f44ea11e"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d438554-8e78-43b3-b0da-ae83f58a9781"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e9c89fb-eb98-43b7-b3ed-d53716c5d708"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8f1c0742-413d-45b5-bdb0-f4b470d5085a"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("90275c25-34aa-49ff-84a9-eeb666b5304b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9341a36d-5f9d-454c-a3ce-16a6b603cd2a"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("96b9198e-e25e-440f-8ddf-0229afcfd4ae"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99724a0f-2db6-45b9-ad43-357d5c9b9483"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99b8f662-bf51-45d4-89c7-c077dcb881a6"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9bc162fd-51d8-4815-9951-4b54d60b3eeb"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9d1a562f-f445-4378-8944-d62a04801f7d"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a051c369-ef95-4038-817f-d3c62bcd256f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c5e3e4ed-0164-4917-a1ce-99679b971a22"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0cf48d8-2904-44a4-99e3-e1631ebb30a3"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2ae82bfd-34db-4928-bfee-b60f4aec4460"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a16659eb-a7c1-488e-81e0-3005ea6ad71c"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2eebe4b-2d20-46d7-ba8f-efef6a8f6d46"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a5a91818-1b68-4519-901f-4e16b1c97606"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7167f942-dc89-4f29-8022-588373aef45e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a661bc30-6888-427e-9bca-61a80574f50b"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a9a4e5cb-37ba-45b9-bf95-489ee7239039"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a9cdbc2c-1f79-4f62-b6f6-c1db94ec8ad5"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aaa53f8d-d95d-40f2-9c31-db050ca63bde"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("51061170-597d-4289-a021-1e7dde88331f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad985de6-b63c-4fee-aa77-48cfaf823134"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae07cc21-d63b-41a6-9505-943f54970d90"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae47b214-4de4-4b44-b82a-783f4e5c40a8"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b2273365-f180-4751-b152-0e7db46a3e8e"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b5721e61-3178-422d-8d00-2b974d3391a8"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b5a0a8b5-3b86-4b1d-b1c5-ed392d4c79fd"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b74c48a1-4cab-41ce-a6dc-99f0e16d50de"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b784a6ad-e0ce-4814-82ed-0db24f0052e8"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b9c4d234-650d-4e96-bc45-43dce1686010"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc037a6a-d3a5-4113-a955-cbe5848fa4e1"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc361b8b-2a85-49c7-ae4f-3be899572343"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c0280a87-a9c9-4d7f-8b94-a065df07fd44"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c1891e6d-fcd8-42b3-89cb-f52cc2c32a8e"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7cd76708-7312-445e-a392-14f0e806a786"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c1943303-ee24-4afc-b247-442469fc87e2"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c33ad0ba-829c-4389-b30e-7a43fe2d9b19"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8382816f-1beb-4804-9698-3b486798b20a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3719a6a-435d-4fba-9544-6537d1120483"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c37d5d47-0985-4be4-a4f9-10691a50c9da"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c6cc0420-eb24-4ccb-9ae0-23fa1ed63358"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c7300055-7af7-482c-acd0-310e06623d92"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c8eaa771-359c-46fc-89f8-529c6d05b1a7"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c90f3fd1-cf73-489a-beda-c4303c500d09"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2405ffc3-524e-4331-9e68-47a411d7b9b8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c9a195f0-2707-4fe2-afc6-02371392841c"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cbaa08d2-d2b7-461d-991d-aecdc3e442b9"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cc3de6e8-8c66-445d-b659-366da9b4c970"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3dc2fa80-ab87-4e26-907b-3516611371b8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cce1dabc-c595-4987-9aef-3cf0207fbf00"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce18ba6a-7d04-4cca-b970-217cf1130dd0"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cee5c35d-8200-4ddf-8345-4669a256c1c5"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf98f260-61e1-4fe5-a46b-dd98e024ec4f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d05f16eb-44df-42bb-a237-ebfb5823124d"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d173c2e8-dd11-4126-80a1-5a8f2f5c0983"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d2b55c53-b272-4172-8f90-6b7a7c343cb6"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d2e3fc32-b210-4407-b84b-eb62c5e1bc14"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d45e9edb-1756-454e-941c-7fe7b403fe74"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d7a23e82-97f4-4089-861b-6472dd13c828"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9678d41-8607-4ae6-840b-b227cff4c849"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d96e4db7-9b1e-4dc2-b915-c4502df1703c"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da806b3e-70c6-4cf7-86af-bf5278793d8e"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("db45c552-1a25-4c2b-8640-2a7bc24cb0c9"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dba1a8c5-b61a-4144-b962-ac6cda83d107"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc471057-3ed7-4055-9f13-52156ca85e60"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dcaaefc4-5c47-4b7d-88ab-2e13074476e4"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ddf09e16-fd30-406b-8a52-e7dc635d90e4"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1cf3482-5270-4fd1-b7c4-05b2cca77807"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e5947a34-880a-478a-aad9-acbe25554702"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e5da1aca-4cfa-4d75-9208-507386ade963"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e6ef8b54-a8c3-4e73-8532-42aa3926ed3b"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e7b5cb35-3d09-4f89-afbf-9dcd7347ccb3"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a504d882-4f38-413e-bb28-fae1f2787150"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e7f9ac66-3713-4c89-a55c-5568a0b5627c"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e8d575bb-4570-41ff-885a-7d5d07937ee7"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e8f4ce98-502f-4b7a-9a4c-a820707a1098"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec54f915-ccb4-4b9e-bb13-628fa515cc7e"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ecdae1b6-e8d4-471f-b032-91698bf24fc9"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a364353c-d589-4a94-9c3b-3038113ea249"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ed8a7fc5-c8ce-4660-8f6f-dba57f8c5496"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef17aa3b-0415-427a-aa8a-fd6771e045e1"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef91ba24-70a5-4b79-8ba8-2c4bc76fa27c"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f06b2998-cf96-4ce1-9394-34a0c81c3a18"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2cee02f-4eab-4fcc-80d9-fd0254f35912"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f6669402-5c51-4891-95d1-4e24027d8756"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f779805f-6094-48d5-a872-09623d2c8f00"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f7a01fd9-1616-4250-8c72-b9daad84ee71"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f7b6b367-49a8-4303-bb34-7e731d83fe55"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f887184f-046d-4a1a-bfd3-6d0521bef6f0"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa8d43bf-b687-4e45-9cf7-bca24172bdf3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fadcbcc5-d8a8-4cc5-9eb1-8245c4959bec"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("85e621ed-0e0c-4d20-8891-51d311cea4a3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fadddf55-a66c-43b2-827a-c86b80e0ba5b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fb0ea3a8-dfc9-4285-8d36-60055790a95e"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc6a40f3-6454-476f-84d5-7d1e6874df86"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fe5c1a22-e994-4d05-8624-b19d582f5fc5"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4edcae53-7e30-42bb-8526-7686355f2268"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "CertificateId", "CertificateName", "CertificateNumber", "ConsultantId", "CreatedAt", "ExpertiseId", "ExpiryDate", "ImageUrls", "IsVerified", "IssueDate", "IssuedBy", "UpdatedAt" },
                values: new object[] { new Guid("76248e20-dd27-4cac-ae7f-bcc883e3c895"), "Chứng chỉ tư vấn dinh dưỡng", "CERT-2025-002", new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ad55299-b566-47e8-a9a0-1997e893e153"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://example.com/certificate1.jpg\"]", false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monhealth Academy", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "ConsultantBanks",
                columns: new[] { "ConsultantBankId", "AccountName", "AccountNumber", "BankId", "ConsultantId", "CreatedAt", "IsDefault", "Status", "UpdatedAt" },
                values: new object[] { new Guid("3f80f24f-c124-405e-af45-121cf404e43d"), "Văn Hữu Toàn", "1890445466", new Guid("936666c3-12f6-406b-9de9-8367233aa6ba"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "DishTypeFoods",
                columns: new[] { "DishTypeFoodId", "CreatedAt", "DishTypeId", "FoodId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01538947-e57e-4e2e-bd48-4c640f2c997d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2349), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2350) },
                    { new Guid("01b667ce-f3bd-4dc5-8360-cd341fd0128f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2484), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2485) },
                    { new Guid("0255a0c5-01e1-4d42-85ec-2b2f069f998d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2721), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("6487a532-ff5e-4b77-b408-46c789608de9"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2721) },
                    { new Guid("044ece72-85e9-4c2f-8d86-e7267c7ab0c2"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2629), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2630) },
                    { new Guid("060c73e0-01a8-4a23-b142-613258103344"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2292), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2292) },
                    { new Guid("069767b7-a336-4d9d-9374-29209aebc5b2"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2836), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2837) },
                    { new Guid("072b82c0-ffbe-42a4-b58a-96f54b0700ab"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2493), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2493) },
                    { new Guid("09118683-e06e-4bd7-9aed-5d6003ba7927"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2209), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2210) },
                    { new Guid("0a97d26a-422c-4a0c-a688-901078538888"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2219), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2219) },
                    { new Guid("0ab0578d-36cf-46ec-9a9a-b92e7aed51d0"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2422), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2422) },
                    { new Guid("0cdc2eb3-5bdc-44c3-bb1e-4dced20bba38"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2361), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2361) },
                    { new Guid("0d305b1c-21a6-42b3-b17f-272f397ca9b2"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2325), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2326) },
                    { new Guid("0dec3001-95a2-41ba-8dd1-eb46ff4e873d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2735), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2736) },
                    { new Guid("0e918aa5-1f49-4397-b82c-7f66bfc26ee2"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2692), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2693) },
                    { new Guid("0ef1c502-b53b-43ac-b58e-3d3e973b6f72"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2760), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2761) },
                    { new Guid("10d92a6d-bc28-49e9-8da0-d2d3dd141b1a"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2354), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2355) },
                    { new Guid("1172e8fe-9031-4fae-a628-7b56901d6b2e"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2554), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2555) },
                    { new Guid("13e08037-015d-44f4-9311-e397b3871118"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2330), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2331) },
                    { new Guid("155a98fc-e3af-496e-bc9c-3de02173ccb0"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2844), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("2405ffc3-524e-4331-9e68-47a411d7b9b8"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2844) },
                    { new Guid("1591902b-84d6-4b51-9931-f05d708e27ad"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2776), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("eec3d874-6331-4e33-bbe6-bf0cc4335b29"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2777) },
                    { new Guid("16e06867-0de2-4b10-9fca-f49c60234632"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2549), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2549) },
                    { new Guid("19c9fe16-6b69-4d4b-b119-a83b047ec636"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2327), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2328) },
                    { new Guid("1a7d92ff-d3ad-46e0-afdb-d75427e3855d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2811), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2811) },
                    { new Guid("1cfaa34f-f37a-4ee0-bed3-4cd83d412fdf"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2819), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("43d635e2-6f0c-4385-83d8-fedfd479d356"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2819) },
                    { new Guid("1eeec506-25c2-4000-b0c8-aa87a8955294"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2302), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2303) },
                    { new Guid("21ebbbe5-d2b8-4dd5-b929-f636c45dfd8e"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2556), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2557) },
                    { new Guid("24b4e962-0598-4ac9-aa93-09f7ed61d2d0"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2573), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2574) },
                    { new Guid("270bd78b-a725-4e5b-bda0-54972519966d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2672), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("7cd76708-7312-445e-a392-14f0e806a786"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2673) },
                    { new Guid("274d96dc-9323-416d-b13e-a402678d3695"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2868), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2869) },
                    { new Guid("2d6ea1a3-f840-4572-bc75-7e161d13103e"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2363), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2364) },
                    { new Guid("2e71338f-c240-4be5-a801-3247f6197f6f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2352), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2352) },
                    { new Guid("2f6b8fa4-b583-4b1a-a3bb-481ea3de2b28"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2787), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2788) },
                    { new Guid("2fc85ad4-da22-4ac4-a8e3-1b031ab145f9"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2617), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2618) },
                    { new Guid("2ffc7611-ddc1-4363-a283-0de81d5fd0e5"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2841), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("8382816f-1beb-4804-9698-3b486798b20a"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2842) },
                    { new Guid("30ba7e32-9d57-495d-92f3-3a05f2c90b17"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2649), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2649) },
                    { new Guid("33d56b8f-7eda-40c1-ab25-1d7e83ca4aca"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2821), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("8ed85dc2-7654-4c48-81f9-19946a73f71d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2822) },
                    { new Guid("346afd74-69d1-4ce6-a8bd-3b707124042d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2341), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2342) },
                    { new Guid("35cea1b9-a96e-4272-bedd-79a70d6b1ccb"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2726), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("827829bf-71cd-4865-80af-1457e0091456"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2726) },
                    { new Guid("3afa077a-5ba1-43fa-a4ef-f04d2897e739"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2429), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2429) },
                    { new Guid("3bc7ad80-d5e2-446e-86a3-af6719defd12"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2632), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2633) },
                    { new Guid("3d6d1971-ac0b-4c56-9939-57d9c62314bb"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2833), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("e370081a-c0a6-4c00-b01c-7c52f953b7f1"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2833) },
                    { new Guid("3f21c0d0-865e-4788-b5af-101e7452158c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2404), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2404) },
                    { new Guid("408cb0e7-4c87-4052-9405-830c49d8b4da"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2371), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2372) },
                    { new Guid("4115cf35-11e8-47a1-bd07-2717440e7d23"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2626), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2627) },
                    { new Guid("4191d6b7-a470-4672-8eb2-c32b7e548777"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2613), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2613) },
                    { new Guid("42a1d571-5187-4755-aa23-01fb80d07c69"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2637), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2638) },
                    { new Guid("43708dfc-a453-49df-8a59-c429b06177d0"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2870), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2871) },
                    { new Guid("44dfa264-2c4f-4a07-8251-9951d36ba7ae"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2663), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2664) },
                    { new Guid("464b2bb2-fe6f-4658-88e7-885636bcce3c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2559), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2560) },
                    { new Guid("4786736a-ebfe-4ead-9a8c-1ffcd275994f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2525), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2526) },
                    { new Guid("480dc12c-bb3d-4564-a9e9-4a726564d395"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2417), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2417) },
                    { new Guid("49cd4005-8fbe-4d74-9617-6aca95a819d5"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2390), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2390) },
                    { new Guid("4ae0b6ec-ea90-4a53-a52d-c83b0f994ef5"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2642), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2643) },
                    { new Guid("4e193602-7abd-443e-81e2-1d278d44a737"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2800), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2800) },
                    { new Guid("4f100eb0-d760-4fda-8540-0a6faeade7c9"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2419), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2420) },
                    { new Guid("4f5f0fb4-9189-460e-b6f2-9d39b3ab8722"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2874), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("85e621ed-0e0c-4d20-8891-51d311cea4a3"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2875) },
                    { new Guid("4f95d9bb-19b5-46f3-a97d-7f87c8421f08"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2400), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2400) },
                    { new Guid("4fbaca8c-8ca0-4c2c-a41c-7daa23631a87"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2699), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2699) },
                    { new Guid("4fd4b3fb-38dd-4163-8a5f-48402242f502"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2564), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2565) },
                    { new Guid("5017699b-dc05-4ed5-bce0-7673a7359850"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2274), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2275) },
                    { new Guid("5054e483-a8e9-4a06-9d22-360e74629985"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2766), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2767) },
                    { new Guid("5115d2fc-40da-4193-bcc6-4cf1441b6782"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2246), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2246) },
                    { new Guid("515bec26-b71f-43a3-83f9-1af822e9b2b1"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2615), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2616) },
                    { new Guid("51b9a835-c080-4f4e-95ee-bec3e8f134d3"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2599), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2599) },
                    { new Guid("51d5ad6f-67c6-4e93-8cdf-0d9b862c9374"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2506), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2507) },
                    { new Guid("5369d5ee-9239-45d4-a8ea-d23742f53d00"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2640), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2640) },
                    { new Guid("53f628d2-77e0-43a8-b64d-788e52b1f5c6"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2711), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2712) },
                    { new Guid("540eea5d-2792-4e18-ad78-b0888ae813d1"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2567), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2567) },
                    { new Guid("544909cc-be03-444c-8b75-eb1106ea3ad2"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2771), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("2ee163f7-4463-44ec-b9e2-8a409c112db4"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2772) },
                    { new Guid("55ec3638-5088-44c6-848f-20fde0f20b56"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2670), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2670) },
                    { new Guid("56ddf6c9-74b3-432c-8180-6b68f5d92c5c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2620), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2621) },
                    { new Guid("571f491c-129d-4dc4-8d39-b9f1c80118af"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2605), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2606) },
                    { new Guid("57e760eb-59a3-46bb-a4c7-0af589b126e0"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2774), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("01e60ae4-ff69-44d6-b4fd-aaf916e3a7e5"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2774) },
                    { new Guid("5aaf1b6d-c032-416b-89bb-96be65b4a4b7"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2411), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2412) },
                    { new Guid("5bcaf628-377c-4e9e-808b-d6f83ad1bf6c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2839), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2839) },
                    { new Guid("5cdd323f-0a35-4d65-a53d-5a8852f582ae"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2608), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2608) },
                    { new Guid("5cdf7c3b-496b-4de2-91d5-7f3efb91704d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2645), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2645) },
                    { new Guid("5d3ddf7d-01c0-4ed1-88d0-4edbf8a6c500"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2339), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2340) },
                    { new Guid("5d5eaa17-042b-4705-85ff-146bb014dcf7"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2248), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2257) },
                    { new Guid("5d6d81fc-8246-4acb-b15b-22b3af047ecc"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2781), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("90a605b6-843d-4cc1-8fe7-a016c76ee29c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2781) },
                    { new Guid("5e590281-62f4-4f5c-a95a-93727baa6ef4"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2706), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2707) },
                    { new Guid("5f8b11d7-99a7-42b9-958d-58fb3d7fc7cb"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2704), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2704) },
                    { new Guid("60cf2b49-ff94-4bbb-ae39-c19eb5879958"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2855), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2856) },
                    { new Guid("6200f039-cf2b-424f-a4b7-c9b52d35bace"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2304), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2305) },
                    { new Guid("623dd4d0-7497-4f9f-b220-f93ea71afc31"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2268), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2269) },
                    { new Guid("62977ebd-98a5-45bb-a84b-317f68aeee9f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2813), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2814) },
                    { new Guid("6352b466-daf7-40a8-813c-6aaae8bcad06"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2680), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2681) },
                    { new Guid("64725a64-a546-465e-ab71-7cd028f098b5"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2284), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2285) },
                    { new Guid("65bd57e7-8f79-4ae3-9370-1713fcc9bd73"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2299), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2300) },
                    { new Guid("67348f2b-f36d-459d-bc56-fb4f49d19ed3"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2824), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2824) },
                    { new Guid("6a118f18-7acf-423a-9edf-ef6f6dfe9d63"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2271), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2272) },
                    { new Guid("6bd8985b-421f-4557-a388-b40d13493d17"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2610), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2611) },
                    { new Guid("6c56d132-da1d-478f-8b7b-f04d21fcc67c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2594), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2594) },
                    { new Guid("6e404eca-2de3-46b2-b6cb-288ee354b916"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2747), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2747) },
                    { new Guid("6ed6ee02-c7a8-44e8-8440-f4f26b291bea"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2797), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("0292d477-d63b-4904-a83b-2cd8cac39c14"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2798) },
                    { new Guid("6f8e0d3e-8fce-4c6d-965c-cfffcc15badc"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2518), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2518) },
                    { new Guid("6fb4ec1a-8a4a-4efb-8699-9711b8524489"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2397), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2398) },
                    { new Guid("70751a0b-d152-40de-a98a-a276c4392104"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2216), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2216) },
                    { new Guid("71927972-c9d1-46fd-ad56-970f563d17c8"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2742), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2742) },
                    { new Guid("72674141-8f33-45ce-9d87-0ba34ec673e9"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2795), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("4edcae53-7e30-42bb-8526-7686355f2268"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2795) },
                    { new Guid("73f70c16-5cc9-40ac-8439-9a47aa28a496"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2515), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2516) },
                    { new Guid("741a949b-d134-46b6-98fd-e2a96472e9cf"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2322), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2323) },
                    { new Guid("74efd3a8-9ba1-4067-9ff1-de444c7801f1"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2536), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2537) },
                    { new Guid("75249787-a6c3-4921-a252-54e338b500d2"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2757), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("00bc33fe-4cd5-47df-bd94-15ac9f93648c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2757) },
                    { new Guid("77aaf545-8f3d-4c87-aa86-533baea702d5"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2623), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2623) },
                    { new Guid("78bab2b9-931c-4085-990e-6f24de35bead"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2442), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2442) },
                    { new Guid("79e5acb9-56da-4c77-a65d-23c7b9dec77e"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2288), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("86d88717-df08-4de6-b86d-870210864b46"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2288) },
                    { new Guid("7bf04bdf-388e-4a75-b3c9-e4f3f15a61ee"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2826), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2827) },
                    { new Guid("7c41812b-2831-4f68-86f3-1afc8c77f9c8"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2344), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2345) },
                    { new Guid("7c50dae7-8acc-4949-bd78-c6903747908b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2347), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2347) },
                    { new Guid("7e8354e0-904c-4025-b74c-16ebd8622699"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2852), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a364353c-d589-4a94-9c3b-3038113ea249"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2853) },
                    { new Guid("7f982a36-22a8-4907-88f8-0a157e59c0ac"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2496), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2496) },
                    { new Guid("81e8f77a-8924-45d1-be96-7b64ecdd2ecb"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2277), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2277) },
                    { new Guid("828853f0-2581-45d6-90fd-ff9a28d0f8ff"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2358), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2359) },
                    { new Guid("82ae0d67-6d80-43bd-9e41-9e4f46883ead"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2279), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2280) },
                    { new Guid("82b18225-b3db-4cb5-b7f6-0fad79d8a89e"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2531), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2531) },
                    { new Guid("83dcc627-8360-40af-b3ee-f42d1da36320"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2728), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c5e3e4ed-0164-4917-a1ce-99679b971a22"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2729) },
                    { new Guid("8418579b-6dc4-453f-b631-91de9cd34716"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2476), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2477) },
                    { new Guid("867a8055-8d0c-46a0-8d95-4e3338fd15cf"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2738), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("7167f942-dc89-4f29-8022-588373aef45e"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2738) },
                    { new Guid("87207154-21dd-4a55-a0c7-8027327cfd38"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2383), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2383) },
                    { new Guid("8ba99018-9902-4404-887a-7534faba1988"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2431), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("51061170-597d-4289-a021-1e7dde88331f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2432) },
                    { new Guid("8c6297f8-0957-41cb-8524-20027d8df44c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2307), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2308) },
                    { new Guid("8c6ca738-f41c-4da4-9d75-5ece29a75033"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2395), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2395) },
                    { new Guid("8d609e0a-7505-4401-9aee-5563a2613829"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2336), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2337) },
                    { new Guid("8eef5b7f-84ed-4c0b-a05e-43600246faff"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2310), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2310) },
                    { new Guid("8fb997c6-68b4-44c8-ad86-e0b5e74b6115"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2816), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("982d8f3e-f517-4bd2-87a8-48329fc9eb91"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2816) },
                    { new Guid("90848325-56a2-4ab4-93d2-15426a3a6b3a"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2317), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2318) },
                    { new Guid("9131317d-0b07-4b8a-8c88-d0a5eff91c0f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2368), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2369) },
                    { new Guid("939bed02-7f28-4481-a975-0148a2becf00"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2675), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2675) },
                    { new Guid("94ffc736-01d7-4611-a3bb-51dd6cdd12b6"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2683), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2683) },
                    { new Guid("958e64d9-dc5c-47da-8f02-20461b92f447"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2512), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2513) },
                    { new Guid("95a28272-c162-435c-96e6-8307af76162f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2764), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2764) },
                    { new Guid("996b2d86-e0e2-4162-8d4a-b3012cec8cef"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2366), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2366) },
                    { new Guid("9b1e614d-f6cc-4e23-9acb-83ae762e5203"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2591), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2592) },
                    { new Guid("9ba847cd-5987-4e2c-9a53-ecdd04bc0b7c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2709), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2709) },
                    { new Guid("9cb22aa6-107e-4b9c-a909-c25ad3f0d626"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2406), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2407) },
                    { new Guid("9d549f9b-7996-4d79-8260-e2ab3aecf470"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2805), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("3dc2fa80-ab87-4e26-907b-3516611371b8"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2805) },
                    { new Guid("9d5cf97e-3f8e-47a1-aff0-6a9feb29737e"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2601), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2602) },
                    { new Guid("9f4adc7e-0b6c-4bb7-bce9-14a3e84f42d9"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2571), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2571) },
                    { new Guid("a241fd18-6209-4f58-a7a7-24927ffe9457"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2297), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2297) },
                    { new Guid("a29bdac2-bdd6-4a95-8420-d1d88a7abdde"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2528), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2529) },
                    { new Guid("a66f20fa-b62c-456f-88fb-4a1fe572458a"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2521), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2522) },
                    { new Guid("a670f989-cc8a-4dbe-bf28-f18ec693d631"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2509), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2510) },
                    { new Guid("ab207cfe-8c61-4751-bd26-c9bd5b6df296"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2444), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2445) },
                    { new Guid("ab92d202-44d2-4344-ab0d-b2b2e5450000"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2482), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2482) },
                    { new Guid("afb5ea2b-2d16-4f5f-a2c7-26decd7c31fb"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2448), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2449) },
                    { new Guid("b0e6be6b-0ab5-485a-a958-75b2d9c20cce"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2434), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2434) },
                    { new Guid("b1f7f35a-797c-4c48-bdf1-7d2b7a833864"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2453), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2454) },
                    { new Guid("b20bf5d9-b30e-4cfa-9743-826b10b2183a"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2701), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2702) },
                    { new Guid("b2fb952b-7204-4c2e-a56a-8b3509479986"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2380), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2381) },
                    { new Guid("b43f17d1-d69b-428a-8171-ffdd590c2e67"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2808), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2809) },
                    { new Guid("b7b7301a-85ed-4b22-a65c-622f759b3096"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2294), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2295) },
                    { new Guid("b874788f-1871-4d93-bf61-9a0b466c4c76"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2858), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2859) },
                    { new Guid("b96955bd-109a-48d2-a845-21c91ae25c03"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2717), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2717) },
                    { new Guid("bb0a741d-c234-4328-a70b-4301acc299e7"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2783), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2784) },
                    { new Guid("bb602d10-7915-4698-bb1b-e0b11d1ff68c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2654), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2654) },
                    { new Guid("bcbf0c4c-7135-41bd-823f-b5722d2b0d59"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2661), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2662) },
                    { new Guid("bcc0efa2-5236-4218-bf95-120b3f4b593b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2576), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2581) },
                    { new Guid("bdf56dcd-be98-4daf-8368-31b3bc6fde9e"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2754), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("af036922-79f3-45a7-b562-a6279520c0e6"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2755) },
                    { new Guid("c09e3a54-519b-4d71-949c-bd62cd9d8bec"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2224), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2225) },
                    { new Guid("c1cc5cfe-a6df-44b0-a0da-efab82e3eb76"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2332), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2333) },
                    { new Guid("c2cfdda0-5656-4127-9ce6-6885086cbe9b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2656), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2657) },
                    { new Guid("c3c9236e-8234-427c-a63f-ace2e8c62d3b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2436), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2437) },
                    { new Guid("c3eff0d0-19fd-4dc1-a576-5345dca063b9"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2487), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2487) },
                    { new Guid("c4fbcbf9-910c-4b83-a569-fb9303f68034"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2439), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2440) },
                    { new Guid("c5d78eee-0aee-47ec-ba3f-a25432c73634"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2830), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2831) },
                    { new Guid("c6238846-3bfa-4541-9bb0-ce50363feea5"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2374), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2374) },
                    { new Guid("c6b30c5e-8e5b-4eff-aa3f-29f61d47d71f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2730), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2731) },
                    { new Guid("c7353857-24b1-42de-933c-26fcd4f2c61a"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2666), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2667) },
                    { new Guid("c81bf152-6dc5-492f-9f2c-7e86458a4f84"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2749), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2750) },
                    { new Guid("c894ca3b-e4ce-40a4-944d-69c8ffb6f0a7"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2426), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2427) },
                    { new Guid("caaf6a3a-73b0-42e5-886e-9e332fa7254b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2752), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2752) },
                    { new Guid("cacbe944-0a8c-4405-ba45-82e823704661"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2551), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2552) },
                    { new Guid("cbf24b61-e144-4c4e-9a9a-cf2256d21089"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2392), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2393) },
                    { new Guid("cd68daa7-fb28-47b5-8901-833d8c82047b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2503), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2504) },
                    { new Guid("cda9366e-17e2-4c4d-8a5a-4b36f8944965"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2714), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("2ae82bfd-34db-4928-bfee-b60f4aec4460"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2715) },
                    { new Guid("cec316ee-3493-417c-8846-0472a1eaae59"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2458), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("faf19891-525a-4308-9222-992e83de7ce7"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2459) },
                    { new Guid("d17a82bd-16b4-4172-ad44-46fe378f705a"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2541), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2542) },
                    { new Guid("d1a9c21c-c335-40f8-b62e-fec9e472f906"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2467), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("faf19891-525a-4308-9222-992e83de7ce7"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2467) },
                    { new Guid("d26390ef-a02f-4ac5-a466-ccdec9f882a4"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2500), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("7b8500af-d730-4138-9617-cba352faed4a"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2500) },
                    { new Guid("d3050820-ddbc-4935-98e4-c03adddb6ce9"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2409), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2409) },
                    { new Guid("d3628015-d816-4f6e-8c4c-c91d3d52a1ef"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2866), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("a504d882-4f38-413e-bb28-fae1f2787150"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2866) },
                    { new Guid("d41c730b-e5e6-4a81-bd5d-9b61e0b3ab29"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2282), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2282) },
                    { new Guid("d455c586-21a5-4b2d-8b8b-db7b3d73900f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2221), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2222) },
                    { new Guid("d6ed3bc7-db8d-47a0-b539-1bedfbdc18ec"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2243), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2243) },
                    { new Guid("d7baff1f-6312-4a35-b35b-675ccacd95c4"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2596), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2597) },
                    { new Guid("da37c116-bd4c-4431-af16-3d7be0ea9698"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2376), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2377) },
                    { new Guid("dadc4546-25e5-4da5-925a-94625e460b14"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2315), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2315) },
                    { new Guid("dcdc3768-3a6a-4bc1-a413-164e9e59a130"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2790), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("29dfb5da-8818-40ff-bf66-7553521c2161"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2790) },
                    { new Guid("dcf157fd-b4ed-4cd9-8b19-a2bfde5f8710"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2479), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2479) },
                    { new Guid("de69bb03-7dcf-43d6-b3e5-7a1b8a41ee5f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2469), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2470) },
                    { new Guid("deca5020-0ec0-4948-a1ee-3c4a33d9f649"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2472), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2473) },
                    { new Guid("deecd66e-53ef-46cf-bff9-de8436d9c493"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2802), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2803) },
                    { new Guid("dffc1c9f-88ab-4a15-be94-0eb9179b4544"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2456), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2456) },
                    { new Guid("e1280fba-8f85-4d2f-970f-f07c5a20ee64"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2562), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2562) },
                    { new Guid("e2e3f8b3-4a2c-489b-9454-c826025cba61"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2863), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("3d19d971-88d0-4108-a335-24ac9e1dec50"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2864) },
                    { new Guid("e3fd8a51-a8a8-45af-9ce2-f77a20bf77ca"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2240), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2241) },
                    { new Guid("e429c407-304d-4676-8213-ff715732bd4c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2723), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2723) },
                    { new Guid("e4b90644-e149-4b1a-9c5a-4b13ff3884e7"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2792), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2793) },
                    { new Guid("e59f2ded-ecf3-46df-a9ce-b774257795f0"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2733), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2733) },
                    { new Guid("e7811158-ea60-4e08-ac22-e02b699ac5b8"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2695), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2695) },
                    { new Guid("e84b88a4-4718-48c4-9f24-e53aa1fbb142"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2450), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2451) },
                    { new Guid("e856379a-c84c-4993-9dab-ac82c04d9d69"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2544), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2544) },
                    { new Guid("eb4d3331-7f6d-4c3a-85df-53be3ba845c3"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2744), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2745) },
                    { new Guid("ef6c26a0-48b0-4293-9c63-bc2dd92f7c34"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2769), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("a988cc73-072e-4af1-9b53-55fbf0f4fe79"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2769) },
                    { new Guid("f02ce0e9-9619-4468-9a00-3a44eab3d2ea"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2861), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2861) },
                    { new Guid("f322f587-fd2e-4a0e-911e-2b813624d755"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2534), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2534) },
                    { new Guid("f32fb702-90f2-47d8-ba59-81fffd49d400"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2849), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2849) },
                    { new Guid("f475459b-ef4e-43c6-81cb-57e33cd1a3d6"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2846), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("2146faae-2e7c-4460-8d81-38f5d313012c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2847) },
                    { new Guid("f528ddae-2b07-4548-a484-208f148b5379"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2658), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2659) },
                    { new Guid("f5295aac-6747-43e8-b3e1-d13acb500b4f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2414), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2415) },
                    { new Guid("f53b6af5-b096-4656-8b35-357bd1b6a240"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2489), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2490) },
                    { new Guid("f76ff0e8-1140-4908-9901-82c88b65bca2"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2385), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2386) },
                    { new Guid("f8cd884f-b1f5-47b0-afd4-0d7f2db16a4e"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2651), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2652) },
                    { new Guid("fc11342a-dd7b-497b-b337-21963e783e28"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2677), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2678) },
                    { new Guid("fc51fea7-f716-48af-8010-1769a1286854"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2320), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2321) },
                    { new Guid("fd4f2803-f382-4464-a882-d83cd071cd35"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2539), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2539) },
                    { new Guid("feae6bda-de5d-4151-b91e-f91eb101a370"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2635), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), new DateTime(2025, 4, 2, 20, 51, 7, 601, DateTimeKind.Local).AddTicks(2635) }
                });

            migrationBuilder.InsertData(
                table: "FoodAllergies",
                columns: new[] { "FoodAllergyId", "AllergyId", "CreatedAt", "FoodId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("08f66a0f-9256-4f59-8d18-7b49bb348c36"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), null },
                    { new Guid("0fb49625-1cb6-4d33-b2df-777995bc4ed7"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), null },
                    { new Guid("16a50beb-bf72-4259-badb-d02209c52250"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("faf19891-525a-4308-9222-992e83de7ce7"), null },
                    { new Guid("20c8a587-40de-40b9-906e-31e329420879"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), null },
                    { new Guid("21a3102c-db90-4b15-879e-d84de62d8c76"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), null },
                    { new Guid("226ae82f-522a-41ed-b82f-e1326ffc2698"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), null },
                    { new Guid("26e7d364-cf87-4ce2-996b-a25de591bacc"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), null },
                    { new Guid("27b81ebd-0156-4821-bc0b-02298855c386"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), null },
                    { new Guid("2bc1279a-fe2a-4287-87d0-4c021e36c3d0"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), null },
                    { new Guid("30aeb8b2-981e-4f9e-b3ed-64ca44ecae8f"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), null },
                    { new Guid("30f101e4-c075-4c87-adad-1d918eabd518"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), null },
                    { new Guid("330c3b81-535f-43c0-85f5-ce874f78e651"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), null },
                    { new Guid("35ca16a3-2fc9-4bb2-9c9c-f775a2fcd113"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), null },
                    { new Guid("3ccc0b64-3a07-44d3-9219-f0218881669b"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), null },
                    { new Guid("44b354b3-02aa-4a71-af84-5257623117fd"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), null },
                    { new Guid("4b157ec5-30ed-43fe-9f41-5a040b47670c"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), null },
                    { new Guid("4b595ed9-5933-402d-9274-23f37071cecf"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), null },
                    { new Guid("4c4aec7a-e9bd-45e5-95f7-ef468749df1d"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), null },
                    { new Guid("52ee752d-0130-4b1d-8200-d6edca3ea3b6"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), null },
                    { new Guid("542c5ba7-5e4c-40ea-8c7b-e2e24a37099c"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), null },
                    { new Guid("58b0e0a4-9ef4-4bf2-8de4-ca78e2e128c8"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), null },
                    { new Guid("5ab21838-3e33-451b-8130-27da501d7273"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), null },
                    { new Guid("6131101a-4e76-4bc9-a684-f0f56cc94611"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), null },
                    { new Guid("61e97682-f3fb-459a-8973-a41fd210be41"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), null },
                    { new Guid("668bc39b-8e95-457b-b2c8-61ffea4333e1"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), null },
                    { new Guid("695c31b7-3d4f-408f-9a86-1464069816ac"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), null },
                    { new Guid("6abdeb66-d512-47e3-bf92-ec9b9a0d7391"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), null },
                    { new Guid("6e6967d2-5e9e-40b3-ba3d-3c83518d3e7f"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), null },
                    { new Guid("711bdb0d-0cde-4e54-964f-a6906e81fb2a"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), null },
                    { new Guid("7b7a2ec8-ea56-4ad2-961d-767d3f8e17a3"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), null },
                    { new Guid("869c5539-4b9f-42af-91e4-cba51afe115e"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), null },
                    { new Guid("8775db0c-e47f-4ea8-97dc-928a6c5a107c"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), null },
                    { new Guid("95c6cc33-02cb-4e31-8543-e5e25c5ff8fc"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), null },
                    { new Guid("9aab24f0-6651-4a37-8e91-9bb69b106417"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), null },
                    { new Guid("9ea0081c-d0fd-4cd2-94be-c3ab458b39bb"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), null },
                    { new Guid("a0a0977a-ce8e-46ed-896a-0103614d3d53"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), null },
                    { new Guid("a17a9b5b-ac9f-4269-b3c5-917e36987958"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), null },
                    { new Guid("a7738a8e-9538-4c25-a4de-0022fabc23fe"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), null },
                    { new Guid("a88d68fc-a7c7-4995-9b4a-197f29ab9bba"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), null },
                    { new Guid("ad60845f-fa12-4177-92d6-9ca436ec9412"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), null },
                    { new Guid("b3f08d2f-6dbc-4d5c-85b4-f78d79f4c7a6"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), null },
                    { new Guid("b730d971-d4e6-4ed2-abf4-e265b2be8dc9"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), null },
                    { new Guid("b7ccec2f-82f8-42ac-af0b-7d823e7cc30b"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), null },
                    { new Guid("b86ab9a3-be98-4890-8505-691b7ba18f90"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), null },
                    { new Guid("ba1c5b9d-8e7f-4569-9295-4d593c8d0fbe"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), null },
                    { new Guid("ba21b663-2f0d-4e71-8c7d-694d672da6fe"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), null },
                    { new Guid("c1af534c-ad6d-43eb-981a-e52108a26a6d"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), null },
                    { new Guid("c415d458-b944-4a75-966b-cd2786a73530"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), null },
                    { new Guid("c4b136ae-33af-42c1-a4ee-69c687d2f9ba"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), null },
                    { new Guid("c73ba788-0801-44f9-a61c-f4667eb5e3cb"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), null },
                    { new Guid("cb367144-e472-4a5a-93bf-1c453d8ff981"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), null },
                    { new Guid("cdb38a72-bbe0-4526-996c-a364655531a0"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), null },
                    { new Guid("d227bd69-9e4d-4ab1-b3c1-c9ae7173cee6"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), null },
                    { new Guid("db1d43ac-d163-4168-b1dd-f287d7d3f772"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), null },
                    { new Guid("e3f6c9e2-3959-445d-8dfe-75525a786d99"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), null },
                    { new Guid("e52db442-59a3-45ec-a34d-3d7e42c1364b"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), null },
                    { new Guid("ea5f90e5-e94c-4b27-8925-faff71f5cfde"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), null },
                    { new Guid("f1eb2620-bbb9-4383-8544-3ccff0f9b688"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), null },
                    { new Guid("f64e0edc-88eb-46ac-93b5-18404fdca908"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), null }
                });

            migrationBuilder.InsertData(
                table: "FoodPortions",
                columns: new[] { "FoodPortionId", "CreatedAt", "FoodId", "PortionId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0195abc3-37a4-43ce-9934-d73a8ff55b5f"), null, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new Guid("3f19ef5c-3c60-4a11-b1b3-5158859f1286"), null },
                    { new Guid("0461d3a8-ed23-4f27-ab76-157042c0a80c"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("e45c2156-a98c-4121-90b4-25097e8a5cd1"), null },
                    { new Guid("062ab1e6-91a2-4963-ab1e-b25a5bd4565b"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("63d10d95-7983-455e-b920-29c1f0c88d85"), null },
                    { new Guid("06a1d6f3-579b-4fa8-9966-2376f06538be"), null, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new Guid("a33065fe-80ad-4879-9333-424aadc6734f"), null },
                    { new Guid("08cc1fc0-e570-4224-98c9-9c5d05507d11"), null, new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new Guid("f0e8f9cd-d133-49cf-be7d-d427b630e05a"), null },
                    { new Guid("08fd08bd-ece3-4f48-96e0-2a4acc35465b"), null, new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new Guid("6792c392-3c86-4162-be91-4fc8646f861d"), null },
                    { new Guid("0b30820b-6a89-4793-81e1-3b0d6cbb61f5"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("709578ca-672f-461e-995d-dc78aeda8c4c"), null },
                    { new Guid("0e61aa62-3129-4f9e-89ff-364fa3ec58dc"), null, new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new Guid("30f41ca6-c420-4f7d-9602-bf80735d5691"), null },
                    { new Guid("0e6c751e-cd2a-41c8-a936-ecd0c279ac4b"), null, new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new Guid("749b288c-112b-4b7b-8750-0daff63d9ab3"), null },
                    { new Guid("1153c3fe-1553-495d-a252-caaf07e85f53"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("5a9ac478-aa65-48ea-9387-1ad92f6c76b1"), null },
                    { new Guid("116dfdf5-4866-48d4-8a94-93d5e37cee1b"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("7b138bd4-4d3a-426c-9ab0-d66699b762d2"), null },
                    { new Guid("173963e5-5818-4fd3-ad60-252087b0d938"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("6f34350b-8f99-446e-9de9-e0c6277b10f3"), null },
                    { new Guid("1892c016-e370-489d-ac90-fc575461db71"), null, new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new Guid("1500876f-ef20-40de-baae-de0336bdc47b"), null },
                    { new Guid("19b7e738-76ee-4aee-937e-5df8ad1465e3"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("d3850e1b-4780-490d-8c0c-ced1a9aa323b"), null },
                    { new Guid("1badb7cb-c458-460e-b766-743ee06f4041"), null, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new Guid("d2e88505-bbd6-4af6-9a88-535896c5d587"), null },
                    { new Guid("1cdadcb9-6306-4b3d-b6c9-bb8c3eba12e3"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("c65d34ee-8c0c-43bb-9d4e-aa39955a4768"), null },
                    { new Guid("260549e5-1947-4167-baa9-376bccfdc4fe"), null, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new Guid("1cf439ce-a31b-4b95-b092-b7f6edf8d40f"), null },
                    { new Guid("2cd050c4-9639-4c3b-8fc2-9f91a3985424"), null, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new Guid("9c276c0b-84b6-4216-8dbb-ae2034ac2176"), null },
                    { new Guid("2ecc26e1-042e-46b1-a1a2-4a978153d129"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("c605aa91-495e-4977-9876-b2a198ce356e"), null },
                    { new Guid("306e9705-3e48-4104-808c-7e24735a5a5e"), null, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new Guid("b6623163-4c27-4d0c-99ef-12a67b87635f"), null },
                    { new Guid("361b41ad-f140-4b81-b427-e30003e294ba"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("5adcb96d-70ef-403d-89c6-cc3aa807b6a7"), null },
                    { new Guid("3c5d822e-c67c-402c-8991-876992dffdea"), null, new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new Guid("255ba0f6-14cc-4049-add8-138f27055b49"), null },
                    { new Guid("3d56668e-7b5e-4ef7-bc72-8ef68a233491"), null, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("40991196-f258-43f1-ac84-0381afa83477"), null },
                    { new Guid("3fc74581-03b2-4ec5-8c47-5d1ef0bc81d7"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("bd16f0ec-5ae1-42f4-a302-b4bce8f0db28"), null },
                    { new Guid("42b64f62-3dd6-46ed-9e26-c985436702f6"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("e5cc2785-6d62-4b5f-8fc1-e6ab45babd76"), null },
                    { new Guid("49d5597a-b0b3-4c83-b40d-97f912a21b19"), null, new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new Guid("5feca670-1f15-430d-9b04-7ac86a329a6c"), null },
                    { new Guid("4b255dd0-f8c6-499e-bb5e-ae963dd0b440"), null, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new Guid("31e9bda5-8ec3-4444-a23a-908e84da6a14"), null },
                    { new Guid("4c1740ea-7bd2-41ad-b9e6-8f3ec81e9294"), null, new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new Guid("1cddc91d-209a-4948-8e9f-9017252d5423"), null },
                    { new Guid("4c7746b8-90ad-46ee-ba17-fb3bd066d211"), null, new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new Guid("2892c25f-bd50-4bb4-a845-997395ef6693"), null },
                    { new Guid("5057fbb5-f4ba-4b71-8a88-6dc6ebc2ba75"), null, new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new Guid("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52"), null },
                    { new Guid("530cfb5a-c246-4122-a3e3-9c29b39c275e"), null, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new Guid("424ebe64-6570-4d88-9052-08c06dc0a2c8"), null },
                    { new Guid("55782bb6-be6a-46d6-8973-a8e22105887d"), null, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new Guid("3d6d946f-8d9f-479a-b27e-3d78dc354db0"), null },
                    { new Guid("55fb68cc-83d3-49ce-8901-c15e97d7b873"), null, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new Guid("84793ef9-fcd0-42df-ab0d-9380dfa18630"), null },
                    { new Guid("5799bf84-2eea-44a6-ad25-94ce8e660871"), null, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new Guid("222e1fa2-3910-42ac-9a5c-f371dded16eb"), null },
                    { new Guid("5c2b724c-d14e-4769-875d-7ccbc954d34b"), null, new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new Guid("a1589990-affa-4805-a1e0-73de1ffa8516"), null },
                    { new Guid("5f730d45-98e0-48bd-a021-c35227cab2a7"), null, new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new Guid("8a81e20e-ea16-4073-957e-29508a8f7419"), null },
                    { new Guid("6453bcbf-4c7b-4477-87f8-075c1a082eff"), null, new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new Guid("41ae956e-14fc-44af-bc6a-e5ba77661cee"), null },
                    { new Guid("647bb78e-8f37-4510-841e-c5be8aa1c5b4"), null, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new Guid("8ecbc063-8d6e-450d-af39-0ba28bc572bf"), null },
                    { new Guid("685b9b02-d49e-457a-93c7-d025cb3a7465"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("f9bc9ae8-e42e-4e8b-84d3-f2bc36037552"), null },
                    { new Guid("687ed317-a4ec-4973-9c6c-6809d8aec5b9"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("6e98f2be-9196-4c4e-8279-b02010f853f1"), null },
                    { new Guid("6b86045d-d35b-4aba-85bd-76889188e12e"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("40bbc8c4-f383-4ae6-979a-3ac83c275881"), null },
                    { new Guid("6f64cf44-c178-4d0c-8d86-1b6311c66932"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("91524cc2-db22-4cab-abb7-700725232f1f"), null },
                    { new Guid("70d4061c-1131-441d-b75f-9ae7172e2169"), null, new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new Guid("92e149ff-8491-48cf-a4e8-8106b1e95c4c"), null },
                    { new Guid("72e652e6-3d01-4ce8-8406-3fdef5719ac8"), null, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new Guid("18809fb3-b78a-4f67-b9f9-8bb6ab95ab00"), null },
                    { new Guid("738723be-3b81-4054-ae56-587904878834"), null, new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new Guid("5384aebd-4eab-4a44-8cbb-7ec2c04f1401"), null },
                    { new Guid("7787149e-d17c-4264-90f9-00b09beeb066"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("919c7f66-53e5-46bd-b181-558f6052b953"), null },
                    { new Guid("7847a7fb-0667-44ee-8520-27706fb7817e"), null, new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new Guid("22f0a09e-6816-410e-a5a2-c802103b089b"), null },
                    { new Guid("7b68d2cc-fdf7-4b2e-8480-4e917e7c9680"), null, new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new Guid("4e9013c8-d6f7-4740-80d5-e95d318873b9"), null },
                    { new Guid("7d3be450-913c-4c7b-b5ff-247c5020e046"), null, new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new Guid("ef6b8c43-9ab5-497c-a9a8-e31f0a349527"), null },
                    { new Guid("8031d9dd-36a3-42b5-94b0-beab57a9b186"), null, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new Guid("c4993d6a-a2e0-4ddd-821a-0629541e019c"), null },
                    { new Guid("8652d9cc-81f2-4333-9cef-28064b1db47b"), null, new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new Guid("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649"), null },
                    { new Guid("8c44972a-7f4f-483d-9171-8e01057199e0"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("f483bb75-84f0-4ecc-8a06-f366a488c6bf"), null },
                    { new Guid("8c939b9a-aa0a-41f8-9cd9-d4fe98a4b756"), null, new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new Guid("f7b36043-9ca9-42c3-8a00-e9e235b56bb3"), null },
                    { new Guid("8f01809b-72aa-48af-af18-9eb8873c1d81"), null, new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new Guid("5a1bc1cb-ed0b-49bf-9c1a-5494db962d27"), null },
                    { new Guid("925c7624-bf53-4b03-b6bf-93b0d4958760"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("faec7c41-2e11-4092-8ab9-cc9c152d858f"), null },
                    { new Guid("929a5350-271a-4d77-aba1-46eb9014b19c"), null, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new Guid("bdd1ee1e-3a93-421f-855e-0993c7e6f767"), null },
                    { new Guid("93637bc6-3831-41a5-a5d5-8b49657e3ef9"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("698c67ad-a726-435b-b9d2-c5690a79eb5a"), null },
                    { new Guid("94c5b5cb-bf54-4518-8428-3c364e19a6a0"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("bf0f7ca4-9089-4800-95d7-8d037d98b7fc"), null },
                    { new Guid("9bb9211a-88c7-4114-93e2-4754cce9b4b6"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("d9dad801-145a-419d-bbe2-408acf97a273"), null },
                    { new Guid("9e86d7e6-9edc-4a77-94d1-858523cd81d1"), null, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("1808de3e-ae43-41a6-b9ce-bfe89131be5a"), null },
                    { new Guid("9eb49fbf-f0b8-4c72-a446-41fce0dabd80"), null, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new Guid("7e071bd6-6afa-483d-8688-28b31b9a8bef"), null },
                    { new Guid("9f9e0f85-d358-4b67-9be7-64e460130c9c"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("26dcc6e0-67aa-40ed-b3d1-8a009c60a62c"), null },
                    { new Guid("a178dcba-6e75-48a2-a540-74093b7caa14"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("28b06cf6-6367-4786-bccb-89c43dd3ce3a"), null },
                    { new Guid("a4741f7a-9c38-4146-8c78-88291bc22700"), null, new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new Guid("c4fc900f-5a92-4228-ac03-57285fff159e"), null },
                    { new Guid("abc9247c-582a-40bb-bd40-8526204428ee"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("a43d7637-6fc7-421b-86f1-f83e691431a4"), null },
                    { new Guid("ad08f703-5f33-417c-b0b1-869d5d81ca05"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("7be0e4d3-1e50-4de1-931d-08adb85f628b"), null },
                    { new Guid("af382f22-cdc8-45de-a6ce-2e4d5a1928c8"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("3c7d60d4-60da-4f51-9448-30877b126572"), null },
                    { new Guid("af781def-148c-4ca1-b232-18310050350b"), null, new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new Guid("3f77fd90-591c-45f3-8bbc-87d0bb49e461"), null },
                    { new Guid("afd9ca93-9670-48af-9c1a-c91c320c95fb"), null, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new Guid("eceaaa32-4023-4eab-abb6-9172c908f77c"), null },
                    { new Guid("b402fca9-9c30-4f3d-ac96-58f3015b8862"), null, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new Guid("d09266d3-9e7d-46a6-ad3a-7c608ec802d1"), null },
                    { new Guid("b60f99dc-957a-40d5-8e72-fda74445101e"), null, new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new Guid("a9385e8a-e9b9-484f-beeb-bc35529cf91a"), null },
                    { new Guid("b733787f-78de-4d6d-95d1-844b210c1e9e"), null, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new Guid("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a"), null },
                    { new Guid("b7a68bc6-6fe9-408f-9ad2-98af669f9c3a"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("218b9709-852d-4a1f-ad8b-c9410b49fea6"), null },
                    { new Guid("b88808d1-1c3c-4d3d-abf4-bf072ba25ff1"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("113f6a04-87c4-43c6-8263-920bd099c8e0"), null },
                    { new Guid("b8a593c6-7bbe-41bb-a565-feb4e72cb78e"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("26096793-894d-47c1-a06f-cf9133f8089d"), null },
                    { new Guid("bbc07ad0-eb34-4987-b8b3-8cc4c10addb6"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("f928b7a6-2558-478a-bc22-515516f4dc74"), null },
                    { new Guid("c47d8372-87e9-48c0-be27-2bff655ef7a4"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("399eee61-90b5-464f-b3f7-7ddc1077ab0d"), null },
                    { new Guid("c4a98f9b-c708-4c9c-9144-eb85a51163e6"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("a7936b9f-b6f8-4295-8b6e-6fe1b096f437"), null },
                    { new Guid("c7528a64-2940-439d-91f2-86d17c012289"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("17c9d30f-bd85-4e58-bfc0-6b6d70b2e5fe"), null },
                    { new Guid("c9c82463-7568-40f2-9c88-f85e304a49ce"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("52c86d57-0909-41c3-b513-e770e6f6d104"), null },
                    { new Guid("ca9f09d7-5bd6-4655-8e46-7070f1669e71"), null, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new Guid("ad9ecd1e-40ec-414a-be69-b16e7013b377"), null },
                    { new Guid("cb44e0d4-2b10-49b7-bea0-52fd234a84c8"), null, new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new Guid("5f7f859a-f20a-4f6c-8b8c-ecfbb1ff522e"), null },
                    { new Guid("cf8d8e44-cef7-4554-b788-86930cf02168"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("c6e853f0-06bd-4cda-8b43-cbe66fea98c8"), null },
                    { new Guid("d03e0adb-47cc-4353-a207-b6f30b9b52be"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("a5dbb27a-4856-44be-a239-76eb073c3e41"), null },
                    { new Guid("d23b4d18-9213-4b74-8914-ecb3daf7efc5"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("36398f6d-0668-4d37-8850-9f9ee89b8b92"), null },
                    { new Guid("d262fae9-a5c9-4dbe-a2ed-d0efda7ba348"), null, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new Guid("de5d78a3-c5b1-4e2a-b9eb-f3757c999024"), null },
                    { new Guid("d7f61aaa-069a-4d05-8469-3a877b38a8c8"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("1b56833b-1ff5-4a90-aea9-074de2d0dd67"), null },
                    { new Guid("d803753a-7d40-4b8f-b4a6-ad135992523a"), null, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new Guid("1802caa2-cfe0-48e7-8580-29165f84387d"), null },
                    { new Guid("dacbe05c-960f-450e-b3b3-0c33c894f618"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("e00ed683-11ff-4c21-8b1c-576b448726c9"), null },
                    { new Guid("dfce8268-e011-4d65-a3e6-22593da596f6"), null, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new Guid("16dc894a-746e-497e-a2c5-2d58f7f83c4d"), null },
                    { new Guid("e13834f2-c55e-421d-be52-5185d91963b4"), null, new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new Guid("e23d4491-73d1-45b5-8010-0385d7185c98"), null },
                    { new Guid("e246d649-0ffd-4f54-ada0-bf192b8c646a"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("23ce32a0-6597-4b60-b35c-98073ff595c6"), null },
                    { new Guid("e28a4e07-99b9-4cc3-8f36-807c6c356b1d"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("9c3399d1-72db-4e86-a518-2575033bb6a8"), null },
                    { new Guid("e2c6538a-5510-49cd-962d-85305c0b231d"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("cd0b1476-44a8-4350-a6a1-3de8747a5ebc"), null },
                    { new Guid("e3e6773e-662a-42ba-b7d0-2d2ec7a0735e"), null, new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new Guid("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1"), null },
                    { new Guid("e53051db-d8ff-4769-bf2b-2e2838bc47e5"), null, new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new Guid("93984b54-2044-4ea9-8364-a03c6568e358"), null },
                    { new Guid("e5ef4c5a-f525-4a27-80b1-48bc037c96e4"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("a88faa7c-6eab-4ecb-8a75-b078a9cf7834"), null },
                    { new Guid("e78b7aa5-f4ca-49a1-bf0d-12a19bc022bc"), null, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new Guid("bad70aff-4237-4c83-b412-460020a5ee44"), null },
                    { new Guid("e85bed6b-9bb0-4ee5-b83f-9586a99d1e35"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("87409e4f-4bea-4bba-855d-a3bfbc2f9c20"), null },
                    { new Guid("eaf8d069-6983-4dd7-b730-2da486639140"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("eff728af-c8f0-4bb5-a985-d079cbadb6b5"), null },
                    { new Guid("ed2ae164-d554-47c6-8366-9196274c042f"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("549d664a-eb1c-4b9a-8ad7-fab9e1482e5b"), null },
                    { new Guid("ef761526-e978-4fd4-a31e-e6a7e2a3902f"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("e09c493c-5806-4b14-bbef-e26e19e1d8d5"), null },
                    { new Guid("f5c1a7b4-6277-4817-83b3-c2bd2582b68a"), null, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new Guid("59589114-7d6a-4c80-8681-db5c554ab38f"), null },
                    { new Guid("fb5e7d40-f866-4037-9cec-da31af4aec17"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("56681171-ccbd-4700-90bc-2233c1e661bb"), null },
                    { new Guid("fc3e10dc-b3cf-4d64-9fb1-69530ccabdde"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("5afaa147-398e-4be8-b0d1-8dcabe6ed18c"), null },
                    { new Guid("fda04690-b708-4f4a-ba89-eda77b0f762c"), null, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new Guid("21e32570-7d64-4cec-b711-873185c76523"), null }
                });

            migrationBuilder.InsertData(
                table: "Nutrition",
                columns: new[] { "NutritionId", "Calcium", "Calories", "Carbs", "Cholesterol", "CreatedAt", "CreatedBy", "Fat", "Fiber", "FoodId", "Iron", "Potassium", "Protein", "SaturatedFat", "Sodium", "Sugar", "UnsaturatedFat", "UpdatedAt", "UpdatedBy", "VitaminA", "VitaminB1", "VitaminB2", "VitaminC", "VitaminD", "VitaminE" },
                values: new object[,]
                {
                    { new Guid("000eb208-b3c3-4ada-b3fd-91836d330cae"), 8f, 110f, 22f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.9f, 2.5f, new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), 0.2f, 60f, 3.5f, 0.1f, 4f, 0.2f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("0325b7e3-c5ea-4941-83ec-376acf5f574e"), 50f, 30f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2f, new Guid("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), 1.2f, 250f, 2f, 0.2f, 300f, 1.5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 400f, 0.05f, 0.07f, 20f, 0f, 0.5f },
                    { new Guid("061bcc3f-9c27-47ec-9fff-ef6e54bc2207"), 40f, 300f, 40f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 2f, new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), 3f, 350f, 20f, 4f, 900f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.08f, 1f, 0f, 0.2f },
                    { new Guid("092d88d2-704c-464e-9cea-c6e4ae338466"), 16f, 25f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.5f, new Guid("3dc2fa80-ab87-4e26-907b-3516611371b8"), 0.3f, 140f, 1f, 0f, 125f, 2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0.05f, 0.06f, 12f, 0f, 0.1f },
                    { new Guid("0946c25c-598d-46ca-9237-b19df3a96df7"), 22f, 265f, 49f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.2f, 2.7f, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), 2.4f, 115f, 9f, 0.5f, 491f, 5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.2f, 0.12f, 0f, 0f, 0.1f },
                    { new Guid("0a555813-50bb-40ec-a1f8-e0ca3d5318a4"), 10f, 330f, 0f, 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25f, 0f, new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), 1.5f, 200f, 27f, 9f, 75f, 0f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.05f, 0f, 0f, 0.1f },
                    { new Guid("0cb2f70b-68d2-4d54-ba69-93566c63535e"), 20f, 20f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.5f, new Guid("e370081a-c0a6-4c00-b01c-7c52f953b7f1"), 0.2f, 150f, 0.8f, 0f, 50f, 2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.05f, 0.04f, 12f, 0f, 0.2f },
                    { new Guid("0d06c834-bc18-496d-9fb9-d3edfc880f9b"), 10f, 120f, 20f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 0.5f, new Guid("c5e3e4ed-0164-4917-a1ce-99679b971a22"), 0.6f, 150f, 6f, 0.5f, 300f, 0.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.06f, 0.05f, 1f, 0f, 0.2f },
                    { new Guid("0dc6f0a1-a106-4342-918c-dd40de66d2b7"), 80f, 280f, 35f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2f, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), 2.5f, 400f, 15f, 4f, 850f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.2f, 4f, 0f, 0.5f },
                    { new Guid("1057333c-6993-4faa-9f6e-e952baf0ef79"), 20f, 170f, 35f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 0.8f, new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), 0.8f, 80f, 4f, 1f, 350f, 1.2f, 2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.02f, 0.02f, 1f, 0f, 0.1f },
                    { new Guid("13af571a-3e57-4b3b-8c13-7f5c6f1ffc43"), 15f, 130f, 20f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 0.5f, new Guid("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), 1f, 200f, 7f, 1f, 400f, 0.5f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30f, 0.05f, 0.1f, 2f, 0f, 0.3f },
                    { new Guid("14121bdb-6a3d-4e96-ad25-495f9b4641c3"), 16f, 16f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.5f, new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), 0.3f, 147f, 0.7f, 0f, 2f, 1.7f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.03f, 0.03f, 2.8f, 0f, 0.03f },
                    { new Guid("14e08bab-f93f-4185-b759-180ece51b04a"), 30f, 220f, 15f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2f, new Guid("29dfb5da-8818-40ff-bf66-7553521c2161"), 2.5f, 300f, 20f, 4f, 600f, 5f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150f, 0.1f, 0.1f, 4f, 0f, 1f },
                    { new Guid("15b07609-ec19-47d6-9edc-d6d88f5abc1b"), 20f, 15f, 3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.8f, new Guid("6487a532-ff5e-4b77-b408-46c789608de9"), 0.3f, 150f, 0.8f, 0f, 180f, 1.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 0.03f, 0.02f, 7f, 0f, 0.1f },
                    { new Guid("161886a9-b2a8-488c-8770-97be13c37528"), 40f, 16f, 3.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.2f, new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), 0.5f, 252f, 1.2f, 0f, 13f, 1.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.37f, 0.04f, 0.04f, 36.6f, 0f, 0.12f },
                    { new Guid("17c6e35c-51a2-49bd-9646-5d77185d867f"), 18f, 15f, 3.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.2f, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), 0.2f, 140f, 0.8f, 0f, 3f, 1.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.04f, 10f, 0f, 0.1f },
                    { new Guid("17f8b780-40f7-4b3f-a458-ea815c493fae"), 6f, 46f, 11f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.4f, new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), 0.2f, 157f, 0.7f, 0f, 0f, 10f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.04f, 9.5f, 0f, 0.4f },
                    { new Guid("1bbbf7bd-15fa-4f05-ae4e-aeafacb3d01f"), 20f, 180f, 35f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 0.5f, new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), 0.7f, 120f, 4f, 1f, 400f, 0.5f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.08f, 0.05f, 1f, 0f, 0.2f },
                    { new Guid("1ca24583-af6b-4730-851a-714531fe509d"), 110f, 90f, 15f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 1f, new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), 0f, 140f, 3f, 1f, 35f, 12f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.04f, 0.14f, 0f, 0.02f, 0f },
                    { new Guid("1d3b49ec-8cc6-408b-af2c-28591ef73341"), 40f, 25f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 2.5f, new Guid("8ed85dc2-7654-4c48-81f9-19946a73f71d"), 0.5f, 170f, 1.3f, 0f, 18f, 2.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 75f, 0.05f, 0.04f, 36f, 0f, 0.1f },
                    { new Guid("1dd791d5-3719-44e8-b534-1574f07ed78c"), 30f, 320f, 50f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 2f, new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), 1.5f, 250f, 15f, 1.5f, 600f, 3f, 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 200f, 0.1f, 0.1f, 5f, 0f, 0.7f },
                    { new Guid("20b85987-83e6-4592-a455-d61868d63ea7"), 40f, 30f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2.5f, new Guid("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), 1f, 250f, 2f, 0.1f, 25f, 1f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 450f, 0.07f, 0.08f, 25f, 0f, 0.4f },
                    { new Guid("21bb5ee3-d8f1-4e4e-ade9-3b25fed1c53a"), 105f, 13f, 2.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1f, new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), 0.8f, 176f, 1.5f, 0f, 65f, 1.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.6f, 0.04f, 0.07f, 45f, 0f, 0.15f },
                    { new Guid("2486eee5-5dae-4875-82fb-fe2706ea1a6d"), 10f, 112f, 24f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.8f, 1.8f, new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), 0.4f, 86f, 2.6f, 0.2f, 1f, 0.4f, 0.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.14f, 0.02f, 0f, 0f, 0.1f },
                    { new Guid("27b102b1-96cb-4218-b3ee-4f9889833f51"), 25f, 52f, 12f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.7f, 6.5f, new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), 0.7f, 151f, 1.2f, 0f, 1f, 4.4f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33f, 0.03f, 0.04f, 26.2f, 0f, 0.9f },
                    { new Guid("27d61a22-3e41-4e8b-a758-89a193293658"), 40f, 65f, 16f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 3.5f, new Guid("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), 0.1f, 181f, 1.3f, 0f, 1f, 13f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.04f, 53.2f, 0f, 0.2f },
                    { new Guid("28d19ab8-1caf-4701-a56c-933fea085f14"), 20f, 190f, 30f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 0.5f, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), 1f, 100f, 5f, 2f, 450f, 0.5f, 4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.04f, 0.05f, 2f, 0f, 0.1f },
                    { new Guid("2951adc0-ba02-4e5f-8bf4-99508f2e6caa"), 30f, 320f, 55f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 1.5f, new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), 1.5f, 200f, 10f, 4f, 500f, 1f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.06f, 1f, 0f, 0.3f },
                    { new Guid("29b15c76-2592-4d2d-a62a-0a2deb4de84b"), 50f, 320f, 48f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9f, 3f, new Guid("8382816f-1beb-4804-9698-3b486798b20a"), 1f, 250f, 15f, 3f, 450f, 4f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.2f, 0.1f, 0f, 0f, 0.5f },
                    { new Guid("2b09523a-773c-490e-8cc8-07610413fb5a"), 39f, 32f, 6.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2f, new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), 0.9f, 391f, 2f, 0f, 36f, 0.5f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 442f, 0.05f, 0.05f, 48.5f, 0f, 0.6f },
                    { new Guid("2c352db6-2fa2-4889-97fc-3d3d095835c4"), 18f, 20f, 4.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.2f, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), 0.3f, 170f, 0.8f, 0f, 1f, 2.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.02f, 0.02f, 10f, 0f, 0.01f },
                    { new Guid("2e01058f-938c-410b-96c3-aa3ca7e69c9f"), 9f, 57f, 15f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 3.1f, new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), 0.2f, 116f, 0.4f, 0f, 1f, 10f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25f, 0.02f, 0.03f, 4.3f, 0f, 0.1f },
                    { new Guid("2e214983-dcde-4c3d-a0c9-58c580731a93"), 30f, 150f, 20f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 0.5f, new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), 1.5f, 200f, 10f, 2f, 500f, 0.5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("2f4c3619-c7f1-4a87-ab7a-f1c6c040f7be"), 130f, 20f, 3.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.5f, new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), 1f, 140f, 1.8f, 0.1f, 40f, 1f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 800f, 0.05f, 0.07f, 40f, 0f, 0.4f },
                    { new Guid("2fb8ef51-72d6-4974-af3b-087f176eb777"), 16f, 258f, 60f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 13f, new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), 0.7f, 533f, 5f, 0f, 4f, 2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("320073b5-a00a-4b81-8ff5-92a9527f6f9a"), 81f, 33f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 3.2f, new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), 0.8f, 299f, 1.9f, 0f, 7f, 1.5f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.36f, 0.02f, 0.04f, 21f, 0f, 0.27f },
                    { new Guid("3248928d-67ef-4948-9f2c-738da0322b33"), 120f, 61f, 4.8f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.3f, 0f, new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), 0.1f, 150f, 3.3f, 0.6f, 44f, 4.8f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47f, 0.02f, 0.18f, 0f, 2f, 0.1f },
                    { new Guid("3277d3fc-e67c-4612-9464-21398f68461b"), 15f, 150f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 3f, new Guid("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), 0.6f, 350f, 4f, 0.1f, 350f, 3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0.06f, 0.05f, 10f, 0f, 0.1f },
                    { new Guid("328d5fd0-ece9-4918-9e6b-e6be8ee65c48"), 11f, 45f, 10.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.2f, new Guid("de097440-db5c-4d91-bd55-76618d70599d"), 0.1f, 200f, 0.7f, 0f, 1f, 8.3f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.1f, 0.02f, 50f, 0f, 0.02f },
                    { new Guid("33e24403-c75e-4c41-a8d2-684b45fa322f"), 30f, 250f, 40f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 1.5f, new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), 1.2f, 220f, 12f, 0.5f, 400f, 2f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.08f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("33ebceaa-92cd-48c4-909a-cc7c236237cd"), 125f, 42f, 5f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), 0f, 150f, 3.4f, 0.6f, 44f, 5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.04f, 0.18f, 0f, 0.02f, 0.03f },
                    { new Guid("35aa7ce9-3f40-4a11-8621-097c0abbc604"), 20f, 250f, 0f, 90f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 0f, new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), 2.5f, 280f, 26f, 6f, 75f, 0f, 9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.2f, 0f, 7f, 0.5f },
                    { new Guid("368503df-855f-41db-ac76-726a74f184f9"), 20f, 220f, 40f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), 1.2f, 100f, 7f, 2f, 300f, 5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.05f, 0.03f, 0f, 0f, 0.2f },
                    { new Guid("36af4ab2-1dbc-4864-a179-4febf0fbf9cd"), 30f, 180f, 10f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 2.5f, new Guid("85e621ed-0e0c-4d20-8891-51d311cea4a3"), 2f, 250f, 20f, 1.5f, 400f, 3f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40f, 0.1f, 0.1f, 4f, 0f, 0.5f },
                    { new Guid("39c45c0f-68ac-4f03-ae46-6c381380587e"), 35f, 280f, 40f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 1.5f, new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), 2.5f, 320f, 18f, 3f, 850f, 2f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.08f, 0.1f, 0.07f, 1f, 0f, 0.3f },
                    { new Guid("3aee5430-d550-47a1-9a98-0552fa08ce6f"), 80f, 280f, 35f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2f, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), 2.5f, 400f, 15f, 4f, 850f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.2f, 4f, 0f, 0.5f },
                    { new Guid("3b8f2305-ac82-4924-92af-2df4f0ea7d63"), 30f, 86f, 20f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3f, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), 0.6f, 337f, 1.6f, 0f, 55f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.96f, 0.08f, 0.03f, 2.4f, 0f, 0.26f },
                    { new Guid("3c7f9711-8216-442b-b7d1-242ca91c193e"), 20f, 190f, 38f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 1.5f, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), 1f, 100f, 5f, 0.5f, 300f, 4f, 1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.06f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("3cb5c580-ed13-4ddf-95db-c01e09aa10c6"), 21f, 70f, 19f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 3.6f, new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), 0.8f, 193f, 0.6f, 0.1f, 12f, 13f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 60f, 0.01f, 0.02f, 14.7f, 0f, 0.1f },
                    { new Guid("3cd0d60b-4f1a-470d-b245-9b4f6c2a31f4"), 10f, 60f, 13f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 3f, new Guid("86d88717-df08-4de6-b86d-870210864b46"), 0.3f, 150f, 1.2f, 0.1f, 4f, 8f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.04f, 0.05f, 3f, 0f, 0.3f },
                    { new Guid("3cf069aa-d3c4-4198-a1dc-516239a36328"), 55f, 70f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 2f, new Guid("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), 1f, 450f, 3f, 0.1f, 250f, 1f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 700f, 0.05f, 0.1f, 45f, 0f, 1.2f },
                    { new Guid("3fe67f5d-268f-497c-bf04-c67dc7a47193"), 3f, 20f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), 0.1f, 15f, 0.1f, 0f, 2f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.02f, 20f, 0f, 0f },
                    { new Guid("424100d2-1c3d-4e2f-9904-424766ed6dea"), 20f, 130f, 20f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.5f, 0.5f, new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), 1.2f, 150f, 8f, 2f, 300f, 0.5f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("42de5f87-278e-42f1-9d01-dad41f2baba7"), 80f, 65f, 2.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.5f, 1f, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), 1f, 150f, 7f, 0.5f, 15f, 0.5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.02f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("4347846f-b23a-4e66-803f-83762a188586"), 110f, 60f, 5f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 0f, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), 0f, 141f, 3.5f, 1f, 36f, 4f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.04f, 0.14f, 0f, 0.02f, 0f },
                    { new Guid("43507270-570b-4ee2-8e5a-7b03c3def7d3"), 7f, 30f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.4f, new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), 0.2f, 112f, 0.6f, 0f, 1f, 6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.57f, 0.03f, 0.02f, 8.1f, 0f, 0.05f },
                    { new Guid("4aae9ca9-c320-46ad-ae8c-4acfbd23c86e"), 40f, 25f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2f, new Guid("4edcae53-7e30-42bb-8526-7686355f2268"), 1f, 300f, 2f, 0.1f, 150f, 1f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500f, 0.05f, 0.06f, 30f, 0f, 0.5f },
                    { new Guid("4ac9e8df-878c-4889-88fd-2880d33e23fe"), 30f, 240f, 38f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 1f, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), 1.2f, 120f, 9f, 2.5f, 350f, 3f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("4c19ac52-7b4a-46a7-a59c-0027c86ca847"), 40f, 280f, 70f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 1.5f, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), 1.2f, 250f, 25f, 2.5f, 850f, 1f, 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.1f, 3f, 0f, 0.2f },
                    { new Guid("4ed31a30-1255-4a9b-89b6-4e23420efde7"), 30f, 350f, 40f, 80f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 2f, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), 2f, 200f, 15f, 5f, 600f, 4f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.1f, 0.08f, 2f, 0f, 0.3f },
                    { new Guid("53657bd9-6c16-47de-8d54-33d8fbc93e18"), 47f, 34f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.6f, new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), 0.7f, 316f, 2.8f, 0f, 33f, 1.7f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 623f, 0.07f, 0.12f, 89.2f, 0f, 0.8f },
                    { new Guid("53ad4175-0f98-4bb6-9b71-14597daa65b5"), 25f, 81f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 5f, new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), 1.5f, 244f, 5f, 0.1f, 5f, 5.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 765f, 0.27f, 0.15f, 40f, 0f, 0.1f },
                    { new Guid("5669e712-1cba-400d-860b-7485841fede9"), 18f, 270f, 0f, 82f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19f, 0f, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), 2.7f, 300f, 25f, 7.4f, 62f, 0f, 11.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.18f, 0f, 8f, 0.5f },
                    { new Guid("57c1d04b-0828-4308-891d-c786cacde114"), 15f, 200f, 40f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 1f, new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), 0.5f, 120f, 5f, 0.1f, 250f, 1f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.1f, 0f, 0f, 0.1f },
                    { new Guid("58dd96df-d450-4787-ac02-19f9c1c965ef"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("59359ac0-06f3-4076-8a6d-3c495ae0ff47"), 27f, 18f, 4.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.6f, new Guid("845454d0-967a-4e48-aef3-bd8458775500"), 0.3f, 233f, 0.6f, 0f, 9f, 2.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.03f, 14.8f, 0f, 0.2f },
                    { new Guid("5de20e8d-2eff-431b-94d6-fcf57267ad2a"), 5f, 66f, 16.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 1.3f, new Guid("7b8500af-d730-4138-9617-cba352faed4a"), 0.3f, 171f, 0.8f, 0f, 1f, 15.2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.01f, 0.07f, 71.5f, 0f, 0.1f },
                    { new Guid("5dfb241a-8da1-4355-98b4-eabbf7e22434"), 18f, 68f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.6f, 5.4f, new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), 0.3f, 417f, 2.6f, 0.3f, 2f, 9f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.21f, 0.07f, 0.04f, 228.3f, 0f, 0.73f },
                    { new Guid("607cc425-ced7-4cd1-81bf-2734bc3446de"), 12f, 165f, 0f, 88f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.6f, 0f, new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), 1.2f, 223f, 31f, 3.8f, 82f, 0f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.07f, 0.13f, 0f, 0.02f, 0.3f },
                    { new Guid("61b229ba-33e2-48f7-bda6-1399ceb499a2"), 11f, 165f, 0f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.6f, 0f, new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), 0.9f, 256f, 31f, 1f, 74f, 0f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.06f, 0.08f, 0f, 0f, 0.3f },
                    { new Guid("63add0d9-b7b3-4b11-9d8f-c8209e12b785"), 50f, 280f, 45f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 2f, new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), 2f, 300f, 10f, 4f, 500f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.08f, 3f, 0f, 0.3f },
                    { new Guid("6529b7a2-2056-4c0b-95ca-dfc816b497c0"), 277f, 172f, 8.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9f, 6f, new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), 2.5f, 620f, 18f, 1.3f, 15f, 2f, 7.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9f, 0.16f, 0.18f, 6f, 0f, 0.9f },
                    { new Guid("66699b4f-f81b-4750-89ed-551f02865fc6"), 40f, 180f, 7f, 80f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 0f, new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), 1f, 180f, 15f, 7f, 850f, 1f, 9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("668557e7-c113-41da-9493-064be37b40bf"), 3f, 27f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.5f, new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), 0.4f, 359f, 2.2f, 0f, 3f, 1f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.11f, 0.1f, 2.1f, 0f, 0.01f },
                    { new Guid("67195561-db94-4f0b-a77c-9ae9573fe06d"), 30f, 270f, 40f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 1.5f, new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), 1.5f, 200f, 15f, 0.5f, 450f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("6c79f5d0-5d76-4cff-8983-79876c99d66b"), 40f, 110f, 15f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 3f, new Guid("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), 0.5f, 230f, 10f, 0.2f, 300f, 5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 850f, 0.05f, 0.07f, 15f, 0f, 0.5f },
                    { new Guid("6e7d8831-dfbe-4f42-a07d-f8d17a1ec0fa"), 20f, 80f, 5f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 1.5f, new Guid("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), 0.7f, 180f, 8f, 0.3f, 250f, 1f, 1.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.07f, 0.05f, 8f, 0f, 0.4f },
                    { new Guid("6e7f8d90-9bf3-4fb7-b388-c7641f725fbe"), 11f, 65f, 17f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.8f, new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), 0.2f, 168f, 0.5f, 0.1f, 1f, 14f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.54f, 0.03f, 0.04f, 36.4f, 0f, 0.9f },
                    { new Guid("6ee0e52c-48f5-4566-b281-1fa2d0f9eb62"), 60f, 70f, 10f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.5f, 0f, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), 0.2f, 80f, 1.5f, 2f, 40f, 8f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.04f, 0.06f, 0f, 0f, 0.1f },
                    { new Guid("6fabfcf2-fca1-4d28-b22b-8a72a36e11ce"), 40f, 40f, 4f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 1.5f, new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), 1.5f, 250f, 4f, 0.5f, 300f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 300f, 0.05f, 0.1f, 5f, 0f, 0.5f },
                    { new Guid("7003a7da-d5be-43bd-a6e0-ed5979bad996"), 30f, 50f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2f, new Guid("00bc33fe-4cd5-47df-bd94-15ac9f93648c"), 0.8f, 200f, 2f, 0.1f, 250f, 3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 600f, 0.06f, 0.05f, 20f, 0f, 1f },
                    { new Guid("70ae194f-11f9-4770-8d37-bdfb63a03d69"), 10f, 130f, 28f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 0.4f, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), 0.2f, 35f, 2.7f, 0.1f, 1f, 0.1f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.01f, 0f, 0f, 0f },
                    { new Guid("70c9d2fc-c7ae-4515-911d-a2ccd374e711"), 114f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.1f, new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), 2.1f, 554f, 2.3f, 0f, 30f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8100f, 0.08f, 0.16f, 51.9f, 0f, 1.9f },
                    { new Guid("70ff70bb-7e62-4065-b7d0-a3c26e003a28"), 25f, 81f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 5f, new Guid("7cd76708-7312-445e-a392-14f0e806a786"), 1.5f, 244f, 5f, 0.1f, 5f, 5.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 765f, 0.27f, 0.15f, 40f, 0f, 0.1f },
                    { new Guid("7208f70b-3b16-4d64-9e43-c927bc095355"), 37f, 31f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 2.7f, new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), 1f, 211f, 1.8f, 0f, 6f, 3.3f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.69f, 0.02f, 0.1f, 12.2f, 0f, 0.41f },
                    { new Guid("7424a126-741b-4072-afd4-0714e53b997b"), 500f, 270f, 0f, 152f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 0f, new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), 2.8f, 684f, 58f, 0.3f, 702f, 0f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.12f, 0.1f, 0f, 0.6f, 0.2f },
                    { new Guid("76627095-8bd3-49aa-a63c-b70efa2e639e"), 10f, 160f, 35f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 0.5f, new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), 0.5f, 50f, 3f, 0.5f, 300f, 1f, 1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.01f, 0.01f, 0f, 0f, 0.1f },
                    { new Guid("767f211b-5113-45f2-b6e8-8a152c72e4ed"), 20f, 120f, 10f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 1.5f, new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), 2f, 250f, 10f, 3f, 500f, 2f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.1f, 0.1f, 5f, 0f, 0.5f },
                    { new Guid("789ec445-2334-4189-9055-08a8ba54c131"), 40f, 380f, 60f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 3f, new Guid("2405ffc3-524e-4331-9e68-47a411d7b9b8"), 1f, 150f, 16f, 1.5f, 500f, 3f, 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.08f, 5f, 0f, 0.4f },
                    { new Guid("794c5761-4232-4309-8ff0-f4a596115bdd"), 5f, 90f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.6f, new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), 0.3f, 358f, 1.1f, 0.1f, 1f, 12f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("7bf358d0-aa6c-4477-b086-4213b0678b5a"), 15f, 420f, 0f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35f, 0f, new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), 1f, 200f, 30f, 14.6f, 800f, 0f, 24.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.09f, 0f, 0f, 0.3f },
                    { new Guid("7c2b800f-b3c0-411a-84d1-073eda64b983"), 25f, 70f, 6f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 1.5f, new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), 1f, 250f, 8f, 0.5f, 500f, 3f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.1f, 10f, 0f, 0.3f },
                    { new Guid("7c773b80-3507-4710-ab5b-a96a9ab763c0"), 34f, 61f, 15f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 3f, new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), 0.3f, 312f, 1.1f, 0f, 3f, 9f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 87f, 0.02f, 0.05f, 92.7f, 0f, 1.5f },
                    { new Guid("7e9f7666-4f76-4424-8d99-ced09b83c912"), 23f, 40f, 9.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.7f, new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), 0.2f, 146f, 1.1f, 0f, 4f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.05f, 0.02f, 7.4f, 0f, 0.02f },
                    { new Guid("7eb27b71-0c82-415f-9700-b910f2f63167"), 40f, 30f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 3f, new Guid("2ee163f7-4463-44ec-b9e2-8a409c112db4"), 0.8f, 300f, 2f, 0.1f, 150f, 2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500f, 0.04f, 0.05f, 20f, 0f, 0.5f },
                    { new Guid("7fcaf04c-5c93-4b3e-abb7-0f2accfd604c"), 80f, 260f, 40f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 1.5f, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), 2f, 350f, 12f, 4f, 900f, 2f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("7fea664a-9a2d-4e66-8977-620756ca6362"), 20f, 250f, 38f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 1f, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), 1.2f, 100f, 10f, 2f, 300f, 4f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("7fede430-3732-402c-8e3b-5e0c8a5f58dc"), 10f, 30f, 7.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), 0.1f, 40f, 0f, 0f, 3f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.01f, 0.01f, 20f, 0f, 0f },
                    { new Guid("806d7898-e2f8-4902-8943-e2df0245b411"), 11f, 77f, 17f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 2.2f, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), 0.8f, 425f, 2f, 0f, 6f, 0.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.11f, 0.03f, 19.7f, 0f, 0.01f },
                    { new Guid("837dac8a-b76c-4382-a578-f5d673c8bd69"), 30f, 120f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 3f, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), 1.2f, 200f, 4f, 1f, 50f, 3f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.03f, 0.02f, 0f, 0f, 0f },
                    { new Guid("83a8113c-bb8d-49d1-94fb-ff52ffb05455"), 357f, 150f, 12f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 3f, new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), 2.8f, 240f, 10f, 1.1f, 15f, 6f, 5.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 0.08f, 0.16f, 5f, 0f, 0.5f },
                    { new Guid("84e0bca0-aab0-480c-b968-3181fbb03823"), 110f, 97f, 3.6f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 0f, new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), 0.1f, 141f, 10f, 0.2f, 36f, 3.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 0.04f, 0.14f, 0f, 0f, 0f },
                    { new Guid("856ef789-94b6-4936-8739-b8bca6c00e48"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("864f6787-3fb5-4db4-ae35-4379a68ea23d"), 24f, 20f, 3.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 2.1f, new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), 0.5f, 202f, 2.2f, 0f, 2f, 1.9f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 756f, 0.08f, 0.14f, 5.6f, 0f, 1.1f },
                    { new Guid("88120e2a-d8bf-4b96-a49e-00eaf334baca"), 25f, 260f, 40f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 1.5f, new Guid("7167f942-dc89-4f29-8022-588373aef45e"), 0.9f, 220f, 14f, 0.5f, 400f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 80f, 0.05f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("8907d37f-efa1-455d-a824-014baf5b7291"), 12f, 190f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 0f, new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), 1.1f, 302f, 20f, 4.3f, 60f, 0f, 8.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.33f, 0f, 440f, 0.5f },
                    { new Guid("8c19d0a5-b282-49be-9a5a-88eac7d83e2b"), 20f, 290f, 2.3f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25f, 0f, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), 1.2f, 200f, 12f, 9f, 1020f, 1f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.3f, 0.12f, 0f, 0f, 0.4f },
                    { new Guid("8c30524d-8e3d-4a26-a3ba-f4a4fcccc211"), 10f, 83f, 19f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.2f, 4f, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), 0.3f, 236f, 1.7f, 0.1f, 3f, 14f, 1.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.07f, 0.06f, 10.2f, 0f, 0.6f },
                    { new Guid("8ce184cd-f97e-45fa-85cc-8d5b57dbcade"), 30f, 280f, 40f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 1.5f, new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), 1.5f, 250f, 16f, 0.5f, 500f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150f, 0.1f, 0.1f, 5f, 0f, 0.4f },
                    { new Guid("8fd06704-b747-4306-a2d1-dd515b04249e"), 120f, 80f, 12f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 0.7f, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), 0.6f, 200f, 3.2f, 1f, 50f, 9f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.1f, 2f, 0.1f, 0.1f },
                    { new Guid("8fee7c21-a9ec-4b09-8acf-48c3f253b18a"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("90697433-3415-4712-859e-dc73c6a78b2f"), 25f, 180f, 5f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 0f, new Guid("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), 1.5f, 300f, 20f, 1.5f, 350f, 3f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 80f, 0.1f, 0.07f, 2f, 0.5f, 0.3f },
                    { new Guid("91617ca6-36ec-4261-8843-d2ae7f1a7a2f"), 24f, 19f, 3.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.1f, new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), 0.3f, 250f, 0.7f, 0f, 11f, 2.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.02f, 2.4f, 0f, 0f },
                    { new Guid("92e6dec2-334c-495b-9aea-34373a2b8765"), 40f, 25f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.5f, new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), 0.6f, 120f, 1.2f, 0f, 750f, 2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.01f, 0.02f, 15f, 0f, 0.02f },
                    { new Guid("9360b9e6-7684-4c31-b73c-c7d34eb426bc"), 16f, 43f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.8f, new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), 0.8f, 325f, 1.6f, 0f, 78f, 6.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33f, 0.05f, 0.03f, 4.9f, 0f, 0.1f },
                    { new Guid("94a8017d-3120-4404-ad15-d343b6ce1832"), 40f, 45f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 3f, new Guid("eec3d874-6331-4e33-bbe6-bf0cc4335b29"), 1f, 250f, 1.5f, 0.1f, 50f, 4f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 700f, 0.05f, 0.06f, 25f, 0f, 1f },
                    { new Guid("96220af6-aadc-4335-8db2-dc694e44cc9c"), 20f, 130f, 20f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.5f, 0.5f, new Guid("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), 1f, 200f, 7f, 1f, 350f, 0.5f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.06f, 0.07f, 2f, 0f, 0.3f },
                    { new Guid("96b0df94-749b-4c8c-a343-77ce69abe6bf"), 2f, 2f, 0f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), 0f, 49f, 0.2f, 0f, 5f, 0f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, 0f, 0f, 0f, 0f },
                    { new Guid("975f52f6-a279-4e6a-b775-72fb7c06ad23"), 22f, 82f, 20f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.3f, new Guid("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), 0.3f, 42f, 0.9f, 0f, 0f, 14f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.05f, 0.05f, 20f, 0f, 0.1f },
                    { new Guid("98002b05-400c-4c13-bee5-2518a10a590b"), 40f, 300f, 35f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), 2f, 250f, 18f, 5f, 800f, 3f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.08f, 3f, 0f, 0.3f },
                    { new Guid("987cddf2-7871-4425-8e5e-f2a3d1dd01ab"), 16f, 32f, 7.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2f, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), 0.4f, 153f, 0.7f, 0f, 1f, 4.9f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 0.02f, 0.05f, 58.8f, 0f, 0.3f },
                    { new Guid("9c047a20-d9d2-4038-bf9b-4ed11f09667b"), 11f, 240f, 0f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19f, 0f, new Guid("51061170-597d-4289-a021-1e7dde88331f"), 2.7f, 205f, 19f, 8.5f, 63f, 0f, 12.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.06f, 0.15f, 0.23f, 0f, 0.02f, 0.3f },
                    { new Guid("9e7f8ca7-0b0d-4b8b-849e-dde1b5568900"), 7f, 143f, 0f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.5f, 0f, new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), 0.9f, 370f, 26f, 5.2f, 65f, 0f, 8.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.6f, 0.15f, 0f, 0f, 0.2f },
                    { new Guid("9f43cf0c-484a-42ed-9dfc-6f600b684f08"), 15f, 195f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), 1.4f, 250f, 19f, 2.5f, 60f, 0f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.06f, 0.15f, 0f, 0f, 0.7f },
                    { new Guid("a04bb017-2744-4ac5-a839-1b244d505aa0"), 50f, 290f, 30f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), 2f, 450f, 20f, 4f, 1200f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.2f, 2f, 0f, 0.4f },
                    { new Guid("a0a0037d-c6a9-458b-b53f-16a2723345d4"), 20f, 30f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1f, new Guid("2ae82bfd-34db-4928-bfee-b60f4aec4460"), 0.5f, 200f, 1.5f, 0.1f, 250f, 3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500f, 0.05f, 0.03f, 15f, 0f, 1f },
                    { new Guid("a0d41b7d-98ae-4ccd-aef9-dfaef20f5220"), 15f, 250f, 8f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 0f, new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), 1.2f, 330f, 20f, 6.5f, 530f, 5f, 10.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45f, 0.8f, 0.2f, 0f, 0f, 0.3f },
                    { new Guid("a14da258-6d68-44b2-bb5c-da9fa82f7ac5"), 55f, 23f, 4.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.6f, new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), 1.8f, 500f, 2.5f, 0f, 15f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8890f, 0.05f, 0.18f, 37.5f, 0f, 0.4f },
                    { new Guid("a1dec765-f62b-4aaf-9692-b8eea2df752e"), 12f, 206f, 0f, 63f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), 0.5f, 363f, 22f, 3.1f, 59f, 0f, 9.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.38f, 0f, 570f, 0.4f },
                    { new Guid("a4f0e449-5dd4-4c8e-b448-c84c01858801"), 15f, 210f, 6f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 0f, new Guid("43d635e2-6f0c-4385-83d8-fedfd479d356"), 1f, 220f, 25f, 1f, 340f, 3f, 2.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0.08f, 0.07f, 0f, 0f, 0.4f },
                    { new Guid("a5048405-4cfd-43e8-8ccd-1b6137ebfec2"), 70f, 35f, 5.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 0.5f, new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), 2.3f, 1040f, 6f, 0.6f, 233f, 0.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 260f, 0.06f, 0.32f, 6f, 0f, 1f },
                    { new Guid("a5741a71-860a-4b0b-86dd-be6fc2e28e64"), 6f, 39f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.5f, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), 0.3f, 190f, 0.9f, 0f, 0f, 8.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 326f, 0.02f, 0.05f, 6.6f, 0f, 0.1f },
                    { new Guid("a5e7219e-3361-4c36-b68a-a6658a7571c0"), 70f, 99f, 0f, 189f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.1f, 0f, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), 0.3f, 259f, 24f, 0.2f, 111f, 0f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.02f, 0.11f, 0f, 0f, 0.6f },
                    { new Guid("a6a51ea5-9083-4945-ba51-018f70bf8366"), 30f, 25f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.5f, new Guid("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), 0.8f, 250f, 1.3f, 0.1f, 300f, 2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 600f, 0.06f, 0.05f, 20f, 0f, 1f },
                    { new Guid("a71b992e-16f1-417a-a814-ff97cd733533"), 50f, 290f, 45f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 2f, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), 2f, 300f, 15f, 4f, 1200f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.08f, 0.1f, 4f, 0f, 0.2f },
                    { new Guid("a8f3d68b-36f5-41b3-81d7-8d8203ebf092"), 54f, 375f, 68f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 10f, new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), 4.7f, 362f, 13f, 1.2f, 2f, 1f, 5.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.76f, 0.14f, 0f, 0f, 0.42f },
                    { new Guid("aaf32cba-82e2-47e6-ac7d-0b9136ddb8d0"), 20f, 43f, 11f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 0.7f, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), 0.3f, 257f, 0.5f, 0f, 3f, 8.3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.95f, 0.03f, 0.04f, 61f, 0f, 0f },
                    { new Guid("adf946a0-b79a-4f08-92df-a9facfc19aa1"), 9f, 206f, 0f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("faf19891-525a-4308-9222-992e83de7ce7"), 0.5f, 363f, 22f, 3.1f, 59f, 0f, 7.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.2f, 0.4f, 0f, 0.38f, 0.5f },
                    { new Guid("adfb1320-1cb8-47b2-a248-c22638def933"), 201f, 80f, 2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.5f, 1.2f, new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), 1.6f, 121f, 8f, 0.7f, 7f, 0.7f, 2.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.03f, 0f, 0f, 0.02f },
                    { new Guid("aecc5aff-4c79-473b-a12f-c3281b5c904d"), 22f, 280f, 45f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 3f, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), 2.4f, 115f, 10f, 0.5f, 491f, 6f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.2f, 0.12f, 0f, 0f, 0.1f },
                    { new Guid("b0ce11d7-9b23-488d-8d49-89ce199c01e1"), 70f, 99f, 0f, 189f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.1f, 0f, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), 0.4f, 264f, 24f, 0.1f, 111f, 0f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.1f, 0f, 0f, 1.3f },
                    { new Guid("b1f410fd-99ca-4e65-a6b0-b4c47f1b84c3"), 35f, 40f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2f, new Guid("0292d477-d63b-4904-a83b-2cd8cac39c14"), 0.5f, 330f, 1.5f, 0.1f, 250f, 3f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 600f, 0.05f, 0.08f, 45f, 0f, 0.7f },
                    { new Guid("b44b4f2e-6cd4-4be6-8419-aca5187d4972"), 30f, 280f, 15f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 5f, new Guid("a364353c-d589-4a94-9c3b-3038113ea249"), 2.5f, 350f, 25f, 2.5f, 350f, 5f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150f, 0.1f, 0.1f, 25f, 0f, 1f },
                    { new Guid("b51e2341-cf39-4b70-8784-35482259ab43"), 10f, 110f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.9f, 1.8f, new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), 0.4f, 43f, 2.6f, 0.2f, 1f, 0.4f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.16f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("bd1e6b22-ce38-436f-9b1a-605f94514a46"), 45f, 31f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.8f, new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), 0.6f, 216f, 1.4f, 0f, 27f, 3.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 993f, 0.05f, 0.06f, 36.6f, 0f, 0.1f },
                    { new Guid("be57a29b-2a47-4cfa-9ecc-7c6cb9d1aafc"), 10f, 184f, 0f, 51f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 0f, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), 0.9f, 252f, 30f, 0.3f, 37f, 0f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.07f, 0.18f, 0f, 0.8f, 0.2f },
                    { new Guid("c03c6a4a-b8c1-4cc6-a26e-2fe5c5e73225"), 43f, 112f, 26f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 4.1f, new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), 0.6f, 484f, 1.5f, 0f, 13f, 0.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47f, 0.09f, 0.03f, 4.5f, 0f, 0.1f },
                    { new Guid("c08782bc-5736-41c8-86bf-bf507cacec70"), 40f, 290f, 40f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 1.5f, new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), 3f, 350f, 18f, 4f, 900f, 2f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.08f, 1f, 0f, 0.2f },
                    { new Guid("c121033c-614a-4f1a-a76a-82899fc06ea1"), 37f, 53f, 13f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.8f, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), 0.1f, 166f, 0.8f, 0f, 2f, 10.5f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.34f, 0.06f, 0.03f, 26.7f, 0f, 0.2f },
                    { new Guid("c4e05d87-9a22-47d8-a9ed-32fd0f924b5c"), 40f, 250f, 45f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1.5f, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), 1.5f, 250f, 8f, 2f, 700f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.08f, 0.06f, 1f, 0f, 0.2f },
                    { new Guid("c4f20c30-8cbe-47fa-bb5d-a7497b9862a4"), 4f, 110f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.9f, new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), 0.1f, 15f, 1.7f, 0.1f, 10f, 0f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.01f, 0.01f, 0f, 0f, 0f },
                    { new Guid("c5566ddc-79f0-4608-bd67-d88c9a92f746"), 10f, 18f, 3.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.2f, new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), 0.3f, 237f, 0.9f, 0f, 5f, 2.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.85f, 0.04f, 0.02f, 13.7f, 0f, 0.5f },
                    { new Guid("c673fb35-da68-48cb-af57-34fa618be769"), 20f, 180f, 35f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 0.5f, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), 0.4f, 100f, 3.5f, 1f, 250f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.04f, 0.02f, 0f, 0f, 0.05f },
                    { new Guid("c682e666-a354-49b9-9b3f-3e83f3cac1ee"), 40f, 180f, 35f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 6f, new Guid("2146faae-2e7c-4460-8d81-38f5d313012c"), 1f, 260f, 8f, 0.2f, 150f, 1f, 1.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.05f, 1f, 0f, 0.3f },
                    { new Guid("c7c0ed71-144b-47d1-8b52-2147fdde45ac"), 30f, 350f, 40f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 1.5f, new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), 2.5f, 320f, 20f, 6f, 650f, 2f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.15f, 0.08f, 2f, 0f, 0.4f },
                    { new Guid("ca454aed-6241-4df4-810c-49b8286b26cf"), 14f, 354f, 15f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33f, 9f, new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), 2.4f, 356f, 3.3f, 29.7f, 20f, 6.2f, 3.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.02f, 3.3f, 0f, 0.3f },
                    { new Guid("caa83bcf-6acb-49f3-92d3-98753a4443e6"), 10f, 170f, 35f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 0.5f, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), 0.4f, 100f, 2f, 1f, 250f, 0.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.02f, 0.02f, 0f, 0f, 0.1f },
                    { new Guid("cb0205f1-0cf0-451b-9214-3a44db1cd5de"), 5f, 35f, 6.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2.5f, new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), 0.3f, 300f, 2.2f, 0f, 3f, 0f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.06f, 0.07f, 0.5f, 0.02f, 0.1f },
                    { new Guid("cd0a08e3-80d3-49b4-9ced-b113e9fe4d0e"), 50f, 70f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.5f, 3f, new Guid("a988cc73-072e-4af1-9b53-55fbf0f4fe79"), 1.2f, 250f, 2.5f, 0.5f, 200f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500f, 0.05f, 0.07f, 15f, 0f, 2f },
                    { new Guid("cebbdc38-0a0b-4d13-8140-17a2215e698c"), 21f, 26f, 6.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.5f, new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), 0.8f, 340f, 1f, 0f, 1f, 2.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8533f, 0.05f, 0.11f, 9f, 0f, 0.3f },
                    { new Guid("d093b153-1c2f-4cc5-a79c-eb4244cc1cb7"), 35f, 30f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2f, new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), 0.5f, 250f, 1.5f, 0.1f, 80f, 2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 650f, 0.04f, 0.05f, 20f, 0f, 0.4f },
                    { new Guid("d093c027-be1a-452f-943c-b19020256e89"), 150f, 25f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.5f, new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), 1.6f, 296f, 2.5f, 0.1f, 50f, 1f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 740f, 0.07f, 0.09f, 55f, 0f, 1.2f },
                    { new Guid("d0ac6b99-efe9-49a8-ab95-01f9a7f2bb03"), 5f, 160f, 8.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 6.7f, new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), 0.3f, 360f, 2f, 0.1f, 1f, 0.7f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("d35730cb-0454-469e-9a2f-8b9b17a0907d"), 10f, 31f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.1f, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), 0.3f, 175f, 1f, 0f, 3f, 4.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.93f, 0.05f, 0.04f, 80f, 0f, 0.37f },
                    { new Guid("d364c3d9-abb7-40f7-897a-9ccf6b2df91a"), 15f, 125f, 20f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.5f, 0.5f, new Guid("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), 0.9f, 180f, 6f, 1f, 350f, 0.5f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0.05f, 0.07f, 1f, 0f, 0.2f },
                    { new Guid("d469cc32-5d88-48fc-ae99-94475800b608"), 9f, 65f, 16f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.3f, new Guid("a504d882-4f38-413e-bb28-fae1f2787150"), 0.3f, 42f, 1.2f, 0f, 1f, 13f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.05f, 10f, 0f, 0.1f },
                    { new Guid("d67eea67-e125-48a7-8f5b-0a4091c7209e"), 40f, 20f, 3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2f, new Guid("90a605b6-843d-4cc1-8fe7-a016c76ee29c"), 0.9f, 300f, 2.5f, 0.1f, 100f, 0.8f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500f, 0.04f, 0.05f, 30f, 0f, 0.5f },
                    { new Guid("da65c078-40ab-4652-b83f-a5201ba01f3f"), 56f, 155f, 1.1f, 373f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10.6f, 0f, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), 1.8f, 126f, 13f, 3.3f, 124f, 1.1f, 3.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.52f, 0.04f, 0.5f, 0f, 1.1f, 0.5f },
                    { new Guid("dbd12597-cd34-4847-a594-3e16ffeabf8d"), 30f, 280f, 5f, 120f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18f, 0f, new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), 2.5f, 300f, 22f, 8f, 800f, 3f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("dbe42763-4596-4f33-8772-8ac46d88c9b6"), 13f, 165f, 0f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.6f, 0f, new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), 1f, 256f, 31f, 1f, 70f, 0f, 2.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0.07f, 0.1f, 0f, 0f, 0.5f },
                    { new Guid("de482c35-cc42-4b1c-b56d-8d2c51092322"), 12f, 190f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 0f, new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), 1.1f, 302f, 20f, 4.3f, 60f, 0f, 8.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.33f, 0f, 440f, 0.5f },
                    { new Guid("de95e84d-ba19-46bb-9697-a4bd75162d99"), 40f, 330f, 40f, 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 2f, new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), 1.5f, 250f, 12f, 3f, 500f, 3f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 250f, 0.1f, 0.1f, 1f, 1f, 0.7f },
                    { new Guid("e183d898-40bc-41b0-8bec-5c04e5cac533"), 40f, 300f, 45f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 2f, new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), 1.2f, 200f, 14f, 1.5f, 500f, 4f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.1f, 2f, 0f, 0.5f },
                    { new Guid("e28bbe1b-9753-49ed-9a5a-902d5ab7b04b"), 33f, 41f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.8f, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), 0.3f, 320f, 0.9f, 0f, 69f, 4.7f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.69f, 0.04f, 0.03f, 5.9f, 0f, 0.66f },
                    { new Guid("e9d879e1-3fd7-4ebd-9598-0821860d2cdf"), 20f, 90f, 10f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 0.5f, new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), 0.7f, 150f, 6f, 0.5f, 500f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.03f, 0.1f, 1f, 0f, 0.1f },
                    { new Guid("ea0f53e9-f81f-4f4a-a5e7-86071b73a9bf"), 10f, 69f, 18f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.9f, new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), 0.4f, 191f, 0.7f, 0f, 2f, 16f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 92f, 0.03f, 0.04f, 10.8f, 0f, 0.1f },
                    { new Guid("eb9b5ef7-c6d7-487d-8443-07442db63cd3"), 21f, 92f, 3.1f, 233f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 0f, new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), 0.7f, 279f, 15.6f, 0.5f, 44f, 0f, 0.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.02f, 0.06f, 0f, 0f, 0.01f },
                    { new Guid("ed4499cf-1bda-4600-9633-28054fbe403e"), 77f, 20f, 3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2f, new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), 1.5f, 312f, 2.6f, 0f, 113f, 0.8f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6.3f, 0.04f, 0.09f, 55f, 0f, 1.5f },
                    { new Guid("edc62eb7-11b4-41b9-b3e8-5d55a93eb341"), 8f, 240f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0f, new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), 1.3f, 220f, 17f, 7f, 65f, 0f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.05f, 0f, 0f, 0.1f },
                    { new Guid("ee61718c-eed3-401d-8598-16356adbca55"), 350f, 270f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 3f, new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), 3f, 230f, 17f, 1f, 10f, 1f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 0.05f, 0.1f, 0.5f, 0f, 0.4f },
                    { new Guid("ef6863a2-7b54-4732-b636-b930e471d4f7"), 20f, 240f, 30f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 1f, new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), 1.5f, 150f, 8f, 3f, 480f, 1f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("f046fa8b-ec0c-486e-b90e-b48df6f4503f"), 12f, 65f, 16f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 6f, new Guid("3d19d971-88d0-4108-a335-24ac9e1dec50"), 0.3f, 42f, 0.5f, 0.1f, 10f, 14f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.05f, 5f, 0f, 0.1f },
                    { new Guid("f0a145bd-28ab-4899-9f77-4c7e30c0e72c"), 15f, 250f, 40f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 1.5f, new Guid("af036922-79f3-45a7-b562-a6279520c0e6"), 0.6f, 200f, 12f, 0.5f, 350f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.05f, 0.07f, 3f, 0f, 0.2f },
                    { new Guid("f0f6bec1-5ab0-4f39-97eb-a8049e5d928e"), 25f, 33f, 2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.8f, 0.5f, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), 0.7f, 118f, 3.3f, 0.2f, 51f, 1f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.03f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("f1b15467-a8ab-46b1-bd50-1890281b3a4b"), 30f, 250f, 5f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 0.5f, new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), 2f, 400f, 25f, 9f, 900f, 2f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("f2217bf4-1ac3-4ecc-b487-4de0b483e2ce"), 15f, 100f, 8f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 1f, new Guid("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), 1f, 200f, 6f, 0.5f, 300f, 1.5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.05f, 0.06f, 4f, 0f, 0.3f },
                    { new Guid("f29f2f80-313e-4901-b245-7b79428502a7"), 30f, 86f, 20f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3f, new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), 0.6f, 337f, 1.6f, 0f, 55f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.96f, 0.08f, 0.03f, 2.4f, 0f, 0f },
                    { new Guid("f2c2c11f-231d-42b2-8851-e56831ab4039"), 15f, 35f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 1.5f, new Guid("827829bf-71cd-4865-80af-1457e0091456"), 0.8f, 300f, 2f, 0.1f, 250f, 2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 0.05f, 0.03f, 4f, 0f, 0.3f },
                    { new Guid("f2fcbea2-3656-412e-8a85-82a252da1f11"), 15f, 220f, 45f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 2f, new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), 1f, 200f, 5f, 2f, 250f, 6f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.15f, 0.1f, 3f, 0f, 0.2f },
                    { new Guid("f3f3f3f3-3626-4cb2-96f7-93f816a194b0"), 40f, 300f, 40f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 2f, new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), 2f, 250f, 18f, 5f, 700f, 3f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.12f, 0.1f, 3f, 0f, 0.5f },
                    { new Guid("f495beda-adb4-4cd8-a07c-7976de1ed158"), 130f, 25f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.5f, new Guid("982d8f3e-f517-4bd2-87a8-48329fc9eb91"), 0.8f, 260f, 1.8f, 0.1f, 60f, 1f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 560f, 0.06f, 0.08f, 35f, 0f, 0.5f },
                    { new Guid("f4b89fdd-38a6-4efd-9538-659bb88da9f5"), 20f, 350f, 45f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 1f, new Guid("01e60ae4-ff69-44d6-b4fd-aaf916e3a7e5"), 1f, 250f, 20f, 3f, 600f, 1f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150f, 0.1f, 0.1f, 3f, 0f, 0.5f },
                    { new Guid("f5a24c42-6565-4b13-9823-9dd5013c9eb9"), 11f, 180f, 0f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9f, 0f, new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), 0.4f, 265f, 25f, 0.7f, 670f, 0f, 3.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.09f, 0.2f, 0f, 200f, 0.6f },
                    { new Guid("f715bf60-72e7-4c92-b0e5-1713b73f858e"), 5f, 89f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.6f, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), 0.3f, 358f, 1.1f, 0.1f, 1f, 12f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("f813675e-625d-4db7-846d-d14aa13f96c3"), 6f, 52f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.4f, new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), 0.1f, 107f, 0.3f, 0f, 1f, 10f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.02f, 0.03f, 4.6f, 0f, 0.18f },
                    { new Guid("f880935f-4887-46e2-93c6-dd684eee2197"), 11f, 116f, 0f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), 0.5f, 200f, 25f, 0.2f, 300f, 0f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.09f, 0.2f, 0f, 200f, 0.4f },
                    { new Guid("fa5b4860-9ba5-4ea3-b6c3-065ac83e58ae"), 15f, 190f, 0f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9f, 0f, new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), 0.8f, 260f, 27f, 4.1f, 70f, 0f, 9.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 0.06f, 0.11f, 0f, 0f, 0.3f },
                    { new Guid("fbeb7113-7903-4f50-999f-9bbab5db1ff8"), 2f, 96f, 21f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 2.4f, new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), 0.5f, 270f, 3.4f, 0.2f, 1f, 4.5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.15f, 0.1f, 6.8f, 0f, 0.2f },
                    { new Guid("fff1baee-cb11-4b47-8e73-72068b0791b7"), 30f, 110f, 10f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), 1f, 250f, 9f, 1f, 450f, 1.5f, 2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.1f, 5f, 0f, 0.4f }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "ScheduleId", "AppUserId", "ConsultantId", "CreatedAt", "RecurringDay", "ScheduleType", "SpecificDate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"), null, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), null, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), null, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), null, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), null, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), null, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), null, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "WalletId", "Balance", "ConsultantId", "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"), 1000000f, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "WorkoutExerciseId", "CreatedAt", "DurationSeconds", "ExerciseId", "IsCompleted", "Order", "Reps", "UpdatedAt", "WorkoutId" },
                values: new object[,]
                {
                    { new Guid("00487838-f65d-4bae-ada5-0fe69adaec6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("23842121-4834-4483-bfe2-2c244f5ecf76"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("038c54e5-c5d5-4b54-acfc-97f15e88fd8b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6749cbc6-0e28-4163-95e8-7fb2a27c54cf"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("0809f340-d32a-4710-acf0-d0c84e353a0b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"), null, 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("0819664b-6ed9-44c7-b8a6-edc0ac04bd9a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6badb5b5-ad99-4b89-80c6-e52d0f7cd7ba"), null, 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("0c006324-82f8-46cd-9602-376eb3d886c6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("58878826-775e-4d4c-8e1b-d5c95afc214d"), null, 8, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("0d0a5545-707e-4de8-8396-063bf15c3e7b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), null, 7, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("0d0a7593-d0ff-4fae-be8e-ad067ad74670"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("07a4dbcd-635a-4a76-92d4-8127de619e6d"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("0dafdaac-5dac-4083-9fcc-bef3d00d59ac"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("0e9662fe-1a6c-48a4-9364-551f1c520caf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("faebde03-bab9-457b-9b45-a9fabd4760aa"), null, 1, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("0ed4b131-52da-4ff6-b864-e900b873d387"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), null, 3, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("1098a111-a7fa-4baa-b031-096d4a130672"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("11c79d5b-90c2-48bf-b3ab-0d8d6919e9d5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01e6141a-930e-4126-a2c6-7c32a2ccdd43"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("13e57d71-4c88-43b3-b48d-6e58100259bc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("22af0171-257b-43bc-9013-8985472a8c84"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("13e9e7aa-5319-46c6-b2bf-cbf05e43219f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), null, 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("18c4ed12-fe4c-4528-948b-8ebd0ec1b7d7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3100278d-eee7-4b89-b726-4b76daefabde"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("1c727b5c-0bc1-4c93-ba33-cb87bf88988a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"), null, 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("1c80f66a-328f-44c0-9839-e7444b184d7a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("1c9bdfe7-e797-4b4e-b622-f228df1d5154"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), null, 1, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("1ec3c76d-b388-440b-9da4-34431e895e83"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), null, 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("2150e5b9-df31-4ace-87b4-cbc146571584"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), null, 8, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("21c0f796-1ac1-404a-b5ff-265f7e528ca6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), null, 6, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("23f0d5f0-4d40-4acd-af8b-4007ffabb212"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("1b2afb40-fb97-49ec-8fe3-81a17c6c9078"), null, 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("243e5b96-b23b-41c6-83eb-cc49a091a581"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), null, 4, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("244ff031-3aae-41f5-ba19-216150d60ff9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), null, 3, 32, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("25361d6c-52dc-4832-a714-582a46f6c02b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), null, 9, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("28a05b82-3650-4525-8c47-10989452cc6c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d6b2c0d5-110f-4dff-9aa7-91da10a29dca"), null, 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("29c83613-1241-4a44-b23b-3eb2c11c1cf9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("2af19b89-7e24-4c21-bc6b-6938a237f807"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("2bace6aa-5c9a-4796-ab11-542017bd3e47"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), null, 3, 30, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("2c0add7c-d4e1-406f-801c-68c356d1cf93"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), null, 1, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("2c457a13-e3c7-469e-b846-150e5ed006ab"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("28de23bb-07b9-4ebc-8f72-ead4d54a4883") },
                    { new Guid("2eaed4af-4837-439a-8402-b07b4fa9554b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), null, 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("2f5b728f-9fda-4c46-af6b-37df26412573"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("2fbbbcdf-d118-4ffd-8c8d-8a3bacc29b56"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), null, 1, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("30032d92-7e62-4eaa-823b-538b0fdf71ff"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("30b6c71f-a19e-494a-a002-54ed543263a9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), null, 2, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("333cf163-b89d-41c3-b44e-8097cb7bd20c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("3354b78b-33e9-4c95-b75e-48cd1dab218a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), null, 4, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("3372032e-2886-4f74-8afa-83b61533eb87"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 6, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("345f0b00-6c45-4364-8fed-384bea4926c3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), null, 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("3b6e5821-7b81-4281-ba37-63af7c82b56a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0d816828-8a94-4dcb-a87c-b70b295a39b6"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("3b826e72-1f7f-495e-bdf7-61e95380a1dc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("3b86c862-0ab3-4256-9baa-aa4c2f1f08ee"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("05c931df-c828-442e-aee1-56432cb772c7"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("3bac5d45-4c61-4174-a269-2018bf587c00"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), null, 8, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("3ffd498a-7778-4ec6-9379-1c767f1a9372"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), null, 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("4269f957-3586-4ac3-a894-228814298910"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("4373778d-279f-4a9f-9cf6-873872876dd9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("5cbc396e-381a-4d9f-9ad6-42b764deee3e"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("4499df90-ffee-4ff0-a5c7-80384a6ec3b9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), null, 1, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("45a34b3a-e3ec-4935-86db-dbd8538002a9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), null, 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("478a1238-ccdf-4a16-b0e8-fcb08f684d7b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8619916d-a296-48a5-af89-f82a6a1cb26f"), null, 3, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("4913cd88-5d0b-4ef9-9ab9-f929281be0c4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"), null, 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("4aa8533c-ccac-4f48-9a09-b6a98f762fc0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b2e62599-1f8c-4fc2-9ca7-8ab7aa571d4e"), null, 2, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("4b9c9497-cc2d-4f1c-82b7-d1adf2560cc4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), null, 5, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("4db09ea1-d737-4ceb-aa6c-44b1ac7691e4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("72206c5e-58f3-46f0-a8b1-031cbf599433"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("4f51e392-83ae-44ce-8683-8527c88acf59"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"), null, 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("50b3d42e-4f3f-479f-a707-b07091f1c6fc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), null, 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("51c92883-8cd3-45a1-997c-4737b3c4459d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), null, 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("5229b4c6-33fa-40c0-88ff-07a40754b6e5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), null, 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("530badd7-0a98-4655-9454-e2f46f133973"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), null, 5, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("53302e42-f622-4372-bbad-aea340d3ba1e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"), null, 4, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("537ca9c8-7ef4-4107-98a7-07f1ab6e8894"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("55014925-bb63-4f6b-812f-d5009877e642"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("4834f1ce-41dc-4161-ac51-e03ca78b62b8"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("57dc5174-a449-49ae-92e1-07b3d41f8b4b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), null, 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("581e41c6-c5e2-47c3-8124-a31c51240336"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), null, 1, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("5928724c-648d-4dee-a34a-d89cdb7f6b5b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), null, 3, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("593b5206-4786-462f-9bf6-1dea0602e3ed"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ae6eaaa1-c8c4-4f97-afa4-4ceeea19d4b3"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("5a81225d-560d-4c05-acde-20990bf49811"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), null, 6, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("5ad666de-decf-4a25-90f9-2255c63fed74"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d4ebca3a-83ef-485b-9178-83d4eab9694c"), null, 4, 16, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("5ae0d9e7-a682-4d8f-97f7-b301d132eea8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("d0dcad19-4c0c-447d-8e3c-092c6d4ad14c"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("5c56a15c-96a5-419d-a123-ccee4d70d4bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), null, 4, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("5ceccc6e-eec8-4a74-9332-f54781199052"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("90ce2a9f-d0be-4ca0-b3ca-8b6947a6b266"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("28de23bb-07b9-4ebc-8f72-ead4d54a4883") },
                    { new Guid("5dba7a39-f5b6-43ea-877b-ca308a5e2a98"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), null, 6, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("5e549ec5-5c36-40cd-a90c-b77c1cdd9b0d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("385f13f7-79bf-437b-acac-745b50485b9f"), null, 2, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("5f3a8967-8365-481a-83dc-18851d17a538"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("439db970-c7c8-4b3b-9a35-127d31d920dc"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("5f669a6b-cf46-462f-948e-1d639ab3e30e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a9e1fb3-9abf-4775-a75e-2bb13009a29d"), null, 1, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("5fd7d020-5866-441c-a4bf-d4455a9f479a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"), null, 1, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("6340b3a0-b3e3-4789-bccb-44f44519b4f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("637914e7-2bc2-4e83-9d94-0f8ca3e3ee33"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a280d32-de67-4a38-8f21-923243489eef"), null, 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("66f6f97c-5aa4-40e7-a1da-2df83b161775"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("680dbe31-6ff7-4e83-bd09-32710f26cf56"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("6bdfac12-8ddd-40be-8ebf-1a28f4ea820c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), null, 2, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("6c704ed0-ee95-4f32-a305-80a57a1ddc66"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), null, 7, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("6f8fd9b3-342c-43f9-9d30-2f5e363a8b52"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("6f9a78a5-6d9d-4066-9e35-539a105dc13c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("6fecdad5-2ae2-493e-bb18-9362411387cf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("72206c5e-58f3-46f0-a8b1-031cbf599433"), null, 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("70f36f46-6849-494e-8280-78b3e0bf4842"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d4ebca3a-83ef-485b-9178-83d4eab9694c"), null, 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("7118221d-b342-445c-92d4-1477042f1f9a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), null, 1, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("720210f0-9516-4b84-a57e-fec0ac153522"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("2696db05-e815-4c8b-870d-23c338479e95"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("72c1627d-a9fa-4813-bb32-f172289aa7ab"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), null, 1, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("73c06bab-a775-4185-86d3-625f5873a7dc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6d6b06e1-5ade-4dae-b442-7aa200661760"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("74ed436f-c32d-482d-b71d-beef9870d7ba"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), null, 3, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("752b83e7-7773-4678-8be4-afdf43e10c56"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), null, 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("768f9553-1b61-47ad-8890-7e435bc0bca2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), null, 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("798cc31a-f7f2-4106-8928-61613408c046"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2e787245-7612-41bc-9b75-7a4857282350"), null, 2, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("79dfc163-b558-4f8b-87e5-df2e7eca725e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), null, 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("7a2166ba-060f-47a5-bf0d-e17318c97224"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bd80fdd3-c46c-4410-b126-51a11a8a2f5b"), null, 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("7bdea8bc-dd93-4cd2-8193-db74b985f767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("7be8aeb2-dee2-4569-a1a0-71ba53080a36"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), null, 1, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("7c773851-9ca4-4b29-9148-040bec57150a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), null, 3, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("7dbc1495-3ff5-434c-80ab-0ea598aaa96e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("8236e717-228d-443b-bd92-f5f9627f79de"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), null, 1, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("86670b67-3382-4f7f-9a81-8ba6ca6cbb27"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"), null, 7, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("887c007c-9d9e-40d8-9859-057387926a43"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6ef8ed78-0d00-4271-bf9b-edf27a55ecab"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("88b1158a-030b-4888-b768-ed2bf9d813ac"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), null, 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("88cfffe7-ebad-425f-9daf-5245b443f128"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), null, 5, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("8af7a3b6-ed93-4d9f-bd26-8c1282102b2a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0c011f92-425a-477c-84d4-3d6dc883119b"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("8b0387c8-1691-4176-b07d-a8c12a9a2635"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("8d56d9e4-3d87-42cd-8476-b116bcec997b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), null, 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("8dc3fcf8-8e54-43c1-bf3c-23ea8ad12623"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8b93dbb2-fc2b-4627-b79a-3ec45a7c6238"), null, 2, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("904c9fea-2383-4d76-a094-26da59589f8b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), null, 3, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("9114706b-034b-4602-aeb9-47ad00c4433f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("256e23fa-03b1-4328-a325-512f0860d9b0"), null, 6, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("92ed53e0-8b8c-4f96-a10c-ea1fe7e005c7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), null, 5, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("952eed94-42a7-4c8f-b5d8-512d89f8bbe3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), null, 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("9645ddb3-089e-4728-9e1f-b77b34719bef"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("99193416-1317-435f-a6e1-6f4dd796e91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("99b850e4-de75-4092-a964-91c4f418aa13"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("9b095dae-ada5-48c8-ac2c-dda6e2edbb1b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ae6eaaa1-c8c4-4f97-afa4-4ceeea19d4b3"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("9e28854b-9f51-466d-b6c8-7b2dfe56fcac"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("d3d944c4-947d-4910-bb6e-636390e5b8d5"), null, 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("a1c4939e-8c24-4836-9c5c-a23804d95e54"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01dc4c46-e1ef-44bc-9f19-ecb283bf27ce"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("a2a8b6eb-2a19-456f-86a5-5baef0f688fd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("a31e98b0-0266-4cf9-8865-5b1a101987f6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), null, 5, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("a6860b8e-4eff-4aed-ba7e-3a8982a8c35c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("aa741589-1ac8-4488-a4d9-b2d1169a4c35"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), null, 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("ab713f9c-98f4-4f83-99da-715c5f906991"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), null, 3, 30, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("ab99e767-8d49-4d09-b815-4ecc6d9a61e2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), null, 4, 6, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("ac21dee7-1fef-4523-a56f-43fca0582f51"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), null, 5, 6, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("ac539b12-8ec4-40e4-9a00-68a5015d8b98"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), null, 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("ad1e8bf8-c7f7-485c-9372-76b14380f563"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), null, 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("ad94f084-3195-4016-b1a9-b868418f59b3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("407ff857-d218-44a8-8d0f-0bfa5d53bf03"), null, 7, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("adf1d9c2-f91d-4cf7-8a4b-18875b009470"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), null, 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("ae3442b0-f7b6-4e5f-9daa-b2db88ef538e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("b39409c7-68c5-4da0-b42f-9ff291420bfb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), null, 4, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("b69d06a5-12ae-4013-a677-55bf11d9b537"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("b80ee1ad-6b21-4548-ab1e-ba231878c41b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a280d32-de67-4a38-8f21-923243489eef"), null, 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("b88f5646-66de-44da-a1c9-6ffaf337fc81"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ff0ef05-4387-4483-8de3-0ef6d7724afd"), null, 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("b9c0b810-92c8-4172-9ddc-ceafb1f8b31b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), null, 8, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("ba0f241d-11b7-4bc1-b4ed-c7eed3f629c2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("bcc54dcc-77e7-4c3e-b399-5d51233651b5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("bd833857-910b-46b6-90d0-89f4b880d3ed"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), null, 5, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("bf2bcece-53e2-43b5-be81-7fd603af6cc8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), null, 6, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("bf658410-91e8-4806-a870-7c3843174ba1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6ffea500-ca35-4483-b049-d8593b2c8680"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("c3b5d565-d247-4e94-aa4e-d75fe31146af"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("c4353a11-d319-4f26-98dd-9531038d8adc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("c5235c29-d625-4a05-a297-e92b470c8855"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 7, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("c7018cdc-8643-4ff0-a60c-b9702fc63387"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("c7dacba5-71ba-480c-82cb-b31a902d406b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("f93d73ba-d1d6-4037-b51b-1fd005accff3"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("c94d2679-7a78-4182-8a9c-7a55e9f3e024"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), null, 5, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("ca6cbb80-eea0-4153-b33a-b71330edc4af"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), null, 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("cba2d458-b321-4b45-905d-9809321462f6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), null, 4, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("cbb27a9c-de8c-4fb7-b564-207a57dc3c4f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("93e22c77-001f-4825-8983-4ec5b643b7bb"), null, 5, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("cc524f2d-0ea1-4c44-8e42-b852720c7922"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("cc6fa18c-2573-4de6-b988-5f2626ff7102"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), null, 7, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("cdbd20a0-6dd5-49ae-8a13-c8680f81704e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("cf9cae80-716f-4f14-97a6-3078438211a6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("d17553ad-c0d5-4d6a-8198-c00a26dc7e70"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"), null, 5, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("d427314b-6e5c-4423-963d-9bb35807c39c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("d5101148-5839-4bd1-b619-baa14650f72a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), null, 2, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("d5e4bcc4-6d9c-41c5-bcda-59fb3e9ea24c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("9ba29558-e51b-4a1a-a1c4-b747967e32fb"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("d8ee86f3-165a-457d-b880-6f1df6e5529b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("db2729d6-bd21-4bce-a537-85456877ebc2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("9ba29558-e51b-4a1a-a1c4-b747967e32fb"), null, 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("dbb98252-15ed-4109-a78a-d61ca4143894"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), null, 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("dc7cb670-ba8a-42f2-ae0b-a6312728b04a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("58878826-775e-4d4c-8e1b-d5c95afc214d"), null, 6, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("dcbc7585-ec5e-4eb9-8c8e-a89cf997c93f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), null, 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("de5ca4d2-42a8-4704-9db4-03a515b562b5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), null, 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("de74b216-5739-446d-83a7-771201aaf67c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("23842121-4834-4483-bfe2-2c244f5ecf76"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("def186c6-d7cf-44ad-914a-be0a6caf5f79"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), null, 6, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("e0e153f8-ba95-4cc9-92e5-e9a530a30023"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("e4f88b1b-e2ff-4a81-84b7-a8114273a75e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("e5caa15d-a489-4141-a967-e506abc64440"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), null, 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("e63ec049-63a3-459f-9da5-f77d37581072"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), null, 1, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("e8372b10-c301-4597-9c72-83c9e402b635"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), null, 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("e9a6d200-403c-4ade-b01b-76be59e71b68"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), null, 8, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("f30e58d4-fb4f-4ff4-8f12-fdd100bbb4ea"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("93e22c77-001f-4825-8983-4ec5b643b7bb"), null, 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("f59cb318-cd2b-4582-b467-ba21b2217e0d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("235f7494-3e7d-45a5-a31a-6d5449b1322d"), null, 2, 16, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("f5ce788d-353c-4b37-ad3a-6ca93279b0ad"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), null, 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("f698a25c-c521-4d97-97f4-50b91f2a6188"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("f7699475-aae9-43bd-817e-0fc587ca73ab"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), null, 6, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("f76faaaf-7f11-4dde-8ff2-4cb1036dc42e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("0d1e54fe-7a5f-4e0a-a59f-ee9f443718e0"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("f786a299-f30b-4dff-9189-9ec5c8fa8be4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), null, 2, 30, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("f85d1a58-0b7a-4a86-89e3-0de7e72fc951"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01e6141a-930e-4126-a2c6-7c32a2ccdd43"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("f99e92bd-544d-426e-a9f4-240eb36e55e4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("13ca014d-8b75-414f-afe3-3d378ef7fa97"), null, 4, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("fca4df2c-4cef-4e9b-a448-7a0771207b1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), null, 3, 30, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("28de23bb-07b9-4ebc-8f72-ead4d54a4883") },
                    { new Guid("fe2ce23d-c375-43ea-9069-c6483e420d37"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("fe467f82-b8bd-4799-8148-4e06403fa80b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), null, 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTimeSlots",
                columns: new[] { "ScheduleTimeSlotId", "CreatedAt", "ScheduleId", "Status", "TimeSlotId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0f9928fe-8e48-4d9c-b8b8-87ede3a2c05d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1bdbb084-ed1b-4d34-adeb-fde4d45b5fb6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2bada19f-e55c-45e7-ab47-0fbfe2fb9efe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c4ce4b1-e7c8-4a16-92fc-fa04b14ed8a4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("46134233-dd48-44a2-b8b3-aa2dd8762354"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("468d7322-061b-4589-8a33-89d91ffc36c6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("47b7ba0a-6918-4282-bac8-30278f1e168d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f09f75c-52c1-48a1-b4df-6e9efedc48c0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("54445f69-1db9-4611-91f4-a8b60fc9c8c6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5a3f9c28-d9da-4b2a-9b6f-b75c22020eba"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5a76bbfc-3d2b-4acb-8f43-567a63c6ce65"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("b8b71edc-d48b-44ea-9dc3-b7d214c582c1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5ada3c80-0f66-4386-8d81-f2421c363d7e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5bb71469-0e2f-48d6-9f93-56dc58fada1a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("b8b71edc-d48b-44ea-9dc3-b7d214c582c1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("64bb8081-ff94-4e44-87da-6841a2412ed8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("678b563f-e6ee-48b7-b70a-79e013aa6b08"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6cf4f3ce-bdf2-4b34-a862-d56bae3d6321"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("72b76c1c-cd97-4d31-bf39-20182e937fc2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c964c65-f04f-4685-a629-7cb6cdb14795"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("920863d3-3f7a-4daa-9a6e-881824045cde"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("93c9b80e-26f7-4590-bbc5-dee264d061f4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("97c83703-7c39-4716-ae5e-8204552a7fa2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("98942fc0-b5bf-45a7-a938-7c7025966225"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a6b739f7-3954-4e9a-96dc-80d12cc5691f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ab4de314-a1c0-4968-977c-b7640aa07012"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac174846-ff36-42bc-9956-9dd2ee074c27"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac9684a7-7a00-49d7-b3eb-690d910554c5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aedc9597-fe98-43c1-a8ca-ade90eab996e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b1e89351-be54-47ad-81f5-bc6bb46d569d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3628a82-5e8f-4bdc-856b-244aea4fb102"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("b8b71edc-d48b-44ea-9dc3-b7d214c582c1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb0f16c0-6446-4f78-babc-0705482cee1d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce6f481c-2231-413a-ae95-9147fdddbffd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d32362f4-b3af-45fd-97b9-4a392d9165e4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d340b26c-b75b-4ba3-9258-5fa4a3179fa6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("b8b71edc-d48b-44ea-9dc3-b7d214c582c1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d75e6ea3-b8e6-4e93-a909-91b9df539068"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d80a7362-9154-4a95-bc2d-74aad4a70b15"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dfebe418-ef84-46d2-9bf8-a1a78ccb966e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e0896ad6-cf54-4b17-8a93-48bb7bfa666e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e6276b58-a55d-447e-9fc9-61304c09b0d0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e930adc4-2e8a-42c3-abae-604aa5f9098c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ed63ab1e-11c9-4893-9b4b-64b7066f44e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2ae63f0-2359-410d-9bed-82bef88dc928"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f65e782b-28fc-47ca-bea5-c20aabce417b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("b8b71edc-d48b-44ea-9dc3-b7d214c582c1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f74d46c8-9d4d-4ad8-bed2-eedb8bcc68dd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_DailyActivityId",
                table: "Activities",
                column: "DailyActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_UserId",
                table: "Activities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_WorkoutId",
                table: "Activities",
                column: "WorkoutId");

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
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFoods_CategoryId",
                table: "CategoryFoods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFoods_FoodId",
                table: "CategoryFoods",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_ConsultantId",
                table: "Certificates",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ConsultantId",
                table: "Chats",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_UserId",
                table: "Chats",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultantBanks_BankId",
                table: "ConsultantBanks",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultantBanks_ConsultantId",
                table: "ConsultantBanks",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultants_ExpertiseId",
                table: "Consultants",
                column: "ExpertiseId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultants_UserId",
                table: "Consultants",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DailyActivities_GoalId",
                table: "DailyActivities",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyActivities_UserId",
                table: "DailyActivities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyMeals_GoalId",
                table: "DailyMeals",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyMeals_UserId",
                table: "DailyMeals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyWaterIntakes_GoalId",
                table: "DailyWaterIntakes",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyWaterIntakes_UserId",
                table: "DailyWaterIntakes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DishTypeFoods_DishTypeId",
                table: "DishTypeFoods",
                column: "DishTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DishTypeFoods_FoodId",
                table: "DishTypeFoods",
                column: "FoodId");

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
                name: "IX_Messages_ChatId",
                table: "Messages",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Metrics_UserId",
                table: "Metrics",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Nutrition_FoodId",
                table: "Nutrition",
                column: "FoodId",
                unique: true,
                filter: "[FoodId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserSubscriptionId",
                table: "Payments",
                column: "UserSubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookingId",
                table: "Reviews",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleExceptions_ScheduleId",
                table: "ScheduleExceptions",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_AppUserId",
                table: "Schedules",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ConsultantId",
                table: "Schedules",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleTimeSlots_ScheduleId",
                table: "ScheduleTimeSlots",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleTimeSlots_TimeSlotId",
                table: "ScheduleTimeSlots",
                column: "TimeSlotId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_BookingId",
                table: "Transactions",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_WalletId",
                table: "Transactions",
                column: "WalletId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAllergies_AllergyId",
                table: "UserAllergies",
                column: "AllergyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAllergies_UserId",
                table: "UserAllergies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCategories_CategoryId",
                table: "UserCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCategories_UserId",
                table: "UserCategories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_SubscriptionId",
                table: "UserSubscriptions",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_UserId",
                table: "UserSubscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_ConsultantId",
                table: "Wallets",
                column: "ConsultantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WaterReminders_UserId",
                table: "WaterReminders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WithdrawalRequests_ConsultantId",
                table: "WithdrawalRequests",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutExercises_ExerciseId",
                table: "WorkoutExercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutExercises_WorkoutId",
                table: "WorkoutExercises",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_CategoryId",
                table: "Workouts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_UserId",
                table: "Workouts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

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
                name: "CategoryFoods");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "ConsultantBanks");

            migrationBuilder.DropTable(
                name: "DailyWaterIntakes");

            migrationBuilder.DropTable(
                name: "DishTypeFoods");

            migrationBuilder.DropTable(
                name: "FoodAllergies");

            migrationBuilder.DropTable(
                name: "FoodPortions");

            migrationBuilder.DropTable(
                name: "MealFoods");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Metrics");

            migrationBuilder.DropTable(
                name: "Nutrition");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ScheduleExceptions");

            migrationBuilder.DropTable(
                name: "ScheduleTimeSlots");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UserAllergies");

            migrationBuilder.DropTable(
                name: "UserCategories");

            migrationBuilder.DropTable(
                name: "WaterReminders");

            migrationBuilder.DropTable(
                name: "WithdrawalRequests");

            migrationBuilder.DropTable(
                name: "WorkoutExercises");

            migrationBuilder.DropTable(
                name: "DailyActivities");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "DishTypes");

            migrationBuilder.DropTable(
                name: "Portions");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "UserSubscriptions");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "TimeSlots");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropTable(
                name: "Allergies");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropTable(
                name: "DailyMeals");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Consultants");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "Expertise");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
