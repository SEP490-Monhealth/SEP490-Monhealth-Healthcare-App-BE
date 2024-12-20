using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class fixDatabase12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7aebf8f3-0a74-41d0-a571-27e1c3aa73ca", "AQAAAAIAAYagAAAAEEPPfqYcMjVi+L8Bm6i/GCrt+PG7COauzAaARxD7qb7CeY8ouUwvnm9PXQsWeKFcfQ==", "37132735-b650-42ab-b9b5-247f9617a278" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "738d5821-df02-4fea-af6c-85aa8fe2da57", "AQAAAAIAAYagAAAAEAs8eT1UEVwNFo1glAaO2D/P5ozSbq6aENAHEMPBzDd3ChVV3lQ/Sp3t41hV/fnKHQ==", "d582ca8a-e86c-41f6-b957-1d51e1896cbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e29d9627-3c92-45d6-8ce9-b421b90a479e", "AQAAAAIAAYagAAAAEDAZwIRCZi5nrNwHBBA46knGbUv+QAgeXvZKMV8+YG3XMGUtIUmew3kC8ssb2i8OkQ==", "420c851b-64a4-457b-aa1a-1a5836086af2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a950ee3-f7ed-4281-adcb-654cb1c2fb5d", "AQAAAAIAAYagAAAAEGmgOKwVnvOjpt+uQglv0KEVL6D++uuHgaaEX0mOnqZ6C1t0nVTbJpIJpF4HGPZf+g==", "1b2b0e8e-5d78-44c7-a5ff-8f3ab12af190" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab3996a9-5246-46e1-b83c-c9f514c05f0e", "AQAAAAIAAYagAAAAEJ2xv85cJyfIkJkkIXYlwtEsRWC8wP1HBKcj08QkDKfDSyprtLkFfB2xZBLuCiZ0Nw==", "f47a8b20-753c-4b41-a74d-60933f4e27ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "436b4a2a-0665-49f9-8beb-e95834ae0959", "AQAAAAIAAYagAAAAELmUj4dP3KMPM5Up7JBwBk7zECWrEj+0zayAy/zmkGLVCzoAHnDkh6yKwvP/Pk223w==", "8ff55e72-5bbb-403b-861f-532668ff3f90" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac06d003-3213-4d8f-b291-9f43c8aacc9d", "AQAAAAIAAYagAAAAEPzHQLnO5Y6TQ8kq7N04PHDh0MTp9m2rVYrlM5oIkBiAo+3jd7pP59XGUCbgrOt/eg==", "5b89e72e-bba4-4d0e-915d-a519bb191030" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd8c7f76-75d8-4d73-85dd-5b57604bac18", "AQAAAAIAAYagAAAAEKRKh5NcNXj4NQ2sWpPgf2KPZ6wyEtQTFkrfbpTJimhDM+1NNF9M9eCbxqp55MrOuA==", "d16931e3-40bb-4a9e-bf94-339591ab652f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cc9e8c6-19d9-476f-90c7-5a00b6c7bb8f", "AQAAAAIAAYagAAAAEHyh7wDumaW6XIETSr56tBz0d4BjAjNJyQjmNdNGXgQsPhYWKNGnzSL1OyKmAgAiKQ==", "0c4358b7-c1ed-4e6a-ac88-316fc5b99ab6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b7988ec-f31e-4ba0-b925-7020a3234140", "AQAAAAIAAYagAAAAEPxErmQ3wIpiIYtRscjwDv5c8v4UW9Jq+A04BQdJDDoik7oCNaVdmZXzEzH1Fqkomg==", "d6d0f462-5d39-42f1-beab-a56c1143f6a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f8aaac6-20d0-48d5-a926-5669a67d345f", "AQAAAAIAAYagAAAAEHrFL6IRRq6VvgZy1FK0qBTGFHUgRJPoX1cx3ysSm/8xX0tlLlse1fFcw7UtfF1bBw==", "ef3cacfb-60e8-4a9a-a745-7e263797defe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6441adff-4466-4bad-af21-a9b91f8baf4b", "AQAAAAIAAYagAAAAELrXrc2USW+jhl0q7fxEfjUHLIGeqAbkbbLHjeLzCk0KvKOiGHCWrRz720cUPI9iGQ==", "e8b7c2c2-6568-4b27-9dea-5ef0565b7aa4" });
        }
    }
}
