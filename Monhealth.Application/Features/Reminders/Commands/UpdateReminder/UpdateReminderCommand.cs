using MediatR;
namespace Monhealth.Application.Features.Reminders.Commands.UpdateReminder
{
    public class UpdateReminderCommand : IRequest<bool>
    {
        public Guid ReminderId { get; set; }
        public float Volume { get; set; }
        public string Time { get; set; } = string.Empty;
        public string ReminderName { get; set; }
        public UpdateReminderCommand(Guid remindId,
        UpdateReminderRequest request)
        {
            ReminderId = remindId;
            Volume = request.Volume;
            Time = request.Time;
            ReminderName = request.ReminderName;

        }
    }
}