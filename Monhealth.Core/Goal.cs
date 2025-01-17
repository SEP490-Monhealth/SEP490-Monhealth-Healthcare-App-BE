using Monhealth.Core;
using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Goal : BaseEntity
    {
        [Key]
        public Guid GoalId { get; set; }
        public Guid UserId { get; set; }
        public GoalType GoalType { get; set; }
        public int WeightGoal { get; set; }
        public float CaloriesGoal { get; set; }
        public float ProteinGoal { get; set; }
        public float CarbGoal { get; set; }
        public float FatGoal { get; set; }
        public float FiberGoal { get; set; }
        public float SugarGoal { get; set; }
        public int WaterGoal { get; set; }
        public float ExerciseGoal { get; set; }
        public float WaterIntakesGoal { get; set; }
        public float ExerciseDurationGoal { get; set; }
        public float ExerciseCaloriesGoal { get; set; }
        public float StepsGoal { get; set; }
        public GoalStatus Status { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        public ICollection<DailyMeal> DailyMeals { get; set; }
        public ICollection<DailyActivity> DailyActivities { get; set; }
        public ICollection<DailyWaterIntake> DailyWaterIntakes { get; set; }
    }
}
