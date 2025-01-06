using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class removeTargetTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealUserFoods");

            migrationBuilder.DropTable(
                name: "Targets");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Goals");

            migrationBuilder.AddColumn<float>(
                name: "CalorieGoal",
                table: "Goals",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "CarbGoal",
                table: "Goals",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ExerciseGoal",
                table: "Goals",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "FatGoal",
                table: "Goals",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "FiberGoal",
                table: "Goals",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ProteinGoal",
                table: "Goals",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "SugarGoal",
                table: "Goals",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "WaterGoal",
                table: "Goals",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "WeightGoal",
                table: "Goals",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b749be3-e4e6-4d3b-a278-0c4b21b7196e", "AQAAAAIAAYagAAAAEBxQ5hTjf7UPve5s8jkhPC07QZq3C504BMv0CymTQGKdzPM8o5yrmuz+rtJshTVNIg==", "67ccd56b-055a-4892-9674-a68a9b38bc71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d4c02ca-c3e7-41e7-b2e8-a4ae4c605026", "AQAAAAIAAYagAAAAEN2s+tCr+vHglhcVZv6FGs25c0h/Jmjjz9+z0XO23VOSw999Az9uzMht4kYpIoYxnA==", "21407be0-ddba-4ccc-ab2c-7a52139a9e93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89beeb21-8726-4785-ba67-def1090062ae", "AQAAAAIAAYagAAAAEHyrbpQjwWyMA/xfx4tVlctf4yliG8oNruO8LM3d5qoPI5ec2VBX8TDC+F/v0ooZHA==", "e638e140-acc5-4763-9fa6-a289504fcf19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "509be4af-6937-4d79-8580-4b00ad1394e9", "AQAAAAIAAYagAAAAEAqmYj3BFEWtelJniGeSujBHDsH7hNzdCmKzIWxUS/wJLwcrGVA7ddgDRXQxWS/HFQ==", "7d6c2bb3-5a65-4bcb-a7b8-c780ff00b801" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b9d64e0-f559-4a3d-a031-c3d6299cb36e", "AQAAAAIAAYagAAAAEGNyfsv6E3uNmxlSNBvfcs6qx/N+pGKGT8MJHxnmqDMtGVvQ49E+Hq8SRncpRAQHlw==", "9fcaa475-9e55-492e-b2ef-5c351043da52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43a71812-f963-49aa-88f7-0df35aeb952f", "AQAAAAIAAYagAAAAEPWn1wUQWgBcx1K9AK55/utJNvzZ2dd1sicMRwz3eMbYJbzKn8nElesMHh08v0nJ8w==", "297a6fca-d9e5-4a93-a329-da6ee386d2ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77371162-6a07-4f76-82fe-45dccff74c8c", "AQAAAAIAAYagAAAAEKqGdhH9p2F4qnCHVFJJ9UQ9an4IVubnBshMCW8hK+z0vgtGThZWFbeYNReJx2n8/w==", "58b493a4-595e-4a1c-b79f-bf8f2506620d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CalorieGoal",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "CarbGoal",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "ExerciseGoal",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "FatGoal",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "FiberGoal",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "ProteinGoal",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "SugarGoal",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "WaterGoal",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "WeightGoal",
                table: "Goals");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Goals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Goals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Goals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "MealUserFoods",
                columns: table => new
                {
                    MealUserFoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PortionSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Targets",
                columns: table => new
                {
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DailyCalories = table.Column<float>(type: "real", nullable: false),
                    DailySteps = table.Column<int>(type: "int", nullable: false),
                    DailyWater = table.Column<float>(type: "real", nullable: false),
                    ExerciseMinutes = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b617e2bf-c818-40fd-add8-16f789877d72", "AQAAAAIAAYagAAAAEFYeogESRyr1LFEHo22t4PcJ6IKfP0js4Opludkj7yKJIP0M/rDlPsDDnhmMFk/C4A==", "a9834bc3-5c15-481c-9b3b-78f9cf98f448" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dddcd90-0502-4dae-a584-d5cb4256c00a", "AQAAAAIAAYagAAAAELMJbXPpM2oAhuk50XVLHTpYuTACMAfx91eSBMPGi/RWClDFUeY4Da9htgFjw9NH+A==", "97129e58-2eb9-42d5-9d60-41a31a330856" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "103a2080-d857-41f0-860a-4b6f0153f762", "AQAAAAIAAYagAAAAEG6Zd3l8dCyezdAa8KFnyOcmbFtAQHpwX/5vJt8WQvp6yS+MbvKVeYR24lxnZ4VUJQ==", "229f67ed-d467-4b4a-a88b-96205368e748" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68538849-1db2-4f1f-bd42-9456e2f3ccea", "AQAAAAIAAYagAAAAEJ+B250WfStkSTNGaV8Qz7B/BRyyMJrI+Ny6/QyCATwdQl+3b6k5Zzyh0k7mB5K+Lw==", "f1bc8794-c74d-491b-afee-25c22dbaa963" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "722aa262-7d8b-43f4-9661-cc971605b488", "AQAAAAIAAYagAAAAEOnFHTOhBFqS1V555jV7gmmr1FsiKx/hJUymW5vpDNwps4/pjy3KjaNdnqcuWjIPLg==", "f3d8556a-eceb-43fa-8940-be313950bf85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "567e4bab-9aea-40be-862d-08e94636247d", "AQAAAAIAAYagAAAAEKR7Yn8j73r/fvNA7qK3fy55+eKP6/46wr4nOimz4gnpLINZ/SQFio8sraTd/jNcrA==", "33f4ae3e-fc42-43da-a234-46d054afa4ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11e1b597-bad3-4449-bfaa-a32891601e1e", "AQAAAAIAAYagAAAAEEos+nz2n3uVm4oddxMYptgpyCnobFozOPRBDIrwOVqNzBl7sEN77ZhBCmM+NO224Q==", "24aa9299-222e-4b83-88e5-8f4d67a7ac3e" });

            migrationBuilder.CreateIndex(
                name: "IX_MealUserFoods_MealId",
                table: "MealUserFoods",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_Targets_GoalId",
                table: "Targets",
                column: "GoalId");
        }
    }
}
