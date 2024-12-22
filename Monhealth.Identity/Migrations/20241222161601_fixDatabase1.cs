using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class fixDatabase1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodCategories_Categories_CategoryId",
                table: "FoodCategories");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "FoodCategories",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b004deb1-dc6e-47c6-bdba-7a45ae8aae91", "AQAAAAIAAYagAAAAEFyvhpaND+C06c2i336oJRK4IwMiVNiiSbYQj+NSkaoF7riIfGaY6/08Tb3sH06FrA==", "be6f8a37-afd5-4b64-8eb5-cd3aef436f1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af13ac25-d41a-4f9c-aec1-a2b3a38434f4", "AQAAAAIAAYagAAAAEJ01QAJCiZcOoTbVfhEtJuXnFHkiwkSpit4yT5F9JMAYQUyP90S5Kmt2Xl4TbWmO8g==", "75c748f0-d330-4a05-9810-543ba09f042a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d43a2906-b133-46d3-8e7c-5671e79d3e2b", "AQAAAAIAAYagAAAAEK1OUp8Db4mXW2k411/kmgGwqK0eYOiSTv8iLE1YcXqRWakcFBaHN/C0Mfd8HJPVuA==", "08407362-5829-4d0a-96e2-0b4e765f5d93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a49bf898-9760-4a1c-ba3f-4d5e1c0b4543", "AQAAAAIAAYagAAAAEJZc8j8GYbmyZRm+rertrksvUDc/WJS1N5FaK1qFkjrMsKvZAZRf8o+DXYJjWIm8rA==", "d2418428-3709-479e-a729-b1a76a7b56fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "042b0cf7-df8f-4a58-9aae-496218ebe62c", "AQAAAAIAAYagAAAAEAO063/ZSTGJct2jbG0lLxX9indW+WtBScTHlT1RqcFFcHMvyrO4BJKBkAcqvIV4nw==", "58613a01-ce95-42d6-b30b-404b852bee2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29b6d84f-a475-4a97-825c-44ce32cf377c", "AQAAAAIAAYagAAAAEO69TwBPq/lPIMaTtRjrB4hZpNfZKKa/iZVMCmj6xyhwgmRQjFveAdDanfPMhAO5iw==", "510d3c5a-6db2-48bc-b7a0-a8965f4479fc" });

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCategories_Categories_CategoryId",
                table: "FoodCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodCategories_Categories_CategoryId",
                table: "FoodCategories");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "FoodCategories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d35a20b3-fcd0-4917-831d-e08e4508e611", "AQAAAAIAAYagAAAAEFaMffqffuRc8AjaSv9e+LyaowCl209uLy+OTGukKv5peFD1wXWvtyXz0ztVxv47IQ==", "21042746-5e7c-4e65-8150-a2f5411ecf7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "673f5903-2780-45f2-b5c7-399a144883fd", "AQAAAAIAAYagAAAAEAFRMTaJOJv+pFpPAuJIFa0VL5E3snQDcknmo14ypE65jySV5WpOfsNluHSqQh03lQ==", "d65359ac-8fa4-40c8-abd9-c80448b91940" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b606e68-8702-4fe4-ae45-76c6b656d14d", "AQAAAAIAAYagAAAAEJ8gno4MGE3+yTFymrZkBQHRmjHB7Cvx/E4SIOLWX11gDrRsG+MGYdh2bwCXj4Ey7A==", "4175cf2a-0143-4c58-a6a9-95e4825ab7a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11a9deec-32b8-4f97-83c9-ac54c7f1afe0", "AQAAAAIAAYagAAAAEDXUmwbHKNgRsMBdqQGOnrVSGyu0mAOXxqRvOi1z7Fii6iIsY+8QfFhROpSD6z0NbA==", "4a371ef1-d0dc-4dfe-868f-36f98e63fb67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "442ac8ed-8d29-431a-a3a0-b1abb440c5b7", "AQAAAAIAAYagAAAAEM46ZziHTuMbevJr4/QoU53FJBpdpT+zAZpl4DsB9OeVEtM4Ee3f6CJB2DVQuzXM6A==", "1fcb25a9-7486-47bd-be9d-12ee7419663a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d161da17-2b18-41b3-bd23-d67f75330ee3", "AQAAAAIAAYagAAAAEOHmDynm45TQUDgtr6GgiM+ICbuOI3aCaRzyOkbjAVf91NrgIgA6TxPDK9Db8t+xMQ==", "a97c99a7-6511-4082-8165-6ca6242e3cee" });

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCategories_Categories_CategoryId",
                table: "FoodCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
