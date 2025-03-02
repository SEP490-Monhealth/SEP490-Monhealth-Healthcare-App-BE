using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Features.Certificate.Commands.UpdateCertificate;

namespace Monhealth.Application.Features.Certificate.Commands.UpdateCertificateStatus
{
    public class UpdateCertificateStatusCommandHandler(ICertificateRepository certificateRepository) : IRequestHandler<UpdateCertificateStatusCommand, Unit>
    {
        public async Task<Unit> Handle(UpdateCertificateStatusCommand request, CancellationToken cancellationToken)
        {
            var certificate = await certificateRepository.GetByIdAsync(request.CertificateId);
            if (certificate == null) { throw new BadRequestException("Không tìm thấy chứng chỉ"); }
            if (certificate.Status)
            {
                certificate.Status = false;
            }
            else
            {
                certificate.Status = true;
            }
            certificateRepository.Update(certificate);
            await certificateRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
