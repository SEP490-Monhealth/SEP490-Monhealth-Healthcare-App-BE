using MediatR;
using Monhealth.Application.Models;
using Monhealth.Core;

namespace Monhealth.Application
{
    public record PaymentUserDTO(Guid PaymentId
    , Guid UserId
    , Guid SubscriptionId
    , Member Member
    , string Subscription
    , string? Description
    , int Amount
    , PaymentStatus Status
    , DateTime? CreatedAt
    , DateTime? UpdatedAt
    , Guid? CreatedBy
    , Guid? UpdatedBy);
    public class GetUserListQuery : IRequest<PageResult<PaymentUserDTO>>
    {
        public Guid UserId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}