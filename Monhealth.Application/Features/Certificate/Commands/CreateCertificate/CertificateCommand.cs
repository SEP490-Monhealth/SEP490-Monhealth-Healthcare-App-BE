using System.Text.Json.Serialization;
using MediatR;

namespace Monhealth.Application.Features.Certificate.Commands.CreateCertificate
{
    public class CertificateCommand : IRequest<Unit>
    {
        public Guid ExpertiseId { get; set; }
        public Guid? ConsultantId { get; set; }
        [JsonPropertyName("number")]
        public string CertificateNumber { get; set; } = null!;
        [JsonPropertyName("name")]
        public string CertificateName { get; set; } = string.Empty;
        public string IssuedBy { get; set; } = null!;
        public List<string> ImageUrls { get; set; } = new List<string>();
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }

    }
}
