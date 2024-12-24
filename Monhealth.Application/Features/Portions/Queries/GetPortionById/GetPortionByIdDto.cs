using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Portions.Queries.GetPortionById
{
    public class GetPortionByIdDto
    {
        [JsonPropertyName("size")]
        public string PortionSize { get; set; } = string.Empty;
        [JsonPropertyName("weight")]
        public float PortionWeight { get; set; }
        [JsonPropertyName("unit")]
        public string MeasurementUnit { get; set; } = string.Empty;
    }
}
