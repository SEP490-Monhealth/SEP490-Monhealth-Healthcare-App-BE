using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Core.Enum;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class WorkoutConfiguration : IEntityTypeConfiguration<Workout>
    {
        public void Configure(EntityTypeBuilder<Workout> builder)
        {
            var userId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6");
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            var fullBody = Guid.Parse("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9");
            var upperBody = Guid.Parse("036a94f2-013a-4375-a685-76ff6ffcc24e");
            var lowerBody = Guid.Parse("2f998806-6963-42cf-9fce-7a5b5c2df540");
            var abs = Guid.Parse("4575699a-5bb6-42ec-9d52-ea19d1170187");

            builder.HasData(

            #region Workout 1
            new Workout
            {
                WorkoutId = new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Warmup,
                WorkoutName = "Khởi động toàn thân",
                WorkoutDescription = "Bài tập này giúp khởi động toàn bộ cơ thể, làm nóng cơ bắp, giúp tăng cường lưu thông máu và chuẩn bị cho các bài tập tiếp theo",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 3f,
                CaloriesBurned = 68.64f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 2
            new Workout
            {
                WorkoutId = new Guid("032322a9-a232-4030-bed3-0ccf952d5cff"),
                UserId = userId,
                CategoryId = lowerBody,
                WorkoutType = WorkoutType.Warmup,
                WorkoutName = "Chân dẻo dai",
                WorkoutDescription = "Bài tập giúp làm dẻo dai các khớp chân, tăng cường độ linh hoạt và giảm thiểu nguy cơ chấn thương khi tập luyện",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 7.5f,
                CaloriesBurned = 60.45f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 3
            new Workout
            {
                WorkoutId = new Guid("580069d7-9025-4864-adf2-3037608e9a22"),
                UserId = userId,
                CategoryId = upperBody,
                WorkoutType = WorkoutType.Warmup,
                WorkoutName = "Tay uyển chuyển",
                WorkoutDescription = "Bài tập này giúp tăng cường sự linh hoạt của khớp tay và vai, hỗ trợ cải thiện khả năng vận động của phần trên cơ thể",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 6.5f,
                CaloriesBurned = 43.6f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 4
            new Workout
            {
                WorkoutId = new Guid("03741247-6b2d-49a9-a656-7fc8343747bd"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Warmup,
                WorkoutName = "Vận động toàn thân",
                WorkoutDescription = "Bài tập toàn thân giúp kích thích các cơ lớn trong cơ thể, cải thiện sự dẻo dai và sức bền chung cho cơ thể",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 11.01f,
                CaloriesBurned = 83.61f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 5
            new Workout
            {
                WorkoutId = new Guid("298502cf-ebdf-4044-9350-a14606ebe099"),
                UserId = userId,
                CategoryId = lowerBody,
                WorkoutType = WorkoutType.Warmup,
                WorkoutName = "Chân săn chắc",
                WorkoutDescription = "Bài tập này giúp cơ bắp chân săn chắc và phát triển sức mạnh, đặc biệt là khi bạn cần cải thiện khả năng di chuyển",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 11.1f,
                CaloriesBurned = 77.76f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 6
            new Workout
            {
                WorkoutId = new Guid("2b36b55e-d222-4cb9-9540-4ce82f7abe54"),
                UserId = userId,
                CategoryId = upperBody,
                WorkoutType = WorkoutType.Warmup,
                WorkoutName = "Tay linh hoạt",
                WorkoutDescription = "Bài tập này giúp tăng cường sự linh hoạt và sức mạnh của cánh tay, hỗ trợ tốt cho các bài tập thể thao khác",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 7.5f,
                CaloriesBurned = 62.4f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 7
            new Workout
            {
                WorkoutId = new Guid("60db3b47-a756-40d2-8d2a-47b5d02b10b3"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Warmup,
                WorkoutName = "Tập luyện toàn thân",
                WorkoutDescription = "Bài tập này giúp làm nóng và kích thích tất cả các nhóm cơ trong cơ thể, chuẩn bị cho những bài tập nặng hơn",
                DifficultyLevel = DifficultyLevel.Medium,
                DurationMinutes = 10.5f,
                CaloriesBurned = 76.95f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 8
            new Workout
            {
                WorkoutId = new Guid("ab9d8ae9-478c-450b-aecc-a86f3ce054b2"),
                UserId = userId,
                CategoryId = lowerBody,
                WorkoutType = WorkoutType.Warmup,
                WorkoutName = "Chân khỏe mạnh",
                WorkoutDescription = "Bài tập này giúp tăng cường sức mạnh cho các cơ chân, đặc biệt là các cơ bắp đùi và bắp chân",
                DifficultyLevel = DifficultyLevel.Medium,
                DurationMinutes = 10.5f,
                CaloriesBurned = 73.95f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 9
            new Workout
            {
                WorkoutId = new Guid("56bdef4d-ab20-46cd-b74b-fc22d25edc00"),
                UserId = userId,
                CategoryId = upperBody,
                WorkoutType = WorkoutType.Warmup,
                WorkoutName = "Tay rắn chắc",
                WorkoutDescription = "Bài tập này giúp phát triển cơ bắp tay và bả vai, làm tay trở nên mạnh mẽ và săn chắc hơn",
                DifficultyLevel = DifficultyLevel.Medium,
                DurationMinutes = 9f,
                CaloriesBurned = 68.64f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 10
            new Workout
            {
                WorkoutId = new Guid("5c81c79b-cb95-4dd6-9620-75484f04a559"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Warmup,
                WorkoutName = "Thử thách thể lực",
                WorkoutDescription = "Bài tập thử thách thể lực này giúp kiểm tra sức mạnh và sự bền bỉ của cơ thể thông qua các bài tập đòi hỏi sức lực cao",
                DifficultyLevel = DifficultyLevel.Medium,
                DurationMinutes = 7.5f,
                CaloriesBurned = 58.95f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 11
            new Workout
            {
                WorkoutId = new Guid("d4425ce8-4652-4ea2-b26b-1ffd8835f97f"),
                UserId = userId,
                CategoryId = lowerBody,
                WorkoutType = WorkoutType.Warmup,
                WorkoutName = "Chân bền bỉ",
                WorkoutDescription = "Bài tập giúp cải thiện sức bền cho đôi chân, thích hợp cho những người tập thể thao đòi hỏi di chuyển lâu dài và mạnh mẽ",
                DifficultyLevel = DifficultyLevel.Medium,
                DurationMinutes = 9f,
                CaloriesBurned = 67.95f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 12
            new Workout
            {
                WorkoutId = new Guid("8aaffa80-a610-4eb3-adb2-bbb46d2487d0"),
                UserId = userId,
                CategoryId = upperBody,
                WorkoutType = WorkoutType.Warmup,
                WorkoutName = "Tay cường độ cao",
                WorkoutDescription = "Bài tập tăng cường sức mạnh cho tay và vai, giúp phát triển cơ bắp và cải thiện khả năng chống chịu với các bài tập nặng",
                DifficultyLevel = DifficultyLevel.Medium,
                DurationMinutes = 5.79f,
                CaloriesBurned = 38.64f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 12-1
            new Workout
            {
                WorkoutId = new Guid("28de23bb-07b9-4ebc-8f72-ead4d54a4883"),
                UserId = userId,
                CategoryId = abs,
                WorkoutType = WorkoutType.Warmup,
                WorkoutName = "Bụng săn chắc",
                WorkoutDescription = "Bài tập này giúp phát triển cơ bụng, làm bụng trở nên mạnh mẽ và săn chắc hơn",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 0f,
                CaloriesBurned = 0f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 13
            new Workout
            {
                WorkoutId = new Guid("092499c9-93fe-45f9-abd9-c0641b9d06d1"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Khởi động linh hoạt",
                WorkoutDescription = "Bài tập này giúp làm mềm các khớp và cơ, tăng cường sự linh hoạt để sẵn sàng cho các hoạt động thể chất nặng hơn",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 12.5f, // 6.0 + 6.5
                CaloriesBurned = 152.96f, // 55.76 + 97.2
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 14
            new Workout
            {
                WorkoutId = new Guid("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0"),
                UserId = userId,
                CategoryId = lowerBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Toàn thân mạnh mẽ",
                WorkoutDescription = "Bài tập toàn thân giúp phát triển sức mạnh cơ bắp cho tất cả các nhóm cơ, đặc biệt là cơ lớn như ngực, lưng, và chân",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 10.5f, // 4.5 + 6.0
                CaloriesBurned = 130.8f, // 49.8 + 81.0
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 15
            new Workout
            {
                WorkoutId = new Guid("bbd7c538-33d2-4f57-ae74-3b96fbd59563"),
                UserId = userId,
                CategoryId = upperBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Nhịp điệu sôi động",
                WorkoutDescription = "Bài tập với các động tác nhịp điệu giúp cải thiện sức bền và sự phối hợp giữa các nhóm cơ, đồng thời tăng cường năng lượng cho cơ thể",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 10.17f, // 3.67 + 6.5
                CaloriesBurned = 114.6f, // 33.6 + 81.0
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 16
            new Workout
            {
                WorkoutId = new Guid("2308c57b-829b-4c6e-b362-5b4634af2877"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Năng lượng dồi dào",
                WorkoutDescription = "Bài tập giúp kích thích năng lượng cho cơ thể, giúp bạn cảm thấy tràn đầy sức sống và chuẩn bị tốt cho các hoạt động tiếp theo",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 15f, // 5.0 + 10.0
                CaloriesBurned = 172.6f, // 55.6 + 117.0
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 17
            new Workout
            {
                WorkoutId = new Guid("d5487fbc-066f-4073-acf3-2d7c595012ee"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Vươn tầm sức mạnh",
                WorkoutDescription = "Bài tập này giúp xây dựng cơ bắp và cải thiện sức mạnh tổng thể, phù hợp cho những ai muốn nâng cao khả năng thể chất",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 14.5f, // 5.0 + 9.5
                CaloriesBurned = 178.6f, // 55.6 + 123.0
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 18
            new Workout
            {
                WorkoutId = new Guid("b8fd1003-667c-417e-80b8-d1b32f0b6788"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Khỏe và linh hoạt",
                WorkoutDescription = "Bài tập này kết hợp giữa sức mạnh và sự linh hoạt, giúp cải thiện khả năng vận động của cơ thể và nâng cao thể lực tổng thể",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 14.5f, // 5.0 + 9.5
                CaloriesBurned = 178.6f, // 55.6 + 123.0
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 19
            new Workout
            {
                WorkoutId = new Guid("d103ce77-a74a-4227-aba0-e0c5452790a1"),
                UserId = userId,
                CategoryId = lowerBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Dẻo dai và bền bỉ",
                WorkoutDescription = "Bài tập này giúp tăng cường sự bền bỉ cho cơ thể và cải thiện khả năng chịu đựng, rất hữu ích cho các hoạt động dài hạn",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 11f, // 4.5 + 6.5
                CaloriesBurned = 147f, // 49.8 + 97.2
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 20
            new Workout
            {
                WorkoutId = new Guid("0812b9f4-73d9-4878-b99e-0b081f92ed13"),
                UserId = userId,
                CategoryId = abs,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Vũ điệu thể thao",
                WorkoutDescription = "Bài tập thể thao này giúp cải thiện sự phối hợp và tốc độ phản xạ của cơ thể, giúp bạn năng động và linh hoạt hơn",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 0f,
                CaloriesBurned = 0f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 21
            new Workout
            {
                WorkoutId = new Guid("3ae73e0d-e6cc-4962-a17c-4e087d655e64"),
                UserId = userId,
                CategoryId = lowerBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Sức mạnh và cân bằng",
                WorkoutDescription = "Bài tập này kết hợp giữa sức mạnh và khả năng duy trì sự cân bằng, giúp cải thiện sự ổn định cơ thể và khả năng phối hợp các nhóm cơ",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 11f, // 4.5 + 6.5
                CaloriesBurned = 147f, // 49.8 + 97.2
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 22
            new Workout
            {
                WorkoutId = new Guid("568e1c3d-c775-4597-86e1-cb65cfe0df6a"),
                UserId = userId,
                CategoryId = lowerBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Khỏe mạnh toàn diện",
                WorkoutDescription = "Bài tập này giúp phát triển sức khỏe toàn diện, bao gồm sức mạnh, sức bền, sự linh hoạt và sự cân bằng của cơ thể",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 10.5f, // 4.5 + 6.0
                CaloriesBurned = 130.8f, // 49.8 + 81.0
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 23
            new Workout
            {
                WorkoutId = new Guid("a99efeb6-14a4-44f6-8d22-b293db1fedcc"),
                UserId = userId,
                CategoryId = upperBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Vũ điệu kết hợp",
                WorkoutDescription = "Bài tập này là sự kết hợp giữa vũ điệu và thể thao, giúp cải thiện khả năng vận động nhịp nhàng và tăng cường sức bền cho cơ thể",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 7.17f, // 3.67 + 3.5
                CaloriesBurned = 72.6f, // 33.6 + 39.0
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 24
            new Workout
            {
                WorkoutId = new Guid("da56e057-d5d4-4077-a7c4-111bf3470e08"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Thử thách cường độ cao",
                WorkoutDescription = "Bài tập này có cường độ cao, giúp tăng cường sức mạnh cơ bắp và nâng cao khả năng chịu đựng cho cơ thể",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 9f, // 5.0 + 4.0
                CaloriesBurned = 109.6f, // 55.6 + 54.0
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 25
            new Workout
            {
                WorkoutId = new Guid("cd738c01-05e8-4b4a-8d85-58544c6e95b5"),
                UserId = userId,
                CategoryId = lowerBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Toàn thân săn chắc",
                WorkoutDescription = "Bài tập này giúp săn chắc cơ bắp toàn thân, với trọng tâm là phát triển cơ bắp, đồng thời giảm mỡ và cải thiện hình thể",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 10.5f, // 4.5 + 6.0
                CaloriesBurned = 147.0f, // 49.8 + 97.2
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 26
            new Workout
            {
                WorkoutId = new Guid("906a8fa1-d0d6-477d-bc07-167098891ffb"),
                UserId = userId,
                CategoryId = lowerBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Khởi động cơ bản",
                WorkoutDescription = "Bài tập khởi động cơ bản giúp làm ấm cơ thể, giảm thiểu nguy cơ chấn thương và chuẩn bị cho các bài tập tiếp theo",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 11f, // 4.5 + 6.5
                CaloriesBurned = 147f, // 49.8 + 97.2
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 27
            new Workout
            {
                WorkoutId = new Guid("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Luyện tập sức bền",
                WorkoutDescription = "Bài tập này giúp nâng cao sức bền, cải thiện khả năng chịu đựng khi thực hiện các hoạt động thể thao kéo dài",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 14.5f, // 5.0 + 9.5
                CaloriesBurned = 178.6f, // 55.6 + 123.0
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 28
            new Workout
            {
                WorkoutId = new Guid("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Luyện tập nhanh và mạnh",
                WorkoutDescription = "Bài tập này giúp tăng cường sức mạnh cơ bắp đồng thời cải thiện tốc độ và độ phản xạ của cơ thể",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 11f, // 5.0 + 6.0
                CaloriesBurned = 136.6f, // 55.6 + 81.0
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 29
            new Workout
            {
                WorkoutId = new Guid("e628d9f7-d645-4f48-b84d-44d6cc38d8ea"),
                UserId = userId,
                CategoryId = upperBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Chuyển động linh hoạt",
                WorkoutDescription = "Bài tập giúp phát triển sự linh hoạt và khả năng vận động của cơ thể, làm cho cơ thể mềm dẻo và dẻo dai hơn",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 9.67f, // 3.67 + 6.0
                CaloriesBurned = 114.6f, // 33.6 + 81.0
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 30
            new Workout
            {
                WorkoutId = new Guid("536ac05d-37a7-41a9-80e0-b1651a24e1d7"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Sức mạnh toàn diện",
                WorkoutDescription = "Bài tập này giúp xây dựng sức mạnh cơ thể toàn diện, với các bài tập kết hợp giữa các nhóm cơ lớn và nhỏ",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 11f, // 5.0 + 6.0
                CaloriesBurned = 136.6f, // 55.6 + 81.0
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            // #region Workout 31
            // new Workout
            // {
            //     WorkoutId = new Guid("7691ed30-fe88-4e75-97c6-f5f88d304efb"),
            //     UserId = userId,
            //     CategoryId = fullBody,
            //     WorkoutType = WorkoutType.Workout,
            //     WorkoutName = "Sức mạnh toàn diện",
            //     WorkoutDescription = "Bài tập này tiếp tục tập trung vào việc phát triển sức mạnh tổng thể, nâng cao sức bền và cải thiện sức khỏe lâu dài",
            //     DifficultyLevel = DifficultyLevel.Easy,
            //     DurationMinutes = 6f,
            //     CaloriesBurned = 45.2f,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = userId,
            //     UpdatedBy = userId,
            // },
            // #endregion

            #region Workout 32
            new Workout
            {
                WorkoutId = new Guid("425fc485-239f-479e-a4da-b1fe6aed6822"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Khỏe và dẻo dai",
                WorkoutDescription = "Bài tập này giúp cơ thể vừa khỏe mạnh vừa dẻo dai, thích hợp cho việc nâng cao độ linh hoạt và sức bền của các nhóm cơ",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 11f, // 5.0 + 6.0
                CaloriesBurned = 136.6f, // 55.6 + 81.0
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 33
            new Workout
            {
                WorkoutId = new Guid("8ac41353-c90d-478d-85b7-1c5ebdbb0da2"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Tập luyện toàn thân",
                WorkoutDescription = "Bài tập toàn thân giúp cải thiện sức khỏe chung, tăng cường khả năng vận động và phát triển cơ bắp đồng đều",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 11.5f, // 5.0 + 6.5
                CaloriesBurned = 153.4f, // 55.6 + 97.8
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 34
            new Workout
            {
                WorkoutId = new Guid("408aa31e-0ccf-45ec-bb86-d2c9135f8a38"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Dẻo dai và năng lượng",
                WorkoutDescription = "Bài tập này giúp cơ thể dẻo dai và tăng cường năng lượng, thích hợp để nâng cao khả năng hoạt động lâu dài và bền bỉ",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 11.5f, // 5.0 + 6.5
                CaloriesBurned = 153.4f, // 55.6 + 97.8
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 35
            new Workout
            {
                WorkoutId = new Guid("c08197fe-5bf6-442c-ade3-6d41313267e7"),
                UserId = userId,
                CategoryId = abs,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Khởi động cơ thể",
                WorkoutDescription = "Bài tập khởi động giúp cơ thể làm quen với các động tác nhẹ nhàng, tăng cường sự linh hoạt và giảm thiểu rủi ro chấn thương",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 0f,
                CaloriesBurned = 0f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 36
            new Workout
            {
                WorkoutId = new Guid("b9329533-0f83-4c93-ac2b-6c6beba82c4f"),
                UserId = userId,
                CategoryId = abs,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Linh hoạt và khỏe mạnh",
                WorkoutDescription = "Bài tập này kết hợp các động tác linh hoạt và sức mạnh, giúp cải thiện khả năng vận động và sự khỏe mạnh của cơ thể",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 0f,
                CaloriesBurned = 0f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 37
            new Workout
            {
                WorkoutId = new Guid("22ccc19e-e649-4c46-b13f-b05bf60100d4"),
                UserId = userId,
                CategoryId = abs,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Săn chắc và khỏe mạnh",
                WorkoutDescription = "Bài tập này giúp săn chắc cơ thể, tăng cường sức mạnh và giảm mỡ hiệu quả",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 0f,
                CaloriesBurned = 0f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 38
            new Workout
            {
                WorkoutId = new Guid("d0a4a055-5a3a-485e-9c98-3e01ae0279d3"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Sức mạnh và bền bỉ",
                WorkoutDescription = "Bài tập giúp nâng cao sức mạnh và bền bỉ cho cơ thể, thích hợp cho những người muốn thử thách sức chịu đựng của mình",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 11.5f, // 5.0 + 6.5
                CaloriesBurned = 153.4f, // 55.6 + 97.8
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 39
            new Workout
            {
                WorkoutId = new Guid("227a4189-7704-4648-9d9d-1f2c772fd25a"),
                UserId = userId,
                CategoryId = upperBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Vũ điệu thể thao",
                WorkoutDescription = "Bài tập vũ điệu thể thao giúp cải thiện khả năng phối hợp và nhịp điệu của cơ thể, đồng thời tăng cường sức bền",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 9.67f, // 3.67 + 6.0
                CaloriesBurned = 114.6f, // 33.6 + 81.0
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 40
            new Workout
            {
                WorkoutId = new Guid("73689578-c13d-4f96-972d-6e52b4a2fd5b"),
                UserId = userId,
                CategoryId = abs,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Chuyển động nhịp nhàng",
                WorkoutDescription = "Bài tập này giúp cải thiện sự nhịp nhàng trong chuyển động của cơ thể, nâng cao sức khỏe và sự linh hoạt",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 0f,
                CaloriesBurned = 0f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 41
            new Workout
            {
                WorkoutId = new Guid("eef6374e-4803-402b-bc2b-a48efa2e3270"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Đốt cháy năng lượng",
                WorkoutDescription = "Bài tập giúp đốt cháy năng lượng và giảm mỡ hiệu quả, cải thiện sức khỏe tổng thể",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 17f, // 5.0 + 12.0
                CaloriesBurned = 164.5f, // 55.6 + 108.9
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 42
            new Workout
            {
                WorkoutId = new Guid("49deb148-c08a-4f58-980e-8e2f65a6d757"),
                UserId = userId,
                CategoryId = upperBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Toàn thân khỏe mạnh",
                WorkoutDescription = "Bài tập này giúp cải thiện sức khỏe toàn thân, tăng cường các nhóm cơ lớn và nhỏ",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 9.67f, // 3.67 + 6.0
                CaloriesBurned = 114.6f, // 33.6 + 81.0
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 43
            new Workout
            {
                WorkoutId = new Guid("93114cad-bc0e-40ca-b465-4911b26ffbc0"),
                UserId = userId,
                CategoryId = fullBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Linh hoạt và mạnh mẽ",
                WorkoutDescription = "Bài tập này giúp tăng cường sự linh hoạt và sức mạnh của cơ thể, phù hợp với những người muốn nâng cao thể lực tổng thể",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 6.5f, // 3.0 + 3.5
                CaloriesBurned = 108.9f, // 55.2 + 53.7
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },
            #endregion

            #region Workout 44
            new Workout
            {
                WorkoutId = new Guid("f9a5b7be-bd78-4185-9e35-ad2c90a55c69"),
                UserId = userId,
                CategoryId = lowerBody,
                WorkoutType = WorkoutType.Workout,
                WorkoutName = "Luyện tập linh hoạt và bền bỉ",
                WorkoutDescription = "Bài tập giúp phát triển sự linh hoạt và bền bỉ cho cơ thể, cải thiện khả năng hoạt động trong thời gian dài",
                DifficultyLevel = DifficultyLevel.Easy,
                DurationMinutes = 13.01f, // 5.0 + 8.01
                CaloriesBurned = 199.67f, // 80.6 + 119.07
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            }
            #endregion
            );
        }
    }
}