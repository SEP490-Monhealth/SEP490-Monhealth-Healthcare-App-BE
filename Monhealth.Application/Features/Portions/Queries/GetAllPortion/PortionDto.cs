using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Portions.Queries.GetAllFoodPortion
{
    public class PortionDto
    {
        public Guid PortionId { get; set; }
        [JsonPropertyName("size")]
        public string PortionSize { get; set; } = string.Empty;
        [JsonPropertyName("weight")]
        public float PortionWeight { get; set; }
        [JsonPropertyName("unit")]
        public string MeasurementUnit { get; set; } = string.Empty;
    }
}
