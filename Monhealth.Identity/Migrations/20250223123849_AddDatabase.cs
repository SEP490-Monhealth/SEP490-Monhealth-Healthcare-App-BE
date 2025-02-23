using System;
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
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), null, "Tư vấn viên", "Consultant", "CONSULTANT" },
                    { new Guid("d21edfd6-42d5-490a-a41c-43f7ef09c61f"), null, "Quản trị viên", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 0, null, "ba8d0721-54f2-4b9b-a14d-7b30a243372d", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "khanhpham@gmail.com", true, "Nguyen Pham Khanh", false, null, "KHANHPHAM@GMAIL.COM", "KUEM113", "AQAAAAIAAYagAAAAEIgCy166F6pjwwHFLUXFxW4bvlS1Ae7F2Zqy1bKxJt9ykjHOixR1pkZVCSEGNHdKmw==", "0969998878", false, null, null, "ad9ac032-b302-4d52-b20f-fb53a0a4ed09", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "kuem113" },
                    { new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), 0, null, "33c2796a-b765-4b96-9977-ca998a7fb0ea", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "duythunglungtinhiu@gmail.com", true, "Pham Hoai Duy", false, null, "DUYTHUNGLUNGTINHIU", "DUYPRO113", "AQAAAAIAAYagAAAAEF79CM6UuHihxu4wP7lKBirFCHvrqEof7d9wMSO8ckj0zKAJdg476zLfzhYf+zjHUA==", "0555666612", false, null, null, "f332c40c-9e4f-43cc-8ff1-3cd5fd762450", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "duypro113" },
                    { new Guid("20041d5b-01e4-443f-9652-e39beb9748e5"), 0, null, "047a1ffe-ba94-4947-8c29-5e6139c2c132", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "consultant@gmail.com", true, "Van Huu Toan 2", false, null, "CONSULTANT@GMAIL.COM", "0987654321", "AQAAAAIAAYagAAAAEB+7TfC3gaT6UhGqW8wzQJocM2UexJHZFQCqhNpXSPGhGzvjytwMkDBB7EaBvcDjBw==", "0987654321", false, null, null, "766f0ab7-c15d-4439-a4b9-31b6ce211ace", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "vanhtoan" },
                    { new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 0, null, "e617ccc0-a50a-46d8-9e61-c4f9084d7a20", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quocdai@gmail.com", true, "Nguyen Quoc Dai", false, null, "QUOCDAI@GMAIL.COM", "DAINQ115", "AQAAAAIAAYagAAAAEPxkFD3ekHUTvZCOPQDnulM9LgYtmWE4Bl85LqD1HFSI5GR+6gy8tP8A+wTbNm87sg==", "0932748924", false, null, null, "614783c8-b1b9-4217-947c-c7238ee9f93c", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "dainq115" },
                    { new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0, null, "5bbc2400-e438-4b71-821e-ca07056224e7", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "asd@gmail.com", true, "asd", false, null, "ASD@GMAIL.COM", "ASD", "AQAAAAIAAYagAAAAEITz1dIUMpOSpu9p7hAsRXoHnD8sWOfMtgiBidG308MrE92ypguLLI6q1b0iSSmGuA==", "0123456789", false, null, null, "c664c628-e1c2-4b5f-af33-6ba6a58c1edb", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "asd" },
                    { new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"), 0, null, "45955519-4297-43b2-876c-b3eebf70fdf0", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "khaitoi@gmail.com", true, "Phan Van Khai", false, null, "KHAITOI@GMAIL.COM", "XAUTRAI123", "AQAAAAIAAYagAAAAEHQEZ+1Hui5UNEdeE8vwXCKFueOY8cfJ10BvlACzljDoFaQoxG8ussCx0hs/CAyn6A==", "0963122758", false, null, null, "0218c654-35b4-45d3-9924-ed72f15cb140", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "xautrai123" },
                    { new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 0, null, "8dcc96fe-5580-47e3-ae26-d73985116b20", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quangdalat@gmail.com", true, "Quang La Tui", false, null, "QUANGDALAT@GMAIL.COM", "QUANGSPA009", "AQAAAAIAAYagAAAAEIgEwnKh/3G3SV3VQBpXXi6eAsbYyfakuY0LfC6wr4YObIsNPeb0vxa55f3NpoPZ8A==", "0999777712", false, null, null, "513e10c1-601b-4c08-a16c-d70f893dd06f", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "quangspa09" },
                    { new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 0, null, "1aba555d-1600-4ef7-8c7e-2cf19fe427ca", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "toanvan@gmail.com", true, "Van Huu Toan", false, null, "TOANVAN@GMAIL.COM", "VIPRO123", "AQAAAAIAAYagAAAAEPN93dH+4lgnl1C5tcmp8wkCQlYdWt2IomaTRYlpSCHWmX21W0EOO/3gRV9PBXzv5Q==", "0792766979", false, null, null, "2a77cf7f-9b5a-4219-b74d-22ebcf682a58", true, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "vipro123" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName", "CategoryType", "CreatedAt", "Image", "UpdatedAt" },
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
                    { new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Bí đỏ là loại rau quả giàu vitamin A và C, giúp cải thiện thị lực và sức khỏe da. Bí đỏ có thể chế biến thành các món canh, xào, hoặc làm sinh tố, là món ăn bổ dưỡng cho cả gia đình", "Bí đỏ", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("00bc33fe-4cd5-47df-bd94-15ac9f93648c"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Súp rau củ là món canh thanh đạm với các loại rau củ như cà rốt, khoai tây, đậu que, nấu trong nước dùng nhẹ nhàng. Món này bổ dưỡng, dễ tiêu hóa và thích hợp cho các bữa ăn thanh mát", "Súp rau củ", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("01e60ae4-ff69-44d6-b4fd-aaf916e3a7e5"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm gà xối mỡ là món ăn đặc trưng với cơm trắng ăn kèm thịt gà chiên giòn, đậm đà với lớp mỡ giòn rụm. Món này thường được ăn kèm với dưa leo và rau sống", "Cơm gà xối mỡ", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Sữa tươi không đường là nguồn cung cấp canxi và protein giúp xương chắc khỏe. Nó cũng hỗ trợ phát triển cơ bắp, cung cấp vitamin A và D. Sữa tươi là thức uống bổ dưỡng cho bữa sáng hoặc giữa các bữa ăn", "Sữa tươi không đường", "[5]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0292d477-d63b-4904-a83b-2cd8cac39c14"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh củ quả là món canh với nhiều loại rau củ như cà rốt, khoai tây, đậu hà lan, nấu trong nước dùng nhẹ nhàng. Món này cung cấp nhiều vitamin và chất xơ, rất tốt cho sức khỏe", "Canh củ quả", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Thịt heo bằm là nguyên liệu dễ chế biến, thường được dùng trong các món như thịt heo bằm xào rau, làm nhân cho các món bánh bao hoặc canh. Món này có hương vị mềm mại và giàu dinh dưỡng", "Thịt heo bằm", "[1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("05cfce09-72b4-482d-adcd-c0718015be3d"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh xèo là món ăn truyền thống với vỏ bánh giòn, nhân tôm, thịt heo, giá đỗ và các loại rau. Món này thường được ăn kèm với nước mắm chua ngọt và rau sống, tạo nên hương vị đậm đà, hấp dẫn", "Bánh xèo", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Bánh mì là món ăn nhanh, phổ biến với lớp vỏ giòn và nhân phong phú như thịt nướng, pate, trứng. Đây là lựa chọn lý tưởng cho bữa sáng hoặc bữa ăn nhẹ, dễ dàng mang theo và rất tiện lợi", "Bánh mì", "[0]", true, "Breakfast,Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau muống là loại rau lá xanh phổ biến ở Việt Nam, có thể xào, luộc hoặc làm canh. Rau muống giàu vitamin, khoáng chất và chất xơ, giúp hỗ trợ tiêu hóa và giải nhiệt", "Rau muống", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún chả cá là món ăn với bún, chả cá chiên hoặc hấp và nước dùng từ cá. Món ăn này có vị ngọt tự nhiên từ cá, rất phổ biến ở miền Trung và Nam Việt Nam", "Bún chả cá", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt gà quay là món ăn có lớp da giòn, thịt mềm, được ướp gia vị rồi quay chín. Món này thường được ăn kèm với cơm hoặc rau sống, rất ngon miệng và dễ ăn", "Thịt gà quay", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Hoành thánh là món ăn từ bột mì, nhân thịt hoặc tôm, thường được nấu trong nước dùng thơm ngon. Món này có thể ăn trong các bữa sáng hoặc bữa tối, mang lại cảm giác ấm cúng và bổ dưỡng", "Hoành thánh", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau dền đỏ là loại rau xanh giàu vitamin C và chất xơ, giúp hỗ trợ tiêu hóa và tăng cường miễn dịch. Rau dền đỏ có thể xào, nấu canh hoặc làm món gỏi, rất bổ dưỡng", "Rau dền đỏ", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Chuối tây là trái cây ngọt, dễ ăn, giàu kali và vitamin. Chuối tây thường được ăn trực tiếp hoặc làm tráng miệng, sinh tố, chè. Đây là món ăn bổ dưỡng và dễ tiêu hóa, thích hợp cho mọi lứa tuổi", "Chuối tây", "[4]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Táo là trái cây giàu vitamin C và chất xơ, tốt cho tiêu hóa và hệ tim mạch. Táo có thể ăn trực tiếp hoặc làm sinh tố, salad, giúp tăng cường sức khỏe và cung cấp năng lượng tự nhiên cho cơ thể", "Táo", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo đậu đỏ là món ăn nhẹ nhàng, làm từ đậu đỏ và gạo, có tác dụng bổ máu, thanh nhiệt. Món này có thể ăn vào buổi sáng hoặc tối, rất bổ dưỡng và dễ tiêu hóa", "Cháo đậu đỏ", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Quýt là trái cây ngọt, chứa nhiều vitamin C và giúp tăng cường hệ miễn dịch. Quýt có thể ăn trực tiếp hoặc làm nước ép, rất tốt cho sức khỏe, đặc biệt là giúp giải nhiệt trong mùa hè", "Quýt", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Đậu hũ là món ăn được làm từ đậu nành, giàu protein thực vật. Đậu hũ có thể chế biến theo nhiều cách như chiên, nấu canh hoặc xào, mang lại hương vị thanh nhẹ và tốt cho sức khỏe", "Đậu hũ", "[1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Nho là trái cây ngọt, giàu vitamin C và chất chống oxy hóa, có tác dụng tăng cường sức đề kháng và làm đẹp da. Nho có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng", "Nho", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Nấm kim châm là loại nấm có thân dài và mỏng, thường được dùng trong các món canh, xào hoặc salad. Nấm kim châm giàu chất xơ và khoáng chất, rất tốt cho sức khỏe, đặc biệt là hệ tiêu hóa", "Nấm kim châm", "[2]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2146faae-2e7c-4460-8d81-38f5d313012c"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo đậu xanh là món ăn nhẹ, dễ tiêu hóa, được làm từ đậu xanh và gạo, có tác dụng bổ máu và thanh nhiệt. Món này có thể ăn vào bữa sáng hoặc tối, rất bổ dưỡng", "Cháo đậu xanh", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh bao chay là món ăn làm từ bột mì, nhân là các loại rau củ, đậu hũ hoặc nấm. Đây là món ăn phù hợp cho những người ăn chay, với hương vị nhẹ nhàng và bổ dưỡng", "Bánh bao chay", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish,MainDish", "Đậu hũ non là món ăn được làm từ đậu nành, có kết cấu mềm mịn. Đậu hũ non có thể chế biến thành các món xào, canh hoặc ăn kèm với siro, là món ăn dễ tiêu hóa và rất bổ dưỡng", "Đậu hũ non", "[1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Khoai lang luộc là món ăn đơn giản nhưng giàu dinh dưỡng, cung cấp vitamin A, chất xơ và khoáng chất. Khoai lang có thể ăn trực tiếp hoặc dùng làm món ăn kèm trong các bữa chính", "Khoai lang luộc", "[0]", true, "Breakfast,Snack,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2405ffc3-524e-4331-9e68-47a411d7b9b8"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm chiên dương châu là món cơm chiên với các loại rau củ, tôm, thịt, trứng, mang đến hương vị đậm đà và đầy đủ dinh dưỡng. Món này thích hợp cho bữa trưa hoặc tối", "Cơm chiên dương châu", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Cải thảo là loại rau xanh, thường được dùng trong các món xào, nấu canh hoặc làm gỏi. Cải thảo chứa nhiều vitamin và khoáng chất, giúp hỗ trợ tiêu hóa và cải thiện sức khỏe", "Cải thảo", "[2]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh bao xá xíu là món bánh mềm mịn, với nhân thịt heo xá xíu thơm ngon. Món này rất phổ biến trong các bữa sáng hoặc bữa ăn nhanh gọn, giàu protein và dễ tiêu hóa", "Bánh bao xá xíu", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("29dfb5da-8818-40ff-bf66-7553521c2161"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bò kho là món ăn với thịt bò hầm mềm mịn, nước dùng đậm đà với gia vị thơm ngon. Món này thường ăn kèm với bánh mì hoặc bún, là bữa ăn đầy đủ và ấm áp", "Bò kho", "[1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ae82bfd-34db-4928-bfee-b60f4aec4460"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh bí đỏ là món ăn thanh mát, giàu vitamin A và C. Canh bí đỏ có thể nấu với thịt heo hoặc tôm, mang lại hương vị ngọt tự nhiên, bổ dưỡng và dễ tiêu hóa", "Canh bí đỏ", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau cải xanh là loại rau giàu vitamin A, C và chất xơ, có thể chế biến thành các món xào, luộc hoặc nấu canh. Món rau cải xanh cung cấp nhiều dưỡng chất và giúp thanh nhiệt cho cơ thể", "Rau cải xanh", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh mì ốp la là món ăn sáng phổ biến với bánh mì giòn, nhân trứng ốp la và có thể kèm thịt, rau. Đây là món ăn nhanh gọn, dễ dàng và bổ dưỡng", "Bánh mì ốp la", "[0,1]", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Dâu tây là trái cây ngọt, chứa nhiều vitamin C và chất chống oxy hóa, giúp làm đẹp da và tăng cường sức đề kháng. Dâu tây có thể ăn trực tiếp, làm sinh tố, hoặc chế biến thành các món tráng miệng", "Dâu tây", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Sữa đậu nành là thức uống từ đậu nành xay nhuyễn, giàu protein và vitamin. Đây là món ăn sáng phổ biến, bổ dưỡng, có thể uống nóng hoặc lạnh, đặc biệt tốt cho người ăn chay và những người muốn bổ sung dưỡng chất từ thực vật", "Sữa đậu nành", "[5,1]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2ee163f7-4463-44ec-b9e2-8a409c112db4"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau luộc là món ăn thanh mát, giúp bổ sung vitamin và khoáng chất, rất tốt cho sức khỏe. Các loại rau như rau muống, rau ngót thường được luộc và ăn kèm với nước mắm hoặc gia vị", "Rau luộc", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo lòng là món ăn sáng phổ biến, được làm từ cháo gạo nấu với các loại nội tạng heo như lòng, gan, dồi. Món này có vị đậm đà, thường ăn kèm với hành lá, rau thơm và gia vị", "Cháo lòng", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Khoai lang là một loại củ giàu vitamin và chất xơ, có thể chế biến thành các món như khoai lang luộc, chiên, hoặc làm món xào. Món này cung cấp năng lượng và rất tốt cho sức khỏe", "Khoai lang", "[0]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("30f9d9dc-1653-495c-99b7-b649c49f7930"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh cuốn thịt bằm là món ăn được làm từ bột gạo, nhân thịt bằm, mộc nhĩ và gia vị, ăn kèm với nước mắm chua ngọt và rau sống. Món này rất phổ biến ở miền Bắc Việt Nam", "Bánh cuốn thịt bằm", "[0,1]", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Cải thìa là loại rau xanh giàu vitamin và khoáng chất, có thể chế biến theo nhiều cách như xào, luộc hoặc nấu canh. Cải thìa giúp giải nhiệt và tốt cho hệ tiêu hóa, thường dùng trong các bữa ăn gia đình", "Cải thìa", "[2]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Súp gà nấm là món ăn nhẹ nhàng với nước dùng từ gà và nấm, giúp thanh nhiệt và dễ tiêu hóa. Món này thường ăn vào bữa sáng hoặc khi cần bồi bổ cơ thể", "Súp gà nấm", "[1,2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Măng khô là món ăn được làm từ măng tươi phơi khô, có thể chế biến thành các món canh hoặc xào. Măng khô có vị ngọt tự nhiên, giòn và là món ăn bổ dưỡng trong các bữa ăn gia đình", "Măng khô", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Nước chanh là thức uống giải khát tuyệt vời, giúp cung cấp vitamin C, giải nhiệt và làm đẹp da. Món này có thể uống vào bất kỳ thời gian nào trong ngày, đặc biệt là trong mùa hè", "Nước chanh", "[5]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3d19d971-88d0-4108-a335-24ac9e1dec50"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Măng cụt là trái cây ngọt, mọng nước, chứa nhiều vitamin C và khoáng chất. Món này có thể ăn trực tiếp hoặc làm nước ép, mang lại cảm giác giải nhiệt và bổ sung dinh dưỡng", "Măng cụt", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3dc2fa80-ab87-4e26-907b-3516611371b8"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh bầu là món canh thanh mát, với bầu nấu cùng nước dùng nhẹ nhàng từ xương hoặc thịt. Món canh này có tác dụng giải nhiệt, rất thích hợp trong những ngày hè nóng bức", "Canh bầu", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Đậu nành luộc là món ăn nhẹ, giàu protein và vitamin. Đậu nành có thể ăn trực tiếp hoặc chế biến thành các món như đậu hũ, giúp bổ sung dinh dưỡng cho cơ thể", "Đậu nành luộc", "[1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("404a286a-90c5-4c54-8e27-3ddeba55ada3"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Hạt dẻ cười là loại hạt giàu chất béo lành mạnh, vitamin E và khoáng chất, giúp bảo vệ tim mạch và cung cấp năng lượng. Hạt dẻ cười có thể ăn trực tiếp hoặc thêm vào các món tráng miệng, salad", "Hạt dẻ cười", "[6,1]", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Đậu bắp là loại rau quả giàu vitamin C và chất xơ, giúp hỗ trợ tiêu hóa và làm đẹp da. Đậu bắp có thể ăn luộc, xào hoặc làm canh, là món ăn bổ dưỡng cho các bữa ăn gia đình", "Đậu bắp", "[2]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Cà chua là thực phẩm giàu vitamin C và chất xơ, có tác dụng làm đẹp da và hỗ trợ tiêu hóa. Cà chua có thể ăn sống, làm salad, hoặc chế biến thành các món xào, canh", "Cà chua", "[2]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("43d635e2-6f0c-4385-83d8-fedfd479d356"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt gà kho là món ăn đậm đà với thịt gà kho trong gia vị như nước mắm, tiêu, và gia vị khác. Món này có thể ăn kèm với cơm trắng, mang lại hương vị ngon miệng và bổ dưỡng", "Thịt gà kho", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Dưa chuột là rau quả tươi mát, giúp giải nhiệt và làm đẹp da. Dưa chuột có thể ăn sống, làm salad, hoặc chế biến thành món xào và canh, rất thích hợp trong các bữa ăn hằng ngày để thanh lọc cơ thể", "Dưa chuột", "[2]", true, "Breakfast,Lunch,Dinner,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún chả là món ăn đặc sản Hà Nội, gồm bún, thịt chả nướng, và rau sống. Món ăn này có nước mắm pha chua ngọt, tạo thành bữa ăn ngon miệng, đậm đà và rất dễ ăn", "Bún chả", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún mắm là món ăn nổi bật với nước dùng từ mắm, kết hợp với bún và các loại hải sản như tôm, cá. Đây là món ăn đặc sản của miền Tây, mang lại hương vị đậm đà và rất thơm ngon", "Bún mắm", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Dừa tươi là thức uống giải khát tuyệt vời, giàu vitamin C và khoáng chất. Nước dừa cung cấp độ ẩm và giúp thanh nhiệt, rất tốt cho làn da và sức khỏe hệ tiêu hóa", "Dừa tươi", "[5]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Tôm hấp là món ăn đơn giản, dễ chế biến, giữ nguyên vị ngọt của tôm. Món này thường được ăn kèm với muối tiêu chanh hoặc nước mắm chua ngọt, thích hợp cho bữa ăn nhẹ", "Tôm hấp", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4e46f955-4413-496f-97b4-968a38ee3e11"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Hạt hướng dương là loại hạt giàu vitamin E, chất béo lành mạnh và protein. Hạt có thể ăn trực tiếp như món snack hoặc thêm vào salad, rất tốt cho sức khỏe tim mạch và giúp cung cấp năng lượng", "Hạt hướng dương", "[6,1]", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("4edcae53-7e30-42bb-8526-7686355f2268"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh cải xanh là món canh nhẹ, giàu vitamin và khoáng chất, thường được nấu với thịt heo hoặc tôm. Đây là món ăn bổ dưỡng, dễ tiêu hóa và thích hợp cho các bữa ăn thanh đạm", "Canh cải xanh", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish,MainDish", "Đậu hũ chiên là món ăn phổ biến trong các bữa ăn chay, có kết cấu giòn bên ngoài và mềm mịn bên trong. Món này có thể ăn kèm với các loại nước chấm hoặc xào với rau củ", "Đậu hũ chiên", "[1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("51061170-597d-4289-a021-1e7dde88331f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt vịt là nguồn protein giàu chất dinh dưỡng, có thể chế biến thành nhiều món như vịt nướng, vịt kho hoặc vịt luộc. Món thịt vịt thường có hương vị đặc trưng, đậm đà và thích hợp cho các bữa ăn gia đình", "Thịt vịt", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bò bít tết là món ăn từ thịt bò nạc, được nướng hoặc áp chảo đến độ chín vừa phải. Món này thường được ăn kèm với khoai tây chiên hoặc rau sống, mang lại hương vị đậm đà, rất thích hợp cho bữa tối", "Bò bít tết", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh chua cá là món ăn đậm đà với nước dùng chua ngọt, thường làm từ cá và các loại rau như giá đỗ, ngò rí, ăn kèm với bún. Món này thanh mát, giải nhiệt và rất bổ dưỡng", "Canh chua cá", "[1,2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rong biển khô là thực phẩm giàu vitamin, khoáng chất và chất xơ, rất tốt cho sức khỏe. Món rong biển có thể dùng làm salad, súp, hoặc làm nhân cho sushi, rất phổ biến trong ẩm thực châu Á", "Rong biển khô", "[2,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Ớt chuông là loại rau quả giàu vitamin C, giúp tăng cường sức khỏe và làm đẹp da. Ớt chuông có thể ăn sống, xào, hoặc làm salad, mang lại hương vị tươi mát và màu sắc đẹp mắt cho bữa ăn", "Ớt chuông", "[2]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Cải bó xôi là rau xanh giàu vitamin A, C và chất sắt. Món cải bó xôi có thể ăn sống trong salad, xào hoặc nấu canh, giúp tăng cường sức khỏe xương và cải thiện hệ miễn dịch", "Cải bó xôi", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("59988378-901f-4ec4-bd6c-9fdc28ca97a1"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Hạt bí ngô là món snack bổ dưỡng, giàu magiê và kẽm, có thể ăn trực tiếp hoặc rắc lên salad. Món này giúp tăng cường hệ miễn dịch và rất tốt cho sức khỏe tim mạch", "Hạt bí ngô", "[6,1]", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm là món ăn chủ yếu trong bữa ăn Việt Nam, cung cấp tinh bột quan trọng. Cơm thường ăn kèm với các món mặn như thịt, cá và rau, tạo nên một bữa ăn đầy đủ dinh dưỡng, bổ sung năng lượng cho cơ thể", "Cơm", "[0]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Lựu là trái cây giàu vitamin C, chất chống oxy hóa và khoáng chất. Món này có thể ăn trực tiếp hoặc làm nước ép, giúp cải thiện hệ miễn dịch và làm đẹp da", "Lựu", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Cá ngừ đóng hộp là món ăn tiện lợi, giàu protein và omega-3. Món này có thể ăn trực tiếp, làm salad hoặc kèm với cơm, rất dễ chế biến và thích hợp cho bữa ăn nhanh", "Cá ngừ đóng hộp", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Súp cua là món ăn nhẹ với nước dùng từ cua, mang hương vị ngọt tự nhiên và bổ dưỡng. Món này thường được ăn vào bữa sáng hoặc bữa tối, rất giàu protein và khoáng chất", "Súp cua", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt kho trứng là món ăn quen thuộc với thịt heo kho cùng trứng luộc, mang hương vị mặn ngọt đậm đà. Món này thường ăn kèm với cơm trắng, rất ngon miệng và bổ dưỡng", "Thịt kho trứng", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Mì Quảng là món đặc sản của miền Trung, gồm mì gạo, nước dùng đậm đà, tôm, thịt hoặc trứng, và rau sống. Món ăn này có vị đặc trưng và rất thích hợp cho bữa sáng hoặc trưa", "Mì Quảng", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Nấm đùi gà có hình dạng giống đùi gà, thịt nấm mềm và thơm. Món này thường được dùng trong các món xào, nấu canh hoặc làm salad, rất giàu dinh dưỡng và dễ chế biến", "Nấm đùi gà", "[2,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh cua mồng tơi là món ăn dân dã, có vị ngọt từ cua và mồng tơi. Món này không chỉ thơm ngon mà còn rất bổ dưỡng, đặc biệt tốt cho hệ tiêu hóa và làn da", "Canh cua mồng tơi", "[1,2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("642480b4-22c9-4350-a6ce-c052f99e60e3"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Lúa mạch là ngũ cốc giàu chất xơ và protein, có thể chế biến thành cháo, bánh hoặc thêm vào các món salad. Lúa mạch giúp cải thiện tiêu hóa và cung cấp năng lượng bền vững cho cơ thể", "Lúa mạch", "[0,1]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau mồng tơi là loại rau xanh giàu vitamin A và chất sắt, có thể chế biến thành các món xào, luộc hoặc canh. Món rau này giúp thanh nhiệt, giải độc và tốt cho hệ tiêu hóa", "Rau mồng tơi", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6487a532-ff5e-4b77-b408-46c789608de9"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh bí đao là món canh mát, giúp giải nhiệt và thanh lọc cơ thể. Bí đao có thể nấu với tôm, thịt heo hoặc cá, mang lại hương vị thanh đạm và rất bổ dưỡng cho sức khỏe", "Canh bí đao", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh rau ngót là món canh thanh mát, có vị ngọt tự nhiên từ rau ngót. Món này thường được nấu với thịt hoặc tôm, giúp giải nhiệt và bổ sung dinh dưỡng cho cơ thể", "Canh rau ngót", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Bánh mì sandwich là món ăn nhanh với lớp bánh mì mềm, nhân có thể là thịt, rau, trứng hoặc phô mai. Đây là lựa chọn lý tưởng cho bữa sáng hoặc bữa phụ, dễ dàng mang theo khi đi làm hoặc đi học", "Bánh mì sandwich", "[0,1]", true, "Breakfast,Lunch,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("68c8c4c4-e5d6-4e15-ad60-1c18f0c1cb4d"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Hạt kê là loại hạt giàu protein, chất xơ và khoáng chất như sắt và magiê. Hạt kê có thể nấu cháo, làm bánh hoặc thêm vào các món salad, là lựa chọn bổ dưỡng cho các bữa ăn nhẹ", "Hạt kê", "[0,1]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Cà phê là thức uống quen thuộc, có thể uống đen hoặc thêm sữa, với hương vị đậm đà và kích thích tinh thần. Cà phê thường được uống vào buổi sáng hoặc trong suốt cả ngày để duy trì sự tỉnh táo", "Cà phê", "[5]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert,SideDish", "Rau má là loại rau mát, giúp thanh nhiệt, giải độc và làm đẹp da. Rau má có thể ăn sống trong salad hoặc nấu canh, rất tốt cho sức khỏe và có tác dụng làm dịu cơ thể trong mùa hè", "Rau má", "[2]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Hủ tiếu là món ăn gồm mì hoặc bún ăn kèm với nước dùng thơm ngon và các loại thịt như tôm, gà, hoặc heo. Món này phổ biến ở miền Nam Việt Nam và rất dễ ăn, thích hợp cho bữa sáng hoặc bữa tối", "Hủ tíu", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo sườn là món ăn sáng phổ biến, với cháo mềm mịn kết hợp cùng sườn heo kho hoặc hầm. Món này có vị ngọt tự nhiên từ xương, thường ăn kèm với hành lá, rau thơm và gia vị", "Cháo sườn", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7167f942-dc89-4f29-8022-588373aef45e"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún gà là món ăn thanh mát với bún, thịt gà luộc hoặc xé nhỏ và nước dùng thơm ngon. Đây là món ăn nhẹ nhàng, thích hợp cho bữa sáng hoặc bữa trưa", "Bún gà", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Canh bún là món ăn nổi bật với nước dùng ngọt từ xương, kết hợp với bún, thịt heo hoặc tôm. Món này thường ăn kèm với rau sống và gia vị, mang lại hương vị đậm đà và dễ ăn", "Canh bún", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Sườn non là phần thịt heo mềm, có thể chế biến thành nhiều món như sườn nướng, sườn kho hoặc sườn xào chua ngọt. Món sườn non rất thích hợp cho các bữa cơm gia đình, có vị đậm đà và dễ ăn", "Sườn non", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("731974ef-495e-4c08-ba95-20589d60c20c"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Hạt mắc ca là loại hạt giàu chất béo lành mạnh, vitamin E và khoáng chất, giúp cải thiện sức khỏe tim mạch. Hạt có thể ăn trực tiếp hoặc thêm vào salad, rất bổ dưỡng và dễ tiêu hóa", "Hạt mắc ca", "[6]", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh bao là món ăn đơn giản, với lớp vỏ mềm mịn và nhân thịt heo hoặc trứng. Đây là món ăn nhanh gọn, thường được ăn sáng hoặc làm món phụ trong các bữa ăn chính", "Bánh bao", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Cà rốt là rau củ giàu vitamin A, giúp cải thiện thị lực và sức khỏe da. Cà rốt có thể ăn sống, làm salad, hoặc chế biến thành các món xào, canh hoặc nước ép", "Cà rốt", "[2]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh mì thịt trứng là món ăn nhanh, với bánh mì mềm, nhân thịt nướng và trứng chiên. Đây là món ăn sáng phổ biến, đơn giản nhưng đầy đủ dinh dưỡng, dễ ăn và tiện lợi", "Bánh mì thịt trứng", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún xào là món ăn ngon miệng với bún xào cùng các loại rau và thịt hoặc tôm. Món này thường được chế biến nhanh, có vị thơm, ngọt từ các nguyên liệu kết hợp, thường ăn vào bữa trưa hoặc tối", "Bún xào", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7729551a-e475-4079-aaa0-07c02efde2a5"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Hạt lanh là nguồn tuyệt vời cung cấp omega-3, chất xơ và lignans, giúp bảo vệ tim mạch và giảm viêm. Hạt lanh có thể thêm vào các món sinh tố, salad hoặc dùng để nướng bánh", "Hạt lanh", "[1]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm tấm sườn là món ăn phổ biến ở miền Nam Việt Nam, bao gồm cơm tấm mềm mịn ăn kèm với sườn nướng và các loại rau sống. Món này mang lại hương vị đậm đà và đầy đủ dinh dưỡng", "Cơm tấm sườn", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7a253877-3c54-4fcf-bb05-d9f4e14d5b64"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Mì xào thập cẩm là món ăn với mì, các loại rau củ và thịt, xào chung với gia vị đậm đà. Món này dễ chế biến và là bữa ăn nhanh gọn nhưng đầy đủ dưỡng chất", "Mì xào thập cẩm", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Măng tây là loại rau giàu vitamin K và chất chống oxy hóa, tốt cho sức khỏe tim mạch và hệ xương. Măng tây có thể xào, nấu canh hoặc ăn sống, rất bổ dưỡng và dễ chế biến", "Măng tây", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Kiwi là trái cây giàu vitamin C, chất xơ và chất chống oxy hóa. Kiwi giúp cải thiện hệ tiêu hóa, tăng cường sức đề kháng và làm đẹp da. Món này có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng", "Kiwi", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Súp bò hầm là món ăn có nước dùng đậm đà từ xương bò, với thịt bò mềm và rau củ đi kèm. Món này cung cấp năng lượng và dưỡng chất, rất phù hợp cho bữa tối", "Súp bò hầm", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7b8500af-d730-4138-9617-cba352faed4a"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Vải là trái cây ngọt, chứa nhiều vitamin C và khoáng chất. Vải có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng, đặc biệt trong mùa hè", "Vải", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7cd76708-7312-445e-a392-14f0e806a786"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Đậu Hà Lan là loại rau giàu vitamin, khoáng chất và chất xơ, giúp hỗ trợ hệ tiêu hóa và tăng cường miễn dịch. Đậu Hà Lan có thể ăn trực tiếp, làm salad hoặc nấu canh", "Đậu Hà Lan", "[1,2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún thịt nướng là món ăn gồm bún mềm, thịt nướng thơm ngon và các loại rau sống. Món này có thể ăn kèm với nước mắm pha, tạo thành một bữa ăn vừa thanh mát vừa đầy đủ dinh dưỡng", "Bún thịt nướng", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Bầu là loại rau quả mát, chứa nhiều vitamin và khoáng chất. Bầu có thể chế biến thành các món canh, xào hoặc làm gỏi, giúp thanh nhiệt và hỗ trợ tiêu hóa", "Bầu", "[2]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Cá ngừ là loại hải sản giàu omega-3 và protein, có thể chế biến thành nhiều món như cá ngừ nướng, cá ngừ kho hoặc làm sushi. Món này rất bổ dưỡng và dễ dàng chế biến", "Cá ngừ", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("827829bf-71cd-4865-80af-1457e0091456"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh nấm là món ăn nhẹ, bổ dưỡng, giàu vitamin và chất xơ. Nấm có thể kết hợp với rau củ hoặc thịt để tạo ra món canh thơm ngon, rất phù hợp cho bữa ăn thanh đạm", "Canh nấm", "[2,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Bông cải xanh (súp lơ) là loại rau chứa nhiều vitamin C, vitamin K và chất chống oxy hóa. Bông cải xanh có thể xào, luộc hoặc làm món canh, là món ăn bổ dưỡng giúp cải thiện sức khỏe", "Bông cải xanh", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8382816f-1beb-4804-9698-3b486798b20a"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh mì chả lụa là món ăn sáng phổ biến, với bánh mì giòn và nhân chả lụa thơm ngon. Món này đơn giản, dễ ăn và thích hợp cho bữa sáng hoặc bữa phụ", "Bánh mì chả lụa", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt kho tiêu là món ăn đơn giản nhưng thơm ngon, thường làm từ thịt ba chỉ hoặc thịt heo kho với tiêu, nước dừa và gia vị. Món này có vị mặn ngọt đậm đà, ăn cùng với cơm trắng rất hợp", "Thịt kho tiêu", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Củ cải trắng là loại rau củ giàu vitamin C và chất xơ, giúp thanh nhiệt và giải độc cơ thể. Món củ cải trắng có thể ăn sống, xào hoặc nấu canh, mang lại hương vị thanh mát và bổ dưỡng", "Củ cải trắng", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Củ cải đường là loại củ chứa nhiều vitamin C và khoáng chất, giúp cải thiện sức khỏe tim mạch và huyết áp. Món củ cải đường có thể ăn sống, xào hoặc nấu canh, mang lại lợi ích cho cơ thể", "Củ cải đường", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Xúc xích là món ăn làm từ thịt xay (thường là thịt heo hoặc bò), tẩm gia vị và nhồi vào ruột lợn, sau đó luộc hoặc nướng. Xúc xích dễ dàng chế biến và là món ăn nhanh gọn cho bữa sáng hoặc bữa phụ", "Xúc xích", "[1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("85e621ed-0e0c-4d20-8891-51d311cea4a3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh thịt bò hầm là món canh đậm đà, với thịt bò hầm mềm cùng các gia vị và rau củ. Món này bổ dưỡng, cung cấp nhiều protein và khoáng chất, thích hợp cho bữa tối hoặc bữa chính", "Canh thịt bò hầm", "[1,2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Ức gà nướng là món ăn ít mỡ, giàu protein, có thể được ướp gia vị và nướng chín. Món này thường được ăn kèm với rau củ hoặc cơm, là lựa chọn tốt cho bữa ăn nhẹ nhàng nhưng đầy đủ dinh dưỡng", "Ức gà nướng", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("86d88717-df08-4de6-b86d-870210864b46"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Thanh long là trái cây ngọt, mát, chứa nhiều vitamin C và khoáng chất, giúp tăng cường sức đề kháng và làm đẹp da. Thanh long có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng", "Thanh long", "[4]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Phở bò viên là món phở nổi tiếng với nước dùng trong, đậm đà từ xương bò, ăn kèm với bánh phở mềm và bò viên. Món này mang lại hương vị thơm ngon, phổ biến cho bữa sáng", "Phở bò viên", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh bí đỏ nấu tôm là món canh nhẹ, thanh mát, với bí đỏ nấu mềm kết hợp với tôm. Món canh này giàu vitamin A và protein, giúp bổ dưỡng và dễ tiêu hóa", "Canh bí đỏ nấu tôm", "[2,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh mùng tơi mướp là món canh mát, giải nhiệt, giúp bổ sung dưỡng chất và hỗ trợ tiêu hóa. Món này thường được nấu với thịt hoặc tôm, mang lại hương vị thanh đạm và bổ dưỡng", "Canh mùng tơi mướp", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Khoai tây là nguồn cung cấp tinh bột và vitamin C. Khoai tây có thể chế biến thành nhiều món như khoai tây chiên, luộc, nghiền hoặc nướng, rất phổ biến trong các bữa ăn gia đình", "Khoai tây", "[0]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh hỏi là món ăn với bánh phở mềm, thường được ăn kèm với thịt nướng hoặc chả, và nước mắm pha. Món này có vị thanh nhẹ, rất phổ biến trong các bữa ăn ở miền Trung", "Bánh hỏi", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Khoai môn là loại củ giàu tinh bột và vitamin C, có thể chế biến thành các món xào, luộc, làm chè hoặc làm nhân bánh. Món khoai môn rất bổ dưỡng và dễ tiêu hóa", "Khoai môn", "[0]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Đậu hũ sốt cà là món ăn chay nhẹ nhàng, với đậu hũ mềm mịn ăn kèm với sốt cà chua đậm đà. Món này cung cấp protein thực vật và rất dễ chế biến, phù hợp cho các bữa ăn chay hoặc ăn kiêng", "Đậu hũ sốt cà", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8ebd5a6e-b0af-42b6-af58-b681fceac1ef"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Chè đậu đen là món tráng miệng phổ biến, làm từ đậu đen nấu nhừ, kết hợp với đường và có thể thêm nước cốt dừa. Món này ngọt mát, giúp thanh nhiệt và rất tốt cho sức khỏe", "Chè đậu đen", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8ed85dc2-7654-4c48-81f9-19946a73f71d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Bắp cải luộc là món ăn thanh mát, dễ làm, chứa nhiều vitamin và khoáng chất. Bắp cải luộc có thể ăn kèm với nước mắm hoặc làm món ăn phụ trong bữa ăn chính", "Bắp cải luộc", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún bò Huế là món ăn nổi tiếng với nước dùng đậm đà từ xương bò, mắm ruốc, và gia vị đặc trưng. Món này kết hợp bún, thịt bò, giò heo và rau sống, tạo nên hương vị thơm ngon, hấp dẫn cho bữa ăn", "Bún bò huế", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún ốc là món ăn nổi bật với nước dùng chua ngọt từ ốc và gia vị, kết hợp với bún và các loại rau sống. Món này có vị thơm ngon, thích hợp cho bữa trưa hoặc tối", "Bún ốc", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("90a605b6-843d-4cc1-8fe7-a016c76ee29c"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau muống luộc là món ăn đơn giản, dễ làm, rất phổ biến ở Việt Nam. Rau muống luộc có thể ăn kèm với nước mắm tỏi ớt hoặc làm món ăn phụ trong bữa cơm, giúp thanh nhiệt và bổ sung dưỡng chất", "Rau muống luộc", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Trà tắc là thức uống giải khát phổ biến, được làm từ trà xanh kết hợp với nước cốt chanh tươi và mật ong. Trà tắc giúp giải nhiệt, thanh lọc cơ thể và mang lại cảm giác sảng khoái", "Trà tắc", "[5]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9349fefa-ecbc-4afc-89f4-62c2f67eb441"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish,MainDish", "Đậu đen là nguồn cung cấp protein thực vật và chất xơ tuyệt vời, giúp cải thiện hệ tiêu hóa. Đậu đen có thể nấu cháo, chè hoặc làm các món xào, rất bổ dưỡng cho sức khỏe", "Đậu đen", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Phở bò tái là món phở nổi tiếng với nước dùng trong, đậm đà từ xương bò, ăn kèm với thịt bò tái và bánh phở mềm. Món ăn này rất phổ biến vào buổi sáng ở Việt Nam, mang lại cảm giác ấm cúng và no lâu", "Phở bò tái", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh mì chả cá là món ăn sáng quen thuộc, với bánh mì mềm, nhân chả cá chiên thơm ngon và rau sống. Món này rất phổ biến ở Việt Nam, tiện lợi và dễ ăn", "Bánh mì chả cá", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Đậu que là loại rau quả giàu vitamin và chất xơ, có thể chế biến thành các món xào, luộc hoặc nấu canh. Đậu que giúp tăng cường hệ tiêu hóa và cung cấp năng lượng cho cơ thể", "Đậu que", "[2]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("982d8f3e-f517-4bd2-87a8-48329fc9eb91"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh cải ngọt là món ăn nhẹ nhàng, với cải ngọt nấu trong nước dùng, có thể kết hợp với thịt heo hoặc tôm. Món canh này bổ dưỡng, dễ tiêu hóa và giúp thanh nhiệt", "Canh cải ngọt", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Sữa bò tươi là thức uống bổ dưỡng, cung cấp canxi, vitamin D và protein. Sữa bò có thể uống trực tiếp hoặc làm nguyên liệu cho các món sinh tố, mang lại nhiều lợi ích cho sức khỏe xương", "Sữa bò tươi", "[5]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau cải bó xôi là loại rau xanh chứa nhiều vitamin A, C và chất sắt. Món cải bó xôi có thể ăn sống trong salad, xào hoặc nấu canh, rất bổ dưỡng và tốt cho sức khỏe xương", "Rau cải bó xôi", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau chân vịt (cải bó xôi) là loại rau giàu vitamin A, C và chất sắt, giúp tăng cường sức khỏe xương và hỗ trợ miễn dịch. Rau chân vịt có thể ăn sống trong salad, xào hoặc nấu canh", "Rau chân vịt", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau muống xào tỏi là món ăn phổ biến, với rau muống tươi xào cùng tỏi và gia vị. Món này có vị đậm đà, thơm ngon, rất thích hợp ăn kèm với cơm trắng", "Rau muống xào tỏi", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Cải ngọt luộc là món rau luộc đơn giản, dễ làm, giàu vitamin và chất xơ. Món này thường ăn kèm với nước mắm chua ngọt hoặc làm món ăn phụ trong các bữa ăn chính", "Cải ngọt luộc", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Gạo lứt là loại gạo nguyên hạt, giàu chất xơ, vitamin và khoáng chất. Món gạo lứt có thể ăn kèm với các món thịt hoặc rau, giúp duy trì năng lượng lâu dài và rất tốt cho hệ tiêu hóa", "Gạo lứt", "[0]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Cam là trái cây giàu vitamin C, giúp tăng cường miễn dịch và làm đẹp da. Cam có thể ăn trực tiếp hoặc làm nước ép, giúp giải nhiệt và bổ sung dinh dưỡng cho cơ thể", "Cam", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Sữa chua là món ăn từ sữa lên men, chứa nhiều vi khuẩn có lợi cho hệ tiêu hóa. Sữa chua có thể ăn trực tiếp hoặc làm thành các món tráng miệng, bổ dưỡng và dễ tiêu hóa", "Sữa chua", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a1ff09f1-9d02-40a8-84de-8da9aad67c58"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm rang là món ăn phổ biến, làm từ cơm nguội chiên với gia vị và các nguyên liệu như thịt, rau, trứng. Món này nhanh gọn, dễ chế biến và có thể ăn kèm với dưa leo hoặc salad", "Cơm rang", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá hồi hun khói là món ăn giàu omega-3, có hương vị đậm đà và thơm ngon từ quá trình hun khói. Món này thường được ăn kèm với bánh mì hoặc làm thành salad, rất bổ dưỡng và dễ ăn", "Cá hồi hun khói", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm gạo lức được làm từ gạo lức chưa xay xát hoàn toàn, giàu chất xơ và dinh dưỡng. Món này cung cấp năng lượng lâu dài, tốt cho sức khỏe và rất phổ biến trong các bữa ăn hàng ngày", "Cơm gạo lức", "[0]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Xoài là trái cây ngọt, thơm, giàu vitamin C và chất xơ. Xoài có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng", "Xoài", "[4]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a364353c-d589-4a94-9c3b-3038113ea249"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bò xào rau củ là món ăn ngon với thịt bò thái mỏng xào nhanh với các loại rau củ như ớt, hành tây, cà rốt. Món này cung cấp nhiều vitamin và protein, thích hợp cho bữa tối bổ dưỡng", "Bò xào rau củ", "[1,2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún riêu cua là món ăn nổi tiếng với nước dùng chua ngọt, kết hợp với cua, bún và các loại rau sống. Món ăn này mang hương vị đặc trưng và bổ dưỡng, phù hợp cho bữa trưa hoặc tối", "Bún riêu cua", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Nước dừa là thức uống mát từ nước bên trong quả dừa, giúp giải nhiệt và bổ sung khoáng chất. Nó cũng rất tốt cho làn da và hệ tiêu hóa, thích hợp để uống trong mùa hè", "Nước dừa", "[5]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a504d882-4f38-413e-bb28-fae1f2787150"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Nhãn là trái cây ngọt, mọng nước, chứa nhiều vitamin C và giúp tăng cường sức đề kháng. Nhãn có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng, rất tốt cho sức khỏe", "Nhãn", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Mực là hải sản giàu protein và khoáng chất, có thể chế biến thành các món xào, hấp, hoặc nướng. Mực có vị ngọt tự nhiên, giúp bổ sung dinh dưỡng và rất dễ ăn", "Mực", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 27 },
                    { new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt lợn xông khói có vị mặn ngọt, được chế biến bằng cách xông khói để tạo hương vị đặc trưng. Món này có thể ăn kèm với cơm, salad hoặc làm nhân cho bánh mì", "Thịt lợn xông khói", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt bò nạc là phần thịt ít mỡ, giàu protein và sắt, có thể chế biến thành các món như bò xào, nướng hoặc làm súp. Món ăn này cung cấp năng lượng và dưỡng chất cho cơ thể, thích hợp cho các bữa chính", "Thịt bò nạc", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish,MainDish", "Lòng đỏ trứng gà là phần chứa nhiều chất béo, protein và vitamin, rất tốt cho sự phát triển của cơ thể. Lòng đỏ trứng gà thường được sử dụng trong các món ăn như trứng bác, bánh hoặc các món ăn kèm", "Lòng đỏ trứng gà", "[1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Mâm xôi là trái cây giàu vitamin C và chất chống oxy hóa, có tác dụng tốt cho hệ miễn dịch và làn da. Mâm xôi có thể ăn trực tiếp hoặc làm sinh tố, chè, tráng miệng", "Mâm xôi", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Súp khoai tây là món canh ngon và bổ dưỡng, với khoai tây nấu mềm trong nước dùng nhẹ nhàng. Món này thích hợp cho bữa tối, mang lại cảm giác ấm áp và dễ tiêu hóa", "Súp khoai tây", "[0]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a988cc73-072e-4af1-9b53-55fbf0f4fe79"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Rau xào là món ăn đơn giản với rau củ được xào nhanh với gia vị. Món này thường sử dụng các loại rau như cải thảo, cải ngọt, giúp cung cấp vitamin và khoáng chất cho cơ thể", "Rau xào", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Chuối là trái cây ngọt, dễ ăn, cung cấp vitamin C và kali. Chuối rất tốt cho hệ tiêu hóa và tim mạch. Món này thường được ăn trực tiếp, làm sinh tố hoặc chế biến thành các món tráng miệng như chè", "Chuối", "[4]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Đào là trái cây ngọt, mọng nước, chứa nhiều vitamin C và chất chống oxy hóa. Món này có thể ăn trực tiếp, làm sinh tố hoặc chế biến thành các món tráng miệng, giúp tăng cường sức đề kháng", "Đào", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Bún là món ăn phổ biến ở Việt Nam, được chế biến từ gạo. Bún có thể kết hợp với các loại thịt, cá, hoặc rau, tạo thành những món như bún riêu, bún chả, bún bò Huế, mang lại hương vị đặc trưng", "Bún", "[0]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 100 },
                    { new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Ức vịt nướng là món ăn ngon miệng, thịt vịt mềm và mọng nước khi được ướp gia vị và nướng chín. Món này có thể ăn kèm với cơm hoặc rau sống, mang lại hương vị đậm đà", "Ức vịt nướng", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá thu nướng là món ăn thơm ngon, giàu protein và omega-3. Cá thu thường được ướp gia vị rồi nướng, tạo nên món ăn đậm đà và bổ dưỡng cho bữa tối", "Cá thu nướng", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("af036922-79f3-45a7-b562-a6279520c0e6"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Miến gà là món ăn nhẹ với miến mềm, nước dùng thơm ngon từ gà, ăn kèm với thịt gà xé nhỏ. Món này rất dễ ăn, thích hợp cho bữa sáng hoặc bữa trưa nhẹ nhàng", "Miến gà", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Đu đủ là trái cây ngọt, giàu vitamin C và enzym papain, giúp tiêu hóa tốt. Đu đủ có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng, rất tốt cho sức khỏe và làn da", "Đu đủ", "[4]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b0f051be-5972-4e7a-a77d-47ec28d58993"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Snack", "Hạt hạnh nhân là loại hạt giàu chất béo lành mạnh, vitamin E và protein. Hạnh nhân có thể ăn trực tiếp, làm snack hoặc thêm vào các món salad, mang lại lợi ích cho sức khỏe tim mạch", "Hạt hạnh nhân", "[6,1]", true, "Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Đậu hà lan luộc là món ăn giàu protein và chất xơ, có thể ăn trực tiếp hoặc chế biến thành salad. Món này có vị ngọt tự nhiên, rất bổ dưỡng và dễ chế biến", "Đậu Hà Lan luộc", "[1,2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh rau dền là món ăn nhẹ nhàng, thanh mát, thường được nấu với thịt hoặc tôm. Rau dền chứa nhiều vitamin và khoáng chất, giúp cải thiện sức khỏe và hỗ trợ tiêu hóa", "Canh rau dền", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá kho là món ăn đậm đà với cá kho trong nước mắm, tiêu và các gia vị khác. Món này có thể ăn kèm với cơm trắng, mang lại hương vị mặn ngọt và rất bổ dưỡng", "Cá kho", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt heo kho là món ăn với thịt heo được kho mềm, thấm đẫm gia vị mặn ngọt. Món này thường ăn kèm với cơm trắng, tạo thành một bữa ăn đậm đà và bổ dưỡng", "Thịt heo kho", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm chiên là món ăn phổ biến, được làm từ cơm nguội chiên cùng với thịt, trứng và rau củ. Món này thường ăn kèm với dưa leo hoặc salad, rất dễ ăn và tiện lợi", "Cơm chiên", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt gà là nguồn protein nhẹ nhàng, giàu dinh dưỡng. Thịt gà có thể chế biến thành nhiều món như gà kho, gà luộc, hoặc gà xào. Đây là lựa chọn phổ biến trong các bữa ăn hàng ngày", "Thịt gà", "[1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh bèo là món ăn dân dã của miền Trung, gồm bánh làm từ bột gạo, thường được phủ lên trên các loại tôm, thịt hoặc mỡ hành. Món này có thể ăn kèm với nước mắm chua ngọt", "Bánh bèo", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Bắp luộc là món ăn đơn giản nhưng bổ dưỡng, chứa nhiều chất xơ và vitamin. Bắp luộc có thể ăn trực tiếp hoặc làm món ăn kèm trong bữa ăn, đặc biệt là vào mùa hè", "Bắp luộc", "[0]", true, "Snack,Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish,MainDish", "Trứng gà luộc là món ăn đơn giản, giàu protein, vitamin B12 và khoáng chất. Trứng gà thường được ăn sáng hoặc dùng làm món phụ trong bữa ăn chính, giúp cung cấp năng lượng và duy trì sức khỏe", "Trứng gà luộc", "[1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Yến mạch là ngũ cốc giàu chất xơ và vitamin, giúp giảm cholesterol và hỗ trợ tiêu hóa. Món yến mạch có thể nấu cháo hoặc làm sinh tố, thích hợp cho bữa sáng bổ dưỡng", "Yến mạch", "[0,1]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c5e3e4ed-0164-4917-a1ce-99679b971a22"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo gà là món ăn nhẹ, với cháo mịn và thịt gà chín mềm, thường ăn kèm với hành lá, rau thơm và gia vị. Món này dễ tiêu hóa, phù hợp cho bữa sáng hoặc khi bạn cảm thấy mệt mỏi", "Cháo gà", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh rau củ là món ăn nhẹ nhàng, giàu vitamin và chất xơ, thích hợp cho các bữa ăn dinh dưỡng. Các loại rau như cà rốt, khoai tây, đậu que được nấu chung tạo thành món canh thơm ngon, dễ ăn", "Canh rau củ", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c81a404a-ec10-428e-acec-dd56ec1d3607"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Nem chua là món ăn đặc sản, được làm từ thịt heo xay nhuyễn, gia vị và gói trong lá chuối, lên men tự nhiên. Món này có vị chua nhẹ, thơm ngon, thường ăn kèm với tỏi, ớt hoặc rau sống", "Nem chua", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Mì gạo lứt được làm từ gạo lứt nguyên hạt, giàu chất xơ và vitamin. Món mì này có thể chế biến thành các món xào, soup hoặc ăn kèm với thịt, rất tốt cho sức khỏe và giúp giảm cholesterol", "Mì gạo lứt", "[0]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Chôm chôm là trái cây ngọt, có vỏ đỏ hoặc vàng, mọng nước và giàu vitamin C. Món này rất thích hợp trong mùa hè, giúp giải nhiệt và bổ sung dinh dưỡng", "Chôm chôm", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Hồng xiêm là trái cây ngọt, có hương vị đặc trưng, giàu vitamin C và khoáng chất. Món này có thể ăn trực tiếp hoặc chế biến thành các món tráng miệng, sinh tố, rất tốt cho sức khỏe", "Hồng xiêm", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("cf9ab10f-2094-496b-9018-96b9d2e1af76"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm gà là món ăn đơn giản với cơm trắng ăn kèm thịt gà luộc hoặc chiên, thường được dùng kèm với nước mắm, rau sống và canh. Món này ngon miệng, dễ chế biến và bổ dưỡng", "Cơm gà", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh hẹ tôm là món canh thanh mát, với tôm và hẹ nấu chung trong nước dùng thơm ngon. Món này giúp bổ sung protein và vitamin, rất dễ ăn và thích hợp cho các bữa ăn nhẹ", "Canh hẹ tôm", "[1,2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cơm chiên trứng là món ăn đơn giản nhưng ngon miệng, được làm từ cơm nguội xào cùng trứng, có thể thêm các loại rau và thịt tùy thích. Món này phù hợp cho bữa trưa hoặc tối nhanh gọn và đầy đủ dinh dưỡng", "Cơm chiên trứng", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Sữa chua Hy Lạp là loại sữa chua đặc, chứa nhiều probiotics giúp hỗ trợ tiêu hóa. Món này có thể ăn trực tiếp hoặc kết hợp với trái cây tươi, mang lại cảm giác ngon miệng và bổ dưỡng", "Sữa chua Hy Lạp", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Thịt lợn nạc là phần thịt ít mỡ, dễ chế biến thành các món như xào, kho hoặc nướng. Món này cung cấp protein và chất sắt, thường được ăn trong các bữa chính", "Thịt lợn nạc", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá thu là loại hải sản giàu omega-3 và protein, rất tốt cho sức khỏe tim mạch. Cá thu có thể nướng, chiên hoặc kho, mang lại hương vị thơm ngon và bổ dưỡng cho bữa ăn", "Cá thu", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh canh là món ăn nổi bật với nước dùng đậm đà, có thể làm từ bún hoặc bánh canh, ăn kèm với các loại thịt như cua, tôm, hoặc giò heo. Món này rất phổ biến ở miền Trung và Nam Việt Nam", "Bánh canh", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh bột lọc là món ăn đặc trưng của miền Trung, gồm vỏ bánh làm từ bột năng, nhân tôm hoặc thịt, sau đó hấp chín. Món này thường ăn kèm với nước mắm chua ngọt và rau sống", "Bánh bột lọc", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bún hải sản là món ăn đậm đà với bún, nước dùng từ hải sản và các loại hải sản như tôm, cua, mực. Món này có hương vị đặc trưng và rất bổ dưỡng", "Bún hải sản", "[0,1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Dưa cải chua là món ăn lên men, được làm từ cải thảo hoặc cải bẹ, mang vị chua nhẹ. Món này thường ăn kèm với cơm, giúp hỗ trợ tiêu hóa và bổ sung lợi khuẩn cho hệ tiêu hóa", "Dưa cải chua", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Phở gà là món ăn nhẹ nhàng, nước dùng thơm từ gà, ăn kèm với bánh phở và thịt gà. Món này có thể ăn vào buổi sáng hoặc bữa tối, rất thanh đạm nhưng đầy đủ dinh dưỡng", "Phở gà", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Hành tây là loại củ gia vị phổ biến, mang lại hương vị thơm ngon cho các món xào, canh hoặc salad. Hành tây có tác dụng tốt cho sức khỏe tim mạch và giúp cải thiện hệ tiêu hóa", "Hành tây", "[2]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Chả lụa là món ăn được làm từ thịt heo xay nhuyễn, cuộn chặt và hấp chín. Món này thường dùng trong các bữa ăn chính, bánh mì hoặc cơm, mang lại hương vị ngọt mềm, thơm ngon", "Chả lụa", "[1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Cá khô là món ăn truyền thống, có thể làm từ nhiều loại cá, chế biến bằng cách phơi khô. Cá khô có vị mặn, thơm, thường được ăn kèm với cơm trắng hoặc làm nguyên liệu cho các món canh", "Cá khô", "[1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Ức gà là phần thịt ít mỡ, giàu protein và dễ chế biến. Món ức gà có thể nướng, xào, hấp hoặc luộc, cung cấp năng lượng và dưỡng chất cho cơ thể, phù hợp với bữa trưa hoặc tối", "Ức gà", "[1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Nước cam là thức uống từ cam tươi, cung cấp vitamin C và chất chống oxy hóa. Nước cam là lựa chọn tuyệt vời để giải khát và bổ sung dưỡng chất cho cơ thể, đặc biệt trong mùa lạnh", "Nước cam", "[5]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Cà phê sữa là thức uống phổ biến ở Việt Nam, được pha chế từ cà phê đen đặc kết hợp với sữa đặc ngọt. Món này có vị đắng nhẹ kết hợp với ngọt béo, thích hợp để uống vào buổi sáng để khởi đầu ngày mới", "Cà phê sữa", "[5]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh canh cua là món ăn đặc trưng với nước dùng đậm đà từ cua, ăn kèm với bánh canh mềm và các loại rau. Món này rất phổ biến ở miền Nam và mang lại hương vị thơm ngon, bổ dưỡng", "Bánh canh cua", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Xôi bắp là món ăn sáng đơn giản, được làm từ gạo nếp và bắp, có vị ngọt tự nhiên của ngô. Món này dễ ăn, cung cấp năng lượng cho cả ngày dài, thường được ăn kèm với thịt hoặc các món mặn khác", "Xôi bắp", "[0]", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo vịt là món cháo nấu với thịt vịt, có vị ngọt tự nhiên từ thịt và xương vịt. Món này thường được ăn vào bữa sáng hoặc bữa tối, giúp cung cấp năng lượng và dưỡng chất", "Cháo vịt", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e370081a-c0a6-4c00-b01c-7c52f953b7f1"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Canh mướp là món ăn thanh mát với mướp nấu trong nước dùng nhẹ nhàng từ xương hoặc thịt. Món canh này có tác dụng giải nhiệt, rất thích hợp vào mùa hè", "Canh mướp", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Lê là trái cây ngọt mát, giàu vitamin C và chất xơ, giúp cải thiện hệ tiêu hóa và làm đẹp da. Lê có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng", "Lê", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Tôm là hải sản giàu protein, omega-3 và vitamin, rất tốt cho sức khỏe tim mạch. Tôm có thể chế biến thành nhiều món ăn như xào, hấp, hoặc nấu canh, tạo hương vị tươi ngon cho bữa ăn", "Tôm", "[1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo sườn non là món ăn thơm ngon, với cháo được nấu từ xương sườn heo, có vị ngọt tự nhiên từ xương. Món này thường được ăn kèm với hành phi và gia vị, thích hợp cho bữa sáng", "Cháo sườn non", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Soup", "Súp hải sản là món ăn đậm đà với nước dùng từ hải sản như tôm, cua, mực, nấu cùng với rau củ và gia vị. Món này rất bổ dưỡng và thích hợp cho các bữa ăn chính", "Súp hải sản", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Dưa hấu là trái cây giải nhiệt, chứa nhiều nước và vitamin C. Đây là món ăn lý tưởng trong mùa hè, giúp cung cấp nước và dưỡng chất cho cơ thể, có thể ăn trực tiếp hoặc làm sinh tố", "Dưa hấu", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cá hồi nướng là món ăn bổ dưỡng, giàu omega-3 và protein, thường được ướp gia vị trước khi nướng. Món này có hương vị ngọt tự nhiên, thích hợp ăn kèm với rau sống hoặc cơm", "Cá hồi nướng", "[1]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("eec3d874-6331-4e33-bbe6-bf0cc4335b29"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Salad rau là món ăn nhẹ, là sự kết hợp của các loại rau tươi như xà lách, cà chua, dưa leo, trộn với nước sốt chua ngọt hoặc dầu olive. Món này bổ dưỡng, giàu vitamin và chất xơ", "Salad rau", "[2]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh bao trứng cút là món bánh bao với nhân thịt heo hoặc đậu xanh, kèm trứng cút. Bánh có vỏ mềm, nhân thơm ngon, thường được ăn sáng hoặc làm món ăn phụ trong các bữa ăn chính", "Bánh bao trứng cút", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh cuốn là món ăn làm từ bột gạo, nhân thường là thịt băm, nấm hoặc trứng. Bánh cuốn mềm mịn, ăn kèm với nước mắm và rau sống, thường được dùng trong bữa sáng hoặc bữa phụ", "Bánh cuốn", "[0,1]", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Mận là trái cây ngọt, mọng nước, chứa nhiều vitamin C và chất chống oxy hóa, giúp tăng cường sức đề kháng và làm đẹp da. Mận có thể ăn trực tiếp hoặc làm sinh tố, chè", "Mận", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f41484a3-c7df-4530-b7d2-060390103985"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish,MainDish", "Lòng trắng trứng gà chứa nhiều protein và ít chất béo, rất tốt cho sức khỏe. Lòng trắng trứng có thể chế biến thành các món như trứng luộc, trứng chưng, hoặc làm nguyên liệu trong các món ăn khác", "Lòng trắng trứng gà", "[1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Xôi mặn là món ăn từ gạo nếp, kết hợp với thịt, lạp xưởng hoặc trứng. Món này thường được ăn vào buổi sáng hoặc trong các dịp đặc biệt, rất bổ dưỡng và dễ ăn", "Xôi mặn", "[0,1]", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Drink", "Sữa hộp Milo là thức uống bổ dưỡng chứa nhiều vitamin và khoáng chất, phù hợp cho trẻ em và người lớn. Milo có hương vị ngọt ngào, thường được uống vào bữa sáng hoặc giữa các bữa ăn", "Sữa hộp milo", "[5]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Ổi là trái cây giàu vitamin C, giúp tăng cường hệ miễn dịch và làm đẹp da. Ổi có thể ăn trực tiếp hoặc làm sinh tố, nước ép, rất tốt cho sức khỏe, đặc biệt là trong việc hỗ trợ tiêu hóa", "Ổi", "[4]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Cháo thịt bằm là món cháo có thịt heo xay nhuyễn, nấu cùng với gạo và gia vị. Món này bổ dưỡng, dễ ăn và dễ tiêu hóa, thích hợp cho bữa sáng hoặc bữa ăn nhẹ", "Cháo thịt bằm", "[0,1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Sữa chua nha đam là món tráng miệng được làm từ sữa chua và nha đam tươi, giúp làm đẹp da và hỗ trợ tiêu hóa. Món này mát, dễ ăn và rất tốt cho sức khỏe, đặc biệt là trong thời tiết nóng", "Sữa chua nha đam", "[4]", true, "Snack,Breakfast", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("faf19891-525a-4308-9222-992e83de7ce7"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish,SideDish", "Cá hồi là loại hải sản giàu omega-3, tốt cho sức khỏe tim mạch. Cá hồi có thể chế biến thành nhiều món như nướng, hấp, hoặc làm sushi, mang lại hương vị tươi ngon và bổ dưỡng", "Cá hồi", "[1]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "MainDish", "Bánh ướt là món ăn nhẹ làm từ bột gạo, có kết cấu mềm mịn, thường được ăn kèm với thịt heo, chả lụa và rau sống. Món này có thể được rưới nước mắm chua ngọt, mang lại hương vị thơm ngon và thanh mát", "Bánh ướt", "[0,1]", true, "Breakfast,Lunch", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Mướp là loại rau quả mát, chứa nhiều nước và vitamin. Mướp có thể chế biến thành canh, xào hoặc làm món gỏi, giúp thanh nhiệt, giải độc và tốt cho hệ tiêu hóa", "Mướp", "[2]", true, "Breakfast,Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "Dessert", "Chuối tiêu là trái cây ngọt nhẹ, giàu kali và vitamin C, giúp hỗ trợ tiêu hóa và cung cấp năng lượng. Chuối tiêu có thể ăn trực tiếp hoặc chế biến thành các món tráng miệng như chè chuối hấp", "Chuối tiêu", "[4]", true, "Breakfast,Snack", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 },
                    { new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), "SideDish", "Bắp cải tím là loại rau giàu vitamin C và chất xơ, có thể chế biến thành salad, xào hoặc nấu canh. Món bắp cải tím giúp giải độc, hỗ trợ tiêu hóa và tốt cho sức khỏe tim mạch", "Bắp cải tím", "[2]", true, "Lunch,Dinner", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"), 0 }
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
                    { new Guid("00e4d081-d530-4fcc-91ec-35bb59b08ed4"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), null },
                    { new Guid("0402a3c7-c6d8-48fe-a03e-8bbab2792e7b"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), null },
                    { new Guid("06549d88-0bc7-41ec-bfde-ce087d6d12fb"), new Guid("0eec9d43-391c-43c6-9635-01ca2d6fc66c"), null, new Guid("404a286a-90c5-4c54-8e27-3ddeba55ada3"), null },
                    { new Guid("10c46180-b9e7-405c-9fa5-79da5bfe706f"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), null },
                    { new Guid("119104a3-4bde-4c0b-85df-6960931a7ff1"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), null },
                    { new Guid("14ac2caa-d74b-4a28-8d14-cee0e156b638"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), null },
                    { new Guid("1ba46cb8-a791-4c14-accb-b9ec8049becf"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), null },
                    { new Guid("1ed5d2e7-a78c-4419-a793-f5fbbbd8dd7f"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), null },
                    { new Guid("1ef05e68-2474-4066-9a32-3c83d429ffd2"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), null },
                    { new Guid("204ad7fe-468e-430a-98cc-c623b9abb453"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("f41484a3-c7df-4530-b7d2-060390103985"), null },
                    { new Guid("274f9f3c-47e0-4b37-831a-4a51456c3a99"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), null },
                    { new Guid("2f8a6776-a771-4ded-b4d0-41880bf8442f"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), null },
                    { new Guid("33d2f16f-d4b2-4797-8313-95c63553657e"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("a1ff09f1-9d02-40a8-84de-8da9aad67c58"), null },
                    { new Guid("3caf9ce7-4dfc-4a41-a994-c06be1717fae"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), null },
                    { new Guid("40c1e7e4-7352-4eeb-8a87-b1e3d5eda73a"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), null },
                    { new Guid("439d3f6f-cf73-49ee-82a8-a507c8ec5ea2"), new Guid("0eec9d43-391c-43c6-9635-01ca2d6fc66c"), null, new Guid("b0f051be-5972-4e7a-a77d-47ec28d58993"), null },
                    { new Guid("43ec8000-e8ad-4e1c-a4c1-fd1061786a9c"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), null },
                    { new Guid("43f08a4f-e2e5-421a-9c31-471aedb1b6d2"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), null },
                    { new Guid("4604c735-a709-48e4-bcfe-5a959b3835de"), new Guid("0eec9d43-391c-43c6-9635-01ca2d6fc66c"), null, new Guid("731974ef-495e-4c08-ba95-20589d60c20c"), null },
                    { new Guid("492da15e-8897-4a95-97db-d13b6c68d264"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), null },
                    { new Guid("4d25bc02-009d-48a7-8cd8-1cf8db63ceee"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), null },
                    { new Guid("4edd79e7-6ef6-4b71-b7b8-29462d5e54c0"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), null },
                    { new Guid("55151210-5503-4857-b127-042e054e5150"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), null },
                    { new Guid("5641c232-6d43-4618-804d-8a4795ba19bc"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), null },
                    { new Guid("5cc046ff-dd07-47b8-a801-5ad8d8eb5d4b"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), null },
                    { new Guid("5f032c13-150c-4e99-afbb-90ecc6ada65d"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), null },
                    { new Guid("5fa329ea-de70-4ec3-8107-78d7ca5033ea"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), null },
                    { new Guid("6078b4e4-c5c8-42d2-960b-fbcd221fe330"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), null },
                    { new Guid("6ce282fa-e5dd-424e-8625-d757a013a875"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), null },
                    { new Guid("6d043abd-b0ac-43b2-8d09-f36f1f87a5be"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), null },
                    { new Guid("6eac30f2-9e0e-4e19-a788-e0b8be1538f1"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), null },
                    { new Guid("7230fea5-59f0-46b3-8677-275c0e41b010"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("05cfce09-72b4-482d-adcd-c0718015be3d"), null },
                    { new Guid("72db2287-6101-4ee7-a7d1-04f083e6eb04"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), null },
                    { new Guid("74b2c3ef-c95e-4402-a090-632083034b00"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), null },
                    { new Guid("79829e02-f7b0-440b-82d8-2af25cc6349e"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), null },
                    { new Guid("7bacd0df-e9f9-4ad7-8e23-aafd15e27ead"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), null },
                    { new Guid("7d29590a-382d-453f-996f-068b74024a9d"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), null },
                    { new Guid("8271aaf1-87f1-4677-bdf0-f99a87d2c4fb"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), null },
                    { new Guid("8729079d-56b5-42e3-8482-f8ecad345930"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), null },
                    { new Guid("89ca29b5-9457-457a-9cb3-27edce49fc9b"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), null },
                    { new Guid("8a917141-da79-4462-80ec-529ea923aa09"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), null },
                    { new Guid("9034ab66-f700-44d0-9add-c42c3b5f996b"), new Guid("ea406418-19d1-43dc-96a2-9abf97b9d2a5"), null, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), null },
                    { new Guid("988651b7-57f1-4c17-a2ea-75a43ccd0119"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), null },
                    { new Guid("9bf2b6e2-7030-476c-b57c-1f80abab6f1a"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), null },
                    { new Guid("9d4cac6f-111c-47b4-a234-0d3fbf0fb184"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), null },
                    { new Guid("9e413391-1e07-4ff5-84f2-4fd32776d8d6"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), null },
                    { new Guid("a028c4ba-50a1-4ddc-a764-55e21bf5b421"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), null },
                    { new Guid("a6fc2246-f26a-48e3-b12e-3ff51e0a1b4b"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("faf19891-525a-4308-9222-992e83de7ce7"), null },
                    { new Guid("ad66eab9-95fa-494d-b0c5-ed87ccacfa6c"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), null },
                    { new Guid("b56ed337-5c1b-420f-818c-f1e3629c5009"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), null },
                    { new Guid("ba29f76a-a041-479d-9e9a-8d39d859c58c"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), null },
                    { new Guid("bd82b146-6ba5-445c-ac75-20d0a350d6c9"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), null },
                    { new Guid("beaa068e-9947-4775-8cb4-3a06c342d838"), new Guid("0eec9d43-391c-43c6-9635-01ca2d6fc66c"), null, new Guid("4e46f955-4413-496f-97b4-968a38ee3e11"), null },
                    { new Guid("bfb2c252-80f3-424d-b4f4-fa4c42a24172"), new Guid("0eec9d43-391c-43c6-9635-01ca2d6fc66c"), null, new Guid("59988378-901f-4ec4-bd6c-9fdc28ca97a1"), null },
                    { new Guid("c5d3857f-4959-457a-a9bf-3e326bec131b"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), null },
                    { new Guid("cb59de0a-6eb7-44d9-922a-390dbc050cd2"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), null },
                    { new Guid("cc73fe37-bbd7-4759-89c8-bc28b77e196c"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), null },
                    { new Guid("d2a17c4d-b218-41d5-a189-380d44ad67f7"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), null },
                    { new Guid("d53742ca-0a35-4cba-866b-808e58c7c434"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), null },
                    { new Guid("d641931c-0c7e-4d2c-86c5-9251347eca48"), new Guid("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"), null, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), null },
                    { new Guid("e1464c0f-a865-47c8-809f-237f6423060f"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), null },
                    { new Guid("e1c4274f-f0ed-499d-ba04-621bb37ed7da"), new Guid("1ada29ad-354a-44aa-b402-3f8a9c854e56"), null, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), null },
                    { new Guid("e366d53f-a249-4727-b8be-8bb97e12c61c"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), null },
                    { new Guid("edf4e669-4b38-4e37-a9aa-bb279224ba09"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), null },
                    { new Guid("f676c7ef-0ca4-4d19-972d-882529809b8f"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), null },
                    { new Guid("f7ccf592-50ca-4462-a654-785ca4514fe5"), new Guid("c87bd979-3dde-4a47-9f1c-7eef88c6c041"), null, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), null },
                    { new Guid("f8148202-7fae-48a0-b3c0-009a41047228"), new Guid("91df2b87-a28d-4e89-a779-d4220d68a0f8"), null, new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), null },
                    { new Guid("f8dbd0c4-c5b6-493d-8ec6-6fc0caea7aaa"), new Guid("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), null }
                });

            migrationBuilder.InsertData(
                table: "FoodPortions",
                columns: new[] { "FoodPortionId", "CreatedAt", "FoodId", "PortionId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("03d4688f-707f-4c86-81b5-a726dae42fd1"), null, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new Guid("31e9bda5-8ec3-4444-a23a-908e84da6a14"), null },
                    { new Guid("05361e77-c0fc-48c1-ad17-60170bbca604"), null, new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), new Guid("f7b36043-9ca9-42c3-8a00-e9e235b56bb3"), null },
                    { new Guid("062e708f-1552-4f2a-a28b-3dfb1a48462a"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("bf0f7ca4-9089-4800-95d7-8d037d98b7fc"), null },
                    { new Guid("0c49908b-0efa-4ead-ba01-e850a303e1fb"), null, new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new Guid("e23d4491-73d1-45b5-8010-0385d7185c98"), null },
                    { new Guid("0c68df0a-9793-4327-938c-2ed315c9df20"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("549d664a-eb1c-4b9a-8ad7-fab9e1482e5b"), null },
                    { new Guid("0f00d893-57b5-48dd-9949-e6d1c17dcad7"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("56681171-ccbd-4700-90bc-2233c1e661bb"), null },
                    { new Guid("14898637-a841-4782-9885-9fbfa0e8b373"), null, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), new Guid("84793ef9-fcd0-42df-ab0d-9380dfa18630"), null },
                    { new Guid("1a527d18-fdfd-4324-af30-b6eea98ff931"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("e09c493c-5806-4b14-bbef-e26e19e1d8d5"), null },
                    { new Guid("1ab93213-11e4-4885-bc39-fc8529ea6673"), null, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), new Guid("3d6d946f-8d9f-479a-b27e-3d78dc354db0"), null },
                    { new Guid("1c5779ea-12f8-4ac2-85b7-3b6e18a24cdf"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("36398f6d-0668-4d37-8850-9f9ee89b8b92"), null },
                    { new Guid("1cad4e9f-7e11-4c84-9b00-33616a375463"), null, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new Guid("eceaaa32-4023-4eab-abb6-9172c908f77c"), null },
                    { new Guid("1e67a0bf-7f60-449e-95a8-04816787251d"), null, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), new Guid("c4993d6a-a2e0-4ddd-821a-0629541e019c"), null },
                    { new Guid("1f1db6d5-a2bd-4647-813e-7f52b301cd3c"), null, new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new Guid("3f77fd90-591c-45f3-8bbc-87d0bb49e461"), null },
                    { new Guid("2b324a47-3e2a-4460-ba0b-8039b40b5672"), null, new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), new Guid("03a92c0b-b7f6-4283-8109-a35898d5d3c5"), null },
                    { new Guid("2ec6097c-4565-4016-bf8a-6ffd060d6ac3"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("1b56833b-1ff5-4a90-aea9-074de2d0dd67"), null },
                    { new Guid("2f7945e1-ca38-4897-b7e1-f9f7f7c9a743"), null, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new Guid("1802caa2-cfe0-48e7-8580-29165f84387d"), null },
                    { new Guid("300bc894-e521-4240-b645-3b5de4b67464"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("698c67ad-a726-435b-b9d2-c5690a79eb5a"), null },
                    { new Guid("3154e2f9-a663-4e45-b8f0-2f2b43b69d3a"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("28b06cf6-6367-4786-bccb-89c43dd3ce3a"), null },
                    { new Guid("31a0d436-c39d-4483-ba95-4fc78d3fd0dc"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("e5cc2785-6d62-4b5f-8fc1-e6ab45babd76"), null },
                    { new Guid("3444b476-3397-4b4f-b194-aae0bc6ff085"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("a43d7637-6fc7-421b-86f1-f83e691431a4"), null },
                    { new Guid("37c44cdd-084c-4b80-a54a-bcaf1a0f9d00"), null, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new Guid("ad9ecd1e-40ec-414a-be69-b16e7013b377"), null },
                    { new Guid("39b465b0-f6f0-44ee-99a6-176900100d39"), null, new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), new Guid("5a1bc1cb-ed0b-49bf-9c1a-5494db962d27"), null },
                    { new Guid("3c402236-4965-4642-9d2b-837ea58fe2e8"), null, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new Guid("de5d78a3-c5b1-4e2a-b9eb-f3757c999024"), null },
                    { new Guid("3f097eca-008c-4678-bfa9-010d6ed06c58"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("7be0e4d3-1e50-4de1-931d-08adb85f628b"), null },
                    { new Guid("3fa39e3a-541e-4f67-ab58-4a84660e663f"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("c65d34ee-8c0c-43bb-9d4e-aa39955a4768"), null },
                    { new Guid("4011478e-0ff0-4eb5-ba1d-4579c2351e36"), null, new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), new Guid("2892c25f-bd50-4bb4-a845-997395ef6693"), null },
                    { new Guid("40587e40-0641-4437-b34e-64a75315e228"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("5a9ac478-aa65-48ea-9387-1ad92f6c76b1"), null },
                    { new Guid("4100cbdd-d586-4856-8c67-a187182b91e6"), null, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), new Guid("424ebe64-6570-4d88-9052-08c06dc0a2c8"), null },
                    { new Guid("42e317f5-de86-4a06-b5e9-3c20ed4e5948"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("26096793-894d-47c1-a06f-cf9133f8089d"), null },
                    { new Guid("43cefb80-0a09-4543-96be-e67ab241c86e"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("63d10d95-7983-455e-b920-29c1f0c88d85"), null },
                    { new Guid("4447caa2-0dbc-460d-b5b4-a34fe2aa405f"), null, new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), new Guid("da254ee7-d229-4769-bad5-a617d09676d4"), null },
                    { new Guid("453bde03-6b04-4a68-b8af-3090d881747d"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("6e98f2be-9196-4c4e-8279-b02010f853f1"), null },
                    { new Guid("4a4cbba7-3f6f-4f39-9fb4-80b567b5bb30"), null, new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), new Guid("255ba0f6-14cc-4049-add8-138f27055b49"), null },
                    { new Guid("4bfda18d-c288-4034-8f24-efbf324ec176"), null, new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new Guid("22f0a09e-6816-410e-a5a2-c802103b089b"), null },
                    { new Guid("4e4d8e2b-09ed-48df-962e-7962c13e6c97"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("f483bb75-84f0-4ecc-8a06-f366a488c6bf"), null },
                    { new Guid("4e995ca4-4255-4d2c-82d8-222f069bf091"), null, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new Guid("222e1fa2-3910-42ac-9a5c-f371dded16eb"), null },
                    { new Guid("5495ee04-b450-4cee-a1ea-7a0e3383bc86"), null, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), new Guid("bdd1ee1e-3a93-421f-855e-0993c7e6f767"), null },
                    { new Guid("56a26f92-a045-4e26-93a6-97a4d894ac8b"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("399eee61-90b5-464f-b3f7-7ddc1077ab0d"), null },
                    { new Guid("5a26a0de-8f09-41c2-8633-f77581c8943f"), null, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), new Guid("d9dad801-145a-419d-bbe2-408acf97a273"), null },
                    { new Guid("5af74f35-1290-4cb0-a4eb-ad7d6947f6a9"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("a88faa7c-6eab-4ecb-8a75-b078a9cf7834"), null },
                    { new Guid("5bebf9d5-1f9f-49ab-84f0-64f69edfb259"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("709578ca-672f-461e-995d-dc78aeda8c4c"), null },
                    { new Guid("5d389405-d578-4902-b9c3-89ff7691046d"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("f928b7a6-2558-478a-bc22-515516f4dc74"), null },
                    { new Guid("5e3abb01-fb2d-4390-a971-77fc97a0961a"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("52c86d57-0909-41c3-b513-e770e6f6d104"), null },
                    { new Guid("5f3fb7a7-f614-4ed6-9c8e-6f1ff46403e0"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("113f6a04-87c4-43c6-8263-920bd099c8e0"), null },
                    { new Guid("667776ab-d5e0-4da4-aad3-5cf70ce32795"), null, new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new Guid("c4fc900f-5a92-4228-ac03-57285fff159e"), null },
                    { new Guid("68493546-dac3-4996-809e-d1edc0f953ff"), null, new Guid("c81a404a-ec10-428e-acec-dd56ec1d3607"), new Guid("d6c41cdb-4735-4b9e-85ae-1f48f33b7d6c"), null },
                    { new Guid("74b900d9-01d1-40c7-b49a-359f35b33cce"), null, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("17c9d30f-bd85-4e58-bfc0-6b6d70b2e5fe"), null },
                    { new Guid("756d40fe-7975-4c42-a0f7-a8be5ab2d9ea"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("f9bc9ae8-e42e-4e8b-84d3-f2bc36037552"), null },
                    { new Guid("76a55aac-2419-4bfe-99aa-412ac2ed6cad"), null, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("6f34350b-8f99-446e-9de9-e0c6277b10f3"), null },
                    { new Guid("7cac180f-14cb-4f8f-adfb-d7e7a1a0776c"), null, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), new Guid("8ecbc063-8d6e-450d-af39-0ba28bc572bf"), null },
                    { new Guid("80e45c92-0573-4a1f-9647-63b0148bb0cc"), null, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new Guid("d2e88505-bbd6-4af6-9a88-535896c5d587"), null },
                    { new Guid("825aa056-1c09-4edd-b27c-baa31b0c58db"), null, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), new Guid("d09266d3-9e7d-46a6-ad3a-7c608ec802d1"), null },
                    { new Guid("826f966e-3431-4294-8f63-081265f67067"), null, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), new Guid("e00ed683-11ff-4c21-8b1c-576b448726c9"), null },
                    { new Guid("846a56c9-e009-4a61-b666-b8aa8890e264"), null, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), new Guid("9c276c0b-84b6-4216-8dbb-ae2034ac2176"), null },
                    { new Guid("849594e5-0ee5-4eee-99d4-164528c6ef4b"), null, new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new Guid("a9385e8a-e9b9-484f-beeb-bc35529cf91a"), null },
                    { new Guid("8937d224-b8bf-4f71-98c0-0baba5ec7941"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("c6e853f0-06bd-4cda-8b43-cbe66fea98c8"), null },
                    { new Guid("8fa958c8-210a-480c-b3e3-f942aad6f964"), null, new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new Guid("a1589990-affa-4805-a1e0-73de1ffa8516"), null },
                    { new Guid("935b9c43-0934-4f08-aac7-04fa1131fab9"), null, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), new Guid("59589114-7d6a-4c80-8681-db5c554ab38f"), null },
                    { new Guid("937d169c-f9ae-4acf-9429-14592d316acf"), null, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), new Guid("bad70aff-4237-4c83-b412-460020a5ee44"), null },
                    { new Guid("962cc9b4-e8f1-45ad-a931-f54be81dfdb7"), null, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), new Guid("3f19ef5c-3c60-4a11-b1b3-5158859f1286"), null },
                    { new Guid("9725fc8b-e17c-4e4e-9edf-ecb6304a13a3"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("9c3399d1-72db-4e86-a518-2575033bb6a8"), null },
                    { new Guid("97b47834-48c6-46d7-9d14-417f9d95cdaf"), null, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("218b9709-852d-4a1f-ad8b-c9410b49fea6"), null },
                    { new Guid("998a2713-9a3d-4eea-b39d-ca1858771e2b"), null, new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new Guid("6792c392-3c86-4162-be91-4fc8646f861d"), null },
                    { new Guid("99ed1648-d30a-45cf-9a47-31189a802235"), null, new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), new Guid("ef6b8c43-9ab5-497c-a9a8-e31f0a349527"), null },
                    { new Guid("9a82fa8c-0729-47d5-9e07-d8415fe3439b"), null, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new Guid("a33065fe-80ad-4879-9333-424aadc6734f"), null },
                    { new Guid("9ba9f9ae-32b9-47f1-be32-1f13019872f3"), null, new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), new Guid("fc245902-ef53-4363-b4ce-0e598e1dd4a4"), null },
                    { new Guid("9c608d6b-54aa-4b28-a2bd-8e6a576b881e"), null, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), new Guid("7e071bd6-6afa-483d-8688-28b31b9a8bef"), null },
                    { new Guid("a2b3fb4b-a97c-4d5f-b641-fbb718e0c7d5"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("faec7c41-2e11-4092-8ab9-cc9c152d858f"), null },
                    { new Guid("a740ce15-6bb3-404f-b779-138d9741e0e5"), null, new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new Guid("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52"), null },
                    { new Guid("ab8ec972-55f3-4dad-a516-a063ac9efb31"), null, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("1808de3e-ae43-41a6-b9ce-bfe89131be5a"), null },
                    { new Guid("af0237d8-9c5d-4264-8268-1c3b11f8f039"), null, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), new Guid("23ce32a0-6597-4b60-b35c-98073ff595c6"), null },
                    { new Guid("b1e7ceb9-1a2d-4973-b987-4cf72661f922"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("a7936b9f-b6f8-4295-8b6e-6fe1b096f437"), null },
                    { new Guid("b2628bc0-2509-4f7a-b2e0-49d9512d7ddf"), null, new Guid("845454d0-967a-4e48-aef3-bd8458775500"), new Guid("1cddc91d-209a-4948-8e9f-9017252d5423"), null },
                    { new Guid("b404eab5-7995-47d7-98ff-6b4b30c0d87d"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("a5dbb27a-4856-44be-a239-76eb073c3e41"), null },
                    { new Guid("b49bdbbf-96d7-4f7d-8dc0-9e268a6e6f67"), null, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("40991196-f258-43f1-ac84-0381afa83477"), null },
                    { new Guid("b63c7317-0fa3-436a-88f6-0c67235584e8"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("e45c2156-a98c-4121-90b4-25097e8a5cd1"), null },
                    { new Guid("b7662cda-52be-4aff-a290-80786ffbc6bf"), null, new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new Guid("5feca670-1f15-430d-9b04-7ac86a329a6c"), null },
                    { new Guid("b79b363c-e37c-4760-9d35-3ca6b8af2ef4"), null, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("91524cc2-db22-4cab-abb7-700725232f1f"), null },
                    { new Guid("ba557b63-c29c-498c-82a0-8780d58e30c9"), null, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), new Guid("bd16f0ec-5ae1-42f4-a302-b4bce8f0db28"), null },
                    { new Guid("bda79a9c-8a49-48fc-92dd-e33db29aae03"), null, new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new Guid("92e149ff-8491-48cf-a4e8-8106b1e95c4c"), null },
                    { new Guid("beb2e228-4f93-40f4-ac97-9bd8223528bf"), null, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("c605aa91-495e-4977-9876-b2a198ce356e"), null },
                    { new Guid("bedcc38e-068a-47f2-93c3-8a351d12f182"), null, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), new Guid("5adcb96d-70ef-403d-89c6-cc3aa807b6a7"), null },
                    { new Guid("bff25dc0-0d4c-4140-a29f-d989437acd0d"), null, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("eff728af-c8f0-4bb5-a985-d079cbadb6b5"), null },
                    { new Guid("c2bc6845-e809-40b1-8a8e-a5436b858da8"), null, new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new Guid("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1"), null },
                    { new Guid("c383b819-187e-4338-8b5e-a3c1a32e2105"), null, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), new Guid("1cf439ce-a31b-4b95-b092-b7f6edf8d40f"), null },
                    { new Guid("c42cb510-9cc2-41c6-bb7e-a337e3110d7b"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("d3850e1b-4780-490d-8c0c-ced1a9aa323b"), null },
                    { new Guid("c509d28a-33c3-4d2c-bd16-df74189a2138"), null, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), new Guid("21e32570-7d64-4cec-b711-873185c76523"), null },
                    { new Guid("c7003fb7-4468-4f9e-9188-068eda6dc624"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("26dcc6e0-67aa-40ed-b3d1-8a009c60a62c"), null },
                    { new Guid("cd6d7520-eb7c-4875-8349-cee9cfe4b867"), null, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("cd0b1476-44a8-4350-a6a1-3de8747a5ebc"), null },
                    { new Guid("d315de7b-8c84-492a-a4af-3a13c69c28af"), null, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), new Guid("7b138bd4-4d3a-426c-9ab0-d66699b762d2"), null },
                    { new Guid("d33201c1-45e5-4b38-b874-26dd97cef917"), null, new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new Guid("41ae956e-14fc-44af-bc6a-e5ba77661cee"), null },
                    { new Guid("d336ca7e-6eec-4433-be3e-a4be858f57b0"), null, new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new Guid("8a81e20e-ea16-4073-957e-29508a8f7419"), null },
                    { new Guid("d599c5fc-dde3-463f-84c8-1c1c702211cf"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("87409e4f-4bea-4bba-855d-a3bfbc2f9c20"), null },
                    { new Guid("d8381938-91eb-4815-9949-ecb0ed37350a"), null, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), new Guid("18809fb3-b78a-4f67-b9f9-8bb6ab95ab00"), null },
                    { new Guid("d8f83a80-df47-49a5-b371-680c97ea733f"), null, new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new Guid("93984b54-2044-4ea9-8364-a03c6568e358"), null },
                    { new Guid("d90fc92d-1d14-4b64-80a5-446d0c0b8b9f"), null, new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), new Guid("5f7f859a-f20a-4f6c-8b8c-ecfbb1ff522e"), null },
                    { new Guid("dc23d1f7-8492-45bb-b50f-0d8c1a53753e"), null, new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new Guid("749b288c-112b-4b7b-8750-0daff63d9ab3"), null },
                    { new Guid("ddbd5689-2472-4f02-a823-908bf9c8ea65"), null, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new Guid("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a"), null },
                    { new Guid("de0d3a83-9c28-4394-8bed-adcf371d40cd"), null, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), new Guid("5afaa147-398e-4be8-b0d1-8dcabe6ed18c"), null },
                    { new Guid("e08fcea3-adf4-451f-8daa-590ef8a48d64"), null, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), new Guid("16dc894a-746e-497e-a2c5-2d58f7f83c4d"), null },
                    { new Guid("e402ea10-31ed-4db7-b970-b8c413a20474"), null, new Guid("05cfce09-72b4-482d-adcd-c0718015be3d"), new Guid("24a4ed15-69e4-4fb5-8dd2-1695de52c264"), null },
                    { new Guid("e73d47af-f29e-4c8c-82ca-da0135014cc0"), null, new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new Guid("4e9013c8-d6f7-4740-80d5-e95d318873b9"), null },
                    { new Guid("ecc5e4a4-0d5a-4ffe-9a32-2dac37e60dd3"), null, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new Guid("b6623163-4c27-4d0c-99ef-12a67b87635f"), null },
                    { new Guid("ed2520fe-7f41-4454-ae87-93fe4d805348"), null, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), new Guid("3c7d60d4-60da-4f51-9448-30877b126572"), null },
                    { new Guid("f64a5163-6da2-4cfa-91ce-2c5e4cc344aa"), null, new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new Guid("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649"), null },
                    { new Guid("f9f74c1c-d2ce-4428-b93f-f287aee4d377"), null, new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), new Guid("5384aebd-4eab-4a44-8cbb-7ec2c04f1401"), null },
                    { new Guid("fb6adbfb-5050-4dd3-b3c2-17ace3f3ba6f"), null, new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new Guid("1500876f-ef20-40de-baae-de0336bdc47b"), null },
                    { new Guid("fe482198-f43c-4f10-9fba-c16035faf8c2"), null, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("40bbc8c4-f383-4ae6-979a-3ac83c275881"), null },
                    { new Guid("fe7ba303-a793-4e82-874d-2b5580d599d1"), null, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), new Guid("919c7f66-53e5-46bd-b181-558f6052b953"), null },
                    { new Guid("ff301f99-088d-49c4-b85a-c8386679ab0a"), null, new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), new Guid("f0e8f9cd-d133-49cf-be7d-d427b630e05a"), null },
                    { new Guid("ffe931a3-c7e3-47cf-b964-de6e7b104a47"), null, new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), new Guid("30f41ca6-c420-4f7d-9602-bf80735d5691"), null }
                });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "NutritionId", "Calcium", "Calories", "Carbs", "Cholesterol", "CreatedAt", "CreatedBy", "Fat", "Fiber", "FoodId", "Iron", "Potassium", "Protein", "SaturatedFat", "Sodium", "Sugar", "UnsaturatedFat", "UpdatedAt", "UpdatedBy", "VitaminA", "VitaminB1", "VitaminB2", "VitaminC", "VitaminD", "VitaminE" },
                values: new object[,]
                {
                    { new Guid("001a4620-96ae-4088-af22-989dd14041bd"), 120f, 42f, 5f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), 0.1f, 150f, 3.4f, 0.6f, 44f, 5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47f, 0.02f, 0.18f, 0f, 2f, 0.1f },
                    { new Guid("00c702e6-d21b-4e78-adaf-54afce0ee796"), 43f, 142f, 34.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 5.1f, new Guid("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), 0.6f, 484f, 0.5f, 0f, 13f, 0.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47f, 0.09f, 0.03f, 4.5f, 0f, 0.1f },
                    { new Guid("00cd2e09-44b3-4774-b086-92382dc58416"), 15f, 190f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 0f, new Guid("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), 1.4f, 250f, 28f, 2.5f, 60f, 0f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.06f, 0.15f, 0f, 0f, 0.7f },
                    { new Guid("01026e88-64ce-4ea8-8a88-3ec516f999ae"), 30f, 400f, 45f, 80f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 3f, new Guid("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), 2f, 200f, 15f, 5f, 600f, 3.5f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.1f, 0.08f, 2f, 0f, 0.3f },
                    { new Guid("022079c2-f84b-47e5-8b2e-e556162f82bb"), 13f, 165f, 0f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.6f, 0f, new Guid("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), 1f, 256f, 31f, 1f, 70f, 0f, 2.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0.07f, 0.1f, 0f, 0f, 0.5f },
                    { new Guid("02a4c31f-2429-43c9-a315-8730ff9485ee"), 11f, 337f, 0f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28f, 0f, new Guid("51061170-597d-4289-a021-1e7dde88331f"), 2.7f, 205f, 19f, 8.5f, 63f, 0f, 12.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.06f, 0.15f, 0.23f, 0f, 0.02f, 0.3f },
                    { new Guid("03c627d4-3e33-4f1b-bcf6-9349712fa6ef"), 80f, 380f, 50f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), 2f, 350f, 18f, 4f, 900f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("043840d9-7e55-4c2a-a32b-2d306b113586"), 9f, 57f, 15.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3.1f, new Guid("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), 0.2f, 116f, 0.4f, 0f, 1f, 9.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25f, 0.02f, 0.03f, 4.3f, 0f, 0.1f },
                    { new Guid("05b2e963-38d1-4656-a246-9c8d52f643f9"), 16f, 13f, 3.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.5f, new Guid("3dc2fa80-ab87-4e26-907b-3516611371b8"), 0.3f, 140f, 0.6f, 0f, 125f, 1.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0.05f, 0.06f, 12f, 0f, 0.1f },
                    { new Guid("05d3ed67-4586-4e15-9970-077d90857ec3"), 37f, 31f, 7.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3.4f, new Guid("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), 1f, 211f, 1.8f, 0f, 6f, 1.6f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.69f, 0.02f, 0.1f, 12.2f, 0f, 0.41f },
                    { new Guid("05f14319-8351-496f-a4f5-e4b180b6f301"), 9f, 206f, 0f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("faf19891-525a-4308-9222-992e83de7ce7"), 0.5f, 363f, 22f, 3.1f, 59f, 0f, 7.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.2f, 0.4f, 0f, 0.38f, 0.5f },
                    { new Guid("0781c737-8e30-4807-9037-8cdcfa5503b6"), 5f, 89f, 22.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.6f, new Guid("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), 0.3f, 358f, 1.1f, 0.1f, 1f, 12.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("09cb058b-8c0b-4e94-957c-fc1412564934"), 16f, 43f, 9.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.8f, new Guid("857b3565-b170-4162-a97b-c0184c4258aa"), 0.8f, 325f, 1.6f, 0f, 78f, 6.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33f, 0.05f, 0.03f, 4.9f, 0f, 0.1f },
                    { new Guid("09cbe70d-336f-4786-b732-17fc0ec6a10a"), 20f, 59f, 15f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2f, new Guid("afe0a180-0077-4fdf-89e8-9513c6132f92"), 0.3f, 257f, 0.9f, 0f, 3f, 9.8f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.95f, 0.03f, 0.04f, 61f, 0f, 0f },
                    { new Guid("0de7c2c4-de83-469a-9cae-60f479665075"), 11f, 117f, 0f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.3f, 0f, new Guid("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), 0.4f, 265f, 20f, 0.7f, 670f, 0f, 3.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.09f, 0.2f, 0f, 200f, 0.6f },
                    { new Guid("0e26c5de-77c8-4527-b50a-352275f3794d"), 40f, 190f, 28f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 1.5f, new Guid("2405ffc3-524e-4331-9e68-47a411d7b9b8"), 1f, 150f, 5f, 1.5f, 500f, 2f, 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.08f, 5f, 0f, 0.4f },
                    { new Guid("0e8ffb01-a04d-4fd8-85f6-57aa2d6abf33"), 30f, 120f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 4f, new Guid("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), 1.2f, 200f, 3f, 1f, 50f, 10f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.03f, 0.02f, 0f, 0f, 0f },
                    { new Guid("0feac812-a1b6-4d93-a8a3-8bcecfc65be8"), 27f, 132f, 23.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 8.7f, new Guid("9349fefa-ecbc-4afc-89f4-62c2f67eb441"), 2.1f, 355f, 8.9f, 0.1f, 5f, 0.3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 0.24f, 0.21f, 0f, 0f, 0.2f },
                    { new Guid("1179087f-f7d5-4e76-8712-96273fe9d9df"), 4f, 110f, 24f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.5f, new Guid("ab2117f7-9940-44cb-b191-2dfabefac8c8"), 0.1f, 15f, 1.8f, 0.1f, 10f, 0.1f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.01f, 0.01f, 0f, 0f, 0f },
                    { new Guid("17f231a0-41b4-4f6e-98b9-4acc74240a0a"), 50f, 250f, 30f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2f, new Guid("8382816f-1beb-4804-9698-3b486798b20a"), 1f, 250f, 10f, 3f, 450f, 2f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.2f, 0.1f, 0f, 0f, 0.5f },
                    { new Guid("187d7cbf-1d4e-4973-954b-10f87778d4d3"), 150f, 23f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.1f, new Guid("2c990331-b6ca-4642-893a-be68f0d398d5"), 1.6f, 296f, 2f, 0.1f, 50f, 1f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 740f, 0.07f, 0.09f, 55f, 0f, 1.2f },
                    { new Guid("1a0b45e6-fe4b-479c-8dca-9879ca93a529"), 15f, 242f, 3.1f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17.2f, 0.5f, new Guid("b80c562a-e1d4-4117-a317-c06b5bae8950"), 1.2f, 330f, 22.5f, 6.5f, 530f, 1.2f, 10.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45f, 0.8f, 0.2f, 0f, 0f, 0.3f },
                    { new Guid("1abb2d1e-7a7c-4e9b-86d5-da67f4031a64"), 16f, 27f, 5.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.2f, new Guid("35cad577-0748-469f-8909-7dc013cf1c55"), 0.7f, 533f, 3f, 0f, 4f, 0.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("1bb926c0-528e-4f2f-82c3-6438f0abed03"), 201f, 76f, 1.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.8f, 0.3f, new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), 1.6f, 121f, 8f, 0.7f, 7f, 0.4f, 2.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.03f, 0f, 0f, 0.02f },
                    { new Guid("1d5ca6dd-b9f8-4827-82a6-d79111c01e7f"), 30f, 110f, 15f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("d65c7826-78c0-4991-b3b6-1e2b25437f61"), 1.5f, 250f, 14f, 0.5f, 500f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150f, 0.1f, 0.1f, 5f, 0f, 0.4f },
                    { new Guid("1da8d5dc-6b71-4322-acfe-222c7fdc18ff"), 10f, 40f, 10f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.5f, new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), 0.1f, 40f, 0.2f, 0f, 3f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.01f, 0.01f, 20f, 0f, 0f },
                    { new Guid("1edd7220-1e34-4446-b0c3-d063b757b835"), 5f, 66f, 16.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 1.3f, new Guid("7b8500af-d730-4138-9617-cba352faed4a"), 0.3f, 171f, 0.8f, 0f, 1f, 15.2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.01f, 0.07f, 71.5f, 0f, 0.1f },
                    { new Guid("1fef95bb-cef2-4d0b-b197-89410605d7f4"), 7f, 242f, 0f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14f, 0f, new Guid("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), 0.9f, 370f, 27f, 5.2f, 65f, 0f, 8.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.6f, 0.15f, 0f, 0f, 0.2f },
                    { new Guid("20363c9a-f661-452c-9670-24c8f6b8a8e9"), 10f, 110f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.9f, 1.8f, new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), 0.4f, 43f, 2.6f, 0.2f, 1f, 0.4f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.16f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("21069091-74f4-4635-95fd-899e8bb394fc"), 10f, 132f, 0f, 51f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), 0.9f, 252f, 29f, 0.3f, 37f, 0f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.07f, 0.18f, 0f, 0.8f, 0.2f },
                    { new Guid("21d2848f-62a8-4d03-a23d-b5a94cd35cb5"), 130f, 23f, 4.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("982d8f3e-f517-4bd2-87a8-48329fc9eb91"), 0.8f, 260f, 1.6f, 0.1f, 60f, 1.3f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 560f, 0.06f, 0.08f, 35f, 0f, 0.5f },
                    { new Guid("246016b6-c047-4cb1-a718-4cd60a590054"), 30f, 200f, 25f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 2f, new Guid("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), 1.5f, 250f, 10f, 1.5f, 600f, 3f, 6.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 200f, 0.1f, 0.1f, 5f, 0f, 0.7f },
                    { new Guid("24c26aa8-3645-476f-a890-44d24cd72af0"), 30f, 440f, 50f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17f, 2f, new Guid("77fe5e06-7fee-486d-a1a7-c031f2065490"), 2.5f, 320f, 21f, 6f, 650f, 3f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.15f, 0.08f, 2f, 0f, 0.4f },
                    { new Guid("25da48e4-be8b-431b-8dc6-7a9934e0d319"), 50f, 40f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 2f, new Guid("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), 1.2f, 250f, 3f, 0.2f, 300f, 1f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 400f, 0.05f, 0.07f, 20f, 0f, 0.5f },
                    { new Guid("26c0b301-e1a6-4813-8a45-8335acf5822c"), 55f, 22f, 3.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.2f, new Guid("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), 1.8f, 500f, 2.1f, 0f, 15f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8890f, 0.05f, 0.18f, 37.5f, 0f, 0.4f },
                    { new Guid("270be2cb-1f5a-4bdf-b289-f5bf6e575723"), 20f, 296f, 1.7f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26f, 0f, new Guid("85822a08-7189-4e08-8f55-25c73698af92"), 1.2f, 200f, 12f, 9f, 1020f, 0.2f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.3f, 0.12f, 0f, 0f, 0.4f },
                    { new Guid("28f294ff-193b-4109-92f1-42150c24cb04"), 11f, 165f, 0f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.6f, 0f, new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), 0.9f, 256f, 31f, 1f, 74f, 0f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.06f, 0.08f, 0f, 0f, 0.3f },
                    { new Guid("2a5aef78-063b-4893-9eea-281270921b56"), 20f, 250f, 32f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 1f, new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), 1.5f, 150f, 10f, 3f, 480f, 1.5f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("2b89704c-62a5-4777-843e-0043515ace69"), 130f, 23f, 4.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2f, new Guid("9acdf58c-c37d-4026-a3f9-40fda186184b"), 1f, 140f, 2.1f, 0.1f, 40f, 1.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 800f, 0.05f, 0.07f, 40f, 0f, 0.4f },
                    { new Guid("2c453166-b39f-490b-9785-b03af72b250a"), 12f, 189f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), 1.1f, 302f, 19f, 4.3f, 60f, 0f, 8.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.33f, 0f, 440f, 0.5f },
                    { new Guid("2cc9b81e-f497-41db-b4b4-8ddaaba84ee0"), 25f, 52f, 11.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.6f, 6.5f, new Guid("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), 0.7f, 151f, 1.2f, 0f, 1f, 4.4f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33f, 0.03f, 0.04f, 26.2f, 0f, 0.9f },
                    { new Guid("2d8e511a-2db0-4a78-a33b-4a500351ac00"), 40f, 410f, 50f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 3f, new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), 2f, 250f, 16f, 5f, 800f, 5f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.08f, 3f, 0f, 0.3f },
                    { new Guid("2da8013a-34ec-44ac-9a81-afc0de6b1fc9"), 80f, 55f, 2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 0.5f, new Guid("22d1cbad-a884-400c-b681-30b17d98bf1c"), 1f, 150f, 5f, 0.5f, 15f, 0.5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.02f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("2dedf83c-8e28-4985-b005-c38b1a32b10f"), 46f, 559f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49f, 6f, new Guid("59988378-901f-4ec4-bd6c-9fdc28ca97a1"), 8.8f, 809f, 30f, 8.7f, 18f, 1.4f, 40.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.19f, 0.32f, 0f, 0f, 2.2f },
                    { new Guid("2e290dfa-7c66-4ebd-9c07-66c9bece85ca"), 2f, 96f, 21f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 2.4f, new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), 0.5f, 270f, 3.4f, 0.2f, 1f, 4.5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.15f, 0.1f, 6.8f, 0f, 0.2f },
                    { new Guid("318702a1-0ce2-4a76-949f-baba94d81992"), 30f, 86f, 20.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3f, new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), 0.6f, 337f, 1.6f, 0f, 55f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.96f, 0.08f, 0.03f, 2.4f, 0f, 0.26f },
                    { new Guid("31cf2b48-e85f-45fd-a3a9-232815f36008"), 34f, 61f, 14.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 3f, new Guid("7b3216ff-858e-423e-b8db-a85571aa5488"), 0.3f, 312f, 1.1f, 0f, 3f, 8.9f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 87f, 0.02f, 0.05f, 92.7f, 0f, 1.5f },
                    { new Guid("32011ef0-7b76-44e1-a699-575ce2ff34e8"), 3f, 37f, 7.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.5f, new Guid("1d0feb2f-0735-4333-87ce-09e22304ad0d"), 0.4f, 359f, 2.7f, 0f, 3f, 0.5f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.11f, 0.1f, 2.1f, 0f, 0.01f },
                    { new Guid("339eadb8-6d1f-4a08-8168-0914fc875126"), 21f, 83f, 19.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 5.3f, new Guid("cb693182-b5ff-4f2b-9a47-44ab84841843"), 0.8f, 193f, 0.4f, 0.1f, 12f, 14.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 60f, 0.01f, 0.02f, 14.7f, 0f, 0.1f },
                    { new Guid("33a5f66a-fcf3-4f24-823d-f5e2e5cd0cee"), 15f, 239f, 0f, 76f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14f, 0f, new Guid("0f7f47a1-f122-4f58-9e24-40ece9323520"), 0.8f, 260f, 27f, 4.1f, 70f, 0f, 9.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 0.06f, 0.11f, 0f, 0f, 0.3f },
                    { new Guid("344f7b19-b175-4f10-9904-524763043f93"), 15f, 417f, 1.4f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39f, 0f, new Guid("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), 1f, 200f, 13f, 14.6f, 800f, 1.2f, 24.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.09f, 0f, 0f, 0.3f },
                    { new Guid("3628c4ed-f791-4ea2-90c9-4697f6c86657"), 50f, 400f, 60f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 3f, new Guid("77243d82-a633-4fe8-84c9-61a4b6cd4428"), 2f, 300f, 12f, 4f, 500f, 2.5f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.08f, 3f, 0f, 0.3f },
                    { new Guid("37c984c8-c531-4375-a986-f23d1122398b"), 60f, 350f, 50f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2.5f, new Guid("7268b449-cb54-4f3d-9709-f42b9966d707"), 1.5f, 300f, 12f, 3f, 700f, 2f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.08f, 0.06f, 2f, 0f, 0.2f },
                    { new Guid("37d271ba-238c-462d-befb-f0fa3f585dc6"), 12f, 189f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("d3c360a2-441e-4700-a6ec-4310b5976901"), 1.1f, 302f, 19f, 4.3f, 60f, 0f, 8.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.33f, 0f, 440f, 0.5f },
                    { new Guid("383259d3-0a17-4961-9b03-e65f1cd66149"), 80f, 360f, 45f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 4f, new Guid("a41a3bc6-0f34-409f-9045-0807fbb4469b"), 2.5f, 400f, 15f, 4f, 850f, 6f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.2f, 4f, 0f, 0.5f },
                    { new Guid("3a58e44e-dae0-4f2c-bda0-f004269bfdc0"), 30f, 150f, 18f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 0.5f, new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), 1.5f, 200f, 8f, 2f, 500f, 1f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("3a5a64d3-b14c-4967-8053-7e982b5198b3"), 105f, 13f, 2.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1f, new Guid("3222413a-e385-4a0b-9d07-2af7b0cb4276"), 0.8f, 176f, 1.5f, 0f, 65f, 0.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.6f, 0.04f, 0.07f, 45f, 0f, 0.15f },
                    { new Guid("3a905968-b96a-4692-91f9-a83adc49c1bb"), 20f, 16f, 3.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.8f, new Guid("e370081a-c0a6-4c00-b01c-7c52f953b7f1"), 0.2f, 150f, 0.6f, 0f, 50f, 2.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.05f, 0.04f, 12f, 0f, 0.2f },
                    { new Guid("3b639fbb-f1de-4c1f-81e3-a891426d6916"), 30f, 95f, 15f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 1f, new Guid("90099162-15e0-4ef0-b93e-59d409678b63"), 1.2f, 220f, 12f, 0.5f, 400f, 2f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.08f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("3c27fe2d-b75e-446e-b5f9-6b3b328b25c3"), 50f, 60f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 3f, new Guid("a988cc73-072e-4af1-9b53-55fbf0f4fe79"), 1.2f, 250f, 3f, 0.5f, 200f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500f, 0.05f, 0.07f, 15f, 0f, 2f },
                    { new Guid("3c717b84-3817-4f2c-9104-de6b71b1b7fe"), 40f, 280f, 30f, 150f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 2f, new Guid("2d821db4-3e99-4877-b979-bc82d34b3b01"), 1.5f, 250f, 10f, 3f, 500f, 3f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 250f, 0.1f, 0.1f, 1f, 1f, 0.7f },
                    { new Guid("403ac5bf-eeb8-436c-a9f2-376bc7ddb658"), 30f, 300f, 3f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24f, 0.2f, new Guid("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), 2f, 400f, 20f, 9f, 900f, 1.5f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("4165058a-ad54-45cf-8048-5c23256ec6fc"), 255f, 534f, 28.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42.2f, 27.3f, new Guid("7729551a-e475-4079-aaa0-07c02efde2a5"), 5.7f, 813f, 18.3f, 3.7f, 30f, 1.6f, 38.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.41f, 0.16f, 0.6f, 0f, 0.3f },
                    { new Guid("4353167a-5972-449e-a06a-a08ffde87061"), 30f, 90f, 6f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), 1f, 250f, 12f, 1f, 450f, 2f, 2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.1f, 5f, 0f, 0.4f },
                    { new Guid("43a65add-a7d2-42c0-8277-15986c139fd1"), 21f, 92f, 3.1f, 233f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.4f, 0f, new Guid("a53672e7-8593-4779-bd02-9f02ae81f915"), 0.7f, 279f, 15.6f, 0.5f, 44f, 0f, 0.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.02f, 0.06f, 0f, 0f, 0.01f },
                    { new Guid("43b6ec80-0a97-4587-ae26-52bb709f60b7"), 40f, 350f, 55f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 2.5f, new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), 1.2f, 250f, 12f, 2.5f, 850f, 4f, 4.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.1f, 3f, 0f, 0.2f },
                    { new Guid("443a1fd0-05b3-41f9-9bbc-8f019555189b"), 25f, 54f, 6.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.6f, 0.4f, new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), 0.7f, 118f, 3.3f, 0.2f, 51f, 1.2f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.03f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("44c7f615-f7ed-4793-9975-ead8945fc443"), 50f, 380f, 45f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), 2f, 450f, 16f, 4f, 1200f, 4f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.2f, 2f, 0f, 0.4f },
                    { new Guid("45fdb042-ab4e-4262-8984-030c1d700db6"), 6f, 52f, 13.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.4f, new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), 0.1f, 107f, 0.3f, 0f, 1f, 10.4f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.02f, 0.03f, 4.6f, 0f, 0.18f },
                    { new Guid("4619cd97-19ad-4225-9cdb-660093c35e6d"), 110f, 59f, 3.6f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 0f, new Guid("d3392e5d-a48f-4b5a-968d-31b98bd47835"), 0.1f, 141f, 10f, 0.2f, 36f, 3.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 0.04f, 0.14f, 0f, 0f, 0f },
                    { new Guid("46fffbb7-db83-438a-b1fd-b433811929de"), 12f, 206f, 0f, 63f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13f, 0f, new Guid("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), 0.5f, 363f, 22f, 3.1f, 59f, 0f, 9.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.38f, 0f, 570f, 0.4f },
                    { new Guid("493f9aa1-5b0d-4a73-82a9-c2d1f963e25b"), 10f, 69f, 18.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.9f, new Guid("1aa49363-ab95-4565-9e27-1855702197fd"), 0.4f, 191f, 0.7f, 0f, 2f, 16.3f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 92f, 0.03f, 0.04f, 10.8f, 0f, 0.1f },
                    { new Guid("4b333e5d-8f1c-43c4-9fe4-8008db5fd285"), 10f, 290f, 0f, 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23f, 0f, new Guid("73016f70-ebb4-4583-aa12-7f3f4633ada4"), 1.5f, 200f, 20f, 9f, 75f, 0f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.05f, 0f, 0f, 0.1f },
                    { new Guid("4b467ef5-29d1-4b4c-b246-a6f76fc14f2e"), 12f, 73f, 18f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.6f, 1.5f, new Guid("3d19d971-88d0-4108-a335-24ac9e1dec50"), 0.3f, 42f, 0.6f, 0.1f, 10f, 15f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.05f, 5f, 0f, 0.1f },
                    { new Guid("4d14c758-e288-4d7b-864e-58dc126a0a4a"), 30f, 130f, 6f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.5f, 1.5f, new Guid("85e621ed-0e0c-4d20-8891-51d311cea4a3"), 2f, 250f, 200f, 1.5f, 400f, 2f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40f, 0.1f, 0.1f, 4f, 0f, 0.5f },
                    { new Guid("4f0eab71-b4d1-4790-b42f-27587fb4cb59"), 40f, 30f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2.5f, new Guid("2ee163f7-4463-44ec-b9e2-8a409c112db4"), 0.8f, 300f, 2f, 0.1f, 150f, 2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500f, 0.04f, 0.05f, 20f, 0f, 0.5f },
                    { new Guid("4f261318-2a0e-4fe5-abd8-5e68d8630734"), 5f, 28f, 4.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.2f, new Guid("628d87df-0bde-417d-b8b5-5f8f5536410b"), 0.3f, 300f, 2.8f, 0f, 3f, 1f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.06f, 0.07f, 0.5f, 0.02f, 0.1f },
                    { new Guid("5004742e-f776-40db-8d97-13d54ac96434"), 10f, 112f, 23.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.9f, 1.8f, new Guid("9b98036c-2047-4700-bb13-b34a432bb999"), 0.4f, 86f, 2.6f, 0.2f, 1f, 0.4f, 0.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.14f, 0.02f, 0f, 0f, 0.1f },
                    { new Guid("509cdb3c-c810-43be-9ab8-492efeccd78d"), 25f, 150f, 2f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 0.5f, new Guid("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), 1.5f, 300f, 23f, 1.5f, 350f, 1f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 80f, 0.1f, 0.07f, 2f, 0.5f, 0.3f },
                    { new Guid("53196773-ec92-425e-a280-9c9615499b05"), 6f, 46f, 11.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.4f, new Guid("f0e4a066-b920-4540-a035-1a5504ff1358"), 0.2f, 157f, 0.7f, 0f, 0f, 9.9f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.04f, 9.5f, 0f, 0.4f },
                    { new Guid("53385d94-be3e-4b20-ab99-57e6281c619a"), 357f, 145f, 4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 1.8f, new Guid("8da16f72-42a9-4da2-b217-811903e340c4"), 2.8f, 240f, 12f, 1.1f, 15f, 2.3f, 5.9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 0.08f, 0.16f, 5f, 0f, 0.5f },
                    { new Guid("56a4a1c1-b3ff-4143-8d39-bf49a9f6fe19"), 15f, 90f, 14f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 1f, new Guid("af036922-79f3-45a7-b562-a6279520c0e6"), 0.6f, 200f, 8f, 0.5f, 350f, 2f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.05f, 0.07f, 3f, 0f, 0.2f },
                    { new Guid("5f13bf66-2280-40b2-a038-3b6078477a92"), 8f, 378f, 72.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.2f, 8.5f, new Guid("68c8c4c4-e5d6-4e15-ad60-1c18f0c1cb4d"), 3f, 195f, 11f, 0.7f, 5f, 0.6f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.41f, 0.29f, 0f, 0f, 0.1f },
                    { new Guid("606ec04d-7102-465f-b3f3-33c6fc848309"), 10f, 160f, 30f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), 0.4f, 100f, 5f, 1f, 250f, 1.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.02f, 0.02f, 0f, 0f, 0.1f },
                    { new Guid("61a33b83-e34f-4c6d-aa90-e47d2984bc1a"), 15f, 110f, 14f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 0.5f, new Guid("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), 0.9f, 180f, 7f, 1f, 350f, 1f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0.05f, 0.07f, 1f, 0f, 0.2f },
                    { new Guid("636ffb58-f3ec-45be-919d-7127ce8c5706"), 40f, 230f, 30f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 1f, new Guid("9669cdf4-c133-476f-b2bd-f3c091346c52"), 1.2f, 200f, 15f, 1.5f, 500f, 3f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.1f, 2f, 0f, 0.5f },
                    { new Guid("63c9264c-6cb8-4d3f-92f5-921502e24357"), 15f, 80f, 17f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2f, new Guid("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), 0.6f, 350f, 2f, 0.1f, 350f, 1.5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0.06f, 0.05f, 10f, 0f, 0.1f },
                    { new Guid("63da554d-f0c8-4322-b673-be434c841794"), 15f, 350f, 70f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 3f, new Guid("e0eec003-8384-412c-a307-b0185afdb0c7"), 1f, 200f, 8f, 2f, 250f, 2f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.15f, 0.1f, 3f, 0f, 0.2f },
                    { new Guid("63e3f487-3079-4773-8cf8-83910b27eed0"), 40f, 23f, 4.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2f, new Guid("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), 1f, 250f, 2f, 0.1f, 25f, 1.5f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 450f, 0.07f, 0.08f, 25f, 0f, 0.4f },
                    { new Guid("640d61d2-0844-4c5e-9109-7ff174eef472"), 5f, 90f, 23f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.6f, new Guid("1140212e-cdb4-4f25-92f6-9b9407a71163"), 0.3f, 360f, 1f, 0.1f, 1f, 12f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("646a0890-8ae8-4098-aa1f-8d3acbf3d6df"), 14f, 354f, 15.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33.5f, 9f, new Guid("49601ef1-2131-478f-a1de-f2e444602be3"), 2.4f, 356f, 3.3f, 29.7f, 20f, 6.2f, 3.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.04f, 0.02f, 3.3f, 0f, 0.3f },
                    { new Guid("64d45697-299c-4b6d-ae2d-69aba6a43e4b"), 129f, 322f, 3.6f, 1085f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26.5f, 0f, new Guid("a782e478-d5c5-4da6-b809-180b48ad08c3"), 2.7f, 109f, 15.9f, 8.7f, 48f, 0.6f, 11.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.53f, 0.08f, 0.37f, 0f, 2f, 2.7f },
                    { new Guid("665e4eb8-61e9-465f-b26a-ddd0a283a6c4"), 11f, 45f, 10.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.2f, new Guid("de097440-db5c-4d91-bd55-76618d70599d"), 0.1f, 200f, 0.7f, 0f, 1f, 8.4f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.1f, 0.02f, 50f, 0f, 0.02f },
                    { new Guid("6696c68d-0bd6-4f36-bedb-a523dee4ef5e"), 11f, 60f, 15f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 1.6f, new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), 0.2f, 168f, 0.8f, 0.1f, 1f, 13.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.54f, 0.03f, 0.04f, 36.4f, 0f, 0.9f },
                    { new Guid("6813db9b-2c02-4ea3-a079-0e78985c1768"), 10f, 83f, 18.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.2f, 4f, new Guid("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), 0.3f, 236f, 1.7f, 0.1f, 3f, 13.7f, 1.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.07f, 0.06f, 10.2f, 0f, 0.6f },
                    { new Guid("6818108d-770e-4204-8008-d33ada30be15"), 18f, 68f, 14.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.9f, 5.4f, new Guid("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), 0.3f, 417f, 2.6f, 0.3f, 2f, 8.9f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.21f, 0.07f, 0.04f, 228.3f, 0f, 0.73f },
                    { new Guid("69f70b00-7127-4ba6-a184-667e06e7c777"), 40f, 15f, 2.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.5f, new Guid("da85064b-e528-4bfa-8a64-1fbe704f9af5"), 0.6f, 120f, 1.2f, 0f, 750f, 0.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.01f, 0.02f, 15f, 0f, 0.02f },
                    { new Guid("6c7ad8ea-a7a0-4169-b160-c547aed53cc9"), 40f, 25f, 5.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 2.5f, new Guid("8ed85dc2-7654-4c48-81f9-19946a73f71d"), 0.5f, 170f, 1.3f, 0f, 18f, 3.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 75f, 0.05f, 0.04f, 36f, 0f, 0.1f },
                    { new Guid("70e67f66-8fe2-4716-9097-804bec986326"), 20f, 15f, 3.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1f, new Guid("6487a532-ff5e-4b77-b408-46c789608de9"), 0.3f, 150f, 1f, 0f, 180f, 2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 0.03f, 0.02f, 7f, 0f, 0.1f },
                    { new Guid("756cbb2f-3b33-4c11-a8bc-81f0a8ce1508"), 40f, 25f, 5.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.8f, new Guid("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), 0.5f, 252f, 1.3f, 0f, 13f, 1.4f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.37f, 0.04f, 0.04f, 36.6f, 0f, 0.12f },
                    { new Guid("76e30110-25d3-442b-a406-0900ecafd115"), 40f, 50f, 8.5f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 1.5f, new Guid("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), 0.5f, 230f, 3.5f, 0.2f, 300f, 3.5f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 850f, 0.05f, 0.07f, 15f, 0f, 0.5f },
                    { new Guid("775b8b05-c4f1-4ee3-9a95-ce5e8796ea64"), 10f, 50f, 11f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 3f, new Guid("86d88717-df08-4de6-b86d-870210864b46"), 0.3f, 150f, 1.1f, 0.1f, 4f, 8f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.04f, 0.05f, 3f, 0f, 0.3f },
                    { new Guid("7820a73a-27c0-445e-ae0f-7bde377bcc5c"), 25f, 81f, 14f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 5.7f, new Guid("b29dc622-e8ae-4471-8e22-5676aa5fa909"), 1.5f, 244f, 5.4f, 0.1f, 5f, 5.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 765f, 0.27f, 0.15f, 40f, 0f, 0.1f },
                    { new Guid("78389da0-d5c7-4913-855c-a06bd1639998"), 15f, 130f, 28f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 1f, new Guid("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), 0.5f, 120f, 4f, 0.1f, 250f, 1.5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.1f, 0f, 0f, 0.1f },
                    { new Guid("78e179e2-20ea-4f76-888f-bd4b044199d7"), 85f, 718f, 13.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 75.8f, 8.6f, new Guid("731974ef-495e-4c08-ba95-20589d60c20c"), 2.5f, 363f, 7.9f, 12.1f, 5f, 4.6f, 63.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.21f, 0.16f, 1.1f, 0f, 0.6f },
                    { new Guid("79afbf41-daf6-444e-922e-52f13e2d5328"), 7f, 30f, 7.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.4f, new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), 0.2f, 112f, 0.6f, 0f, 1f, 6.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.57f, 0.03f, 0.02f, 8.1f, 0f, 0.05f },
                    { new Guid("7a44b5cf-ae8c-440b-9fe4-aa1adbe9b897"), 277f, 172f, 8.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9f, 6f, new Guid("3fa8cf38-d835-4279-a113-a8f44cd013e6"), 2.5f, 620f, 18f, 1.3f, 15f, 3f, 7.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9f, 0.16f, 0.18f, 6f, 0f, 0.9f },
                    { new Guid("7f9097f3-84d8-4087-87f6-5247492186d1"), 40f, 450f, 50f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 3f, new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), 2f, 250f, 20f, 5f, 700f, 5f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.12f, 0.1f, 3f, 0f, 0.5f },
                    { new Guid("80058469-aa54-4e79-af55-fe54f8a31da3"), 120f, 120f, 18f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), 0.6f, 200f, 4f, 1f, 50f, 12f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.1f, 0.1f, 2f, 0.1f, 0.1f },
                    { new Guid("800ae0b7-b212-466a-bc68-79400bfd7f9a"), 107f, 562f, 27.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45.4f, 10.3f, new Guid("404a286a-90c5-4c54-8e27-3ddeba55ada3"), 4f, 1025f, 20.3f, 5.6f, 1f, 7.7f, 39.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26f, 0.87f, 0.16f, 5.4f, 0f, 2.9f },
                    { new Guid("83848472-0125-474b-ad25-4958ce785ea9"), 21f, 26f, 6.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.1f, new Guid("00333cd3-f43b-40af-855e-95aa8a636e4a"), 0.8f, 340f, 1f, 0f, 1f, 2.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8533f, 0.05f, 0.11f, 9f, 0f, 0.3f },
                    { new Guid("84293442-97fe-4f4f-9f84-ff2052bb96d6"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("8567d57a-faa1-4b68-962d-61b055ca4a07"), 50f, 400f, 55f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 3f, new Guid("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), 2f, 300f, 15f, 4f, 1200f, 4f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.08f, 0.1f, 4f, 0f, 0.2f },
                    { new Guid("85f83a38-0b42-4142-80f7-4fddb43c6287"), 35f, 420f, 50f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2.5f, new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), 2.5f, 320f, 18f, 3f, 850f, 2f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.08f, 0.1f, 0.07f, 1f, 0f, 0.3f },
                    { new Guid("86fc419e-bc49-4940-8f52-c3f6e8365e5a"), 30f, 260f, 42f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 1.5f, new Guid("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), 1.2f, 120f, 9f, 2.5f, 350f, 6f, 3.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("87e185ca-137b-452b-996f-57ee69da5851"), 33f, 354f, 73.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.3f, 17.3f, new Guid("642480b4-22c9-4350-a6ce-c052f99e60e3"), 3.6f, 452f, 12.5f, 0.5f, 9f, 0.8f, 1.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22f, 0.27f, 0.16f, 0f, 0f, 0.2f },
                    { new Guid("8863b0b9-07b9-4cfc-8783-57f81e10891a"), 500f, 245f, 0f, 152f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.1f, 0f, new Guid("dd1482e7-b3dd-4b17-80f6-5618a640c671"), 2.8f, 684f, 57f, 0.3f, 702f, 0f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.12f, 0.1f, 0f, 0.6f, 0.2f },
                    { new Guid("89d144cc-e30b-4a2d-89a8-ebf2ec3f1f50"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("9979963d-5c37-4fa9-955c-d1ecb5814607"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("8a211bdf-54ae-479f-ae2f-f586a0421531"), 40f, 30f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2.5f, new Guid("4edcae53-7e30-42bb-8526-7686355f2268"), 1f, 300f, 2f, 0.1f, 150f, 2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500f, 0.05f, 0.06f, 30f, 0f, 0.5f },
                    { new Guid("8acd54ac-0e45-408a-9b8b-af88b1999574"), 78f, 584f, 20f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 51.5f, 8.6f, new Guid("4e46f955-4413-496f-97b4-968a38ee3e11"), 5.3f, 645f, 20.8f, 4.5f, 9f, 2.6f, 47f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 1.48f, 0.25f, 1.4f, 0f, 35.2f },
                    { new Guid("8b2d562f-826c-49e3-92bc-3bded04e99d7"), 30f, 220f, 12f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 1.5f, new Guid("29dfb5da-8818-40ff-bf66-7553521c2161"), 2.5f, 300f, 15f, 4f, 600f, 3f, 8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150f, 0.1f, 0.1f, 4f, 0f, 1f },
                    { new Guid("8dc4fb30-c222-452b-aac2-aa59cd451feb"), 70f, 99f, 0.2f, 189f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 0f, new Guid("4d640470-857a-4765-905f-e49e98a281a1"), 0.4f, 264f, 24f, 0.1f, 111f, 0.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.1f, 0f, 0f, 1.3f },
                    { new Guid("8eda5261-f52b-4459-af8d-3b29dfca27ea"), 25f, 105f, 15f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("7167f942-dc89-4f29-8022-588373aef45e"), 0.9f, 220f, 10f, 0.5f, 400f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 80f, 0.05f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("8f471162-ec77-45ec-b3a2-2584ab5944a9"), 35f, 22f, 4.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2f, new Guid("881ae045-1c9a-4e20-9160-0e8c14486be5"), 0.5f, 250f, 1f, 0.1f, 80f, 1.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 650f, 0.04f, 0.05f, 20f, 0f, 0.4f },
                    { new Guid("925382ae-0b2e-42a2-991e-28fcc2ff7fe9"), 30f, 130f, 18f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.5f, 1f, new Guid("30f9d9dc-1653-495c-99b7-b649c49f7930"), 1.2f, 180f, 6f, 1.5f, 500f, 1f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.1f, 0.1f, 2f, 0f, 0.3f },
                    { new Guid("9a8b9c6f-67fb-4ce6-8d9a-8f9ba87e1f00"), 20f, 35f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 1.5f, new Guid("2ae82bfd-34db-4928-bfee-b60f4aec4460"), 0.5f, 200f, 1f, 0.1f, 250f, 3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500f, 0.05f, 0.03f, 15f, 0f, 1f },
                    { new Guid("9b8a31ad-2838-4163-86e1-f56002f89c5a"), 27f, 16f, 3.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.6f, new Guid("845454d0-967a-4e48-aef3-bd8458775500"), 0.3f, 233f, 0.6f, 0f, 9f, 1.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.03f, 14.8f, 0f, 0.2f },
                    { new Guid("9bfb84ff-0b28-44cc-98fd-4890d896a04e"), 45f, 31f, 7.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.1f, new Guid("ff348fc8-cd36-41c4-984f-a5884171f367"), 0.6f, 216f, 1.4f, 0f, 27f, 3.8f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 993f, 0.05f, 0.06f, 36.6f, 0f, 0.1f },
                    { new Guid("9d15e30b-d43f-49bc-9bf2-3a89a3e0ea35"), 10f, 150f, 30f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 1f, new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), 0.5f, 50f, 3f, 0.5f, 300f, 2f, 1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.01f, 0.01f, 0f, 0f, 0.1f },
                    { new Guid("9e39b479-89d2-464a-b3a9-daff6c3eb0d5"), 40f, 70f, 6f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 2f, new Guid("63045676-0e70-425f-aa96-e348a4e88c3a"), 1.5f, 250f, 7f, 0.5f, 300f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 300f, 0.05f, 0.1f, 5f, 0f, 0.5f },
                    { new Guid("9f25a767-bb5b-41a5-9e22-804ecc034cda"), 25f, 70f, 6f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 1f, new Guid("56513d2d-2472-4fa4-80bc-2f54002b187f"), 1f, 250f, 10f, 0.5f, 500f, 2f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.1f, 10f, 0f, 0.3f },
                    { new Guid("a12450cc-e4fc-497c-a546-2ae33795a9cb"), 33f, 41f, 9.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.8f, new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), 0.3f, 320f, 0.9f, 0f, 69f, 4.7f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.69f, 0.04f, 0.03f, 5.9f, 0f, 0.66f },
                    { new Guid("a3191800-2dbb-4c59-9e3b-51ed4467c269"), 20f, 150f, 30f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 2f, new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), 1f, 100f, 5f, 0.5f, 300f, 2.5f, 1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.06f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("a6193ca8-bef7-4896-9d01-81c9d5a0b8a8"), 24f, 19f, 3.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0f, new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), 0.3f, 250f, 0.7f, 0f, 11f, 2.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.02f, 2.4f, 0f, 0f },
                    { new Guid("a65beea1-116d-4449-9893-2edad0196231"), 8f, 250f, 0f, 75f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0f, new Guid("0455b535-2662-43aa-bca2-3e75595fb181"), 1.3f, 220f, 19f, 7f, 65f, 0f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.05f, 0f, 0f, 0.1f },
                    { new Guid("a7c425c7-32f6-4c5f-9469-891e495c4a7a"), 5f, 89f, 22.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2.6f, new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), 0.3f, 358f, 1.1f, 0.1f, 1f, 12.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.07f, 8.7f, 0f, 0.1f },
                    { new Guid("a7f245e8-8471-483f-9077-dd0fcbc3200a"), 35f, 28f, 6.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.5f, new Guid("0292d477-d63b-4904-a83b-2cd8cac39c14"), 0.5f, 330f, 1.2f, 0.1f, 250f, 3.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 600f, 0.05f, 0.08f, 45f, 0f, 0.7f },
                    { new Guid("aba17e53-d61d-4f6c-9ef9-276c71f6b762"), 30f, 420f, 60f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), 1.5f, 200f, 12f, 4f, 500f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.06f, 1f, 0f, 0.3f },
                    { new Guid("ad897ea4-e84c-4f27-a5ca-bc1fa9b96a88"), 18f, 20f, 4.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1f, new Guid("fc85f2de-9aae-4ff4-a829-e01662a42976"), 0.2f, 140f, 1.2f, 0f, 3f, 2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.03f, 0.04f, 10f, 0f, 0.1f },
                    { new Guid("aea766e6-f4eb-4f3d-bb20-1a18e75cf620"), 30f, 40f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2.5f, new Guid("00bc33fe-4cd5-47df-bd94-15ac9f93648c"), 0.8f, 200f, 2f, 0.1f, 250f, 3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 600f, 0.06f, 0.05f, 20f, 0f, 1f },
                    { new Guid("af506ed8-7a6e-4a2c-9cb0-5849262287d5"), 22f, 265f, 49f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.2f, 2.7f, new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), 2.4f, 115f, 8f, 0.5f, 491f, 5.6f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.2f, 0.12f, 0f, 0f, 0.1f },
                    { new Guid("afdcf058-1b38-419c-9276-2df798da66de"), 9f, 60f, 16f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1f, new Guid("a504d882-4f38-413e-bb28-fae1f2787150"), 0.3f, 42f, 0.9f, 0f, 1f, 13f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.03f, 0.05f, 10f, 0f, 0.1f },
                    { new Guid("b0939c55-17ce-4909-882e-efceb264b98f"), 11f, 116f, 0f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("5ebbc839-81e6-496f-9e4d-8d90d732a906"), 0.5f, 200f, 25f, 0.2f, 300f, 0f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.09f, 0.2f, 0f, 200f, 0.4f },
                    { new Guid("b0d06e59-11a5-40d6-9582-f0e680103aae"), 30f, 40f, 9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2.5f, new Guid("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), 0.8f, 250f, 2f, 0.1f, 300f, 3f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 600f, 0.06f, 0.05f, 20f, 0f, 1f },
                    { new Guid("b14cb208-2ed5-4635-9b2e-d38b3abc8700"), 2f, 17f, 0.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0f, new Guid("f41484a3-c7df-4530-b7d2-060390103985"), 0f, 54f, 3.6f, 0f, 55f, 0.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.01f, 0.15f, 0f, 0f, 0f },
                    { new Guid("b180efce-b993-4e4b-833e-b2624c4024fd"), 24f, 20f, 3.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.1f, new Guid("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), 0.5f, 202f, 2.2f, 0f, 2f, 1.2f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 756f, 0.08f, 0.14f, 5.6f, 0f, 1.1f },
                    { new Guid("b3bb4bee-f8d3-4d0a-98e3-a7a814c2d36a"), 70f, 306f, 80f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.1f, 7f, new Guid("575e8bca-57e3-4d16-b380-545a046c9a4e"), 2.3f, 1040f, 5.8f, 0.6f, 233f, 0.6f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 260f, 0.06f, 0.32f, 6f, 0f, 1f },
                    { new Guid("b74a6e1a-1d3f-449b-a3a9-2bd71e5f6eb2"), 10f, 100f, 3f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 0f, new Guid("c81a404a-ec10-428e-acec-dd56ec1d3607"), 0.8f, 200f, 8f, 2f, 500f, 1f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.04f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("b84d5059-1268-470c-ba6f-cc335972cdd9"), 6f, 39f, 9.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.5f, new Guid("aaeb8b86-48b3-454c-a299-ec5a627f7047"), 0.3f, 190f, 0.9f, 0f, 0f, 8.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 326f, 0.02f, 0.05f, 6.6f, 0f, 0.1f },
                    { new Guid("b92ab557-8560-42d2-a5aa-d4c352e2c76c"), 20f, 200f, 25f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6f, 1f, new Guid("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), 1.2f, 150f, 10f, 2f, 300f, 1f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.05f, 0.04f, 0f, 0f, 0.1f },
                    { new Guid("b9a842eb-637d-4ce4-871d-9ae3dd631df0"), 15f, 30f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2f, new Guid("827829bf-71cd-4865-80af-1457e0091456"), 0.8f, 300f, 2f, 0.1f, 250f, 1f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 0.05f, 0.03f, 4f, 0f, 0.3f },
                    { new Guid("ba34fadf-949b-453e-8a15-3cc597911404"), 54f, 389f, 66.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6.9f, 10.6f, new Guid("c46676b3-cbcc-49e9-ad44-7d450a481a19"), 4.7f, 362f, 16.9f, 1.2f, 2f, 0.6f, 5.7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.76f, 0.14f, 0f, 0f, 0.42f },
                    { new Guid("ba47b322-d179-4056-914a-546d816480b1"), 47f, 34f, 6.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.6f, new Guid("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), 0.7f, 316f, 2.8f, 0f, 33f, 1.7f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 623f, 0.07f, 0.12f, 89.2f, 0f, 0.8f },
                    { new Guid("ba9c0d6b-151e-425d-89a5-fe37368d3f12"), 20f, 230f, 40f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 1f, new Guid("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), 1.2f, 100f, 7f, 2f, 300f, 5f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("bcf98da6-0420-44ea-b454-35bec5bd52fa"), 15f, 165f, 1.1f, 85f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.6f, 0.2f, new Guid("43d635e2-6f0c-4385-83d8-fedfd479d356"), 1f, 220f, 31f, 1f, 340f, 0.5f, 2.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0.08f, 0.07f, 0f, 0f, 0.4f },
                    { new Guid("bf6914b0-9740-4af1-a865-9214ad878d93"), 20f, 40f, 3f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 1f, new Guid("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), 0.7f, 180f, 6f, 0.3f, 250f, 1.5f, 1.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.07f, 0.05f, 8f, 0f, 0.4f },
                    { new Guid("c00cdaeb-9ba3-4586-b531-03a889684d1e"), 22f, 265f, 49f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.2f, 2.7f, new Guid("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), 2.4f, 115f, 8f, 0.5f, 491f, 5.6f, 0.8f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.2f, 0.12f, 0f, 0f, 0.1f },
                    { new Guid("c0f38afb-36c2-42f7-bec2-267cbfd552b4"), 20f, 250f, 30f, 45f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 1f, new Guid("01e60ae4-ff69-44d6-b4fd-aaf916e3a7e5"), 1f, 250f, 14f, 3f, 600f, 3f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150f, 0.1f, 0.1f, 3f, 0f, 0.5f },
                    { new Guid("c32fce36-a3ce-4f0f-b1c6-2901a5f9bb08"), 20f, 150f, 22.5f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6.5f, 1f, new Guid("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), 0.7f, 120f, 3f, 1f, 400f, 1.5f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.08f, 0.05f, 1f, 0f, 0.2f },
                    { new Guid("c43255ca-602e-41bf-9572-bebbadc454d9"), 20f, 170f, 23f, 15f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 1f, new Guid("a1ff09f1-9d02-40a8-84de-8da9aad67c58"), 0.7f, 150f, 4f, 1f, 350f, 1f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.05f, 0.05f, 0f, 0f, 0.2f },
                    { new Guid("c8ad6a21-ce6d-4de4-bdbd-0ad4af20ed91"), 18f, 14f, 3.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.5f, new Guid("80ba2672-d26a-4703-98f0-d246a50f92f1"), 0.3f, 170f, 0.6f, 0f, 1f, 1.5f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.02f, 0.02f, 10f, 0f, 0.01f },
                    { new Guid("c8c9c006-a6d7-4155-a9d4-76b1f01ed467"), 264f, 576f, 22f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 12f, new Guid("b0f051be-5972-4e7a-a77d-47ec28d58993"), 3.7f, 705f, 21f, 3.8f, 1f, 3.9f, 46.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0.21f, 1.01f, 0f, 0f, 25.6f },
                    { new Guid("c9275372-51cd-4a67-b146-2296db2d478e"), 18f, 271f, 0f, 82f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19f, 0f, new Guid("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), 2.7f, 300f, 26f, 7.4f, 62f, 0f, 11.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.18f, 0f, 8f, 0.5f },
                    { new Guid("ca6d7244-35df-4cbc-80c0-064db53760e4"), 350f, 145f, 5.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 1f, new Guid("50c0adac-c878-4a21-8b5f-01478e7e4852"), 3f, 230f, 15f, 1f, 10f, 1.2f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 0.05f, 0.1f, 0.5f, 0f, 0.4f },
                    { new Guid("cce6c5be-f18e-4a02-af88-9f3a80821631"), 40f, 249f, 1.5f, 80f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, 0f, new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), 1f, 180f, 16f, 7f, 850f, 0.5f, 9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("cce7bcaf-d0b2-4aed-8408-bea831bbbd29"), 11f, 77f, 17f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 2.2f, new Guid("8893c58d-06fd-4c34-9e77-2f50779642dd"), 0.8f, 425f, 2f, 0f, 6f, 0.8f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.11f, 0.03f, 19.7f, 0f, 0.01f },
                    { new Guid("cde22a78-6723-475e-80a7-07646f782bf1"), 10f, 90f, 15f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 0.5f, new Guid("c5e3e4ed-0164-4917-a1ce-99679b971a22"), 0.6f, 150f, 6f, 0.5f, 300f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.06f, 0.05f, 1f, 0f, 0.2f },
                    { new Guid("ce0af9a9-d4c6-48c9-8229-f5b63eeecc3a"), 40f, 450f, 50f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2f, new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), 3f, 350f, 20f, 4f, 900f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.08f, 1f, 0f, 0.2f },
                    { new Guid("ce195134-14a3-4bd3-ba98-1983c06f9bb0"), 60f, 90f, 10f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 0f, new Guid("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), 0.2f, 80f, 2f, 2f, 40f, 8f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.04f, 0.06f, 0f, 0f, 0.1f },
                    { new Guid("ce69c9b1-edf4-48d4-83ee-154fdf8122ef"), 30f, 86f, 20.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 3f, new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), 0.6f, 337f, 1.6f, 0f, 55f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.96f, 0.08f, 0.03f, 2.4f, 0f, 0f },
                    { new Guid("d02a632c-445e-4162-8cc0-c375afd3128b"), 30f, 180f, 10f, 55f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 2f, new Guid("a364353c-d589-4a94-9c3b-3038113ea249"), 2.5f, 350f, 20f, 2.5f, 350f, 3f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150f, 0.1f, 0.1f, 25f, 0f, 1f },
                    { new Guid("d0a9050c-305d-4382-8e4f-0c5b5b436578"), 15f, 70f, 6f, 25f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), 1f, 200f, 6f, 0.5f, 300f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.05f, 0.06f, 4f, 0f, 0.3f },
                    { new Guid("d1723be5-a903-4ba6-b156-b6e593f84159"), 23f, 40f, 9.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 1.7f, new Guid("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), 0.2f, 146f, 1.1f, 0f, 4f, 4.2f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.05f, 0.02f, 7.4f, 0f, 0.02f },
                    { new Guid("d284a36a-956f-4ab1-9629-03b43c1afa96"), 81f, 33f, 7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 3.2f, new Guid("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), 0.8f, 299f, 1.9f, 0f, 7f, 1.5f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.36f, 0.02f, 0.04f, 21f, 0f, 0.27f },
                    { new Guid("d29241aa-283e-4623-bc34-585e2aa7a004"), 22f, 68f, 16.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 0.9f, new Guid("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), 0.3f, 42f, 0.9f, 0f, 0f, 15f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.05f, 0.05f, 20f, 0f, 0.1f },
                    { new Guid("d30c71b0-44ed-483b-b9e7-dfebd43ad075"), 30f, 120f, 18f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), 1.5f, 200f, 15f, 0.5f, 450f, 2f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.1f, 3f, 0f, 0.3f },
                    { new Guid("d36eb1a4-afc5-48de-b41f-9a7b169aa2b3"), 16f, 32f, 7.7f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2f, new Guid("2e641c82-56f7-480d-b216-63723b5a5e7d"), 0.4f, 153f, 0.7f, 0f, 1f, 4.9f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 0.02f, 0.05f, 58.8f, 0f, 0.3f },
                    { new Guid("d3ef9d4b-51c8-49c7-bc24-fe9d45bdfbed"), 99f, 23f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 2.2f, new Guid("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), 2.7f, 558f, 2.9f, 0.1f, 79f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9377f, 0.08f, 0.19f, 28.1f, 0f, 2.1f },
                    { new Guid("d47459fd-6d4c-47b9-9e4c-c7c952f2fa25"), 77f, 35f, 5.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 1.5f, new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), 1.5f, 312f, 3.6f, 0f, 113f, 0.5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6.3f, 0.04f, 0.09f, 55f, 0f, 1.5f },
                    { new Guid("d4b3d964-ba15-443c-b0c1-419facbb56de"), 10f, 20f, 4.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.5f, new Guid("58fe08ca-5c52-4847-800e-b9970c3782f0"), 0.3f, 175f, 0.9f, 0f, 3f, 2.4f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.93f, 0.05f, 0.04f, 80f, 0f, 0.37f },
                    { new Guid("d4d38b17-3ae4-4cc3-8d3d-7cbfb914a3fb"), 110f, 59f, 4.7f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.6f, 0f, new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), 0f, 141f, 3.5f, 1f, 36f, 4.7f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.04f, 0.14f, 0f, 0.02f, 0f },
                    { new Guid("d67a6010-db12-443c-996d-3622b5c63860"), 20f, 150f, 30f, 10f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3f, 1f, new Guid("c16aac77-64ee-476d-a646-a3029da83e41"), 0.4f, 100f, 3f, 1f, 250f, 1.5f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.04f, 0.02f, 0f, 0f, 0.05f },
                    { new Guid("d8034406-0825-4026-b190-05b99813eb89"), 125f, 42f, 5f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), 0f, 150f, 3.4f, 0.6f, 44f, 5f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.04f, 0.04f, 0.18f, 0f, 0.02f, 0.03f },
                    { new Guid("d8129129-16c7-4a77-a28a-955c9b41f9a0"), 114f, 19f, 3.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 2f, new Guid("644f32b3-897e-45b1-b4d7-aa8b9585a262"), 2.1f, 554f, 2f, 0f, 30f, 0.4f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8100f, 0.08f, 0.16f, 51.9f, 0f, 1.9f },
                    { new Guid("d8c72c8a-c2a0-4e02-8aba-49473a2ccdcd"), 20f, 230f, 40f, 35f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 1.5f, new Guid("7378ca5f-f1a8-4c23-a019-50af3012526f"), 1.2f, 100f, 7f, 2f, 300f, 3f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.05f, 0.03f, 0f, 0f, 0.2f },
                    { new Guid("d99ade89-4cc2-4626-8494-df02b3e0f21e"), 15f, 120f, 15f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 0.5f, new Guid("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), 1f, 200f, 8f, 1f, 400f, 1f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30f, 0.05f, 0.1f, 2f, 0f, 0.3f },
                    { new Guid("d9d0b91a-4150-4373-a745-e6824a33777c"), 40f, 30f, 6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 2.5f, new Guid("90a605b6-843d-4cc1-8fe7-a016c76ee29c"), 0.9f, 300f, 2f, 0.1f, 100f, 1f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500f, 0.04f, 0.05f, 30f, 0f, 0.5f },
                    { new Guid("db1c0d04-a48c-4e28-958c-169e042cae08"), 40f, 40f, 8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.5f, 3f, new Guid("eec3d874-6331-4e33-bbe6-bf0cc4335b29"), 1f, 250f, 2f, 0.1f, 50f, 2f, 0.4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 700f, 0.05f, 0.06f, 25f, 0f, 1f },
                    { new Guid("db8e0e97-9540-4ab1-a789-fa8f9971ac15"), 37f, 53f, 13.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 1.8f, new Guid("16bf44f2-711d-4b64-a409-995c6b0c13ce"), 0.1f, 166f, 0.8f, 0f, 2f, 10.6f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.34f, 0.06f, 0.03f, 26.7f, 0f, 0.2f },
                    { new Guid("dbe7f28c-4792-42c8-a4d8-186d00f8d9f6"), 40f, 140f, 25f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 5f, new Guid("8ebd5a6e-b0af-42b6-af58-b681fceac1ef"), 2f, 300f, 5f, 0.5f, 30f, 12f, 1.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.05f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("e0119600-f8ee-4eab-bc6a-74ac617e1244"), 2f, 2f, 0f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, new Guid("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), 0f, 49f, 0.1f, 0f, 5f, 0f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0f, 0f, 0f, 0f, 0f },
                    { new Guid("e0850b10-0283-423d-a2c9-12f6cf7b97a8"), 10f, 130f, 28.2f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.3f, 0.4f, new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), 0.2f, 35f, 2.7f, 0.1f, 1f, 0.1f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.01f, 0f, 0f, 0f },
                    { new Guid("e13db8a1-4094-4191-ae98-ad8d6a655e02"), 40f, 300f, 50f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5f, 2f, new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), 1.5f, 250f, 10f, 2f, 700f, 3f, 2.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.08f, 0.06f, 1f, 0f, 0.2f },
                    { new Guid("e14d7a15-c2e6-434f-9377-23d1db0211a3"), 30f, 300f, 40f, 50f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, 2f, new Guid("05cfce09-72b4-482d-adcd-c0718015be3d"), 1.2f, 150f, 10f, 3f, 400f, 3f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.08f, 0.05f, 2f, 0f, 0.2f },
                    { new Guid("e4443a19-8189-44aa-8f52-92659c56adf6"), 25f, 81f, 14.5f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.4f, 5.1f, new Guid("7cd76708-7312-445e-a392-14f0e806a786"), 1.5f, 244f, 5.4f, 0.1f, 5f, 5.7f, 0.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 765f, 0.27f, 0.15f, 40f, 0f, 0.1f },
                    { new Guid("e4866876-03d9-4bf1-944e-39eff00c21c2"), 12f, 239f, 0f, 88f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14f, 0f, new Guid("c137f014-34c2-4f0a-be52-7c2a5c64abae"), 1.2f, 223f, 27f, 3.8f, 82f, 0f, 7f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.07f, 0.13f, 0f, 0.02f, 0.3f },
                    { new Guid("e4ece59b-346c-4a30-9010-b9c2e480e127"), 10f, 18f, 3.9f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.2f, new Guid("42883b21-4cbd-40ce-850f-b0723f1766fe"), 0.3f, 237f, 0.9f, 0f, 5f, 2.6f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.85f, 0.04f, 0.02f, 13.7f, 0f, 0.5f },
                    { new Guid("e57614df-7bbb-4b5e-9035-19c56b808bc3"), 8f, 110f, 23.4f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.6f, 1.9f, new Guid("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), 0.2f, 60f, 2.5f, 0.1f, 4f, 0.3f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.03f, 0f, 0f, 0.1f },
                    { new Guid("e6ac175a-5547-4061-88b1-4953dca980e7"), 20f, 120f, 16f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 0.5f, new Guid("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), 1f, 200f, 10f, 1f, 350f, 1f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.06f, 0.07f, 2f, 0f, 0.3f },
                    { new Guid("ed3b1505-5b5c-4d51-b591-20dbfa4b203c"), 40f, 200f, 30f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7f, 2f, new Guid("7a253877-3c54-4fcf-bb05-d9f4e14d5b64"), 1.2f, 200f, 7.5f, 1.5f, 600f, 3f, 5.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100f, 0.1f, 0.1f, 10f, 0f, 0.5f },
                    { new Guid("ed91241a-4827-4fd6-9e40-77e2a6ddde99"), 56f, 155f, 1.1f, 373f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10.6f, 0f, new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), 1.8f, 126f, 13f, 3.3f, 124f, 1.1f, 3.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.52f, 0.04f, 0.5f, 0f, 1.1f, 0.5f },
                    { new Guid("ef274c98-ff6a-4ea6-99db-700a403707fb"), 20f, 220f, 28f, 70f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 1f, new Guid("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), 1f, 100f, 7f, 2f, 450f, 1f, 4f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.04f, 0.05f, 2f, 0f, 0.1f },
                    { new Guid("efc9bd8a-38d4-4160-92f2-f2143fcfc793"), 20f, 85f, 5f, 30f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2f, 0.5f, new Guid("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), 0.7f, 150f, 12f, 0.5f, 500f, 1f, 1.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.03f, 0.1f, 1f, 0f, 0.1f },
                    { new Guid("f11adad0-6834-441f-b765-26d81c8abe79"), 110f, 64f, 9.4f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 0.4f, new Guid("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), 0f, 140f, 3.4f, 1f, 35f, 7.5f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.04f, 0.14f, 0f, 0.02f, 0f },
                    { new Guid("f1704e69-bdb8-4189-9e6d-06ae483017af"), 70f, 99f, 0.2f, 189f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1f, 0f, new Guid("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), 0.3f, 259f, 20.9f, 0.2f, 111f, 0f, 0.6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, 0.02f, 0.11f, 0f, 0f, 0.6f },
                    { new Guid("f1e6ef3a-cfa7-4a19-9ac8-9d345469b60b"), 39f, 20f, 3.8f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 1.2f, new Guid("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), 0.9f, 391f, 2f, 0f, 36f, 0.3f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 442f, 0.05f, 0.05f, 48.5f, 0f, 0.6f },
                    { new Guid("f3a8e0fe-a64c-4f2c-b85e-b484e93c6844"), 55f, 35f, 7.1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.6f, 2.5f, new Guid("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), 1f, 450f, 2.4f, 0.1f, 250f, 0.9f, 0.5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 700f, 0.05f, 0.1f, 45f, 0f, 1.2f },
                    { new Guid("f80f715f-e967-4880-823d-b802886d9b12"), 16f, 15f, 3.6f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.5f, new Guid("455bb5ed-ed2c-4172-8831-2b8a08614198"), 0.3f, 147f, 0.7f, 0f, 2f, 1.7f, 0.1f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, 0.03f, 0.03f, 2.8f, 0f, 0.03f },
                    { new Guid("f9248b43-f57f-485d-a4e0-c71de0720712"), 30f, 150f, 18f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 1f, new Guid("cf9ab10f-2094-496b-9018-96b9d2e1af76"), 1f, 250f, 10.5f, 1f, 400f, 1.5f, 3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40f, 0.1f, 0.1f, 5f, 0f, 0.3f },
                    { new Guid("fb8b500f-1c51-44fd-a64c-32def5e138b9"), 40f, 52f, 13f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.2f, 2.4f, new Guid("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), 0.1f, 181f, 1f, 0f, 1f, 9.4f, 0.2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.04f, 53.2f, 0f, 0.2f },
                    { new Guid("fba64663-5137-443a-a6b4-4954f1d7711f"), 20f, 200f, 35f, 20f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4f, 1.5f, new Guid("f0132626-5535-4f30-9af4-7e89e086aaaf"), 0.8f, 80f, 6f, 1f, 350f, 3f, 2f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.01f, 0.02f, 0.02f, 1f, 0f, 0.1f },
                    { new Guid("fc7b9db3-502e-44df-a49b-342152427818"), 20f, 150f, 8f, 40f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8f, 1f, new Guid("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), 2f, 250f, 12f, 3f, 500f, 2f, 5f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50f, 0.1f, 0.1f, 5f, 0f, 0.5f },
                    { new Guid("fd11a07c-e2d1-466f-8037-942e63990e5c"), 40f, 110f, 20f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.5f, 3f, new Guid("2146faae-2e7c-4460-8d81-38f5d313012c"), 1f, 260f, 5.2f, 0.2f, 150f, 1.5f, 1.3f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, 0.05f, 1f, 0f, 0.3f },
                    { new Guid("fd2a9adf-d185-4ff5-8e7c-f492842d6736"), 20f, 250f, 0f, 90f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, 0f, new Guid("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), 2.5f, 280f, 26f, 6f, 75f, 0f, 9f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.08f, 0.2f, 0f, 7f, 0.5f },
                    { new Guid("fd4166f1-cde7-4756-ac27-885b8eba2b22"), 30f, 300f, 2f, 120f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25f, 0f, new Guid("5ff26461-880d-4b94-bfd0-e8badc77fe33"), 2.5f, 300f, 18f, 8f, 800f, 1f, 12f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.03f, 0.1f, 0.06f, 0f, 0f, 0.2f },
                    { new Guid("ff35bf3f-1f3e-46a4-bf48-652b114b1921"), 3f, 11f, 3.3f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.1f, new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), 0.1f, 15f, 0.2f, 0f, 2f, 1f, 0f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, 0.02f, 0.02f, 20f, 0f, 0f },
                    { new Guid("ff82ba05-dd0b-4e9e-a8c4-9d12ec1d3fbc"), 40f, 450f, 50f, 60f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12f, 2.5f, new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), 3f, 350f, 20f, 4f, 900f, 3f, 6f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, 0.1f, 0.08f, 1f, 0f, 0.2f }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "WorkoutExerciseId", "CreatedAt", "Duration", "ExerciseId", "Order", "Reps", "Status", "UpdatedAt", "WorkoutId" },
                values: new object[,]
                {
                    { new Guid("01855ac4-c129-4c98-b601-e33fa433af31"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("58878826-775e-4d4c-8e1b-d5c95afc214d"), 8, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("04ad5c4a-b71d-45fe-b7ca-f5d9c32fdedd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("05c931df-c828-442e-aee1-56432cb772c7"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("0c566bba-9530-484b-8df2-4b31cf4eddd8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), 4, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("0cb5e28a-074b-49a0-8eb6-bfc11b49aed0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("4834f1ce-41dc-4161-ac51-e03ca78b62b8"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("0defc12f-1573-4655-89fa-85cfc228dbb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8b93dbb2-fc2b-4627-b79a-3ec45a7c6238"), 2, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("0ee6f767-4d84-4c0c-b36b-0b476703858f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), 2, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("0eff7920-ec03-40dc-ab30-555eac11730e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("0ff3142d-e452-4338-8df0-bb7e6be8ad36"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 4, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("10cfa779-aebb-4026-902d-1e33b3ca499c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), 6, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("13308031-26c4-430e-aa3d-c2c10d2ebf18"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 1, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("1334eee0-a39e-4af7-b9c6-cda8c45e101c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("153025d8-9db2-4cc5-8a41-a9c10a2266ae"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0c011f92-425a-477c-84d4-3d6dc883119b"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("17e0c654-766a-4a0a-b22b-282b3c0e3270"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"), 3, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("1852d87c-3fc7-4fa1-b2cf-94c7d4ead334"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), 8, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("18a5f6b7-1ace-4022-b319-ee16cbb3d802"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("235f7494-3e7d-45a5-a31a-6d5449b1322d"), 2, 16, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("192505f0-84be-4040-bedb-a5e97e20f4c1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), 1, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("19a248d4-012d-4244-96ba-d72e57077a62"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"), 3, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("1b4ddbcc-fa77-4e22-b45d-a90463d267cb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d4ebca3a-83ef-485b-9178-83d4eab9694c"), 4, 16, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("1c868dbd-28fb-4a41-8603-72dc320c6ae8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 5, 6, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("1e881cce-9bc5-43fc-9ac9-86cb3003dd38"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 1, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("1fb87781-3686-4258-bbbd-9e82092585e5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("1fc18e4d-34d0-4c3b-b01c-25507fcbcaa3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("72206c5e-58f3-46f0-a8b1-031cbf599433"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("260bd12d-ef4c-4ea3-b48c-e61eaa396656"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("d3d944c4-947d-4910-bb6e-636390e5b8d5"), 3, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("281449c5-f94c-4741-8965-c75c4deb6302"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 1, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("28a7e031-a18a-455e-aae3-63a272feabf3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d4ebca3a-83ef-485b-9178-83d4eab9694c"), 1, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("29aa1201-200f-400d-a7a6-4b568044030a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("2abcbcb3-c05d-492a-8001-83c321a9271c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 1, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("2b0e932d-af22-48f3-81e0-cf4c52c85ac0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 1, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("2bd13ee2-7046-4c32-bcf2-d8697e2ddf26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("407ff857-d218-44a8-8d0f-0bfa5d53bf03"), 7, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("2e8190c7-5466-4632-945b-e1b0bb4caaf0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8619916d-a296-48a5-af89-f82a6a1cb26f"), 3, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("319fc9ca-2d2a-4d09-9380-d2963977e330"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), 6, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("3351b839-2e7c-4ad8-a1af-305e863a770c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), 3, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("3498332f-1f5c-4b60-bef3-b111f4571c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a280d32-de67-4a38-8f21-923243489eef"), 2, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("3709b5b0-6071-4683-bc36-24674a94ee06"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0d816828-8a94-4dcb-a87c-b70b295a39b6"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("391be7c8-9657-41f3-9adb-d22e35bf863b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("3950c3bb-9d98-43a2-b094-5566d0f198eb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("5cbc396e-381a-4d9f-9ad6-42b764deee3e"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("3a68262d-a284-412e-a12f-5531b5ca2b9a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("3d3cd4f3-e898-4dec-9f6b-c004628f23af"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("72206c5e-58f3-46f0-a8b1-031cbf599433"), 3, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("3d8b9d72-ef1f-4c10-95ea-4d10d06eee64"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 3, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("3fd96905-6464-4476-aee0-1b26b0c126b9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), 6, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("40b778d3-1eb2-455f-856d-07fb9d9f2b2d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("4125f1a3-ec0f-46f3-ba51-968477455445"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("434779d9-e53d-4356-aaca-8480755b299a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 5, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("4821f41c-6671-410b-a284-2f137937c142"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), 7, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("4944eba9-d302-49f2-a528-7f8666ffb8fc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("4a03a0dd-ff79-4bff-94a0-9bf7b49debb4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), 4, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("4b4784c9-bed9-4051-964a-f50db0baaf33"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 8, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("4f900839-ee13-442b-bb63-ce1e026577cf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), 6, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("5000da1d-b3d7-4b61-b66c-f2f0ece1fad5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 4, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("5057e3b2-52f2-41d5-9d45-45fecfd1af5d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("518375cb-abb6-4d64-ad95-a15cd4bf288c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6d6b06e1-5ade-4dae-b442-7aa200661760"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("51efccbf-79c0-4939-8770-f1bdcea3106d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 2, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("53fe5ec3-dad6-4978-82f0-2415c196494c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("598e119f-6da8-4fe0-afe2-2e6d27805f12"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 4, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("5cb224bb-f84b-4dbf-ae63-b3b66957ab40"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("5db75139-1d4f-4206-8666-63fea9ee43d3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 9, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("5f3693ba-9089-4a31-97a7-63fed0bb5165"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"), 4, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("612e9cd0-008f-492f-a1b8-7f5191fd0db6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 5, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("64069987-3bb2-49cd-b440-cb1088914417"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("6419e197-8b72-45a4-8da6-497024ed3b17"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), 3, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("669818fb-9f03-472f-8787-926ebc9c137b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 2, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("6a2c960f-a8ef-4de6-80eb-eff51cd857ca"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"), 4, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("6bdc28c0-4eb8-44c3-948e-d4ef1d28a6cb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 3, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7") },
                    { new Guid("6c8589c5-a627-44a1-9618-b6fe26fca5f5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 8, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("70437309-2d73-41e5-8785-a0bde049e304"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("71d23b57-bcfe-4d96-9bde-290e8d788f62"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("724593ec-b87c-4185-a66b-3d7fa1e5259a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("23842121-4834-4483-bfe2-2c244f5ecf76"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("741ab32f-21c1-4821-86c0-e5b00124dadc"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("7516c3ec-50d4-4235-bdc3-9f778098fd19"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 1, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("7592aa4a-6d4c-44eb-ac65-19bd8d08c4df"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("75cf160d-c4a8-4f70-9d7e-0938a83aacd1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"), 1, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("764443e1-8749-47cb-991f-4bc61e44371e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a280d32-de67-4a38-8f21-923243489eef"), 3, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("789bd2e8-dbd4-411a-aadb-fab7502b9d87"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 1, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("7909837a-f0c3-4a9e-8168-e9b4667ce0e4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("ca76bd88-8267-4e05-afce-8765546c20f5"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("79e91a30-55f0-4967-a4ee-3ee4c04c6d31"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new Guid("0b702969-cd49-412a-94a1-4f0027ec77d7"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("7a78c9bf-fcfe-436b-b7e5-bbe166067a0d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("7aad16e1-e1c2-438e-9dee-5613883a1384"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("faebde03-bab9-457b-9b45-a9fabd4760aa"), 1, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("7d8b8b3e-2bc8-47d5-963d-acf1f9df3bf9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 1, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("7f149e58-756c-40dc-81b3-0cc99b682f3e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), 4, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("7fe6baa5-5da6-42d6-ab55-8d5816f4d86c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("8042d8a2-6e2c-4e9e-bfc1-79648d150d7c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), 2, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("80f6f4b3-366d-47f9-b211-0f01543790a9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 2, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("82573fb2-a8b8-4d64-9f16-4b99862b811c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("93e22c77-001f-4825-8983-4ec5b643b7bb"), 3, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("84c71a9d-7d41-4665-a5b0-786b258f5fe3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") },
                    { new Guid("859187d1-fb3e-49fc-b743-03fad7f9fb2b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("0d1e54fe-7a5f-4e0a-a59f-ee9f443718e0"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("85a3d49a-175b-425d-a0c3-f5e2fc338077"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 2, 30, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("85ab340e-54e3-4df6-b2cb-c84690fdac4c"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 4, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("88e1ad44-fe3d-428f-9a0e-5a5ff6033653"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ae6eaaa1-c8c4-4f97-afa4-4ceeea19d4b3"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("893324f6-7556-46b4-853a-3baefdd2c144"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("f93d73ba-d1d6-4037-b51b-1fd005accff3"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("8a85e789-4840-4e7c-9dc5-b57f6491b9c1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0a9e1fb3-9abf-4775-a75e-2bb13009a29d"), 1, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("8ab8e67d-45e7-4398-80da-0fb093a424b9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("580069d7-9025-4864-adf2-3037608e9a22") },
                    { new Guid("8c34c369-f793-44f0-9ce9-34b5910f9172"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), 5, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("8c7e5ca0-40c2-46cd-99b4-061b652af218"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("8cfa4395-5b03-4de7-88dc-276572fe45b1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("2696db05-e815-4c8b-870d-23c338479e95"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("8d10f279-7bbf-4f44-b960-ca8914697b7d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("22af0171-257b-43bc-9013-8985472a8c84"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("8d177794-8abf-4a39-aef2-84d03e8548ef"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08") },
                    { new Guid("8da9a1bc-cc8c-4e6b-b0d9-a32101f4f41b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("256e23fa-03b1-4328-a325-512f0860d9b0"), 6, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("8dba0807-e2be-4efe-a3fa-d373361e4f76"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 6, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("8f60874f-4be6-4cd2-8dd9-496824b2ff71"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 6, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("90003dff-a835-4990-956d-03866cb5bb60"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), 3, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("910e4c18-ba44-4e7a-ac53-ec42cc6bdc28"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1") },
                    { new Guid("926dea4b-c8bb-4fe4-9e0d-f249a54f6cb8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("1b2afb40-fb97-49ec-8fe3-81a17c6c9078"), 3, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559") },
                    { new Guid("927907d2-d993-4b7f-a50c-fb21658b34d0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"), 3, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("93818ac7-492f-4086-ac30-74bc184fd32f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 1, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3") },
                    { new Guid("94e91738-4a1b-4562-8ee3-abb25358b086"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("439db970-c7c8-4b3b-9a35-127d31d920dc"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("98caf438-3764-403f-a87a-44ad779428bb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 3, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("9b66311c-6a38-4ea6-8afa-908950f0c15d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("9ca05e76-5660-4279-b1f2-b2c2d3e6b609"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("9ddcac53-46f8-457e-a7c5-fecf66077275"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("3100278d-eee7-4b89-b726-4b76daefabde"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("9e26e34f-ea90-47b3-8869-1bda27d8e1c7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6ef8ed78-0d00-4271-bf9b-edf27a55ecab"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("a02e6fd9-43c8-421c-821b-070f56d92466"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("a24be4c2-2fee-4214-b6d0-0422fd05a9a9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("07a4dbcd-635a-4a76-92d4-8127de619e6d"), 4, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("a298a4d1-8ad5-45b1-a8c5-581a0eb79538"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("efbcb7f9-3585-4a1b-8700-871547b7e857"), 5, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("a3ceae92-d18b-4d88-a98c-b832039aa5e5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 5, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("a46dab9c-44c2-402e-9883-44ac26c681f9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 3, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("a4b19df2-b621-4f0e-990a-9468c65aed0a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d6b2c0d5-110f-4dff-9aa7-91da10a29dca"), 3, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("a64f4acd-6a9a-44e5-bc7a-2e3d2026b217"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("13ca014d-8b75-414f-afe3-3d378ef7fa97"), 4, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("a6b3c7e6-2d43-4631-8c00-51be1a36ca1b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 3, 32, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("a8a4a2d0-8a54-4d52-846b-121d89ef1d5b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2da27966-24d6-4159-9a70-968e20c4036d"), 4, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("a9d95370-0c7c-4bdb-b093-687b6eb8f8fd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 7, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("a9f05c47-ba75-4d29-9717-a6836dca4a10"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("d0dcad19-4c0c-447d-8e3c-092c6d4ad14c"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("aac53b47-9961-4683-aaee-56f0dde74ce3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 5, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("b0ea4568-6cee-48c9-a943-63a14c38765d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("ae6eaaa1-c8c4-4f97-afa4-4ceeea19d4b3"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("298502cf-ebdf-4044-9350-a14606ebe099") },
                    { new Guid("b0fb24fa-0fbe-483d-9c1f-4fa60e468ff6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("9ba29558-e51b-4a1a-a1c4-b747967e32fb"), 5, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2308c57b-829b-4c6e-b362-5b4634af2877") },
                    { new Guid("b2deb2f7-71a0-4dcc-88e5-39481b014684"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("44f8a6a5-04ab-447a-9361-b0e545d12f42"), 3, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("b632ba9a-0cd4-458b-b5c8-55b074565016"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), 5, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a") },
                    { new Guid("b97b1079-b958-4fc0-885b-cd1960648be6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 5, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3") },
                    { new Guid("b987e69b-1587-45bf-b175-64fe84dd5962"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), 2, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("ba4e245c-bc01-42db-9497-57218f500aba"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), 1, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("bd23550b-b4c7-476d-8f03-4503e9f16588"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("93e22c77-001f-4825-8983-4ec5b643b7bb"), 5, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69") },
                    { new Guid("bf74a17b-c98a-4ace-95cc-ec5f122516f1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("c0916027-23fa-401b-b3ba-3a3d9a5a3c28"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("c076c867-b379-4889-9428-5bc1ae76cbc7"), 1, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("c1f94985-e392-4ca9-b166-1ea7bb6dbb61"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 5, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("c29fe6d3-4f36-4e46-a9a4-bb5cd741d223"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"), 5, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("c2a7e2b3-a222-4e32-a55d-2bd5223d9a1f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2e787245-7612-41bc-9b75-7a4857282350"), 2, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0") },
                    { new Guid("c461f6af-4da3-4166-97f7-e2d82caf2e6b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00") },
                    { new Guid("c54f46fe-c523-4409-939f-4901a6e11247"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6749cbc6-0e28-4163-95e8-7fb2a27c54cf"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc") },
                    { new Guid("c57a4460-58aa-4baa-8148-6ae89c1187b9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 2, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38") },
                    { new Guid("c593a6ac-281e-4412-9b09-c57766532e81"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2") },
                    { new Guid("c6079389-5fe2-4803-806a-dcdeaf9d3626"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4d4ca701-48a4-4385-a9b7-511cf07ef775"), 4, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5") },
                    { new Guid("cb5304b4-e893-4ff8-9ba1-79d2b2547232"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("9ba29558-e51b-4a1a-a1c4-b747967e32fb"), 2, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13") },
                    { new Guid("cbe656a0-38e5-4c4a-8060-62fd18e35ece"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b2e62599-1f8c-4fc2-9ca7-8ab7aa571d4e"), 2, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("cc1d50bf-4708-4636-87ea-c1f7a567a880"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 8, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("ccc513f7-bf53-4b7e-9659-bf146568c54e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01e6141a-930e-4126-a2c6-7c32a2ccdd43"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("ceea1ed3-2af6-4f81-815f-51f4a94bf905"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("425fc485-239f-479e-a4da-b1fe6aed6822") },
                    { new Guid("cf4ee3d1-4b9f-4c23-b2f4-949492f13fb9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("92ddccfd-7076-4dbc-b96b-9197cd4cc308"), 3, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032322a9-a232-4030-bed3-0ccf952d5cff") },
                    { new Guid("cf89c726-3f08-4a15-9108-56f383deb700"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("587228d2-b0a2-46d4-8f0b-e728a3726993"), 3, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4") },
                    { new Guid("d1a8631f-f0b2-4b49-8f42-60919533b89b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0") },
                    { new Guid("d24dae27-7d20-4247-a2a8-1d58cc475a0b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("58878826-775e-4d4c-8e1b-d5c95afc214d"), 6, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("d378e420-0958-4828-9208-1c3bb5ed97e8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("d5b80af8-c3b5-4f88-b529-494cf1308d92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"), 7, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("d63aea8f-930f-4154-ad0f-8ed41258e59b"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"), 7, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc") },
                    { new Guid("d6516622-eea5-4e91-a2ea-2feef5425d6e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), 1, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757") },
                    { new Guid("d7c68e60-45a3-4c47-aeef-0a6494c82c23"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bc06f6c3-3625-438b-9563-3406e50612ee"), 7, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("dad4e1ed-e742-401f-97be-4364bb6801e8"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("6fe4dcc3-5262-470e-b043-0db293dda2fb"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("db0750f8-88b9-49c0-9e55-8c8d2403b2d6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 5, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64") },
                    { new Guid("dc3c5df1-f80d-4f14-9d7e-1dece2d1f7ee"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("68018365-010c-4ab8-81f4-05a5cbfcc24b"), 5, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1") },
                    { new Guid("dcb3aa7a-c054-47f1-accd-7cb8a20dca85"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1ff0ef05-4387-4483-8de3-0ef6d7724afd"), 4, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("dec7454c-115a-42a7-b6d7-4d033f67a281"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 3, 30, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("dfdbf271-33ec-4677-bc83-994b8b60cbcd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01dc4c46-e1ef-44bc-9f19-ecb283bf27ce"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("e14f65bf-3eda-4540-888d-09d26d7c0e55"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("bd976f53-25f4-49ba-9943-4c92a2a7eb89"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270") },
                    { new Guid("e1a2497e-2162-4aab-bb32-603aa548fc81"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 3, 30, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf") },
                    { new Guid("e8d88eb2-5c63-4d32-9393-6edc3fed8775"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 4, 6, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("eb1cbbfb-47e8-419b-be64-95f52a6c19b3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("30be3b2d-bf46-4e90-8139-41411971cefc"), 3, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("eb57ac57-8d10-4018-a14a-191820487681"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"), 5, 8, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("ed043dcc-ec25-4130-b0fc-605f6c0d1ba5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("23842121-4834-4483-bfe2-2c244f5ecf76"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f") },
                    { new Guid("ee317c62-95c8-4290-9b8a-0a806202f281"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4e76715f-6578-41d8-8315-cdb23340fb5a"), 2, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2") },
                    { new Guid("efcaa2c0-7ae7-49b6-ada5-f471ac32cecf"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6badb5b5-ad99-4b89-80c6-e52d0f7cd7ba"), 4, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788") },
                    { new Guid("f003bb75-f06f-4a64-8922-d1777cefe272"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("385f13f7-79bf-437b-acac-745b50485b9f"), 2, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a") },
                    { new Guid("f0197cb8-327f-4ae5-b558-9f531aa112f9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("546e3f6d-16be-4d13-8c15-3947bcf15b1f"), 1, 0, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("f0f59b20-544a-40ba-a338-5399daf31e95"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("9dac0527-8042-462b-8f23-7a6b503efc68"), 6, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0") },
                    { new Guid("f3b1e0a2-c0d5-4172-88e0-4c807e676383"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 5, 12, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563") },
                    { new Guid("f45c0761-af54-4934-9b48-ee659e5b6831"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("6ffea500-ca35-4483-b049-d8593b2c8680"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f") },
                    { new Guid("f4674786-42f3-493a-84db-847968ef4247"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a4c84cac-058f-472a-8b81-a00c025eace4"), 1, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7") },
                    { new Guid("f783ce0f-5f5a-4263-977a-83a5cb2c555a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bd80fdd3-c46c-4410-b126-51a11a8a2f5b"), 3, 20, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03741247-6b2d-49a9-a656-7fc8343747bd") },
                    { new Guid("f790e4a1-c936-44c2-a1b0-448d4d496c8f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("a9629bb1-7d84-4e14-8898-c3bf6c932efb"), 3, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b") },
                    { new Guid("f9235b94-49ff-4dd1-9b97-6247307c36d3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("01e6141a-930e-4126-a2c6-7c32a2ccdd43"), 2, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783") },
                    { new Guid("f958599d-b435-460c-8b2e-0564a27f3aef"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3409fd0e-659a-4ee4-8157-60e2ba94350c"), 3, 15, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee") },
                    { new Guid("f9925967-1258-4a03-bf7f-91bdd6c39beb"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"), 1, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea") },
                    { new Guid("fe1ac130-f7d9-4db5-843b-588f2da3d5fe"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8fad349a-913c-42dd-8bba-c1bc267918e9"), 1, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb") },
                    { new Guid("ffc77841-9a61-4b7d-86a1-5bed02e39986"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e7a186ac-57ea-47c1-8656-7419571b8cb4"), 3, 10, false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54") }
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
