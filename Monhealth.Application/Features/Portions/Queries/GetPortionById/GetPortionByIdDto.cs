namespace Monhealth.Application.Features.Portions.Queries.GetPortionById
{
    public class GetPortionByIdDto
    {
        public Guid PortionId { get; set; }
        public string PortionSize { get; set; } = string.Empty;
        public string PortionWeight { get; set; } = string.Empty;
        public string MeasurementUnit { get; set; } = string.Empty;
    }
}
