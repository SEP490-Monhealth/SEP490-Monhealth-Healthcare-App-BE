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
              return certificate.Select(c =>new GetCertificateByConsultantDTO{
                 CertificateId = c.CertificateId,
                 CertificateName =c.CertificateName,
                 CertificateNumber =c.CertificateNumber,
                 ConsultantId = c.ConsultantId,
                 ExpertiseId = (Guid)c.ExpertiseId,
                 ExpiryDate = c.ExpiryDate,
                 Images = c.ImageUrls.Select(i => i.ToString()).ToList(),
                 IssueDate = c.IssueDate,
                 IssuedBy = c.IssuedBy,

              }).ToList();
        }
    }
}