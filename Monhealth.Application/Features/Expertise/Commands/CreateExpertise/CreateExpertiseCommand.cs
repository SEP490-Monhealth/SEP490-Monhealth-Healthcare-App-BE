using MediatR;

namespace Monhealth.Application.Features.Expertise.Commands.CreateExpertise
{
    public class CreateExpertiseCommand : IRequest<Unit>
    {
        public CreateExpertiseDTO CreateExpertiseDTO { get; set; }
        public CreateExpertiseCommand(CreateExpertiseDTO createExpertiseDTO)
        {
            CreateExpertiseDTO = createExpertiseDTO;
        }
    }
}
