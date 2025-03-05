using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
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
                    CategoryType = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Expertises",
                columns: table => new
                {
                    ExpertiseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpertiseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expertises", x => x.ExpertiseId);
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
                name: "Goals",
                columns: table => new
                {
                    GoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalType = table.Column<int>(type: "int", nullable: false),
                    WeightGoal = table.Column<int>(type: "int", nullable: false),
                    CaloriesRatio = table.Column<float>(type: "real", nullable: false),
                    CaloriesGoal = table.Column<float>(type: "real", nullable: false),
                    ProteinGoal = table.Column<float>(type: "real", nullable: false),
                    CarbsGoal = table.Column<float>(type: "real", nullable: false),
                    FatGoal = table.Column<float>(type: "real", nullable: false),
                    FiberGoal = table.Column<float>(type: "real", nullable: false),
                    SugarGoal = table.Column<float>(type: "real", nullable: false),
                    WaterIntakesGoal = table.Column<float>(type: "real", nullable: false),
                    CaloriesBurnedGoal = table.Column<float>(type: "real", nullable: false),
                    DurationGoal = table.Column<float>(type: "real", nullable: false),
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
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FoodType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MealType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DishType = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    WorkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkoutType = table.Column<int>(type: "int", nullable: false),
                    WorkoutName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkoutDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DifficultyLevel = table.Column<int>(type: "int", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false),
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
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpertiseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: true),
                    RatingCount = table.Column<double>(type: "float", nullable: true),
                    AverageRating = table.Column<double>(type: "float", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultants", x => x.ConsultantId);
                    table.ForeignKey(
                        name: "FK_Consultants_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Consultants_Expertises_ExpertiseId",
                        column: x => x.ExpertiseId,
                        principalTable: "Expertises",
                        principalColumn: "ExpertiseId");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_Payments_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "SubscriptionId",
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "ConsultantId");
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    CertificateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpertiseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CertificateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        name: "FK_Certificates_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "ConsultantId");
                    table.ForeignKey(
                        name: "FK_Certificates_Expertises_ExpertiseId",
                        column: x => x.ExpertiseId,
                        principalTable: "Expertises",
                        principalColumn: "ExpertiseId");
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ScheduleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Time = table.Column<TimeOnly>(type: "time", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "ConsultantId",
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
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_Reviews_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "ConsultantId",
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
                columns: new[] { "AllergyId", "AllergyDescription", "AllergyName", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0eec9d43-391c-43c6-9635-01ca2d6fc66c"), "Dị ứng với các loại hạt như hạt điều, hạt hạnh nhân cũng có thể gây ra phản ứng mạnh, đặc biệt là đối với những người có cơ địa nhạy cảm", "Các loại hạt", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), "Dị ứng với lúa mì, thường gặp ở những người không dung nạp gluten", "Lúa mì", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4d6270d3-69c6-4b9f-9c11-125369139775"), "Dị ứng với hạt vừng (mè) có thể gây phát ban, ngứa, và có thể nghiêm trọng nếu không được kiểm soát", "Hạt vừng", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), "Dị ứng với hải sản có vỏ như tôm, cua, sò, nghêu rất phổ biến ở Việt Nam và có thể gây phản ứng dị ứng nặng, từ phát ban đến khó thở", "Hải sản có vỏ", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99b9eae6-f5e8-4b41-9394-6a8f2ca1062b"), "Dị ứng với đậu phộng khá phổ biến và có thể gây phản ứng nghiêm trọng như sưng tấy, phát ban, khó thở, hoặc sốc phản vệ", "Đậu phộng", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), "Dị ứng cá cũng khá phổ biến và có thể gây ra các phản ứng nghiêm trọng như phát ban, sưng, hoặc khó thở", "Cá", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), "Dị ứng sữa có thể gây ngứa, phát ban, hoặc tiêu chảy ở một số người, đặc biệt là trẻ em", "Sữa", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), "Dị ứng với đậu nành khá phổ biến và có thể gây phát ban, ngứa, hoặc khó thở. Đậu nành là thành phần chính trong nhiều món ăn và thực phẩm chế biến sẵn tại Việt Nam", "Đậu nành", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), "Dị ứng trứng là một trong những dị ứng thực phẩm phổ biến, đặc biệt là ở trẻ em. Triệu chứng có thể bao gồm phát ban, ngứa, hoặc khó thở", "Trứng", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1975eaae-fd39-417e-bfcc-5e09f963b95f"), null, "Quản lý", "Manager", "MANAGER" },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), null, "Thành viên", "Member", "MEMBER" },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), null, "Người dùng", "User", "USER" },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), null, "Tư vấn viên", "Consultant", "CONSULTANT" },
                    { new Guid("d21edfd6-42d5-490a-a41c-43f7ef09c61f"), null, "Quản trị viên", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 0, null, "a361d41f-87db-4ae4-a10f-b20876f5e82d", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "khanhpham@gmail.com", true, "Nguyen Pham Khanh", false, null, "KHANHPHAM@GMAIL.COM", "KUEM113", "AQAAAAIAAYagAAAAEAJE8H7U/Eitp7RhXfl8zA2+mPDGZZLtW7PqeP1984o5v7zew8ldrlhyPFe/0ueJ9A==", "0969998878", false, null, null, "c550cbc2-f142-4a60-af04-aeda9027de96", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "kuem113" },
                    { new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), 0, null, "32d574de-c003-48ea-b343-3de778490b81", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "duythunglungtinhiu@gmail.com", true, "Pham Hoai Duy", false, null, "DUYTHUNGLUNGTINHIU", "DUYPRO113", "AQAAAAIAAYagAAAAEFMcJe9JSXOGbeq1ZytPcalDbfV1awvNEtT/4a4dfO1lTzlFFWWu3UQNeaeX3+Ep8g==", "0555666612", false, null, null, "1b04cc0b-d171-4057-8fd5-c569c6b94c5d", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "duypro113" },
                    { new Guid("20041d5b-01e4-443f-9652-e39beb9748e5"), 0, null, "4b73198c-36fb-4f3b-906e-0ba70e4ac57f", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "consultant@gmail.com", true, "Van Huu Toan 2", false, null, "CONSULTANT@GMAIL.COM", "0987654321", "AQAAAAIAAYagAAAAED9YK0NHDQ2c26aXZW5VBG+N9ssOYrzjZNEF56EFsmfZU53IH7J6zsqZqL99IsEOaw==", "0987654321", false, null, null, "9afa2118-881b-4a0e-a4cb-1207665d2406", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "vanhtoan" },
                    { new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 0, null, "2b48a4fa-16da-4440-a239-729ea253eec5", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quocdai@gmail.com", true, "Nguyen Quoc Dai", false, null, "QUOCDAI@GMAIL.COM", "DAINQ115", "AQAAAAIAAYagAAAAEJDcTpzt//VZNIYMa91ce6l0sR6RSRdNohCqEOPpYOoJXbipTL39aX7uDKOT687f2Q==", "0932748924", false, null, null, "cae14347-17d1-4559-b131-55dc2a54badb", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "dainq115" },
                    { new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, null, "8792c84d-4222-455c-8fae-8076760f2fda", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "asd@gmail.com", true, "asd", false, null, "ASD@GMAIL.COM", "ASD", "AQAAAAIAAYagAAAAELKG2TQ25lU0swRBph50fffiHBBXcJjVBOVTD+lKbtSO/EZUfCo10JA7N9wJ13vobQ==", "0123456789", false, null, null, "fa9f0819-d82e-4038-9956-61dd5e095b48", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "asd" },
                    { new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"), 0, null, "9b6b99bd-3d41-4334-b5ea-94a788f1c41b", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "khaitoi@gmail.com", true, "Phan Van Khai", false, null, "KHAITOI@GMAIL.COM", "XAUTRAI123", "AQAAAAIAAYagAAAAEK2YrM/I0WBjy+2lwLPcjZOOYIlFzn3unPCk7LbDKYSbLrnBe5IuUfeOqKgfnbg6Qg==", "0963122758", false, null, null, "8c551751-aa05-4bc7-b62f-684e37bc884b", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "xautrai123" },
                    { new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 0, null, "cc4a30e6-c4bd-4539-b4c9-ad6963cae960", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quangdalat@gmail.com", true, "Quang La Tui", false, null, "QUANGDALAT@GMAIL.COM", "QUANGSPA009", "AQAAAAIAAYagAAAAELVONQT+6ORP17ubMdH1gspzQ9l0UGlUnNvO6E5wdyqLW7VF2ORxXy+jVpaY5tT02w==", "0999777712", false, null, null, "5ce43e5d-713c-44f4-9b8c-f49fe089a210", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quangspa09" },
                    { new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 0, null, "124a0386-1c4d-4e0c-af3d-0afcbed67240", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "toanvan@gmail.com", true, "Van Huu Toan", false, null, "TOANVAN@GMAIL.COM", "VIPRO123", "AQAAAAIAAYagAAAAEC872TnMl3WRJ/oJ1WAKLv3K3/iD2VBcnA2cHyTF/X+ARY/dyltdwZcHMuFJVMTscg==", "0792766979", false, null, null, "3b5af04d-2162-42e4-9d39-9202f7bb343d", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "vipro123" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName", "CategoryType", "CreatedAt", "ImageUrls", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), "", "Thân trên", 1, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), "Hoa quả tươi hoặc chế biến như salad trái cây, nước ép, sinh tố, cung cấp vitamin và khoáng chất", "Trái cây", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fapple.png?alt=media&token=106a39ee-5c36-4c27-8bbe-c850ee19cb02", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), "Các món ăn từ thực vật, đậu phụ, và nguyên liệu không sử dụng thịt, phù hợp với người ăn chay hoặc muốn đổi vị thanh đạm", "Món chay", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fradish.png?alt=media&token=c27e26f3-3f39-42ec-bf40-94c9abb074d5", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), "", "Thân dưới", 1, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4575699a-5bb6-42ec-9d52-ea19d1170187"), "", "Bụng", 1, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), "Gạo, mì, bánh mì, yến mạch, và các loại hạt ngũ cốc. Là nguồn cung cấp năng lượng chính trong ngày", "Ngũ cốc", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Frice.png?alt=media&token=1ef6ca23-003f-4415-9ce4-3a3f5cd8e65e", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), "Món ăn từ rau xanh, củ quả và nấm. Phù hợp cho những ai yêu thích thực phẩm tươi sạch, giàu dinh dưỡng", "Rau củ", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbroccoli.png?alt=media&token=6746e0eb-bcf0-44d1-830a-79821f735f84", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), "Bánh ngọt, kẹo, kem, và các món tráng miệng ngọt ngào, lý tưởng cho những ai yêu thích đồ ngọt", "Món ngọt", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcupcake.png?alt=media&token=8721bd49-186f-4ccf-a85a-64008e4c8e38", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), "Bao gồm các món ăn từ thịt bò, thịt gà, thịt lợn, thịt vịt và các loại thịt khác. Là lựa chọn phổ biến trong bữa ăn chính", "Thịt", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fsteak.png?alt=media&token=dfffb9c2-2964-40cc-8712-e83b4200e7af", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), "Pizza, burger, khoai tây chiên, gà rán, và các món ăn tiện lợi, phù hợp cho những ai bận rộn", "Đồ ăn nhanh", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fburger.png?alt=media&token=66dd457f-64d3-4b66-851c-10eba13fdc7d", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), "Các món ăn từ tôm, cá, cua, mực, hàu, sò và các loại hải sản khác. Thích hợp cho những ai yêu thích hương vị biển cả", "Hải sản", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcrab.png?alt=media&token=0cde2529-8e28-4b5e-80cf-660f27564de2", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), "Bao gồm nước ép, sinh tố, trà, cà phê, và các loại đồ uống giải khát khác", "Đồ uống", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcoffee-cup.png?alt=media&token=14155321-cd44-422b-a49f-3e34636d7f85", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), "Kimchi, dưa chua, sữa chua, rượu vang và các món ăn lên men, tốt cho tiêu hóa và sức khỏe đường ruột", "Món lên men", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fpickles.png?alt=media&token=2a078ceb-40a9-403d-a68c-9682faf1b97f", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), "", "Toàn thân", 1, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), "Các loại hạt (hạnh nhân, hạt chia, hạt điều) và đậu (đậu nành, đậu xanh, đậu đen). Giàu protein và chất xơ", "Hạt và đậu", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fgrain.png?alt=media&token=e224b22a-925e-4aa4-ab50-d74309ba71f4", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Portions",
                columns: new[] { "PortionId", "CreatedAt", "CreatedBy", "MeasurementUnit", "PortionSize", "PortionWeight", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0336a88f-f5cd-4cc2-8478-980467aa91aa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "con", 550f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("03a92c0b-b7f6-4283-8109-a35898d5d3c5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả nhỏ", 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("113f6a04-87c4-43c6-8263-920bd099c8e0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ to", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("13672611-5453-40a0-9b58-33c2e552bf57"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả nhỏ", 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("1500876f-ef20-40de-baae-de0336bdc47b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "cốc", 240f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("16dc894a-746e-497e-a2c5-2d58f7f83c4d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "ly", 180f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("17c9d30f-bd85-4e58-bfc0-6b6d70b2e5fe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "khúc vừa", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("1802caa2-cfe0-48e7-8580-29165f84387d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả nhỏ", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("1808de3e-ae43-41a6-b9ce-bfe89131be5a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "chén", 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("18809fb3-b78a-4f67-b9f9-8bb6ab95ab00"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cái", 130f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("1b56833b-1ff5-4a90-aea9-074de2d0dd67"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả lớn", 136f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "miếng", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("1cddc91d-209a-4948-8e9f-9017252d5423"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("1cf439ce-a31b-4b95-b092-b7f6edf8d40f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả nhỏ", 220f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("218b9709-852d-4a1f-ad8b-c9410b49fea6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ vừa", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("21e32570-7d64-4cec-b711-873185c76523"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả to", 1500f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("222e1fa2-3910-42ac-9a5c-f371dded16eb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "lát", 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("22f0a09e-6816-410e-a5a2-c802103b089b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "đĩa", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("23ce32a0-6597-4b60-b35c-98073ff595c6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "con to", 500f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("24a4ed15-69e4-4fb5-8dd2-1695de52c264"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cái", 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("255ba0f6-14cc-4049-add8-138f27055b49"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "đĩa", 220f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("26096793-894d-47c1-a06f-cf9133f8089d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "hộp", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "trái", 164f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("26dcc6e0-67aa-40ed-b3d1-8a009c60a62c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả nhỏ", 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("2892c25f-bd50-4bb4-a845-997395ef6693"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "gói", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("28b06cf6-6367-4786-bccb-89c43dd3ce3a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả nhỏ", 81f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("28f6a369-f694-437d-82eb-944b09d5e369"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "con to", 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("2b7a3473-9f67-4938-b419-7cafa8f72a41"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "hộp", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("2c7ac6ee-f7fe-4ec8-974f-11f62a5f60b9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "con", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("30f41ca6-c420-4f7d-9602-bf80735d5691"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("31e9bda5-8ec3-4444-a23a-908e84da6a14"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "cốc", 240f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("36398f6d-0668-4d37-8850-9f9ee89b8b92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cây vừa", 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("399eee61-90b5-464f-b3f7-7ddc1077ab0d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "hộp", 110f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("3c7d60d4-60da-4f51-9448-30877b126572"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả vừa", 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("3d6d946f-8d9f-479a-b27e-3d78dc354db0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "chén", 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("3d7eafa9-9fcc-4f49-b8fb-2a5c629ae6eb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cái", 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("3f19ef5c-3c60-4a11-b1b3-5158859f1286"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả vừa", 900f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("3f77fd90-591c-45f3-8bbc-87d0bb49e461"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("40991196-f258-43f1-ac84-0381afa83477"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("40bbc8c4-f383-4ae6-979a-3ac83c275881"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "cốc", 240f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("41ae956e-14fc-44af-bc6a-e5ba77661cee"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 350f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("424ebe64-6570-4d88-9052-08c06dc0a2c8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cái", 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("4e9013c8-d6f7-4740-80d5-e95d318873b9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("509da3d8-ed0f-4cd0-be26-3a896b9500b3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "con nhỏ", 15f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("52c86d57-0909-41c3-b513-e770e6f6d104"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "khúc to", 600f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("5384aebd-4eab-4a44-8cbb-7ec2c04f1401"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "đĩa", 230f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("549d664a-eb1c-4b9a-8ad7-fab9e1482e5b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả nhỏ", 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("56681171-ccbd-4700-90bc-2233c1e661bb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "con to", 500f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("59589114-7d6a-4c80-8681-db5c554ab38f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "ổ", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("5a1bc1cb-ed0b-49bf-9c1a-5494db962d27"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "đĩa", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("5a9ac478-aa65-48ea-9387-1ad92f6c76b1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ vừa", 180f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("5adcb96d-70ef-403d-89c6-cc3aa807b6a7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ nhỏ", 110f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("5afaa147-398e-4be8-b0d1-8dcabe6ed18c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả nhỏ", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("5f7f859a-f20a-4f6c-8b8c-ecfbb1ff522e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả", 90f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("5feca670-1f15-430d-9b04-7ac86a329a6c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "ly", 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("63d10d95-7983-455e-b920-29c1f0c88d85"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả nhỏ", 120f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("6792c392-3c86-4162-be91-4fc8646f861d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "ly", 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("698c67ad-a726-435b-b9d2-c5690a79eb5a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả lớn", 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("6e98f2be-9196-4c4e-8279-b02010f853f1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "phần vừa", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("6f34350b-8f99-446e-9de9-e0c6277b10f3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "hộp", 180f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("709578ca-672f-461e-995d-dc78aeda8c4c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "con nhỏ", 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("749b288c-112b-4b7b-8750-0daff63d9ab3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 228f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("7b138bd4-4d3a-426c-9ab0-d66699b762d2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả to", 350f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("7be0e4d3-1e50-4de1-931d-08adb85f628b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả vừa", 44f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("7e071bd6-6afa-483d-8688-28b31b9a8bef"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "hộp", 280f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("84793ef9-fcd0-42df-ab0d-9380dfa18630"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "ổ", 110f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("87409e4f-4bea-4bba-855d-a3bfbc2f9c20"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả to", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("8a81e20e-ea16-4073-957e-29508a8f7419"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("8bffc4ad-afcc-436b-953c-444f1e8ce533"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "con vừa", 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("8c141b0b-f09b-486e-b75a-04fa194d412c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ nhỏ", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("8ecbc063-8d6e-450d-af39-0ba28bc572bf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("91524cc2-db22-4cab-abb7-700725232f1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả vừa", 118f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("919c7f66-53e5-46bd-b181-558f6052b953"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả vừa", 170f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("92e149ff-8491-48cf-a4e8-8106b1e95c4c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "cốc", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("93984b54-2044-4ea9-8364-a03c6568e358"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 330f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("9c276c0b-84b6-4216-8dbb-ae2034ac2176"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("9c3399d1-72db-4e86-a518-2575033bb6a8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả to", 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a1589990-affa-4805-a1e0-73de1ffa8516"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "trái", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a33065fe-80ad-4879-9333-424aadc6734f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 350f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a43d7637-6fc7-421b-86f1-f83e691431a4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "phần nhỏ", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a5dbb27a-4856-44be-a239-76eb073c3e41"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ vừa", 80f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a7936b9f-b6f8-4295-8b6e-6fe1b096f437"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ to", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a88faa7c-6eab-4ecb-8a75-b078a9cf7834"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ nhỏ", 110f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a9385e8a-e9b9-484f-beeb-bc35529cf91a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 330f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("ad9ecd1e-40ec-414a-be69-b16e7013b377"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả to", 550f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("b6623163-4c27-4d0c-99ef-12a67b87635f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 350f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("b6b0faee-84e8-4a16-a8f7-4b8719787e8a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ to", 450f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("b9423874-3290-4fda-9996-7c13d7c61d96"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cái", 90f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("bad70aff-4237-4c83-b412-460020a5ee44"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "hộp", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("bd16f0ec-5ae1-42f4-a302-b4bce8f0db28"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả to", 220f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("bdd1ee1e-3a93-421f-855e-0993c7e6f767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "đĩa", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("bf0f7ca4-9089-4800-95d7-8d037d98b7fc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "con vừa", 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c4993d6a-a2e0-4ddd-821a-0629541e019c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c4fc900f-5a92-4228-ac03-57285fff159e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "đĩa vừa", 350f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c605aa91-495e-4977-9876-b2a198ce356e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả nhỏ", 38f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c65d34ee-8c0c-43bb-9d4e-aa39955a4768"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả nhỏ", 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c6e853f0-06bd-4cda-8b43-cbe66fea98c8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cây to", 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "hộp", 180f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("cd0b1476-44a8-4350-a6a1-3de8747a5ebc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cái", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("d09266d3-9e7d-46a6-ad3a-7c608ec802d1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("d2e88505-bbd6-4af6-9a88-535896c5d587"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả nhỏ", 500f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("d3850e1b-4780-490d-8c0c-ced1a9aa323b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả vừa", 220f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("d6c41cdb-4735-4b9e-85ae-1f48f33b7d6c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cây", 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("d9dad801-145a-419d-bbe2-408acf97a273"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "con nhỏ", 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("da254ee7-d229-4769-bad5-a617d09676d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả to", 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("de5d78a3-c5b1-4e2a-b9eb-f3757c999024"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cái", 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("e00ed683-11ff-4c21-8b1c-576b448726c9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "phần to", 400f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("e09c493c-5806-4b14-bbef-e26e19e1d8d5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả to", 400f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("e23d4491-73d1-45b5-8010-0385d7185c98"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("e45c2156-a98c-4121-90b4-25097e8a5cd1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả vừa", 170f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("e4e4252f-ad38-4190-aba5-8989e3cca994"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "miếng", 114f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("e5cc2785-6d62-4b5f-8fc1-e6ab45babd76"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ to", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("eceaaa32-4023-4eab-abb6-9172c908f77c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 250f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("ef6b8c43-9ab5-497c-a9a8-e31f0a349527"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả", 220f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("eff728af-c8f0-4bb5-a985-d079cbadb6b5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ nhỏ", 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f01f8da7-9d7b-4893-999f-cf30e719e010"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả to", 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f0e8f9cd-d133-49cf-be7d-d427b630e05a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả", 120f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f359ba3c-6597-40ad-9dbd-6719ff302994"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ vừa", 300f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f483bb75-84f0-4ecc-8a06-f366a488c6bf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "khúc nhỏ", 120f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f7b36043-9ca9-42c3-8a00-e9e235b56bb3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "ly", 200f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f928b7a6-2558-478a-bc22-515516f4dc74"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "con vừa", 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f9bc9ae8-e42e-4e8b-84d3-f2bc36037552"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả vừa", 110f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("faec7c41-2e11-4092-8ab9-cc9c152d858f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cây nhỏ", 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("fc245902-ef53-4363-b4ce-0e598e1dd4a4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả vừa", 17f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "SubscriptionId", "CreatedAt", "CreatedBy", "Price", "SubscriptionName", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("af1d42fa-b5d2-469e-918b-724d8db19009"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "Gói cơ bản (Basic)", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("b743cc4e-cb7d-4f94-bc91-a2631d4506fa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99000, "Gói cao cấp (Premium)", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
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
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), new Guid("20041d5b-01e4-443f-9652-e39beb9748e5") },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87") }
                });

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
                    { new Guid("4834f1ce-41dc-4161-ac51-e03ca78b62b8"), 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Superman tĩnh", 0, "Nằm sấp trên sàn. Giữ cho chân của bạn thẳng và khép lại\nDuỗi thẳng tay của bạn lên trên đầu để cơ thể bạn tạo thành một đường thẳng\nHít vào và nâng cánh tay, ngực và chân của bạn lên. Cơ thể của bạn phải tạo thành một vòng cung\nGiữ ở vị trí này với cơ bụng siết chặt và thở chậm", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
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
                columns: new[] { "FoodId", "CategoryId", "CreatedAt", "CreatedBy", "DishType", "FoodDescription", "FoodName", "FoodType", "IsPublic", "MealType", "Status", "UpdatedAt", "UpdatedBy", "UserId", "Views" },
                values: new object[,]
                {
                    { new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Bí đỏ là loại rau quả giàu vitamin A và C, giúp cải thiện thị lực và sức khỏe da. Bí đỏ có thể chế biến thành các món canh, xào, hoặc làm sinh tố, là món ăn bổ dưỡng cho cả gia đình", "Bí đỏ", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("00bc33fe-4cd5-47df-bd94-15ac9f93648c"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Súp rau củ là món canh thanh đạm với các loại rau củ như cà rốt, khoai tây, đậu que, nấu trong nước dùng nhẹ nhàng. Món này bổ dưỡng, dễ tiêu hóa và thích hợp cho các bữa ăn thanh mát", "Súp rau củ", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("01e60ae4-ff69-44d6-b4fd-aaf916e3a7e5"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm gà xối mỡ là món ăn đặc trưng với cơm trắng ăn kèm thịt gà chiên giòn, đậm đà với lớp mỡ giòn rụm. Món này thường được ăn kèm với dưa leo và rau sống", "Cơm gà xối mỡ", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Sữa tươi không đường là nguồn cung cấp canxi và protein giúp xương chắc khỏe. Nó cũng hỗ trợ phát triển cơ bắp, cung cấp vitamin A và D. Sữa tươi là thức uống bổ dưỡng cho bữa sáng hoặc giữa các bữa ăn", "Sữa tươi không đường", "Drink", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0292d477-d63b-4904-a83b-2cd8cac39c14"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh củ quả là món canh với nhiều loại rau củ như cà rốt, khoai tây, đậu hà lan, nấu trong nước dùng nhẹ nhàng. Món này cung cấp nhiều vitamin và chất xơ, rất tốt cho sức khỏe", "Canh củ quả", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Thịt heo bằm là nguyên liệu dễ chế biến, thường được dùng trong các món như thịt heo bằm xào rau, làm nhân cho các món bánh bao hoặc canh. Món này có hương vị mềm mại và giàu dinh dưỡng", "Thịt heo bằm", "Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("05cfce09-72b4-482d-adcd-c0718015be3d"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh xèo là món ăn truyền thống với vỏ bánh giòn, nhân tôm, thịt heo, giá đỗ và các loại rau. Món này thường được ăn kèm với nước mắm chua ngọt và rau sống, tạo nên hương vị đậm đà, hấp dẫn", "Bánh xèo", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Bánh mì là món ăn nhanh, phổ biến với lớp vỏ giòn và nhân phong phú như thịt nướng, pate, trứng. Đây là lựa chọn lý tưởng cho bữa sáng hoặc bữa ăn nhẹ, dễ dàng mang theo và rất tiện lợi", "Bánh mì", "Carbs", true, "Breakfast,Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau muống là loại rau lá xanh phổ biến ở Việt Nam, có thể xào, luộc hoặc làm canh. Rau muống giàu vitamin, khoáng chất và chất xơ, giúp hỗ trợ tiêu hóa và giải nhiệt", "Rau muống", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún chả cá là món ăn với bún, chả cá chiên hoặc hấp và nước dùng từ cá. Món ăn này có vị ngọt tự nhiên từ cá, rất phổ biến ở miền Trung và Nam Việt Nam", "Bún chả cá", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt gà quay là món ăn có lớp da giòn, thịt mềm, được ướp gia vị rồi quay chín. Món này thường được ăn kèm với cơm hoặc rau sống, rất ngon miệng và dễ ăn", "Thịt gà quay", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Hoành thánh là món ăn từ bột mì, nhân thịt hoặc tôm, thường được nấu trong nước dùng thơm ngon. Món này có thể ăn trong các bữa sáng hoặc bữa tối, mang lại cảm giác ấm cúng và bổ dưỡng", "Hoành thánh", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau dền đỏ là loại rau xanh giàu vitamin C và chất xơ, giúp hỗ trợ tiêu hóa và tăng cường miễn dịch. Rau dền đỏ có thể xào, nấu canh hoặc làm món gỏi, rất bổ dưỡng", "Rau dền đỏ", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Chuối tây là trái cây ngọt, dễ ăn, giàu kali và vitamin. Chuối tây thường được ăn trực tiếp hoặc làm tráng miệng, sinh tố, chè. Đây là món ăn bổ dưỡng và dễ tiêu hóa, thích hợp cho mọi lứa tuổi", "Chuối tây", "Dessert", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Táo là trái cây giàu vitamin C và chất xơ, tốt cho tiêu hóa và hệ tim mạch. Táo có thể ăn trực tiếp hoặc làm sinh tố, salad, giúp tăng cường sức khỏe và cung cấp năng lượng tự nhiên cho cơ thể", "Táo", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo đậu đỏ là món ăn nhẹ nhàng, làm từ đậu đỏ và gạo, có tác dụng bổ máu, thanh nhiệt. Món này có thể ăn vào buổi sáng hoặc tối, rất bổ dưỡng và dễ tiêu hóa", "Cháo đậu đỏ", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Quýt là trái cây ngọt, chứa nhiều vitamin C và giúp tăng cường hệ miễn dịch. Quýt có thể ăn trực tiếp hoặc làm nước ép, rất tốt cho sức khỏe, đặc biệt là giúp giải nhiệt trong mùa hè", "Quýt", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Đậu hũ là món ăn được làm từ đậu nành, giàu protein thực vật. Đậu hũ có thể chế biến theo nhiều cách như chiên, nấu canh hoặc xào, mang lại hương vị thanh nhẹ và tốt cho sức khỏe", "Đậu hũ", "Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Nho là trái cây ngọt, giàu vitamin C và chất chống oxy hóa, có tác dụng tăng cường sức đề kháng và làm đẹp da. Nho có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng", "Nho", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Nấm kim châm là loại nấm có thân dài và mỏng, thường được dùng trong các món canh, xào hoặc salad. Nấm kim châm giàu chất xơ và khoáng chất, rất tốt cho sức khỏe, đặc biệt là hệ tiêu hóa", "Nấm kim châm", "Vegetables", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2146faae-2e7c-4460-8d81-38f5d313012c"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo đậu xanh là món ăn nhẹ, dễ tiêu hóa, được làm từ đậu xanh và gạo, có tác dụng bổ máu và thanh nhiệt. Món này có thể ăn vào bữa sáng hoặc tối, rất bổ dưỡng", "Cháo đậu xanh", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh bao chay là món ăn làm từ bột mì, nhân là các loại rau củ, đậu hũ hoặc nấm. Đây là món ăn phù hợp cho những người ăn chay, với hương vị nhẹ nhàng và bổ dưỡng", "Bánh bao chay", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish,MainDish", "Đậu hũ non là món ăn được làm từ đậu nành, có kết cấu mềm mịn. Đậu hũ non có thể chế biến thành các món xào, canh hoặc ăn kèm với siro, là món ăn dễ tiêu hóa và rất bổ dưỡng", "Đậu hũ non", "Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Khoai lang luộc là món ăn đơn giản nhưng giàu dinh dưỡng, cung cấp vitamin A, chất xơ và khoáng chất. Khoai lang có thể ăn trực tiếp hoặc dùng làm món ăn kèm trong các bữa chính", "Khoai lang luộc", "Carbs", true, "Breakfast,Snack,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2405ffc3-524e-4331-9e68-47a411d7b9b8"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm chiên dương châu là món cơm chiên với các loại rau củ, tôm, thịt, trứng, mang đến hương vị đậm đà và đầy đủ dinh dưỡng. Món này thích hợp cho bữa trưa hoặc tối", "Cơm chiên dương châu", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Cải thảo là loại rau xanh, thường được dùng trong các món xào, nấu canh hoặc làm gỏi. Cải thảo chứa nhiều vitamin và khoáng chất, giúp hỗ trợ tiêu hóa và cải thiện sức khỏe", "Cải thảo", "Vegetables", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh bao xá xíu là món bánh mềm mịn, với nhân thịt heo xá xíu thơm ngon. Món này rất phổ biến trong các bữa sáng hoặc bữa ăn nhanh gọn, giàu protein và dễ tiêu hóa", "Bánh bao xá xíu", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("29dfb5da-8818-40ff-bf66-7553521c2161"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bò kho là món ăn với thịt bò hầm mềm mịn, nước dùng đậm đà với gia vị thơm ngon. Món này thường ăn kèm với bánh mì hoặc bún, là bữa ăn đầy đủ và ấm áp", "Bò kho", "Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ae82bfd-34db-4928-bfee-b60f4aec4460"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh bí đỏ là món ăn thanh mát, giàu vitamin A và C. Canh bí đỏ có thể nấu với thịt heo hoặc tôm, mang lại hương vị ngọt tự nhiên, bổ dưỡng và dễ tiêu hóa", "Canh bí đỏ", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau cải xanh là loại rau giàu vitamin A, C và chất xơ, có thể chế biến thành các món xào, luộc hoặc nấu canh. Món rau cải xanh cung cấp nhiều dưỡng chất và giúp thanh nhiệt cho cơ thể", "Rau cải xanh", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh mì ốp la là món ăn sáng phổ biến với bánh mì giòn, nhân trứng ốp la và có thể kèm thịt, rau. Đây là món ăn nhanh gọn, dễ dàng và bổ dưỡng", "Bánh mì ốp la", "Carbs,Protein", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Dâu tây là trái cây ngọt, chứa nhiều vitamin C và chất chống oxy hóa, giúp làm đẹp da và tăng cường sức đề kháng. Dâu tây có thể ăn trực tiếp, làm sinh tố, hoặc chế biến thành các món tráng miệng", "Dâu tây", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Sữa đậu nành là thức uống từ đậu nành xay nhuyễn, giàu protein và vitamin. Đây là món ăn sáng phổ biến, bổ dưỡng, có thể uống nóng hoặc lạnh, đặc biệt tốt cho người ăn chay và những người muốn bổ sung dưỡng chất từ thực vật", "Sữa đậu nành", "Drink,Protein", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ee163f7-4463-44ec-b9e2-8a409c112db4"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau luộc là món ăn thanh mát, giúp bổ sung vitamin và khoáng chất, rất tốt cho sức khỏe. Các loại rau như rau muống, rau ngót thường được luộc và ăn kèm với nước mắm hoặc gia vị", "Rau luộc", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo lòng là món ăn sáng phổ biến, được làm từ cháo gạo nấu với các loại nội tạng heo như lòng, gan, dồi. Món này có vị đậm đà, thường ăn kèm với hành lá, rau thơm và gia vị", "Cháo lòng", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Khoai lang là một loại củ giàu vitamin và chất xơ, có thể chế biến thành các món như khoai lang luộc, chiên, hoặc làm món xào. Món này cung cấp năng lượng và rất tốt cho sức khỏe", "Khoai lang", "Carbs", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("30f9d9dc-1653-495c-99b7-b649c49f7930"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh cuốn thịt bằm là món ăn được làm từ bột gạo, nhân thịt bằm, mộc nhĩ và gia vị, ăn kèm với nước mắm chua ngọt và rau sống. Món này rất phổ biến ở miền Bắc Việt Nam", "Bánh cuốn thịt bằm", "Carbs,Protein", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Cải thìa là loại rau xanh giàu vitamin và khoáng chất, có thể chế biến theo nhiều cách như xào, luộc hoặc nấu canh. Cải thìa giúp giải nhiệt và tốt cho hệ tiêu hóa, thường dùng trong các bữa ăn gia đình", "Cải thìa", "Vegetables", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Súp gà nấm là món ăn nhẹ nhàng với nước dùng từ gà và nấm, giúp thanh nhiệt và dễ tiêu hóa. Món này thường ăn vào bữa sáng hoặc khi cần bồi bổ cơ thể", "Súp gà nấm", "Protein,Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Măng khô là món ăn được làm từ măng tươi phơi khô, có thể chế biến thành các món canh hoặc xào. Măng khô có vị ngọt tự nhiên, giòn và là món ăn bổ dưỡng trong các bữa ăn gia đình", "Măng khô", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Nước chanh là thức uống giải khát tuyệt vời, giúp cung cấp vitamin C, giải nhiệt và làm đẹp da. Món này có thể uống vào bất kỳ thời gian nào trong ngày, đặc biệt là trong mùa hè", "Nước chanh", "Drink", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3d19d971-88d0-4108-a335-24ac9e1dec50"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Măng cụt là trái cây ngọt, mọng nước, chứa nhiều vitamin C và khoáng chất. Món này có thể ăn trực tiếp hoặc làm nước ép, mang lại cảm giác giải nhiệt và bổ sung dinh dưỡng", "Măng cụt", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3dc2fa80-ab87-4e26-907b-3516611371b8"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh bầu là món canh thanh mát, với bầu nấu cùng nước dùng nhẹ nhàng từ xương hoặc thịt. Món canh này có tác dụng giải nhiệt, rất thích hợp trong những ngày hè nóng bức", "Canh bầu", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Đậu nành luộc là món ăn nhẹ, giàu protein và vitamin. Đậu nành có thể ăn trực tiếp hoặc chế biến thành các món như đậu hũ, giúp bổ sung dinh dưỡng cho cơ thể", "Đậu nành luộc", "Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("404a286a-90c5-4c54-8e27-3ddeba55ada3"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Hạt dẻ cười là loại hạt giàu chất béo lành mạnh, vitamin E và khoáng chất, giúp bảo vệ tim mạch và cung cấp năng lượng. Hạt dẻ cười có thể ăn trực tiếp hoặc thêm vào các món tráng miệng, salad", "Hạt dẻ cười", "Snack,Protein", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Đậu bắp là loại rau quả giàu vitamin C và chất xơ, giúp hỗ trợ tiêu hóa và làm đẹp da. Đậu bắp có thể ăn luộc, xào hoặc làm canh, là món ăn bổ dưỡng cho các bữa ăn gia đình", "Đậu bắp", "Vegetables", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Cà chua là thực phẩm giàu vitamin C và chất xơ, có tác dụng làm đẹp da và hỗ trợ tiêu hóa. Cà chua có thể ăn sống, làm salad, hoặc chế biến thành các món xào, canh", "Cà chua", "Vegetables", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("43d635e2-6f0c-4385-83d8-fedfd479d356"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt gà kho là món ăn đậm đà với thịt gà kho trong gia vị như nước mắm, tiêu, và gia vị khác. Món này có thể ăn kèm với cơm trắng, mang lại hương vị ngon miệng và bổ dưỡng", "Thịt gà kho", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Dưa chuột là rau quả tươi mát, giúp giải nhiệt và làm đẹp da. Dưa chuột có thể ăn sống, làm salad, hoặc chế biến thành món xào và canh, rất thích hợp trong các bữa ăn hằng ngày để thanh lọc cơ thể", "Dưa chuột", "Vegetables", true, "Breakfast,Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún chả là món ăn đặc sản Hà Nội, gồm bún, thịt chả nướng, và rau sống. Món ăn này có nước mắm pha chua ngọt, tạo thành bữa ăn ngon miệng, đậm đà và rất dễ ăn", "Bún chả", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún mắm là món ăn nổi bật với nước dùng từ mắm, kết hợp với bún và các loại hải sản như tôm, cá. Đây là món ăn đặc sản của miền Tây, mang lại hương vị đậm đà và rất thơm ngon", "Bún mắm", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Dừa tươi là thức uống giải khát tuyệt vời, giàu vitamin C và khoáng chất. Nước dừa cung cấp độ ẩm và giúp thanh nhiệt, rất tốt cho làn da và sức khỏe hệ tiêu hóa", "Dừa tươi", "Drink", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Tôm hấp là món ăn đơn giản, dễ chế biến, giữ nguyên vị ngọt của tôm. Món này thường được ăn kèm với muối tiêu chanh hoặc nước mắm chua ngọt, thích hợp cho bữa ăn nhẹ", "Tôm hấp", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4e46f955-4413-496f-97b4-968a38ee3e11"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Hạt hướng dương là loại hạt giàu vitamin E, chất béo lành mạnh và protein. Hạt có thể ăn trực tiếp như món snack hoặc thêm vào salad, rất tốt cho sức khỏe tim mạch và giúp cung cấp năng lượng", "Hạt hướng dương", "Snack,Protein", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4edcae53-7e30-42bb-8526-7686355f2268"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh cải xanh là món canh nhẹ, giàu vitamin và khoáng chất, thường được nấu với thịt heo hoặc tôm. Đây là món ăn bổ dưỡng, dễ tiêu hóa và thích hợp cho các bữa ăn thanh đạm", "Canh cải xanh", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish,MainDish", "Đậu hũ chiên là món ăn phổ biến trong các bữa ăn chay, có kết cấu giòn bên ngoài và mềm mịn bên trong. Món này có thể ăn kèm với các loại nước chấm hoặc xào với rau củ", "Đậu hũ chiên", "Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("51061170-597d-4289-a021-1e7dde88331f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt vịt là nguồn protein giàu chất dinh dưỡng, có thể chế biến thành nhiều món như vịt nướng, vịt kho hoặc vịt luộc. Món thịt vịt thường có hương vị đặc trưng, đậm đà và thích hợp cho các bữa ăn gia đình", "Thịt vịt", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bò bít tết là món ăn từ thịt bò nạc, được nướng hoặc áp chảo đến độ chín vừa phải. Món này thường được ăn kèm với khoai tây chiên hoặc rau sống, mang lại hương vị đậm đà, rất thích hợp cho bữa tối", "Bò bít tết", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh chua cá là món ăn đậm đà với nước dùng chua ngọt, thường làm từ cá và các loại rau như giá đỗ, ngò rí, ăn kèm với bún. Món này thanh mát, giải nhiệt và rất bổ dưỡng", "Canh chua cá", "Protein,Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rong biển khô là thực phẩm giàu vitamin, khoáng chất và chất xơ, rất tốt cho sức khỏe. Món rong biển có thể dùng làm salad, súp, hoặc làm nhân cho sushi, rất phổ biến trong ẩm thực châu Á", "Rong biển khô", "Vegetables,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Ớt chuông là loại rau quả giàu vitamin C, giúp tăng cường sức khỏe và làm đẹp da. Ớt chuông có thể ăn sống, xào, hoặc làm salad, mang lại hương vị tươi mát và màu sắc đẹp mắt cho bữa ăn", "Ớt chuông", "Vegetables", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Cải bó xôi là rau xanh giàu vitamin A, C và chất sắt. Món cải bó xôi có thể ăn sống trong salad, xào hoặc nấu canh, giúp tăng cường sức khỏe xương và cải thiện hệ miễn dịch", "Cải bó xôi", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("59988378-901f-4ec4-bd6c-9fdc28ca97a1"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Hạt bí ngô là món snack bổ dưỡng, giàu magiê và kẽm, có thể ăn trực tiếp hoặc rắc lên salad. Món này giúp tăng cường hệ miễn dịch và rất tốt cho sức khỏe tim mạch", "Hạt bí ngô", "Snack,Protein", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm là món ăn chủ yếu trong bữa ăn Việt Nam, cung cấp tinh bột quan trọng. Cơm thường ăn kèm với các món mặn như thịt, cá và rau, tạo nên một bữa ăn đầy đủ dinh dưỡng, bổ sung năng lượng cho cơ thể", "Cơm", "Carbs", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Lựu là trái cây giàu vitamin C, chất chống oxy hóa và khoáng chất. Món này có thể ăn trực tiếp hoặc làm nước ép, giúp cải thiện hệ miễn dịch và làm đẹp da", "Lựu", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Cá ngừ đóng hộp là món ăn tiện lợi, giàu protein và omega-3. Món này có thể ăn trực tiếp, làm salad hoặc kèm với cơm, rất dễ chế biến và thích hợp cho bữa ăn nhanh", "Cá ngừ đóng hộp", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Súp cua là món ăn nhẹ với nước dùng từ cua, mang hương vị ngọt tự nhiên và bổ dưỡng. Món này thường được ăn vào bữa sáng hoặc bữa tối, rất giàu protein và khoáng chất", "Súp cua", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt kho trứng là món ăn quen thuộc với thịt heo kho cùng trứng luộc, mang hương vị mặn ngọt đậm đà. Món này thường ăn kèm với cơm trắng, rất ngon miệng và bổ dưỡng", "Thịt kho trứng", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Mì Quảng là món đặc sản của miền Trung, gồm mì gạo, nước dùng đậm đà, tôm, thịt hoặc trứng, và rau sống. Món ăn này có vị đặc trưng và rất thích hợp cho bữa sáng hoặc trưa", "Mì Quảng", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Nấm đùi gà có hình dạng giống đùi gà, thịt nấm mềm và thơm. Món này thường được dùng trong các món xào, nấu canh hoặc làm salad, rất giàu dinh dưỡng và dễ chế biến", "Nấm đùi gà", "Vegetables,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh cua mồng tơi là món ăn dân dã, có vị ngọt từ cua và mồng tơi. Món này không chỉ thơm ngon mà còn rất bổ dưỡng, đặc biệt tốt cho hệ tiêu hóa và làn da", "Canh cua mồng tơi", "Protein,Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("642480b4-22c9-4350-a6ce-c052f99e60e3"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Lúa mạch là ngũ cốc giàu chất xơ và protein, có thể chế biến thành cháo, bánh hoặc thêm vào các món salad. Lúa mạch giúp cải thiện tiêu hóa và cung cấp năng lượng bền vững cho cơ thể", "Lúa mạch", "Carbs,Protein", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau mồng tơi là loại rau xanh giàu vitamin A và chất sắt, có thể chế biến thành các món xào, luộc hoặc canh. Món rau này giúp thanh nhiệt, giải độc và tốt cho hệ tiêu hóa", "Rau mồng tơi", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6487a532-ff5e-4b77-b408-46c789608de9"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh bí đao là món canh mát, giúp giải nhiệt và thanh lọc cơ thể. Bí đao có thể nấu với tôm, thịt heo hoặc cá, mang lại hương vị thanh đạm và rất bổ dưỡng cho sức khỏe", "Canh bí đao", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh rau ngót là món canh thanh mát, có vị ngọt tự nhiên từ rau ngót. Món này thường được nấu với thịt hoặc tôm, giúp giải nhiệt và bổ sung dinh dưỡng cho cơ thể", "Canh rau ngót", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Bánh mì sandwich là món ăn nhanh với lớp bánh mì mềm, nhân có thể là thịt, rau, trứng hoặc phô mai. Đây là lựa chọn lý tưởng cho bữa sáng hoặc bữa phụ, dễ dàng mang theo khi đi làm hoặc đi học", "Bánh mì sandwich", "Carbs,Protein", true, "Breakfast,Lunch,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("68c8c4c4-e5d6-4e15-ad60-1c18f0c1cb4d"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Hạt kê là loại hạt giàu protein, chất xơ và khoáng chất như sắt và magiê. Hạt kê có thể nấu cháo, làm bánh hoặc thêm vào các món salad, là lựa chọn bổ dưỡng cho các bữa ăn nhẹ", "Hạt kê", "Carbs,Protein", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Cà phê là thức uống quen thuộc, có thể uống đen hoặc thêm sữa, với hương vị đậm đà và kích thích tinh thần. Cà phê thường được uống vào buổi sáng hoặc trong suốt cả ngày để duy trì sự tỉnh táo", "Cà phê", "Drink", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert,SideDish", "Rau má là loại rau mát, giúp thanh nhiệt, giải độc và làm đẹp da. Rau má có thể ăn sống trong salad hoặc nấu canh, rất tốt cho sức khỏe và có tác dụng làm dịu cơ thể trong mùa hè", "Rau má", "Vegetables", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Hủ tiếu là món ăn gồm mì hoặc bún ăn kèm với nước dùng thơm ngon và các loại thịt như tôm, gà, hoặc heo. Món này phổ biến ở miền Nam Việt Nam và rất dễ ăn, thích hợp cho bữa sáng hoặc bữa tối", "Hủ tíu", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo sườn là món ăn sáng phổ biến, với cháo mềm mịn kết hợp cùng sườn heo kho hoặc hầm. Món này có vị ngọt tự nhiên từ xương, thường ăn kèm với hành lá, rau thơm và gia vị", "Cháo sườn", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7167f942-dc89-4f29-8022-588373aef45e"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún gà là món ăn thanh mát với bún, thịt gà luộc hoặc xé nhỏ và nước dùng thơm ngon. Đây là món ăn nhẹ nhàng, thích hợp cho bữa sáng hoặc bữa trưa", "Bún gà", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Canh bún là món ăn nổi bật với nước dùng ngọt từ xương, kết hợp với bún, thịt heo hoặc tôm. Món này thường ăn kèm với rau sống và gia vị, mang lại hương vị đậm đà và dễ ăn", "Canh bún", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Sườn non là phần thịt heo mềm, có thể chế biến thành nhiều món như sườn nướng, sườn kho hoặc sườn xào chua ngọt. Món sườn non rất thích hợp cho các bữa cơm gia đình, có vị đậm đà và dễ ăn", "Sườn non", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("731974ef-495e-4c08-ba95-20589d60c20c"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Hạt mắc ca là loại hạt giàu chất béo lành mạnh, vitamin E và khoáng chất, giúp cải thiện sức khỏe tim mạch. Hạt có thể ăn trực tiếp hoặc thêm vào salad, rất bổ dưỡng và dễ tiêu hóa", "Hạt mắc ca", "Snack", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh bao là món ăn đơn giản, với lớp vỏ mềm mịn và nhân thịt heo hoặc trứng. Đây là món ăn nhanh gọn, thường được ăn sáng hoặc làm món phụ trong các bữa ăn chính", "Bánh bao", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Cà rốt là rau củ giàu vitamin A, giúp cải thiện thị lực và sức khỏe da. Cà rốt có thể ăn sống, làm salad, hoặc chế biến thành các món xào, canh hoặc nước ép", "Cà rốt", "Vegetables", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh mì thịt trứng là món ăn nhanh, với bánh mì mềm, nhân thịt nướng và trứng chiên. Đây là món ăn sáng phổ biến, đơn giản nhưng đầy đủ dinh dưỡng, dễ ăn và tiện lợi", "Bánh mì thịt trứng", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún xào là món ăn ngon miệng với bún xào cùng các loại rau và thịt hoặc tôm. Món này thường được chế biến nhanh, có vị thơm, ngọt từ các nguyên liệu kết hợp, thường ăn vào bữa trưa hoặc tối", "Bún xào", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7729551a-e475-4079-aaa0-07c02efde2a5"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Hạt lanh là nguồn tuyệt vời cung cấp omega-3, chất xơ và lignans, giúp bảo vệ tim mạch và giảm viêm. Hạt lanh có thể thêm vào các món sinh tố, salad hoặc dùng để nướng bánh", "Hạt lanh", "Protein", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm tấm sườn là món ăn phổ biến ở miền Nam Việt Nam, bao gồm cơm tấm mềm mịn ăn kèm với sườn nướng và các loại rau sống. Món này mang lại hương vị đậm đà và đầy đủ dinh dưỡng", "Cơm tấm sườn", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7a253877-3c54-4fcf-bb05-d9f4e14d5b64"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Mì xào thập cẩm là món ăn với mì, các loại rau củ và thịt, xào chung với gia vị đậm đà. Món này dễ chế biến và là bữa ăn nhanh gọn nhưng đầy đủ dưỡng chất", "Mì xào thập cẩm", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Măng tây là loại rau giàu vitamin K và chất chống oxy hóa, tốt cho sức khỏe tim mạch và hệ xương. Măng tây có thể xào, nấu canh hoặc ăn sống, rất bổ dưỡng và dễ chế biến", "Măng tây", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Kiwi là trái cây giàu vitamin C, chất xơ và chất chống oxy hóa. Kiwi giúp cải thiện hệ tiêu hóa, tăng cường sức đề kháng và làm đẹp da. Món này có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng", "Kiwi", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Súp bò hầm là món ăn có nước dùng đậm đà từ xương bò, với thịt bò mềm và rau củ đi kèm. Món này cung cấp năng lượng và dưỡng chất, rất phù hợp cho bữa tối", "Súp bò hầm", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b8500af-d730-4138-9617-cba352faed4a"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Vải là trái cây ngọt, chứa nhiều vitamin C và khoáng chất. Vải có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng, đặc biệt trong mùa hè", "Vải", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7cd76708-7312-445e-a392-14f0e806a786"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Đậu Hà Lan là loại rau giàu vitamin, khoáng chất và chất xơ, giúp hỗ trợ hệ tiêu hóa và tăng cường miễn dịch. Đậu Hà Lan có thể ăn trực tiếp, làm salad hoặc nấu canh", "Đậu Hà Lan", "Protein,Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún thịt nướng là món ăn gồm bún mềm, thịt nướng thơm ngon và các loại rau sống. Món này có thể ăn kèm với nước mắm pha, tạo thành một bữa ăn vừa thanh mát vừa đầy đủ dinh dưỡng", "Bún thịt nướng", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Bầu là loại rau quả mát, chứa nhiều vitamin và khoáng chất. Bầu có thể chế biến thành các món canh, xào hoặc làm gỏi, giúp thanh nhiệt và hỗ trợ tiêu hóa", "Bầu", "Vegetables", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Cá ngừ là loại hải sản giàu omega-3 và protein, có thể chế biến thành nhiều món như cá ngừ nướng, cá ngừ kho hoặc làm sushi. Món này rất bổ dưỡng và dễ dàng chế biến", "Cá ngừ", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("827829bf-71cd-4865-80af-1457e0091456"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh nấm là món ăn nhẹ, bổ dưỡng, giàu vitamin và chất xơ. Nấm có thể kết hợp với rau củ hoặc thịt để tạo ra món canh thơm ngon, rất phù hợp cho bữa ăn thanh đạm", "Canh nấm", "Vegetables,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Bông cải xanh (súp lơ) là loại rau chứa nhiều vitamin C, vitamin K và chất chống oxy hóa. Bông cải xanh có thể xào, luộc hoặc làm món canh, là món ăn bổ dưỡng giúp cải thiện sức khỏe", "Bông cải xanh", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8382816f-1beb-4804-9698-3b486798b20a"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh mì chả lụa là món ăn sáng phổ biến, với bánh mì giòn và nhân chả lụa thơm ngon. Món này đơn giản, dễ ăn và thích hợp cho bữa sáng hoặc bữa phụ", "Bánh mì chả lụa", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt kho tiêu là món ăn đơn giản nhưng thơm ngon, thường làm từ thịt ba chỉ hoặc thịt heo kho với tiêu, nước dừa và gia vị. Món này có vị mặn ngọt đậm đà, ăn cùng với cơm trắng rất hợp", "Thịt kho tiêu", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Củ cải trắng là loại rau củ giàu vitamin C và chất xơ, giúp thanh nhiệt và giải độc cơ thể. Món củ cải trắng có thể ăn sống, xào hoặc nấu canh, mang lại hương vị thanh mát và bổ dưỡng", "Củ cải trắng", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Củ cải đường là loại củ chứa nhiều vitamin C và khoáng chất, giúp cải thiện sức khỏe tim mạch và huyết áp. Món củ cải đường có thể ăn sống, xào hoặc nấu canh, mang lại lợi ích cho cơ thể", "Củ cải đường", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Xúc xích là món ăn làm từ thịt xay (thường là thịt heo hoặc bò), tẩm gia vị và nhồi vào ruột lợn, sau đó luộc hoặc nướng. Xúc xích dễ dàng chế biến và là món ăn nhanh gọn cho bữa sáng hoặc bữa phụ", "Xúc xích", "Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("85e621ed-0e0c-4d20-8891-51d311cea4a3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh thịt bò hầm là món canh đậm đà, với thịt bò hầm mềm cùng các gia vị và rau củ. Món này bổ dưỡng, cung cấp nhiều protein và khoáng chất, thích hợp cho bữa tối hoặc bữa chính", "Canh thịt bò hầm", "Protein,Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Ức gà nướng là món ăn ít mỡ, giàu protein, có thể được ướp gia vị và nướng chín. Món này thường được ăn kèm với rau củ hoặc cơm, là lựa chọn tốt cho bữa ăn nhẹ nhàng nhưng đầy đủ dinh dưỡng", "Ức gà nướng", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("86d88717-df08-4de6-b86d-870210864b46"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Thanh long là trái cây ngọt, mát, chứa nhiều vitamin C và khoáng chất, giúp tăng cường sức đề kháng và làm đẹp da. Thanh long có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng", "Thanh long", "Dessert", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Phở bò viên là món phở nổi tiếng với nước dùng trong, đậm đà từ xương bò, ăn kèm với bánh phở mềm và bò viên. Món này mang lại hương vị thơm ngon, phổ biến cho bữa sáng", "Phở bò viên", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh bí đỏ nấu tôm là món canh nhẹ, thanh mát, với bí đỏ nấu mềm kết hợp với tôm. Món canh này giàu vitamin A và protein, giúp bổ dưỡng và dễ tiêu hóa", "Canh bí đỏ nấu tôm", "Vegetables,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh mùng tơi mướp là món canh mát, giải nhiệt, giúp bổ sung dưỡng chất và hỗ trợ tiêu hóa. Món này thường được nấu với thịt hoặc tôm, mang lại hương vị thanh đạm và bổ dưỡng", "Canh mùng tơi mướp", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Khoai tây là nguồn cung cấp tinh bột và vitamin C. Khoai tây có thể chế biến thành nhiều món như khoai tây chiên, luộc, nghiền hoặc nướng, rất phổ biến trong các bữa ăn gia đình", "Khoai tây", "Carbs", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh hỏi là món ăn với bánh phở mềm, thường được ăn kèm với thịt nướng hoặc chả, và nước mắm pha. Món này có vị thanh nhẹ, rất phổ biến trong các bữa ăn ở miền Trung", "Bánh hỏi", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Khoai môn là loại củ giàu tinh bột và vitamin C, có thể chế biến thành các món xào, luộc, làm chè hoặc làm nhân bánh. Món khoai môn rất bổ dưỡng và dễ tiêu hóa", "Khoai môn", "Carbs", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Đậu hũ sốt cà là món ăn chay nhẹ nhàng, với đậu hũ mềm mịn ăn kèm với sốt cà chua đậm đà. Món này cung cấp protein thực vật và rất dễ chế biến, phù hợp cho các bữa ăn chay hoặc ăn kiêng", "Đậu hũ sốt cà", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8ebd5a6e-b0af-42b6-af58-b681fceac1ef"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Chè đậu đen là món tráng miệng phổ biến, làm từ đậu đen nấu nhừ, kết hợp với đường và có thể thêm nước cốt dừa. Món này ngọt mát, giúp thanh nhiệt và rất tốt cho sức khỏe", "Chè đậu đen", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8ed85dc2-7654-4c48-81f9-19946a73f71d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Bắp cải luộc là món ăn thanh mát, dễ làm, chứa nhiều vitamin và khoáng chất. Bắp cải luộc có thể ăn kèm với nước mắm hoặc làm món ăn phụ trong bữa ăn chính", "Bắp cải luộc", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún bò Huế là món ăn nổi tiếng với nước dùng đậm đà từ xương bò, mắm ruốc, và gia vị đặc trưng. Món này kết hợp bún, thịt bò, giò heo và rau sống, tạo nên hương vị thơm ngon, hấp dẫn cho bữa ăn", "Bún bò huế", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún ốc là món ăn nổi bật với nước dùng chua ngọt từ ốc và gia vị, kết hợp với bún và các loại rau sống. Món này có vị thơm ngon, thích hợp cho bữa trưa hoặc tối", "Bún ốc", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("90a605b6-843d-4cc1-8fe7-a016c76ee29c"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau muống luộc là món ăn đơn giản, dễ làm, rất phổ biến ở Việt Nam. Rau muống luộc có thể ăn kèm với nước mắm tỏi ớt hoặc làm món ăn phụ trong bữa cơm, giúp thanh nhiệt và bổ sung dưỡng chất", "Rau muống luộc", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Trà tắc là thức uống giải khát phổ biến, được làm từ trà xanh kết hợp với nước cốt chanh tươi và mật ong. Trà tắc giúp giải nhiệt, thanh lọc cơ thể và mang lại cảm giác sảng khoái", "Trà tắc", "Drink", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9349fefa-ecbc-4afc-89f4-62c2f67eb441"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish,MainDish", "Đậu đen là nguồn cung cấp protein thực vật và chất xơ tuyệt vời, giúp cải thiện hệ tiêu hóa. Đậu đen có thể nấu cháo, chè hoặc làm các món xào, rất bổ dưỡng cho sức khỏe", "Đậu đen", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Phở bò tái là món phở nổi tiếng với nước dùng trong, đậm đà từ xương bò, ăn kèm với thịt bò tái và bánh phở mềm. Món ăn này rất phổ biến vào buổi sáng ở Việt Nam, mang lại cảm giác ấm cúng và no lâu", "Phở bò tái", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh mì chả cá là món ăn sáng quen thuộc, với bánh mì mềm, nhân chả cá chiên thơm ngon và rau sống. Món này rất phổ biến ở Việt Nam, tiện lợi và dễ ăn", "Bánh mì chả cá", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Đậu que là loại rau quả giàu vitamin và chất xơ, có thể chế biến thành các món xào, luộc hoặc nấu canh. Đậu que giúp tăng cường hệ tiêu hóa và cung cấp năng lượng cho cơ thể", "Đậu que", "Vegetables", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("982d8f3e-f517-4bd2-87a8-48329fc9eb91"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh cải ngọt là món ăn nhẹ nhàng, với cải ngọt nấu trong nước dùng, có thể kết hợp với thịt heo hoặc tôm. Món canh này bổ dưỡng, dễ tiêu hóa và giúp thanh nhiệt", "Canh cải ngọt", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Sữa bò tươi là thức uống bổ dưỡng, cung cấp canxi, vitamin D và protein. Sữa bò có thể uống trực tiếp hoặc làm nguyên liệu cho các món sinh tố, mang lại nhiều lợi ích cho sức khỏe xương", "Sữa bò tươi", "Drink", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau cải bó xôi là loại rau xanh chứa nhiều vitamin A, C và chất sắt. Món cải bó xôi có thể ăn sống trong salad, xào hoặc nấu canh, rất bổ dưỡng và tốt cho sức khỏe xương", "Rau cải bó xôi", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau chân vịt (cải bó xôi) là loại rau giàu vitamin A, C và chất sắt, giúp tăng cường sức khỏe xương và hỗ trợ miễn dịch. Rau chân vịt có thể ăn sống trong salad, xào hoặc nấu canh", "Rau chân vịt", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau muống xào tỏi là món ăn phổ biến, với rau muống tươi xào cùng tỏi và gia vị. Món này có vị đậm đà, thơm ngon, rất thích hợp ăn kèm với cơm trắng", "Rau muống xào tỏi", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Cải ngọt luộc là món rau luộc đơn giản, dễ làm, giàu vitamin và chất xơ. Món này thường ăn kèm với nước mắm chua ngọt hoặc làm món ăn phụ trong các bữa ăn chính", "Cải ngọt luộc", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Gạo lứt là loại gạo nguyên hạt, giàu chất xơ, vitamin và khoáng chất. Món gạo lứt có thể ăn kèm với các món thịt hoặc rau, giúp duy trì năng lượng lâu dài và rất tốt cho hệ tiêu hóa", "Gạo lứt", "Carbs", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Cam là trái cây giàu vitamin C, giúp tăng cường miễn dịch và làm đẹp da. Cam có thể ăn trực tiếp hoặc làm nước ép, giúp giải nhiệt và bổ sung dinh dưỡng cho cơ thể", "Cam", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Sữa chua là món ăn từ sữa lên men, chứa nhiều vi khuẩn có lợi cho hệ tiêu hóa. Sữa chua có thể ăn trực tiếp hoặc làm thành các món tráng miệng, bổ dưỡng và dễ tiêu hóa", "Sữa chua", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a1ff09f1-9d02-40a8-84de-8da9aad67c58"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm rang là món ăn phổ biến, làm từ cơm nguội chiên với gia vị và các nguyên liệu như thịt, rau, trứng. Món này nhanh gọn, dễ chế biến và có thể ăn kèm với dưa leo hoặc salad", "Cơm rang", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá hồi hun khói là món ăn giàu omega-3, có hương vị đậm đà và thơm ngon từ quá trình hun khói. Món này thường được ăn kèm với bánh mì hoặc làm thành salad, rất bổ dưỡng và dễ ăn", "Cá hồi hun khói", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm gạo lức được làm từ gạo lức chưa xay xát hoàn toàn, giàu chất xơ và dinh dưỡng. Món này cung cấp năng lượng lâu dài, tốt cho sức khỏe và rất phổ biến trong các bữa ăn hàng ngày", "Cơm gạo lức", "Carbs", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Xoài là trái cây ngọt, thơm, giàu vitamin C và chất xơ. Xoài có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng", "Xoài", "Dessert", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a364353c-d589-4a94-9c3b-3038113ea249"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bò xào rau củ là món ăn ngon với thịt bò thái mỏng xào nhanh với các loại rau củ như ớt, hành tây, cà rốt. Món này cung cấp nhiều vitamin và protein, thích hợp cho bữa tối bổ dưỡng", "Bò xào rau củ", "Protein,Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún riêu cua là món ăn nổi tiếng với nước dùng chua ngọt, kết hợp với cua, bún và các loại rau sống. Món ăn này mang hương vị đặc trưng và bổ dưỡng, phù hợp cho bữa trưa hoặc tối", "Bún riêu cua", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Nước dừa là thức uống mát từ nước bên trong quả dừa, giúp giải nhiệt và bổ sung khoáng chất. Nó cũng rất tốt cho làn da và hệ tiêu hóa, thích hợp để uống trong mùa hè", "Nước dừa", "Drink", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a504d882-4f38-413e-bb28-fae1f2787150"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Nhãn là trái cây ngọt, mọng nước, chứa nhiều vitamin C và giúp tăng cường sức đề kháng. Nhãn có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng, rất tốt cho sức khỏe", "Nhãn", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Mực là hải sản giàu protein và khoáng chất, có thể chế biến thành các món xào, hấp, hoặc nướng. Mực có vị ngọt tự nhiên, giúp bổ sung dinh dưỡng và rất dễ ăn", "Mực", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 27 },
                    { new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt lợn xông khói có vị mặn ngọt, được chế biến bằng cách xông khói để tạo hương vị đặc trưng. Món này có thể ăn kèm với cơm, salad hoặc làm nhân cho bánh mì", "Thịt lợn xông khói", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt bò nạc là phần thịt ít mỡ, giàu protein và sắt, có thể chế biến thành các món như bò xào, nướng hoặc làm súp. Món ăn này cung cấp năng lượng và dưỡng chất cho cơ thể, thích hợp cho các bữa chính", "Thịt bò nạc", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish,MainDish", "Lòng đỏ trứng gà là phần chứa nhiều chất béo, protein và vitamin, rất tốt cho sự phát triển của cơ thể. Lòng đỏ trứng gà thường được sử dụng trong các món ăn như trứng bác, bánh hoặc các món ăn kèm", "Lòng đỏ trứng gà", "Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Mâm xôi là trái cây giàu vitamin C và chất chống oxy hóa, có tác dụng tốt cho hệ miễn dịch và làn da. Mâm xôi có thể ăn trực tiếp hoặc làm sinh tố, chè, tráng miệng", "Mâm xôi", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Súp khoai tây là món canh ngon và bổ dưỡng, với khoai tây nấu mềm trong nước dùng nhẹ nhàng. Món này thích hợp cho bữa tối, mang lại cảm giác ấm áp và dễ tiêu hóa", "Súp khoai tây", "Carbs", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a988cc73-072e-4af1-9b53-55fbf0f4fe79"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xào là món ăn đơn giản với rau củ được xào nhanh với gia vị. Món này thường sử dụng các loại rau như cải thảo, cải ngọt, giúp cung cấp vitamin và khoáng chất cho cơ thể", "Rau xào", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Chuối là trái cây ngọt, dễ ăn, cung cấp vitamin C và kali. Chuối rất tốt cho hệ tiêu hóa và tim mạch. Món này thường được ăn trực tiếp, làm sinh tố hoặc chế biến thành các món tráng miệng như chè", "Chuối", "Dessert", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Đào là trái cây ngọt, mọng nước, chứa nhiều vitamin C và chất chống oxy hóa. Món này có thể ăn trực tiếp, làm sinh tố hoặc chế biến thành các món tráng miệng, giúp tăng cường sức đề kháng", "Đào", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Bún là món ăn phổ biến ở Việt Nam, được chế biến từ gạo. Bún có thể kết hợp với các loại thịt, cá, hoặc rau, tạo thành những món như bún riêu, bún chả, bún bò Huế, mang lại hương vị đặc trưng", "Bún", "Carbs", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Ức vịt nướng là món ăn ngon miệng, thịt vịt mềm và mọng nước khi được ướp gia vị và nướng chín. Món này có thể ăn kèm với cơm hoặc rau sống, mang lại hương vị đậm đà", "Ức vịt nướng", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá thu nướng là món ăn thơm ngon, giàu protein và omega-3. Cá thu thường được ướp gia vị rồi nướng, tạo nên món ăn đậm đà và bổ dưỡng cho bữa tối", "Cá thu nướng", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("af036922-79f3-45a7-b562-a6279520c0e6"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Miến gà là món ăn nhẹ với miến mềm, nước dùng thơm ngon từ gà, ăn kèm với thịt gà xé nhỏ. Món này rất dễ ăn, thích hợp cho bữa sáng hoặc bữa trưa nhẹ nhàng", "Miến gà", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Đu đủ là trái cây ngọt, giàu vitamin C và enzym papain, giúp tiêu hóa tốt. Đu đủ có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng, rất tốt cho sức khỏe và làn da", "Đu đủ", "Dessert", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b0f051be-5972-4e7a-a77d-47ec28d58993"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Hạt hạnh nhân là loại hạt giàu chất béo lành mạnh, vitamin E và protein. Hạnh nhân có thể ăn trực tiếp, làm snack hoặc thêm vào các món salad, mang lại lợi ích cho sức khỏe tim mạch", "Hạt hạnh nhân", "Snack,Protein", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Đậu hà lan luộc là món ăn giàu protein và chất xơ, có thể ăn trực tiếp hoặc chế biến thành salad. Món này có vị ngọt tự nhiên, rất bổ dưỡng và dễ chế biến", "Đậu Hà Lan luộc", "Protein,Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh rau dền là món ăn nhẹ nhàng, thanh mát, thường được nấu với thịt hoặc tôm. Rau dền chứa nhiều vitamin và khoáng chất, giúp cải thiện sức khỏe và hỗ trợ tiêu hóa", "Canh rau dền", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá kho là món ăn đậm đà với cá kho trong nước mắm, tiêu và các gia vị khác. Món này có thể ăn kèm với cơm trắng, mang lại hương vị mặn ngọt và rất bổ dưỡng", "Cá kho", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt heo kho là món ăn với thịt heo được kho mềm, thấm đẫm gia vị mặn ngọt. Món này thường ăn kèm với cơm trắng, tạo thành một bữa ăn đậm đà và bổ dưỡng", "Thịt heo kho", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm chiên là món ăn phổ biến, được làm từ cơm nguội chiên cùng với thịt, trứng và rau củ. Món này thường ăn kèm với dưa leo hoặc salad, rất dễ ăn và tiện lợi", "Cơm chiên", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt gà là nguồn protein nhẹ nhàng, giàu dinh dưỡng. Thịt gà có thể chế biến thành nhiều món như gà kho, gà luộc, hoặc gà xào. Đây là lựa chọn phổ biến trong các bữa ăn hàng ngày", "Thịt gà", "Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh bèo là món ăn dân dã của miền Trung, gồm bánh làm từ bột gạo, thường được phủ lên trên các loại tôm, thịt hoặc mỡ hành. Món này có thể ăn kèm với nước mắm chua ngọt", "Bánh bèo", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Bắp luộc là món ăn đơn giản nhưng bổ dưỡng, chứa nhiều chất xơ và vitamin. Bắp luộc có thể ăn trực tiếp hoặc làm món ăn kèm trong bữa ăn, đặc biệt là vào mùa hè", "Bắp luộc", "Carbs", true, "Snack,Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish,MainDish", "Trứng gà luộc là món ăn đơn giản, giàu protein, vitamin B12 và khoáng chất. Trứng gà thường được ăn sáng hoặc dùng làm món phụ trong bữa ăn chính, giúp cung cấp năng lượng và duy trì sức khỏe", "Trứng gà luộc", "Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Yến mạch là ngũ cốc giàu chất xơ và vitamin, giúp giảm cholesterol và hỗ trợ tiêu hóa. Món yến mạch có thể nấu cháo hoặc làm sinh tố, thích hợp cho bữa sáng bổ dưỡng", "Yến mạch", "Carbs,Protein", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c5e3e4ed-0164-4917-a1ce-99679b971a22"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo gà là món ăn nhẹ, với cháo mịn và thịt gà chín mềm, thường ăn kèm với hành lá, rau thơm và gia vị. Món này dễ tiêu hóa, phù hợp cho bữa sáng hoặc khi bạn cảm thấy mệt mỏi", "Cháo gà", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh rau củ là món ăn nhẹ nhàng, giàu vitamin và chất xơ, thích hợp cho các bữa ăn dinh dưỡng. Các loại rau như cà rốt, khoai tây, đậu que được nấu chung tạo thành món canh thơm ngon, dễ ăn", "Canh rau củ", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c81a404a-ec10-428e-acec-dd56ec1d3607"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Nem chua là món ăn đặc sản, được làm từ thịt heo xay nhuyễn, gia vị và gói trong lá chuối, lên men tự nhiên. Món này có vị chua nhẹ, thơm ngon, thường ăn kèm với tỏi, ớt hoặc rau sống", "Nem chua", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Mì gạo lứt được làm từ gạo lứt nguyên hạt, giàu chất xơ và vitamin. Món mì này có thể chế biến thành các món xào, soup hoặc ăn kèm với thịt, rất tốt cho sức khỏe và giúp giảm cholesterol", "Mì gạo lứt", "Carbs", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Chôm chôm là trái cây ngọt, có vỏ đỏ hoặc vàng, mọng nước và giàu vitamin C. Món này rất thích hợp trong mùa hè, giúp giải nhiệt và bổ sung dinh dưỡng", "Chôm chôm", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Hồng xiêm là trái cây ngọt, có hương vị đặc trưng, giàu vitamin C và khoáng chất. Món này có thể ăn trực tiếp hoặc chế biến thành các món tráng miệng, sinh tố, rất tốt cho sức khỏe", "Hồng xiêm", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("cf9ab10f-2094-496b-9018-96b9d2e1af76"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm gà là món ăn đơn giản với cơm trắng ăn kèm thịt gà luộc hoặc chiên, thường được dùng kèm với nước mắm, rau sống và canh. Món này ngon miệng, dễ chế biến và bổ dưỡng", "Cơm gà", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh hẹ tôm là món canh thanh mát, với tôm và hẹ nấu chung trong nước dùng thơm ngon. Món này giúp bổ sung protein và vitamin, rất dễ ăn và thích hợp cho các bữa ăn nhẹ", "Canh hẹ tôm", "Protein,Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm chiên trứng là món ăn đơn giản nhưng ngon miệng, được làm từ cơm nguội xào cùng trứng, có thể thêm các loại rau và thịt tùy thích. Món này phù hợp cho bữa trưa hoặc tối nhanh gọn và đầy đủ dinh dưỡng", "Cơm chiên trứng", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Sữa chua Hy Lạp là loại sữa chua đặc, chứa nhiều probiotics giúp hỗ trợ tiêu hóa. Món này có thể ăn trực tiếp hoặc kết hợp với trái cây tươi, mang lại cảm giác ngon miệng và bổ dưỡng", "Sữa chua Hy Lạp", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt lợn nạc là phần thịt ít mỡ, dễ chế biến thành các món như xào, kho hoặc nướng. Món này cung cấp protein và chất sắt, thường được ăn trong các bữa chính", "Thịt lợn nạc", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá thu là loại hải sản giàu omega-3 và protein, rất tốt cho sức khỏe tim mạch. Cá thu có thể nướng, chiên hoặc kho, mang lại hương vị thơm ngon và bổ dưỡng cho bữa ăn", "Cá thu", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh canh là món ăn nổi bật với nước dùng đậm đà, có thể làm từ bún hoặc bánh canh, ăn kèm với các loại thịt như cua, tôm, hoặc giò heo. Món này rất phổ biến ở miền Trung và Nam Việt Nam", "Bánh canh", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh bột lọc là món ăn đặc trưng của miền Trung, gồm vỏ bánh làm từ bột năng, nhân tôm hoặc thịt, sau đó hấp chín. Món này thường ăn kèm với nước mắm chua ngọt và rau sống", "Bánh bột lọc", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún hải sản là món ăn đậm đà với bún, nước dùng từ hải sản và các loại hải sản như tôm, cua, mực. Món này có hương vị đặc trưng và rất bổ dưỡng", "Bún hải sản", "Carbs,Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Dưa cải chua là món ăn lên men, được làm từ cải thảo hoặc cải bẹ, mang vị chua nhẹ. Món này thường ăn kèm với cơm, giúp hỗ trợ tiêu hóa và bổ sung lợi khuẩn cho hệ tiêu hóa", "Dưa cải chua", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Phở gà là món ăn nhẹ nhàng, nước dùng thơm từ gà, ăn kèm với bánh phở và thịt gà. Món này có thể ăn vào buổi sáng hoặc bữa tối, rất thanh đạm nhưng đầy đủ dinh dưỡng", "Phở gà", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Hành tây là loại củ gia vị phổ biến, mang lại hương vị thơm ngon cho các món xào, canh hoặc salad. Hành tây có tác dụng tốt cho sức khỏe tim mạch và giúp cải thiện hệ tiêu hóa", "Hành tây", "Vegetables", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Chả lụa là món ăn được làm từ thịt heo xay nhuyễn, cuộn chặt và hấp chín. Món này thường dùng trong các bữa ăn chính, bánh mì hoặc cơm, mang lại hương vị ngọt mềm, thơm ngon", "Chả lụa", "Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Cá khô là món ăn truyền thống, có thể làm từ nhiều loại cá, chế biến bằng cách phơi khô. Cá khô có vị mặn, thơm, thường được ăn kèm với cơm trắng hoặc làm nguyên liệu cho các món canh", "Cá khô", "Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Ức gà là phần thịt ít mỡ, giàu protein và dễ chế biến. Món ức gà có thể nướng, xào, hấp hoặc luộc, cung cấp năng lượng và dưỡng chất cho cơ thể, phù hợp với bữa trưa hoặc tối", "Ức gà", "Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Nước cam là thức uống từ cam tươi, cung cấp vitamin C và chất chống oxy hóa. Nước cam là lựa chọn tuyệt vời để giải khát và bổ sung dưỡng chất cho cơ thể, đặc biệt trong mùa lạnh", "Nước cam", "Drink", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Cà phê sữa là thức uống phổ biến ở Việt Nam, được pha chế từ cà phê đen đặc kết hợp với sữa đặc ngọt. Món này có vị đắng nhẹ kết hợp với ngọt béo, thích hợp để uống vào buổi sáng để khởi đầu ngày mới", "Cà phê sữa", "Drink", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh canh cua là món ăn đặc trưng với nước dùng đậm đà từ cua, ăn kèm với bánh canh mềm và các loại rau. Món này rất phổ biến ở miền Nam và mang lại hương vị thơm ngon, bổ dưỡng", "Bánh canh cua", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Xôi bắp là món ăn sáng đơn giản, được làm từ gạo nếp và bắp, có vị ngọt tự nhiên của ngô. Món này dễ ăn, cung cấp năng lượng cho cả ngày dài, thường được ăn kèm với thịt hoặc các món mặn khác", "Xôi bắp", "Carbs", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo vịt là món cháo nấu với thịt vịt, có vị ngọt tự nhiên từ thịt và xương vịt. Món này thường được ăn vào bữa sáng hoặc bữa tối, giúp cung cấp năng lượng và dưỡng chất", "Cháo vịt", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e370081a-c0a6-4c00-b01c-7c52f953b7f1"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh mướp là món ăn thanh mát với mướp nấu trong nước dùng nhẹ nhàng từ xương hoặc thịt. Món canh này có tác dụng giải nhiệt, rất thích hợp vào mùa hè", "Canh mướp", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Lê là trái cây ngọt mát, giàu vitamin C và chất xơ, giúp cải thiện hệ tiêu hóa và làm đẹp da. Lê có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng", "Lê", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Tôm là hải sản giàu protein, omega-3 và vitamin, rất tốt cho sức khỏe tim mạch. Tôm có thể chế biến thành nhiều món ăn như xào, hấp, hoặc nấu canh, tạo hương vị tươi ngon cho bữa ăn", "Tôm", "Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo sườn non là món ăn thơm ngon, với cháo được nấu từ xương sườn heo, có vị ngọt tự nhiên từ xương. Món này thường được ăn kèm với hành phi và gia vị, thích hợp cho bữa sáng", "Cháo sườn non", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Súp hải sản là món ăn đậm đà với nước dùng từ hải sản như tôm, cua, mực, nấu cùng với rau củ và gia vị. Món này rất bổ dưỡng và thích hợp cho các bữa ăn chính", "Súp hải sản", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Dưa hấu là trái cây giải nhiệt, chứa nhiều nước và vitamin C. Đây là món ăn lý tưởng trong mùa hè, giúp cung cấp nước và dưỡng chất cho cơ thể, có thể ăn trực tiếp hoặc làm sinh tố", "Dưa hấu", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá hồi nướng là món ăn bổ dưỡng, giàu omega-3 và protein, thường được ướp gia vị trước khi nướng. Món này có hương vị ngọt tự nhiên, thích hợp ăn kèm với rau sống hoặc cơm", "Cá hồi nướng", "Protein", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("eec3d874-6331-4e33-bbe6-bf0cc4335b29"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Salad rau là món ăn nhẹ, là sự kết hợp của các loại rau tươi như xà lách, cà chua, dưa leo, trộn với nước sốt chua ngọt hoặc dầu olive. Món này bổ dưỡng, giàu vitamin và chất xơ", "Salad rau", "Vegetables", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh bao trứng cút là món bánh bao với nhân thịt heo hoặc đậu xanh, kèm trứng cút. Bánh có vỏ mềm, nhân thơm ngon, thường được ăn sáng hoặc làm món ăn phụ trong các bữa ăn chính", "Bánh bao trứng cút", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh cuốn là món ăn làm từ bột gạo, nhân thường là thịt băm, nấm hoặc trứng. Bánh cuốn mềm mịn, ăn kèm với nước mắm và rau sống, thường được dùng trong bữa sáng hoặc bữa phụ", "Bánh cuốn", "Carbs,Protein", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Mận là trái cây ngọt, mọng nước, chứa nhiều vitamin C và chất chống oxy hóa, giúp tăng cường sức đề kháng và làm đẹp da. Mận có thể ăn trực tiếp hoặc làm sinh tố, chè", "Mận", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f41484a3-c7df-4530-b7d2-060390103985"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish,MainDish", "Lòng trắng trứng gà chứa nhiều protein và ít chất béo, rất tốt cho sức khỏe. Lòng trắng trứng có thể chế biến thành các món như trứng luộc, trứng chưng, hoặc làm nguyên liệu trong các món ăn khác", "Lòng trắng trứng gà", "Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Xôi mặn là món ăn từ gạo nếp, kết hợp với thịt, lạp xưởng hoặc trứng. Món này thường được ăn vào buổi sáng hoặc trong các dịp đặc biệt, rất bổ dưỡng và dễ ăn", "Xôi mặn", "Carbs,Protein", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Sữa hộp Milo là thức uống bổ dưỡng chứa nhiều vitamin và khoáng chất, phù hợp cho trẻ em và người lớn. Milo có hương vị ngọt ngào, thường được uống vào bữa sáng hoặc giữa các bữa ăn", "Sữa hộp milo", "Drink", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Ổi là trái cây giàu vitamin C, giúp tăng cường hệ miễn dịch và làm đẹp da. Ổi có thể ăn trực tiếp hoặc làm sinh tố, nước ép, rất tốt cho sức khỏe, đặc biệt là trong việc hỗ trợ tiêu hóa", "Ổi", "Dessert", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo thịt bằm là món cháo có thịt heo xay nhuyễn, nấu cùng với gạo và gia vị. Món này bổ dưỡng, dễ ăn và dễ tiêu hóa, thích hợp cho bữa sáng hoặc bữa ăn nhẹ", "Cháo thịt bằm", "Carbs,Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Sữa chua nha đam là món tráng miệng được làm từ sữa chua và nha đam tươi, giúp làm đẹp da và hỗ trợ tiêu hóa. Món này mát, dễ ăn và rất tốt cho sức khỏe, đặc biệt là trong thời tiết nóng", "Sữa chua nha đam", "Dessert", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("faf19891-525a-4308-9222-992e83de7ce7"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Cá hồi là loại hải sản giàu omega-3, tốt cho sức khỏe tim mạch. Cá hồi có thể chế biến thành nhiều món như nướng, hấp, hoặc làm sushi, mang lại hương vị tươi ngon và bổ dưỡng", "Cá hồi", "Protein", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh ướt là món ăn nhẹ làm từ bột gạo, có kết cấu mềm mịn, thường được ăn kèm với thịt heo, chả lụa và rau sống. Món này có thể được rưới nước mắm chua ngọt, mang lại hương vị thơm ngon và thanh mát", "Bánh ướt", "Carbs,Protein", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Mướp là loại rau quả mát, chứa nhiều nước và vitamin. Mướp có thể chế biến thành canh, xào hoặc làm món gỏi, giúp thanh nhiệt, giải độc và tốt cho hệ tiêu hóa", "Mướp", "Vegetables", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Chuối tiêu là trái cây ngọt nhẹ, giàu kali và vitamin C, giúp hỗ trợ tiêu hóa và cung cấp năng lượng. Chuối tiêu có thể ăn trực tiếp hoặc chế biến thành các món tráng miệng như chè chuối hấp", "Chuối tiêu", "Dessert", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Bắp cải tím là loại rau giàu vitamin C và chất xơ, có thể chế biến thành salad, xào hoặc nấu canh. Món bắp cải tím giúp giải độc, hỗ trợ tiêu hóa và tốt cho sức khỏe tim mạch", "Bắp cải tím", "Vegetables", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "WorkoutId", "CategoryId", "CreatedAt", "CreatedBy", "DifficultyLevel", "Status", "UpdatedAt", "UpdatedBy", "UserId", "Views", "WorkoutDescription", "WorkoutName", "WorkoutType" },
                values: new object[,]
                {
                    { new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp khởi động toàn bộ cơ thể, làm nóng cơ bắp, giúp tăng cường lưu thông máu và chuẩn bị cho các bài tập tiếp theo", "Khởi động toàn thân", 0 },
                    { new Guid("032322a9-a232-4030-bed3-0ccf952d5cff"), new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập giúp làm dẻo dai các khớp chân, tăng cường độ linh hoạt và giảm thiểu nguy cơ chấn thương khi tập luyện", "Chân dẻo dai", 0 },
                    { new Guid("03741247-6b2d-49a9-a656-7fc8343747bd"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập toàn thân giúp kích thích các cơ lớn trong cơ thể, cải thiện sự dẻo dai và sức bền chung cho cơ thể", "Vận động toàn thân", 0 },
                    { new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13"), new Guid("4575699a-5bb6-42ec-9d52-ea19d1170187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập thể thao này giúp cải thiện sự phối hợp và tốc độ phản xạ của cơ thể, giúp bạn năng động và linh hoạt hơn", "Vũ điệu thể thao", 1 },
                    { new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp làm mềm các khớp và cơ, tăng cường sự linh hoạt để sẵn sàng cho các hoạt động thể chất nặng hơn", "Khởi động linh hoạt", 1 },
                    { new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a"), new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập vũ điệu thể thao giúp cải thiện khả năng phối hợp và nhịp điệu của cơ thể, đồng thời tăng cường sức bền", "Vũ điệu thể thao", 1 },
                    { new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4"), new Guid("4575699a-5bb6-42ec-9d52-ea19d1170187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp săn chắc cơ thể, tăng cường sức mạnh và giảm mỡ hiệu quả", "Săn chắc và khỏe mạnh", 1 },
                    { new Guid("2308c57b-829b-4c6e-b362-5b4634af2877"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập giúp kích thích năng lượng cho cơ thể, giúp bạn cảm thấy tràn đầy sức sống và chuẩn bị tốt cho các hoạt động tiếp theo", "Năng lượng dồi dào", 1 },
                    { new Guid("298502cf-ebdf-4044-9350-a14606ebe099"), new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp cơ bắp chân săn chắc và phát triển sức mạnh, đặc biệt là khi bạn cần cải thiện khả năng di chuyển", "Chân săn chắc", 0 },
                    { new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54"), new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp tăng cường sự linh hoạt và sức mạnh của cánh tay, hỗ trợ tốt cho các bài tập thể thao khác", "Tay linh hoạt", 0 },
                    { new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64"), new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này kết hợp giữa sức mạnh và khả năng duy trì sự cân bằng, giúp cải thiện sự ổn định cơ thể và khả năng phối hợp các nhóm cơ", "Sức mạnh và cân bằng", 1 },
                    { new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp cơ thể dẻo dai và tăng cường năng lượng, thích hợp để nâng cao khả năng hoạt động lâu dài và bền bỉ", "Dẻo dai và năng lượng", 1 },
                    { new Guid("425fc485-239f-479e-a4da-b1fe6aed6822"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp cơ thể vừa khỏe mạnh vừa dẻo dai, thích hợp cho việc nâng cao độ linh hoạt và sức bền của các nhóm cơ", "Khỏe và dẻo dai", 1 },
                    { new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757"), new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp cải thiện sức khỏe toàn thân, tăng cường các nhóm cơ lớn và nhỏ", "Toàn thân khỏe mạnh", 1 },
                    { new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp xây dựng sức mạnh cơ thể toàn diện, với các bài tập kết hợp giữa các nhóm cơ lớn và nhỏ", "Sức mạnh toàn diện", 1 },
                    { new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a"), new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp phát triển sức khỏe toàn diện, bao gồm sức mạnh, sức bền, sự linh hoạt và sự cân bằng của cơ thể", "Khỏe mạnh toàn diện", 1 },
                    { new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00"), new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp phát triển cơ bắp tay và bả vai, làm tay trở nên mạnh mẽ và săn chắc hơn", "Tay rắn chắc", 0 },
                    { new Guid("580069d7-9025-4864-adf2-3037608e9a22"), new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp tăng cường sự linh hoạt của khớp tay và vai, hỗ trợ cải thiện khả năng vận động của phần trên cơ thể", "Tay uyển chuyển", 0 },
                    { new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập thử thách thể lực này giúp kiểm tra sức mạnh và sự bền bỉ của cơ thể thông qua các bài tập đòi hỏi sức lực cao", "Thử thách thể lực", 0 },
                    { new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp nâng cao sức bền, cải thiện khả năng chịu đựng khi thực hiện các hoạt động thể thao kéo dài", "Luyện tập sức bền", 1 },
                    { new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp làm nóng và kích thích tất cả các nhóm cơ trong cơ thể, chuẩn bị cho những bài tập nặng hơn", "Tập luyện toàn thân", 0 },
                    { new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b"), new Guid("4575699a-5bb6-42ec-9d52-ea19d1170187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp cải thiện sự nhịp nhàng trong chuyển động của cơ thể, nâng cao sức khỏe và sự linh hoạt", "Chuyển động nhịp nhàng", 1 },
                    { new Guid("7691ed30-fe88-4e75-97c6-f5f88d304efb"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này tiếp tục tập trung vào việc phát triển sức mạnh tổng thể, nâng cao sức bền và cải thiện sức khỏe lâu dài", "Sức mạnh toàn diện", 1 },
                    { new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0"), new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập tăng cường sức mạnh cho tay và vai, giúp phát triển cơ bắp và cải thiện khả năng chống chịu với các bài tập nặng", "Tay cường độ cao", 0 },
                    { new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập toàn thân giúp cải thiện sức khỏe chung, tăng cường khả năng vận động và phát triển cơ bắp đồng đều", "Tập luyện toàn thân", 1 },
                    { new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb"), new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập khởi động cơ bản giúp làm ấm cơ thể, giảm thiểu nguy cơ chấn thương và chuẩn bị cho các bài tập tiếp theo", "Khởi động cơ bản", 1 },
                    { new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp tăng cường sự linh hoạt và sức mạnh của cơ thể, phù hợp với những người muốn nâng cao thể lực tổng thể", "Linh hoạt và mạnh mẽ", 1 },
                    { new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc"), new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này là sự kết hợp giữa vũ điệu và thể thao, giúp cải thiện khả năng vận động nhịp nhàng và tăng cường sức bền cho cơ thể", "Vũ điệu kết hợp", 1 },
                    { new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp tăng cường sức mạnh cơ bắp đồng thời cải thiện tốc độ và độ phản xạ của cơ thể", "Luyện tập nhanh và mạnh", 1 },
                    { new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2"), new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp tăng cường sức mạnh cho các cơ chân, đặc biệt là các cơ bắp đùi và bắp chân", "Chân khỏe mạnh", 0 },
                    { new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này kết hợp giữa sức mạnh và sự linh hoạt, giúp cải thiện khả năng vận động của cơ thể và nâng cao thể lực tổng thể", "Khỏe và linh hoạt", 1 },
                    { new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f"), new Guid("4575699a-5bb6-42ec-9d52-ea19d1170187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này kết hợp các động tác linh hoạt và sức mạnh, giúp cải thiện khả năng vận động và sự khỏe mạnh của cơ thể", "Linh hoạt và khỏe mạnh", 1 },
                    { new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563"), new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập với các động tác nhịp điệu giúp cải thiện sức bền và sự phối hợp giữa các nhóm cơ, đồng thời tăng cường năng lượng cho cơ thể", "Nhịp điệu sôi động", 1 },
                    { new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0"), new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập toàn thân giúp phát triển sức mạnh cơ bắp cho tất cả các nhóm cơ, đặc biệt là cơ lớn như ngực, lưng, và chân", "Toàn thân mạnh mẽ", 1 },
                    { new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7"), new Guid("4575699a-5bb6-42ec-9d52-ea19d1170187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập khởi động giúp cơ thể làm quen với các động tác nhẹ nhàng, tăng cường sự linh hoạt và giảm thiểu rủi ro chấn thương", "Khởi động cơ thể", 1 },
                    { new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5"), new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp săn chắc cơ bắp toàn thân, với trọng tâm là phát triển cơ bắp, đồng thời giảm mỡ và cải thiện hình thể", "Toàn thân săn chắc", 1 },
                    { new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập giúp nâng cao sức mạnh và bền bỉ cho cơ thể, thích hợp cho những người muốn thử thách sức chịu đựng của mình", "Sức mạnh và bền bỉ", 1 },
                    { new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1"), new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp tăng cường sự bền bỉ cho cơ thể và cải thiện khả năng chịu đựng, rất hữu ích cho các hoạt động dài hạn", "Dẻo dai và bền bỉ", 1 },
                    { new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f"), new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập giúp cải thiện sức bền cho đôi chân, thích hợp cho những người tập thể thao đòi hỏi di chuyển lâu dài và mạnh mẽ", "Chân bền bỉ", 0 },
                    { new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này giúp xây dựng cơ bắp và cải thiện sức mạnh tổng thể, phù hợp cho những ai muốn nâng cao khả năng thể chất", "Vươn tầm sức mạnh", 1 },
                    { new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập này có cường độ cao, giúp tăng cường sức mạnh cơ bắp và nâng cao khả năng chịu đựng cho cơ thể", "Thử thách cường độ cao", 1 },
                    { new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea"), new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập giúp phát triển sự linh hoạt và khả năng vận động của cơ thể, làm cho cơ thể mềm dẻo và dẻo dai hơn", "Chuyển động linh hoạt", 1 },
                    { new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270"), new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập giúp đốt cháy năng lượng và giảm mỡ hiệu quả, cải thiện sức khỏe tổng thể", "Đốt cháy năng lượng", 1 },
                    { new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69"), new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "Bài tập giúp phát triển sự linh hoạt và bền bỉ cho cơ thể, cải thiện khả năng hoạt động trong thời gian dài", "Luyện tập linh hoạt và bền bỉ", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodAllergies",
                columns: new[] { "FoodAllergyId", "AllergyId", "CreatedAt", "FoodId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("071597ce-611f-4332-9e51-15b6b5f7f7ea"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), null },
                    { new Guid("11c35744-fa90-483e-9c2f-c393ff86e07a"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), null },
                    { new Guid("180d438e-c855-4f44-abdc-bf2083f203e5"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), null },
                    { new Guid("1b5fb79c-be45-4ec0-a702-4bec66fef146"), new Guid("0eec9d43-391c-43c6-9635-01ca2d6fc66c"), null, new Guid("404a286a-90c5-4c54-8e27-3ddeba55ada3"), null },
                    { new Guid("1b8289b8-ff3f-457b-8a7d-8d51eac6dc0c"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), null },
                    { new Guid("1b97261f-3a72-4ff8-bdc4-e30eaf81eefd"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), null },
                    { new Guid("22ff7714-75f0-47f8-8371-3871719f2743"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), null },
                    { new Guid("24bc6106-5e03-4a3d-8989-872a715ac7b2"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), null },
                    { new Guid("29f6aec1-4844-44c9-bf6a-90e0d32f6c9b"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), null },
                    { new Guid("2c34461c-73e3-48d0-ac8b-cb1954c2cc56"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), null },
                    { new Guid("34447790-c255-45f1-8921-31bae18351d5"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), null },
                    { new Guid("4515bd43-b709-411a-b39d-67da96450f1c"), new Guid("0eec9d43-391c-43c6-9635-01ca2d6fc66c"), null, new Guid("731974ef-495e-4c08-ba95-20589d60c20c"), null },
                    { new Guid("4a090e83-f8fb-4882-9c35-dd88a42f12ca"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), null },
                    { new Guid("4cc5a7d6-a17b-47a1-85fc-507e8d1c5ccd"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("05cfce09-72b4-482d-adcd-c0718015be3d"), null },
                    { new Guid("51da847c-8861-41b1-8441-9657dd39e913"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), null },
                    { new Guid("52a7010c-80a7-4483-afc8-518c469dad80"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), null },
                    { new Guid("535eb80d-31f0-427f-a097-012318789f9e"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("faf19891-525a-4308-9222-992e83de7ce7"), null },
                    { new Guid("590028e5-54af-4bad-8adc-28b1707477ee"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), null },
                    { new Guid("5c5b3dc1-11c8-4068-8401-aafa6e28e2fc"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("a1ff09f1-9d02-40a8-84de-8da9aad67c58"), null },
                    { new Guid("5d9a3ef7-932c-4be5-87a5-ac309d3ce779"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), null },
                    { new Guid("6087f985-6b23-4328-87fe-d81611b89447"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), null },
                    { new Guid("616a0810-66da-4088-9234-d4db9d2ab1f0"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), null },
                    { new Guid("67ae0f2d-1e59-4307-829a-c419ae52e6bc"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), null },
                    { new Guid("69c060a7-7660-4b5b-87e2-8b0de4ee47d9"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), null },
                    { new Guid("6f2656c0-f93c-4370-9f97-f04ba4ebf193"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), null },
                    { new Guid("6fc5f17c-4a3b-432b-930c-0070f0c4e809"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), null },
                    { new Guid("71cc461a-e841-4f8b-8067-2eb20a20ff3a"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), null },
                    { new Guid("73d57d40-2832-4d57-a928-af1a599be747"), new Guid("0eec9d43-391c-43c6-9635-01ca2d6fc66c"), null, new Guid("59988378-901f-4ec4-bd6c-9fdc28ca97a1"), null },
                    { new Guid("755c6f1c-9107-4aef-84d5-5a7235aebc20"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), null },
                    { new Guid("773f2adb-5e4e-4867-8e44-f0f6c2aaa971"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), null },
                    { new Guid("7d9af5ea-4d89-4191-8066-1e9227e743fb"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), null },
                    { new Guid("7f164b62-9066-495c-acdf-302d4f4d72d1"), new Guid("0eec9d43-391c-43c6-9635-01ca2d6fc66c"), null, new Guid("b0f051be-5972-4e7a-a77d-47ec28d58993"), null },
                    { new Guid("7f4225ba-e149-4c9f-9e3e-e7b7f96afc82"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), null },
                    { new Guid("81c3a155-9784-4fc5-bef0-fac108d1c7aa"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), null },
                    { new Guid("8692d974-f7a7-4e7e-89d7-5f53158bc72d"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), null },
                    { new Guid("8ab4c274-293f-4266-b5c1-bc5ec2cae7d4"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), null },
                    { new Guid("8ad8b3ef-cead-4113-acf1-79d039c623f7"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), null },
                    { new Guid("91144e1f-91cc-41c7-bb9b-080c54227c9f"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), null },
                    { new Guid("91311370-97b9-42b7-98b9-9dee23aa6b7b"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), null },
                    { new Guid("96f3a3a6-e841-4a7c-a5db-45b077c5964c"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), null },
                    { new Guid("988b148b-6a1b-4dc6-bb50-ac994d791b8f"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), null },
                    { new Guid("99da64a9-f5bb-4a27-acd4-0b97f28c7365"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), null },
                    { new Guid("99fa283b-3c28-4e41-b49f-c8e635519033"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), null },
                    { new Guid("9b5e2d16-2a1c-4ada-a863-04423fb6fbcb"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), null },
                    { new Guid("a1f8c9fa-e90b-4df2-ad89-8adab804c4ad"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), null },
                    { new Guid("a21ae73a-9c23-4d03-be1d-f70f14bef546"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), null },
                    { new Guid("a56293e8-e22a-40a4-9a31-afe9e4ca4ee5"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), null },
                    { new Guid("a7d0b079-4e5e-45b6-9b5b-43fb947817f5"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), null },
                    { new Guid("a9ebe492-f324-4c7b-b7ce-03b079303828"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), null },
                    { new Guid("aa2a10a8-b392-4adb-8ea0-63eb1415d9c4"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), null },
                    { new Guid("afb56a74-e922-42f7-916e-6d85734b3f7c"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), null },
                    { new Guid("b4613f37-def8-422b-a5b8-14e1765d38a7"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), null },
                    { new Guid("b899d5be-6f7c-4248-8ade-6896b20f9a48"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), null },
                    { new Guid("ba835565-202d-4e42-b5d0-a2331de6efb1"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), null },
                    { new Guid("be1101fc-5d1d-4636-b1c5-1a7326a4f574"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), null },
                    { new Guid("bf6146ee-d300-4886-8879-d200745e9e45"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), null },
                    { new Guid("c714f02c-4614-4399-94d1-04317a1f4ad3"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), null },
                    { new Guid("ca933daa-48d3-49f6-9623-e39397901e17"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), null },
                    { new Guid("cc27e238-5e39-4118-acf4-e738ebfa4792"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), null },
                    { new Guid("d69a03a1-eab7-4dce-9447-031c67349488"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("f41484a3-c7df-4530-b7d2-060390103985"), null },
                    { new Guid("d89efe2a-2f5c-4ff4-9a9e-dbc692d9e974"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), null },
                    { new Guid("d95b6040-1ba5-470c-9f6b-cc915e6e3581"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), null },
                    { new Guid("ee6dac8f-beb9-439b-9275-243efeb23b40"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), null },
                    { new Guid("f212c7ea-6539-40d1-9802-f02a5a22dbf6"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), null },
                    { new Guid("f33d17d8-57ec-4ca3-b0e8-ea006d80561b"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), null },
                    { new Guid("f4fc097e-af26-4b2d-b523-ff7d5ef1ba52"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), null },
                    { new Guid("fb65c074-21e9-4068-8e0a-58241fe52dd4"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), null },
                    { new Guid("fbaac9eb-7a21-4b28-a741-b32aafb5e739"), new Guid("0eec9d43-391c-43c6-9635-01ca2d6fc66c"), null, new Guid("4e46f955-4413-496f-97b4-968a38ee3e11"), null }
                });

            migrationBuilder.InsertData(
                table: "FoodPortions",
                columns: new[] { "FoodPortionId", "CreatedAt", "FoodId", "PortionId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0a746e80-9675-4e8d-9e2b-dd4abceaed06"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("6e98f2be-9196-4c4e-8279-b02010f853f1"), null },
                    { new Guid("0acb4e4c-81cc-4feb-9282-8be064b81efa"), null, new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new Guid("2892c25f-bd50-4bb4-a845-997395ef6693"), null },
                    { new Guid("0b47d00d-4890-48b0-a7db-fa38434aac5f"), null, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new Guid("8ecbc063-8d6e-450d-af39-0ba28bc572bf"), null },
                    { new Guid("0b543941-66dc-4f30-80d8-2f6fb63ed8bf"), null, new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new Guid("41ae956e-14fc-44af-bc6a-e5ba77661cee"), null },
                    { new Guid("0d496959-da3b-4038-9e0b-bfbb06210b04"), null, new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new Guid("f0e8f9cd-d133-49cf-be7d-d427b630e05a"), null },
                    { new Guid("0f95c3a0-a071-4a91-83a4-73d575c57885"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("5a9ac478-aa65-48ea-9387-1ad92f6c76b1"), null },
                    { new Guid("0fc7f043-60fa-4d62-9e50-cf01a60e3f0c"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("bd16f0ec-5ae1-42f4-a302-b4bce8f0db28"), null },
                    { new Guid("0fcea4e0-61e2-496b-8fcb-ac636654a020"), null, new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new Guid("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52"), null },
                    { new Guid("113f9909-6799-45cd-8b20-fd4503433161"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("d9dad801-145a-419d-bbe2-408acf97a273"), null },
                    { new Guid("12feef8f-a06a-4eff-bbe6-49ace58fe4e4"), null, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new Guid("bad70aff-4237-4c83-b412-460020a5ee44"), null },
                    { new Guid("13064183-9065-4f5e-8085-da249a3b719a"), null, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new Guid("d2e88505-bbd6-4af6-9a88-535896c5d587"), null },
                    { new Guid("13b45d03-ab95-4fa4-9bf4-870fce93a865"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("1b56833b-1ff5-4a90-aea9-074de2d0dd67"), null },
                    { new Guid("1968aaf5-6dda-4a4f-97c6-8045a79dfacc"), null, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("1808de3e-ae43-41a6-b9ce-bfe89131be5a"), null },
                    { new Guid("1b8595d7-1b90-4b88-8f5b-ef81eb1ab3e6"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("87409e4f-4bea-4bba-855d-a3bfbc2f9c20"), null },
                    { new Guid("1da76a55-ab2d-4cfe-91ef-1b22b5114a30"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("d3850e1b-4780-490d-8c0c-ced1a9aa323b"), null },
                    { new Guid("1e750720-0882-4379-ad66-5165a0a35ca1"), null, new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new Guid("a9385e8a-e9b9-484f-beeb-bc35529cf91a"), null },
                    { new Guid("2067b547-2c48-4056-b0a1-003a3048f2e9"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("91524cc2-db22-4cab-abb7-700725232f1f"), null },
                    { new Guid("21cffd96-7166-4d6b-816b-893eb6444af6"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("17c9d30f-bd85-4e58-bfc0-6b6d70b2e5fe"), null },
                    { new Guid("232998eb-268e-4e99-9941-b77a7876378f"), null, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new Guid("b6623163-4c27-4d0c-99ef-12a67b87635f"), null },
                    { new Guid("24fb66a0-3f6e-45a6-9f31-ca6aa3917af8"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("a7936b9f-b6f8-4295-8b6e-6fe1b096f437"), null },
                    { new Guid("25ed7269-7d07-4028-a48f-46579b0468be"), null, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new Guid("21e32570-7d64-4cec-b711-873185c76523"), null },
                    { new Guid("29d6c448-b1b7-45b1-909e-3704b3af9f20"), null, new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new Guid("22f0a09e-6816-410e-a5a2-c802103b089b"), null },
                    { new Guid("2e10380f-c530-4310-908a-08bafa834ccd"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("28b06cf6-6367-4786-bccb-89c43dd3ce3a"), null },
                    { new Guid("2e704cfc-90bf-46e7-8b1a-093a71ce0dc9"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("f9bc9ae8-e42e-4e8b-84d3-f2bc36037552"), null },
                    { new Guid("2faa7fa3-a536-46a4-b103-f2ef89a939a7"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("549d664a-eb1c-4b9a-8ad7-fab9e1482e5b"), null },
                    { new Guid("3207002d-5466-48aa-bf65-c19652758a8e"), null, new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new Guid("5a1bc1cb-ed0b-49bf-9c1a-5494db962d27"), null },
                    { new Guid("39afd9ea-4245-4130-935b-7c4951007f66"), null, new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new Guid("5feca670-1f15-430d-9b04-7ac86a329a6c"), null },
                    { new Guid("3c8c4b42-cb5b-4e40-a25d-9639abeb0539"), null, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new Guid("1cf439ce-a31b-4b95-b092-b7f6edf8d40f"), null },
                    { new Guid("3e0d4335-5c12-4160-bbd8-dfbe165fdc42"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("919c7f66-53e5-46bd-b181-558f6052b953"), null },
                    { new Guid("43249243-4cb6-45aa-ad56-4ad3f48cff2d"), null, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new Guid("bdd1ee1e-3a93-421f-855e-0993c7e6f767"), null },
                    { new Guid("450a3d86-05b3-4a70-b4c7-c9c3123400b7"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("36398f6d-0668-4d37-8850-9f9ee89b8b92"), null },
                    { new Guid("46e0f036-e42c-4527-9448-7404c1a227b7"), null, new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new Guid("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649"), null },
                    { new Guid("49a8ddb1-f852-4dc7-8046-0634f1c7937d"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("f483bb75-84f0-4ecc-8a06-f366a488c6bf"), null },
                    { new Guid("4b05c9e6-0135-4bb5-9f5b-3bee4ca505a5"), null, new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new Guid("5384aebd-4eab-4a44-8cbb-7ec2c04f1401"), null },
                    { new Guid("4cfe6e1f-c81a-4ae4-b029-0b5038c371f5"), null, new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new Guid("6792c392-3c86-4162-be91-4fc8646f861d"), null },
                    { new Guid("523f27b0-b8ca-47fc-bae2-0b5090cc030b"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("f928b7a6-2558-478a-bc22-515516f4dc74"), null },
                    { new Guid("543b47e1-1425-4351-926d-2b310c2ab728"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("e00ed683-11ff-4c21-8b1c-576b448726c9"), null },
                    { new Guid("54960d13-3c2b-4abf-a4e3-53f3087559e7"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("218b9709-852d-4a1f-ad8b-c9410b49fea6"), null },
                    { new Guid("557af44a-eb28-4134-97b2-684abf1ef286"), null, new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new Guid("749b288c-112b-4b7b-8750-0daff63d9ab3"), null },
                    { new Guid("56574d2c-7de6-460a-aa01-a3e5d70b01d1"), null, new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new Guid("a1589990-affa-4805-a1e0-73de1ffa8516"), null },
                    { new Guid("5ad31073-7578-4bf3-b396-f3f6a81c562a"), null, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new Guid("de5d78a3-c5b1-4e2a-b9eb-f3757c999024"), null },
                    { new Guid("5ce378cb-13ee-4255-abbb-d41bc0bbbafc"), null, new Guid("c81a404a-ec10-428e-acec-dd56ec1d3607"), new Guid("d6c41cdb-4735-4b9e-85ae-1f48f33b7d6c"), null },
                    { new Guid("5d7793b8-245d-4ec7-bc59-8339a723f997"), null, new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new Guid("93984b54-2044-4ea9-8364-a03c6568e358"), null },
                    { new Guid("5d9e0dbd-86d5-4193-9361-82cb68eb425c"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("40bbc8c4-f383-4ae6-979a-3ac83c275881"), null },
                    { new Guid("5e522a66-b77a-4901-8e49-c2c1d4f96344"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("c65d34ee-8c0c-43bb-9d4e-aa39955a4768"), null },
                    { new Guid("5f71c11e-fd09-4418-9a08-c9d218131e1e"), null, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new Guid("9c276c0b-84b6-4216-8dbb-ae2034ac2176"), null },
                    { new Guid("5f826dc9-f74c-4be9-85a0-292d3f7e09ac"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("e09c493c-5806-4b14-bbef-e26e19e1d8d5"), null },
                    { new Guid("60ab047e-0a77-4850-bc9a-ca7ec6b8ba20"), null, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new Guid("c4993d6a-a2e0-4ddd-821a-0629541e019c"), null },
                    { new Guid("6707ca5f-10e2-4ace-a86a-f25b94f9b646"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("e45c2156-a98c-4121-90b4-25097e8a5cd1"), null },
                    { new Guid("68787c78-b7ec-4a1c-898e-575f619428e1"), null, new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new Guid("3f77fd90-591c-45f3-8bbc-87d0bb49e461"), null },
                    { new Guid("6887625c-e392-460a-a2f1-2f1d62b9d327"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("709578ca-672f-461e-995d-dc78aeda8c4c"), null },
                    { new Guid("68a25987-ec7f-471c-be7f-21263a038c41"), null, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new Guid("18809fb3-b78a-4f67-b9f9-8bb6ab95ab00"), null },
                    { new Guid("68f97784-91d5-4621-b007-c7634d36261c"), null, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new Guid("16dc894a-746e-497e-a2c5-2d58f7f83c4d"), null },
                    { new Guid("6caf0fb6-477d-412d-93d8-0342f2048239"), null, new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new Guid("1cddc91d-209a-4948-8e9f-9017252d5423"), null },
                    { new Guid("6dc48639-be93-4b5a-a071-852350406c8d"), null, new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new Guid("e23d4491-73d1-45b5-8010-0385d7185c98"), null },
                    { new Guid("6e8fe531-4414-4acb-907e-e167fe1a1286"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("56681171-ccbd-4700-90bc-2233c1e661bb"), null },
                    { new Guid("74fadc92-572e-496d-9d82-613e7e43ebc1"), null, new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new Guid("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1"), null },
                    { new Guid("7935acf1-92bd-470c-a582-ef39a60ffa44"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("5adcb96d-70ef-403d-89c6-cc3aa807b6a7"), null },
                    { new Guid("798dcfe8-9fb2-4bdb-ac36-e978dfc06e92"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("c605aa91-495e-4977-9876-b2a198ce356e"), null },
                    { new Guid("7a55a8b5-f919-4c11-a63c-e8f0398d9733"), null, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new Guid("59589114-7d6a-4c80-8681-db5c554ab38f"), null },
                    { new Guid("7bf57a48-dc8c-4443-8646-9d046920b063"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("faec7c41-2e11-4092-8ab9-cc9c152d858f"), null },
                    { new Guid("8463899f-2500-46cd-90e9-54b311cdab00"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("3c7d60d4-60da-4f51-9448-30877b126572"), null },
                    { new Guid("879c828c-f625-4fdd-ae71-006fff6f14a1"), null, new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new Guid("92e149ff-8491-48cf-a4e8-8106b1e95c4c"), null },
                    { new Guid("8927d7c2-8c2d-45fa-a4f4-429c3dd1e700"), null, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new Guid("3f19ef5c-3c60-4a11-b1b3-5158859f1286"), null },
                    { new Guid("898f8c84-0a4e-4d1c-b888-d6ab6dcf4233"), null, new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new Guid("255ba0f6-14cc-4049-add8-138f27055b49"), null },
                    { new Guid("95363f3c-bcbd-4081-96cc-05ed08b387a4"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("a43d7637-6fc7-421b-86f1-f83e691431a4"), null },
                    { new Guid("954cb04b-a55b-4910-91c1-fa0c7bba509c"), null, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new Guid("ad9ecd1e-40ec-414a-be69-b16e7013b377"), null },
                    { new Guid("9565bfe8-72ed-49fb-bbe9-83a2b19bc9d4"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("5afaa147-398e-4be8-b0d1-8dcabe6ed18c"), null },
                    { new Guid("96114c19-0609-402c-bb28-8730f638d0c5"), null, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new Guid("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a"), null },
                    { new Guid("96815473-d1ea-4e1c-b0a2-2a29a3da8b63"), null, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new Guid("31e9bda5-8ec3-4444-a23a-908e84da6a14"), null },
                    { new Guid("988e64df-83a5-4196-8c94-eb1de15445ce"), null, new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), new Guid("03a92c0b-b7f6-4283-8109-a35898d5d3c5"), null },
                    { new Guid("9e523008-0362-48d0-a41b-f480685183b0"), null, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new Guid("84793ef9-fcd0-42df-ab0d-9380dfa18630"), null },
                    { new Guid("9ee37170-ff80-46cc-beae-e93c2d3c0c2c"), null, new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new Guid("4e9013c8-d6f7-4740-80d5-e95d318873b9"), null },
                    { new Guid("a4a5b4dd-3d0f-4c6a-a838-9d0b59041df1"), null, new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new Guid("1500876f-ef20-40de-baae-de0336bdc47b"), null },
                    { new Guid("a4e8a1f3-c00b-4553-ada1-68a91cbe3079"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("c6e853f0-06bd-4cda-8b43-cbe66fea98c8"), null },
                    { new Guid("a78e434f-b47f-43e4-a7a1-ca3ff8abc810"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("a5dbb27a-4856-44be-a239-76eb073c3e41"), null },
                    { new Guid("a7e313cd-9286-4c96-86a7-5a3eabc8a4aa"), null, new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new Guid("f7b36043-9ca9-42c3-8a00-e9e235b56bb3"), null },
                    { new Guid("aad42e32-e22f-49e5-b97a-0efdd3f616d5"), null, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("40991196-f258-43f1-ac84-0381afa83477"), null },
                    { new Guid("ade29481-8ed6-4ce8-a285-ecf95542018b"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("a88faa7c-6eab-4ecb-8a75-b078a9cf7834"), null },
                    { new Guid("afdbbab0-ffb0-42f5-876a-1eb09dd41c52"), null, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new Guid("7e071bd6-6afa-483d-8688-28b31b9a8bef"), null },
                    { new Guid("b26de8df-2bd4-4339-bb54-a9b08a121406"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("113f6a04-87c4-43c6-8263-920bd099c8e0"), null },
                    { new Guid("b61c9056-7ba3-4ff7-a4b1-a9f0448d0ffa"), null, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new Guid("d09266d3-9e7d-46a6-ad3a-7c608ec802d1"), null },
                    { new Guid("b6bcb1a3-78ab-40c0-b9a3-97efeb929ffd"), null, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new Guid("3d6d946f-8d9f-479a-b27e-3d78dc354db0"), null },
                    { new Guid("b84b61b6-2826-451b-b143-f329decbbb57"), null, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new Guid("1802caa2-cfe0-48e7-8580-29165f84387d"), null },
                    { new Guid("bb4ad75d-e7f3-4a6e-b918-9444b0c90a17"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("52c86d57-0909-41c3-b513-e770e6f6d104"), null },
                    { new Guid("bce58596-4df3-449f-9368-a2c57c9963c3"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("7be0e4d3-1e50-4de1-931d-08adb85f628b"), null },
                    { new Guid("c3663f75-7dae-439f-a611-01bd43e4ef9a"), null, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new Guid("a33065fe-80ad-4879-9333-424aadc6734f"), null },
                    { new Guid("c486242a-dfa0-47aa-a65d-2dbfd97f1526"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("26dcc6e0-67aa-40ed-b3d1-8a009c60a62c"), null },
                    { new Guid("c602dd3e-e971-48f5-ab88-a7ad5eac4aa8"), null, new Guid("05cfce09-72b4-482d-adcd-c0718015be3d"), new Guid("24a4ed15-69e4-4fb5-8dd2-1695de52c264"), null },
                    { new Guid("c705f96b-b47f-4552-b9ad-4c0663dcf853"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("23ce32a0-6597-4b60-b35c-98073ff595c6"), null },
                    { new Guid("c7a7113a-a995-4002-b5f9-5bc113dcf1be"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("399eee61-90b5-464f-b3f7-7ddc1077ab0d"), null },
                    { new Guid("c8805671-ad95-44b2-b064-0007b1cab070"), null, new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), new Guid("da254ee7-d229-4769-bad5-a617d09676d4"), null },
                    { new Guid("ccb47dae-f4a4-4ab5-93fb-bb2c4ea394e8"), null, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new Guid("eceaaa32-4023-4eab-abb6-9172c908f77c"), null },
                    { new Guid("cce00a5b-22c7-4374-9af5-9c564e7e1f51"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("cd0b1476-44a8-4350-a6a1-3de8747a5ebc"), null },
                    { new Guid("ce5d3c7c-caed-4bb6-8bf9-4df4f352ef39"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("9c3399d1-72db-4e86-a518-2575033bb6a8"), null },
                    { new Guid("d6353018-ee55-404a-ab3e-79613e871400"), null, new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new Guid("8a81e20e-ea16-4073-957e-29508a8f7419"), null },
                    { new Guid("d794f2a0-402a-4913-ab6c-628d8d42d6c4"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("698c67ad-a726-435b-b9d2-c5690a79eb5a"), null },
                    { new Guid("d7bb1710-ce85-4e27-9c3d-2c3b721ef31c"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("6f34350b-8f99-446e-9de9-e0c6277b10f3"), null },
                    { new Guid("d924d276-9077-4bad-9986-5dd3e5d8bde3"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("e5cc2785-6d62-4b5f-8fc1-e6ab45babd76"), null },
                    { new Guid("dab87fa5-8ef5-4b95-8760-33c4164ddf5d"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("63d10d95-7983-455e-b920-29c1f0c88d85"), null },
                    { new Guid("dafa65de-88e8-48a3-96b5-b606300765f2"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("bf0f7ca4-9089-4800-95d7-8d037d98b7fc"), null },
                    { new Guid("db662b6b-312e-4da3-81f2-8f287bac525f"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("26096793-894d-47c1-a06f-cf9133f8089d"), null },
                    { new Guid("ddab3bdb-7934-4baf-be59-1249195bf5d0"), null, new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new Guid("30f41ca6-c420-4f7d-9602-bf80735d5691"), null },
                    { new Guid("dfd29f26-02bb-407e-b4cb-8abc6f1be2fe"), null, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new Guid("424ebe64-6570-4d88-9052-08c06dc0a2c8"), null },
                    { new Guid("e3293ae7-28f0-43b0-893c-990e20ee0242"), null, new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new Guid("ef6b8c43-9ab5-497c-a9a8-e31f0a349527"), null },
                    { new Guid("ed4ff1c7-dd0e-4782-af9c-a4cba99ed25e"), null, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new Guid("222e1fa2-3910-42ac-9a5c-f371dded16eb"), null },
                    { new Guid("efe76af1-4104-45ad-962b-e6af6949bbbb"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("7b138bd4-4d3a-426c-9ab0-d66699b762d2"), null },
                    { new Guid("f29c08d0-bf8f-4b3a-94f6-42a019eb055f"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("eff728af-c8f0-4bb5-a985-d079cbadb6b5"), null },
                    { new Guid("f5d5417e-eab0-420b-9cff-c4db09fa4f1d"), null, new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), new Guid("fc245902-ef53-4363-b4ce-0e598e1dd4a4"), null },
                    { new Guid("f71004f1-7e72-4929-a1fa-500eeaa60a06"), null, new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new Guid("c4fc900f-5a92-4228-ac03-57285fff159e"), null },
                    { new Guid("fbf979db-99d7-4b36-9757-7bb058c706d0"), null, new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new Guid("5f7f859a-f20a-4f6c-8b8c-ecfbb1ff522e"), null }
                });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "NutritionId", "Calcium", "Calories", "Carbs", "Cholesterol", "CreatedAt", "CreatedBy", "Fat", "Fiber", "FoodId", "Iron", "Potassium", "Protein", "SaturatedFat", "Sodium", "Sugar", "UnsaturatedFat", "UpdatedAt", "UpdatedBy", "VitaminA", "VitaminB1", "VitaminB2", "VitaminC", "VitaminD", "VitaminE" },
                values: new object[,]
                {
                    { new Guid("0095158d-feeb-4171-beed-510382bc0f32"), 47f, 34f, 6.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.6f, new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), 0.7f, 316f, 2.8f, 0f, 33f, 1.7f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 623f, 0.07f, 0.12f, 89.2f, 0f, 0.8f },
                    { new Guid("020465fe-033f-4917-84d0-03986b60fdf8"), 50f, 60f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 3f, new Guid("a988cc73-072e-4af1-9b53-55fbf0f4fe79"), 1.2f, 250f, 3f, 0.5f, 200f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500f, 0.05f, 0.07f, 15f, 0f, 2f },
                    { new Guid("02c7e928-cd83-461d-a895-46e27f1afe30"), 30f, 86f, 20.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3f, new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), 0.6f, 337f, 1.6f, 0f, 55f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.96f, 0.08f, 0.03f, 2.4f, 0f, 0f },
                    { new Guid("03138a2c-2b5c-4b83-8cbb-1487a1a9062b"), 10f, 20f, 4.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.5f, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), 0.3f, 175f, 0.9f, 0f, 3f, 2.4f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.93f, 0.05f, 0.04f, 80f, 0f, 0.37f },
                    { new Guid("03c125f5-27c8-4670-b516-b2da48145547"), 10f, 40f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.5f, new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), 0.1f, 40f, 0.2f, 0f, 3f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.01f, 0.01f, 20f, 0f, 0f },
                    { new Guid("03c41f8e-1865-4344-97b9-2eb1457fc3af"), 30f, 95f, 15f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 1f, new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), 1.2f, 220f, 12f, 0.5f, 400f, 2f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.08f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("0930448a-07ec-4b3b-8445-285500c6da25"), 9f, 206f, 0f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("faf19891-525a-4308-9222-992e83de7ce7"), 0.5f, 363f, 22f, 3.1f, 59f, 0f, 7.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.2f, 0.4f, 0f, 0.38f, 0.5f },
                    { new Guid("0970335b-eb04-4ec8-9b01-28fc3a99ce95"), 16f, 27f, 5.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.2f, new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), 0.7f, 533f, 3f, 0f, 4f, 0.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("09fb51ae-4f7e-4e7d-a36e-b20b37d64163"), 500f, 245f, 0f, 152f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.1f, 0f, new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), 2.8f, 684f, 57f, 0.3f, 702f, 0f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.12f, 0.1f, 0f, 0.6f, 0.2f },
                    { new Guid("0aa3b3a9-39fc-4303-a2f6-c4602da604aa"), 110f, 59f, 4.7f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.6f, 0f, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), 0f, 141f, 3.5f, 1f, 36f, 4.7f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.04f, 0.14f, 0f, 0.02f, 0f },
                    { new Guid("0d067f61-6281-4e8f-8c33-46b55d68289d"), 20f, 220f, 28f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 1f, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), 1f, 100f, 7f, 2f, 450f, 1f, 4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.04f, 0.05f, 2f, 0f, 0.1f },
                    { new Guid("0d532d6d-6bd5-4ef1-b9ec-d3e82bf4244d"), 30f, 86f, 20.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3f, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), 0.6f, 337f, 1.6f, 0f, 55f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.96f, 0.08f, 0.03f, 2.4f, 0f, 0.26f },
                    { new Guid("0db7464e-c0ae-4fad-b4f1-6f90a3cdfb9c"), 25f, 81f, 14.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 5.1f, new Guid("7cd76708-7312-445e-a392-14f0e806a786"), 1.5f, 244f, 5.4f, 0.1f, 5f, 5.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 765f, 0.27f, 0.15f, 40f, 0f, 0.1f },
                    { new Guid("0fff3755-da1b-443b-8771-6c0536f0b670"), 40f, 110f, 20f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 3f, new Guid("2146faae-2e7c-4460-8d81-38f5d313012c"), 1f, 260f, 5.2f, 0.2f, 150f, 1.5f, 1.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.05f, 1f, 0f, 0.3f },
                    { new Guid("11adbaf4-f61f-4bd3-8704-e3fb4dcae26f"), 20f, 230f, 40f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 1.5f, new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), 1.2f, 100f, 7f, 2f, 300f, 3f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.05f, 0.03f, 0f, 0f, 0.2f },
                    { new Guid("120dfe18-5a43-4578-af04-ab7cae24f627"), 20f, 40f, 3f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 1f, new Guid("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), 0.7f, 180f, 6f, 0.3f, 250f, 1.5f, 1.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.07f, 0.05f, 8f, 0f, 0.4f },
                    { new Guid("120e946c-7039-4838-bb3e-2de306871866"), 20f, 250f, 30f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 1f, new Guid("01e60ae4-ff69-44d6-b4fd-aaf916e3a7e5"), 1f, 250f, 14f, 3f, 600f, 3f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150f, 0.1f, 0.1f, 3f, 0f, 0.5f },
                    { new Guid("13ef46b8-813d-4b0c-bfd2-3b3392f61a1c"), 130f, 23f, 4.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2f, new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), 1f, 140f, 2.1f, 0.1f, 40f, 1.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 800f, 0.05f, 0.07f, 40f, 0f, 0.4f },
                    { new Guid("15ee912d-6812-4d9e-901d-4f0e64ca7d2f"), 2f, 96f, 21f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 2.4f, new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), 0.5f, 270f, 3.4f, 0.2f, 1f, 4.5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.15f, 0.1f, 6.8f, 0f, 0.2f },
                    { new Guid("16ceed42-e875-4eaf-bf02-a3b6c7f6fadb"), 18f, 20f, 4.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1f, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), 0.2f, 140f, 1.2f, 0f, 3f, 2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.04f, 10f, 0f, 0.1f },
                    { new Guid("18c272c2-6800-48c7-a443-f62b2c860a52"), 70f, 99f, 0.2f, 189f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 0f, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), 0.4f, 264f, 24f, 0.1f, 111f, 0.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.1f, 0f, 0f, 1.3f },
                    { new Guid("18dbf2dc-0d7e-4ff3-ae2a-f74804967113"), 20f, 35f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 1.5f, new Guid("2ae82bfd-34db-4928-bfee-b60f4aec4460"), 0.5f, 200f, 1f, 0.1f, 250f, 3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500f, 0.05f, 0.03f, 15f, 0f, 1f },
                    { new Guid("19af41aa-6488-4bcc-b657-ca81f697d4b1"), 60f, 350f, 50f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2.5f, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), 1.5f, 300f, 12f, 3f, 700f, 2f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.08f, 0.06f, 2f, 0f, 0.2f },
                    { new Guid("19de50c1-feb8-438b-8c42-cf8b27495379"), 12f, 189f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), 1.1f, 302f, 19f, 4.3f, 60f, 0f, 8.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.33f, 0f, 440f, 0.5f },
                    { new Guid("1dca769c-b465-4414-b0aa-260d855122cf"), 30f, 180f, 10f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 2f, new Guid("a364353c-d589-4a94-9c3b-3038113ea249"), 2.5f, 350f, 20f, 2.5f, 350f, 3f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150f, 0.1f, 0.1f, 25f, 0f, 1f },
                    { new Guid("21144a76-411e-4a75-a9ec-f960777a7bd1"), 81f, 33f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 3.2f, new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), 0.8f, 299f, 1.9f, 0f, 7f, 1.5f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.36f, 0.02f, 0.04f, 21f, 0f, 0.27f },
                    { new Guid("21e03fe3-edad-456a-932a-d8cb47b3ef5a"), 105f, 13f, 2.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1f, new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), 0.8f, 176f, 1.5f, 0f, 65f, 0.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.6f, 0.04f, 0.07f, 45f, 0f, 0.15f },
                    { new Guid("24b3c029-840c-4a71-bb64-ff32faaf3cd5"), 11f, 116f, 0f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), 0.5f, 200f, 25f, 0.2f, 300f, 0f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.09f, 0.2f, 0f, 200f, 0.4f },
                    { new Guid("2840fead-b9e0-4316-b065-c4a6885b8df4"), 37f, 31f, 7.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3.4f, new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), 1f, 211f, 1.8f, 0f, 6f, 1.6f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.69f, 0.02f, 0.1f, 12.2f, 0f, 0.41f },
                    { new Guid("28463371-fb35-422e-96af-da37f9eb3c58"), 40f, 450f, 50f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2.5f, new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), 3f, 350f, 20f, 4f, 900f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.08f, 1f, 0f, 0.2f },
                    { new Guid("2936d4e0-79bc-4a0f-9be3-03fbd1638740"), 50f, 400f, 55f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 3f, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), 2f, 300f, 15f, 4f, 1200f, 4f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.08f, 0.1f, 4f, 0f, 0.2f },
                    { new Guid("2be18ccd-6617-4f5e-80ee-4555b44bcf2d"), 4f, 110f, 24f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.5f, new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), 0.1f, 15f, 1.8f, 0.1f, 10f, 0.1f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.01f, 0.01f, 0f, 0f, 0f },
                    { new Guid("2fb50f12-4b05-4ed9-b975-86b8a605091f"), 21f, 26f, 6.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.1f, new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), 0.8f, 340f, 1f, 0f, 1f, 2.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8533f, 0.05f, 0.11f, 9f, 0f, 0.3f },
                    { new Guid("30b74f69-5177-4313-80fd-8a454780b353"), 6f, 52f, 13.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.4f, new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), 0.1f, 107f, 0.3f, 0f, 1f, 10.4f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.02f, 0.03f, 4.6f, 0f, 0.18f },
                    { new Guid("31dc4a85-8ded-4051-b3b3-5dadc83036f2"), 10f, 50f, 11f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 3f, new Guid("86d88717-df08-4de6-b86d-870210864b46"), 0.3f, 150f, 1.1f, 0.1f, 4f, 8f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.04f, 0.05f, 3f, 0f, 0.3f },
                    { new Guid("35288ebb-5312-481b-8201-f5a3183f9ec4"), 40f, 280f, 30f, 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 2f, new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), 1.5f, 250f, 10f, 3f, 500f, 3f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 250f, 0.1f, 0.1f, 1f, 1f, 0.7f },
                    { new Guid("352ab808-58b1-498b-b21e-247c74c0f694"), 13f, 165f, 0f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.6f, 0f, new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), 1f, 256f, 31f, 1f, 70f, 0f, 2.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0.07f, 0.1f, 0f, 0f, 0.5f },
                    { new Guid("3593cbf5-767e-4270-921b-8d7270319b57"), 15f, 350f, 70f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 3f, new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), 1f, 200f, 8f, 2f, 250f, 2f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.15f, 0.1f, 3f, 0f, 0.2f },
                    { new Guid("38d64bee-b10b-4473-91d6-c2d2d4f5f8d5"), 12f, 189f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), 1.1f, 302f, 19f, 4.3f, 60f, 0f, 8.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.33f, 0f, 440f, 0.5f },
                    { new Guid("390fe193-ac49-4316-b52f-c49632459b4b"), 40f, 25f, 5.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 2.5f, new Guid("8ed85dc2-7654-4c48-81f9-19946a73f71d"), 0.5f, 170f, 1.3f, 0f, 18f, 3.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 75f, 0.05f, 0.04f, 36f, 0f, 0.1f },
                    { new Guid("3a816822-740d-4073-8a5d-5b777d2f8628"), 20f, 85f, 5f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 0.5f, new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), 0.7f, 150f, 12f, 0.5f, 500f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.03f, 0.1f, 1f, 0f, 0.1f },
                    { new Guid("3a9f4096-f816-49c8-b59a-260e2b3f3143"), 40f, 40f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 3f, new Guid("eec3d874-6331-4e33-bbe6-bf0cc4335b29"), 1f, 250f, 2f, 0.1f, 50f, 2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 700f, 0.05f, 0.06f, 25f, 0f, 1f },
                    { new Guid("3d193e10-05d1-4ed9-b4a1-d94f5630c7df"), 40f, 200f, 30f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 2f, new Guid("7a253877-3c54-4fcf-bb05-d9f4e14d5b64"), 1.2f, 200f, 7.5f, 1.5f, 600f, 3f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.1f, 10f, 0f, 0.5f },
                    { new Guid("3e3914f3-7b00-4a7c-ae25-142813d9d10a"), 129f, 322f, 3.6f, 1085f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26.5f, 0f, new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), 2.7f, 109f, 15.9f, 8.7f, 48f, 0.6f, 11.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.53f, 0.08f, 0.37f, 0f, 2f, 2.7f },
                    { new Guid("3edc8cb1-a4e9-4af0-8d55-560f769dc6c7"), 40f, 350f, 55f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 2.5f, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), 1.2f, 250f, 12f, 2.5f, 850f, 4f, 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.1f, 3f, 0f, 0.2f },
                    { new Guid("3f89320a-3f40-4cee-9e0c-c2c68d02c8ff"), 30f, 150f, 18f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 1f, new Guid("cf9ab10f-2094-496b-9018-96b9d2e1af76"), 1f, 250f, 10.5f, 1f, 400f, 1.5f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40f, 0.1f, 0.1f, 5f, 0f, 0.3f },
                    { new Guid("3fe0b0c5-25d8-4bdc-8253-30b9b8e4c5cd"), 125f, 42f, 5f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), 0f, 150f, 3.4f, 0.6f, 44f, 5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.04f, 0.18f, 0f, 0.02f, 0.03f },
                    { new Guid("417a1aa7-d886-415e-9ff3-4d0ac6b5df7c"), 40f, 249f, 1.5f, 80f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0f, new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), 1f, 180f, 16f, 7f, 850f, 0.5f, 9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("4396ce74-6c3d-44c0-8fe7-bdf76890d693"), 45f, 31f, 7.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.1f, new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), 0.6f, 216f, 1.4f, 0f, 27f, 3.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 993f, 0.05f, 0.06f, 36.6f, 0f, 0.1f },
                    { new Guid("44038cdf-db14-42d1-a6f1-51155fa770f5"), 30f, 120f, 18f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), 1.5f, 200f, 15f, 0.5f, 450f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("468ec17b-dc78-41d1-900e-ccd4deff0ab1"), 30f, 150f, 18f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 0.5f, new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), 1.5f, 200f, 8f, 2f, 500f, 1f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("48a4f72a-b613-4296-8aa2-ff5d2d2e7d8a"), 21f, 92f, 3.1f, 233f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.4f, 0f, new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), 0.7f, 279f, 15.6f, 0.5f, 44f, 0f, 0.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.02f, 0.06f, 0f, 0f, 0.01f },
                    { new Guid("48eb657d-2302-4f45-a860-79e4db6015b5"), 70f, 306f, 80f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.1f, 7f, new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), 2.3f, 1040f, 5.8f, 0.6f, 233f, 0.6f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 260f, 0.06f, 0.32f, 6f, 0f, 1f },
                    { new Guid("4cf72972-cf73-4a3d-9094-40c69cd7a399"), 33f, 354f, 73.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.3f, 17.3f, new Guid("642480b4-22c9-4350-a6ce-c052f99e60e3"), 3.6f, 452f, 12.5f, 0.5f, 9f, 0.8f, 1.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22f, 0.27f, 0.16f, 0f, 0f, 0.2f },
                    { new Guid("4f12d9cd-151a-4601-b6eb-fd33628d3906"), 11f, 77f, 17f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 2.2f, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), 0.8f, 425f, 2f, 0f, 6f, 0.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.11f, 0.03f, 19.7f, 0f, 0.01f },
                    { new Guid("4f2601fc-5df9-452c-b55a-fe7976b75c8a"), 15f, 80f, 17f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2f, new Guid("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), 0.6f, 350f, 2f, 0.1f, 350f, 1.5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0.06f, 0.05f, 10f, 0f, 0.1f },
                    { new Guid("4f54cbbf-8da6-41f4-af91-17af01ece2be"), 30f, 440f, 50f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17f, 2f, new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), 2.5f, 320f, 21f, 6f, 650f, 3f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.15f, 0.08f, 2f, 0f, 0.4f },
                    { new Guid("50477205-545d-4bbb-a7a6-feb3131d1769"), 20f, 250f, 32f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 1f, new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), 1.5f, 150f, 10f, 3f, 480f, 1.5f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("50ce8cfe-7a14-4a11-9b41-cfa2714f60c5"), 22f, 265f, 49f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.2f, 2.7f, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), 2.4f, 115f, 8f, 0.5f, 491f, 5.6f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.2f, 0.12f, 0f, 0f, 0.1f },
                    { new Guid("548c5e52-88c4-4aa5-aa26-07eeaef41858"), 8f, 250f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0f, new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), 1.3f, 220f, 19f, 7f, 65f, 0f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.05f, 0f, 0f, 0.1f },
                    { new Guid("557146c4-cb9c-4951-8a0c-11ce69604bbb"), 60f, 90f, 10f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 0f, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), 0.2f, 80f, 2f, 2f, 40f, 8f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.04f, 0.06f, 0f, 0f, 0.1f },
                    { new Guid("580214d4-4029-4e52-9d39-21a28a598f43"), 55f, 35f, 7.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.6f, 2.5f, new Guid("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), 1f, 450f, 2.4f, 0.1f, 250f, 0.9f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 700f, 0.05f, 0.1f, 45f, 0f, 1.2f },
                    { new Guid("58b92264-0c4c-4109-9f8c-c05065c55df4"), 30f, 300f, 40f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2f, new Guid("05cfce09-72b4-482d-adcd-c0718015be3d"), 1.2f, 150f, 10f, 3f, 400f, 3f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.08f, 0.05f, 2f, 0f, 0.2f },
                    { new Guid("599982b9-f604-4dfd-a5ce-637d27a900ef"), 30f, 130f, 18f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.5f, 1f, new Guid("30f9d9dc-1653-495c-99b7-b649c49f7930"), 1.2f, 180f, 6f, 1.5f, 500f, 1f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.1f, 0.1f, 2f, 0f, 0.3f },
                    { new Guid("59e60338-49a3-4ca8-8347-d19081264faa"), 107f, 562f, 27.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45.4f, 10.3f, new Guid("404a286a-90c5-4c54-8e27-3ddeba55ada3"), 4f, 1025f, 20.3f, 5.6f, 1f, 7.7f, 39.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26f, 0.87f, 0.16f, 5.4f, 0f, 2.9f },
                    { new Guid("5c480d77-a10f-4bab-becc-15fbcc061cb5"), 55f, 22f, 3.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.2f, new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), 1.8f, 500f, 2.1f, 0f, 15f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8890f, 0.05f, 0.18f, 37.5f, 0f, 0.4f },
                    { new Guid("5df08b89-282b-4a03-ba93-f1b856ba5a76"), 255f, 534f, 28.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42.2f, 27.3f, new Guid("7729551a-e475-4079-aaa0-07c02efde2a5"), 5.7f, 813f, 18.3f, 3.7f, 30f, 1.6f, 38.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.41f, 0.16f, 0.6f, 0f, 0.3f },
                    { new Guid("5e43c1d3-abca-4c35-940a-65811883a7a7"), 20f, 59f, 15f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2f, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), 0.3f, 257f, 0.9f, 0f, 3f, 9.8f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.95f, 0.03f, 0.04f, 61f, 0f, 0f },
                    { new Guid("5efd30b9-7c6e-4afe-b10e-ed6fe2291396"), 56f, 155f, 1.1f, 373f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10.6f, 0f, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), 1.8f, 126f, 13f, 3.3f, 124f, 1.1f, 3.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.52f, 0.04f, 0.5f, 0f, 1.1f, 0.5f },
                    { new Guid("6203b29a-a9ca-4c5f-913c-12d6ce108130"), 30f, 260f, 42f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 1.5f, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), 1.2f, 120f, 9f, 2.5f, 350f, 6f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("635e95f5-a8d9-4962-ac46-504975777397"), 20f, 296f, 1.7f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26f, 0f, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), 1.2f, 200f, 12f, 9f, 1020f, 0.2f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.3f, 0.12f, 0f, 0f, 0.4f },
                    { new Guid("63c54c95-db6a-4894-9cf2-41d002c99e65"), 10f, 132f, 0f, 51f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), 0.9f, 252f, 29f, 0.3f, 37f, 0f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.07f, 0.18f, 0f, 0.8f, 0.2f },
                    { new Guid("648a4250-cd04-40ce-aa8e-3a31b65906f3"), 277f, 172f, 8.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9f, 6f, new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), 2.5f, 620f, 18f, 1.3f, 15f, 3f, 7.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9f, 0.16f, 0.18f, 6f, 0f, 0.9f },
                    { new Guid("65dc193e-3688-4ed4-b6bf-c5d884c057cc"), 16f, 13f, 3.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.5f, new Guid("3dc2fa80-ab87-4e26-907b-3516611371b8"), 0.3f, 140f, 0.6f, 0f, 125f, 1.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0.05f, 0.06f, 12f, 0f, 0.1f },
                    { new Guid("6735671e-1ce0-48a8-949e-b42ce9661f14"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("676ed336-f41d-45f9-8ec3-4cbe54dee209"), 40f, 50f, 8.5f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 1.5f, new Guid("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), 0.5f, 230f, 3.5f, 0.2f, 300f, 3.5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 850f, 0.05f, 0.07f, 15f, 0f, 0.5f },
                    { new Guid("677921f0-44e4-4934-9c77-86eece60fa22"), 18f, 271f, 0f, 82f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19f, 0f, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), 2.7f, 300f, 26f, 7.4f, 62f, 0f, 11.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.18f, 0f, 8f, 0.5f },
                    { new Guid("6a1f325c-f9f8-4597-9c81-25b347ae1f0c"), 15f, 190f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 0f, new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), 1.4f, 250f, 28f, 2.5f, 60f, 0f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.06f, 0.15f, 0f, 0f, 0.7f },
                    { new Guid("6d3704e7-5692-4bf3-b7df-a7bb98f5f6d0"), 201f, 76f, 1.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.8f, 0.3f, new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), 1.6f, 121f, 8f, 0.7f, 7f, 0.4f, 2.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.03f, 0f, 0f, 0.02f },
                    { new Guid("6ec362c4-d059-44b4-808e-42af1aed4259"), 20f, 16f, 3.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.8f, new Guid("e370081a-c0a6-4c00-b01c-7c52f953b7f1"), 0.2f, 150f, 0.6f, 0f, 50f, 2.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.05f, 0.04f, 12f, 0f, 0.2f },
                    { new Guid("706f8176-fbf4-43ff-8d35-b5c541bb9f28"), 40f, 410f, 50f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 3f, new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), 2f, 250f, 16f, 5f, 800f, 5f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.08f, 3f, 0f, 0.3f },
                    { new Guid("70a101a2-26cb-484b-b9cb-65654f5d6e0d"), 5f, 28f, 4.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.2f, new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), 0.3f, 300f, 2.8f, 0f, 3f, 1f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.06f, 0.07f, 0.5f, 0.02f, 0.1f },
                    { new Guid("70c95055-c298-4a1e-a48c-b3b8b206a35e"), 30f, 40f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2.5f, new Guid("00bc33fe-4cd5-47df-bd94-15ac9f93648c"), 0.8f, 200f, 2f, 0.1f, 250f, 3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 600f, 0.06f, 0.05f, 20f, 0f, 1f },
                    { new Guid("70efe56a-59e7-4e3d-85b3-5caf4376b2b7"), 70f, 99f, 0.2f, 189f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), 0.3f, 259f, 20.9f, 0.2f, 111f, 0f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.02f, 0.11f, 0f, 0f, 0.6f },
                    { new Guid("71d7e327-2650-4634-aeef-c000d3a6450c"), 25f, 150f, 2f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 0.5f, new Guid("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), 1.5f, 300f, 23f, 1.5f, 350f, 1f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 80f, 0.1f, 0.07f, 2f, 0.5f, 0.3f },
                    { new Guid("71e01b7e-59b2-42d8-b911-e7437f79415d"), 25f, 54f, 6.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.6f, 0.4f, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), 0.7f, 118f, 3.3f, 0.2f, 51f, 1.2f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.03f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("73a71946-e0af-4c59-bc6e-616a373f35cd"), 30f, 300f, 3f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24f, 0.2f, new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), 2f, 400f, 20f, 9f, 900f, 1.5f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("7487544b-7c61-4d7c-9099-16bca5d13a6a"), 5f, 90f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.6f, new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), 0.3f, 360f, 1f, 0.1f, 1f, 12f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("74cd29cb-e521-40b8-b22f-af62ba3ae592"), 50f, 250f, 30f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2f, new Guid("8382816f-1beb-4804-9698-3b486798b20a"), 1f, 250f, 10f, 3f, 450f, 2f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.2f, 0.1f, 0f, 0f, 0.5f },
                    { new Guid("75652e97-dd85-4227-8228-bf8a779e9506"), 18f, 14f, 3.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.5f, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), 0.3f, 170f, 0.6f, 0f, 1f, 1.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.02f, 0.02f, 10f, 0f, 0.01f },
                    { new Guid("76d74b8e-8453-4952-896e-c29b692b922a"), 10f, 160f, 30f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), 0.4f, 100f, 5f, 1f, 250f, 1.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.02f, 0.02f, 0f, 0f, 0.1f },
                    { new Guid("77acaed4-7386-4ade-a229-ca6b142cb340"), 20f, 150f, 30f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 2f, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), 1f, 100f, 5f, 0.5f, 300f, 2.5f, 1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.06f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("78764fc5-dde1-4b28-a432-2a1f0eb558ae"), 20f, 150f, 8f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 1f, new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), 2f, 250f, 12f, 3f, 500f, 2f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.1f, 0.1f, 5f, 0f, 0.5f },
                    { new Guid("78c1b3bf-4692-4f68-8402-0e003d8bd2c7"), 30f, 40f, 9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2.5f, new Guid("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), 0.8f, 250f, 2f, 0.1f, 300f, 3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 600f, 0.06f, 0.05f, 20f, 0f, 1f },
                    { new Guid("7972716c-d2a1-4acb-9697-26921f5d2b3a"), 27f, 132f, 23.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 8.7f, new Guid("9349fefa-ecbc-4afc-89f4-62c2f67eb441"), 2.1f, 355f, 8.9f, 0.1f, 5f, 0.3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 0.24f, 0.21f, 0f, 0f, 0.2f },
                    { new Guid("7d2359f1-67c5-43c2-a7ee-48a44b86c4bc"), 20f, 250f, 0f, 90f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 0f, new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), 2.5f, 280f, 26f, 6f, 75f, 0f, 9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.2f, 0f, 7f, 0.5f },
                    { new Guid("7d8a46dd-ca73-4764-8809-993a021367dc"), 30f, 420f, 60f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), 1.5f, 200f, 12f, 4f, 500f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.06f, 1f, 0f, 0.3f },
                    { new Guid("7e67ba13-3c81-41d4-add5-cf7a45b41c6a"), 12f, 239f, 0f, 88f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14f, 0f, new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), 1.2f, 223f, 27f, 3.8f, 82f, 0f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.07f, 0.13f, 0f, 0.02f, 0.3f },
                    { new Guid("7ed97a5a-7955-4950-bac6-2cccc9f1bc2d"), 54f, 389f, 66.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6.9f, 10.6f, new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), 4.7f, 362f, 16.9f, 1.2f, 2f, 0.6f, 5.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.76f, 0.14f, 0f, 0f, 0.42f },
                    { new Guid("7f2bbc4b-bde5-49bc-9a2f-1e3198ddb1e4"), 40f, 30f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2.5f, new Guid("90a605b6-843d-4cc1-8fe7-a016c76ee29c"), 0.9f, 300f, 2f, 0.1f, 100f, 1f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500f, 0.04f, 0.05f, 30f, 0f, 0.5f },
                    { new Guid("815cb8a7-ca70-47aa-9a9a-40bca0134043"), 40f, 190f, 28f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 1.5f, new Guid("2405ffc3-524e-4331-9e68-47a411d7b9b8"), 1f, 150f, 5f, 1.5f, 500f, 2f, 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.08f, 5f, 0f, 0.4f },
                    { new Guid("85da32fe-b9ec-463a-bf6d-c4f8ec649e8e"), 350f, 145f, 5.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 1f, new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), 3f, 230f, 15f, 1f, 10f, 1.2f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 0.05f, 0.1f, 0.5f, 0f, 0.4f },
                    { new Guid("85dc7dfc-bcd3-4d5f-91cc-65dca68e1590"), 12f, 73f, 18f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.6f, 1.5f, new Guid("3d19d971-88d0-4108-a335-24ac9e1dec50"), 0.3f, 42f, 0.6f, 0.1f, 10f, 15f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.05f, 5f, 0f, 0.1f },
                    { new Guid("8602d293-ea35-4b81-ba71-99dc7c564653"), 40f, 140f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 5f, new Guid("8ebd5a6e-b0af-42b6-af58-b681fceac1ef"), 2f, 300f, 5f, 0.5f, 30f, 12f, 1.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("88712f9f-9afe-4e38-b515-d911a6b7aaff"), 11f, 165f, 0f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.6f, 0f, new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), 0.9f, 256f, 31f, 1f, 74f, 0f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.06f, 0.08f, 0f, 0f, 0.3f },
                    { new Guid("8979aea7-f0c6-4324-9cb5-8a950b9a404a"), 40f, 300f, 50f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 2f, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), 1.5f, 250f, 10f, 2f, 700f, 3f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.08f, 0.06f, 1f, 0f, 0.2f },
                    { new Guid("89e05c8d-25a1-469d-979e-164df5ff6216"), 40f, 450f, 50f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 3f, new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), 2f, 250f, 20f, 5f, 700f, 5f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.12f, 0.1f, 3f, 0f, 0.5f },
                    { new Guid("8b163e4a-5baf-43ee-a684-7059d17a0014"), 7f, 242f, 0f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14f, 0f, new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), 0.9f, 370f, 27f, 5.2f, 65f, 0f, 8.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.6f, 0.15f, 0f, 0f, 0.2f },
                    { new Guid("8be97299-04c4-4989-b9e4-81322b419c03"), 20f, 200f, 25f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 1f, new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), 1.2f, 150f, 10f, 2f, 300f, 1f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("8c7ffec2-89d7-4636-a702-27bd21a10e31"), 6f, 46f, 11.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.4f, new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), 0.2f, 157f, 0.7f, 0f, 0f, 9.9f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.04f, 9.5f, 0f, 0.4f },
                    { new Guid("8cd9e5d9-c3cf-4680-9434-e0ea2594f147"), 24f, 20f, 3.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.1f, new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), 0.5f, 202f, 2.2f, 0f, 2f, 1.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 756f, 0.08f, 0.14f, 5.6f, 0f, 1.1f },
                    { new Guid("8f65d8bb-1a90-4060-b2b0-1ad3cb4839d2"), 10f, 69f, 18.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.9f, new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), 0.4f, 191f, 0.7f, 0f, 2f, 16.3f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 92f, 0.03f, 0.04f, 10.8f, 0f, 0.1f },
                    { new Guid("9129ccf5-7bb6-4956-8b18-cc508e734560"), 30f, 130f, 6f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.5f, 1.5f, new Guid("85e621ed-0e0c-4d20-8891-51d311cea4a3"), 2f, 250f, 200f, 1.5f, 400f, 2f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40f, 0.1f, 0.1f, 4f, 0f, 0.5f },
                    { new Guid("91ab7948-0c12-43c7-8e79-2fe69fb946a5"), 20f, 170f, 23f, 15f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 1f, new Guid("a1ff09f1-9d02-40a8-84de-8da9aad67c58"), 0.7f, 150f, 4f, 1f, 350f, 1f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.05f, 0.05f, 0f, 0f, 0.2f },
                    { new Guid("92675867-e239-4dd6-b9c4-9f906a98f659"), 110f, 64f, 9.4f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 0.4f, new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), 0f, 140f, 3.4f, 1f, 35f, 7.5f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.04f, 0.14f, 0f, 0.02f, 0f },
                    { new Guid("947112f2-6e29-4613-a744-83530ce003b9"), 27f, 16f, 3.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.6f, new Guid("845454d0-967a-4e48-aef3-bd8458775500"), 0.3f, 233f, 0.6f, 0f, 9f, 1.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.03f, 14.8f, 0f, 0.2f },
                    { new Guid("94ab6357-248b-47b6-a93b-76526bf74d86"), 5f, 89f, 22.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.6f, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), 0.3f, 358f, 1.1f, 0.1f, 1f, 12.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("94cc816d-b001-4ee2-9bee-0fc25d7b5cb6"), 21f, 83f, 19.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 5.3f, new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), 0.8f, 193f, 0.4f, 0.1f, 12f, 14.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 60f, 0.01f, 0.02f, 14.7f, 0f, 0.1f },
                    { new Guid("96c85bf5-e230-4dd2-95c4-fcb91aa2d9a0"), 35f, 420f, 50f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2.5f, new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), 2.5f, 320f, 18f, 3f, 850f, 2f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.08f, 0.1f, 0.07f, 1f, 0f, 0.3f },
                    { new Guid("9733ba31-6fc3-4f73-b41b-55ae447c8aed"), 43f, 142f, 34.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 5.1f, new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), 0.6f, 484f, 0.5f, 0f, 13f, 0.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47f, 0.09f, 0.03f, 4.5f, 0f, 0.1f },
                    { new Guid("98946027-2079-436d-9abb-6d6c6f50d8bc"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("99d6bc2b-509e-4971-942c-4dae142859cc"), 34f, 61f, 14.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 3f, new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), 0.3f, 312f, 1.1f, 0f, 3f, 8.9f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 87f, 0.02f, 0.05f, 92.7f, 0f, 1.5f },
                    { new Guid("9aff4c17-18bb-4d33-91f8-2950b986bb2c"), 18f, 68f, 14.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.9f, 5.4f, new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), 0.3f, 417f, 2.6f, 0.3f, 2f, 8.9f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.21f, 0.07f, 0.04f, 228.3f, 0f, 0.73f },
                    { new Guid("9ca99f42-fccf-4580-866a-60e0aef5f680"), 5f, 89f, 22.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.6f, new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), 0.3f, 358f, 1.1f, 0.1f, 1f, 12.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("9e526d95-4c9e-46ae-ad16-2693e17b639c"), 15f, 165f, 1.1f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.6f, 0.2f, new Guid("43d635e2-6f0c-4385-83d8-fedfd479d356"), 1f, 220f, 31f, 1f, 340f, 0.5f, 2.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0.08f, 0.07f, 0f, 0f, 0.4f },
                    { new Guid("9ea81029-4fe9-4ac9-8ebd-4fa5d55b363d"), 11f, 337f, 0f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28f, 0f, new Guid("51061170-597d-4289-a021-1e7dde88331f"), 2.7f, 205f, 19f, 8.5f, 63f, 0f, 12.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.06f, 0.15f, 0.23f, 0f, 0.02f, 0.3f },
                    { new Guid("9f21b294-7723-4d85-85be-33a89a27af05"), 50f, 400f, 60f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 3f, new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), 2f, 300f, 12f, 4f, 500f, 2.5f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.08f, 3f, 0f, 0.3f },
                    { new Guid("a020c101-8a53-4523-875d-eb60d6c3f5fb"), 357f, 145f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 1.8f, new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), 2.8f, 240f, 12f, 1.1f, 15f, 2.3f, 5.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 0.08f, 0.16f, 5f, 0f, 0.5f },
                    { new Guid("a031d885-cd40-4f9c-a350-6df9d3c3a323"), 10f, 18f, 3.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.2f, new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), 0.3f, 237f, 0.9f, 0f, 5f, 2.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.85f, 0.04f, 0.02f, 13.7f, 0f, 0.5f },
                    { new Guid("a0a6c288-1561-4822-b22d-529d94840dcc"), 40f, 52f, 13f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.4f, new Guid("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), 0.1f, 181f, 1f, 0f, 1f, 9.4f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.04f, 53.2f, 0f, 0.2f },
                    { new Guid("a4b8e853-eb8c-4b2d-b78e-b0765adebec8"), 110f, 59f, 3.6f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 0f, new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), 0.1f, 141f, 10f, 0.2f, 36f, 3.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 0.04f, 0.14f, 0f, 0f, 0f },
                    { new Guid("a59c20c1-dee7-461c-80b7-706fe72b8d15"), 15f, 70f, 6f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), 1f, 200f, 6f, 0.5f, 300f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.05f, 0.06f, 4f, 0f, 0.3f },
                    { new Guid("a5a34c9e-0a6f-4cca-95b8-ddd020c929a5"), 10f, 130f, 28.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 0.4f, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), 0.2f, 35f, 2.7f, 0.1f, 1f, 0.1f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.01f, 0f, 0f, 0f },
                    { new Guid("a61944cb-b25c-4c0d-96ee-8ddb8af6bfd2"), 40f, 70f, 6f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 2f, new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), 1.5f, 250f, 7f, 0.5f, 300f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 300f, 0.05f, 0.1f, 5f, 0f, 0.5f },
                    { new Guid("a79d6bc7-4895-4399-bb66-9df7ae36da2c"), 20f, 15f, 3.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1f, new Guid("6487a532-ff5e-4b77-b408-46c789608de9"), 0.3f, 150f, 1f, 0f, 180f, 2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 0.03f, 0.02f, 7f, 0f, 0.1f },
                    { new Guid("a8e51bba-c7b5-431f-91bf-2adfb7d1e968"), 3f, 37f, 7.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.5f, new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), 0.4f, 359f, 2.7f, 0f, 3f, 0.5f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.11f, 0.1f, 2.1f, 0f, 0.01f },
                    { new Guid("a91a00c3-40f5-4dbc-b229-ecfa06ad328a"), 50f, 40f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 2f, new Guid("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), 1.2f, 250f, 3f, 0.2f, 300f, 1f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 400f, 0.05f, 0.07f, 20f, 0f, 0.5f },
                    { new Guid("a9404e07-5519-46db-92a4-6c95ebaea8b0"), 8f, 110f, 23.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.6f, 1.9f, new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), 0.2f, 60f, 2.5f, 0.1f, 4f, 0.3f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("a9488a0e-e0ea-4c14-ac4b-07f647bceadf"), 10f, 150f, 30f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 1f, new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), 0.5f, 50f, 3f, 0.5f, 300f, 2f, 1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.01f, 0.01f, 0f, 0f, 0.1f },
                    { new Guid("a9f4d8ff-44f8-4e50-ba7a-508b1e9fc4d0"), 40f, 230f, 30f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 1f, new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), 1.2f, 200f, 15f, 1.5f, 500f, 3f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.1f, 2f, 0f, 0.5f },
                    { new Guid("aa66eab0-f112-455c-9102-fe47bf99af54"), 9f, 60f, 16f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1f, new Guid("a504d882-4f38-413e-bb28-fae1f2787150"), 0.3f, 42f, 0.9f, 0f, 1f, 13f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.05f, 10f, 0f, 0.1f },
                    { new Guid("aae6b458-a347-446c-8580-608e1e2fd273"), 10f, 83f, 18.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.2f, 4f, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), 0.3f, 236f, 1.7f, 0.1f, 3f, 13.7f, 1.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.07f, 0.06f, 10.2f, 0f, 0.6f },
                    { new Guid("aaeef033-8c12-48c6-a076-4a5687cf0ace"), 30f, 90f, 6f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), 1f, 250f, 12f, 1f, 450f, 2f, 2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.1f, 5f, 0f, 0.4f },
                    { new Guid("ab8ecd1d-54bd-4036-bf3a-e2dbd21c024d"), 77f, 35f, 5.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 1.5f, new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), 1.5f, 312f, 3.6f, 0f, 113f, 0.5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6.3f, 0.04f, 0.09f, 55f, 0f, 1.5f },
                    { new Guid("abe4c644-9b00-4a9c-81b9-5c3657fb3408"), 16f, 43f, 9.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.8f, new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), 0.8f, 325f, 1.6f, 0f, 78f, 6.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33f, 0.05f, 0.03f, 4.9f, 0f, 0.1f },
                    { new Guid("ac76ea79-3d5f-4fe3-b96c-5271ba262b3e"), 114f, 19f, 3.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2f, new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), 2.1f, 554f, 2f, 0f, 30f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8100f, 0.08f, 0.16f, 51.9f, 0f, 1.9f },
                    { new Guid("ac78a7cc-756f-41d6-ac3f-b6288891cb38"), 50f, 380f, 45f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), 2f, 450f, 16f, 4f, 1200f, 4f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.2f, 2f, 0f, 0.4f },
                    { new Guid("b06a517a-dd47-4aad-a8f9-88a209596093"), 9f, 57f, 15.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3.1f, new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), 0.2f, 116f, 0.4f, 0f, 1f, 9.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25f, 0.02f, 0.03f, 4.3f, 0f, 0.1f },
                    { new Guid("b09efab3-8def-4c76-824e-b95e721a2a19"), 11f, 45f, 10.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.2f, new Guid("de097440-db5c-4d91-bd55-76618d70599d"), 0.1f, 200f, 0.7f, 0f, 1f, 8.4f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.1f, 0.02f, 50f, 0f, 0.02f },
                    { new Guid("b0b78051-9ae9-49a7-a878-d6ef52d2ef41"), 150f, 23f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.1f, new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), 1.6f, 296f, 2f, 0.1f, 50f, 1f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 740f, 0.07f, 0.09f, 55f, 0f, 1.2f },
                    { new Guid("b2595d86-40ae-4f52-a688-7c53c16d53f0"), 85f, 718f, 13.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 75.8f, 8.6f, new Guid("731974ef-495e-4c08-ba95-20589d60c20c"), 2.5f, 363f, 7.9f, 12.1f, 5f, 4.6f, 63.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.21f, 0.16f, 1.1f, 0f, 0.6f },
                    { new Guid("b3e0c8ca-c26e-43a7-92b2-a3ea87c136b8"), 40f, 25f, 5.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.8f, new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), 0.5f, 252f, 1.3f, 0f, 13f, 1.4f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.37f, 0.04f, 0.04f, 36.6f, 0f, 0.12f },
                    { new Guid("b48dcece-3934-4aa7-9d65-6bb0a44c0fbf"), 46f, 559f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49f, 6f, new Guid("59988378-901f-4ec4-bd6c-9fdc28ca97a1"), 8.8f, 809f, 30f, 8.7f, 18f, 1.4f, 40.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.19f, 0.32f, 0f, 0f, 2.2f },
                    { new Guid("b4a08f53-86b3-4103-988b-9058d10eddaf"), 10f, 100f, 3f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 0f, new Guid("c81a404a-ec10-428e-acec-dd56ec1d3607"), 0.8f, 200f, 8f, 2f, 500f, 1f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.04f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("b6dc8c03-9a21-48d8-8b8a-0b895edc6c19"), 20f, 230f, 40f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 1f, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), 1.2f, 100f, 7f, 2f, 300f, 5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("b7554e8e-9bf0-4f52-b354-1f672c3ff5f2"), 30f, 110f, 15f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), 1.5f, 250f, 14f, 0.5f, 500f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150f, 0.1f, 0.1f, 5f, 0f, 0.4f },
                    { new Guid("bcba3e2d-93c1-4e1a-a9c0-7a0a389a75a6"), 30f, 400f, 45f, 80f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 3f, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), 2f, 200f, 15f, 5f, 600f, 3.5f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.1f, 0.08f, 2f, 0f, 0.3f },
                    { new Guid("bcfe0940-22bd-4b69-a155-8fc25bf291f8"), 15f, 239f, 0f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14f, 0f, new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), 0.8f, 260f, 27f, 4.1f, 70f, 0f, 9.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 0.06f, 0.11f, 0f, 0f, 0.3f },
                    { new Guid("bd3ceb50-ceb9-4ea8-a193-794247f0862f"), 23f, 40f, 9.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.7f, new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), 0.2f, 146f, 1.1f, 0f, 4f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.05f, 0.02f, 7.4f, 0f, 0.02f },
                    { new Guid("bd4aa901-e349-483d-8572-1a676ed934d5"), 14f, 354f, 15.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33.5f, 9f, new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), 2.4f, 356f, 3.3f, 29.7f, 20f, 6.2f, 3.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.02f, 3.3f, 0f, 0.3f },
                    { new Guid("bd80c14d-c372-4ced-9940-ab6b40b919b0"), 10f, 90f, 15f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 0.5f, new Guid("c5e3e4ed-0164-4917-a1ce-99679b971a22"), 0.6f, 150f, 6f, 0.5f, 300f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.06f, 0.05f, 1f, 0f, 0.2f },
                    { new Guid("c25ca53b-8964-4e89-81fc-28178dfa380c"), 2f, 2f, 0f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), 0f, 49f, 0.1f, 0f, 5f, 0f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, 0f, 0f, 0f, 0f },
                    { new Guid("c5925176-b02b-43f3-882f-1b44b54378d3"), 40f, 23f, 4.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2f, new Guid("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), 1f, 250f, 2f, 0.1f, 25f, 1.5f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 450f, 0.07f, 0.08f, 25f, 0f, 0.4f },
                    { new Guid("c70fa704-2a2e-4a6e-b60c-818a5d6b2a5d"), 40f, 30f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2.5f, new Guid("4edcae53-7e30-42bb-8526-7686355f2268"), 1f, 300f, 2f, 0.1f, 150f, 2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500f, 0.05f, 0.06f, 30f, 0f, 0.5f },
                    { new Guid("c763c3d4-cc90-4185-8cbd-37474ec5a22b"), 10f, 112f, 23.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.9f, 1.8f, new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), 0.4f, 86f, 2.6f, 0.2f, 1f, 0.4f, 0.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.14f, 0.02f, 0f, 0f, 0.1f },
                    { new Guid("c7733287-0935-4bf4-9943-1ff038cbfc6e"), 7f, 30f, 7.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.4f, new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), 0.2f, 112f, 0.6f, 0f, 1f, 6.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.57f, 0.03f, 0.02f, 8.1f, 0f, 0.05f },
                    { new Guid("c8a17989-c4a7-45cc-8ccf-c739517f2dfe"), 15f, 110f, 14f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 0.5f, new Guid("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), 0.9f, 180f, 7f, 1f, 350f, 1f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0.05f, 0.07f, 1f, 0f, 0.2f },
                    { new Guid("c991cebc-0380-42bf-bf40-d385ea93fb90"), 20f, 120f, 16f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 0.5f, new Guid("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), 1f, 200f, 10f, 1f, 350f, 1f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.06f, 0.07f, 2f, 0f, 0.3f },
                    { new Guid("c9ba2e65-0ee5-422e-9222-95890c57f9d4"), 33f, 41f, 9.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.8f, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), 0.3f, 320f, 0.9f, 0f, 69f, 4.7f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.69f, 0.04f, 0.03f, 5.9f, 0f, 0.66f },
                    { new Guid("cb66ad43-ce15-4296-ba5a-ef7633c7b880"), 20f, 150f, 22.5f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6.5f, 1f, new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), 0.7f, 120f, 3f, 1f, 400f, 1.5f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.08f, 0.05f, 1f, 0f, 0.2f },
                    { new Guid("cc969c1a-b3f6-4d0f-84a3-e6e439ae857b"), 12f, 206f, 0f, 63f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), 0.5f, 363f, 22f, 3.1f, 59f, 0f, 9.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.38f, 0f, 570f, 0.4f },
                    { new Guid("ced8ce0a-e018-4e94-96b2-b6843ca8a405"), 120f, 42f, 5f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), 0.1f, 150f, 3.4f, 0.6f, 44f, 5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47f, 0.02f, 0.18f, 0f, 2f, 0.1f },
                    { new Guid("cef6eef5-cb44-48ab-b7be-e88ca3cad658"), 120f, 120f, 18f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), 0.6f, 200f, 4f, 1f, 50f, 12f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.1f, 2f, 0.1f, 0.1f },
                    { new Guid("d14c94e3-98ee-4271-b04f-75e8e533c55c"), 25f, 70f, 6f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 1f, new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), 1f, 250f, 10f, 0.5f, 500f, 2f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.1f, 10f, 0f, 0.3f },
                    { new Guid("d2dffd6f-b9d2-4490-bc34-400f2f356cb4"), 11f, 60f, 15f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 1.6f, new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), 0.2f, 168f, 0.8f, 0.1f, 1f, 13.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.54f, 0.03f, 0.04f, 36.4f, 0f, 0.9f },
                    { new Guid("d3add970-333f-4000-a420-4258de9fd79a"), 35f, 28f, 6.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.5f, new Guid("0292d477-d63b-4904-a83b-2cd8cac39c14"), 0.5f, 330f, 1.2f, 0.1f, 250f, 3.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 600f, 0.05f, 0.08f, 45f, 0f, 0.7f },
                    { new Guid("d8590ae8-d7b7-46bf-866b-38bbfd705e59"), 6f, 39f, 9.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.5f, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), 0.3f, 190f, 0.9f, 0f, 0f, 8.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 326f, 0.02f, 0.05f, 6.6f, 0f, 0.1f },
                    { new Guid("d954ae3d-ee53-49f4-b84d-d64987d02df5"), 15f, 242f, 3.1f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17.2f, 0.5f, new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), 1.2f, 330f, 22.5f, 6.5f, 530f, 1.2f, 10.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45f, 0.8f, 0.2f, 0f, 0f, 0.3f },
                    { new Guid("da0ea45f-b88f-4b0f-91d3-a1c445a517b3"), 15f, 417f, 1.4f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39f, 0f, new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), 1f, 200f, 13f, 14.6f, 800f, 1.2f, 24.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.09f, 0f, 0f, 0.3f },
                    { new Guid("dae87c45-ef94-4879-a6fb-5ddd2a7266c2"), 3f, 11f, 3.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), 0.1f, 15f, 0.2f, 0f, 2f, 1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.02f, 20f, 0f, 0f },
                    { new Guid("de597840-c144-4797-a749-321f1757197e"), 15f, 30f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2f, new Guid("827829bf-71cd-4865-80af-1457e0091456"), 0.8f, 300f, 2f, 0.1f, 250f, 1f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 0.05f, 0.03f, 4f, 0f, 0.3f },
                    { new Guid("df7091bb-763c-421b-b182-e9aff2384e00"), 10f, 110f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.9f, 1.8f, new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), 0.4f, 43f, 2.6f, 0.2f, 1f, 0.4f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.16f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("e22f7140-8bd3-4c58-9b8c-84019147f3be"), 11f, 117f, 0f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.3f, 0f, new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), 0.4f, 265f, 20f, 0.7f, 670f, 0f, 3.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.09f, 0.2f, 0f, 200f, 0.6f },
                    { new Guid("e28d5920-d765-40b2-a1da-7067b0fb8a15"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("e53983df-2b78-47f8-9d87-c7adc5a0398e"), 25f, 105f, 15f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("7167f942-dc89-4f29-8022-588373aef45e"), 0.9f, 220f, 10f, 0.5f, 400f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 80f, 0.05f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("e5610377-d3a1-4db4-aac0-47ba279b0c5f"), 22f, 68f, 16.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.9f, new Guid("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), 0.3f, 42f, 0.9f, 0f, 0f, 15f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.05f, 0.05f, 20f, 0f, 0.1f },
                    { new Guid("e64c6bba-c0d7-4cef-8aba-e81e468b50f7"), 40f, 450f, 50f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), 3f, 350f, 20f, 4f, 900f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.08f, 1f, 0f, 0.2f },
                    { new Guid("e66351b1-9159-4555-95c8-5b58b8548ca0"), 24f, 19f, 3.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0f, new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), 0.3f, 250f, 0.7f, 0f, 11f, 2.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.02f, 2.4f, 0f, 0f },
                    { new Guid("e6d4ac88-0657-4dfd-8dcf-8e9c61ddc6fe"), 30f, 120f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 4f, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), 1.2f, 200f, 3f, 1f, 50f, 10f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.03f, 0.02f, 0f, 0f, 0f },
                    { new Guid("e78183cd-7d05-419e-93f1-34f31826c516"), 20f, 150f, 30f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), 0.4f, 100f, 3f, 1f, 250f, 1.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.04f, 0.02f, 0f, 0f, 0.05f },
                    { new Guid("e82b4476-53a8-4d08-9b4d-987b05d67731"), 10f, 290f, 0f, 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23f, 0f, new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), 1.5f, 200f, 20f, 9f, 75f, 0f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.05f, 0f, 0f, 0.1f },
                    { new Guid("e937cd5b-b7a5-4008-81c9-21948b7fb299"), 80f, 360f, 45f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 4f, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), 2.5f, 400f, 15f, 4f, 850f, 6f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.2f, 4f, 0f, 0.5f },
                    { new Guid("ebbdea7d-8dc9-4db8-a9b9-bd95f56d8312"), 80f, 55f, 2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 0.5f, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), 1f, 150f, 5f, 0.5f, 15f, 0.5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.02f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("ecbaf9c9-55c0-4556-aa0b-1d985972964e"), 39f, 20f, 3.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.2f, new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), 0.9f, 391f, 2f, 0f, 36f, 0.3f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 442f, 0.05f, 0.05f, 48.5f, 0f, 0.6f },
                    { new Guid("ee2a1e61-41a0-4775-b7e6-a20ab79a3dfc"), 30f, 300f, 2f, 120f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25f, 0f, new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), 2.5f, 300f, 18f, 8f, 800f, 1f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("f0046e19-31f8-4a58-b616-1cc41d70041d"), 22f, 265f, 49f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.2f, 2.7f, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), 2.4f, 115f, 8f, 0.5f, 491f, 5.6f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.2f, 0.12f, 0f, 0f, 0.1f },
                    { new Guid("f015b257-217b-49cf-9c37-4345ad37afa3"), 40f, 30f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2.5f, new Guid("2ee163f7-4463-44ec-b9e2-8a409c112db4"), 0.8f, 300f, 2f, 0.1f, 150f, 2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500f, 0.04f, 0.05f, 20f, 0f, 0.5f },
                    { new Guid("f0af066f-8071-4bcb-817f-bd9217d9cffe"), 2f, 17f, 0.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0f, new Guid("f41484a3-c7df-4530-b7d2-060390103985"), 0f, 54f, 3.6f, 0f, 55f, 0.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.01f, 0.15f, 0f, 0f, 0f },
                    { new Guid("f229b0aa-ce5f-4282-a058-ba17d7028631"), 264f, 576f, 22f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 12f, new Guid("b0f051be-5972-4e7a-a77d-47ec28d58993"), 3.7f, 705f, 21f, 3.8f, 1f, 3.9f, 46.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0.21f, 1.01f, 0f, 0f, 25.6f },
                    { new Guid("f35b57a2-9360-4a1d-a57e-553d436ca579"), 25f, 81f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 5.7f, new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), 1.5f, 244f, 5.4f, 0.1f, 5f, 5.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 765f, 0.27f, 0.15f, 40f, 0f, 0.1f },
                    { new Guid("f3d33c20-a4a4-47c1-8d85-e294e89bbe92"), 78f, 584f, 20f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 51.5f, 8.6f, new Guid("4e46f955-4413-496f-97b4-968a38ee3e11"), 5.3f, 645f, 20.8f, 4.5f, 9f, 2.6f, 47f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 1.48f, 0.25f, 1.4f, 0f, 35.2f },
                    { new Guid("f5104624-be7f-43d8-b4aa-cf1c8e5e3662"), 35f, 22f, 4.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2f, new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), 0.5f, 250f, 1f, 0.1f, 80f, 1.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 650f, 0.04f, 0.05f, 20f, 0f, 0.4f },
                    { new Guid("f6f00587-af35-4b0e-a9dd-a23aa8a95bcd"), 16f, 32f, 7.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2f, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), 0.4f, 153f, 0.7f, 0f, 1f, 4.9f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 0.02f, 0.05f, 58.8f, 0f, 0.3f },
                    { new Guid("f8260022-4786-4a58-bb98-0cbef383070b"), 16f, 15f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.5f, new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), 0.3f, 147f, 0.7f, 0f, 2f, 1.7f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.03f, 0.03f, 2.8f, 0f, 0.03f },
                    { new Guid("f885a93b-6ca0-4224-bd54-76291d283bd4"), 15f, 130f, 28f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 1f, new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), 0.5f, 120f, 4f, 0.1f, 250f, 1.5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.1f, 0f, 0f, 0.1f },
                    { new Guid("f88d7aa4-7933-49be-9b42-1bac44b2695b"), 30f, 220f, 12f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 1.5f, new Guid("29dfb5da-8818-40ff-bf66-7553521c2161"), 2.5f, 300f, 15f, 4f, 600f, 3f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150f, 0.1f, 0.1f, 4f, 0f, 1f },
                    { new Guid("f8f59ab4-5bc9-4227-aebb-6263f786f9b3"), 130f, 23f, 4.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("982d8f3e-f517-4bd2-87a8-48329fc9eb91"), 0.8f, 260f, 1.6f, 0.1f, 60f, 1.3f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 560f, 0.06f, 0.08f, 35f, 0f, 0.5f },
                    { new Guid("f9148b2b-b1c6-4b7d-88dd-f40bec78ade6"), 20f, 200f, 35f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 1.5f, new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), 0.8f, 80f, 6f, 1f, 350f, 3f, 2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.02f, 0.02f, 1f, 0f, 0.1f },
                    { new Guid("fa973fc9-1bc5-4a7d-a4b1-212aea922dce"), 5f, 66f, 16.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 1.3f, new Guid("7b8500af-d730-4138-9617-cba352faed4a"), 0.3f, 171f, 0.8f, 0f, 1f, 15.2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.01f, 0.07f, 71.5f, 0f, 0.1f },
                    { new Guid("fae51c68-6c79-44f1-b193-f8f998e1d082"), 30f, 200f, 25f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 2f, new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), 1.5f, 250f, 10f, 1.5f, 600f, 3f, 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 200f, 0.1f, 0.1f, 5f, 0f, 0.7f },
                    { new Guid("fb104622-e017-40c6-822b-9171f1d3c9e2"), 8f, 378f, 72.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.2f, 8.5f, new Guid("68c8c4c4-e5d6-4e15-ad60-1c18f0c1cb4d"), 3f, 195f, 11f, 0.7f, 5f, 0.6f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.41f, 0.29f, 0f, 0f, 0.1f },
                    { new Guid("fb2a9dab-48db-428f-86f0-a674dcb48c09"), 15f, 90f, 14f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 1f, new Guid("af036922-79f3-45a7-b562-a6279520c0e6"), 0.6f, 200f, 8f, 0.5f, 350f, 2f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.05f, 0.07f, 3f, 0f, 0.2f },
                    { new Guid("fc2dbf3f-f1ee-4545-afcb-7afcdac3396f"), 40f, 15f, 2.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.5f, new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), 0.6f, 120f, 1.2f, 0f, 750f, 0.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.01f, 0.02f, 15f, 0f, 0.02f },
                    { new Guid("fc6640f8-bfdd-45ef-a92e-136b617da0a1"), 37f, 53f, 13.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.8f, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), 0.1f, 166f, 0.8f, 0f, 2f, 10.6f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.34f, 0.06f, 0.03f, 26.7f, 0f, 0.2f },
                    { new Guid("fd8cb189-e811-4fa5-95cd-6aa46fbe5f17"), 15f, 120f, 15f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 0.5f, new Guid("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), 1f, 200f, 8f, 1f, 400f, 1f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30f, 0.05f, 0.1f, 2f, 0f, 0.3f },
                    { new Guid("ffb987c3-be78-4418-bad2-9e809fa6c743"), 25f, 52f, 11.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.6f, 6.5f, new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), 0.7f, 151f, 1.2f, 0f, 1f, 4.4f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33f, 0.03f, 0.04f, 26.2f, 0f, 0.9f },
                    { new Guid("ffe39f83-2d8d-460a-bdb6-c51a441dedbc"), 80f, 380f, 50f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), 2f, 350f, 18f, 4f, 900f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.1f, 3f, 0f, 0.3f }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "WorkoutExerciseId", "CreatedAt", "DurationSeconds", "ExerciseId", "IsCompleted", "Order", "Reps", "UpdatedAt", "WorkoutId" },
                values: new object[,]
                {
                    { new Guid("004006c6-f766-42f2-85f0-fed452d3934c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("00716146-196d-425e-89ba-066a1ea25a0e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 6, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("011b6dd3-9405-44cc-88a3-eeef04681dda"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("13ca014d-8b75-414f-afe3-3d378ef7fa97"), null, 4, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("01d96b9a-b1e5-4f6a-8d81-2d0d157feac5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), null, 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("02c4093e-ac06-4f30-8fdd-2086319ed891"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("439db970-c7c8-4b3b-9a35-127d31d920dc"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("04155e58-3d32-41ec-b655-66cc94688b69"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"), null, 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("096c820c-f50e-4e08-8815-b0afe1b7f7b0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("09d9f15c-3f6a-47fd-8096-db22a8eded67"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), null, 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("0cae1d0d-0b6c-4409-b690-d6fb50762164"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), null, 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("0de44b2e-6f66-4e65-ad43-afaccf0cd306"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), null, 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("0e0ab094-4222-447f-bde9-003d6e88c8c1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), null, 1, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("1051a32b-9185-467c-b406-a061672145b6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), null, 1, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("1252be36-2a7f-44c2-a0a4-1f45b1282fd0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), null, 5, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("14797859-e30b-46cd-a1ca-11b7cf3fe387"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), null, 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("1717cbdd-fdf1-48c5-a4df-7bac59a790a6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("19f2a1b8-b11b-4916-8f13-df95d7f7f8ea"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("1b7706b4-950d-4fd5-90cb-07a2cdd6b30d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), null, 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("1e67285f-c064-420f-ab5c-e007b96231b1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d4ebca3a-83ef-485b-9178-83d4eab9694c"), null, 4, 16, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("1e7f3a8f-6446-44e8-85c0-f875532c4f63"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), null, 1, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("1ee859a9-2b07-4098-9d7c-1427f23ef8de"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), null, 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("20058bab-b764-4533-89e6-6a54b37828ec"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), null, 5, 6, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("20f6de98-0ee2-4b80-9717-55655d432ec6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("2319f4dc-903b-4c50-aa6e-3841aa4bb6de"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("2386727f-e2cb-4e19-b4fc-27a7adab6494"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("d0dcad19-4c0c-447d-8e3c-092c6d4ad14c"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("23da7ebb-a277-4ca5-8e24-83dc672d8682"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("385f13f7-79bf-437b-acac-745b50485b9f"), null, 2, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("296e9005-7917-4ba6-8340-f5cf9c982b89"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("2a31c2ab-fc3f-41b2-9647-c69ba7f5db20"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), null, 3, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("2d95c4ca-d510-4ff0-bfdf-9762d01e02ec"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("f93d73ba-d1d6-4037-b51b-1fd005accff3"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("2dce08ea-c916-461a-9017-e53dcef9acd5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"), null, 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("2ed5183c-342d-44ac-a067-bea646985fa5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("05c931df-c828-442e-aee1-56432cb772c7"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("2f1dbf02-b941-46cf-902f-0e028a9bdd91"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d6b2c0d5-110f-4dff-9aa7-91da10a29dca"), null, 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("30c688b3-19b1-4bb7-bb85-49bbb1f94b58"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("0d1e54fe-7a5f-4e0a-a59f-ee9f443718e0"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("30ebe217-3a51-43ae-9b76-ae079843dc5d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("31137920-a696-4e11-852a-cf49c95f3b18"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("93e22c77-001f-4825-8983-4ec5b643b7bb"), null, 5, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("31f5520a-dde6-4d14-b7d2-6ae4fe4aabb0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), null, 4, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("33ebfdab-b0cc-4b5c-ab0b-cfaa4014863f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), null, 1, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("33ffcb67-7536-453b-b0b7-fd4a65748ca1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ff0ef05-4387-4483-8de3-0ef6d7724afd"), null, 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("358cbe1f-5bcb-4659-89b3-0c11f6a76326"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), null, 9, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("35d2060c-c02d-4a24-b395-813647999f67"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a280d32-de67-4a38-8f21-923243489eef"), null, 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("368c9aa8-75f1-4f4a-be2d-1294b5c83fc0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("37de4a85-b9d4-4da7-88e4-7a290287bebe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("384b08db-b721-4d70-a32e-6f2eba212202"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("3a4d0a14-ccd5-405c-a267-6b157fee8a3f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), null, 7, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("3bcc8ca3-10b3-4a52-a6dc-322a6d57da4a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("3ce2b5bb-ce4d-4b1d-9b2a-72e80689b2cc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ae6eaaa1-c8c4-4f97-afa4-4ceeea19d4b3"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("404f947e-dd2a-487f-9e71-74d3fbcf7f3b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), null, 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("44ba2694-211d-4a35-b644-1ca231bab570"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bd80fdd3-c46c-4410-b126-51a11a8a2f5b"), null, 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("45ec1b11-143f-4c00-844e-71c4ab9aeb48"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("46a5c514-440e-4d4c-a28a-a9a387ef228a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), null, 3, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("473547b2-e3ac-4090-b664-13c900d26240"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ae6eaaa1-c8c4-4f97-afa4-4ceeea19d4b3"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("47cdf366-97e9-4f39-b289-f09969b205b0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a9e1fb3-9abf-4775-a75e-2bb13009a29d"), null, 1, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("4a3568ac-fee2-4c59-981f-133db5bbdc70"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), null, 1, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("4c6896b7-8573-408f-aac7-77571d058dac"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("4e7a0a57-bce1-44d9-8663-78b3d4510eff"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), null, 2, 30, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("4feda8b9-f2ff-40e0-9bb3-c3fe42b3eb19"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), null, 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("519010dc-fe2b-4a69-9a4e-1ca03cfd79a6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), null, 3, 30, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("53a08942-a4c3-4088-870c-678babf1257b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), null, 4, 6, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("5556fb83-0d11-431d-82c7-cf819e1d55d8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("4834f1ce-41dc-4161-ac51-e03ca78b62b8"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("5562acad-b3a6-454a-90f6-199a3ad0abcd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("57047ba0-4f87-43b5-9b57-fff375d6d2d6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), null, 6, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("5acd4318-dc35-4eee-93a1-1551a5753bf9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0c011f92-425a-477c-84d4-3d6dc883119b"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("5aee8c3e-ed88-41ea-8115-91dfe01fc75d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("5b7a49c6-5d36-4ccf-b3ed-697c51ca1d6f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), null, 8, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("5b96dae7-49ae-459e-8361-aee5fb195207"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01dc4c46-e1ef-44bc-9f19-ecb283bf27ce"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("6206e924-9308-49db-a8a4-210a8aac9080"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("6393d42a-2135-4966-8ab7-213834a6b19f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01e6141a-930e-4126-a2c6-7c32a2ccdd43"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("6401b6df-4076-4f8f-b51e-dbe818175a1c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"), null, 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("64145977-8925-46e6-8710-cc28a7545e8e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("6474ee98-4e12-4c65-8d6b-9ea9f8a88e98"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), null, 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("655babb6-0683-4f67-b814-6a5546ae71cc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), null, 3, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("6607e264-1980-4a63-84b6-f3f4e9f4b6a1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("23842121-4834-4483-bfe2-2c244f5ecf76"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("66741a8c-1d8a-422a-86a3-330d467f4f4b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), null, 2, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("678a7050-be8f-491c-9928-30d341bf491a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("faebde03-bab9-457b-9b45-a9fabd4760aa"), null, 1, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("6bd4518b-1642-4c34-aa64-e55fca5ec3ca"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6ffea500-ca35-4483-b049-d8593b2c8680"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("6be91003-8815-4efa-b019-80eb36fca146"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("6ca56fdb-85e3-4d35-a75d-eda8a47b6b49"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("1b2afb40-fb97-49ec-8fe3-81a17c6c9078"), null, 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("72bd3511-a166-4a6c-a67c-4f466e88f5f1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), null, 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("7512ac31-b4bb-4b11-92a4-629387fb10d7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), null, 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("75796674-738f-412c-b74b-d5e335d79543"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("75b6cbef-369c-41a5-ae4b-d4ec43542830"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), null, 5, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("76447649-be24-45a7-9ab5-fcd94ce62e23"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), null, 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("76bdabe6-4459-4519-ab15-aa6dba81d003"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8619916d-a296-48a5-af89-f82a6a1cb26f"), null, 3, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("776ca3db-8ef5-44c2-8e36-598fdafea745"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("23842121-4834-4483-bfe2-2c244f5ecf76"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("7edfc180-b252-4efb-b2b2-387e5e51a4b8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), null, 3, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("809da299-531b-4857-9a6d-e39b22d2332b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), null, 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("80cce6e4-f393-4067-99e9-e75a3743f2ff"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), null, 1, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("816a16a4-53f7-4f45-8063-d90397638d96"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("2696db05-e815-4c8b-870d-23c338479e95"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("83b727d6-2feb-4cf6-97da-56eed5ef01a9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), null, 4, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("845b7df7-17b5-466d-8a89-8f6efa4529c2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("85485cf3-cf4e-44a6-a490-67e6321157f4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01e6141a-930e-4126-a2c6-7c32a2ccdd43"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("86890f9c-29df-4d14-9425-e2af274effe7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("88dfda30-01c1-4593-af08-1ac82dbb7b15"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("8914dc99-cb20-43f7-a1cd-7e5abce79390"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("8de6ce1b-ed7c-4c56-ac45-c5411d984ffb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), null, 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("8e1c727e-a446-4586-95e1-0e903ffaedf2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), null, 6, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("8e5fbbea-b685-44fa-9ef8-b63f69448a03"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), null, 6, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("904295dd-6c8a-44bc-aaa2-6a71ef68b0d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), null, 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("908fb608-f67c-43ae-8891-8260a45fbde7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3100278d-eee7-4b89-b726-4b76daefabde"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("93991d38-8519-462a-a09f-8de3d5b5e0ce"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6d6b06e1-5ade-4dae-b442-7aa200661760"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("94e9d517-b1d2-4a58-83ad-6626e3463fca"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("9740036f-2ae3-41f4-847f-41b315732c31"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("98b9f5c1-be1a-44ef-a56b-20b4e67fb145"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("9a2bb4db-4d30-4a05-8f65-1bc79b1d6aa0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("d3d944c4-947d-4910-bb6e-636390e5b8d5"), null, 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("9a62d066-d4bc-4d07-9c37-81da74cac61d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), null, 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("9b085150-8661-4078-a7ac-a2da5a7e351d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("235f7494-3e7d-45a5-a31a-6d5449b1322d"), null, 2, 16, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("9bd15bc0-4d70-4423-823c-f6b5812eac70"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), null, 4, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("9e2cbd36-00b8-4dfa-b8ed-b5b35bd88255"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), null, 1, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("9e55afdc-1f90-4f2a-ae36-a92fbdca6c76"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("9f902b32-04f2-4670-a615-01362008fc71"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("a1a10a37-164e-4afc-aa95-0971e92d00e4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), null, 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("a1dd937a-48bd-4e77-a135-517bdd374dda"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), null, 5, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("a29062dd-b76a-4c08-9ebf-46d5c3779031"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("9ba29558-e51b-4a1a-a1c4-b747967e32fb"), null, 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("a3488d73-75fa-4961-85a9-af5e4f5b820b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), null, 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("a3ed3f79-31a2-4999-b8f1-b61cbdf9fc53"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), null, 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("a41ad897-0c71-45f0-beb3-73443ae224ae"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("a4e6c50c-fec6-4b73-a8e1-73c74f22fefd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2e787245-7612-41bc-9b75-7a4857282350"), null, 2, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("a619bf85-6529-4f82-8560-6e5e505c131f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("a8a8fca9-cd44-4e90-9e54-64ee775e397a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0d816828-8a94-4dcb-a87c-b70b295a39b6"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("a8c98fca-3aea-4d35-997e-642ff64103cd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b2e62599-1f8c-4fc2-9ca7-8ab7aa571d4e"), null, 2, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("a90a8913-f790-4e3b-be83-ed32b580f37c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("72206c5e-58f3-46f0-a8b1-031cbf599433"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("ab0ef808-7334-4a65-b03f-0877bf39cd3b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"), null, 4, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("aff55579-05b7-4b80-b617-5ed4e9a00a81"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("b2351b16-7e25-40ef-aa13-cafd0f99d2a6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), null, 5, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("b2ca88fd-876b-4ad9-8543-68b7900685f0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("b6e4b764-e09a-48da-aa02-db3b976b191d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6749cbc6-0e28-4163-95e8-7fb2a27c54cf"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("b7265d49-c2f1-42f3-81e1-357c8450c7d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("58878826-775e-4d4c-8e1b-d5c95afc214d"), null, 6, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("b78c9d68-d471-4a4a-b297-cff0fc35d96a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("5cbc396e-381a-4d9f-9ad6-42b764deee3e"), null, 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("b9ce0105-63ec-47cc-8c00-65fe03060d51"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8b93dbb2-fc2b-4627-b79a-3ec45a7c6238"), null, 2, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("bddff8e2-8317-4614-b7b7-2713730be1dd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), null, 4, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("bf6ebb08-25ef-4bcb-8755-194c288395fa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d4ebca3a-83ef-485b-9178-83d4eab9694c"), null, 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("bfc536e8-f327-4a74-8141-71558c1a629e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"), null, 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("c1c1445e-5e91-412f-ae6b-282d07367bb6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"), null, 1, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("c2490dad-dd76-43f0-87b5-f90dd99532fc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), null, 1, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("c2f96a0d-c1fb-4c38-9eca-9cf363e808bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6badb5b5-ad99-4b89-80c6-e52d0f7cd7ba"), null, 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("c35753c7-f9df-45ea-9110-9d2c77d288b9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), null, 6, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("c3dd7adb-6f97-443c-bb92-164c25dc7362"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), null, 6, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("c3dfc0f9-558f-4058-9aaf-52cf484148c1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), null, 7, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("c4687476-ff2f-40a9-8eec-a47dbe9b5a77"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), null, 2, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("c6cd8df5-2f09-4c65-9160-838f89123db4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"), null, 5, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("c76c44f5-44ad-4aef-aaaf-78a5f308001b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("22af0171-257b-43bc-9013-8985472a8c84"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("c7c2853b-461a-4fb6-a1ca-9c1a07104829"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("72206c5e-58f3-46f0-a8b1-031cbf599433"), null, 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("c954f19f-9aea-4c1f-be14-39acabf0bac0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("c9892b49-8803-4ce0-ac72-aaed145b1395"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), null, 5, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("cb55d7c5-088a-4920-bdf7-bce0a1e581a3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("58878826-775e-4d4c-8e1b-d5c95afc214d"), null, 8, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("cc263413-b0ec-4c1d-9e98-bc2332d3d570"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), null, 6, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("ccc60b44-6419-4ba4-b06b-56eaf57b6a78"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("07a4dbcd-635a-4a76-92d4-8127de619e6d"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("cd059fe1-9d04-4c37-a619-a8783c6df323"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), null, 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("cfaec9bb-e829-4a16-ae38-dd18f7afd25a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), null, 3, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("cfc2f98b-91ed-4212-84e6-debe172f7104"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), null, 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("d0965be4-a4b6-4a37-8f64-ea0c491e7bc0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), null, 7, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("d2765e29-4225-40b8-8ddb-dfe1106ea096"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), null, 3, 32, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("d5044a35-e430-47fd-9033-0692e4e29f43"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), null, 8, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("d7026161-1010-4a98-8e5e-da3e53eae1e5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("d827571f-7237-4cc0-9bbe-0e3d3f2dc95c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), null, 3, 30, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("da96c24a-f67e-4432-8bb2-0685f57ff404"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), null, 7, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("db45f68d-06c9-4c3e-9acc-1c33f4c7ec51"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("deeb2ae8-f558-4d01-9ea8-6655ae264c9f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), null, 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("dfff5e82-7d0d-4c41-8ad3-aa50a1b62fda"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), null, 8, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("e13a4a8b-5132-4a58-9489-03df9f0c865d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("9ba29558-e51b-4a1a-a1c4-b747967e32fb"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("e206be04-3ca6-426f-95f6-78d36cd3d128"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("256e23fa-03b1-4328-a325-512f0860d9b0"), null, 6, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("e62f8e82-167a-40a7-b2a1-62568be2ae74"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), null, 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("e6bbe9b9-1707-4698-ba60-23bddf410e8a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), null, 2, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("e912a791-063f-483b-a50d-603b864f4ccb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), null, 5, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("e9be28e7-b3b4-423a-b985-045799c6c7be"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), null, 5, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("e9c524c4-0776-45b2-b26c-d25bdbd4b262"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"), null, 7, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("eb5334d7-bae2-4ea2-8399-1eb35fd1884d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), null, 8, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("ebfabc0e-cae6-4b8f-8cb5-3aaf1714d123"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), null, 1, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("ed1e0c6e-df20-48c5-9c04-f7807eccca32"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), null, 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("eda64ef0-22ca-4ce1-8c36-25ed0366f160"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), null, 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("ede7b89b-87b7-4ce1-ab44-d5a503d24236"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6ef8ed78-0d00-4271-bf9b-edf27a55ecab"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("ee49b05c-1fb8-439d-9c6e-64d89d5aa202"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), null, 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("ef7bfeef-53d3-4dfa-9b77-044471bfd509"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), null, 4, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("f139f4ae-2f51-4d8e-acdc-9b6da1dd18a0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a280d32-de67-4a38-8f21-923243489eef"), null, 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("f202e897-11a3-443e-bbce-a8e914b22659"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("93e22c77-001f-4825-8983-4ec5b643b7bb"), null, 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("f31e002b-5fc0-4c8c-8530-3763332554e6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), null, 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("f331f571-6a10-4e09-81d6-79a79dada30a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), null, 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("f7eea3e7-97dd-4aa3-b2c2-00d3640b045a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), null, 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("fa8bbc4d-e743-4645-bfbf-0b8e2f358a0b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("407ff857-d218-44a8-8d0f-0bfa5d53bf03"), null, 7, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("fb66fb30-264b-419b-a9ad-2584294bac02"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), null, 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("fd1500c1-43d0-42f5-b0fe-e68dca19aee9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), null, 1, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("ffe42beb-f67a-4d4e-b2d6-61b978f0d8aa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), null, 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") }
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
                name: "IX_Certificates_ConsultantId",
                table: "Certificates",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_ExpertiseId",
                table: "Certificates",
                column: "ExpertiseId",
                unique: true,
                filter: "[ExpertiseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Consultants_ExpertiseId",
                table: "Consultants",
                column: "ExpertiseId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultants_UserId",
                table: "Consultants",
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
                name: "IX_Payments_SubscriptionId",
                table: "Payments",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookingId",
                table: "Reviews",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ConsultantId",
                table: "Reviews",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_AppUserId",
                table: "Schedules",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ConsultantId",
                table: "Schedules",
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
                name: "Certificates");

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
                name: "DailyActivities");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

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
                name: "Consultants");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "Expertises");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
