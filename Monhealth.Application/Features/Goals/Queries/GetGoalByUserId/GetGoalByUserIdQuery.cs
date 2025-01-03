using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Goals.Queries.GetGoalByUserId
{
    public class GetGoalByUserIdQuery : IRequest<List<GetGoalByUserIdDTO>>
    {
        public Guid UserId { get; set; }
    }
}
