using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.ConsultantBank.Queries.GetAllConsultantBanks
{
    public class GetAllConsultantBanksQuery : IRequest<PageResult<GetAllConsultantBanksDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Search { get; set; }
        public bool? Status { get; set; }
        public GetAllConsultantBanksQuery(int page, int limit, string? search, bool? status)
        {
            Page = page;
            Limit = limit;
            Search = search;
            Status = status;
        }
    }
}
