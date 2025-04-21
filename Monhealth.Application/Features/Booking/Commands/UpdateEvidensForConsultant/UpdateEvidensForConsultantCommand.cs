using MediatR;

namespace Monhealth.Application.Features.Booking.Commands.UpdateEvidensForConsultant
{
    public class UpdateEvidensForConsultantCommand : IRequest<bool>
    {
        public Guid BookingId { get; set; }
        public UpdateEvidensDto UpdateEvidensDto { get; set; }
        public UpdateEvidensForConsultantCommand(Guid bookingId, UpdateEvidensDto updateEvidensDto)
        {
            BookingId = bookingId;
            UpdateEvidensDto = updateEvidensDto;
        }
    }
    public class UpdateEvidensDto
    {
        public List<string> EvidenceUrls { get; set; }

    }
}
