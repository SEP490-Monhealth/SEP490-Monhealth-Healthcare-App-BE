namespace Monhealth.Application.Features.Portions.Queries.GetAllFoodPortion
{
    public class PortionDto
    {
        public Guid PortionId { get; set; }
        public string PortionSize { get; set; } = string.Empty;
        public float PortionWeight { get; set; }
        public string MeasurementUnit { get; set; } = string.Empty;
    }
}
