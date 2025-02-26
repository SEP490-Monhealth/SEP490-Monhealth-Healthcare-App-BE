using MediatR;

namespace Monhealth.Application.Features.Certificate.Commands.UpdateCertificate
{
    public class UpdateCertificateStatusCommand : IRequest<Unit>
    {
        public Guid CertificcateId { get; set; }
    }
}
