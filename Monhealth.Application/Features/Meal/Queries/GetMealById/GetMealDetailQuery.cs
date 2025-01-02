using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Meal.Queries.GetMealById
{
    public class GetMealDetailQuery : IRequest<MealDetailDTo>
    {
        public Guid MealId { get; set; }
    }
}