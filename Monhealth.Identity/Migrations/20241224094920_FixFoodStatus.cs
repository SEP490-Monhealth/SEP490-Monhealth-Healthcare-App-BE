using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class FixFoodStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce591a76-3904-4a25-989d-5efd04f2fd3a", "AQAAAAIAAYagAAAAEFZl0SXFYo61CUiJOrgXKrdWgFS+z9cZa7AysuVUlWK54szLEDfK0wEq0Nb+/q5apg==", "a1d2d5b4-e579-4fff-ae34-4c4e969510ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d670377-b4be-4e9f-b1f0-f251410a4599", "AQAAAAIAAYagAAAAEGFri8s7hiKez3TMPV6K7XOvvZLvUb1P0di/NZJyFH7u71dh3g7d2IZDKW4fhPKjEg==", "f2600d28-4763-4711-9be8-eef28123499f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04cb390b-4008-4c46-9493-95ff62967622", "AQAAAAIAAYagAAAAEGl1m+YzmedQqT3zkGohWgU4UJVVD5baBSZoV2Fkme2pr3ozFRbaBsvhjnCJuyYK/g==", "63248b0b-1a01-4481-9d42-38f8587ad801" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84fbd30e-5530-47a2-aae5-29163bacddf5", "AQAAAAIAAYagAAAAEOY4bH23R1inUB5/rnsRkz+UK9mlmDHCnqQg7F6l4FC9PAreyLiRTmJb+j46YSg3LA==", "51b0ad1d-e562-462f-aa46-2c86a607a9bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c5453a8-245c-4424-821e-f88addc67032", "AQAAAAIAAYagAAAAEEsy0B5Ilkg6h9TylZhLs77IConbjb3rNrJBx6pypM0A1eLP9E0IyIRB2hOr88x9ag==", "efabfa99-8a62-4ea9-a280-d74449364b5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da598341-b74c-403e-8182-c28c0a976ee6", "AQAAAAIAAYagAAAAEMe1m5tMqOUCCEkKbMr0/NFausTNB8VdvsX/XJ/3o9x0NQFeY0F4ej4lugqZJfMWFw==", "e307b77d-68e3-4d87-9ae0-9b8cd100b028" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("00a16b6c-9396-4389-95fd-205f72fe5164"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("3b372064-e2a9-4729-b725-635e54e11c5d"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("80c5e605-307f-4fef-bdf8-9967a800eab9"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a3be942d-a225-44fb-9c98-22a109995145"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("b6fa82bc-715c-42da-af22-93290d3f2421"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c4f9e44d-b7f6-4530-8b2e-b64c8f993f2a"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c567f8a9-71e4-4167-839d-a839ece79427"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("c82a256d-5573-4d27-b045-a411db42e694"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("ced123e2-0b86-444b-ac83-7dba6860e354"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("d4f8f2c7-5318-4f07-803d-2b093be4d6c7"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("d65bff7e-4a2d-498b-97b2-676d4dd92a90"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("dd918def-34c2-4f5c-b402-6d51d8a1c604"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("e1b0767d-4b3b-42ea-820f-2154f7883ab9"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: new Guid("f789601f-8026-499b-98cb-0f189926094a"),
                columns: new[] { "FoodDescription", "Status" },
                values: new object[] { "Rau muống thường được dùng để xào hoặc nấu canh, có vị ngọt, giòn và dễ chế biến", true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "FoodDescription", "Status" },
                values: new object[] { "Rau muống thường được dùng để xào hoặc nấu canh, có vị ngọt, giòn và dễ chế biếnD", false });
        }
    }
}
