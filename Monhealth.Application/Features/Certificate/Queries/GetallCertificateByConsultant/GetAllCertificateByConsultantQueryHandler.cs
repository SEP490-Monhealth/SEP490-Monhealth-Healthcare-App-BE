using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class GetAllCertificateByConsultantQueryHandler (ICertificateRepository certificateRepository)
    : IRequestHandler<GetAllCertificateByConsultantQuery, List<GetCertificateByConsultantDTO>>
    {
        public async Task<List<GetCertificateByConsultantDTO>> Handle(GetAllCertificateByConsultantQuery request, CancellationToken cancellationToken)
        {
              var certificate 
              = await certificateRepository.GetCertificateByConsultant(request.ConsultantId);
              return certificate?.Select(c => new GetCertificateByConsultantDTO{
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
              }).ToList() ?? new List<GetCertificateByConsultantDTO>();
        }
    }
}