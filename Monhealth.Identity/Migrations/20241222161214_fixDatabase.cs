using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class fixDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("00a16b6c-9396-4389-95fd-205f72fe5164"),
                column: "FoodDescription",
                value: "Nem chua là món ăn đặc trưng miền Bắc, được làm từ thịt heo lên men, có vị chua, cay, thường ăn kèm với rau sống");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("3b372064-e2a9-4729-b725-635e54e11c5d"),
                column: "FoodDescription",
                value: "Bún tươi là món ăn phổ biến trong các bữa ăn miền Bắc và miền Nam, dùng với nước lèo, thịt, rau hoặc hải sản");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db"),
                column: "FoodDescription",
                value: "Tôm biển ngọt, mềm, thường được chế biến thành các món canh, xào hoặc nướng");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552"),
                column: "FoodDescription",
                value: "Khoai tây là nguyên liệu phổ biến, có thể nấu canh, chiên hoặc nướng, chứa nhiều tinh bột và dinh dưỡng");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("80c5e605-307f-4fef-bdf8-9967a800eab9"),
                column: "FoodDescription",
                value: "Mãng cầu là trái cây có vị ngọt, chua nhẹ, thường được ăn tươi hoặc làm sinh tố giải nhiệt");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91"),
                column: "FoodDescription",
                value: "Chuối tây ngọt, mềm, dễ tiêu hóa, thường được ăn trực tiếp hoặc chế biến thành các món tráng miệng");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a3be942d-a225-44fb-9c98-22a109995145"),
                column: "FoodDescription",
                value: "Thịt heo nạc mềm, ít mỡ, thường được dùng trong các món xào, kho hoặc nướng");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7"),
                column: "FoodDescription",
                value: "Sầu riêng là trái cây đặc trưng của miền Nam, có mùi rất mạnh, ngọt béo, được yêu thích làm món tráng miệng");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f"),
                column: "FoodDescription",
                value: "Đậu phộng là món ăn vặt giòn, có thể ăn sống, rang muối hoặc dùng làm gia vị trong các món ăn");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("b6fa82bc-715c-42da-af22-93290d3f2421"),
                column: "FoodDescription",
                value: "Cơm là một món phổ biến trong ẩm thực Việt Nam, thường được ăn kèm với các món khác như cá, thịt, rau");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c4f9e44d-b7f6-4530-8b2e-b64c8f993f2a"),
                column: "FoodDescription",
                value: "Thịt bò có hương vị đặc trưng, mềm và giàu protein, thường được dùng trong các món xào, nướng hoặc làm súp");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c567f8a9-71e4-4167-839d-a839ece79427"),
                column: "FoodDescription",
                value: "Bỏng ngô là món ăn vặt giòn nhẹ, phổ biến trong các buổi tiệc hoặc xem phim, có thể ăn trực tiếp hoặc kết hợp với gia vị");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c82a256d-5573-4d27-b045-a411db42e694"),
                column: "FoodDescription",
                value: "Xúc xích là món ăn nhanh, thường được chế biến sẵn, có thể chiên, nướng hoặc ăn kèm trong các món salad");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("ced123e2-0b86-444b-ac83-7dba6860e354"),
                column: "FoodDescription",
                value: "Chả giò là món ăn chiên giòn, nhân thịt, tôm, rau, thường được ăn kèm với nước chấm và rau sống");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("d4f8f2c7-5318-4f07-803d-2b093be4d6c7"),
                column: "FoodDescription",
                value: "Bưởi có vị chua ngọt, thường được ăn tươi hoặc làm món tráng miệng, rất giàu vitamin C");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("d65bff7e-4a2d-498b-97b2-676d4dd92a90"),
                column: "FoodDescription",
                value: "Bắp luộc là món ăn vặt phổ biến, ngọt và mềm, thường được ăn vào mùa hè, có thể ăn kèm với muối hoặc bơ");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("dd918def-34c2-4f5c-b402-6d51d8a1c604"),
                column: "FoodDescription",
                value: "Bầu là một loại quả mềm, thường được dùng trong các món canh hoặc xào, có vị ngọt mát và thanh");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("e1b0767d-4b3b-42ea-820f-2154f7883ab9"),
                column: "FoodDescription",
                value: "Nấm kim châm nhỏ, ngọt, dùng để xào, nấu canh hoặc ăn sống, bổ dưỡng và dễ chế biến");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9"),
                column: "FoodDescription",
                value: "Giá đỗ giòn, có thể ăn sống trong salad hoặc xào với thịt, là nguồn cung cấp vitamin rất tốt cho cơ thể");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("f789601f-8026-499b-98cb-0f189926094a"),
                column: "FoodDescription",
                value: "Rau muống thường được dùng để xào hoặc nấu canh, có vị ngọt, giòn và dễ chế biếnD");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afe40294-5b34-4ea7-a123-084e543552ff", "AQAAAAIAAYagAAAAEOMNVgHkjEsoTSvJwtV1TXzUNeJT1rO1B1F4A1mT0xLVUBNWhyymQHxvDF1hjAvaaw==", "4c2f2bf5-9ae5-40d2-a376-84c9f8243ba3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c50ec1b7-72ea-4a99-99ec-7ebe02a8398e", "AQAAAAIAAYagAAAAEAMLIP1x0v2NbxISJQq0tmiQLwVnzsyIE8ISeDeInaD2oLNmuPk2JVi0oJuEyZPWDw==", "eede4247-a908-47d4-8548-3550adcbab35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24ee5fa1-2cc3-4103-8cb6-b1d866fa6b71", "AQAAAAIAAYagAAAAECz9lKi2gvI3OyBJk47OSzHYFgpwful9OPw1s7a3JaK6WP3e1yc1MtXfo4ZKIcJs4Q==", "27dbfe12-f3ac-45e1-bdd3-a9e47e3d6821" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b6ec39d-15ee-4697-8861-459c6500b4fe", "AQAAAAIAAYagAAAAEK3gjYIiMzS8zt+oxzk1pC3H9eqGgbGPhMmn4KPtyYGeYbVX64/iGOO5rTg62oaLdw==", "1162217c-89cd-48cd-97ee-86cddadac2dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "307085a3-25f0-472f-b01f-25bf526e458d", "AQAAAAIAAYagAAAAEATfOg9AT/ix/kewbZm8BnenlG6usIvX7MDlb6eTNLmn4g1pFGgtU0jIFpNoX05qsw==", "2196b181-fa76-443e-81f0-642687ecb9d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d62ed65-3a89-4c9b-af37-74b0745ff294", "AQAAAAIAAYagAAAAEOHbT3Ic6O7iP4GVryq+98JbG+Fjfp5+664v0kQr7dUWbRWuQbpFJyxvEtor5GY/WA==", "761d985e-19a4-4875-9e35-1ae305ecd5d2" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("00a16b6c-9396-4389-95fd-205f72fe5164"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("3b372064-e2a9-4729-b725-635e54e11c5d"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("80c5e605-307f-4fef-bdf8-9967a800eab9"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a3be942d-a225-44fb-9c98-22a109995145"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("b6fa82bc-715c-42da-af22-93290d3f2421"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c4f9e44d-b7f6-4530-8b2e-b64c8f993f2a"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c567f8a9-71e4-4167-839d-a839ece79427"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c82a256d-5573-4d27-b045-a411db42e694"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("ced123e2-0b86-444b-ac83-7dba6860e354"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("d4f8f2c7-5318-4f07-803d-2b093be4d6c7"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("d65bff7e-4a2d-498b-97b2-676d4dd92a90"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("dd918def-34c2-4f5c-b402-6d51d8a1c604"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("e1b0767d-4b3b-42ea-820f-2154f7883ab9"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9"),
                column: "FoodDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("f789601f-8026-499b-98cb-0f189926094a"),
                column: "FoodDescription",
                value: "");
        }
    }
}
