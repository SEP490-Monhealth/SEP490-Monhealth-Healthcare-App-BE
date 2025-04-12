using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Certificate.Queries.GetCertificateById
{
    public class GetCertificateByIdQueryHandler(IMapper mapper, ICertificateRepository certificateRepository) : IRequestHandler<GetCertificateByIdQuery, GetCertificateByIdDTO>
    {
        public async Task<GetCertificateByIdDTO> Handle(GetCertificateByIdQuery request, CancellationToken cancellationToken)
        {
            var certificate = await certificateRepository.GetByCertificateIdAsync(request.CertificateId);
            if (certificate == null) throw new NotFoundException("Không tìm thấy chứng chỉ");
            var certificateDTO = new GetCertificateByIdDTO
            {
                CertificateId = certificate.CertificateId,
                CertificateName = certificate.CertificateName,
                CertificateNumber = certificate.CertificateNumber,
                ConsultantId = certificate.ConsultantId,
                ExpertiseDescription = certificate?.Consultant?.Expertise?.ExpertiseDescription,
                ExpertiseName = certificate.Consultant?.Expertise.ExpertiseName,
                ExpiryDate = certificate.ExpiryDate,
                Images = certificate.ImageUrls,
                IssueDate = certificate.IssueDate,
                IssuedBy = certificate.IssuedBy,
                IsVerified = certificate.IsVerified,
                CreatedAt = certificate.CreatedAt,
                UpdatedAt = certificate.UpdatedAt

            };
            return certificateDTO;
        }
    }
}
