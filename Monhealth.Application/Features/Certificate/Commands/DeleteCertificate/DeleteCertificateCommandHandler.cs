using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Certificate.Commands.DeleteCertificate
{
    public class DeleteCertificateCommandHandler(ICertificateRepository certificateRepository) : IRequestHandler<DeleteCertificateCommand, bool>
    {
        public async Task<bool> Handle(DeleteCertificateCommand request, CancellationToken cancellationToken)
        {
            var certificate = await certificateRepository.GetByIdAsync(request.CertificateId);
            if (certificate == null) { throw new BadRequestException("Không tìm thấy chứng chỉ"); }
            certificateRepository.Remove(certificate);
            await certificateRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
