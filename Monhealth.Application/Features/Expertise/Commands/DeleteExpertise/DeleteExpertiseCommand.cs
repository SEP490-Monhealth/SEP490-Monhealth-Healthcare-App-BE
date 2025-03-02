using MediatR;

namespace Monhealth.Application.Features.Expertise.Commands.DeleteExpertise
{
    public class DeleteExpertiseCommand : IRequest<bool>
    {
        public Guid ExpertiseId { get; set; }
    }
}
