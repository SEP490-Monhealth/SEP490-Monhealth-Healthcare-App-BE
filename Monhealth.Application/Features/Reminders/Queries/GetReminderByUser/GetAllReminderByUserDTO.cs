using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Reminders.Queries.GetReminderByUser
{
    public class GetAllReminderByUserDTO 
    {
        public Guid ReminderId { get; set; }
        public float Volume { get; set; }
        public string Time { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}