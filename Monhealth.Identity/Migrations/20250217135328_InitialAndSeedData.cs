﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class InitialAndSeedData : Migration
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
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Consultants",
                columns: table => new
                {
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
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
                    FoodType = table.Column<int>(type: "int", nullable: false),
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
                name: "Certificates",
                columns: table => new
                {
                    CertificateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpertiseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CertificateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Certificates_Expertises_ExpertiseId",
                        column: x => x.ExpertiseId,
                        principalTable: "Expertises",
                        principalColumn: "ExpertiseId",
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
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        principalColumn: "BookingId");
                });

            migrationBuilder.CreateTable(
                name: "ConsultantExpertises",
                columns: table => new
                {
                    ConsultantExpertiseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpertiseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultantExpertises", x => x.ConsultantExpertiseId);
                    table.ForeignKey(
                        name: "FK_ConsultantExpertises_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "ConsultantId");
                    table.ForeignKey(
                        name: "FK_ConsultantExpertises_Expertises_ExpertiseId",
                        column: x => x.ExpertiseId,
                        principalTable: "Expertises",
                        principalColumn: "ExpertiseId");
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
                    table.ForeignKey(
                        name: "FK_Reviews_Consultants_ConsultantId",
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
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxBookings = table.Column<int>(type: "int", nullable: false),
                    BookedSlots = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
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
                name: "Activities",
                columns: table => new
                {
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DailyActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WorkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivityId);
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
                    DailyMealId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    { new Guid("0eec9d43-391c-43c6-9635-01ca2d6fc66c"), "Dị ứng với các loại hạt như hạt điều, hạt hạnh nhân cũng có thể gây ra phản ứng mạnh, đặc biệt là đối với những người có cơ địa nhạy cảm", "Các loại hạt", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), "Dị ứng với lúa mì, thường gặp ở những người không dung nạp gluten", "Lúa mì", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4d6270d3-69c6-4b9f-9c11-125369139775"), "Dị ứng với hạt vừng (mè) có thể gây phát ban, ngứa, và có thể nghiêm trọng nếu không được kiểm soát", "Hạt vừng", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), "Dị ứng với hải sản có vỏ như tôm, cua, sò, nghêu rất phổ biến ở Việt Nam và có thể gây phản ứng dị ứng nặng, từ phát ban đến khó thở", "Hải sản có vỏ", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99b9eae6-f5e8-4b41-9394-6a8f2ca1062b"), "Dị ứng với đậu phộng khá phổ biến và có thể gây phản ứng nghiêm trọng như sưng tấy, phát ban, khó thở, hoặc sốc phản vệ.", "Đậu phộng", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
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
                    { new Guid("c0278115-8549-4fad-890a-44f8E8fcc022"), null, "Tư vấn viên", "Consultant", "CONSULTANT" },
                    { new Guid("d21edfd6-42d5-490a-a41c-43f7ef09c61f"), null, "Quản trị viên", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 0, null, "3454679d-12f2-45d6-831c-0c27da41cab9", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "khanhpham@gmail.com", true, "Nguyen Pham Khanh", false, null, "KHANHPHAM@GMAIL.COM", "KUEM113", "AQAAAAIAAYagAAAAENBtn29nEgbide82Q4YkJHXJBHOpHMj6pt+tKIY38MIEvyVfxE2RxU8fCFI5PGTuxQ==", "0969998878", false, null, null, "93f9b6a2-b6d7-4159-8647-9fcdfb21b968", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "kuem113" },
                    { new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), 0, null, "2017a0c8-2921-4213-bdc1-c787c830808f", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "duythunglungtinhiu@gmail.com", true, "Pham Hoai Duy", false, null, "DUYTHUNGLUNGTINHIU", "DUYPRO113", "AQAAAAIAAYagAAAAEPX1Bg3ibDSmzFznHh6/83YtPLEtPUSktHLTYfVI5PmV4qjwtDrHd2tDlsRyIki/vA==", "0555666612", false, null, null, "4753eaa8-d632-4b4e-8bb8-2fede02c6e81", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "duypro113" },
                    { new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 0, null, "0adced6f-7c37-460e-aad2-f197a7b584ac", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quocdai@gmail.com", true, "Nguyen Quoc Dai", false, null, "QUOCDAI@GMAIL.COM", "DAINQ115", "AQAAAAIAAYagAAAAEIg9wrVSkeVuETt4UlaVrEnuTX36uXsOA6ogiVzeGXON2im6EAvpoefTj8TahHa+Gg==", "0932748924", false, null, null, "5ddc08c5-433a-417a-a1c3-abeb631324d8", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "dainq115" },
                    { new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, null, "7e6720fd-c8ba-44dd-913d-e5511f5bcdbe", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "asd@gmail.com", true, "asd", false, null, "ASD@GMAIL.COM", "ASD", "AQAAAAIAAYagAAAAEEvrJ3F9rciwpagSQEwuMzow13kLPy6x5BJ4k+B+MAKJDxiC5YSMIh70CQ2RtdhhGg==", "0123456789", false, null, null, "adc257d0-e84e-4ba2-98fc-4ce7f098b63d", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "asd" },
                    { new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"), 0, null, "46e52b6c-e186-41c8-a9e4-c5d19de0c2d5", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "khaitoi@gmail.com", true, "Phan Van Khai", false, null, "KHAITOI@GMAIL.COM", "XAUTRAI123", "AQAAAAIAAYagAAAAEB9n+cqG/yhhWa6eym8hHhngcZ5J6AWWDsuHm2IE5DiEFJdm5YcbY7q/Zgxcw8fBxw==", "0963122758", false, null, null, "39e2a659-4a37-4539-8d75-bfde321b9867", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "xautrai123" },
                    { new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 0, null, "c696167a-8224-47b7-9440-ce9f9cf35552", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quangdalat@gmail.com", true, "Quang La Tui", false, null, "QUANGDALAT@GMAIL.COM", "QUANGSPA009", "AQAAAAIAAYagAAAAEDbvuIt51eH0Fym8HO8P41UBx1R2KzYSBjn6yhbMy+iQQGbDiN/CsyHorRgV3dkETA==", "0999777712", false, null, null, "2bd303a4-c31e-476e-b977-2ac51654c86a", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quangspa09" },
                    { new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 0, null, "df4fe6f9-24b3-4cfe-a10a-2f9632fede0b", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "toanvan@gmail.com", true, "Van Huu Toan", false, null, "TOANVAN@GMAIL.COM", "VIPRO123", "AQAAAAIAAYagAAAAEJiH5qJuI+xoAXBE31eTJayJKeMTzihkNiT+C5S6c/ndxifSPi4UazSllEN0dWk0dQ==", "0792766979", false, null, null, "0bbcaa4d-25e9-407c-aeb1-a7b7d7d2b460", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "vipro123" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName", "CategoryType", "CreatedAt", "Image", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("036a94f2-013a-4375-a685-76ff6ffcc24e"), "", "Upper Body", 1, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), "Hoa quả tươi hoặc chế biến như salad trái cây, nước ép, sinh tố, cung cấp vitamin và khoáng chất", "Trái cây", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fapple.png?alt=media&token=106a39ee-5c36-4c27-8bbe-c850ee19cb02", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), "Các món ăn từ thực vật, đậu phụ, và nguyên liệu không sử dụng thịt, phù hợp với người ăn chay hoặc muốn đổi vị thanh đạm", "Món chay", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fradish.png?alt=media&token=c27e26f3-3f39-42ec-bf40-94c9abb074d5", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2f998806-6963-42cf-9fce-7a5b5c2df540"), "", "Lower Body", 1, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4575699a-5bb6-42ec-9d52-ea19d1170187"), "", "Abs", 1, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), "Gạo, mì, bánh mì, yến mạch, và các loại hạt ngũ cốc. Là nguồn cung cấp năng lượng chính trong ngày", "Ngũ cốc", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Frice.png?alt=media&token=1ef6ca23-003f-4415-9ce4-3a3f5cd8e65e", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), "Snack, khô gà, khô bò, bim bim, và các món ăn nhẹ lý tưởng cho những lúc giải trí hay nghỉ ngơi", "Đồ ăn vặt", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fpopcorn.png?alt=media&token=8aecf5e1-071f-4b0f-8e55-a2c47b289def", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), "Món ăn từ rau xanh, củ quả và nấm. Phù hợp cho những ai yêu thích thực phẩm tươi sạch, giàu dinh dưỡng", "Rau củ", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbroccoli.png?alt=media&token=6746e0eb-bcf0-44d1-830a-79821f735f84", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), "Bánh ngọt, kẹo, kem, và các món tráng miệng ngọt ngào, lý tưởng cho những ai yêu thích đồ ngọt", "Món ngọt", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcupcake.png?alt=media&token=8721bd49-186f-4ccf-a85a-64008e4c8e38", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), "Bao gồm các món ăn từ thịt bò, thịt gà, thịt lợn, thịt vịt và các loại thịt khác. Là lựa chọn phổ biến trong bữa ăn chính", "Thịt", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fsteak.png?alt=media&token=dfffb9c2-2964-40cc-8712-e83b4200e7af", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), "Pizza, burger, khoai tây chiên, gà rán, và các món ăn tiện lợi, phù hợp cho những ai bận rộn", "Đồ ăn nhanh", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fburger.png?alt=media&token=66dd457f-64d3-4b66-851c-10eba13fdc7d", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), "Bánh mì, bánh ngọt, bánh mặn, bánh hấp, và các món bánh truyền thống hay hiện đại", "Bánh các loại", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbread.png?alt=media&token=decd5d8c-994f-4a71-ab9e-2096209515fc", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), "Các món ăn từ tôm, cá, cua, mực, hàu, sò và các loại hải sản khác. Thích hợp cho những ai yêu thích hương vị biển cả", "Hải sản", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcrab.png?alt=media&token=0cde2529-8e28-4b5e-80cf-660f27564de2", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), "Bao gồm nước ép, sinh tố, trà, cà phê, và các loại đồ uống giải khát khác", "Đồ uống", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcoffee-cup.png?alt=media&token=14155321-cd44-422b-a49f-3e34636d7f85", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), "Kimchi, dưa chua, sữa chua, rượu vang và các món ăn lên men, tốt cho tiêu hóa và sức khỏe đường ruột", "Món lên men", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fpickles.png?alt=media&token=2a078ceb-40a9-403d-a68c-9682faf1b97f", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"), "", "Full Body", 1, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
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
                    { new Guid("c0278115-8549-4fad-890a-44f8E8fcc022"), new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87") }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "CaloriesPerMinute", "CreatedAt", "CreatedBy", "ExerciseName", "ExerciseType", "Instructions", "Status", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("01dc4c46-e1ef-44bc-9f19-ecb283bf27ce"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng chân sang ngang bên phải", 1, "Đứng thẳng và quấn dây kháng lực quanh chân của bạn\n Giữ thẳng lưng và siết chặt cơ bụng, sau đó nâng chân sang ngang\n Thực hiện một hiệp đầy đủ với một chân, sau đó thực hiện một hiệp với chân kia", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("01e6141a-930e-4126-a2c6-7c32a2ccdd43"), 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Kéo vai bằng dây đàn hồi", 1, "Đảm bảo bạn có dây kháng lực phù hợp với sức mạnh của mình\n Đứng thẳng và đặt một đầu của dây dưới chân của bạn và nắm đầu kia bằng tay của bạn\n Duỗi thẳng tay của bạn xuống đất với lòng bàn tay hướng xuống dưới\n Giữ hai tay của bạn với nhau và kéo dây về phía cằm của bạn\n Đảm bảo nới lỏng vai của bạn trước khi bắt đầu bài tập\n Giữ cho bụng của bạn siết chặt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("05c931df-c828-442e-aee1-56432cb772c7"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Plank ngược", 0, "Mắt và cơ bụng hướng lên trần nhà\n Lòng bàn tay và gót chân trên thảm\n Cơ thể siết chặt và nằm trên một đường thẳng từ đầu đến chân\n Giữ vị trí này với chân, mông và cơ bụng của bạn co lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("07a4dbcd-635a-4a76-92d4-8127de619e6d"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Plank ngôi sao", 0, "Vị trí plank cổ điển: hai tay trên sàn, hai chân rộng bằng hông, đầu gối cong\n Nâng chân của bạn lên trần nhà mà không cong lưng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("0a280d32-de67-4a38-8f21-923243489eef"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gập bụng và xoay người", 1, "Nằm ngửa với hai chân cong và hơi tách rời\n Nâng ngực lên và xoay người khi bạn lên đến đỉnh\n Bạn có thể bắt đầu bằng cách xoay sang bên phải và sau đó đưa ngực trở lại xuống\n Khi bạn đi lên trở lại, hãy xoay sang bên trái, v.v\n Nhìn lên trần nhà và theo hướng bạn xoay người", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("0a9e1fb3-9abf-4775-a75e-2bb13009a29d"), 7.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Squat với tạ", 1, "Đứng thẳng với hai bàn chân rộng bằng vai và các ngón chân hơi hướng ra ngoài\n Nắm một quả tạ giữa hai tay và nâng lên ngực với khuỷu tay cong\n Nhìn thẳng về phía trước, hít một hơi thật sâu và siết chặt cơ bụng đồng thời đẩy hông ra sau và gập đầu gối để bắt đầu squat\n Cột sống của bạn phải giữ ở vị trí trung lập\n Giữ lòng bàn chân đặt chắc chắn trên sàn và đảm bảo trọng lượng cơ thể và tạ được phân bổ đều trên bàn chân của bạn\n Trong khi squat, hạ mông xuống hơi quá điểm mà đùi của bạn song song với sàn nhà\n Ở dưới cùng của squat, khuỷu tay của bạn phải chạm vào bên trong đầu gối của bạn\n Đẩy gót chân để trở lại vị trí bắt đầu\n Thở ra trong phần cuối cùng của bài tập này", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng tay sang ngang", 1, "Đứng thẳng và nắm một quả tạ ở mỗi tay\n Giữ lưng thẳng và bụng siết chặt\n Nâng tạ sang ngang\n Cổ tay của bạn không vượt quá chiều cao của vai trong khi nâng\n Hạ tạ xuống cẩn thận", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("0c011f92-425a-477c-84d4-3d6dc883119b"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Mở ngực", 1, "Nằm ngửa với đầu, vai và mông chạm sàn\n Chân của bạn phải cong và bàn chân đặt trên sàn\n Nắm một quả tạ ở mỗi tay với lòng bàn tay hướng về phía bàn chân của bạn\n Nâng tạ trực tiếp lên trên ngực của bạn cho đến khi chúng chạm nhau\n Hít vào và giữ hơi thở của bạn trong khi hạ tạ xuống\n Khuỷu tay của bạn sẽ di chuyển ra ngoài khi tạ đến gần hai bên của bạn\n Lặp lại\n Thở ra trong phần khó nhất của động tác nâng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("0d1e54fe-7a5f-4e0a-a59f-ee9f443718e0"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chạm mũi chân khi đứng", 0, "Đứng thẳng với cơ bụng siết chặt\n Nâng chân trái của bạn ra phía sau đến chiều cao của hông hoặc cao hơn, nếu có thể\n Bằng tay phải, chạm vào đỉnh bàn chân trái của bạn\n Trở lại vị trí bắt đầu và đổi chân", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("0d816828-8a94-4dcb-a87c-b70b295a39b6"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đá tay sau với tạ bên trái", 1, "Trong khi đứng, hạ ngực của bạn cho đến khi nó nằm ngang (hoặc gần như nằm ngang)\n Nếu nó giúp ích, bạn có thể sử dụng lưng ghế để hỗ trợ cánh tay không hoạt động\n Nắm một quả tạ bằng một tay với lòng bàn tay hướng vào cơ thể bạn\n Giữ cánh tay của bạn (cầm quả tạ) thẳng hàng với cơ thể của bạn\n Gập khuỷu tay của bạn để cẳng tay của bạn thẳng đứng\n Nâng quả tạ trong khi giữ cho cánh tay trên của bạn bất động\n Từ từ đưa quả tạ trở lại vị trí bắt đầu\n Khi cánh tay của bạn duỗi thẳng, nó phải thẳng hàng với ngực của bạn\n Tiếp tục với tốc độ vừa phải mà không giật quả tạ lên trên\n Sau khi bạn hoàn thành một hiệp với một tay, hãy đổi bên và thực hiện một hiệp với tay kia", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("13ca014d-8b75-414f-afe3-3d378ef7fa97"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bước lên", 1, "Đứng trước một bậc thang như ghế đẩu, ghế hoặc băng ghế\n Đứng thẳng và siết chặt cơ bụng và ngực của bạn\n Bước lên vật thể, luân phiên chân", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1b2afb40-fb97-49ec-8fe3-81a17c6c9078"), 6.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư thế chiến binh", 0, "Đứng thẳng và bước một bước lớn về phía trước bằng cách gập chân cho đến khi đầu gối của bạn cong 90 độ\n Đầu gối của chân sau của bạn không được chạm vào\n Nâng hai tay lên trên đầu\n Đảm bảo vai không chạm vào tai của bạn\n Giữ ở vị trí này trong vài giây\n Đổi chân", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1c5d2078-a923-4953-9677-ff890977ffcd"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Squat nhịp nhàng", 1, "Đứng thẳng với hai chân rộng bằng vai và hai tay duỗi thẳng và thẳng hàng với bàn chân\n Hít vào và gập đầu gối cho đến khi đùi của bạn song song với sàn nhà\n Gập đầu gối tới lui mà không đứng lên để bạn liên tục vận động cơ bắp của mình\n Đảm bảo giữ ngực thẳng và ưỡn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đá chân sau với dây kháng lực bên trái", 1, "Đứng thẳng và quấn dây kháng lực quanh chân của bạn.\n Giữ thẳng lưng và siết chặt cơ bụng, sau đó nâng chân ra phía sau.\n Thực hiện một hiệp đầy đủ với một chân, sau đó thực hiện một hiệp với chân kia.\n Cẩn thận không cong lưng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("1ff0ef05-4387-4483-8de3-0ef6d7724afd"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chống đẩy dốc", 1, "Đặt tay của bạn trên ghế hoặc băng ghế để dễ dàng chống đẩy hơn\n Đảm bảo lưng của bạn vẫn đẹp và thẳng\n Khi bạn đi xuống, khuỷu tay của bạn không nên vuông góc mà hơi gần với cơ thể của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("22af0171-257b-43bc-9013-8985472a8c84"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gập bụng chéo bên phải", 1, "Nằm ngửa với hai chân cong\n Nâng chân phải của bạn lên để nó vuông góc với chân trái của bạn\n Đặt chân phải của bạn lên đầu gối trái của bạn\n Nâng ngực của bạn và đưa khuỷu tay trái của bạn càng gần đầu gối phải của bạn càng tốt\n Nhìn lên trần nhà để bạn vận động cơ bụng đúng cách và không làm căng cổ\n Thực hiện một hiệp đầy đủ như thế này. sau đó đổi chân và thực hiện một hiệp trong khi đưa khuỷu tay phải của bạn lên đầu gối trái của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("235f7494-3e7d-45a5-a31a-6d5449b1322d"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bước lùi", 1, "Đứng thẳng và bước một bước lớn về phía sau bằng cách gập chân cho đến khi đầu gối của bạn cong 90°\n Trở lại vị trí bắt đầu\n Lặp lại\n Luân phiên giữa chân phải và chân trái", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("23842121-4834-4483-bfe2-2c244f5ecf76"), 7.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Trượt băng", 0, "Đứng thẳng, sau đó gập đầu gối của bạn và bước nhanh, chéo về phía bên phải bằng chân trái của bạn\n Trở lại vị trí bắt đầu và ngay lập tức bước chéo về phía bên trái bằng chân phải của bạn\n Tiếp tục luân phiên các bước bằng chân của bạn\n Chuyển động của bạn nên năng động và giống như trượt băng\n Đảm bảo cơ bụng của bạn được siết chặt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("256e23fa-03b1-4328-a325-512f0860d9b0"), 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng chân", 1, "Nằm ngửa với hai chân duỗi thẳng và hai tay đặt dưới mông\n Cố gắng nâng chân của bạn để chúng tạo thành một góc vuông với cơ thể của bạn\n Từ từ đưa chân của bạn trở lại xuống mà không để chúng chạm sàn, sau đó nâng chúng lên một lần nữa\n Cực kỳ cẩn thận để bạn không mở rộng quá mức lưng của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("2696db05-e815-4c8b-870d-23c338479e95"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tựa lưng vào tường", 0, "Tựa lưng vào tường\n Gập đầu gối của bạn để tạo thành một góc 90°\n Giữ tay của bạn ở hai bên hoặc phía trước cơ thể, hoặc trên đầu, nhưng không để chúng tựa vào chân của bạn\n Giữ ở vị trí này trong số giây yêu cầu", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Duỗi tay sau đầu bên phải", 1, "Đứng thẳng\n Nắm một quả tạ bằng một tay. Giữ ngực thẳng và thẳng, và nhìn thẳng phía trước\n Gập khuỷu tay của bạn và nâng cánh tay lên trên đầu với cẳng tay và quả tạ treo phía sau bạn để khuỷu tay của bạn hướng thẳng lên trần nhà\n Ngón út của bạn phải chạm vào đỉnh tay cầm quả tạ\n Hít một hơi thật sâu và giữ cánh tay trên của bạn bất động\n Đẩy quả tạ lên trên cho đến khi cánh tay của bạn duỗi thẳng hoàn toàn\n Từ từ đưa quả tạ trở lại vị trí bắt đầu", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ép tạ qua đầu khi ngồi", 1, "Nắm một quả tạ ở mỗi tay\n Ngồi trên ghế hoặc băng ghế và đặt tạ lên đùi của bạn\n Tựa lưng vào tựa lưng hoặc giữ cho mình cực kỳ thẳng với vai ra sau và ngực ưỡn ra\n Bàn chân của bạn phải đặt trên sàn và chân của bạn phải hoàn toàn ổn định\n Nâng tạ cho đến khi tay của bạn ngang tầm với vai trên của bạn và khuỷu tay của bạn cong xuống và thẳng hàng với cơ thể của bạn\n Lòng bàn tay của bạn phải hướng về phía trước\n Bây giờ nâng tạ lên trên đầu với cánh tay duỗi thẳng và không khóa khuỷu tay\n Cẩn thận trở lại vị trí bắt đầu và hoàn thành hiệp của bạn\n Nhìn thẳng về phía trước trong suốt bài tập", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("2e787245-7612-41bc-9b75-7a4857282350"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gập người lên và nâng hông", 1, "Nằm thẳng lưng\n Hai tay của bạn phải duỗi thẳng ra sau đầu\n Thực hiện động tác gập người hoàn toàn\n Ngay lập tức vào tư thế bàn ngược bằng cách nâng hông của bạn lên trần nhà\n Trở lại vị trí bắt đầu và bắt đầu lại\n Giữ cho cơ bụng của bạn siết chặt trong suốt bài tập\n Chuyển động của bạn phải chính xác\n Giữ ánh mắt của bạn hướng lên trần nhà\n Vai của bạn phải thấp hơn tai", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Squat tĩnh", 0, "Đứng thẳng với hai chân rộng bằng vai và hai tay duỗi thẳng và thẳng hàng với bàn chân\n Hít vào và gập đầu gối cho đến khi đùi của bạn song song với sàn nhà\n Giữ ở vị trí này", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("3100278d-eee7-4b89-b726-4b76daefabde"), 7.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Lắc vòng", 0, "Đứng thẳng với hai tay chống vào hông\n Thực hiện các chuyển động tròn bằng xương chậu\n Bài tập này cải thiện khả năng vận động của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cuốn tay với dây kháng lực", 1, "Đứng thẳng\n Nắm một đầu của dây kháng lực bằng cả hai tay (rộng bằng hông với lòng bàn tay hướng lên trên) và đặt đầu kia dưới chân của bạn\n Giữ ngực thẳng và thẳng\n Gập cánh tay của bạn để nâng dây về phía ngực của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("385f13f7-79bf-437b-acac-745b50485b9f"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng tay phía trước", 1, "Đứng thẳng và nắm một quả tạ ở mỗi tay\n Giữ lưng thẳng và cơ bụng siết chặt\n Nâng tạ trực tiếp về phía trước bạn\n Cổ tay của bạn không được vượt quá chiều cao của vai trong khi nâng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đi bộ gấu", 0, "Quỳ bốn chân\n Bắt đầu với hai tay dưới vai, đầu gối dưới hông và lưng thẳng\n Bước về phía trước, luân phiên giữa tay và chân", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("3f674891-2d75-42bf-af35-a89dff24ab22"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Deadlift với dây kháng lực", 1, "Đứng hai chân rộng bằng hông hoặc vai\n Đặt một đầu của dây kháng lực nhỏ dưới chân của bạn và nắm đầu kia bằng tay với lòng bàn tay hướng về phía bạn\n Hít một hơi thật sâu và thở ra trong khi nghiêng người về phía trước và đẩy hông ra phía sau\n Giữ lưng thẳng hoặc lưng dưới (thắt lưng) hơi cong bằng cách đẩy hông ra phía sau, và nghiêng người về phía trước cho đến khi ngực của bạn song song với mặt đất hoặc hơi cao hơn\n Giữ đầu của bạn thẳng hàng với cột sống của bạn và trở lại vị trí bắt đầu", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("407ff857-d218-44a8-8d0f-0bfa5d53bf03"), 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gập bụng chéo", 0, "Nằm thẳng lưng\n Giữ hai tay sau đầu để nâng đỡ cổ, nhưng không bao giờ kéo nó\n Nâng ngực lên và xoay sang bên phải, đưa khuỷu tay trái lên đầu gối phải đồng thời giữ chân trái thẳng\n Chân phải của bạn duỗi thẳng về phía ngực\n Đổi bên, đưa khuỷu tay phải lên đầu gối trái, chân này duỗi thẳng về phía ngực khi chân phải của bạn nằm thẳng\n Nhìn lên trần nhà để bạn vận động cơ bụng đúng cách và không làm căng cổ", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("439db970-c7c8-4b3b-9a35-127d31d920dc"), 7.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Plank nhảy", 0, "Vị trí plank cổ điển: hai tay trên sàn, hai chân rộng bằng hông, đầu gối cong\n Di chuyển bàn chân sang hai bên bằng các động tác nhảy\n Trở lại vị trí plank và thực hiện số lần lặp lại mong muốn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), 4.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Xoay vòng tay", 1, "Đứng thẳng và duỗi tay sang một bên với hai tay ngang tầm vai\n Thực hiện các vòng tròn nhỏ bằng cánh tay theo một hướng rồi đổi hướng. Điều này sẽ làm ấm vai của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("4834f1ce-41dc-4161-ac51-e03ca78b62b8"), 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Superman tĩnh", 0, "Nằm sấp trên sàn. Giữ cho chân của bạn thẳng và khép lại\n Duỗi thẳng tay của bạn lên trên đầu để cơ thể bạn tạo thành một đường thẳng\n Hít vào và nâng cánh tay, ngực và chân của bạn lên. Cơ thể của bạn phải tạo thành một vòng cung\n Giữ ở vị trí này với cơ bụng siết chặt và thở chậm", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Deadlift với tạ", 1, "Đứng hai chân rộng bằng vai hoặc hông và nắm một quả tạ ở mỗi tay với lòng bàn tay hướng xuống dưới\n Hít một hơi thật sâu và thở ra trong khi nghiêng người về phía trước bằng hông của bạn\n Giữ lưng thẳng hoặc lưng dưới (thắt lưng) hơi cong bằng cách đẩy hông ra phía sau, và nghiêng người về phía trước cho đến khi ngực của bạn song song với mặt đất hoặc hơi thấp hơn\n Giữ đầu của bạn thẳng hàng với cột sống của bạn và đầu gối của bạn hơi cong\n Nếu lưng của bạn bắt đầu cong khi bạn nghiêng người về phía trước, hãy dừng bài tập ngay lập tức\n Khi bạn đạt đến vị trí thấp nhất, hãy giữ cho cột sống của bạn thẳng và nâng ngực lên trong khi hít vào và đẩy hông về phía trước", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bước tới", 1, "Đứng thẳng và bước một bước lớn về phía trước bằng cách gập chân cho đến khi đầu gối của bạn cong 90 độ\n Đứng lên trở lại, sau đó bước một bước lớn khác bằng chân còn lại\n Lặp lại\n Tiếp tục bước tới vài bước\n Trong mỗi bước tới, giữ ngực thẳng và thẳng\n Tập trung vào việc kéo giãn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 5.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chéo chân năng động", 1, "Nằm thẳng lưng với hai tay duỗi sang hai bên\n Nâng chân phải về phía tay trái\n Bây giờ nâng chân trái về phía tay phải\n Giữ lưng càng gần sàn càng tốt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Plank", 0, "Cẳng tay và ngón chân trên thảm\n Cơ thể siết chặt và nằm trên một đường thẳng từ đầu đến chân\n Giữ vị trí này với chân, mông và bụng của bạn co lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("58878826-775e-4d4c-8e1b-d5c95afc214d"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chặt gỗ bên trái", 1, "Đặt một tay lên ghế hoặc băng ghế. Cúi người về phía trước cho đến khi ngực của bạn song song với sàn nhà, giữ lưng thẳng với đầu gối cong và lưng dưới hơi cong\n Nắm một quả tạ bằng tay kia với lòng bàn tay hướng vào cơ thể bạn\n Để tay cầm tạ hạ xuống sàn và thả lỏng vai của bạn\n Hít một hơi thật sâu và kéo tạ lên trên\n Tập trung vào việc kéo bằng vai và cơ lưng và nâng khuỷu tay của bạn càng cao càng tốt khi bạn thở ra\n Giữ tạ nâng lên trong một hoặc hai giây trước khi trở về vị trí bắt đầu\n Sau khi bạn hoàn thành một hiệp với một tay, hãy đổi bên và thực hiện một hiệp với tay kia", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("5cbc396e-381a-4d9f-9ad6-42b764deee3e"), 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đá mông", 0, "Đứng thẳng và chạy tại chỗ\n Giữ ngực thẳng và siết chặt và đưa gót chân lên mông của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6749cbc6-0e28-4163-95e8-7fb2a27c54cf"), 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chim bay", 1, "Đối với bài tập này, hãy chọn một quả tạ tương đối nhẹ\n Ngồi xuống với ngực nghiêng về phía đầu gối\n Nắm một quả tạ ở mỗi tay với lòng bàn tay hướng xuống dưới\n Nâng tạ bằng cách dang rộng hai tay ra ngoài và giữ cho khuỷu tay vuông góc với cơ thể", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 8.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Leo núi", 0, "Bắt đầu ở tư thế plank\n Kéo một đầu gối vào gần ngực, sau đó đổi chân\n Giữ nhịp điệu ổn định", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6badb5b5-ad99-4b89-80c6-e52d0f7cd7ba"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng chân sang ngang bên trái", 1, "Đứng thẳng và quấn dây kháng lực quanh chân của bạn\n Giữ thẳng lưng và siết chặt cơ bụng, sau đó nâng chân sang ngang\n Thực hiện một hiệp đầy đủ với một chân, sau đó thực hiện một hiệp với chân kia", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6d6b06e1-5ade-4dae-b442-7aa200661760"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Plank bắt đầu", 0, "Vị trí plank cổ điển: hai tay trên sàn, hai chân rộng bằng hông, đầu gối cong\n Nâng chân của bạn lên trần nhà mà không cong lưng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6ef8ed78-0d00-4271-bf9b-edf27a55ecab"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đá tay sau với tạ bên phải", 1, "Trong khi đứng, hạ ngực của bạn cho đến khi nó nằm ngang (hoặc gần như nằm ngang)\n Nếu nó giúp ích, bạn có thể sử dụng lưng ghế để hỗ trợ cánh tay không hoạt động\n Nắm một quả tạ bằng một tay với lòng bàn tay hướng vào cơ thể bạn\n Giữ cánh tay của bạn (cầm quả tạ) thẳng hàng với cơ thể của bạn\n Gập khuỷu tay của bạn để cẳng tay của bạn thẳng đứng\n Nâng quả tạ trong khi giữ cho cánh tay trên của bạn bất động\n Từ từ đưa quả tạ trở lại vị trí bắt đầu\n Khi cánh tay của bạn duỗi thẳng, nó phải thẳng hàng với ngực của bạn\n Tiếp tục với tốc độ vừa phải mà không giật quả tạ lên trên\n Sau khi bạn hoàn thành một hiệp với một tay, hãy đổi bên và thực hiện một hiệp với tay kia", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 9.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nhảy dang tay", 0, "Đứng thẳng với hai tay đặt dọc theo thân người\n Nhảy lên đồng thời dang hai chân và đưa hai tay lên cao cho đến khi hai bàn tay chạm nhau trên đỉnh đầu\n Giữ tư thế này trong một giây\n Thực hiện cú nhảy thứ hai, lần này đưa tay và chân trở lại vị trí bắt đầu", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("6ffea500-ca35-4483-b049-d8593b2c8680"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gập bụng chéo bên trái", 1, "Nằm ngửa với hai chân cong\n Nâng chân trái của bạn lên để nó vuông góc với chân phải của bạn\n Đặt chân trái của bạn lên đầu gối phải của bạn\n Nâng ngực của bạn và đưa khuỷu tay phải của bạn càng gần đầu gối trái của bạn càng tốt\n Nhìn lên trần nhà để bạn vận động cơ bụng đúng cách và không làm căng cổ\n Thực hiện một hiệp đầy đủ như thế này. Sau đó đổi chân và thực hiện một hiệp trong khi đưa khuỷu tay trái của bạn lên đầu gối phải của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("72206c5e-58f3-46f0-a8b1-031cbf599433"), 5.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Macarena", 0, "Đứng thẳng lưng\n Nâng hai tay sang hai bên\n Thực hiện các chuyển động bắt chéo\n Tay phải của bạn vượt qua tay trái của bạn và ngược lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chặt gỗ bên phải", 1, "Đặt một tay lên ghế hoặc băng ghế. Cúi người về phía trước cho đến khi ngực của bạn song song với sàn nhà, giữ lưng thẳng với đầu gối cong và lưng dưới hơi cong\n Nắm một quả tạ bằng tay kia với lòng bàn tay hướng vào cơ thể bạn\n Để tay cầm tạ hạ xuống sàn và thả lỏng vai của bạn\n Hít một hơi thật sâu và kéo tạ lên trên\n Tập trung vào việc kéo bằng vai và cơ lưng và nâng khuỷu tay của bạn càng cao càng tốt khi bạn thở ra\n Giữ tạ nâng lên trong một hoặc hai giây trước khi trở về vị trí bắt đầu\n Sau khi bạn hoàn thành một hiệp với một tay, hãy đổi bên và thực hiện một hiệp với tay kia", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("8619916d-a296-48a5-af89-f82a6a1cb26f"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đá mông bên trái", 1, "Quỳ bốn chân và chống khuỷu tay với lưng thẳng, cổ thẳng hàng với cột sống và mắt hướng xuống đất\n Khi bạn thở ra, hãy nâng một chân lên và siết chặt mông của bạn\n Khi bạn hít vào, hãy hạ chân xuống mà không chạm đất\n Lặp lại\n Để khó hơn, hãy sử dụng tạ mắt cá chân", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("8b93dbb2-fc2b-4627-b79a-3ec45a7c6238"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đá mông bên phải", 1, "Quỳ bốn chân và chống khuỷu tay với lưng thẳng, cổ thẳng hàng với cột sống và mắt hướng xuống đất\n Khi bạn thở ra, hãy nâng một chân lên và siết chặt mông của bạn\n Khi bạn hít vào, hãy hạ chân xuống mà không chạm đất\n Lặp lại\n Để khó hơn, hãy sử dụng tạ mắt cá chân", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chào buổi sáng", 1, "Đứng thẳng với hai tay chống vào eo\n Hai chân rộng bằng vai\n Nhẹ nhàng gập đầu gối trong khi giữ lưng thẳng hoặc hơi cong\n Hít một hơi thật sâu và thở ra trong khi nghiêng người về phía trước\n Đẩy hông ra phía sau để ngực hạ xuống vị trí nằm ngang, sau đó hít vào và trở lại vị trí thẳng đứng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("90ce2a9f-d0be-4ca0-b3ca-8b6947a6b266"), 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Siêu nhân", 0, "Nằm sấp trên thảm. Giữ chân thẳng và khép lại.\n Duỗi thẳng tay lên trên đầu, tạo thành một đường thẳng với cơ thể.\n Hít vào và nâng tay, ngực và chân lên. Cơ thể tạo thành hình vòng cung.\n Giữ tư thế trong khoảng 4 giây, sau đó thở ra và trở về vị trí bắt đầu. Lặp lại bài tập", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 6.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Squats", 1, "Đứng thẳng với hai chân rộng bằng vai và hai tay duỗi thẳng và thẳng hàng với bàn chân\n Hít vào và gập đầu gối cho đến khi đùi của bạn song song với sàn nhà\n Giữ ngực thẳng đứng và dành nhiều thời gian hơn để hạ mình xuống hơn là đứng lên", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("93e22c77-001f-4825-8983-4ec5b643b7bb"), 4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng bắp chân", 1, "Đứng thẳng với hai chân duỗi thẳng để bàn chân, hông và vai của bạn thẳng hàng\n Nhấc gót chân lên khỏi sàn nhiều lần liên tiếp\n Bạn sẽ cảm thấy hơi nóng rát ở bắp chân", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("9ba29558-e51b-4a1a-a1c4-b747967e32fb"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Tư thế con thuyền", 0, "Nằm ngửa với hai chân duỗi thẳng\n Nâng chân và ngực của bạn cho đến khi cơ thể bạn có hình chữ V\n Giữ lưng thẳng và ngực siết chặt\n Nếu bài tập quá khó, bạn có thể giữ chân bằng tay\n Nếu không, hãy giữ thẳng tay và nâng nhẹ lên khỏi mặt đất", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gập chân", 1, "Bắt đầu bằng cách quấn tạ mắt cá chân quanh mắt cá chân của bạn\n Quỳ gối ở tư thế plank và nâng bàn chân lên về phía mông\n Nâng cho đến khi đầu gối của bạn thẳng hàng hoàn hảo với đầu của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"), 7.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Squat với tạ", 1, "Đứng thẳng với hai bàn chân rộng bằng vai và các ngón chân hơi hướng ra ngoài\n Nắm một quả tạ giữa hai tay và nâng lên ngực với khuỷu tay cong\n Nhìn thẳng về phía trước, hít một hơi thật sâu và siết chặt cơ bụng đồng thời đẩy hông ra sau và gập đầu gối để bắt đầu squat\n Cột sống của bạn phải giữ ở vị trí trung lập\n Giữ lòng bàn chân đặt chắc chắn trên sàn và đảm bảo trọng lượng cơ thể và tạ được phân bổ đều trên bàn chân của bạn\n Trong khi squat, hạ mông xuống hơi quá điểm mà đùi của bạn song song với sàn nhà\n Ở dưới cùng của squat, khuỷu tay của bạn phải chạm vào bên trong đầu gối của bạn\n Đẩy gót chân để trở lại vị trí bắt đầu\n Thở ra trong phần cuối cùng của bài tập này", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Burpee dễ dàng", 1, "Bắt đầu bằng cách đứng, sau đó vào vị trí plank bằng cách di chuyển từng chân ra phía sau\n Đưa hai chân về phía trước (từng chân một) vào tư thế squat\n Nhảy thẳng lên và giơ hai tay lên trên đầu\n Trở lại vị trí plank và lặp lại bài tập", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Gập bụng", 1, "Nằm ngửa với hai chân hơi cong\n Nâng ngực lên cho đến khi bạn đang ngồi\n Nhìn lên trần nhà để bạn vận động cơ bụng đúng cách và không làm căng cổ", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cuốn tạ", 1, "Đứng hoặc ngồi với hai bàn chân đủ rộng để giữ cho bạn ở một vị trí ổn định\n Nắm một quả tạ mỗi tay và giữ cánh tay của bạn ở hai bên với lòng bàn tay hướng vào trong về phía đùi của bạn\n Gập cánh tay của bạn lên trên trong khi giữ ngực thẳng và ưỡn\n Khi cánh tay của bạn cong 90°, hãy xoay cẳng tay của bạn để lòng bàn tay của bạn hướng lên trên\n Tiếp tục nâng cánh tay của bạn, sau đó trở lại vị trí bắt đầu bằng cách thực hiện các bước theo thứ tự ngược lại\n Luân phiên từ phải sang trái", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("ae6eaaa1-c8c4-4f97-afa4-4ceeea19d4b3"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Lunge và xoay ngực", 1, "Đứng thẳng và bước một bước lớn về phía trước bằng cách gập chân cho đến khi đầu gối của bạn cong 90 độ\n Khi bạn ở vị trí bước tới, hãy xoay ngực sang bên phải nếu chân phải của bạn ở phía trước\n Xoay ngực sang bên trái nếu chân trái của bạn ở phía trước\n Thực hiện vài lần lặp lại ở mỗi bên", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("b2e62599-1f8c-4fc2-9ca7-8ab7aa571d4e"), 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Ép tạ qua đầu khi ngồi", 1, "Nắm tạ ở mỗi tay\n Ngồi trên ghế hoặc băng ghế và đặt tạ lên đùi của bạn\n Tựa lưng vào ghế cực kỳ thẳng với vai ra sau và ngực ưỡn ra\n Bàn chân của bạn phải đặt trên sàn và chân của bạn phải hoàn toàn ổn định\n Nâng tạ cho đến khi tay của bạn ngang tầm với vai trên của bạn và khuỷu tay của bạn cong xuống và thẳng hàng với cơ thể của bạn\n Lòng bàn tay của bạn phải hướng về phía trước\n Bây giờ nâng tạ lên trên đầu với cánh tay duỗi thẳng và không khóa khuỷu tay\n Cẩn thận trở lại vị trí bắt đầu và hoàn thành hiệp của bạn\n Nhìn thẳng về phía trước trong suốt bài tập", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Duỗi tay sau đầu bên trái", 1, "Đứng thẳng\n Nắm một quả tạ bằng một tay. Giữ ngực thẳng và thẳng, và nhìn thẳng phía trước\n Gập khuỷu tay của bạn và nâng cánh tay lên trên đầu với cẳng tay và quả tạ treo phía sau bạn để khuỷu tay của bạn hướng thẳng lên trần nhà\n Ngón út của bạn phải chạm vào đỉnh tay cầm quả tạ\n Hít một hơi thật sâu và giữ cánh tay trên của bạn bất động\n Đẩy quả tạ lên trên cho đến khi cánh tay của bạn duỗi thẳng hoàn toàn\n Từ từ đưa quả tạ trở lại vị trí bắt đầu", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("bd80fdd3-c46c-4410-b126-51a11a8a2f5b"), 6.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chuông lắc", 1, "Vào tư thế chống đẩy\n Đưa hai chân vào để chúng hơi cong với mông nâng lên trần nhà\n Đảm bảo lưng của bạn vẫn thẳng\n Đu chân phải của bạn sang bên phải, sau đó đưa nó trở lại vị trí bắt đầu\n Làm tương tự với chân trái của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nhảy dây", 0, "Nắm mỗi đầu của dây nhảy\n Vung dây và nhảy nhiều lần qua nó\n Nếu bạn không có dây nhảy, hãy bắt chước chuyển động bằng cổ tay của bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), 6.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Squat kiểu sumo", 1, "Đứng thẳng với hai chân rộng hơn vai một chút\n Hít vào và khuỵu gối xuống càng sâu càng tốt\n Đẩy hông và mông ra phía sau mà không cong lưng\n Đảm bảo giữ ngực thẳng và ưỡn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Xoay người kiểu Nga", 1, "Nằm ngửa, nâng chân và ngực của bạn lên như thể bạn đang vào tư thế con thuyền\n Ngoại trừ ở đây, đầu gối của bạn không bị khóa mà hơi cong\n Xoay từ trái sang phải như thể bạn đang di chuyển một vật từ bên này cơ thể sang bên kia. Giữ lưng thẳng và ngực siết chặt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d0dcad19-4c0c-447d-8e3c-092c6d4ad14c"), 7.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đi bộ kiểu zombie", 0, "Đứng thẳng, bước về phía trước với hai tay duỗi thẳng phía trước bạn, và nâng chân lên ngang tầm tay của bạn với mỗi bước\n Giữ ngực thẳng đứng và cơ bụng siết chặt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d3d944c4-947d-4910-bb6e-636390e5b8d5"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Plank nghiêng bên trái", 0, "Vào vị trí plank nghiêng\n Cơ thể của bạn phải được nâng lên khỏi thảm và chỉ được hỗ trợ bởi cẳng tay và bàn chân của bạn\n Thở chậm và giữ cho cơ bụng của bạn siết chặt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d4ebca3a-83ef-485b-9178-83d4eab9694c"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Cây cầu", 1, "Nằm ngửa với hai tay ở hai bên, hai chân cong và bàn chân đặt trên sàn\n Thở ra trong khi nâng mông lên khỏi sàn, đảm bảo không mở rộng quá mức lưng dưới của bạn\n Hít vào trong khi hạ xương chậu xuống, đảm bảo mông của bạn không chạm sàn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d6b2c0d5-110f-4dff-9aa7-91da10a29dca"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng hông với dây kháng lực", 1, "Quấn dây kháng lực quanh chân của bạn, ngay trên đầu gối\n Tựa lưng trên của bạn vào mép ghế sofa, ghế tựa hoặc băng ghế\n Lưỡi vai dưới của bạn phải nằm trực tiếp trên mép\n Đầu gối của bạn phải thẳng hàng hoàn hảo với ngực trên của bạn\n Bàn chân của bạn phải thẳng hàng với đầu gối của bạn\n Giữ cho đầu gối của bạn cong, đẩy gót chân để nâng hông lên\n Nâng hông của bạn lên và xuống mà không để mông chạm sàn\n Phần dưới cơ thể của bạn - chứ không phải lưng của bạn - phải thực hiện công việc\n Không khóa đầu gối của bạn khi đi lên\n Tối đa hóa sức đề kháng của dây\n Đặt chân của bạn ở nhiều góc độ khác nhau để tìm vị trí phù hợp nhất với bạn", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Bước tới", 1, "Đứng thẳng và bước một bước lớn về phía trước bằng cách gập chân cho đến khi đầu gối của bạn cong 90°\n Trở lại vị trí bắt đầu\n Luân phiên giữa chân phải và chân trái", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chống đẩy trên đầu gối", 1, "Nằm sấp\n Đặt hai tay thẳng trên sàn sao cho thẳng hàng với vai và hơi rộng hơn vai một chút\n Giữ cho cơ thể thẳng\n Nâng cơ thể lên bằng cách duỗi thẳng tay, đồng thời giữ cho cơ thể thẳng\n Tránh cong lưng\n Chỉ có tay và đầu gối của bạn chạm sàn và cơ thể của bạn phải nằm trên một đường thẳng\n Không chạm sàn giữa các lần chống đẩy", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Sâu đo", 1, "Cúi xuống và đặt hai tay của bạn trên sàn nhà trước bàn chân của bạn, với mông hướng lên trần nhà\n Hơi cong đầu gối của bạn\n Sử dụng tay của bạn để di chuyển về phía trước cho đến khi bạn đạt đến vị trí plank\n Giữ ở vị trí này trong một giây trước khi di chuyển trở lại (bằng tay của bạn) về vị trí ban đầu, sau đó đứng thẳng\n Lặp lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"), 8.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nâng cao gối", 0, "Đứng thẳng và chạy tại chỗ\n Giữ ngực thẳng và siết chặt và nâng đầu gối lên ngực", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 7.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Nhảy Squat", 1, "Thực hiện một động tác squat\n Khi bạn đứng lên, hãy nhảy lên không trung bằng cách duỗi thẳng chân và đẩy tay lên trần nhà\n Trở lại tư thế squat và bắt đầu lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"), 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Chuyển động Arlaud", 1, "Nằm sấp (trên thảm để thoải mái hơn) với hai tay duỗi thẳng và hai chân khép lại\n Ngực của bạn hơi nâng lên\n Hít một hơi thật sâu, sau đó nhẹ nhàng đưa hai tay ra phía sau trong khi thở ra\n Hai tay của bạn không được chạm sàn\n Cố gắng chạm vào mông của bạn\n Đưa hai tay trở lại vị trí bắt đầu và lặp lại", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Đá chân sau với dây kháng lực bên phải", 1, "Đứng thẳng và quấn dây kháng lực quanh chân của bạn.\n Giữ thẳng lưng và siết chặt cơ bụng, sau đó nâng chân ra phía sau.\n Thực hiện một hiệp đầy đủ với một chân, sau đó thực hiện một hiệp với chân kia.\n Cẩn thận không cong lưng", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("f93d73ba-d1d6-4037-b51b-1fd005accff3"), 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Plank nghiêng bên phải", 0, "Vào vị trí plank nghiêng\n Cơ thể của bạn phải được nâng lên khỏi thảm và chỉ được hỗ trợ bởi cẳng tay và bàn chân của bạn\n Thở chậm và giữ cho cơ bụng của bạn siết chặt", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") },
                    { new Guid("faebde03-bab9-457b-9b45-a9fabd4760aa"), 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Burpee", 1, "Bắt đầu bằng cách đứng, sau đó hạ xuống sàn nhà vào vị trí plank. Ngay lập tức thực hiện chống đẩy\n Đưa hai chân của bạn về phía trước vào tư thế squat\n Nhảy thẳng lên và giơ hai tay lên trên đầu\n Trở lại vị trí chống đẩy và lặp lại bài tập", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6") }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "CategoryId", "CreatedAt", "CreatedBy", "DishType", "FoodDescription", "FoodName", "FoodType", "IsPublic", "MealType", "Status", "UpdatedAt", "UpdatedBy", "UserId", "Views" },
                values: new object[,]
                {
                    { new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Nguồn cung cấp beta-carotene tốt cho mắt và da", "Bí đỏ", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Thức uống giàu dinh dưỡng, bổ sung canxi, tốt cho sức khỏe xương và răng", "Sữa tươi không đường", 5, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt heo xay nhuyễn, dùng nấu canh, xào, hoặc làm nhân", "Thịt heo bằm", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("05cfce09-72b4-482d-adcd-c0718015be3d"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bánh bột vàng giòn, nhân thịt, tôm, ăn kèm rau sống", "Bánh xèo", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Bánh vỏ giòn, ruột mềm, dùng kèm nhiều loại nhân như thịt, trứng, rau", "Bánh mì", 0, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh thường luộc, xào hoặc làm gỏi, giàu chất xơ", "Rau muống", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt gà vàng giòn, hương vị hấp dẫn, dễ ăn", "Thịt gà quay", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bột mỏng nhân thịt, hấp hoặc chiên, thường ăn kèm nước lèo", "Hoành thánh", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau củ màu đỏ, giàu sắt và hỗ trợ tuần hoàn máu", "Rau dền đỏ", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Chuối nhỏ, vị ngọt nhẹ, thường dùng làm món ăn nhẹ hoặc nấu chè", "Chuối tây", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây giòn, ngọt, nhiều chất xơ và vitamin, tốt cho hệ tiêu hóa", "Táo", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo từ đậu đỏ, ngọt dịu, bổ máu và mát gan", "Cháo đậu đỏ", 0, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây nhỏ, vị ngọt thanh, dễ bóc vỏ, giàu vitamin C", "Quýt", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Sản phẩm từ đậu nành, giàu protein thực vật, dùng trong nhiều món chay", "Đậu hũ", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây mọng nước, giàu chất chống oxy hóa và kali", "Nho", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Loại nấm nhỏ dài, thơm ngon, thường dùng trong lẩu hoặc xào", "Nấm kim châm", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh bao không nhân thịt, nhân rau củ hoặc đậu xanh", "Bánh bao chay", 1, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Đậu hũ mềm mịn, thường dùng làm canh hoặc món tráng miệng", "Đậu hũ non", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Khoai lang luộc chín, ngọt bùi, giàu chất xơ", "Khoai lang luộc", 0, true, "Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh giòn, thường dùng làm kim chi hoặc xào", "Cải thảo", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh hấp nhân thịt xá xíu, mềm, thơm ngọt", "Bánh bao xá xíu", 1, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 90 },
                    { new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Quả ngọt mọng, giàu chất chống oxy hóa và tốt cho da", "Dâu tây", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Thức uống từ đậu nành, ít ngọt, tốt cho sức khỏe", "Sữa đậu nành", 5, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo gạo nấu với lòng heo, thơm béo, ăn kèm rau thơm", "Cháo lòng", 0, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 80 },
                    { new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Loại củ ngọt tự nhiên, dùng luộc, nướng hoặc chiên", "Khoai lang", 0, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Loại rau xanh thường dùng trong món xào hoặc luộc", "Cải thìa", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau củ khô giàu chất xơ, tiện lợi cho nhiều món ăn", "Măng khô", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Thức uống giải khát, làm từ chanh tươi, cung cấp nhiều vitamin C", "Nước chanh", 5, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Thực phẩm chay bổ dưỡng, giàu protein thực vật", "Đậu nành luộc", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("404a286a-90c5-4c54-8e27-3ddeba55ada3"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Giàu chất xơ và vitamin, tốt cho hệ tiêu hóa", "Hạt dẻ cười", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau quả giòn, nhiều nhớt, thường dùng nấu canh hoặc luộc", "Đậu bắp", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Loại quả đỏ mọng, thường dùng làm nước sốt, canh, hoặc ăn sống", "Cà chua", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau quả mát, nhiều nước, thường ăn sống hoặc làm gỏi", "Dưa chuột", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("46b9f487-dc6d-4c1d-9729-9f707ac28202"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh mì tròn kẹp thịt, phô mai, rau, và nước sốt", "Hamburger", 1, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bún ăn kèm thịt nướng, rau sống, và nước chấm chua ngọt", "Bún chả", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bún với nước lèo mắm cá, đậm đà, ăn kèm hải sản và rau", "Bún mắm", 1, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Trái cây mọng nước, cung cấp hydrat và chất điện giải", "Dừa tươi", 5, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món hải sản ít calo, bổ sung protein và khoáng chất", "Tôm hấp", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4e46f955-4413-496f-97b4-968a38ee3e11"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Thực phẩm ăn nhẹ, giàu vitamin E và khoáng chất", "Hạt hướng dương", 6, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Món chay giàu protein, dễ chế biến với nhiều gia vị", "Đậu hũ chiên", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("51061170-597d-4289-a021-1e7dde88331f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Loại thịt mềm, ngọt, chế biến thành món quay, hấp, hoặc nấu cháo", "Thịt vịt", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt bò mềm, hấp dẫn, thích hợp cho bữa tối cao cấp", "Bò bít tết", 1, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Hải sản khô giàu iod, tốt cho chức năng tuyến giáp", "Rong biển khô", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau quả màu sắc, giòn ngọt, giàu vitamin, thường dùng làm salad", "Ớt chuông", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau lá xanh, chứa nhiều sắt và vitamin K", "Cải bó xôi", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("59988378-901f-4ec4-bd6c-9fdc28ca97a1"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Giàu kẽm, ăn nhẹ tốt cho sức khỏe và làn da", "Hạt bí ngô", 6, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Gạo nấu chín, món ăn cơ bản trong bữa cơm hàng ngày của người Việt Nam", "Cơm", 0, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây giàu chất chống oxy hóa, tốt cho tim mạch", "Lựu", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Tiện lợi, giàu dinh dưỡng, dễ chế biến nhiều món", "Cá ngừ đóng hộp", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món thịt nấu cùng trứng và nước mắm, vị ngọt mặn hấp dẫn", "Thịt kho trứng", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 80 },
                    { new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Loại nấm to, thơm ngon, thích hợp xào hoặc nấu canh", "Nấm đùi gà", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("642480b4-22c9-4350-a6ce-c052f99e60e3"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Ngũ cốc giàu năng lượng, tốt cho tim mạch và tiêu hóa", "Lúa mạch", 0, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh giúp bổ máu, hỗ trợ tiêu hóa tốt", "Rau mồng tơi", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh mì lát, dễ ăn, thích hợp cho bữa sáng nhanh", "Bánh mì sandwich", 0, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 90 },
                    { new Guid("67f6b055-1abc-4a48-97ce-63aea2e5ef7b"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Nguồn năng lượng dồi dào, bổ sung nhiều vitamin", "Hạt lúa mì", 6, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("68c8c4c4-e5d6-4e15-ad60-1c18f0c1cb4d"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Thực phẩm giàu protein thực vật, hỗ trợ tiêu hóa", "Hạt kê", 6, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Thức uống đậm đà, kích thích tinh thần, uống nóng hoặc đá", "Cà phê", 5, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 90 },
                    { new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh giàu chất chống oxy hóa, hỗ trợ thải độc", "Rau má", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món ăn miền Nam với sợi hủ tíu mềm, nước lèo thanh ngọt", "Hủ tíu", 0, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo gạo trắng nấu nhuyễn, thêm sườn heo mềm ngọt", "Cháo sườn", 0, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bún nước dùng từ cua đồng, ăn kèm rau muống", "Canh bún", 1, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Phần sườn heo mềm, ngon, thích hợp nấu canh hoặc kho", "Sườn non", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 90 },
                    { new Guid("731974ef-495e-4c08-ba95-20589d60c20c"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Hạt thơm ngon, bổ sung dinh dưỡng và năng lượng", "Hạt mắc ca", 6, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh hấp có nhân thịt, trứng, hoặc rau củ, mềm và thơm", "Bánh bao", 0, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 90 },
                    { new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau củ màu cam, giàu vitamin A, tốt cho mắt và sức khỏe da", "Cà rốt", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 80 },
                    { new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh mì giòn kẹp thịt, trứng và rau, ăn sáng nhanh tiện lợi", "Bánh mì thịt trứng", 1, true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bún xào cùng rau củ và thịt, thơm ngon, dễ ăn", "Bún xào", 1, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7729551a-e475-4079-aaa0-07c02efde2a5"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Giàu omega-3, tốt cho hệ tim mạch và não bộ", "Hạt lanh", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món cơm từ gạo tấm, ăn kèm sườn nướng, đồ chua, và nước mắm", "Cơm tấm sườn", 0, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh giàu folate, tốt cho phụ nữ mang thai", "Măng tây", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây chua ngọt, giàu vitamin C và chất chống oxy hóa", "Kiwi", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b8500af-d730-4138-9617-cba352faed4a"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây nhỏ, ngọt, mọng nước, vỏ đỏ, hạt to", "Vải", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7cd76708-7312-445e-a392-14f0e806a786"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau củ ngọt tự nhiên, giàu vitamin và chất xơ", "Đậu Hà Lan", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún tươi kết hợp thịt nướng, rau sống, và nước mắm chua ngọt", "Bún thịt nướng", 1, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Loại quả dài, xanh, dùng nấu canh hoặc xào", "Bầu", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Loại cá giàu dinh dưỡng, thường làm salad hoặc áp chảo", "Cá ngừ", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh giàu vitamin C và chất chống oxy hóa", "Bông cải xanh", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món thịt heo nấu tiêu, nước mắm, thơm nồng, đậm đà", "Thịt kho tiêu", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 80 },
                    { new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Củ ngọt, ít calo, giúp làm mát cơ thể hiệu quả", "Củ cải trắng", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Củ đỏ giàu dưỡng chất, hỗ trợ chức năng gan và máu", "Củ cải đường", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Món ăn nhanh từ thịt xay nhuyễn, thích hợp cho bữa ăn nhẹ", "Xúc xích", 1, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Giàu protein, ít béo, phù hợp chế độ giảm cân", "Ức gà nướng", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("86d88717-df08-4de6-b86d-870210864b46"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây mọng nước, thịt trắng hoặc đỏ, vị ngọt thanh mát", "Thanh long", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Phở bò kết hợp bò viên dai ngon, nước lèo đậm đà", "Phở bò viên", 0, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Loại củ mềm, dùng làm khoai chiên, nghiền hoặc hầm", "Khoai tây", 0, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Thực phẩm bổ dưỡng, giàu tinh bột và khoáng chất", "Khoai môn", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Món chay đơn giản, ngon miệng, giàu protein", "Đậu hũ sốt cà", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8ebd5a6e-b0af-42b6-af58-b681fceac1ef"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Món chè ngọt làm từ đậu đen nấu mềm, nước cốt dừa thơm", "Chè đậu đen", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bún nước đậm đà từ Huế, nổi bật với hương sả, ớt, thịt bò", "Bún bò huế", 1, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Nước trà kết hợp tắc, vị chua ngọt, giải khát", "Trà tắc", 5, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9349fefa-ecbc-4afc-89f4-62c2f67eb441"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Nguồn protein thực vật, giàu chất xơ và khoáng chất", "Đậu đen", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món phở với nước dùng đậm đà, thịt bò tái mềm ngon", "Phở bò tái", 1, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh giòn, thích hợp luộc, xào hoặc nấu canh", "Đậu que", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Nguồn canxi tự nhiên, tốt cho xương và cơ thể", "Sữa bò tươi", 5, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh chứa nhiều sắt, giúp bổ máu và tăng sức khỏe", "Rau cải bó xôi", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xanh giàu folate, tốt cho hệ miễn dịch và máu", "Rau chân vịt", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Giàu chất xơ và vitamin, tốt cho sức khỏe tim mạch", "Gạo lứt", 0, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Món ăn lên men từ sữa, giúp hỗ trợ tiêu hóa và làm đẹp da", "Sữa chua", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Hương vị đậm đà, tiện lợi, tốt cho sức khỏe tim", "Cá hồi hun khói", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Cơm từ gạo lứt, giàu chất xơ, tốt cho sức khỏe tim mạch", "Cơm gạo lứt", 0, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây nhiệt đới, thịt vàng, ngọt hoặc chua tùy giống", "Xoài", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bún với nước lèo cua đồng, ăn kèm rau sống và mắm tôm", "Bún riêu cua", 1, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Thức uống giải khát tự nhiên, giàu khoáng chất", "Nước dừa", 5, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Hải sản giòn, ngọt, chế biến nướng, hấp, hoặc chiên", "Mực", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 27 },
                    { new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Vị mặn đậm, dùng làm topping hoặc ăn sáng", "Thịt lợn xông khói", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt đỏ mềm, giàu dinh dưỡng, giúp phát triển cơ bắp", "Thịt bò nạc", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Phần trứng vàng, giàu dinh dưỡng và chất béo", "Lòng đỏ trứng gà", 1, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 80 },
                    { new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Siêu thực phẩm mọng nước, giàu chất xơ và vitamin", "Mâm xôi", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây ngọt, giàu năng lượng và chất dinh dưỡng, dễ dàng mang theo", "Chuối", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 90 },
                    { new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây ngọt, giàu vitamin C, thích hợp làm món tráng miệng", "Đào", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Sợi bún mềm, thường dùng trong các món nước hoặc xào", "Bún", 0, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món giàu sắt, thích hợp cho bữa tiệc thịnh soạn", "Ức vịt nướng", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Giàu omega-3, tốt cho trí não và sức khỏe tim mạch", "Cá thu nướng", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây ngọt mềm, màu cam, giàu vitamin A và chất xơ", "Đu đủ", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b0f051be-5972-4e7a-a77d-47ec28d58993"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Thực phẩm nhẹ, cung cấp năng lượng và vitamin E", "Hạt hạnh nhân", 6, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau củ giàu vitamin, hỗ trợ hệ miễn dịch", "Đậu Hà Lan luộc", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt gia cầm phổ biến, dùng trong nhiều món nướng, luộc, hầm", "Thịt gà", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bánh bột gạo nhỏ, ăn kèm tôm cháy và nước mắm", "Bánh bèo", 0, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Món bắp nấu chín, ngọt tự nhiên, thích hợp ăn sáng hoặc ăn vặt", "Bắp luộc", 0, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Món ăn giàu protein, dễ chế biến, thường dùng trong bữa sáng hoặc ăn vặt", "Trứng gà luộc", 1, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 80 },
                    { new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Giàu chất xơ, hỗ trợ tiêu hóa và tốt cho tim mạch", "Yến mạch", 0, true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c81a404a-ec10-428e-acec-dd56ec1d3607"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt chua lên men, thường ăn kèm lá ổi và tương ớt", "Nem chua", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Mì giàu chất xơ, lựa chọn lành mạnh thay thế mì trắng", "Mì gạo lứt", 0, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây nhiệt đới ngọt, giàu chất xơ và vitamin A", "Hồng xiêm", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm chiên vàng với trứng gà, thêm hành phi thơm ngon", "Cơm chiên trứng", 0, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 90 },
                    { new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Giàu lợi khuẩn, hỗ trợ tiêu hóa và làm đẹp da", "Sữa chua Hy Lạp", 4, true, "Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt trắng mềm, nguồn cung cấp sắt và protein", "Thịt lợn nạc", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá biển giàu omega-3, tăng cường sức khỏe tim mạch", "Cá thu", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món ăn với sợi bánh dày, ăn cùng nước lèo đậm đà", "Bánh canh", 0, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bánh trong suốt, nhân tôm thịt, thường hấp hoặc luộc", "Bánh bột lọc", 0, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau cải muối lên men, chua nhẹ, ăn kèm món kho", "Dưa cải chua", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Phở nước lèo thanh ngọt, ăn kèm thịt gà và rau thơm", "Phở gà", 1, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 90 },
                    { new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Loại rau củ thơm, thường dùng làm gia vị hoặc ăn sống", "Hành tây", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Giò heo hấp chín, mềm, thơm, thường dùng trong bánh mì, bánh cuốn", "Chả lụa", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá phơi khô, dùng nướng, chiên hoặc làm gỏi", "Cá khô", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Phần thịt gà trắng, giàu đạm, ít béo, tốt cho người tập gym", "Ức gà", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 70 },
                    { new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Thức uống tươi mát từ cam, cung cấp vitamin C tăng sức đề kháng", "Nước cam", 5, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Cà phê kết hợp sữa đặc, vị ngọt béo hấp dẫn", "Cà phê sữa", 5, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 90 },
                    { new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món bánh canh với thịt cua, nước lèo đậm đà", "Bánh canh cua", 1, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Xôi gạo nếp kết hợp bắp vàng ngọt, ăn kèm hành phi thơm", "Xôi bắp", 0, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây mọng nước, giàu chất xơ và vitamin C", "Lê", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Hải sản giàu đạm, chế biến đa dạng: hấp, chiên, xào, hoặc nướng", "Tôm", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây nhiều nước, vị ngọt mát, thích hợp trong ngày nóng", "Dưa hấu", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 80 },
                    { new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Omega-3 dồi dào, tốt cho tim mạch và làn da khỏe mạnh", "Cá hồi nướng", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh hấp nhân thịt, trứng cút, ăn sáng tiện lợi", "Bánh bao trứng cút", 0, true, "Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 90 },
                    { new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh tráng mỏng cuộn nhân thịt, mộc nhĩ, ăn kèm nước mắm", "Bánh cuốn", 0, true, "Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 90 },
                    { new Guid("f41484a3-c7df-4530-b7d2-060390103985"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Phần trứng trắng, ít béo, giàu protein, thích hợp cho người ăn kiêng", "Lòng trắng trứng gà", 1, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 80 },
                    { new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Món xôi từ gạo nếp, ăn kèm thịt, trứng, chả, và hành phi", "Xôi mặn", 0, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 90 },
                    { new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Thức uống ca cao bổ dưỡng, thích hợp cho trẻ em", "Sữa hộp milo", 5, true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 80 },
                    { new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Trái cây nhiều vitamin C, giòn, ngọt hoặc chua nhẹ, ăn cả vỏ", "Ổi", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Sữa chua mịn kết hợp nha đam giòn, tốt cho tiêu hóa", "Sữa chua nha đam", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("faf19891-525a-4308-9222-992e83de7ce7"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Loại cá béo, giàu omega-3, thường ăn sống hoặc nướng", "Cá hồi", 1, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh bột gạo tráng mỏng, ăn kèm chả, nước mắm", "Bánh ướt", 0, true, "Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 80 },
                    { new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Loại quả xanh, mềm, thường nấu canh hoặc xào", "Mướp", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Loại chuối phổ biến, vỏ vàng, thơm, ngọt, dùng làm món tráng miệng", "Chuối tiêu", 4, true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Màu sắc hấp dẫn, giàu chất chống oxy hóa", "Bắp cải tím", 2, true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 }
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
                table: "FoodPortions",
                columns: new[] { "FoodPortionId", "CreatedAt", "FoodId", "PortionId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00ba2599-2ed0-4c27-beaf-f5a45516d5e3"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("9c3399d1-72db-4e86-a518-2575033bb6a8"), null },
                    { new Guid("0c4b379f-9730-4c14-968e-1dc6e8b15ee7"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("c65d34ee-8c0c-43bb-9d4e-aa39955a4768"), null },
                    { new Guid("0e231024-1d1b-46a5-aecb-3d6c75ee9665"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("bf0f7ca4-9089-4800-95d7-8d037d98b7fc"), null },
                    { new Guid("0ef99dbc-f81d-4f4e-9676-c3ce3d8ed2a4"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("c6e853f0-06bd-4cda-8b43-cbe66fea98c8"), null },
                    { new Guid("10757a47-3b1d-4dba-8845-39de2121290f"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("a43d7637-6fc7-421b-86f1-f83e691431a4"), null },
                    { new Guid("11f31c88-3f28-4f13-85cb-e2cd4841eaab"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("698c67ad-a726-435b-b9d2-c5690a79eb5a"), null },
                    { new Guid("12a91aca-72b1-444e-bede-b5789ae76a5f"), null, new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new Guid("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52"), null },
                    { new Guid("147ef0f5-8ecd-46c5-899d-1b5eeb3f821c"), null, new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new Guid("5384aebd-4eab-4a44-8cbb-7ec2c04f1401"), null },
                    { new Guid("15d5b48a-4c77-48b4-9ae1-9e75933294e1"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("91524cc2-db22-4cab-abb7-700725232f1f"), null },
                    { new Guid("1705c171-0f6d-4ece-bc62-09451ecb348d"), null, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new Guid("7e071bd6-6afa-483d-8688-28b31b9a8bef"), null },
                    { new Guid("173f99eb-4b74-41f2-822b-7d9ebae9f2cd"), null, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new Guid("a33065fe-80ad-4879-9333-424aadc6734f"), null },
                    { new Guid("1a56d02a-3a8e-41d5-b522-1e1f28e78560"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("d9dad801-145a-419d-bbe2-408acf97a273"), null },
                    { new Guid("1ba4e726-a28d-41db-b7a6-cfe978a4b2ca"), null, new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new Guid("c4fc900f-5a92-4228-ac03-57285fff159e"), null },
                    { new Guid("216b7701-2e52-4994-87ad-ad4f69f19b11"), null, new Guid("c81a404a-ec10-428e-acec-dd56ec1d3607"), new Guid("d6c41cdb-4735-4b9e-85ae-1f48f33b7d6c"), null },
                    { new Guid("21d7e488-9fe8-40de-b8cf-a1b6db67fad9"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("e5cc2785-6d62-4b5f-8fc1-e6ab45babd76"), null },
                    { new Guid("23c007a7-d6be-472d-903a-71d1d8f29047"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("6e98f2be-9196-4c4e-8279-b02010f853f1"), null },
                    { new Guid("250bf29f-7c6d-492b-a497-0e8b414c1627"), null, new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new Guid("5f7f859a-f20a-4f6c-8b8c-ecfbb1ff522e"), null },
                    { new Guid("2a50484f-e38d-4fa7-be8f-81ed2127055b"), null, new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new Guid("255ba0f6-14cc-4049-add8-138f27055b49"), null },
                    { new Guid("2b08d5f5-2f1d-4b5b-b7df-506f3b467943"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("a5dbb27a-4856-44be-a239-76eb073c3e41"), null },
                    { new Guid("2e4dbe43-2a25-4932-bc04-44f37b5afb4b"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("e00ed683-11ff-4c21-8b1c-576b448726c9"), null },
                    { new Guid("32088a17-44b5-46f9-b836-a78b12e04a57"), null, new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new Guid("a1589990-affa-4805-a1e0-73de1ffa8516"), null },
                    { new Guid("335c92fb-07ce-4032-8143-21508381ccfa"), null, new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new Guid("e23d4491-73d1-45b5-8010-0385d7185c98"), null },
                    { new Guid("33fc1765-f91d-4ecd-ab0a-90af26808861"), null, new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new Guid("1cddc91d-209a-4948-8e9f-9017252d5423"), null },
                    { new Guid("36483ecd-b05a-4bbe-81e3-dcaa692e6d4c"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("d3850e1b-4780-490d-8c0c-ced1a9aa323b"), null },
                    { new Guid("3eaa8c80-74af-4f9e-90f0-fae8612f7e78"), null, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new Guid("eceaaa32-4023-4eab-abb6-9172c908f77c"), null },
                    { new Guid("41105b39-3d38-40e8-b8b3-2dc6bd59a33c"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("709578ca-672f-461e-995d-dc78aeda8c4c"), null },
                    { new Guid("4206bb84-22a7-47dd-9758-b96a9d1dedd5"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("52c86d57-0909-41c3-b513-e770e6f6d104"), null },
                    { new Guid("4491cfa3-da4b-4451-89ad-9dcdfd9aab42"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("f928b7a6-2558-478a-bc22-515516f4dc74"), null },
                    { new Guid("4756f12f-6349-4ed5-934b-96f1c996ca2c"), null, new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new Guid("f0e8f9cd-d133-49cf-be7d-d427b630e05a"), null },
                    { new Guid("4b48eb13-c61d-461d-afb0-7922c9d72ab7"), null, new Guid("05cfce09-72b4-482d-adcd-c0718015be3d"), new Guid("24a4ed15-69e4-4fb5-8dd2-1695de52c264"), null },
                    { new Guid("4daca8ce-3434-40a5-a864-0b87f023ae86"), null, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new Guid("8ecbc063-8d6e-450d-af39-0ba28bc572bf"), null },
                    { new Guid("4dd43c4f-0d6c-46b0-ae48-67e8697c0094"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("c605aa91-495e-4977-9876-b2a198ce356e"), null },
                    { new Guid("50ede0d4-0e7f-4b76-ab4b-2ccf12db4b60"), null, new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new Guid("3f77fd90-591c-45f3-8bbc-87d0bb49e461"), null },
                    { new Guid("54b1ee43-8b72-49f3-8253-654f5f50c0fc"), null, new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new Guid("5feca670-1f15-430d-9b04-7ac86a329a6c"), null },
                    { new Guid("54b9e304-9aaf-4a8f-ae9a-bd0d2b349715"), null, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new Guid("31e9bda5-8ec3-4444-a23a-908e84da6a14"), null },
                    { new Guid("59b68b79-7b0e-4b1c-a973-12b1d890f910"), null, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new Guid("3d6d946f-8d9f-479a-b27e-3d78dc354db0"), null },
                    { new Guid("5a613f94-4be2-435f-bf4f-2d90849c5dc3"), null, new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new Guid("ef6b8c43-9ab5-497c-a9a8-e31f0a349527"), null },
                    { new Guid("5ba8333e-ed69-45eb-9e0b-60c3b1e2d29e"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("63d10d95-7983-455e-b920-29c1f0c88d85"), null },
                    { new Guid("5fac90a4-48aa-482e-924d-63df242de911"), null, new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new Guid("22f0a09e-6816-410e-a5a2-c802103b089b"), null },
                    { new Guid("61025b38-c751-4335-8888-fb564ce5ffb6"), null, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new Guid("59589114-7d6a-4c80-8681-db5c554ab38f"), null },
                    { new Guid("62f8377b-636c-42a7-8af5-660fea55b864"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("5a9ac478-aa65-48ea-9387-1ad92f6c76b1"), null },
                    { new Guid("65abc094-9f2e-454e-ada6-943aec6523de"), null, new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new Guid("4e9013c8-d6f7-4740-80d5-e95d318873b9"), null },
                    { new Guid("66623d23-1487-4963-9a32-81595ad5acb9"), null, new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new Guid("8a81e20e-ea16-4073-957e-29508a8f7419"), null },
                    { new Guid("66dcf155-d529-4877-ba7d-967ce1da53e4"), null, new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new Guid("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649"), null },
                    { new Guid("6a7c6351-d441-4f5f-b378-6f6a7ff7da76"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("113f6a04-87c4-43c6-8263-920bd099c8e0"), null },
                    { new Guid("6ad16d0f-0d33-4158-87aa-6a178454bb16"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("f483bb75-84f0-4ecc-8a06-f366a488c6bf"), null },
                    { new Guid("6ff33303-fe14-4e96-9bdc-8db553b4c6e2"), null, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("1808de3e-ae43-41a6-b9ce-bfe89131be5a"), null },
                    { new Guid("7809d28f-1ce6-432e-8c81-41318f1c5a70"), null, new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new Guid("92e149ff-8491-48cf-a4e8-8106b1e95c4c"), null },
                    { new Guid("79192d97-cedd-412f-b698-e670462b3e27"), null, new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), new Guid("03a92c0b-b7f6-4283-8109-a35898d5d3c5"), null },
                    { new Guid("7f806a5b-b3f5-4b1e-94ad-ee735c02aa96"), null, new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new Guid("5a1bc1cb-ed0b-49bf-9c1a-5494db962d27"), null },
                    { new Guid("7f8e289a-8d81-427a-aa5c-4d9e1d95608f"), null, new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), new Guid("da254ee7-d229-4769-bad5-a617d09676d4"), null },
                    { new Guid("83d259c5-e981-4bf3-8f99-97c302501efc"), null, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new Guid("21e32570-7d64-4cec-b711-873185c76523"), null },
                    { new Guid("8400bed4-883c-472d-9893-e0d1d5ebeb34"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("e09c493c-5806-4b14-bbef-e26e19e1d8d5"), null },
                    { new Guid("86601d84-1a4c-43cf-9206-7f955461c2fa"), null, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new Guid("bad70aff-4237-4c83-b412-460020a5ee44"), null },
                    { new Guid("8990708b-f767-4f1d-97e6-cb09383a2513"), null, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new Guid("d2e88505-bbd6-4af6-9a88-535896c5d587"), null },
                    { new Guid("8f8ed943-3ff0-4c83-a86f-04f588cb3af6"), null, new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new Guid("1500876f-ef20-40de-baae-de0336bdc47b"), null },
                    { new Guid("965f7514-9cb0-47ee-b2c4-ad5518013ecf"), null, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new Guid("424ebe64-6570-4d88-9052-08c06dc0a2c8"), null },
                    { new Guid("96651249-602a-4cae-87f5-bfdfbecaa5f1"), null, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new Guid("bdd1ee1e-3a93-421f-855e-0993c7e6f767"), null },
                    { new Guid("998fd3e5-d8c7-4bc8-9b42-eca96daf4b92"), null, new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new Guid("f7b36043-9ca9-42c3-8a00-e9e235b56bb3"), null },
                    { new Guid("9abff65e-1cf4-44e8-80b5-334bac5a3b42"), null, new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new Guid("a9385e8a-e9b9-484f-beeb-bc35529cf91a"), null },
                    { new Guid("9af54402-c073-400e-be61-51580e3ff479"), null, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new Guid("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a"), null },
                    { new Guid("9f2c8cf8-1018-4ae6-8dcf-3d41c2890607"), null, new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new Guid("93984b54-2044-4ea9-8364-a03c6568e358"), null },
                    { new Guid("a1160009-3bf2-4781-bd8c-436fa6db3bd3"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("26096793-894d-47c1-a06f-cf9133f8089d"), null },
                    { new Guid("a4b3362f-4ea8-41ce-b098-4f7e650507c4"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("28b06cf6-6367-4786-bccb-89c43dd3ce3a"), null },
                    { new Guid("a52d0215-26e3-46f5-8f37-62cdf2994a2b"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("87409e4f-4bea-4bba-855d-a3bfbc2f9c20"), null },
                    { new Guid("a9485329-d522-4f04-91e8-8930317fe65a"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("36398f6d-0668-4d37-8850-9f9ee89b8b92"), null },
                    { new Guid("a9b122be-f3bd-4434-a39f-a1575af23448"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("6f34350b-8f99-446e-9de9-e0c6277b10f3"), null },
                    { new Guid("aa806135-59a1-46d5-a62d-449ac51e1d50"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("40bbc8c4-f383-4ae6-979a-3ac83c275881"), null },
                    { new Guid("aaaebd9e-635c-4eb8-bff0-2e547daf9374"), null, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new Guid("ad9ecd1e-40ec-414a-be69-b16e7013b377"), null },
                    { new Guid("b2ae77cc-b8ba-461e-a2b1-698315b1e83d"), null, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new Guid("9c276c0b-84b6-4216-8dbb-ae2034ac2176"), null },
                    { new Guid("b2c11faf-4db6-40cc-be3b-efb27703caf6"), null, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new Guid("c4993d6a-a2e0-4ddd-821a-0629541e019c"), null },
                    { new Guid("b67deeb8-21df-4b8e-b5be-3878f2684615"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("a7936b9f-b6f8-4295-8b6e-6fe1b096f437"), null },
                    { new Guid("b6accbb1-a5ee-441a-a72f-6f82a1d1a601"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("e45c2156-a98c-4121-90b4-25097e8a5cd1"), null },
                    { new Guid("b78d6cab-141f-4fbd-9442-4e73b8ec58da"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("f9bc9ae8-e42e-4e8b-84d3-f2bc36037552"), null },
                    { new Guid("b8a8bc4b-0b4e-489d-930e-10bdd0552a7a"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("218b9709-852d-4a1f-ad8b-c9410b49fea6"), null },
                    { new Guid("b973ae7b-3321-4adc-8e59-c2efa592f10b"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("5adcb96d-70ef-403d-89c6-cc3aa807b6a7"), null },
                    { new Guid("ba96a2c5-e605-4596-a600-2e4e1da6c700"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("56681171-ccbd-4700-90bc-2233c1e661bb"), null },
                    { new Guid("bc4c03ac-c4f9-436b-a4e7-413030ddbaf2"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("faec7c41-2e11-4092-8ab9-cc9c152d858f"), null },
                    { new Guid("be574c74-c56d-446a-aee0-b67bc24cc538"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("a88faa7c-6eab-4ecb-8a75-b078a9cf7834"), null },
                    { new Guid("c00ab349-fe59-41aa-b236-52202ad9c4d6"), null, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new Guid("3f19ef5c-3c60-4a11-b1b3-5158859f1286"), null },
                    { new Guid("c74a0a5c-55d4-4469-9efd-5d0b5fd15107"), null, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new Guid("18809fb3-b78a-4f67-b9f9-8bb6ab95ab00"), null },
                    { new Guid("c85fd020-29dd-4a37-8640-67b5b64ffc0c"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("1b56833b-1ff5-4a90-aea9-074de2d0dd67"), null },
                    { new Guid("c8692389-46df-4eff-9f3c-d7ea05a11795"), null, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new Guid("1cf439ce-a31b-4b95-b092-b7f6edf8d40f"), null },
                    { new Guid("ca6943c5-4718-49b1-9a92-29b58b9a583e"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("cd0b1476-44a8-4350-a6a1-3de8747a5ebc"), null },
                    { new Guid("cb36504a-6c75-4c96-bbb1-7fedf44ef703"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("7be0e4d3-1e50-4de1-931d-08adb85f628b"), null },
                    { new Guid("ccd79816-3dd4-46fc-b96e-41a2d86964a1"), null, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new Guid("84793ef9-fcd0-42df-ab0d-9380dfa18630"), null },
                    { new Guid("cd331ca5-0cdc-4878-979e-c8c84e4ff222"), null, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new Guid("b6623163-4c27-4d0c-99ef-12a67b87635f"), null },
                    { new Guid("cda01b31-be04-4019-947b-28b910c9fe0f"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("23ce32a0-6597-4b60-b35c-98073ff595c6"), null },
                    { new Guid("ced82aac-df9d-4609-a088-8b59889e9e9e"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("7b138bd4-4d3a-426c-9ab0-d66699b762d2"), null },
                    { new Guid("d28a47b2-7c18-451f-b536-0b0d7d9a052c"), null, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new Guid("de5d78a3-c5b1-4e2a-b9eb-f3757c999024"), null },
                    { new Guid("d2c350c0-610a-4dfe-b9a3-a9a682d52ce6"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("3c7d60d4-60da-4f51-9448-30877b126572"), null },
                    { new Guid("d2ccd152-8a58-4ac9-8efb-97a2ad7d46de"), null, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new Guid("1802caa2-cfe0-48e7-8580-29165f84387d"), null },
                    { new Guid("d3696bca-85e2-4c2e-ba40-7062a46c34fa"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("bd16f0ec-5ae1-42f4-a302-b4bce8f0db28"), null },
                    { new Guid("ddd2e5dc-1421-49ea-b08e-981a2fde4fe8"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("919c7f66-53e5-46bd-b181-558f6052b953"), null },
                    { new Guid("deba91b6-1cb3-43e3-9d49-2a72e34d7bae"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("17c9d30f-bd85-4e58-bfc0-6b6d70b2e5fe"), null },
                    { new Guid("def4184d-4677-453b-b27a-fe291d2d6c1a"), null, new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new Guid("41ae956e-14fc-44af-bc6a-e5ba77661cee"), null },
                    { new Guid("e09b6f71-7a18-4779-8757-208c86eeff42"), null, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new Guid("d09266d3-9e7d-46a6-ad3a-7c608ec802d1"), null },
                    { new Guid("e0eb39dd-a1a3-44eb-a5d1-86e44320d508"), null, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new Guid("16dc894a-746e-497e-a2c5-2d58f7f83c4d"), null },
                    { new Guid("e2841185-6431-49de-93cd-1f8ebf2ef93b"), null, new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), new Guid("fc245902-ef53-4363-b4ce-0e598e1dd4a4"), null },
                    { new Guid("e427885b-2b95-49bc-92c6-1efe8056f2ca"), null, new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new Guid("6792c392-3c86-4162-be91-4fc8646f861d"), null },
                    { new Guid("e431221a-e074-4986-9de3-14749c2f9eeb"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("5afaa147-398e-4be8-b0d1-8dcabe6ed18c"), null },
                    { new Guid("e5e2cbeb-8b21-4bbb-af22-fb602729c1a9"), null, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new Guid("222e1fa2-3910-42ac-9a5c-f371dded16eb"), null },
                    { new Guid("e9c4301e-dd35-42af-9b8a-e023c2fa4a60"), null, new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new Guid("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1"), null },
                    { new Guid("ec3c1267-ec54-4ddb-8675-e642a6ffec61"), null, new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new Guid("2892c25f-bd50-4bb4-a845-997395ef6693"), null },
                    { new Guid("ed73036d-e646-4fcc-a468-cd31f88a6568"), null, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("40991196-f258-43f1-ac84-0381afa83477"), null },
                    { new Guid("f3e37df1-01fc-47b0-9f86-c6bbf734bc57"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("eff728af-c8f0-4bb5-a985-d079cbadb6b5"), null },
                    { new Guid("f4a223ce-5a1b-45f3-956e-09608406ce9b"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("399eee61-90b5-464f-b3f7-7ddc1077ab0d"), null },
                    { new Guid("f5ac34fe-2097-41db-bb3e-3f74e962137d"), null, new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new Guid("749b288c-112b-4b7b-8750-0daff63d9ab3"), null },
                    { new Guid("f69de61e-2c74-44c9-b970-694380e9f0e9"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("549d664a-eb1c-4b9a-8ad7-fab9e1482e5b"), null },
                    { new Guid("fc4e13dd-77eb-4ba4-b2a9-6cb28fefe636"), null, new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new Guid("30f41ca6-c420-4f7d-9602-bf80735d5691"), null },
                    { new Guid("fd9d079c-feb7-4686-9aa0-3259d1c2e8ac"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("26dcc6e0-67aa-40ed-b3d1-8a009c60a62c"), null }
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
                    { new Guid("06e223cf-0f44-46b1-bd33-10df70a0461e"), 7f, 30f, 7.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.4f, new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), 0.2f, 112f, 0.6f, 0f, 1f, 6.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.57f, 0.03f, 0.02f, 8.1f, 0f, 0.05f },
                    { new Guid("07240e21-d8f0-495b-a258-5a159e0cf6e0"), 21f, 26f, 6.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.1f, new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), 0.8f, 340f, 1f, 0f, 1f, 2.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8533f, 0.05f, 0.11f, 9f, 0f, 0.3f },
                    { new Guid("07b97860-12b5-41ae-b6fd-baadb0d1f637"), 47f, 34f, 6.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.6f, new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), 0.7f, 316f, 2.8f, 0f, 33f, 1.7f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 623f, 0.07f, 0.12f, 89.2f, 0f, 0.8f },
                    { new Guid("091a6364-90b6-4fe3-957c-2d8b1307a75c"), 20f, 150f, 30f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), 0.4f, 100f, 3f, 1f, 250f, 1.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.04f, 0.02f, 0f, 0f, 0.05f },
                    { new Guid("0941001b-4d50-4f35-b672-aedf872ea325"), 10f, 112f, 23.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.9f, 1.8f, new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), 0.4f, 86f, 2.6f, 0.2f, 1f, 0.4f, 0.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.14f, 0.02f, 0f, 0f, 0.1f },
                    { new Guid("096eb271-f92a-48b7-8238-c85913ed038e"), 105f, 13f, 2.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1f, new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), 0.8f, 176f, 1.5f, 0f, 65f, 0.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.6f, 0.04f, 0.07f, 45f, 0f, 0.15f },
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
                    { new Guid("16e7e423-ddfc-4e43-92ad-2f2cfd76308b"), 14f, 354f, 15.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33.5f, 9f, new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), 2.4f, 356f, 3.3f, 29.7f, 20f, 6.2f, 3.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.02f, 3.3f, 0f, 0.3f },
                    { new Guid("1867907b-f5d1-44f4-859e-baa2724cd04f"), 33f, 354f, 73.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.3f, 17.3f, new Guid("642480b4-22c9-4350-a6ce-c052f99e60e3"), 3.6f, 452f, 12.5f, 0.5f, 9f, 0.8f, 1.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22f, 0.27f, 0.16f, 0f, 0f, 0.2f },
                    { new Guid("1a75b180-b31e-4fe3-8ac7-149003583a88"), 110f, 64f, 9.4f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 0.4f, new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), 0f, 140f, 3.4f, 1f, 35f, 7.5f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.04f, 0.14f, 0f, 0.02f, 0f },
                    { new Guid("1d11ea43-b4c2-47ad-9acb-33a1581df55b"), 46f, 559f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49f, 6f, new Guid("59988378-901f-4ec4-bd6c-9fdc28ca97a1"), 8.8f, 809f, 30f, 8.7f, 18f, 1.4f, 40.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.19f, 0.32f, 0f, 0f, 2.2f },
                    { new Guid("1f0efba1-d79f-4589-9781-67d4e3832a49"), 16f, 27f, 5.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.2f, new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), 0.7f, 533f, 3f, 0f, 4f, 0.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("2294d934-ca9f-4095-a2ae-796dc4a93a15"), 30f, 86f, 20.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3f, new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), 0.6f, 337f, 1.6f, 0f, 55f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.96f, 0.08f, 0.03f, 2.4f, 0f, 0f },
                    { new Guid("22ae0d04-5c0d-4cc9-95ea-3a55d7ca686b"), 30f, 150f, 18f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 0.5f, new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), 1.5f, 200f, 8f, 2f, 500f, 1f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("23311b4d-29be-4d87-982a-2e2db501dd04"), 30f, 420f, 60f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), 1.5f, 200f, 12f, 4f, 500f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.06f, 1f, 0f, 0.3f },
                    { new Guid("25ed5811-187c-4caf-bc27-6ff15182bcdb"), 37f, 53f, 13.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.8f, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), 0.1f, 166f, 0.8f, 0f, 2f, 10.6f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.34f, 0.06f, 0.03f, 26.7f, 0f, 0.2f },
                    { new Guid("26e78cb5-07a9-4cf9-9635-ae49f565002a"), 70f, 306f, 80f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.1f, 7f, new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), 2.3f, 1040f, 5.8f, 0.6f, 233f, 0.6f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 260f, 0.06f, 0.32f, 6f, 0f, 1f },
                    { new Guid("286e4e51-e6c6-40b9-b584-6c43dc41354f"), 350f, 145f, 5.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 1f, new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), 3f, 230f, 15f, 1f, 10f, 1.2f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 0.05f, 0.1f, 0.5f, 0f, 0.4f },
                    { new Guid("28a27e20-ed22-4dbd-9347-c4b44e48fad7"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("28f0f25f-36fa-4b27-9c06-705b460a50f6"), 11f, 165f, 0f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.6f, 0f, new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), 0.9f, 256f, 31f, 1f, 74f, 0f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.06f, 0.08f, 0f, 0f, 0.3f },
                    { new Guid("2a306022-b824-4ba1-80dd-953e3c315d29"), 10f, 290f, 0f, 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23f, 0f, new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), 1.5f, 200f, 20f, 9f, 75f, 0f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.05f, 0f, 0f, 0.1f },
                    { new Guid("2d054b02-0de6-4445-a261-0ec9795be969"), 5f, 89f, 22.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.6f, new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), 0.3f, 358f, 1.1f, 0.1f, 1f, 12.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("2e77be32-b505-4c84-af6e-c2166e9622a7"), 25f, 52f, 11.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.6f, 6.5f, new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), 0.7f, 151f, 1.2f, 0f, 1f, 4.4f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33f, 0.03f, 0.04f, 26.2f, 0f, 0.9f },
                    { new Guid("31e868b9-09e6-4755-8d80-d23c40290901"), 15f, 190f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 0f, new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), 1.4f, 250f, 28f, 2.5f, 60f, 0f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.06f, 0.15f, 0f, 0f, 0.7f },
                    { new Guid("320899d0-0233-4c35-9226-25f18e9f8420"), 15f, 417f, 1.4f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39f, 0f, new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), 1f, 200f, 13f, 14.6f, 800f, 1.2f, 24.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.09f, 0f, 0f, 0.3f },
                    { new Guid("322c2cb9-e6e4-40da-bc07-ba199f5f608e"), 40f, 450f, 50f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 3f, new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), 2f, 250f, 20f, 5f, 700f, 5f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.12f, 0.1f, 3f, 0f, 0.5f },
                    { new Guid("33a32530-356d-4135-8f98-73c80bf301a3"), 110f, 59f, 4.7f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.6f, 0f, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), 0f, 141f, 3.5f, 1f, 36f, 4.7f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.04f, 0.14f, 0f, 0.02f, 0f },
                    { new Guid("3460a786-93a3-47a2-8ef8-871d2a8f48ca"), 8f, 378f, 72.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.2f, 8.5f, new Guid("68c8c4c4-e5d6-4e15-ad60-1c18f0c1cb4d"), 3f, 195f, 11f, 0.7f, 5f, 0.6f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.41f, 0.29f, 0f, 0f, 0.1f },
                    { new Guid("367709d2-284b-4a39-b7dd-4148bd6eb202"), 20f, 250f, 32f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 1f, new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), 1.5f, 150f, 10f, 3f, 480f, 1.5f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("37afe853-af91-43e0-995d-5b47c71f34e9"), 110f, 59f, 3.6f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 0f, new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), 0.1f, 141f, 10f, 0.2f, 36f, 3.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 0.04f, 0.14f, 0f, 0f, 0f },
                    { new Guid("37ddc9f0-736f-43a3-a127-160740e599e8"), 500f, 245f, 0f, 152f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.1f, 0f, new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), 2.8f, 684f, 57f, 0.3f, 702f, 0f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.12f, 0.1f, 0f, 0.6f, 0.2f },
                    { new Guid("380a74d8-eb21-4c3d-bcf4-d49488b4faa6"), 24f, 19f, 3.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0f, new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), 0.3f, 250f, 0.7f, 0f, 11f, 2.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.02f, 2.4f, 0f, 0f },
                    { new Guid("391824d1-8312-4e3d-88b6-840b67e05c1f"), 54f, 389f, 66.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6.9f, 10.6f, new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), 4.7f, 362f, 16.9f, 1.2f, 2f, 0.6f, 5.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.76f, 0.14f, 0f, 0f, 0.42f },
                    { new Guid("3c0b20ab-c832-47c9-8ff7-34528e1ed1c8"), 9f, 57f, 15.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3.1f, new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), 0.2f, 116f, 0.4f, 0f, 1f, 9.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25f, 0.02f, 0.03f, 4.3f, 0f, 0.1f },
                    { new Guid("3d6391c3-73eb-42d1-b3d1-e8a3c6b7e995"), 29f, 339f, 71.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.5f, 12.2f, new Guid("67f6b055-1abc-4a48-97ce-63aea2e5ef7b"), 3.9f, 431f, 13.7f, 0.3f, 2f, 0.4f, 2.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.49f, 0.15f, 0f, 0f, 0.2f },
                    { new Guid("40f36f07-a829-4c0b-bbb1-497cdc5d7494"), 40f, 25f, 5.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.8f, new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), 0.5f, 252f, 1.3f, 0f, 13f, 1.4f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.37f, 0.04f, 0.04f, 36.6f, 0f, 0.12f },
                    { new Guid("415a9ba8-8e8c-48a8-adb7-5b6a5ab88892"), 12f, 189f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), 1.1f, 302f, 19f, 4.3f, 60f, 0f, 8.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.33f, 0f, 440f, 0.5f },
                    { new Guid("42238057-f7d3-4616-bc35-fb6de3e96ca3"), 18f, 271f, 0f, 82f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19f, 0f, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), 2.7f, 300f, 26f, 7.4f, 62f, 0f, 11.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.18f, 0f, 8f, 0.5f },
                    { new Guid("438f7428-5464-45b7-8011-6e112744c5aa"), 11f, 117f, 0f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.3f, 0f, new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), 0.4f, 265f, 20f, 0.7f, 670f, 0f, 3.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.09f, 0.2f, 0f, 200f, 0.6f },
                    { new Guid("43fd1c06-ca6f-45f4-bd25-309e86ff4e8c"), 114f, 19f, 3.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2f, new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), 2.1f, 554f, 2f, 0f, 30f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8100f, 0.08f, 0.16f, 51.9f, 0f, 1.9f },
                    { new Guid("48f62ff0-3017-4f15-a869-d25b229e44f9"), 21f, 92f, 3.1f, 233f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.4f, 0f, new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), 0.7f, 279f, 15.6f, 0.5f, 44f, 0f, 0.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.02f, 0.06f, 0f, 0f, 0.01f },
                    { new Guid("4becd22b-623f-4171-a253-71860e713590"), 35f, 420f, 50f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2.5f, new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), 2.5f, 320f, 18f, 3f, 850f, 2f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.08f, 0.1f, 0.07f, 1f, 0f, 0.3f },
                    { new Guid("4c1369ea-163e-4975-be97-74547f3e9f60"), 16f, 43f, 9.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.8f, new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), 0.8f, 325f, 1.6f, 0f, 78f, 6.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33f, 0.05f, 0.03f, 4.9f, 0f, 0.1f },
                    { new Guid("4c6c4ed8-5e9d-4904-ba56-1de114a00a6f"), 16f, 15f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.5f, new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), 0.3f, 147f, 0.7f, 0f, 2f, 1.7f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.03f, 0.03f, 2.8f, 0f, 0.03f },
                    { new Guid("4de229b6-0e2f-431d-9201-41bf4a9e847f"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("4f7b350b-b3d1-42d7-ad5b-546604b20846"), 30f, 300f, 2f, 120f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25f, 0f, new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), 2.5f, 300f, 18f, 8f, 800f, 1f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("4f85fde0-9e9d-4731-8876-626704643cfd"), 30f, 86f, 20.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3f, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), 0.6f, 337f, 1.6f, 0f, 55f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.96f, 0.08f, 0.03f, 2.4f, 0f, 0.26f },
                    { new Guid("5164278e-0585-41be-b67f-bec3d7857740"), 25f, 54f, 6.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.6f, 0.4f, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), 0.7f, 118f, 3.3f, 0.2f, 51f, 1.2f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.03f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("519c497e-44bb-41c0-87eb-59f4ed5de68f"), 45f, 31f, 7.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.1f, new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), 0.6f, 216f, 1.4f, 0f, 27f, 3.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 993f, 0.05f, 0.06f, 36.6f, 0f, 0.1f },
                    { new Guid("52829ec6-f1fc-4eda-ab4b-55a4e5b1463d"), 20f, 230f, 40f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 1f, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), 1.2f, 100f, 7f, 2f, 300f, 5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("578a7c16-1b10-47d7-a04b-9933eee3ccf9"), 21f, 83f, 19.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 5.3f, new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), 0.8f, 193f, 0.4f, 0.1f, 12f, 14.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 60f, 0.01f, 0.02f, 14.7f, 0f, 0.1f },
                    { new Guid("5bac507b-f44c-4c29-91b7-1d15c59a6449"), 10f, 132f, 0f, 51f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), 0.9f, 252f, 29f, 0.3f, 37f, 0f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.07f, 0.18f, 0f, 0.8f, 0.2f },
                    { new Guid("5c04c4bd-38f6-4df1-ab63-fae57aa591bd"), 3f, 11f, 3.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), 0.1f, 15f, 0.2f, 0f, 2f, 1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.02f, 20f, 0f, 0f },
                    { new Guid("5cc59833-5d75-46de-ac6d-1f695554912d"), 2f, 17f, 0.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0f, new Guid("f41484a3-c7df-4530-b7d2-060390103985"), 0f, 54f, 3.6f, 0f, 55f, 0.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.01f, 0.15f, 0f, 0f, 0f },
                    { new Guid("5d83f737-caf1-4c51-b34b-bb04f2554f53"), 10f, 110f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.9f, 1.8f, new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), 0.4f, 43f, 2.6f, 0.2f, 1f, 0.4f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.16f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("5e990885-3986-44d1-b4da-4f08dc54520e"), 277f, 172f, 8.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9f, 6f, new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), 2.5f, 620f, 18f, 1.3f, 15f, 3f, 7.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9f, 0.16f, 0.18f, 6f, 0f, 0.9f },
                    { new Guid("62d74ef0-fd81-4a5f-89f2-7ebb368e85ee"), 10f, 160f, 30f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), 0.4f, 100f, 5f, 1f, 250f, 1.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.02f, 0.02f, 0f, 0f, 0.1f },
                    { new Guid("6387bbb3-5d75-40f8-a48d-316fb7628ee0"), 39f, 20f, 3.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.2f, new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), 0.9f, 391f, 2f, 0f, 36f, 0.3f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 442f, 0.05f, 0.05f, 48.5f, 0f, 0.6f },
                    { new Guid("64013dfb-bfa6-4ce2-ad13-897b966acb9e"), 60f, 90f, 10f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 0f, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), 0.2f, 80f, 2f, 2f, 40f, 8f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.04f, 0.06f, 0f, 0f, 0.1f },
                    { new Guid("642b5a68-9e92-4e95-a273-35ff6791d0ab"), 15f, 239f, 0f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14f, 0f, new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), 0.8f, 260f, 27f, 4.1f, 70f, 0f, 9.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 0.06f, 0.11f, 0f, 0f, 0.3f },
                    { new Guid("66577f5e-803a-4494-910f-68afa1478176"), 20f, 200f, 35f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 1.5f, new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), 0.8f, 80f, 6f, 1f, 350f, 3f, 2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.02f, 0.02f, 1f, 0f, 0.1f },
                    { new Guid("66b7e498-4724-48ff-946f-7492f83ca015"), 23f, 40f, 9.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.7f, new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), 0.2f, 146f, 1.1f, 0f, 4f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.05f, 0.02f, 7.4f, 0f, 0.02f },
                    { new Guid("68f0232c-daa3-4160-92b4-c9d2f48805a2"), 77f, 35f, 5.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 1.5f, new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), 1.5f, 312f, 3.6f, 0f, 113f, 0.5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6.3f, 0.04f, 0.09f, 55f, 0f, 1.5f },
                    { new Guid("6b20f666-1c8a-4f85-92cd-2f2f97ba206e"), 10f, 18f, 3.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.2f, new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), 0.3f, 237f, 0.9f, 0f, 5f, 2.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.85f, 0.04f, 0.02f, 13.7f, 0f, 0.5f },
                    { new Guid("6b3afd8f-cad3-4529-bac1-5f816c2287a5"), 2f, 2f, 0f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), 0f, 49f, 0.1f, 0f, 5f, 0f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, 0f, 0f, 0f, 0f },
                    { new Guid("6cca7fd0-1564-44ea-b2e6-0c7123a2c46f"), 25f, 81f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 5.7f, new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), 1.5f, 244f, 5.4f, 0.1f, 5f, 5.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 765f, 0.27f, 0.15f, 40f, 0f, 0.1f },
                    { new Guid("6d932f58-dd55-48f7-9e94-6be12a944ee2"), 107f, 562f, 27.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45.4f, 10.3f, new Guid("404a286a-90c5-4c54-8e27-3ddeba55ada3"), 4f, 1025f, 20.3f, 5.6f, 1f, 7.7f, 39.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26f, 0.87f, 0.16f, 5.4f, 0f, 2.9f },
                    { new Guid("6ed6b010-c774-4204-b5d7-9db739c50534"), 37f, 31f, 7.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3.4f, new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), 1f, 211f, 1.8f, 0f, 6f, 1.6f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.69f, 0.02f, 0.1f, 12.2f, 0f, 0.41f },
                    { new Guid("6f09345e-735c-4fd8-a222-3791ce358f65"), 10f, 40f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.5f, new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), 0.1f, 40f, 0.2f, 0f, 3f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.01f, 0.01f, 20f, 0f, 0f },
                    { new Guid("73e992ee-249f-4580-b1d3-ae21e5c2b984"), 5f, 89f, 22.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.6f, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), 0.3f, 358f, 1.1f, 0.1f, 1f, 12.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("78c064d5-1903-4845-bb09-a6e9b4652764"), 357f, 145f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 1.8f, new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), 2.8f, 240f, 12f, 1.1f, 15f, 2.3f, 5.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 0.08f, 0.16f, 5f, 0f, 0.5f },
                    { new Guid("78c68fe2-e3cf-4022-96cc-a3085aca85cf"), 15f, 350f, 70f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 3f, new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), 1f, 200f, 8f, 2f, 250f, 2f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.15f, 0.1f, 3f, 0f, 0.2f },
                    { new Guid("7a15075d-2280-420e-8053-ed9b266f793c"), 12f, 189f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), 1.1f, 302f, 19f, 4.3f, 60f, 0f, 8.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.33f, 0f, 440f, 0.5f },
                    { new Guid("7ef18737-806e-4e66-ab2b-121a0ed87e95"), 70f, 99f, 0.2f, 189f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 0f, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), 0.4f, 264f, 24f, 0.1f, 111f, 0.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.1f, 0f, 0f, 1.3f },
                    { new Guid("81c240bc-77d1-4da5-b93b-40706cc90711"), 10f, 150f, 30f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 1f, new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), 0.5f, 50f, 3f, 0.5f, 300f, 2f, 1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.01f, 0.01f, 0f, 0f, 0.1f },
                    { new Guid("83d8e505-9186-4394-b3c0-b6f36bcd12f9"), 34f, 61f, 14.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 3f, new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), 0.3f, 312f, 1.1f, 0f, 3f, 8.9f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 87f, 0.02f, 0.05f, 92.7f, 0f, 1.5f },
                    { new Guid("8777dd83-1b4a-43f2-83dd-c4fb6834cb27"), 5f, 90f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.6f, new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), 0.3f, 360f, 1f, 0.1f, 1f, 12f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("87b1e95b-a7ad-4514-9f9a-001d54f6653b"), 22f, 265f, 49f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.2f, 2.7f, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), 2.4f, 115f, 8f, 0.5f, 491f, 5.6f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.2f, 0.12f, 0f, 0f, 0.1f },
                    { new Guid("8cecb3df-8f91-4fed-9f0d-e620f7beeb29"), 11f, 337f, 0f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28f, 0f, new Guid("51061170-597d-4289-a021-1e7dde88331f"), 2.7f, 205f, 19f, 8.5f, 63f, 0f, 12.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.06f, 0.15f, 0.23f, 0f, 0.02f, 0.3f },
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
                    { new Guid("a491a600-a88b-44c8-bc7b-70079aa09725"), 27f, 16f, 3.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.6f, new Guid("845454d0-967a-4e48-aef3-bd8458775500"), 0.3f, 233f, 0.6f, 0f, 9f, 1.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.03f, 14.8f, 0f, 0.2f },
                    { new Guid("a5d8a693-7e00-4968-ac24-2b59989c939c"), 40f, 140f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 5f, new Guid("8ebd5a6e-b0af-42b6-af58-b681fceac1ef"), 2f, 300f, 5f, 0.5f, 30f, 12f, 1.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("a8b5a680-61d1-4d93-addc-92e94556be72"), 30f, 300f, 3f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24f, 0.2f, new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), 2f, 400f, 20f, 9f, 900f, 1.5f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("aa894459-9f93-4e75-a127-35b0eae71957"), 10f, 69f, 18.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.9f, new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), 0.4f, 191f, 0.7f, 0f, 2f, 16.3f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 92f, 0.03f, 0.04f, 10.8f, 0f, 0.1f },
                    { new Guid("abd8e616-aa88-44bd-a005-9b27f53c21c8"), 85f, 718f, 13.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 75.8f, 8.6f, new Guid("731974ef-495e-4c08-ba95-20589d60c20c"), 2.5f, 363f, 7.9f, 12.1f, 5f, 4.6f, 63.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.21f, 0.16f, 1.1f, 0f, 0.6f },
                    { new Guid("ac737809-1aca-43de-88bb-b6f5fe42f87f"), 81f, 33f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 3.2f, new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), 0.8f, 299f, 1.9f, 0f, 7f, 1.5f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.36f, 0.02f, 0.04f, 21f, 0f, 0.27f },
                    { new Guid("aebf714c-276f-44a2-8182-8957a551c5f3"), 30f, 300f, 40f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2f, new Guid("05cfce09-72b4-482d-adcd-c0718015be3d"), 1.2f, 150f, 10f, 3f, 400f, 3f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.08f, 0.05f, 2f, 0f, 0.2f },
                    { new Guid("af359eea-3c29-4aa4-96d4-9655583de28a"), 2f, 96f, 21f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 2.4f, new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), 0.5f, 270f, 3.4f, 0.2f, 1f, 4.5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.15f, 0.1f, 6.8f, 0f, 0.2f },
                    { new Guid("b093fbee-db92-4031-b46b-f6528da9b6c7"), 12f, 206f, 0f, 63f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), 0.5f, 363f, 22f, 3.1f, 59f, 0f, 9.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.38f, 0f, 570f, 0.4f },
                    { new Guid("b7982fb5-0e00-457f-a618-3aabbb7d13cb"), 20f, 296f, 1.7f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26f, 0f, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), 1.2f, 200f, 12f, 9f, 1020f, 0.2f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.3f, 0.12f, 0f, 0f, 0.4f },
                    { new Guid("bafda235-4d19-4bfd-abe1-ccf2e8e642a0"), 120f, 120f, 18f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), 0.6f, 200f, 4f, 1f, 50f, 12f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.1f, 2f, 0.1f, 0.1f },
                    { new Guid("bf843bd9-a86c-4308-880f-803ac05c3948"), 125f, 42f, 5f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), 0f, 150f, 3.4f, 0.6f, 44f, 5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.04f, 0.18f, 0f, 0.02f, 0.03f },
                    { new Guid("c087ebac-77dd-40d0-bbc3-f12cc6ec458e"), 60f, 350f, 50f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2.5f, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), 1.5f, 300f, 12f, 3f, 700f, 2f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.08f, 0.06f, 2f, 0f, 0.2f },
                    { new Guid("c1f75dc1-46e3-4243-be43-1c3da379c0f3"), 20f, 200f, 25f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 1f, new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), 1.2f, 150f, 10f, 2f, 300f, 1f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("c290176e-e79f-4f97-9a4f-9e5ef06c0d49"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("c4154bdd-4853-4e11-aeac-c92601d7d628"), 10f, 50f, 11f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 3f, new Guid("86d88717-df08-4de6-b86d-870210864b46"), 0.3f, 150f, 1.1f, 0.1f, 4f, 8f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.04f, 0.05f, 3f, 0f, 0.3f },
                    { new Guid("c8b18054-abb6-4f13-9825-0134a0252c78"), 3f, 37f, 7.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.5f, new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), 0.4f, 359f, 2.7f, 0f, 3f, 0.5f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.11f, 0.1f, 2.1f, 0f, 0.01f },
                    { new Guid("c8da0730-2735-4893-a5d0-b7e46424ca52"), 20f, 59f, 15f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2f, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), 0.3f, 257f, 0.9f, 0f, 3f, 9.8f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.95f, 0.03f, 0.04f, 61f, 0f, 0f },
                    { new Guid("ca821e05-cfcc-4ea5-a544-734a88606c98"), 80f, 250f, 30f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9f, 1.5f, new Guid("46b9f487-dc6d-4c1d-9729-9f707ac28202"), 2f, 200f, 12f, 3f, 400f, 5f, 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.1f, 0.12f, 0f, 0f, 0.2f },
                    { new Guid("cb56c1e3-4966-4c4a-983e-71ca4f2a82d7"), 255f, 534f, 28.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42.2f, 27.3f, new Guid("7729551a-e475-4079-aaa0-07c02efde2a5"), 5.7f, 813f, 18.3f, 3.7f, 30f, 1.6f, 38.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.41f, 0.16f, 0.6f, 0f, 0.3f },
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
                    { new Guid("de579e51-44c1-485b-b775-7be82cafe4ed"), 8f, 110f, 23.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.6f, 1.9f, new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), 0.2f, 60f, 2.5f, 0.1f, 4f, 0.3f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("df3fac73-d9c5-4cc1-a478-c8a2fd7d5aa5"), 13f, 165f, 0f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.6f, 0f, new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), 1f, 256f, 31f, 1f, 70f, 0f, 2.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0.07f, 0.1f, 0f, 0f, 0.5f },
                    { new Guid("df7427c5-d01b-4e38-9830-3a170b5ef80b"), 80f, 380f, 50f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), 2f, 350f, 18f, 4f, 900f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("df8467cf-46a6-428a-9ffe-311514abe5b9"), 80f, 360f, 45f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 4f, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), 2.5f, 400f, 15f, 4f, 850f, 6f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.2f, 4f, 0f, 0.5f },
                    { new Guid("dfe2c54d-de32-461f-9da2-e27cbe29b735"), 50f, 380f, 45f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), 2f, 450f, 16f, 4f, 1200f, 4f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.2f, 2f, 0f, 0.4f },
                    { new Guid("e31e069c-8e49-48a5-b50e-4672ec95a42d"), 40f, 15f, 2.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.5f, new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), 0.6f, 120f, 1.2f, 0f, 750f, 0.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.01f, 0.02f, 15f, 0f, 0.02f },
                    { new Guid("e389a501-335a-4bc4-b58c-7b461c80bf0f"), 7f, 242f, 0f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14f, 0f, new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), 0.9f, 370f, 27f, 5.2f, 65f, 0f, 8.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.6f, 0.15f, 0f, 0f, 0.2f },
                    { new Guid("e4ff8429-0e76-4817-8a59-d3bf5c27f8e3"), 70f, 99f, 0.2f, 189f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), 0.3f, 259f, 20.9f, 0.2f, 111f, 0f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.02f, 0.11f, 0f, 0f, 0.6f },
                    { new Guid("e54509ea-935c-4076-9187-b085565c9c24"), 78f, 584f, 20f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 51.5f, 8.6f, new Guid("4e46f955-4413-496f-97b4-968a38ee3e11"), 5.3f, 645f, 20.8f, 4.5f, 9f, 2.6f, 47f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 1.48f, 0.25f, 1.4f, 0f, 35.2f },
                    { new Guid("e63d956e-7965-4fce-a6b8-4b471d812174"), 11f, 45f, 10.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.2f, new Guid("de097440-db5c-4d91-bd55-76618d70599d"), 0.1f, 200f, 0.7f, 0f, 1f, 8.4f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.1f, 0.02f, 50f, 0f, 0.02f },
                    { new Guid("ea48100c-1775-4605-88ff-f25a40450a04"), 56f, 155f, 1.1f, 373f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10.6f, 0f, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), 1.8f, 126f, 13f, 3.3f, 124f, 1.1f, 3.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.52f, 0.04f, 0.5f, 0f, 1.1f, 0.5f },
                    { new Guid("ea5c7dc7-7502-4eba-a4c5-97e0735584dc"), 50f, 400f, 55f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 3f, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), 2f, 300f, 15f, 4f, 1200f, 4f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.08f, 0.1f, 4f, 0f, 0.2f },
                    { new Guid("f10ffe60-7e1b-4e49-a238-521c8b8c0005"), 10f, 83f, 18.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.2f, 4f, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), 0.3f, 236f, 1.7f, 0.1f, 3f, 13.7f, 1.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.07f, 0.06f, 10.2f, 0f, 0.6f },
                    { new Guid("f3c2112c-b631-403c-9a80-340ba0c205a3"), 40f, 249f, 1.5f, 80f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0f, new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), 1f, 180f, 16f, 7f, 850f, 0.5f, 9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("f4c9c7ca-a1db-41db-8def-9a819c3c5dde"), 5f, 28f, 4.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.2f, new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), 0.3f, 300f, 2.8f, 0f, 3f, 1f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.06f, 0.07f, 0.5f, 0.02f, 0.1f },
                    { new Guid("f5172f72-f249-4842-9a27-71656f044f9c"), 22f, 265f, 49f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.2f, 2.7f, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), 2.4f, 115f, 8f, 0.5f, 491f, 5.6f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.2f, 0.12f, 0f, 0f, 0.1f },
                    { new Guid("f5e817c1-6b7c-42ee-9fd3-e95735b78155"), 8f, 250f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0f, new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), 1.3f, 220f, 19f, 7f, 65f, 0f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.05f, 0f, 0f, 0.1f },
                    { new Guid("f5f1aa49-7b6f-4a25-a0ac-a9966394299a"), 30f, 400f, 45f, 80f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 3f, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), 2f, 200f, 15f, 5f, 600f, 3.5f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.1f, 0.08f, 2f, 0f, 0.3f },
                    { new Guid("f68975c6-d48b-4bf3-a1a3-0c8989d1c43f"), 24f, 20f, 3.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.1f, new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), 0.5f, 202f, 2.2f, 0f, 2f, 1.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 756f, 0.08f, 0.14f, 5.6f, 0f, 1.1f },
                    { new Guid("fd064d13-48cd-473f-9375-c46c79bc4eed"), 40f, 350f, 55f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 2.5f, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), 1.2f, 250f, 12f, 2.5f, 850f, 4f, 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.1f, 3f, 0f, 0.2f },
                    { new Guid("ff22f28d-22f4-4964-91ea-50619e603acd"), 33f, 41f, 9.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.8f, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), 0.3f, 320f, 0.9f, 0f, 69f, 4.7f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.69f, 0.04f, 0.03f, 5.9f, 0f, 0.66f }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "WorkoutExerciseId", "CreatedAt", "Duration", "ExerciseId", "Order", "Reps", "Status", "UpdatedAt", "WorkoutId" },
                values: new object[,]
                {
                    { new Guid("033b47f4-371c-4edf-b3c1-1919341a3e38"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("0547ebef-1c92-4f6c-ac14-35f6925d35a7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 9, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("059df528-336c-484c-b779-21f079e8579c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 5, 6, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("05f3743c-70f4-40aa-8726-a1a565f1b205"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("5cbc396e-381a-4d9f-9ad6-42b764deee3e"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("064f5370-3074-4f74-9066-ba705f1e5466"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), 4, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("086a95d1-3aa2-4762-9070-c44578479749"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 4, 6, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("0a76a1b9-d975-4f81-a79f-320f84f27cd6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 3, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("0bff1182-9b1f-45d0-b593-7c5cc6ca2cad"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 1, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("0c5ab2a9-c894-4271-b126-4016e49058f7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 2, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("10842904-90a9-4af5-8711-1fde977936b5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("4834f1ce-41dc-4161-ac51-e03ca78b62b8"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("110fa024-a967-4917-b4a5-37812bea0f4f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), 8, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("120f6fd6-0e13-4396-b04d-386f64e7c5cb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), 3, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("1390ea0b-159d-45c1-a807-f42a0f28f718"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 1, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("1441eab9-473d-46bf-afb0-2bb442744445"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), 3, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("146f1c77-3f6d-4e6a-ad53-11d16d23c991"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("1587728d-19b5-4cec-9eb1-eb588ba78154"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"), 3, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("15b87798-5032-4449-9448-18f1f43e3c97"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d4ebca3a-83ef-485b-9178-83d4eab9694c"), 1, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("16c74683-2f04-4e80-8961-83144057cb83"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 6, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("170df79f-63e7-4dba-bd2d-b2acd67a7603"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("1a117266-9c22-400d-918c-563bc0d7d1b7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a280d32-de67-4a38-8f21-923243489eef"), 2, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("1ca6b999-2097-45da-b2cf-a73643e38519"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("13ca014d-8b75-414f-afe3-3d378ef7fa97"), 4, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("1dc39e1d-d830-415a-9889-66469fb80b98"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("0d1e54fe-7a5f-4e0a-a59f-ee9f443718e0"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("1e8fb46a-e9a8-4d0a-a073-8353b978253b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 7, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("20702526-2387-41f9-a508-c62c098a7ec9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), 2, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("211d9552-c36f-4a0e-affb-e142271bcca3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("22275258-338f-4e06-b102-e6454d519998"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 5, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("22753743-f0c2-423a-a88e-c2141140fd5c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 3, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("23bbbab0-ff8c-4491-92ba-cd261a36dc98"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("f93d73ba-d1d6-4037-b51b-1fd005accff3"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("24fb11e5-df6b-41e5-a2b0-574bf652ba07"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("2559a224-5723-448a-b3b2-d68a4f572435"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("28d0e1e2-12bd-45bd-ac0f-62d3b1693d7d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"), 5, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("295d84c3-583d-4ce5-b567-f49f761cd9d1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 1, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("2d2bbe08-af3b-4805-ba8f-4e2320806005"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("faebde03-bab9-457b-9b45-a9fabd4760aa"), 1, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("2feb81f6-f2d3-4396-8896-9047e298c1e5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 8, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("2ffc2480-fa98-462f-b647-0c8c3ea0a8ac"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("30255633-35ac-4147-aa82-b885774689fa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("58878826-775e-4d4c-8e1b-d5c95afc214d"), 6, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("31319a3e-685a-4372-babe-8ee3b3dde14c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 3, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("31e24599-6e2a-44d7-bab6-763ff629457d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), 1, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("333faa32-849d-42f1-acd6-9f5819664838"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 6, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("35fddcc2-e649-40d3-aef0-dda58318591a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), 3, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("376bbe96-5173-466d-b1c0-36e20118c04d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("377865b2-b98a-4aa6-aa2e-7088b62fee6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("379dc7df-3407-420a-8386-ef75b84991da"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("07a4dbcd-635a-4a76-92d4-8127de619e6d"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("37a65cbd-dfdf-445d-853e-13592cc21b61"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("37bbaf9a-944f-4977-846e-109fbee55c67"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6ffea500-ca35-4483-b049-d8593b2c8680"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("3a2b7d9c-b6a2-40fd-9bf3-d0d981700a35"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("235f7494-3e7d-45a5-a31a-6d5449b1322d"), 2, 16, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("3bd54c2d-facb-4870-bb6e-32b6e17396ac"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 3, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("3d17cd40-c5ca-4acd-955f-a4b1e1890ee9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("413b8a58-bce8-457b-a6f5-a82de7f41ddc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("44805107-4907-4111-80ce-120c55459e3d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 1, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("45610a24-15a0-433c-a1d6-69064210b725"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), 6, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("4756b227-0190-4b1e-b5c4-076c52956887"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), 6, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("4793ea7a-d4fb-4b72-82ba-1d523592bd4e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("1b2afb40-fb97-49ec-8fe3-81a17c6c9078"), 3, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("48003f07-a231-4013-b617-d23c453a3c17"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 2, 30, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("498f7728-658f-4900-9f16-1a1d2bbdd03d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 7, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("4a578ea4-2026-4bcd-a3df-0492f14279e3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("4abcbe05-8b68-462a-9a59-74e98b71276e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 5, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("4b143bb4-5937-48e7-8476-efea74e4e117"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01e6141a-930e-4126-a2c6-7c32a2ccdd43"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("4d2cefad-22d1-43fd-afdc-2f332564ba70"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a280d32-de67-4a38-8f21-923243489eef"), 3, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("4ee690c1-4b1c-4d11-a479-1eb76ac1ba9f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 5, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("4f16bc1e-1d43-4a6f-b421-8d0833e738ff"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0c011f92-425a-477c-84d4-3d6dc883119b"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("534d68a5-3fc6-4ee7-92dc-779eb9226c4c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 8, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("55509ebe-e7c0-49c9-85ce-56a26b2359e7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ff0ef05-4387-4483-8de3-0ef6d7724afd"), 4, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("556ea4b0-373f-4296-b77d-cd080e9437e1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3100278d-eee7-4b89-b726-4b76daefabde"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("55774c1b-5c7d-434c-9404-1ce396db1411"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("d0dcad19-4c0c-447d-8e3c-092c6d4ad14c"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("56506827-4084-4c6e-b38c-4fac41e49cff"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("57902a01-04b5-46b8-a1f6-381292cf0208"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), 3, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("5d52a17e-fe9f-47ab-9cf6-48be46d81dc9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), 2, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("62b48095-da08-4913-bbf5-4efb102a1833"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 4, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("62d9b48e-0ffe-4a75-95d1-8673dd502495"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("638df2b1-001d-4efc-939f-cd8f6b7198ac"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("65a821e4-c8e8-4b70-bca9-29042a263f1c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 4, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("662e03bb-5b3b-4c26-97da-506980646ca5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("72206c5e-58f3-46f0-a8b1-031cbf599433"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("66a6fc11-2736-4ecf-ac87-bc4db7af19d2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8619916d-a296-48a5-af89-f82a6a1cb26f"), 3, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("68caf073-a31a-47e3-92b0-37eef346c1ea"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 1, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("6aa071ac-6552-4906-8031-59f8a0b6a01e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 4, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("6bbe8f61-0025-4197-bd9c-9ff2bfcd9946"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("6c80f189-a937-4c18-bdcb-bf1c3abc2869"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 8, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("6d2f03da-b017-4807-99d2-fb1f0b5ace7f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"), 7, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("709b95d5-91fd-4688-bdd6-79196a83710c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("7142be1c-2a6a-4814-9d57-c10413bc3bd3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), 4, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("72af4d27-299f-4fb7-9c29-40e955cb6115"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("72fe9536-25c8-4f73-b3fb-9547e39b8454"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("93e22c77-001f-4825-8983-4ec5b643b7bb"), 5, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("7422067b-ae7d-43d6-b678-1c4f199d2b9d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 5, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("74a7ccdc-78ef-4569-abbf-1abcdbabeddd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6ef8ed78-0d00-4271-bf9b-edf27a55ecab"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("755829bb-1f53-460f-b071-11e9403002da"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("757ba751-aec4-4cdc-8584-5a06d10ea003"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("769bc05c-afe4-44e2-aad3-a97ba414aa29"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), 7, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("7993a57c-373e-438f-a91a-eaf925b52676"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), 4, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("7d417f1f-7429-40b3-a1a7-523e1b989584"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8b93dbb2-fc2b-4627-b79a-3ec45a7c6238"), 2, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("83aee4b5-d892-46c7-b444-e7dcf75654ca"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 2, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("84e25dc8-c880-4736-b1cc-219ad085e272"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 3, 30, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("86651ea3-5b6f-461f-b7bc-f118fb1aa267"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"), 3, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("8670c3c2-4c61-40a0-92ee-621713ba604c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 2, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("89236b76-901d-4230-abe3-318065b96100"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("23842121-4834-4483-bfe2-2c244f5ecf76"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("8af8ad6b-79ff-4275-b5cd-df4c27e4d44c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("8c42d2a7-c7ca-48e2-9aca-01f4159c313c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 5, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("8dfd59cd-ef16-44aa-a29d-0e8750a44038"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"), 4, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("9017d27f-d5e1-46d1-86b8-3bf6613a5f11"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), 1, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("9098f870-0fe7-4f4c-8061-b3a89b16663a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"), 3, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("90effa7e-8bd1-4cb9-a077-7ad9faeec607"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("385f13f7-79bf-437b-acac-745b50485b9f"), 2, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("90fbf44e-0160-47b5-bdde-75c16bc43653"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), 1, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("92c913cd-bacc-440e-b2a4-ba3e0dacada4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("94640cf8-8d67-4c9c-abcf-59cb7a09319d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("97798755-6912-4fcc-9609-5eecb9c96cb2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 2, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("97c9f1d8-e6de-4876-81ed-b89289acb283"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ae6eaaa1-c8c4-4f97-afa4-4ceeea19d4b3"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("9bb8a8da-3949-4334-b664-710e9c5a2a09"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), 1, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("9c5ae9a7-8a95-4397-9d06-5e447bd0963c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 3, 30, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("9e616afd-fee8-4899-9b9e-9346f053a0c3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6badb5b5-ad99-4b89-80c6-e52d0f7cd7ba"), 4, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("9ef8c6e6-2c7d-40e6-ba0a-c28db920038d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("05c931df-c828-442e-aee1-56432cb772c7"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("9f310e2a-88b4-4a8e-99cb-447ed6d41808"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 1, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("a1836d9e-0912-46b0-bb60-9ccf317d3738"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), 6, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("a6c968f1-a71b-4935-bc9b-d2690c60831b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a9e1fb3-9abf-4775-a75e-2bb13009a29d"), 1, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("a7a2d146-abf2-425b-8fad-f748198e4c7c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("93e22c77-001f-4825-8983-4ec5b643b7bb"), 3, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("a9450424-580c-4655-a91b-fcd13b256c2d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("439db970-c7c8-4b3b-9a35-127d31d920dc"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("aa371af7-a23f-40f3-8194-a4dde9d51c45"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("aa699ea3-ea3d-471d-8d96-55d286e4896c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ae6eaaa1-c8c4-4f97-afa4-4ceeea19d4b3"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("ab864fdc-70a3-4025-a42c-416f2cfa700a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("9ba29558-e51b-4a1a-a1c4-b747967e32fb"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("acdd8b86-99eb-4bc4-8875-540921ea5126"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 3, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("ae4aee89-066e-475c-b334-12aeb7ef1ee8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 1, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("afa73182-20e9-444a-8bf9-de85a920d7d1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), 5, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("b10f3abc-1438-41fd-986d-f2e3a4349750"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 3, 32, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("b21759a1-b2d8-4471-9376-5d64835dc767"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("b25f6686-6732-4104-9e5c-95c8fa6c2481"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b2e62599-1f8c-4fc2-9ca7-8ab7aa571d4e"), 2, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("b28c1d2f-af76-406f-a766-32feb3cd8f87"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("b4a990db-6cd3-402e-b57d-ad458f832163"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), 1, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("b55415a1-b905-4383-bfd7-9d3374e33ceb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("256e23fa-03b1-4328-a325-512f0860d9b0"), 6, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("b7c173c0-0a23-4810-a216-1ff170896671"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), 4, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("ba36952d-7702-4410-8b6e-0b751db0292b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0d816828-8a94-4dcb-a87c-b70b295a39b6"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("bb545213-8f5b-4e17-b96f-a7a061d2fbb4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 4, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("bca1c1d8-5e19-434e-a23c-0ccd33e1e34d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01dc4c46-e1ef-44bc-9f19-ecb283bf27ce"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("bd8d2eb8-3f69-4d65-a3f0-cbe1519f49b6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("bde019f0-b9ee-4146-9087-f3ca553952e2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), 2, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("be77f2f7-10ea-4038-8dab-911b95e42770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"), 4, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("bee4251a-f9fb-422c-b35c-2a63e6715ed9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("72206c5e-58f3-46f0-a8b1-031cbf599433"), 3, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("bf97d9d2-c9ab-4f52-a592-24fd4b2e76cc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 5, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("c16ca592-8f61-46f5-97e7-b764d2349d6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 5, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("c28d2a41-c018-4e69-98e6-402ca485a906"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("ca671f59-5509-40e5-bd5a-7167fd779725"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2e787245-7612-41bc-9b75-7a4857282350"), 2, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("cbdcba64-1e72-4061-9994-d437b2565646"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), 1, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("ceb33e88-093d-4b4b-9b40-f79c08d9b45d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 5, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("ceba9321-ca16-4a8e-a135-ef79069df7cc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6749cbc6-0e28-4163-95e8-7fb2a27c54cf"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("d13c82e8-3261-4f19-82b6-0e9f0c1eccdb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("d532b764-220e-485d-b130-f0498941bfe2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), 6, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("d6d283b9-ea28-4668-8ec2-c72ba9b759aa"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("d8316d68-c5c9-486e-bd07-8083c0e1a86c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), 7, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("d852330b-0ee7-4efd-83dd-9434d5b8dd7f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), 3, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("dfb43667-010f-4519-88e9-3f2be39e0b53"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("e1114354-917c-4680-9c00-c0c6a2961e54"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 1, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("e128a9c3-cab0-44f0-912a-03e4af308a6b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("e431cc76-0582-4cc2-814f-81ba151a686c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("2696db05-e815-4c8b-870d-23c338479e95"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("e56c0318-e410-41c3-b842-42039371453b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("e6e996d5-3409-4833-a0c5-655d70e30805"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), 6, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("e75f0c70-d23e-4323-92b7-ba0e33ef4e01"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("9ba29558-e51b-4a1a-a1c4-b747967e32fb"), 5, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("e986985d-b204-46be-9386-23a56e2a6315"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("58878826-775e-4d4c-8e1b-d5c95afc214d"), 8, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("e9bf1ed0-44a6-4230-b40f-4adb945e942f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 2, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("e9d8fcb2-270d-4f47-a1b5-5305b238ce9c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 3, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("eb491678-de6a-4fa6-9b11-e7a5e30cd4b5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01e6141a-930e-4126-a2c6-7c32a2ccdd43"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("eb8eca45-cd28-4660-95b4-f750315bb79d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("22af0171-257b-43bc-9013-8985472a8c84"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("ee6b86f1-69eb-435e-ae38-aea3a8be9ca7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 5, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("eeabc5d1-0204-450b-b6c3-336263ad8e0f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("407ff857-d218-44a8-8d0f-0bfa5d53bf03"), 7, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("ef606768-fcbc-4825-a852-d91986c66a0e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bd80fdd3-c46c-4410-b126-51a11a8a2f5b"), 3, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("ef880810-a3f0-4f77-ab85-accb0ce6aaa3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"), 1, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("ef8f7f21-eae4-4453-8050-f63e60498d70"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("23842121-4834-4483-bfe2-2c244f5ecf76"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("efdda1f9-dc85-40bf-9bf8-8b7a02dd84fd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 1, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("f0268e00-71b3-4b51-a4ad-33be6811e389"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 5, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("f11da39d-99e3-4994-bb94-80db8c64261b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("d3d944c4-947d-4910-bb6e-636390e5b8d5"), 3, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("f2abb795-c822-475e-8c38-adf9e6d1510d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 4, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("f522eb19-2465-40fd-9cf0-a4f50f084dfc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 1, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("f61337af-1301-44a9-8f5b-53e1f537b377"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 3, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("f6275006-cf75-4f2a-b290-58fa0bca662d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d4ebca3a-83ef-485b-9178-83d4eab9694c"), 4, 16, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("f6a14bee-6be2-4417-b6d9-6cc56510a51c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("f7664a69-0d3b-4caf-baae-991c62ce269f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d6b2c0d5-110f-4dff-9aa7-91da10a29dca"), 3, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("f7af0d81-ee8d-4182-b227-69067bb6c2b6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 5, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("f886a397-d4a9-40eb-8b9f-380a2d69e167"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), 5, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("f92fec32-4740-4679-adba-2d582956089d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("faad179b-503c-4a14-94d6-3da87b7a7855"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6d6b06e1-5ade-4dae-b442-7aa200661760"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("fbbc356e-81b9-4ee0-994a-57b7808dcc8e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("fbd400eb-0716-45f0-aeb7-72b5fe3a30b3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("fc97df3d-3b5c-4ddc-8eb4-411df765afa2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), 3, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("fcb2a3bf-4222-47d2-baff-88dd7c200b10"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_DailyActivityId",
                table: "Activities",
                column: "DailyActivityId");

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
                name: "IX_Certificates_ExpertiseId",
                table: "Certificates",
                column: "ExpertiseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_UserId",
                table: "Certificates",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultantExpertises_ConsultantId",
                table: "ConsultantExpertises",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultantExpertises_ExpertiseId",
                table: "ConsultantExpertises",
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
                name: "IX_Payments_BookingId",
                table: "Payments",
                column: "BookingId");

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
                name: "ConsultantExpertises");

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
                name: "Expertises");

            migrationBuilder.DropTable(
                name: "Portions");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Consultants");

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
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
