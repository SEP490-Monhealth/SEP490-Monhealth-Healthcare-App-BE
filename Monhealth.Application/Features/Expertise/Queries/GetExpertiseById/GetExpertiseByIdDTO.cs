using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Expertise.Queries.GetExpertiseById
{
    public class GetExpertiseByIdDTO
    {
        [JsonPropertyName("name")]
        public string ExpertiseName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string ExpertiseDescription { get; set; } = null!;
    }
}
