using MediatR;

namespace Monhealth.Application.Features.Review.Queries.GetReviewByConsultant
{
    public class GetReviewByConsultantQuery : IRequest<List<ReviewByConsultantDTO>>
    {
        public Guid ConsultantId { get; set; }
    }
}