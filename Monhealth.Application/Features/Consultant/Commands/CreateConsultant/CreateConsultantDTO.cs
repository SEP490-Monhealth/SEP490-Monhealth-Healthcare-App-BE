using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Consultant.Commands.CreateConsultant
{
    public class CreateConsultantDTO
    {
        public Guid? UserId { get; set; }
        public string Bio { get; set; } = string.Empty;
        public int? Experience { get; set; }

        // Expertise
        [JsonPropertyName("expertise")]
        public string ExpertiseName { get; set; } = string.Empty;

        // Certificate
        [JsonPropertyName("certificate")]
        public string CertificateName { get; set; } = string.Empty;
        public List<string>? Images { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
