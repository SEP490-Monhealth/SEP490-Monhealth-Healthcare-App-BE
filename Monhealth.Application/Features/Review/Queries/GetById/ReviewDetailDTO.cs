using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Review.Queries.GetById
{
    public class ReviewDetailDTO : TimeEntity
    {
        public Guid BookingId { get; set; }
        public Guid UserId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}