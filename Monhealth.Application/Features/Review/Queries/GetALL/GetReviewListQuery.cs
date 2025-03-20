using MediatR;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Review.Queries
{
    public class GetReviewListQuery : IRequest<PageResult<ReviewDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public int Rating { get; set; }
        public GetReviewListQuery(int page, int limit, int rating)
        {
            Page = page;
            Limit = limit;
            Rating = rating;
        }
        
    }
}