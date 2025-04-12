using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Certificate.Queries.GetAllCertificates
{
    public class GetAllCertificatesQueryHandler : IRequestHandler<GetAllCertificatesQuery, List<GetAllCertificatesDTO>>
    {
        private readonly ICertificateRepository _certificateRepository;
        private readonly IMapper _mapper;
        public GetAllCertificatesQueryHandler(ICertificateRepository certificateRepository, IMapper mapper)
        {
            _certificateRepository = certificateRepository;
            _mapper = mapper;
        }
        public async Task<List<GetAllCertificatesDTO>> Handle(GetAllCertificatesQuery request, CancellationToken cancellationToken)
        {
            var listCertificates = await _certificateRepository.GetAllCertificatesAsync();
            
               return listCertificates?.Select(c => new GetAllCertificatesDTO{
                 CertificateId = c.CertificateId,
                 CertificateName = c.CertificateName,
                 CertificateNumber = c.CertificateNumber,
                 ConsultantId = c.ConsultantId,
                 ExpertiseName = c.Consultant?.Expertise?.ExpertiseName,
                 ExpiryDate = c.ExpiryDate,
                 Images = c.ImageUrls,
                 IssueDate = c.IssueDate,
                 IssuedBy = c.IssuedBy,
                 IsVerified = c.IsVerified,
                 ExpertiseDescription = c.Consultant?.Expertise?.ExpertiseDescription,
                 CreatedAt = c.CreatedAt,
                 UpdatedAt = c.UpdatedAt
              }).ToList() ?? new List<GetAllCertificatesDTO>();
        }
    }
}
