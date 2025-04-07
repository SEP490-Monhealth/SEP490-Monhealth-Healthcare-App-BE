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
            var isNameExist = await certificateRepository
            .AnyAsync(c => c.CertificateName == request.CertificateName);
            if (isNameExist) throw new BadRequestException("Tên chứng chỉ đã tồn tại");

            var checkExpertiseExisted = await expertiseRepository.GetExpertiseByNameAsync(request.ExpertiseName);
            //if (checkExpertiseExisted != null)
            //{
            //    throw new Exception("Chuyên môn đã tồn tại.");
            //}

            // var urlLists = string.Join(",", request.Images);
            //string imageUrls = JsonSerializer.Serialize(request.ImageUrls);
            var certificate = mapper.Map<Domain.Certificate>(request);
            if (request.ImageUrls != null)
            {
                certificate.ImageUrls = request.ImageUrls;
            }
            certificate.ExpertiseId = checkExpertiseExisted.ExpertiseId;
            certificate.IsVerified = false;
            certificate.CreatedAt = DateTime.Now;
            certificate.UpdatedAt = DateTime.Now;
            certificateRepository.Add(certificate);
            await certificateRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
