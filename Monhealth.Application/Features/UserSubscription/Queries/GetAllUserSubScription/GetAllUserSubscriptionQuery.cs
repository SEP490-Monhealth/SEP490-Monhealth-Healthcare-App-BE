using MediatR;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application
{
    public class GetAllUserSubscriptionQuery : IRequest<PageResult<GetAllUserSubscriptionDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public GetAllUserSubscriptionQuery(int page, int limit)
        {
            Page = page;
            Limit = limit;
        }
    }
}