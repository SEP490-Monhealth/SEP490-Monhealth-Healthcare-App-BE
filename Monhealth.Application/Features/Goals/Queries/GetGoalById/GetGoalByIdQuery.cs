using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Goals.Queries.GetGoalById
{
    public class GetGoalByIdQuery : IRequest<GetGoalByIdDTO>
    {
        public Guid GoalId { get; set; }
    }
}
