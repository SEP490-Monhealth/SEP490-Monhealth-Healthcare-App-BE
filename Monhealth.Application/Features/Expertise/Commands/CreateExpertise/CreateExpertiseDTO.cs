using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Expertise.Commands.CreateExpertise
{
    public class CreateExpertiseDTO
    {
        [JsonPropertyName("name")]
        public string ExpertiseName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string ExpertiseDescription { get; set; } = null!;
    }
}
