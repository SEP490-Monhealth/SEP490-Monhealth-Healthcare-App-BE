using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Goals.Commands.UpdateCommand
{
    public class UpdateGoalCommand : IRequest<bool>
    {
        public Guid GoalId { get; set; }
        public UpdateGoalDTO UpdateGoalDTO { get; set; }
        public UpdateGoalCommand(Guid goalId, UpdateGoalDTO updateGoalDTO)
        {
            GoalId = goalId;
            UpdateGoalDTO = updateGoalDTO;
        }
    }
}
