using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Certificate.Commands.CreateCertificate
{
    public class CertificateCommandHandler(IMapper mapper, ICertificateRepository certificateRepository, IExpertiseRepository expertiseRepository) : IRequestHandler<CertificateCommand, Unit>
    {
        public async Task<Unit> Handle(CertificateCommand request, CancellationToken cancellationToken)
        {
            var checkExpertiseExisted = await expertiseRepository.GetExpertiseByNameAsync(request.ExpertiseName);
            if (checkExpertiseExisted == null) throw new BadRequestException("Không tìm thấy chuyên môn");
            var certificate = mapper.Map<Domain.Certificate>(request);
            if (request.ImageUrls != null)
            {
                certificate.ImageUrls = request.ImageUrls;
            }
            certificate.ExpertiseId = checkExpertiseExisted.ExpertiseId;
            certificate.IsVerified = false;
            certificate.CreatedAt = DateTime.UtcNow;
            certificate.UpdatedAt = DateTime.UtcNow;
            certificateRepository.Add(certificate);

            await certificateRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
