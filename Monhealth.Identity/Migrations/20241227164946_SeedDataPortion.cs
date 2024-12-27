using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataPortion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("a44fd2e0-b595-4423-9e6f-42a010d96f66"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("d2f3a6c9-19c1-45fa-9a4f-3ad8396c19a7"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c81ecc5e-0b54-4c7b-b1c2-a054a2a9acad", "AQAAAAIAAYagAAAAEPRiKQLUBnZZxjHq3Fee+qz4SHOsMYwSdz7nMsk6LXmi7TpYz3xKAVw2VZ02BX7eJg==", "8ddcdb7d-3dc7-4c43-8221-9f48d58c025c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3560d981-5e04-453f-b6a7-83a20df39c47", "AQAAAAIAAYagAAAAEEvrNDjpnMVOdkgUcASbDygfZ6BU+Ty3KrublRhM8XNg6sIx11qrrLS0Kc2S9sJqZw==", "86a2bf8f-c792-465a-b5a1-6a74918d796a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44ea5e66-fbe4-43a7-aeda-b77298c8ec57", "AQAAAAIAAYagAAAAEIv65bVviYTLeRpZJwwj2Ivgh9IaM/mS9Ro7l/LgfiPl6x9hU3+dnBMl3QHtnxffLQ==", "7afc6e3e-717b-4665-9107-f66b69f1330f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcb2c63f-f6e8-45d4-bdbe-ca9f269df19f", "AQAAAAIAAYagAAAAEFk4F5gpeZWLZMQ55Fu1gekIdfojSHGin6S39CWjoSridKkYZvhL06gT1x90yoMf+Q==", "3a867220-5699-4e5b-a2a4-91ebd7b155a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30aafac2-9eca-4125-87ed-5aaa2ff23591", "AQAAAAIAAYagAAAAEF3w5ARquNvEfnGbQtdfUqDpa50LSgK5ijmYGa75l9yjnQpXQQaEwOAcc2QhaHGGhQ==", "be0fd756-0178-4857-b226-f0df8f1c65ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad4c0c52-9e7d-4483-ba6d-8793283caa94", "AQAAAAIAAYagAAAAEGO3rMaXqUXvgU2U8V1X+UErvAVkx4whY0nA5NzphIfwIsfUPy0t3JfGp+sN4+aHkw==", "5296de13-964d-48db-921a-82bac52c8b3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56796e33-039e-4665-afa6-d0d5c56d9a78", "AQAAAAIAAYagAAAAEI9QSK0qlkgJH/Ms7nXxVwz8TB8lIYtr8FijKgR4SxpJEW48sZCG9dAkkqScsv6ySw==", "6b97f39b-7df4-4584-82bd-dcd891a71abc" });

            migrationBuilder.InsertData(
                table: "Portions",
                columns: new[] { "PortionId", "CreatedAt", "CreatedBy", "MeasurementUnit", "PortionSize", "PortionWeight", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1500876f-ef20-40de-baae-de0336bdc47b"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "cốc", 240f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("1808de3e-ae43-41a6-b9ce-bfe89131be5a"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "chén", 100f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("1b56833b-1ff5-4a90-aea9-074de2d0dd67"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả lớn", 136f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "miếng", 150f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("22f0a09e-6816-410e-a5a2-c802103b089b"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "đĩa", 200f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("24a4ed15-69e4-4fb5-8dd2-1695de52c264"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cái", 100f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "trái", 164f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("28b06cf6-6367-4786-bccb-89c43dd3ce3a"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả nhỏ", 81f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("31e9bda5-8ec3-4444-a23a-908e84da6a14"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "cốc", 240f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("399eee61-90b5-464f-b3f7-7ddc1077ab0d"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "hộp", 110f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("3d7eafa9-9fcc-4f49-b8fb-2a5c629ae6eb"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cái", 50f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("3f77fd90-591c-45f3-8bbc-87d0bb49e461"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 250f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("40991196-f258-43f1-ac84-0381afa83477"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 300f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("40bbc8c4-f383-4ae6-979a-3ac83c275881"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "cốc", 240f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("41ae956e-14fc-44af-bc6a-e5ba77661cee"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 350f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("4e9013c8-d6f7-4740-80d5-e95d318873b9"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 300f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("5feca670-1f15-430d-9b04-7ac86a329a6c"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "ly", 100f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("6792c392-3c86-4162-be91-4fc8646f861d"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "ly", 100f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("698c67ad-a726-435b-b9d2-c5690a79eb5a"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả lớn", 50f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("6f34350b-8f99-446e-9de9-e0c6277b10f3"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "hộp", 180f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("749b288c-112b-4b7b-8750-0daff63d9ab3"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 228f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("7be0e4d3-1e50-4de1-931d-08adb85f628b"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả vừa", 44f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("8a81e20e-ea16-4073-957e-29508a8f7419"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ", 150f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("91524cc2-db22-4cab-abb7-700725232f1f"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả vừa", 118f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("92e149ff-8491-48cf-a4e8-8106b1e95c4c"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "cốc", 200f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("93984b54-2044-4ea9-8364-a03c6568e358"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 330f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a1589990-affa-4805-a1e0-73de1ffa8516"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "trái", 150f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a33065fe-80ad-4879-9333-424aadc6734f"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 350f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a88faa7c-6eab-4ecb-8a75-b078a9cf7834"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "củ", 150f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a9385e8a-e9b9-484f-beeb-bc35529cf91a"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 330f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("b6623163-4c27-4d0c-99ef-12a67b87635f"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 350f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 250f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c4fc900f-5a92-4228-ac03-57285fff159e"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "đĩa vừa", 350f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c605aa91-495e-4977-9876-b2a198ce356e"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "quả nhỏ", 38f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ml", "hộp", 180f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("de5d78a3-c5b1-4e2a-b9eb-f3757c999024"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cái", 50f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("e4e4252f-ad38-4190-aba5-8989e3cca994"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "miếng", 114f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("eceaaa32-4023-4eab-abb6-9172c908f77c"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "tô", 250f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f483bb75-84f0-4ecc-8a06-f366a488c6bf"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "hộp", 116f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("faec7c41-2e11-4092-8ab9-cc9c152d858f"), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "cây", 35f, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "FoodPortions",
                columns: new[] { "FoodPortionId", "FoodId", "PortionId" },
                values: new object[,]
                {
                    { new Guid("00b508dc-fd72-46b5-8fd0-71caa552cf8d"), new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("c605aa91-495e-4977-9876-b2a198ce356e") },
                    { new Guid("034c5f36-35f5-4fb4-b567-4631a20c99b6"), new Guid("d9fa8f03-5825-4e83-88d3-1a7c49e39a7d"), new Guid("e4e4252f-ad38-4190-aba5-8989e3cca994") },
                    { new Guid("05d20084-3157-48d2-bbdf-59bd4be2d7f9"), new Guid("30355638-a0e2-4126-93ae-beb7aa9b5758"), new Guid("a88faa7c-6eab-4ecb-8a75-b078a9cf7834") },
                    { new Guid("166bdafd-3440-45db-af3c-9f254f75381d"), new Guid("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), new Guid("f483bb75-84f0-4ecc-8a06-f366a488c6bf") },
                    { new Guid("29be3e7f-31f6-459d-bcb5-2342e7e0a250"), new Guid("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), new Guid("31e9bda5-8ec3-4444-a23a-908e84da6a14") },
                    { new Guid("3cea29a7-afbb-4d5d-9755-6f514ae1a0a2"), new Guid("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), new Guid("93984b54-2044-4ea9-8364-a03c6568e358") },
                    { new Guid("3dcc2c21-c974-4827-b8bf-224881a2af24"), new Guid("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), new Guid("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a") },
                    { new Guid("4601ad5c-3b27-4b7b-a4c1-4e2c0acbd844"), new Guid("23443efa-dc06-4e7a-949c-5c823ee6e575"), new Guid("8a81e20e-ea16-4073-957e-29508a8f7419") },
                    { new Guid("49e440ff-31d5-49a0-8f8b-98c9a9d95cf9"), new Guid("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), new Guid("de5d78a3-c5b1-4e2a-b9eb-f3757c999024") },
                    { new Guid("50cd88da-4abe-448a-bf7f-4c50bd4d1bc3"), new Guid("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), new Guid("eceaaa32-4023-4eab-abb6-9172c908f77c") },
                    { new Guid("55ed9075-67ec-4a5e-8d67-71b778fb480f"), new Guid("d4df84f2-2d79-41e6-b313-28e89e3785ba"), new Guid("a33065fe-80ad-4879-9333-424aadc6734f") },
                    { new Guid("624eeb3d-b90c-41de-aaac-82aac1278366"), new Guid("87225215-43af-49f2-a40b-a5ebb087d27b"), new Guid("a9385e8a-e9b9-484f-beeb-bc35529cf91a") },
                    { new Guid("63c7b97d-ad3e-47c0-a294-fc74ae5c312e"), new Guid("1387c20d-27a6-495b-a3a0-efbb715f6430"), new Guid("a1589990-affa-4805-a1e0-73de1ffa8516") },
                    { new Guid("6488aed8-d811-4054-aa55-1419362b89f6"), new Guid("c5822776-96df-4208-82b2-02f22594063b"), new Guid("3d7eafa9-9fcc-4f49-b8fb-2a5c629ae6eb") },
                    { new Guid("689236b2-c41a-4581-97f4-9943a8bf619f"), new Guid("05cfce09-72b4-482d-adcd-c0718015be3d"), new Guid("24a4ed15-69e4-4fb5-8dd2-1695de52c264") },
                    { new Guid("6956e07b-da21-481e-ac76-65255fd9587f"), new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("1808de3e-ae43-41a6-b9ce-bfe89131be5a") },
                    { new Guid("6dfc62b1-fc62-4aea-a8f4-aa93dcfb10fe"), new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("6f34350b-8f99-446e-9de9-e0c6277b10f3") },
                    { new Guid("77ff6660-2d5b-45db-bd7b-524a3eac0a98"), new Guid("85822a08-7189-4e08-8f55-25c73698af92"), new Guid("faec7c41-2e11-4092-8ab9-cc9c152d858f") },
                    { new Guid("79f8e00a-8627-4c17-ad1b-1f2e30152cf7"), new Guid("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), new Guid("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1") },
                    { new Guid("7a61797f-8c44-44f2-87d7-9d14946e91e0"), new Guid("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), new Guid("4e9013c8-d6f7-4740-80d5-e95d318873b9") },
                    { new Guid("8c85d7a4-bace-4691-ab0f-e1628f24bfd3"), new Guid("599cfc95-4108-4dcc-9c5a-077173251f8b"), new Guid("40991196-f258-43f1-ac84-0381afa83477") },
                    { new Guid("8d47ad59-d162-4777-81dc-c2bec9e72f22"), new Guid("de097440-db5c-4d91-bd55-76618d70599d"), new Guid("92e149ff-8491-48cf-a4e8-8106b1e95c4c") },
                    { new Guid("99a56d5b-3a27-437b-b2dd-9ed46689be76"), new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("698c67ad-a726-435b-b9d2-c5690a79eb5a") },
                    { new Guid("9fcf8d40-47b2-45fb-8197-e77bf2071542"), new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("91524cc2-db22-4cab-abb7-700725232f1f") },
                    { new Guid("aac2bdea-12f2-4a18-970b-53f31238c765"), new Guid("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), new Guid("7be0e4d3-1e50-4de1-931d-08adb85f628b") },
                    { new Guid("b38e1bf5-f34c-422f-bc6a-456eb9f1439f"), new Guid("8fa26c41-16b2-49f8-a284-856024a5f947"), new Guid("41ae956e-14fc-44af-bc6a-e5ba77661cee") },
                    { new Guid("b915f9fe-df4f-4b9a-aeee-746a7206a297"), new Guid("021b651c-bb01-4965-95bc-3532fbacad3d"), new Guid("399eee61-90b5-464f-b3f7-7ddc1077ab0d") },
                    { new Guid("bdfe0d61-37a3-4062-bff8-b1ab5d7959cc"), new Guid("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), new Guid("3f77fd90-591c-45f3-8bbc-87d0bb49e461") },
                    { new Guid("c15e4bd1-ddaa-4330-8ae5-dbf1549a8f9c"), new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("28b06cf6-6367-4786-bccb-89c43dd3ce3a") },
                    { new Guid("c5c017a3-f52c-4e61-b3f5-d36fc3da9438"), new Guid("9122357a-179f-45f4-9106-67eea24d48ab"), new Guid("5feca670-1f15-430d-9b04-7ac86a329a6c") },
                    { new Guid("cfab2fdb-5a1a-4b4c-8e85-5247c64e3492"), new Guid("48113ca0-a1e7-4181-85fa-be6538a70873"), new Guid("c4fc900f-5a92-4228-ac03-57285fff159e") },
                    { new Guid("d5d5889a-bbc4-408c-9884-d194e1f48346"), new Guid("a47b1646-3576-46f0-a3b6-763a9c3f889b"), new Guid("6792c392-3c86-4162-be91-4fc8646f861d") },
                    { new Guid("da959267-1066-4a30-84a6-c5975af7c398"), new Guid("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), new Guid("40bbc8c4-f383-4ae6-979a-3ac83c275881") },
                    { new Guid("db166416-f2d4-4e69-98b2-4b14ac28f725"), new Guid("a989c8db-7506-467f-8aba-dce042f68eea"), new Guid("1b56833b-1ff5-4a90-aea9-074de2d0dd67") },
                    { new Guid("e07e4ccc-de61-4564-a047-d5f29395e765"), new Guid("eac10b91-8509-4986-b689-7ee3a3757a18"), new Guid("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649") },
                    { new Guid("e428756d-f4a5-4ea2-a168-409faa856d57"), new Guid("37a66f5c-437f-4520-90ec-4376e0093061"), new Guid("1500876f-ef20-40de-baae-de0336bdc47b") },
                    { new Guid("ea36ca31-4756-426f-8f30-116a401871ff"), new Guid("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), new Guid("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52") },
                    { new Guid("eef1a8f0-25f1-4695-b6ff-c57662e845cd"), new Guid("da89578e-9470-4b18-af4f-0bdcc011882f"), new Guid("749b288c-112b-4b7b-8750-0daff63d9ab3") },
                    { new Guid("ef7605fb-2047-4fd6-b9eb-bcaa4265dcfa"), new Guid("fb7d87aa-2bb8-4065-bd31-b54239057405"), new Guid("22f0a09e-6816-410e-a5a2-c802103b089b") },
                    { new Guid("ff83c895-9e7c-497d-ba90-48a0b27ac753"), new Guid("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), new Guid("b6623163-4c27-4d0c-99ef-12a67b87635f") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("00b508dc-fd72-46b5-8fd0-71caa552cf8d"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("034c5f36-35f5-4fb4-b567-4631a20c99b6"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("05d20084-3157-48d2-bbdf-59bd4be2d7f9"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("166bdafd-3440-45db-af3c-9f254f75381d"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("29be3e7f-31f6-459d-bcb5-2342e7e0a250"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("3cea29a7-afbb-4d5d-9755-6f514ae1a0a2"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("3dcc2c21-c974-4827-b8bf-224881a2af24"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("4601ad5c-3b27-4b7b-a4c1-4e2c0acbd844"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("49e440ff-31d5-49a0-8f8b-98c9a9d95cf9"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("50cd88da-4abe-448a-bf7f-4c50bd4d1bc3"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("55ed9075-67ec-4a5e-8d67-71b778fb480f"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("624eeb3d-b90c-41de-aaac-82aac1278366"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("63c7b97d-ad3e-47c0-a294-fc74ae5c312e"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("6488aed8-d811-4054-aa55-1419362b89f6"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("689236b2-c41a-4581-97f4-9943a8bf619f"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("6956e07b-da21-481e-ac76-65255fd9587f"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("6dfc62b1-fc62-4aea-a8f4-aa93dcfb10fe"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("77ff6660-2d5b-45db-bd7b-524a3eac0a98"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("79f8e00a-8627-4c17-ad1b-1f2e30152cf7"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("7a61797f-8c44-44f2-87d7-9d14946e91e0"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("8c85d7a4-bace-4691-ab0f-e1628f24bfd3"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("8d47ad59-d162-4777-81dc-c2bec9e72f22"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("99a56d5b-3a27-437b-b2dd-9ed46689be76"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("9fcf8d40-47b2-45fb-8197-e77bf2071542"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("aac2bdea-12f2-4a18-970b-53f31238c765"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("b38e1bf5-f34c-422f-bc6a-456eb9f1439f"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("b915f9fe-df4f-4b9a-aeee-746a7206a297"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("bdfe0d61-37a3-4062-bff8-b1ab5d7959cc"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("c15e4bd1-ddaa-4330-8ae5-dbf1549a8f9c"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("c5c017a3-f52c-4e61-b3f5-d36fc3da9438"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("cfab2fdb-5a1a-4b4c-8e85-5247c64e3492"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("d5d5889a-bbc4-408c-9884-d194e1f48346"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("da959267-1066-4a30-84a6-c5975af7c398"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("db166416-f2d4-4e69-98b2-4b14ac28f725"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("e07e4ccc-de61-4564-a047-d5f29395e765"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("e428756d-f4a5-4ea2-a168-409faa856d57"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("ea36ca31-4756-426f-8f30-116a401871ff"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("eef1a8f0-25f1-4695-b6ff-c57662e845cd"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("ef7605fb-2047-4fd6-b9eb-bcaa4265dcfa"));

            migrationBuilder.DeleteData(
                table: "FoodPortions",
                keyColumn: "FoodPortionId",
                keyValue: new Guid("ff83c895-9e7c-497d-ba90-48a0b27ac753"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("1500876f-ef20-40de-baae-de0336bdc47b"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("1808de3e-ae43-41a6-b9ce-bfe89131be5a"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("1b56833b-1ff5-4a90-aea9-074de2d0dd67"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("22f0a09e-6816-410e-a5a2-c802103b089b"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("24a4ed15-69e4-4fb5-8dd2-1695de52c264"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("28b06cf6-6367-4786-bccb-89c43dd3ce3a"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("31e9bda5-8ec3-4444-a23a-908e84da6a14"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("399eee61-90b5-464f-b3f7-7ddc1077ab0d"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("3d7eafa9-9fcc-4f49-b8fb-2a5c629ae6eb"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("3f77fd90-591c-45f3-8bbc-87d0bb49e461"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("40991196-f258-43f1-ac84-0381afa83477"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("40bbc8c4-f383-4ae6-979a-3ac83c275881"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("41ae956e-14fc-44af-bc6a-e5ba77661cee"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("4e9013c8-d6f7-4740-80d5-e95d318873b9"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("5feca670-1f15-430d-9b04-7ac86a329a6c"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("6792c392-3c86-4162-be91-4fc8646f861d"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("698c67ad-a726-435b-b9d2-c5690a79eb5a"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("6f34350b-8f99-446e-9de9-e0c6277b10f3"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("749b288c-112b-4b7b-8750-0daff63d9ab3"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("7be0e4d3-1e50-4de1-931d-08adb85f628b"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("8a81e20e-ea16-4073-957e-29508a8f7419"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("91524cc2-db22-4cab-abb7-700725232f1f"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("92e149ff-8491-48cf-a4e8-8106b1e95c4c"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("93984b54-2044-4ea9-8364-a03c6568e358"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("a1589990-affa-4805-a1e0-73de1ffa8516"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("a33065fe-80ad-4879-9333-424aadc6734f"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("a88faa7c-6eab-4ecb-8a75-b078a9cf7834"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("a9385e8a-e9b9-484f-beeb-bc35529cf91a"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("b6623163-4c27-4d0c-99ef-12a67b87635f"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("c4fc900f-5a92-4228-ac03-57285fff159e"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("c605aa91-495e-4977-9876-b2a198ce356e"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("de5d78a3-c5b1-4e2a-b9eb-f3757c999024"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("e4e4252f-ad38-4190-aba5-8989e3cca994"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("eceaaa32-4023-4eab-abb6-9172c908f77c"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("f483bb75-84f0-4ecc-8a06-f366a488c6bf"));

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "PortionId",
                keyValue: new Guid("faec7c41-2e11-4092-8ab9-cc9c152d858f"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec0b2684-cfb8-4119-a96f-3357f8594212", "AQAAAAIAAYagAAAAECNs5o6gRNkU4Rb2zwvEwR1jwOHvSagqUCm8qAQKXnrhEJEwYoCYFD9HOp0LIKWYVA==", "4d2be625-6eeb-4ba6-a6bc-54570f21b75a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee89a6a6-0b46-4849-b6bc-85275a3f645c", "AQAAAAIAAYagAAAAECgYOF1BVJ7tqVb9ffzXemqKJnsj23S7w0nagsd+TsiNguQv23qK4haZM9aqhMr60Q==", "ab69c249-694b-4ea6-a7ed-e96d6f4f185e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a540db70-cc97-4849-8943-c78a5a9c6982", "AQAAAAIAAYagAAAAEE4/ZctPgjLFY8Dm/gKYU4b0GUvZBYpnr5L/Keo3OMMWCxU+/drnpGW3RcdSIj3Rog==", "8d55c49a-e96b-49d1-8935-e4e4ac810816" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08809abc-e60f-4b03-830f-904770bcc7fb", "AQAAAAIAAYagAAAAEEX+SfBdzK9llxDm0ASLRnL0rMKAGhaDw68EZ4ftMSM6EF47rGJ95taxR0ot/ATlnw==", "6c0c0eef-191e-4fbd-9aea-4f47aedb56d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7b0d300-1c0c-4d95-beef-f43470a9ada9", "AQAAAAIAAYagAAAAECb3BFnhiVxiDnS9b3KxJBeRmj/+ntCunRDxcuYnH8Qg6eCHdbrr4TH0fDvd2vlnAw==", "340c05e1-8ae3-4a44-a069-288cc53d4fc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2feeb498-2d98-4744-bc41-303c61f51cd9", "AQAAAAIAAYagAAAAEAbsACBdx/DU6J7kyGEnAZVQBLIzL/a1SNul4ixyXyJapglBh4bSBj7Yu7C+tpdsRQ==", "482c832a-887c-405c-8da7-7525a043f66a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da5bd825-5c0c-44e2-a2cf-a09c77aa226f", "AQAAAAIAAYagAAAAEB4TBVqPRJ59GJsxnkG8ZAo50Q6kmQWZMUq0WNpVE5zstuzVfRuh6vSxhdZWHYn3eA==", "694dd591-eabe-41e9-9302-aac319aa5b69" });

            migrationBuilder.InsertData(
                table: "Portions",
                columns: new[] { "PortionId", "CreatedAt", "CreatedBy", "MeasurementUnit", "PortionSize", "PortionWeight", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("a44fd2e0-b595-4423-9e6f-42a010d96f66"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "Chén", 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("d2f3a6c9-19c1-45fa-9a4f-3ad8396c19a7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "g", "Phần ăn", 100f, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }
    }
}
