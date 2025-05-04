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
            }
            #endregion
            );
        }
    }
}
