using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Reminders.Queries.GetAllReminder
{
    public class ReminderDTo
    {
        public Guid ReminderId { get; set; }
        public Guid UserId { get; set; }
        public float Volume { get; set; }
        public string Time { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}