namespace Monhealth.Application.Features.Metric.Commands.UpdateMetric
{
    public class UpdateMetricDTO
    {
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public float ActivityLevel { get; set; }
    }
}
