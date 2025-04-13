using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application
{
    public class GetCertificateByConsultantDTO : TimeEntity
    {
        public Guid CertificateId { get; set; }
        public string ExpertiseName { get; set; } = string.Empty;
        public string ExpertiseDescription { get; set; } = string.Empty;
        public Guid? ConsultantId { get; set; }
        [JsonPropertyName("number")]
        public string CertificateNumber { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string CertificateName { get; set; } = string.Empty;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string IssuedBy { get; set; } = string.Empty;
        [JsonPropertyName("imageUrls")]
        public List<string> Images { get; set; } = new List<string>();
        public bool IsVerified { get; set; } = false;
    }
}