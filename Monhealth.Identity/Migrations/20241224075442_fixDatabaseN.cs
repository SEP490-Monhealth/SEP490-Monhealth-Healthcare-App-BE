using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class fixDatabaseN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Foods",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "347005ba-992a-477c-85eb-c915867e1e98", "AQAAAAIAAYagAAAAEP87J75MzyA/XPi9hQUzYM1ZY7PHVZ5vcvR1ZDRVDaK4vXIhombi+TJWM9GpfYVd3A==", "dfe7254a-1fda-4efc-b003-509b12bf177a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e59b390-b67a-42cf-9dfa-6c94e6cd2ff5", "AQAAAAIAAYagAAAAEOG5PHpKcfdlTELBxKAPnMTa+OTNlZLsLYegc80/foxhNHvtNHwoQyyS39VN9PF6Gw==", "044f63bf-cbfe-49a5-942a-e9454e61c636" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7186b11f-7a7c-4585-8d49-84daee4c4879", "AQAAAAIAAYagAAAAEPT58OoVVhSrFdSQtjY94Ntzb6/B9bIf7oeNvv5yIoz0YaPDJAqIsADC7V/rmSr47A==", "919bef4f-84ef-47d0-8037-3ba08933e112" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6216104a-62f6-4a3e-b300-9b1cfc5f89ac", "AQAAAAIAAYagAAAAEDHDuJGv7FfOE32sozs5zzTwsxdpV+MMVOh9/Ymk4N2wmd54U2F4pCWcwJFhRbPTzg==", "2d2d88eb-fb69-4696-9a7c-d6e7e21bf5c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ee69d7a-1c28-427c-9a18-ebc927693696", "AQAAAAIAAYagAAAAEP0ZJZPB6Ojykq9CBuMm+SiTBrMPCs6HUsnM/avBa8bLK/d0MmcwMQnVqF2cpTFBTA==", "9c8e8028-4373-4308-b68a-c135a3b5d0fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "855c143f-f35e-496f-b2b4-45a514ffc63f", "AQAAAAIAAYagAAAAEGIZx04H6JZzpwi6ttH+5ITJ4P2JYWg5a9k4uH8nZl24ME/OKaGkoDz4k+rFZHkiFg==", "d6027e30-cfd1-41ba-9362-7c279a1324f7" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("00a16b6c-9396-4389-95fd-205f72fe5164"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("3b372064-e2a9-4729-b725-635e54e11c5d"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("80c5e605-307f-4fef-bdf8-9967a800eab9"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a3be942d-a225-44fb-9c98-22a109995145"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("b6fa82bc-715c-42da-af22-93290d3f2421"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c4f9e44d-b7f6-4530-8b2e-b64c8f993f2a"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c567f8a9-71e4-4167-839d-a839ece79427"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c82a256d-5573-4d27-b045-a411db42e694"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("ced123e2-0b86-444b-ac83-7dba6860e354"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("d4f8f2c7-5318-4f07-803d-2b093be4d6c7"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("d65bff7e-4a2d-498b-97b2-676d4dd92a90"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("dd918def-34c2-4f5c-b402-6d51d8a1c604"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("e1b0767d-4b3b-42ea-820f-2154f7883ab9"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9"),
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("f789601f-8026-499b-98cb-0f189926094a"),
                column: "CategoryId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Foods");

            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    FoodCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.FoodCategoryId);
                    table.ForeignKey(
                        name: "FK_FoodCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
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
                values: new object[] { "364f021a-23d9-4dfa-b892-fffb18e1fc0e", "AQAAAAIAAYagAAAAECuIZRfMxRT73s2PZFzVy3lmV78aGStB9mFrVBgkltZTsGmzy9TIRoVpUWQPF9ipoQ==", "9ec43fe9-e472-43a3-b4e9-4948ac910f45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5b25284-2117-4e61-9f92-ec72a32efcbc", "AQAAAAIAAYagAAAAEP5+g+qQHUH5q/Ct/r3suTa5ki4RSIr3Bj916k3NxwYtIeNPwRCmhjRvRnw3DjWTaA==", "4926d991-dfad-42c5-aff3-8a4b731e12ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6c8187b-f3e6-49ca-a2a4-00a1280d8b2a", "AQAAAAIAAYagAAAAEDvIKjoFnkBdgjZOoNgAATFd9MEkxROR3Fyi7BYM0HgBCCysAPh09baUyRzTZ08gzg==", "c722f1e3-34bd-4e03-b61d-6c6762dc8dde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43d336b1-a3a9-4f57-8ae9-cc5b0bbe402b", "AQAAAAIAAYagAAAAEJUERIeAJciU/GVAB4I94T3QRmRa9U+6mR0/KjqrWl9OACjR2bRSIpZY7xHAmz3X1A==", "d8ae4677-d768-4830-b199-18e5f67ce730" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fdfc1b0-44d7-4e8a-a4ba-1c590e4842e0", "AQAAAAIAAYagAAAAEIZbTdSoH4AifoIEnuv+K2OZzTfehZcqmAwYgzuwL6dKsYbGe1lhZX3Xu9uJQeUUhw==", "05bb0a49-1900-4045-ac29-59eb964913df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "635071c7-5330-4733-973a-8d776057b247", "AQAAAAIAAYagAAAAENRlv2zBdFBRt5kYUx6tBmMMq8p5hQe3CCu7w23k9aCpTmWjmEoope9SAFE6Lf+wGw==", "2b6a427f-f890-46a9-80f0-5bd164f410ca" });

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

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategories_CategoryId",
                table: "FoodCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategories_FoodId",
                table: "FoodCategories",
                column: "FoodId");
        }
    }
}
