using System.Text.Json.Serialization;
using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Report.Queries.GetReportById
{
    public class GetReportByIdDTO : TimeEntity
    {
        public Guid ReportId { get; set; }
        public Guid BookingId { get; set; }
        public string? Notes { get; set; }

        public Guid UserId { get; set; }
        public Guid ConsultantId { get; set; }
        public Member Member { get; set; }
        public Consultant Consultant { get; set; }
        public string Reason { get; set; }
        public List<string> ImageUrls { get; set; } = new();
        public Booking Booking { get; set; }
        public StatusReport Status { get; set; }
    }
    public class Member
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        [JsonPropertyName("avatarUrl")]
        public string? Avatar { get; set; }
    }
    public class Consultant
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        [JsonPropertyName("avatarUrl")]
        public string? Avatar { get; set; }
    }
    public class Booking
    {
        [JsonPropertyName("date")]
        public DateOnly Day { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }
}
