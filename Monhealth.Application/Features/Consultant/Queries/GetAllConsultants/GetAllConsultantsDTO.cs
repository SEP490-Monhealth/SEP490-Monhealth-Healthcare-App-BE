using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Consultant.Queries.GetAllConsultants
{
    public class GetAllConsultantsDTO : TimeEntity
    {
        public Guid ConsultantId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [JsonPropertyName("avatarUrl")]
        public string? Avatar { get; set; }
        public string Bio { get; set; } = string.Empty;
        public int? Experience { get; set; }
        [JsonPropertyName("expertise")]
        public string? ExpertiseName { get; set; }
        public int BookingCount { get; set; }
        public double? RatingCount { get; set; }
        public double? AverageRating { get; set; }
        public VerificationStatus IsVerified { get; set; }
        public bool? Status { get; set; }
    }
}
