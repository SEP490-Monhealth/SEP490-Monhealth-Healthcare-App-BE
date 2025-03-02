using MediatR;

namespace Monhealth.Application.Features.Certificate.Queries.GetAllCertificates
{
    public class GetAllCertificatesQuery : IRequest<List<GetAllCertificatesDTO>>
    {
    }
}
