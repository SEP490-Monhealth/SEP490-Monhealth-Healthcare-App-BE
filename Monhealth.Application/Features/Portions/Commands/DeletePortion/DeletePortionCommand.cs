using MediatR;

namespace Monhealth.Application.Features.Portions.Commands.DeletePortion
{
    public class DeletePortionCommand : IRequest<bool>
    {
        public Guid PortionId { get; set; }
    }
}
