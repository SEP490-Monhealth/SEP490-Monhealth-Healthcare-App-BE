using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Review.Queries.GetReviewByConsultant
{
    public class ReviewByConsultantDTO : BaseEntity
    {
        public Guid BookingId { get; set; }
        public Guid UserId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}