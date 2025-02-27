using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Booking.Queries.GetAllBookings
{
    public class BookingDto : BaseEntity
    {
        public Guid BookingId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ConsultantId { get; set; }
        public DateTime Date { get; set; }
        public string? Notes { get; set; } = string.Empty;
        public BookingStatus Status { get; set; }
    }
}
