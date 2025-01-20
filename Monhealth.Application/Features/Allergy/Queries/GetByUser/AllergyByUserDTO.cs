using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Allergy.Queries.GetByUser
{
    public class AllergyByUserDTO : TimeEntity
    {
        public Guid AllergyId { get; set; }
        [JsonPropertyName("name")]
        public string AllergyName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string AllergyDescription { get; set; } = string.Empty;
    }
}