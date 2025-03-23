using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Certificate.Queries.GetAllCertificate
{
    public class CertificateDto
    {
        public Guid CertificateId { get; set; } // PK 
        public Guid? ExpertiseId { get; set; }
        public Guid? ConsultantId { get; set; }
        public string FullName { get; set; } = string.Empty;
        [JsonPropertyName("number")]
        public string CertificateNumber { get; set; } = null!;
        [JsonPropertyName("name")]
        public string CertificateName { get; set; } = string.Empty;       
        public string IssuedBy { get; set; } = null!;
        public List<string> ImageUrls { get; set; } = new List<string>();
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool Status { get; set; }
    }
}
