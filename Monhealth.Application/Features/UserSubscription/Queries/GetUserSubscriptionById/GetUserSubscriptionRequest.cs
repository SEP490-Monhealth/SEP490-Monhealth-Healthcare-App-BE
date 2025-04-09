using MediatR;
using Monhealth.Core.Enum;

namespace Monhealth.Application
{
    public record GetUserSubscriptionDTO
    (Guid UserSubscriptionId, Guid UserId, Guid SubscriptionId,
    Member Member, string subscription
    , DateTime StartedAt, DateTime ExpiredAt, int RemainingBookings,
    UserSubscriptionStatus status, DateTime? CreateAt, DateTime? UpdateAt
    );
    public class GetUserSubscriptionRequest : IRequest<GetUserSubscriptionDTO>
    {
        public Guid UserSubscriptionId { get; set; }
    }
}