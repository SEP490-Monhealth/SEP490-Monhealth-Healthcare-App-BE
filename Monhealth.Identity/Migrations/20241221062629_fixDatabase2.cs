using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class fixDatabase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Foods",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("3b372064-e2a9-4729-b725-635e54e11c5d"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("80c5e605-307f-4fef-bdf8-9967a800eab9"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a3be942d-a225-44fb-9c98-22a109995145"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("b6fa82bc-715c-42da-af22-93290d3f2421"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c4f9e44d-b7f6-4530-8b2e-b64c8f993f2a"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c567f8a9-71e4-4167-839d-a839ece79427"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c82a256d-5573-4d27-b045-a411db42e694"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("ced123e2-0b86-444b-ac83-7dba6860e354"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("d4f8f2c7-5318-4f07-803d-2b093be4d6c7"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("d65bff7e-4a2d-498b-97b2-676d4dd92a90"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("dd918def-34c2-4f5c-b402-6d51d8a1c604"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("e1b0767d-4b3b-42ea-820f-2154f7883ab9"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9"),
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("f789601f-8026-499b-98cb-0f189926094a"),
                column: "Status",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Foods");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e8832be-2a98-40c1-ab0d-5d70f42b9b76", "AQAAAAIAAYagAAAAEKQf3D66wZH2YXXWEqouzalcm4h1qctm49qs6rKchSyoEprtOgDav1EqtPQfLtXycw==", "160ee2fc-c5e7-4fdf-90f1-7e4245e74e53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94f2d413-16bb-438e-8842-923601ac578b", "AQAAAAIAAYagAAAAENjp5N6Pvnli/eciT7wzZQBXleKUu9IDxQpw6lunoRM9g040mn7wRwCSeW0LZLe6aQ==", "246fe14e-d96b-4d0f-ae46-3ee844001b70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6356c76-eda6-42fa-bfe6-f50d5fc1f68b", "AQAAAAIAAYagAAAAEBO8I0+nMOXTCyAvlScLpDqi3F5sDF+KenO7JzdIbCaKAn1y+Rs39pdJw2JU9oT+bA==", "a7723236-3311-43c6-ad9a-0101b87d0309" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18327a55-14d4-4b5b-b48e-5952682de6a5", "AQAAAAIAAYagAAAAEMP1U1IZI6C9Q+09PeUdv/731K6wJiIcAEiNM6J60eLkeB9wFI0VJZB/LHrCh5g1Ig==", "124dd4bb-c809-497b-8bd3-46c7bcc1b5ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56a9e949-7fe7-4a74-b6cb-3f6dab48aeb7", "AQAAAAIAAYagAAAAEGEB4pIoFiIKvzre5mz5NNGGZDdc5v7yZMeamh3gOjA0Y5+WLS0ddf9iOZRq1EyngA==", "db597951-95f2-4dee-b3c9-48c628cdafc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "748ea5b7-79f9-4ff4-939c-f45ed64a09b6", "AQAAAAIAAYagAAAAEKRofNARpYjcaNqKPOUv8XSDPCO4nbGai9EentZvzORP8CiyQu4+wP5lxf2bcw6TKg==", "ce13b708-f294-490f-a348-29907180ab5a" });
        }
    }
}
