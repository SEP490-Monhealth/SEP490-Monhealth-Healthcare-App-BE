namespace Monhealth.Application.Features.Reminders.Commands.UpdateReminder
{
    public class UpdateReminderRequest
    {
        public float Volume { get; set; }
        public string Time { get; set; } = string.Empty;
    }
}