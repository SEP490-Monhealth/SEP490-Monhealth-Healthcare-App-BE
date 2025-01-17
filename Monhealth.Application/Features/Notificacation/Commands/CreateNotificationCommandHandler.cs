using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Notificacation.Commands
{
    public class CreateNotificationCommandHandler : IRequestHandler<CreateNotificationCommand, CreateNotificationResponse>
    {
        private readonly INotificationRepository _notificationRepository;
        private readonly IReminderRepository _reminderRepository;
        public CreateNotificationCommandHandler(INotificationRepository notificationRepository,
        IReminderRepository reminderRepository)
        {
            _notificationRepository = notificationRepository;
            _reminderRepository = reminderRepository;
        }

        public async Task<CreateNotificationResponse> Handle(CreateNotificationCommand request, CancellationToken cancellationToken)
        {
            var currentTime = DateTime.Now.ToString("HH:mm");

            // Lấy danh sách các Reminder phù hợp
            var activeReminders = await _reminderRepository.GetActiveRemindersAsync(currentTime);

            // Khởi tạo kết quả trả về
            var response = new CreateNotificationResponse();

            foreach (var reminder in activeReminders)
            {
                // Tạo Notification mới
                var notification = new Monhealth.Core.Notification
                {
                    Message = $"{reminder.WaterReminderName}",
                    NotifyTime = DateTime.Now,
                    IsSent = false
                };

                 _notificationRepository.Add(notification);

                // Cập nhật kết quả trả về
                response.NotificationsCreated++;
                response.ReminderDescriptions.Add(reminder.WaterReminderName);
            }

            // Lưu thay đổi vào cơ sở dữ liệu
            await _notificationRepository.SaveChangeAsync();

            return response;
        }
    }
}