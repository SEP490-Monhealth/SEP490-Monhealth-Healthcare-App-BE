using MediatR;
using Monhealth.Core.Enum;

namespace Monhealth.Application
{
    public record GetUserSubscriptionDTO
    (Guid USerSubScriptionId, Guid SubscriptionId,
    Member Member, string subscription
    , DateTime StartedAt, DateTime ExpiredAt, int RemainingBookings,
    UserSubscriptionStatus status , DateTime? CreateAt , DateTime? UpdateAt,
    Guid? CreateBy , Guid? UpdateBy);
    public class GetUserSubscriptionRequest : IRequest<GetUserSubscriptionDTO>
    {
          public Guid UserSubScriptionId { get; set; }
    }
}