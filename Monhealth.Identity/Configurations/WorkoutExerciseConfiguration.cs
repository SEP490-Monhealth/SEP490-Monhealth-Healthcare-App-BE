using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class WorkoutExerciseConfiguration : IEntityTypeConfiguration<WorkoutExercise>
    {
        public void Configure(EntityTypeBuilder<WorkoutExercise> builder)
        {
            builder.HasData(

            #region Workout Exercise 1
            new WorkoutExercise
            {
                WorkoutExerciseId = new Guid(""),
                WorkoutId = Guid.Parse("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7"),
                ExerciseId = Guid.Parse("1d7e129b-30e5-4ca7-ade1-0ac2c2534332"),
                Duration = 30,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion
        }
    }
}
