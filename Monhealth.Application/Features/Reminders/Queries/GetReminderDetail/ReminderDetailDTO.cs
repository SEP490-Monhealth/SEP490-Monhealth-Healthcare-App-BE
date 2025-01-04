using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Reminders.Queries.GetReminderDetail
{
    public class ReminderDetailDTO
    {
        public Guid UserId { get; set; }
        public float Volume { get; set; }
        [JsonPropertyName("Name")]
        public string ReminderName { get; set; }
        public string Time { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}