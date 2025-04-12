using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Expertise.Commands.UpdateExpertiseByConsultantId
{
    public class UpdateExpertiseByConsultantIdDto
    {
        public string Expertise { get; set; } = string.Empty;
        [JsonPropertyName("number")]
        public string CertificateNumber { get; set; } = string.Empty;
        [JsonPropertyName("certificate")]
        public string CertificateName { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string IssuedBy { get; set; } = null!;
        public List<string> ImageUrls { get; set; } = new List<string>();
    }
}
