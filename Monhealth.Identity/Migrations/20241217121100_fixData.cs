using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class fixData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods");

            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    FoodCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.FoodCategoryId);
                    table.ForeignKey(
                        name: "FK_FoodCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodCategories_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be559302-bb2f-4ff7-87ff-edd825b9ee6e", "AQAAAAIAAYagAAAAEPXBdzOQJ7bGIURfOZASnOGn54akIXeD1b5BoJ04UmLEk4lvgxKkB/KcmqPcecaNTg==", "0d5e9330-7a7f-4dbc-ab80-250673ff6e47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3de226b4-ba1a-423c-9b3c-2c5816ec8c81", "AQAAAAIAAYagAAAAEHK4GA/omOAB5OGjbK3XG3Ixt8V8l1oX9BPB0LsDj+de0KZrBFANY/oGtf/w33Xf3g==", "51119a2d-332b-4582-af75-77ec7e91fdc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d08616b-0c52-4f16-a456-e9879ee244ab", "AQAAAAIAAYagAAAAEE1vehJdlkwrocvFpOl26jnSph1ssKN/QUDo7N7Dmi17Yy3OhM0Jsu94Av4KcT2CIw==", "c21199f0-107a-49e5-bfd8-940a6a392b52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "232a3f4e-27d9-4667-bfc2-bd4e89c64d7b", "AQAAAAIAAYagAAAAEJ1G8TUnPptCo9x0Vlou14AVhNZPszycP1IyQdgfounzveTtvt7dgNc77JS6CkNr/Q==", "66c4fb11-6e74-4750-890a-0d24740941e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "feb1d4ff-93b5-4434-99f1-8c6642f7a14c", "AQAAAAIAAYagAAAAEHxIORQoRUyCMyyRktK3vO8ZI1JjfC8Fa461whwbCvJ4BqGkHDIV5lT8UJknkn7VGg==", "a7799bb3-2127-4740-bf3e-6c328ddde0ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "870e27db-5b27-4501-9e1b-a4df9993b57c", "AQAAAAIAAYagAAAAEFP4br7WbgfomrhEaESr4Ja8Pw7d+T0IGVrAXH2BuIZFVcxiN7ZNXJRarZjnmngDDQ==", "fe63544e-2da2-4427-acab-5f6ad7179805" });

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategories_CategoryId",
                table: "FoodCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategories_FoodId",
                table: "FoodCategories",
                column: "FoodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b58bae6c-4ec6-44f5-bff7-0d1573bce748", "AQAAAAIAAYagAAAAEJqAKXjl8uHxRH5Y6RKuuxe9BQ3xNMu/7HgYlvKahTEUfWS5OuEsST8a42xic/HYSQ==", "7a1a5b70-fb91-4584-8f00-dfe921a17e43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13219a38-4bdc-4382-9d67-c0e19864f5cb", "AQAAAAIAAYagAAAAEAX6UqATkBwnjZ7jQrmzVUcmbME/wfSYvNtwIVYJ4koqM27q+VgAKc7aKfpb8CFE4g==", "20b6ed39-c27d-4d84-bde9-0dd9ea38f0a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8f85f6c-fb00-4b75-b9ac-a13e92df7626", "AQAAAAIAAYagAAAAEKNs5QKGue7KZ0bRN57FnJR8JNwYs/LUXXrf7oyegAscFyGxlw2yD6ykc+wNbUsJcQ==", "23c65f41-2713-485a-9574-4d29cde4758a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "896f4580-e95c-4a8a-a4e1-721217af02db", "AQAAAAIAAYagAAAAENmAbs7r0f2PYSIwxBvQmImH4lhpsNqcl1JgI9pf2fRlZn0S2HVAtDcNwNfJuQKmwQ==", "3c3cceab-626f-4ffc-986b-78f00746ee6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31774cfc-fba2-4104-a879-f28eb295ac69", "AQAAAAIAAYagAAAAEDSE3+Dg1jTjBywSnDa8AmsQZclkAQGk26IpSvtpen7DiuQchKFh5Yk0vCKIF8ECRA==", "9dcc338b-6554-4763-ade8-fee62af6aceb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63454daa-a14d-43dd-a922-7744cf01c5ac", "AQAAAAIAAYagAAAAEB8hVHin+o+kY0IbbiIZQjilOIE2nqgorjqnMN6b3r8m2o4xdzQpFTG2szhi4oSdiQ==", "d7df109c-8834-478f-ba5c-cd51cc207d2b" });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
