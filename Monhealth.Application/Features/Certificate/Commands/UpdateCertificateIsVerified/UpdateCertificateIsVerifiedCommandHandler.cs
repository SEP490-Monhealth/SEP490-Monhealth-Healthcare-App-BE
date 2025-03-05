using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Features.Certificate.Commands.UpdateCertificate;

namespace Monhealth.Application.Features.Certificate.Commands.UpdateCertificateStatus
{
    public class UpdateCertificateIsVerifiedCommandHandler(ICertificateRepository certificateRepository) : IRequestHandler<UpdateCertificateIsVerifiedCommand, Unit>
    {
        public async Task<Unit> Handle(UpdateCertificateIsVerifiedCommand request, CancellationToken cancellationToken)
        {
            var certificate = await certificateRepository.GetByIdAsync(request.CertificateId);
            if (certificate == null) { throw new BadRequestException("Không tìm thấy chứng chỉ"); }
            if (certificate.IsVerified)
            {
                certificate.IsVerified = false;
            }
            else
            {
                certificate.IsVerified = true;
            }
            certificateRepository.Update(certificate);
            await certificateRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
