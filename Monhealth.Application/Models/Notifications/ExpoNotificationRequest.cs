using System.Text.Json.Serialization;

namespace Monhealth.Application.Models.Notifications
{
    public class ExpoNotificationRequest
    {
        [JsonPropertyName("to")]
        public string To { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }
    }
}
