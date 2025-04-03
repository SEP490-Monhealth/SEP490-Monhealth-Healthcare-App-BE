using MediatR;

namespace Monhealth.Application.Features.Activity.Commands.ChangeIsCompletedActivity
{
    public class ChangeIsCompletedActivityCommand : IRequest<bool>
    {
        public Guid ActivityId { get; set; }
    }
}
