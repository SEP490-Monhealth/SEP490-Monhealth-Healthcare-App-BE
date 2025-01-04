using MediatR;

namespace Monhealth.Application.Features.Reminders.Queries.GetReminderDetail
{
    public class GerReminderDetailQuery : IRequest<ReminderDetailDTO>
    {
        public Guid ReminderId { get; set; }
    }
}