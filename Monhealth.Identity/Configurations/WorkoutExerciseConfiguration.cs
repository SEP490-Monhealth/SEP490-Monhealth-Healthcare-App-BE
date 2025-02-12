using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class WorkoutExerciseConfiguration : IEntityTypeConfiguration<WorkoutExercise>
    {
        public void Configure(EntityTypeBuilder<WorkoutExercise> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region Workout Exercise 1
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("027c771b-8dd4-4124-b651-111fda0b0dcf"),
                ExerciseId = Guid.Parse("6fe4dcc3-5262-470e-b043-0db293dda2fb"),
                Order = 1,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("027c771b-8dd4-4124-b651-111fda0b0dcf"),
                ExerciseId = Guid.Parse("68018365-010c-4ab8-81f4-05a5cbfcc24b"),
                Order = 2,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("027c771b-8dd4-4124-b651-111fda0b0dcf"),
                ExerciseId = Guid.Parse("546e3f6d-16be-4d13-8c15-3947bcf15b1f"),
                Order = 3,
                Duration = 0,
                Reps = 30,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 2
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("032322a9-a232-4030-bed3-0ccf952d5cff"),
                ExerciseId = Guid.Parse("6fe4dcc3-5262-470e-b043-0db293dda2fb"),
                Order = 1,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("032322a9-a232-4030-bed3-0ccf952d5cff"),
                ExerciseId = Guid.Parse("3100278d-eee7-4b89-b726-4b76daefabde"),
                Order = 2,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("032322a9-a232-4030-bed3-0ccf952d5cff"),
                ExerciseId = Guid.Parse("92ddccfd-7076-4dbc-b96b-9197cd4cc308"),
                Order = 3,
                Duration = 0,
                Reps = 15,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("032322a9-a232-4030-bed3-0ccf952d5cff"),
                ExerciseId = Guid.Parse("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"),
                Order = 4,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 3
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("580069d7-9025-4864-adf2-3037608e9a22"),
                ExerciseId = Guid.Parse("6fe4dcc3-5262-470e-b043-0db293dda2fb"),
                Order = 1,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("580069d7-9025-4864-adf2-3037608e9a22"),
                ExerciseId = Guid.Parse("44f8a6a5-04ab-447a-9361-b0e545d12f42"),
                Order = 2,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("580069d7-9025-4864-adf2-3037608e9a22"),
                ExerciseId = Guid.Parse("72206c5e-58f3-46f0-a8b1-031cbf599433"),
                Order = 3,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 4
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("03741247-6b2d-49a9-a656-7fc8343747bd"),
                ExerciseId = Guid.Parse("6fe4dcc3-5262-470e-b043-0db293dda2fb"),
                Order = 1,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("03741247-6b2d-49a9-a656-7fc8343747bd"),
                ExerciseId = Guid.Parse("d0dcad19-4c0c-447d-8e3c-092c6d4ad14c"),
                Order = 2,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("03741247-6b2d-49a9-a656-7fc8343747bd"),
                ExerciseId = Guid.Parse("bd80fdd3-c46c-4410-b126-51a11a8a2f5b"),
                Order = 3,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 5
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("298502cf-ebdf-4044-9350-a14606ebe099"),
                ExerciseId = Guid.Parse("6fe4dcc3-5262-470e-b043-0db293dda2fb"),
                Order = 1,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("298502cf-ebdf-4044-9350-a14606ebe099"),
                ExerciseId = Guid.Parse("ae6eaaa1-c8c4-4f97-afa4-4ceeea19d4b3"),
                Order = 2,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("298502cf-ebdf-4044-9350-a14606ebe099"),
                ExerciseId = Guid.Parse("546e3f6d-16be-4d13-8c15-3947bcf15b1f"),
                Order = 3,
                Duration = 0,
                Reps = 32,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 6
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("2b36b55e-d222-4cb9-9540-4ce82f7abe54"),
                ExerciseId = Guid.Parse("6fe4dcc3-5262-470e-b043-0db293dda2fb"),
                Order = 1,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("2b36b55e-d222-4cb9-9540-4ce82f7abe54"),
                ExerciseId = Guid.Parse("72206c5e-58f3-46f0-a8b1-031cbf599433"),
                Order = 2,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("2b36b55e-d222-4cb9-9540-4ce82f7abe54"),
                ExerciseId = Guid.Parse("e7a186ac-57ea-47c1-8656-7419571b8cb4"),
                Order = 3,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 7
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("60db3b47-a756-40d2-8d2a-47b5d02b10b3"),
                ExerciseId = Guid.Parse("4e76715f-6578-41d8-8315-cdb23340fb5a"),
                Order = 1,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("60db3b47-a756-40d2-8d2a-47b5d02b10b3"),
                ExerciseId = Guid.Parse("546e3f6d-16be-4d13-8c15-3947bcf15b1f"),
                Order = 2,
                Duration = 0,
                Reps = 30,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("60db3b47-a756-40d2-8d2a-47b5d02b10b3"),
                ExerciseId = Guid.Parse("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"),
                Order = 3,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 8
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("ab9d8ae9-478c-450b-aecc-a86f3ce054b2"),
                ExerciseId = Guid.Parse("5cbc396e-381a-4d9f-9ad6-42b764deee3e"),
                Order = 1,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("ab9d8ae9-478c-450b-aecc-a86f3ce054b2"),
                ExerciseId = Guid.Parse("4e76715f-6578-41d8-8315-cdb23340fb5a"),
                Order = 2,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("ab9d8ae9-478c-450b-aecc-a86f3ce054b2"),
                ExerciseId = Guid.Parse("92ddccfd-7076-4dbc-b96b-9197cd4cc308"),
                Order = 3,
                Duration = 0,
                Reps = 15,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 9
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("56bdef4d-ab20-46cd-b74b-fc22d25edc00"),
                ExerciseId = Guid.Parse("6fe4dcc3-5262-470e-b043-0db293dda2fb"),
                Order = 1,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("56bdef4d-ab20-46cd-b74b-fc22d25edc00"),
                ExerciseId = Guid.Parse("e7a186ac-57ea-47c1-8656-7419571b8cb4"),
                Order = 2,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("56bdef4d-ab20-46cd-b74b-fc22d25edc00"),
                ExerciseId = Guid.Parse("44f8a6a5-04ab-447a-9361-b0e545d12f42"),
                Order = 3,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 10
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("5c81c79b-cb95-4dd6-9620-75484f04a559"),
                ExerciseId = Guid.Parse("92ddccfd-7076-4dbc-b96b-9197cd4cc308"),
                Order = 1,
                Duration = 0,
                Reps = 15,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("5c81c79b-cb95-4dd6-9620-75484f04a559"),
                ExerciseId = Guid.Parse("68018365-010c-4ab8-81f4-05a5cbfcc24b"),
                Order = 2,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("5c81c79b-cb95-4dd6-9620-75484f04a559"),
                ExerciseId = Guid.Parse("1b2afb40-fb97-49ec-8fe3-81a17c6c9078"),
                Order = 3,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 11
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d4425ce8-4652-4ea2-b26b-1ffd8835f97f"),
                ExerciseId = Guid.Parse("23842121-4834-4483-bfe2-2c244f5ecf76"),
                Order = 1,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d4425ce8-4652-4ea2-b26b-1ffd8835f97f"),
                ExerciseId = Guid.Parse("92ddccfd-7076-4dbc-b96b-9197cd4cc308"),
                Order = 2,
                Duration = 0,
                Reps = 15,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d4425ce8-4652-4ea2-b26b-1ffd8835f97f"),
                ExerciseId = Guid.Parse("546e3f6d-16be-4d13-8c15-3947bcf15b1f"),
                Order = 3,
                Duration = 0,
                Reps = 30,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 12
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("8aaffa80-a610-4eb3-adb2-bbb46d2487d0"),
                ExerciseId = Guid.Parse("faebde03-bab9-457b-9b45-a9fabd4760aa"),
                Order = 1,
                Duration = 0,
                Reps = 8,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("8aaffa80-a610-4eb3-adb2-bbb46d2487d0"),
                ExerciseId = Guid.Parse("e7a186ac-57ea-47c1-8656-7419571b8cb4"),
                Order = 2,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("8aaffa80-a610-4eb3-adb2-bbb46d2487d0"),
                ExerciseId = Guid.Parse("44f8a6a5-04ab-447a-9361-b0e545d12f42"),
                Order = 3,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 13
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("092499c9-93fe-45f9-abd9-c0641b9d06d1"),
                ExerciseId = Guid.Parse("68018365-010c-4ab8-81f4-05a5cbfcc24b"),
                Order = 5,
                Duration = 20,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("092499c9-93fe-45f9-abd9-c0641b9d06d1"),
                ExerciseId = Guid.Parse("c076c867-b379-4889-9428-5bc1ae76cbc7"),
                Order = 6,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("092499c9-93fe-45f9-abd9-c0641b9d06d1"),
                ExerciseId = Guid.Parse("6fe4dcc3-5262-470e-b043-0db293dda2fb"),
                Order = 7,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("092499c9-93fe-45f9-abd9-c0641b9d06d1"),
                ExerciseId = Guid.Parse("4e76715f-6578-41d8-8315-cdb23340fb5a"),
                Order = 8,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 14
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0"),
                ExerciseId = Guid.Parse("efbcb7f9-3585-4a1b-8700-871547b7e857"),
                Order = 5,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0"),
                ExerciseId = Guid.Parse("9dac0527-8042-462b-8f23-7a6b503efc68"),
                Order = 6,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0"),
                ExerciseId = Guid.Parse("8fad349a-913c-42dd-8bba-c1bc267918e9"),
                Order = 7,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("bcfb878c-4188-4e02-bdb8-6ff72e9c8fb0"),
                ExerciseId = Guid.Parse("30be3b2d-bf46-4e90-8139-41411971cefc"),
                Order = 8,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion 

            #region Workout Exercise 15
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("bbd7c538-33d2-4f57-ae74-3b96fbd59563"),
                ExerciseId = Guid.Parse("1ff0ef05-4387-4483-8de3-0ef6d7724afd"),
                Order = 4,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("bbd7c538-33d2-4f57-ae74-3b96fbd59563"),
                ExerciseId = Guid.Parse("e7a186ac-57ea-47c1-8656-7419571b8cb4"),
                Order = 5,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("bbd7c538-33d2-4f57-ae74-3b96fbd59563"),
                ExerciseId = Guid.Parse("0b702969-cd49-412a-94a1-4f0027ec77d7"),
                Order = 6,
                Duration = 0,
                Reps = 15,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("bbd7c538-33d2-4f57-ae74-3b96fbd59563"),
                ExerciseId = Guid.Parse("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"),
                Order = 7,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("bbd7c538-33d2-4f57-ae74-3b96fbd59563"),
                ExerciseId = Guid.Parse("58878826-775e-4d4c-8e1b-d5c95afc214d"),
                Order = 8,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            }
            #endregion




            // #region Workout Exercise ???
            // new WorkoutExercise
            // {
            //     WorkoutExerciseId = Guid.NewGuid(),
            //     WorkoutId = Guid.Parse(""),
            //     ExerciseId = Guid.Parse(""),
            //     Order = 0,
            //     Duration = 0,
            //     Reps = 0,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // }
            // #endregion
            );
        }
    }
}
