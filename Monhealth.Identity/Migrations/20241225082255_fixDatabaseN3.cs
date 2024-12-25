using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class fixDatabaseN3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Calcium",
                table: "Nutritions",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Cholesterol",
                table: "Nutritions",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Iron",
                table: "Nutritions",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Potassium",
                table: "Nutritions",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "SaturatedFat",
                table: "Nutritions",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Sodium",
                table: "Nutritions",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "UnsaturatedFat",
                table: "Nutritions",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "VitaminA",
                table: "Nutritions",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "VitaminB1",
                table: "Nutritions",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "VitaminB2",
                table: "Nutritions",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "VitaminC",
                table: "Nutritions",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "VitaminD",
                table: "Nutritions",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "VitaminE",
                table: "Nutritions",
                type: "real",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f82ae142-a062-48c0-941e-17ff441bfd9b", "AQAAAAIAAYagAAAAEPiT55qZukBMEs/MRaB5VcXR7SBX4L0qXA3gIPLivzDlalnE57yQUBe9Gv9+/4vgGA==", "db0a8db3-db23-4d50-b734-816da06a115b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86fbf325-2f29-445e-b9b8-c1fb977395f7", "AQAAAAIAAYagAAAAEAMBA90iN7NOkGpwQwnvAY1pAkXAOIZhrv9lePFUN7ClLgxc2B/QG0tiNxArnWyemg==", "b2e1e90d-45ae-4f75-ba8d-e710e5c84dc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "836b5b59-81fd-448e-9693-73642f5fcdbb", "AQAAAAIAAYagAAAAEBPpD06aHbASxXxNQQtzUzs+U89uy81WctLtorsWKhQO8wUjDMrDlNMk/uq11yQVtQ==", "28e3ec11-2345-4180-a7ba-9f6de1e01a8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37e33ad8-412f-4685-8eec-a68a9672e1ec", "AQAAAAIAAYagAAAAEGck8kdPuLXqdxZkVewkmkwHCpPXH+g04f3MLnVehXOxX0ouTKT0C/ghd01fyW30rA==", "8a5c27a2-cbd4-4909-a6c9-4c6617a8ce11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86998557-d238-442d-8aeb-3b0bddfef27c", "AQAAAAIAAYagAAAAEJRDUxC2BV0fWD87BdzyRCbv3FXx/srbVRP/ZGbgZaj8HvPwPRPFExHh140J0ZYIZw==", "ccb6682d-6f2c-465c-a0d7-559ee97f7607" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21b34ed5-cb75-4191-922b-d4afee447a91", "AQAAAAIAAYagAAAAEDChzqAU6L5Sr361MW78twQrZXOo3Omh9KM+Fq5+OfngT+3Tliq96MqZ0vdiCO5rJw==", "8d31ff95-ffb0-4cd3-8c9d-fbeca767c8c1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calcium",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "Cholesterol",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "Iron",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "Potassium",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "SaturatedFat",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "Sodium",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "UnsaturatedFat",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "VitaminA",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "VitaminB1",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "VitaminB2",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "VitaminC",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "VitaminD",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "VitaminE",
                table: "Nutritions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce591a76-3904-4a25-989d-5efd04f2fd3a", "AQAAAAIAAYagAAAAEFZl0SXFYo61CUiJOrgXKrdWgFS+z9cZa7AysuVUlWK54szLEDfK0wEq0Nb+/q5apg==", "a1d2d5b4-e579-4fff-ae34-4c4e969510ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d670377-b4be-4e9f-b1f0-f251410a4599", "AQAAAAIAAYagAAAAEGFri8s7hiKez3TMPV6K7XOvvZLvUb1P0di/NZJyFH7u71dh3g7d2IZDKW4fhPKjEg==", "f2600d28-4763-4711-9be8-eef28123499f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04cb390b-4008-4c46-9493-95ff62967622", "AQAAAAIAAYagAAAAEGl1m+YzmedQqT3zkGohWgU4UJVVD5baBSZoV2Fkme2pr3ozFRbaBsvhjnCJuyYK/g==", "63248b0b-1a01-4481-9d42-38f8587ad801" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84fbd30e-5530-47a2-aae5-29163bacddf5", "AQAAAAIAAYagAAAAEOY4bH23R1inUB5/rnsRkz+UK9mlmDHCnqQg7F6l4FC9PAreyLiRTmJb+j46YSg3LA==", "51b0ad1d-e562-462f-aa46-2c86a607a9bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c5453a8-245c-4424-821e-f88addc67032", "AQAAAAIAAYagAAAAEEsy0B5Ilkg6h9TylZhLs77IConbjb3rNrJBx6pypM0A1eLP9E0IyIRB2hOr88x9ag==", "efabfa99-8a62-4ea9-a280-d74449364b5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da598341-b74c-403e-8182-c28c0a976ee6", "AQAAAAIAAYagAAAAEMe1m5tMqOUCCEkKbMr0/NFausTNB8VdvsX/XJ/3o9x0NQFeY0F4ej4lugqZJfMWFw==", "e307b77d-68e3-4d87-9ae0-9b8cd100b028" });
        }
    }
}
