using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataforFoodCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af0c12c9-7abf-49de-84a5-5a544660d8a6", "AQAAAAIAAYagAAAAEBVg2b938UjfIZqOMIGWYE4iojqdcjaIxXrdPVZY+2Mj10Bh9cOd6RRO7gS/HM/Wgg==", "4df92095-f212-4de2-82c3-730053c21a1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6844fc5d-8d43-4d26-b9fb-bc426ff26151", "AQAAAAIAAYagAAAAEGU/8PfcnIsA3PXyaG0rbsZVmxYd2I/8KV0qmtZQjAuV3WS28F5w1zHlwpFG+g211g==", "5d2c58fc-7c20-4285-9995-dbf55cc03373" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e71dfb6b-91bd-40d2-8c28-9813c065baf3", "AQAAAAIAAYagAAAAEBoNAzgwcYNKct8Q97VyIzsbn29A8Z1EZHhZcoyPro29wqu/TvTR38W3N21dVtgrxw==", "efaf1115-2e68-4f13-8fa9-28d7c03ec68d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05a0413c-e553-4f08-b959-ec46b06f281e", "AQAAAAIAAYagAAAAEHBEWc3DGnI62ONnAsW1ENEfn2aQVlt4X4KLYdNtfToC2Go9OT5wgm6rR58Pjg39Sg==", "a3b2ef96-722c-410e-8c5d-b15e4c7e60a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d199d3c-64d0-4e12-8e35-ea26d8472c76", "AQAAAAIAAYagAAAAEPxRla1hGFdljLd6hvn5/xcjxp5lNGBAGnnpd+KSD6dUOnDy8/bE71N7BlPOm9KJWQ==", "7b0d52b9-5ed9-4073-ac5c-5ea4b0c6201b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f93fc96e-931f-456d-b7fc-ba94b292fb47", "AQAAAAIAAYagAAAAEL7VQumPOO2MWLiClsYweQRjc4hvs4kQNJqtCCDi4vHYeBop3LyPhdx31+/xUnBm9w==", "0cd34bcc-69e4-4137-bb2e-1ce9e821b637" });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "FoodCategoryId", "CategoryId", "FoodId" },
                values: new object[,]
                {
                    { new Guid("008dbfb1-2fa6-4bb6-8313-0d15afb5a217"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new Guid("d65bff7e-4a2d-498b-97b2-676d4dd92a90") },
                    { new Guid("17d4b096-43fb-4ead-aa15-b4f3796a0095"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new Guid("b6fa82bc-715c-42da-af22-93290d3f2421") },
                    { new Guid("232587aa-9171-4816-80de-3f2ca21e7809"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new Guid("ced123e2-0b86-444b-ac83-7dba6860e354") },
                    { new Guid("2824c391-f2a7-4b96-b54d-72d49d224c6c"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new Guid("3b372064-e2a9-4729-b725-635e54e11c5d") },
                    { new Guid("2f71d694-34fa-4e27-9a45-c85636ae80c4"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new Guid("e1b0767d-4b3b-42ea-820f-2154f7883ab9") },
                    { new Guid("38e471a8-d7f3-4885-9873-8ace803a6e26"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new Guid("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9") },
                    { new Guid("400db0ab-1a3e-4de5-b0e0-68a01663c2e7"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new Guid("c567f8a9-71e4-4167-839d-a839ece79427") },
                    { new Guid("448b576b-aeb6-43ea-9040-09d47c5eaa42"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new Guid("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7") },
                    { new Guid("4528e935-231a-4069-b5ee-f07c99b14170"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new Guid("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91") },
                    { new Guid("4584e6b9-8c30-490f-af08-52f093f1d294"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new Guid("e1b0767d-4b3b-42ea-820f-2154f7883ab9") },
                    { new Guid("46f54659-1d67-4107-96a5-124a5302d873"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new Guid("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f") },
                    { new Guid("4f80dc13-5a25-48ae-8563-5c3e998aaf63"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new Guid("dd918def-34c2-4f5c-b402-6d51d8a1c604") },
                    { new Guid("542ed436-d4ab-44e9-971d-f3fd64b1d305"), new Guid("ee39be57-cf88-4420-8e19-606b2ed4dc6d"), new Guid("c567f8a9-71e4-4167-839d-a839ece79427") },
                    { new Guid("54f2de38-ce45-4168-80e7-74b1574f6401"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new Guid("80c5e605-307f-4fef-bdf8-9967a800eab9") },
                    { new Guid("714cb573-594e-47d0-a017-2f51d1588bf8"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new Guid("f789601f-8026-499b-98cb-0f189926094a") },
                    { new Guid("71cd5ed0-003e-4185-8001-ab4bfba3cd21"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new Guid("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91") },
                    { new Guid("7b42248c-c0c4-46b7-aa60-2bf7f7dcc2c7"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new Guid("d4f8f2c7-5318-4f07-803d-2b093be4d6c7") },
                    { new Guid("8dbd85a6-ab87-43db-a763-81ee66f10dd0"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new Guid("3b372064-e2a9-4729-b725-635e54e11c5d") },
                    { new Guid("a4927114-6501-4c79-a466-42ae40364b9d"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new Guid("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f") },
                    { new Guid("a82c5ca4-16d0-4f8c-aca7-0c8a8eb9c195"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new Guid("a3be942d-a225-44fb-9c98-22a109995145") },
                    { new Guid("b534c4d6-bd93-4825-8866-05a8d7a282cb"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new Guid("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db") },
                    { new Guid("b88c6718-9bbd-4efa-8cac-6aafdc1e27f8"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new Guid("dd918def-34c2-4f5c-b402-6d51d8a1c604") },
                    { new Guid("bdcd6f3c-4844-418b-9ed9-95a58fe9c518"), new Guid("78651ea5-2013-4e50-a55f-714de91a712d"), new Guid("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91") },
                    { new Guid("c412b3ae-23d1-4f64-9cb2-b4208f29c1c4"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new Guid("f789601f-8026-499b-98cb-0f189926094a") },
                    { new Guid("c4e7cbb0-fe65-4fee-bcce-bc43ef5aab15"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new Guid("d4f8f2c7-5318-4f07-803d-2b093be4d6c7") },
                    { new Guid("c8f19b8c-8487-4c74-acc9-5e6c1cf5a80b"), new Guid("19fe32e8-9e15-486b-9398-f0116cd5019a"), new Guid("00a16b6c-9396-4389-95fd-205f72fe5164") },
                    { new Guid("cab91050-7489-4967-93c7-62bd2cd64a9f"), new Guid("99052f16-54f5-4456-80f8-1691db7c90f2"), new Guid("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552") },
                    { new Guid("cc1a2489-196e-4f98-b68e-785f9842b4e5"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new Guid("d4f8f2c7-5318-4f07-803d-2b093be4d6c7") },
                    { new Guid("d340e3a2-f56c-48be-b33b-93e1c655abd4"), new Guid("cd017b8a-fbed-4399-99ed-b59eec9b9551"), new Guid("c82a256d-5573-4d27-b045-a411db42e694") },
                    { new Guid("da9f39bb-9e03-447a-8874-220b14b2bea7"), new Guid("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"), new Guid("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9") },
                    { new Guid("e0ff9c14-ff0e-46ce-b1e2-b4eec545f188"), new Guid("fc7f66aa-8c09-46db-a679-be440e3ed91f"), new Guid("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7") },
                    { new Guid("e7265736-1531-47b1-a665-bcecdac73bd2"), new Guid("22ee062d-4904-4c64-a783-74b3e142aac7"), new Guid("c4f9e44d-b7f6-4530-8b2e-b64c8f993f2a") },
                    { new Guid("ecd2cc49-a429-4f77-b074-d5bdf407b720"), new Guid("fe3a3546-b294-4665-9c82-092d4ab5a187"), new Guid("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db") },
                    { new Guid("f6e1ebb2-9c7a-424a-803c-2b7cb7747fce"), new Guid("4c35b262-4c08-4624-900b-e22ba8988c92"), new Guid("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552") },
                    { new Guid("ff7d6a78-5d2d-4475-910a-154e395c5426"), new Guid("f63dd434-9796-46ab-95ad-759bfac51e26"), new Guid("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("008dbfb1-2fa6-4bb6-8313-0d15afb5a217"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("17d4b096-43fb-4ead-aa15-b4f3796a0095"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("232587aa-9171-4816-80de-3f2ca21e7809"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("2824c391-f2a7-4b96-b54d-72d49d224c6c"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("2f71d694-34fa-4e27-9a45-c85636ae80c4"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("38e471a8-d7f3-4885-9873-8ace803a6e26"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("400db0ab-1a3e-4de5-b0e0-68a01663c2e7"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("448b576b-aeb6-43ea-9040-09d47c5eaa42"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("4528e935-231a-4069-b5ee-f07c99b14170"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("4584e6b9-8c30-490f-af08-52f093f1d294"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("46f54659-1d67-4107-96a5-124a5302d873"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("4f80dc13-5a25-48ae-8563-5c3e998aaf63"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("542ed436-d4ab-44e9-971d-f3fd64b1d305"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("54f2de38-ce45-4168-80e7-74b1574f6401"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("714cb573-594e-47d0-a017-2f51d1588bf8"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("71cd5ed0-003e-4185-8001-ab4bfba3cd21"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("7b42248c-c0c4-46b7-aa60-2bf7f7dcc2c7"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("8dbd85a6-ab87-43db-a763-81ee66f10dd0"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("a4927114-6501-4c79-a466-42ae40364b9d"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("a82c5ca4-16d0-4f8c-aca7-0c8a8eb9c195"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("b534c4d6-bd93-4825-8866-05a8d7a282cb"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("b88c6718-9bbd-4efa-8cac-6aafdc1e27f8"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("bdcd6f3c-4844-418b-9ed9-95a58fe9c518"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("c412b3ae-23d1-4f64-9cb2-b4208f29c1c4"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("c4e7cbb0-fe65-4fee-bcce-bc43ef5aab15"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("c8f19b8c-8487-4c74-acc9-5e6c1cf5a80b"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("cab91050-7489-4967-93c7-62bd2cd64a9f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("cc1a2489-196e-4f98-b68e-785f9842b4e5"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("d340e3a2-f56c-48be-b33b-93e1c655abd4"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("da9f39bb-9e03-447a-8874-220b14b2bea7"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("e0ff9c14-ff0e-46ce-b1e2-b4eec545f188"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("e7265736-1531-47b1-a665-bcecdac73bd2"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("ecd2cc49-a429-4f77-b074-d5bdf407b720"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("f6e1ebb2-9c7a-424a-803c-2b7cb7747fce"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: new Guid("ff7d6a78-5d2d-4475-910a-154e395c5426"));

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
        }
    }
}
