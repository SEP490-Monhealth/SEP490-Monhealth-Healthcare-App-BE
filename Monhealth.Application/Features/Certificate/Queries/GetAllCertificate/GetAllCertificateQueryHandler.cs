using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Certificate.Queries.GetAllCertificate
{
    public class GetAllCertificateQueryHandler : IRequestHandler<GetAllCertificateQuery, PageResult<CertificateDto>>
    {
        private readonly ICertificateRepository _certificateRepository;
      

        public GetAllCertificateQueryHandler(ICertificateRepository certificateRepository, IMapper mapper)
        {
            _certificateRepository = certificateRepository;
        }

        public async Task<PageResult<CertificateDto>> Handle(GetAllCertificateQuery request, CancellationToken cancellationToken)
        {
            var pagingCertificates = await _certificateRepository.GetAllCertificateAsync(request.Page, request.Limit, request.Search, request.IsVerified);

            List<CertificateDto> certificateDtos = new List<CertificateDto>();
            foreach (var certificate in pagingCertificates.Items)
            {
                var certificateDTO = new CertificateDto
                {
                    CertificateId = certificate.CertificateId,
                    CertificateName = certificate.CertificateName,
                    CertificateNumber = certificate.CertificateNumber,
                    ConsultantId = certificate.ConsultantId,
                    CreatedAt = certificate.CreatedAt,
                    ExpertiseId = certificate.Consultant?.Expertise?.ExpertiseId ?? Guid.Empty,
                    ExpiryDate = certificate.ExpiryDate,
                    Images = certificate.ImageUrls,
                    IssueDate = certificate.IssueDate,
                    IssuedBy = certificate.IssuedBy,
                    IsVerified = certificate.IsVerified,
                    UpdatedAt = certificate.UpdatedAt,
                    ExpertiseDescription = certificate.Consultant?.Expertise?.ExpertiseDescription,
                    ExpertiseName = certificate.Consultant?.Expertise?.ExpertiseName
                };
                certificateDtos.Add(certificateDTO);
            }

            // Tính toán phân trang
            var result = new PageResult<CertificateDto>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(pagingCertificates.TotalCount / (double)request.Limit),
                TotalItems = pagingCertificates.TotalCount,
                Items = certificateDtos
            };

            return result;
        }
    }
}
