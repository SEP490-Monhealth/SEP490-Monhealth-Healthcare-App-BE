using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataCategory02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("78651ea5-2013-4e50-a55f-714de91a712d"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1db7e1cd-9993-475e-acc0-2357ee4edc38", "AQAAAAIAAYagAAAAEF9ZL662+eWQOpAf/zPJULl7Si0Wcp3W/RuhF3YGgFKA94I2KrzlAAbsJi3sRXe74w==", "eb7e68bf-0b0f-4fb1-be12-00ba5f555c28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd516d16-e2fe-48af-bbd0-71fb738e82e3", "AQAAAAIAAYagAAAAEKNCTZguTPi6Cx12h4rYg1w/6kgiJvMYP+atkIsg/tw9I2k73pvv33Rpj37+M+V9aQ==", "96f36996-8b92-4dca-9b9b-5fd221c282ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9c3e9ad-2e2d-4c84-bf71-67c3a4c084a4", "AQAAAAIAAYagAAAAEClHXYvB/5om8XCkbLlSXYg257fHbQZP5AADyMp19Dpnd4W6MVrp0W8gf8n8VFHw9Q==", "6022713b-e3b9-4e8f-8e55-63e0a6cf07dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9ecaa7c-6f36-4d93-8a92-b9d15a851787", "AQAAAAIAAYagAAAAEDPp8YXge3/9Feo3KkQfQTxT6G96yskk3DzQGS6ntzM1YcXTrSTp2CroXmVhdmLOdQ==", "9d898896-7806-4a06-8768-1887329ff79a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbb5d38b-a4c0-4693-b53d-0329fd8a947f", "AQAAAAIAAYagAAAAEMOmw3oYB/PrlDtfvdXHmtusiIleSCd9qM84yn2RcOLnQmvLApq6zmXpzEp9y44IzQ==", "d595c69e-2127-47e4-82a6-4fa538e64b1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71bf4106-2c74-48c8-a1d9-8785ff94fb7e", "AQAAAAIAAYagAAAAEEk0FezarKz4Bm8eSf/1xe0XyX4M/vi50fVFVitJ9er6NMIp/+b3zcIkJ7lr+nL1DA==", "146ce906-d713-47f7-bdae-ef669f5b907a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("78651ea5-2013-4e50-a55f-714de91a712d"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { null, null });
        }
    }
}
