using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.DailyActivity.Queries.GetDailyActivityByUserId
{
    public class GetDailyActivityByUserIdQuery : IRequest<GetDailyActivityByUserIdDTO>
    {
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public GetDailyActivityByUserIdQuery(Guid userId, DateTime date)
        {
            UserId = userId;
            Date = date;
        }
    }
}
