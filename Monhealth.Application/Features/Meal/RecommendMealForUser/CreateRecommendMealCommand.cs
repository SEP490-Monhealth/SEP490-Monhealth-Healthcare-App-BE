using MediatR;

namespace Monhealth.Application
{
    public class CreateRecommendMealCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
    }
}