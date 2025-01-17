using MediatR;

namespace Monhealth.Application.Features.Reminders.Queries.GetReminderByUser
{
    public class GetAllReminderByUserQuery : IRequest<List<GetAllReminderByUserDTO>>
    {
        public Guid UserId { get; set; }
    }
}