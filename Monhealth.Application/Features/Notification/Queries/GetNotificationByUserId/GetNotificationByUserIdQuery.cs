using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Notification.Queries.GetNotificationByUserId
{
    public class GetNotificationByUserIdQuery : IRequest<PageResult<GetNotificationByUserIdDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public Guid UserId { get; set; }
    }
}
