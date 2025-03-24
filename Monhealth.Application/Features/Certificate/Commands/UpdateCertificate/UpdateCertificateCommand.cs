using MediatR;

namespace Monhealth.Application.Features.Certificate.Commands.UpdateCertificate
{
    public class UpdateCertificateCommand : IRequest<bool>
    {
        public Guid CertificateId { get; set; }
        public UpdateCertificateDTO UpdateCertificateDTO { get; set; }
        public UpdateCertificateCommand(Guid certificateId, UpdateCertificateDTO updateCertificateDTO)
        {
            CertificateId = certificateId;
            UpdateCertificateDTO = updateCertificateDTO;
        }
    }
}
