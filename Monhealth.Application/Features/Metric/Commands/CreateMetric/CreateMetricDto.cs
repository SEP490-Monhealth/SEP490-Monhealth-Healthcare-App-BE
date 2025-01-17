namespace Monhealth.Application.Features.Metric.Commands.CreateMetric
{
    public class CreateMetricDTO
    {
        public Guid UserId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public float ActivityLevel { get; set; }
        public string GoalType { get; set; }
        public int WeightGoal { get; set; }
    }
}
