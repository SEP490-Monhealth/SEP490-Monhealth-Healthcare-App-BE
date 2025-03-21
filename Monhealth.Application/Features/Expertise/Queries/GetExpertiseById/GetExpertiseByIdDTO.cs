using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Expertise.Queries.GetExpertiseById
{
    public class GetExpertiseByIdDTO : BaseEntity
    {
        public Guid ExpertiseId { get; set; }
        [JsonPropertyName("name")]
        public string ExpertiseName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string ExpertiseDescription { get; set; } = null!;
    }
}
