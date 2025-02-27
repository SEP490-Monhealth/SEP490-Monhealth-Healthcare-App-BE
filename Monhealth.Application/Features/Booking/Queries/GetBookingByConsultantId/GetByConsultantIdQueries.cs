using MediatR;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByConsultantId
{
    public class GetByConsultantIdQueries : IRequest<GetByConsultantIdDto>
    {
        public Guid ConsultantId { get; set; }
    }
}
