using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Consultant.Commands.CreateConsultant
{
    public class CreateConsultantDTO
    {
        public Guid? UserId { get; set; }
        public string Bio { get; set; } = string.Empty;
        public int? Experience { get; set; }
        public string MeetUrl { get; set; } = string.Empty;
        [JsonPropertyName("expertise")]
        public string ExpertiseName { get; set; } = string.Empty;
        [JsonPropertyName("certificate")]
        public string CertificateName { get; set; } = string.Empty;
        public string CertificateNumber { get; set; } = string.Empty;
        public string IssuedBy { get; set; } = null!;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public List<string>? ImageUrls { get; set; }
    }
}
