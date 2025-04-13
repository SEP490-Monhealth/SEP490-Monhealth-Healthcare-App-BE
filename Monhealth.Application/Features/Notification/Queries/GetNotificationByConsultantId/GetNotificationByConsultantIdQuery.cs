using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Notification.Queries.GetNotificationByConsultantId
{
    public class GetNotificationByConsultantIdQuery : IRequest<PageResult<GetNotificationByConsultantIdDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public Guid ConsultantId { get; set; }
    }
}
