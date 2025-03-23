using System.Text.Json.Serialization;
using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Booking.Queries.GetAllBookings
{
    public class BookingDto : BaseEntity
    {
        public Guid BookingId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ConsultantId { get; set; }
        //consultant name
        public string ConsultantName { get; set; } = string.Empty;
        //consultant avatar
        public string ConsultantAvatar { get; set; } = string.Empty;
        //consultant phone number
        public string PhoneNumber { get; set; } = string.Empty;
        //consultant email
         public string Email { get; set; } = string.Empty;
        //member name
        public string MemberName { get; set; } = string.Empty;
        //member avatar
        public string MemberAvatar { get; set; } = string.Empty;
        [JsonPropertyName("date")]
        public DateTime Day { get; set; }
        public string? Notes { get; set; } = string.Empty;
        public string CancellationReason { get; set; } = null!;
        public BookingStatus Status { get; set; }
    }
}
