using MediatR;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Review.Queries.GetReviewByUser
{
    public class GetReviewByUserQuery : IRequest<PageResult<ReviewByUserDTO>>
    {

        public Guid UserId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public GetReviewByUserQuery( Guid userId, int page, int limit)
        {
            UserId = userId;
            Page = page;
            Limit = limit;
        }
        
    }
}