using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByUserId
{
    public class GetBookingByUserIdDto : BaseEntity
    {
        public Guid BookingId { get; set; }
        public Guid? ConsultantId { get; set; }
        public DateTime Date { get; set; }
        public string? Notes { get; set; } = string.Empty;
        public string CancellationReason { get; set; } = null!;
        public BookingStatus Status { get; set; }


    }
}
