using MediatR;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Certificate.Queries.GetAllCertificate
{
    public class GetAllCertificateQuery : IRequest<PageResult<CertificateDto>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string Search { get; set; }
        public bool? Status { get; set; }

        public GetAllCertificateQuery(int page, int limit, string search, bool? status)
        {
            Page = page;
            Limit = limit;
            Search = search;
            Status = status;
        }
    }
}
