using MediatR;

namespace Monhealth.Application.Features.Activity.Commands.DeleteActivity
{
    public class DeleteActivityCommand : IRequest<bool>
    {
        public Guid ActivityId { get; set; }
    }
}
