using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class fixDatabaseN2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "344e0645-b240-40a8-9202-a805ea079322", "AQAAAAIAAYagAAAAEGDd7Nwga0PDNnJewwGms/hnyCD0fQHrOUuWLq2qgyroZrHBurnV76Q7dFmsHvPbYA==", "f8016612-70d1-4b91-9c38-ef231e773448" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbd4239f-164b-46c6-8e9a-0402f3e72b7c", "AQAAAAIAAYagAAAAEIXio1tt7q5ayIJwXpijvXVWVslxdV5otwMDH7qdzdtWhlFRlbVlw1mfy7hU75fi6g==", "2972df79-ebf8-4729-b811-c69139e7b454" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cdaaace-f9a2-4677-bdc0-00508915fbb9", "AQAAAAIAAYagAAAAEIfWuIjMEQmYHx89naF69vhflf90VcWe/MMo/yWFizpo59LcbGlrdDxuLJaDN7XpZQ==", "72a1bcfb-f8c5-4766-887a-8889dc37879c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee5776d0-e9ea-4776-8a43-d990f52fea25", "AQAAAAIAAYagAAAAEC69vhuMCyyOVB8owBjIa4eW28HbveD9pgugYVpEliekwbLRsH1O8jpRK37+b60YuA==", "28537d81-01a1-4b40-9e85-edb7aad995f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb838dc4-9b16-420e-8694-dadebbbc7146", "AQAAAAIAAYagAAAAEKDnZU5MqjkP7jaAoqwKAVj4F+4xfFX92Jwq7ndvKrlangdtJcZJzYw3To22ay1VFA==", "9ccb8942-2fba-47db-b6af-75638da501ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61ed39ad-03f2-41fe-a868-973fb9222a73", "AQAAAAIAAYagAAAAEOKJAMoCjQ2BKHVVntXxWV5fdS36ScBxj2MvwX7jbjxaFaI5ddtNnMEetS1stWKppA==", "7e7e7b16-43dc-441f-9936-57a9c5057af1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Hoa quả tươi hoặc chế biến như salad trái cây, nước ép, sinh tố, cung cấp vitamin và khoáng chất", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fapple.png?alt=media&token=106a39ee-5c36-4c27-8bbe-c850ee19cb02", "Trái cây" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Các món ăn từ thực vật, đậu phụ, và nguyên liệu không sử dụng thịt, phù hợp với người ăn chay hoặc muốn đổi vị thanh đạm", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fradish.png?alt=media&token=c27e26f3-3f39-42ec-bf40-94c9abb074d5", "Món chay" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Gạo, mì, bánh mì, yến mạch, và các loại hạt ngũ cốc. Là nguồn cung cấp năng lượng chính trong ngày", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Frice.png?alt=media&token=1ef6ca23-003f-4415-9ce4-3a3f5cd8e65e", "Ngũ cốc" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Món ăn từ rau xanh, củ quả và nấm. Phù hợp cho những ai yêu thích thực phẩm tươi sạch, giàu dinh dưỡng", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbroccoli.png?alt=media&token=6746e0eb-bcf0-44d1-830a-79821f735f84", "Rau củ" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("78651ea5-2013-4e50-a55f-714de91a712d"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Bánh ngọt, kẹo, kem, và các món tráng miệng ngọt ngào, lý tưởng cho những ai yêu thích đồ ngọt", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcupcake.png?alt=media&token=8721bd49-186f-4ccf-a85a-64008e4c8e38", "Món ngọt" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Bao gồm các món ăn từ thịt bò, thịt gà, thịt lợn, thịt vịt và các loại thịt khác. Là lựa chọn phổ biến trong bữa ăn chính", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fsteak.png?alt=media&token=dfffb9c2-2964-40cc-8712-e83b4200e7af", "Thịt" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Pizza, burger, khoai tây chiên, gà rán, và các món ăn tiện lợi, phù hợp cho những ai bận rộn", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fburger.png?alt=media&token=66dd457f-64d3-4b66-851c-10eba13fdc7d", "Đồ ăn nhanh" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Bánh mì, bánh ngọt, bánh mặn, bánh hấp, và các món bánh truyền thống hay hiện đại", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbread.png?alt=media&token=decd5d8c-994f-4a71-ab9e-2096209515fc", "Bánh các loại" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Các món ăn từ tôm, cá, cua, mực, hàu, sò và các loại hải sản khác. Thích hợp cho những ai yêu thích hương vị biển cả", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcrab.png?alt=media&token=0cde2529-8e28-4b5e-80cf-660f27564de2", "Hải sản" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Bao gồm nước ép, sinh tố, trà, cà phê, và các loại đồ uống giải khát khác", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcoffee-cup.png?alt=media&token=14155321-cd44-422b-a49f-3e34636d7f85", "Đồ uống" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Kimchi, dưa chua, sữa chua, rượu vang và các món ăn lên men, tốt cho tiêu hóa và sức khỏe đường ruột", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fpickles.png?alt=media&token=2a078ceb-40a9-403d-a68c-9682faf1b97f", "Món lên men" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Các loại hạt (hạnh nhân, hạt chia, hạt điều) và đậu (đậu nành, đậu xanh, đậu đen). Giàu protein và chất xơ", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fgrain.png?alt=media&token=e224b22a-925e-4aa4-ab50-d74309ba71f4", "Hạt và đậu" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryImage", "CategoryName", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), "Snack, khô gà, khô bò, bim bim, và các món ăn nhẹ lý tưởng cho những lúc giải trí hay nghỉ ngơi", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fpopcorn.png?alt=media&token=8aecf5e1-071f-4b0f-8e55-a2c47b289def", "Đồ ăn vặt", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"));

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
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Thực phẩm đã qua quá trình lên men, mang lại hương vị độc đáo và chứa probiotics, như kim chi hoặc sữa chua.", "", "Lên men" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Thực phẩm giàu protein, bao gồm thịt, đậu, trứng, và các loại hạt, cần thiết cho việc xây dựng và sửa chữa cơ bắp.", "", "Giàu protein" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Các bữa ăn không có thịt hoặc cá, tập trung vào rau củ và ngũ cốc.", "", "Đồ ăn chay" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Các món ăn đậm đà, cay nóng, thường được tăng cường với ớt và gia vị.", "", "Nhiều gia vị" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("78651ea5-2013-4e50-a55f-714de91a712d"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Thực phẩm có hàm lượng năng lượng (calo) thấp, thường được thiết kế để hỗ trợ kiểm soát cân nặng hoặc duy trì sức khỏe.", "", "Ít calo" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Món ăn nhiều carbohydrate (carb) thường là những thực phẩm chứa hàm lượng tinh bột hoặc đường cao.", "", "Nhiều carbs" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Thực phẩm được trồng mà không sử dụng thuốc trừ sâu tổng hợp hoặc phân bón, tập trung vào tính bền vững và sức khỏe.", "", "Hữu cơ" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Thực phẩm đã qua xử lý để thay đổi trạng thái tự nhiên của chúng thông qua các phương pháp như đóng hộp, đông lạnh hoặc thêm chất bảo quản.", "", "Chế biến sẵn" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Các bữa ăn nhanh, tiện lợi, thường được phục vụ trong môi trường nhịp độ nhanh.", "", "Fast food" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Thực phẩm giàu chất xơ, giúp thúc đẩy sức khỏe tiêu hóa, chẳng hạn như trái cây, rau và ngũ cốc nguyên hạt.", "", "Giàu chất xơ" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Món tráng miệng hoặc đồ ăn giàu đường, mang lại hương vị ngọt ngào, thỏa mãn.", "", "Đồ ngọt" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"),
                columns: new[] { "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[] { "Cá tươi, động vật có vỏ, và các sinh vật biển khác, mang lại hương vị đậm đà của đại dương.", "", "Hải sản" });
        }
    }
}
