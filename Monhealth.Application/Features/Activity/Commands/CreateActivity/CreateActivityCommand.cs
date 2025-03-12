using MediatR;

namespace Monhealth.Application.Features.Activity.Commands.CreateActivity
{
    public class CreateActivityCommand : IRequest<Unit>
    {
        public CreateActivityDTO CreateActivityDTO { get; set; }

        public CreateActivityCommand(CreateActivityDTO createActivityDTO)
        {
            CreateActivityDTO = createActivityDTO;
        }
    }
}