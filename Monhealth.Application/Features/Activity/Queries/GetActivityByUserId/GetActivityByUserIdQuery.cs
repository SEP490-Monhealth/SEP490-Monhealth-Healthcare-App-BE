using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Activity.Queries.GetActivityByUserId
{
    public class GetActivityByUserIdQuery : IRequest<List<GetActivityByUserIdDTO>>
    {
        public Guid UserId { get; set; }
        public GetActivityByUserIdQuery(Guid userId)
        {
            UserId = userId;
        }
    }
}
