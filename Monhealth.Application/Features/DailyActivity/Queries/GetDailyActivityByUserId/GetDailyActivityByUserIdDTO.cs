using System.Text.Json.Serialization;
using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.DailyActivity.Queries.GetDailyActivityByUserId
{
    public class GetDailyActivityByUserIdDTO : TimeEntity
    {
        public Guid DailyActivityId { get; set; }
        public GoalType GoalType { get; set; }
        public float TotalCaloriesIntake { get; set; }
        public float TotalCaloriesBurned { get; set; }
        public float TotalDurationMinutes { get; set; }
        public List<ActivityDTO> Items { get; set; }
    }
    public class ActivityDTO
    {
        public Guid ActivityId { get; set; }
        public Guid UserId { get; set; }
        public Guid DailyActivityId { get; set; }
        public Guid WorkoutId { get; set; }
        public float CaloriesBurned { get; set; }
        public float DurationMinutes { get; set; }
    }
}
