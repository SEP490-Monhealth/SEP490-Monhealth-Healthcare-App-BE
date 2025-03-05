using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Certificate.Queries.GetAllCertificates
{
    public class GetAllCertificatesDTO
    {
        public Guid CertificateId { get; set; } // PK 
        public Guid ExpertiseId { get; set; }
        public Guid? ConsultantId { get; set; }
        [JsonPropertyName("name")]
        public string CertificateName { get; set; } = string.Empty;
        public List<string> Images { get; set; } = new List<string>();
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
