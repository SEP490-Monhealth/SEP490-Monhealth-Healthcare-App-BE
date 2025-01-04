using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Reminders.Queries.GetReminderByUser
{
    public class GetAllReminderByUserDTO
    {
        public Guid ReminderId { get; set; }
        public float Volume { get; set; }
        [JsonPropertyName("Name")]
        public string ReminderName { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}