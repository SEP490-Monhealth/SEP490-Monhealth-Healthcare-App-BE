using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Meal.Queries.GetAllMeals
{
    public class GetMealListQuery : IRequest<List<MealDTO>>
    {
         
    }
}