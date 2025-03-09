using System.Text.Json.Serialization;
using MediatR;

namespace Monhealth.Application.Features.Certificate.Commands.CreateCertificate
{
    public class CertificateCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; } // FK 
        public Guid ExpertiseId { get; set; }
        public Guid? ConsultantId { get; set; }
        [JsonPropertyName("name")]
        public string CertificateName { get; set; } = string.Empty;
        [JsonPropertyName("number")]
        public string CertificateNumber { get; set; } = null!;
        public string IssueBy { get; set; } = null!;
        public List<string> Images { get; set; } = new List<string>();
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }

    }
}
