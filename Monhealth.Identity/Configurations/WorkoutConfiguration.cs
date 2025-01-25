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
            builder.HasData(

            #region Workout 1
            new Workout
            {
                WorkoutId = new Guid("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                WorkoutName = "Toàn thân năng động",
                WorkoutDescription = "Kết hợp toàn thân để tăng cường năng lượng và khởi động ngày mới hiệu quả.",
                Intensity = IntensityLevel.Medium,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region Workout 2
            new Workout
            {
                WorkoutId = new Guid("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                WorkoutName = "Tăng nhịp tim",
                WorkoutDescription = "Đốt cháy calo và tăng sức bền với các bài tập cardio cường độ cao.",
                Intensity = IntensityLevel.High,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region Workout 3
            new Workout
            {
                WorkoutId = new Guid("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                WorkoutName = "Cơ bụng vững chắc",
                WorkoutDescription = "Tăng cường sức mạnh cơ bụng và vùng core để cải thiện tư thế và độ bền.",
                Intensity = IntensityLevel.Medium,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region Workout 4
            new Workout
            {
                WorkoutId = new Guid("1c7ded15-2d6e-45f3-8854-f9f12f84493c"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                WorkoutName = "Chân & mông khỏe mạnh",
                WorkoutDescription = "Phát triển cơ chân và mông, giúp tăng cường sức mạnh và sự linh hoạt.",
                Intensity = IntensityLevel.Medium,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region Workout 5
            new Workout
            {
                WorkoutId = new Guid("784c8491-28cd-478c-8101-63472dfda717"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                WorkoutName = "Cơ tay và ngực săn chắc",
                WorkoutDescription = "Tăng cường sức mạnh thân trên với các bài tập tay, vai và ngực cường độ cao.",
                Intensity = IntensityLevel.High,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region Workout 6
            new Workout
            {
                WorkoutId = new Guid("0b56cd61-ca2c-4bac-9127-2211cceecf80"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                WorkoutName = "Người mới bắt đầu",
                WorkoutDescription = "Nhẹ nhàng và dễ tiếp cận, phù hợp với người mới bắt đầu hoặc cần buổi tập nhẹ nhàng.",
                Intensity = IntensityLevel.Medium,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region Workout 7
            new Workout
            {
                WorkoutId = new Guid("234104de-c069-401d-8b01-01fb47e2c03b"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                WorkoutName = "Linh hoạt và thư giãn",
                WorkoutDescription = "Thư giãn cơ bắp và cải thiện sự linh hoạt với các bài tập giãn cơ nhẹ nhàng.",
                Intensity = IntensityLevel.Low,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            });
            #endregion
        }
    }
}
