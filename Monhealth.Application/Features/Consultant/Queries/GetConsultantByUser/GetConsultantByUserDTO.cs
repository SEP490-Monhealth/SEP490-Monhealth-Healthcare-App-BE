using System.Text.Json.Serialization;

namespace Monhealth.Application
{
    public class GetConsultantByUserDTO
    {
        public Guid? UserId { get; set; }
        public string FullName { get; set; }
        [JsonPropertyName("avatarUrl")]
        public string? Avatar { get; set; }
        public string Bio { get; set; } = string.Empty;
        public int? Experience { get; set; }
        [JsonPropertyName("expertise")]
        public string? ExpertiseName { get; set; }
        public double? RatingCount { get; set; }
        public double? AverageRating { get; set; }
        public bool? Status { get; set; }
    }
}