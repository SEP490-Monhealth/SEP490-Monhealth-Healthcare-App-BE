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
        public string ConsultantName { get; set; }
        //consultant avatar
        public string ConsultantAvatar { get; set; }
        //member name
        public string MemberName { get; set; }
        //member avatar
        public string MemberAvatar { get; set; }
        public DateTime Day { get; set; }
        public string? Notes { get; set; } = string.Empty;
        public string CancellationReason { get; set; } = null!;
        public BookingStatus Status { get; set; }
    }
}
