using Monhealth.Domain.Common;

namespace Monhealth.Application
{
    public class GetActivityByDTO : TimeEntity
    {
        public Guid ActivityId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? DailyActivityId { get; set; }
        public Guid? WorkoutId { get; set; }
        public float CaloriesBurned { get; set; }
        public float DurationMinutes { get; set; }
        public bool IsCompleted { get; set; }
    }
}