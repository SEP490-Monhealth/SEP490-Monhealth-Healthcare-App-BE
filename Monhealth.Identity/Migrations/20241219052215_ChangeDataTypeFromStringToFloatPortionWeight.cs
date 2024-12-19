using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDataTypeFromStringToFloatPortionWeight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "PortionWeight",
                table: "Portions",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05dcfebe-678c-4077-b4f7-6f89139b26ff", "AQAAAAIAAYagAAAAEFTcSJHWz+kB4cl8cLpUtsAbWaCAWGoKISq1JB8cK7cYFXAX7r6NbE//q8aNBUSZSg==", "c91d8ceb-13d8-4661-9281-9631b6900516" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19a593d0-4b57-4ab4-b072-40888ea1b8f6", "AQAAAAIAAYagAAAAED9apHnVys/y+i16/EfjlJG7aGErFBzPYiOMpMr//cj1lA4VYR2vU2J5OrF17siTnA==", "3ae08119-e738-480b-baa6-f2f01e78c0bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44522466-2e8d-4010-894d-1015ad7bb9ce", "AQAAAAIAAYagAAAAEAk4m/NdgMnUCHZnmPg3rybpz4hEV9r5Otc4pKWUwCKlVAoepIngzpi+Ow4JwB2XHg==", "6966647e-c5bc-4d14-9fb9-73acd60ae5c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a5b3195-d84e-4eca-9ce6-d8103b8e861f", "AQAAAAIAAYagAAAAEJ9seQHx/f3p/FbLAXPHQ1q+tW1hiOLi36BrVhlPAw2msclLwhKdb8KrmQZduaAVHQ==", "f6c85add-cde0-4727-befe-92d257a9f70c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fd7da96-e82d-4e5f-b835-98c8dcfbda47", "AQAAAAIAAYagAAAAEBuEWGzhVIN+HzsZcr+tDUS9ILWnef8yKt6f4KAF9KueJ/RRmhEySU0UFbobNc3Wyg==", "a7a94079-acff-4d81-bf77-a5c1995f6d89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3491dea7-0dd5-40bf-bb5a-f2de9e5d9082", "AQAAAAIAAYagAAAAEFSlDe0G3P26nB/0qcfnm+3TNdpK3gEVLEGDT098ZKQpbd59uCpY7G4Gz/318h3PKA==", "065dc293-ff19-4b37-a98d-71784262493c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PortionWeight",
                table: "Portions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec31f49a-0e87-4c62-a55d-5c0a5689dc61", "AQAAAAIAAYagAAAAELi4SpNazwxIdXYOiCcAH13FowLfSId+pUqqLo2CTDUGOypd7sNUQVGzbfuSq3PS1w==", "4415839e-ea8d-4547-904f-a007f708eb3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fc0ac5d-40be-45a0-9928-078eaf3059e4", "AQAAAAIAAYagAAAAEGodVHtqdBFpcFwuPvahtmsDACOuZ6yJqNHR3pGS66Wvh89cXhLfKMYpiGzCqGML3g==", "a555bd30-5c3c-4107-8a9b-b2086c310c32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fa51b9a-8857-4616-ac3b-d55491e3a11b", "AQAAAAIAAYagAAAAEEK4GxHS1+rliWZcuznF3Szjvl2xJJfF6vIUcwWrftUnBpQ/s6+DmV7Nce1ykRrLtQ==", "0c5a4b94-82c5-42ce-9a01-2384accc3fcb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd67ff27-577b-4ee1-8eeb-5bd49a0aeaab", "AQAAAAIAAYagAAAAEAiCzsmWT31mi1jLrt4JOIXTvaHnG7oW+StBxsEn9xUhcixGHqzzm2mzeVmRuOEH/g==", "5bde04ed-cf85-4970-8bc5-be524a544551" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47397846-ffc7-416d-bdb1-5a156f4c7657", "AQAAAAIAAYagAAAAEFzNv0wrLiV7ACiUPHkQtd5PX81vlVAyisfiTVH1Nvj+uW5jVGiL2Xisn3ABpF/5Sg==", "09f66786-631f-4185-9948-b22827149583" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66ae87a3-3beb-4a74-a24e-4379179da5f9", "AQAAAAIAAYagAAAAEMDAW7ucMKDeA5Fpbly8gfT4X8FrUsHOgQxNz2BVxgUKPDXWbYxmJpnv8hQGLb5LtQ==", "dacc6fa5-bf96-4199-a936-a85b1791906b" });
        }
    }
}
