using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Consultant.Queries.GetConsultantById
{
    public class GetConsultantByIdDTO : TimeEntity
    {
        public Guid? UserId { get; set; }
        public string FullName { get; set; }
        [JsonPropertyName("avatarUrl")]
        public string? Avatar { get; set; }
        public string Bio { get; set; } = string.Empty;
        [JsonPropertyName("expertise")]
        public string? ExpertiseName { get; set; }
        public int? Experience { get; set; }
        public double? RatingCount { get; set; }
        public double? AverageRating { get; set; }
        public bool? Status { get; set; }
    }
}
