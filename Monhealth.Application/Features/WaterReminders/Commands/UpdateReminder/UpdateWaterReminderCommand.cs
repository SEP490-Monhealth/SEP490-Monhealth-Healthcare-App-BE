using MediatR;
namespace Monhealth.Application.Features.Reminders.Commands.UpdateReminder
{
    public class UpdateReminderCommand : IRequest<bool>
    {
        public Guid WaterReminderId { get; set; }
        public string WaterReminderName { get; set; }
        public string Time { get; set; } = string.Empty;
        public int Volume { get; set; }
        public UpdateReminderCommand(Guid remindId,
        UpdateReminderRequest request)
        {
            WaterReminderId = remindId;
            WaterReminderName = request.WaterReminderName;
            Time = request.Time;
            Volume = request.Volume;
        }
    }
}