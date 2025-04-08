using MediatR;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Booking.Commands.CreateBooking
{
    public class CreateBookingCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public Guid ConsultantId { get; set; }
        [JsonPropertyName("date")]
        public DateTime Day { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public string? Notes { get; set; } = string.Empty;
    }
}
