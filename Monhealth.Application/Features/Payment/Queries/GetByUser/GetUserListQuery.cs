using MediatR;
using Monhealth.Core;

namespace Monhealth.Application
{
    public record PaymentUserDTO(Guid PaymentId
    , Guid UserId
    , Guid SubscriptionId
    ,string Subscription
    , Member Member
    , int Amount
    , PaymentStatus Status
    , DateTime?CreatedAt
    , DateTime? UpdatedAt
    , Guid? CreatedBy
    , Guid? UpdatedBy);
    public class GetUserListQuery : IRequest<List<PaymentUserDTO>>
    {
        public Guid UserId { get; set; }
    }
}