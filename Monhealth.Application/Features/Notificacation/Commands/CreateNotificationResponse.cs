using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Notificacation.Commands
{
    public class CreateNotificationResponse
    {
        public int NotificationsCreated { get; set; } // Số lượng thông báo đã tạo
        public List<string> ReminderDescriptions { get; set; } = new List<string>(); // Mô tả các Reminder được xử lý
    }

}