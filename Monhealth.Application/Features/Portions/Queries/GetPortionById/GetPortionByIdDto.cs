namespace Monhealth.Application.Features.Portions.Queries.GetPortionById
{
    public class GetPortionByIdDto
    {
        public string PortionSize { get; set; } = string.Empty;
        public float PortionWeight { get; set; }
        public string MeasurementUnit { get; set; } = string.Empty;
    }
}
