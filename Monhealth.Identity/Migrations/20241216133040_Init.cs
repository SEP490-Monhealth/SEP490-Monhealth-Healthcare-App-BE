using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categories",
                newName: "CategoryDescription");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abc0797d-be72-4d2b-b995-8b1cf65331fc", "AQAAAAIAAYagAAAAEOY30ehjYVGCQzK8FJ5Ra9L5KDl3PBk3TXAr4WPF/XEaviSqpu9i9yrcMqLzm8mNuQ==", "8d917ada-ee3d-48e5-8011-0068d8550881" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce6c8850-b166-443b-ac8b-0fbd9e702fbb", "AQAAAAIAAYagAAAAEN3QaUQHdWCpA/0l44K0Iq2o3nu4aJelK810lIxf8X48oUl+mcp3MUJ/GkAv8Th9dg==", "e61cdc9e-44c9-4ffe-95a0-263d410adba1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5595cb6-9c1f-4a92-b7e8-a33fdf9f83e6", "AQAAAAIAAYagAAAAELe7mtLMMce4SlNDNdzYqYbhWY4BA4Hl9ApymVOJsphrHX769wIFcRnC1rkUdHkUwQ==", "8f31a96e-64c5-448c-8db0-54b582e6bd29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "621d9d18-cd88-4a9c-9891-e89bad7bc8ba", "AQAAAAIAAYagAAAAEKDl9/M5SdVBbVkaT+rH8+cdsWqytuC+2pdOsbvJr2k+aHhYIwCd6pUwPLqmiS9dhA==", "d173f1e3-a2d2-4a54-a8cf-fc575c464c25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22224370-8b55-42ef-b67f-f2ecf689c54c", "AQAAAAIAAYagAAAAEO6hbqQbgiDTNPIaouxLkMWyZYgGKCU2ylaIwot5OeMm+zXFbrR7sygk/wXRfedtVw==", "3316f297-16e1-40d5-98bb-a74958392595" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a877b67-b53a-4aeb-bf14-00f47d70a753", "AQAAAAIAAYagAAAAENxf6+svq3wID8BEtRQzRwlEThl929nn8W3sbfHwPS48WK8RsCUMHDFZHYa91/VKDA==", "822223b6-4c45-40d5-8a4f-1aeeb6a145f7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryDescription",
                table: "Categories",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e0ded6c-ab6a-4d57-b95b-ee6079c493fd", "AQAAAAIAAYagAAAAEDjl82T+jhMdwdGz2kq9qltPi4SJPbbQkQ5YWzVHSHqHeG7iqbywpQzynidkBoMISQ==", "faaaff38-845d-4b56-a067-063a16929b73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa2e8b17-d7b5-490d-ae8e-5e2fd6f3b337", "AQAAAAIAAYagAAAAEDfsMVft2LAZl7Rg0Jf+nVV5UpbQDJkNAIvM2a4FO+u8X8Y8PC/UL41Y/1oS4kEFWA==", "c331bc27-2a70-45b7-ad9f-6d349bebb896" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e227910-1bd9-4423-9a3a-aeb501f71927", "AQAAAAIAAYagAAAAEEX0Vp0aidbdx4w7U86BcCYh6IoFJ6qeXt3VuXDlb5PhJPUzNxkqyxDGbZPHtjx/sg==", "ecf82e37-f168-4b98-bd63-db532d96056a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d397a00e-eca1-4524-b956-7efe506762d2", "AQAAAAIAAYagAAAAEPtrDEaSqf05D9XX8rqua516quxDix8TigihFwLn8jCf8YUkSWcFj0K1toL+Rqxk7A==", "11f7fe6c-747b-4eba-9de8-014d267c2748" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7b5d642-8970-4573-9253-4da43dd694b3", "AQAAAAIAAYagAAAAEOq8/IU47e2CEifN+BBuxqpMI5gmR5osnhirnYJXwVn+ccYgVt1w6KaVC8HtYlbZhg==", "25ac4e14-e3d5-4155-b49f-c9e6ea2c73be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7abec34f-ed48-4a52-8631-478208b796e2", "AQAAAAIAAYagAAAAEEmWGuqjCU0muLmDLrAVQzjYu7i48pVHgJKWrRdhGZ+UqKf3Qll5FG/pIVE6sFwdvg==", "5c1048cf-fbed-47bd-98b3-8f5d49f63c2d" });
        }
    }
}
