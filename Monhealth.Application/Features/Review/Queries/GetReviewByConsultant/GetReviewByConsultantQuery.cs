using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Review.Queries.GetReviewByConsultant
{
    public class GetReviewByConsultantQuery : IRequest<PageResult<ReviewByConsultantDTO>>
    {
        public Guid ConsultantId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}