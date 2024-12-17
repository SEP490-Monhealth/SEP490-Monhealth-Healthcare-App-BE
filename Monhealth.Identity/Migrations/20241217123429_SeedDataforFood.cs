using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataforFood : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f79d10fb-fab2-4072-8a22-e6cde680a010", "AQAAAAIAAYagAAAAEGkiwoAp12+enCcvffhSHWtlL5UKGKSuTk180oJmVD8MkoTnLRF2PGeTkgrYXaeAzA==", "53244e9c-0daa-4057-84c8-107454f4fba7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4ace1a4-741c-44e5-9bba-74c4bacd86c8", "AQAAAAIAAYagAAAAEJeQmI1SvrBJDM8+XWjiD71KfNllhfvz3PuXeVrnHoZ/Fv+SXAFrm/oAJd2l3OPWPQ==", "53b8efad-4dbb-4b02-9db4-9ec8a071941f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17ff81f5-6011-47b0-a196-fe9c1a77dbbc", "AQAAAAIAAYagAAAAEDXcTFPcvZIS1nPQr8gkLSpAeGHL3Mc/ZYKV56X2cbDzBQPVG/IPZEtQzQqrzgxy4A==", "96d84d4b-7431-49b2-a331-4eba095ac46c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7394dbad-0be2-42a7-bcc1-091c67b3de82", "AQAAAAIAAYagAAAAEHeecIHntFsIURBHkgqqQMSq6IT3jcgiRzkNwxCiHqQhCqmlGDG0ZEcc62Ffw0h5BQ==", "34862414-4e27-4964-96b0-f1a955187050" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc1c5165-da2b-4a3a-8371-5f8278a11032", "AQAAAAIAAYagAAAAEOrwEIl44v745jKXMjtmL7/AMANL3sbmxXjfWZGvshzwFklDg0mpSqfW9Vh2Z8sXQQ==", "09bc154b-d4bf-410f-b92d-801ae7792488" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4a52a63-9c52-4ed9-84c0-6c5d1f4a43c4", "AQAAAAIAAYagAAAAEIeU4U/LHaDGEcQrv0PgGhAbjH6Rau8paBFR3/iwSpI7M76sOTvAyFx5XPLPmzE72w==", "d90c4e3f-cb20-4026-86aa-3812478d1366" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "CreatedBy", "DateCreated", "DateModified", "FoodName", "ModifiedBy" },
                values: new object[,]
                {
                    { new Guid("00a16b6c-9396-4389-95fd-205f72fe5164"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nem chua", null },
                    { new Guid("3b372064-e2a9-4729-b725-635e54e11c5d"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bún tươi", null },
                    { new Guid("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tôm biển", null },
                    { new Guid("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khoai tây", null },
                    { new Guid("80c5e605-307f-4fef-bdf8-9967a800eab9"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mãng cầu", null },
                    { new Guid("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chuối tây", null },
                    { new Guid("a3be942d-a225-44fb-9c98-22a109995145"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thịt heo nạc", null },
                    { new Guid("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sầu riêng", null },
                    { new Guid("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đậu phộng", null },
                    { new Guid("b6fa82bc-715c-42da-af22-93290d3f2421"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cơm trắng", null },
                    { new Guid("c4f9e44d-b7f6-4530-8b2e-b64c8f993f2a"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thịt bò", null },
                    { new Guid("c567f8a9-71e4-4167-839d-a839ece79427"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bỏng ngô", null },
                    { new Guid("c82a256d-5573-4d27-b045-a411db42e694"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xúc xích", null },
                    { new Guid("ced123e2-0b86-444b-ac83-7dba6860e354"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chả giò", null },
                    { new Guid("d4f8f2c7-5318-4f07-803d-2b093be4d6c7"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bưởi", null },
                    { new Guid("d65bff7e-4a2d-498b-97b2-676d4dd92a90"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bắp luộc", null },
                    { new Guid("dd918def-34c2-4f5c-b402-6d51d8a1c604"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bầu", null },
                    { new Guid("e1b0767d-4b3b-42ea-820f-2154f7883ab9"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nấm kim châm", null },
                    { new Guid("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giá đỗ", null },
                    { new Guid("f789601f-8026-499b-98cb-0f189926094a"), null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rau muống", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("00a16b6c-9396-4389-95fd-205f72fe5164"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("3b372064-e2a9-4729-b725-635e54e11c5d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("80c5e605-307f-4fef-bdf8-9967a800eab9"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a3be942d-a225-44fb-9c98-22a109995145"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("b6fa82bc-715c-42da-af22-93290d3f2421"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c4f9e44d-b7f6-4530-8b2e-b64c8f993f2a"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c567f8a9-71e4-4167-839d-a839ece79427"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c82a256d-5573-4d27-b045-a411db42e694"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("ced123e2-0b86-444b-ac83-7dba6860e354"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("d4f8f2c7-5318-4f07-803d-2b093be4d6c7"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("d65bff7e-4a2d-498b-97b2-676d4dd92a90"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("dd918def-34c2-4f5c-b402-6d51d8a1c604"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("e1b0767d-4b3b-42ea-820f-2154f7883ab9"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("f789601f-8026-499b-98cb-0f189926094a"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15e7b6fd-366f-4ed1-9eae-d83f6567b9ab", "AQAAAAIAAYagAAAAENt+D1z63ctB112UjHe2KOr2jNohsLrHi51y85IyLo4LlfMVvZlsrrtZA+M3CeJmbA==", "407971b2-848c-49d8-ad8e-948c7d3e8e75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66adedd5-fba1-48d8-b36f-d2f5c9e87590", "AQAAAAIAAYagAAAAEJCY55U8fIwGfJR06Pc4zp+3E4KKRq6FbP2ejHG+fpZvP+sFwaw2uqD2otfa2c/CEQ==", "0c5216c5-2da0-4ec7-baa8-f63d00872b1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "892d510a-de8d-4ccf-ab8a-a01596b85327", "AQAAAAIAAYagAAAAEBHKBix2uWrs7mEIY/++x1htAvEy/AMeC5URfKrhYmsbU8fs6XD7mGVIyWZGMnZVqw==", "1000e00f-a641-4707-a8e0-3949f308912c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c545a798-d248-4333-be4c-a8a08b812e3c", "AQAAAAIAAYagAAAAEKp38vn4QasYAx1henNcQcx41JFtkovz5g14vySFU2LxGm2FN9uKa4uPw20lGnOYyg==", "13d2d571-2d34-4fbc-bd47-e43becf5ddff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec780abc-b994-4c58-8a3a-6ae1560b06fa", "AQAAAAIAAYagAAAAEGPVBMBcR9Qj1PIdYymzrFW/rwknhu4SatSFblLKhBZ1UPv2YLad6K2hdrxW3LR1NQ==", "e4dd5e4b-d510-4b3f-aea1-9c6bc11cd87e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff06edbf-da3a-4897-a02f-186729cd79e5", "AQAAAAIAAYagAAAAEKayzA7pUPi81pmUtwd9vdb5TQBQX9itjXdsurhSojKsv5q5eWInHgzFLkIOjVLA5g==", "128d00ea-882a-432b-9abc-eb5803c9d5c2" });
        }
    }
}
