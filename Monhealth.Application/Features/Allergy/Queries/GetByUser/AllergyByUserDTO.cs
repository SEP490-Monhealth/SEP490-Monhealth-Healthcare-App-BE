using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Allergy.Queries.GetByUser
{
    public class AllergyByUserDTO
    {
        public Guid AllergyId { get; set; }
        [JsonPropertyName("name")]
        public string AllergyName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string AllergyDescription { get; set; } = string.Empty;
    }
}