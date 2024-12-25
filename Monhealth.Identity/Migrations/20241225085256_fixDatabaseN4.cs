using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class fixDatabaseN4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "6de73a80-0761-458f-ab7a-44cd99e6c69b", "AQAAAAIAAYagAAAAEHr6gnnp5+3418EzevLoHQD78MRJZSN/GhkMYW6Uzai+zUvycVCWsSkVccv9iJdGSg==", "e53c312a-c17b-498d-8ddc-465c76dcf5d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04751153-f5fd-48cd-9805-49ccabcd8fdc", "AQAAAAIAAYagAAAAEP4rHtPEB98ypGvNRLYFNsDG/M5qT+xRU006Ngh+FHFGjFU4ZKed4S40DGDVELAQtg==", "bff7e7ce-41f0-4099-ac8c-1e59ca78f8fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56c09126-369c-4c07-bad1-e6d412a1b423", "AQAAAAIAAYagAAAAENKmAOTmVfL8gELuYgi9RV2Uo//cGs4gBRMypU1I+hjp7sAj2cmJwy3vfA2yMzJC8A==", "eb132790-6a85-4e6c-880b-7307fde14ac2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11f016e5-a354-4b63-a883-f0041795de99", "AQAAAAIAAYagAAAAEPfTmdVH+Bea7gOj23/3y2zJkEZvrMTgYvQ6QXN5Czx826EwW++Jg1T5mjwr6GzBmg==", "f55c802d-61ff-4c84-a203-1c89e423b611" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27f757ac-b0ec-4168-b489-f487a5e49b2d", "AQAAAAIAAYagAAAAEHpGyaYsP8yk7/DiBiuhkwfNcvLcaE/Ok/DGIHlhBoUHvyYO6svMcm0a/YHTQHGj1g==", "28870644-6585-4555-a45e-2578398f5b39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f321bda-a551-4ecd-b140-057968055deb", "AQAAAAIAAYagAAAAEB8L+u3SlArSKTPMKGiusutCXtsegYZAMzvo5VGYROp5crGULbvWklL9b/Bf+eoWhg==", "9f1f5e7b-00d0-4a26-81c3-4aa3cd0e600f" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "CategoryId", "CreatedAt", "CreatedBy", "FoodDescription", "FoodName", "FoodType", "Status", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rau xanh thường luộc, xào hoặc làm gỏi, giàu chất xơ", "Rau muống", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("19bbab17-91c6-410f-b566-b509d067e76e"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sản phẩm từ đậu nành, giàu protein thực vật, dùng trong nhiều món chay", "Đậu hũ", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bánh bao không nhân thịt, nhân rau củ hoặc đậu xanh", "Bánh bao chay", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cháo gạo nấu với lòng heo, thơm béo, ăn kèm rau thơm", "Cháo lòng", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Món bún ăn kèm thịt nướng, rau sống, và nước chấm chua ngọt", "Bún chả", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bánh mì lát, dễ ăn, thích hợp cho bữa sáng nhanh", "Bánh mì sandwich", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"), new Guid("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rau củ màu cam, giàu vitamin A, tốt cho mắt và sức khỏe da", "Cà rốt", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Món ăn nhanh từ thịt xay nhuyễn, thích hợp cho bữa ăn nhẹ", "Xúc xích", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Món ăn lên men từ sữa, giúp hỗ trợ tiêu hóa và làm đẹp da", "Sữa chua", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cơm từ gạo lức, giàu chất xơ, tốt cho sức khỏe tim mạch", "Cơm gạo lức", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Trái cây nhiệt đới, thịt vàng, ngọt hoặc chua tùy giống", "Xoài", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thức uống giải khát tự nhiên, giàu khoáng chất", "Nước dừa", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Món bắp nấu chín, ngọt tự nhiên, thích hợp ăn sáng hoặc ăn vặt", "Bắp luộc", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new Guid("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Món ăn với sợi bánh dày, ăn cùng nước lèo đậm đà", "Bánh canh", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Giò heo hấp chín, mềm, thơm, thường dùng trong bánh mì, bánh cuốn", "Chả lụa", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phần thịt gà trắng, giàu đạm, ít béo, tốt cho người tập gym", "Ức gà", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thức uống tươi mát từ cam, cung cấp vitamin C tăng sức đề kháng", "Nước cam", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Trái cây nhiều nước, vị ngọt mát, thích hợp trong ngày nóng", "Dưa hấu", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thức uống ca cao bổ dưỡng, thích hợp cho trẻ em", "Sữa hộp milo", "", false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("0a47589f-d177-46f9-8a10-63fd6da9b611"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("19bbab17-91c6-410f-b566-b509d067e76e"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("65c7b876-87e2-4307-ab76-c72ca277b78c"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("74181cd5-4b0b-48a9-9042-16d8789483d4"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("85822a08-7189-4e08-8f55-25c73698af92"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a3074169-6441-49cc-9ea7-79e240f6dda3"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("dca16637-cf90-402f-921f-5c60e99e4bfa"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("de097440-db5c-4d91-bd55-76618d70599d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f82ae142-a062-48c0-941e-17ff441bfd9b", "AQAAAAIAAYagAAAAEPiT55qZukBMEs/MRaB5VcXR7SBX4L0qXA3gIPLivzDlalnE57yQUBe9Gv9+/4vgGA==", "db0a8db3-db23-4d50-b734-816da06a115b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86fbf325-2f29-445e-b9b8-c1fb977395f7", "AQAAAAIAAYagAAAAEAMBA90iN7NOkGpwQwnvAY1pAkXAOIZhrv9lePFUN7ClLgxc2B/QG0tiNxArnWyemg==", "b2e1e90d-45ae-4f75-ba8d-e710e5c84dc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "836b5b59-81fd-448e-9693-73642f5fcdbb", "AQAAAAIAAYagAAAAEBPpD06aHbASxXxNQQtzUzs+U89uy81WctLtorsWKhQO8wUjDMrDlNMk/uq11yQVtQ==", "28e3ec11-2345-4180-a7ba-9f6de1e01a8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37e33ad8-412f-4685-8eec-a68a9672e1ec", "AQAAAAIAAYagAAAAEGck8kdPuLXqdxZkVewkmkwHCpPXH+g04f3MLnVehXOxX0ouTKT0C/ghd01fyW30rA==", "8a5c27a2-cbd4-4909-a6c9-4c6617a8ce11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86998557-d238-442d-8aeb-3b0bddfef27c", "AQAAAAIAAYagAAAAEJRDUxC2BV0fWD87BdzyRCbv3FXx/srbVRP/ZGbgZaj8HvPwPRPFExHh140J0ZYIZw==", "ccb6682d-6f2c-465c-a0d7-559ee97f7607" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21b34ed5-cb75-4191-922b-d4afee447a91", "AQAAAAIAAYagAAAAEDChzqAU6L5Sr361MW78twQrZXOo3Omh9KM+Fq5+OfngT+3Tliq96MqZ0vdiCO5rJw==", "8d31ff95-ffb0-4cd3-8c9d-fbeca767c8c1" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "CategoryId", "CreatedAt", "CreatedBy", "FoodDescription", "FoodName", "FoodType", "Status", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("00a16b6c-9396-4389-95fd-205f72fe5164"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nem chua là món ăn đặc trưng miền Bắc, được làm từ thịt heo lên men, có vị chua, cay, thường ăn kèm với rau sống", "Nem chua", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("3b372064-e2a9-4729-b725-635e54e11c5d"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bún tươi là món ăn phổ biến trong các bữa ăn miền Bắc và miền Nam, dùng với nước lèo, thịt, rau hoặc hải sản", "Bún tươi", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tôm biển ngọt, mềm, thường được chế biến thành các món canh, xào hoặc nướng", "Tôm biển", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khoai tây là nguyên liệu phổ biến, có thể nấu canh, chiên hoặc nướng, chứa nhiều tinh bột và dinh dưỡng", "Khoai tây", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("80c5e605-307f-4fef-bdf8-9967a800eab9"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mãng cầu là trái cây có vị ngọt, chua nhẹ, thường được ăn tươi hoặc làm sinh tố giải nhiệt", "Mãng cầu", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chuối tây ngọt, mềm, dễ tiêu hóa, thường được ăn trực tiếp hoặc chế biến thành các món tráng miệng", "Chuối tây", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("a3be942d-a225-44fb-9c98-22a109995145"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thịt heo nạc mềm, ít mỡ, thường được dùng trong các món xào, kho hoặc nướng", "Thịt heo nạc", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sầu riêng là trái cây đặc trưng của miền Nam, có mùi rất mạnh, ngọt béo, được yêu thích làm món tráng miệng", "Sầu riêng", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Đậu phộng là món ăn vặt giòn, có thể ăn sống, rang muối hoặc dùng làm gia vị trong các món ăn", "Đậu phộng", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("b6fa82bc-715c-42da-af22-93290d3f2421"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cơm là một món phổ biến trong ẩm thực Việt Nam, thường được ăn kèm với các món khác như cá, thịt, rau", "Cơm trắng", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("c4f9e44d-b7f6-4530-8b2e-b64c8f993f2a"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thịt bò có hương vị đặc trưng, mềm và giàu protein, thường được dùng trong các món xào, nướng hoặc làm súp", "Thịt bò", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("c567f8a9-71e4-4167-839d-a839ece79427"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bỏng ngô là món ăn vặt giòn nhẹ, phổ biến trong các buổi tiệc hoặc xem phim, có thể ăn trực tiếp hoặc kết hợp với gia vị", "Bỏng ngô", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("c82a256d-5573-4d27-b045-a411db42e694"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xúc xích là món ăn nhanh, thường được chế biến sẵn, có thể chiên, nướng hoặc ăn kèm trong các món salad", "Xúc xích", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("ced123e2-0b86-444b-ac83-7dba6860e354"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chả giò là món ăn chiên giòn, nhân thịt, tôm, rau, thường được ăn kèm với nước chấm và rau sống", "Chả giò", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("d4f8f2c7-5318-4f07-803d-2b093be4d6c7"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bưởi có vị chua ngọt, thường được ăn tươi hoặc làm món tráng miệng, rất giàu vitamin C", "Bưởi", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("d65bff7e-4a2d-498b-97b2-676d4dd92a90"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bắp luộc là món ăn vặt phổ biến, ngọt và mềm, thường được ăn vào mùa hè, có thể ăn kèm với muối hoặc bơ", "Bắp luộc", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("dd918def-34c2-4f5c-b402-6d51d8a1c604"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bầu là một loại quả mềm, thường được dùng trong các món canh hoặc xào, có vị ngọt mát và thanh", "Bầu", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("e1b0767d-4b3b-42ea-820f-2154f7883ab9"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nấm kim châm nhỏ, ngọt, dùng để xào, nấu canh hoặc ăn sống, bổ dưỡng và dễ chế biến", "Nấm kim châm", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Giá đỗ giòn, có thể ăn sống trong salad hoặc xào với thịt, là nguồn cung cấp vitamin rất tốt cho cơ thể", "Giá đỗ", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") },
                    { new Guid("f789601f-8026-499b-98cb-0f189926094a"), null, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rau muống thường được dùng để xào hoặc nấu canh, có vị ngọt, giòn và dễ chế biến", "Rau muống", "", true, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") }
                });
        }
    }
}
