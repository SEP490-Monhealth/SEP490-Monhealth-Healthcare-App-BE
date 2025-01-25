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
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7"),
                ExerciseId = Guid.Parse("1d7e129b-30e5-4ca7-ade1-0ac2c2534332"),
                Duration = 30,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region 2
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7"),
                ExerciseId = Guid.Parse("9ba0c68f-426b-4459-8b12-7eafc4b43f2b"),
                Duration = 40,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region 3 
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7"),
                ExerciseId = Guid.Parse("fc719720-6259-4e21-bec9-82b2949e35e2"),
                Duration = 30,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region 4 
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7"),
                ExerciseId = Guid.Parse("ae68fd8e-0226-4368-824a-abe06fed86b3"),
                Duration = 40,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region 5 
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7"),
                ExerciseId = Guid.Parse("e37feb90-ad70-4da1-b274-809412dd808a"),
                Duration = 30,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region 6 
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("9572b6fe-c61d-40b2-a0f5-c9d9f7c7eed7"),
                ExerciseId = Guid.Parse("21e53e39-de13-43c1-ad22-f69ac024677a"),
                Duration = 60,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            //Work out 2
            #region 7
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8"),
                ExerciseId = Guid.Parse("f344b5e8-c338-4da7-a99c-78952ba2db9b"),
                Duration = 40,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion


            #region 8 
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8"),
                ExerciseId = Guid.Parse("e37feb90-ad70-4da1-b274-809412dd808a"),
                Duration = 40,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion


            #region 9 
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8"),
                ExerciseId = Guid.Parse("fc719720-6259-4e21-bec9-82b2949e35e2"),
                Duration = 30,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion


            #region 10 
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8"),
                ExerciseId = Guid.Parse("32989028-4533-4700-b454-a4df1cfa08a9"),
                Duration = 60,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion


            #region 11
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8"),
                ExerciseId = Guid.Parse("86365264-7f1c-4bc2-8886-92a8523624b4"),
                Duration = 30,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region 12
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("b2f2926b-bc30-4db5-a2ff-4aeadbc469f8"),
                ExerciseId = Guid.Parse("21e53e39-de13-43c1-ad22-f69ac024677a"),
                Duration = 60,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion
           

           //Workout 3
            #region 13
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c"),
                ExerciseId = Guid.Parse("2f4c14b8-3207-40dc-8233-1ec310a47dd5"),
                Duration = 60,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region 14
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c"),
                ExerciseId = Guid.Parse("ae68fd8e-0226-4368-824a-abe06fed86b3"),
                Duration = 40,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region 15
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c"),
                ExerciseId = Guid.Parse("c0d1b74c-521b-428b-9776-0f9e95bd0ef0"),
                Duration = 40,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region 16
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c"),
                ExerciseId = Guid.Parse("c37426f7-6e98-4dcd-85b5-49e9e75aa380"),
                Duration = 30,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region 17
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c"),
                ExerciseId = Guid.Parse("67c5180f-978d-4cd7-ae1e-57fa80ac5e27"),
                Duration = 30,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion
             #region 18
            // new WorkoutExercise
            // {
            //     WorkoutExerciseId = Guid.NewGuid(),
            //     WorkoutId = Guid.Parse("d20af37b-9fc3-47fb-bc1f-bc82df3d9e9c"),
            //     ExerciseId = Guid.Parse("21e53e39-de13-43c1-ad22-f69ac024677a"),
            //     Duration = 60,
            //     Status = true,
            //     CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            //     UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            // },
             #endregion

            //Work out 4
            #region 19
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("1c7ded15-2d6e-45f3-8854-f9f12f84493c"),
                ExerciseId = Guid.Parse("1d7e129b-30e5-4ca7-ade1-0ac2c2534332"),
                Duration = 40,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region 20
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("1c7ded15-2d6e-45f3-8854-f9f12f84493c"),
                ExerciseId = Guid.Parse("c09b0b4e-dfad-4d62-b620-e3a348849393"),
                Duration = 30,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region 21
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("1c7ded15-2d6e-45f3-8854-f9f12f84493c"),
                ExerciseId = Guid.Parse("7213c6ec-d1ea-4e7e-97b7-5f4cd675f7ba"),
                Duration = 60,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region 22
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("1c7ded15-2d6e-45f3-8854-f9f12f84493c"),
                ExerciseId = Guid.Parse("9cadb2bc-6ae3-49a1-a094-c89039795ca3"),
                Duration = 80,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region 23
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("1c7ded15-2d6e-45f3-8854-f9f12f84493c"),
                ExerciseId = Guid.Parse("b39f7142-3d9b-4e80-9304-342de4ebe8d0"),
                Duration = 50,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region 24
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("1c7ded15-2d6e-45f3-8854-f9f12f84493c"),
                ExerciseId = Guid.Parse("00355a5e-e30b-4770-a4e5-abf20671a049"),
                Duration = 60,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
            });
            #endregion

        }
    }
}
