using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class fixDatabas2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MeasurementUnit",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "PortionSize",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "PortionWeight",
                table: "Foods");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3db195d5-9e78-4621-8863-6e4890250e37", "AQAAAAIAAYagAAAAENHAAFIQSVsBeEsx5c+wsz7RQQDBh5MNgc0aNGPSV5vs9aECNJuJsyQTYhCFtfdpaQ==", "90c3bf3a-bd1b-4aca-91fb-5845c41689c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98d3cb37-d2f5-4f65-86e9-845bea5c3010", "AQAAAAIAAYagAAAAEOM7cl+S7o7alQp/CytfVnqGCxkwQY5a/i6VirjrG1XD0wbgPT8PeEqkQa/daOaTCA==", "96a68e3f-d666-47ed-bcdc-6660e37ac4a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa053cdf-b2df-4342-9e6b-68144f0eb7ca", "AQAAAAIAAYagAAAAEKOlGFx5OVUkhE+nNzwJZ1quQ6lfFuQvsWwrvGpashkLP1LMYC2O1kIjO10fpVR9QA==", "11ac8d4b-e3c9-4b64-999c-31b32d9aee34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3f1d2e1-31e6-4946-a7d0-5d2c1cf5204b", "AQAAAAIAAYagAAAAEG65WcYB3ICC5KVo+4/F1v4Bd8uTrpy7DB/bqwsGdzisHGzE9e8oXfWbQebXGPbdmQ==", "53854e35-c9a8-4155-ba59-f60e796e193b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9661612-d9eb-4854-891f-0c8a3d7e579f", "AQAAAAIAAYagAAAAEFb4G+J0tCJrMys1Gb/bw3G++9pJxo20/cFt5CeDiuQ0Sn7B4uzuUxOhh+So89xh8A==", "20d8ef16-85c8-40e3-91f5-d270757ab211" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5ad227f-f041-45c4-92f8-6cf416711489", "AQAAAAIAAYagAAAAEC70aFCe5Sq4g3a2jJgzHV6OFtVsVT9V/N0TXzERMFH0XgM7SVkpbhoQKag9rhOG2g==", "d80065f3-793d-45ce-923a-e612aae96365" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MeasurementUnit",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PortionSize",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "PortionWeight",
                table: "Foods",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9c7a8e5-8d68-491f-934c-92591e6eef8a", "AQAAAAIAAYagAAAAENDVU5G7316rbYnnyQDFTMkvJUNGRxFWEHp0TUV9GQ4yA8PcOfiHGR30+yJVyn70Ow==", "18a3ed53-706d-4d27-b40c-b303853f6101" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a5c597b-3810-44fa-9bd7-a10ed31c12d1", "AQAAAAIAAYagAAAAEClIw7SxVafOg5kRlRbTXjvqNs6MgxLiU01SwYNNgJ5UFX7dju5dymwE1kYarip10Q==", "b31ff9e5-17e7-4e1d-bf9d-0aa3631fdb86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c66893fa-d713-46e1-9595-d69f21daa4fe", "AQAAAAIAAYagAAAAENHJ6nnb//YPtqM5tHmbSVwT9Y2Iwv/jQXontI/sbH1OYv5/eCN763C5UhvCixbnbA==", "d7fceb5f-bb6b-47cb-8aaa-a2951c6d1870" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b5dd3fd-38aa-4a9c-b88b-fd4799cfcec5", "AQAAAAIAAYagAAAAEBfFzgXu0RcYCm5Xw5mgtM7ZD9o/OwpS2QqOUjDe8LedX0tkLxWhYkQDYZM3pMFjfA==", "afbb1e41-3a96-4532-a99c-39fd412ccc9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7eaaa4d-c400-4a6a-8c03-2aa60bb779a9", "AQAAAAIAAYagAAAAEJqHFi2kez/7x4j0kmcaQ2vYR9ZHD20iQbFKQDElXS/gLAjaAwG71Et3OA87QTFelw==", "f435b1c5-54ea-4b4a-9aa9-a09c2e09d74b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52702e08-2191-4c60-aa15-b9c6ed2b0457", "AQAAAAIAAYagAAAAEGefy/Fb6Ik6UtMUP2zyoo8Bp9nLQYhf3oVHTtCrU9BJkKnkt8GSxyGK6xJxmLXf8Q==", "ea7845a6-d93d-44e6-84a1-6cba942426c1" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("00a16b6c-9396-4389-95fd-205f72fe5164"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("3b372064-e2a9-4729-b725-635e54e11c5d"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("80c5e605-307f-4fef-bdf8-9967a800eab9"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a3be942d-a225-44fb-9c98-22a109995145"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("b6fa82bc-715c-42da-af22-93290d3f2421"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c4f9e44d-b7f6-4530-8b2e-b64c8f993f2a"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c567f8a9-71e4-4167-839d-a839ece79427"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c82a256d-5573-4d27-b045-a411db42e694"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("ced123e2-0b86-444b-ac83-7dba6860e354"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("d4f8f2c7-5318-4f07-803d-2b093be4d6c7"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("d65bff7e-4a2d-498b-97b2-676d4dd92a90"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("dd918def-34c2-4f5c-b402-6d51d8a1c604"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("e1b0767d-4b3b-42ea-820f-2154f7883ab9"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("f789601f-8026-499b-98cb-0f189926094a"),
                columns: new[] { "MeasurementUnit", "PortionSize", "PortionWeight" },
                values: new object[] { "", "", 0f });
        }
    }
}
