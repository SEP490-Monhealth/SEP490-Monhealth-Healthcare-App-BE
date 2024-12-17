using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class fixData02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Foods");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c39878fe-6f4b-4875-aecb-88d18679d4fa", "AQAAAAIAAYagAAAAEKUVkBlGVhcRGy6iyCmIRaTlqAOWWmo6/aBOIKKiUdUvGfz+i3VDe0jIjmlBmTEsAA==", "064488a2-1b8e-4c84-9ae1-b385a1093618" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60bb1a92-52ce-45ee-a837-128be8016882", "AQAAAAIAAYagAAAAEEfb0H2q3icS/FMbQ+M94KV4I8YV185PirDBtvTZUMj7PhT8rDZsVUV9aablzx5XXA==", "fa21ad64-5cd9-425d-a8ba-be221382d5f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2b7cde6-51a8-4569-bc6f-c2c357e9995c", "AQAAAAIAAYagAAAAEAeM5oQtdIXPYUDlD75bAViucCO1cm1FfkPKiev5BfX1go9jkhe1CNcLU/7Kd5kw+g==", "582c1519-9d0c-452b-babb-0ffe420f4d84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a59c9e77-d228-42e9-8cf4-5af782f08740", "AQAAAAIAAYagAAAAEKHa8GxhkRtI9nii8ddUHHV8+aokkZyfzJXqTCSx67clTPBRy9FjJQTTK9SeFIFpGg==", "ca8c839c-fdd6-4f50-b5ec-460d6af2b710" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7954d0b-e6c4-42ee-bb61-dbbd4cbf0c3d", "AQAAAAIAAYagAAAAELVoUSAtBJTSNSOxjNzPlprwBMsMtKvqis4+5pNURT5pxTxpnTi6Fo4E40fFq/7HKQ==", "b2264be2-8cdc-4ac3-beb5-24b86db72bee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ff0509e-3339-4799-999e-83d0de7e2acc", "AQAAAAIAAYagAAAAEBdqngjQU2Ryk/tvl+9qNCaJ97oo+523Wgr6Fcg47X6CGWMTn8p/f5sBkowx0wYy9A==", "dbabd98d-9a54-4469-92b3-f8d4bd72bc42" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Foods",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
        }
    }
}
