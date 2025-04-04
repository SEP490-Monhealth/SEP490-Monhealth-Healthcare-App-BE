using MediatR;
using Monhealth.Application.Models.Paging;
using Monhealth.Core.Enum;

namespace Monhealth.Application
{
    public class GetAllUserSubscriptionQuery : IRequest<PageResult<GetAllUserSubscriptionDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Name { get; set; }
        public string? Search { get; set; }
        public UserSubscriptionStatus? Status { get; set; }
        public GetAllUserSubscriptionQuery(int page, int limit, string? name, string? search, UserSubscriptionStatus? status)
        {
            Page = page;
            Limit = limit;
            Name = name;
            Search = search;
            Status = status;
        }
    }
}