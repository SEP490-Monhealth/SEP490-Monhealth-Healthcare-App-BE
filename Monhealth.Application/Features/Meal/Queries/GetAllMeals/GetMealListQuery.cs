using MediatR;

namespace Monhealth.Application.Features.Meal.Queries.GetAllMeals
{
    public class GetMealListQuery : IRequest<List<MealDTO>>
    {

    }
}