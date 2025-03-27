using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Bank.Queries.GetAllBanks
{
    public class GetAllBanksQuery : IRequest<PageResult<GetAllBanksDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Search { get; set; }
        public bool? Status { get; set; }
        public GetAllBanksQuery(int page, int limit, string? search, bool? status)
        {
            Page = page;
            Limit = limit;
            Search = search;
            Status = status;
        }
    }
}
