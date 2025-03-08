using MediatR;

namespace Monhealth.Application
{
    public class CheckGoalTypeQuery : IRequest<Unit>
    {
        public Guid UserId { get; set; }
    }
}