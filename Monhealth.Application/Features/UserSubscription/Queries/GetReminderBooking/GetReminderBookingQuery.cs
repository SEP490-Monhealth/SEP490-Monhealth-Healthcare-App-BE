using MediatR;
namespace Monhealth.Application
{
    public class GetReminderBookingQuery : IRequest<GetReminderBookingDTO>
    {
        public Guid UserId { get; set; }
    }
}