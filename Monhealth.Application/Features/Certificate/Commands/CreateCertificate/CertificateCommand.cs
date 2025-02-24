using MediatR;

namespace Monhealth.Application.Features.Certificate.Commands.CreateCertificate
{
    public class CertificateCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; } // FK 
        public Guid ExpertiseId { get; set; }
        public string CertificateName { get; set; } = string.Empty;
        public List<string> Images { get; set; } = new List<string>();
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
