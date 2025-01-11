using MediatR;


namespace Monhealth.Application.Features.Goals.Commands.CreateCommand
{
    public class CreateGoalCommand : IRequest<Unit>
    {
        public CreateGoalDTO CreateGoalDTO { get; set; }
        public CreateGoalCommand(CreateGoalDTO createGoalDTO)
        {
            CreateGoalDTO = createGoalDTO;
        }
    }
}
