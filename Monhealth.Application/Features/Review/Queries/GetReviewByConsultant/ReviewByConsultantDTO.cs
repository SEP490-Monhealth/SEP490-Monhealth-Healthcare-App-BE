using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Review.Queries.GetReviewByConsultant
{
    public class ReviewByConsultantDTO : TimeEntity
    {
        public Guid ReviewId { get; set; }
        public Guid UserId { get; set; }
        public Guid BookingId { get; set; }
        public Member Member { get; set; } = null!;
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
    }

    public class Member
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;
    }
}