using MediatR;

namespace Monhealth.Application.Features.Certificate.Commands.UpdateCertificate
{
    public class UpdateCertificateIsVerifiedCommand : IRequest<Unit>
    {
        public Guid CertificateId { get; set; }
    }
}
