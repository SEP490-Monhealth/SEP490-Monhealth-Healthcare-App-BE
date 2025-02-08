using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            var userId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6");
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            //#region Exercise 1
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("aac12e14-eb0e-4921-9fee-8a72cc46f13e"),
            //    CategoryId = Guid.Parse("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"),
            //    UserId = userId,
            //    ExerciseName = "Sit-Ups",
            //    Instructions = "Nằm ngửa, co gối, đặt tay sau đầu. Nâng thân lên hướng về gối, sau đó trở về. Lặp lại",
            //    Duration = 30,
            //    CaloriesBurned = 8f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 2
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("2f4c14b8-3207-40dc-8233-1ec310a47dd5"),
            //    CategoryId = Guid.Parse("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"),
            //    UserId = userId,
            //    ExerciseName = "Plank",
            //    Instructions = "Nằm úp, nâng cơ thể bằng khuỷu tay và ngón chân. Giữ cơ thể thẳng. Giữ tư thế này",
            //    Duration = 60,
            //    CaloriesBurned = 5f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 3
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("d409a2a7-e695-4696-94c3-41013d590887"),
            //    CategoryId = Guid.Parse("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"),
            //    UserId = userId,
            //    ExerciseName = "Dynamic Rollup",
            //    Instructions = "Nằm phẳng, duỗi tay qua đầu. Cuộn lên tư thế ngồi, sau đó cuộn trở lại",
            //    Duration = 45,
            //    CaloriesBurned = 7f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 4
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("b45baf25-682a-4de3-b5aa-15f4ea6e590d"),
            //    CategoryId = Guid.Parse("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"),
            //    UserId = userId,
            //    ExerciseName = "Side Crunches",
            //    Instructions = "Nằm nghiêng, co chân. Nâng thân lên nghiêng về phía gối",
            //    Duration = 30,
            //    CaloriesBurned = 6f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 5
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("6ee8f18c-d1de-4899-8af9-8bc7341cb225"),
            //    CategoryId = Guid.Parse("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"),
            //    UserId = userId,
            //    ExerciseName = "Mason Twist",
            //    Instructions = "Ngồi, co gối, nhấc chân khỏi sàn. Xoay thân từ bên này qua bên kia",
            //    Duration = 30,
            //    CaloriesBurned = 8f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 6
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("f2e4e45f-9514-452c-91ff-d5486243fb0d"),
            //    CategoryId = Guid.Parse("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"),
            //    UserId = userId,
            //    ExerciseName = "Reaching Crunch",
            //    Instructions = "Nằm ngửa, co gối. Đưa tay về phía gối khi nâng thân lên",
            //    Duration = 30,
            //    CaloriesBurned = 6f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 7
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("ab679a82-97a1-4772-a824-69de7a8626d5"),
            //    CategoryId = Guid.Parse("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"),
            //    UserId = userId,
            //    ExerciseName = "Corkscrew",
            //    Instructions = "Nằm ngửa, chân duỗi thẳng lên. Xoay chân theo vòng tròn",
            //    Duration = 45,
            //    CaloriesBurned = 9f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 8
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("c37426f7-6e98-4dcd-85b5-49e9e75aa380"),
            //    CategoryId = Guid.Parse("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"),
            //    UserId = userId,
            //    ExerciseName = "Bicycle Crunches",
            //    Instructions = "Nằm ngửa, luân phiên chạm khuỷu tay đối diện vào gối theo động tác đạp xe",
            //    Duration = 30,
            //    CaloriesBurned = 8f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 9
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("8f7b3eaf-288e-47bd-8a37-94133fe25e62"),
            //    CategoryId = Guid.Parse("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"),
            //    UserId = userId,
            //    ExerciseName = "Elevated Crunches",
            //    Instructions = "Đặt chân trên bề mặt nâng cao, thực hiện động tác gập bụng",
            //    Duration = 30,
            //    CaloriesBurned = 7f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 10
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("78e05e91-0d2a-4418-a363-281cfa7ced50"),
            //    CategoryId = Guid.Parse("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"),
            //    UserId = userId,
            //    ExerciseName = "Hundred Pike",
            //    Instructions = "Nằm phẳng, nhấc chân thẳng lên, bơm tay hướng xuống đất",
            //    Duration = 60,
            //    CaloriesBurned = 10f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 11
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("67c5180f-978d-4cd7-ae1e-57fa80ac5e27"),
            //    CategoryId = Guid.Parse("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"),
            //    UserId = userId,
            //    ExerciseName = "Seated Core Twist",
            //    Instructions = "Ngồi thẳng, xoay thân qua lại hai bên",
            //    Duration = 30,
            //    CaloriesBurned = 6f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 12
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("8482d5db-ee6e-473e-b156-500de0619dfc"),
            //    CategoryId = Guid.Parse("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"),
            //    UserId = userId,
            //    ExerciseName = "Abdominal Hip Raises",
            //    Instructions = "Nằm ngửa, nâng hông lên trần nhà",
            //    Duration = 45,
            //    CaloriesBurned = 8f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 13
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("ae68fd8e-0226-4368-824a-abe06fed86b3"),
            //    CategoryId = Guid.Parse("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"),
            //    UserId = userId,
            //    ExerciseName = "Russian Twist",
            //    Instructions = "Ngồi, co gối, xoay thân qua lại hai bên",
            //    Duration = 30,
            //    CaloriesBurned = 8f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 14
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("c0d1b74c-521b-428b-9776-0f9e95bd0ef0"),
            //    CategoryId = Guid.Parse("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"),
            //    UserId = userId,
            //    ExerciseName = "Leg Lifts",
            //    Instructions = "Nằm phẳng, nâng cả hai chân lên trần nhà, sau đó hạ xuống",
            //    Duration = 30,
            //    CaloriesBurned = 5f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 15
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("1d7e129b-30e5-4ca7-ade1-0ac2c2534332"),
            //    CategoryId = Guid.Parse("7d730669-e718-4c17-ae6e-529636932e62"),
            //    UserId = userId,
            //    ExerciseName = "Jump Squats",
            //    Instructions = "Thực hiện động tác squat, sau đó nhảy lên mạnh mẽ",
            //    Duration = 30,
            //    CaloriesBurned = 10f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 16
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("4c2f77bb-3bb2-4348-b6cd-a5325f3b2214"),
            //    CategoryId = Guid.Parse("7d730669-e718-4c17-ae6e-529636932e62"),
            //    UserId = userId,
            //    ExerciseName = "Outer Thigh Raises",
            //    Instructions = "Nằm nghiêng, nâng chân trên lên xuống",
            //    Duration = 30,
            //    CaloriesBurned = 5f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 17
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("09d79e39-bbd9-4405-9fa6-8d5cd4fc8c7f"),
            //    CategoryId = Guid.Parse("7d730669-e718-4c17-ae6e-529636932e62"),
            //    UserId = userId,
            //    ExerciseName = "Ski Sit",
            //    Instructions = "Dựa lưng vào tường trong tư thế ngồi, đùi song song với mặt đất",
            //    Duration = 45,
            //    CaloriesBurned = 7f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 18
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("9cadb2bc-6ae3-49a1-a094-c89039795ca3"),
            //    CategoryId = Guid.Parse("7d730669-e718-4c17-ae6e-529636932e62"),
            //    UserId = userId,
            //    ExerciseName = "Straight Leg Donkey Kick",
            //    Instructions = "Đứng bốn chân, đá một chân thẳng ra sau và quay lại",
            //    Duration = 30,
            //    CaloriesBurned = 8f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 19
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("7213c6ec-d1ea-4e7e-97b7-5f4cd675f7ba"),
            //    CategoryId = Guid.Parse("7d730669-e718-4c17-ae6e-529636932e62"),
            //    UserId = userId,
            //    ExerciseName = "Bridge Kicker",
            //    Instructions = "Thực hiện động tác nâng hông, đá từng chân một",
            //    Duration = 45,
            //    CaloriesBurned = 9f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 20
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("b39f7142-3d9b-4e80-9304-342de4ebe8d0"),
            //    CategoryId = Guid.Parse("7d730669-e718-4c17-ae6e-529636932e62"),
            //    UserId = userId,
            //    ExerciseName = "Sumo Chair Squats",
            //    Instructions = "Đứng tư thế rộng, squat giữ lưng thẳng",
            //    Duration = 30,
            //    CaloriesBurned = 8f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 21
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("c09b0b4e-dfad-4d62-b620-e3a348849393"),
            //    CategoryId = Guid.Parse("7d730669-e718-4c17-ae6e-529636932e62"),
            //    UserId = userId,
            //    ExerciseName = "Side Lunge March",
            //    Instructions = "Bước sang bên thành tư thế lunge, sau đó trở lại",
            //    Duration = 30,
            //    CaloriesBurned = 6f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 22
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("2ec9ee3b-2768-4ae4-9246-05cdac76a8a6"),
            //    CategoryId = Guid.Parse("7d730669-e718-4c17-ae6e-529636932e62"),
            //    UserId = userId,
            //    ExerciseName = "Single Calf Raises",
            //    Instructions = "Đứng một chân, nâng gót chân lên xuống",
            //    Duration = 30,
            //    CaloriesBurned = 5f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 23
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("a2be65b5-8135-4a29-a44c-b8f34418c537"),
            //    CategoryId = Guid.Parse("7d730669-e718-4c17-ae6e-529636932e62"),
            //    UserId = userId,
            //    ExerciseName = "Rear Lunges",
            //    Instructions = "Bước một chân ra sau thành tư thế lunge, sau đó trở lại",
            //    Duration = 30,
            //    CaloriesBurned = 7f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 24
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("c48fb04a-0b63-4d5b-ad72-6c23a7b8267c"),
            //    CategoryId = Guid.Parse("7d730669-e718-4c17-ae6e-529636932e62"),
            //    UserId = userId,
            //    ExerciseName = "Side to Side Jump Squat",
            //    Instructions = "Thực hiện jump squats trong khi di chuyển từ bên này qua bên kia",
            //    Duration = 45,
            //    CaloriesBurned = 10f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 25
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("7910e21a-a190-4a6f-bd87-54b6f54cf5e3"),
            //    CategoryId = Guid.Parse("7d730669-e718-4c17-ae6e-529636932e62"),
            //    UserId = userId,
            //    ExerciseName = "Prisoner's Squat",
            //    Instructions = "Squat với hai tay đặt sau đầu",
            //    Duration = 30,
            //    CaloriesBurned = 8f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 26
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("dfa2b796-d12d-4e7c-93bf-89f412b0d551"),
            //    CategoryId = Guid.Parse("7d730669-e718-4c17-ae6e-529636932e62"),
            //    UserId = userId,
            //    ExerciseName = "Squat & Reach",
            //    Instructions = "Squat xuống, sau đó với tay lên trên",
            //    Duration = 30,
            //    CaloriesBurned = 6f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 27
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("55fe0528-86d5-49ab-bb6e-a2345418b5de"),
            //    CategoryId = Guid.Parse("7d730669-e718-4c17-ae6e-529636932e62"),
            //    UserId = userId,
            //    ExerciseName = "Jump Squats with Pulse",
            //    Instructions = "Thực hiện jump squat, giữ ở vị trí thấp trước khi nhảy",
            //    Duration = 45,
            //    CaloriesBurned = 10f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 28
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("04424053-69cc-4342-afcf-2b1a62a6dbf1"),
            //    CategoryId = Guid.Parse("462eddbb-989c-4c39-8904-d9a54950f81b"),
            //    UserId = userId,
            //    ExerciseName = "Pulse Rows",
            //    Instructions = "Ngồi thẳng lưng, gập tay về phía sau như chèo thuyền, giữ nhịp đều",
            //    Duration = 30,
            //    CaloriesBurned = 6f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 29
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("15f6c0bf-f983-48c9-b030-863200a7d4eb"),
            //    CategoryId = Guid.Parse("462eddbb-989c-4c39-8904-d9a54950f81b"),
            //    UserId = userId,
            //    ExerciseName = "T Raise",
            //    Instructions = "Đứng thẳng, nâng tay ngang vai thành hình chữ T, sau đó hạ xuống",
            //    Duration = 30,
            //    CaloriesBurned = 5f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 30
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("befbdedd-8795-4f9a-842a-00ea9b770f55"),
            //    CategoryId = Guid.Parse("462eddbb-989c-4c39-8904-d9a54950f81b"),
            //    UserId = userId,
            //    ExerciseName = "Roof Kickback",
            //    Instructions = "Đứng gập người về trước, đẩy tay ra sau, giữ thẳng",
            //    Duration = 45,
            //    CaloriesBurned = 7f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 31
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("b3ba3cfc-34a3-4b31-9e1c-78df5bd7910a"),
            //    CategoryId = Guid.Parse("462eddbb-989c-4c39-8904-d9a54950f81b"),
            //    UserId = userId,
            //    ExerciseName = "Tricep Press",
            //    Instructions = "Ngồi, đặt tay sau lưng, nhấc thân lên bằng cơ tay sau, sau đó hạ xuống",
            //    Duration = 30,
            //    CaloriesBurned = 6f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 32
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("9ba0c68f-426b-4459-8b12-7eafc4b43f2b"),
            //    CategoryId = Guid.Parse("462eddbb-989c-4c39-8904-d9a54950f81b"),
            //    UserId = userId,
            //    ExerciseName = "Push-Up & Rotation",
            //    Instructions = "Thực hiện chống đẩy, sau đó xoay người và nâng một tay lên cao",
            //    Duration = 45,
            //    CaloriesBurned = 9f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 33
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("2f3358f6-6e47-4a7e-8ab1-998a4f58386f"),
            //    CategoryId = Guid.Parse("462eddbb-989c-4c39-8904-d9a54950f81b"),
            //    UserId = userId,
            //    ExerciseName = "Y Raise",
            //    Instructions = "Đứng thẳng, nâng tay chéo ra trước thành hình chữ Y, sau đó hạ xuống",
            //    Duration = 30,
            //    CaloriesBurned = 5f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 34
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("e0176052-1ea9-4af4-8724-6b3b956acdf5"),
            //    CategoryId = Guid.Parse("462eddbb-989c-4c39-8904-d9a54950f81b"),
            //    UserId = userId,
            //    ExerciseName = "Kneeled Narrow Push-Ups",
            //    Instructions = "Chống đẩy gối xuống sàn, hai tay gần nhau",
            //    Duration = 30,
            //    CaloriesBurned = 6f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 35
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("d2efc4c7-fa6e-45d8-a571-61d919650713"),
            //    CategoryId = Guid.Parse("462eddbb-989c-4c39-8904-d9a54950f81b"),
            //    UserId = userId,
            //    ExerciseName = "Spiderman Push-Ups",
            //    Instructions = "Chống đẩy, mỗi lần hạ xuống, đưa một gối lên gần cùi chỏ",
            //    Duration = 45,
            //    CaloriesBurned = 9f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 36
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("4da7a997-6d33-4034-912b-6f1dd1fdab3d"),
            //    CategoryId = Guid.Parse("462eddbb-989c-4c39-8904-d9a54950f81b"),
            //    UserId = userId,
            //    ExerciseName = "Clap Push-Ups",
            //    Instructions = "Chống đẩy, khi nâng lên vỗ tay trước ngực rồi trở về vị trí cũ",
            //    Duration = 30,
            //    CaloriesBurned = 10f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 37
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("e37feb90-ad70-4da1-b274-809412dd808a"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "Burpees",
            //    Instructions = "Nhảy lên, sau đó hạ xuống tư thế chống đẩy, lặp lại",
            //    Duration = 60,
            //    CaloriesBurned = 12f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 38
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("92c92e7d-5eab-491c-8d31-6721158eb1a9"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "Running in Place",
            //    Instructions = "Chạy tại chỗ, nâng cao gối một cách nhẹ nhàng",
            //    Duration = 30,
            //    CaloriesBurned = 8f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 39
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("5ca4aa32-a164-4e51-b6d5-89db5c8fcc46"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "Push-Up & Burpees",
            //    Instructions = "Kết hợp chống đẩy và động tác burpee hoàn chỉnh",
            //    Duration = 45,
            //    CaloriesBurned = 12f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 40
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("fc719720-6259-4e21-bec9-82b2949e35e2"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "Mountain Climbers",
            //    Instructions = "Tư thế plank, kéo gối xen kẽ về phía ngực như leo núi",
            //    Duration = 30,
            //    CaloriesBurned = 10f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 41
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("f344b5e8-c338-4da7-a99c-78952ba2db9b"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "High Knees",
            //    Instructions = "Chạy tại chỗ, nâng cao gối ngang hông",
            //    Duration = 30,
            //    CaloriesBurned = 9f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 42
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("b8d89172-aa14-4315-a7d9-49a44a7b06ca"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "Butt Kickers",
            //    Instructions = "Chạy tại chỗ, gót chân chạm vào mông",
            //    Duration = 30,
            //    CaloriesBurned = 8f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 43
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("c26a95d0-b7b6-4654-b05a-768d078258bd"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "One Leg Side Hops",
            //    Instructions = "Nhảy ngang qua lại bằng một chân, đổi chân xen kẽ",
            //    Duration = 30,
            //    CaloriesBurned = 10f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 44
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("32989028-4533-4700-b454-a4df1cfa08a9"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "Jumping Jacks",
            //    Instructions = "Nhảy dang tay và chân, sau đó thu lại",
            //    Duration = 30,
            //    CaloriesBurned = 7f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 45
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("86365264-7f1c-4bc2-8886-92a8523624b4"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "Tuck Jumps",
            //    Instructions = "Nhảy lên cao, kéo gối sát ngực, sau đó hạ xuống",
            //    Duration = 45,
            //    CaloriesBurned = 12f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 46
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("4520be3b-5b4f-43e1-8e09-e10a2d3b3e3a"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "Lunge Jumps",
            //    Instructions = "Nhảy đổi chân trong tư thế lunge",
            //    Duration = 30,
            //    CaloriesBurned = 12f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 47
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("deee2611-a087-4d0d-80f0-53e085a06a82"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "Plank to Frogger",
            //    Instructions = "Từ tư thế plank, nhảy chân lên gần tay, sau đó trở lại plank",
            //    Duration = 45,
            //    CaloriesBurned = 11f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 48
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("bd5485ee-c420-4af7-888f-5022127f4a42"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "Star Jumps",
            //    Instructions = "Nhảy lên, dang tay chân ra tạo hình ngôi sao, sau đó trở lại",
            //    Duration = 30,
            //    CaloriesBurned = 10f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 49
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("7bc46c3f-a8df-499e-a6dc-fd1ed244592f"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "Box Jumps",
            //    Instructions = "Nhảy lên hộp hoặc bục cao, sau đó nhảy xuống",
            //    Duration = 45,
            //    CaloriesBurned = 12f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 50
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("31550981-bdb4-4f14-b209-dc1e9b9a568c"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "Broad Kicks",
            //    Instructions = "Đá chân rộng ra trước, xen kẽ hai bên",
            //    Duration = 30,
            //    CaloriesBurned = 9f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 51
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("53493645-f027-43ff-8d95-c8baff2fb02e"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "Toe Taps",
            //    Instructions = "Chạm mũi chân vào bậc thang hoặc bề mặt cao, đổi bên liên tục",
            //    Duration = 30,
            //    CaloriesBurned = 7f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 52
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("05ece9e8-b50d-4269-acb5-023e839d1c42"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "Pop Squats",
            //    Instructions = "Nhảy sang tư thế squat, sau đó nhảy trở về",
            //    Duration = 30,
            //    CaloriesBurned = 9f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 53
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("53fabb8c-d213-4050-9c00-3d5cf4103635"),
            //    CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //    UserId = userId,
            //    ExerciseName = "Side Shuffle Touch",
            //    Instructions = "Chạy ngang qua lại, chạm tay xuống sàn mỗi lần",
            //    Duration = 30,
            //    CaloriesBurned = 8f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 54
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("1945eebf-2077-4c8c-b5ab-42736e5a2b4e"),
            //    CategoryId = Guid.Parse("aa7ac7df-8edb-431a-9fae-5b8520d7630d"),
            //    UserId = userId,
            //    ExerciseName = "Standing Crawl Stroke",
            //    Instructions = "Bơi sải nhưng đứng tại chỗ, di chuyển tay luân phiên.",
            //    Duration = 20,
            //    CaloriesBurned = 6f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 55
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("e202a749-5631-4436-aaec-95dc51b41201"),
            //    CategoryId = Guid.Parse("aa7ac7df-8edb-431a-9fae-5b8520d7630d"),
            //    UserId = userId,
            //    ExerciseName = "Standing Butterfly Stroke",
            //    Instructions = "Bơi bướm khi đứng tại chỗ, di chuyển cả hai tay đồng thời.",
            //    Duration = 20,
            //    CaloriesBurned = 7f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 56
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("44f7957f-4a06-420c-9c37-67251eac8688"),
            //    CategoryId = Guid.Parse("aa7ac7df-8edb-431a-9fae-5b8520d7630d"),
            //    UserId = userId,
            //    ExerciseName = "Standing Side Bend",
            //    Instructions = "Đứng thẳng, nghiêng người sang hai bên luân phiên, giữ thẳng lưng.",
            //    Duration = 15,
            //    CaloriesBurned = 5f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 57
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("29cffa47-f89b-43c9-ab0a-0eaded59a58d"),
            //    CategoryId = Guid.Parse("aa7ac7df-8edb-431a-9fae-5b8520d7630d"),
            //    UserId = userId,
            //    ExerciseName = "Modified Side Plank",
            //    Instructions = "Nằm nghiêng, chống tay và gập đầu gối dưới, giữ cơ thể thẳng trong tư thế plank nghiêng.",
            //    Duration = 30,
            //    CaloriesBurned = 8f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 58
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("297bf196-67ad-485f-a1a4-a15895074cce"),
            //    CategoryId = Guid.Parse("aa7ac7df-8edb-431a-9fae-5b8520d7630d"),
            //    UserId = userId,
            //    ExerciseName = "One Leg Side Hops",
            //    Instructions = "Đứng trên một chân, nhảy sang hai bên với khoảng cách ngắn, giữ thăng bằng.",
            //    Duration = 25,
            //    CaloriesBurned = 10f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 59
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("e2afc25d-44b9-49da-93cd-ed028acd3581"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Bow Pose",
            //    Instructions = "Nằm sấp, nắm hai cổ chân, kéo chân lên phía đầu để uốn cong cơ thể",
            //    Duration = 60,
            //    CaloriesBurned = 5f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 60
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("30515dc2-1295-4401-b204-2a27f00b7fd1"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Seated Spinal Twist",
            //    Instructions = "Ngồi, xoay thân sang một bên, tay đặt lên đầu gối đối diện",
            //    Duration = 45,
            //    CaloriesBurned = 3f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 61
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("af2b9f55-ec76-4e40-8fb6-8854f101ee58"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Yoga Squat",
            //    Instructions = "Ngồi xuống thấp, hai tay chắp trước ngực, giữ tư thế yoga",
            //    Duration = 30,
            //    CaloriesBurned = 3f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 62
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("5e7c79b5-bbaa-4e8d-bace-3b36fc13960f"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "High Lunge",
            //    Instructions = "Bước một chân về phía trước, chân sau duỗi thẳng, giữ tư thế lunge cao",
            //    Duration = 30,
            //    CaloriesBurned = 3f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 63
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("ea43be6e-ed4f-47f2-a4fa-60e34e95f410"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Pyramid",
            //    Instructions = "Đứng, bước một chân ra sau, cúi người xuống chân trước, giữ lưng thẳng",
            //    Duration = 30,
            //    CaloriesBurned = 3f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 64
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("34c98139-7bb7-44ad-94d9-0aedb473acb5"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Standing Backbend",
            //    Instructions = "Đứng, uốn cong người ra sau, giữ thăng bằng",
            //    Duration = 30,
            //    CaloriesBurned = 3f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 65
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("3195ac62-c7a7-41f4-8208-c1e5f7fecc47"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Goddess",
            //    Instructions = "Đứng, chân rộng, squat nhẹ, tay giơ lên ngang vai",
            //    Duration = 30,
            //    CaloriesBurned = 3f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 66
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("712662bf-3def-4bad-83a7-58bd3c4e4f9e"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Humble Warrior",
            //    Instructions = "Từ tư thế lunge, hạ thấp thân, tay chắp ra sau",
            //    Duration = 30,
            //    CaloriesBurned = 3f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 67
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("14fe699e-4652-4250-968d-696223001cc9"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Chair Twist",
            //    Instructions = "Ngồi xổm, xoay thân sang một bên, tay chắp trước ngực",
            //    Duration = 30,
            //    CaloriesBurned = 3f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 68
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("00355a5e-e30b-4770-a4e5-abf20671a049"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Pigeon Base",
            //    Instructions = "Ngồi, một chân duỗi ra sau, một chân gập phía trước",
            //    Duration = 45,
            //    CaloriesBurned = 4f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 69
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("73ca30ef-84cf-4e3f-b360-ac33038cb597"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Half Frog",
            //    Instructions = "Nằm sấp, co một chân, dùng tay kéo chân gần đầu",
            //    Duration = 45,
            //    CaloriesBurned = 4f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 70
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("59514612-923b-46b5-85bb-96ead6cbe61f"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Shoulder Stand",
            //    Instructions = "Nằm ngửa, nâng chân lên cao, hỗ trợ hông bằng tay",
            //    Duration = 60,
            //    CaloriesBurned = 5f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 71
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("1766c620-0c7f-4673-8767-bb5702d9e1f0"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Revolved Triangle",
            //    Instructions = "Từ tư thế tam giác, xoay thân và tay hướng xuống chân trước",
            //    Duration = 30,
            //    CaloriesBurned = 3f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 72
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("fb102f19-2bf9-4ca1-8222-ea1c35b55f0e"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Peaceful Warrior",
            //    Instructions = "Từ tư thế lunge, đưa tay sau về phía chân sau, tay trước hướng lên",
            //    Duration = 30,
            //    CaloriesBurned = 3f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 73
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("6d976edf-2f6a-4d74-bbde-434385f55ced"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Seated Side Bend",
            //    Instructions = "Ngồi, duỗi một tay qua đầu, cúi người sang một bên",
            //    Duration = 30,
            //    CaloriesBurned = 3f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 74
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("c56d1ee0-3ea3-4128-9a35-7f97287e11af"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Tiger with Bow",
            //    Instructions = "Từ tư thế bò, nắm một chân kéo lên gần đầu",
            //    Duration = 60,
            //    CaloriesBurned = 5f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 75
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("f53ac445-0d94-46a0-ba3a-fbabf2eaa811"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Locust Pose",
            //    Instructions = "Nằm sấp, nâng chân và tay lên khỏi mặt đất, giữ tư thế",
            //    Duration = 45,
            //    CaloriesBurned = 4f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 76
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("233892f9-f283-4084-a005-7b7121ecc4a1"),
            //    CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //    UserId = userId,
            //    ExerciseName = "Accomplished Eagle",
            //    Instructions = "Đứng, quấn tay và chân lại với nhau, giữ thăng bằng",
            //    Duration = 45,
            //    CaloriesBurned = 5f,
            //    Difficulty = DifficultyLevel.Hard,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 77
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("45049ee3-e43a-4395-ab5e-ada8b7bfbb3a"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Extended Arm Circles",
            //    Instructions = "Đứng thẳng, xoay hai tay theo vòng tròn lớn",
            //    Duration = 30,
            //    CaloriesBurned = 2f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 78
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("fba9adfd-be77-4cf4-81b0-aeb21506cbbf"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Ankle Twist",
            //    Instructions = "Ngồi, xoay cổ chân theo vòng tròn",
            //    Duration = 30,
            //    CaloriesBurned = 2f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 79
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("14399a61-ccab-4af5-91fb-04fdc1f92c20"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Bridges",
            //    Instructions = "Nằm ngửa, nâng hông lên cao, giữ lưng thẳng",
            //    Duration = 45,
            //    CaloriesBurned = 4f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 80
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("15fe99fe-0ae1-4727-a104-5ce133c0c5e2"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Slow Box",
            //    Instructions = "Di chuyển chậm trong tư thế squat, bước qua lại như hộp vuông",
            //    Duration = 30,
            //    CaloriesBurned = 3f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 81
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("e1092fc5-3c26-441c-9c3d-f281f17a5bc1"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Knee Circles",
            //    Instructions = "Đứng, đặt tay lên gối, xoay gối theo vòng tròn",
            //    Duration = 30,
            //    CaloriesBurned = 2f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 82
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("6b331c4b-71ad-4e2b-930f-64cff22abaf6"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Hip Circles",
            //    Instructions = "Đứng, xoay hông theo vòng tròn lớn",
            //    Duration = 30,
            //    CaloriesBurned = 2f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 83
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("90aa224f-411a-4a5d-abbe-e6ed94b209c2"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Single Leg Runner",
            //    Instructions = "Đứng một chân, nghiêng người về trước, đá chân sau ra sau",
            //    Duration = 30,
            //    CaloriesBurned = 4f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 84
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("21e53e39-de13-43c1-ad22-f69ac024677a"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Step Touch",
            //    Instructions = "Bước sang hai bên, chạm tay xuống chân mỗi lần bước",
            //    Duration = 30,
            //    CaloriesBurned = 2f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 85
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("4ea81029-ce2f-4c13-928d-b2b576446283"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Windmill",
            //    Instructions = "Đứng, cúi người, tay chạm ngón chân đối diện, luân phiên hai bên",
            //    Duration = 30,
            //    CaloriesBurned = 3f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 86
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("29336dc7-f70f-4ced-a225-dacc6007f912"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Inchworms",
            //    Instructions = "Đứng, cúi người, đi tay ra phía trước thành tư thế plank, sau đó quay lại",
            //    Duration = 30,
            //    CaloriesBurned = 4f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 87
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("466c1a67-f7bb-4203-affb-1fd19faf2e72"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Heel Touches",
            //    Instructions = "Nằm ngửa, gập gối, chạm tay vào gót chân hai bên",
            //    Duration = 30,
            //    CaloriesBurned = 2f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 88
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("c7c451d2-c4ee-47b5-8caf-f09d0836ae78"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Toe Touch Walk",
            //    Instructions = "Đi bộ, gập người chạm ngón tay vào ngón chân mỗi bước",
            //    Duration = 30,
            //    CaloriesBurned = 2f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 89
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("eb69be55-8aa5-47b0-b633-12770fe6ac5a"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Jogging",
            //    Instructions = "Chạy bộ nhẹ tại chỗ hoặc ngoài trời",
            //    Duration = 30,
            //    CaloriesBurned = 3f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 90
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("fe68c0ac-1b8e-4712-a0d1-a41ca15833e9"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Jump Rope",
            //    Instructions = "Nhảy dây với nhịp độ ổn định",
            //    Duration = 30,
            //    CaloriesBurned = 5f,
            //    Difficulty = DifficultyLevel.Medium,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 91
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("ec2cfe0e-3949-4572-9c02-2c2f5dcc2f1d"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Supine Marching",
            //    Instructions = "Nằm ngửa, gập gối, nâng từng chân lên xuống như đi bộ",
            //    Duration = 30,
            //    CaloriesBurned = 3f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 92
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("b0d4c89e-5ced-4782-b76a-0be207aa4725"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Shoulder Roll",
            //    Instructions = "Đứng, xoay vai theo vòng tròn",
            //    Duration = 30,
            //    CaloriesBurned = 2f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 93
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("f8c6b372-1b43-45c3-93ca-99e6e9ab734b"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Teres Roll",
            //    Instructions = "Xoay nhẹ cánh tay trên để khởi động cơ vai",
            //    Duration = 30,
            //    CaloriesBurned = 2f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //},
            //#endregion

            //#region Exercise 94
            //new Exercise
            //{
            //    ExerciseId = Guid.Parse("9ac85a51-9155-40ef-a7eb-d5561c238c4f"),
            //    CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //    UserId = userId,
            //    ExerciseName = "Triceps Roll",
            //    Instructions = "Xoay nhẹ cánh tay để làm nóng cơ tam đầu",
            //    Duration = 30,
            //    CaloriesBurned = 2f,
            //    Difficulty = DifficultyLevel.Easy,
            //    Status = true,
            //    CreatedAt = today,
            //    UpdatedAt = today,
            //    CreatedBy = userId,
            //    UpdatedBy = userId
            //}
            //#endregion

            );



        }
    }
}
