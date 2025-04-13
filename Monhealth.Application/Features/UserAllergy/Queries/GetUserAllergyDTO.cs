using System.Text.Json.Serialization;

namespace Monhealth.Application
{
    public class GetUserAllergyDTO
    {
        public Guid AllergyId { get; set; }
        [JsonPropertyName("name")]
        public string AllergyName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string AllergyDescription { get; set; } = string.Empty;
    }

}