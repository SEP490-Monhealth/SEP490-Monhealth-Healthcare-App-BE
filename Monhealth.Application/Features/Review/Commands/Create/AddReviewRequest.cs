using MediatR;

namespace Monhealth.Application.Features.Review.Commands.Create
{
    public class AddReviewRequest : IRequest<Unit>
    {
        public Guid BookingId { get; set; } // FK
        public Guid UserId { get; set; } // FK
        public Guid ConsultantId { get; set; } // FK
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}