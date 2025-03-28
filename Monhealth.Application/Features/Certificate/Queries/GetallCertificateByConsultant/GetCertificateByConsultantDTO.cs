using System.Text.Json.Serialization;

namespace Monhealth.Application
{
    public class GetCertificateByConsultantDTO
    {
        public Guid CertificateId { get; set; } // PK 
        public Guid ExpertiseId { get; set; }
        public Guid? ConsultantId { get; set; }
        [JsonPropertyName("number")]
        public string CertificateNumber { get; set; } = null!;
        [JsonPropertyName("name")]
        public string CertificateName { get; set; } = string.Empty;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string IssuedBy { get; set; } = null!;
        [JsonPropertyName("imageUrls")]
        public List<string> Images { get; set; } = new List<string>();
    }
}