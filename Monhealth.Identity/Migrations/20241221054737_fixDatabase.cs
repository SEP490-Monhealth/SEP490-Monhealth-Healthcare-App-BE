using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class fixDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6241ebf-c959-445c-8d78-618bae1ed5e3", "AQAAAAIAAYagAAAAELcnJkdLE3L5FSx3mZeexuAoJW5hvONUCZ5h7YeDAg63QEOhJlv7b9arfVmifNCvbw==", "f794865a-ae56-40e8-8b43-c64a413ec970" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "059e146d-8f2c-4edd-b359-6ec738bfafc6", "AQAAAAIAAYagAAAAEATFhPvj+sk+VdxYSDhk10oUM8vYSC1iDJfuRaBGPMVVALvzxRS89b9S34OOju2E9Q==", "c9b292e1-095b-481b-bff9-37b607f7be1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e8767ac-8310-4cfe-a434-418c0cc1bed6", "AQAAAAIAAYagAAAAEPgTHPf89TJwnxAdC+B7OwWgUvkzVI84bNM2znHtv55iEdcjRMAidpsyDCA1CzO5qg==", "70f2cac6-f1ea-4e3c-8ab1-07084f9fd99d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4022108-f21b-4c33-b9f3-51c8cf0126dc", "AQAAAAIAAYagAAAAENwKa6gRwyJsRoFFTdl6T8UnaRcD+VAcFeMmP//OJ6F7Ewv/t+GtPi3btRZjAuq9eQ==", "b4a8d109-71d7-4f23-872f-28998b887db4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28c8b356-10ec-4445-970d-6b8287f8c34c", "AQAAAAIAAYagAAAAEGBg0abwyAmxht0lYIIswV/7q2NI87Mh+0CFUBAeiY6IX3Y7lO2EpN/nwXYel/yv3A==", "e014119f-e618-41c9-8077-15b5e56edf3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81732088-4eb2-489a-b13a-d0340450dbac", "AQAAAAIAAYagAAAAEELRiYixWKNrESe/z2W4lSgrP2SjlIKar1Fc57BifH/NNE6a3hF+fPMWoi5VYxq8pw==", "c0a537da-3014-4885-b2d8-9f3b2d47b25f" });

            migrationBuilder.InsertData(
                table: "Portions",
                columns: new[] { "PortionId", "CreatedAt", "CreatedBy", "MeasurementUnit", "PortionSize", "PortionWeight", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("a44fd2e0-b595-4423-9e6f-42a010d96f66"), null, null, "g", "Chén", 100f, null, null },
                    { new Guid("d2f3a6c9-19c1-45fa-9a4f-3ad8396c19a7"), null, null, "g", "Phần ăn", 100f, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "ba7d267f-7f21-4a6a-9f6c-7ad094546b3a", "AQAAAAIAAYagAAAAELyQ+A2bedYZh5kuBarGi8HVWfQEmz+wP45Q3BG2JCSWxZP6SgISe7CkMa9lWrZCTQ==", "b327421a-7c21-4938-a51d-464a5d0c1b42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a0e1022-b80d-4674-8fec-70d2d503d88f", "AQAAAAIAAYagAAAAEIm4HCcTMuyUKruPNEzYQbQtcLlMxX50S6szjG7k4qL+QLL0DOx0211YMRVP2fpX1w==", "4e7eeeaf-ba43-4fc2-bad2-e1fee73cc5c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb9d163f-83ab-4fc9-97fc-e61997fd3a83", "AQAAAAIAAYagAAAAENziQgUCtU6EbmZZgkdramXpksDlNvXVMVzzG5fK2eQLkVzuE+i9+nrmxQi+1SSJMQ==", "5c1e7792-427a-4920-a26a-cdc7104cde5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8707e68d-ba13-4b81-b387-4ac645c2976b", "AQAAAAIAAYagAAAAEITcIpPsWHGVxnQTBpvhHA/RfJ0JyDLKayZqADxKYORbg4pBPvtQudOkTJfVIWInCA==", "f25caf72-3cde-4c7b-aea5-f7b9846e5680" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8512dc41-d778-474c-8ea4-832f64cc1baf", "AQAAAAIAAYagAAAAEBPqw1+QjdC4VeobVMBXPCNmVgIL65SczaaLyJ8S7zi/K1Tl4q0FHhAu6G39up5qPA==", "b7beb976-02f8-4062-8467-0b5b01363ef8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "925ed51c-db00-43d3-bc83-85c675fbf482", "AQAAAAIAAYagAAAAEPEnLQFGNOzBr7Fr/fbcHBzZ22CdpH1iKpN1TVnsZtRw+4r9VpuMdhh+0SbxgdXYjw==", "e4de4cd8-88df-42f3-b4e7-0f7f7c1de114" });
        }
    }
}
