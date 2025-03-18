using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Subscription.Queries.GetAll
{
    public class GetAllSubscriptionQuery : IRequest<PageResult<SubscriptionDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Search { get; set; }
        public bool? Sort { get; set; }
        public bool? Status { get; set; }
    }
}