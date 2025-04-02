namespace Monhealth.Application.Features.Notification.Commands.CreateNotification
{
    public class CreateNotificationDTO
    {
        public Guid ReferenceId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string? ActionUrl { get; set; }
    }
}
