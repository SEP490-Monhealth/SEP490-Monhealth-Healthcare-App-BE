using MediatR;

namespace Monhealth.Application
{
    public class GetAllCertificateByConsultantQuery : IRequest<List<GetCertificateByConsultantDTO>>
    {
        public Guid ConsultantId { get; set; }
    }
}