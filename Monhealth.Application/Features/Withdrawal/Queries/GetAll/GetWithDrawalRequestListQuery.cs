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
        public GetWithdrawalRequestListQuery(int page , int limit , WithdrawalStatus? status)
        {
            Page = page;
            Limit = limit;
            Status = status;
        }
    }
}