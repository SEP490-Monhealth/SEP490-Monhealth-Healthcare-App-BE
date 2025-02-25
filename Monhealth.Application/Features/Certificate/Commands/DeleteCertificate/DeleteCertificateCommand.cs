using MediatR;

namespace Monhealth.Application.Features.Certificate.Commands.DeleteCertificate
{
    public class DeleteCertificateCommand : IRequest<bool>
    {
        public Guid CertificateId { get; set; } // PK 

    }
}
