using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Identity.Configurations
{
    public class GoalConfiguration : IEntityTypeConfiguration<Goal>
    {
        public void Configure(EntityTypeBuilder<Goal> builder)
        {
            builder.HasData(

            // Toàn
            #region Goal 1
            new Goal
            {
                GoalId = Guid.NewGuid(),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                GoalType = GoalType.WeightGain,
                CaloriesRatio = 1.2f,
                WeightGoal = 66,
                CaloriesGoal = 2413.125f,
                ProteinGoal = 150.82031f,
                CarbsGoal = 271.47656f,
                FatGoal = 80.4375f,
                FiberGoal = 21.718124f,
                SugarGoal = 81.44297f,
                WaterIntakesGoal = 1750.0f,
                WorkoutDurationGoal = 35.0f,
                CaloriesBurnedGoal = 116.666664f,
                Status = GoalStatus.Abandoned,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region Goal 2
            new Goal
            {
                GoalId = Guid.NewGuid(),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                GoalType = GoalType.WeightGain,
                CaloriesRatio = 1.2f,
                WeightGoal = 66,
                CaloriesGoal = 2429.625f,
                ProteinGoal = 151.85156f,
                CarbsGoal = 273.3328f,
                FatGoal = 80.9875f,
                FiberGoal = 21.866623f,
                SugarGoal = 81.99984f,
                WaterIntakesGoal = 1785.0f,
                WorkoutDurationGoal = 35.0f,
                CaloriesBurnedGoal = 118.99999f,
                Status = GoalStatus.Abandoned,
                CreatedAt = DateTime.ParseExact("05-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("05-04-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region Goal 3
            new Goal
            {
                GoalId = Guid.NewGuid(),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                GoalType = GoalType.WeightGain,
                CaloriesRatio = 1.2f,
                WeightGoal = 66,
                CaloriesGoal = 2462.625f,
                ProteinGoal = 153.91406f,
                CarbsGoal = 277.04532f,
                FatGoal = 82.0875f,
                FiberGoal = 22.163626f,
                SugarGoal = 83.1136f,
                WaterIntakesGoal = 1855.0f,
                WorkoutDurationGoal = 35.0f,
                CaloriesBurnedGoal = 123.666664f,
                Status = GoalStatus.Abandoned,
                CreatedAt = DateTime.ParseExact("12-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("12-04-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region Goal 4
            new Goal
            {
                GoalId = Guid.NewGuid(),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                GoalType = GoalType.WeightGain,
                CaloriesRatio = 1.2f,
                WeightGoal = 66,
                CaloriesGoal = 2479.125f,
                ProteinGoal = 154.94531f,
                CarbsGoal = 278.90155f,
                FatGoal = 82.637505f,
                FiberGoal = 22.312124f,
                SugarGoal = 83.67047f,
                WaterIntakesGoal = 1890.0f,
                WorkoutDurationGoal = 35.0f,
                CaloriesBurnedGoal = 125.99999f,
                Status = GoalStatus.Abandoned,
                CreatedAt = DateTime.ParseExact("19-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("19-04-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region Goal 5
            new Goal
            {
                GoalId = Guid.NewGuid(),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                GoalType = GoalType.WeightGain,
                CaloriesRatio = 1.2f,
                WeightGoal = 66,
                CaloriesGoal = 2446.125f,
                ProteinGoal = 152.88281f,
                CarbsGoal = 275.18906f,
                FatGoal = 81.537506f,
                FiberGoal = 22.015123f,
                SugarGoal = 82.55672f,
                WaterIntakesGoal = 1820.0f,
                WorkoutDurationGoal = 35.0f,
                CaloriesBurnedGoal = 121.33333f,
                Status = GoalStatus.Abandoned,
                CreatedAt = DateTime.ParseExact("26-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("26-04-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region Goal 6
            new Goal
            {
                GoalId = Guid.NewGuid(),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                GoalType = GoalType.WeightGain,
                CaloriesRatio = 1.2f,
                WeightGoal = 66,
                CaloriesGoal = 2446.125f,
                ProteinGoal = 152.88281f,
                CarbsGoal = 275.18906f,
                FatGoal = 81.537506f,
                FiberGoal = 22.015123f,
                SugarGoal = 82.55672f,
                WaterIntakesGoal = 1820.0f,
                WorkoutDurationGoal = 35.0f,
                CaloriesBurnedGoal = 121.33333f,
                Status = GoalStatus.Active,
                CreatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
            },
            #endregion

            // Đại
            #region Goal 7
             new Goal
             {
                 GoalId = Guid.NewGuid(),
                 UserId = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87"),
                 GoalType = GoalType.WeightGain,
                 CaloriesRatio = 1.2f,
                 WeightGoal = 66,
                 CaloriesGoal = 2479.125f,
                 ProteinGoal = 154.94531f,
                 CarbsGoal = 278.90155f,
                 FatGoal = 82.637505f,
                 FiberGoal = 22.312124f,
                 SugarGoal = 83.67047f,
                 WaterIntakesGoal = 1890.0f,
                 WorkoutDurationGoal = 35.0f,
                 CaloriesBurnedGoal = 125.99999f,
                 Status = GoalStatus.Active,
                 CreatedAt = DateTime.ParseExact("19-04-2025", "dd-MM-yyyy", null),
                 UpdatedAt = DateTime.ParseExact("19-04-2025", "dd-MM-yyyy", null),
             },
            #endregion

             // Khải
            #region Goal 8
             new Goal
             {
                 GoalId = Guid.NewGuid(),
                 UserId = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E"),
                 GoalType = GoalType.WeightGain,
                 CaloriesRatio = 1.2f,
                 WeightGoal = 66,
                 CaloriesGoal = 2479.125f,
                 ProteinGoal = 154.94531f,
                 CarbsGoal = 278.90155f,
                 FatGoal = 82.637505f,
                 FiberGoal = 22.312124f,
                 SugarGoal = 83.67047f,
                 WaterIntakesGoal = 1890.0f,
                 WorkoutDurationGoal = 35.0f,
                 CaloriesBurnedGoal = 125.99999f,
                 Status = GoalStatus.Active,
                 CreatedAt = DateTime.ParseExact("19-04-2025", "dd-MM-yyyy", null),
                 UpdatedAt = DateTime.ParseExact("19-04-2025", "dd-MM-yyyy", null),
             },
            #endregion

             // Duy
            #region Goal 9
             new Goal
             {
                 GoalId = Guid.NewGuid(),
                 UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                 GoalType = GoalType.WeightGain,
                 CaloriesRatio = 1.2f,
                 WeightGoal = 66,
                 CaloriesGoal = 2479.125f,
                 ProteinGoal = 154.94531f,
                 CarbsGoal = 278.90155f,
                 FatGoal = 82.637505f,
                 FiberGoal = 22.312124f,
                 SugarGoal = 83.67047f,
                 WaterIntakesGoal = 1890.0f,
                 WorkoutDurationGoal = 35.0f,
                 CaloriesBurnedGoal = 125.99999f,
                 Status = GoalStatus.Active,
                 CreatedAt = DateTime.ParseExact("19-04-2025", "dd-MM-yyyy", null),
                 UpdatedAt = DateTime.ParseExact("19-04-2025", "dd-MM-yyyy", null),
             },
            #endregion

             // Khanh
            #region Goal 10
             new Goal
             {
                 GoalId = Guid.NewGuid(),
                 UserId = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2"),
                 GoalType = GoalType.WeightGain,
                 CaloriesRatio = 1.2f,
                 WeightGoal = 66,
                 CaloriesGoal = 2479.125f,
                 ProteinGoal = 154.94531f,
                 CarbsGoal = 278.90155f,
                 FatGoal = 82.637505f,
                 FiberGoal = 22.312124f,
                 SugarGoal = 83.67047f,
                 WaterIntakesGoal = 1890.0f,
                 WorkoutDurationGoal = 35.0f,
                 CaloriesBurnedGoal = 125.99999f,
                 Status = GoalStatus.Active,
                 CreatedAt = DateTime.ParseExact("19-04-2025", "dd-MM-yyyy", null),
                 UpdatedAt = DateTime.ParseExact("19-04-2025", "dd-MM-yyyy", null),
             }
             #endregion

            );
        }
    }
}
