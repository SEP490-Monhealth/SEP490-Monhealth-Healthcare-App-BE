using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Certificate.Queries.GetCertificateById
{
    public class GetCertificateByIdDTO : TimeEntity
    {
        public Guid? ExpertiseId { get; set; }
        public Guid? ConsultantId { get; set; }
        [JsonPropertyName("number")]
        public string CertificateNumber { get; set; } = null!;
        [JsonPropertyName("name")]
        public string CertificateName { get; set; } = string.Empty;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string IssuedBy { get; set; } = null!;
        public List<string> ImageUrls { get; set; } = new List<string>();
        public bool IsVerified { get; set; }
    }
}
