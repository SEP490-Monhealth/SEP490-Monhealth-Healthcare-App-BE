using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Expertise.Queries.GetAllExpertises
{
    public class GetAllExpertisesDTO : TimeEntity
    {
        public Guid ExpertiseId { get; set; }
        [JsonPropertyName("name")]
        public string ExpertiseName { get; set; } = string.Empty;
    }
}
