using MediatR;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionBySubscriptionId
{
    public class GetTransactionBySubscriptionIdQuery : IRequest<List<GetTransactionBySubscriptionIdDto>>
    {
        public Guid SubscriptionId { get; set; }
    }
}
