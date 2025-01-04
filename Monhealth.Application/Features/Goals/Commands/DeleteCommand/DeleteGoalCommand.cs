using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Goals.Commands.DeleteCommand
{
    public class DeleteGoalCommand : IRequest<bool>
    {
        public Guid GoalId { get; set; }
    }
}
