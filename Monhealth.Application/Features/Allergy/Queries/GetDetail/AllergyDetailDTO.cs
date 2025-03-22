using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Allergy.Queries.GetDetail
{
    public class AllergyDetailDTO : BaseEntity
    {
        [JsonPropertyName("name")]
        public string AllergyName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string AllergyDescription { get; set; } = string.Empty;
    }
}