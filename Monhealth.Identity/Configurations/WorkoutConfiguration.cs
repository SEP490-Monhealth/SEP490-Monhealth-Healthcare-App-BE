// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Metadata.Builders;
// using Monhealth.Core.Enum;
// using Monhealth.Domain;

// namespace Monhealth.Identity.Configurations
// {
//     public class WorkoutConfiguration : IEntityTypeConfiguration<Workout>
//     {
//         public void Configure(EntityTypeBuilder<Workout> builder)
//         {
//             var userId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6");
//             var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

//             builder.HasData(

//             #region Workout 1
//             new Workout
//             {
//                 WorkoutId = new Guid("027c771b-8dd4-4124-b651-111fda0b0dcf"),
//                 CategoryId = new Guid(""),
//                 UserId = userId,
//                 WorkoutName = "Soft Full Routine",
//                 WorkoutDescription = "Bài tập toàn thân nhẹ nhàng, giúp cơ thể linh hoạt và thư giãn.",
//                 DifficultyLevel = DifficultyLevel.Easy,
//                 CreatedAt = today,
//                 UpdatedAt = today,
//             },
//             #endregion
//             );
//         }
//     }
// }
