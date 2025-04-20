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
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReferenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
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
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false),
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
                name: "Devices",
                columns: table => new
                {
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpoPushToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Os = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OsVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.DeviceId);
                    table.ForeignKey(
                        name: "FK_Devices_AspNetUsers_UserId",
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
                    ReferenceUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CaloriesRatio = table.Column<float>(type: "real", nullable: false),
                    WeightGoal = table.Column<float>(type: "real", nullable: false),
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
                    DurationMinutes = table.Column<float>(type: "real", nullable: false),
                    CaloriesBurned = table.Column<float>(type: "real", nullable: false),
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
                    Experience = table.Column<int>(type: "int", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false),
                    BookingCount = table.Column<int>(type: "int", nullable: false),
                    RatingCount = table.Column<double>(type: "float", nullable: false),
                    AverageRating = table.Column<double>(type: "float", nullable: false),
                    VerificationStatus = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
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
                        name: "FK_Consultants_Expertise_ExpertiseId",
                        column: x => x.ExpertiseId,
                        principalTable: "Expertise",
                        principalColumn: "ExpertiseId");
                });

            migrationBuilder.CreateTable(
                name: "UserNotifications",
                columns: table => new
                {
                    UserNotificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NotificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNotifications", x => x.UserNotificationId);
                    table.ForeignKey(
                        name: "FK_UserNotifications_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNotifications_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "NotificationId",
                        onDelete: ReferentialAction.Cascade);
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    DailyMealDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    Day = table.Column<DateOnly>(type: "date", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    MeetingUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvidenceUrls = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        principalColumn: "ConsultantId");
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
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IssuedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                        principalColumn: "ConsultantId",
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
                        principalColumn: "ConsultantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleExceptions",
                columns: table => new
                {
                    ScheduleExceptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleExceptions", x => x.ScheduleExceptionId);
                    table.ForeignKey(
                        name: "FK_ScheduleExceptions_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "ConsultantId",
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ScheduleId);
                    table.ForeignKey(
                        name: "FK_Schedules_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "ConsultantId",
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
                        principalColumn: "ConsultantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WithdrawalRequests",
                columns: table => new
                {
                    WithdrawalRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultantBankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WithdrawalRequests", x => x.WithdrawalRequestId);
                    table.ForeignKey(
                        name: "FK_WithdrawalRequests_Consultants_ConsultantId",
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
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
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
                    MealDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "Reports",
                columns: table => new
                {
                    ReportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportId);
                    table.ForeignKey(
                        name: "FK_Reports_Bookings_BookingId",
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
                        principalColumn: "TimeSlotId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WalletId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WithdrawalRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserSubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    OrderCode = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<float>(type: "real", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_Transactions_UserSubscriptions_UserSubscriptionId",
                        column: x => x.UserSubscriptionId,
                        principalTable: "UserSubscriptions",
                        principalColumn: "UserSubscriptionId");
                    table.ForeignKey(
                        name: "FK_Transactions_Wallets_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallets",
                        principalColumn: "WalletId");
                    table.ForeignKey(
                        name: "FK_Transactions_WithdrawalRequests_WithdrawalRequestId",
                        column: x => x.WithdrawalRequestId,
                        principalTable: "WithdrawalRequests",
                        principalColumn: "WithdrawalRequestId");
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
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), null, "Thành viên trả phí", "Subscription Member", "SUBSCRIPTION MEMBER" },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), null, "Thành viên", "Member", "MEMBER" },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), null, "Chuyên viên", "Consultant", "CONSULTANT" },
                    { new Guid("d21edfd6-42d5-490a-a41c-43f7ef09c61f"), null, "Quản trị viên", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F9c0e576b-c736-4c13-8f21-aa0b1649fe5c.jpg?alt=media&token=236a11b7-836c-4735-b4c8-109a58b41e45", "b160719f-d5d1-45cc-a5b0-ed14f141d7d2", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "khanhpham@gmail.com", true, "Nguyễn Phạm Khanh", false, null, "KHANHPHAM@GMAIL.COM", "KUEM113", "AQAAAAIAAYagAAAAEO3wJQzp5zXK6EE3lGyZowFZQjdH3lQCD5ti20PZHJiyVp69BCinTGzA1TRx2ubkNg==", "0368309526", false, null, null, "8280f71d-0528-480c-b6cd-7dff77a152c1", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "kuem113" },
                    { new Guid("06114384-3057-49ea-b106-e03c0e0e8f20"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2Fz6092344870918_1ddc20ef2ae3cb256497bcfae9abc600.jpg?alt=media&token=fb76c360-aaea-428e-b0b2-73bd22714098", "450a2ee7-3d3f-4ce9-9cf3-6fdae4997b62", new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "vanhuutoan27@gmail.com", true, "Văn Hữu Toàn", false, null, "VANHUUTOAN27@GMAIL.COM", "TOANDEVTRAI", "AQAAAAIAAYagAAAAEKnMRx7NJOrd84F2S0CpBEzy17O0EqqujhKKPqW/ilIExgwtrb67JcH+X1h2Zkjtzg==", "0329055024", false, null, null, "985c6b9e-ec2f-418e-9f78-58fb4457e4b1", true, false, new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "toandevtrai" },
                    { new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F467b63b9-c4c2-42c2-ba5a-71f294681586.jpg?alt=media&token=89eb5119-1669-4515-9dc6-9130672d3d50", "67b420a0-b9b3-44a3-ae30-d50f0a58cd47", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "duythunglungtinhiu@gmail.com", true, "Phạm Hoài Duy", false, null, "DUYTHUNGLUNGTINHIU", "DUYPRO113", "AQAAAAIAAYagAAAAEL8fXjnmwxaDeORci8VBjcfA6CPSlNJ0x5qrJGJw2Nl43iFkV1nQ+6j/8H2nPfFR9w==", "0967588443", false, null, null, "3befb30b-5fbd-43ba-a4b0-5c6f0ea28398", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "duypro113" },
                    { new Guid("20041d5b-01e4-443f-9652-e39beb9748e5"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F92077987-c716-4efc-b039-12268e8cb97d.jpg?alt=media&token=903adb9c-41c4-4482-a439-3c758b3c050d", "a072ffae-0b8c-486a-802e-d35a8d14ff9f", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "consultant@gmail.com", true, "Van Huu Toan Con", false, null, "CONSULTANT@GMAIL.COM", "0987654321", "AQAAAAIAAYagAAAAEFKocUdBP7TRA1tYavPpbaCVG9U5sDo9osjnIstA9GHCQT1FYG1XQazCwrkGnCs0dw==", "0987654321", false, null, null, "77cbec55-c8b3-4c07-92be-96ee8c0ec749", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "toanconsultant" },
                    { new Guid("258e6035-f606-492e-9d24-c6e27ec1ecfe"), 0, "", "aded5b37-7953-4c91-9547-2c7fef738c6f", new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "nqduy@gmail.com", true, "Nguyễn Quốc Duy", false, null, "NQDUY@GMAIL.COM", "DUYNGUYENQUOC", "AQAAAAIAAYagAAAAEMfzkbO5IreG2TVNQfd7LYT4YzP7Dm8kywBn3lTtbmofDASd+VdEQ/SQ2OWFLnnQOQ==", "0983607574", false, null, null, "780184f1-e502-4bdf-b576-397a857509d2", true, false, new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "duynguyenquoc" },
                    { new Guid("2606b7e4-3fec-43c2-8988-8db7dfb0d56e"), 0, "", "714c4aec-6755-4024-ba27-14f26f659880", new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "anhthedinh@gmail.com", true, "Đinh Thế Anh", false, null, "ANHTHEDINH@GMAIL.COM", "THEANHDEPZAI", "AQAAAAIAAYagAAAAEApBfQS0JhXEEEJaLqbs+epYKbBuEfv2OqDvbRT9u25NDojC3CQoQPvOQNKsUkBUew==", "0906643433", false, null, null, "5f7e2070-2bf7-4110-b27e-8c6ea195a2dd", true, false, new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "theanhdepzai" },
                    { new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2Fef00731b-724a-4e80-8930-36b2abffbec6.jpg?alt=media&token=408e26ce-b249-4139-a919-5cac9082c35c", "f440ad61-162a-4ebc-ba28-84fcac589c50", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quocdai@gmail.com", true, "Nguyễn Quốc Đại", false, null, "QUOCDAI@GMAIL.COM", "DAINQ115", "AQAAAAIAAYagAAAAEOHWaBdmMEk8lFGpcyBYQuEKe6IK7hU2OMuAaKMtXDDfa1gg7wOmV/S8k3OCrl6Rjg==", "0932748924", false, null, null, "f5be90ca-e281-4850-8a03-68a079d7e99c", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "dainq115" },
                    { new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Ftests%2Fangrycat.jpg?alt=media&token=542becf5-173f-47c2-951b-b9f79578fa60", "578f06e9-ae77-462e-b141-86ec07f67c13", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "asd@gmail.com", true, "asd", false, null, "ASD@GMAIL.COM", "ASD", "AQAAAAIAAYagAAAAEPWwchl6b2EGV+UeNr1p1kB2eg0gh4fZtENLe3DX5thmKIoa3bPaLXWbjjoc/bRcSA==", "0123456789", false, null, null, "13db4246-cac6-42ad-8ca5-a86095b4410d", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "asd" },
                    { new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2Fcb927cfb-c88a-48c6-abf7-e77c9ca1982d.jpg?alt=media&token=e6cbb66c-6ecb-45ef-ac25-29511f9e7adb", "7caa0ed6-cf3f-42db-8ce8-bd0c9294d936", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "khaitoi@gmail.com", true, "Phan Văn Khải", false, null, "KHAITOI@GMAIL.COM", "XAUTRAI123", "AQAAAAIAAYagAAAAEEtVl2XHobBTbEuw8DsVocH3OpO4mO4P6UkhXCcx89qG3bx9rDf4aPDXnaD+s6jKuA==", "0963122758", false, null, null, "933334d2-d854-46f2-a7ea-9d49014000e5", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "xautrai123" },
                    { new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F16296811-d53d-4415-a907-e899e206b492.jpg?alt=media&token=819eaa35-ae0f-4dc3-815d-4dc19ab22782", "4b5d2d3c-33db-409e-a7d6-3bb76170cd85", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quangdalat@gmail.com", true, "Trần Nhật Quang", false, null, "QUANGDALAT@GMAIL.COM", "QUANGSPA009", "AQAAAAIAAYagAAAAEF3xQ2FmMdRE5O0StyrD4ix1XdIZOpFU16K5ZAURP35vuvx0G/VdI3Uf0XUeSnUoiQ==", "0999777712", false, null, null, "e632b7fd-ebe6-419b-b2ba-f2cc1634e80a", true, false, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quangspa09" },
                    { new Guid("619de5dc-80d1-40c7-bae5-bd8940d6e780"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F476503216_635093698997337_8270148483946389400_n.jpg?alt=media&token=3a6b111c-bda3-4f70-9273-1144c7b4910c", "53581165-39c6-4f2c-9bcb-44f74604ed95", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "nguyenphat@gmail.com", true, "Nguyễn Tiến Phát", false, null, "NGUYENPHAT@GMAIL.COM", "PHATBE114", "AQAAAAIAAYagAAAAEC75BX5nUfBG2IaF8tDoeS4btmhFclAWV23tdqb2OYPhl/iH/Dbap7fWgpc4ASu5fw==", "0961434567", false, null, null, "16568047-cca4-4e39-b46e-25fb89d8c633", true, false, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "phatbe114" },
                    { new Guid("6535e9eb-fd28-448a-bb0f-31b2dbe2a013"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F470571730_1366066811024707_881271775933456916_n.jpg?alt=media&token=cddd2828-8693-44d8-98fa-98d8b9119656", "5e0d5579-4d97-40fd-84a8-28554105a05d", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "phamducthinh@gmail.com", true, "Phạm Đức Thịnh", false, null, "PHAMDUCTHINH@GMAIL.COM", "THINHFA123", "AQAAAAIAAYagAAAAEDuOzqUK1eu8BXpKLU3Wmka54h3PxM3rOJNb3d9ixfb4NzqqWzWNWMswfpZngPbwEg==", "0961234567", false, null, null, "af73f052-aa53-43ff-bdff-7859ba06c18b", true, false, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "thinhfa123" },
                    { new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F92077987-c716-4efc-b039-12268e8cb97d.jpg?alt=media&token=903adb9c-41c4-4482-a439-3c758b3c050d", "ba4ca81d-f7c5-4216-869a-cc5e6083708f", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "toanvan@gmail.com", true, "Văn Hữu Toàn", false, null, "TOANVAN@GMAIL.COM", "VIPRO123", "AQAAAAIAAYagAAAAEIOd+7D343prow9M3voiKz6nFQp5z+Hj/sWOtyC+ujcudRKEsyalCzxBrRy628XRyQ==", "0792766979", false, null, null, "c962ec5e-7cff-46cd-aa3a-9197b0c73cad", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "vipro123" },
                    { new Guid("b2ad99a0-43fd-4b12-8864-3a2e2626fb90"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F116903299_1425092281017219_6440424626013075423_n.jpg?alt=media&token=119a783e-4a9d-4d1c-a427-115df697f1ca", "c539d53a-2597-4640-9cfe-9386cf681b13", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "nguyenvandung@gmail.com", true, "Nguyễn Văn Dũng", false, null, "NGUYENVANDUNG@GMAIL.COM", "DUNGFE113", "AQAAAAIAAYagAAAAEH7CqQa1GC/adf0vezuwZaw2w3fPfqHhFILGvWHq6CMwXQTW3ErVlDEnh552OiwuGw==", "0961233264", false, null, null, "6b4b9aee-0529-4af3-9991-77e6cd67b923", true, false, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "dungfe113" },
                    { new Guid("b49c65e4-1864-4f8d-82ad-87838284e33f"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F469647230_2079099535874281_3037480323183292732_n.jpg?alt=media&token=fb87f351-8ba2-4987-8ce1-d23704a3625f", "5fd33c45-b5fa-4910-b114-cd2acb97d3b5", new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quangfuhola@gmail.com", true, "Trần Xuân Quang", false, null, "QUANGFUHOLA@GMAIL.COM", "QAQFUHOLA", "AQAAAAIAAYagAAAAEFsCGiliu02+BBgO2U4m/vdFgAmd/SCjy/jsVvAkLUlS3En7cQRKwDiKXGJQRVxwSg==", "0951237521", false, null, null, "07701852-e2c3-4624-8111-4e4adea1d0a5", true, false, new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "qaqfuhola" }
                });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "BankId", "BankCode", "BankName", "CreatedAt", "CreatedBy", "LogoUrl", "ShortName", "Status", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("013ece97-6fbd-482b-91bb-16250e7dbf90"), "PVCB", "Ngân hàng TMCP Đại Chúng Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/PVCB.svg", "PVcomBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("0267e3a6-40a3-4f69-9da4-4b5d753b0eef"), "DAB", "Ngân hàng TNHH MTV Số Vikki", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/DOB.svg", "VikkiBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("079a52f6-5a51-4673-bd1a-5e5264df9865"), "SGCB", "Ngân hàng TMCP Sài Gòn", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SCB.svg", "SCB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("0ac6b7fa-23db-4ba1-8459-111bb3ccbece"), "VTLMONEY", "Viettel Money", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VTLMONEY.svg", "ViettelMoney", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("0cf279c6-6735-45ca-b600-03dc84f340f0"), "ACB", "Ngân hàng TMCP Á Châu", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/ACB.svg", "ACB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("10803623-a665-48fc-b9d5-87b2117c283e"), "IVB", "Ngân hàng TNHH Indovina", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/IVB.svg", "Indovina Bank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("1b4e6597-7d56-4b6d-833d-c17f5755aad1"), "TPB", "Ngân hàng TMCP Tiên Phong", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/TPB.svg", "TPBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("20b685d5-00f5-497b-a444-472f42d6ca6f"), "KLB", "Ngân hàng TMCP Kiên Long", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/KLB.svg", "KienLongBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("2362f0eb-05c3-48f4-8c73-b2fb5ddf3c2a"), "HSBC", "Ngân hàng TNHH MTV HSBC (Việt Nam)", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/HSBC.svg", "HSBC", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("25511b3a-b051-4cf4-93ae-f879f59b83e6"), "OJB", "Ngân hàng Thương mại TNHH MTV Đại Dương", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/Oceanbank.svg", "OceanBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("26485923-c386-478f-b001-4fba530b4c8c"), "NHB", "Ngân hàng Nonghyup - Chi nhánh Hà Nội", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/NHB HN.svg", "Nonghyup", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("276653df-dec6-4556-81ca-0f407b39aa1b"), "VB", "Ngân hàng TMCP Việt Nam Thương Tín", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VIETBANK.svg", "VietBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("2d9604ea-f01b-4cc7-871f-97a8d9f6d8d4"), "SEAB", "Ngân hàng TMCP Đông Nam Á", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SEAB.svg", "SeABank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("41fdc350-9fa7-41b8-95a0-13daa785da12"), "KB", "Ngân hàng Đại chúng TNHH Kasikornbank", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/KBank.svg", "Kasikornbank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("45a33d94-dea0-4801-b4ca-b9c16f4299f7"), "BVB", "Ngân hàng TMCP Bảo Việt", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/BVB.svg", "BaoVietBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("46e3bfac-39b6-485d-a4bd-5321a15c4889"), "VCB", "Ngân hàng TMCP Ngoại thương Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VCB.svg", "Vietcombank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("4bf3cc07-5c79-4eeb-989b-2a3d22bc91f6"), "TCB", "Ngân hàng TMCP Kỹ thương Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/TCB.svg", "Techcombank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("4e5dfdfb-8bb4-4a36-8a7f-511439f7447f"), "TIMO", "Ngân hàng số Timo", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/TIMO.svg", "Timo", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("507d5d5f-3685-42c5-895e-394226f4604d"), "PGB", "Ngân hàng TMCP Xăng dầu Petrolimex", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/PGB.svg", "PGBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("52c28542-9f7c-483c-bf52-2ade8c6c5870"), "VPB", "Ngân hàng TMCP Việt Nam Thịnh Vượng", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VPB.svg", "VPBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("5493e975-b270-4a49-aa4b-b236f9f04370"), "UB", "TMCP Việt Nam Thịnh Vượng - Ngân hàng số Ubank by VPBank", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/Ubank.svg", "Ubank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("5758309a-d6e0-4d99-b154-32147cb5b40d"), "VARB", "Ngân hàng Nông nghiệp và Phát triển Nông thôn Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VBA.svg", "Agribank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("5bbe3238-bfb5-40de-9080-c8a9f63f986c"), "GPB", "Ngân hàng Thương mại TNHH MTV Dầu Khí Toàn Cầu", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/GPB.svg", "GPBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("607798d3-0549-4818-b79c-3eed35a3ca7d"), "STB", "Ngân hàng TMCP Sài Gòn Thương Tín", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/STB.svg", "Sacombank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("6118b95e-f023-4583-96f2-91ded18a1bc0"), "KBKHCM", "Ngân hàng Kookmin - Chi nhánh Thành phố Hồ Chí Minh", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/KBHCM.svg", "KookminHCM", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("614f37e6-4389-4c84-aba4-8fe619024cf2"), "EIB", "Ngân hàng TMCP Xuất nhập khẩu Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/EIB.svg", "Eximbank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("766d6cca-3f96-4bf7-98b2-f5ab91ec6ff8"), "KBKHN", "Ngân hàng Kookmin - Chi nhánh Hà Nội", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/KBHN.svg", "KookminHN", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("7b78cf2d-b444-42a6-b00b-d02f3288fb2f"), "CIMB", "Ngân hàng TNHH MTV CIMB Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/CIMB.svg", "CIMB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("80bd7cb6-d2d4-4721-8c74-7dc589ce8d73"), "MB", "Ngân hàng TMCP Quân đội", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/MB.svg", "MBBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("80e98f32-162c-4167-8667-dfa5658ac39a"), "LPB", "Ngân hàng TMCP Lộc Phát Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/LPB.svg", "LPBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("8c28e891-7ff0-4c40-9184-c6f17ef684a0"), "VTB", "Ngân hàng TMCP Công thương Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/ICB.svg", "VietinBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("8cd14fc6-9d2c-4499-8c9e-65f632082df3"), "IBKHN", "Ngân hàng Công nghiệp Hàn Quốc - Chi nhánh Hà Nội", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/IBK - HN.svg", "IBKHN", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("8d9e3027-9f06-48de-83f8-02a0c277b1e8"), "CBB", "Ngân hàng Thương mại TNHH MTV Xây dựng Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/CBB.svg", "CBBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("912c980e-0959-4a73-b8dd-d0e8730ea8eb"), "MSB", "Ngân hàng TMCP Hàng Hải", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/MSB.svg", "MSB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("936666c3-12f6-406b-9de9-8367233aa6ba"), "BIDV", "Ngân hàng TMCP Đầu tư và Phát triển Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/BIDV.svg", "BIDV", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("978fa2f3-c344-4bd8-a08a-e0fd346e8336"), "SGB", "Ngân hàng TMCP Sài Gòn Công Thương", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SGICB.svg", "SaigonBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("9c0cf5b9-cc9a-4537-938f-17e7bfba5323"), "DBS", "DBS Bank Ltd - Chi nhánh Thành phố Hồ Chí Minh", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/DBS.svg", "DBSBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("a0d4e039-8934-4fd1-87ee-f761369975b0"), "ABB", "Ngân hàng TMCP An Bình", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/ABB.svg", "ABBANK", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("a316fa6b-e159-483a-8d1e-a014d2fdd1a5"), "UOB", "Ngân hàng United Overseas", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/UOB.svg", "United Overseas Bank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("a460c1c6-f7f8-404e-aba9-6a571f897ed4"), "COOPB", "Ngân hàng Hợp tác xã Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/COOPBANK.svg", "Co-op Bank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("a73fb7bf-a81e-48f5-aade-91abe030b174"), "OCB", "Ngân hàng TMCP Phương Đông", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/OCB.svg", "OCB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("ac938b1a-edb0-425c-a8f1-c30f84c33df4"), "VCCB", "Ngân hàng TMCP Bản Việt", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VCCB.svg", "Ngân hàng Bản Việt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("ad1a6ae2-77f5-462f-ab55-63ce04b4e8b9"), "HDB", "Ngân hàng TMCP Phát triển Thành phố Hồ Chí Minh", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/HDB.svg", "HDBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("b4400a52-0dbc-4657-a8a6-0f50c9888cbb"), "VRB", "Ngân hàng Liên doanh Việt - Nga", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VRB.svg", "VRB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("be8d2d35-caa1-4729-b6fc-4d91fa2d6d60"), "WOO", "Ngân hàng TNHH MTV Woori Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/WVN.svg", "Woori", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("c29c8439-b148-4345-b302-a1d574686c39"), "NAB", "Ngân hàng TMCP Nam Á", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/NAB.svg", "NamABank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("c65214a1-c087-4afe-a07d-4a381ec84de9"), "SCBVN", "Ngân hàng TNHH MTV Standard Chartered Bank Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SCVN.svg", "Standard Chartered VN", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("c6ac64c2-7e1f-4578-aebc-f4b8f0a6db3e"), "VAB", "Ngân hàng TMCP Việt Á", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VAB.svg", "VietABank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("d2400cd9-793f-4e6b-8e6c-72959d5bea44"), "PBVN", "Ngân hàng TNHH MTV Public Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/PBVN.svg", "PublicBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("d3ae85d6-9d31-4de8-9611-aa49f3322a3b"), "BAB", "Ngân hàng TMCP Bắc Á", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/BAB.svg", "BacABank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("d3ba0508-0809-4ac3-a04e-b318b1a67e46"), "VIB", "Ngân hàng TMCP Quốc tế Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VIB.svg", "VIB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("dd25ece5-0488-4d25-82f8-1ba7670e55ff"), "SHBVN", "Ngân hàng TNHH MTV Shinhan Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SHBVN.svg", "ShinhanBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("e5ff3492-ad34-4908-a422-b17798107edc"), "CAKE", "TMCP Việt Nam Thịnh Vượng - Ngân hàng số CAKE by VPBank", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/CAKE.svg", "CAKE", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("efe63a53-da1a-4448-bcc7-654f516a93ac"), "VNPTMONEY", "VNPT Money", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VNPTMONEY.svg", "VNPTMoney", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("f4556127-90ce-4cfb-b441-a117830b9894"), "SHB", "Ngân hàng TMCP Sài Gòn - Hà Nội", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SHB.svg", "SHB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("f4b588a9-0c7c-4ba1-a310-583815aa7d1b"), "IBKHCM", "Ngân hàng Công nghiệp Hàn Quốc - Chi nhánh TP. Hồ Chí Minh", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/IBK - HCM.svg", "IBKHCM", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("f51651ca-867e-4de0-8d32-29224021660c"), "NCB", "Ngân hàng TMCP Quốc Dân", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/NCB.svg", "NCB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("f6120297-be1e-43dc-87b5-212c27a2f7ad"), "HLB", "Ngân hàng TNHH MTV Hong Leong Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/HLBVN.svg", "Hong Leong Bank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") }
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
                    { new Guid("5bc13328-01b0-4f09-a32b-5c2f3384c98c"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5700), null, "Snack", new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5701), null },
                    { new Guid("640474cb-2135-4648-b921-fca3a9219533"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5679), null, "MainDish", new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5691), null },
                    { new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5693), null, "SideDish", new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5694), null },
                    { new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5696), null, "Soup", new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5696), null },
                    { new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5703), null, "Drink", new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5703), null },
                    { new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5698), null, "Dessert", new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5699), null }
                });

            migrationBuilder.InsertData(
                table: "Expertise",
                columns: new[] { "ExpertiseId", "CreatedAt", "CreatedBy", "ExpertiseDescription", "ExpertiseName", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("44d9ffb3-a8b8-407b-975c-99e6f6146bc9"), new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hướng dẫn bài tập tăng cơ, giảm mỡ và định hình cơ thể theo mục tiêu mong muốn.", "Thể hình", new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("63100127-6781-4385-a1df-b21cae459bdb"), new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hỗ trợ giải quyết vấn đề căng thẳng, lo âu và cải thiện sức khỏe tinh thần.", "Sức khỏe tâm lý", new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("67188399-9f09-4b74-9eb3-31ff82734850"), new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hướng dẫn các tư thế, kỹ thuật thở và thiền định để cân bằng thân-tâm.", "Yoga", new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6c6a7d90-1c16-44ae-9b2a-b3addfe55dbc"), new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn lối sống lành mạnh, cân bằng giữa làm việc, nghỉ ngơi và vận động.", "Sức khỏe tổng quát", new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("7a61f09f-f999-44fd-8973-105e22df1401"), new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn xây dựng chế độ ăn uống cân đối, đa dạng và phù hợp với thể trạng cá nhân.", "Dinh dưỡng", new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("8ad55299-b566-47e8-a9a0-1997e893e153"), new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư vấn cải thiện chất lượng giấc ngủ và khắc phục các rối loạn giấc ngủ nhẹ.", "Giấc ngủ", new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c32b7429-13df-4aa0-b32d-705d1050de5f"), new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thiết kế thực đơn giảm cân khoa học, an toàn và phù hợp với lối sống.", "Chế độ ăn kiêng", new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c5d7a490-e25e-4ae6-a6db-2d637e6630de"), new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng cao kỹ thuật, hiệu suất và phòng tránh chấn thương trong các môn thể thao.", "Thể thao", new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d762370d-3b36-45f6-ae15-bbe4c2b9bf8a"), new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dạy phương pháp tập trung tư tưởng, thư giãn sâu và phát triển nhận thức.", "Thiền", new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("fdb9b159-8cd5-4a4b-9879-1a140365c207"), new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hướng dẫn các bài tập và phương pháp phục hồi sau chấn thương hoặc phẫu thuật.", "Phục hồi chức năng", new DateTime(2025, 1, 6, 7, 0, 0, 0, DateTimeKind.Local), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") }
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
                    { new Guid("51789abd-bbcc-42ef-9663-f2ea104302bd"), 3, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 30, "[\"T\\u1EA5t c\\u1EA3 t\\u00EDnh n\\u0103ng c\\u1EE7a G\\u00F3i N\\u00E2ng Cao\\nTruy c\\u1EADp danh s\\u00E1ch chuy\\u00EAn vi\\u00EAn t\\u01B0 v\\u1EA5n ch\\u1ECDn l\\u1ECDc\\n\\u0110\\u1EB7t l\\u1ECBch t\\u01B0 v\\u1EA5n 1-1 v\\u1EDBi chuy\\u00EAn gia (3 bu\\u1ED5i/th\\u00E1ng)\\nNh\\u1EAFn tin tr\\u1EF1c ti\\u1EBFp v\\u1EDBi chuy\\u00EAn gia\\nK\\u1EBF ho\\u1EA1ch dinh d\\u01B0\\u1EE1ng v\\u00E0 t\\u1EADp luy\\u1EC7n c\\u00E1 nh\\u00E2n h\\u00F3a\\n\\u0110\\u00E1nh gi\\u00E1 v\\u00E0 ph\\u1EA3n h\\u1ED3i d\\u1ECBch v\\u1EE5 chi ti\\u1EBFt\"]", 899000, true, "Gói dịch vụ cao cấp bao gồm tư vấn cá nhân từ chuyên gia dinh dưỡng và thể hình", "Gói Cao Cấp", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("9dba3bb9-d153-4490-b39e-7c889cf01759"), 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "[\"Theo d\\u00F5i ch\\u1EC9 s\\u1ED1 s\\u1EE9c kh\\u1ECFe c\\u01A1 b\\u1EA3n\\nQu\\u1EA3n l\\u00FD m\\u1EE5c ti\\u00EAu c\\u00E1 nh\\u00E2n\\nTheo d\\u00F5i l\\u01B0\\u1EE3ng n\\u01B0\\u1EDBc u\\u1ED1ng h\\u00E0ng ng\\u00E0y\\nTruy c\\u1EADp danh s\\u00E1ch b\\u00E0i t\\u1EADp gi\\u1EDBi h\\u1EA1n\\nB\\u00E1o c\\u00E1o ti\\u1EBFn \\u0111\\u1ED9 h\\u00E0ng tu\\u1EA7n c\\u01A1 b\\u1EA3n\"]", 0, true, "Gói dịch vụ miễn phí với các tính năng cơ bản để theo dõi sức khỏe và dinh dưỡng", "Gói Cơ Bản", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e62b480d-16a6-4565-87fa-262870d75f68"), 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 30, "[\"T\\u1EA5t c\\u1EA3 t\\u00EDnh n\\u0103ng c\\u1EE7a G\\u00F3i C\\u01A1 B\\u1EA3n\\nG\\u1EE3i \\u00FD b\\u1EEFa \\u0103n h\\u00E0ng ng\\u00E0y theo m\\u1EE5c ti\\u00EAu\\nTruy c\\u1EADp \\u0111\\u1EA7y \\u0111\\u1EE7 th\\u01B0 vi\\u1EC7n b\\u00E0i t\\u1EADp\\nNh\\u1EADn th\\u00F4ng b\\u00E1o nh\\u1EAFc nh\\u1EDF theo l\\u1ECBch tr\\u00ECnh\\nPh\\u00E2n t\\u00EDch ch\\u1EC9 s\\u1ED1 dinh d\\u01B0\\u1EE1ng chi ti\\u1EBFt\"]", 249000, true, "Gói dịch vụ nâng cao với đầy đủ tính năng dinh dưỡng và tập luyện cá nhân hóa", "Gói Nâng Cao", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") }
                });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "CreatedAt", "EndTime", "StartTime", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(16, 0, 0), new TimeOnly(15, 0, 0), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(11, 30, 0), new TimeOnly(10, 30, 0), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(9, 0, 0), new TimeOnly(8, 0, 0), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(14, 45, 0), new TimeOnly(13, 45, 0), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(10, 15, 0), new TimeOnly(9, 15, 0), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(17, 15, 0), new TimeOnly(16, 15, 0), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("06114384-3057-49ea-b106-e03c0e0e8f20") },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2") },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b") },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87") },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e") },
                    { new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), new Guid("20041d5b-01e4-443f-9652-e39beb9748e5") },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), new Guid("258e6035-f606-492e-9d24-c6e27ec1ecfe") },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), new Guid("2606b7e4-3fec-43c2-8988-8db7dfb0d56e") },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d") },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), new Guid("619de5dc-80d1-40c7-bae5-bd8940d6e780") },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), new Guid("6535e9eb-fd28-448a-bb0f-31b2dbe2a013") },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), new Guid("b2ad99a0-43fd-4b12-8864-3a2e2626fb90") },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), new Guid("b49c65e4-1864-4f8d-82ad-87838284e33f") },
                    { new Guid("d21edfd6-42d5-490a-a41c-43f7ef09c61f"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") }
                });

            migrationBuilder.InsertData(
                table: "Consultants",
                columns: new[] { "ConsultantId", "AverageRating", "Bio", "BookingCount", "CreatedAt", "Experience", "ExpertiseId", "RatingCount", "Status", "UpdatedAt", "UserId", "VerificationStatus", "Views" },
                values: new object[,]
                {
                    { new Guid("0a9dad22-7b87-408b-a377-71dbbe004abc"), 0.0, "Chuyên tư vấn về lối sống lành mạnh và cách duy trì sự cân bằng giữa công việc, cuộc sống và tập luyện thể thao.", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("6c6a7d90-1c16-44ae-9b2a-b3addfe55dbc"), 0.0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6535e9eb-fd28-448a-bb0f-31b2dbe2a013"), 1, 21 },
                    { new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), 0.0, "Với kinh nghiệm hơn 2 năm trong lĩnh vực tư vấn tâm lý, tôi chuyên hỗ trợ những người gặp phải các triệu chứng trầm cảm, lo âu và căng thẳng kéo dài. Tôi tin rằng mỗi người đều có khả năng tìm lại sự cân bằng và hạnh phúc trong cuộc sống. Thông qua phương pháp trị liệu cá nhân hóa và sự đồng hành tận tâm, tôi giúp khách hàng từng bước vượt qua khó khăn, cải thiện sức khỏe tinh thần và xây dựng một cuộc sống tích cực hơn", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("8ad55299-b566-47e8-a9a0-1997e893e153"), 0.0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("20041d5b-01e4-443f-9652-e39beb9748e5"), 1, 27 },
                    { new Guid("6bce17d4-909f-4fad-b125-0074793f22bd"), 0.0, "Chuyên gia thể hình Quang, với hơn 5 năm kinh nghiệm huấn luyện thể hình cho hàng trăm khách hàng, giúp họ đạt được mục tiêu tăng cơ và giảm mỡ hiệu quả. Tôi luôn sử dụng các bài tập đa dạng và công cụ phù hợp để mang lại kết quả tối ưu.", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new Guid("44d9ffb3-a8b8-407b-975c-99e6f6146bc9"), 0.0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 1, 14 },
                    { new Guid("77db6560-34ad-44b5-86ab-c74f9033d5f9"), 0.0, "Chuyên tư vấn kỹ thuật thể thao và phòng ngừa chấn thương cho các vận động viên chuyên nghiệp. Bản thân tôi đã giúp nhiều vận động viên nâng cao thành tích thi đấu và duy trì sức khỏe lâu dài.", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("c5d7a490-e25e-4ae6-a6db-2d637e6630de"), 0.0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("619de5dc-80d1-40c7-bae5-bd8940d6e780"), 1, 19 },
                    { new Guid("8d8827cc-904a-4de5-8261-65acdbcb168d"), 0.0, "Với kinh nghiệm tư vấn cho hàng nghìn khách hàng về chế độ ăn kiêng và giảm cân an toàn. Phương Anh luôn thiết kế thực đơn giảm cân phù hợp với nhu cầu và sức khỏe của từng người.", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("c32b7429-13df-4aa0-b32d-705d1050de5f"), 0.0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("258e6035-f606-492e-9d24-c6e27ec1ecfe"), 1, 17 },
                    { new Guid("96818b5d-41a2-436b-841a-4aff36116b95"), 0.0, "Chuyên gia Thiền Thế Anh, với hơn 6 năm kinh nghiệm trong việc giảng dạy thiền và phát triển nhận thức. Tôi giúp khách hàng vượt qua căng thẳng, lo âu và tìm lại sự bình yên trong tâm trí.", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new Guid("d762370d-3b36-45f6-ae15-bbe4c2b9bf8a"), 0.0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2606b7e4-3fec-43c2-8988-8db7dfb0d56e"), 1, 36 },
                    { new Guid("9a40351b-954a-4697-ac3c-c2e35e89702c"), 0.0, "7 năm kinh nghiệm trong việc giảng dạy Yoga cho các nhóm đối tượng khác nhau, từ người mới bắt đầu đến những người muốn nâng cao kỹ thuật. Luôn tập trung vào sự cân bằng thân-tâm và sự thư giãn tối đa trong mỗi buổi tập.", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new Guid("67188399-9f09-4b74-9eb3-31ff82734850"), 0.0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b49c65e4-1864-4f8d-82ad-87838284e33f"), 1, 38 },
                    { new Guid("a0385565-b5f4-4ad3-915e-b95558c00f7d"), 0.0, "Với hơn 8 năm kinh nghiệm, chuyên cung cấp dịch vụ tư vấn cho những người gặp vấn đề về căng thẳng, lo âu và stress. Tôi áp dụng các phương pháp trị liệu hiện đại như CBT (Cognitive Behavioral Therapy) để giúp khách hàng cải thiện sức khỏe tinh thần.", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new Guid("63100127-6781-4385-a1df-b21cae459bdb"), 0.0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2ad99a0-43fd-4b12-8864-3a2e2626fb90"), 1, 54 }
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
                columns: new[] { "FoodId", "CreatedAt", "CreatedBy", "FoodDescription", "FoodName", "IsPublic", "MealType", "ReferenceUrl", "Status", "UpdatedAt", "UpdatedBy", "UserId", "Views" },
                values: new object[,]
                {
                    { new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bí đỏ là loại rau quả giàu vitamin A và C, giúp cải thiện thị lực và sức khỏe da. Bí đỏ có thể chế biến thành các món canh, xào, hoặc làm sinh tố, là món ăn bổ dưỡng cho cả gia đình", "Bí đỏ", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("00bc33fe-4cd5-47df-bd94-15ac9f93648c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp rau củ là món canh thanh đạm với các loại rau củ như cà rốt, khoai tây, đậu que, nấu trong nước dùng nhẹ nhàng. Món này bổ dưỡng, dễ tiêu hóa và thích hợp cho các bữa ăn thanh mát", "Súp rau củ", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("01e60ae4-ff69-44d6-b4fd-aaf916e3a7e5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm gà xối mỡ là món ăn đặc trưng với cơm trắng ăn kèm thịt gà chiên giòn, đậm đà với lớp mỡ giòn rụm. Món này thường được ăn kèm với dưa leo và rau sống", "Cơm gà xối mỡ", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa tươi không đường là nguồn cung cấp canxi và protein giúp xương chắc khỏe. Nó cũng hỗ trợ phát triển cơ bắp, cung cấp vitamin A và D. Sữa tươi là thức uống bổ dưỡng cho bữa sáng hoặc giữa các bữa ăn", "Sữa tươi không đường", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0292d477-d63b-4904-a83b-2cd8cac39c14"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh củ quả là món canh với nhiều loại rau củ như cà rốt, khoai tây, đậu hà lan, nấu trong nước dùng nhẹ nhàng. Món này cung cấp nhiều vitamin và chất xơ, rất tốt cho sức khỏe", "Canh củ quả", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt heo bằm là nguyên liệu dễ chế biến, thường được dùng trong các món như thịt heo bằm xào rau, làm nhân cho các món bánh bao hoặc canh. Món này có hương vị mềm mại và giàu dinh dưỡng", "Thịt heo bằm", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2514745/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì là món ăn nhanh, phổ biến với lớp vỏ giòn và nhân phong phú như thịt nướng, pate, trứng. Đây là lựa chọn lý tưởng cho bữa sáng hoặc bữa ăn nhẹ, dễ dàng mang theo và rất tiện lợi", "Bánh mì", true, "Breakfast,Lunch,Dinner,Snack", "https://fdc.nal.usda.gov/food-details/325871/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau muống là loại rau lá xanh phổ biến ở Việt Nam, có thể xào, luộc hoặc làm canh. Rau muống giàu vitamin, khoáng chất và chất xơ, giúp hỗ trợ tiêu hóa và giải nhiệt", "Rau muống", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/1999632/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún chả cá là món ăn với bún, chả cá chiên hoặc hấp và nước dùng từ cá. Món ăn này có vị ngọt tự nhiên từ cá, rất phổ biến ở miền Trung và Nam Việt Nam", "Bún chả cá", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt gà quay là món ăn có lớp da giòn, thịt mềm, được ướp gia vị rồi quay chín. Món này thường được ăn kèm với cơm hoặc rau sống, rất ngon miệng và dễ ăn", "Thịt gà quay", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2514746/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hoành thánh là món ăn từ bột mì, nhân thịt hoặc tôm, thường được nấu trong nước dùng thơm ngon. Món này có thể ăn trong các bữa sáng hoặc bữa tối, mang lại cảm giác ấm cúng và bổ dưỡng", "Hoành thánh", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau dền đỏ là loại rau xanh giàu vitamin C và chất xơ, giúp hỗ trợ tiêu hóa và tăng cường miễn dịch. Rau dền đỏ có thể xào, nấu canh hoặc làm món gỏi, rất bổ dưỡng", "Rau dền đỏ", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chuối tây là trái cây ngọt, dễ ăn, giàu kali và vitamin. Chuối tây thường được ăn trực tiếp hoặc làm tráng miệng, sinh tố, chè. Đây là món ăn bổ dưỡng và dễ tiêu hóa, thích hợp cho mọi lứa tuổi", "Chuối tây", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Táo là trái cây giàu vitamin C và chất xơ, tốt cho tiêu hóa và hệ tim mạch. Táo có thể ăn trực tiếp hoặc làm sinh tố, salad, giúp tăng cường sức khỏe và cung cấp năng lượng tự nhiên cho cơ thể", "Táo", true, "Snack,Breakfast", "https://fdc.nal.usda.gov/food-details/1750339/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo đậu đỏ là món ăn nhẹ nhàng, làm từ đậu đỏ và gạo, có tác dụng bổ máu, thanh nhiệt. Món này có thể ăn vào buổi sáng hoặc tối, rất bổ dưỡng và dễ tiêu hóa", "Cháo đậu đỏ", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Quýt là trái cây ngọt, chứa nhiều vitamin C và giúp tăng cường hệ miễn dịch. Quýt có thể ăn trực tiếp hoặc làm nước ép, rất tốt cho sức khỏe, đặc biệt là giúp giải nhiệt trong mùa hè", "Quýt", true, "Snack,Breakfast", "https://fdc.nal.usda.gov/food-details/746771/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu hũ là món ăn được làm từ đậu nành, giàu protein thực vật. Đậu hũ có thể chế biến theo nhiều cách như chiên, nấu canh hoặc xào, mang lại hương vị thanh nhẹ và tốt cho sức khỏe", "Đậu hũ", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nho là trái cây ngọt, giàu vitamin C và chất chống oxy hóa, có tác dụng tăng cường sức đề kháng và làm đẹp da. Nho có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng", "Nho", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nấm kim châm là loại nấm có thân dài và mỏng, thường được dùng trong các món canh, xào hoặc salad. Nấm kim châm giàu chất xơ và khoáng chất, rất tốt cho sức khỏe, đặc biệt là hệ tiêu hóa", "Nấm kim châm", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2003600/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2146faae-2e7c-4460-8d81-38f5d313012c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo đậu xanh là món ăn nhẹ, dễ tiêu hóa, được làm từ đậu xanh và gạo, có tác dụng bổ máu và thanh nhiệt. Món này có thể ăn vào bữa sáng hoặc tối, rất bổ dưỡng", "Cháo đậu xanh", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bao chay là món ăn làm từ bột mì, nhân là các loại rau củ, đậu hũ hoặc nấm. Đây là món ăn phù hợp cho những người ăn chay, với hương vị nhẹ nhàng và bổ dưỡng", "Bánh bao chay", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu hũ non là món ăn được làm từ đậu nành, có kết cấu mềm mịn. Đậu hũ non có thể chế biến thành các món xào, canh hoặc ăn kèm với siro, là món ăn dễ tiêu hóa và rất bổ dưỡng", "Đậu hũ non", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Khoai lang luộc là món ăn đơn giản nhưng giàu dinh dưỡng, cung cấp vitamin A, chất xơ và khoáng chất. Khoai lang có thể ăn trực tiếp hoặc dùng làm món ăn kèm trong các bữa chính", "Khoai lang luộc", true, "Breakfast,Snack,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2346403/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2405ffc3-524e-4331-9e68-47a411d7b9b8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm chiên dương châu là món cơm chiên với các loại rau củ, tôm, thịt, trứng, mang đến hương vị đậm đà và đầy đủ dinh dưỡng. Món này thích hợp cho bữa trưa hoặc tối", "Cơm chiên dương châu", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cải thảo là loại rau xanh, thường được dùng trong các món xào, nấu canh hoặc làm gỏi. Cải thảo chứa nhiều vitamin và khoáng chất, giúp hỗ trợ tiêu hóa và cải thiện sức khỏe", "Cải thảo", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2346407/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bao xá xíu là món bánh mềm mịn, với nhân thịt heo xá xíu thơm ngon. Món này rất phổ biến trong các bữa sáng hoặc bữa ăn nhanh gọn, giàu protein và dễ tiêu hóa", "Bánh bao xá xíu", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("29dfb5da-8818-40ff-bf66-7553521c2161"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bò kho là món ăn với thịt bò hầm mềm mịn, nước dùng đậm đà với gia vị thơm ngon. Món này thường ăn kèm với bánh mì hoặc bún, là bữa ăn đầy đủ và ấm áp", "Bò kho", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ae82bfd-34db-4928-bfee-b60f4aec4460"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh bí đỏ là món ăn thanh mát, giàu vitamin A và C. Canh bí đỏ có thể nấu với thịt heo hoặc tôm, mang lại hương vị ngọt tự nhiên, bổ dưỡng và dễ tiêu hóa", "Canh bí đỏ", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau cải xanh là loại rau giàu vitamin A, C và chất xơ, có thể chế biến thành các món xào, luộc hoặc nấu canh. Món rau cải xanh cung cấp nhiều dưỡng chất và giúp thanh nhiệt cho cơ thể", "Rau cải xanh", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì ốp la là món ăn sáng phổ biến với bánh mì giòn, nhân trứng ốp la và có thể kèm thịt, rau. Đây là món ăn nhanh gọn, dễ dàng và bổ dưỡng", "Bánh mì ốp la", true, "Breakfast,Lunch", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dâu tây là trái cây ngọt, chứa nhiều vitamin C và chất chống oxy hóa, giúp làm đẹp da và tăng cường sức đề kháng. Dâu tây có thể ăn trực tiếp, làm sinh tố, hoặc chế biến thành các món tráng miệng", "Dâu tây", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa đậu nành là thức uống từ đậu nành xay nhuyễn, giàu protein và vitamin. Đây là món ăn sáng phổ biến, bổ dưỡng, có thể uống nóng hoặc lạnh, đặc biệt tốt cho người ăn chay và những người muốn bổ sung dưỡng chất từ thực vật", "Sữa đậu nành", true, "Breakfast,Snack", "https://fdc.nal.usda.gov/food-details/2257044/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ee163f7-4463-44ec-b9e2-8a409c112db4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau luộc là món ăn thanh mát, giúp bổ sung vitamin và khoáng chất, rất tốt cho sức khỏe. Các loại rau như rau muống, rau ngót thường được luộc và ăn kèm với nước mắm hoặc gia vị", "Rau luộc", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo lòng là món ăn sáng phổ biến, được làm từ cháo gạo nấu với các loại nội tạng heo như lòng, gan, dồi. Món này có vị đậm đà, thường ăn kèm với hành lá, rau thơm và gia vị", "Cháo lòng", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Khoai lang là một loại củ giàu vitamin và chất xơ, có thể chế biến thành các món như khoai lang luộc, chiên, hoặc làm món xào. Món này cung cấp năng lượng và rất tốt cho sức khỏe", "Khoai lang", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2346404/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cải thìa là loại rau xanh giàu vitamin và khoáng chất, có thể chế biến theo nhiều cách như xào, luộc hoặc nấu canh. Cải thìa giúp giải nhiệt và tốt cho hệ tiêu hóa, thường dùng trong các bữa ăn gia đình", "Cải thìa", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2685572/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp gà nấm là món ăn nhẹ nhàng với nước dùng từ gà và nấm, giúp thanh nhiệt và dễ tiêu hóa. Món này thường ăn vào bữa sáng hoặc khi cần bồi bổ cơ thể", "Súp gà nấm", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Măng khô là món ăn được làm từ măng tươi phơi khô, có thể chế biến thành các món canh hoặc xào. Măng khô có vị ngọt tự nhiên, giòn và là món ăn bổ dưỡng trong các bữa ăn gia đình", "Măng khô", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nước chanh là thức uống giải khát tuyệt vời, giúp cung cấp vitamin C, giải nhiệt và làm đẹp da. Món này có thể uống vào bất kỳ thời gian nào trong ngày, đặc biệt là trong mùa hè", "Nước chanh", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3d19d971-88d0-4108-a335-24ac9e1dec50"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Măng cụt là trái cây ngọt, mọng nước, chứa nhiều vitamin C và khoáng chất. Món này có thể ăn trực tiếp hoặc làm nước ép, mang lại cảm giác giải nhiệt và bổ sung dinh dưỡng", "Măng cụt", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3dc2fa80-ab87-4e26-907b-3516611371b8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh bầu là món canh thanh mát, với bầu nấu cùng nước dùng nhẹ nhàng từ xương hoặc thịt. Món canh này có tác dụng giải nhiệt, rất thích hợp trong những ngày hè nóng bức", "Canh bầu", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu nành luộc là món ăn nhẹ, giàu protein và vitamin. Đậu nành có thể ăn trực tiếp hoặc chế biến thành các món như đậu hũ, giúp bổ sung dinh dưỡng cho cơ thể", "Đậu nành luộc", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu bắp là loại rau quả giàu vitamin C và chất xơ, giúp hỗ trợ tiêu hóa và làm đẹp da. Đậu bắp có thể ăn luộc, xào hoặc làm canh, là món ăn bổ dưỡng cho các bữa ăn gia đình", "Đậu bắp", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cà chua là thực phẩm giàu vitamin C và chất xơ, có tác dụng làm đẹp da và hỗ trợ tiêu hóa. Cà chua có thể ăn sống, làm salad, hoặc chế biến thành các món xào, canh", "Cà chua", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/1999634/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("43d635e2-6f0c-4385-83d8-fedfd479d356"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt gà kho là món ăn đậm đà với thịt gà kho trong gia vị như nước mắm, tiêu, và gia vị khác. Món này có thể ăn kèm với cơm trắng, mang lại hương vị ngon miệng và bổ dưỡng", "Thịt gà kho", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dưa chuột là rau quả tươi mát, giúp giải nhiệt và làm đẹp da. Dưa chuột có thể ăn sống, làm salad, hoặc chế biến thành món xào và canh, rất thích hợp trong các bữa ăn hằng ngày để thanh lọc cơ thể", "Dưa chuột", true, "Breakfast,Lunch,Dinner,Snack", "https://fdc.nal.usda.gov/food-details/2346406/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún chả là món ăn đặc sản Hà Nội, gồm bún, thịt chả nướng, và rau sống. Món ăn này có nước mắm pha chua ngọt, tạo thành bữa ăn ngon miệng, đậm đà và rất dễ ăn", "Bún chả", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún mắm là món ăn nổi bật với nước dùng từ mắm, kết hợp với bún và các loại hải sản như tôm, cá. Đây là món ăn đặc sản của miền Tây, mang lại hương vị đậm đà và rất thơm ngon", "Bún mắm", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/333374/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dừa tươi là thức uống giải khát tuyệt vời, giàu vitamin C và khoáng chất. Nước dừa cung cấp độ ẩm và giúp thanh nhiệt, rất tốt cho làn da và sức khỏe hệ tiêu hóa", "Dừa tươi", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tôm hấp là món ăn đơn giản, dễ chế biến, giữ nguyên vị ngọt của tôm. Món này thường được ăn kèm với muối tiêu chanh hoặc nước mắm chua ngọt, thích hợp cho bữa ăn nhẹ", "Tôm hấp", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2684443/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4edcae53-7e30-42bb-8526-7686355f2268"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh cải xanh là món canh nhẹ, giàu vitamin và khoáng chất, thường được nấu với thịt heo hoặc tôm. Đây là món ăn bổ dưỡng, dễ tiêu hóa và thích hợp cho các bữa ăn thanh đạm", "Canh cải xanh", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu hũ chiên là món ăn phổ biến trong các bữa ăn chay, có kết cấu giòn bên ngoài và mềm mịn bên trong. Món này có thể ăn kèm với các loại nước chấm hoặc xào với rau củ", "Đậu hũ chiên", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("51061170-597d-4289-a021-1e7dde88331f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt vịt là nguồn protein giàu chất dinh dưỡng, có thể chế biến thành nhiều món như vịt nướng, vịt kho hoặc vịt luộc. Món thịt vịt thường có hương vị đặc trưng, đậm đà và thích hợp cho các bữa ăn gia đình", "Thịt vịt", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bò bít tết là món ăn từ thịt bò nạc, được nướng hoặc áp chảo đến độ chín vừa phải. Món này thường được ăn kèm với khoai tây chiên hoặc rau sống, mang lại hương vị đậm đà, rất thích hợp cho bữa tối", "Bò bít tết", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2646175/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh chua cá là món ăn đậm đà với nước dùng chua ngọt, thường làm từ cá và các loại rau như giá đỗ, ngò rí, ăn kèm với bún. Món này thanh mát, giải nhiệt và rất bổ dưỡng", "Canh chua cá", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rong biển khô là thực phẩm giàu vitamin, khoáng chất và chất xơ, rất tốt cho sức khỏe. Món rong biển có thể dùng làm salad, súp, hoặc làm nhân cho sushi, rất phổ biến trong ẩm thực châu Á", "Rong biển khô", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ớt chuông là loại rau quả giàu vitamin C, giúp tăng cường sức khỏe và làm đẹp da. Ớt chuông có thể ăn sống, xào, hoặc làm salad, mang lại hương vị tươi mát và màu sắc đẹp mắt cho bữa ăn", "Ớt chuông", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2258590/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cải bó xôi là rau xanh giàu vitamin A, C và chất sắt. Món cải bó xôi có thể ăn sống trong salad, xào hoặc nấu canh, giúp tăng cường sức khỏe xương và cải thiện hệ miễn dịch", "Cải bó xôi", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/1999632/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm là món ăn chủ yếu trong bữa ăn Việt Nam, cung cấp tinh bột quan trọng. Cơm thường ăn kèm với các món mặn như thịt, cá và rau, tạo nên một bữa ăn đầy đủ dinh dưỡng, bổ sung năng lượng cho cơ thể", "Cơm", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2512381/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Lựu là trái cây giàu vitamin C, chất chống oxy hóa và khoáng chất. Món này có thể ăn trực tiếp hoặc làm nước ép, giúp cải thiện hệ miễn dịch và làm đẹp da", "Lựu", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá ngừ đóng hộp là món ăn tiện lợi, giàu protein và omega-3. Món này có thể ăn trực tiếp, làm salad hoặc kèm với cơm, rất dễ chế biến và thích hợp cho bữa ăn nhanh", "Cá ngừ đóng hộp", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/334194/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp cua là món ăn nhẹ với nước dùng từ cua, mang hương vị ngọt tự nhiên và bổ dưỡng. Món này thường được ăn vào bữa sáng hoặc bữa tối, rất giàu protein và khoáng chất", "Súp cua", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt kho trứng là món ăn quen thuộc với thịt heo kho cùng trứng luộc, mang hương vị mặn ngọt đậm đà. Món này thường ăn kèm với cơm trắng, rất ngon miệng và bổ dưỡng", "Thịt kho trứng", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mì quảng là món đặc sản của miền Trung, gồm mì gạo, nước dùng đậm đà, tôm, thịt hoặc trứng, và rau sống. Món ăn này có vị đặc trưng và rất thích hợp cho bữa sáng hoặc trưa", "Mì quảng", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nấm đùi gà có hình dạng giống đùi gà, thịt nấm mềm và thơm. Món này thường được dùng trong các món xào, nấu canh hoặc làm salad, rất giàu dinh dưỡng và dễ chế biến", "Nấm đùi gà", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2003599/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh cua mồng tơi là món ăn dân dã, có vị ngọt từ cua và mồng tơi. Món này không chỉ thơm ngon mà còn rất bổ dưỡng, đặc biệt tốt cho hệ tiêu hóa và làn da", "Canh cua mồng tơi", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau mồng tơi là loại rau xanh giàu vitamin A và chất sắt, có thể chế biến thành các món xào, luộc hoặc canh. Món rau này giúp thanh nhiệt, giải độc và tốt cho hệ tiêu hóa", "Rau mồng tơi", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6487a532-ff5e-4b77-b408-46c789608de9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh bí đao là món canh mát, giúp giải nhiệt và thanh lọc cơ thể. Bí đao có thể nấu với tôm, thịt heo hoặc cá, mang lại hương vị thanh đạm và rất bổ dưỡng cho sức khỏe", "Canh bí đao", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh rau ngót là món canh thanh mát, có vị ngọt tự nhiên từ rau ngót. Món này thường được nấu với thịt hoặc tôm, giúp giải nhiệt và bổ sung dinh dưỡng cho cơ thể", "Canh rau ngót", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì sandwich là món ăn nhanh với lớp bánh mì mềm, nhân có thể là thịt, rau, trứng hoặc phô mai. Đây là lựa chọn lý tưởng cho bữa sáng hoặc bữa phụ, dễ dàng mang theo khi đi làm hoặc đi học", "Bánh mì sandwich", true, "Breakfast,Lunch,Snack", "https://fdc.nal.usda.gov/food-details/325871/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cà phê là thức uống quen thuộc, có thể uống đen hoặc thêm sữa, với hương vị đậm đà và kích thích tinh thần. Cà phê thường được uống vào buổi sáng hoặc trong suốt cả ngày để duy trì sự tỉnh táo", "Cà phê", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau má là loại rau mát, giúp thanh nhiệt, giải độc và làm đẹp da. Rau má có thể ăn sống trong salad hoặc nấu canh, rất tốt cho sức khỏe và có tác dụng làm dịu cơ thể trong mùa hè", "Rau má", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hủ tiếu là món ăn gồm mì hoặc bún ăn kèm với nước dùng thơm ngon và các loại thịt như tôm, gà, hoặc heo. Món này phổ biến ở miền Nam Việt Nam và rất dễ ăn, thích hợp cho bữa sáng hoặc bữa tối", "Hủ tiếu", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo sườn là món ăn sáng phổ biến, với cháo mềm mịn kết hợp cùng sườn heo kho hoặc hầm. Món này có vị ngọt tự nhiên từ xương, thường ăn kèm với hành lá, rau thơm và gia vị", "Cháo sườn", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7167f942-dc89-4f29-8022-588373aef45e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún gà là món ăn thanh mát với bún, thịt gà luộc hoặc xé nhỏ và nước dùng thơm ngon. Đây là món ăn nhẹ nhàng, thích hợp cho bữa sáng hoặc bữa trưa", "Bún gà", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh bún là món ăn nổi bật với nước dùng ngọt từ xương, kết hợp với bún, thịt heo hoặc tôm. Món này thường ăn kèm với rau sống và gia vị, mang lại hương vị đậm đà và dễ ăn", "Canh bún", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sườn non là phần thịt heo mềm, có thể chế biến thành nhiều món như sườn nướng, sườn kho hoặc sườn xào chua ngọt. Món sườn non rất thích hợp cho các bữa cơm gia đình, có vị đậm đà và dễ ăn", "Sườn non", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2646168/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bao là món ăn đơn giản, với lớp vỏ mềm mịn và nhân thịt heo hoặc trứng. Đây là món ăn nhanh gọn, thường được ăn sáng hoặc làm món phụ trong các bữa ăn chính", "Bánh bao", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cà rốt là rau củ giàu vitamin A, giúp cải thiện thị lực và sức khỏe da. Cà rốt có thể ăn sống, làm salad, hoặc chế biến thành các món xào, canh hoặc nước ép", "Cà rốt", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2258587/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì thịt trứng là món ăn nhanh, với bánh mì mềm, nhân thịt nướng và trứng chiên. Đây là món ăn sáng phổ biến, đơn giản nhưng đầy đủ dinh dưỡng, dễ ăn và tiện lợi", "Bánh mì thịt trứng", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún xào là món ăn ngon miệng với bún xào cùng các loại rau và thịt hoặc tôm. Món này thường được chế biến nhanh, có vị thơm, ngọt từ các nguyên liệu kết hợp, thường ăn vào bữa trưa hoặc tối", "Bún xào", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm tấm sườn là món ăn phổ biến ở miền Nam Việt Nam, bao gồm cơm tấm mềm mịn ăn kèm với sườn nướng và các loại rau sống. Món này mang lại hương vị đậm đà và đầy đủ dinh dưỡng", "Cơm tấm sườn", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2514745/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Măng tây là loại rau giàu vitamin K và chất chống oxy hóa, tốt cho sức khỏe tim mạch và hệ xương. Măng tây có thể xào, nấu canh hoặc ăn sống, rất bổ dưỡng và dễ chế biến", "Măng tây", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Kiwi là trái cây giàu vitamin C, chất xơ và chất chống oxy hóa. Kiwi giúp cải thiện hệ tiêu hóa, tăng cường sức đề kháng và làm đẹp da. Món này có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng", "Kiwi", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp bò hầm là món ăn có nước dùng đậm đà từ xương bò, với thịt bò mềm và rau củ đi kèm. Món này cung cấp năng lượng và dưỡng chất, rất phù hợp cho bữa tối", "Súp bò hầm", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b8500af-d730-4138-9617-cba352faed4a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Vải là trái cây ngọt, chứa nhiều vitamin C và khoáng chất. Vải có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng, đặc biệt trong mùa hè", "Vải", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7cd76708-7312-445e-a392-14f0e806a786"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu Hà Lan là loại rau giàu vitamin, khoáng chất và chất xơ, giúp hỗ trợ hệ tiêu hóa và tăng cường miễn dịch. Đậu Hà Lan có thể ăn trực tiếp, làm salad hoặc nấu canh", "Đậu Hà Lan", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún thịt nướng là món ăn gồm bún mềm, thịt nướng thơm ngon và các loại rau sống. Món này có thể ăn kèm với nước mắm pha, tạo thành một bữa ăn vừa thanh mát vừa đầy đủ dinh dưỡng", "Bún thịt nướng", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bầu là loại rau quả mát, chứa nhiều vitamin và khoáng chất. Bầu có thể chế biến thành các món canh, xào hoặc làm gỏi, giúp thanh nhiệt và hỗ trợ tiêu hóa", "Bầu", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá ngừ là loại hải sản giàu omega-3 và protein, có thể chế biến thành nhiều món như cá ngừ nướng, cá ngừ kho hoặc làm sushi. Món này rất bổ dưỡng và dễ dàng chế biến", "Cá ngừ", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/334194/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("827829bf-71cd-4865-80af-1457e0091456"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh nấm là món ăn nhẹ, bổ dưỡng, giàu vitamin và chất xơ. Nấm có thể kết hợp với rau củ hoặc thịt để tạo ra món canh thơm ngon, rất phù hợp cho bữa ăn thanh đạm", "Canh nấm", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bông cải xanh (súp lơ) là loại rau chứa nhiều vitamin C, vitamin K và chất chống oxy hóa. Bông cải xanh có thể xào, luộc hoặc làm món canh, là món ăn bổ dưỡng giúp cải thiện sức khỏe", "Bông cải xanh", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8382816f-1beb-4804-9698-3b486798b20a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì chả lụa là món ăn sáng phổ biến, với bánh mì giòn và nhân chả lụa thơm ngon. Món này đơn giản, dễ ăn và thích hợp cho bữa sáng hoặc bữa phụ", "Bánh mì chả lụa", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt kho tiêu là món ăn đơn giản nhưng thơm ngon, thường làm từ thịt ba chỉ hoặc thịt heo kho với tiêu, nước dừa và gia vị. Món này có vị mặn ngọt đậm đà, ăn cùng với cơm trắng rất hợp", "Thịt kho tiêu", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/331897/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Củ cải trắng là loại rau củ giàu vitamin C và chất xơ, giúp thanh nhiệt và giải độc cơ thể. Món củ cải trắng có thể ăn sống, xào hoặc nấu canh, mang lại hương vị thanh mát và bổ dưỡng", "Củ cải trắng", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Củ cải đường là loại củ chứa nhiều vitamin C và khoáng chất, giúp cải thiện sức khỏe tim mạch và huyết áp. Món củ cải đường có thể ăn sống, xào hoặc nấu canh, mang lại lợi ích cho cơ thể", "Củ cải đường", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Xúc xích là món ăn làm từ thịt xay (thường là thịt heo hoặc bò), tẩm gia vị và nhồi vào ruột lợn, sau đó luộc hoặc nướng. Xúc xích dễ dàng chế biến và là món ăn nhanh gọn cho bữa sáng hoặc bữa phụ", "Xúc xích", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/746779/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("85e621ed-0e0c-4d20-8891-51d311cea4a3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh thịt bò hầm là món canh đậm đà, với thịt bò hầm mềm cùng các gia vị và rau củ. Món này bổ dưỡng, cung cấp nhiều protein và khoáng chất, thích hợp cho bữa tối hoặc bữa chính", "Canh thịt bò hầm", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ức gà nướng là món ăn ít mỡ, giàu protein, có thể được ướp gia vị và nướng chín. Món này thường được ăn kèm với rau củ hoặc cơm, là lựa chọn tốt cho bữa ăn nhẹ nhàng nhưng đầy đủ dinh dưỡng", "Ức gà nướng", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2646170/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("86d88717-df08-4de6-b86d-870210864b46"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thanh long là trái cây ngọt, mát, chứa nhiều vitamin C và khoáng chất, giúp tăng cường sức đề kháng và làm đẹp da. Thanh long có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng", "Thanh long", true, "Breakfast,Snack", "https://vikinutri.com/thuc-pham/qua-trai-cay/thanh-long", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Phở bò viên là món phở nổi tiếng với nước dùng trong, đậm đà từ xương bò, ăn kèm với bánh phở mềm và bò viên. Món này mang lại hương vị thơm ngon, phổ biến cho bữa sáng", "Phở bò viên", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh bí đỏ nấu tôm là món canh nhẹ, thanh mát, với bí đỏ nấu mềm kết hợp với tôm. Món canh này giàu vitamin A và protein, giúp bổ dưỡng và dễ tiêu hóa", "Canh bí đỏ nấu tôm", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh mùng tơi mướp là món canh mát, giải nhiệt, giúp bổ sung dưỡng chất và hỗ trợ tiêu hóa. Món này thường được nấu với thịt hoặc tôm, mang lại hương vị thanh đạm và bổ dưỡng", "Canh mùng tơi mướp", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Khoai tây là nguồn cung cấp tinh bột và vitamin C. Khoai tây có thể chế biến thành nhiều món như khoai tây chiên, luộc, nghiền hoặc nướng, rất phổ biến trong các bữa ăn gia đình", "Khoai tây", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2346403/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh hỏi là món ăn với bánh phở mềm, thường được ăn kèm với thịt nướng hoặc chả, và nước mắm pha. Món này có vị thanh nhẹ, rất phổ biến trong các bữa ăn ở miền Trung", "Bánh hỏi", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Khoai môn là loại củ giàu tinh bột và vitamin C, có thể chế biến thành các món xào, luộc, làm chè hoặc làm nhân bánh. Món khoai môn rất bổ dưỡng và dễ tiêu hóa", "Khoai môn", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu hũ sốt cà là món ăn chay nhẹ nhàng, với đậu hũ mềm mịn ăn kèm với sốt cà chua đậm đà. Món này cung cấp protein thực vật và rất dễ chế biến, phù hợp cho các bữa ăn chay hoặc ăn kiêng", "Đậu hũ sốt cà", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8ed85dc2-7654-4c48-81f9-19946a73f71d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bắp cải luộc là món ăn thanh mát, dễ làm, chứa nhiều vitamin và khoáng chất. Bắp cải luộc có thể ăn kèm với nước mắm hoặc làm món ăn phụ trong bữa ăn chính", "Bắp cải luộc", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún bò Huế là món ăn nổi tiếng với nước dùng đậm đà từ xương bò, mắm ruốc, và gia vị đặc trưng. Món này kết hợp bún, thịt bò, giò heo và rau sống, tạo nên hương vị thơm ngon, hấp dẫn cho bữa ăn", "Bún bò huế", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún ốc là món ăn nổi bật với nước dùng chua ngọt từ ốc và gia vị, kết hợp với bún và các loại rau sống. Món này có vị thơm ngon, thích hợp cho bữa trưa hoặc tối", "Bún ốc", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("90a605b6-843d-4cc1-8fe7-a016c76ee29c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau muống luộc là món ăn đơn giản, dễ làm, rất phổ biến ở Việt Nam. Rau muống luộc có thể ăn kèm với nước mắm tỏi ớt hoặc làm món ăn phụ trong bữa cơm, giúp thanh nhiệt và bổ sung dưỡng chất", "Rau muống luộc", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Trà tắc là thức uống giải khát phổ biến, được làm từ trà xanh kết hợp với nước cốt chanh tươi và mật ong. Trà tắc giúp giải nhiệt, thanh lọc cơ thể và mang lại cảm giác sảng khoái", "Trà tắc", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Phở bò tái là món phở nổi tiếng với nước dùng trong, đậm đà từ xương bò, ăn kèm với thịt bò tái và bánh phở mềm. Món ăn này rất phổ biến vào buổi sáng ở Việt Nam, mang lại cảm giác ấm cúng và no lâu", "Phở bò tái", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì chả cá là món ăn sáng quen thuộc, với bánh mì mềm, nhân chả cá chiên thơm ngon và rau sống. Món này rất phổ biến ở Việt Nam, tiện lợi và dễ ăn", "Bánh mì chả cá", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu que là loại rau quả giàu vitamin và chất xơ, có thể chế biến thành các món xào, luộc hoặc nấu canh. Đậu que giúp tăng cường hệ tiêu hóa và cung cấp năng lượng cho cơ thể", "Đậu que", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2346400/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("982d8f3e-f517-4bd2-87a8-48329fc9eb91"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh cải ngọt là món ăn nhẹ nhàng, với cải ngọt nấu trong nước dùng, có thể kết hợp với thịt heo hoặc tôm. Món canh này bổ dưỡng, dễ tiêu hóa và giúp thanh nhiệt", "Canh cải ngọt", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa bò tươi là thức uống bổ dưỡng, cung cấp canxi, vitamin D và protein. Sữa bò có thể uống trực tiếp hoặc làm nguyên liệu cho các món sinh tố, mang lại nhiều lợi ích cho sức khỏe xương", "Sữa bò tươi", true, "Breakfast,Snack", "https://fdc.nal.usda.gov/food-details/746772/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau cải bó xôi là loại rau xanh chứa nhiều vitamin A, C và chất sắt. Món cải bó xôi có thể ăn sống trong salad, xào hoặc nấu canh, rất bổ dưỡng và tốt cho sức khỏe xương", "Rau cải bó xôi", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau chân vịt (cải bó xôi) là loại rau giàu vitamin A, C và chất sắt, giúp tăng cường sức khỏe xương và hỗ trợ miễn dịch. Rau chân vịt có thể ăn sống trong salad, xào hoặc nấu canh", "Rau chân vịt", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau muống xào tỏi là món ăn phổ biến, với rau muống tươi xào cùng tỏi và gia vị. Món này có vị đậm đà, thơm ngon, rất thích hợp ăn kèm với cơm trắng", "Rau muống xào tỏi", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cải ngọt luộc là món rau luộc đơn giản, dễ làm, giàu vitamin và chất xơ. Món này thường ăn kèm với nước mắm chua ngọt hoặc làm món ăn phụ trong các bữa ăn chính", "Cải ngọt luộc", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gạo lứt là loại gạo nguyên hạt, giàu chất xơ, vitamin và khoáng chất. Món gạo lứt có thể ăn kèm với các món thịt hoặc rau, giúp duy trì năng lượng lâu dài và rất tốt cho hệ tiêu hóa", "Gạo lứt", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cam là trái cây giàu vitamin C, giúp tăng cường miễn dịch và làm đẹp da. Cam có thể ăn trực tiếp hoặc làm nước ép, giúp giải nhiệt và bổ sung dinh dưỡng cho cơ thể", "Cam", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa chua là món ăn từ sữa lên men, chứa nhiều vi khuẩn có lợi cho hệ tiêu hóa. Sữa chua có thể ăn trực tiếp hoặc làm thành các món tráng miệng, bổ dưỡng và dễ tiêu hóa", "Sữa chua", true, "Snack,Breakfast", "https://fdc.nal.usda.gov/food-details/2647437/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá hồi hun khói là món ăn giàu omega-3, có hương vị đậm đà và thơm ngon từ quá trình hun khói. Món này thường được ăn kèm với bánh mì hoặc làm thành salad, rất bổ dưỡng và dễ ăn", "Cá hồi hun khói", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2684441/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm gạo lức được làm từ gạo lức chưa xay xát hoàn toàn, giàu chất xơ và dinh dưỡng. Món này cung cấp năng lượng lâu dài, tốt cho sức khỏe và rất phổ biến trong các bữa ăn hàng ngày", "Cơm gạo lức", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Xoài là trái cây ngọt, thơm, giàu vitamin C và chất xơ. Xoài có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng", "Xoài", true, "Breakfast,Snack", "https://fdc.nal.usda.gov/food-details/2710834/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a364353c-d589-4a94-9c3b-3038113ea249"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bò xào rau củ là món ăn ngon với thịt bò thái mỏng xào nhanh với các loại rau củ như ớt, hành tây, cà rốt. Món này cung cấp nhiều vitamin và protein, thích hợp cho bữa tối bổ dưỡng", "Bò xào rau củ", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún riêu cua là món ăn nổi tiếng với nước dùng chua ngọt, kết hợp với cua, bún và các loại rau sống. Món ăn này mang hương vị đặc trưng và bổ dưỡng, phù hợp cho bữa trưa hoặc tối", "Bún riêu cua", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nước dừa là thức uống mát từ nước bên trong quả dừa, giúp giải nhiệt và bổ sung khoáng chất. Nó cũng rất tốt cho làn da và hệ tiêu hóa, thích hợp để uống trong mùa hè", "Nước dừa", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a504d882-4f38-413e-bb28-fae1f2787150"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nhãn là trái cây ngọt, mọng nước, chứa nhiều vitamin C và giúp tăng cường sức đề kháng. Nhãn có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng, rất tốt cho sức khỏe", "Nhãn", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mực là hải sản giàu protein và khoáng chất, có thể chế biến thành các món xào, hấp, hoặc nướng. Mực có vị ngọt tự nhiên, giúp bổ sung dinh dưỡng và rất dễ ăn", "Mực", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 27 },
                    { new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt lợn xông khói có vị mặn ngọt, được chế biến bằng cách xông khói để tạo hương vị đặc trưng. Món này có thể ăn kèm với cơm, salad hoặc làm nhân cho bánh mì", "Thịt lợn xông khói", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/749420/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt bò nạc là phần thịt ít mỡ, giàu protein và sắt, có thể chế biến thành các món như bò xào, nướng hoặc làm súp. Món ăn này cung cấp năng lượng và dưỡng chất cho cơ thể, thích hợp cho các bữa chính", "Thịt bò nạc", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/746758/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mâm xôi là trái cây giàu vitamin C và chất chống oxy hóa, có tác dụng tốt cho hệ miễn dịch và làn da. Mâm xôi có thể ăn trực tiếp hoặc làm sinh tố, chè, tráng miệng", "Mâm xôi", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp khoai tây là món canh ngon và bổ dưỡng, với khoai tây nấu mềm trong nước dùng nhẹ nhàng. Món này thích hợp cho bữa tối, mang lại cảm giác ấm áp và dễ tiêu hóa", "Súp khoai tây", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a988cc73-072e-4af1-9b53-55fbf0f4fe79"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau xào là món ăn đơn giản với rau củ được xào nhanh với gia vị. Món này thường sử dụng các loại rau như cải thảo, cải ngọt, giúp cung cấp vitamin và khoáng chất cho cơ thể", "Rau xào", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chuối là trái cây ngọt, dễ ăn, cung cấp vitamin C và kali. Chuối rất tốt cho hệ tiêu hóa và tim mạch. Món này thường được ăn trực tiếp, làm sinh tố hoặc chế biến thành các món tráng miệng như chè", "Chuối", true, "Breakfast,Snack", "https://fdc.nal.usda.gov/food-details/1105073/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đào là trái cây ngọt, mọng nước, chứa nhiều vitamin C và chất chống oxy hóa. Món này có thể ăn trực tiếp, làm sinh tố hoặc chế biến thành các món tráng miệng, giúp tăng cường sức đề kháng", "Đào", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún là món ăn phổ biến ở Việt Nam, được chế biến từ gạo. Bún có thể kết hợp với các loại thịt, cá, hoặc rau, tạo thành những món như bún riêu, bún chả, bún bò Huế, mang lại hương vị đặc trưng", "Bún", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ức vịt nướng là món ăn ngon miệng, thịt vịt mềm và mọng nước khi được ướp gia vị và nướng chín. Món này có thể ăn kèm với cơm hoặc rau sống, mang lại hương vị đậm đà", "Ức vịt nướng", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá thu nướng là món ăn thơm ngon, giàu protein và omega-3. Cá thu thường được ướp gia vị rồi nướng, tạo nên món ăn đậm đà và bổ dưỡng cho bữa tối", "Cá thu nướng", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("af036922-79f3-45a7-b562-a6279520c0e6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Miến gà là món ăn nhẹ với miến mềm, nước dùng thơm ngon từ gà, ăn kèm với thịt gà xé nhỏ. Món này rất dễ ăn, thích hợp cho bữa sáng hoặc bữa trưa nhẹ nhàng", "Miến gà", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đu đủ là trái cây ngọt, giàu vitamin C và enzym papain, giúp tiêu hóa tốt. Đu đủ có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng, rất tốt cho sức khỏe và làn da", "Đu đủ", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu hà lan luộc là món ăn giàu protein và chất xơ, có thể ăn trực tiếp hoặc chế biến thành salad. Món này có vị ngọt tự nhiên, rất bổ dưỡng và dễ chế biến", "Đậu Hà Lan luộc", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2644291/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh rau dền là món ăn nhẹ nhàng, thanh mát, thường được nấu với thịt hoặc tôm. Rau dền chứa nhiều vitamin và khoáng chất, giúp cải thiện sức khỏe và hỗ trợ tiêu hóa", "Canh rau dền", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá kho là món ăn đậm đà với cá kho trong nước mắm, tiêu và các gia vị khác. Món này có thể ăn kèm với cơm trắng, mang lại hương vị mặn ngọt và rất bổ dưỡng", "Cá kho", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt heo kho là món ăn với thịt heo được kho mềm, thấm đẫm gia vị mặn ngọt. Món này thường ăn kèm với cơm trắng, tạo thành một bữa ăn đậm đà và bổ dưỡng", "Thịt heo kho", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm chiên là món ăn phổ biến, được làm từ cơm nguội chiên cùng với thịt, trứng và rau củ. Món này thường ăn kèm với dưa leo hoặc salad, rất dễ ăn và tiện lợi", "Cơm chiên", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt gà là nguồn protein nhẹ nhàng, giàu dinh dưỡng. Thịt gà có thể chế biến thành nhiều món như gà kho, gà luộc, hoặc gà xào. Đây là lựa chọn phổ biến trong các bữa ăn hàng ngày", "Thịt gà", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/331960/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bèo là món ăn dân dã của miền Trung, gồm bánh làm từ bột gạo, thường được phủ lên trên các loại tôm, thịt hoặc mỡ hành. Món này có thể ăn kèm với nước mắm chua ngọt", "Bánh bèo", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bắp luộc là món ăn đơn giản nhưng bổ dưỡng, chứa nhiều chất xơ và vitamin. Bắp luộc có thể ăn trực tiếp hoặc làm món ăn kèm trong bữa ăn, đặc biệt là vào mùa hè", "Bắp luộc", true, "Snack,Breakfast,Lunch", "https://fdc.nal.usda.gov/food-details/2710826/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Trứng gà luộc là món ăn đơn giản, giàu protein, vitamin B12 và khoáng chất. Trứng gà thường được ăn sáng hoặc dùng làm món phụ trong bữa ăn chính, giúp cung cấp năng lượng và duy trì sức khỏe", "Trứng gà luộc", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/747997/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Yến mạch là ngũ cốc giàu chất xơ và vitamin, giúp giảm cholesterol và hỗ trợ tiêu hóa. Món yến mạch có thể nấu cháo hoặc làm sinh tố, thích hợp cho bữa sáng bổ dưỡng", "Yến mạch", true, "Breakfast,Snack", "https://fdc.nal.usda.gov/food-details/2261421/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c5e3e4ed-0164-4917-a1ce-99679b971a22"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo gà là món ăn nhẹ, với cháo mịn và thịt gà chín mềm, thường ăn kèm với hành lá, rau thơm và gia vị. Món này dễ tiêu hóa, phù hợp cho bữa sáng hoặc khi bạn cảm thấy mệt mỏi", "Cháo gà", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh rau củ là món ăn nhẹ nhàng, giàu vitamin và chất xơ, thích hợp cho các bữa ăn dinh dưỡng. Các loại rau như cà rốt, khoai tây, đậu que được nấu chung tạo thành món canh thơm ngon, dễ ăn", "Canh rau củ", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mì gạo lứt được làm từ gạo lứt nguyên hạt, giàu chất xơ và vitamin. Món mì này có thể chế biến thành các món xào, soup hoặc ăn kèm với thịt, rất tốt cho sức khỏe và giúp giảm cholesterol", "Mì gạo lứt", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chôm chôm là trái cây ngọt, có vỏ đỏ hoặc vàng, mọng nước và giàu vitamin C. Món này rất thích hợp trong mùa hè, giúp giải nhiệt và bổ sung dinh dưỡng", "Chôm chôm", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hồng xiêm là trái cây ngọt, có hương vị đặc trưng, giàu vitamin C và khoáng chất. Món này có thể ăn trực tiếp hoặc chế biến thành các món tráng miệng, sinh tố, rất tốt cho sức khỏe", "Hồng xiêm", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh hẹ tôm là món canh thanh mát, với tôm và hẹ nấu chung trong nước dùng thơm ngon. Món này giúp bổ sung protein và vitamin, rất dễ ăn và thích hợp cho các bữa ăn nhẹ", "Canh hẹ tôm", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm chiên trứng là món ăn đơn giản nhưng ngon miệng, được làm từ cơm nguội xào cùng trứng, có thể thêm các loại rau và thịt tùy thích. Món này phù hợp cho bữa trưa hoặc tối nhanh gọn và đầy đủ dinh dưỡng", "Cơm chiên trứng", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa chua Hy Lạp là loại sữa chua đặc, chứa nhiều probiotics giúp hỗ trợ tiêu hóa. Món này có thể ăn trực tiếp hoặc kết hợp với trái cây tươi, mang lại cảm giác ngon miệng và bổ dưỡng", "Sữa chua Hy Lạp", true, "Snack,Breakfast", "https://fdc.nal.usda.gov/food-details/330137/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt lợn nạc là phần thịt ít mỡ, dễ chế biến thành các món như xào, kho hoặc nướng. Món này cung cấp protein và chất sắt, thường được ăn trong các bữa chính", "Thịt lợn nạc", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2646168/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá thu là loại hải sản giàu omega-3 và protein, rất tốt cho sức khỏe tim mạch. Cá thu có thể nướng, chiên hoặc kho, mang lại hương vị thơm ngon và bổ dưỡng cho bữa ăn", "Cá thu", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh canh là món ăn nổi bật với nước dùng đậm đà, có thể làm từ bún hoặc bánh canh, ăn kèm với các loại thịt như cua, tôm, hoặc giò heo. Món này rất phổ biến ở miền Trung và Nam Việt Nam", "Bánh canh", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bột lọc là món ăn đặc trưng của miền Trung, gồm vỏ bánh làm từ bột năng, nhân tôm hoặc thịt, sau đó hấp chín. Món này thường ăn kèm với nước mắm chua ngọt và rau sống", "Bánh bột lọc", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún hải sản là món ăn đậm đà với bún, nước dùng từ hải sản và các loại hải sản như tôm, cua, mực. Món này có hương vị đặc trưng và rất bổ dưỡng", "Bún hải sản", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dưa cải chua là món ăn lên men, được làm từ cải thảo hoặc cải bẹ, mang vị chua nhẹ. Món này thường ăn kèm với cơm, giúp hỗ trợ tiêu hóa và bổ sung lợi khuẩn cho hệ tiêu hóa", "Dưa cải chua", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/324653/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Phở gà là món ăn nhẹ nhàng, nước dùng thơm từ gà, ăn kèm với bánh phở và thịt gà. Món này có thể ăn vào buổi sáng hoặc bữa tối, rất thanh đạm nhưng đầy đủ dinh dưỡng", "Phở gà", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hành tây là loại củ gia vị phổ biến, mang lại hương vị thơm ngon cho các món xào, canh hoặc salad. Hành tây có tác dụng tốt cho sức khỏe tim mạch và giúp cải thiện hệ tiêu hóa", "Hành tây", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/1104962/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chả lụa là món ăn được làm từ thịt heo xay nhuyễn, cuộn chặt và hấp chín. Món này thường dùng trong các bữa ăn chính, bánh mì hoặc cơm, mang lại hương vị ngọt mềm, thơm ngon", "Chả lụa", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá khô là món ăn truyền thống, có thể làm từ nhiều loại cá, chế biến bằng cách phơi khô. Cá khô có vị mặn, thơm, thường được ăn kèm với cơm trắng hoặc làm nguyên liệu cho các món canh", "Cá khô", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ức gà là phần thịt ít mỡ, giàu protein và dễ chế biến. Món ức gà có thể nướng, xào, hấp hoặc luộc, cung cấp năng lượng và dưỡng chất cho cơ thể, phù hợp với bữa trưa hoặc tối", "Ức gà", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/331960/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nước cam là thức uống từ cam tươi, cung cấp vitamin C và chất chống oxy hóa. Nước cam là lựa chọn tuyệt vời để giải khát và bổ sung dưỡng chất cho cơ thể, đặc biệt trong mùa lạnh", "Nước cam", true, "Breakfast,Snack", "https://fdc.nal.usda.gov/food-details/2003591/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cà phê sữa là thức uống phổ biến ở Việt Nam, được pha chế từ cà phê đen đặc kết hợp với sữa đặc ngọt. Món này có vị đắng nhẹ kết hợp với ngọt béo, thích hợp để uống vào buổi sáng để khởi đầu ngày mới", "Cà phê sữa", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh canh cua là món ăn đặc trưng với nước dùng đậm đà từ cua, ăn kèm với bánh canh mềm và các loại rau. Món này rất phổ biến ở miền Nam và mang lại hương vị thơm ngon, bổ dưỡng", "Bánh canh cua", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2684446/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Xôi bắp là món ăn sáng đơn giản, được làm từ gạo nếp và bắp, có vị ngọt tự nhiên của ngô. Món này dễ ăn, cung cấp năng lượng cho cả ngày dài, thường được ăn kèm với thịt hoặc các món mặn khác", "Xôi bắp", true, "Breakfast,Lunch", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo vịt là món cháo nấu với thịt vịt, có vị ngọt tự nhiên từ thịt và xương vịt. Món này thường được ăn vào bữa sáng hoặc bữa tối, giúp cung cấp năng lượng và dưỡng chất", "Cháo vịt", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e370081a-c0a6-4c00-b01c-7c52f953b7f1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh mướp là món ăn thanh mát với mướp nấu trong nước dùng nhẹ nhàng từ xương hoặc thịt. Món canh này có tác dụng giải nhiệt, rất thích hợp vào mùa hè", "Canh mướp", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Lê là trái cây ngọt mát, giàu vitamin C và chất xơ, giúp cải thiện hệ tiêu hóa và làm đẹp da. Lê có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng", "Lê", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tôm là hải sản giàu protein, omega-3 và vitamin, rất tốt cho sức khỏe tim mạch. Tôm có thể chế biến thành nhiều món ăn như xào, hấp, hoặc nấu canh, tạo hương vị tươi ngon cho bữa ăn", "Tôm", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2684443/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo sườn non là món ăn thơm ngon, với cháo được nấu từ xương sườn heo, có vị ngọt tự nhiên từ xương. Món này thường được ăn kèm với hành phi và gia vị, thích hợp cho bữa sáng", "Cháo sườn non", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp hải sản là món ăn đậm đà với nước dùng từ hải sản như tôm, cua, mực, nấu cùng với rau củ và gia vị. Món này rất bổ dưỡng và thích hợp cho các bữa ăn chính", "Súp hải sản", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dưa hấu là trái cây giải nhiệt, chứa nhiều nước và vitamin C. Đây là món ăn lý tưởng trong mùa hè, giúp cung cấp nước và dưỡng chất cho cơ thể, có thể ăn trực tiếp hoặc làm sinh tố", "Dưa hấu", true, "Snack,Breakfast", "https://fdc.nal.usda.gov/food-details/746770/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá hồi nướng là món ăn bổ dưỡng, giàu omega-3 và protein, thường được ướp gia vị trước khi nướng. Món này có hương vị ngọt tự nhiên, thích hợp ăn kèm với rau sống hoặc cơm", "Cá hồi nướng", true, "Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2684441/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("eec3d874-6331-4e33-bbe6-bf0cc4335b29"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Salad rau là món ăn nhẹ, là sự kết hợp của các loại rau tươi như xà lách, cà chua, dưa leo, trộn với nước sốt chua ngọt hoặc dầu olive. Món này bổ dưỡng, giàu vitamin và chất xơ", "Salad rau", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bao trứng cút là món bánh bao với nhân thịt heo hoặc đậu xanh, kèm trứng cút. Bánh có vỏ mềm, nhân thơm ngon, thường được ăn sáng hoặc làm món ăn phụ trong các bữa ăn chính", "Bánh bao trứng cút", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh cuốn là món ăn làm từ bột gạo, nhân thường là thịt băm, nấm hoặc trứng. Bánh cuốn mềm mịn, ăn kèm với nước mắm và rau sống, thường được dùng trong bữa sáng hoặc bữa phụ", "Bánh cuốn", true, "Breakfast,Lunch", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mận là trái cây ngọt, mọng nước, chứa nhiều vitamin C và chất chống oxy hóa, giúp tăng cường sức đề kháng và làm đẹp da. Mận có thể ăn trực tiếp hoặc làm sinh tố, chè", "Mận", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Xôi mặn là món ăn từ gạo nếp, kết hợp với thịt, lạp xưởng hoặc trứng. Món này thường được ăn vào buổi sáng hoặc trong các dịp đặc biệt, rất bổ dưỡng và dễ ăn", "Xôi mặn", true, "Breakfast,Lunch", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa hộp Milo là thức uống bổ dưỡng chứa nhiều vitamin và khoáng chất, phù hợp cho trẻ em và người lớn. Milo có hương vị ngọt ngào, thường được uống vào bữa sáng hoặc giữa các bữa ăn", "Sữa hộp milo", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ổi là trái cây giàu vitamin C, giúp tăng cường hệ miễn dịch và làm đẹp da. Ổi có thể ăn trực tiếp hoặc làm sinh tố, nước ép, rất tốt cho sức khỏe, đặc biệt là trong việc hỗ trợ tiêu hóa", "Ổi", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo thịt bằm là món cháo có thịt heo xay nhuyễn, nấu cùng với gạo và gia vị. Món này bổ dưỡng, dễ ăn và dễ tiêu hóa, thích hợp cho bữa sáng hoặc bữa ăn nhẹ", "Cháo thịt bằm", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa chua nha đam là món tráng miệng được làm từ sữa chua và nha đam tươi, giúp làm đẹp da và hỗ trợ tiêu hóa. Món này mát, dễ ăn và rất tốt cho sức khỏe, đặc biệt là trong thời tiết nóng", "Sữa chua nha đam", true, "Snack,Breakfast", "https://fdc.nal.usda.gov/food-details/2259793/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("faf19891-525a-4308-9222-992e83de7ce7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá hồi là loại hải sản giàu omega-3, tốt cho sức khỏe tim mạch. Cá hồi có thể chế biến thành nhiều món như nướng, hấp, hoặc làm sushi, mang lại hương vị tươi ngon và bổ dưỡng", "Cá hồi", true, "Breakfast,Lunch,Dinner", "https://fdc.nal.usda.gov/food-details/2684441/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh ướt là món ăn nhẹ làm từ bột gạo, có kết cấu mềm mịn, thường được ăn kèm với thịt heo, chả lụa và rau sống. Món này có thể được rưới nước mắm chua ngọt, mang lại hương vị thơm ngon và thanh mát", "Bánh ướt", true, "Breakfast,Lunch", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mướp là loại rau quả mát, chứa nhiều nước và vitamin. Mướp có thể chế biến thành canh, xào hoặc làm món gỏi, giúp thanh nhiệt, giải độc và tốt cho hệ tiêu hóa", "Mướp", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chuối tiêu là trái cây ngọt nhẹ, giàu kali và vitamin C, giúp hỗ trợ tiêu hóa và cung cấp năng lượng. Chuối tiêu có thể ăn trực tiếp hoặc chế biến thành các món tráng miệng như chè chuối hấp", "Chuối tiêu", true, "Breakfast,Snack", "https://fdc.nal.usda.gov/food-details/1105073/nutrients", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bắp cải tím là loại rau giàu vitamin C và chất xơ, có thể chế biến thành salad, xào hoặc nấu canh. Món bắp cải tím giúp giải độc, hỗ trợ tiêu hóa và tốt cho sức khỏe tim mạch", "Bắp cải tím", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 }
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
                    { new Guid("0135a11e-e823-4191-9393-976d58023a44"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("027dfe23-3409-4faa-9d2f-d5810c24af88"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("03f95bd4-8c18-4c77-8313-8ebb2cca0e39"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0b47b553-bbd0-4a4a-a3e9-05d6f21af7ca"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0b709672-59e5-4594-9ea4-d588c0a89f1e"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0c875989-0de4-4ea3-a78c-99332013e7bb"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0db10c67-333f-45c8-a2f6-5b94c2825cd5"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f1e10da-3b91-428a-a9c6-4f3300a743a4"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1050312d-7c51-41c8-8f90-c5e8d684d658"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("11c3484c-bb32-427c-9b3f-89cd9b3d22fd"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("13ae145d-f2f7-4272-9170-cc3555791c51"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("51061170-597d-4289-a021-1e7dde88331f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("13d1cbab-11b4-44a3-ad8a-9860a3ea83fb"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("140ad999-340a-485d-bf30-22cad0c90c18"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1491e304-5f99-44b9-b559-84916fd49cdf"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("16032cfd-31c4-4faf-8473-bcecfe45683f"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("16abeff3-b7f4-4c78-b0ca-add2e94ae892"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("187735b8-943b-4893-aa0d-51a0b3815923"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1899e66c-b9fe-4d0b-be47-12b3e366454e"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1befcfb4-ece4-4c01-a445-61ed63dd8e3e"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1d346310-6911-45a0-bba9-d4ef51f0756c"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1dbd84ba-3754-465f-8f74-ccf03b5c716d"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e9ec47f-83e4-46c6-a312-9b078b95b10c"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("20523606-4d1a-4328-9e9e-9360f26604f6"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("20fd76f9-1065-4911-beb2-60d0e26a1106"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("21dff2ef-3383-42db-8c34-e6c85d6d5a95"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("21efad51-e160-4cb0-a0e7-186dbddc23c4"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("221a0d84-aebf-471f-ba15-7e9e7ecf01f2"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22a008f6-5695-4da7-b6aa-a14e8fea4375"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22e54a0a-cad7-4ea2-9308-3a864d439bc0"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("23e6f6c8-54f2-4a67-84d7-287cb228bca3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2438b31c-f1c7-49af-b6d8-26b2e0a385dc"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("24a7744a-28c2-4e20-9ad7-3774da51e297"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("27ac0230-ab83-48f1-b59d-9fa7d97823b3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("287c27b2-b38e-4651-b0f5-4e9d164c419e"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2987c9d5-da1c-4c69-8163-8740a0b5fc19"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4edcae53-7e30-42bb-8526-7686355f2268"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2a91d3f9-4eb6-4199-942c-0b1e6e58f905"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2b39447e-74e5-4cc2-a957-4d27a0155f3b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2fc58bd3-66bc-4471-aab2-e2b1cbbb4384"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("309b2de9-0a47-4a06-99bb-d5707d1d1eac"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("31cfb9f5-8535-4e9e-a2c6-367ef24c0009"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("32145861-8cbf-496f-bd59-19154d4a746d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3216daeb-27c8-4323-9a04-753c33a0470f"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3244770d-277d-4df1-a187-2fc36cd5ca70"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("348879c5-ad73-44ed-83b4-44ebc8167c62"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7cd76708-7312-445e-a392-14f0e806a786"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("35c5c28e-fea9-4f5c-9aa7-ccb51d212055"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3648787e-0bac-40a2-8b84-9327f3cf46f6"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("378eaa2b-72b0-43ad-b9de-18601e6cae9e"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37a3850f-8409-4267-96e7-230ceaafea28"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37d56ad5-328f-4dae-85c1-3b42e59d8c24"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("38401b29-eb08-4521-b6f3-492ec16252ff"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2146faae-2e7c-4460-8d81-38f5d313012c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a6ab980-4a5c-4ae0-9f48-b9a2a5e2d8d9"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3be2a97a-497d-43ec-b6f3-f5c0ee442121"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f5b3ab4-b944-4b44-9930-07c16f34f91d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("45a72f5c-3eca-43f6-bfd3-24babfb34fcd"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49b45647-35de-4023-88af-e616150f12d6"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a0a06f8-e7a9-4a44-bd93-a18a6b822f75"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4adef83c-9793-4894-9e6f-163abd1d39b3"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4cb57b4e-bbd6-4912-babc-25ff6aecf490"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2405ffc3-524e-4331-9e68-47a411d7b9b8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4e0a3112-52ea-4598-a68b-718d56ceb5a3"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ea5624d-093f-431a-ad34-14efcfe9fcfb"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ecb0478-9a4f-4d45-88ed-291f4d50fffc"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5002a8c6-21fe-418f-bf68-53994b84a6cf"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("512b785c-cefe-4814-848e-e12d94ffbce3"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("513be78e-83fe-4a13-9545-31939401b309"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("524548d0-1aa2-4bd0-a792-316e51bc1a04"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5278101d-e8ca-4255-9719-e2f2eb591008"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7167f942-dc89-4f29-8022-588373aef45e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("542d3b6d-883b-4aac-87fe-59d24a74fb1e"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("54f04c1b-ea05-407a-9421-413cf50b4902"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("552dce77-fff3-4aeb-84f0-c4ce57f53afe"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5657292e-19d5-4d2f-bd3f-e2a45f9ad934"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("59a6ad2d-258c-4d45-934a-5e77cc20d22f"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b0c1ec2-00d5-4e80-a1d7-15b79953357c"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5c7b0264-398f-40db-8966-aa9cffb2c9a8"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5e63eca1-b752-4bb6-9f4c-bbce0b0aa2cb"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6342c9e6-007e-4287-9ddf-a5b28af3761c"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66a2859f-b958-406d-85a3-db3590780d62"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("68b8f2a1-ca2d-4e62-8143-6163a2c0f85c"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("69e6f50b-e8e7-4ac0-8c58-c49b1c6886c3"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d485e4a-bfcd-4af7-beb0-a6179f0781a6"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e2d6704-454d-4a61-aab9-525f7c93a865"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e81ab8b-d58f-4f6f-93b2-78dbf3975c40"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e88039d-15fa-4405-b237-eb30e2b227ce"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6eb11d43-6cc9-47e7-ae4e-649cf77a41ab"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f97f801-a53d-45f2-8879-d3fac6ab78ab"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6487a532-ff5e-4b77-b408-46c789608de9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6fede5e3-b0b6-48bd-804d-58b65498ca55"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("86d88717-df08-4de6-b86d-870210864b46"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("725b885c-b8dc-439c-be07-7ddb4e696992"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("727e561e-b937-442a-acf6-daa0d7174695"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("73c796dd-0fe5-4be3-8204-650323bd370f"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("73ea90eb-6e33-4d53-8b5a-444f83d6a7f2"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75601f11-ff61-42d5-b95f-a95350dc9d1d"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76f8c536-056b-4689-a3bf-dcc5c29afd97"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7854fa95-550f-4b00-bd95-1a8395b5e7e2"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78982374-5457-4a94-8073-f16cfc71bf31"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78a77ff0-ba11-483b-ab63-28e8d7764af0"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("79518336-f94c-4571-bb39-3e803c4e0e32"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("af036922-79f3-45a7-b562-a6279520c0e6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7a46b29f-18f5-43e4-84d0-5cf7e1ea8bf6"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("faf19891-525a-4308-9222-992e83de7ce7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ae8f4f6-77ed-4296-9a8f-38d332b83466"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7b227956-62f4-4dcb-92b7-92576812be1f"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7e0de975-ef33-444f-8ead-e5d1859e33b1"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("85e621ed-0e0c-4d20-8891-51d311cea4a3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81960e16-d923-446c-b260-966fc88dcfee"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8220b9cb-4ddb-4325-85bb-7e965096170f"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("869dcbd1-a3f5-45be-a6e8-0427ff050d33"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("86b149c3-3fcb-40bc-acf6-3f7675d1f1b8"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a364353c-d589-4a94-9c3b-3038113ea249"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("86fae38c-6f09-417a-8762-18069b9af4c5"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("89082353-ac74-4aef-9162-cad6ec8a1079"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c22d19c-dcee-4e4c-9552-6514cc5a5543"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d7ed248-4c64-4c94-b5f0-7690d11c711a"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9093b917-cf28-402b-8081-dfb1645dac25"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9097501a-4ecc-41e0-9e78-5c19fd4c408e"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("929615ce-feae-4a91-b1fa-2128bea53508"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8382816f-1beb-4804-9698-3b486798b20a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92a6f4c6-2d24-4eb9-b79a-6b926a5cb180"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("94fd68d6-112a-4c4c-b339-11c495f0d5b2"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0292d477-d63b-4904-a83b-2cd8cac39c14"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("951d5ed0-541f-44ba-93fc-4229ba7a7a14"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("96be9dbc-b87e-4833-8a13-40ebf7d64ecd"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("97edcbd4-a7fa-4a21-889b-1e9c789094eb"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99fcef6c-d460-4890-9c14-18d632d9b772"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9a8d9a72-6e94-4493-8071-f70a20584d25"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9daba08e-1dab-44a2-b912-ab5dad06eecb"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0b73a95-b485-4f66-9b00-57330467fedd"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0df78dd-d8f3-403b-8059-912c80438fa7"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a11627de-5e54-455e-8986-2b02d5cd2852"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a3143a16-b54a-41c0-849f-99f6fbb2e8ac"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4b507b4-59cf-4df0-a7b1-bc30fc61ece3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4d7fcb6-0b45-4aa9-995a-013c928a1e19"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4fdbd0b-dce2-42f9-8f3f-05395695c633"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a86b4b0b-b186-428a-b81a-388dfceb1c59"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a87c0572-491d-4b0b-b244-332340d789c4"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a9ceccc9-3c50-41be-9fa3-ce72f8e83ee6"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa8ef70b-1295-4937-b1ae-0800339e2f0c"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("abc5bf1e-49fa-4213-98eb-e9d6293882cd"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a504d882-4f38-413e-bb28-fae1f2787150"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac634f45-c550-47a0-b0ce-44bdb740ffb7"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b0661dbc-2ddf-4403-ae82-db3dc95566fe"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b189ca3b-d66a-4f59-b8f4-4fba9d8d3825"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b2db452c-2e72-4c9a-9f89-e0356f455aae"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b37b01db-7cc6-4e87-9c19-5acd23f5cc68"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b42f7513-3cd2-412a-9e69-293a90100b9f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b473a9b8-1163-4160-bf3c-4116bf8c1b38"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b4815afc-1fc1-471d-88f3-1ec4b13b6cf8"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b60fbf05-adda-4d35-ad2d-db93fc39a624"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("29dfb5da-8818-40ff-bf66-7553521c2161"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b6a1abcd-6507-4978-a93e-f5ad0f3da6d3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c5e3e4ed-0164-4917-a1ce-99679b971a22"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b714f361-016f-43f6-bbc6-6df5652f4d47"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b9667f4b-7891-4522-adbb-42effd3a577d"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b9f37176-7186-4e23-beaa-e14cd2e7f5e9"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba618cd9-5db9-48cd-b8d1-530eccccc95f"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bbba9db3-0dd8-4c0e-a32c-9f32e47f34f2"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bcb5558b-3291-4be2-b21a-a7ea32b82198"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00bc33fe-4cd5-47df-bd94-15ac9f93648c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd25ed13-736e-4984-b2a8-e8d73f82970e"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd5bb721-1239-4237-91fb-0d99c5501d86"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("827829bf-71cd-4865-80af-1457e0091456"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf7452eb-b6bc-4af8-981b-993d088765d9"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c05b52ad-258f-4662-88c5-6bcb7365328a"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c090c483-8d73-4b97-9917-03c54e501f79"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2912d57-9b10-4d60-a245-80c26badbb1a"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2e77f2a-47eb-4e49-b794-7ed593a005ab"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c38c8138-8501-4c08-8b1c-970508adb2c1"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3cc0816-2abf-4540-8d0d-b56c25aa8ad8"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c5f25831-47e3-4926-985e-4b7ed0621b23"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d19d971-88d0-4108-a335-24ac9e1dec50"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c64529c5-96fa-42be-a272-cd1646100bfd"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c98f87c2-22c8-438f-ad52-201d8ba58baf"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cdf71412-af53-40f0-84b6-c94882c7f9ea"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d2cb9512-07eb-41f8-845d-1463c73dfbd3"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d34c4fb3-132b-4302-93e0-1112720c2d08"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d424c6c2-6694-4fe1-9013-7bdd591c21eb"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d46e3a99-abf8-4053-8ca0-de20dccab40b"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b8500af-d730-4138-9617-cba352faed4a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d4ac96d0-5e5d-40c2-a86b-6b9cd0c4e23b"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d4e22dcb-3ae2-4066-82ce-c0871de9fd63"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d4e87f73-9d1a-48f6-b4a6-677b5491b666"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d74b51f4-bbbe-4307-881b-976a1a3dc219"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d84daa6e-0b53-402e-bb05-b200ed564dba"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8c23b4a-d8fa-42ed-b436-0828dd9b1674"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d941719a-5a6c-4904-aa4f-4b82e01aafba"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d94b2778-cda2-4b0f-be2f-0e547b1cf1f1"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d99e7c5c-011b-4087-b3c2-03cfafb93e55"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dbd836df-ebe2-4c3c-b76a-d76c12db74b6"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2ae82bfd-34db-4928-bfee-b60f4aec4460"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("de665c69-97cd-40a4-9193-111a4641f196"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("de6e555a-d1e6-489f-896b-e24649206f05"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("de77cd57-295f-48d1-805c-6ae52fb95f0d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("deac6c02-f11d-4d20-bca7-dfe98bd8cbef"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dfaab39f-58fb-4291-93d8-2ec9ec84ea26"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1225d22-a012-4a51-89b3-a8de54a9dd8a"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1625074-0cc1-4508-8cff-9dba30d5188f"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e255ba45-07b9-49ec-827b-c22fa748eb54"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e2742fb0-009b-4a14-be64-cc7b80bbef50"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e3f20b53-ac00-4b6b-ae5c-eca9eb4351f7"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ed85dc2-7654-4c48-81f9-19946a73f71d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e4f147af-af43-45f8-96da-d0a905df31b0"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e50fdb8c-46d1-4b38-b84d-00858929398b"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e52a2708-3316-4a14-8e29-5bd7a2f75aae"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e613ecd0-d783-4478-9d63-d74993c713f2"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e6c74868-6485-4b90-86a0-a08f6b1f96fd"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e8287553-f016-46b0-9ed2-653bd021efa6"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e85a03c2-c615-411a-a320-1d6ef6d79821"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb6ff867-c9cf-44ed-82be-ce88a3089afa"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec447f11-a8d8-48fd-a97b-4c51f6acce5d"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f1a62e51-f310-40b8-9bfc-cbfddc81e90f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2a953c3-3505-4117-b828-995824627b05"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f4779f58-34cb-4e3e-b7fe-96e1b4b85b14"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3dc2fa80-ab87-4e26-907b-3516611371b8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f98795c6-2e1c-4e6d-a12e-fe3cbe39d331"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc2e6b96-8de5-49f6-9303-57ee17f06554"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc310b26-663c-413b-ab1b-b2580ca3d5ad"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fd12c36c-8cdb-465d-bbbf-e4d06b159971"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "CertificateId", "CertificateName", "CertificateNumber", "ConsultantId", "CreatedAt", "ExpertiseId", "ExpiryDate", "ImageUrls", "IsVerified", "IssueDate", "IssuedBy", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("3b939015-099f-4e2c-87dd-841e0e124b81"), "Giáo viên thể thao", "CCH-2025-531", new Guid("77db6560-34ad-44b5-86ab-c74f9033d5f9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c5d7a490-e25e-4ae6-a6db-2d637e6630de"), new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_1.jpg?alt=media\\u0026token=331a36a4-82bb-4102-b224-da8cc1067efb\"]", true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ACSM", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5062b130-65d2-4d4b-9c1e-afa4f0a444d5"), "Chứng chỉ Yoga toàn thân", "CCH-2024-121", new Guid("9a40351b-954a-4697-ac3c-c2e35e89702c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("67188399-9f09-4b74-9eb3-31ff82734850"), new DateTime(2029, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_1.jpg?alt=media\\u0026token=331a36a4-82bb-4102-b224-da8cc1067efb\"]", true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yoga Alliance", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("62328b1b-2e26-46b8-9dbf-c4eddd0129de"), "Chứng chỉ tư vấn dinh dưỡng", "CERT-2025-002", new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ad55299-b566-47e8-a9a0-1997e893e153"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_1.jpg?alt=media\\u0026token=331a36a4-82bb-4102-b224-da8cc1067efb\",\"https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_2.jpg?alt=media\\u0026token=25015de2-7cdc-4a9f-9355-0c7b4b99fd85\"]", true, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monhealth Academy", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6c48b7d1-d18c-4f77-8a3c-a333851f0869"), "Chứng chỉ giảm cân VICN", "CCH-2024-033", new Guid("8d8827cc-904a-4de5-8261-65acdbcb168d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c32b7429-13df-4aa0-b32d-705d1050de5f"), new DateTime(2029, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_1.jpg?alt=media\\u0026token=331a36a4-82bb-4102-b224-da8cc1067efb\"]", true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Academy of Nutrition", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("888cbe07-c005-415c-9806-36f74b9e530a"), "Chứng chỉ thiền", "CCH-2025-042", new Guid("96818b5d-41a2-436b-841a-4aff36116b95"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d762370d-3b36-45f6-ae15-bbe4c2b9bf8a"), new DateTime(2028, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_1.jpg?alt=media\\u0026token=331a36a4-82bb-4102-b224-da8cc1067efb\"]", true, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "National Strength and Conditioning", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bbe291dc-c0ee-4cde-a9c1-08c1285e39ac"), "Chứng chỉ hỗ trợ tâm lý", "CCH-2023-751", new Guid("a0385565-b5f4-4ad3-915e-b95558c00f7d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("63100127-6781-4385-a1df-b21cae459bdb"), new DateTime(2029, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_1.jpg?alt=media\\u0026token=331a36a4-82bb-4102-b224-da8cc1067efb\"]", true, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "American Council on Exercise", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("de51877b-cba9-4ea7-b031-615e2e70778b"), "Chứng chỉ thể hình vóc dáng", "CCH-2025-001", new Guid("6bce17d4-909f-4fad-b125-0074793f22bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44d9ffb3-a8b8-407b-975c-99e6f6146bc9"), new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_1.jpg?alt=media\\u0026token=331a36a4-82bb-4102-b224-da8cc1067efb\"]", true, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NASM", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f1266239-015e-4eb1-838e-4fed5c671752"), "Chứng chỉ sức khỏe tổng quát", "CCH-2022-040", new Guid("0a9dad22-7b87-408b-a377-71dbbe004abc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c6a7d90-1c16-44ae-9b2a-b3addfe55dbc"), new DateTime(2028, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_1.jpg?alt=media\\u0026token=331a36a4-82bb-4102-b224-da8cc1067efb\"]", true, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mindful Schools", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "ChatId", "ConsultantId", "CreatedAt", "LastMessage", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("9b4dc3a1-5076-48f0-b91d-3d964ff1aa7d"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 20, 23, 54, 39, 905, DateTimeKind.Local).AddTicks(147), "Tôi muốn hẹn lịch tư vấn vào tuần sau.", new DateTime(2025, 4, 20, 23, 54, 39, 905, DateTimeKind.Local).AddTicks(147), new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2") },
                    { new Guid("e7a3f1bd-d891-4a79-9086-9f3e79cf8e01"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 20, 23, 54, 39, 905, DateTimeKind.Local).AddTicks(147), "Tôi cần tư vấn về chế độ ăn cho người tiểu đường.", new DateTime(2025, 4, 20, 23, 54, 39, 905, DateTimeKind.Local).AddTicks(147), new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87") },
                    { new Guid("f04b47df-8e5a-4bfa-8519-0ed5f9b1c7ea"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 20, 23, 54, 39, 905, DateTimeKind.Local).AddTicks(147), "Bạn vui lòng cung cấp thêm thông tin sức khỏe để tôi hỗ trợ tốt hơn.", new DateTime(2025, 4, 20, 23, 54, 39, 905, DateTimeKind.Local).AddTicks(147), new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b") }
                });

            migrationBuilder.InsertData(
                table: "ConsultantBanks",
                columns: new[] { "ConsultantBankId", "AccountName", "AccountNumber", "BankId", "ConsultantId", "CreatedAt", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0467cf6c-2a5d-47dc-bc04-cb2dea296906"), "Văn Hữu Toàn", "vanhuutoan27", new Guid("1b4e6597-7d56-4b6d-833d-c17f5755aad1"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1819cf58-52db-49ee-8f91-752de431285b"), "Văn Hữu Toàn", "0792766979", new Guid("1b4e6597-7d56-4b6d-833d-c17f5755aad1"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4e6f616b-b78a-4faa-8e4f-fe228101ff60"), "Văn Hữu Toàn", "28497112029", new Guid("1b4e6597-7d56-4b6d-833d-c17f5755aad1"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c46c1128-4bf7-4c30-a465-988f3d736bca"), "Văn Hữu Toàn", "1890445466", new Guid("936666c3-12f6-406b-9de9-8367233aa6ba"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "DishTypeFoods",
                columns: new[] { "DishTypeFoodId", "CreatedAt", "DishTypeId", "FoodId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("006288c9-69dc-400a-9d7c-9a9ddcf9ebb9"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6106), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6107) },
                    { new Guid("008efd53-d878-46d0-9b58-985d43a9e7ee"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5864), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5865) },
                    { new Guid("00ca3483-a8b0-4c77-ba45-bd8d3bc123b5"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5926), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5927) },
                    { new Guid("013bd5ae-294e-49b2-a8ee-e6e308b0a125"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6002), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6003) },
                    { new Guid("060a9c4b-1ca3-4769-8d8b-b2b7789c308f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6109), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6109) },
                    { new Guid("084903e7-ec3a-4aa8-80d2-3d9cdbffbbbe"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5938), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5938) },
                    { new Guid("08c53ef8-e41c-45cb-b7eb-2ffac4dce33a"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6089), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6090) },
                    { new Guid("08f41a10-2415-43a5-b1ab-769d2300c45d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6588), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("2146faae-2e7c-4460-8d81-38f5d313012c"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6589) },
                    { new Guid("09c69318-5fa7-4248-9b4e-32d1943da556"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6430), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6431) },
                    { new Guid("0a4cf9dc-0416-4c21-a3ec-e7d9dfaf3031"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5993), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5994) },
                    { new Guid("0a7e1b80-0c5a-482d-9f70-5a8367b6a120"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6529), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("4edcae53-7e30-42bb-8526-7686355f2268"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6530) },
                    { new Guid("0b6db4f5-29a9-41ec-a22a-c764b4261e76"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6334), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6334) },
                    { new Guid("122acc4b-0ed6-4f56-821c-5d7a1eddc6b3"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6022), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6022) },
                    { new Guid("12629255-24da-4ece-b247-72c0c09cc5e6"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6052), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6053) },
                    { new Guid("126c34e7-62eb-4cc0-b411-f7bc6fc00285"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6532), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("0292d477-d63b-4904-a83b-2cd8cac39c14"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6533) },
                    { new Guid("14aa3f95-9cb6-47a0-8f55-4709b94d82cb"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6484), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("2ee163f7-4463-44ec-b9e2-8a409c112db4"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6485) },
                    { new Guid("1504f8ba-4205-46e1-9c39-6f1396f8d096"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5954), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5954) },
                    { new Guid("1774a251-b819-47e3-91d1-228c239f1b57"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6277), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6278) },
                    { new Guid("1782dd67-2099-4df4-9042-678f42564143"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5867), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5879) },
                    { new Guid("191ee092-0c67-413c-a2ff-3c380383f6e2"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6385), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6385) },
                    { new Guid("1a1cbde7-2236-478f-9204-4093e9bfbba9"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6317), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6317) },
                    { new Guid("1a5d904c-71d5-4b34-9bff-6d6f334aaa70"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6240), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6241) },
                    { new Guid("1e155997-85e1-4d89-83da-9b1a6572d443"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6594), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a364353c-d589-4a94-9c3b-3038113ea249"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6595) },
                    { new Guid("1f88dc66-8ca9-4da6-8010-0b91761698e0"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6415), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6415) },
                    { new Guid("21ae4965-d9a1-41f6-a947-f34f1007c1fe"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6076), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6077) },
                    { new Guid("265c22b7-8291-44c7-9e87-ee89b7bfae75"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5850), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5850) },
                    { new Guid("273800ff-4431-469e-8273-60dae420652f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6154), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6155) },
                    { new Guid("27a240c4-8385-4994-b025-4850f8fecc32"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6441), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6442) },
                    { new Guid("27ce7cff-8b55-4592-96c2-806df48fe0a6"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6125), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("faf19891-525a-4308-9222-992e83de7ce7"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6125) },
                    { new Guid("2a304585-230a-4328-b895-9b1ffb504dcb"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6524), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("29dfb5da-8818-40ff-bf66-7553521c2161"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6524) },
                    { new Guid("2a8ce90a-cddc-4c06-a827-844031afb9f3"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6363), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6364) },
                    { new Guid("2aec4afa-c061-4506-aadf-6e905d28d676"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6138), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6138) },
                    { new Guid("2e0c48be-1d81-4705-ba85-db9f1f86027d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5896), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5897) },
                    { new Guid("2ef15069-6e2f-44e7-9088-063a8ab4e4bd"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6024), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6025) },
                    { new Guid("32aa5a2b-0197-4088-a631-7d05128ab14d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6457), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6458) },
                    { new Guid("36c86960-4a43-43c6-958d-155c9e93c507"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5935), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5935) },
                    { new Guid("37e3022f-215b-4a05-90c2-5757395b51f8"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6519), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6519) },
                    { new Guid("3ab675f4-7047-4c54-9897-bb32adcd06a3"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6243), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6244) },
                    { new Guid("3b5e96df-14f1-4875-86b6-3766c6730ad6"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6562), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6563) },
                    { new Guid("3c92270d-fc56-44f6-aa7d-f6d6fba82c10"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6450), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6450) },
                    { new Guid("3d8f407f-e1c1-46af-89c7-a178559e0155"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6548), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6549) },
                    { new Guid("3e08a809-e101-4ea3-97ba-628a45f4c1c5"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6192), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6192) },
                    { new Guid("3e942a3c-6310-4d0a-9af8-fe763508b079"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6513), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("90a605b6-843d-4cc1-8fe7-a016c76ee29c"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6514) },
                    { new Guid("41d0b1c5-4adb-4979-b0f6-dc39487f361e"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6060), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6061) },
                    { new Guid("42a39346-3e6c-475b-b49e-a22115e27289"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6387), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6388) },
                    { new Guid("44cee878-a61b-4576-b4f8-5cd8735a1218"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5948), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5949) },
                    { new Guid("4531c0c1-db64-4672-9602-5613bbd81cce"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6374), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6375) },
                    { new Guid("495f936f-b3c1-4b08-bee8-53f1c6ecf871"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5861), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5862) },
                    { new Guid("4a71fb78-818e-4956-b5f1-20ec6fbed176"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6254), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6255) },
                    { new Guid("4b4f3639-6deb-493d-adb5-4f77649142bc"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6167), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6168) },
                    { new Guid("4c7d881a-603f-4334-912b-bc764c2bb6aa"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5840), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5841) },
                    { new Guid("4d0565fb-f164-4da0-8c0d-f0ffdf15a1cb"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5856), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5856) },
                    { new Guid("4eb6c88d-2650-4a52-82ca-a4e0cda437e0"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5924), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5924) },
                    { new Guid("50a27f1d-4024-4152-b28e-3ef56f9d6222"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6008), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6009) },
                    { new Guid("52158ace-b81d-49d0-b7ca-77cf5f645e66"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6551), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6552) },
                    { new Guid("534392cc-bf8b-4646-bd58-b6f1f00d2a91"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6399), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6400) },
                    { new Guid("53826953-fd2b-46d6-adcb-40b5cb22f773"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6426), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("6487a532-ff5e-4b77-b408-46c789608de9"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6426) },
                    { new Guid("53eb1c9c-b543-4331-a0b7-7a8ed5f2d67a"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6057), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6058) },
                    { new Guid("546fbaec-8468-4a5f-9134-0144913e192e"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6213), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6214) },
                    { new Guid("565d28ce-8315-4818-a0ec-18353d678948"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6510), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("eec3d874-6331-4e33-bbe6-bf0cc4335b29"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6511) },
                    { new Guid("585c4466-c046-4767-88f1-2ce5276e6406"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6019), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6019) },
                    { new Guid("58976a7b-a6e3-4c5e-8c59-62b8739dab23"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6128), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6128) },
                    { new Guid("58b52c0e-2707-4a06-8463-40c22531b18f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5893), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5894) },
                    { new Guid("595fc117-5dc5-43a4-ae95-673ccd4fe129"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6577), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6578) },
                    { new Guid("5a4af248-3742-4e5f-b9f6-c61df6097cd7"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6049), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6050) },
                    { new Guid("5ad790c8-0b66-4207-a8cc-0197a1914549"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5932), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5933) },
                    { new Guid("5b175b0f-208c-434d-854c-9b4bc14a0030"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6478), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6479) },
                    { new Guid("5bb9d19a-6133-4345-97d6-771d46945544"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6133), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6134) },
                    { new Guid("5e2954d7-b03d-412d-a92d-cf2846197e11"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5921), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5921) },
                    { new Guid("5e881a13-1c77-49c0-a9fe-66d4aacd03de"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6294), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6295) },
                    { new Guid("5fb3c605-2edf-43c9-9eca-13f663db7a97"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6357), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6357) },
                    { new Guid("6400c648-0e2a-4716-9ee8-6c74bcdf729f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6591), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6592) },
                    { new Guid("654c8a0c-b8fd-4f4a-b442-6406456f3b9c"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5962), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5963) },
                    { new Guid("65f4a246-e89b-4c8d-a5ac-f3c5830fbf2e"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6303), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6304) },
                    { new Guid("6730bca9-848e-4ece-a4bb-4557623e0448"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6073), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6074) },
                    { new Guid("6839b719-c292-4a69-b339-390678d13077"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6436), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c5e3e4ed-0164-4917-a1ce-99679b971a22"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6436) },
                    { new Guid("6a0bf319-5d4d-4ecd-91c0-a86d08e9b3dd"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6566), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6567) },
                    { new Guid("6a8f435e-de16-4377-a9a0-1e25c425228b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6382), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("7cd76708-7312-445e-a392-14f0e806a786"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6382) },
                    { new Guid("6b6b15e5-c966-4539-9b55-285ec5f502f1"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6447), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("7167f942-dc89-4f29-8022-588373aef45e"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6448) },
                    { new Guid("6ce9e24d-d436-4bd1-9141-7c2592eb2552"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6178), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6179) },
                    { new Guid("6e5de85a-86d8-4db0-a516-306793e05654"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6036), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6036) },
                    { new Guid("704f259b-41db-4887-b54d-97cb306ddab2"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6366), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6366) },
                    { new Guid("72656fd5-f51c-442b-ab6b-e4d34f2b1c77"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6041), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6041) },
                    { new Guid("730a6a81-4fb2-4e04-9efd-bf70c1b0dce3"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5889), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5889) },
                    { new Guid("73147c36-c547-4528-9235-63590508c88e"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6481), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("a988cc73-072e-4af1-9b53-55fbf0f4fe79"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6481) },
                    { new Guid("77882c60-4d15-4598-84b2-339141dead12"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6148), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6149) },
                    { new Guid("7853ea66-e606-43b8-b1c6-b4214cda358d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6569), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6570) },
                    { new Guid("7866133a-0b2b-439e-9470-2d3915a29b7a"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6393), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6394) },
                    { new Guid("78e7cba6-fd65-479a-b2d5-212809416033"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6543), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6544) },
                    { new Guid("79d52c32-1307-4bff-9c7c-1880d2d1b4c6"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6151), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6152) },
                    { new Guid("7b4002c8-9268-499c-8fd1-fd27812ff37d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6409), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6410) },
                    { new Guid("7ce4c12c-8425-4517-8ab0-2d6a1655c18a"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5844), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5845) },
                    { new Guid("7cf85832-be8a-48be-85dc-12fe4086bbac"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6257), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6257) },
                    { new Guid("7d4d5f51-e593-42f3-a19c-1e3cbc510011"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5929), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5930) },
                    { new Guid("7de3ae2a-91d3-4597-9d48-b514d581a1ec"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6341), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6342) },
                    { new Guid("7e22289c-1354-411b-856b-90a33614969d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6368), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6369) },
                    { new Guid("7e960747-6733-4efb-b7e3-4144ad18d530"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5956), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5957) },
                    { new Guid("7ebf1358-cbe3-431a-9afb-297dc4ac2d9f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6402), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6402) },
                    { new Guid("801447a3-cecd-4003-a957-082bebb54df4"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6027), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6028) },
                    { new Guid("825c089e-f362-4f96-becf-52271215dc61"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6377), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6377) },
                    { new Guid("826387b0-93be-4a19-8a9d-e52e1a3be47a"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6011), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6012) },
                    { new Guid("827f83e6-cbe1-47c7-bd17-8a1e0443d185"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6417), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6418) },
                    { new Guid("83453a9c-ce3d-49ed-8969-da4cbd75741f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5905), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5905) },
                    { new Guid("844db805-2e4e-434f-9316-340850f1d4b0"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6328), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6328) },
                    { new Guid("85058e55-4f95-42f6-84fc-a0a7576ac824"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6602), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6602) },
                    { new Guid("85989f75-e3b4-4016-9126-9f3e51aa980b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6468), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("00bc33fe-4cd5-47df-bd94-15ac9f93648c"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6468) },
                    { new Guid("869069a7-77a8-4d02-9d12-88d48d9d4a76"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6610), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("a504d882-4f38-413e-bb28-fae1f2787150"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6611) },
                    { new Guid("86d05513-b8f7-41ab-9b0c-c9a9700e4fc6"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6194), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6195) },
                    { new Guid("8886c8b4-dec1-47ed-b84f-095a8dccb932"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6580), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6581) },
                    { new Guid("88c2a4b0-4c7b-445a-afd7-01179552b7c6"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6122), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("faf19891-525a-4308-9222-992e83de7ce7"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6122) },
                    { new Guid("8af75921-3e7b-4388-b80e-d8feb3cb95e4"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6507), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("01e60ae4-ff69-44d6-b4fd-aaf916e3a7e5"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6508) },
                    { new Guid("8d464810-dcce-4eb4-8268-d359163adf11"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6181), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6182) },
                    { new Guid("902531f4-b7a1-487e-8920-7c6938140d8e"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6280), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6282) },
                    { new Guid("9062c6fd-59ac-433d-8a9b-d0003eaf2679"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6360), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6360) },
                    { new Guid("921ed5a2-5d89-4506-b0a1-c3407169ff07"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6322), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6323) },
                    { new Guid("92676174-c11d-4931-b2a1-6b2de50ab5dd"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5899), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5900) },
                    { new Guid("92d1a57b-8412-4451-a35b-b25f6a2bb7b4"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6284), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6284) },
                    { new Guid("93818b21-2450-473a-8744-432107ebdfb8"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5999), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6000) },
                    { new Guid("948994f6-9c96-4595-a0f8-cfe42a72ce33"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6170), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6171) },
                    { new Guid("948a1a88-ebde-42df-a38f-97afe553a113"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6130), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6131) },
                    { new Guid("94dbf43e-07dc-4d91-9af1-46226ebace3e"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6439), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6439) },
                    { new Guid("977c5213-6834-4192-a6c5-0f19c110f8a2"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6146), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6146) },
                    { new Guid("984a6832-2479-4bf4-a378-223ab563db31"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6084), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6085) },
                    { new Guid("9a59075f-931e-4de7-a662-ab9a6ab930e4"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5910), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("86d88717-df08-4de6-b86d-870210864b46"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5911) },
                    { new Guid("9de5b8b5-2846-4783-9953-e951ea5b55d2"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6287), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6287) },
                    { new Guid("9e6f1d04-ce83-497f-8f2d-2fee712efbea"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6114), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6114) },
                    { new Guid("a1b9b539-b16d-459b-9bbb-063afdf18272"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6433), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("827829bf-71cd-4865-80af-1457e0091456"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6434) },
                    { new Guid("a280e305-79d0-4797-babd-9332956d6d13"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6330), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6331) },
                    { new Guid("a3eaf179-d2df-401a-b023-0ce04caca46c"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6586), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("2405ffc3-524e-4331-9e68-47a411d7b9b8"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6586) },
                    { new Guid("a4405d74-4486-4363-abc6-bfe7810bf6a4"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6140), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6141) },
                    { new Guid("a4a0934a-63bb-40b8-ba9e-4472b5b36e9a"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6173), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6174) },
                    { new Guid("a664a0c0-03b8-4a9c-80de-ff3db69b7461"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6095), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6096) },
                    { new Guid("a82c6f17-4548-4977-a31c-a055f2ad7ceb"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6470), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6471) },
                    { new Guid("a862dce1-8e76-4317-a588-56aa963e03a5"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6092), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("51061170-597d-4289-a021-1e7dde88331f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6093) },
                    { new Guid("a9742b61-936b-4f00-ad51-0a55112ecea9"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6351), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6351) },
                    { new Guid("ab714c7c-691d-4ab9-8d60-b59ab0cd8aa5"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6616), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6617) },
                    { new Guid("ad2e6235-869b-441b-af1a-5ffc50db9cfc"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6081), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6082) },
                    { new Guid("aefc452e-4568-4d38-8255-43e4a9bbbdfe"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6200), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6201) },
                    { new Guid("afe3bf2f-0644-46a2-9b4d-fc8aefa00381"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6055), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6055) },
                    { new Guid("b22262d3-2b8d-47e4-b596-0815b23020f1"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5951), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5952) },
                    { new Guid("b2230c3b-dcd2-451b-beee-d1f3fb5543f1"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6344), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6345) },
                    { new Guid("b29e30c2-0b16-4423-b756-96b363844ea9"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6189), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6190) },
                    { new Guid("b43c47a2-412a-45e8-8748-4021d2c1218c"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5913), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5914) },
                    { new Guid("b45804e3-b511-4ae2-bdce-b8ec47376c22"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6538), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6538) },
                    { new Guid("b47319c3-fbb6-4ce9-b969-53a9d4876d6d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6203), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6203) },
                    { new Guid("b4e290d0-e391-4e77-980d-9b88292431fe"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6100), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6101) },
                    { new Guid("b5001b86-2a69-4753-979d-b55de91a47ad"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6207), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6207) },
                    { new Guid("b50c5e90-c891-4aef-91aa-a37f26b11908"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6300), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6301) },
                    { new Guid("b571b179-86d4-483d-a466-f6c9af78353b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6465), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("af036922-79f3-45a7-b562-a6279520c0e6"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6466) },
                    { new Guid("b6e42213-6e9f-45bd-b2e8-3e21f84e2bd8"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6444), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6445) },
                    { new Guid("b7fc3b5a-1ec6-4bcb-863a-e03ce1b15ac0"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6311), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6312) },
                    { new Guid("b8f671e8-f794-4f2b-89f2-bb37e583147d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6347), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6348) },
                    { new Guid("bab7c2d4-ab6d-4b44-843e-fd97cd5b244a"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5959), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5960) },
                    { new Guid("bb6fe38c-bd70-442d-8cc7-9873c2d88cee"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6079), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6079) },
                    { new Guid("bc307383-92bf-4ee6-bd54-cb6a570f15f6"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5943), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5943) },
                    { new Guid("bcf17441-c665-41ca-a1ba-7bfb8093c4cd"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6157), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("7b8500af-d730-4138-9617-cba352faed4a"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6157) },
                    { new Guid("bd424d15-f451-4211-bdde-87e5bd453384"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6030), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6030) },
                    { new Guid("bd8f2173-d484-4990-bd1e-081e1d6630d1"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6583), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("8382816f-1beb-4804-9698-3b486798b20a"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6584) },
                    { new Guid("be40ea4b-39b5-43d2-96d9-0adfe55c1ab7"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5990), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5991) },
                    { new Guid("be90de31-b1b0-449f-90c1-5ecd7782d58a"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6005), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6006) },
                    { new Guid("bee91ab6-eb5e-4395-811e-cdb882a9edbf"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6460), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6460) },
                    { new Guid("c11c6d77-4b75-4006-b6a3-54bec53ddf26"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5945), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5946) },
                    { new Guid("c21b3598-8743-4639-aacd-c4e77e1e90e3"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6033), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6033) },
                    { new Guid("c2699ee9-7912-478d-ad66-12e496c223b7"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6043), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6044) },
                    { new Guid("c38a5544-0a19-48a7-8845-af1f7e917c5a"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6391), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6391) },
                    { new Guid("c3aba123-2386-42a5-9971-0264a9f4ca66"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6371), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6372) },
                    { new Guid("c48d1b15-14e0-4c83-bc34-7a76ea6324f4"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5996), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5997) },
                    { new Guid("c4d059af-8dac-4d42-a711-d4cf618a26cb"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6396), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6397) },
                    { new Guid("c53f9a77-4c4d-448c-ba21-f0f2c5b23606"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6065), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6066) },
                    { new Guid("c57c9dbf-8c60-4614-a31f-5ed1482188a9"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6098), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6098) },
                    { new Guid("c583f50f-6dab-4252-88ef-043b9f9e34de"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5853), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5853) },
                    { new Guid("c6d31879-c1d2-402c-ab9e-bae5e25acecf"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6268), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6268) },
                    { new Guid("c77d5ecc-ff9a-4479-9e2c-c2a69226162f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6407), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6407) },
                    { new Guid("c7d7e32c-daab-4932-893f-af821b42d682"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6412), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6413) },
                    { new Guid("ca5bda23-7e2b-4c78-9839-182f90558e13"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6186), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6187) },
                    { new Guid("cb42c760-1522-4351-95a5-ac5de567ffd1"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6535), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6536) },
                    { new Guid("cbd85cf0-9303-4b0f-b741-64a191ba9edf"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6103), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6104) },
                    { new Guid("cc3198fb-afca-420c-9f3c-53a0a25de4f5"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6557), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("43d635e2-6f0c-4385-83d8-fedfd479d356"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6558) },
                    { new Guid("ccf53f00-1aaf-42c1-9129-23dc94e5ecf6"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6119), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6120) },
                    { new Guid("cdd29e40-4d47-4f36-92c2-85fe18860eed"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6454), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6455) },
                    { new Guid("cdf4454d-52b7-4424-927a-ff438f353c38"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6164), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6165) },
                    { new Guid("cee9d9dd-327f-4d38-a50a-8a915b7bc4d0"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6071), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6071) },
                    { new Guid("cf4c0606-f103-4583-85e2-021f0d6b3ec0"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6116), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6117) },
                    { new Guid("d021c4f7-9331-4094-b86a-634a4873c66c"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5918), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5919) },
                    { new Guid("d0986427-9b8b-40f6-bbe4-675ae7c2a60e"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6197), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6198) },
                    { new Guid("d38d2f20-8970-48a3-88ac-e09f15a0d5d9"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6473), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6474) },
                    { new Guid("d3a1b912-1816-48a3-917e-c8db317edda9"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6143), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6144) },
                    { new Guid("d3e0f2ba-0add-42e6-9174-b414b132bf87"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6613), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6613) },
                    { new Guid("d56f8829-03dd-4701-903a-11f66240f22c"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6314), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6315) },
                    { new Guid("d5fc51b9-beb7-4f07-b83a-32837a03cad6"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6554), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("982d8f3e-f517-4bd2-87a8-48329fc9eb91"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6554) },
                    { new Guid("d70fdee7-e81a-4833-b16e-1de42002170a"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6289), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6290) },
                    { new Guid("d723668b-b443-4312-829e-9fdf652e3402"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6423), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6424) },
                    { new Guid("d7bbfac4-89f3-46ba-8f4c-351a173da58e"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6420), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("2ae82bfd-34db-4928-bfee-b60f4aec4460"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6421) },
                    { new Guid("d84bc3bb-92b1-47b0-ad0f-5df4b5e5c64f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6016), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6017) },
                    { new Guid("dca6da3a-a4a8-414f-8d4c-78f92db88d43"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5907), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5908) },
                    { new Guid("dcaaec3c-afdf-4f02-9d56-93fbdbf0b793"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6162), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6162) },
                    { new Guid("defec389-c7d1-4180-b711-6c0a0cc470d3"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6619), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("85e621ed-0e0c-4d20-8891-51d311cea4a3"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6619) },
                    { new Guid("e052442e-a7fc-4c39-aab3-13ca0e4959e4"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6575), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("e370081a-c0a6-4c00-b01c-7c52f953b7f1"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6575) },
                    { new Guid("e1af7dda-7bb5-45c1-9e25-d28b4bb24ba7"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6462), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6463) },
                    { new Guid("e4610ae7-f8f2-43b3-b25f-5fe74547bffb"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6516), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6517) },
                    { new Guid("e6f4c606-f6d7-4385-8875-1f5fd53a013d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6265), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6266) },
                    { new Guid("e74770ee-6575-4c95-9e11-b4ba61336534"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6176), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6176) },
                    { new Guid("e81ffb7b-fb2e-4171-affb-1053e1fb0030"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5858), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5859) },
                    { new Guid("ecffc87d-3edd-4d63-b367-18bf6daf0c3f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6251), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6251) },
                    { new Guid("ed555591-a089-4d8b-b5ef-7da464bf5d9f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6068), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6068) },
                    { new Guid("ee095106-172a-4dcb-aef8-d3f6ab16559d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6046), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6047) },
                    { new Guid("f024cadc-ecbf-4269-8244-782735a2077f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5902), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(5903) },
                    { new Guid("f26f8a7a-6785-40dc-8783-a734546dff51"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6297), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6298) },
                    { new Guid("f6231cf9-eea7-4eed-84c4-bf5f9bfed5a9"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6607), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("3d19d971-88d0-4108-a335-24ac9e1dec50"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6608) },
                    { new Guid("f72dc4f5-3c10-43dc-9af4-91309420ea37"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6260), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6260) },
                    { new Guid("f770a8a6-af8c-4160-8b6e-6fd2ce755ea6"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6526), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6527) },
                    { new Guid("f814e049-13dc-403f-a4a3-e8e23ae1503e"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6560), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("8ed85dc2-7654-4c48-81f9-19946a73f71d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6560) },
                    { new Guid("f8506178-0f27-40fa-a9d1-bd3e33eefb44"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6272), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6273) },
                    { new Guid("fa51910c-cd9c-4c22-b756-c2520d4ff302"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6308), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6309) },
                    { new Guid("fa77ad01-84ea-4723-b52c-39059a8ec57d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6604), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6605) },
                    { new Guid("fac89677-8308-4538-8fbe-965742b1abd9"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6247), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6248) },
                    { new Guid("fe5ec169-4045-4362-939f-9a6ea96a094d"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6599), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6600) },
                    { new Guid("ff59d2e8-edfd-451b-84d8-eeca703e3cee"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6540), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("3dc2fa80-ab87-4e26-907b-3516611371b8"), new DateTime(2025, 4, 20, 23, 54, 39, 904, DateTimeKind.Local).AddTicks(6541) }
                });

            migrationBuilder.InsertData(
                table: "FoodAllergies",
                columns: new[] { "FoodAllergyId", "AllergyId", "CreatedAt", "FoodId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("06aff42f-e9b2-4ac2-9c6d-7032f1660217"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), null },
                    { new Guid("0ca41aa0-264a-4aaf-a19e-0d7b0691eac1"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), null },
                    { new Guid("0ede14a5-c5f9-4b4e-80a5-f6efc112054d"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), null },
                    { new Guid("0f406322-0840-4e55-8094-47fd5a63fd0c"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), null },
                    { new Guid("10f66e54-a3c5-488e-b2c1-d70b38162b58"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), null },
                    { new Guid("1cd2030d-7a58-4a8c-a9e0-1133fda824c6"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), null },
                    { new Guid("230d99b8-1952-4ac0-a5d3-9bff39a2776e"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), null },
                    { new Guid("26a0942a-3399-4e33-9715-01444b69cbdb"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), null },
                    { new Guid("2a09af7f-9763-42cf-a064-31bae4e4da07"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), null },
                    { new Guid("2be04448-ae79-4308-aaca-1699838364ad"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), null },
                    { new Guid("2c24bf92-4695-453a-a456-2ccec66e0cfc"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), null },
                    { new Guid("375b25f6-1649-4021-8741-65d4ee7ce92e"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), null },
                    { new Guid("3c0d18d4-086d-4ea2-b207-8055beb57058"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), null },
                    { new Guid("3c2e34be-37d8-450e-a529-5fe21be964bf"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), null },
                    { new Guid("4aceff13-8b9c-414f-98c2-2ccf716dc765"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), null },
                    { new Guid("4dffa29f-1d39-4c0f-b0e8-896fc3d1a598"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), null },
                    { new Guid("51b85f02-6f45-4c5a-b053-ede1b77432eb"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("faf19891-525a-4308-9222-992e83de7ce7"), null },
                    { new Guid("53a8083d-16c0-4a00-a5aa-a1688d0c1788"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), null },
                    { new Guid("58562ffc-18f3-4e32-bbb5-44198cd6e5f5"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), null },
                    { new Guid("5d444e87-d33b-4100-a840-f86431b59509"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), null },
                    { new Guid("63e01601-998d-4198-bcf6-e334800efa53"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), null },
                    { new Guid("6c0c0493-0edc-4a4b-841f-2ddaa29696c1"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), null },
                    { new Guid("6f04219b-b531-4934-befe-c97afcefe0e2"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), null },
                    { new Guid("8306f928-f3fe-4f7e-ab55-3c5953680911"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), null },
                    { new Guid("84e84f34-a7ec-4716-9215-a0264c3b176e"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), null },
                    { new Guid("876d0965-b961-445d-b4e2-dc738a90e8c5"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), null },
                    { new Guid("8ed1139d-7de6-4db5-91b8-65b693e6b84a"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), null },
                    { new Guid("93494237-8924-4a36-9a0d-29f83a7fb2f6"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), null },
                    { new Guid("93e40911-0e43-4dd2-994a-4d715fa34f37"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), null },
                    { new Guid("97cc8c73-d847-4489-8443-166a491e7125"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), null },
                    { new Guid("af2bed90-cfa8-477a-920a-f18bbba8b7e5"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), null },
                    { new Guid("b66995a5-21e8-4cfe-98b3-7da2111b56aa"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), null },
                    { new Guid("bb479aed-f583-4326-97fa-9ae9d28cefe9"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), null },
                    { new Guid("bef09d7d-64c7-4f04-9042-389bb32f60fc"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), null },
                    { new Guid("c0cf04ce-70a0-4159-b0f9-3b513d79bfb7"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), null },
                    { new Guid("c6d0bbd8-ca1a-4268-93fb-6d59f02a2553"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), null },
                    { new Guid("c7aee572-b311-4cbc-8b55-601df31b3183"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), null },
                    { new Guid("caaa719b-8e05-445b-9cd4-a1599acfdc3b"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), null },
                    { new Guid("cb5f1c72-80d3-4b1b-a75c-128040f62fa5"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), null },
                    { new Guid("ccd3555e-baa2-402f-b65f-408aaa9b7099"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), null },
                    { new Guid("cd8bcec9-6373-4776-ae50-10da1e8d4b1b"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), null },
                    { new Guid("d46de40f-1e80-48b0-80c8-339e7da485aa"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), null },
                    { new Guid("d4f109db-1f73-4293-90ac-3c6c0d744088"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), null },
                    { new Guid("d753d262-7714-4767-a1bc-8ad0d049706b"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), null },
                    { new Guid("d75c8b99-e346-4e54-9253-ddce3ac5d5cd"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), null },
                    { new Guid("d9357bd0-9054-46e3-b59f-9a05d9547eb5"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), null },
                    { new Guid("dc5f2bf6-5ac0-4874-b2a2-0babb29a58be"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), null },
                    { new Guid("dd20d4df-2b15-4e69-9164-6930a957b6c6"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), null },
                    { new Guid("dddbbcc9-c535-45b0-801c-c1e1da93a1b4"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), null },
                    { new Guid("dee221ba-e377-4334-a0ce-6f6a95c3bcd3"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), null },
                    { new Guid("e6f12d8e-13b6-4fdd-9a2b-68caea619105"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), null },
                    { new Guid("e7ae2f9a-0e7b-4e6c-be8f-368d1c0ceb1a"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), null },
                    { new Guid("eb5dec9d-21eb-48be-84c8-1c8ee0ec5e48"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), null },
                    { new Guid("ebfce09c-0534-401f-9870-e8cba6955ef6"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), null },
                    { new Guid("ec1cb909-2a40-4285-87b6-8017d7109e3d"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), null },
                    { new Guid("edf1fdbc-4db3-422d-b69d-e49f302252a2"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), null },
                    { new Guid("f8db9a56-93a5-4fc7-a117-e7f8dbe7da7a"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), null },
                    { new Guid("f95f8443-c42b-4eb7-8221-69461116ddb2"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), null },
                    { new Guid("fb938b59-95a9-45c4-9222-6113f9f99e3c"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), null }
                });

            migrationBuilder.InsertData(
                table: "FoodPortions",
                columns: new[] { "FoodPortionId", "CreatedAt", "FoodId", "PortionId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("028913f2-ed16-4524-8d3b-04451bb6f3b9"), null, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new Guid("b6623163-4c27-4d0c-99ef-12a67b87635f"), null },
                    { new Guid("052ca909-3d9c-4a43-a056-336a3c4bd0ee"), null, new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new Guid("5384aebd-4eab-4a44-8cbb-7ec2c04f1401"), null },
                    { new Guid("05e28b2f-18b8-41f1-b69c-f16469bf6470"), null, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new Guid("8ecbc063-8d6e-450d-af39-0ba28bc572bf"), null },
                    { new Guid("0ba1d7a9-34a1-4260-a967-343ea3098635"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("919c7f66-53e5-46bd-b181-558f6052b953"), null },
                    { new Guid("0cb2367c-d7a8-43ef-ae5a-20c0169629bb"), null, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new Guid("1802caa2-cfe0-48e7-8580-29165f84387d"), null },
                    { new Guid("0ee70ca5-108e-4949-8a26-861f96e9b1a9"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("c6e853f0-06bd-4cda-8b43-cbe66fea98c8"), null },
                    { new Guid("11b2b497-a373-45ee-ab07-b750e0d7a55a"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("c605aa91-495e-4977-9876-b2a198ce356e"), null },
                    { new Guid("179bc550-d7bc-4f33-9bde-fd3e58cb954e"), null, new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new Guid("30f41ca6-c420-4f7d-9602-bf80735d5691"), null },
                    { new Guid("292e4e95-2285-4f62-a46e-ace09aa834cf"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("a7936b9f-b6f8-4295-8b6e-6fe1b096f437"), null },
                    { new Guid("2957f41c-31dd-4033-8074-17fff603ca7a"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("bf0f7ca4-9089-4800-95d7-8d037d98b7fc"), null },
                    { new Guid("2a544211-6ca9-4ce6-96ef-226c73f80b03"), null, new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new Guid("749b288c-112b-4b7b-8750-0daff63d9ab3"), null },
                    { new Guid("2abdd3a4-6210-4079-bf80-ee3d4c46813f"), null, new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new Guid("5f7f859a-f20a-4f6c-8b8c-ecfbb1ff522e"), null },
                    { new Guid("2c2748d3-3215-40ff-8707-50c819e61a39"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("bd16f0ec-5ae1-42f4-a302-b4bce8f0db28"), null },
                    { new Guid("2c744f92-9b3b-4b3f-8b2c-0bc6a2a18892"), null, new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new Guid("41ae956e-14fc-44af-bc6a-e5ba77661cee"), null },
                    { new Guid("2e868990-3430-4f93-a2dd-e9d0afb852fc"), null, new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new Guid("1500876f-ef20-40de-baae-de0336bdc47b"), null },
                    { new Guid("2f67afaf-035e-449c-b497-485f3ad8ded4"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("e09c493c-5806-4b14-bbef-e26e19e1d8d5"), null },
                    { new Guid("3218f888-d5bc-4e5a-8e92-3ee29afb3f04"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("5adcb96d-70ef-403d-89c6-cc3aa807b6a7"), null },
                    { new Guid("36e8bf5b-993b-414a-a2d3-ee26356c0de1"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("40bbc8c4-f383-4ae6-979a-3ac83c275881"), null },
                    { new Guid("3a6d37f1-d02a-45bd-aaef-a353a2ee6f4f"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("1b56833b-1ff5-4a90-aea9-074de2d0dd67"), null },
                    { new Guid("3abf30f8-edd7-4c24-b0bb-fa5ea2bc3db5"), null, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new Guid("9c276c0b-84b6-4216-8dbb-ae2034ac2176"), null },
                    { new Guid("4913b0a0-54f6-400b-99bb-f1d304e30919"), null, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new Guid("bad70aff-4237-4c83-b412-460020a5ee44"), null },
                    { new Guid("4b9f5b5f-7b61-4cab-b149-e5563e7beae5"), null, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("1808de3e-ae43-41a6-b9ce-bfe89131be5a"), null },
                    { new Guid("4c2ef789-adfe-47cd-80af-c62692f1c081"), null, new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new Guid("4e9013c8-d6f7-4740-80d5-e95d318873b9"), null },
                    { new Guid("4c9cb0a2-a15e-45b9-a35c-1e7a8659b905"), null, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new Guid("18809fb3-b78a-4f67-b9f9-8bb6ab95ab00"), null },
                    { new Guid("4d4e1e89-a21d-49a0-b03d-0810a7eff3ae"), null, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new Guid("d09266d3-9e7d-46a6-ad3a-7c608ec802d1"), null },
                    { new Guid("4d89fe48-a269-41f1-9c4c-970cd641ba74"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("9c3399d1-72db-4e86-a518-2575033bb6a8"), null },
                    { new Guid("525b608c-e52e-4ea1-ba48-309b2714e6f9"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("c65d34ee-8c0c-43bb-9d4e-aa39955a4768"), null },
                    { new Guid("549bc5b9-4e0f-403a-83ae-d7a29283599d"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("28b06cf6-6367-4786-bccb-89c43dd3ce3a"), null },
                    { new Guid("54a5a7c3-50e8-41ac-b1f3-0df6f4ade39e"), null, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new Guid("222e1fa2-3910-42ac-9a5c-f371dded16eb"), null },
                    { new Guid("576b740e-de3b-4b45-ab3a-2f56daeaed9a"), null, new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new Guid("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649"), null },
                    { new Guid("5787372a-ce05-4546-a831-9b2b0ad44398"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("87409e4f-4bea-4bba-855d-a3bfbc2f9c20"), null },
                    { new Guid("589c1664-f4bf-4f96-813f-a67052cabcf9"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("f483bb75-84f0-4ecc-8a06-f366a488c6bf"), null },
                    { new Guid("5b08c658-72b1-4f01-a5f8-7e9325d1659e"), null, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new Guid("59589114-7d6a-4c80-8681-db5c554ab38f"), null },
                    { new Guid("626cbf24-41a2-4d25-816c-32806ec0c309"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("17c9d30f-bd85-4e58-bfc0-6b6d70b2e5fe"), null },
                    { new Guid("62e3a0ec-7c1e-4759-a36e-9254384e43a0"), null, new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new Guid("2892c25f-bd50-4bb4-a845-997395ef6693"), null },
                    { new Guid("62ea04b9-1cce-4728-92d3-a542da49da73"), null, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("40991196-f258-43f1-ac84-0381afa83477"), null },
                    { new Guid("63e111ea-671e-4c2a-bc9b-72ba66b5c6f6"), null, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new Guid("3f19ef5c-3c60-4a11-b1b3-5158859f1286"), null },
                    { new Guid("64d8b191-88b6-4b26-bef8-de806f4bfd01"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("f9bc9ae8-e42e-4e8b-84d3-f2bc36037552"), null },
                    { new Guid("676ccbd4-4b6c-4fb7-97a7-438caf459c33"), null, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new Guid("c4993d6a-a2e0-4ddd-821a-0629541e019c"), null },
                    { new Guid("6909997a-d5c9-4d2f-8705-3157a12d3d98"), null, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new Guid("de5d78a3-c5b1-4e2a-b9eb-f3757c999024"), null },
                    { new Guid("6b449a94-79d4-486e-9422-efd5c2edd90c"), null, new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new Guid("93984b54-2044-4ea9-8364-a03c6568e358"), null },
                    { new Guid("75ea34bb-0521-4886-be47-ab4e820cccf8"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("63d10d95-7983-455e-b920-29c1f0c88d85"), null },
                    { new Guid("777be86e-0978-4374-b3d5-ac2ab64694ef"), null, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new Guid("21e32570-7d64-4cec-b711-873185c76523"), null },
                    { new Guid("781b44a3-b8a0-459e-a1ed-baa864101b04"), null, new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new Guid("1cddc91d-209a-4948-8e9f-9017252d5423"), null },
                    { new Guid("7947677b-045a-40e7-959d-ddc8732c615f"), null, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new Guid("84793ef9-fcd0-42df-ab0d-9380dfa18630"), null },
                    { new Guid("83f44fa4-24e9-4fb6-baaa-7cf69108af84"), null, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new Guid("16dc894a-746e-497e-a2c5-2d58f7f83c4d"), null },
                    { new Guid("86271b16-f2b0-4f0c-80c3-e261c9bcf88f"), null, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new Guid("7e071bd6-6afa-483d-8688-28b31b9a8bef"), null },
                    { new Guid("872f8d5d-9109-40ac-9b12-d7c590fe1a03"), null, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new Guid("d2e88505-bbd6-4af6-9a88-535896c5d587"), null },
                    { new Guid("88a46464-6e4d-424f-be03-6d0b6c54ff5b"), null, new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new Guid("255ba0f6-14cc-4049-add8-138f27055b49"), null },
                    { new Guid("93752824-7d24-471b-8c8b-26c62c72f9ef"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("5a9ac478-aa65-48ea-9387-1ad92f6c76b1"), null },
                    { new Guid("954e12c9-2511-4f39-95d3-89dd21978f15"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("3c7d60d4-60da-4f51-9448-30877b126572"), null },
                    { new Guid("95d292d4-a4ae-404a-91c6-83f68bf3010c"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("d9dad801-145a-419d-bbe2-408acf97a273"), null },
                    { new Guid("9972cf31-163d-4634-8857-01824a7c7d46"), null, new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new Guid("a9385e8a-e9b9-484f-beeb-bc35529cf91a"), null },
                    { new Guid("9b57608a-bdc9-49a7-85cf-343c831d3bb1"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("e45c2156-a98c-4121-90b4-25097e8a5cd1"), null },
                    { new Guid("9bacb263-d507-4846-b827-e6d3585fd08c"), null, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new Guid("424ebe64-6570-4d88-9052-08c06dc0a2c8"), null },
                    { new Guid("9f1f9be8-cc8a-4478-9a6c-9f3c94cb3052"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("26096793-894d-47c1-a06f-cf9133f8089d"), null },
                    { new Guid("9fb22cf3-f0bf-4f19-ac2f-0665ed2985e1"), null, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new Guid("31e9bda5-8ec3-4444-a23a-908e84da6a14"), null },
                    { new Guid("a4d3cc69-109a-4947-b38c-c78da4682257"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("e00ed683-11ff-4c21-8b1c-576b448726c9"), null },
                    { new Guid("a6083902-2113-451b-829b-4cdbe8c47c29"), null, new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new Guid("3f77fd90-591c-45f3-8bbc-87d0bb49e461"), null },
                    { new Guid("a65c901b-90a6-47f5-9599-a7d31c191736"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("698c67ad-a726-435b-b9d2-c5690a79eb5a"), null },
                    { new Guid("aa6b57f6-cc41-4826-add2-9176a89cbb71"), null, new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new Guid("5a1bc1cb-ed0b-49bf-9c1a-5494db962d27"), null },
                    { new Guid("aa9882ac-0086-444c-b8a0-dfa2ee76f737"), null, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new Guid("ad9ecd1e-40ec-414a-be69-b16e7013b377"), null },
                    { new Guid("ab0ab144-ac89-46b9-b9af-ba2b8576e782"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("a88faa7c-6eab-4ecb-8a75-b078a9cf7834"), null },
                    { new Guid("ac9932e1-9c51-4b2d-af53-e24db4099363"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("a43d7637-6fc7-421b-86f1-f83e691431a4"), null },
                    { new Guid("acc4bef2-7b82-4908-b917-c975d85b78d4"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("6e98f2be-9196-4c4e-8279-b02010f853f1"), null },
                    { new Guid("b1d8e023-b1b5-4dd1-925c-d5ceb38ee0f3"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("eff728af-c8f0-4bb5-a985-d079cbadb6b5"), null },
                    { new Guid("b2fa5dac-cd6a-4f96-b1e0-cfe0f71166fc"), null, new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new Guid("6792c392-3c86-4162-be91-4fc8646f861d"), null },
                    { new Guid("b307ad79-aba4-4915-bcfc-1a262bcb5bba"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("113f6a04-87c4-43c6-8263-920bd099c8e0"), null },
                    { new Guid("b5904161-a656-4826-8bdc-035ed3f42a71"), null, new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new Guid("f0e8f9cd-d133-49cf-be7d-d427b630e05a"), null },
                    { new Guid("b5d7883e-2a3b-46d0-8b25-408f5885979d"), null, new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new Guid("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52"), null },
                    { new Guid("b6fac442-e0a3-4e2f-813c-0596c4537d0d"), null, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new Guid("bdd1ee1e-3a93-421f-855e-0993c7e6f767"), null },
                    { new Guid("b843c66a-e347-4d4c-a498-5693ca4ff09a"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("91524cc2-db22-4cab-abb7-700725232f1f"), null },
                    { new Guid("bb4955a7-52b8-48d2-bbda-376751ae837c"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("d3850e1b-4780-490d-8c0c-ced1a9aa323b"), null },
                    { new Guid("bc322459-c507-44dd-90e1-f0dcf33c305e"), null, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new Guid("1cf439ce-a31b-4b95-b092-b7f6edf8d40f"), null },
                    { new Guid("bd6e49f7-6b0b-4fc4-8f67-fc1aeba80f7a"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("23ce32a0-6597-4b60-b35c-98073ff595c6"), null },
                    { new Guid("c085c2b9-6b57-47c1-90b7-90d7a2214f9b"), null, new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new Guid("f7b36043-9ca9-42c3-8a00-e9e235b56bb3"), null },
                    { new Guid("c087e746-8a3a-4b12-b929-a8638b737014"), null, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new Guid("3d6d946f-8d9f-479a-b27e-3d78dc354db0"), null },
                    { new Guid("c218a1f4-b68f-44be-98a3-2a262f478ddf"), null, new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new Guid("92e149ff-8491-48cf-a4e8-8106b1e95c4c"), null },
                    { new Guid("c2689b49-ce73-4a05-9365-1f26123fdf0a"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("7b138bd4-4d3a-426c-9ab0-d66699b762d2"), null },
                    { new Guid("c2dd87ea-1178-4ef7-b2a0-f5f401f2748d"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("a5dbb27a-4856-44be-a239-76eb073c3e41"), null },
                    { new Guid("c5556df0-c0b6-4df9-bc66-10f0f4c93697"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("218b9709-852d-4a1f-ad8b-c9410b49fea6"), null },
                    { new Guid("c58ad284-8eda-4d6f-aa20-896a735ea23a"), null, new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new Guid("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1"), null },
                    { new Guid("c680b752-0e7e-486e-ac09-8e500f7bc5e1"), null, new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new Guid("22f0a09e-6816-410e-a5a2-c802103b089b"), null },
                    { new Guid("ca94b25d-8f69-47d5-b98d-a1dc81dc4d72"), null, new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new Guid("e23d4491-73d1-45b5-8010-0385d7185c98"), null },
                    { new Guid("ccd1d5eb-6745-413e-97a6-404585eb8bd3"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("6f34350b-8f99-446e-9de9-e0c6277b10f3"), null },
                    { new Guid("d15821b0-c408-417b-be0e-68978b92806b"), null, new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new Guid("a1589990-affa-4805-a1e0-73de1ffa8516"), null },
                    { new Guid("d15da041-372f-4ed0-be80-b5040606bb36"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("e5cc2785-6d62-4b5f-8fc1-e6ab45babd76"), null },
                    { new Guid("d1a2b9b6-5a59-4a01-aa1d-7e3f7893b399"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("7be0e4d3-1e50-4de1-931d-08adb85f628b"), null },
                    { new Guid("d22996a8-3e6f-42a1-bdac-a46b08baa0e0"), null, new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new Guid("c4fc900f-5a92-4228-ac03-57285fff159e"), null },
                    { new Guid("d25cd3df-67ab-42ea-bada-b07ce91d9122"), null, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new Guid("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a"), null },
                    { new Guid("d80fb07a-9d2f-4816-abb7-50b0eaa017ea"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("399eee61-90b5-464f-b3f7-7ddc1077ab0d"), null },
                    { new Guid("e0925ee4-a287-4200-9c03-b07c01fffc5b"), null, new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new Guid("8a81e20e-ea16-4073-957e-29508a8f7419"), null },
                    { new Guid("e10da98f-6042-4598-b31a-0319fef4e93f"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("faec7c41-2e11-4092-8ab9-cc9c152d858f"), null },
                    { new Guid("e465587c-87c3-4c51-a5c6-3f71a6844e09"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("5afaa147-398e-4be8-b0d1-8dcabe6ed18c"), null },
                    { new Guid("e4dc0d3f-c715-4e52-9669-e35a800f2c8e"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("cd0b1476-44a8-4350-a6a1-3de8747a5ebc"), null },
                    { new Guid("e54fbdbc-b1b4-4f26-987e-5bb76643f9db"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("36398f6d-0668-4d37-8850-9f9ee89b8b92"), null },
                    { new Guid("e58596f1-6a64-4a11-8e7a-65e7f14357a1"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("56681171-ccbd-4700-90bc-2233c1e661bb"), null },
                    { new Guid("e606b714-80b7-42a0-bbaf-5285e46d7306"), null, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new Guid("a33065fe-80ad-4879-9333-424aadc6734f"), null },
                    { new Guid("e7768b1b-3767-4fb0-9960-c4d145349bd2"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("52c86d57-0909-41c3-b513-e770e6f6d104"), null },
                    { new Guid("eaf056d3-6351-4764-bcb4-2ee0a95b68d0"), null, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new Guid("eceaaa32-4023-4eab-abb6-9172c908f77c"), null },
                    { new Guid("ecbba54b-53c1-4d93-ba11-f4e70bfe13e7"), null, new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new Guid("5feca670-1f15-430d-9b04-7ac86a329a6c"), null },
                    { new Guid("edac6023-f820-42ef-b307-31223cd8a326"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("549d664a-eb1c-4b9a-8ad7-fab9e1482e5b"), null },
                    { new Guid("f39f917d-6d70-4ab5-8196-b0cdb6d1aed3"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("709578ca-672f-461e-995d-dc78aeda8c4c"), null },
                    { new Guid("f3ca9f2c-f43e-437b-8cd4-d28a54b5e7fa"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("f928b7a6-2558-478a-bc22-515516f4dc74"), null },
                    { new Guid("f96c4bf3-3600-4f4b-8204-e286b6832ec7"), null, new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new Guid("ef6b8c43-9ab5-497c-a9a8-e31f0a349527"), null },
                    { new Guid("fc9ef9f1-4b15-4e3b-943f-d6ae432c42db"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("26dcc6e0-67aa-40ed-b3d1-8a009c60a62c"), null }
                });

            migrationBuilder.InsertData(
                table: "Nutrition",
                columns: new[] { "NutritionId", "Calcium", "Calories", "Carbs", "Cholesterol", "CreatedAt", "Fat", "Fiber", "FoodId", "Iron", "Potassium", "Protein", "SaturatedFat", "Sodium", "Sugar", "UnsaturatedFat", "UpdatedAt", "VitaminA", "VitaminB1", "VitaminB2", "VitaminC", "VitaminD", "VitaminE" },
                values: new object[,]
                {
                    { new Guid("0093c070-88f3-4c1c-ae88-fcbb1a2f204a"), 30f, 280f, 40f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6f, 1.5f, new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), 1.5f, 250f, 16f, 0.5f, 500f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 150f, 0.1f, 0.1f, 5f, 0f, 0.4f },
                    { new Guid("021a1032-5627-474a-a997-3c7738fc23ed"), 10f, 60f, 13f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.4f, 3f, new Guid("86d88717-df08-4de6-b86d-870210864b46"), 0.3f, 150f, 1.2f, 0.1f, 4f, 8f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.04f, 0.05f, 3f, 0f, 0.3f },
                    { new Guid("03d54346-f33e-4ffe-81c2-e27843a0b4ae"), 35f, 280f, 40f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6f, 1.5f, new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), 2.5f, 320f, 18f, 3f, 850f, 2f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.08f, 0.1f, 0.07f, 1f, 0f, 0.3f },
                    { new Guid("04734055-0621-4d9d-bd60-df96d7edb744"), 25f, 260f, 40f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 1.5f, new Guid("7167f942-dc89-4f29-8022-588373aef45e"), 0.9f, 220f, 14f, 0.5f, 400f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 80f, 0.05f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("056e2ad1-003d-48b7-813d-730779689272"), 37f, 31f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 2.7f, new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), 1f, 211f, 1.8f, 0f, 6f, 3.3f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.69f, 0.02f, 0.1f, 12.2f, 0f, 0.41f },
                    { new Guid("065cd0db-9495-47e0-af35-f8517c5c1d37"), 10f, 160f, 35f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5f, 0.5f, new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), 0.5f, 50f, 3f, 0.5f, 300f, 1f, 1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.01f, 0.01f, 0f, 0f, 0.1f },
                    { new Guid("0698b7fb-3dcc-4245-b1e3-5ff77d1e0e3e"), 37f, 53f, 13f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1.8f, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), 0.1f, 166f, 0.8f, 0f, 2f, 10.5f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.34f, 0.06f, 0.03f, 26.7f, 0f, 0.2f },
                    { new Guid("06c446f3-55a0-4ed3-82e2-4b54d0645d24"), 350f, 270f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20f, 3f, new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), 3f, 230f, 17f, 1f, 10f, 1f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 0.05f, 0.1f, 0.5f, 0f, 0.4f },
                    { new Guid("0742d51d-cb44-4d68-9598-95a9023c700c"), 30f, 250f, 5f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15f, 0.5f, new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), 2f, 400f, 25f, 9f, 900f, 2f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.04f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("07568448-75bc-4a78-93c8-9a45db00f73b"), 30f, 50f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 2f, new Guid("00bc33fe-4cd5-47df-bd94-15ac9f93648c"), 0.8f, 200f, 2f, 0.1f, 250f, 3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 600f, 0.06f, 0.05f, 20f, 0f, 1f },
                    { new Guid("07f921bb-08a4-4176-acd2-8da41fb66ae1"), 40f, 25f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 1.5f, new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), 0.6f, 120f, 1.2f, 0f, 750f, 2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.01f, 0.02f, 15f, 0f, 0.02f },
                    { new Guid("0880a81d-f566-4fe5-8689-3b4d0c1f849c"), 40f, 300f, 40f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8f, 2f, new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), 3f, 350f, 20f, 4f, 900f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.1f, 0.08f, 1f, 0f, 0.2f },
                    { new Guid("0943a9c2-ab7b-4ab3-b33c-62d4b4041b00"), 35f, 40f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 2f, new Guid("0292d477-d63b-4904-a83b-2cd8cac39c14"), 0.5f, 330f, 1.5f, 0.1f, 250f, 3f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 600f, 0.05f, 0.08f, 45f, 0f, 0.7f },
                    { new Guid("0995b388-61e4-40e6-a452-454febbcf379"), 54f, 375f, 68f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7f, 10f, new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), 4.7f, 362f, 13f, 1.2f, 2f, 1f, 5.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.76f, 0.14f, 0f, 0f, 0.42f },
                    { new Guid("09968aa5-9d5f-4611-99db-a58adbeb6ce2"), 10f, 130f, 28f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 0.4f, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), 0.2f, 35f, 2.7f, 0.1f, 1f, 0.1f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.02f, 0.01f, 0f, 0f, 0f },
                    { new Guid("0d8ac101-61b9-4c62-9615-e57efb549590"), 10f, 184f, 0f, 51f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6f, 0f, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), 0.9f, 252f, 30f, 0.3f, 37f, 0f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.01f, 0.07f, 0.18f, 0f, 0.8f, 0.2f },
                    { new Guid("0f526a1d-855f-4690-a2c1-17ea0f94415a"), 40f, 25f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 2f, new Guid("4edcae53-7e30-42bb-8526-7686355f2268"), 1f, 300f, 2f, 0.1f, 150f, 1f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 500f, 0.05f, 0.06f, 30f, 0f, 0.5f },
                    { new Guid("0f543297-39b7-4cfe-9861-5efa7bfbd039"), 12f, 165f, 0f, 88f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, 0f, new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), 1.2f, 223f, 31f, 3.8f, 82f, 0f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.07f, 0.13f, 0f, 0.02f, 0.3f },
                    { new Guid("0f6d3c2f-b50d-4077-9187-0f6bdddc282a"), 47f, 34f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.4f, 2.6f, new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), 0.7f, 316f, 2.8f, 0f, 33f, 1.7f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 623f, 0.07f, 0.12f, 89.2f, 0f, 0.8f },
                    { new Guid("0ff0b7cf-29f7-47e6-9c26-762a825bddd9"), 40f, 300f, 45f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8f, 2f, new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), 1.2f, 200f, 14f, 1.5f, 500f, 4f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 0.1f, 0.1f, 2f, 0f, 0.5f },
                    { new Guid("10e51b70-b86f-4b04-9666-5b1ed3b00a21"), 15f, 195f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 13f, 0f, new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), 1.4f, 250f, 19f, 2.5f, 60f, 0f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.06f, 0.15f, 0f, 0f, 0.7f },
                    { new Guid("142db4a7-48c0-4e6b-bdd3-1121188d22fd"), 22f, 280f, 45f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 3f, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), 2.4f, 115f, 10f, 0.5f, 491f, 6f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.2f, 0.12f, 0f, 0f, 0.1f },
                    { new Guid("1697ff68-5ede-47d4-815f-a09eea06c7e5"), 77f, 20f, 3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 2f, new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), 1.5f, 312f, 2.6f, 0f, 113f, 0.8f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.3f, 0.04f, 0.09f, 55f, 0f, 1.5f },
                    { new Guid("18730385-1d84-44a8-b17b-4aec0bea8566"), 25f, 33f, 2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8f, 0.5f, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), 0.7f, 118f, 3.3f, 0.2f, 51f, 1f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.03f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("1c1ad1e0-bc64-41ab-9d05-1208c33277b5"), 50f, 290f, 45f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6f, 2f, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), 2f, 300f, 15f, 4f, 1200f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.08f, 0.1f, 4f, 0f, 0.2f },
                    { new Guid("1e1bad19-ca90-4abc-8122-c96b4664eaa2"), 20f, 190f, 38f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 1.5f, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), 1f, 100f, 5f, 0.5f, 300f, 4f, 1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.05f, 0.06f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("21f27f47-4e62-457a-8157-88bff4262bcb"), 30f, 150f, 20f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 0.5f, new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), 1.5f, 200f, 10f, 2f, 500f, 0.5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("2290546b-0776-4a0c-a01c-21a3e72de379"), 500f, 270f, 0f, 152f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6f, 0f, new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), 2.8f, 684f, 58f, 0.3f, 702f, 0f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.04f, 0.12f, 0.1f, 0f, 0.6f, 0.2f },
                    { new Guid("22e58d44-5767-4720-99a9-c68d15d3977b"), 50f, 70f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, 3f, new Guid("a988cc73-072e-4af1-9b53-55fbf0f4fe79"), 1.2f, 250f, 2.5f, 0.5f, 200f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 500f, 0.05f, 0.07f, 15f, 0f, 2f },
                    { new Guid("2527fd1c-2c52-43b2-9e26-e1a226218866"), 3f, 20f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.1f, new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), 0.1f, 15f, 0.1f, 0f, 2f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.02f, 0.02f, 20f, 0f, 0f },
                    { new Guid("259434eb-eab4-4e6b-8f3e-c4289b01b5fe"), 20f, 250f, 0f, 90f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15f, 0f, new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), 2.5f, 280f, 26f, 6f, 75f, 0f, 9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.08f, 0.2f, 0f, 7f, 0.5f },
                    { new Guid("25ce663f-e83c-48d2-9eda-dd9653715d5b"), 10f, 330f, 0f, 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 25f, 0f, new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), 1.5f, 200f, 27f, 9f, 75f, 0f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.08f, 0.05f, 0f, 0f, 0.1f },
                    { new Guid("29649ec8-99b5-43f0-8024-c52223dda62a"), 20f, 43f, 11f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 0.7f, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), 0.3f, 257f, 0.5f, 0f, 3f, 8.3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.95f, 0.03f, 0.04f, 61f, 0f, 0f },
                    { new Guid("29d01605-95dd-4b7a-8a3d-dc39817af45a"), 25f, 52f, 12f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.7f, 6.5f, new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), 0.7f, 151f, 1.2f, 0f, 1f, 4.4f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 33f, 0.03f, 0.04f, 26.2f, 0f, 0.9f },
                    { new Guid("2afde1ff-0c2d-48ba-8f03-f383ff90d2bb"), 120f, 80f, 12f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 0.7f, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), 0.6f, 200f, 3.2f, 1f, 50f, 9f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.1f, 0.1f, 2f, 0.1f, 0.1f },
                    { new Guid("2cc8cda3-223c-42f7-86e3-6aac7d2faa77"), 14f, 354f, 15f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 33f, 9f, new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), 2.4f, 356f, 3.3f, 29.7f, 20f, 6.2f, 3.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.04f, 0.02f, 3.3f, 0f, 0.3f },
                    { new Guid("2d47fcb3-a7cc-4ef2-be28-b0eaaee57cff"), 60f, 70f, 10f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.5f, 0f, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), 0.2f, 80f, 1.5f, 2f, 40f, 8f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.04f, 0.06f, 0f, 0f, 0.1f },
                    { new Guid("30a53d63-3acd-4ad0-9b58-334090579575"), 80f, 280f, 35f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 2f, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), 2.5f, 400f, 15f, 4f, 850f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.1f, 0.2f, 4f, 0f, 0.5f },
                    { new Guid("35e3dea9-e7ba-4598-a976-caa315400ec4"), 18f, 270f, 0f, 82f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 19f, 0f, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), 2.7f, 300f, 25f, 7.4f, 62f, 0f, 11.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.08f, 0.18f, 0f, 8f, 0.5f },
                    { new Guid("36d3a6a3-e208-434b-b070-ac81af1703df"), 15f, 130f, 20f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 0.5f, new Guid("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), 1f, 200f, 7f, 1f, 400f, 0.5f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30f, 0.05f, 0.1f, 2f, 0f, 0.3f },
                    { new Guid("375c292a-e5d1-47b3-8e1f-00e023700700"), 50f, 290f, 30f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 2f, new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), 2f, 450f, 20f, 4f, 1200f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.1f, 0.2f, 2f, 0f, 0.4f },
                    { new Guid("3868457b-2c31-4fbf-bd91-fa368a75c3bc"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.4f, 2.2f, new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("38a668bc-e751-4d2c-be10-03161f4e839f"), 40f, 20f, 3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 2f, new Guid("90a605b6-843d-4cc1-8fe7-a016c76ee29c"), 0.9f, 300f, 2.5f, 0.1f, 100f, 0.8f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 500f, 0.04f, 0.05f, 30f, 0f, 0.5f },
                    { new Guid("3a0ebfdb-874e-47c3-851e-28bd4ce2c12b"), 25f, 70f, 6f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 1.5f, new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), 1f, 250f, 8f, 0.5f, 500f, 3f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 0.1f, 0.1f, 10f, 0f, 0.3f },
                    { new Guid("3c9a5965-4704-4777-b142-4cec19a631fd"), 43f, 112f, 26f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 4.1f, new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), 0.6f, 484f, 1.5f, 0f, 13f, 0.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 47f, 0.09f, 0.03f, 4.5f, 0f, 0.1f },
                    { new Guid("4010e963-8d80-43d1-b166-08915aef62e1"), 20f, 220f, 40f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 1f, new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), 1.2f, 100f, 7f, 2f, 300f, 5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.05f, 0.05f, 0.03f, 0f, 0f, 0.2f },
                    { new Guid("40819395-4efd-4198-a265-6adf4a000794"), 8f, 110f, 22f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9f, 2.5f, new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), 0.2f, 60f, 3.5f, 0.1f, 4f, 0.2f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.08f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("41aa7fc1-e3d2-405a-858c-21ff682a00c4"), 3f, 27f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2.5f, new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), 0.4f, 359f, 2.2f, 0f, 3f, 1f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.11f, 0.1f, 2.1f, 0f, 0.01f },
                    { new Guid("423fe09f-76c3-4a52-bd7c-1b2a5d429350"), 125f, 42f, 5f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1f, 0f, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), 0f, 150f, 3.4f, 0.6f, 44f, 5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.04f, 0.04f, 0.18f, 0f, 0.02f, 0.03f },
                    { new Guid("46efc0da-83b0-4644-9310-9cb34d229e02"), 55f, 23f, 4.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2.6f, new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), 1.8f, 500f, 2.5f, 0f, 15f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8890f, 0.05f, 0.18f, 37.5f, 0f, 0.4f },
                    { new Guid("47831a2f-ad70-4913-9a06-66f743604079"), 40f, 30f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 2.5f, new Guid("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), 1f, 250f, 2f, 0.1f, 25f, 1f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 450f, 0.07f, 0.08f, 25f, 0f, 0.4f },
                    { new Guid("4b147a86-8d04-47ea-937b-44373bf9725f"), 15f, 100f, 8f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, 1f, new Guid("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), 1f, 200f, 6f, 0.5f, 300f, 1.5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 0.05f, 0.06f, 4f, 0f, 0.3f },
                    { new Guid("4b60575c-b319-452f-8369-aeccdce8ab8e"), 11f, 180f, 0f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9f, 0f, new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), 0.4f, 265f, 25f, 0.7f, 670f, 0f, 3.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.09f, 0.2f, 0f, 200f, 0.6f },
                    { new Guid("4db36cb9-84d5-42b7-8415-0ec6a6669579"), 30f, 350f, 40f, 80f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15f, 2f, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), 2f, 200f, 15f, 5f, 600f, 4f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.04f, 0.1f, 0.08f, 2f, 0f, 0.3f },
                    { new Guid("4e4618fa-5ffb-4eef-ac30-18168a0d1ec5"), 11f, 165f, 0f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, 0f, new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), 0.9f, 256f, 31f, 1f, 74f, 0f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.06f, 0.08f, 0f, 0f, 0.3f },
                    { new Guid("4ee313ed-56ef-4379-9a68-ac2b436252ec"), 12f, 206f, 0f, 63f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 13f, 0f, new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), 0.5f, 363f, 22f, 3.1f, 59f, 0f, 9.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.1f, 0.38f, 0f, 570f, 0.4f },
                    { new Guid("4f7f31f4-cdf6-49c3-b9d7-a50ddb094889"), 2f, 96f, 21f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5f, 2.4f, new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), 0.5f, 270f, 3.4f, 0.2f, 1f, 4.5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.15f, 0.1f, 6.8f, 0f, 0.2f },
                    { new Guid("4fa9e669-5d95-4b1d-bef5-ebea3e061b18"), 22f, 265f, 49f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, 2.7f, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), 2.4f, 115f, 9f, 0.5f, 491f, 5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.2f, 0.12f, 0f, 0f, 0.1f },
                    { new Guid("50420ecb-e44a-41d1-a4e8-237456713b68"), 30f, 240f, 38f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 1f, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), 1.2f, 120f, 9f, 2.5f, 350f, 3f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("5144c417-d7dd-42bd-ac38-c8403269783e"), 25f, 180f, 5f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 0f, new Guid("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), 1.5f, 300f, 20f, 1.5f, 350f, 3f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 80f, 0.1f, 0.07f, 2f, 0.5f, 0.3f },
                    { new Guid("530bafd1-8b7d-4167-bc87-9fd7e12c859c"), 30f, 280f, 15f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 5f, new Guid("a364353c-d589-4a94-9c3b-3038113ea249"), 2.5f, 350f, 25f, 2.5f, 350f, 5f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 150f, 0.1f, 0.1f, 25f, 0f, 1f },
                    { new Guid("5358c4a4-106f-4175-a602-85e518e73a67"), 7f, 143f, 0f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, 0f, new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), 0.9f, 370f, 26f, 5.2f, 65f, 0f, 8.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.6f, 0.15f, 0f, 0f, 0.2f },
                    { new Guid("5501e859-9a37-4a80-82a5-7aa5372a7d95"), 6f, 39f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1.5f, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), 0.3f, 190f, 0.9f, 0f, 0f, 8.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 326f, 0.02f, 0.05f, 6.6f, 0f, 0.1f },
                    { new Guid("55f9eb26-17a5-4c12-ab2b-e8729673f466"), 40f, 380f, 60f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 3f, new Guid("2405ffc3-524e-4331-9e68-47a411d7b9b8"), 1f, 150f, 16f, 1.5f, 500f, 3f, 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 0.1f, 0.08f, 5f, 0f, 0.4f },
                    { new Guid("56517f01-872d-4461-8062-d56483c92733"), 21f, 92f, 3.1f, 233f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5f, 0f, new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), 0.7f, 279f, 15.6f, 0.5f, 44f, 0f, 0.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.01f, 0.02f, 0.06f, 0f, 0f, 0.01f },
                    { new Guid("588eb7fc-2731-4c94-97f3-0a7a100bc918"), 30f, 86f, 20f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 3f, new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), 0.6f, 337f, 1.6f, 0f, 55f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.96f, 0.08f, 0.03f, 2.4f, 0f, 0f },
                    { new Guid("59592500-d822-467b-b4fd-d2ccd9c64b77"), 20f, 15f, 3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.8f, new Guid("6487a532-ff5e-4b77-b408-46c789608de9"), 0.3f, 150f, 0.8f, 0f, 180f, 1.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 0.03f, 0.02f, 7f, 0f, 0.1f },
                    { new Guid("5990f593-f51b-4a28-b32f-e31df25baa46"), 16f, 25f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1.5f, new Guid("3dc2fa80-ab87-4e26-907b-3516611371b8"), 0.3f, 140f, 1f, 0f, 125f, 2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20f, 0.05f, 0.06f, 12f, 0f, 0.1f },
                    { new Guid("59d5da03-888e-4a5d-b7d2-0b096ac39521"), 6f, 46f, 11f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1.4f, new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), 0.2f, 157f, 0.7f, 0f, 0f, 10f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.03f, 0.04f, 9.5f, 0f, 0.4f },
                    { new Guid("5ce096d3-864c-4d4c-a996-19eb35f5ccb4"), 30f, 220f, 15f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 2f, new Guid("29dfb5da-8818-40ff-bf66-7553521c2161"), 2.5f, 300f, 20f, 4f, 600f, 5f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 150f, 0.1f, 0.1f, 4f, 0f, 1f },
                    { new Guid("5f2d8662-40bb-4645-904f-abd1757b5fe3"), 15f, 250f, 8f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15f, 0f, new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), 1.2f, 330f, 20f, 6.5f, 530f, 5f, 10.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 45f, 0.8f, 0.2f, 0f, 0f, 0.3f },
                    { new Guid("5f634536-fb39-419c-9a00-c528d2b2478f"), 30f, 270f, 40f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6f, 1.5f, new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), 1.5f, 200f, 15f, 0.5f, 450f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 0.1f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("6100b445-10af-4009-b6c4-57098ef50e20"), 277f, 172f, 8.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9f, 6f, new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), 2.5f, 620f, 18f, 1.3f, 15f, 2f, 7.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9f, 0.16f, 0.18f, 6f, 0f, 0.9f },
                    { new Guid("612d865c-7f91-42cf-90f5-086297990b4f"), 40f, 65f, 16f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 3.5f, new Guid("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), 0.1f, 181f, 1.3f, 0f, 1f, 13f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.1f, 0.04f, 53.2f, 0f, 0.2f },
                    { new Guid("62ca91d1-ef98-4de4-95c2-4c7a56a5ba38"), 50f, 30f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 2f, new Guid("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), 1.2f, 250f, 2f, 0.2f, 300f, 1.5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 400f, 0.05f, 0.07f, 20f, 0f, 0.5f },
                    { new Guid("65980413-8715-4e06-af67-db2efff71a9e"), 22f, 82f, 20f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1.3f, new Guid("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), 0.3f, 42f, 0.9f, 0f, 0f, 14f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.05f, 0.05f, 20f, 0f, 0.1f },
                    { new Guid("67848c98-3542-4cf8-9e0e-cf20dc6fdc48"), 20f, 120f, 10f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 1.5f, new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), 2f, 250f, 10f, 3f, 500f, 2f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 0.1f, 0.1f, 5f, 0f, 0.5f },
                    { new Guid("68f52fe4-8e6b-4c52-a6dc-783dca6ef6c1"), 10f, 83f, 19f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2f, 4f, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), 0.3f, 236f, 1.7f, 0.1f, 3f, 14f, 1.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.07f, 0.06f, 10.2f, 0f, 0.6f },
                    { new Guid("6950626b-e27a-438b-b908-22155844f0de"), 30f, 320f, 55f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7f, 1.5f, new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), 1.5f, 200f, 10f, 4f, 500f, 1f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.1f, 0.06f, 1f, 0f, 0.3f },
                    { new Guid("695b2a59-bfa1-43b6-be12-328ccc82d371"), 15f, 420f, 0f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 35f, 0f, new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), 1f, 200f, 30f, 14.6f, 800f, 0f, 24.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.04f, 0.09f, 0f, 0f, 0.3f },
                    { new Guid("69743411-9e1b-4fb8-bf35-96e8e0e35360"), 15f, 150f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 3f, new Guid("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), 0.6f, 350f, 4f, 0.1f, 350f, 3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20f, 0.06f, 0.05f, 10f, 0f, 0.1f },
                    { new Guid("6b0f8c57-fcd3-48a6-bff1-b606e8b10751"), 2f, 2f, 0f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0f, new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), 0f, 49f, 0.2f, 0f, 5f, 0f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0f, 0f, 0f, 0f, 0f },
                    { new Guid("6bffc350-352a-4d8a-9909-18cc42d8e5a2"), 18f, 68f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.6f, 5.4f, new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), 0.3f, 417f, 2.6f, 0.3f, 2f, 9f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.21f, 0.07f, 0.04f, 228.3f, 0f, 0.73f },
                    { new Guid("6d127776-e64c-42fd-92f0-3dad73c0a409"), 30f, 350f, 40f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 1.5f, new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), 2.5f, 320f, 20f, 6f, 650f, 2f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.15f, 0.08f, 2f, 0f, 0.4f },
                    { new Guid("6d6e344d-ce9c-49dc-8c17-852582c5f716"), 40f, 45f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5f, 3f, new Guid("eec3d874-6331-4e33-bbe6-bf0cc4335b29"), 1f, 250f, 1.5f, 0.1f, 50f, 4f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 700f, 0.05f, 0.06f, 25f, 0f, 1f },
                    { new Guid("6fc73557-919d-4d28-a26e-2ad9bfaf18e4"), 56f, 155f, 1.1f, 373f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.6f, 0f, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), 1.8f, 126f, 13f, 3.3f, 124f, 1.1f, 3.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.52f, 0.04f, 0.5f, 0f, 1.1f, 0.5f },
                    { new Guid("702ea66e-04a0-4e8b-8e1e-e7887ab18092"), 80f, 280f, 35f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 2f, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), 2.5f, 400f, 15f, 4f, 850f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.1f, 0.2f, 4f, 0f, 0.5f },
                    { new Guid("7212c213-8af9-43fd-a47a-2e747b4b263b"), 110f, 60f, 5f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 0f, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), 0f, 141f, 3.5f, 1f, 36f, 4f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.05f, 0.04f, 0.14f, 0f, 0.02f, 0f },
                    { new Guid("741c55f6-744c-4ce5-954e-999a7614d124"), 16f, 258f, 60f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1f, 13f, new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), 0.7f, 533f, 5f, 0f, 4f, 2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("754e2f7d-d75a-4a7c-96f6-2aa872a6720e"), 70f, 99f, 0f, 189f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1f, 0f, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), 0.4f, 264f, 24f, 0.1f, 111f, 0f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.02f, 0.1f, 0f, 0f, 1.3f },
                    { new Guid("75967e67-880f-492b-afa5-91aff7fc860a"), 24f, 19f, 3.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 1.1f, new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), 0.3f, 250f, 0.7f, 0f, 11f, 2.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.03f, 0.02f, 2.4f, 0f, 0f },
                    { new Guid("7811ff59-5fe1-4a21-887d-b5cbacbd2762"), 80f, 65f, 2.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, 1f, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), 1f, 150f, 7f, 0.5f, 15f, 0.5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.01f, 0.02f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("7a20b9af-b5c3-44bb-ba57-2fa4c8f61925"), 25f, 81f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.4f, 5f, new Guid("7cd76708-7312-445e-a392-14f0e806a786"), 1.5f, 244f, 5f, 0.1f, 5f, 5.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 765f, 0.27f, 0.15f, 40f, 0f, 0.1f },
                    { new Guid("7adf2489-40d5-4968-a9b3-aac10bef79a6"), 81f, 33f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 3.2f, new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), 0.8f, 299f, 1.9f, 0f, 7f, 1.5f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.36f, 0.02f, 0.04f, 21f, 0f, 0.27f },
                    { new Guid("7c0ebae9-9806-4232-a2e8-74a8862c5c54"), 30f, 86f, 20f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 3f, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), 0.6f, 337f, 1.6f, 0f, 55f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.96f, 0.08f, 0.03f, 2.4f, 0f, 0.26f },
                    { new Guid("7c672890-7ca2-4fa7-9328-bce1dd2ef818"), 40f, 330f, 40f, 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15f, 2f, new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), 1.5f, 250f, 12f, 3f, 500f, 3f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 250f, 0.1f, 0.1f, 1f, 1f, 0.7f },
                    { new Guid("8546ac09-dc36-488d-a98b-263074ab24ef"), 30f, 110f, 10f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 1f, new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), 1f, 250f, 9f, 1f, 450f, 1.5f, 2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 0.1f, 0.1f, 5f, 0f, 0.4f },
                    { new Guid("860fa83b-058a-40c6-98d1-ab3c95591a31"), 10f, 31f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2.1f, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), 0.3f, 175f, 1f, 0f, 3f, 4.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.93f, 0.05f, 0.04f, 80f, 0f, 0.37f },
                    { new Guid("870df10e-5af2-4907-93a9-3aff38b636d7"), 30f, 250f, 40f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, 1.5f, new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), 1.2f, 220f, 12f, 0.5f, 400f, 2f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 0.08f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("87d0b5ab-9a9c-47e3-98c9-9118cb25a16b"), 40f, 40f, 4f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1f, 1.5f, new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), 1.5f, 250f, 4f, 0.5f, 300f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 300f, 0.05f, 0.1f, 5f, 0f, 0.5f },
                    { new Guid("8d03f9a6-56f8-41ad-9d89-73a310d4a05e"), 9f, 206f, 0f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 13f, 0f, new Guid("faf19891-525a-4308-9222-992e83de7ce7"), 0.5f, 363f, 22f, 3.1f, 59f, 0f, 7.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.2f, 0.4f, 0f, 0.38f, 0.5f },
                    { new Guid("8ff6e39c-1955-48cf-94f9-3f26c62cc5a9"), 5f, 90f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2.6f, new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), 0.3f, 358f, 1.1f, 0.1f, 1f, 12f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("9077ebb9-1ce7-4955-85e3-978bbc20df99"), 30f, 25f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 1.5f, new Guid("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), 0.8f, 250f, 1.3f, 0.1f, 300f, 2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 600f, 0.06f, 0.05f, 20f, 0f, 1f },
                    { new Guid("90e71f32-003b-4615-a4f1-3a1bd50ae38b"), 12f, 65f, 16f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 6f, new Guid("3d19d971-88d0-4108-a335-24ac9e1dec50"), 0.3f, 42f, 0.5f, 0.1f, 10f, 14f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.04f, 0.05f, 5f, 0f, 0.1f },
                    { new Guid("9112f8ed-e7dc-49c7-ac5d-e5087d6f3227"), 20f, 30f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1f, new Guid("2ae82bfd-34db-4928-bfee-b60f4aec4460"), 0.5f, 200f, 1.5f, 0.1f, 250f, 3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 500f, 0.05f, 0.03f, 15f, 0f, 1f },
                    { new Guid("93024d8f-8614-4169-b03e-0a271b2a69bd"), 110f, 90f, 15f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 1f, new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), 0f, 140f, 3f, 1f, 35f, 12f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.05f, 0.04f, 0.14f, 0f, 0.02f, 0f },
                    { new Guid("94f92457-2ba8-4e4f-8cd7-ca40cec1fddd"), 20f, 240f, 30f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 1f, new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), 1.5f, 150f, 8f, 3f, 480f, 1f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("9541cecf-8329-40d4-9217-852d5652e48c"), 27f, 18f, 4.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 1.6f, new Guid("845454d0-967a-4e48-aef3-bd8458775500"), 0.3f, 233f, 0.6f, 0f, 9f, 2.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.02f, 0.03f, 14.8f, 0f, 0.2f },
                    { new Guid("95ffc260-79f7-4010-9b98-50bf75051b59"), 40f, 25f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 2.5f, new Guid("8ed85dc2-7654-4c48-81f9-19946a73f71d"), 0.5f, 170f, 1.3f, 0f, 18f, 2.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 75f, 0.05f, 0.04f, 36f, 0f, 0.1f },
                    { new Guid("985c9b8a-935c-41cf-81b3-6ac7cf53252a"), 20f, 130f, 20f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.5f, 0.5f, new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), 1.2f, 150f, 8f, 2f, 300f, 0.5f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("996def7b-7356-4a35-845e-ff918a060c9f"), 39f, 32f, 6.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2f, new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), 0.9f, 391f, 2f, 0f, 36f, 0.5f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 442f, 0.05f, 0.05f, 48.5f, 0f, 0.6f },
                    { new Guid("9a1b18d3-bb36-4cf8-bc03-be8bac53763e"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.4f, 2.2f, new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("9a9439df-0d55-4381-994d-d1a00f11409a"), 201f, 80f, 2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, 1.2f, new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), 1.6f, 121f, 8f, 0.7f, 7f, 0.7f, 2.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.04f, 0.03f, 0f, 0f, 0.02f },
                    { new Guid("9b08bb5a-1791-4f76-b3cb-7ad4485eacfb"), 5f, 66f, 16.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.4f, 1.3f, new Guid("7b8500af-d730-4138-9617-cba352faed4a"), 0.3f, 171f, 0.8f, 0f, 1f, 15.2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.01f, 0.07f, 71.5f, 0f, 0.1f },
                    { new Guid("9bb747a4-b4b0-4125-8c31-8aba098afb87"), 15f, 200f, 40f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 1f, new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), 0.5f, 120f, 5f, 0.1f, 250f, 1f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.1f, 0.1f, 0f, 0f, 0.1f },
                    { new Guid("9c4423bb-3d20-486d-864c-ae4bed0c53f2"), 10f, 30f, 7.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0f, new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), 0.1f, 40f, 0f, 0f, 3f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.01f, 0.01f, 20f, 0f, 0f },
                    { new Guid("9ccc7e2f-0e1d-486a-bfa4-994a27745603"), 15f, 250f, 40f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 1.5f, new Guid("af036922-79f3-45a7-b562-a6279520c0e6"), 0.6f, 200f, 12f, 0.5f, 350f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 0.05f, 0.07f, 3f, 0f, 0.2f },
                    { new Guid("9f619628-6a8f-44eb-b236-1ee7d03301e3"), 30f, 120f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 3f, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), 1.2f, 200f, 4f, 1f, 50f, 3f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.03f, 0.02f, 0f, 0f, 0f },
                    { new Guid("a060e81d-af41-4e20-bea6-2e2e8283845e"), 9f, 65f, 16f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1.3f, new Guid("a504d882-4f38-413e-bb28-fae1f2787150"), 0.3f, 42f, 1.2f, 0f, 1f, 13f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.03f, 0.05f, 10f, 0f, 0.1f },
                    { new Guid("a0668c35-5223-4bdd-9e16-5fc843d472be"), 20f, 180f, 35f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 0.5f, new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), 0.7f, 120f, 4f, 1f, 400f, 0.5f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 0.08f, 0.05f, 1f, 0f, 0.2f },
                    { new Guid("a08db708-1018-4f4f-a736-18ef2a1011f5"), 33f, 41f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 2.8f, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), 0.3f, 320f, 0.9f, 0f, 69f, 4.7f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.69f, 0.04f, 0.03f, 5.9f, 0f, 0.66f },
                    { new Guid("a1b1ce64-ec7c-4b2a-9b1f-c94254bc37b4"), 40f, 30f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 3f, new Guid("2ee163f7-4463-44ec-b9e2-8a409c112db4"), 0.8f, 300f, 2f, 0.1f, 150f, 2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 500f, 0.04f, 0.05f, 20f, 0f, 0.5f },
                    { new Guid("a2d26c12-fd21-4d9b-a77a-7311308bce3a"), 4f, 110f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.9f, new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), 0.1f, 15f, 1.7f, 0.1f, 10f, 0f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.01f, 0.01f, 0f, 0f, 0f },
                    { new Guid("a8a2ac90-583d-4f91-b844-d39ecdcc7364"), 50f, 320f, 48f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9f, 3f, new Guid("8382816f-1beb-4804-9698-3b486798b20a"), 1f, 250f, 15f, 3f, 450f, 4f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 0.2f, 0.1f, 0f, 0f, 0.5f },
                    { new Guid("a8bb73e9-34ea-458e-8b79-be4e28e6e355"), 24f, 20f, 3.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 2.1f, new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), 0.5f, 202f, 2.2f, 0f, 2f, 1.9f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 756f, 0.08f, 0.14f, 5.6f, 0f, 1.1f },
                    { new Guid("ab8b71ed-4937-4542-a32b-e6a06002c8b0"), 80f, 260f, 40f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 1.5f, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), 2f, 350f, 12f, 4f, 900f, 2f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.1f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("abf92ade-8ecd-4e76-b97d-97fea12083b0"), 8f, 240f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20f, 0f, new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), 1.3f, 220f, 17f, 7f, 65f, 0f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.08f, 0.05f, 0f, 0f, 0.1f },
                    { new Guid("b13ddbac-2066-41b7-8749-1519fd9962b7"), 11f, 65f, 17f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1.8f, new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), 0.2f, 168f, 0.5f, 0.1f, 1f, 14f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.54f, 0.03f, 0.04f, 36.4f, 0f, 0.9f },
                    { new Guid("b152e7be-b966-404f-bedf-068c90d41402"), 114f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2.1f, new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), 2.1f, 554f, 2.3f, 0f, 30f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8100f, 0.08f, 0.16f, 51.9f, 0f, 1.9f },
                    { new Guid("b1acd6c0-e48e-4111-883f-3e0f59bb3d8d"), 20f, 190f, 30f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 0.5f, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), 1f, 100f, 5f, 2f, 450f, 0.5f, 4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.04f, 0.05f, 2f, 0f, 0.1f },
                    { new Guid("b1ae2ea5-7560-4d93-96b4-a2bcf82ae570"), 35f, 30f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 2f, new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), 0.5f, 250f, 1.5f, 0.1f, 80f, 2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 650f, 0.04f, 0.05f, 20f, 0f, 0.4f },
                    { new Guid("b2718d8d-a317-44ac-a29c-1c55cb748166"), 13f, 165f, 0f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, 0f, new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), 1f, 256f, 31f, 1f, 70f, 0f, 2.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 13f, 0.07f, 0.1f, 0f, 0f, 0.5f },
                    { new Guid("b348036d-061c-472d-a323-84676c4c83e1"), 130f, 25f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1.5f, new Guid("982d8f3e-f517-4bd2-87a8-48329fc9eb91"), 0.8f, 260f, 1.8f, 0.1f, 60f, 1f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 560f, 0.06f, 0.08f, 35f, 0f, 0.5f },
                    { new Guid("b56e7e36-f268-421c-b9bc-64af2ca8321e"), 20f, 20f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 1.5f, new Guid("e370081a-c0a6-4c00-b01c-7c52f953b7f1"), 0.2f, 150f, 0.8f, 0f, 50f, 2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 0.05f, 0.04f, 12f, 0f, 0.2f },
                    { new Guid("be0fcfb2-0efc-48a3-b2b5-e01f3415bcf3"), 20f, 130f, 20f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, 0.5f, new Guid("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), 1f, 200f, 7f, 1f, 350f, 0.5f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 0.06f, 0.07f, 2f, 0f, 0.3f },
                    { new Guid("c0cabb31-5b31-4154-b8ed-e9316b78def5"), 10f, 170f, 35f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 0.5f, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), 0.4f, 100f, 2f, 1f, 250f, 0.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.02f, 0.02f, 0f, 0f, 0.1f },
                    { new Guid("c0ed28d8-92f8-4cdc-91b6-fa492be43614"), 40f, 16f, 3.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 1.2f, new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), 0.5f, 252f, 1.2f, 0f, 13f, 1.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.37f, 0.04f, 0.04f, 36.6f, 0f, 0.12f },
                    { new Guid("c1d2378e-5fc2-4b09-bd46-5a99a2eb3934"), 12f, 190f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 0f, new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), 1.1f, 302f, 20f, 4.3f, 60f, 0f, 8.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.03f, 0.33f, 0f, 440f, 0.5f },
                    { new Guid("c26053b6-74d1-4b48-80a7-43a1ffb0086c"), 40f, 300f, 35f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 2f, new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), 2f, 250f, 18f, 5f, 800f, 3f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.1f, 0.08f, 3f, 0f, 0.3f },
                    { new Guid("c306a290-0224-4f15-88f0-8a46fb4e4bd3"), 50f, 280f, 45f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8f, 2f, new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), 2f, 300f, 10f, 4f, 500f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.1f, 0.08f, 3f, 0f, 0.3f },
                    { new Guid("c31b980a-5033-4e5f-ad8e-ebbe681b0cbb"), 15f, 125f, 20f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.5f, 0.5f, new Guid("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), 0.9f, 180f, 6f, 1f, 350f, 0.5f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20f, 0.05f, 0.07f, 1f, 0f, 0.2f },
                    { new Guid("c483b3ca-25e8-4535-bb7e-c2a7928041ad"), 357f, 150f, 12f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8f, 3f, new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), 2.8f, 240f, 10f, 1.1f, 15f, 6f, 5.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 0.08f, 0.16f, 5f, 0f, 0.5f },
                    { new Guid("c8683a0c-3321-4de2-89f8-f296a5ff19dc"), 15f, 35f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1f, 1.5f, new Guid("827829bf-71cd-4865-80af-1457e0091456"), 0.8f, 300f, 2f, 0.1f, 250f, 2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 0.05f, 0.03f, 4f, 0f, 0.3f },
                    { new Guid("c96bfc0b-c34c-4f72-8c92-a147a8924f77"), 10f, 18f, 3.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 1.2f, new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), 0.3f, 237f, 0.9f, 0f, 5f, 2.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.85f, 0.04f, 0.02f, 13.7f, 0f, 0.5f },
                    { new Guid("ca072b9a-f6a4-4e3f-bbdd-396f143e9717"), 21f, 26f, 6.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.5f, new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), 0.8f, 340f, 1f, 0f, 1f, 2.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8533f, 0.05f, 0.11f, 9f, 0f, 0.3f },
                    { new Guid("ca62b3a5-6919-4f7c-951c-9aebece30fa7"), 21f, 70f, 19f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 3.6f, new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), 0.8f, 193f, 0.6f, 0.1f, 12f, 13f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60f, 0.01f, 0.02f, 14.7f, 0f, 0.1f },
                    { new Guid("ccaa23d6-288c-400a-a3e6-d3c6d103fc5b"), 7f, 30f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.4f, new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), 0.2f, 112f, 0.6f, 0f, 1f, 6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.57f, 0.03f, 0.02f, 8.1f, 0f, 0.05f },
                    { new Guid("cf87d2f3-37b1-4aeb-99e5-133bd06dcc25"), 15f, 210f, 6f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 0f, new Guid("43d635e2-6f0c-4385-83d8-fedfd479d356"), 1f, 220f, 25f, 1f, 340f, 3f, 2.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20f, 0.08f, 0.07f, 0f, 0f, 0.4f },
                    { new Guid("d0173150-8007-466b-b62b-fc23c3476e1e"), 55f, 70f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, 2f, new Guid("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), 1f, 450f, 3f, 0.1f, 250f, 1f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 700f, 0.05f, 0.1f, 45f, 0f, 1.2f },
                    { new Guid("d020325c-5bc3-4073-b850-4a3053151271"), 11f, 116f, 0f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1f, 0f, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), 0.5f, 200f, 25f, 0.2f, 300f, 0f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.09f, 0.2f, 0f, 200f, 0.4f },
                    { new Guid("d08b3caf-d71d-4a66-9f6e-d214aea42ba4"), 20f, 170f, 35f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 0.8f, new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), 0.8f, 80f, 4f, 1f, 350f, 1.2f, 2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.01f, 0.02f, 0.02f, 1f, 0f, 0.1f },
                    { new Guid("d215f505-ce1f-42c3-b40d-c30e5c047793"), 40f, 180f, 35f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1f, 6f, new Guid("2146faae-2e7c-4460-8d81-38f5d313012c"), 1f, 260f, 8f, 0.2f, 150f, 1f, 1.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.1f, 0.05f, 1f, 0f, 0.3f },
                    { new Guid("d3a82aaf-1fb7-4c46-b9cc-40616116f0e0"), 70f, 35f, 5.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 0.5f, new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), 2.3f, 1040f, 6f, 0.6f, 233f, 0.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 260f, 0.06f, 0.32f, 6f, 0f, 1f },
                    { new Guid("d4105485-4262-436b-85d5-af44918c4320"), 40f, 250f, 45f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 1.5f, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), 1.5f, 250f, 8f, 2f, 700f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.08f, 0.06f, 1f, 0f, 0.2f },
                    { new Guid("d6646415-aaf4-4320-ae26-07b8d5030b02"), 5f, 35f, 6.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 2.5f, new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), 0.3f, 300f, 2.2f, 0f, 3f, 0f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.06f, 0.07f, 0.5f, 0.02f, 0.1f },
                    { new Guid("d77c3f85-8860-4a93-8db3-0c4e9390a196"), 5f, 89f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2.6f, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), 0.3f, 358f, 1.1f, 0.1f, 1f, 12f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("d88c9912-d521-41eb-adfb-f5d7d871cd84"), 12f, 190f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 0f, new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), 1.1f, 302f, 20f, 4.3f, 60f, 0f, 8.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.03f, 0.33f, 0f, 440f, 0.5f },
                    { new Guid("d8ad5a14-29e9-49f0-a9e7-309d49037b0a"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.4f, 2.2f, new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("dacdee39-2fa0-4c68-927e-df84f79d3cb0"), 30f, 180f, 10f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8f, 2.5f, new Guid("85e621ed-0e0c-4d20-8891-51d311cea4a3"), 2f, 250f, 20f, 1.5f, 400f, 3f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40f, 0.1f, 0.1f, 4f, 0f, 0.5f },
                    { new Guid("db6fbdbb-8ac7-4106-a439-0191f86ac305"), 18f, 15f, 3.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 1.2f, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), 0.2f, 140f, 0.8f, 0f, 3f, 1.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.03f, 0.04f, 10f, 0f, 0.1f },
                    { new Guid("dd7ef12f-2812-49ba-b39b-50a79b1b4a36"), 9f, 57f, 15f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 3.1f, new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), 0.2f, 116f, 0.4f, 0f, 1f, 10f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 25f, 0.02f, 0.03f, 4.3f, 0f, 0.1f },
                    { new Guid("df922c4b-01a7-402f-a372-dc021349e061"), 150f, 25f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2.5f, new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), 1.6f, 296f, 2.5f, 0.1f, 50f, 1f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 740f, 0.07f, 0.09f, 55f, 0f, 1.2f },
                    { new Guid("dfa86b3d-da1d-4d9c-a9f0-fd4532056746"), 30f, 320f, 50f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7f, 2f, new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), 1.5f, 250f, 15f, 1.5f, 600f, 3f, 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 200f, 0.1f, 0.1f, 5f, 0f, 0.7f },
                    { new Guid("e1ce72a8-dea6-4446-80d9-7bab34499cbc"), 11f, 77f, 17f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 2.2f, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), 0.8f, 425f, 2f, 0f, 6f, 0.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.01f, 0.11f, 0.03f, 19.7f, 0f, 0.01f },
                    { new Guid("e22ccb4d-790f-473a-9727-f84609eabc22"), 25f, 81f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.4f, 5f, new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), 1.5f, 244f, 5f, 0.1f, 5f, 5.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 765f, 0.27f, 0.15f, 40f, 0f, 0.1f },
                    { new Guid("e28d7b9b-ea12-4a9a-8a94-678255c3a97f"), 40f, 110f, 15f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 3f, new Guid("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), 0.5f, 230f, 10f, 0.2f, 300f, 5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 850f, 0.05f, 0.07f, 15f, 0f, 0.5f },
                    { new Guid("e28f3193-5ba0-4c09-854d-4300c01f804b"), 130f, 20f, 3.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 1.5f, new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), 1f, 140f, 1.8f, 0.1f, 40f, 1f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 800f, 0.05f, 0.07f, 40f, 0f, 0.4f },
                    { new Guid("e3c5beb6-276a-4898-8489-1196a39762ed"), 20f, 290f, 2.3f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 25f, 0f, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), 1.2f, 200f, 12f, 9f, 1020f, 1f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.3f, 0.12f, 0f, 0f, 0.4f },
                    { new Guid("e3c8aace-be7d-4681-8da3-9785a43d9c3f"), 110f, 97f, 3.6f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 0f, new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), 0.1f, 141f, 10f, 0.2f, 36f, 3.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 0.04f, 0.14f, 0f, 0f, 0f },
                    { new Guid("e69a0fbd-1c60-4521-9cb3-da01aab229aa"), 5f, 160f, 8.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15f, 6.7f, new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), 0.3f, 360f, 2f, 0.1f, 1f, 0.7f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("e95b6fa6-11e2-4455-aefa-fbaa40745c17"), 40f, 180f, 7f, 80f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 0f, new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), 1f, 180f, 15f, 7f, 850f, 1f, 9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("e95c9497-4dfd-4b77-b735-b4ef283f8338"), 10f, 69f, 18f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.9f, new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), 0.4f, 191f, 0.7f, 0f, 2f, 16f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 92f, 0.03f, 0.04f, 10.8f, 0f, 0.1f },
                    { new Guid("e984f5ca-dc71-4511-b74f-6283a4ffbb33"), 15f, 220f, 45f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 2f, new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), 1f, 200f, 5f, 2f, 250f, 6f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.15f, 0.1f, 3f, 0f, 0.2f },
                    { new Guid("e9fc27eb-be19-461b-8bc6-4715ec97cc62"), 40f, 290f, 40f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7f, 1.5f, new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), 3f, 350f, 18f, 4f, 900f, 2f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.1f, 0.08f, 1f, 0f, 0.2f },
                    { new Guid("ecb696c9-02a5-4a0d-a4d9-d5ac9e0c136e"), 20f, 80f, 5f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 1.5f, new Guid("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), 0.7f, 180f, 8f, 0.3f, 250f, 1f, 1.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 0.07f, 0.05f, 8f, 0f, 0.4f },
                    { new Guid("edc2d27a-5741-4f02-9996-908690a396d0"), 23f, 40f, 9.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 1.7f, new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), 0.2f, 146f, 1.1f, 0f, 4f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.01f, 0.05f, 0.02f, 7.4f, 0f, 0.02f },
                    { new Guid("ee4cdc6e-8816-4e85-8896-01fe44ba4cf9"), 16f, 43f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 2.8f, new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), 0.8f, 325f, 1.6f, 0f, 78f, 6.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 33f, 0.05f, 0.03f, 4.9f, 0f, 0.1f },
                    { new Guid("eeb2dcb7-4363-46e8-937c-af1ad472114e"), 40f, 280f, 70f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 1.5f, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), 1.2f, 250f, 25f, 2.5f, 850f, 1f, 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.1f, 0.1f, 3f, 0f, 0.2f },
                    { new Guid("ef957212-fca2-48bf-a765-440facdb289c"), 45f, 31f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 2.8f, new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), 0.6f, 216f, 1.4f, 0f, 27f, 3.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 993f, 0.05f, 0.06f, 36.6f, 0f, 0.1f },
                    { new Guid("eff2c59d-0bc0-4122-8ca7-b11242e19961"), 34f, 61f, 15f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 3f, new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), 0.3f, 312f, 1.1f, 0f, 3f, 9f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 87f, 0.02f, 0.05f, 92.7f, 0f, 1.5f },
                    { new Guid("f02169a7-d938-409c-b7c2-d7aa68acd80d"), 10f, 120f, 20f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 0.5f, new Guid("c5e3e4ed-0164-4917-a1ce-99679b971a22"), 0.6f, 150f, 6f, 0.5f, 300f, 0.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 0.06f, 0.05f, 1f, 0f, 0.2f },
                    { new Guid("f09c28d0-88f6-4180-abf4-b03670087d17"), 20f, 180f, 35f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 0.5f, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), 0.4f, 100f, 3.5f, 1f, 250f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.01f, 0.04f, 0.02f, 0f, 0f, 0.05f },
                    { new Guid("f1688e49-9cca-41e2-9f3c-62fdb4d78c1c"), 30f, 280f, 5f, 120f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 18f, 0f, new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), 2.5f, 300f, 22f, 8f, 800f, 3f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("f1b4ea54-1c77-4196-84ba-0d93049a43cc"), 10f, 110f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9f, 1.8f, new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), 0.4f, 43f, 2.6f, 0.2f, 1f, 0.4f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.16f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("f1eb57cc-0814-489a-b036-5a2af21b2a06"), 10f, 112f, 24f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.8f, 1.8f, new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), 0.4f, 86f, 2.6f, 0.2f, 1f, 0.4f, 0.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.14f, 0.02f, 0f, 0f, 0.1f },
                    { new Guid("f1fda3c8-18d7-41aa-902b-d4159c36cce1"), 15f, 190f, 0f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9f, 0f, new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), 0.8f, 260f, 27f, 4.1f, 70f, 0f, 9.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 0.06f, 0.11f, 0f, 0f, 0.3f },
                    { new Guid("f2295c56-36c1-4bac-a662-9f9c25d3ae47"), 18f, 20f, 4.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 1.2f, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), 0.3f, 170f, 0.8f, 0f, 1f, 2.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.02f, 0.02f, 10f, 0f, 0.01f },
                    { new Guid("f6cbccd9-d54a-4b34-a8d1-e0ec715e6652"), 6f, 52f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 2.4f, new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), 0.1f, 107f, 0.3f, 0f, 1f, 10f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.02f, 0.03f, 4.6f, 0f, 0.18f },
                    { new Guid("f887fb69-c0ca-46d1-99b8-baa9a707de53"), 20f, 350f, 45f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 1f, new Guid("01e60ae4-ff69-44d6-b4fd-aaf916e3a7e5"), 1f, 250f, 20f, 3f, 600f, 1f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 150f, 0.1f, 0.1f, 3f, 0f, 0.5f },
                    { new Guid("f96eb0dc-4358-4029-8548-48d23c64bcad"), 70f, 99f, 0f, 189f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1f, 0f, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), 0.3f, 259f, 24f, 0.2f, 111f, 0f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.02f, 0.11f, 0f, 0f, 0.6f },
                    { new Guid("f9952404-291a-480a-84e0-0663cdeeede1"), 11f, 45f, 10.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.2f, new Guid("de097440-db5c-4d91-bd55-76618d70599d"), 0.1f, 200f, 0.7f, 0f, 1f, 8.3f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.1f, 0.02f, 50f, 0f, 0.02f },
                    { new Guid("fa74ba87-32b0-45cd-a6ed-47d3e499584a"), 105f, 13f, 2.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 1f, new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), 0.8f, 176f, 1.5f, 0f, 65f, 1.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.6f, 0.04f, 0.07f, 45f, 0f, 0.15f },
                    { new Guid("fac55b29-56f8-4ee1-8092-a53ed3e8f7f6"), 120f, 61f, 4.8f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, 0f, new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), 0.1f, 150f, 3.3f, 0.6f, 44f, 4.8f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 47f, 0.02f, 0.18f, 0f, 2f, 0.1f },
                    { new Guid("fb38313b-027f-469f-bc84-8351a960a6b8"), 40f, 300f, 40f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8f, 2f, new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), 2f, 250f, 18f, 5f, 700f, 3f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.12f, 0.1f, 3f, 0f, 0.5f },
                    { new Guid("fc3b4517-3332-4dc0-b563-b858e5d0307b"), 11f, 240f, 0f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 19f, 0f, new Guid("51061170-597d-4289-a021-1e7dde88331f"), 2.7f, 205f, 19f, 8.5f, 63f, 0f, 12.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.06f, 0.15f, 0.23f, 0f, 0.02f, 0.3f },
                    { new Guid("fe120b96-8b26-4718-8e9b-a3296326b197"), 20f, 250f, 38f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6f, 1f, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), 1.2f, 100f, 10f, 2f, 300f, 4f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.01f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("fe4b1e64-ad04-4354-8c99-0f9ab28b0981"), 16f, 32f, 7.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2f, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), 0.4f, 153f, 0.7f, 0f, 1f, 4.9f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 0.02f, 0.05f, 58.8f, 0f, 0.3f },
                    { new Guid("fe9269be-37ad-47c5-a59c-c33b62636b08"), 20f, 90f, 10f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 0.5f, new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), 0.7f, 150f, 6f, 0.5f, 500f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 0.03f, 0.1f, 1f, 0f, 0.1f },
                    { new Guid("ff1cc4e9-606b-4645-acd4-8f6497b7b237"), 16f, 16f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.5f, new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), 0.3f, 147f, 0.7f, 0f, 2f, 1.7f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.05f, 0.03f, 0.03f, 2.8f, 0f, 0.03f }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "ScheduleId", "ConsultantId", "CreatedAt", "RecurringDay", "ScheduleType", "SpecificDate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"), new Guid("6bce17d4-909f-4fad-b125-0074793f22bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), new Guid("6bce17d4-909f-4fad-b125-0074793f22bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b7d907f-1f57-42bf-8c26-1d870f2159ea"), new Guid("0a9dad22-7b87-408b-a377-71dbbe004abc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("21515171-04ee-46dc-b978-07bf7d01896d"), new Guid("0a9dad22-7b87-408b-a377-71dbbe004abc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), new Guid("6bce17d4-909f-4fad-b125-0074793f22bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2a0c644a-83b2-4cc9-8d2e-2b17877303e3"), new Guid("0a9dad22-7b87-408b-a377-71dbbe004abc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), new Guid("6bce17d4-909f-4fad-b125-0074793f22bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("68f7dc95-0090-4b7f-a044-5ff48ecf313c"), new Guid("0a9dad22-7b87-408b-a377-71dbbe004abc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), new Guid("6bce17d4-909f-4fad-b125-0074793f22bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("79370315-ebc7-49e3-b408-9f882e925d0b"), new Guid("0a9dad22-7b87-408b-a377-71dbbe004abc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a089c869-6406-4007-8bfb-8098c02cde67"), new Guid("0a9dad22-7b87-408b-a377-71dbbe004abc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), new Guid("6bce17d4-909f-4fad-b125-0074793f22bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca3d30fe-255b-4bbe-bb7f-1c9f1d12a579"), new Guid("0a9dad22-7b87-408b-a377-71dbbe004abc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), new Guid("6bce17d4-909f-4fad-b125-0074793f22bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "WalletId", "Balance", "ConsultantId", "CreatedAt", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"), 1000000f, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("32cd37ec-1b39-4d25-babd-6c81ef867d2f"), 750000f, new Guid("0a9dad22-7b87-408b-a377-71dbbe004abc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3dbc8aed-a146-4b73-90f4-453bfbc2f071"), 1160000f, new Guid("6bce17d4-909f-4fad-b125-0074793f22bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f02d88c-72be-46df-abb1-5afb9023bfe0"), 937000f, new Guid("77db6560-34ad-44b5-86ab-c74f9033d5f9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81140a5a-b05e-4ff2-b0ee-812913aeef23"), 678000f, new Guid("8d8827cc-904a-4de5-8261-65acdbcb168d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("af37c11a-4773-4b3f-b5ad-1851ffa48feb"), 479000f, new Guid("9a40351b-954a-4697-ac3c-c2e35e89702c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b7d09e14-d5d7-4806-a6f7-e581f792ef1f"), 305000f, new Guid("a0385565-b5f4-4ad3-915e-b95558c00f7d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e370ae45-fa9a-4f3d-b06e-649f8caa7e43"), 957000f, new Guid("96818b5d-41a2-436b-841a-4aff36116b95"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "WorkoutExerciseId", "CreatedAt", "DurationSeconds", "ExerciseId", "Order", "Reps", "UpdatedAt", "WorkoutId" },
                values: new object[,]
                {
                    { new Guid("01cbdb60-8bfd-49b2-a442-4cb59ea7b685"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"), 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("02f528e8-fdfc-43e2-aecc-f4dd60c02cfe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 4, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("0337f769-2825-409d-b70b-7332a5614b53"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("0376dd6a-fc20-435e-ab21-012149207678"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("03e8bf78-03b0-4df6-96e8-b44b13b3654f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("05a4a11f-ab2c-4c74-825b-1a834c1c5bbe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 5, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("06acb760-4aec-4002-9d6c-ca5595513038"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 8, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("0a7c37aa-0e1b-47a9-b0a2-fde820e6c7fd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a280d32-de67-4a38-8f21-923243489eef"), 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("0b205d7b-40fe-47dc-b3e8-4b25b6a0e5bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d4ebca3a-83ef-485b-9178-83d4eab9694c"), 4, 16, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("0b259097-5a67-48a6-905c-eba0e7893bcc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("0f68b10c-608e-451c-b9d4-a4c7887afda0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"), 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("0f79c0af-c498-447f-86cf-16e92fd2cfbe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("0f800c73-3564-492e-a318-c5094ceb0a97"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b2e62599-1f8c-4fc2-9ca7-8ab7aa571d4e"), 2, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("10000b0a-7381-4c59-b67f-0c5424f97975"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 3, 30, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("16c42a2d-4024-4bbb-bfe3-84619b7c94ed"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bd80fdd3-c46c-4410-b126-51a11a8a2f5b"), 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("16d30b11-7007-48dc-8738-ff078e3e2297"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), 7, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("1938098a-9a27-41e8-bda1-9c9f75b93fda"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 1, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("1a22c59d-7fea-4eed-b563-af29c6cfbb91"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("1abc984c-276e-4ede-b8f5-27a1ad1611d2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3100278d-eee7-4b89-b726-4b76daefabde"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("1b9ed739-1543-4257-b3fc-89cd20c72feb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 8, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("1c346390-93ae-458b-87ba-7765ebda8fa8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("1e15dda2-763d-4ae5-8d0c-ceb8ea763581"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"), 7, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("1f6f0fdc-befa-472c-920a-9e24187c2472"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("21525705-6101-4e9e-8400-0164fbfce0ad"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("05c931df-c828-442e-aee1-56432cb772c7"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("216952a1-aa8f-43e9-851d-d610eae05fd8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("26a93c50-f294-4921-83bb-b177169c157d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("1b2afb40-fb97-49ec-8fe3-81a17c6c9078"), 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("270b0545-1298-4aeb-940c-f71bff860fb4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("27e533b4-920c-4aa4-aa45-09533a0e7e34"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("93e22c77-001f-4825-8983-4ec5b643b7bb"), 5, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("2a9be485-26c5-4dc2-a2e7-95eb82479da5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("2bb2a044-accf-45c9-84f1-fc1af0dbc408"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("2bb9706e-b00f-4619-879d-4e4cc3702005"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("5cbc396e-381a-4d9f-9ad6-42b764deee3e"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("31a7763e-3c3c-45c7-8b21-0e6cbb22d3ed"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6d6b06e1-5ade-4dae-b442-7aa200661760"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("343ebf38-d2c2-43e8-af9b-6a1f180d05fe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), 3, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("345e9c82-f91b-43a1-be36-97e003326775"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("36bb906b-a18c-4da5-8bb3-8af61b2a1911"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), 5, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("3b255a0f-4da2-4f40-9100-10542e891337"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("3c22211a-ad1d-4a10-ac41-3a98d5143960"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("3e0ca874-a989-4604-aa11-5a53df5d119b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("413661b0-f9b3-4041-8003-b178dd5efc2c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("42546e4d-62a9-497d-b2f1-56b3cbc1bc6c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6badb5b5-ad99-4b89-80c6-e52d0f7cd7ba"), 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("431a083e-8b6c-4443-99bd-13aeafadc6ce"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a9e1fb3-9abf-4775-a75e-2bb13009a29d"), 1, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("4496b616-d181-4675-99f4-cecad115b1d2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("47415a01-84c8-459c-988e-70fc59c34f90"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("d0dcad19-4c0c-447d-8e3c-092c6d4ad14c"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("48232fef-763b-4b0e-8c27-e934b35ff683"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("4851bf33-1cc0-4443-a2e2-d3937b63a0ee"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ff0ef05-4387-4483-8de3-0ef6d7724afd"), 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("489780c4-3fe0-4dcc-8e90-2b33d293017f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("4a806fc5-0c63-43a7-b666-79bd554f608f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"), 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("4b50dca8-022b-4e53-82e1-fd368697c063"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 1, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("4db3b27c-8951-486a-b75a-d10a52c1b6cb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("439db970-c7c8-4b3b-9a35-127d31d920dc"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("529186c9-72f4-4417-b632-c897fecd5768"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), 3, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("535442c2-e092-43f4-bef2-052d6c1fde5b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("5402d78b-3b6a-464a-81bb-e6679b1352c0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), 6, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("55cb22ee-9856-4d4a-b2ce-8919d7a684de"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("256e23fa-03b1-4328-a325-512f0860d9b0"), 6, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("58454876-c565-481d-896a-f15500c67b90"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("58ec0b3f-7c24-4de6-8923-941e28ec0674"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ae6eaaa1-c8c4-4f97-afa4-4ceeea19d4b3"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("5c25637d-dee3-4051-a610-8c741566e066"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("5c39c988-4900-4d3b-8884-dd9895ef1a0e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("5e23ac9e-54b0-49a7-ab81-e4c0abb61c44"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("5e47794f-8f2c-426e-b17d-7af399adfc15"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("23842121-4834-4483-bfe2-2c244f5ecf76"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("5f48883d-60b3-4bb7-bd7c-8e00a202954b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("5f770c9c-8ba8-4727-a588-04daee35bb86"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 1, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("60782749-d62c-45c2-819b-88c1f888ac8a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 3, 30, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("28de23bb-07b9-4ebc-8f72-ead4d54a4883") },
                    { new Guid("61a157c9-9d06-4ab0-a183-65c1668c273a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 4, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("61e8e6bc-7d94-41a7-a79a-e4cfb48deb58"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("630b8fac-005b-4239-b27c-364309f3ee3c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("58878826-775e-4d4c-8e1b-d5c95afc214d"), 8, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("655e72ef-ad96-4f56-bcfd-68cd15de6224"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d4ebca3a-83ef-485b-9178-83d4eab9694c"), 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("65df92b4-dbdb-413a-9211-f0639bac2c37"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("f93d73ba-d1d6-4037-b51b-1fd005accff3"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("671dd6b9-f642-4ea1-a499-fb1cc10a94d9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), 6, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("67f68094-0350-46df-8d38-58ebd672745d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("6a6fdd4f-f56f-4f4c-9a2a-673e014d8060"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"), 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("6af6b641-dc20-480a-9ff1-aa3a25a08e27"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("58878826-775e-4d4c-8e1b-d5c95afc214d"), 6, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("6d629c89-a13d-4fc3-a435-71beceaf1769"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 3, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("6db530d3-b584-4618-88b3-6e015a5e1b31"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 8, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("6e2d0bee-0de2-497e-ac8a-e6671ab1d74c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0d816828-8a94-4dcb-a87c-b70b295a39b6"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("6e8b9163-7c72-4015-b846-9ae4c54a0c8c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("faebde03-bab9-457b-9b45-a9fabd4760aa"), 1, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("6f872120-4402-4761-92a1-29b55b4ca542"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("70c5565f-30ca-4830-ba3c-e8a022b1d900"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6ffea500-ca35-4483-b049-d8593b2c8680"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("736ce8bb-afdf-483a-b4df-4f6bb0f7bc8e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 4, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("756a2804-c469-47a0-80e9-9ba0e588de3a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("28de23bb-07b9-4ebc-8f72-ead4d54a4883") },
                    { new Guid("7661fbd5-6f38-4d2f-b46a-ee9a68200e91"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), 1, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("76bb58f3-d866-4c48-9f76-27e043eea0d8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), 7, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("76f76c5d-2c6d-439d-b8cd-69ae67b266aa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), 2, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("785a4dcd-06f2-4b97-92d8-fe2215afe276"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("7c0a315c-04e5-4fe0-8966-c5718ce9de09"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("23842121-4834-4483-bfe2-2c244f5ecf76"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("7d1d3c7b-3cb4-4a45-9909-d91d4aaff314"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 4, 6, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("7e91e365-e6e1-458a-971f-79fe4a128b78"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("13ca014d-8b75-414f-afe3-3d378ef7fa97"), 4, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("7f211664-5231-48fe-ba7b-a804ef193780"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8b93dbb2-fc2b-4627-b79a-3ec45a7c6238"), 2, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("800fedf3-fdd6-458c-85cf-43d3651c2ebe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 2, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("834ad2c2-3a4c-4155-8a7a-16be2088a959"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("86d001b5-4352-4118-8d73-8f77b20ad860"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("72206c5e-58f3-46f0-a8b1-031cbf599433"), 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("86e7c9f5-9795-4687-8eab-95cb800e178b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("8b075c00-31e7-4ae0-8743-d94fe21ee985"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01dc4c46-e1ef-44bc-9f19-ecb283bf27ce"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("8b0776e5-9255-4a96-8211-c37d576d6cd6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("8bc4de29-5871-4214-987b-5817b50aebd3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 3, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("8c8f913b-fcb1-48a9-b532-bb2aeece9cc6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("07a4dbcd-635a-4a76-92d4-8127de619e6d"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("943087ef-31ed-4fc4-b9c0-7a00f36e86e9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01e6141a-930e-4126-a2c6-7c32a2ccdd43"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("951daefc-a9d0-4a08-83c6-84b718fe56cd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6ef8ed78-0d00-4271-bf9b-edf27a55ecab"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("9545b9c7-9668-4531-8406-5313c32d9ff6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), 4, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("963cbb76-a1c2-490a-baef-92549e9e2930"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), 6, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("968f98d7-3833-49ff-8c87-1c3b115a6c1c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 1, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("969e4aab-052e-4a6f-8dc6-d9ae662af9f8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"), 1, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("98b45a6c-9535-4778-9f9d-acf0a1f94b42"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ae6eaaa1-c8c4-4f97-afa4-4ceeea19d4b3"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("9acd5442-c4b4-436c-a691-e6b7801660c7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("407ff857-d218-44a8-8d0f-0bfa5d53bf03"), 7, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("9c9b376d-5448-411f-9468-a5bc673a8314"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("9e8b222a-df31-4a01-b984-d5e87171b7f5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("9ba29558-e51b-4a1a-a1c4-b747967e32fb"), 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("9eb4826e-dc99-44fc-b772-9211047bc78e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6749cbc6-0e28-4163-95e8-7fb2a27c54cf"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("9ec90b36-41a3-453f-98cc-c43b400e349e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("a10d2fe5-5ea1-418f-9b35-0dec7ffade99"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0c011f92-425a-477c-84d4-3d6dc883119b"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("a173f670-cc8f-427c-9457-67a627cc7cc0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), 8, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("a31ab3af-059f-4de9-8d06-6657d12aaa4d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("a3991d88-0b88-424e-9f30-4672cc04ee91"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("a3d961c1-8c25-4234-833a-d66b85cec80b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("a5b7a3a6-f10d-483f-86b8-76c7cf5751db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("a6bb7b0d-f2b4-4c6f-a38a-93ceabe7408c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), 5, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("a6d0f14a-9b06-4292-9ae2-b6652e564b93"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("a8e81957-721c-4bf1-82e2-cf63f7782cba"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("aa0b2cf7-1c8c-4588-905c-503af8721ebb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 1, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("aa7e5870-4f13-404b-b10e-1dd66653587d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("ad3e2f7a-a647-49ee-934f-9214d29b6b75"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("b000e0ff-a3bd-4089-bdaa-e6da22b98202"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("22af0171-257b-43bc-9013-8985472a8c84"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("b199de4a-3ab1-40a9-8103-ac71aa3fd44c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("0d1e54fe-7a5f-4e0a-a59f-ee9f443718e0"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("b1b24e03-3ee4-43e2-a0d4-2f7c69d53a70"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 5, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("b2372fe6-2d10-45d9-88f1-7935e29e92ee"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 3, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("b5136778-4953-4c29-9f32-2305bb6ae101"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), 1, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("b570a89f-823c-4654-b915-02376239c40d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("b5a35d7c-3f8a-4faa-9754-4f822cdbfbe1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"), 5, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("b6e42f98-e87c-4118-905f-a24e486d1692"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("b73e6969-5de3-49d2-85c4-4e7296aca971"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), 6, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("b7e1a83f-e79e-49e0-b9ba-3f1d4cb78915"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), 1, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("ba006226-6969-47db-838b-35b7a628fe8a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 7, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("ba90e408-28b2-4040-8580-9deb7719ab4f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("72206c5e-58f3-46f0-a8b1-031cbf599433"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("bd09102a-2543-49d8-8bf4-c85656cee8d6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("90ce2a9f-d0be-4ca0-b3ca-8b6947a6b266"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("28de23bb-07b9-4ebc-8f72-ead4d54a4883") },
                    { new Guid("c188b195-7c2a-4e89-9e68-7e8345798a90"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("c2c0d26e-30ce-4333-bc2f-9311d2b06b3c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("93e22c77-001f-4825-8983-4ec5b643b7bb"), 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("c327512b-0bff-475f-a7be-89ce3c86b924"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), 6, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("c52b6ff2-ee97-4ddf-ab96-2b117217ac1c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("c575bd84-7cbe-4fd0-8ad1-d9b31e9a8f8d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 2, 30, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("c6a935de-c2be-406f-8bb0-d0f7f3a1f7c3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("c7acbe6b-3f52-4ddc-a7a9-f406ec72ea5b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("c804552d-1c33-4d61-b49b-54ae24dd07a5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 2, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("c8b70835-cfe9-4872-88f5-ab372aa9fcd6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("cb2cc7e0-ec24-405c-b3a9-3b40515a2db3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 5, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("cd32e9f0-7cab-44b8-be4a-c744a6f403e7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 6, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("cf0eb952-a496-4498-a1f4-2830ca71f4c7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01e6141a-930e-4126-a2c6-7c32a2ccdd43"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("d04f2b26-6864-425a-a82e-de83f20f332b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("d18f41ec-87d3-4738-8493-9dbd577ec63e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("d224e3dd-e459-440e-b890-38692553c101"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("d3d944c4-947d-4910-bb6e-636390e5b8d5"), 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("d3d335b0-e3a8-4a82-8645-43332e521830"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("d460280c-c1ac-42fc-b354-43f56de39782"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("d9a24991-79eb-474a-b402-623cc3d21e1d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("daf345cc-11ed-4e16-b39d-8800f0bc858a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 9, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("dba09d82-09af-4ee1-9853-ca71196cce78"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 3, 30, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("dd5540c6-a844-482f-8fdd-c030fd464dae"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("e04684a7-9f04-4802-9899-98f6e20116a4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 5, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("e079aee4-a83a-4b52-9e1f-7648fba80052"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("e265ca4e-7d07-4ead-bbbc-85e38c1a8379"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("4834f1ce-41dc-4161-ac51-e03ca78b62b8"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("e41e5112-873b-4004-89c1-c4252014adad"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 5, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("e46c31fe-4245-459d-be35-6694148f1356"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"), 4, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("e68d7fc1-08fe-4752-aa77-b2548b6bc7a3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("e7dd765b-74ae-4af6-8cb7-d0299d36ae91"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("e92d7411-2781-4b1f-b639-295f3a059efe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("ee0e72bb-08e7-4c6e-bfba-0a1414647417"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("385f13f7-79bf-437b-acac-745b50485b9f"), 2, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("ee2dc0b4-fe75-4dbc-b2e8-8140b71a720d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2e787245-7612-41bc-9b75-7a4857282350"), 2, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("eed2e053-3870-4288-b271-15cd75d6f9ab"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("2696db05-e815-4c8b-870d-23c338479e95"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("f203e5ce-a1c8-4378-8645-6ea9ba067670"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("f2f43ab2-1b34-4800-aa3d-c066673fd2ae"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 6, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("f38e2ca9-1a95-4b97-9caf-47dd0107f57b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 1, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("f3d6401e-e689-4957-97ce-81685df80efd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d6b2c0d5-110f-4dff-9aa7-91da10a29dca"), 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("f4c0eebf-0d90-46e2-8ca8-07adb78d2285"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("f5d92b79-c1eb-4113-bc6c-19bf19a7871b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 5, 6, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("f66a90d3-d108-4580-9ecd-9a8988f3ee2b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("f7840490-d9b9-4512-b533-7387f1bf94be"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("f7b001ae-b9ed-4671-9c5f-f93f199ace74"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a280d32-de67-4a38-8f21-923243489eef"), 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("f8dea347-1097-4733-b31d-f8f9072a7fff"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("f932f0c4-050a-4d4b-b96b-270c3d2a6b41"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("fae567a6-4162-4d5e-9257-739142ebdee6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("235f7494-3e7d-45a5-a31a-6d5449b1322d"), 2, 16, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("faec6f24-c413-443c-af6c-985759a2279c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 7, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("fb1b154d-0e5a-444a-8da6-a0e55a0ad54d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 4, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("fb6c9d03-d1eb-4076-9ecb-bf373bfdfe85"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("fb6dcc0a-3a9d-4e58-b43a-c8b84c596b10"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("9ba29558-e51b-4a1a-a1c4-b747967e32fb"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("fdcba335-1b8f-4add-b11b-12aa2e23ce90"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("fe43fc5d-66d6-4649-a33c-5acd3f66f726"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8619916d-a296-48a5-af89-f82a6a1cb26f"), 3, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("ff876e3c-d2c4-476b-ba6b-d7649ac2de9a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 3, 32, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("ff93e5be-528d-4a01-970e-a9102b2bdcd5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 1, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "ChatId", "Content", "CreatedAt", "IsRead", "SenderId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0d37e44f-d0d2-4a40-90ae-24e7e05c0f29"), new Guid("9b4dc3a1-5076-48f0-b91d-3d964ff1aa7d"), "Cảm ơn bác sĩ, tôi sẽ làm theo.", new DateTime(2025, 4, 10, 8, 56, 0, 0, DateTimeKind.Unspecified), false, new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), new DateTime(2025, 4, 10, 8, 56, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("1852bc57-4b6d-4f45-a120-017b0b4e0c26"), new Guid("9b4dc3a1-5076-48f0-b91d-3d964ff1aa7d"), "Bạn nên hạn chế muối, không uống rượu bia, và tập thể dục nhẹ nhàng.", new DateTime(2025, 4, 10, 8, 50, 0, 0, DateTimeKind.Unspecified), false, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 10, 8, 50, 18, 0, DateTimeKind.Unspecified) },
                    { new Guid("18a2f0bc-fd99-4b88-ae36-e25e4e132ba2"), new Guid("e7a3f1bd-d891-4a79-9086-9f3e79cf8e01"), "Bạn đã đi khám và dùng thuốc điều trị nào chưa?", new DateTime(2025, 4, 10, 8, 12, 0, 0, DateTimeKind.Unspecified), false, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 10, 8, 12, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("1fa1138e-7a18-49a5-8758-3a71e4990e03"), new Guid("f04b47df-8e5a-4bfa-8519-0ed5f9b1c7ea"), "Đúng vậy, tôi làm việc với máy tính cả ngày và ngủ không ngon.", new DateTime(2025, 4, 10, 8, 48, 0, 0, DateTimeKind.Unspecified), false, new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), new DateTime(2025, 4, 10, 8, 48, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("2ae31844-2cb9-4f4d-8cd1-bfb809b2d69a"), new Guid("e7a3f1bd-d891-4a79-9086-9f3e79cf8e01"), "Tôi bị tiểu đường tuýp 2, hay mệt mỏi và hay khát nước.", new DateTime(2025, 4, 10, 8, 8, 0, 0, DateTimeKind.Unspecified), false, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), new DateTime(2025, 4, 10, 8, 8, 44, 0, DateTimeKind.Unspecified) },
                    { new Guid("2b58be2c-20cf-439e-853e-b6ed7aa5d706"), new Guid("f04b47df-8e5a-4bfa-8519-0ed5f9b1c7ea"), "Tạm thời bạn chỉ cần thay đổi thói quen sinh hoạt. Nếu không cải thiện sau 1 tuần, hãy tái khám.", new DateTime(2025, 4, 10, 8, 30, 0, 0, DateTimeKind.Unspecified), false, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 10, 8, 30, 17, 0, DateTimeKind.Unspecified) },
                    { new Guid("2e345b2b-8d2e-4e9a-86f2-4fc9cb01ef02"), new Guid("f04b47df-8e5a-4bfa-8519-0ed5f9b1c7ea"), "Bạn có bị mất ngủ hoặc áp lực công việc gần đây không?", new DateTime(2025, 4, 10, 8, 33, 0, 0, DateTimeKind.Unspecified), false, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 10, 8, 33, 28, 0, DateTimeKind.Unspecified) },
                    { new Guid("2ea02b74-96e3-4fd5-b0a0-9bb3ecb9a209"), new Guid("f04b47df-8e5a-4bfa-8519-0ed5f9b1c7ea"), "Tôi sẽ thử thực hiện và cập nhật lại.", new DateTime(2025, 4, 10, 9, 12, 0, 0, DateTimeKind.Unspecified), false, new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), new DateTime(2025, 4, 10, 9, 12, 27, 0, DateTimeKind.Unspecified) },
                    { new Guid("3e8973e9-e1cf-44f5-a155-55a442198e27"), new Guid("9b4dc3a1-5076-48f0-b91d-3d964ff1aa7d"), "Tôi nên ăn gì để giảm huyết áp?", new DateTime(2025, 4, 10, 8, 52, 0, 0, DateTimeKind.Unspecified), false, new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), new DateTime(2025, 4, 10, 8, 52, 18, 0, DateTimeKind.Unspecified) },
                    { new Guid("3e8a2b1f-7f23-465b-b92d-d591b35c76de"), new Guid("e7a3f1bd-d891-4a79-9086-9f3e79cf8e01"), "Rất tốt. Bạn cần duy trì chế độ ăn ít tinh bột, nhiều rau xanh.", new DateTime(2025, 4, 10, 8, 20, 0, 0, DateTimeKind.Unspecified), false, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 10, 8, 20, 9, 0, DateTimeKind.Unspecified) },
                    { new Guid("6cf9b540-1ae0-41c8-9e2b-7a89e4c3fc08"), new Guid("f04b47df-8e5a-4bfa-8519-0ed5f9b1c7ea"), "Không có gì. Bạn thử áp dụng và theo dõi nhé.", new DateTime(2025, 4, 10, 8, 51, 0, 0, DateTimeKind.Unspecified), false, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 10, 8, 51, 51, 0, DateTimeKind.Unspecified) },
                    { new Guid("715b2dcf-8b1e-46aa-b16b-6e6b5242eecc"), new Guid("e7a3f1bd-d891-4a79-9086-9f3e79cf8e01"), "Cảm ơn bác sĩ rất nhiều!", new DateTime(2025, 4, 10, 8, 16, 0, 0, DateTimeKind.Unspecified), false, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), new DateTime(2025, 4, 10, 8, 16, 24, 0, DateTimeKind.Unspecified) },
                    { new Guid("75c64f06-1427-4a2b-90a3-8571e6375810"), new Guid("f04b47df-8e5a-4bfa-8519-0ed5f9b1c7ea"), "Chúc bạn mau khỏe!", new DateTime(2025, 4, 10, 9, 35, 0, 0, DateTimeKind.Unspecified), false, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 10, 9, 35, 31, 0, DateTimeKind.Unspecified) },
                    { new Guid("7b2b3b94-36f3-44c2-8e25-8f531e02c124"), new Guid("9b4dc3a1-5076-48f0-b91d-3d964ff1aa7d"), "Đó là chỉ số cao. Bạn đã từng bị huyết áp cao chưa?", new DateTime(2025, 4, 10, 9, 55, 0, 0, DateTimeKind.Unspecified), false, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 10, 9, 55, 9, 0, DateTimeKind.Unspecified) },
                    { new Guid("882eb55e-b1ea-4f1e-9e91-f28e36e03349"), new Guid("e7a3f1bd-d891-4a79-9086-9f3e79cf8e01"), "Tôi có nên kiêng hoàn toàn trái cây không?", new DateTime(2025, 4, 10, 8, 12, 0, 0, DateTimeKind.Unspecified), false, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), new DateTime(2025, 4, 10, 8, 12, 22, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b0151cf-c9fa-4707-96ff-4b324387cb30"), new Guid("9b4dc3a1-5076-48f0-b91d-3d964ff1aa7d"), "Bạn theo dõi chỉ số 3 ngày tới, nếu không giảm nên đi khám sớm nhé.", new DateTime(2025, 4, 10, 9, 56, 0, 0, DateTimeKind.Unspecified), false, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 10, 9, 56, 15, 0, DateTimeKind.Unspecified) },
                    { new Guid("aff2bdf2-2dc5-4957-8e3c-0377ecba3d21"), new Guid("9b4dc3a1-5076-48f0-b91d-3d964ff1aa7d"), "Chào bác sĩ, tôi thường bị chóng mặt và nhức đầu.", new DateTime(2025, 4, 10, 9, 40, 0, 0, DateTimeKind.Unspecified), false, new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), new DateTime(2025, 4, 10, 9, 40, 43, 0, DateTimeKind.Unspecified) },
                    { new Guid("b143ba57-3e1d-4172-8c7d-818f65332104"), new Guid("f04b47df-8e5a-4bfa-8519-0ed5f9b1c7ea"), "Bạn nên nghỉ mắt sau mỗi 30 phút làm việc và tập vài động tác giãn cơ.", new DateTime(2025, 4, 10, 9, 5, 0, 0, DateTimeKind.Unspecified), false, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 10, 9, 5, 18, 0, DateTimeKind.Unspecified) },
                    { new Guid("b5cc9df7-16f3-4d7a-a84d-2d03dca0de10"), new Guid("e7a3f1bd-d891-4a79-9086-9f3e79cf8e01"), "Chào bạn, bạn có thể chia sẻ thêm tình trạng sức khỏe hiện tại không?", new DateTime(2025, 4, 10, 8, 3, 0, 0, DateTimeKind.Unspecified), false, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 10, 8, 3, 8, 0, DateTimeKind.Unspecified) },
                    { new Guid("bb372046-86cb-4a49-bcf4-13b35fef8d25"), new Guid("9b4dc3a1-5076-48f0-b91d-3d964ff1aa7d"), "Trước đây tôi chưa từng bị, gần đây mới xuất hiện.", new DateTime(2025, 4, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), new DateTime(2025, 4, 10, 10, 0, 12, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf1ef4a0-6b7a-4c1d-8576-3ed08e7cece4"), new Guid("e7a3f1bd-d891-4a79-9086-9f3e79cf8e01"), "Tôi đang dùng Metformin theo chỉ định của bác sĩ.", new DateTime(2025, 4, 10, 8, 16, 0, 0, DateTimeKind.Unspecified), false, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), new DateTime(2025, 4, 10, 8, 16, 9, 0, DateTimeKind.Unspecified) },
                    { new Guid("c81d1b8a-c914-4b4b-813c-6f22623733c2"), new Guid("e7a3f1bd-d891-4a79-9086-9f3e79cf8e01"), "Không có gì, bạn giữ sức khỏe nhé!", new DateTime(2025, 4, 10, 8, 45, 0, 0, DateTimeKind.Unspecified), false, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 10, 8, 45, 17, 0, DateTimeKind.Unspecified) },
                    { new Guid("d1b2a250-bb24-43f2-b16a-23b8f3be0e07"), new Guid("f04b47df-8e5a-4bfa-8519-0ed5f9b1c7ea"), "Tôi hiểu rồi, cảm ơn bác sĩ.", new DateTime(2025, 4, 10, 9, 20, 0, 0, DateTimeKind.Unspecified), false, new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), new DateTime(2025, 4, 10, 9, 20, 5, 0, DateTimeKind.Unspecified) },
                    { new Guid("d44eafeb-d430-40e0-8673-f8a376b2bcdc"), new Guid("e7a3f1bd-d891-4a79-9086-9f3e79cf8e01"), "Không cần kiêng hoàn toàn, bạn có thể ăn táo, bưởi, dưa leo.", new DateTime(2025, 4, 10, 8, 21, 0, 0, DateTimeKind.Unspecified), false, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 10, 8, 21, 23, 0, DateTimeKind.Unspecified) },
                    { new Guid("e54cb8f4-b614-4a91-a962-66535378cd22"), new Guid("9b4dc3a1-5076-48f0-b91d-3d964ff1aa7d"), "Bạn có đo huyết áp gần đây không? Kết quả là bao nhiêu?", new DateTime(2025, 4, 10, 9, 24, 0, 0, DateTimeKind.Unspecified), false, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 10, 9, 24, 46, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea91e4b0-bbfc-4a9c-a73d-c3c118038528"), new Guid("9b4dc3a1-5076-48f0-b91d-3d964ff1aa7d"), "Bạn nên ăn rau xanh, chuối, khoai lang, cá và uống nhiều nước.", new DateTime(2025, 4, 10, 9, 48, 0, 0, DateTimeKind.Unspecified), false, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 10, 9, 48, 21, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec6f49fd-cbfb-4fe3-8a1f-cc99f40f5205"), new Guid("f04b47df-8e5a-4bfa-8519-0ed5f9b1c7ea"), "Tôi chưa từng thử. Có cần dùng thuốc không ạ?", new DateTime(2025, 4, 10, 8, 28, 0, 0, DateTimeKind.Unspecified), false, new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), new DateTime(2025, 4, 10, 8, 28, 15, 0, DateTimeKind.Unspecified) },
                    { new Guid("ee77a54e-fd3e-47db-9bc5-317e5fdc5f23"), new Guid("9b4dc3a1-5076-48f0-b91d-3d964ff1aa7d"), "Tôi đo sáng nay là 150/95.", new DateTime(2025, 4, 10, 8, 44, 0, 0, DateTimeKind.Unspecified), false, new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), new DateTime(2025, 4, 10, 8, 44, 18, 0, DateTimeKind.Unspecified) },
                    { new Guid("f6a28d85-bc92-4f47-9255-bb15822ef6a1"), new Guid("e7a3f1bd-d891-4a79-9086-9f3e79cf8e01"), "Chào bác sĩ, tôi cần tư vấn về chế độ ăn.", new DateTime(2025, 4, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), new DateTime(2025, 4, 10, 8, 0, 8, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa72b480-40a3-4aa6-b0e5-fc5bd882f301"), new Guid("f04b47df-8e5a-4bfa-8519-0ed5f9b1c7ea"), "Chào bác sĩ, dạo này tôi bị đau đầu liên tục.", new DateTime(2025, 4, 10, 8, 40, 0, 0, DateTimeKind.Unspecified), false, new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), new DateTime(2025, 4, 10, 8, 40, 34, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTimeSlots",
                columns: new[] { "ScheduleTimeSlotId", "CreatedAt", "ScheduleId", "Status", "TimeSlotId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("06b675c0-71fe-4174-b39e-289f9acc1975"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0b075731-ada1-4409-a7bb-63c94a7090f0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("21515171-04ee-46dc-b978-07bf7d01896d"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0ce6d751-a29b-4875-a681-3941dc78b8cf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a0c644a-83b2-4cc9-8d2e-2b17877303e3"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f670d3b-79a0-4a6f-9768-958eb9f8ba76"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("79370315-ebc7-49e3-b408-9f882e925d0b"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10d09994-76c2-44f9-b3ca-9d5403bb84d8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("14ac493d-31d3-464f-a7bb-57143fa4aa24"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("15ef8b2a-3866-40db-8ac1-440e4cc974a2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a089c869-6406-4007-8bfb-8098c02cde67"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1dc0e7f4-1ab0-4b28-9131-04750b695240"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("269e8602-5440-412a-9d89-b4bc97b37462"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("79370315-ebc7-49e3-b408-9f882e925d0b"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2a505ad2-b839-4378-995b-3e8c4c4f00f3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("79370315-ebc7-49e3-b408-9f882e925d0b"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3198f6cc-5245-4587-af3e-c4b7ec9bf941"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("38a4c7c0-41ee-4902-8f70-e89b90fc634a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3da82051-82ce-4c1c-82b1-6d797459aff3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("520de804-c65f-43f5-86c9-6bda15922fed"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("21515171-04ee-46dc-b978-07bf7d01896d"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52c59436-0732-4ae1-9835-3498a03bc7b4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1b7d907f-1f57-42bf-8c26-1d870f2159ea"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52e66f0f-3b7e-4c9f-95ba-3e5287a5d3cb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("55d82fc9-70e5-4b35-9dde-ae7ddb6dff73"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58e5f910-4db6-4405-a89a-0bb27690eb30"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a0c644a-83b2-4cc9-8d2e-2b17877303e3"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5928edd9-f09a-45c2-aaee-e941a77d5d6a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b6de2dc-0b81-489d-9249-5c558d2597c1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6142266d-1809-4776-a927-d7a12c63f89e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("625cbeba-deda-4c3f-ae2e-ca8ab4e7767c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("79370315-ebc7-49e3-b408-9f882e925d0b"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d246a83-49ac-4587-a3b0-370828b5fb44"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e914427-7085-4862-a63d-d904149264d1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("737d8c76-583a-489c-b3eb-aa174c1e0669"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7418481b-c081-481c-ad6e-6d87bc9dc329"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("79cb5a27-e82e-4d8d-bd1b-36d83b4b4b73"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1b7d907f-1f57-42bf-8c26-1d870f2159ea"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7b280b73-0fcd-49b8-8297-8316e7aba28a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7c204160-803d-4b11-bd7b-476c8f67ff49"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a0c644a-83b2-4cc9-8d2e-2b17877303e3"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7c481f52-39ae-44b1-8302-38aa786e79f6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ca3d30fe-255b-4bbe-bb7f-1c9f1d12a579"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7de42cac-a583-4e99-bb08-6d16e3d03e7d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ca3d30fe-255b-4bbe-bb7f-1c9f1d12a579"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("82d64434-67ce-4b4b-88b3-ac76798f72fc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("86197581-74a5-42a1-9025-46d315af092b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("79370315-ebc7-49e3-b408-9f882e925d0b"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("87e9b928-5cee-4fcd-bb35-e3007afbfaf4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8878700c-c674-4140-8c46-1132fbf21d52"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1b7d907f-1f57-42bf-8c26-1d870f2159ea"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("889e7722-107d-47f1-9c65-e744845a0449"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d4f1268-2672-4566-a1d5-6426260ec3e4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8db2641d-7255-46ce-9b5a-40afc2f45dbb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e733056-1771-49b7-ada9-3fa009f2d7b5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8fb45d56-c8f2-4c73-adbd-df105d5fccca"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9157daa4-677d-471e-a2a4-5e87343cce5b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a0c644a-83b2-4cc9-8d2e-2b17877303e3"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("925037e9-7745-4a31-a468-5c6c79512018"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ca3d30fe-255b-4bbe-bb7f-1c9f1d12a579"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("98ae0339-43dc-4027-a661-89ecc5054790"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1b7d907f-1f57-42bf-8c26-1d870f2159ea"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99699bcd-b330-447e-ada9-10c8a6f009fa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ca3d30fe-255b-4bbe-bb7f-1c9f1d12a579"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e7e7194-24b4-4352-9c60-2f688bbb3c9d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("68f7dc95-0090-4b7f-a044-5ff48ecf313c"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a316c965-f65a-48e7-bcf3-b9ab9c063b85"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("68f7dc95-0090-4b7f-a044-5ff48ecf313c"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a85bd434-bbb1-4ce6-99ec-72771ce458c3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aeb32b4f-9e0c-43ac-9aba-bb5473ded779"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a089c869-6406-4007-8bfb-8098c02cde67"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b2a8d754-fa1a-4419-b6d7-50cdf0500dc8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a0c644a-83b2-4cc9-8d2e-2b17877303e3"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b4693334-5d99-4c1b-a699-a426eb03436c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b6de39df-ed3e-4012-a80a-02ff4bcbd2f0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b778af2d-0ace-4569-b140-c7e1d94b3ce2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba1a7059-4041-47fe-96fa-69fa5aaf79e2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("21515171-04ee-46dc-b978-07bf7d01896d"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc9930eb-cca9-4a5d-827c-b4bd06489b9d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("79370315-ebc7-49e3-b408-9f882e925d0b"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("be3720b1-b9c7-4fae-8ba4-489fb659c383"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("21515171-04ee-46dc-b978-07bf7d01896d"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c422464e-5c4f-4bea-b0ec-7e7e62fc9f49"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("caa8c001-1fc4-4178-b558-e03932f68b8b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a089c869-6406-4007-8bfb-8098c02cde67"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb33e429-c622-40a7-8aef-df27da044b73"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a089c869-6406-4007-8bfb-8098c02cde67"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb87cbbe-6f7d-4336-9288-d7b66d13912e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ccc212eb-b1eb-4a07-8d3d-43452e4c1a11"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd1ae4a8-56a0-48b2-b7bf-7d59b9830be6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a089c869-6406-4007-8bfb-8098c02cde67"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf680ece-1ac1-4cd1-b491-0bdb82eddf4d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dae87f71-c02f-49e6-849c-b516eddc5b89"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dce62142-ad22-4f7a-901b-10c064f65b48"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1b7d907f-1f57-42bf-8c26-1d870f2159ea"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e023a050-835c-4db2-a77c-f916e2cef440"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ca3d30fe-255b-4bbe-bb7f-1c9f1d12a579"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e30fd0c2-ce74-48d9-bbd4-087db2512e40"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("21515171-04ee-46dc-b978-07bf7d01896d"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e35eac7b-68f4-4df1-8220-0f2ace781654"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e45ba5f9-887b-40a8-9a8d-1b91d61e3ab0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ca3d30fe-255b-4bbe-bb7f-1c9f1d12a579"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e516dad6-d7c6-4b7f-8e75-0c36bc1654a9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1b7d907f-1f57-42bf-8c26-1d870f2159ea"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e60be9e8-b91f-438c-a108-563b6e9cf747"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a0c644a-83b2-4cc9-8d2e-2b17877303e3"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea1f8c80-3e03-4595-b65d-b50c9a22fefc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f3488b16-228c-4bc5-a8cd-4c55cdc661aa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("68f7dc95-0090-4b7f-a044-5ff48ecf313c"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f7f3d937-4497-4d5e-8e07-bed5f5b4e940"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f9e09995-8c9c-4749-92e5-11c49bb1b366"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("feeff748-74a2-4a0c-ad6e-3c6bead46e60"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a089c869-6406-4007-8bfb-8098c02cde67"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ff12745a-9da6-461a-8e70-b31e24a091da"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                name: "IX_Devices_UserId",
                table: "Devices",
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
                name: "IX_Reports_BookingId",
                table: "Reports",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookingId",
                table: "Reviews",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleExceptions_ConsultantId",
                table: "ScheduleExceptions",
                column: "ConsultantId");

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
                name: "IX_Transactions_UserSubscriptionId",
                table: "Transactions",
                column: "UserSubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_WalletId",
                table: "Transactions",
                column: "WalletId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_WithdrawalRequestId",
                table: "Transactions",
                column: "WithdrawalRequestId");

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
                name: "IX_UserNotifications_NotificationId",
                table: "UserNotifications",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNotifications_UserId",
                table: "UserNotifications",
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
                name: "Devices");

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
                name: "Reports");

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
                name: "UserNotifications");

            migrationBuilder.DropTable(
                name: "WaterReminders");

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
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "TimeSlots");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "UserSubscriptions");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropTable(
                name: "WithdrawalRequests");

            migrationBuilder.DropTable(
                name: "Allergies");

            migrationBuilder.DropTable(
                name: "Notifications");

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
