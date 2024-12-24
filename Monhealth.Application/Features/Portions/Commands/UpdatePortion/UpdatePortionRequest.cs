using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Portions.Commands.UpdatePortion
{
    public class UpdatePortionRequest
    {
        [JsonPropertyName("size")]
        public string? PortionSize { get; set; }
        [JsonPropertyName("weight")]
        public float PortionWeight { get; set; }
        [JsonPropertyName("unit")]
        public string MeasurementUnit { get; set; }
    }
}
