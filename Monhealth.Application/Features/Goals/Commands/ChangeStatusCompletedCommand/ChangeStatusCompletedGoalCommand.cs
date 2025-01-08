using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Goals.Commands.ChangeStatusCompletedCommand
{
    public class ChangeStatusCompletedGoalCommand : IRequest<bool>
    {
        public Guid GoalId { get; set; }
    }
}
