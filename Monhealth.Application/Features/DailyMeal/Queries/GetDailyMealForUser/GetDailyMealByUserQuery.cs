using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.DailyMeal.Queries.GetDailyMealForUser
{
    public class GetDailyMealByUserQuery : IRequest<List<GetDailyMealByUserDTO>>
    {
        public Guid UseId { get; set; }
    }
}