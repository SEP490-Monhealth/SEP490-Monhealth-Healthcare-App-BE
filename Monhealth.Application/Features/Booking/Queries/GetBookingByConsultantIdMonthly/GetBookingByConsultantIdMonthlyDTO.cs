using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByConsultantIdMonthly
{
    public class GetBookingByConsultantIdMonthlyDTO : BaseEntity
    {
        public Guid BookingId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ConsultantId { get; set; }
        public Member Member { get; set; }
        public Consultant Consultant { get; set; }
        [JsonPropertyName("date")]
        public DateOnly Day { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public string? Notes { get; set; } = string.Empty;
        public string CancellationReason { get; set; } = null!;
        public List<string>? EvidenceUrls { get; set; } = new();
        public string MeetingUrl { get; set; } = string.Empty;
        public bool IsReviewed { get; set; }
        public bool IsReported { get; set; } = false;
        public BookingStatus Status { get; set; }
    }

    public class Member
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;
    }

    public class Consultant
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;
    }
}
