using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class AddAllergiesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodAllergies_Allergy_AllergyId",
                table: "FoodAllergies");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAllergies_Allergy_AllergyId",
                table: "UserAllergies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Allergy",
                table: "Allergy");

            migrationBuilder.RenameTable(
                name: "Allergy",
                newName: "Allergies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Allergies",
                table: "Allergies",
                column: "AllergyId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acd3bd75-d102-4b82-b2bc-7f97241a0798", "AQAAAAIAAYagAAAAEP4LpmlVBfRk8g4yIey8mBM/W+qz3PgJSnzz8x9sgGPBABhtVBtY9Jg7yb/bj3v/Sw==", "b854a980-2789-44e4-b2c0-6d2f262c0d3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d792f5a0-a066-424b-b781-148d8d08baa0", "AQAAAAIAAYagAAAAEG436tUokNbeq42zTUy57R5dQnMbu6KigUQQUMmhX/MjcSkgN1plNrDibn9wmeqHLA==", "c99dbf59-7893-4939-8ba7-d34418871e0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e427ebcc-b8c5-4de1-8c4a-db6b28a68d46", "AQAAAAIAAYagAAAAENFSEpjou78YONEDefhAY+DHHgkFSLN+ZwdR3bYDBNLPMe7/lq8xBUdwyH5JkzROvg==", "ab72a917-48ba-4913-b96b-042c56812823" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "500ed216-93ae-4434-ad5d-8b89e596dac1", "AQAAAAIAAYagAAAAEO7sj7Fo7308D7gxrMnFUD2C3aN57KaE7cO3MDxpkcwOrnRGNnLy6jrBF+EPD+oYkg==", "507bdb97-d5b4-41f1-96ad-eece90bf7970" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67e68d8b-c3ee-43f0-afff-3c376651b6ea", "AQAAAAIAAYagAAAAEE2wZbGvHU+4Dm1dYujDhXJ8bGH3gdrLdlYJ2irItHPr4XZH48Rim229r8F807gLWA==", "43ff3ada-a30c-4d29-9e9f-ab5cd6c04050" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0f795ae-980c-48da-8640-c7ec438fb67e", "AQAAAAIAAYagAAAAEBpCaikBLnFz8hdWSyrUPLVrIMkFs1MRV6hVGjR1JNf4c7mHGZHMwD1krLMvYDP60g==", "dc125d05-1a68-49b3-9d16-5340aa70f8db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "818e4f77-ee00-4db0-9492-446d2e3dda35", "AQAAAAIAAYagAAAAEBAQljY/V9YbucDOVtSC4BdkK1NH5pqV+E0pe/CMKpGC2vthz6BCmFuSb/F9ty+VQw==", "419d320b-791d-4567-99ce-0d672b4a4ba8" });

            migrationBuilder.AddForeignKey(
                name: "FK_FoodAllergies_Allergies_AllergyId",
                table: "FoodAllergies",
                column: "AllergyId",
                principalTable: "Allergies",
                principalColumn: "AllergyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAllergies_Allergies_AllergyId",
                table: "UserAllergies",
                column: "AllergyId",
                principalTable: "Allergies",
                principalColumn: "AllergyId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodAllergies_Allergies_AllergyId",
                table: "FoodAllergies");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAllergies_Allergies_AllergyId",
                table: "UserAllergies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Allergies",
                table: "Allergies");

            migrationBuilder.RenameTable(
                name: "Allergies",
                newName: "Allergy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Allergy",
                table: "Allergy",
                column: "AllergyId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65f6fde7-b45c-4423-9c26-424dfe3a6420", "AQAAAAIAAYagAAAAEEhg68yVRN1+40GPrbKlDu7Ml5wrlG23G1/sLN0SI9VsHd5zZJOQahBWEst37IZKxw==", "0856c002-7e93-49d7-8c0f-7bf3d2cdeb43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "979d6ee9-0079-45fc-9ba8-18dc4096f5e6", "AQAAAAIAAYagAAAAEPdBqKDhvsCuWGp3nON/wb+SJk0+SdKTNH7kx95Wu6GnhNeNM9f1nwKrl2Vzkg8Ybg==", "f4d53ae2-ec99-4866-b5f0-9ac7c6be66bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58bec576-b9d2-41fb-aed2-24cc955b8ee7", "AQAAAAIAAYagAAAAED5PJbU+NrFXkfr+vPNtMU/DHxI22N82qesLJKx5Kb5BgJTo1Paf2Q2C44RvSL/tlQ==", "d95c42d1-5b7a-4cbc-a363-de03325c9104" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a92663b1-8090-4670-b1b1-41cb0d3287ee", "AQAAAAIAAYagAAAAECoCEbXgPP4psz86swECfH3rkGlWwufQoWpkHF9Ph4in3RsBiPnW/k/+NKcAbXOEOw==", "1788d75b-f003-4097-9419-c3bee52f444e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc447c9f-3323-4724-9487-e47038e11a59", "AQAAAAIAAYagAAAAEAKK8VWcBa1PsO8yr4iicADKIsQjbns1C7ybVQbeTkzRj0n2+o4+lw9vGEWslsw7/g==", "dc41b382-da9f-44e3-91bc-7b7f2daab49e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "259f7b85-7916-4155-80bb-cf6e72d119ff", "AQAAAAIAAYagAAAAEOG05E71wS6J/RYvZyR8O8B+itLScNPDPeJkS0Zkx87lscBdM0ehY3cyrz8Bsf0i7A==", "031cd72d-3769-4fbe-b48c-4b146fffc031" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed11fefc-30a4-401b-a91d-6c01c77cf9d9", "AQAAAAIAAYagAAAAEOkapVx3668vb3O6l5SB9OwIwxBDFR+JLJXYNioflbJdee7ZwapucV9Rh6N0v5gHxw==", "9b5858b7-eef8-4dfc-ac53-b48599cc33e6" });

            migrationBuilder.AddForeignKey(
                name: "FK_FoodAllergies_Allergy_AllergyId",
                table: "FoodAllergies",
                column: "AllergyId",
                principalTable: "Allergy",
                principalColumn: "AllergyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAllergies_Allergy_AllergyId",
                table: "UserAllergies",
                column: "AllergyId",
                principalTable: "Allergy",
                principalColumn: "AllergyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
