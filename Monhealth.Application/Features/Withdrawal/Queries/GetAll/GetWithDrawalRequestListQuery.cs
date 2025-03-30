using MediatR;
using Monhealth.Application.Models;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class GetWithdrawalRequestListQuery : IRequest<PageResult<GetWithdrawalRequestDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public WithdrawalStatus? Status { get; set; }
        public string? Search { get; set; }
        public GetWithdrawalRequestListQuery(int page , int limit , WithdrawalStatus? status , string? search)
        {
            Page = page;
            Limit = limit;
            Status = status;
            Search = search;
        }
    }
}