using MediatR;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Portions.Commands.CreateFoodPortion
{
    public class CreatePortionCommand : IRequest<Unit>
    {
        public Guid FoodId { get; set; }
        [JsonPropertyName("size")]
        public string? PortionSize { get; set; }
        [JsonPropertyName("weight")]
        public float PortionWeight { get; set; }
        [JsonPropertyName("unit")]
        public string MeasurementUnit { get; set; }
    }
}
