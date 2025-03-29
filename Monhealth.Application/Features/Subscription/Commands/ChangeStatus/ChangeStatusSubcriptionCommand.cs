using MediatR;

namespace Monhealth.Application.Features.Subscription.Commands.ChangeStatus
{
    public class ChangeStatusSubcriptionCommand : IRequest<bool>
    {
        public Guid SubcriptionId { get; set; }
    }
}
