using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByConsultantId
{
    public class GetByConsultantIdDto : BaseEntity
    {
        public Guid BookingId { get; set; }
        public Guid? UserId { get; set; }
        public DateTime Date { get; set; }
        public string? Notes { get; set; } = string.Empty;
        public string CancellationReason { get; set; } = null!;
        public BookingStatus Status { get; set; }
    }
}
