using MediatR;
using Monhealth.Application.Features.Goals.Queries.GetAllGoalQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Goals.Queries.GetAllGoals
{
    public class GetAllGoalsListQuery : IRequest<List<GetAllGoalsDTO>>
    {
    }
}
