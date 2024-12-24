using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class fixDatabaseN1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryImage",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45322bed-3b9f-4421-9574-34089ffffcd2", "AQAAAAIAAYagAAAAELdlWjtaLVjIomCQGYvV0E28sVYRmOzKxeFEPO57Cy9ZYn4dvCgJEkGdeG4v+rcUBw==", "4c19ef2c-d3b5-4e00-978a-f410b4814ff7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6099b8cc-e989-4739-acbd-5ce711b167d8", "AQAAAAIAAYagAAAAEKvwCMZ7WQRnjf0YtjVQNHqyDVC9nbyv4C5/3o+SRwnDd83FtaMYP5jd4hKzcaVcPg==", "3727ab10-fb97-483c-92a3-6a4d57d37d1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfa809f5-b9ea-4233-9a4e-6446114546db", "AQAAAAIAAYagAAAAEIXWNdyv/EAwUZ1hMe802Pr+dspA/lPe+fmTiAqOeKBAGACRdMkAHCC4vPRaghjM2g==", "4e016d57-673b-43c6-8b85-cc8d5842b821" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2159b898-a595-4d84-a851-7707cf68ba3c", "AQAAAAIAAYagAAAAEH5XsoRO99VQjFYXSMwgX0HEizhlwJNUiNoM5Uj7vx1WwnTQxNBM4W11TH7fd2G94g==", "91e2f3e2-bad8-4b78-9ea5-2831455f8af0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8554e28a-660b-4e10-98fb-b8a1b442adeb", "AQAAAAIAAYagAAAAEFhbcIrED4prehdFCT2BrTK1C34bvHeefEJvowOBRuCi5URlA1ycep3TQ0XQgHG4Zg==", "64011dd5-3a66-4317-a88e-2e0dd668f194" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf1bfd3f-cf3f-4fe1-955b-ac5ac633dd7d", "AQAAAAIAAYagAAAAEH7VI7gY48xjH9qZeOjFcr51GEFrmSGEDP7EnorNjKlNTUt7QGUK0LNf3ui+VXvUDw==", "4311cdc0-40f0-40e8-9825-10443cb78044" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                column: "CategoryImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"),
                column: "CategoryImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"),
                column: "CategoryImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                column: "CategoryImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("78651ea5-2013-4e50-a55f-714de91a712d"),
                column: "CategoryImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"),
                column: "CategoryImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                column: "CategoryImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                column: "CategoryImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                column: "CategoryImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"),
                column: "CategoryImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"),
                column: "CategoryImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"),
                column: "CategoryImage",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryImage",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "347005ba-992a-477c-85eb-c915867e1e98", "AQAAAAIAAYagAAAAEP87J75MzyA/XPi9hQUzYM1ZY7PHVZ5vcvR1ZDRVDaK4vXIhombi+TJWM9GpfYVd3A==", "dfe7254a-1fda-4efc-b003-509b12bf177a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e59b390-b67a-42cf-9dfa-6c94e6cd2ff5", "AQAAAAIAAYagAAAAEOG5PHpKcfdlTELBxKAPnMTa+OTNlZLsLYegc80/foxhNHvtNHwoQyyS39VN9PF6Gw==", "044f63bf-cbfe-49a5-942a-e9454e61c636" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7186b11f-7a7c-4585-8d49-84daee4c4879", "AQAAAAIAAYagAAAAEPT58OoVVhSrFdSQtjY94Ntzb6/B9bIf7oeNvv5yIoz0YaPDJAqIsADC7V/rmSr47A==", "919bef4f-84ef-47d0-8037-3ba08933e112" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6216104a-62f6-4a3e-b300-9b1cfc5f89ac", "AQAAAAIAAYagAAAAEDHDuJGv7FfOE32sozs5zzTwsxdpV+MMVOh9/Ymk4N2wmd54U2F4pCWcwJFhRbPTzg==", "2d2d88eb-fb69-4696-9a7c-d6e7e21bf5c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ee69d7a-1c28-427c-9a18-ebc927693696", "AQAAAAIAAYagAAAAEP0ZJZPB6Ojykq9CBuMm+SiTBrMPCs6HUsnM/avBa8bLK/d0MmcwMQnVqF2cpTFBTA==", "9c8e8028-4373-4308-b68a-c135a3b5d0fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "855c143f-f35e-496f-b2b4-45a514ffc63f", "AQAAAAIAAYagAAAAEGIZx04H6JZzpwi6ttH+5ITJ4P2JYWg5a9k4uH8nZl24ME/OKaGkoDz4k+rFZHkiFg==", "d6027e30-cfd1-41ba-9362-7c279a1324f7" });
        }
    }
}
