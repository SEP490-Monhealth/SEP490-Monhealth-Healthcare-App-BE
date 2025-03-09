using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Certificate.Queries.GetAllCertificate
{
    public class CertificateDto
    {
        public Guid CertificateId { get; set; } // PK 
        public Guid? UserId { get; set; } // FK 
        public Guid? ExpertiseId { get; set; }
        public Guid? ConsultantId { get; set; }
        [JsonPropertyName("name")]
        public string CertificateName { get; set; } = string.Empty;
        [JsonPropertyName("number")]
        public string CertificateNumber { get; set; } = null!;
        public string IssueBy { get; set; } = null!;
        public string Images { get; set; } = string.Empty;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool Status { get; set; }
    }
}
