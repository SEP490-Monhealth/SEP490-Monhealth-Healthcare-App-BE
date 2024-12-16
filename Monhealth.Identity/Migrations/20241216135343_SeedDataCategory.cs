using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName", "CreatedBy", "DateCreated", "DateModified", "ModifiedBy" },
                values: new object[,]
                {
                    { new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), "Thực phẩm đã qua quá trình lên men, mang lại hương vị độc đáo và chứa probiotics, như kim chi hoặc sữa chua.", "Lên men", null, null, null, null },
                    { new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), "Thực phẩm giàu protein, bao gồm thịt, đậu, trứng, và các loại hạt, cần thiết cho việc xây dựng và sửa chữa cơ bắp.", "Giàu protein", null, null, null, null },
                    { new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), "Các bữa ăn không có thịt hoặc cá, tập trung vào rau củ và ngũ cốc.", "Đồ ăn chay", null, null, null, null },
                    { new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), "Các món ăn đậm đà, cay nóng, thường được tăng cường với ớt và gia vị.", "Nhiều gia vị", null, null, null, null },
                    { new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), "Thực phẩm có hàm lượng năng lượng (calo) thấp, thường được thiết kế để hỗ trợ kiểm soát cân nặng hoặc duy trì sức khỏe.", "Ít calo", null, null, null, null },
                    { new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), "Thức ăn nhiều carbohydrate (carb) thường là những thực phẩm chứa hàm lượng tinh bột hoặc đường cao.", "Nhiều carbs", null, null, null, null },
                    { new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), "Thực phẩm được trồng mà không sử dụng thuốc trừ sâu tổng hợp hoặc phân bón, tập trung vào tính bền vững và sức khỏe.", "Hữu cơ", null, null, null, null },
                    { new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), "Thực phẩm đã qua xử lý để thay đổi trạng thái tự nhiên của chúng thông qua các phương pháp như đóng hộp, đông lạnh hoặc thêm chất bảo quản.", "Chế biến sẵn", null, null, null, null },
                    { new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), "Các bữa ăn nhanh, tiện lợi, thường được phục vụ trong môi trường nhịp độ nhanh.", "Fast food", null, null, null, null },
                    { new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), "Thực phẩm giàu chất xơ, giúp thúc đẩy sức khỏe tiêu hóa, chẳng hạn như trái cây, rau và ngũ cốc nguyên hạt.", "Giàu chất xơ", null, null, null, null },
                    { new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), "Món tráng miệng hoặc đồ ăn giàu đường, mang lại hương vị ngọt ngào, thỏa mãn.", "Đồ ngọt", null, null, null, null },
                    { new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), "Cá tươi, động vật có vỏ, và các sinh vật biển khác, mang lại hương vị đậm đà của đại dương.", "Hải sản", null, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("78651ea5-2013-4e50-a55f-714de91a712d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"));

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
    }
}
