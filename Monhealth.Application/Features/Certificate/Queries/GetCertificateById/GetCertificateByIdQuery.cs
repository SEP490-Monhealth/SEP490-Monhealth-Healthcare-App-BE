using MediatR;
using Monhealth.Application.Features.Certificate.Queries.GetAllCertificate;

namespace Monhealth.Application.Features.Certificate.Queries.GetCertificateById
{
    public class GetCertificateByIdQuery : IRequest<CertificateDto>
    {
        public Guid CertificateId { get; set; } // PK 
    }
}
