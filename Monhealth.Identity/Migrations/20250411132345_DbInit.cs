using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class DbInit : Migration
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
                    ReferenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    ReferenceUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Views = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
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
                    CancellationReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReviewed = table.Column<bool>(type: "bit", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false),
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
                        principalColumn: "ConsultantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserSubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderCode = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        principalColumn: "UserSubscriptionId");
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        principalColumn: "TimeSlotId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WalletId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        principalColumn: "WalletId");
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
                    { new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F9c0e576b-c736-4c13-8f21-aa0b1649fe5c.jpg?alt=media&token=236a11b7-836c-4735-b4c8-109a58b41e45", "1568c1cc-245a-465c-b211-ec07f402549c", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "khanhpham@gmail.com", true, "Nguyen Pham Khanh", false, null, "KHANHPHAM@GMAIL.COM", "KUEM113", "AQAAAAIAAYagAAAAEFBmsp05Ths/Y0sqwwmZGBd289B3E+gox2rfKLJIL+CKJgsdrszAVphGvzXPM1Xy/g==", "0368309526", false, null, null, "d013bfb4-8582-4f64-be90-336df079c9dc", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "kuem113" },
                    { new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F467b63b9-c4c2-42c2-ba5a-71f294681586.jpg?alt=media&token=89eb5119-1669-4515-9dc6-9130672d3d50", "65d154b6-e97a-4ecd-8598-afd73080e8f1", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "duythunglungtinhiu@gmail.com", true, "Pham Hoai Duy", false, null, "DUYTHUNGLUNGTINHIU", "DUYPRO113", "AQAAAAIAAYagAAAAEClFG1BqJ1fEJ/rHG5hE0w9/fYb1HAOj1ob5NxVyFIDkHg9Qf8WaUJT12G4FoSkjpw==", "0967588443", false, null, null, "34c0aaca-e527-463e-b67d-e5aa1f20ff8a", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "duypro113" },
                    { new Guid("20041d5b-01e4-443f-9652-e39beb9748e5"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F92077987-c716-4efc-b039-12268e8cb97d.jpg?alt=media&token=903adb9c-41c4-4482-a439-3c758b3c050d", "8a7dd0cb-e15c-42e2-b4be-1615bac81bfe", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "consultant@gmail.com", true, "Van Huu Toan Con", false, null, "CONSULTANT@GMAIL.COM", "0987654321", "AQAAAAIAAYagAAAAELbLzGrzs2NfCaxh6ad7wF++BuORjl8UC99NCiNuKYyRRaN/BXY172FICkvgoauk8A==", "0987654321", false, null, null, "e65a8481-0585-4251-a265-3f83cebb707f", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "toanconsultant" },
                    { new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2Fef00731b-724a-4e80-8930-36b2abffbec6.jpg?alt=media&token=408e26ce-b249-4139-a919-5cac9082c35c", "6f17b25a-9e26-463a-90f7-c047bfeedb83", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quocdai@gmail.com", true, "Nguyen Quoc Dai", false, null, "QUOCDAI@GMAIL.COM", "DAINQ115", "AQAAAAIAAYagAAAAEHOPvYmw8B+d+IlX+3Oj2h2ITQSImHsaTDmpkn6FNKFUmpAllwJC3FZRmBbuY08mFQ==", "0932748924", false, null, null, "07e0c479-6c4f-4df4-8334-04cbc1538ee4", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "dainq115" },
                    { new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Ftests%2Fangrycat.jpg?alt=media&token=542becf5-173f-47c2-951b-b9f79578fa60", "595750a8-aa2b-4d76-980b-8702ef6d92eb", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "asd@gmail.com", true, "asd", false, null, "ASD@GMAIL.COM", "ASD", "AQAAAAIAAYagAAAAEMM30kadbhcn42b/JtTUMzEF5jE5kK+0WM1jOMGPS48WrzZNe7iJ2knwLZ1f08xHIA==", "0123456789", false, null, null, "82aade31-cb13-4a1a-b466-d0c913b0774a", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "asd" },
                    { new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2Fcb927cfb-c88a-48c6-abf7-e77c9ca1982d.jpg?alt=media&token=e6cbb66c-6ecb-45ef-ac25-29511f9e7adb", "4b02471e-e744-421c-a97d-ffda8179488f", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "khaitoi@gmail.com", true, "Phan Van Khai", false, null, "KHAITOI@GMAIL.COM", "XAUTRAI123", "AQAAAAIAAYagAAAAEO4/UqbcWaJfPsLMn8bpr8dY+mvlsqfAU7Vd2grbzrJBdAnS6Q/e2kN5dOojxjRluA==", "0963122758", false, null, null, "99da15ac-1e84-41bf-9205-e1ff2e9f698e", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "xautrai123" },
                    { new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F16296811-d53d-4415-a907-e899e206b492.jpg?alt=media&token=819eaa35-ae0f-4dc3-815d-4dc19ab22782", "f5f0c694-3d18-419a-b711-936c12a15251", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quangdalat@gmail.com", true, "Quang La Tui", false, null, "QUANGDALAT@GMAIL.COM", "QUANGSPA009", "AQAAAAIAAYagAAAAEL7SX98s66qHF6fj9QWu1jULFyhzax1lrEaILYpLGNvdFh4Yah5KaGulNzuPOJz3Vg==", "0999777712", false, null, null, "5db598d5-9e8f-4c00-98a6-7cd5cfc8e0e8", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quangspa09" },
                    { new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 0, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F92077987-c716-4efc-b039-12268e8cb97d.jpg?alt=media&token=903adb9c-41c4-4482-a439-3c758b3c050d", "09e0b1de-963f-46a2-bcba-f2dc4d468537", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "toanvan@gmail.com", true, "Van Huu Toan", false, null, "TOANVAN@GMAIL.COM", "VIPRO123", "AQAAAAIAAYagAAAAEAmoLzV+jj6AXSQ+jKCeP2IuRZPrGya4B6NOX6At+X0LwiWMtVV9EsAKfUSCe7Kf7w==", "0792766979", false, null, null, "d4bb3087-3e09-4481-96f9-69a5eb781f35", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "vipro123" }
                });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "BankId", "BankCode", "BankName", "CreatedAt", "CreatedBy", "LogoUrl", "ShortName", "Status", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("003f7668-a77b-4361-a001-119fd9f1605e"), "KLB", "Ngân hàng TMCP Kiên Long", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/KLB.svg", "KienLongBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("0309bfa4-a5b3-4ec2-a828-21664574e692"), "VIB", "Ngân hàng TMCP Quốc tế Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VIB.svg", "VIB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("040d7d43-c454-494e-8ed7-cd22d2bc8775"), "CIMB", "Ngân hàng TNHH MTV CIMB Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/CIMB.svg", "CIMB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("054800ea-7020-45fd-946e-fbda05a6f252"), "STB", "Ngân hàng TMCP Sài Gòn Thương Tín", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/STB.svg", "Sacombank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("06aa3a5f-5964-478c-af03-2ccca3729fa3"), "HSBC", "Ngân hàng TNHH MTV HSBC (Việt Nam)", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/HSBC.svg", "HSBC", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("0c2cb5ab-3257-4416-b0fd-4813bb0f9e39"), "ACB", "Ngân hàng TMCP Á Châu", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/ACB.svg", "ACB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("0c4100bc-4be1-4501-81eb-8c11681dbc24"), "DAB", "Ngân hàng TNHH MTV Số Vikki", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/DOB.svg", "VikkiBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("152d1781-995c-46c1-b1bb-86b77478a5a2"), "IVB", "Ngân hàng TNHH Indovina", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/IVB.svg", "Indovina Bank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("16836590-d395-49b0-be4e-ac176177f1f4"), "CBB", "Ngân hàng Thương mại TNHH MTV Xây dựng Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/CBB.svg", "CBBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("1b4e6597-7d56-4b6d-833d-c17f5755aad1"), "TPB", "Ngân hàng TMCP Tiên Phong", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/TPB.svg", "TPBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("1bbcc67d-751a-4498-adf8-1808440720c1"), "NAB", "Ngân hàng TMCP Nam Á", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/NAB.svg", "NamABank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("1c1aab9b-f026-49e4-be5c-76e2b5e1fae3"), "VCCB", "Ngân hàng TMCP Bản Việt", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VCCB.svg", "Ngân hàng Bản Việt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("1d40ae66-0f18-42f4-a629-2df41b64741c"), "NCB", "Ngân hàng TMCP Quốc Dân", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/NCB.svg", "NCB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("20b58316-69fa-41f7-9234-1c6c81d084d2"), "VARB", "Ngân hàng Nông nghiệp và Phát triển Nông thôn Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VBA.svg", "Agribank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("27fbda5c-29f3-457b-be54-efc2558c43a5"), "HDB", "Ngân hàng TMCP Phát triển Thành phố Hồ Chí Minh", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/HDB.svg", "HDBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("2f45f88b-9ba4-4a3a-989f-68015e99ac3d"), "SGB", "Ngân hàng TMCP Sài Gòn Công Thương", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SGICB.svg", "SaigonBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("327a2597-397d-4e45-be7d-f0e02b596849"), "DBS", "DBS Bank Ltd - Chi nhánh Thành phố Hồ Chí Minh", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/DBS.svg", "DBSBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("34a0e13b-edf2-4e99-8e36-4bd0e1715fe3"), "HLB", "Ngân hàng TNHH MTV Hong Leong Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/HLBVN.svg", "Hong Leong Bank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("397867dc-1a85-4a5a-b2bf-e0126ecddd8a"), "OCB", "Ngân hàng TMCP Phương Đông", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/OCB.svg", "OCB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("466fc91d-0cc1-45e6-b03b-a5579020d379"), "VB", "Ngân hàng TMCP Việt Nam Thương Tín", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VIETBANK.svg", "VietBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("46961534-b4b0-4236-ae99-61142f5f00c0"), "KBKHCM", "Ngân hàng Kookmin - Chi nhánh Thành phố Hồ Chí Minh", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/KBHCM.svg", "KookminHCM", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("47adf346-204d-4962-bad6-25352385e239"), "KB", "Ngân hàng Đại chúng TNHH Kasikornbank", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/KBank.svg", "Kasikornbank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("4bc6bd5a-531e-4c55-8fb3-06d6327700f3"), "SHB", "Ngân hàng TMCP Sài Gòn - Hà Nội", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SHB.svg", "SHB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("4d1684ab-560a-4d60-a6b0-1ad0d52bde93"), "VRB", "Ngân hàng Liên doanh Việt - Nga", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VRB.svg", "VRB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("570f82c9-d3bc-40a7-8fa1-059bd61fd407"), "VCB", "Ngân hàng TMCP Ngoại thương Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VCB.svg", "Vietcombank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("577f81c1-dbab-4f6e-b0e3-1631b45cf5a8"), "PBVN", "Ngân hàng TNHH MTV Public Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/PBVN.svg", "PublicBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("5de6330b-032f-4cc1-a965-f182c58e1d1f"), "VAB", "Ngân hàng TMCP Việt Á", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VAB.svg", "VietABank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("5e307359-2ebb-4a78-9b65-d5528d8d3192"), "MSB", "Ngân hàng TMCP Hàng Hải", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/MSB.svg", "MSB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("61acfe3f-c123-4d2e-b8bc-442541877b3b"), "OJB", "Ngân hàng Thương mại TNHH MTV Đại Dương", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/Oceanbank.svg", "OceanBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("6d2d4d8f-db04-4c1e-85e9-1ac3b74513fc"), "SHBVN", "Ngân hàng TNHH MTV Shinhan Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SHBVN.svg", "ShinhanBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("6dcf9452-a974-4834-b2b1-b8df0447f776"), "ABB", "Ngân hàng TMCP An Bình", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/ABB.svg", "ABBANK", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("71add674-721b-4320-b4db-8cf2e8c86803"), "BAB", "Ngân hàng TMCP Bắc Á", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/BAB.svg", "BacABank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("7a79c7d0-114a-4c0f-8a5f-b6e880ae19c5"), "IBKHCM", "Ngân hàng Công nghiệp Hàn Quốc - Chi nhánh TP. Hồ Chí Minh", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/IBK - HCM.svg", "IBKHCM", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("80021a92-ba3f-4489-ba88-949d64911782"), "LPB", "Ngân hàng TMCP Lộc Phát Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/LPB.svg", "LPBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("8201169f-7092-4efa-91bf-252254e122a8"), "GPB", "Ngân hàng Thương mại TNHH MTV Dầu Khí Toàn Cầu", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/GPB.svg", "GPBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("857f58a5-bd65-477f-aea7-8eac77cebfb7"), "VPB", "Ngân hàng TMCP Việt Nam Thịnh Vượng", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VPB.svg", "VPBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("928d963f-d0a8-4b59-a603-061b662bb6dc"), "TCB", "Ngân hàng TMCP Kỹ thương Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/TCB.svg", "Techcombank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("936666c3-12f6-406b-9de9-8367233aa6ba"), "BIDV", "Ngân hàng TMCP Đầu tư và Phát triển Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/BIDV.svg", "BIDV", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("9af77cb6-23c1-4aac-ab81-3dbe092342cd"), "MB", "Ngân hàng TMCP Quân đội", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/MB.svg", "MBBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("9bd9dbdf-4495-4cc0-b174-3bd01f094a41"), "COOPB", "Ngân hàng Hợp tác xã Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/COOPBANK.svg", "Co-op Bank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("a1fa8895-6013-4d43-a887-eb3c4684ff6f"), "BVB", "Ngân hàng TMCP Bảo Việt", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/BVB.svg", "BaoVietBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("a9838229-8e5c-4ffa-acbf-4d9c449a3908"), "NHB", "Ngân hàng Nonghyup - Chi nhánh Hà Nội", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/NHB HN.svg", "Nonghyup", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("a9bd570a-2bcc-49ed-8137-1c98be57c09c"), "SEAB", "Ngân hàng TMCP Đông Nam Á", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SEAB.svg", "SeABank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("b406d587-e63f-4177-9851-7a2478cc0430"), "VTB", "Ngân hàng TMCP Công thương Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/ICB.svg", "VietinBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("badc990d-e045-4bc9-91da-7021d5ee6534"), "SCBVN", "Ngân hàng TNHH MTV Standard Chartered Bank Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SCVN.svg", "Standard Chartered VN", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("c3e2758a-c56f-4599-9336-d8513485138e"), "IBKHN", "Ngân hàng Công nghiệp Hàn Quốc - Chi nhánh Hà Nội", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/IBK - HN.svg", "IBKHN", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("cc81bb3d-6af0-4937-b7ae-1aefa1d198cf"), "VNPTMONEY", "VNPT Money", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VNPTMONEY.svg", "VNPTMoney", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("d7142b7e-8ed6-48e2-9af2-000aab876591"), "UB", "TMCP Việt Nam Thịnh Vượng - Ngân hàng số Ubank by VPBank", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/Ubank.svg", "Ubank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("d7e306f4-2464-437a-ac11-657fe4b246a8"), "WOO", "Ngân hàng TNHH MTV Woori Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/WVN.svg", "Woori", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("db61f1e2-8c2d-49cc-9443-98af33f52abf"), "UOB", "Ngân hàng United Overseas", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/UOB.svg", "United Overseas Bank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("de25b355-3bff-4f34-a23b-1de1b3b9b36a"), "SGCB", "Ngân hàng TMCP Sài Gòn", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/SCB.svg", "SCB", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("e57a4162-a5e7-4180-9b12-8a587e8fa94a"), "VTLMONEY", "Viettel Money", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/VTLMONEY.svg", "ViettelMoney", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("ea479381-4723-4420-9883-7e9505d12607"), "EIB", "Ngân hàng TMCP Xuất nhập khẩu Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/EIB.svg", "Eximbank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("f21e7cdc-1afa-4120-ac05-ddca6d1b92a7"), "KBKHN", "Ngân hàng Kookmin - Chi nhánh Hà Nội", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/KBHN.svg", "KookminHN", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("f4f8ee5c-b870-4258-a887-ada91aa9a02d"), "PGB", "Ngân hàng TMCP Xăng dầu Petrolimex", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/PGB.svg", "PGBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("f50350e7-8fe1-442e-a90b-9beda4dfea9c"), "CAKE", "TMCP Việt Nam Thịnh Vượng - Ngân hàng số CAKE by VPBank", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/CAKE.svg", "CAKE", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("faacd7a3-f42c-47d6-bc04-cfda5f407464"), "PVCB", "Ngân hàng TMCP Đại Chúng Việt Nam", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/PVCB.svg", "PVcomBank", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("fe2c8a4b-72c9-4d81-973a-050623972b6f"), "TIMO", "Ngân hàng số Timo", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), "https://cdn.banklookup.net/assets/images/bank-icons/TIMO.svg", "Timo", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") }
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
                    { new Guid("5bc13328-01b0-4f09-a32b-5c2f3384c98c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(2983), null, "Snack", new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(2984), null },
                    { new Guid("640474cb-2135-4648-b921-fca3a9219533"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(2906), null, "MainDish", new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(2967), null },
                    { new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(2973), null, "SideDish", new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(2974), null },
                    { new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(2977), null, "Soup", new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(2978), null },
                    { new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(2986), null, "Drink", new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(2987), null },
                    { new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(2980), null, "Dessert", new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(2981), null }
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
                columns: new[] { "ConsultantId", "AverageRating", "Bio", "BookingCount", "CreatedAt", "Experience", "ExpertiseId", "RatingCount", "Status", "UpdatedAt", "UserId", "VerificationStatus", "Views" },
                values: new object[] { new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), 0.0, "Với kinh nghiệm hơn 2 năm trong lĩnh vực tư vấn tâm lý, tôi chuyên hỗ trợ những người gặp phải các triệu chứng trầm cảm, lo âu và căng thẳng kéo dài. Tôi tin rằng mỗi người đều có khả năng tìm lại sự cân bằng và hạnh phúc trong cuộc sống. Thông qua phương pháp trị liệu cá nhân hóa và sự đồng hành tận tâm, tôi giúp khách hàng từng bước vượt qua khó khăn, cải thiện sức khỏe tinh thần và xây dựng một cuộc sống tích cực hơn", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("8ad55299-b566-47e8-a9a0-1997e893e153"), 0.0, true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("20041d5b-01e4-443f-9652-e39beb9748e5"), 1, 27 });

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
                    { new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt heo bằm là nguyên liệu dễ chế biến, thường được dùng trong các món như thịt heo bằm xào rau, làm nhân cho các món bánh bao hoặc canh. Món này có hương vị mềm mại và giàu dinh dưỡng", "Thịt heo bằm", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì là món ăn nhanh, phổ biến với lớp vỏ giòn và nhân phong phú như thịt nướng, pate, trứng. Đây là lựa chọn lý tưởng cho bữa sáng hoặc bữa ăn nhẹ, dễ dàng mang theo và rất tiện lợi", "Bánh mì", true, "Breakfast,Lunch,Dinner,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau muống là loại rau lá xanh phổ biến ở Việt Nam, có thể xào, luộc hoặc làm canh. Rau muống giàu vitamin, khoáng chất và chất xơ, giúp hỗ trợ tiêu hóa và giải nhiệt", "Rau muống", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún chả cá là món ăn với bún, chả cá chiên hoặc hấp và nước dùng từ cá. Món ăn này có vị ngọt tự nhiên từ cá, rất phổ biến ở miền Trung và Nam Việt Nam", "Bún chả cá", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt gà quay là món ăn có lớp da giòn, thịt mềm, được ướp gia vị rồi quay chín. Món này thường được ăn kèm với cơm hoặc rau sống, rất ngon miệng và dễ ăn", "Thịt gà quay", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hoành thánh là món ăn từ bột mì, nhân thịt hoặc tôm, thường được nấu trong nước dùng thơm ngon. Món này có thể ăn trong các bữa sáng hoặc bữa tối, mang lại cảm giác ấm cúng và bổ dưỡng", "Hoành thánh", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau dền đỏ là loại rau xanh giàu vitamin C và chất xơ, giúp hỗ trợ tiêu hóa và tăng cường miễn dịch. Rau dền đỏ có thể xào, nấu canh hoặc làm món gỏi, rất bổ dưỡng", "Rau dền đỏ", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chuối tây là trái cây ngọt, dễ ăn, giàu kali và vitamin. Chuối tây thường được ăn trực tiếp hoặc làm tráng miệng, sinh tố, chè. Đây là món ăn bổ dưỡng và dễ tiêu hóa, thích hợp cho mọi lứa tuổi", "Chuối tây", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Táo là trái cây giàu vitamin C và chất xơ, tốt cho tiêu hóa và hệ tim mạch. Táo có thể ăn trực tiếp hoặc làm sinh tố, salad, giúp tăng cường sức khỏe và cung cấp năng lượng tự nhiên cho cơ thể", "Táo", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo đậu đỏ là món ăn nhẹ nhàng, làm từ đậu đỏ và gạo, có tác dụng bổ máu, thanh nhiệt. Món này có thể ăn vào buổi sáng hoặc tối, rất bổ dưỡng và dễ tiêu hóa", "Cháo đậu đỏ", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Quýt là trái cây ngọt, chứa nhiều vitamin C và giúp tăng cường hệ miễn dịch. Quýt có thể ăn trực tiếp hoặc làm nước ép, rất tốt cho sức khỏe, đặc biệt là giúp giải nhiệt trong mùa hè", "Quýt", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu hũ là món ăn được làm từ đậu nành, giàu protein thực vật. Đậu hũ có thể chế biến theo nhiều cách như chiên, nấu canh hoặc xào, mang lại hương vị thanh nhẹ và tốt cho sức khỏe", "Đậu hũ", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nho là trái cây ngọt, giàu vitamin C và chất chống oxy hóa, có tác dụng tăng cường sức đề kháng và làm đẹp da. Nho có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng", "Nho", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nấm kim châm là loại nấm có thân dài và mỏng, thường được dùng trong các món canh, xào hoặc salad. Nấm kim châm giàu chất xơ và khoáng chất, rất tốt cho sức khỏe, đặc biệt là hệ tiêu hóa", "Nấm kim châm", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2146faae-2e7c-4460-8d81-38f5d313012c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo đậu xanh là món ăn nhẹ, dễ tiêu hóa, được làm từ đậu xanh và gạo, có tác dụng bổ máu và thanh nhiệt. Món này có thể ăn vào bữa sáng hoặc tối, rất bổ dưỡng", "Cháo đậu xanh", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bao chay là món ăn làm từ bột mì, nhân là các loại rau củ, đậu hũ hoặc nấm. Đây là món ăn phù hợp cho những người ăn chay, với hương vị nhẹ nhàng và bổ dưỡng", "Bánh bao chay", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu hũ non là món ăn được làm từ đậu nành, có kết cấu mềm mịn. Đậu hũ non có thể chế biến thành các món xào, canh hoặc ăn kèm với siro, là món ăn dễ tiêu hóa và rất bổ dưỡng", "Đậu hũ non", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Khoai lang luộc là món ăn đơn giản nhưng giàu dinh dưỡng, cung cấp vitamin A, chất xơ và khoáng chất. Khoai lang có thể ăn trực tiếp hoặc dùng làm món ăn kèm trong các bữa chính", "Khoai lang luộc", true, "Breakfast,Snack,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2405ffc3-524e-4331-9e68-47a411d7b9b8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm chiên dương châu là món cơm chiên với các loại rau củ, tôm, thịt, trứng, mang đến hương vị đậm đà và đầy đủ dinh dưỡng. Món này thích hợp cho bữa trưa hoặc tối", "Cơm chiên dương châu", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cải thảo là loại rau xanh, thường được dùng trong các món xào, nấu canh hoặc làm gỏi. Cải thảo chứa nhiều vitamin và khoáng chất, giúp hỗ trợ tiêu hóa và cải thiện sức khỏe", "Cải thảo", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bao xá xíu là món bánh mềm mịn, với nhân thịt heo xá xíu thơm ngon. Món này rất phổ biến trong các bữa sáng hoặc bữa ăn nhanh gọn, giàu protein và dễ tiêu hóa", "Bánh bao xá xíu", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("29dfb5da-8818-40ff-bf66-7553521c2161"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bò kho là món ăn với thịt bò hầm mềm mịn, nước dùng đậm đà với gia vị thơm ngon. Món này thường ăn kèm với bánh mì hoặc bún, là bữa ăn đầy đủ và ấm áp", "Bò kho", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ae82bfd-34db-4928-bfee-b60f4aec4460"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh bí đỏ là món ăn thanh mát, giàu vitamin A và C. Canh bí đỏ có thể nấu với thịt heo hoặc tôm, mang lại hương vị ngọt tự nhiên, bổ dưỡng và dễ tiêu hóa", "Canh bí đỏ", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau cải xanh là loại rau giàu vitamin A, C và chất xơ, có thể chế biến thành các món xào, luộc hoặc nấu canh. Món rau cải xanh cung cấp nhiều dưỡng chất và giúp thanh nhiệt cho cơ thể", "Rau cải xanh", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì ốp la là món ăn sáng phổ biến với bánh mì giòn, nhân trứng ốp la và có thể kèm thịt, rau. Đây là món ăn nhanh gọn, dễ dàng và bổ dưỡng", "Bánh mì ốp la", true, "Breakfast,Lunch", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dâu tây là trái cây ngọt, chứa nhiều vitamin C và chất chống oxy hóa, giúp làm đẹp da và tăng cường sức đề kháng. Dâu tây có thể ăn trực tiếp, làm sinh tố, hoặc chế biến thành các món tráng miệng", "Dâu tây", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa đậu nành là thức uống từ đậu nành xay nhuyễn, giàu protein và vitamin. Đây là món ăn sáng phổ biến, bổ dưỡng, có thể uống nóng hoặc lạnh, đặc biệt tốt cho người ăn chay và những người muốn bổ sung dưỡng chất từ thực vật", "Sữa đậu nành", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ee163f7-4463-44ec-b9e2-8a409c112db4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau luộc là món ăn thanh mát, giúp bổ sung vitamin và khoáng chất, rất tốt cho sức khỏe. Các loại rau như rau muống, rau ngót thường được luộc và ăn kèm với nước mắm hoặc gia vị", "Rau luộc", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo lòng là món ăn sáng phổ biến, được làm từ cháo gạo nấu với các loại nội tạng heo như lòng, gan, dồi. Món này có vị đậm đà, thường ăn kèm với hành lá, rau thơm và gia vị", "Cháo lòng", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Khoai lang là một loại củ giàu vitamin và chất xơ, có thể chế biến thành các món như khoai lang luộc, chiên, hoặc làm món xào. Món này cung cấp năng lượng và rất tốt cho sức khỏe", "Khoai lang", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cải thìa là loại rau xanh giàu vitamin và khoáng chất, có thể chế biến theo nhiều cách như xào, luộc hoặc nấu canh. Cải thìa giúp giải nhiệt và tốt cho hệ tiêu hóa, thường dùng trong các bữa ăn gia đình", "Cải thìa", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp gà nấm là món ăn nhẹ nhàng với nước dùng từ gà và nấm, giúp thanh nhiệt và dễ tiêu hóa. Món này thường ăn vào bữa sáng hoặc khi cần bồi bổ cơ thể", "Súp gà nấm", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Măng khô là món ăn được làm từ măng tươi phơi khô, có thể chế biến thành các món canh hoặc xào. Măng khô có vị ngọt tự nhiên, giòn và là món ăn bổ dưỡng trong các bữa ăn gia đình", "Măng khô", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nước chanh là thức uống giải khát tuyệt vời, giúp cung cấp vitamin C, giải nhiệt và làm đẹp da. Món này có thể uống vào bất kỳ thời gian nào trong ngày, đặc biệt là trong mùa hè", "Nước chanh", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3d19d971-88d0-4108-a335-24ac9e1dec50"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Măng cụt là trái cây ngọt, mọng nước, chứa nhiều vitamin C và khoáng chất. Món này có thể ăn trực tiếp hoặc làm nước ép, mang lại cảm giác giải nhiệt và bổ sung dinh dưỡng", "Măng cụt", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3dc2fa80-ab87-4e26-907b-3516611371b8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh bầu là món canh thanh mát, với bầu nấu cùng nước dùng nhẹ nhàng từ xương hoặc thịt. Món canh này có tác dụng giải nhiệt, rất thích hợp trong những ngày hè nóng bức", "Canh bầu", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu nành luộc là món ăn nhẹ, giàu protein và vitamin. Đậu nành có thể ăn trực tiếp hoặc chế biến thành các món như đậu hũ, giúp bổ sung dinh dưỡng cho cơ thể", "Đậu nành luộc", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu bắp là loại rau quả giàu vitamin C và chất xơ, giúp hỗ trợ tiêu hóa và làm đẹp da. Đậu bắp có thể ăn luộc, xào hoặc làm canh, là món ăn bổ dưỡng cho các bữa ăn gia đình", "Đậu bắp", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cà chua là thực phẩm giàu vitamin C và chất xơ, có tác dụng làm đẹp da và hỗ trợ tiêu hóa. Cà chua có thể ăn sống, làm salad, hoặc chế biến thành các món xào, canh", "Cà chua", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("43d635e2-6f0c-4385-83d8-fedfd479d356"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt gà kho là món ăn đậm đà với thịt gà kho trong gia vị như nước mắm, tiêu, và gia vị khác. Món này có thể ăn kèm với cơm trắng, mang lại hương vị ngon miệng và bổ dưỡng", "Thịt gà kho", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dưa chuột là rau quả tươi mát, giúp giải nhiệt và làm đẹp da. Dưa chuột có thể ăn sống, làm salad, hoặc chế biến thành món xào và canh, rất thích hợp trong các bữa ăn hằng ngày để thanh lọc cơ thể", "Dưa chuột", true, "Breakfast,Lunch,Dinner,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún chả là món ăn đặc sản Hà Nội, gồm bún, thịt chả nướng, và rau sống. Món ăn này có nước mắm pha chua ngọt, tạo thành bữa ăn ngon miệng, đậm đà và rất dễ ăn", "Bún chả", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún mắm là món ăn nổi bật với nước dùng từ mắm, kết hợp với bún và các loại hải sản như tôm, cá. Đây là món ăn đặc sản của miền Tây, mang lại hương vị đậm đà và rất thơm ngon", "Bún mắm", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dừa tươi là thức uống giải khát tuyệt vời, giàu vitamin C và khoáng chất. Nước dừa cung cấp độ ẩm và giúp thanh nhiệt, rất tốt cho làn da và sức khỏe hệ tiêu hóa", "Dừa tươi", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tôm hấp là món ăn đơn giản, dễ chế biến, giữ nguyên vị ngọt của tôm. Món này thường được ăn kèm với muối tiêu chanh hoặc nước mắm chua ngọt, thích hợp cho bữa ăn nhẹ", "Tôm hấp", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4edcae53-7e30-42bb-8526-7686355f2268"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh cải xanh là món canh nhẹ, giàu vitamin và khoáng chất, thường được nấu với thịt heo hoặc tôm. Đây là món ăn bổ dưỡng, dễ tiêu hóa và thích hợp cho các bữa ăn thanh đạm", "Canh cải xanh", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu hũ chiên là món ăn phổ biến trong các bữa ăn chay, có kết cấu giòn bên ngoài và mềm mịn bên trong. Món này có thể ăn kèm với các loại nước chấm hoặc xào với rau củ", "Đậu hũ chiên", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("51061170-597d-4289-a021-1e7dde88331f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt vịt là nguồn protein giàu chất dinh dưỡng, có thể chế biến thành nhiều món như vịt nướng, vịt kho hoặc vịt luộc. Món thịt vịt thường có hương vị đặc trưng, đậm đà và thích hợp cho các bữa ăn gia đình", "Thịt vịt", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bò bít tết là món ăn từ thịt bò nạc, được nướng hoặc áp chảo đến độ chín vừa phải. Món này thường được ăn kèm với khoai tây chiên hoặc rau sống, mang lại hương vị đậm đà, rất thích hợp cho bữa tối", "Bò bít tết", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh chua cá là món ăn đậm đà với nước dùng chua ngọt, thường làm từ cá và các loại rau như giá đỗ, ngò rí, ăn kèm với bún. Món này thanh mát, giải nhiệt và rất bổ dưỡng", "Canh chua cá", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rong biển khô là thực phẩm giàu vitamin, khoáng chất và chất xơ, rất tốt cho sức khỏe. Món rong biển có thể dùng làm salad, súp, hoặc làm nhân cho sushi, rất phổ biến trong ẩm thực châu Á", "Rong biển khô", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ớt chuông là loại rau quả giàu vitamin C, giúp tăng cường sức khỏe và làm đẹp da. Ớt chuông có thể ăn sống, xào, hoặc làm salad, mang lại hương vị tươi mát và màu sắc đẹp mắt cho bữa ăn", "Ớt chuông", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cải bó xôi là rau xanh giàu vitamin A, C và chất sắt. Món cải bó xôi có thể ăn sống trong salad, xào hoặc nấu canh, giúp tăng cường sức khỏe xương và cải thiện hệ miễn dịch", "Cải bó xôi", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm là món ăn chủ yếu trong bữa ăn Việt Nam, cung cấp tinh bột quan trọng. Cơm thường ăn kèm với các món mặn như thịt, cá và rau, tạo nên một bữa ăn đầy đủ dinh dưỡng, bổ sung năng lượng cho cơ thể", "Cơm", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Lựu là trái cây giàu vitamin C, chất chống oxy hóa và khoáng chất. Món này có thể ăn trực tiếp hoặc làm nước ép, giúp cải thiện hệ miễn dịch và làm đẹp da", "Lựu", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá ngừ đóng hộp là món ăn tiện lợi, giàu protein và omega-3. Món này có thể ăn trực tiếp, làm salad hoặc kèm với cơm, rất dễ chế biến và thích hợp cho bữa ăn nhanh", "Cá ngừ đóng hộp", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp cua là món ăn nhẹ với nước dùng từ cua, mang hương vị ngọt tự nhiên và bổ dưỡng. Món này thường được ăn vào bữa sáng hoặc bữa tối, rất giàu protein và khoáng chất", "Súp cua", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt kho trứng là món ăn quen thuộc với thịt heo kho cùng trứng luộc, mang hương vị mặn ngọt đậm đà. Món này thường ăn kèm với cơm trắng, rất ngon miệng và bổ dưỡng", "Thịt kho trứng", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mì quảng là món đặc sản của miền Trung, gồm mì gạo, nước dùng đậm đà, tôm, thịt hoặc trứng, và rau sống. Món ăn này có vị đặc trưng và rất thích hợp cho bữa sáng hoặc trưa", "Mì quảng", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nấm đùi gà có hình dạng giống đùi gà, thịt nấm mềm và thơm. Món này thường được dùng trong các món xào, nấu canh hoặc làm salad, rất giàu dinh dưỡng và dễ chế biến", "Nấm đùi gà", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh cua mồng tơi là món ăn dân dã, có vị ngọt từ cua và mồng tơi. Món này không chỉ thơm ngon mà còn rất bổ dưỡng, đặc biệt tốt cho hệ tiêu hóa và làn da", "Canh cua mồng tơi", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau mồng tơi là loại rau xanh giàu vitamin A và chất sắt, có thể chế biến thành các món xào, luộc hoặc canh. Món rau này giúp thanh nhiệt, giải độc và tốt cho hệ tiêu hóa", "Rau mồng tơi", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6487a532-ff5e-4b77-b408-46c789608de9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh bí đao là món canh mát, giúp giải nhiệt và thanh lọc cơ thể. Bí đao có thể nấu với tôm, thịt heo hoặc cá, mang lại hương vị thanh đạm và rất bổ dưỡng cho sức khỏe", "Canh bí đao", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh rau ngót là món canh thanh mát, có vị ngọt tự nhiên từ rau ngót. Món này thường được nấu với thịt hoặc tôm, giúp giải nhiệt và bổ sung dinh dưỡng cho cơ thể", "Canh rau ngót", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì sandwich là món ăn nhanh với lớp bánh mì mềm, nhân có thể là thịt, rau, trứng hoặc phô mai. Đây là lựa chọn lý tưởng cho bữa sáng hoặc bữa phụ, dễ dàng mang theo khi đi làm hoặc đi học", "Bánh mì sandwich", true, "Breakfast,Lunch,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cà phê là thức uống quen thuộc, có thể uống đen hoặc thêm sữa, với hương vị đậm đà và kích thích tinh thần. Cà phê thường được uống vào buổi sáng hoặc trong suốt cả ngày để duy trì sự tỉnh táo", "Cà phê", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau má là loại rau mát, giúp thanh nhiệt, giải độc và làm đẹp da. Rau má có thể ăn sống trong salad hoặc nấu canh, rất tốt cho sức khỏe và có tác dụng làm dịu cơ thể trong mùa hè", "Rau má", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hủ tiếu là món ăn gồm mì hoặc bún ăn kèm với nước dùng thơm ngon và các loại thịt như tôm, gà, hoặc heo. Món này phổ biến ở miền Nam Việt Nam và rất dễ ăn, thích hợp cho bữa sáng hoặc bữa tối", "Hủ tíu", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo sườn là món ăn sáng phổ biến, với cháo mềm mịn kết hợp cùng sườn heo kho hoặc hầm. Món này có vị ngọt tự nhiên từ xương, thường ăn kèm với hành lá, rau thơm và gia vị", "Cháo sườn", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7167f942-dc89-4f29-8022-588373aef45e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún gà là món ăn thanh mát với bún, thịt gà luộc hoặc xé nhỏ và nước dùng thơm ngon. Đây là món ăn nhẹ nhàng, thích hợp cho bữa sáng hoặc bữa trưa", "Bún gà", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh bún là món ăn nổi bật với nước dùng ngọt từ xương, kết hợp với bún, thịt heo hoặc tôm. Món này thường ăn kèm với rau sống và gia vị, mang lại hương vị đậm đà và dễ ăn", "Canh bún", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sườn non là phần thịt heo mềm, có thể chế biến thành nhiều món như sườn nướng, sườn kho hoặc sườn xào chua ngọt. Món sườn non rất thích hợp cho các bữa cơm gia đình, có vị đậm đà và dễ ăn", "Sườn non", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bao là món ăn đơn giản, với lớp vỏ mềm mịn và nhân thịt heo hoặc trứng. Đây là món ăn nhanh gọn, thường được ăn sáng hoặc làm món phụ trong các bữa ăn chính", "Bánh bao", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cà rốt là rau củ giàu vitamin A, giúp cải thiện thị lực và sức khỏe da. Cà rốt có thể ăn sống, làm salad, hoặc chế biến thành các món xào, canh hoặc nước ép", "Cà rốt", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì thịt trứng là món ăn nhanh, với bánh mì mềm, nhân thịt nướng và trứng chiên. Đây là món ăn sáng phổ biến, đơn giản nhưng đầy đủ dinh dưỡng, dễ ăn và tiện lợi", "Bánh mì thịt trứng", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún xào là món ăn ngon miệng với bún xào cùng các loại rau và thịt hoặc tôm. Món này thường được chế biến nhanh, có vị thơm, ngọt từ các nguyên liệu kết hợp, thường ăn vào bữa trưa hoặc tối", "Bún xào", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm tấm sườn là món ăn phổ biến ở miền Nam Việt Nam, bao gồm cơm tấm mềm mịn ăn kèm với sườn nướng và các loại rau sống. Món này mang lại hương vị đậm đà và đầy đủ dinh dưỡng", "Cơm tấm sườn", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Măng tây là loại rau giàu vitamin K và chất chống oxy hóa, tốt cho sức khỏe tim mạch và hệ xương. Măng tây có thể xào, nấu canh hoặc ăn sống, rất bổ dưỡng và dễ chế biến", "Măng tây", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Kiwi là trái cây giàu vitamin C, chất xơ và chất chống oxy hóa. Kiwi giúp cải thiện hệ tiêu hóa, tăng cường sức đề kháng và làm đẹp da. Món này có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng", "Kiwi", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp bò hầm là món ăn có nước dùng đậm đà từ xương bò, với thịt bò mềm và rau củ đi kèm. Món này cung cấp năng lượng và dưỡng chất, rất phù hợp cho bữa tối", "Súp bò hầm", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b8500af-d730-4138-9617-cba352faed4a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Vải là trái cây ngọt, chứa nhiều vitamin C và khoáng chất. Vải có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng, đặc biệt trong mùa hè", "Vải", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7cd76708-7312-445e-a392-14f0e806a786"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu Hà Lan là loại rau giàu vitamin, khoáng chất và chất xơ, giúp hỗ trợ hệ tiêu hóa và tăng cường miễn dịch. Đậu Hà Lan có thể ăn trực tiếp, làm salad hoặc nấu canh", "Đậu Hà Lan", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún thịt nướng là món ăn gồm bún mềm, thịt nướng thơm ngon và các loại rau sống. Món này có thể ăn kèm với nước mắm pha, tạo thành một bữa ăn vừa thanh mát vừa đầy đủ dinh dưỡng", "Bún thịt nướng", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bầu là loại rau quả mát, chứa nhiều vitamin và khoáng chất. Bầu có thể chế biến thành các món canh, xào hoặc làm gỏi, giúp thanh nhiệt và hỗ trợ tiêu hóa", "Bầu", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá ngừ là loại hải sản giàu omega-3 và protein, có thể chế biến thành nhiều món như cá ngừ nướng, cá ngừ kho hoặc làm sushi. Món này rất bổ dưỡng và dễ dàng chế biến", "Cá ngừ", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("827829bf-71cd-4865-80af-1457e0091456"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh nấm là món ăn nhẹ, bổ dưỡng, giàu vitamin và chất xơ. Nấm có thể kết hợp với rau củ hoặc thịt để tạo ra món canh thơm ngon, rất phù hợp cho bữa ăn thanh đạm", "Canh nấm", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bông cải xanh (súp lơ) là loại rau chứa nhiều vitamin C, vitamin K và chất chống oxy hóa. Bông cải xanh có thể xào, luộc hoặc làm món canh, là món ăn bổ dưỡng giúp cải thiện sức khỏe", "Bông cải xanh", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8382816f-1beb-4804-9698-3b486798b20a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh mì chả lụa là món ăn sáng phổ biến, với bánh mì giòn và nhân chả lụa thơm ngon. Món này đơn giản, dễ ăn và thích hợp cho bữa sáng hoặc bữa phụ", "Bánh mì chả lụa", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt kho tiêu là món ăn đơn giản nhưng thơm ngon, thường làm từ thịt ba chỉ hoặc thịt heo kho với tiêu, nước dừa và gia vị. Món này có vị mặn ngọt đậm đà, ăn cùng với cơm trắng rất hợp", "Thịt kho tiêu", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Củ cải trắng là loại rau củ giàu vitamin C và chất xơ, giúp thanh nhiệt và giải độc cơ thể. Món củ cải trắng có thể ăn sống, xào hoặc nấu canh, mang lại hương vị thanh mát và bổ dưỡng", "Củ cải trắng", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Củ cải đường là loại củ chứa nhiều vitamin C và khoáng chất, giúp cải thiện sức khỏe tim mạch và huyết áp. Món củ cải đường có thể ăn sống, xào hoặc nấu canh, mang lại lợi ích cho cơ thể", "Củ cải đường", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Xúc xích là món ăn làm từ thịt xay (thường là thịt heo hoặc bò), tẩm gia vị và nhồi vào ruột lợn, sau đó luộc hoặc nướng. Xúc xích dễ dàng chế biến và là món ăn nhanh gọn cho bữa sáng hoặc bữa phụ", "Xúc xích", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("85e621ed-0e0c-4d20-8891-51d311cea4a3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh thịt bò hầm là món canh đậm đà, với thịt bò hầm mềm cùng các gia vị và rau củ. Món này bổ dưỡng, cung cấp nhiều protein và khoáng chất, thích hợp cho bữa tối hoặc bữa chính", "Canh thịt bò hầm", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ức gà nướng là món ăn ít mỡ, giàu protein, có thể được ướp gia vị và nướng chín. Món này thường được ăn kèm với rau củ hoặc cơm, là lựa chọn tốt cho bữa ăn nhẹ nhàng nhưng đầy đủ dinh dưỡng", "Ức gà nướng", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("86d88717-df08-4de6-b86d-870210864b46"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thanh long là trái cây ngọt, mát, chứa nhiều vitamin C và khoáng chất, giúp tăng cường sức đề kháng và làm đẹp da. Thanh long có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng", "Thanh long", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Phở bò viên là món phở nổi tiếng với nước dùng trong, đậm đà từ xương bò, ăn kèm với bánh phở mềm và bò viên. Món này mang lại hương vị thơm ngon, phổ biến cho bữa sáng", "Phở bò viên", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh bí đỏ nấu tôm là món canh nhẹ, thanh mát, với bí đỏ nấu mềm kết hợp với tôm. Món canh này giàu vitamin A và protein, giúp bổ dưỡng và dễ tiêu hóa", "Canh bí đỏ nấu tôm", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh mùng tơi mướp là món canh mát, giải nhiệt, giúp bổ sung dưỡng chất và hỗ trợ tiêu hóa. Món này thường được nấu với thịt hoặc tôm, mang lại hương vị thanh đạm và bổ dưỡng", "Canh mùng tơi mướp", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Khoai tây là nguồn cung cấp tinh bột và vitamin C. Khoai tây có thể chế biến thành nhiều món như khoai tây chiên, luộc, nghiền hoặc nướng, rất phổ biến trong các bữa ăn gia đình", "Khoai tây", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
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
                    { new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu que là loại rau quả giàu vitamin và chất xơ, có thể chế biến thành các món xào, luộc hoặc nấu canh. Đậu que giúp tăng cường hệ tiêu hóa và cung cấp năng lượng cho cơ thể", "Đậu que", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("982d8f3e-f517-4bd2-87a8-48329fc9eb91"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh cải ngọt là món ăn nhẹ nhàng, với cải ngọt nấu trong nước dùng, có thể kết hợp với thịt heo hoặc tôm. Món canh này bổ dưỡng, dễ tiêu hóa và giúp thanh nhiệt", "Canh cải ngọt", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa bò tươi là thức uống bổ dưỡng, cung cấp canxi, vitamin D và protein. Sữa bò có thể uống trực tiếp hoặc làm nguyên liệu cho các món sinh tố, mang lại nhiều lợi ích cho sức khỏe xương", "Sữa bò tươi", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau cải bó xôi là loại rau xanh chứa nhiều vitamin A, C và chất sắt. Món cải bó xôi có thể ăn sống trong salad, xào hoặc nấu canh, rất bổ dưỡng và tốt cho sức khỏe xương", "Rau cải bó xôi", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau chân vịt (cải bó xôi) là loại rau giàu vitamin A, C và chất sắt, giúp tăng cường sức khỏe xương và hỗ trợ miễn dịch. Rau chân vịt có thể ăn sống trong salad, xào hoặc nấu canh", "Rau chân vịt", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau muống xào tỏi là món ăn phổ biến, với rau muống tươi xào cùng tỏi và gia vị. Món này có vị đậm đà, thơm ngon, rất thích hợp ăn kèm với cơm trắng", "Rau muống xào tỏi", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cải ngọt luộc là món rau luộc đơn giản, dễ làm, giàu vitamin và chất xơ. Món này thường ăn kèm với nước mắm chua ngọt hoặc làm món ăn phụ trong các bữa ăn chính", "Cải ngọt luộc", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gạo lứt là loại gạo nguyên hạt, giàu chất xơ, vitamin và khoáng chất. Món gạo lứt có thể ăn kèm với các món thịt hoặc rau, giúp duy trì năng lượng lâu dài và rất tốt cho hệ tiêu hóa", "Gạo lứt", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cam là trái cây giàu vitamin C, giúp tăng cường miễn dịch và làm đẹp da. Cam có thể ăn trực tiếp hoặc làm nước ép, giúp giải nhiệt và bổ sung dinh dưỡng cho cơ thể", "Cam", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa chua là món ăn từ sữa lên men, chứa nhiều vi khuẩn có lợi cho hệ tiêu hóa. Sữa chua có thể ăn trực tiếp hoặc làm thành các món tráng miệng, bổ dưỡng và dễ tiêu hóa", "Sữa chua", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá hồi hun khói là món ăn giàu omega-3, có hương vị đậm đà và thơm ngon từ quá trình hun khói. Món này thường được ăn kèm với bánh mì hoặc làm thành salad, rất bổ dưỡng và dễ ăn", "Cá hồi hun khói", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm gạo lức được làm từ gạo lức chưa xay xát hoàn toàn, giàu chất xơ và dinh dưỡng. Món này cung cấp năng lượng lâu dài, tốt cho sức khỏe và rất phổ biến trong các bữa ăn hàng ngày", "Cơm gạo lức", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Xoài là trái cây ngọt, thơm, giàu vitamin C và chất xơ. Xoài có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng", "Xoài", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a364353c-d589-4a94-9c3b-3038113ea249"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bò xào rau củ là món ăn ngon với thịt bò thái mỏng xào nhanh với các loại rau củ như ớt, hành tây, cà rốt. Món này cung cấp nhiều vitamin và protein, thích hợp cho bữa tối bổ dưỡng", "Bò xào rau củ", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún riêu cua là món ăn nổi tiếng với nước dùng chua ngọt, kết hợp với cua, bún và các loại rau sống. Món ăn này mang hương vị đặc trưng và bổ dưỡng, phù hợp cho bữa trưa hoặc tối", "Bún riêu cua", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nước dừa là thức uống mát từ nước bên trong quả dừa, giúp giải nhiệt và bổ sung khoáng chất. Nó cũng rất tốt cho làn da và hệ tiêu hóa, thích hợp để uống trong mùa hè", "Nước dừa", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a504d882-4f38-413e-bb28-fae1f2787150"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nhãn là trái cây ngọt, mọng nước, chứa nhiều vitamin C và giúp tăng cường sức đề kháng. Nhãn có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng, rất tốt cho sức khỏe", "Nhãn", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mực là hải sản giàu protein và khoáng chất, có thể chế biến thành các món xào, hấp, hoặc nướng. Mực có vị ngọt tự nhiên, giúp bổ sung dinh dưỡng và rất dễ ăn", "Mực", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 27 },
                    { new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt lợn xông khói có vị mặn ngọt, được chế biến bằng cách xông khói để tạo hương vị đặc trưng. Món này có thể ăn kèm với cơm, salad hoặc làm nhân cho bánh mì", "Thịt lợn xông khói", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt bò nạc là phần thịt ít mỡ, giàu protein và sắt, có thể chế biến thành các món như bò xào, nướng hoặc làm súp. Món ăn này cung cấp năng lượng và dưỡng chất cho cơ thể, thích hợp cho các bữa chính", "Thịt bò nạc", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mâm xôi là trái cây giàu vitamin C và chất chống oxy hóa, có tác dụng tốt cho hệ miễn dịch và làn da. Mâm xôi có thể ăn trực tiếp hoặc làm sinh tố, chè, tráng miệng", "Mâm xôi", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp khoai tây là món canh ngon và bổ dưỡng, với khoai tây nấu mềm trong nước dùng nhẹ nhàng. Món này thích hợp cho bữa tối, mang lại cảm giác ấm áp và dễ tiêu hóa", "Súp khoai tây", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a988cc73-072e-4af1-9b53-55fbf0f4fe79"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Rau xào là món ăn đơn giản với rau củ được xào nhanh với gia vị. Món này thường sử dụng các loại rau như cải thảo, cải ngọt, giúp cung cấp vitamin và khoáng chất cho cơ thể", "Rau xào", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chuối là trái cây ngọt, dễ ăn, cung cấp vitamin C và kali. Chuối rất tốt cho hệ tiêu hóa và tim mạch. Món này thường được ăn trực tiếp, làm sinh tố hoặc chế biến thành các món tráng miệng như chè", "Chuối", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đào là trái cây ngọt, mọng nước, chứa nhiều vitamin C và chất chống oxy hóa. Món này có thể ăn trực tiếp, làm sinh tố hoặc chế biến thành các món tráng miệng, giúp tăng cường sức đề kháng", "Đào", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún là món ăn phổ biến ở Việt Nam, được chế biến từ gạo. Bún có thể kết hợp với các loại thịt, cá, hoặc rau, tạo thành những món như bún riêu, bún chả, bún bò Huế, mang lại hương vị đặc trưng", "Bún", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ức vịt nướng là món ăn ngon miệng, thịt vịt mềm và mọng nước khi được ướp gia vị và nướng chín. Món này có thể ăn kèm với cơm hoặc rau sống, mang lại hương vị đậm đà", "Ức vịt nướng", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá thu nướng là món ăn thơm ngon, giàu protein và omega-3. Cá thu thường được ướp gia vị rồi nướng, tạo nên món ăn đậm đà và bổ dưỡng cho bữa tối", "Cá thu nướng", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("af036922-79f3-45a7-b562-a6279520c0e6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Miến gà là món ăn nhẹ với miến mềm, nước dùng thơm ngon từ gà, ăn kèm với thịt gà xé nhỏ. Món này rất dễ ăn, thích hợp cho bữa sáng hoặc bữa trưa nhẹ nhàng", "Miến gà", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đu đủ là trái cây ngọt, giàu vitamin C và enzym papain, giúp tiêu hóa tốt. Đu đủ có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng, rất tốt cho sức khỏe và làn da", "Đu đủ", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đậu hà lan luộc là món ăn giàu protein và chất xơ, có thể ăn trực tiếp hoặc chế biến thành salad. Món này có vị ngọt tự nhiên, rất bổ dưỡng và dễ chế biến", "Đậu Hà Lan luộc", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh rau dền là món ăn nhẹ nhàng, thanh mát, thường được nấu với thịt hoặc tôm. Rau dền chứa nhiều vitamin và khoáng chất, giúp cải thiện sức khỏe và hỗ trợ tiêu hóa", "Canh rau dền", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá kho là món ăn đậm đà với cá kho trong nước mắm, tiêu và các gia vị khác. Món này có thể ăn kèm với cơm trắng, mang lại hương vị mặn ngọt và rất bổ dưỡng", "Cá kho", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt heo kho là món ăn với thịt heo được kho mềm, thấm đẫm gia vị mặn ngọt. Món này thường ăn kèm với cơm trắng, tạo thành một bữa ăn đậm đà và bổ dưỡng", "Thịt heo kho", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm chiên là món ăn phổ biến, được làm từ cơm nguội chiên cùng với thịt, trứng và rau củ. Món này thường ăn kèm với dưa leo hoặc salad, rất dễ ăn và tiện lợi", "Cơm chiên", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt gà là nguồn protein nhẹ nhàng, giàu dinh dưỡng. Thịt gà có thể chế biến thành nhiều món như gà kho, gà luộc, hoặc gà xào. Đây là lựa chọn phổ biến trong các bữa ăn hàng ngày", "Thịt gà", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bèo là món ăn dân dã của miền Trung, gồm bánh làm từ bột gạo, thường được phủ lên trên các loại tôm, thịt hoặc mỡ hành. Món này có thể ăn kèm với nước mắm chua ngọt", "Bánh bèo", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bắp luộc là món ăn đơn giản nhưng bổ dưỡng, chứa nhiều chất xơ và vitamin. Bắp luộc có thể ăn trực tiếp hoặc làm món ăn kèm trong bữa ăn, đặc biệt là vào mùa hè", "Bắp luộc", true, "Snack,Breakfast,Lunch", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Trứng gà luộc là món ăn đơn giản, giàu protein, vitamin B12 và khoáng chất. Trứng gà thường được ăn sáng hoặc dùng làm món phụ trong bữa ăn chính, giúp cung cấp năng lượng và duy trì sức khỏe", "Trứng gà luộc", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Yến mạch là ngũ cốc giàu chất xơ và vitamin, giúp giảm cholesterol và hỗ trợ tiêu hóa. Món yến mạch có thể nấu cháo hoặc làm sinh tố, thích hợp cho bữa sáng bổ dưỡng", "Yến mạch", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c5e3e4ed-0164-4917-a1ce-99679b971a22"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo gà là món ăn nhẹ, với cháo mịn và thịt gà chín mềm, thường ăn kèm với hành lá, rau thơm và gia vị. Món này dễ tiêu hóa, phù hợp cho bữa sáng hoặc khi bạn cảm thấy mệt mỏi", "Cháo gà", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh rau củ là món ăn nhẹ nhàng, giàu vitamin và chất xơ, thích hợp cho các bữa ăn dinh dưỡng. Các loại rau như cà rốt, khoai tây, đậu que được nấu chung tạo thành món canh thơm ngon, dễ ăn", "Canh rau củ", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mì gạo lứt được làm từ gạo lứt nguyên hạt, giàu chất xơ và vitamin. Món mì này có thể chế biến thành các món xào, soup hoặc ăn kèm với thịt, rất tốt cho sức khỏe và giúp giảm cholesterol", "Mì gạo lứt", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chôm chôm là trái cây ngọt, có vỏ đỏ hoặc vàng, mọng nước và giàu vitamin C. Món này rất thích hợp trong mùa hè, giúp giải nhiệt và bổ sung dinh dưỡng", "Chôm chôm", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hồng xiêm là trái cây ngọt, có hương vị đặc trưng, giàu vitamin C và khoáng chất. Món này có thể ăn trực tiếp hoặc chế biến thành các món tráng miệng, sinh tố, rất tốt cho sức khỏe", "Hồng xiêm", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh hẹ tôm là món canh thanh mát, với tôm và hẹ nấu chung trong nước dùng thơm ngon. Món này giúp bổ sung protein và vitamin, rất dễ ăn và thích hợp cho các bữa ăn nhẹ", "Canh hẹ tôm", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cơm chiên trứng là món ăn đơn giản nhưng ngon miệng, được làm từ cơm nguội xào cùng trứng, có thể thêm các loại rau và thịt tùy thích. Món này phù hợp cho bữa trưa hoặc tối nhanh gọn và đầy đủ dinh dưỡng", "Cơm chiên trứng", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa chua Hy Lạp là loại sữa chua đặc, chứa nhiều probiotics giúp hỗ trợ tiêu hóa. Món này có thể ăn trực tiếp hoặc kết hợp với trái cây tươi, mang lại cảm giác ngon miệng và bổ dưỡng", "Sữa chua Hy Lạp", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Thịt lợn nạc là phần thịt ít mỡ, dễ chế biến thành các món như xào, kho hoặc nướng. Món này cung cấp protein và chất sắt, thường được ăn trong các bữa chính", "Thịt lợn nạc", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá thu là loại hải sản giàu omega-3 và protein, rất tốt cho sức khỏe tim mạch. Cá thu có thể nướng, chiên hoặc kho, mang lại hương vị thơm ngon và bổ dưỡng cho bữa ăn", "Cá thu", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh canh là món ăn nổi bật với nước dùng đậm đà, có thể làm từ bún hoặc bánh canh, ăn kèm với các loại thịt như cua, tôm, hoặc giò heo. Món này rất phổ biến ở miền Trung và Nam Việt Nam", "Bánh canh", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bột lọc là món ăn đặc trưng của miền Trung, gồm vỏ bánh làm từ bột năng, nhân tôm hoặc thịt, sau đó hấp chín. Món này thường ăn kèm với nước mắm chua ngọt và rau sống", "Bánh bột lọc", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bún hải sản là món ăn đậm đà với bún, nước dùng từ hải sản và các loại hải sản như tôm, cua, mực. Món này có hương vị đặc trưng và rất bổ dưỡng", "Bún hải sản", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dưa cải chua là món ăn lên men, được làm từ cải thảo hoặc cải bẹ, mang vị chua nhẹ. Món này thường ăn kèm với cơm, giúp hỗ trợ tiêu hóa và bổ sung lợi khuẩn cho hệ tiêu hóa", "Dưa cải chua", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Phở gà là món ăn nhẹ nhàng, nước dùng thơm từ gà, ăn kèm với bánh phở và thịt gà. Món này có thể ăn vào buổi sáng hoặc bữa tối, rất thanh đạm nhưng đầy đủ dinh dưỡng", "Phở gà", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Hành tây là loại củ gia vị phổ biến, mang lại hương vị thơm ngon cho các món xào, canh hoặc salad. Hành tây có tác dụng tốt cho sức khỏe tim mạch và giúp cải thiện hệ tiêu hóa", "Hành tây", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chả lụa là món ăn được làm từ thịt heo xay nhuyễn, cuộn chặt và hấp chín. Món này thường dùng trong các bữa ăn chính, bánh mì hoặc cơm, mang lại hương vị ngọt mềm, thơm ngon", "Chả lụa", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá khô là món ăn truyền thống, có thể làm từ nhiều loại cá, chế biến bằng cách phơi khô. Cá khô có vị mặn, thơm, thường được ăn kèm với cơm trắng hoặc làm nguyên liệu cho các món canh", "Cá khô", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ức gà là phần thịt ít mỡ, giàu protein và dễ chế biến. Món ức gà có thể nướng, xào, hấp hoặc luộc, cung cấp năng lượng và dưỡng chất cho cơ thể, phù hợp với bữa trưa hoặc tối", "Ức gà", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nước cam là thức uống từ cam tươi, cung cấp vitamin C và chất chống oxy hóa. Nước cam là lựa chọn tuyệt vời để giải khát và bổ sung dưỡng chất cho cơ thể, đặc biệt trong mùa lạnh", "Nước cam", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cà phê sữa là thức uống phổ biến ở Việt Nam, được pha chế từ cà phê đen đặc kết hợp với sữa đặc ngọt. Món này có vị đắng nhẹ kết hợp với ngọt béo, thích hợp để uống vào buổi sáng để khởi đầu ngày mới", "Cà phê sữa", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh canh cua là món ăn đặc trưng với nước dùng đậm đà từ cua, ăn kèm với bánh canh mềm và các loại rau. Món này rất phổ biến ở miền Nam và mang lại hương vị thơm ngon, bổ dưỡng", "Bánh canh cua", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Xôi bắp là món ăn sáng đơn giản, được làm từ gạo nếp và bắp, có vị ngọt tự nhiên của ngô. Món này dễ ăn, cung cấp năng lượng cho cả ngày dài, thường được ăn kèm với thịt hoặc các món mặn khác", "Xôi bắp", true, "Breakfast,Lunch", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo vịt là món cháo nấu với thịt vịt, có vị ngọt tự nhiên từ thịt và xương vịt. Món này thường được ăn vào bữa sáng hoặc bữa tối, giúp cung cấp năng lượng và dưỡng chất", "Cháo vịt", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e370081a-c0a6-4c00-b01c-7c52f953b7f1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Canh mướp là món ăn thanh mát với mướp nấu trong nước dùng nhẹ nhàng từ xương hoặc thịt. Món canh này có tác dụng giải nhiệt, rất thích hợp vào mùa hè", "Canh mướp", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Lê là trái cây ngọt mát, giàu vitamin C và chất xơ, giúp cải thiện hệ tiêu hóa và làm đẹp da. Lê có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng", "Lê", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tôm là hải sản giàu protein, omega-3 và vitamin, rất tốt cho sức khỏe tim mạch. Tôm có thể chế biến thành nhiều món ăn như xào, hấp, hoặc nấu canh, tạo hương vị tươi ngon cho bữa ăn", "Tôm", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo sườn non là món ăn thơm ngon, với cháo được nấu từ xương sườn heo, có vị ngọt tự nhiên từ xương. Món này thường được ăn kèm với hành phi và gia vị, thích hợp cho bữa sáng", "Cháo sườn non", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Súp hải sản là món ăn đậm đà với nước dùng từ hải sản như tôm, cua, mực, nấu cùng với rau củ và gia vị. Món này rất bổ dưỡng và thích hợp cho các bữa ăn chính", "Súp hải sản", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dưa hấu là trái cây giải nhiệt, chứa nhiều nước và vitamin C. Đây là món ăn lý tưởng trong mùa hè, giúp cung cấp nước và dưỡng chất cho cơ thể, có thể ăn trực tiếp hoặc làm sinh tố", "Dưa hấu", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá hồi nướng là món ăn bổ dưỡng, giàu omega-3 và protein, thường được ướp gia vị trước khi nướng. Món này có hương vị ngọt tự nhiên, thích hợp ăn kèm với rau sống hoặc cơm", "Cá hồi nướng", true, "Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("eec3d874-6331-4e33-bbe6-bf0cc4335b29"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Salad rau là món ăn nhẹ, là sự kết hợp của các loại rau tươi như xà lách, cà chua, dưa leo, trộn với nước sốt chua ngọt hoặc dầu olive. Món này bổ dưỡng, giàu vitamin và chất xơ", "Salad rau", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh bao trứng cút là món bánh bao với nhân thịt heo hoặc đậu xanh, kèm trứng cút. Bánh có vỏ mềm, nhân thơm ngon, thường được ăn sáng hoặc làm món ăn phụ trong các bữa ăn chính", "Bánh bao trứng cút", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh cuốn là món ăn làm từ bột gạo, nhân thường là thịt băm, nấm hoặc trứng. Bánh cuốn mềm mịn, ăn kèm với nước mắm và rau sống, thường được dùng trong bữa sáng hoặc bữa phụ", "Bánh cuốn", true, "Breakfast,Lunch", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mận là trái cây ngọt, mọng nước, chứa nhiều vitamin C và chất chống oxy hóa, giúp tăng cường sức đề kháng và làm đẹp da. Mận có thể ăn trực tiếp hoặc làm sinh tố, chè", "Mận", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Xôi mặn là món ăn từ gạo nếp, kết hợp với thịt, lạp xưởng hoặc trứng. Món này thường được ăn vào buổi sáng hoặc trong các dịp đặc biệt, rất bổ dưỡng và dễ ăn", "Xôi mặn", true, "Breakfast,Lunch", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa hộp Milo là thức uống bổ dưỡng chứa nhiều vitamin và khoáng chất, phù hợp cho trẻ em và người lớn. Milo có hương vị ngọt ngào, thường được uống vào bữa sáng hoặc giữa các bữa ăn", "Sữa hộp milo", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ổi là trái cây giàu vitamin C, giúp tăng cường hệ miễn dịch và làm đẹp da. Ổi có thể ăn trực tiếp hoặc làm sinh tố, nước ép, rất tốt cho sức khỏe, đặc biệt là trong việc hỗ trợ tiêu hóa", "Ổi", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cháo thịt bằm là món cháo có thịt heo xay nhuyễn, nấu cùng với gạo và gia vị. Món này bổ dưỡng, dễ ăn và dễ tiêu hóa, thích hợp cho bữa sáng hoặc bữa ăn nhẹ", "Cháo thịt bằm", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sữa chua nha đam là món tráng miệng được làm từ sữa chua và nha đam tươi, giúp làm đẹp da và hỗ trợ tiêu hóa. Món này mát, dễ ăn và rất tốt cho sức khỏe, đặc biệt là trong thời tiết nóng", "Sữa chua nha đam", true, "Snack,Breakfast", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("faf19891-525a-4308-9222-992e83de7ce7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cá hồi là loại hải sản giàu omega-3, tốt cho sức khỏe tim mạch. Cá hồi có thể chế biến thành nhiều món như nướng, hấp, hoặc làm sushi, mang lại hương vị tươi ngon và bổ dưỡng", "Cá hồi", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bánh ướt là món ăn nhẹ làm từ bột gạo, có kết cấu mềm mịn, thường được ăn kèm với thịt heo, chả lụa và rau sống. Món này có thể được rưới nước mắm chua ngọt, mang lại hương vị thơm ngon và thanh mát", "Bánh ướt", true, "Breakfast,Lunch", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mướp là loại rau quả mát, chứa nhiều nước và vitamin. Mướp có thể chế biến thành canh, xào hoặc làm món gỏi, giúp thanh nhiệt, giải độc và tốt cho hệ tiêu hóa", "Mướp", true, "Breakfast,Lunch,Dinner", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chuối tiêu là trái cây ngọt nhẹ, giàu kali và vitamin C, giúp hỗ trợ tiêu hóa và cung cấp năng lượng. Chuối tiêu có thể ăn trực tiếp hoặc chế biến thành các món tráng miệng như chè chuối hấp", "Chuối tiêu", true, "Breakfast,Snack", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
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
                    { new Guid("01b43be6-81a7-4c61-ac1c-142246bf6ef6"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("029c1346-67a7-459b-8349-00be565b2ed6"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("039b6f74-ac93-43f0-aadc-cb916de942d3"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("074bbc3a-1ed7-4f1f-866e-f802662c7b6c"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0bf9925e-0139-44b5-a894-6db7ef392545"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0cd35962-de61-498d-9410-854b9f77c577"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0cddc159-8bc1-4a22-8525-6509b9eb0286"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d521380-9b5a-449b-b012-0a20b3d5358c"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0daed600-7c8c-4f42-bed4-3902263faed3"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0e33b601-55f0-4f5a-ba7d-8438bc807724"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f9d0a1d-d22b-4b49-b1d8-ea3d8ea8ae9b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("140fc596-a296-4526-99a1-b289d55b0545"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("15e551a3-619d-4966-a46a-fb7d1bbadeb9"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17b7ea55-3418-499e-b1be-adcf11566d2a"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0292d477-d63b-4904-a83b-2cd8cac39c14"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17d2a41e-6e42-4754-a341-406bebf0630b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("51061170-597d-4289-a021-1e7dde88331f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1810a7b3-b725-42fd-bb9d-a69b002f857d"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("192b0757-7a5b-43b1-9470-c8206749c65f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1c6d3526-1f6e-48a1-bf1e-6b0e3e5081bd"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e3478b6-b814-4fd0-9f7a-40836d137444"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1efef226-c581-43b4-91b9-dcc2d6071fa6"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("20bcd506-7741-4648-a04a-744a2d0183bf"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("20e5c6e8-6ab7-4a42-8488-a666b86fd7bb"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22255274-405a-439e-a301-3e0eebeec6e6"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("25485140-0286-4489-901f-b83eec7b0785"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("257403ae-96de-4f7e-9152-90a0b7d4f1d9"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("25ae3883-d06c-4d47-b0b8-15ec1d8f149e"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("27885123-a88e-4914-859d-205b29435f95"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("278d852a-8cc4-4899-8abc-03edd19aaf7d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("29220f42-bf52-430e-a8e7-8c7b83167c50"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("29480fb5-e453-4fc2-8b82-9de2c58eb048"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("29f15db9-d9cc-474a-897c-6237db780838"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2bfcc61d-475a-4b08-ac01-1eb77e9dd68f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7167f942-dc89-4f29-8022-588373aef45e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c6e0ae1-ee2f-40db-89c5-2315c13f3396"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c942047-5f41-401b-b52e-7b58815e2002"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2caaff5f-6eb5-4436-8ac5-119a4876e998"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2d2bf0ad-a605-4b0a-94fe-e4bf0be91730"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2d39b365-2fe2-4325-8492-5ae21e44bd6e"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2dd1242a-b494-4d1d-8ffd-b351f0c9595e"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2dddcd4b-e9c4-41eb-b63a-2df8a8a7fa22"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2ded64c8-5aa3-42d0-9df7-7fc6c9e52b48"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2146faae-2e7c-4460-8d81-38f5d313012c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3143d88d-2bd4-4e28-a13e-3386ccbd8520"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("327c0b29-abe1-47d0-bf2e-e11ce8c677b4"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("33b9a4a3-28ec-49fc-b36e-4f5a2bef1cfd"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("344d1652-2686-4072-a257-64849f0cbf88"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("34c6888c-3cfc-4d15-83ec-33ca3ef29438"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("35cd94dd-14d4-4cbb-b92a-82231462b860"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3637f2ce-a3d0-4872-9e32-9edf8f5b5c96"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2405ffc3-524e-4331-9e68-47a411d7b9b8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37188e8f-a6b8-4ba8-87da-d2798635645b"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("372b7451-305e-4723-a0c6-20f4d250cf49"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37f4a894-d803-4c40-8c86-a9a4c5828930"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("394369d3-fcea-4be6-9a32-df2bbede6dac"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3981107e-6a21-4703-ac9b-6bc2f226421f"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3b8022f6-44c1-40b4-8413-0c4d8af5d305"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c804ac1-907d-4a80-95c1-f30a0f5acd30"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3e00ba0d-f6a0-4da1-9561-bbe497744bae"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f401c20-54ae-49e7-b0d7-77f01a0746a3"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3fc0da3f-6999-488e-99c9-8f3116702037"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("40a458ad-2535-4a1e-8001-39e7b7afee40"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("40e8a2ec-68b1-4a42-87f6-5f2555a76433"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("440a2193-a35f-40a5-87bf-229ce4dfb68e"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("446c25bf-b5f3-4256-aa1d-bb0ffca58483"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4480db37-82c3-41fe-949e-8ec9904512f5"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("451d83a1-bfb2-4d28-830f-dc716970ea15"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("45492717-8d09-4233-8651-704d4c6acd4d"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4856f8f3-6dc2-4d0d-afca-5d3ff5769fa5"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49ff7192-fd46-435b-aace-39223d4e3306"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4cce2ab4-e48f-4c13-8832-8ec4a4a54d5c"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4d3d55f7-4572-4414-8eed-ee8380e98376"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f8ff795-c94a-460c-9ede-e5737ca8c547"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5015a10f-a233-4d63-8db8-852773fcba0f"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("501a51f7-0ca1-424e-bb09-c4ff0ef6f076"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52677737-e744-46d0-80c9-0b9a6faabf4c"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a364353c-d589-4a94-9c3b-3038113ea249"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("53421f05-690b-4757-84d8-f465b9d3dddc"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("55310c34-c1a0-4d94-9e68-76a8c5d1419b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00bc33fe-4cd5-47df-bd94-15ac9f93648c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("570d0d9c-58c6-4eac-a54c-b04b4fdb5f5e"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("578e8826-2b7e-4453-9a1a-3ed9f1542387"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5869b155-281d-49c8-978f-bcba20a43be2"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("587ca0ee-b8b9-4ecc-afeb-e57f1901eecf"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("59160ce8-2ed6-4d78-8ef5-f7b463453b44"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5ac3f1d9-1c8d-4da7-acdd-651befbbbe22"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5c15950b-127a-4497-9837-02c01d1f16e1"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5c530642-05ba-4b5f-9347-f3b70043743f"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5caf234a-7a1f-4361-8366-911f8cbb4d4c"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d5aa268-ffca-4c61-a444-a7315416b02b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d60cac1-a88f-41c1-8e03-daa3ddca0f80"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5ded0a57-d83a-464d-83e2-d20a548dd322"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("61315286-da62-49bb-be13-36cebc045fdb"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("62da172c-d622-4576-8265-9ea5faf18cb3"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("638accd0-ad1f-4d99-8d37-fb6593554191"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("64344b71-e9fc-4435-9079-850495679eba"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("65374e9a-7d80-4758-bf6e-5807edfcf7af"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("86d88717-df08-4de6-b86d-870210864b46"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("65be164f-7728-40a1-9979-99bdb67e9ca5"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66810dda-38ba-4136-be27-50ab8c30c5f8"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("67a880f7-4b76-41e6-9955-98b6e5f2aa26"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("faf19891-525a-4308-9222-992e83de7ce7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("68ef061a-ce9e-4da9-9442-093326c7a73a"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6ac09ea9-2ca8-4b58-8894-48e5d67a5005"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6c44e90c-6a4f-4455-b0bb-3c25824ebbf0"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6c512774-e360-4f6f-97a6-a95417d067f8"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a504d882-4f38-413e-bb28-fae1f2787150"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6ed26ab8-bc86-44f6-9378-6fff9f6e421a"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("af036922-79f3-45a7-b562-a6279520c0e6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("70e9f9a7-e334-4a9e-a206-d3638b5e6218"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("710f9c4d-76fc-4b1f-8927-5eb532848d6a"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71c57df9-d606-438e-8407-c85374dbe047"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("735218a6-5932-4fd3-9e7d-a6ced947fda6"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ed85dc2-7654-4c48-81f9-19946a73f71d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("738de059-9569-43b0-8b9f-fdfae3219d2e"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("74902526-9061-482e-8708-08212994bca4"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75832d0e-1c8e-46be-a635-1e95f50e2579"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7bf91a84-de63-4465-b436-f21217deaa95"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7dfa602a-1134-4169-862d-aa3e4255fa9b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ede72db-c875-4b3e-90fa-e52c17440e49"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f2ed0a7-a884-4868-9758-6649690fbf91"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f94ed70-dc93-43fc-82ab-41acb675e254"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7fd057ef-4dc9-4ed9-a12c-4014fe5899b6"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("80910755-c07d-4254-a5e0-3cfbb47aeb9f"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3dc2fa80-ab87-4e26-907b-3516611371b8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81766f1d-a574-414e-b0d9-db53a846495c"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81e12142-2104-43a4-b654-ee192c25a939"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("83c49413-cc76-4114-94ee-68a4b8ca1048"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b8500af-d730-4138-9617-cba352faed4a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8732011c-0eb3-4e22-8805-328027319f9b"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("87ced52c-087f-426b-abc2-89baf886d5af"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88a52158-52a4-451c-9bc6-041717787dfc"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88a6eacf-588b-4e81-bd66-2b930cdb1a90"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b20361e-acf7-428f-a79d-57e016b4024c"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c5a2ff6-23a1-4ed7-b202-110350485356"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8cb0fe75-b2a2-4a2c-bc18-103fd02a60c6"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d85688c-066b-42aa-94f5-55dfc3a1e1c7"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("90afed94-45b8-48fc-a1e8-e1b63eb86d3a"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("91c28a3b-7aea-431b-b571-5719689f5030"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92330d61-22ff-4b60-a02f-b7699c034774"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9314a19e-814c-417f-9a65-f84a98efbb30"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("937a9404-a8b0-4504-b3b4-bed8f0f0bfb7"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9507cdc7-2bd9-4041-857d-2c3917af8fe1"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("29dfb5da-8818-40ff-bf66-7553521c2161"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9961612d-6e2e-41a5-a2a9-db5d5eba1ebf"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7cd76708-7312-445e-a392-14f0e806a786"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9ab65e00-63ef-457a-ad6d-67079dc9d91a"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b0feb51-aedd-4df0-80ce-1f4f35a75c6a"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9d6f12c9-946f-43c6-9e75-ffb7fd21a989"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e4a6eb1-49e8-45e4-b107-08c79b32a5d4"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e70fa8c-ce1a-4939-9988-9159da211324"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a3d7c381-4848-4b37-9851-c157722d43cb"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("827829bf-71cd-4865-80af-1457e0091456"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4832ab0-6c40-4e48-8854-e04545c5a7db"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a5df6b60-c9bd-4f88-b8db-262dee198904"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a600c249-cd88-4841-89eb-b56851432b2e"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a9014cd1-815d-49b2-842c-a6857b8e4bc0"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac8b17d8-2013-47cc-b4c3-d42d054595d7"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae6b2e64-713a-40bc-8c78-fc9da6050edc"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b04482e0-fe0c-4754-b7f4-2d714780dd18"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b1a11d10-b332-4794-a9df-0256c598682c"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b1bda46c-f181-4f41-8e88-5194366f6667"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c5e3e4ed-0164-4917-a1ce-99679b971a22"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b22a13e8-21d2-418e-926d-058e3b2859a4"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3ff45cb-ac06-425f-a6fe-51c72b7f25d5"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b4c1ffd1-e691-4b6c-b6a1-21311534c0d8"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b5fe9f36-dcf0-4702-b05b-26f623131e36"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b7ad8019-841a-4de9-b892-649ca90e4d80"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("baf825fa-f326-47be-93f4-8b46c3c13d1a"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bb037123-8b65-4129-ae52-f12949b2c0ea"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc423c25-d72d-47a2-9c2f-b5e0f8630027"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd298f25-3677-4427-af50-0d1eb69a7816"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d19d971-88d0-4108-a335-24ac9e1dec50"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd52e803-bce6-471c-8200-44e8711c6d0d"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd53ecdd-316e-4592-b07c-68bf27123d63"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4edcae53-7e30-42bb-8526-7686355f2268"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd7dceb6-d5bf-4376-9955-8f3e23ff2239"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bfaffdc4-7964-44c4-ba3b-4e22e24ba053"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c180c622-6066-4df6-a446-f55fdcddc739"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c1f55ef6-e981-41ea-b9f7-02350823e952"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c26dc703-1bc1-42ec-91e0-bd61a11e48b2"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c364241e-b166-4ec9-920d-28fd9212d3fb"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4a83619-e380-4223-8961-69249e9e1347"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4b0269c-e10a-486e-b7cc-6f82a0e75b34"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c71726ea-fc9d-4984-b3ea-2161a1889085"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c9d92020-f7d7-4fcc-930d-6fa61b48aad0"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca597c18-2fdd-40c0-a1ad-ff5995fb0145"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cac86a4a-5701-4518-a9b3-870d6c29eae3"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2ae82bfd-34db-4928-bfee-b60f4aec4460"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb5c2a07-186f-42dc-9da1-73ce99a95817"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb9732a5-2cb0-4a9d-acea-c18f377445e5"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ccf2d07e-1c4c-49f9-8c14-3b375f8aa9d2"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cdb5e8dc-df76-445d-aa7f-5d5515cd8398"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf231162-8f51-4c4f-bb92-fd85e486a878"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d4a860e0-21f7-473a-8d71-e8d34de0cabc"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d597e69f-1f13-42db-bb8d-781f340787b1"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc5ab055-a389-42f5-aa3b-3c58b0ef81a7"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6487a532-ff5e-4b77-b408-46c789608de9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("df0f254b-2f6c-4d03-94c4-9ee14a2923d3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e09d1130-903b-4ca2-a0c2-45632e30b2a8"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1160b67-0858-4ed8-9139-86186b7dc27c"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("85e621ed-0e0c-4d20-8891-51d311cea4a3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e185c92c-ea40-4e39-b02e-1965186f0cd6"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e713957e-9e6c-4ac5-9c67-8e6dddbef484"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e9c557b8-2eca-42a6-b793-4a30d2b31656"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea15a65e-2196-48ab-b128-ad9a11c6224b"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8382816f-1beb-4804-9698-3b486798b20a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea61bde3-f13c-4887-a737-6b302ccad06b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb941b2e-2fa0-4a62-a460-1e75dbfd385e"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec2bcbd9-2c6b-422f-8257-b52f75a26337"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ed3b43a4-1b1b-45bb-afe8-9e4db91d9699"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ed48dd54-e0cd-423a-af9e-c475bf0ab9fc"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("efb3d3e6-6d53-4a1d-a13d-4274ad5c8a40"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f0d07e9c-0eef-4aef-9b38-d3ce93ed3016"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f1c835e5-e977-4d12-8cf1-bba2463851f4"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f345f679-e2c3-42c6-81d5-123d1d12dd1a"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5c0758c-d92b-4360-9003-241c3e1bd476"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8071316-1e2e-46c3-a5dd-44d96b0558b4"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa59ed8a-f56c-4353-b060-983623225350"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa69fe4a-9725-4614-972b-6a9fe1fe6d21"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fb580f0f-6eef-4198-a48f-f23d41333903"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fead7b73-59a6-4f9c-8108-fb6098315840"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "CertificateId", "CertificateName", "CertificateNumber", "ConsultantId", "CreatedAt", "ExpertiseId", "ExpiryDate", "ImageUrls", "IsVerified", "IssueDate", "IssuedBy", "UpdatedAt" },
                values: new object[] { new Guid("8da31231-09de-4ee8-9ef0-8a830a118c30"), "Chứng chỉ tư vấn dinh dưỡng", "CERT-2025-002", new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ad55299-b566-47e8-a9a0-1997e893e153"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://example.com/certificate1.jpg\"]", false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monhealth Academy", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "ChatId", "ConsultantId", "CreatedAt", "CreatedBy", "LastMessage", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("9b4dc3a1-5076-48f0-b91d-3d964ff1aa7d"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(9809), new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), "Tôi muốn hẹn lịch tư vấn vào tuần sau.", new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(9809), new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2") },
                    { new Guid("e7a3f1bd-d891-4a79-9086-9f3e79cf8e01"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(9809), new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), "Tôi cần tư vấn về chế độ ăn cho người tiểu đường.", new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(9809), new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87") },
                    { new Guid("f04b47df-8e5a-4bfa-8519-0ed5f9b1c7ea"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(9809), new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), "Bạn vui lòng cung cấp thêm thông tin sức khỏe để tôi hỗ trợ tốt hơn.", new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(9809), new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b") }
                });

            migrationBuilder.InsertData(
                table: "ConsultantBanks",
                columns: new[] { "ConsultantBankId", "AccountName", "AccountNumber", "BankId", "ConsultantId", "CreatedAt", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("765e2b2d-bf6c-4aeb-95e9-86231bff8c9a"), "Văn Hữu Toàn", "vanhuutoan27", new Guid("1b4e6597-7d56-4b6d-833d-c17f5755aad1"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2054c88-385b-42c8-a219-39f29404ae24"), "Văn Hữu Toàn", "1890445466", new Guid("936666c3-12f6-406b-9de9-8367233aa6ba"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("abe1abf5-70f0-49eb-8d16-f5db3ced9d2e"), "Văn Hữu Toàn", "28497112029", new Guid("1b4e6597-7d56-4b6d-833d-c17f5755aad1"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec0c02e2-bf9c-466a-a25d-2139e39a167b"), "Văn Hữu Toàn", "0792766979", new Guid("1b4e6597-7d56-4b6d-833d-c17f5755aad1"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "DishTypeFoods",
                columns: new[] { "DishTypeFoodId", "CreatedAt", "DishTypeId", "FoodId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01b08a2a-d708-472a-9a6f-0c7651a1e285"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4316), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4317) },
                    { new Guid("025d4fa0-0b61-4a7a-a198-7a15442aa99b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3820), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3821) },
                    { new Guid("02c4607f-c097-4024-abae-6e0dc1a6f9a3"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3807), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3808) },
                    { new Guid("030c41b3-dacf-4347-b98f-bc33e2a58b6a"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3639), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3640) },
                    { new Guid("03503307-bba1-41a8-b2b8-3bc02d54a231"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4144), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4145) },
                    { new Guid("039dd150-1d9c-44a5-80eb-236064de37f5"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3421), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3422) },
                    { new Guid("03a80aaa-47e0-4ccb-91c5-8cb27cdc9c8e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4301), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("af036922-79f3-45a7-b562-a6279520c0e6"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4302) },
                    { new Guid("060c68f8-584b-48e3-b5b7-8808578433a2"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3459), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3460) },
                    { new Guid("07e10969-0a82-47f3-bb77-3309e4de1e87"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4233), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("2ae82bfd-34db-4928-bfee-b60f4aec4460"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4233) },
                    { new Guid("08e70454-d9de-41d0-9efb-653ae4c269f3"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3886), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3887) },
                    { new Guid("095464ca-6a5d-4c4a-92d5-3d83808072a1"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3450), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3451) },
                    { new Guid("1007ae25-0ca1-4d0c-a484-e88f22f3c928"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4053), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4054) },
                    { new Guid("110a3128-48ea-415e-a102-adb89bd16972"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3520), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3522) },
                    { new Guid("139c1406-8b84-4307-bef2-6ad4925cfd40"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4236), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4237) },
                    { new Guid("141607e8-b373-4691-8b8a-4b9fcf656c58"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3719), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("faf19891-525a-4308-9222-992e83de7ce7"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3720) },
                    { new Guid("1461be72-9ad3-4e42-9661-d3342f1dd84e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3584), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3584) },
                    { new Guid("15fe7d37-9314-4b6e-9dc9-f3b1459941b2"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4211), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4211) },
                    { new Guid("17d8cd88-a50f-47ed-84d9-741536a7309f"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3254), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3255) },
                    { new Guid("18023a8f-806a-477c-94aa-43d2cf42d930"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3676), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3677) },
                    { new Guid("190ae2b2-c4ca-40fd-995d-7d7316607dba"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4490), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4491) },
                    { new Guid("1935d69c-1e00-47c1-8849-76311da14d80"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3363), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3364) },
                    { new Guid("19880899-99a9-4c9f-be39-02bb7ce214f4"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4425), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("8ed85dc2-7654-4c48-81f9-19946a73f71d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4426) },
                    { new Guid("1c6f08f4-897c-4929-b9ea-27c32fe8f226"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3672), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("51061170-597d-4289-a021-1e7dde88331f"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3672) },
                    { new Guid("1d9f848c-f421-4c0c-98dd-110764174f2e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4259), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4259) },
                    { new Guid("1e6eb444-f3a1-4649-a66a-18a42e68d0d3"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3484), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3485) },
                    { new Guid("1f241ac1-4510-4730-9474-5d6127448dfe"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3689), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3689) },
                    { new Guid("1f7690cc-4edb-4fa0-9423-57f9b38c1bb9"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4129), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4130) },
                    { new Guid("1fb1414e-6aa6-492d-b4df-5c63b6e51d80"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4286), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4286) },
                    { new Guid("20149816-806f-407a-a062-5c206bc6722e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3911), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3912) },
                    { new Guid("20253856-6215-4349-9bba-c7f30a3965ad"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3660), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3661) },
                    { new Guid("21234f32-613b-4b8e-9a70-6464080b4245"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3890), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3891) },
                    { new Guid("2234ae7c-9a00-400b-8b01-52ca2115ca01"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4033), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4034) },
                    { new Guid("2438d82b-984d-4d3f-8af0-ad334d7d74f7"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4548), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4549) },
                    { new Guid("26960abb-7088-4f16-9a69-aa1077d51863"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3668), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3668) },
                    { new Guid("27e8e971-7121-4f9d-9266-6114d3f5fb12"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3942), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3943) },
                    { new Guid("2d50c6de-fbe0-4625-9500-ed9cc62bd812"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3786), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3787) },
                    { new Guid("31041df7-cd96-48cc-a250-dfdd545ecaa1"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4418), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("43d635e2-6f0c-4385-83d8-fedfd479d356"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4419) },
                    { new Guid("311280cd-1d26-418a-ac05-a62ee7d668e0"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4470), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4471) },
                    { new Guid("32eaf984-d591-4cc3-9d49-29eb7197c8cb"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3489), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3489) },
                    { new Guid("34401a86-190b-4f0b-96a5-d946b29db841"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4326), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("a988cc73-072e-4af1-9b53-55fbf0f4fe79"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4327) },
                    { new Guid("37727031-e97f-4db9-83af-5a8a1638e18e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4207), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4207) },
                    { new Guid("38eb0469-c6ab-41b3-a37b-74549f0caa7b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4389), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4390) },
                    { new Guid("392c6ca0-a5c0-4619-840a-1fdf9c94f9a8"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3472), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3473) },
                    { new Guid("3bc9385d-b04a-4138-a577-a15515c6fc06"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3516), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3517) },
                    { new Guid("3be86953-0d44-4ea4-9051-08ceb2e4faa3"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3988), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3989) },
                    { new Guid("3c672e01-20f1-4d0b-ac1d-e8c70d11f99a"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3992), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3993) },
                    { new Guid("3d4c2b1e-540f-4351-ac04-d5900501aa29"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4228), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4229) },
                    { new Guid("3dfe6b6b-1ff7-4b49-9f06-69a714fffc73"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3446), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3447) },
                    { new Guid("3e1e03f5-5a4e-4f3a-87fc-103176566ceb"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4082), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4083) },
                    { new Guid("4008f7eb-727d-410a-ac4e-c8189c826ce4"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3804), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3804) },
                    { new Guid("40684bec-2650-4093-a16b-ffef2dffef9e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3592), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3593) },
                    { new Guid("4116399a-5c75-4b65-bfbc-2ed56ad8cc70"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3861), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3862) },
                    { new Guid("419cbf9e-220d-4ec0-a512-7f7073488880"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4450), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4451) },
                    { new Guid("435025c1-4a32-42f3-b3e0-b8f4a7ad0496"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3646), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3646) },
                    { new Guid("43846658-4283-4e34-b7c1-2574b481468b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4434), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4435) },
                    { new Guid("44391eae-916e-48d0-9b74-f3024dc60a7e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4270), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4271) },
                    { new Guid("4458d9b6-ade7-448f-8447-74d2f80b90ca"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3652), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3653) },
                    { new Guid("45c13c0a-e4cc-46f8-b47a-f9609a95d27d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4442), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("e370081a-c0a6-4c00-b01c-7c52f953b7f1"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4443) },
                    { new Guid("4661bec4-406b-43db-bdf2-78ed9f7620f6"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3962), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3963) },
                    { new Guid("4771fb6f-d93f-418e-b34f-19307cb670db"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4358), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4360) },
                    { new Guid("491e2469-5c40-4683-892d-a1a552e354ba"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4109), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4110) },
                    { new Guid("49e94f93-abfa-4697-9956-6b4056dbab80"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4140), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4141) },
                    { new Guid("4a249989-13f9-49f5-a01d-7d48fe952ab5"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4113), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4114) },
                    { new Guid("4cf9995e-cd6b-4937-9da6-397362fa3975"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4273), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("7167f942-dc89-4f29-8022-588373aef45e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4274) },
                    { new Guid("4d4b54e8-8f6a-4dd5-a134-52cf145db1e7"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3524), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3525) },
                    { new Guid("4da6da96-4f66-464b-b977-dc273ad6b3a5"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4220), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4221) },
                    { new Guid("4e98f72b-29d8-42e4-9354-6a7c34a32935"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3843), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3844) },
                    { new Guid("506cc6a6-9801-466a-a46e-bda9fdbd8d10"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3946), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3947) },
                    { new Guid("51470596-b360-46c5-b338-0d667b9fa37e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3623), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3623) },
                    { new Guid("5408a7a7-1c45-4ba0-974d-a9118a6e851c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3950), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3951) },
                    { new Guid("54cb7069-70bf-40e6-bc29-fe62768324f0"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3829), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3830) },
                    { new Guid("55d70df6-dcf1-47fb-948e-942ead403b29"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4439), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4439) },
                    { new Guid("55d885c3-86e7-4cbc-b347-bc1d5a829d4c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4330), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("2ee163f7-4463-44ec-b9e2-8a409c112db4"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4331) },
                    { new Guid("57728004-7f36-4b9f-b604-d11c5a8e088d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3927), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3927) },
                    { new Guid("57816795-b741-46fc-bddd-35b25c5e2d20"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3834), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("7b8500af-d730-4138-9617-cba352faed4a"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3834) },
                    { new Guid("57c15b6e-f81c-46a8-a9ae-817c33db5037"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4374), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("4edcae53-7e30-42bb-8526-7686355f2268"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4374) },
                    { new Guid("57c41722-4db1-4611-8313-5924cd403f17"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3434), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3435) },
                    { new Guid("57cc02b6-6a4f-48d7-81c3-a0dd80b26e51"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3972), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3972) },
                    { new Guid("5923e16d-ecbe-446a-9e4a-22c2daaaf4f6"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4414), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("982d8f3e-f517-4bd2-87a8-48329fc9eb91"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4415) },
                    { new Guid("5d77c59e-08e9-4687-a223-397331424115"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3504), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3505) },
                    { new Guid("5e58d0eb-47bb-4745-92e9-5596c2b833ea"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4090), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4091) },
                    { new Guid("5eef75ed-f5ed-4040-a0c9-7bb970c6e0a3"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3698), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3699) },
                    { new Guid("5f0e6837-356c-42a8-b56c-ccc81305979d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3857), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3858) },
                    { new Guid("5f9b075e-cbf3-42d2-8cf4-f73b6e84fe1f"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4246), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4247) },
                    { new Guid("633d7029-bbef-4b22-bc23-3949c95db4c0"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4342), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("eec3d874-6331-4e33-bbe6-bf0cc4335b29"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4343) },
                    { new Guid("640530b2-2e6b-4dd9-bae0-78343b9ca552"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4133), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4134) },
                    { new Guid("64566249-d267-442c-9b7c-e72aa7d48d05"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3824), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3825) },
                    { new Guid("66049279-9580-4c92-9e03-6d3f8ea370cd"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4009), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4009) },
                    { new Guid("68a23733-4da2-43e0-a8ab-53f710bcdf1c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3466), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3467) },
                    { new Guid("6a0104d6-3704-4983-a7d7-c6c9f43fa928"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3539), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3540) },
                    { new Guid("70bbda54-a907-47c6-9aa9-4a991d5b138b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3608), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3609) },
                    { new Guid("710d9e5e-fda2-4dc0-a62a-3af6a7a2c65f"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3438), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("86d88717-df08-4de6-b86d-870210864b46"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3438) },
                    { new Guid("714b8a82-ab37-4942-9aa5-060eaa25db99"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3358), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3359) },
                    { new Guid("71c258fb-8d9c-4fa6-9c45-b7bc19a11742"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3704), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3704) },
                    { new Guid("74a355aa-67dc-49ef-a51e-2262241ae249"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4121), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("7cd76708-7312-445e-a392-14f0e806a786"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4121) },
                    { new Guid("74b53a36-e9b0-4d06-972b-7b97727e6bd0"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3560), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3561) },
                    { new Guid("74ed4b87-75ac-4e06-b683-f3b140e774e4"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3266), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3267) },
                    { new Guid("78f30c80-8bc7-45bb-8c05-9fc3e03fc26f"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4495), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("3d19d971-88d0-4108-a335-24ac9e1dec50"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4495) },
                    { new Guid("7c196355-8515-4373-9ed3-0dd31eeb5d87"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3512), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3513) },
                    { new Guid("7c6c6c6b-b1b3-45c5-8ec0-0682ae51578a"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4558), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("85e621ed-0e0c-4d20-8891-51d311cea4a3"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4559) },
                    { new Guid("8131131d-81ea-48c3-a981-0258162ed614"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3410), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3411) },
                    { new Guid("82f1927b-b7b8-42ea-aa13-b967ae5ecd68"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3635), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3636) },
                    { new Guid("834a55a4-e2e3-4ffe-934f-a4860c6e4697"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4306), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("00bc33fe-4cd5-47df-bd94-15ac9f93648c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4307) },
                    { new Guid("835e8fec-13b2-42ea-b249-a0a234afce8e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3935), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3936) },
                    { new Guid("83ae53fb-97e4-49ed-ab1c-30df33dd2e1b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3528), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3529) },
                    { new Guid("83b903ca-fd95-41fe-b3f9-329adf93bea7"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3874), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3874) },
                    { new Guid("851f7dc9-07ba-4f3b-b7f8-01243d272e48"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3262), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3263) },
                    { new Guid("853bf4aa-57e3-4117-9a00-b2a98c1257a9"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3600), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3601) },
                    { new Guid("85883f98-b814-4a39-b94c-772ef838d862"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4096), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4097) },
                    { new Guid("864dab19-d0ad-495d-8d66-2e20743eae44"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4025), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4026) },
                    { new Guid("867985f5-a256-4598-a799-18fc227ea709"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3907), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3908) },
                    { new Guid("87256efa-663b-44fa-b441-306fe98a9de4"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4378), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("0292d477-d63b-4904-a83b-2cd8cac39c14"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4379) },
                    { new Guid("8779b53f-cefb-4976-ac18-3f5e944bd4e3"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4402), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4403) },
                    { new Guid("87849476-4ad6-497f-b098-90545f47ff9a"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3694), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3694) },
                    { new Guid("8891b63a-7af4-45ca-af9c-d9aa306ab1d3"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4462), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("2405ffc3-524e-4331-9e68-47a411d7b9b8"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4462) },
                    { new Guid("8af458e6-b8e2-4b59-886e-7361cb7d0cf7"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3476), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3477) },
                    { new Guid("8ce0de8b-5a19-4aa2-8278-ed548d9d9a02"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3596), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3597) },
                    { new Guid("8eec61ee-fed5-4503-a0be-de04c461bb47"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4363), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("29dfb5da-8818-40ff-bf66-7553521c2161"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4364) },
                    { new Guid("8f1f1610-985a-46b8-be29-44d060bde59e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4554), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4554) },
                    { new Guid("9261149a-7a50-4ab3-929b-b3ebd6fd1211"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3556), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3556) },
                    { new Guid("92c37eb2-99d3-4fb8-9362-1aa80eb0aeae"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3455), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3456) },
                    { new Guid("93512590-44c7-46dd-a599-6dde240471e6"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3707), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3708) },
                    { new Guid("96c25900-f5bf-4656-b368-4e887157b9dd"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4429), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4430) },
                    { new Guid("972ddec6-9ece-4e3b-bde2-337b1fd7f4f3"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4215), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4216) },
                    { new Guid("98f533ed-fdb5-41c8-94e8-262414e98acf"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3656), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3657) },
                    { new Guid("98feb46e-c457-41a7-bbb9-d62b97e42d32"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3899), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3900) },
                    { new Guid("9b99e32e-3a4a-4aa3-81fc-7b63167cd96c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3881), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3882) },
                    { new Guid("9c0288d9-8e58-4189-82d6-1422ac29c116"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4466), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("2146faae-2e7c-4460-8d81-38f5d313012c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4467) },
                    { new Guid("9d3cbaa5-c911-4b43-95c0-a6387f00cd4c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3604), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3605) },
                    { new Guid("9d7cc537-ca57-4fc0-8d60-39eab0ce19a4"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3799), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3800) },
                    { new Guid("9fb66b7b-3ae4-4b2d-a4aa-99c162ff194e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3930), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3931) },
                    { new Guid("a1f9697a-28c9-4134-a2bc-1227ae7748d1"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4040), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4041) },
                    { new Guid("a28218a8-af75-4920-ad92-6e84a43a2389"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4354), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4355) },
                    { new Guid("a2a4a567-2e4c-49ab-8c19-20109b7507a1"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3568), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3569) },
                    { new Guid("a37f6d7e-2858-4b79-99ff-f64419476f83"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3619), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3620) },
                    { new Guid("a39ba449-ef14-4bcc-86cd-af6d2f0ebb1d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4455), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("8382816f-1beb-4804-9698-3b486798b20a"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4456) },
                    { new Guid("a48d9c82-2341-4de6-a767-f20c738bf0db"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3664), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3664) },
                    { new Guid("a540ba11-4f13-4cee-883e-fa91f952e8de"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4250), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("827829bf-71cd-4865-80af-1457e0091456"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4251) },
                    { new Guid("a60ce43c-bbaa-4548-834d-fda5dd4eaa0b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3865), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3865) },
                    { new Guid("a822e598-bb05-4871-8bff-e8ae117959da"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3975), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3976) },
                    { new Guid("a8bf5eba-0292-42b3-8b0b-3061d5a919ac"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3726), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("faf19891-525a-4308-9222-992e83de7ce7"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3726) },
                    { new Guid("a9a35a51-0bc7-47fd-b37f-833fe7dcfbc5"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4265), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4266) },
                    { new Guid("abac1039-2a2a-4af5-a068-6f453156cf3f"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4004), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4005) },
                    { new Guid("acafe4da-b1ab-4632-a5e2-7ed0157e179c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3508), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3509) },
                    { new Guid("ae3610e7-ebd1-490c-9956-107dbb40b062"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3258), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3259) },
                    { new Guid("ae5c3662-82df-4210-857f-6e142fb816d8"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3681), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3681) },
                    { new Guid("ae7e0df3-3a0b-4ebf-ad3c-c1589f671d0e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3878), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3878) },
                    { new Guid("b05925e4-06bb-4d04-bc69-6f1ae3eb5193"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3954), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3955) },
                    { new Guid("b09d723a-4d9b-4886-a306-c30db01d0000"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4409), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4410) },
                    { new Guid("b0b5a9a7-ebe8-4dc0-874b-5b05bb15d0f8"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3579), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3580) },
                    { new Guid("b0dbb548-8c54-4687-92d8-9f70e50e7ee3"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3270), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3271) },
                    { new Guid("b3fd957e-b010-4e38-bf39-fe950b74e75d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3922), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3923) },
                    { new Guid("b653c695-d6fe-48d6-8f2d-d666d9a35877"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3245), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3248) },
                    { new Guid("b8d38f62-b5f0-4110-be74-c77030178f7a"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3615), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3616) },
                    { new Guid("b90cf531-bf09-4b40-8673-9928d8e3093b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3813), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3813) },
                    { new Guid("ba0442cd-23b7-47f1-82bd-c386c9ae70cf"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3480), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3481) },
                    { new Guid("bad4462b-f2c9-40ff-b937-a3877235c659"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4294), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4295) },
                    { new Guid("bc9a2660-91be-4f0c-83c1-da56dbff2d1a"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4201), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4202) },
                    { new Guid("bd283c24-31be-4e04-8315-beef9b17b5e9"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4447), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4447) },
                    { new Guid("be41fba1-27ee-42e5-bd1d-5dc65705f3cd"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4385), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4386) },
                    { new Guid("be4c301d-1678-4ec2-9d56-9eeb97da54f8"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3572), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3573) },
                    { new Guid("c088d956-3d7c-47b9-962e-56692ab93c8c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4281), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4282) },
                    { new Guid("c1ea9f1d-c8a5-4a46-a6f4-547fca7aba05"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3838), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3839) },
                    { new Guid("c30cb950-6a86-4974-8d89-5703577009a5"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4242), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("6487a532-ff5e-4b77-b408-46c789608de9"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4243) },
                    { new Guid("c8699da8-4c79-41d4-9e83-7622146a4e14"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4074), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4075) },
                    { new Guid("c8a4bac5-8b7e-4e2c-b0a9-cf920c112f55"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4086), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4087) },
                    { new Guid("c9d20f8b-1f44-40d4-8382-9de3c40c33a8"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3368), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3385) },
                    { new Guid("c9f6dd20-68e0-457e-bf22-9ca0b5fbbdfe"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4048), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4049) },
                    { new Guid("ca6f47e9-63a3-4075-9f32-c20e6f14300a"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3917), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3919) },
                    { new Guid("cbb0fb31-a39c-4e2f-b3ab-fcbb9197e52b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4474), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a364353c-d589-4a94-9c3b-3038113ea249"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4474) },
                    { new Guid("cc9664fd-3d80-470e-94ab-41a518c5b63d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3429), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3430) },
                    { new Guid("cd339b87-c823-4859-a477-be0398c33812"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3588), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3589) },
                    { new Guid("cd8e39a8-2351-4083-831e-e188feeafbed"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3958), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3959) },
                    { new Guid("cf34eb0c-822d-4549-9c98-d7f5a67501d9"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3715), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3715) },
                    { new Guid("cfbee5a1-663b-45d6-91f9-e9e02dca63e4"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3548), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3549) },
                    { new Guid("d2dd1286-fb72-45ef-8a08-da019130623c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3417), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3417) },
                    { new Guid("d31a9d00-e694-4d3f-8b2b-c27b11c50773"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3402), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3403) },
                    { new Guid("d48a63c2-2117-465e-b01a-131df9f69350"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3632), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3633) },
                    { new Guid("d576eb72-b3ab-4591-8236-47cc0f17b02a"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3442), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3443) },
                    { new Guid("d66b0b2f-723f-448a-b0a6-008f59ce147e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4064), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4065) },
                    { new Guid("d8d96827-eb17-4c50-9a8d-389550f75323"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4478), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4479) },
                    { new Guid("da839f42-a3df-4e9b-a0fc-9fec5aeb40f8"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3984), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3985) },
                    { new Guid("db86a13a-7e5e-4e15-a9d4-d7ee0bead444"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3847), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3848) },
                    { new Guid("db950b7d-e13d-4f5d-8427-bcc46635dfa9"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3493), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3494) },
                    { new Guid("dc221bd5-6850-43ba-a58f-6cfbc216bffe"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4013), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4014) },
                    { new Guid("dc82eb1b-4274-4274-9b38-68c8e45dd68b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4312), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4312) },
                    { new Guid("dddfb6c6-8fec-4a54-a400-617d3ea2db56"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3642), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3643) },
                    { new Guid("dde7e99c-9211-433f-9c2e-518fb159131b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4000), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4001) },
                    { new Guid("de4a2c03-7252-4e01-a5a4-07032c8b323e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4290), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4291) },
                    { new Guid("e035097e-4693-47e9-b967-ea3ef123d102"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3406), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3407) },
                    { new Guid("e2152702-130c-4cf6-8f7a-071bcd602c39"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4029), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4030) },
                    { new Guid("e2a3663a-765d-472c-aba6-87c4092324a8"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4103), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4104) },
                    { new Guid("e2c39615-649b-4d99-abed-c4ea59059ec6"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3851), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3852) },
                    { new Guid("e31c16d2-9562-4e4f-8db3-d52f646b25a8"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4393), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("3dc2fa80-ab87-4e26-907b-3516611371b8"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4394) },
                    { new Guid("e457f219-dfcd-4366-a76f-dcc9783bcb9a"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3711), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3711) },
                    { new Guid("e567c818-9f2b-4fcd-8167-8f5bea875cd9"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4277), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4278) },
                    { new Guid("e6089796-5794-4a38-9a38-bf050b56a92c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4069), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4070) },
                    { new Guid("e6ad957b-6ced-442b-b574-c331c9a2ac83"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4117), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4118) },
                    { new Guid("e86f8880-6eb6-42ab-8eaa-7a9b82bba77b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4502), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("a504d882-4f38-413e-bb28-fae1f2787150"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4503) },
                    { new Guid("ea560e6b-4d68-40bf-832f-eb6d721be84e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4368), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4368) },
                    { new Guid("eb30bf0d-8adc-4dcc-8a77-eb5b10d68240"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4057), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4057) },
                    { new Guid("ec39b9fd-d92f-4706-b0c4-fc2293b70041"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3532), new Guid("c76a8736-de8a-417a-864a-68e64ee2b2eb"), new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3533) },
                    { new Guid("ed45d2a8-1987-41c1-bf04-6e443b83381b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4078), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4079) },
                    { new Guid("ed6b0d94-a897-4f8c-af09-aa420ab2e54f"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4196), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4197) },
                    { new Guid("f3090b4a-dbbf-452e-8670-8df725247412"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3996), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3996) },
                    { new Guid("f3ea260c-970a-4808-b877-bd9e6c5d1bf2"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4044), new Guid("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"), new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4044) },
                    { new Guid("f4878d01-5a28-4066-bf19-e6ce803277b6"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4350), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("90a605b6-843d-4cc1-8fe7-a016c76ee29c"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4351) },
                    { new Guid("f6e903c8-9407-4c82-9d0f-84310579f151"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3795), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3796) },
                    { new Guid("f70f4c5a-f234-4791-a20c-90cd7c52fc28"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3497), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3498) },
                    { new Guid("fa1c3d64-bdee-4c0f-ba69-245b9a41b975"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4320), new Guid("c5791b20-5d7f-439c-9db6-418a7b18b457"), new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4321) },
                    { new Guid("fabac613-866e-475f-babf-055d274d2f7f"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4254), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("c5e3e4ed-0164-4917-a1ce-99679b971a22"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4255) },
                    { new Guid("fb015300-3846-4e48-9a25-cc11d8bc4188"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3791), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3792) },
                    { new Guid("fbc2c08a-bc72-4b38-ad5f-82b360e57689"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3544), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3545) },
                    { new Guid("fcd5c6ad-4d08-4918-acc5-cbea8769efa1"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4482), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4483) },
                    { new Guid("fdfc5192-dd78-42fe-9880-5da8bfd1304b"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4125), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4126) },
                    { new Guid("fe0f996a-a532-4ee8-9fa4-d807f27a5eb1"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3564), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(3565) },
                    { new Guid("ff9f62af-def8-4d20-851f-a676f90efa83"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4335), new Guid("640474cb-2135-4648-b921-fca3a9219533"), new Guid("01e60ae4-ff69-44d6-b4fd-aaf916e3a7e5"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4336) },
                    { new Guid("ffeed65f-85e1-4ea7-9f1a-4cdb07edc7db"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4397), new Guid("a8a61860-12ee-4216-b185-1b8b6703c24d"), new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new DateTime(2025, 4, 11, 20, 23, 44, 386, DateTimeKind.Local).AddTicks(4398) }
                });

            migrationBuilder.InsertData(
                table: "FoodAllergies",
                columns: new[] { "FoodAllergyId", "AllergyId", "CreatedAt", "FoodId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("026a89ea-6abe-460a-bbab-a11ff67be2b1"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), null },
                    { new Guid("028d88e1-cb9a-485c-a911-ff73aed624a9"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), null },
                    { new Guid("03095a0e-70dd-4931-85b4-e971a2b0879a"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), null },
                    { new Guid("099901e5-3b64-4e60-8533-16351185632c"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), null },
                    { new Guid("124b98dd-9866-4191-bf48-85d0b768cd93"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), null },
                    { new Guid("19afa87f-658c-4bea-a38d-b18dcd7c0b95"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), null },
                    { new Guid("1e2f53ac-b9bf-4a74-9273-079670db0d7f"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), null },
                    { new Guid("1e4a86f1-0633-430d-a1f1-aeea33eb9213"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), null },
                    { new Guid("21c2cabe-812e-4f2e-96f1-1881be00744c"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), null },
                    { new Guid("2541fb21-7a79-45b6-8d28-06bd9dbed55c"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), null },
                    { new Guid("2628b56f-a662-4ba3-9def-4bc689a6fc8e"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), null },
                    { new Guid("26ab0e46-f660-4785-b130-1bb96c338349"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), null },
                    { new Guid("26cc65d7-c037-4537-aba0-2a495a2cc370"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), null },
                    { new Guid("2a959d0f-da81-46b7-b5a4-3cc106166510"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), null },
                    { new Guid("2e4d4b6e-7867-4c44-b7a7-0ba70289c7a8"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), null },
                    { new Guid("2fa13951-30c3-46ee-91b9-0faff5d937ec"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), null },
                    { new Guid("32061e48-8bf2-4c73-a8c2-5a49487a3d5c"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("faf19891-525a-4308-9222-992e83de7ce7"), null },
                    { new Guid("34967398-a36c-4a07-b284-bb388f81f6dc"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), null },
                    { new Guid("3f7d1258-a5b3-4e5f-856f-90c359eba222"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), null },
                    { new Guid("40b195b3-63d9-4c64-af86-56aebbd0aa6d"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), null },
                    { new Guid("41566c8c-30ee-4ee1-9613-fb3a78147358"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), null },
                    { new Guid("4ced15a5-a0ae-4dab-9775-bafaf38462e2"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), null },
                    { new Guid("506943c5-210b-4a52-95f5-4e98722cdca8"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), null },
                    { new Guid("557b3268-7638-4bcb-9731-5091549a0f45"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), null },
                    { new Guid("649e9362-cddc-413d-86da-9882ee77e75a"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), null },
                    { new Guid("6525e82c-c707-485f-b096-6b31aa959810"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), null },
                    { new Guid("6c621ac2-7dbb-4495-a955-212c22211991"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), null },
                    { new Guid("700b0d69-8500-4e59-95c1-e4e89887eb38"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), null },
                    { new Guid("70649401-5aa4-489a-a861-9828f365df1a"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), null },
                    { new Guid("72c89425-1218-4470-a3bd-d44b0bc6c363"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), null },
                    { new Guid("7cf6b1e6-a407-47d9-bb38-8aea32e875c4"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), null },
                    { new Guid("7d831846-eac5-4a03-bbf7-225d0322ca2d"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), null },
                    { new Guid("81309ee5-f161-4dcd-9901-86d6242a6438"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), null },
                    { new Guid("841ae26b-82c9-4e17-a477-e762ba5e2494"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), null },
                    { new Guid("8593442a-800c-4396-b5af-dd7df38c3800"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), null },
                    { new Guid("8b5edea9-60cc-48d2-bc5e-897412d03e51"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), null },
                    { new Guid("94bc5973-e507-4260-b641-a7d5f6453967"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), null },
                    { new Guid("97089892-f4ff-44fe-bdad-ef3dee8c4ba4"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), null },
                    { new Guid("987dd4f5-e573-4e22-8611-bfc1e0608cb7"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), null },
                    { new Guid("9cd0a7df-2332-46ed-baef-dd3271b79e72"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), null },
                    { new Guid("abf52807-d19e-486c-8f4f-a4a3b6207b9e"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), null },
                    { new Guid("ac4ea6ee-a3f7-461d-8fd0-ea6da77f6932"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), null },
                    { new Guid("b464a293-a304-49d3-88a4-ccdf50af4c6b"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), null },
                    { new Guid("b8adfb8f-5674-4cef-866c-78f946be86f5"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), null },
                    { new Guid("b999490a-f12d-42e3-9d99-7fcd05d82124"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), null },
                    { new Guid("bf273eee-de32-4ec9-8b7d-f5228ee39b31"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), null },
                    { new Guid("c0c0574d-2706-40e0-82e2-0f85c547dc5f"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), null },
                    { new Guid("cbf4a7de-edb1-4275-a231-96cb6fd81a73"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), null },
                    { new Guid("cecbf3c2-b7d2-402e-8db9-86eb8b691966"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), null },
                    { new Guid("d61fb4cd-cc2e-4747-a980-558d10ef197e"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), null },
                    { new Guid("dc017316-d96b-4bbf-bdfe-7fd446751f15"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), null },
                    { new Guid("dcc21bf3-1254-44c8-a9ad-74b92b2ad9e9"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), null },
                    { new Guid("e0b2c003-04b5-42d0-a8de-0da5f667ee56"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), null },
                    { new Guid("e4c1ba2c-88b5-4402-8fc1-bf9752e94d64"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), null },
                    { new Guid("ec4fac4f-37e9-4bc3-b936-a04acc43554e"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), null },
                    { new Guid("ef8175e5-7b57-41e9-8553-7e8a258ee638"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), null },
                    { new Guid("f31a8501-b9fa-4151-a080-45df3c2149cd"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), null },
                    { new Guid("fa1e4d3d-e4dd-4a65-986a-af0b558ee7ed"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), null },
                    { new Guid("fcf49fca-bf4e-41fe-a813-73fe5a9a9b4e"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), null }
                });

            migrationBuilder.InsertData(
                table: "FoodPortions",
                columns: new[] { "FoodPortionId", "CreatedAt", "FoodId", "PortionId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("03243be8-f071-471d-9732-714fb264bd87"), null, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new Guid("3d6d946f-8d9f-479a-b27e-3d78dc354db0"), null },
                    { new Guid("03502fd7-8354-4703-9c0e-adc39ec47d80"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("3c7d60d4-60da-4f51-9448-30877b126572"), null },
                    { new Guid("04392d06-ba30-4ff4-bde8-0106b9985f32"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("e00ed683-11ff-4c21-8b1c-576b448726c9"), null },
                    { new Guid("12073f91-1879-4f1a-be4c-02dc3059b0b5"), null, new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new Guid("5a1bc1cb-ed0b-49bf-9c1a-5494db962d27"), null },
                    { new Guid("12bb34be-f1f6-4f2c-a385-962678a06734"), null, new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new Guid("8a81e20e-ea16-4073-957e-29508a8f7419"), null },
                    { new Guid("160840f1-f977-4051-b667-812f509436ed"), null, new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new Guid("30f41ca6-c420-4f7d-9602-bf80735d5691"), null },
                    { new Guid("16d6eada-5b90-4fcf-abf2-75617dcad0cd"), null, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new Guid("b6623163-4c27-4d0c-99ef-12a67b87635f"), null },
                    { new Guid("16eb24c8-9111-44e7-8fe0-41fb2858aa92"), null, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new Guid("8ecbc063-8d6e-450d-af39-0ba28bc572bf"), null },
                    { new Guid("1708bf2d-b2c0-48b4-88d5-3b21adb260b5"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("eff728af-c8f0-4bb5-a985-d079cbadb6b5"), null },
                    { new Guid("1bba32c7-3e57-4fa7-922d-4f88db8cdc6a"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("709578ca-672f-461e-995d-dc78aeda8c4c"), null },
                    { new Guid("1c567a46-f82b-44ec-b30f-5b874d7808b6"), null, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new Guid("de5d78a3-c5b1-4e2a-b9eb-f3757c999024"), null },
                    { new Guid("1cf7d002-ac1a-4e15-9424-9d052f8f181d"), null, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new Guid("d2e88505-bbd6-4af6-9a88-535896c5d587"), null },
                    { new Guid("1d4bab8f-a797-4790-a772-7a65d027ca58"), null, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new Guid("7e071bd6-6afa-483d-8688-28b31b9a8bef"), null },
                    { new Guid("1fe019b4-6ba1-45a1-bcd4-99b3dfd594c7"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("e5cc2785-6d62-4b5f-8fc1-e6ab45babd76"), null },
                    { new Guid("200c79e3-2ff1-4c17-aa68-e6d562d9347c"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("26dcc6e0-67aa-40ed-b3d1-8a009c60a62c"), null },
                    { new Guid("22dc6a8e-3540-462a-bf71-4b749e3b8b8a"), null, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new Guid("222e1fa2-3910-42ac-9a5c-f371dded16eb"), null },
                    { new Guid("28c7b920-0ed1-4c9b-8e72-0b4ec62151f3"), null, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new Guid("31e9bda5-8ec3-4444-a23a-908e84da6a14"), null },
                    { new Guid("28cd6bde-4140-4718-9028-7617dd56bbb1"), null, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new Guid("ad9ecd1e-40ec-414a-be69-b16e7013b377"), null },
                    { new Guid("2a2af9ed-0034-442e-aacb-1a9bb1c2e807"), null, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new Guid("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a"), null },
                    { new Guid("2e10c5f8-b3ac-488d-804e-ee3061bd2252"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("5adcb96d-70ef-403d-89c6-cc3aa807b6a7"), null },
                    { new Guid("31cb74af-8da3-4b38-93d9-c8d90ce14808"), null, new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new Guid("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1"), null },
                    { new Guid("336ff2e6-a0f0-4341-9607-5acc5be974ab"), null, new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new Guid("3f77fd90-591c-45f3-8bbc-87d0bb49e461"), null },
                    { new Guid("3476e35c-5105-45a5-b0e6-890430e3ddda"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("e45c2156-a98c-4121-90b4-25097e8a5cd1"), null },
                    { new Guid("348936db-a2b8-4409-85b9-c6d01e6a9dc3"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("17c9d30f-bd85-4e58-bfc0-6b6d70b2e5fe"), null },
                    { new Guid("37f5b866-0cac-462a-aaea-37a3936029da"), null, new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new Guid("1cddc91d-209a-4948-8e9f-9017252d5423"), null },
                    { new Guid("39e95854-7115-4609-b6f7-b64d5d54c2fa"), null, new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new Guid("a9385e8a-e9b9-484f-beeb-bc35529cf91a"), null },
                    { new Guid("3be0bfb6-1959-4988-9f83-c8df9a0f7b74"), null, new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new Guid("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649"), null },
                    { new Guid("3ca94dc7-a274-4e98-822a-9d56069051d3"), null, new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new Guid("f0e8f9cd-d133-49cf-be7d-d427b630e05a"), null },
                    { new Guid("408d7dc3-3659-4891-b612-79575307a0e3"), null, new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new Guid("e23d4491-73d1-45b5-8010-0385d7185c98"), null },
                    { new Guid("41ab9c57-353c-4879-9515-aea29f6aec63"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("d3850e1b-4780-490d-8c0c-ced1a9aa323b"), null },
                    { new Guid("42f5dff6-1867-4684-aa7e-4ead034fe8e2"), null, new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new Guid("a1589990-affa-4805-a1e0-73de1ffa8516"), null },
                    { new Guid("4573d126-5d8e-4501-b70a-42a964e81868"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("a5dbb27a-4856-44be-a239-76eb073c3e41"), null },
                    { new Guid("47831497-3ce6-4833-b3b4-ff73b6283d12"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("36398f6d-0668-4d37-8850-9f9ee89b8b92"), null },
                    { new Guid("494776dd-b685-4e2f-9cbd-bf1e02ec9d88"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("a43d7637-6fc7-421b-86f1-f83e691431a4"), null },
                    { new Guid("4c3e3271-0d4d-4d47-ac15-eec123c4fbe4"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("bf0f7ca4-9089-4800-95d7-8d037d98b7fc"), null },
                    { new Guid("54b0e0eb-db8d-4882-85fd-877617147f89"), null, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("40991196-f258-43f1-ac84-0381afa83477"), null },
                    { new Guid("5703c668-035a-41c2-bf9a-814217f2bc8f"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("faec7c41-2e11-4092-8ab9-cc9c152d858f"), null },
                    { new Guid("5ad91c7f-7689-4f71-8d00-66d4618a55f2"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("9c3399d1-72db-4e86-a518-2575033bb6a8"), null },
                    { new Guid("5f0c4153-96b0-42e5-910d-b06ac260b5e6"), null, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new Guid("21e32570-7d64-4cec-b711-873185c76523"), null },
                    { new Guid("62787729-0216-4a7f-a473-2d604940012f"), null, new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new Guid("5feca670-1f15-430d-9b04-7ac86a329a6c"), null },
                    { new Guid("68894feb-0428-49c5-ac24-05178d17e2fe"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("28b06cf6-6367-4786-bccb-89c43dd3ce3a"), null },
                    { new Guid("6ab602d7-4933-4cab-be54-dc3a33ca2b91"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("a7936b9f-b6f8-4295-8b6e-6fe1b096f437"), null },
                    { new Guid("6d311247-b6d9-4f16-a9b2-a9b00ddfb138"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("7b138bd4-4d3a-426c-9ab0-d66699b762d2"), null },
                    { new Guid("6debe8e9-585c-4e2e-84e5-e87080cce1b0"), null, new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new Guid("1500876f-ef20-40de-baae-de0336bdc47b"), null },
                    { new Guid("6e9a3aba-344d-44f9-a1d9-a1517ee014a1"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("26096793-894d-47c1-a06f-cf9133f8089d"), null },
                    { new Guid("6f96f8ab-5de3-4f6d-a366-f4b8e2b8d89c"), null, new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new Guid("749b288c-112b-4b7b-8750-0daff63d9ab3"), null },
                    { new Guid("70aff27f-7c50-4a40-9317-d7fe41cbd93f"), null, new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new Guid("4e9013c8-d6f7-4740-80d5-e95d318873b9"), null },
                    { new Guid("720e3c2c-ba72-4484-a2de-43fb6cedd46d"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("c6e853f0-06bd-4cda-8b43-cbe66fea98c8"), null },
                    { new Guid("728fa290-7953-4069-b950-9c0a5115999e"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("113f6a04-87c4-43c6-8263-920bd099c8e0"), null },
                    { new Guid("7574dbf9-a2a3-4e6f-bc7e-aab0a7c9c732"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("f928b7a6-2558-478a-bc22-515516f4dc74"), null },
                    { new Guid("795cadec-7e22-4c24-bc7c-d8ea8f03a0c3"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("63d10d95-7983-455e-b920-29c1f0c88d85"), null },
                    { new Guid("8001441c-20c8-4b55-9d80-6b30981a4f43"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("549d664a-eb1c-4b9a-8ad7-fab9e1482e5b"), null },
                    { new Guid("871a7564-725f-4a10-be82-544075ab7c19"), null, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new Guid("9c276c0b-84b6-4216-8dbb-ae2034ac2176"), null },
                    { new Guid("874fa8ff-6b45-4dd2-8e6b-1e3362059ba5"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("cd0b1476-44a8-4350-a6a1-3de8747a5ebc"), null },
                    { new Guid("8c8d7bab-6969-4593-940e-7c66cd6675c0"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("56681171-ccbd-4700-90bc-2233c1e661bb"), null },
                    { new Guid("8f42609e-7ff5-4926-b942-4047921ca2db"), null, new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new Guid("c4fc900f-5a92-4228-ac03-57285fff159e"), null },
                    { new Guid("9a27f39d-80d9-4508-93da-a8e69102aef3"), null, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new Guid("1cf439ce-a31b-4b95-b092-b7f6edf8d40f"), null },
                    { new Guid("9c1b5083-f4b1-4f61-8349-d2b8c04fdebb"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("6e98f2be-9196-4c4e-8279-b02010f853f1"), null },
                    { new Guid("9dff0a8e-d82e-4a3b-a22d-3ffb30cb7dba"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("f483bb75-84f0-4ecc-8a06-f366a488c6bf"), null },
                    { new Guid("9ebd9586-5f56-4396-b642-9b8420565f4b"), null, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new Guid("59589114-7d6a-4c80-8681-db5c554ab38f"), null },
                    { new Guid("a048cd64-355d-40be-87cd-67ab6d88000e"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("87409e4f-4bea-4bba-855d-a3bfbc2f9c20"), null },
                    { new Guid("a152489b-556b-46a6-8283-8669b76908f2"), null, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new Guid("c4993d6a-a2e0-4ddd-821a-0629541e019c"), null },
                    { new Guid("a32f27fb-f1b6-4e04-9deb-dac9845e04b8"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("7be0e4d3-1e50-4de1-931d-08adb85f628b"), null },
                    { new Guid("a4483429-f3c4-4535-8a00-7ae28694a71d"), null, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new Guid("bad70aff-4237-4c83-b412-460020a5ee44"), null },
                    { new Guid("a62a16b0-5b81-4244-beaa-bdf04e6a8b5a"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("52c86d57-0909-41c3-b513-e770e6f6d104"), null },
                    { new Guid("a6880dbf-d3f4-4e05-be58-8b6a1577d510"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("218b9709-852d-4a1f-ad8b-c9410b49fea6"), null },
                    { new Guid("a7357ac3-a341-4871-aa15-f39e057a0229"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("bd16f0ec-5ae1-42f4-a302-b4bce8f0db28"), null },
                    { new Guid("ac703bfc-9650-4564-bfcf-66cacf1d0e55"), null, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new Guid("d09266d3-9e7d-46a6-ad3a-7c608ec802d1"), null },
                    { new Guid("ad923005-b9aa-4a40-9fd8-04cc4cfc1a09"), null, new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new Guid("22f0a09e-6816-410e-a5a2-c802103b089b"), null },
                    { new Guid("b0c6f2c0-401b-4789-bfb2-9fa9fd7264c5"), null, new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new Guid("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52"), null },
                    { new Guid("b2fe363d-c745-4226-8c9f-758dea10abfa"), null, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new Guid("424ebe64-6570-4d88-9052-08c06dc0a2c8"), null },
                    { new Guid("b6b697b9-459a-48f4-b751-7b4a056fb5e1"), null, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("1808de3e-ae43-41a6-b9ce-bfe89131be5a"), null },
                    { new Guid("b7a0e65c-55ff-4fdc-9e07-ddf7b3db061c"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("5a9ac478-aa65-48ea-9387-1ad92f6c76b1"), null },
                    { new Guid("bcf05452-bcfc-4190-ac4c-4e766967b5a1"), null, new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new Guid("2892c25f-bd50-4bb4-a845-997395ef6693"), null },
                    { new Guid("bd668cf8-e0e1-4483-9990-f932c3ee6a0a"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("f9bc9ae8-e42e-4e8b-84d3-f2bc36037552"), null },
                    { new Guid("c57fa773-0130-4f4e-be99-5b04982737cc"), null, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new Guid("eceaaa32-4023-4eab-abb6-9172c908f77c"), null },
                    { new Guid("c638888e-6081-4f49-9632-d50f5ab9d44a"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("919c7f66-53e5-46bd-b181-558f6052b953"), null },
                    { new Guid("c7846f51-f3fa-4ef8-9827-695179db6da3"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("5afaa147-398e-4be8-b0d1-8dcabe6ed18c"), null },
                    { new Guid("cbedf789-f49d-42fb-8191-ffa296315820"), null, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new Guid("18809fb3-b78a-4f67-b9f9-8bb6ab95ab00"), null },
                    { new Guid("cefa94be-8970-4c76-9341-c668c87dff3d"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("399eee61-90b5-464f-b3f7-7ddc1077ab0d"), null },
                    { new Guid("d0dce350-7d66-4332-a13e-dc7c53ca4c7f"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("d9dad801-145a-419d-bbe2-408acf97a273"), null },
                    { new Guid("d15561d6-7744-4b9c-91ac-91eea4a3b771"), null, new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new Guid("93984b54-2044-4ea9-8364-a03c6568e358"), null },
                    { new Guid("da0148ad-28fb-4b03-a287-4578c4cf75f2"), null, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new Guid("bdd1ee1e-3a93-421f-855e-0993c7e6f767"), null },
                    { new Guid("dce074e5-9d57-45db-ab96-6e40167eab67"), null, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new Guid("3f19ef5c-3c60-4a11-b1b3-5158859f1286"), null },
                    { new Guid("e07d403f-6dbc-4067-8ec9-ed76b5ed529e"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("91524cc2-db22-4cab-abb7-700725232f1f"), null },
                    { new Guid("e12992a5-12ee-46d8-8f04-fa1043a71a9d"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("6f34350b-8f99-446e-9de9-e0c6277b10f3"), null },
                    { new Guid("e319d8d3-9801-47c3-9d12-ac9bf9d64335"), null, new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new Guid("6792c392-3c86-4162-be91-4fc8646f861d"), null },
                    { new Guid("e42c3db0-357a-44b0-9bfc-ed6ec3a1bd3d"), null, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new Guid("1802caa2-cfe0-48e7-8580-29165f84387d"), null },
                    { new Guid("e5b50b57-c52a-4b1e-b3f8-77810a9c31f4"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("e09c493c-5806-4b14-bbef-e26e19e1d8d5"), null },
                    { new Guid("e7c41a26-ea47-4b77-aad8-f516237e2d68"), null, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new Guid("16dc894a-746e-497e-a2c5-2d58f7f83c4d"), null },
                    { new Guid("e849207c-073b-4006-bacc-322de008a20f"), null, new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new Guid("5384aebd-4eab-4a44-8cbb-7ec2c04f1401"), null },
                    { new Guid("e8fe8d6c-7771-4a94-95e0-519a3474bbcc"), null, new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new Guid("41ae956e-14fc-44af-bc6a-e5ba77661cee"), null },
                    { new Guid("ec984474-2053-457f-b822-80e031bbbd9c"), null, new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new Guid("f7b36043-9ca9-42c3-8a00-e9e235b56bb3"), null },
                    { new Guid("ed06d555-539a-4fad-bffc-5fc0965892f3"), null, new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new Guid("255ba0f6-14cc-4049-add8-138f27055b49"), null },
                    { new Guid("ee8e462d-e427-4427-a49a-9d640d623ffa"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("1b56833b-1ff5-4a90-aea9-074de2d0dd67"), null },
                    { new Guid("ef216954-1f4a-4c06-92a1-12dbc4254df4"), null, new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new Guid("5f7f859a-f20a-4f6c-8b8c-ecfbb1ff522e"), null },
                    { new Guid("efda0c4a-91f2-4d22-989d-02f9e0150dff"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("c605aa91-495e-4977-9876-b2a198ce356e"), null },
                    { new Guid("f0cac20f-4096-409b-817a-40c20e38c7d5"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("23ce32a0-6597-4b60-b35c-98073ff595c6"), null },
                    { new Guid("f6f6f41a-fc8f-4796-b82c-977e7c126fd0"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("c65d34ee-8c0c-43bb-9d4e-aa39955a4768"), null },
                    { new Guid("f9f94a00-9540-465c-8ad9-a07a4d6903db"), null, new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new Guid("92e149ff-8491-48cf-a4e8-8106b1e95c4c"), null },
                    { new Guid("fa6131f4-0a6f-43fc-8f80-ca617d0cf786"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("a88faa7c-6eab-4ecb-8a75-b078a9cf7834"), null },
                    { new Guid("fb3d6450-0f5a-4580-9c7a-22f74e115bd3"), null, new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new Guid("ef6b8c43-9ab5-497c-a9a8-e31f0a349527"), null },
                    { new Guid("fcbf4c81-3f96-40e5-b756-9fbaa148aa3e"), null, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new Guid("84793ef9-fcd0-42df-ab0d-9380dfa18630"), null },
                    { new Guid("fdfff835-bb04-4d2d-8e74-ddc5d2354848"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("40bbc8c4-f383-4ae6-979a-3ac83c275881"), null },
                    { new Guid("ff119b0b-5fa2-48fa-ac1c-d141f60130d4"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("698c67ad-a726-435b-b9d2-c5690a79eb5a"), null },
                    { new Guid("ff813188-f353-402a-9aec-d1cec9d0ce6d"), null, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new Guid("a33065fe-80ad-4879-9333-424aadc6734f"), null }
                });

            migrationBuilder.InsertData(
                table: "Nutrition",
                columns: new[] { "NutritionId", "Calcium", "Calories", "Carbs", "Cholesterol", "CreatedAt", "Fat", "Fiber", "FoodId", "Iron", "Potassium", "Protein", "SaturatedFat", "Sodium", "Sugar", "UnsaturatedFat", "UpdatedAt", "VitaminA", "VitaminB1", "VitaminB2", "VitaminC", "VitaminD", "VitaminE" },
                values: new object[,]
                {
                    { new Guid("0083f139-137e-428e-8c28-6148e9c9895a"), 37f, 53f, 13f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1.8f, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), 0.1f, 166f, 0.8f, 0f, 2f, 10.5f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.34f, 0.06f, 0.03f, 26.7f, 0f, 0.2f },
                    { new Guid("00fe58fe-3943-45fd-bd55-809a72769d9e"), 5f, 35f, 6.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 2.5f, new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), 0.3f, 300f, 2.2f, 0f, 3f, 0f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.06f, 0.07f, 0.5f, 0.02f, 0.1f },
                    { new Guid("0100cfae-cc21-438b-8dbc-558aaf0e42f2"), 20f, 170f, 35f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 0.8f, new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), 0.8f, 80f, 4f, 1f, 350f, 1.2f, 2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.01f, 0.02f, 0.02f, 1f, 0f, 0.1f },
                    { new Guid("018672fb-93b9-43eb-ac02-664766eeebdc"), 10f, 112f, 24f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.8f, 1.8f, new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), 0.4f, 86f, 2.6f, 0.2f, 1f, 0.4f, 0.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.14f, 0.02f, 0f, 0f, 0.1f },
                    { new Guid("02da2ce8-3d38-4db3-858b-616f3bb2ccc5"), 11f, 65f, 17f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1.8f, new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), 0.2f, 168f, 0.5f, 0.1f, 1f, 14f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.54f, 0.03f, 0.04f, 36.4f, 0f, 0.9f },
                    { new Guid("0387be53-45b7-40b8-b6c2-0644917bf761"), 40f, 40f, 4f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1f, 1.5f, new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), 1.5f, 250f, 4f, 0.5f, 300f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 300f, 0.05f, 0.1f, 5f, 0f, 0.5f },
                    { new Guid("082ca4fa-b256-4648-8757-1bf35900e7d7"), 120f, 61f, 4.8f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, 0f, new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), 0.1f, 150f, 3.3f, 0.6f, 44f, 4.8f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 47f, 0.02f, 0.18f, 0f, 2f, 0.1f },
                    { new Guid("0b3e92e9-c872-4707-b765-9a79dcfd0531"), 3f, 27f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2.5f, new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), 0.4f, 359f, 2.2f, 0f, 3f, 1f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.11f, 0.1f, 2.1f, 0f, 0.01f },
                    { new Guid("0b49a9a4-cda4-4741-9b34-dfb8d6b0264e"), 40f, 30f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 3f, new Guid("2ee163f7-4463-44ec-b9e2-8a409c112db4"), 0.8f, 300f, 2f, 0.1f, 150f, 2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 500f, 0.04f, 0.05f, 20f, 0f, 0.5f },
                    { new Guid("0b5592ec-ac54-43a6-bd59-6a48aba46708"), 43f, 112f, 26f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 4.1f, new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), 0.6f, 484f, 1.5f, 0f, 13f, 0.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 47f, 0.09f, 0.03f, 4.5f, 0f, 0.1f },
                    { new Guid("0d63f63c-9026-46c6-b5aa-c23cf53dc1dd"), 25f, 81f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.4f, 5f, new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), 1.5f, 244f, 5f, 0.1f, 5f, 5.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 765f, 0.27f, 0.15f, 40f, 0f, 0.1f },
                    { new Guid("0e031b9d-0ac4-4ecc-8994-54eaaeb75c5f"), 20f, 250f, 38f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6f, 1f, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), 1.2f, 100f, 10f, 2f, 300f, 4f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.01f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("0f5b2ed3-75f1-48b1-ad0b-b7445f1e0ec9"), 5f, 66f, 16.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.4f, 1.3f, new Guid("7b8500af-d730-4138-9617-cba352faed4a"), 0.3f, 171f, 0.8f, 0f, 1f, 15.2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.01f, 0.07f, 71.5f, 0f, 0.1f },
                    { new Guid("0ff96d56-9166-4975-b943-3b1e02196b14"), 10f, 330f, 0f, 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 25f, 0f, new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), 1.5f, 200f, 27f, 9f, 75f, 0f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.08f, 0.05f, 0f, 0f, 0.1f },
                    { new Guid("10123427-bbba-49ab-b633-5522799181b5"), 201f, 80f, 2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, 1.2f, new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), 1.6f, 121f, 8f, 0.7f, 7f, 0.7f, 2.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.04f, 0.03f, 0f, 0f, 0.02f },
                    { new Guid("11380f32-e7e6-48fc-ab23-d471a1d1d8b6"), 20f, 220f, 40f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 1f, new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), 1.2f, 100f, 7f, 2f, 300f, 5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.05f, 0.05f, 0.03f, 0f, 0f, 0.2f },
                    { new Guid("119b1289-5382-464a-a540-24a18ae6b7bb"), 30f, 86f, 20f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 3f, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), 0.6f, 337f, 1.6f, 0f, 55f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.96f, 0.08f, 0.03f, 2.4f, 0f, 0.26f },
                    { new Guid("12e5fdd4-a1ed-4dfd-87f8-2d0941975241"), 105f, 13f, 2.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 1f, new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), 0.8f, 176f, 1.5f, 0f, 65f, 1.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.6f, 0.04f, 0.07f, 45f, 0f, 0.15f },
                    { new Guid("131c5d1d-88ca-49d9-9246-02f16b424705"), 20f, 30f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1f, new Guid("2ae82bfd-34db-4928-bfee-b60f4aec4460"), 0.5f, 200f, 1.5f, 0.1f, 250f, 3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 500f, 0.05f, 0.03f, 15f, 0f, 1f },
                    { new Guid("13d9ea64-51b6-4c4a-b366-0b4537ef3a9c"), 40f, 45f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5f, 3f, new Guid("eec3d874-6331-4e33-bbe6-bf0cc4335b29"), 1f, 250f, 1.5f, 0.1f, 50f, 4f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 700f, 0.05f, 0.06f, 25f, 0f, 1f },
                    { new Guid("15011714-ced2-4820-8989-beef33ca6d79"), 277f, 172f, 8.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9f, 6f, new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), 2.5f, 620f, 18f, 1.3f, 15f, 2f, 7.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9f, 0.16f, 0.18f, 6f, 0f, 0.9f },
                    { new Guid("16fdd29d-d57f-4176-8e3e-4ed9af7a37a7"), 30f, 280f, 40f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6f, 1.5f, new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), 1.5f, 250f, 16f, 0.5f, 500f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 150f, 0.1f, 0.1f, 5f, 0f, 0.4f },
                    { new Guid("17cb0952-2c39-4b8f-a3bd-ec906445ec2b"), 23f, 40f, 9.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 1.7f, new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), 0.2f, 146f, 1.1f, 0f, 4f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.01f, 0.05f, 0.02f, 7.4f, 0f, 0.02f },
                    { new Guid("193e95e3-9179-4534-a061-471315c92b09"), 10f, 18f, 3.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 1.2f, new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), 0.3f, 237f, 0.9f, 0f, 5f, 2.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.85f, 0.04f, 0.02f, 13.7f, 0f, 0.5f },
                    { new Guid("1cdc6bfd-16f4-442b-a546-5ee60adff563"), 11f, 165f, 0f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, 0f, new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), 0.9f, 256f, 31f, 1f, 74f, 0f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.06f, 0.08f, 0f, 0f, 0.3f },
                    { new Guid("1f7eb1d1-5ba2-4c04-9b6b-e2391098317d"), 54f, 375f, 68f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7f, 10f, new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), 4.7f, 362f, 13f, 1.2f, 2f, 1f, 5.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.76f, 0.14f, 0f, 0f, 0.42f },
                    { new Guid("1f8643d3-fc72-4cb7-80b5-97512ef05e47"), 2f, 2f, 0f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0f, new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), 0f, 49f, 0.2f, 0f, 5f, 0f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0f, 0f, 0f, 0f, 0f },
                    { new Guid("2178e139-1566-44c4-a747-7c3d0005c886"), 20f, 80f, 5f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 1.5f, new Guid("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), 0.7f, 180f, 8f, 0.3f, 250f, 1f, 1.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 0.07f, 0.05f, 8f, 0f, 0.4f },
                    { new Guid("25ee5c45-58c9-460e-aaca-5fd3835052fa"), 15f, 200f, 40f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 1f, new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), 0.5f, 120f, 5f, 0.1f, 250f, 1f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.1f, 0.1f, 0f, 0f, 0.1f },
                    { new Guid("285e0d19-adfb-41c2-9010-a1287fc1ef72"), 20f, 90f, 10f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 0.5f, new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), 0.7f, 150f, 6f, 0.5f, 500f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 0.03f, 0.1f, 1f, 0f, 0.1f },
                    { new Guid("2867753c-c853-4ba3-a4c4-3ba346a51df7"), 60f, 70f, 10f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.5f, 0f, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), 0.2f, 80f, 1.5f, 2f, 40f, 8f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.04f, 0.06f, 0f, 0f, 0.1f },
                    { new Guid("290318be-6bee-473c-bb41-3f83e66f988f"), 10f, 170f, 35f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 0.5f, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), 0.4f, 100f, 2f, 1f, 250f, 0.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.02f, 0.02f, 0f, 0f, 0.1f },
                    { new Guid("29605db0-6cae-4276-9cee-ea9f6e4b2e37"), 7f, 30f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.4f, new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), 0.2f, 112f, 0.6f, 0f, 1f, 6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.57f, 0.03f, 0.02f, 8.1f, 0f, 0.05f },
                    { new Guid("2ab79896-44ef-4d1e-881b-c518ca8bb4d2"), 30f, 280f, 15f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 5f, new Guid("a364353c-d589-4a94-9c3b-3038113ea249"), 2.5f, 350f, 25f, 2.5f, 350f, 5f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 150f, 0.1f, 0.1f, 25f, 0f, 1f },
                    { new Guid("2b90a8e7-0d5d-415c-aec0-83bfb0783c24"), 22f, 280f, 45f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 3f, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), 2.4f, 115f, 10f, 0.5f, 491f, 6f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.2f, 0.12f, 0f, 0f, 0.1f },
                    { new Guid("2d70fa5a-4c3b-47a8-ab82-8c8b01acd116"), 27f, 18f, 4.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 1.6f, new Guid("845454d0-967a-4e48-aef3-bd8458775500"), 0.3f, 233f, 0.6f, 0f, 9f, 2.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.02f, 0.03f, 14.8f, 0f, 0.2f },
                    { new Guid("2fe0686e-af8e-4073-b021-ff40a88b4e39"), 35f, 40f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 2f, new Guid("0292d477-d63b-4904-a83b-2cd8cac39c14"), 0.5f, 330f, 1.5f, 0.1f, 250f, 3f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 600f, 0.05f, 0.08f, 45f, 0f, 0.7f },
                    { new Guid("33230f6d-31d5-4ee6-bdd4-f884fbf33a04"), 15f, 210f, 6f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 0f, new Guid("43d635e2-6f0c-4385-83d8-fedfd479d356"), 1f, 220f, 25f, 1f, 340f, 3f, 2.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20f, 0.08f, 0.07f, 0f, 0f, 0.4f },
                    { new Guid("35637c06-6739-4bb6-9db5-874db5fdf22a"), 35f, 30f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 2f, new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), 0.5f, 250f, 1.5f, 0.1f, 80f, 2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 650f, 0.04f, 0.05f, 20f, 0f, 0.4f },
                    { new Guid("367e9862-2e5a-4c81-923a-03d1599d2097"), 40f, 300f, 40f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8f, 2f, new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), 2f, 250f, 18f, 5f, 700f, 3f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.12f, 0.1f, 3f, 0f, 0.5f },
                    { new Guid("37f77e2b-960f-4900-a6df-e836bc32e2e7"), 30f, 150f, 20f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 0.5f, new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), 1.5f, 200f, 10f, 2f, 500f, 0.5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("38a8065a-8161-4693-8fbb-3a8b2740ff79"), 20f, 240f, 30f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 1f, new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), 1.5f, 150f, 8f, 3f, 480f, 1f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("392d3cf6-ca94-43bd-a108-ff90f6e6bbcc"), 25f, 180f, 5f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 0f, new Guid("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), 1.5f, 300f, 20f, 1.5f, 350f, 3f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 80f, 0.1f, 0.07f, 2f, 0.5f, 0.3f },
                    { new Guid("3b491292-858f-4a1e-8417-108bb2f7f743"), 15f, 250f, 8f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15f, 0f, new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), 1.2f, 330f, 20f, 6.5f, 530f, 5f, 10.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 45f, 0.8f, 0.2f, 0f, 0f, 0.3f },
                    { new Guid("3d1f735b-4cf9-46cd-8b13-ae72a20fc94e"), 10f, 30f, 7.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0f, new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), 0.1f, 40f, 0f, 0f, 3f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.01f, 0.01f, 20f, 0f, 0f },
                    { new Guid("3f6ee71d-7cbb-4d4c-a408-a43f38db0aeb"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.4f, 2.2f, new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("4162affb-0e44-46fd-ba3d-961fc3e7a529"), 20f, 190f, 38f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 1.5f, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), 1f, 100f, 5f, 0.5f, 300f, 4f, 1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.05f, 0.06f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("41b4724a-87eb-4142-a458-b4b2c349658c"), 20f, 250f, 0f, 90f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15f, 0f, new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), 2.5f, 280f, 26f, 6f, 75f, 0f, 9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.08f, 0.2f, 0f, 7f, 0.5f },
                    { new Guid("42562d74-8090-40d1-819a-d471ccf5343c"), 40f, 300f, 40f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8f, 2f, new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), 3f, 350f, 20f, 4f, 900f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.1f, 0.08f, 1f, 0f, 0.2f },
                    { new Guid("42f21267-6c3b-49f5-a1c8-4ae26bd3231f"), 20f, 180f, 35f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 0.5f, new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), 0.7f, 120f, 4f, 1f, 400f, 0.5f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 0.08f, 0.05f, 1f, 0f, 0.2f },
                    { new Guid("42f38014-99b1-4a25-bd1f-d91fe3a8daff"), 8f, 110f, 22f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9f, 2.5f, new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), 0.2f, 60f, 3.5f, 0.1f, 4f, 0.2f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.08f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("45debd99-8093-4194-8b5d-397fda9fd033"), 40f, 25f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 1.5f, new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), 0.6f, 120f, 1.2f, 0f, 750f, 2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.01f, 0.02f, 15f, 0f, 0.02f },
                    { new Guid("4a182622-3b68-45e6-b6c7-c244b8add076"), 30f, 180f, 10f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8f, 2.5f, new Guid("85e621ed-0e0c-4d20-8891-51d311cea4a3"), 2f, 250f, 20f, 1.5f, 400f, 3f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40f, 0.1f, 0.1f, 4f, 0f, 0.5f },
                    { new Guid("4ac1fef2-f3f0-4167-afb4-a2f5988460d5"), 40f, 380f, 60f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 3f, new Guid("2405ffc3-524e-4331-9e68-47a411d7b9b8"), 1f, 150f, 16f, 1.5f, 500f, 3f, 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 0.1f, 0.08f, 5f, 0f, 0.4f },
                    { new Guid("4b6f98fb-82f4-467c-8580-9c66da8c1359"), 45f, 31f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 2.8f, new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), 0.6f, 216f, 1.4f, 0f, 27f, 3.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 993f, 0.05f, 0.06f, 36.6f, 0f, 0.1f },
                    { new Guid("4c0bbcc4-e178-4499-989f-849a29e7b02b"), 16f, 25f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1.5f, new Guid("3dc2fa80-ab87-4e26-907b-3516611371b8"), 0.3f, 140f, 1f, 0f, 125f, 2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20f, 0.05f, 0.06f, 12f, 0f, 0.1f },
                    { new Guid("4c46d5f0-12c9-4b8f-a591-32b5042f762a"), 25f, 70f, 6f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 1.5f, new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), 1f, 250f, 8f, 0.5f, 500f, 3f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 0.1f, 0.1f, 10f, 0f, 0.3f },
                    { new Guid("4d8fb26c-7ce1-40f9-ba64-5499390a7196"), 80f, 280f, 35f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 2f, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), 2.5f, 400f, 15f, 4f, 850f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.1f, 0.2f, 4f, 0f, 0.5f },
                    { new Guid("5005de60-10fe-4447-b16f-7c6fb6474045"), 12f, 190f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 0f, new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), 1.1f, 302f, 20f, 4.3f, 60f, 0f, 8.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.03f, 0.33f, 0f, 440f, 0.5f },
                    { new Guid("51b05fcc-570a-4e15-822c-c4609e8013a7"), 50f, 290f, 30f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 2f, new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), 2f, 450f, 20f, 4f, 1200f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.1f, 0.2f, 2f, 0f, 0.4f },
                    { new Guid("5417a5ee-58a8-4fb2-9c96-6e0acc22ba2e"), 4f, 110f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.9f, new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), 0.1f, 15f, 1.7f, 0.1f, 10f, 0f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.01f, 0.01f, 0f, 0f, 0f },
                    { new Guid("549a0eca-43ef-4bd6-a853-95acaa2efd8e"), 2f, 96f, 21f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5f, 2.4f, new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), 0.5f, 270f, 3.4f, 0.2f, 1f, 4.5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.15f, 0.1f, 6.8f, 0f, 0.2f },
                    { new Guid("5585f814-f3af-4819-b42b-6b97cf84532a"), 40f, 300f, 35f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 2f, new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), 2f, 250f, 18f, 5f, 800f, 3f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.1f, 0.08f, 3f, 0f, 0.3f },
                    { new Guid("57e6af2e-5ac5-442d-96d3-d3862d2c5cc7"), 110f, 90f, 15f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 1f, new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), 0f, 140f, 3f, 1f, 35f, 12f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.05f, 0.04f, 0.14f, 0f, 0.02f, 0f },
                    { new Guid("587a1006-d046-4052-a884-4c9b874f80a0"), 40f, 250f, 45f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 1.5f, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), 1.5f, 250f, 8f, 2f, 700f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.08f, 0.06f, 1f, 0f, 0.2f },
                    { new Guid("5a248de8-f350-41ce-8603-9f2fed35c28f"), 130f, 20f, 3.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 1.5f, new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), 1f, 140f, 1.8f, 0.1f, 40f, 1f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 800f, 0.05f, 0.07f, 40f, 0f, 0.4f },
                    { new Guid("5c16ffb3-8542-4ba1-a262-ea01157222ce"), 130f, 25f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1.5f, new Guid("982d8f3e-f517-4bd2-87a8-48329fc9eb91"), 0.8f, 260f, 1.8f, 0.1f, 60f, 1f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 560f, 0.06f, 0.08f, 35f, 0f, 0.5f },
                    { new Guid("5cc8f6e1-5d21-4efd-a789-d1f150a48729"), 33f, 41f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 2.8f, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), 0.3f, 320f, 0.9f, 0f, 69f, 4.7f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.69f, 0.04f, 0.03f, 5.9f, 0f, 0.66f },
                    { new Guid("60fb466a-c97d-4089-bc96-be5a01619d43"), 11f, 240f, 0f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 19f, 0f, new Guid("51061170-597d-4289-a021-1e7dde88331f"), 2.7f, 205f, 19f, 8.5f, 63f, 0f, 12.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.06f, 0.15f, 0.23f, 0f, 0.02f, 0.3f },
                    { new Guid("615c1b1f-8e2c-4144-b401-1c8ae55cef75"), 150f, 25f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2.5f, new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), 1.6f, 296f, 2.5f, 0.1f, 50f, 1f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 740f, 0.07f, 0.09f, 55f, 0f, 1.2f },
                    { new Guid("62fdeffe-888f-48f9-99e5-3401f121ee64"), 10f, 60f, 13f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.4f, 3f, new Guid("86d88717-df08-4de6-b86d-870210864b46"), 0.3f, 150f, 1.2f, 0.1f, 4f, 8f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.04f, 0.05f, 3f, 0f, 0.3f },
                    { new Guid("644fabe3-d538-4e7f-bb04-b577e5abdfd8"), 14f, 354f, 15f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 33f, 9f, new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), 2.4f, 356f, 3.3f, 29.7f, 20f, 6.2f, 3.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.04f, 0.02f, 3.3f, 0f, 0.3f },
                    { new Guid("64950ee9-046d-4342-9c28-ee63c365aa89"), 40f, 110f, 15f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 3f, new Guid("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), 0.5f, 230f, 10f, 0.2f, 300f, 5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 850f, 0.05f, 0.07f, 15f, 0f, 0.5f },
                    { new Guid("667e427d-2e2e-4807-a034-946a6fc8a30d"), 10f, 83f, 19f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2f, 4f, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), 0.3f, 236f, 1.7f, 0.1f, 3f, 14f, 1.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.07f, 0.06f, 10.2f, 0f, 0.6f },
                    { new Guid("67282a27-b367-4bc0-a8ef-7d360e406226"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.4f, 2.2f, new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("672d06b1-2853-492e-a6f5-03f1f7d1311c"), 15f, 190f, 0f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9f, 0f, new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), 0.8f, 260f, 27f, 4.1f, 70f, 0f, 9.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 0.06f, 0.11f, 0f, 0f, 0.3f },
                    { new Guid("673941ac-bb35-4b1c-93c6-2241f54e8f90"), 24f, 19f, 3.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 1.1f, new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), 0.3f, 250f, 0.7f, 0f, 11f, 2.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.03f, 0.02f, 2.4f, 0f, 0f },
                    { new Guid("6e2223ea-5bcc-41fe-9320-f635fdfbb1af"), 10f, 160f, 35f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5f, 0.5f, new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), 0.5f, 50f, 3f, 0.5f, 300f, 1f, 1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.01f, 0.01f, 0f, 0f, 0.1f },
                    { new Guid("6ee8d5db-1953-434f-aded-85cca0f90e9e"), 40f, 25f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 2f, new Guid("4edcae53-7e30-42bb-8526-7686355f2268"), 1f, 300f, 2f, 0.1f, 150f, 1f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 500f, 0.05f, 0.06f, 30f, 0f, 0.5f },
                    { new Guid("6f8bd5d9-e17a-41f2-8f48-9c5a17dfb632"), 25f, 260f, 40f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 1.5f, new Guid("7167f942-dc89-4f29-8022-588373aef45e"), 0.9f, 220f, 14f, 0.5f, 400f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 80f, 0.05f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("701a8f56-253d-43c5-93bf-fea87a237bbb"), 81f, 33f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 3.2f, new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), 0.8f, 299f, 1.9f, 0f, 7f, 1.5f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.36f, 0.02f, 0.04f, 21f, 0f, 0.27f },
                    { new Guid("725981fb-f81e-463b-a087-b76da12449f6"), 34f, 61f, 15f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 3f, new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), 0.3f, 312f, 1.1f, 0f, 3f, 9f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 87f, 0.02f, 0.05f, 92.7f, 0f, 1.5f },
                    { new Guid("731ff162-5eaf-46ac-a638-86f41ea526cc"), 70f, 99f, 0f, 189f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1f, 0f, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), 0.3f, 259f, 24f, 0.2f, 111f, 0f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.02f, 0.11f, 0f, 0f, 0.6f },
                    { new Guid("748f6378-3880-4575-a4b3-4e0429dc0c22"), 15f, 125f, 20f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.5f, 0.5f, new Guid("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), 0.9f, 180f, 6f, 1f, 350f, 0.5f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20f, 0.05f, 0.07f, 1f, 0f, 0.2f },
                    { new Guid("761e6705-be93-4d3d-8a16-7e7fc1ea6bae"), 18f, 270f, 0f, 82f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 19f, 0f, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), 2.7f, 300f, 25f, 7.4f, 62f, 0f, 11.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.08f, 0.18f, 0f, 8f, 0.5f },
                    { new Guid("7703e6c8-6e2e-44ee-aa62-891bffa62945"), 30f, 350f, 40f, 80f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15f, 2f, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), 2f, 200f, 15f, 5f, 600f, 4f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.04f, 0.1f, 0.08f, 2f, 0f, 0.3f },
                    { new Guid("77862418-eec2-480b-acfb-bd9f09e5b369"), 6f, 46f, 11f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1.4f, new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), 0.2f, 157f, 0.7f, 0f, 0f, 10f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.03f, 0.04f, 9.5f, 0f, 0.4f },
                    { new Guid("7c8c96b8-a9c0-4e84-9022-d3d849743168"), 30f, 220f, 15f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 2f, new Guid("29dfb5da-8818-40ff-bf66-7553521c2161"), 2.5f, 300f, 20f, 4f, 600f, 5f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 150f, 0.1f, 0.1f, 4f, 0f, 1f },
                    { new Guid("7dc230f3-3bce-43ef-a43d-3138615195e0"), 30f, 110f, 10f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 1f, new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), 1f, 250f, 9f, 1f, 450f, 1.5f, 2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 0.1f, 0.1f, 5f, 0f, 0.4f },
                    { new Guid("7ec5ccad-8112-456c-a8a3-ce3569c742f7"), 110f, 97f, 3.6f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 0f, new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), 0.1f, 141f, 10f, 0.2f, 36f, 3.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 0.04f, 0.14f, 0f, 0f, 0f },
                    { new Guid("7fe0cad6-b741-4c2b-ba69-aea448c7be27"), 20f, 20f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 1.5f, new Guid("e370081a-c0a6-4c00-b01c-7c52f953b7f1"), 0.2f, 150f, 0.8f, 0f, 50f, 2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 0.05f, 0.04f, 12f, 0f, 0.2f },
                    { new Guid("814611c5-44bf-4fb4-a880-11273d97b119"), 21f, 26f, 6.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.5f, new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), 0.8f, 340f, 1f, 0f, 1f, 2.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8533f, 0.05f, 0.11f, 9f, 0f, 0.3f },
                    { new Guid("8224ef56-43b8-4bc7-8e04-7e54c1d67768"), 40f, 330f, 40f, 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15f, 2f, new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), 1.5f, 250f, 12f, 3f, 500f, 3f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 250f, 0.1f, 0.1f, 1f, 1f, 0.7f },
                    { new Guid("8359ade5-f07d-47cb-9eba-2a1da1d1b399"), 22f, 82f, 20f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1.3f, new Guid("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), 0.3f, 42f, 0.9f, 0f, 0f, 14f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.05f, 0.05f, 20f, 0f, 0.1f },
                    { new Guid("8492b451-923c-47e6-9f4e-12d0ca180e33"), 40f, 20f, 3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 2f, new Guid("90a605b6-843d-4cc1-8fe7-a016c76ee29c"), 0.9f, 300f, 2.5f, 0.1f, 100f, 0.8f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 500f, 0.04f, 0.05f, 30f, 0f, 0.5f },
                    { new Guid("84d09d24-2367-4a59-9baf-326d93423205"), 15f, 220f, 45f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 2f, new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), 1f, 200f, 5f, 2f, 250f, 6f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.15f, 0.1f, 3f, 0f, 0.2f },
                    { new Guid("84e5e267-c2e3-4cd6-8637-bd36c1badf5b"), 7f, 143f, 0f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, 0f, new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), 0.9f, 370f, 26f, 5.2f, 65f, 0f, 8.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.6f, 0.15f, 0f, 0f, 0.2f },
                    { new Guid("85fa9837-f7d8-4ed7-b804-76fa4c63534b"), 80f, 260f, 40f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 1.5f, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), 2f, 350f, 12f, 4f, 900f, 2f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.1f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("87c985e5-c09d-4f40-9178-4fab52e44df0"), 50f, 70f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, 3f, new Guid("a988cc73-072e-4af1-9b53-55fbf0f4fe79"), 1.2f, 250f, 2.5f, 0.5f, 200f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 500f, 0.05f, 0.07f, 15f, 0f, 2f },
                    { new Guid("87ca437f-0ac3-46da-a5e3-c6548bea0620"), 50f, 30f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 2f, new Guid("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), 1.2f, 250f, 2f, 0.2f, 300f, 1.5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 400f, 0.05f, 0.07f, 20f, 0f, 0.5f },
                    { new Guid("8a8ed759-4f61-4599-91f4-a3042f88f985"), 120f, 80f, 12f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 0.7f, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), 0.6f, 200f, 3.2f, 1f, 50f, 9f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.1f, 0.1f, 2f, 0.1f, 0.1f },
                    { new Guid("8f086dff-fef7-47ce-a0eb-0efcf3ed4466"), 110f, 60f, 5f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 0f, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), 0f, 141f, 3.5f, 1f, 36f, 4f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.05f, 0.04f, 0.14f, 0f, 0.02f, 0f },
                    { new Guid("8fe48028-9d26-45a3-b058-fe8ebe77301d"), 11f, 180f, 0f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9f, 0f, new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), 0.4f, 265f, 25f, 0.7f, 670f, 0f, 3.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.09f, 0.2f, 0f, 200f, 0.6f },
                    { new Guid("8ff3ece0-5ba9-4be3-a3f9-cd3170a243c4"), 6f, 39f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1.5f, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), 0.3f, 190f, 0.9f, 0f, 0f, 8.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 326f, 0.02f, 0.05f, 6.6f, 0f, 0.1f },
                    { new Guid("92040c9d-46b0-46fa-808e-e028095906ce"), 30f, 320f, 55f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7f, 1.5f, new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), 1.5f, 200f, 10f, 4f, 500f, 1f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.1f, 0.06f, 1f, 0f, 0.3f },
                    { new Guid("9255d754-72dd-4bc4-8de1-bd4f323b3a3e"), 40f, 180f, 7f, 80f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 0f, new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), 1f, 180f, 15f, 7f, 850f, 1f, 9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("93f5c53b-c39c-4119-90d3-3982d6a55203"), 20f, 120f, 10f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 1.5f, new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), 2f, 250f, 10f, 3f, 500f, 2f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 0.1f, 0.1f, 5f, 0f, 0.5f },
                    { new Guid("94eeb000-5148-4d6c-9ea4-2d54d0e03d6a"), 350f, 270f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20f, 3f, new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), 3f, 230f, 17f, 1f, 10f, 1f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 0.05f, 0.1f, 0.5f, 0f, 0.4f },
                    { new Guid("956b7128-ecdd-42e3-9a44-c11c667acad6"), 12f, 190f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 0f, new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), 1.1f, 302f, 20f, 4.3f, 60f, 0f, 8.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.03f, 0.33f, 0f, 440f, 0.5f },
                    { new Guid("95fc8bea-1795-41ce-838b-97d7254f6b8c"), 6f, 52f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 2.4f, new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), 0.1f, 107f, 0.3f, 0f, 1f, 10f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.02f, 0.03f, 4.6f, 0f, 0.18f },
                    { new Guid("9675a184-c705-47ca-8700-489bb219245e"), 10f, 110f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9f, 1.8f, new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), 0.4f, 43f, 2.6f, 0.2f, 1f, 0.4f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.16f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("9899ad76-573d-436d-bebb-25874f33c46d"), 15f, 130f, 20f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 0.5f, new Guid("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), 1f, 200f, 7f, 1f, 400f, 0.5f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30f, 0.05f, 0.1f, 2f, 0f, 0.3f },
                    { new Guid("992ed264-2144-4cc3-98ee-0451777e388a"), 25f, 52f, 12f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.7f, 6.5f, new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), 0.7f, 151f, 1.2f, 0f, 1f, 4.4f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 33f, 0.03f, 0.04f, 26.2f, 0f, 0.9f },
                    { new Guid("99698d56-cd79-4e52-a5f6-16e50d21c3dd"), 5f, 160f, 8.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15f, 6.7f, new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), 0.3f, 360f, 2f, 0.1f, 1f, 0.7f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("99b49988-ddbb-4650-8590-10e3c17a25ca"), 21f, 70f, 19f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 3.6f, new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), 0.8f, 193f, 0.6f, 0.1f, 12f, 13f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60f, 0.01f, 0.02f, 14.7f, 0f, 0.1f },
                    { new Guid("9b344455-10f1-4726-8a8f-1f1518afcf39"), 80f, 280f, 35f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 2f, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), 2.5f, 400f, 15f, 4f, 850f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.1f, 0.2f, 4f, 0f, 0.5f },
                    { new Guid("9b3b467c-0313-4b40-9238-102a0435911e"), 50f, 280f, 45f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8f, 2f, new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), 2f, 300f, 10f, 4f, 500f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.1f, 0.08f, 3f, 0f, 0.3f },
                    { new Guid("9f658a79-9e15-4e11-a7f5-82ac1dda1a3a"), 30f, 250f, 5f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15f, 0.5f, new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), 2f, 400f, 25f, 9f, 900f, 2f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.04f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("a0eb8287-24ff-4e0d-b316-2bc087462b07"), 70f, 99f, 0f, 189f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1f, 0f, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), 0.4f, 264f, 24f, 0.1f, 111f, 0f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.02f, 0.1f, 0f, 0f, 1.3f },
                    { new Guid("a162369b-2ac2-40d2-9636-c98d4cb5fafa"), 55f, 70f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, 2f, new Guid("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), 1f, 450f, 3f, 0.1f, 250f, 1f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 700f, 0.05f, 0.1f, 45f, 0f, 1.2f },
                    { new Guid("a2620397-951d-483c-b6dd-2303bdd8f691"), 20f, 190f, 30f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 0.5f, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), 1f, 100f, 5f, 2f, 450f, 0.5f, 4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.04f, 0.05f, 2f, 0f, 0.1f },
                    { new Guid("a7726596-8418-40ab-bb3a-925dc9a093c9"), 20f, 15f, 3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.8f, new Guid("6487a532-ff5e-4b77-b408-46c789608de9"), 0.3f, 150f, 0.8f, 0f, 180f, 1.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 0.03f, 0.02f, 7f, 0f, 0.1f },
                    { new Guid("a7c2e848-e776-4fd5-9cbd-80dedd506672"), 77f, 20f, 3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 2f, new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), 1.5f, 312f, 2.6f, 0f, 113f, 0.8f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.3f, 0.04f, 0.09f, 55f, 0f, 1.5f },
                    { new Guid("a9156633-32b1-4710-be0c-c4a7762a2f21"), 30f, 320f, 50f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7f, 2f, new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), 1.5f, 250f, 15f, 1.5f, 600f, 3f, 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 200f, 0.1f, 0.1f, 5f, 0f, 0.7f },
                    { new Guid("aa599023-fd38-4e08-ba3d-a255821d27f8"), 40f, 280f, 70f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 1.5f, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), 1.2f, 250f, 25f, 2.5f, 850f, 1f, 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.1f, 0.1f, 3f, 0f, 0.2f },
                    { new Guid("aa72baf7-2851-44ad-b266-c4ff923bc00a"), 5f, 90f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2.6f, new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), 0.3f, 358f, 1.1f, 0.1f, 1f, 12f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("aada3749-d141-4c29-8607-3da6bb15ed1d"), 15f, 420f, 0f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 35f, 0f, new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), 1f, 200f, 30f, 14.6f, 800f, 0f, 24.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.04f, 0.09f, 0f, 0f, 0.3f },
                    { new Guid("ab8917d8-0163-4a92-aa67-2b3e20080983"), 50f, 290f, 45f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6f, 2f, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), 2f, 300f, 15f, 4f, 1200f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.08f, 0.1f, 4f, 0f, 0.2f },
                    { new Guid("ac4f974a-561d-4886-997b-513e39ba4112"), 47f, 34f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.4f, 2.6f, new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), 0.7f, 316f, 2.8f, 0f, 33f, 1.7f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 623f, 0.07f, 0.12f, 89.2f, 0f, 0.8f },
                    { new Guid("acb0fe93-c9d3-46b2-aee1-171cb8814439"), 30f, 270f, 40f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6f, 1.5f, new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), 1.5f, 200f, 15f, 0.5f, 450f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 0.1f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("ae0d2201-4998-42a2-8ea3-469399b3a485"), 15f, 250f, 40f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 1.5f, new Guid("af036922-79f3-45a7-b562-a6279520c0e6"), 0.6f, 200f, 12f, 0.5f, 350f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 0.05f, 0.07f, 3f, 0f, 0.2f },
                    { new Guid("ae94224f-3110-4c05-a25e-b3990bd393c5"), 357f, 150f, 12f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8f, 3f, new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), 2.8f, 240f, 10f, 1.1f, 15f, 6f, 5.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 0.08f, 0.16f, 5f, 0f, 0.5f },
                    { new Guid("b003985f-4d45-4ba2-b259-dbe56ebf6952"), 10f, 120f, 20f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2f, 0.5f, new Guid("c5e3e4ed-0164-4917-a1ce-99679b971a22"), 0.6f, 150f, 6f, 0.5f, 300f, 0.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 0.06f, 0.05f, 1f, 0f, 0.2f },
                    { new Guid("b071f3b5-b579-44d6-8a91-e321893c511f"), 24f, 20f, 3.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 2.1f, new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), 0.5f, 202f, 2.2f, 0f, 2f, 1.9f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 756f, 0.08f, 0.14f, 5.6f, 0f, 1.1f },
                    { new Guid("b2d36922-584e-4334-a800-e90e7e366e82"), 3f, 20f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.1f, new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), 0.1f, 15f, 0.1f, 0f, 2f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.02f, 0.02f, 20f, 0f, 0f },
                    { new Guid("b4fc8bc6-85bc-4d9c-9148-bd3c9dd15af1"), 30f, 25f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 1.5f, new Guid("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), 0.8f, 250f, 1.3f, 0.1f, 300f, 2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 600f, 0.06f, 0.05f, 20f, 0f, 1f },
                    { new Guid("b5133a8f-f7f8-4977-b452-531053bc2337"), 25f, 33f, 2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8f, 0.5f, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), 0.7f, 118f, 3.3f, 0.2f, 51f, 1f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.03f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("b6075a38-1b65-4f7f-8baa-9434ffe8b362"), 500f, 270f, 0f, 152f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6f, 0f, new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), 2.8f, 684f, 58f, 0.3f, 702f, 0f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.04f, 0.12f, 0.1f, 0f, 0.6f, 0.2f },
                    { new Guid("bac2a67f-db78-4851-a5e8-a2412df99a27"), 70f, 35f, 5.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 0.5f, new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), 2.3f, 1040f, 6f, 0.6f, 233f, 0.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 260f, 0.06f, 0.32f, 6f, 0f, 1f },
                    { new Guid("bbb1c577-94c2-43ec-925f-b73ade7df319"), 10f, 130f, 28f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 0.4f, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), 0.2f, 35f, 2.7f, 0.1f, 1f, 0.1f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.02f, 0.01f, 0f, 0f, 0f },
                    { new Guid("bbca6cdf-a7e9-4062-be09-16b271c36318"), 20f, 180f, 35f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, 0.5f, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), 0.4f, 100f, 3.5f, 1f, 250f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.01f, 0.04f, 0.02f, 0f, 0f, 0.05f },
                    { new Guid("bcc6918e-2fa1-4b7c-8b62-f1997ab6022c"), 10f, 184f, 0f, 51f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6f, 0f, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), 0.9f, 252f, 30f, 0.3f, 37f, 0f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.01f, 0.07f, 0.18f, 0f, 0.8f, 0.2f },
                    { new Guid("be353e4e-2d28-47a2-a3e5-e1a26c7d101d"), 8f, 240f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20f, 0f, new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), 1.3f, 220f, 17f, 7f, 65f, 0f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.08f, 0.05f, 0f, 0f, 0.1f },
                    { new Guid("be8043a3-a079-4a90-acb9-1ce604ec75f8"), 30f, 280f, 5f, 120f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 18f, 0f, new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), 2.5f, 300f, 22f, 8f, 800f, 3f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("bee8b059-5caa-4f73-ae31-00a5ef8b3730"), 22f, 265f, 49f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, 2.7f, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), 2.4f, 115f, 9f, 0.5f, 491f, 5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.2f, 0.12f, 0f, 0f, 0.1f },
                    { new Guid("bff8c2d9-4a23-49ea-8550-3a0d74b46e34"), 40f, 30f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 2.5f, new Guid("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), 1f, 250f, 2f, 0.1f, 25f, 1f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 450f, 0.07f, 0.08f, 25f, 0f, 0.4f },
                    { new Guid("c1d27f37-710e-45a8-88ee-be1faf013fb2"), 30f, 50f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 2f, new Guid("00bc33fe-4cd5-47df-bd94-15ac9f93648c"), 0.8f, 200f, 2f, 0.1f, 250f, 3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 600f, 0.06f, 0.05f, 20f, 0f, 1f },
                    { new Guid("c294ec6f-3ddc-462b-a7b4-1383ee32f8f8"), 18f, 15f, 3.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 1.2f, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), 0.2f, 140f, 0.8f, 0f, 3f, 1.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.03f, 0.04f, 10f, 0f, 0.1f },
                    { new Guid("c2cb80ad-1d16-4776-8a10-11e63d512fac"), 35f, 280f, 40f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6f, 1.5f, new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), 2.5f, 320f, 18f, 3f, 850f, 2f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.08f, 0.1f, 0.07f, 1f, 0f, 0.3f },
                    { new Guid("c5f932e1-5b79-4b58-9024-ef1c65085aa1"), 30f, 120f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 3f, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), 1.2f, 200f, 4f, 1f, 50f, 3f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.03f, 0.02f, 0f, 0f, 0f },
                    { new Guid("c65e908c-d933-49c1-bad7-f210eee59d68"), 40f, 300f, 45f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8f, 2f, new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), 1.2f, 200f, 14f, 1.5f, 500f, 4f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 0.1f, 0.1f, 2f, 0f, 0.5f },
                    { new Guid("c80afe57-0d2c-4058-8835-9a293dd62987"), 18f, 20f, 4.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 1.2f, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), 0.3f, 170f, 0.8f, 0f, 1f, 2.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.02f, 0.02f, 10f, 0f, 0.01f },
                    { new Guid("cdf4359a-17e9-4ffb-9c14-456d6d26d4af"), 40f, 290f, 40f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7f, 1.5f, new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), 3f, 350f, 18f, 4f, 900f, 2f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.1f, 0.08f, 1f, 0f, 0.2f },
                    { new Guid("cec92de0-2831-4c7d-904e-06b1fe585a96"), 30f, 86f, 20f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 3f, new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), 0.6f, 337f, 1.6f, 0f, 55f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.96f, 0.08f, 0.03f, 2.4f, 0f, 0f },
                    { new Guid("cf799d4f-9027-4347-8d70-b28391b917d7"), 39f, 32f, 6.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2f, new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), 0.9f, 391f, 2f, 0f, 36f, 0.5f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 442f, 0.05f, 0.05f, 48.5f, 0f, 0.6f },
                    { new Guid("d0dad974-ef44-463d-ac70-c4a17887b025"), 30f, 250f, 40f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, 1.5f, new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), 1.2f, 220f, 12f, 0.5f, 400f, 2f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 0.08f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("d3c69281-7f16-4906-a2b3-a9fe73012de9"), 16f, 43f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 2.8f, new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), 0.8f, 325f, 1.6f, 0f, 78f, 6.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 33f, 0.05f, 0.03f, 4.9f, 0f, 0.1f },
                    { new Guid("d3dd7511-74ee-4905-be54-3cae0dedecaf"), 9f, 65f, 16f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 1.3f, new Guid("a504d882-4f38-413e-bb28-fae1f2787150"), 0.3f, 42f, 1.2f, 0f, 1f, 13f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.03f, 0.05f, 10f, 0f, 0.1f },
                    { new Guid("d3f14e6b-210a-4709-822f-5d0d08234364"), 15f, 150f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 3f, new Guid("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), 0.6f, 350f, 4f, 0.1f, 350f, 3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20f, 0.06f, 0.05f, 10f, 0f, 0.1f },
                    { new Guid("d55a1fd0-0dfc-4b8e-9aca-58eb32645f47"), 18f, 68f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.6f, 5.4f, new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), 0.3f, 417f, 2.6f, 0.3f, 2f, 9f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.21f, 0.07f, 0.04f, 228.3f, 0f, 0.73f },
                    { new Guid("d635a254-0fe5-471d-b46b-b61b511b38e7"), 20f, 130f, 20f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.5f, 0.5f, new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), 1.2f, 150f, 8f, 2f, 300f, 0.5f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("d650dc13-65a1-4e14-ad7e-12eca014d2eb"), 125f, 42f, 5f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1f, 0f, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), 0f, 150f, 3.4f, 0.6f, 44f, 5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.04f, 0.04f, 0.18f, 0f, 0.02f, 0.03f },
                    { new Guid("d869b845-9ff7-4e57-bd7f-8c5896e18ef3"), 12f, 165f, 0f, 88f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, 0f, new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), 1.2f, 223f, 31f, 3.8f, 82f, 0f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.07f, 0.13f, 0f, 0.02f, 0.3f },
                    { new Guid("d993943c-d686-432c-a901-4fd5d43b9ee8"), 40f, 16f, 3.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 1.2f, new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), 0.5f, 252f, 1.2f, 0f, 13f, 1.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.37f, 0.04f, 0.04f, 36.6f, 0f, 0.12f },
                    { new Guid("dac2f2e0-f884-4816-b1ea-949908db071e"), 10f, 31f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2.1f, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), 0.3f, 175f, 1f, 0f, 3f, 4.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.93f, 0.05f, 0.04f, 80f, 0f, 0.37f },
                    { new Guid("dad7b9c1-c601-4433-b563-8f5cdcee2c9b"), 80f, 65f, 2.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, 1f, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), 1f, 150f, 7f, 0.5f, 15f, 0.5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.01f, 0.02f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("daed1ade-716c-40c6-aa82-5b627997e543"), 37f, 31f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 2.7f, new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), 1f, 211f, 1.8f, 0f, 6f, 3.3f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.69f, 0.02f, 0.1f, 12.2f, 0f, 0.41f },
                    { new Guid("dc3c656e-3c74-490b-8d07-1dd697762b14"), 11f, 116f, 0f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1f, 0f, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), 0.5f, 200f, 25f, 0.2f, 300f, 0f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.09f, 0.2f, 0f, 200f, 0.4f },
                    { new Guid("dd9114d3-ba08-4f31-9b99-e4e4a12c2b7b"), 9f, 57f, 15f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 3.1f, new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), 0.2f, 116f, 0.4f, 0f, 1f, 10f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 25f, 0.02f, 0.03f, 4.3f, 0f, 0.1f },
                    { new Guid("de1af270-2a6a-4cf5-8376-487d1014b3bc"), 10f, 69f, 18f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.9f, new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), 0.4f, 191f, 0.7f, 0f, 2f, 16f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 92f, 0.03f, 0.04f, 10.8f, 0f, 0.1f },
                    { new Guid("de47d09f-c383-4f47-9d05-37755c4ea3fb"), 40f, 180f, 35f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1f, 6f, new Guid("2146faae-2e7c-4460-8d81-38f5d313012c"), 1f, 260f, 8f, 0.2f, 150f, 1f, 1.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.1f, 0.05f, 1f, 0f, 0.3f },
                    { new Guid("de69368d-b9d8-42f6-8faf-92485583b2da"), 12f, 65f, 16f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5f, 6f, new Guid("3d19d971-88d0-4108-a335-24ac9e1dec50"), 0.3f, 42f, 0.5f, 0.1f, 10f, 14f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.04f, 0.05f, 5f, 0f, 0.1f },
                    { new Guid("df92decd-9f9a-4889-bcf2-764a645b6280"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.4f, 2.2f, new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("e0e62dee-fd88-4284-bf85-233addd2e4c5"), 15f, 35f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1f, 1.5f, new Guid("827829bf-71cd-4865-80af-1457e0091456"), 0.8f, 300f, 2f, 0.1f, 250f, 2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 0.05f, 0.03f, 4f, 0f, 0.3f },
                    { new Guid("e307a36e-7315-4f13-a278-7906a365e399"), 20f, 130f, 20f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, 0.5f, new Guid("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), 1f, 200f, 7f, 1f, 350f, 0.5f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 0.06f, 0.07f, 2f, 0f, 0.3f },
                    { new Guid("e35a71f6-e63d-4d43-a605-e369e06363df"), 5f, 89f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2.6f, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), 0.3f, 358f, 1.1f, 0.1f, 1f, 12f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("e397bfba-194c-452f-bf1e-09953b1e9ccb"), 21f, 92f, 3.1f, 233f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5f, 0f, new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), 0.7f, 279f, 15.6f, 0.5f, 44f, 0f, 0.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.01f, 0.02f, 0.06f, 0f, 0f, 0.01f },
                    { new Guid("e6e9fe76-089a-4501-9715-f65d49275b47"), 16f, 16f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.5f, new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), 0.3f, 147f, 0.7f, 0f, 2f, 1.7f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.05f, 0.03f, 0.03f, 2.8f, 0f, 0.03f },
                    { new Guid("e79c4a26-2250-4636-afd4-4debb1a35514"), 56f, 155f, 1.1f, 373f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.6f, 0f, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), 1.8f, 126f, 13f, 3.3f, 124f, 1.1f, 3.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.52f, 0.04f, 0.5f, 0f, 1.1f, 0.5f },
                    { new Guid("e7bb06b6-697a-4dbf-b21d-54be32cf415c"), 50f, 320f, 48f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9f, 3f, new Guid("8382816f-1beb-4804-9698-3b486798b20a"), 1f, 250f, 15f, 3f, 450f, 4f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 0.2f, 0.1f, 0f, 0f, 0.5f },
                    { new Guid("e8cbfd09-6276-471f-8ee5-eab5d49f7399"), 55f, 23f, 4.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2.6f, new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), 1.8f, 500f, 2.5f, 0f, 15f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8890f, 0.05f, 0.18f, 37.5f, 0f, 0.4f },
                    { new Guid("e937440b-e942-45ec-8369-0b7910143c43"), 15f, 195f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 13f, 0f, new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), 1.4f, 250f, 19f, 2.5f, 60f, 0f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.06f, 0.15f, 0f, 0f, 0.7f },
                    { new Guid("ec2b17a8-a607-4a83-8239-8ad29405fe9e"), 12f, 206f, 0f, 63f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 13f, 0f, new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), 0.5f, 363f, 22f, 3.1f, 59f, 0f, 9.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.1f, 0.38f, 0f, 570f, 0.4f },
                    { new Guid("ed32cb0b-f03e-4240-aee0-dd8e73914c18"), 20f, 43f, 11f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 0.7f, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), 0.3f, 257f, 0.5f, 0f, 3f, 8.3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.95f, 0.03f, 0.04f, 61f, 0f, 0f },
                    { new Guid("ee9e16f9-6e2e-4cc0-926b-815436b429c0"), 15f, 100f, 8f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, 1f, new Guid("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), 1f, 200f, 6f, 0.5f, 300f, 1.5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 0.05f, 0.06f, 4f, 0f, 0.3f },
                    { new Guid("ef3c8f82-4aa0-4e9b-a286-e6f140010eae"), 20f, 290f, 2.3f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 25f, 0f, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), 1.2f, 200f, 12f, 9f, 1020f, 1f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.3f, 0.12f, 0f, 0f, 0.4f },
                    { new Guid("f12f8d12-d32d-463f-8462-4def47bddbff"), 16f, 258f, 60f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1f, 13f, new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), 0.7f, 533f, 5f, 0f, 4f, 2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("f1303d4b-9519-4014-92eb-f5aeb8b4c41a"), 30f, 350f, 40f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 1.5f, new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), 2.5f, 320f, 20f, 6f, 650f, 2f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 0.15f, 0.08f, 2f, 0f, 0.4f },
                    { new Guid("f207c26c-7d1b-40b1-bed1-ea43a1e5629a"), 9f, 206f, 0f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 13f, 0f, new Guid("faf19891-525a-4308-9222-992e83de7ce7"), 0.5f, 363f, 22f, 3.1f, 59f, 0f, 7.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.03f, 0.2f, 0.4f, 0f, 0.38f, 0.5f },
                    { new Guid("f5ddfe0c-28c7-40be-aa57-cae42d4c2b93"), 13f, 165f, 0f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, 0f, new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), 1f, 256f, 31f, 1f, 70f, 0f, 2.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 13f, 0.07f, 0.1f, 0f, 0f, 0.5f },
                    { new Guid("f66bd341-77f8-47a5-8055-c802db3f9da8"), 16f, 32f, 7.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2f, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), 0.4f, 153f, 0.7f, 0f, 1f, 4.9f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, 0.02f, 0.05f, 58.8f, 0f, 0.3f },
                    { new Guid("f764f8c8-56e1-4627-9ae0-004a25b7929a"), 11f, 77f, 17f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 2.2f, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), 0.8f, 425f, 2f, 0f, 6f, 0.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.01f, 0.11f, 0.03f, 19.7f, 0f, 0.01f },
                    { new Guid("f92b0f2d-b8c2-4a64-9116-f1b10943429b"), 25f, 81f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.4f, 5f, new Guid("7cd76708-7312-445e-a392-14f0e806a786"), 1.5f, 244f, 5f, 0.1f, 5f, 5.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 765f, 0.27f, 0.15f, 40f, 0f, 0.1f },
                    { new Guid("f9fe80e3-bd31-413b-b6bf-abceedeaa803"), 11f, 45f, 10.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 0.2f, new Guid("de097440-db5c-4d91-bd55-76618d70599d"), 0.1f, 200f, 0.7f, 0f, 1f, 8.3f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.1f, 0.02f, 50f, 0f, 0.02f },
                    { new Guid("fa3cc5c7-ee24-48ce-9929-72337578852d"), 40f, 65f, 16f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.2f, 3.5f, new Guid("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), 0.1f, 181f, 1.3f, 0f, 1f, 13f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, 0.1f, 0.04f, 53.2f, 0f, 0.2f },
                    { new Guid("fdf459ad-6b1d-48aa-8422-94f24be20e4c"), 30f, 240f, 38f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, 1f, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), 1.2f, 120f, 9f, 2.5f, 350f, 3f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.02f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("fe2207d3-d306-42f1-8c52-c4edfce15abd"), 40f, 25f, 5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.1f, 2.5f, new Guid("8ed85dc2-7654-4c48-81f9-19946a73f71d"), 0.5f, 170f, 1.3f, 0f, 18f, 2.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 75f, 0.05f, 0.04f, 36f, 0f, 0.1f },
                    { new Guid("ff176198-051f-4602-a419-42db8f7a7637"), 114f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f, 2.1f, new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), 2.1f, 554f, 2.3f, 0f, 30f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8100f, 0.08f, 0.16f, 51.9f, 0f, 1.9f },
                    { new Guid("ff77d023-e2f1-49be-841a-0cd38f50f611"), 20f, 350f, 45f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10f, 1f, new Guid("01e60ae4-ff69-44d6-b4fd-aaf916e3a7e5"), 1f, 250f, 20f, 3f, 600f, 1f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 150f, 0.1f, 0.1f, 3f, 0f, 0.5f }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "ScheduleId", "ConsultantId", "CreatedAt", "RecurringDay", "ScheduleType", "SpecificDate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "WalletId", "Balance", "ConsultantId", "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"), 1000000f, new Guid("122dc7df-16de-49a3-ab83-5299686f6203"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "WorkoutExerciseId", "CreatedAt", "DurationSeconds", "ExerciseId", "Order", "Reps", "UpdatedAt", "WorkoutId" },
                values: new object[,]
                {
                    { new Guid("025a5530-ec7d-4434-aee3-075b5425786b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("28de23bb-07b9-4ebc-8f72-ead4d54a4883") },
                    { new Guid("02f778cb-0044-43f9-a274-3a6194aa4dd3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), 1, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("03d75859-4e77-418a-923b-60d69bc74e39"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("03f0be60-bcf8-40fc-bfc8-a240352ed7bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d6b2c0d5-110f-4dff-9aa7-91da10a29dca"), 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("051e0815-c4b8-4c17-8bac-62cb87393138"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("0588b76e-5f18-4022-8a9d-5404e365a774"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("08ca7849-7044-4763-9820-1cea281e0206"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 3, 30, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("0af73f50-1c80-4ec2-a7ee-c753147e324d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a9e1fb3-9abf-4775-a75e-2bb13009a29d"), 1, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("0cbea731-8290-40b7-a5c8-57ac851bdd1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d4ebca3a-83ef-485b-9178-83d4eab9694c"), 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("1005060a-167c-476f-9ebd-f38296d77231"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("11532919-2620-4a7c-8ff3-7820b6f61e1a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("12df558a-de90-4bde-bdbd-cc9060867070"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 8, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("1388eae8-5c6d-4821-b4ab-9f7f8a84f426"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a280d32-de67-4a38-8f21-923243489eef"), 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("149363ef-bac2-441f-8579-94aa2cc32250"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 5, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("149990d8-010b-4275-b185-9a7bb68e4830"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("150264b7-ecf8-49ac-a11e-8c323991440d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("16a0ca6b-cd73-42d5-ab0f-d3789a04c377"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("9ba29558-e51b-4a1a-a1c4-b747967e32fb"), 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("1a585ecd-f27c-4b02-94b1-e09afedc3159"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("1bd77a94-b124-4a81-a32b-a33f7862361f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("1e1d7c92-6a15-44a8-8e14-dd08d0437517"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6badb5b5-ad99-4b89-80c6-e52d0f7cd7ba"), 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("1f9e038b-79f8-48db-a40a-4ec4cb5a7ab0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), 6, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("21e5cb33-88b1-4aab-85bd-9656ff624e15"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("226f1060-7364-4fce-9c87-5e4e503c2b56"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"), 5, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("24a4e3a6-b3b6-4a8d-9112-7c0b19ba2c7b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("273e1ab4-6e5f-4d86-8e21-44db5e546379"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 8, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("27596140-a85a-4314-a27f-959788da81b4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("292237bd-7607-4e6d-9305-5318196d72b7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"), 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("2a3b3dfa-2a6f-4810-a142-a77c318f2f44"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 5, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("2a4fb12d-8772-43b2-ae5a-46217cca8d61"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("93e22c77-001f-4825-8983-4ec5b643b7bb"), 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("2c7ae26d-c709-4acf-b36f-062592fd8205"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), 6, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("2e7b0876-14d2-49cf-b72f-f140a733cde2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), 5, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("2fbbc45f-5e1f-4b5a-851f-7865fe2d5aa7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("f93d73ba-d1d6-4037-b51b-1fd005accff3"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("2fe93401-3aeb-411e-ba39-ccfb98c4bfd9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 1, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("30d66fb9-43d7-43f0-b41e-83e6246c6bf2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 7, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("31f97aa1-cd53-46ed-b9c4-02ebe7f3735d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("32a0b9a2-e01b-48f8-860e-27c3b09ff1c0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("33a7a379-7b98-415d-b547-55c690687065"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("33e788cf-fd79-450d-aaac-2edf3f7b954d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 1, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("352f74d5-1cf5-4cb0-bd9f-5fa66c60345b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("5cbc396e-381a-4d9f-9ad6-42b764deee3e"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("356cc822-b139-4815-b1df-84d93c41809b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"), 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("3786ed9c-6a4b-4bb6-b3f2-3a92a562dba7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 1, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("39eecef6-b275-4740-b227-b868be89d956"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("d0dcad19-4c0c-447d-8e3c-092c6d4ad14c"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("3cd52598-fbd9-4f1e-be41-12a6457bdde6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6d6b06e1-5ade-4dae-b442-7aa200661760"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("3d2d42e5-1c59-421c-9607-944d546697ae"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 3, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("420d96c2-bf35-46ea-bc1a-933cc27abb66"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("385f13f7-79bf-437b-acac-745b50485b9f"), 2, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("433793cf-e005-4217-a340-598b76d4049c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("43959e29-93c1-4d49-8a0c-1c9cbadc2467"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("44a9304f-89cd-48bd-b88d-e4531ad46e05"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01e6141a-930e-4126-a2c6-7c32a2ccdd43"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("46cc9a0c-86c3-4b32-82e6-6f1fe0380644"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), 6, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("474263bb-ea91-4878-bfde-c4c78de069f8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("4791ac1a-a6cd-46ca-96b5-9ca3903bdbdc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 6, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("47973f51-b99c-4ce3-b41a-c6a47381df53"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0c011f92-425a-477c-84d4-3d6dc883119b"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("47ff43df-ed83-4d98-ab54-51be49432841"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("4837539f-5d72-4c37-b542-c02030b97e90"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("22af0171-257b-43bc-9013-8985472a8c84"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("48e63632-a570-4add-b772-4dae63b95301"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), 8, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("4c334ee9-c90f-4820-9c50-d6a703c7d72f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("4c3f76df-b69c-4352-9ac8-9ed87bfd29d8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), 5, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("4cf3a2d1-ec5f-4f3a-b2a7-e6230be8ece3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), 2, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("4eea5a29-24e2-498d-b6f6-b8a693985254"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), 1, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("4f47b025-aff5-4ca8-aeaf-ba84d08326a1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), 3, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("502286a4-7417-4307-9ddd-92f8d19e65f3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("51b3515e-523d-4627-bf62-d533900b9615"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("51e76278-724b-4087-808d-c3d6b58beedf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 4, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("555a7386-8a12-4b2e-a81f-350ae5e41a43"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 1, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("57d329e7-dd46-41be-9fe8-2343ffa70ec8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("58103625-f8cd-4dd4-af17-3a5341ef16d4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("5e0604f2-dc52-4ca8-9519-03b1fb749334"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("d3d944c4-947d-4910-bb6e-636390e5b8d5"), 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("5ef9c92f-9290-4b1b-89d6-5bc8c03c81cb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01e6141a-930e-4126-a2c6-7c32a2ccdd43"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("60158c90-9cab-43a2-adc6-8506872efc31"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("72206c5e-58f3-46f0-a8b1-031cbf599433"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("60d1e780-c96b-471b-9a63-67c4150d9671"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("61376dce-d39a-4d05-bdd9-55b91a2c536e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("439db970-c7c8-4b3b-9a35-127d31d920dc"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("61f08941-7bd6-4505-b6a0-0a2b27723a84"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 3, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("62499df8-b52d-40c8-b741-e7cf750f36b6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("6273c7cb-873c-4a0c-adb4-78199081623b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d4ebca3a-83ef-485b-9178-83d4eab9694c"), 4, 16, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("62e4a924-31cb-4377-81e5-ef92c872a34e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8b93dbb2-fc2b-4627-b79a-3ec45a7c6238"), 2, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("64319afe-7b86-42a6-be00-d4ce892425a8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("235f7494-3e7d-45a5-a31a-6d5449b1322d"), 2, 16, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("6b3fb122-dda2-4def-80cb-b424894aa446"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"), 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("6d106c7e-f7e4-4450-b3a5-ab132ecf936c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"), 4, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("7019a508-ab7a-4d8b-b76b-3266a067eb70"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("72206c5e-58f3-46f0-a8b1-031cbf599433"), 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("71fa183d-d589-4012-8721-e55af2acfc54"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("7486eeda-1bc5-4ad4-ae7e-ffa9338bcf68"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("75ddc969-f622-4ef3-b062-d2bb77b41323"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("58878826-775e-4d4c-8e1b-d5c95afc214d"), 6, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("7683b133-cc5c-43b6-9c16-8549d7d26c02"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("77c8c8be-f4f4-4d8e-ad18-bee54c31010d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("4834f1ce-41dc-4161-ac51-e03ca78b62b8"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("78e7ce1b-5cef-425b-86bf-326123b4fdb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), 7, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("7d695670-b379-4e67-8029-f6d567cec157"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), 6, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("7e3a3339-3423-4aab-99c7-3c3d8fa6ccbe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a280d32-de67-4a38-8f21-923243489eef"), 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("83c4a92a-3bf0-4848-b6ab-6935ed4c737c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("58878826-775e-4d4c-8e1b-d5c95afc214d"), 8, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("83e27868-fee9-4fd9-9999-4b09f4dbbafc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("87a5585e-98d1-47ea-8dcc-861efa043cb2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("87edaedb-1c9c-462d-be11-94f4d7cc6690"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("8869629b-acb6-42c1-8e6b-1fbef92df2e5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("faebde03-bab9-457b-9b45-a9fabd4760aa"), 1, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("8897a714-6cb1-438b-8ade-56048a36835c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 3, 30, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("28de23bb-07b9-4ebc-8f72-ead4d54a4883") },
                    { new Guid("8908e2c0-77b9-4ffd-84d2-9fd70ee057eb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 2, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("8a6fe521-eb17-43c5-a300-8d44c2beef63"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("8ab74f48-f261-473a-87ab-57778627669b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), 1, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("8afd487e-9597-4878-bcb4-47761eb90b49"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2e787245-7612-41bc-9b75-7a4857282350"), 2, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("8b700cda-f5ba-4026-9bdb-929b3c168892"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("93e22c77-001f-4825-8983-4ec5b643b7bb"), 5, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("8d06988d-c52b-49a1-8f6e-1bef028b0d0d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), 4, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("8e2a7baf-37c8-4bae-99bb-6560bd1d086f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("90a425b4-6f10-4f05-8c1a-77fd46a6540d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("07a4dbcd-635a-4a76-92d4-8127de619e6d"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("91f40728-50c6-4ca4-b7cc-080f4dc3ba02"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 6, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("92e3d8e7-55a2-48d0-831f-3173b38d6389"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6749cbc6-0e28-4163-95e8-7fb2a27c54cf"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("935db215-7a03-4efa-b155-a4df4ea0fc4a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 2, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("93b84e2c-25e5-4985-9b3a-d7df47f602c6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 7, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("96cac60c-ac37-4d95-a9c4-8175bfddc611"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("971f7320-f427-4e5e-b1f3-3c2ce09c8735"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"), 7, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("98608dae-572a-4a1d-974a-dc846a90e84e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 9, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("99763e65-1d91-43b8-837a-b0f15a8be5cd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("2696db05-e815-4c8b-870d-23c338479e95"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("9f0628b4-f07d-42e7-978d-86da8c0f119f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ae6eaaa1-c8c4-4f97-afa4-4ceeea19d4b3"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("9f51d84d-d1bd-4b07-8736-7913240d480f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 4, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("9ff5c15c-63c4-4cde-a8ce-1d12d23bb08b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6ffea500-ca35-4483-b049-d8593b2c8680"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("a1412b0c-86d1-40cc-bef4-bb953e053b05"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("23842121-4834-4483-bfe2-2c244f5ecf76"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("a1ff2bf9-afcd-4802-aa76-dceab71a01b3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("a217a404-68e1-488c-889f-6688dca06df3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("a2fc4e28-1454-411d-9387-e523532f2bac"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("a5c5893c-debb-4474-b38b-e9c0ea0ccc53"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 1, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("a5dce3f9-aacd-4c29-b69f-743309572895"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("1b2afb40-fb97-49ec-8fe3-81a17c6c9078"), 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("a6e01096-cdef-4b77-a664-c63ef4438e8b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("0d1e54fe-7a5f-4e0a-a59f-ee9f443718e0"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("b4f73ec4-2149-4820-98f8-044b85f9404f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bd80fdd3-c46c-4410-b126-51a11a8a2f5b"), 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("b8ca2015-6770-467d-8373-251655f96f41"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("90ce2a9f-d0be-4ca0-b3ca-8b6947a6b266"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("28de23bb-07b9-4ebc-8f72-ead4d54a4883") },
                    { new Guid("ba1a948a-1949-4907-8857-706990125f24"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01dc4c46-e1ef-44bc-9f19-ecb283bf27ce"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("bb2a2cba-19fb-4ba8-9b01-55ddbe3c8c2f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("05c931df-c828-442e-aee1-56432cb772c7"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("bb52ac90-b665-44e9-a4ea-077c1be7e171"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("bd9f6b82-168a-4286-bae6-9d552796218e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 1, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("bf842bab-7c1d-4206-b77c-864402f355e9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("bfc23249-5a8e-44c3-afc2-102fc674b48a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"), 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("c13d6f96-c598-4bbd-90f4-30f66509e719"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), 3, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("c345d1b3-caf2-44a5-9f3c-74298c8e499c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("c42fcf0d-3eaa-44ba-ae6c-0d12f0adbf9a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 4, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("c53e5d24-3e6c-4d20-9301-6fc3ae2d5b77"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"), 4, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("c72198f1-3996-4f52-83aa-b49fd70c9509"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 5, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("c8d64244-ac59-4eb3-92f9-51f1f231e271"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("c99bdcdf-6403-45cc-82d0-9c947ce13950"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), 6, 15, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("c9e2709e-aaa5-4d56-ba47-0dd3e6eb53f6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("cb0ccc87-316e-4c8c-a387-66ccdde037bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("cb8c8132-6f65-4757-b76a-df3cbb21e8b8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("d071e67b-6528-46b1-9071-a694cd702fbc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("d0ecc287-bab3-4705-ba4b-437870870e67"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("d10a4328-029e-4180-9a80-033f486b6979"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("9ba29558-e51b-4a1a-a1c4-b747967e32fb"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("d1bb69fd-de4f-4bfe-ac5e-fd7189626f02"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 4, 6, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("d4160c25-e6fb-4991-b4f1-0590883d2ad1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("d5524993-221e-47cc-8e36-000c6d94db1e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("d625c1c0-e721-4dda-8eee-ef0b54bed614"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 5, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("dc7ef8d0-3290-4b05-b97b-8a02d9757885"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("13ca014d-8b75-414f-afe3-3d378ef7fa97"), 4, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("dd0a4211-57ef-4bcb-b228-4e42876f5be1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 5, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("dd3e7560-325b-4185-984e-53ac98f34e2b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ae6eaaa1-c8c4-4f97-afa4-4ceeea19d4b3"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("df4ba091-083f-4c07-8b2e-8a005a1ff10a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 3, 30, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("df93f1e6-2c38-433a-9461-2b5613a8f6e2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6ef8ed78-0d00-4271-bf9b-edf27a55ecab"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("e0ba8a74-38f7-4aa8-a7e8-dadcad751ed1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("e18047c3-4aa8-4baf-ae2f-27408ae1c03e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("e185fa66-5289-4d0f-a6a0-439feba9beb1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("e2b8aeac-8e74-49e7-a44b-4429653a3391"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("e305d903-3e28-411a-9853-01a9975ee36f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 5, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("e617b62a-1ecb-4dcb-91cb-cd46153d756a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 2, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("e68da1f8-0dfe-43be-9550-c5ae8170d65c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("e9567b09-b144-432f-8eaf-cbf058dc4929"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8619916d-a296-48a5-af89-f82a6a1cb26f"), 3, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("ea1ec2f1-3b11-4436-b88b-11c26755fab6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 3, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("ea34b378-30d0-4154-8616-dc2d9b4a8ba7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("eba55563-678d-491d-a9ab-4bf6f23fa3c8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("23842121-4834-4483-bfe2-2c244f5ecf76"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("ecc68d83-3b55-42a2-b810-bc4eadf8f69b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ff0ef05-4387-4483-8de3-0ef6d7724afd"), 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("ecd3fd8c-1902-493f-b421-b218beec6692"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("ee46b58b-5552-48a9-8aa6-2fd100a07fa8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b2e62599-1f8c-4fc2-9ca7-8ab7aa571d4e"), 2, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("ee84705f-9d8f-44f3-85cd-53a7e705eca3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 4, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("efba045b-d232-44c2-b32a-b768ba8699c1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 1, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("efc4088c-c2a8-489d-a694-cbd70ad94f28"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), 1, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("f05866de-2411-4481-a3f2-3920b1e173b3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"), 1, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("f0676003-35de-4567-8197-df7fa7b1467a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), 3, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("f1659417-b501-464e-b866-7460bbfd0cfb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 8, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("f17fa1df-51ca-42df-b9dc-90461ce1a7c5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), 2, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("f2ce234e-d9a0-47b9-acf1-7f0c9e22aeea"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("407ff857-d218-44a8-8d0f-0bfa5d53bf03"), 7, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("f3f2f767-02de-471a-9b09-c6342a8a9899"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 1, 12, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("f55b8df1-541f-449f-8a26-23345c178f9c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("256e23fa-03b1-4328-a325-512f0860d9b0"), 6, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("f678a519-9c10-497d-94d2-0589af0522a7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 3, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("f76c85a6-039a-43c2-ba3a-edc9f209f763"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0d816828-8a94-4dcb-a87c-b70b295a39b6"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("f7cfe9a4-4935-41a1-8ccd-ad33cca1d520"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("f7dc9b07-ae88-419e-b71d-b93c16335d55"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), 4, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("f9865d19-df6d-408d-a1fb-b040835c3a92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 3, 32, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("f9b4a300-01ed-4215-a8cc-9686331d665b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 3, 8, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("fadaa5c4-8a98-4c22-8032-45616ac83dbd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 5, 6, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("fbbb9844-2645-47fd-bc65-ca2eca5fe4c2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 3, 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("fc765fef-1938-4f76-9045-40f2f23b78bc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 2, 30, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("fdeb3ab1-83cd-4010-a084-fcd04d3e601a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3100278d-eee7-4b89-b726-4b76daefabde"), 2, 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("ffd1b5dd-8f76-4473-8af4-fba884b2a17b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), 7, 20, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") }
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
                    { new Guid("02c191c4-00d8-4e51-a5c0-e241db66f10a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0874d7b2-ed6e-4805-9aab-3cff838fcc82"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d221bf5-c282-4dbc-986e-d1701dbe7000"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f7796c9-c587-4ab5-a807-d99510e78b29"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1277ef10-d8f1-4afe-85cd-b3f2617482cd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("16b9c56a-5709-45e9-a064-c196be1a0887"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22da7168-5fe1-4003-882b-fa5464b4c287"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("26a34e88-85d4-46f3-8cd9-6daad1758602"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("26dc5edb-2a37-4576-b474-2257bdec9d2b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c7fceda-8e4b-4ab5-865b-947210fa95ee"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3332aca8-383e-405e-b237-396ce707ab68"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3ae1a5aa-4069-41a2-8c7d-337e5f4e3da3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5367abdf-8e74-4ce1-8c3f-0fb530f6682d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5da9f56f-d338-4a83-a96d-b39ede1f018c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("621ba582-2e56-43be-818c-783599fc36ac"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6c732714-230d-414f-8c5f-dd03cd9bcfeb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e527abf-6378-4893-936a-3112cdb7a95d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7b3bfbd7-215f-49a8-8c1e-b7726775ac2c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b481859-b8fe-4108-9b3c-1fa6552273b5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9f79aff1-82b4-4d04-9db3-6edf19b0fa0a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a5c37baa-3c39-4b0d-beac-1a7c7a0005f4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a62b66b0-9cf3-4754-b588-7d469ce5a07d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aae6f3d4-22eb-48a5-98c9-0078f1170396"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aca75980-de15-4fd1-871d-43cc3ab6cee6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"), 0, new Guid("8affe245-30a2-4164-ad48-7d3032fa91df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("acb8b5d5-7377-4e78-951a-a7353796393b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae54c7f5-7649-4fa9-bc64-03e7e29e07b5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("afe163ca-aae4-4d66-ae88-181393ee6104"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b7e8e8b8-ca61-4838-ac3d-63397d39aa19"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8708546-e1c3-44ce-a5eb-c02b1bf53535"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c6d31aff-84bf-4e54-b6e9-5b07de4ffc03"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca167252-cbf8-4dad-97c8-5c2777d29f78"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640d26b-ea65-4901-b9fc-e78bed626fcb"), 0, new Guid("54da261e-ad94-4bd8-a696-82f77c47fc1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8b81dfd-6fa6-4858-a348-5696500a0b26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d987914a-474b-40c6-9cd1-0ec9961e72ac"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9ec8dac-492f-46f3-8d98-9768213f40f3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("db35179f-f0f6-4cb9-89b8-0c4c3e75f3ab"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"), 0, new Guid("8a0f1db6-8007-487d-96e3-67e49f697767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dba6d7cb-71da-4ad9-99fc-6bf9719d7a88"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b988823-2ed9-4835-a0ae-f73c125f589a"), 0, new Guid("cf1c96eb-0193-49b7-9813-23c1d9646e5e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f08328bb-c5b9-473c-8f73-5ff16af17652"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"), 0, new Guid("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa143a4f-f0d6-4092-ab08-708296b0b7f1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2794c45b-08fb-428c-b863-37059ef29d1f"), 0, new Guid("c366221c-1be4-4ffe-9271-e1357f3cf8e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "BookingId", "CreatedAt", "Description", "Status", "TransactionType", "UpdatedAt", "WalletId" },
                values: new object[,]
                {
                    { new Guid("0cd2958b-a84c-4fc9-9a7e-74e2c8c07800"), 700000f, null, new DateTime(2025, 3, 16, 6, 49, 0, 0, DateTimeKind.Unspecified), "Rút tiền khẩn cấp", 1, 1, new DateTime(2025, 4, 27, 3, 57, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("0e24da3a-c2f7-4a36-9631-9c9f37158e95"), 0f, null, new DateTime(2025, 3, 31, 12, 1, 0, 0, DateTimeKind.Unspecified), "Tặng lượt dùng miễn phí", 0, 0, new DateTime(2025, 4, 23, 0, 6, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("1a225e17-5b77-41dc-ae3b-b90770ee2a25"), 100000f, null, new DateTime(2025, 4, 5, 4, 40, 0, 0, DateTimeKind.Unspecified), "Tặng tiền sinh nhật", 0, 2, new DateTime(2025, 3, 19, 17, 15, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("1bd5a950-5343-40b4-99bd-17e91988496d"), 200000f, null, new DateTime(2025, 4, 1, 14, 53, 0, 0, DateTimeKind.Unspecified), "Hoàn tiền bác sĩ hủy lịch", 2, 1, new DateTime(2025, 3, 2, 21, 49, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("21c05599-a25e-4b91-8d02-3c24929dfedc"), 250000f, null, new DateTime(2025, 3, 20, 23, 45, 0, 0, DateTimeKind.Unspecified), "Hoàn tiền dịch vụ lỗi", 0, 4, new DateTime(2025, 3, 17, 21, 44, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("3d8d7e24-2822-44ee-8910-3ce394bb0a03"), 180000f, null, new DateTime(2025, 4, 18, 19, 51, 0, 0, DateTimeKind.Unspecified), "Hoàn tiền do lỗi kỹ thuật", 2, 4, new DateTime(2025, 4, 27, 8, 24, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("4156d515-4098-4eb9-9887-7f226450e384"), 1000000f, null, new DateTime(2025, 3, 1, 13, 50, 0, 0, DateTimeKind.Unspecified), "Nạp tiền từ VNPay", 1, 0, new DateTime(2025, 3, 24, 17, 1, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("45cece13-9275-4713-bfec-939fc89346d7"), 600000f, null, new DateTime(2025, 3, 30, 16, 19, 0, 0, DateTimeKind.Unspecified), "Nạp từ ShopeePay", 1, 3, new DateTime(2025, 3, 9, 1, 4, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("581aa498-b624-488b-9ff9-4527f73b0ee8"), 450000f, null, new DateTime(2025, 4, 24, 17, 17, 0, 0, DateTimeKind.Unspecified), "Rút tiền hoàn tất", 0, 3, new DateTime(2025, 3, 18, 17, 50, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("6d8b4ecf-cdd2-4da5-8017-64bdfe42147a"), 50000f, null, new DateTime(2025, 3, 22, 1, 38, 0, 0, DateTimeKind.Unspecified), "Điểm danh mỗi ngày", 2, 2, new DateTime(2025, 3, 11, 10, 25, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("86f7d67b-27e9-4d80-8d62-5786393ac2b3"), 0f, null, new DateTime(2025, 4, 18, 8, 2, 0, 0, DateTimeKind.Unspecified), "Lượt khám miễn phí", 0, 1, new DateTime(2025, 3, 2, 15, 35, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("95044cd6-d2bb-4456-894f-d55cc9a101e6"), 800000f, null, new DateTime(2025, 4, 9, 5, 11, 0, 0, DateTimeKind.Unspecified), "Nạp qua ngân hàng", 2, 3, new DateTime(2025, 4, 26, 21, 25, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("c3c27c41-6dfb-4676-9609-da81ad19a500"), 1000000f, null, new DateTime(2025, 4, 1, 15, 42, 0, 0, DateTimeKind.Unspecified), "Rút định kỳ", 1, 4, new DateTime(2025, 4, 7, 8, 21, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("d4e25c12-0b56-4016-9b00-4fc909d5e402"), 400000f, null, new DateTime(2025, 4, 12, 21, 31, 0, 0, DateTimeKind.Unspecified), "Rút tiền thường kỳ", 1, 0, new DateTime(2025, 3, 5, 23, 5, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("d6dbc6e1-2e92-4468-aceb-7f716ce4effa"), 1500000f, null, new DateTime(2025, 3, 15, 3, 48, 0, 0, DateTimeKind.Unspecified), "Nạp tiền qua Momo", 2, 0, new DateTime(2025, 3, 5, 5, 25, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("d9f3ab4f-918b-427e-ad0f-f5ce89f741eb"), 300000f, null, new DateTime(2025, 3, 9, 23, 35, 0, 0, DateTimeKind.Unspecified), "Hoàn tiền do hủy lịch", 2, 4, new DateTime(2025, 3, 22, 18, 40, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("dc4a910f-a537-4a20-ba61-813ee5794aea"), 300000f, null, new DateTime(2025, 4, 22, 16, 43, 0, 0, DateTimeKind.Unspecified), "Thưởng khách hàng thân thiết", 1, 2, new DateTime(2025, 4, 14, 7, 48, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("e02744ff-cfea-463e-a0bc-05d3273d805e"), 500000f, null, new DateTime(2025, 3, 4, 4, 7, 0, 0, DateTimeKind.Unspecified), "Rút tiền về ngân hàng", 0, 1, new DateTime(2025, 4, 2, 22, 56, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("f26ec6df-b269-444e-9637-f7121c2bb50b"), 0f, null, new DateTime(2025, 3, 10, 17, 2, 0, 0, DateTimeKind.Unspecified), "Lượt sử dụng miễn phí đầu tiên", 1, 2, new DateTime(2025, 4, 22, 5, 4, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") },
                    { new Guid("fbaa19c1-8ad5-45f4-8668-89142ae4d75a"), 200000f, null, new DateTime(2025, 3, 14, 11, 58, 0, 0, DateTimeKind.Unspecified), "Thưởng đăng ký mới", 0, 3, new DateTime(2025, 3, 13, 20, 45, 0, 0, DateTimeKind.Unspecified), new Guid("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6") }
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
                name: "UserNotifications");

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
