using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
