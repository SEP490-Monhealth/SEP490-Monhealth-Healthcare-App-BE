using Monhealth.Domain.Common;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Consultant.Queries.GetAllConsultants
{
    public class GetAllConsultantsDTO : TimeEntity
    {
        public Guid ConsultantId { get; set; }
        public Guid? UserId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        [JsonPropertyName("avatarUrl")]
        public string? Avatar { get; set; }
        public string Bio { get; set; } = string.Empty;
        public int? Experience { get; set; }
        [JsonPropertyName("expertise")]
        public string? ExpertiseName { get; set; }
        public double? RatingCount { get; set; }
        public double? AverageRating { get; set; }
        public bool IsVerified { get; set; }
        public bool? Status { get; set; }
    }
}
