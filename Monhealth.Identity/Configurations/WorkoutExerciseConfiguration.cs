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
            },
            #endregion

            #region Workout Exercise 16
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("2308c57b-829b-4c6e-b362-5b4634af2877"),
                ExerciseId = Guid.Parse("bd976f53-25f4-49ba-9943-4c92a2a7eb89"),
                Order = 4,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("2308c57b-829b-4c6e-b362-5b4634af2877"),
                ExerciseId = Guid.Parse("9ba29558-e51b-4a1a-a1c4-b747967e32fb"),
                Order = 5,
                Duration = 20,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("2308c57b-829b-4c6e-b362-5b4634af2877"),
                ExerciseId = Guid.Parse("6fe4dcc3-5262-470e-b043-0db293dda2fb"),
                Order = 6,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("2308c57b-829b-4c6e-b362-5b4634af2877"),
                ExerciseId = Guid.Parse("407ff857-d218-44a8-8d0f-0bfa5d53bf03"),
                Order = 7,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("2308c57b-829b-4c6e-b362-5b4634af2877"),
                ExerciseId = Guid.Parse("bd976f53-25f4-49ba-9943-4c92a2a7eb89"),
                Order = 8,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("2308c57b-829b-4c6e-b362-5b4634af2877"),
                ExerciseId = Guid.Parse("92ddccfd-7076-4dbc-b96b-9197cd4cc308"),
                Order = 9,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 17
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d5487fbc-066f-4073-acf3-2d7c595012ee"),
                ExerciseId = Guid.Parse("0a9e1fb3-9abf-4775-a75e-2bb13009a29d"),
                Order = 1,
                Duration = 0,
                Reps = 15,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d5487fbc-066f-4073-acf3-2d7c595012ee"),
                ExerciseId = Guid.Parse("b2e62599-1f8c-4fc2-9ca7-8ab7aa571d4e"),
                Order = 2,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d5487fbc-066f-4073-acf3-2d7c595012ee"),
                ExerciseId = Guid.Parse("3409fd0e-659a-4ee4-8157-60e2ba94350c"),
                Order = 3,
                Duration = 0,
                Reps = 15,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d5487fbc-066f-4073-acf3-2d7c595012ee"),
                ExerciseId = Guid.Parse("07a4dbcd-635a-4a76-92d4-8127de619e6d"),
                Order = 4,
                Duration = 40,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
             new WorkoutExercise
             {
                 WorkoutExerciseId = Guid.NewGuid(),
                 WorkoutId = Guid.Parse("d5487fbc-066f-4073-acf3-2d7c595012ee"),
                 ExerciseId = Guid.Parse("ca76bd88-8267-4e05-afce-8765546c20f5"),
                 Order = 5,
                 Duration = 0,
                 Reps = 20,
                 CreatedAt = today,
                 UpdatedAt = today,
             },
             new WorkoutExercise
             {
                 WorkoutExerciseId = Guid.NewGuid(),
                 WorkoutId = Guid.Parse("d5487fbc-066f-4073-acf3-2d7c595012ee"),
                 ExerciseId = Guid.Parse("9dac0527-8042-462b-8f23-7a6b503efc68"),
                 Order = 6,
                 Duration = 0,
                 Reps = 15,
                 CreatedAt = today,
                 UpdatedAt = today,
             },
            #endregion

            #region Workout Exercise 18
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("b8fd1003-667c-417e-80b8-d1b32f0b6788"),
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
                WorkoutId = Guid.Parse("b8fd1003-667c-417e-80b8-d1b32f0b6788"),
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
                WorkoutId = Guid.Parse("b8fd1003-667c-417e-80b8-d1b32f0b6788"),
                ExerciseId = Guid.Parse("01dc4c46-e1ef-44bc-9f19-ecb283bf27ce"),
                Order = 3,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("b8fd1003-667c-417e-80b8-d1b32f0b6788"),
                ExerciseId = Guid.Parse("6badb5b5-ad99-4b89-80c6-e52d0f7cd7ba"),
                Order = 4,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("b8fd1003-667c-417e-80b8-d1b32f0b6788"),
                ExerciseId = Guid.Parse("bd976f53-25f4-49ba-9943-4c92a2a7eb89"),
                Order = 5,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
             new WorkoutExercise
             {
                 WorkoutExerciseId = Guid.NewGuid(),
                 WorkoutId = Guid.Parse("b8fd1003-667c-417e-80b8-d1b32f0b6788"),
                 ExerciseId = Guid.Parse("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"),
                 Order = 6,
                 Duration = 0,
                 Reps = 10,
                 CreatedAt = today,
                 UpdatedAt = today,
             },
             new WorkoutExercise
             {
                 WorkoutExerciseId = Guid.NewGuid(),
                 WorkoutId = Guid.Parse("b8fd1003-667c-417e-80b8-d1b32f0b6788"),
                 ExerciseId = Guid.Parse("bc06f6c3-3625-438b-9563-3406e50612ee"),
                 Order = 7,
                 Duration = 0,
                 Reps = 10,
                 CreatedAt = today,
                 UpdatedAt = today,
             },
             new WorkoutExercise
             {
                 WorkoutExerciseId = Guid.NewGuid(),
                 WorkoutId = Guid.Parse("b8fd1003-667c-417e-80b8-d1b32f0b6788"),
                 ExerciseId = Guid.Parse("3409fd0e-659a-4ee4-8157-60e2ba94350c"),
                 Order = 8,
                 Duration = 0,
                 Reps = 15,
                 CreatedAt = today,
                 UpdatedAt = today,
             },
            #endregion

            #region Workout Exercise 19
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d103ce77-a74a-4227-aba0-e0c5452790a1"),
                ExerciseId = Guid.Parse("30be3b2d-bf46-4e90-8139-41411971cefc"),
                Order = 1,
                Duration = 20,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d103ce77-a74a-4227-aba0-e0c5452790a1"),
                ExerciseId = Guid.Parse("efbcb7f9-3585-4a1b-8700-871547b7e857"),
                Order = 2,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d103ce77-a74a-4227-aba0-e0c5452790a1"),
                ExerciseId = Guid.Parse("93e22c77-001f-4825-8983-4ec5b643b7bb"),
                Order = 3,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d103ce77-a74a-4227-aba0-e0c5452790a1"),
                ExerciseId = Guid.Parse("23842121-4834-4483-bfe2-2c244f5ecf76"),
                Order = 4,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 20
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("0812b9f4-73d9-4878-b99e-0b081f92ed13"),
                ExerciseId = Guid.Parse("439db970-c7c8-4b3b-9a35-127d31d920dc"),
                Order = 1,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("0812b9f4-73d9-4878-b99e-0b081f92ed13"),
                ExerciseId = Guid.Parse("9ba29558-e51b-4a1a-a1c4-b747967e32fb"),
                Order = 2,
                Duration = 20,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("0812b9f4-73d9-4878-b99e-0b081f92ed13"),
                ExerciseId = Guid.Parse("0a280d32-de67-4a38-8f21-923243489eef"),
                Order = 3,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 21
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("3ae73e0d-e6cc-4962-a17c-4e087d655e64"),
                ExerciseId = Guid.Parse("c076c867-b379-4889-9428-5bc1ae76cbc7"),
                Order = 1,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("3ae73e0d-e6cc-4962-a17c-4e087d655e64"),
                ExerciseId = Guid.Parse("235f7494-3e7d-45a5-a31a-6d5449b1322d"),
                Order = 2,
                Duration = 0,
                Reps = 16,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("3ae73e0d-e6cc-4962-a17c-4e087d655e64"),
                ExerciseId = Guid.Parse("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"),
                Order = 3,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("3ae73e0d-e6cc-4962-a17c-4e087d655e64"),
                ExerciseId = Guid.Parse("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"),
                Order = 4,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("3ae73e0d-e6cc-4962-a17c-4e087d655e64"),
                ExerciseId = Guid.Parse("30be3b2d-bf46-4e90-8139-41411971cefc"),
                Order = 5,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 22
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("568e1c3d-c775-4597-86e1-cb65cfe0df6a"),
                ExerciseId = Guid.Parse("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"),
                Order = 1,
                Duration = 0,
                Reps = 8,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("568e1c3d-c775-4597-86e1-cb65cfe0df6a"),
                ExerciseId = Guid.Parse("8b93dbb2-fc2b-4627-b79a-3ec45a7c6238"),
                Order = 2,
                Duration = 0,
                Reps = 8,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("568e1c3d-c775-4597-86e1-cb65cfe0df6a"),
                ExerciseId = Guid.Parse("8619916d-a296-48a5-af89-f82a6a1cb26f"),
                Order = 3,
                Duration = 0,
                Reps = 8,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("568e1c3d-c775-4597-86e1-cb65cfe0df6a"),
                ExerciseId = Guid.Parse("d4ebca3a-83ef-485b-9178-83d4eab9694c"),
                Order = 4,
                Duration = 0,
                Reps = 16,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("568e1c3d-c775-4597-86e1-cb65cfe0df6a"),
                ExerciseId = Guid.Parse("9dac0527-8042-462b-8f23-7a6b503efc68"),
                Order = 5,
                Duration = 0,
                Reps = 8,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 23
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("a99efeb6-14a4-44f6-8d22-b293db1fedcc"),
                ExerciseId = Guid.Parse("0b702969-cd49-412a-94a1-4f0027ec77d7"),
                Order = 1,
                Duration = 10,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("a99efeb6-14a4-44f6-8d22-b293db1fedcc"),
                ExerciseId = Guid.Parse("6749cbc6-0e28-4163-95e8-7fb2a27c54cf"),
                Order = 2,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("a99efeb6-14a4-44f6-8d22-b293db1fedcc"),
                ExerciseId = Guid.Parse("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"),
                Order = 3,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("a99efeb6-14a4-44f6-8d22-b293db1fedcc"),
                ExerciseId = Guid.Parse("2da27966-24d6-4159-9a70-968e20c4036d"),
                Order = 4,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 24
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("da56e057-d5d4-4077-a7c4-111bf3470e08"),
                ExerciseId = Guid.Parse("d4ebca3a-83ef-485b-9178-83d4eab9694c"),
                Order = 1,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("da56e057-d5d4-4077-a7c4-111bf3470e08"),
                ExerciseId = Guid.Parse("a4c84cac-058f-472a-8b81-a00c025eace4"),
                Order = 2,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("da56e057-d5d4-4077-a7c4-111bf3470e08"),
                ExerciseId = Guid.Parse("0c011f92-425a-477c-84d4-3d6dc883119b"),
                Order = 3,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("da56e057-d5d4-4077-a7c4-111bf3470e08"),
                ExerciseId = Guid.Parse("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"),
                Order = 4,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 25
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("cd738c01-05e8-4b4a-8d85-58544c6e95b5"),
                ExerciseId = Guid.Parse("92ddccfd-7076-4dbc-b96b-9197cd4cc308"),
                Order = 1,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("cd738c01-05e8-4b4a-8d85-58544c6e95b5"),
                ExerciseId = Guid.Parse("6fe4dcc3-5262-470e-b043-0db293dda2fb"),
                Order = 2,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("cd738c01-05e8-4b4a-8d85-58544c6e95b5"),
                ExerciseId = Guid.Parse("c076c867-b379-4889-9428-5bc1ae76cbc7"),
                Order = 3,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("cd738c01-05e8-4b4a-8d85-58544c6e95b5"),
                ExerciseId = Guid.Parse("4d4ca701-48a4-4385-a9b7-511cf07ef775"),
                Order = 4,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 26
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("906a8fa1-d0d6-477d-bc07-167098891ffb"),
                ExerciseId = Guid.Parse("8fad349a-913c-42dd-8bba-c1bc267918e9"),
                Order = 1,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("906a8fa1-d0d6-477d-bc07-167098891ffb"),
                ExerciseId = Guid.Parse("efbcb7f9-3585-4a1b-8700-871547b7e857"),
                Order = 2,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("906a8fa1-d0d6-477d-bc07-167098891ffb"),
                ExerciseId = Guid.Parse("30be3b2d-bf46-4e90-8139-41411971cefc"),
                Order = 3,
                Duration = 20,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("906a8fa1-d0d6-477d-bc07-167098891ffb"),
                ExerciseId = Guid.Parse("4e76715f-6578-41d8-8315-cdb23340fb5a"),
                Order = 4,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 27
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc"),
                ExerciseId = Guid.Parse("2da27966-24d6-4159-9a70-968e20c4036d"),
                Order = 1,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc"),
                ExerciseId = Guid.Parse("6ef8ed78-0d00-4271-bf9b-edf27a55ecab"),
                Order = 2,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc"),
                ExerciseId = Guid.Parse("0d816828-8a94-4dcb-a87c-b70b295a39b6"),
                Order = 3,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc"),
                ExerciseId = Guid.Parse("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"),
                Order = 4,
                Duration = 0,
                Reps = 15,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc"),
                ExerciseId = Guid.Parse("587228d2-b0a2-46d4-8f0b-e728a3726993"),
                Order = 5,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc"),
                ExerciseId = Guid.Parse("256e23fa-03b1-4328-a325-512f0860d9b0"),
                Order = 6,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("5d0a9ed1-c2e3-42f8-93b0-c6f2b9781ccc"),
                ExerciseId = Guid.Parse("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"),
                Order = 7,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 28
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783"),
                ExerciseId = Guid.Parse("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"),
                Order = 1,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783"),
                ExerciseId = Guid.Parse("01e6141a-930e-4126-a2c6-7c32a2ccdd43"),
                Order = 2,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783"),
                ExerciseId = Guid.Parse("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"),
                Order = 3,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783"),
                ExerciseId = Guid.Parse("bc06f6c3-3625-438b-9563-3406e50612ee"),
                Order = 4,
                Duration = 0,
                Reps = 8,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("ab2503e2-4ecb-44a4-9e5c-6fc4ad697783"),
                ExerciseId = Guid.Parse("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"),
                Order = 5,
                Duration = 0,
                Reps = 8,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 29
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("e628d9f7-d645-4f48-b84d-44d6cc38d8ea"),
                ExerciseId = Guid.Parse("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"),
                Order = 1,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("e628d9f7-d645-4f48-b84d-44d6cc38d8ea"),
                ExerciseId = Guid.Parse("01e6141a-930e-4126-a2c6-7c32a2ccdd43"),
                Order = 2,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("e628d9f7-d645-4f48-b84d-44d6cc38d8ea"),
                ExerciseId = Guid.Parse("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"),
                Order = 3,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("e628d9f7-d645-4f48-b84d-44d6cc38d8ea"),
                ExerciseId = Guid.Parse("bc06f6c3-3625-438b-9563-3406e50612ee"),
                Order = 4,
                Duration = 0,
                Reps = 8,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("e628d9f7-d645-4f48-b84d-44d6cc38d8ea"),
                ExerciseId = Guid.Parse("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"),
                Order = 5,
                Duration = 0,
                Reps = 8,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 30
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("536ac05d-37a7-41a9-80e0-b1651a24e1d7"),
                ExerciseId = Guid.Parse("a4c84cac-058f-472a-8b81-a00c025eace4"),
                Order = 1,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("536ac05d-37a7-41a9-80e0-b1651a24e1d7"),
                ExerciseId = Guid.Parse("92ddccfd-7076-4dbc-b96b-9197cd4cc308"),
                Order = 2,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("536ac05d-37a7-41a9-80e0-b1651a24e1d7"),
                ExerciseId = Guid.Parse("6fe4dcc3-5262-470e-b043-0db293dda2fb"),
                Order = 3,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("536ac05d-37a7-41a9-80e0-b1651a24e1d7"),
                ExerciseId = Guid.Parse("587228d2-b0a2-46d4-8f0b-e728a3726993"),
                Order = 4,
                Duration = 20,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 31
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("425fc485-239f-479e-a4da-b1fe6aed6822"),
                ExerciseId = Guid.Parse("92ddccfd-7076-4dbc-b96b-9197cd4cc308"),
                Order = 1,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("425fc485-239f-479e-a4da-b1fe6aed6822"),
                ExerciseId = Guid.Parse("a4c84cac-058f-472a-8b81-a00c025eace4"),
                Order = 2,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("425fc485-239f-479e-a4da-b1fe6aed6822"),
                ExerciseId = Guid.Parse("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"),
                Order = 3,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("425fc485-239f-479e-a4da-b1fe6aed6822"),
                ExerciseId = Guid.Parse("4834f1ce-41dc-4161-ac51-e03ca78b62b8"),
                Order = 4,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 32
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("8ac41353-c90d-478d-85b7-1c5ebdbb0da2"),
                ExerciseId = Guid.Parse("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"),
                Order = 1,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("8ac41353-c90d-478d-85b7-1c5ebdbb0da2"),
                ExerciseId = Guid.Parse("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"),
                Order = 2,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("8ac41353-c90d-478d-85b7-1c5ebdbb0da2"),
                ExerciseId = Guid.Parse("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"),
                Order = 3,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("8ac41353-c90d-478d-85b7-1c5ebdbb0da2"),
                ExerciseId = Guid.Parse("4d4ca701-48a4-4385-a9b7-511cf07ef775"),
                Order = 4,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("8ac41353-c90d-478d-85b7-1c5ebdbb0da2"),
                ExerciseId = Guid.Parse("8fad349a-913c-42dd-8bba-c1bc267918e9"),
                Order = 5,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 33
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("408aa31e-0ccf-45ec-bb86-d2c9135f8a38"),
                ExerciseId = Guid.Parse("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"),
                Order = 1,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("408aa31e-0ccf-45ec-bb86-d2c9135f8a38"),
                ExerciseId = Guid.Parse("e7a186ac-57ea-47c1-8656-7419571b8cb4"),
                Order = 2,
                Duration = 0,
                Reps = 8,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("408aa31e-0ccf-45ec-bb86-d2c9135f8a38"),
                ExerciseId = Guid.Parse("d6b2c0d5-110f-4dff-9aa7-91da10a29dca"),
                Order = 3,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("408aa31e-0ccf-45ec-bb86-d2c9135f8a38"),
                ExerciseId = Guid.Parse("13ca014d-8b75-414f-afe3-3d378ef7fa97"),
                Order = 4,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 34
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("c08197fe-5bf6-442c-ade3-6d41313267e7"),
                ExerciseId = Guid.Parse("05c931df-c828-442e-aee1-56432cb772c7"),
                Order = 1,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("c08197fe-5bf6-442c-ade3-6d41313267e7"),
                ExerciseId = Guid.Parse("a9629bb1-7d84-4e14-8898-c3bf6c932efb"),
                Order = 2,
                Duration = 0,
                Reps = 15,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("c08197fe-5bf6-442c-ade3-6d41313267e7"),
                ExerciseId = Guid.Parse("ca76bd88-8267-4e05-afce-8765546c20f5"),
                Order = 3,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 35
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("b9329533-0f83-4c93-ac2b-6c6beba82c4f"),
                ExerciseId = Guid.Parse("546e3f6d-16be-4d13-8c15-3947bcf15b1f"),
                Order = 1,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("b9329533-0f83-4c93-ac2b-6c6beba82c4f"),
                ExerciseId = Guid.Parse("22af0171-257b-43bc-9013-8985472a8c84"),
                Order = 2,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("b9329533-0f83-4c93-ac2b-6c6beba82c4f"),
                ExerciseId = Guid.Parse("6ffea500-ca35-4483-b049-d8593b2c8680"),
                Order = 3,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("b9329533-0f83-4c93-ac2b-6c6beba82c4f"),
                ExerciseId = Guid.Parse("6d6b06e1-5ade-4dae-b442-7aa200661760"),
                Order = 4,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 36
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("22ccc19e-e649-4c46-b13f-b05bf60100d4"),
                ExerciseId = Guid.Parse("a9629bb1-7d84-4e14-8898-c3bf6c932efb"),
                Order = 1,
                Duration = 0,
                Reps = 15,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("22ccc19e-e649-4c46-b13f-b05bf60100d4"),
                ExerciseId = Guid.Parse("0a280d32-de67-4a38-8f21-923243489eef"),
                Order = 2,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("22ccc19e-e649-4c46-b13f-b05bf60100d4"),
                ExerciseId = Guid.Parse("587228d2-b0a2-46d4-8f0b-e728a3726993"),
                Order = 3,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 37
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d0a4a055-5a3a-485e-9c98-3e01ae0279d3"),
                ExerciseId = Guid.Parse("0d1e54fe-7a5f-4e0a-a59f-ee9f443718e0"),
                Order = 1,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d0a4a055-5a3a-485e-9c98-3e01ae0279d3"),
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
                WorkoutId = Guid.Parse("d0a4a055-5a3a-485e-9c98-3e01ae0279d3"),
                ExerciseId = Guid.Parse("d3d944c4-947d-4910-bb6e-636390e5b8d5"),
                Order = 3,
                Duration = 20,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d0a4a055-5a3a-485e-9c98-3e01ae0279d3"),
                ExerciseId = Guid.Parse("f93d73ba-d1d6-4037-b51b-1fd005accff3"),
                Order = 4,
                Duration = 20,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("d0a4a055-5a3a-485e-9c98-3e01ae0279d3"),
                ExerciseId = Guid.Parse("6fe4dcc3-5262-470e-b043-0db293dda2fb"),
                Order = 5,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 38
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("227a4189-7704-4648-9d9d-1f2c772fd25a"),
                ExerciseId = Guid.Parse("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"),
                Order = 1,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("227a4189-7704-4648-9d9d-1f2c772fd25a"),
                ExerciseId = Guid.Parse("385f13f7-79bf-437b-acac-745b50485b9f"),
                Order = 2,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("227a4189-7704-4648-9d9d-1f2c772fd25a"),
                ExerciseId = Guid.Parse("0b702969-cd49-412a-94a1-4f0027ec77d7"),
                Order = 3,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("227a4189-7704-4648-9d9d-1f2c772fd25a"),
                ExerciseId = Guid.Parse("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"),
                Order = 4,
                Duration = 0,
                Reps = 6,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("227a4189-7704-4648-9d9d-1f2c772fd25a"),
                ExerciseId = Guid.Parse("bc06f6c3-3625-438b-9563-3406e50612ee"),
                Order = 5,
                Duration = 0,
                Reps = 6,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 39
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("73689578-c13d-4f96-972d-6e52b4a2fd5b"),
                ExerciseId = Guid.Parse("ca76bd88-8267-4e05-afce-8765546c20f5"),
                Order = 1,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("73689578-c13d-4f96-972d-6e52b4a2fd5b"),
                ExerciseId = Guid.Parse("587228d2-b0a2-46d4-8f0b-e728a3726993"),
                Order = 2,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("73689578-c13d-4f96-972d-6e52b4a2fd5b"),
                ExerciseId = Guid.Parse("a9629bb1-7d84-4e14-8898-c3bf6c932efb"),
                Order = 3,
                Duration = 0,
                Reps = 15,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 40
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("eef6374e-4803-402b-bc2b-a48efa2e3270"),
                ExerciseId = Guid.Parse("bd976f53-25f4-49ba-9943-4c92a2a7eb89"),
                Order = 1,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("eef6374e-4803-402b-bc2b-a48efa2e3270"),
                ExerciseId = Guid.Parse("ca76bd88-8267-4e05-afce-8765546c20f5"),
                Order = 2,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("eef6374e-4803-402b-bc2b-a48efa2e3270"),
                ExerciseId = Guid.Parse("68018365-010c-4ab8-81f4-05a5cbfcc24b"),
                Order = 3,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("eef6374e-4803-402b-bc2b-a48efa2e3270"),
                ExerciseId = Guid.Parse("2da27966-24d6-4159-9a70-968e20c4036d"),
                Order = 4,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("eef6374e-4803-402b-bc2b-a48efa2e3270"),
                ExerciseId = Guid.Parse("bd976f53-25f4-49ba-9943-4c92a2a7eb89"),
                Order = 5,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("eef6374e-4803-402b-bc2b-a48efa2e3270"),
                ExerciseId = Guid.Parse("4d4ca701-48a4-4385-a9b7-511cf07ef775"),
                Order = 6,
                Duration = 60,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 41
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("49deb148-c08a-4f58-980e-8e2f65a6d757"),
                ExerciseId = Guid.Parse("3409fd0e-659a-4ee4-8157-60e2ba94350c"),
                Order = 1,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("49deb148-c08a-4f58-980e-8e2f65a6d757"),
                ExerciseId = Guid.Parse("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"),
                Order = 2,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("49deb148-c08a-4f58-980e-8e2f65a6d757"),
                ExerciseId = Guid.Parse("bc06f6c3-3625-438b-9563-3406e50612ee"),
                Order = 3,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("49deb148-c08a-4f58-980e-8e2f65a6d757"),
                ExerciseId = Guid.Parse("2da27966-24d6-4159-9a70-968e20c4036d"),
                Order = 4,
                Duration = 0,
                Reps = 12,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("49deb148-c08a-4f58-980e-8e2f65a6d757"),
                ExerciseId = Guid.Parse("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"),
                Order = 5,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("49deb148-c08a-4f58-980e-8e2f65a6d757"),
                ExerciseId = Guid.Parse("58878826-775e-4d4c-8e1b-d5c95afc214d"),
                Order = 6,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 42
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("93114cad-bc0e-40ca-b465-4911b26ffbc0"),
                ExerciseId = Guid.Parse("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"),
                Order = 1,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("93114cad-bc0e-40ca-b465-4911b26ffbc0"),
                ExerciseId = Guid.Parse("2e787245-7612-41bc-9b75-7a4857282350"),
                Order = 2,
                Duration = 0,
                Reps = 8,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("93114cad-bc0e-40ca-b465-4911b26ffbc0"),
                ExerciseId = Guid.Parse("efbcb7f9-3585-4a1b-8700-871547b7e857"),
                Order = 3,
                Duration = 0,
                Reps = 8,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("93114cad-bc0e-40ca-b465-4911b26ffbc0"),
                ExerciseId = Guid.Parse("2696db05-e815-4c8b-870d-23c338479e95"),
                Order = 4,
                Duration = 30,
                Reps = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Workout Exercise 43
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("f9a5b7be-bd78-4185-9e35-ad2c90a55c69"),
                ExerciseId = Guid.Parse("546e3f6d-16be-4d13-8c15-3947bcf15b1f"),
                Order = 1,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("f9a5b7be-bd78-4185-9e35-ad2c90a55c69"),
                ExerciseId = Guid.Parse("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"),
                Order = 2,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("f9a5b7be-bd78-4185-9e35-ad2c90a55c69"),
                ExerciseId = Guid.Parse("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"),
                Order = 3,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("f9a5b7be-bd78-4185-9e35-ad2c90a55c69"),
                ExerciseId = Guid.Parse("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"),
                Order = 4,
                Duration = 0,
                Reps = 10,
                CreatedAt = today,
                UpdatedAt = today,
            },
            new WorkoutExercise
            {
                WorkoutExerciseId = Guid.NewGuid(),
                WorkoutId = Guid.Parse("f9a5b7be-bd78-4185-9e35-ad2c90a55c69"),
                ExerciseId = Guid.Parse("93e22c77-001f-4825-8983-4ec5b643b7bb"),
                Order = 5,
                Duration = 0,
                Reps = 20,
                CreatedAt = today,
                UpdatedAt = today,
            }
            #endregion

            );
        }
    }
}
