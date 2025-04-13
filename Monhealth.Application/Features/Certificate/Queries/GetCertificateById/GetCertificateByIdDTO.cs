using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Certificate.Queries.GetCertificateById
{
    public class GetCertificateByIdDTO : TimeEntity
    {
        public Guid CertificateId { get; set; }
        public Guid? ConsultantId { get; set; }
        public string ExpertiseName { get; set; } = string.Empty;
        public string ExpertiseDescription { get; set; } = string.Empty;
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
