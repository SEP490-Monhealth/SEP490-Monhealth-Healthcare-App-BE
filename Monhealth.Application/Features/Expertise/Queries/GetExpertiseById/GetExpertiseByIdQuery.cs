using MediatR;

namespace Monhealth.Application.Features.Expertise.Queries.GetExpertiseById
{
    public class GetExpertiseByIdQuery : IRequest<GetExpertiseByIdDTO>
    {
        public Guid ExpertiseId { get; set; }
    }
}
