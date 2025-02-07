using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Monhealth.Identity.Migrations
{
    /// <inheritdoc />
    public partial class AddCaloriesCatioForGoal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("01204cc2-1030-4803-b9d5-9fca856ee169"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("085b42a5-a607-4971-adc7-4d42390dabd0"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("3ba5469d-42aa-40db-a95c-dc8541bcc3d0"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("3d669fa9-30ca-461e-a1df-369c6a24103f"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("4526f68b-753b-414a-8ee7-313af1052b15"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("57309f32-053a-4374-bd2d-fcb1eeba4c96"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("5763e39e-2b6b-4b32-9001-f3ed4cbac06a"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("6910c323-46fa-40f5-8c70-a81f848ec23f"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("6e4e73a8-7a6d-414f-9062-0fc76ba9974f"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("83af16a1-9890-4337-b03e-18682d0abc4d"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("8bf230f8-74dc-482e-9798-7409bfda49e2"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("90e4e430-673f-433b-853e-4daad7654be1"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("97ffb64f-bf83-4dfb-bbb7-68c713561ef9"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("9a772804-96b3-4257-b2f5-eb7074e4ffc6"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("a00235f8-07a0-4bc1-a241-a8eedcc1e063"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("b3fa8fcb-b3a9-44c9-95e8-95502f409f8f"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("b4483531-bf93-4b46-9d52-49703bf76a27"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("b935edf6-eed1-47cf-a117-ca22f8c0926a"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("ca292322-7ae7-47ea-9a47-cd632e50eca3"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("daaebf30-0ddc-4f8f-a09c-77ef406791e0"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("e052b273-9e6f-4810-9896-9a8e776e9cde"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("eaf2a65b-723e-48f9-8efa-38a0bd47442d"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("ec1e013b-c112-4105-a643-54a7c4f68a4e"));

            migrationBuilder.AddColumn<float>(
                name: "CaloriesRatio",
                table: "Goals",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3876e700-45e0-4b83-8fc4-df01aa44baa6", "AQAAAAIAAYagAAAAEBNJ1F/aP3o6fyffmWrG6RqXjHScRl5IUFUh1knDRUOHlDJYClLGTxbSJMj37VtSMQ==", "eddd20ff-0adb-4bc0-a11d-320f668fe4b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe05f621-46fa-49c2-b165-48154c8927ac", "AQAAAAIAAYagAAAAEIHXU6zUjkW6IwWRqACtnBfXCMMJTfHsT1RxjsF/P5nX1euBu7ZWYQOq+SOQ1PuUlQ==", "3d216649-6af2-432e-aa86-a724afafe1bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ef72258-3706-4dd9-a72d-57014bec54be", "AQAAAAIAAYagAAAAEGPi4ZgSbqrsbzZGVhQyEkBtssogiCGo58W5aT+JAJT3q1BOA7+xAc83UDByPwDcOA==", "d0480a3a-fd95-4122-87ee-4638c0f5c431" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "979281b3-c38f-4f19-a7ff-6c0da4eabe01", "AQAAAAIAAYagAAAAEKOjgVOHkbHHo5q5fHSsFMWDhPh9iiw52SOTyu+0O3Jryq1Mko8fHoUxCGnc8NC/qg==", "7ce202a5-ff5e-4261-9bec-32b2c2a5a7ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b420cb1-b69e-45a0-91bf-07ff4111af99", "AQAAAAIAAYagAAAAENiFV1dfjxFiRJbwni4nzPNVrXvJFq/WKj31hrxOkH5FkuhVcl2dfoXoG4fGMw6zbA==", "2e3ac953-a080-4be1-9172-d306690f1653" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42e4bc6c-4d7d-4970-bff1-e27b0b91431a", "AQAAAAIAAYagAAAAEMMCkxvzED4X5o6kEfFZaJ34XABZzp42B6GDGJ/uo9s1ywraGUBAO8cRntqiN1g+0g==", "412ce4d9-4f0e-4270-8282-d7d0b5490a0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d402380-d1ce-41b4-9ded-00b379be475a", "AQAAAAIAAYagAAAAEKRrPNQ7iCSkrIyFtd0AhJWUo+IFm6LvxiQHSyCQ4opuuzTC3wVKNYAFxbQyU0bHSA==", "ed40ad7c-b28d-401d-b0f0-5a3e2a62c243" });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "WorkoutExerciseId", "CreatedAt", "Duration", "ExerciseId", "Status", "UpdatedAt", "WorkoutId" },
                values: new object[,]
                {
                    { new Guid("05b589d5-62ac-4175-90e0-161c28a042dd"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("86365264-7f1c-4bc2-8886-92a8523624b4"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8") },
                    { new Guid("08914f4c-abd2-4126-8ef9-b482bd91f032"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("00355a5e-e30b-4770-a4e5-abf20671a049"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c7ded15-2d6e-45f3-8854-f9f12f84493c") },
                    { new Guid("19577597-e0ac-441e-b22e-764cd2f2c432"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("2f4c14b8-3207-40dc-8233-1ec310a47dd5"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c") },
                    { new Guid("198ecb40-5c7e-4ac1-90ae-82d97873a2f7"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("7213c6ec-d1ea-4e7e-97b7-5f4cd675f7ba"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c7ded15-2d6e-45f3-8854-f9f12f84493c") },
                    { new Guid("1b3a7696-0474-4697-b135-7c6bfb1018d5"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("f344b5e8-c338-4da7-a99c-78952ba2db9b"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8") },
                    { new Guid("35805fc8-fda5-4141-b99c-f2d7c871e4b2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("9ba0c68f-426b-4459-8b12-7eafc4b43f2b"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7") },
                    { new Guid("35cf58cd-8ffb-47c5-825c-e6e0f063c196"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("21e53e39-de13-43c1-ad22-f69ac024677a"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7") },
                    { new Guid("4934861b-fe0d-40f1-86de-e567cb8ffa82"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("fc719720-6259-4e21-bec9-82b2949e35e2"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7") },
                    { new Guid("51f9d834-e93e-4e6b-9e81-c99437e39e19"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("e37feb90-ad70-4da1-b274-809412dd808a"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8") },
                    { new Guid("56938857-f0a0-467d-8c22-0ee5c2da0e4a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("c0d1b74c-521b-428b-9776-0f9e95bd0ef0"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c") },
                    { new Guid("56b0dc0b-595d-44a8-83fe-0d8bf671561e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, new Guid("b39f7142-3d9b-4e80-9304-342de4ebe8d0"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c7ded15-2d6e-45f3-8854-f9f12f84493c") },
                    { new Guid("57be818a-b600-4153-ac88-5ea332fbbaa0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, new Guid("9cadb2bc-6ae3-49a1-a094-c89039795ca3"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c7ded15-2d6e-45f3-8854-f9f12f84493c") },
                    { new Guid("599c95c7-8e3c-46e9-a694-00d173a0afc4"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("ae68fd8e-0226-4368-824a-abe06fed86b3"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7") },
                    { new Guid("6916e7b4-569f-4b63-b232-d0a454ccab2a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("c09b0b4e-dfad-4d62-b620-e3a348849393"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c7ded15-2d6e-45f3-8854-f9f12f84493c") },
                    { new Guid("8e0da8c6-2144-420c-bbc5-8a51d0e4747f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("32989028-4533-4700-b454-a4df1cfa08a9"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8") },
                    { new Guid("a90f51a4-db7b-4af9-9a44-a128ff5d3ea1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("67c5180f-978d-4cd7-ae1e-57fa80ac5e27"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c") },
                    { new Guid("b27babcb-c3b2-4aeb-bbb6-f0ed4541ddff"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("21e53e39-de13-43c1-ad22-f69ac024677a"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8") },
                    { new Guid("cfe6d187-71f6-4093-9f63-8a08869b6ab2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("1d7e129b-30e5-4ca7-ade1-0ac2c2534332"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7") },
                    { new Guid("dec964eb-c784-4d59-9832-52bd519074b0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("c37426f7-6e98-4dcd-85b5-49e9e75aa380"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c") },
                    { new Guid("deff7202-1ecc-4f17-9493-0fae594e98e0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("ae68fd8e-0226-4368-824a-abe06fed86b3"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c") },
                    { new Guid("f4adc65b-4316-4aa8-a7b1-603d6be1f7f6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("fc719720-6259-4e21-bec9-82b2949e35e2"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8") },
                    { new Guid("f8ab334d-022b-4fbf-86a6-8d11d3d0a830"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("e37feb90-ad70-4da1-b274-809412dd808a"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7") },
                    { new Guid("fd647fae-a7f4-4314-b114-c5fcf2dd110f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("1d7e129b-30e5-4ca7-ade1-0ac2c2534332"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c7ded15-2d6e-45f3-8854-f9f12f84493c") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("05b589d5-62ac-4175-90e0-161c28a042dd"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("08914f4c-abd2-4126-8ef9-b482bd91f032"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("19577597-e0ac-441e-b22e-764cd2f2c432"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("198ecb40-5c7e-4ac1-90ae-82d97873a2f7"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("1b3a7696-0474-4697-b135-7c6bfb1018d5"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("35805fc8-fda5-4141-b99c-f2d7c871e4b2"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("35cf58cd-8ffb-47c5-825c-e6e0f063c196"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("4934861b-fe0d-40f1-86de-e567cb8ffa82"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("51f9d834-e93e-4e6b-9e81-c99437e39e19"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("56938857-f0a0-467d-8c22-0ee5c2da0e4a"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("56b0dc0b-595d-44a8-83fe-0d8bf671561e"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("57be818a-b600-4153-ac88-5ea332fbbaa0"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("599c95c7-8e3c-46e9-a694-00d173a0afc4"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("6916e7b4-569f-4b63-b232-d0a454ccab2a"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("8e0da8c6-2144-420c-bbc5-8a51d0e4747f"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("a90f51a4-db7b-4af9-9a44-a128ff5d3ea1"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("b27babcb-c3b2-4aeb-bbb6-f0ed4541ddff"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("cfe6d187-71f6-4093-9f63-8a08869b6ab2"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("dec964eb-c784-4d59-9832-52bd519074b0"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("deff7202-1ecc-4f17-9493-0fae594e98e0"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("f4adc65b-4316-4aa8-a7b1-603d6be1f7f6"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("f8ab334d-022b-4fbf-86a6-8d11d3d0a830"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "WorkoutExerciseId",
                keyValue: new Guid("fd647fae-a7f4-4314-b114-c5fcf2dd110f"));

            migrationBuilder.DropColumn(
                name: "CaloriesRatio",
                table: "Goals");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95e76253-1a20-4f02-96cc-a9c1f8c1bb38", "AQAAAAIAAYagAAAAEKMdhKXAGIDEsdXnVwBvcWp8K3MGqb/0RDBCHWUDAE70KdWrUEt4d19avofSbdZA5w==", "8d109692-e363-40a8-8468-8a3048a9b380" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "552aa243-0046-40d0-8e06-7dd8e895192a", "AQAAAAIAAYagAAAAEItErv0SSB9SEQ+3dW6C4MeXh5aeRN616zDWde0/23G+c+HH17eIoUXW1yA8xnkqPA==", "21d5076f-5acd-4ebd-89d3-fd5d69770dd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56403ecc-5567-45aa-a01a-8531a134c207", "AQAAAAIAAYagAAAAEIWGmJq/cSIQSpQeqdfAiovkPY3MQ9HLL8Y/baz+cDnqNigd36C4HOCIx8Lt06uZlA==", "791594b6-577d-493b-b8cd-153faaa466ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53922bee-8860-4e96-b964-9bb5de5f7b4f", "AQAAAAIAAYagAAAAEPQFbH8Ow/qmBxpSUA/ZHFPm1n5KwZZnUGsnI7duL3fPXO+Az8HACSf8HDunWPkLsg==", "d45a9e6c-a9b4-42e8-91e4-9d474eb1aeb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63973fa2-c133-42ce-92f4-a4b57e5648ee", "AQAAAAIAAYagAAAAEJ/6yGIXCRhWVx02Ke7lPaAnJEEHYFNRLUcx1kzqunjgq+OciubHTJehD4Y/kzA4Ng==", "d10419fb-f310-4e31-a40f-d01f97ffc58a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c3824cc-4fe5-4855-a970-5775923ffbe9", "AQAAAAIAAYagAAAAEHovTGlBJUuKlSYOUAyOqHyzLAnVIBTSO8EzlRzWo38zVB2Ib5UDhuvQJYaoKzuJMA==", "0bb9c237-a51c-4e69-bf8c-94bade2144ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "452e2941-51fa-4153-833d-03d695cd848d", "AQAAAAIAAYagAAAAEN2G1RzPf1dZjp/aVmdzzmG5WDQwtbFov8udjWvB/gKAKfjqwTo/3J6PN86yGDMPcw==", "f1114346-41e5-40ae-8091-a1f7a9417fbf" });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "WorkoutExerciseId", "CreatedAt", "Duration", "ExerciseId", "Status", "UpdatedAt", "WorkoutId" },
                values: new object[,]
                {
                    { new Guid("01204cc2-1030-4803-b9d5-9fca856ee169"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("00355a5e-e30b-4770-a4e5-abf20671a049"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c7ded15-2d6e-45f3-8854-f9f12f84493c") },
                    { new Guid("085b42a5-a607-4971-adc7-4d42390dabd0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("9ba0c68f-426b-4459-8b12-7eafc4b43f2b"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7") },
                    { new Guid("3ba5469d-42aa-40db-a95c-dc8541bcc3d0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("1d7e129b-30e5-4ca7-ade1-0ac2c2534332"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c7ded15-2d6e-45f3-8854-f9f12f84493c") },
                    { new Guid("3d669fa9-30ca-461e-a1df-369c6a24103f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("21e53e39-de13-43c1-ad22-f69ac024677a"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7") },
                    { new Guid("4526f68b-753b-414a-8ee7-313af1052b15"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("c37426f7-6e98-4dcd-85b5-49e9e75aa380"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c") },
                    { new Guid("57309f32-053a-4374-bd2d-fcb1eeba4c96"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("67c5180f-978d-4cd7-ae1e-57fa80ac5e27"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c") },
                    { new Guid("5763e39e-2b6b-4b32-9001-f3ed4cbac06a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("1d7e129b-30e5-4ca7-ade1-0ac2c2534332"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7") },
                    { new Guid("6910c323-46fa-40f5-8c70-a81f848ec23f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("ae68fd8e-0226-4368-824a-abe06fed86b3"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7") },
                    { new Guid("6e4e73a8-7a6d-414f-9062-0fc76ba9974f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, new Guid("9cadb2bc-6ae3-49a1-a094-c89039795ca3"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c7ded15-2d6e-45f3-8854-f9f12f84493c") },
                    { new Guid("83af16a1-9890-4337-b03e-18682d0abc4d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("f344b5e8-c338-4da7-a99c-78952ba2db9b"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8") },
                    { new Guid("8bf230f8-74dc-482e-9798-7409bfda49e2"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("86365264-7f1c-4bc2-8886-92a8523624b4"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8") },
                    { new Guid("90e4e430-673f-433b-853e-4daad7654be1"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("21e53e39-de13-43c1-ad22-f69ac024677a"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8") },
                    { new Guid("97ffb64f-bf83-4dfb-bbb7-68c713561ef9"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, new Guid("b39f7142-3d9b-4e80-9304-342de4ebe8d0"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c7ded15-2d6e-45f3-8854-f9f12f84493c") },
                    { new Guid("9a772804-96b3-4257-b2f5-eb7074e4ffc6"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("e37feb90-ad70-4da1-b274-809412dd808a"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8") },
                    { new Guid("a00235f8-07a0-4bc1-a241-a8eedcc1e063"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("c0d1b74c-521b-428b-9776-0f9e95bd0ef0"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c") },
                    { new Guid("b3fa8fcb-b3a9-44c9-95e8-95502f409f8f"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("c09b0b4e-dfad-4d62-b620-e3a348849393"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c7ded15-2d6e-45f3-8854-f9f12f84493c") },
                    { new Guid("b4483531-bf93-4b46-9d52-49703bf76a27"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("2f4c14b8-3207-40dc-8233-1ec310a47dd5"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c") },
                    { new Guid("b935edf6-eed1-47cf-a117-ca22f8c0926a"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("fc719720-6259-4e21-bec9-82b2949e35e2"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8") },
                    { new Guid("ca292322-7ae7-47ea-9a47-cd632e50eca3"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("ae68fd8e-0226-4368-824a-abe06fed86b3"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c") },
                    { new Guid("daaebf30-0ddc-4f8f-a09c-77ef406791e0"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("7213c6ec-d1ea-4e7e-97b7-5f4cd675f7ba"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c7ded15-2d6e-45f3-8854-f9f12f84493c") },
                    { new Guid("e052b273-9e6f-4810-9896-9a8e776e9cde"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("fc719720-6259-4e21-bec9-82b2949e35e2"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7") },
                    { new Guid("eaf2a65b-723e-48f9-8efa-38a0bd47442d"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("e37feb90-ad70-4da1-b274-809412dd808a"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7") },
                    { new Guid("ec1e013b-c112-4105-a643-54a7c4f68a4e"), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("32989028-4533-4700-b454-a4df1cfa08a9"), false, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8") }
                });
        }
    }
}
