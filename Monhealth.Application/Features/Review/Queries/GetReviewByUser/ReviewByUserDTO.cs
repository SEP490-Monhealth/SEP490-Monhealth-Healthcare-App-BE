using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Review.Queries.GetReviewByUser
{
    public class ReviewByUserDTO : TimeEntity
    {
        public Guid BookingId { get; set; }
        public Guid ConsultantId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}