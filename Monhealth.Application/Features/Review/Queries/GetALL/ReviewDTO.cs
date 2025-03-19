using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Review.Queries
{
    public class ReviewDTO : TimeEntity
    {
        public Guid ReviewId { get; set; }
        public Guid BookingId { get; set; }
        public Guid UserId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}