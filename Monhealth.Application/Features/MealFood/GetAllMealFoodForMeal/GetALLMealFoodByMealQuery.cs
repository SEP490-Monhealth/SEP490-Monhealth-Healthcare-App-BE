
using MediatR;

namespace Monhealth.Application.Features.MealFood.GetAllMealFoodForMeal
{
    public class GetALLMealFoodByMealQuery :  IRequest<List<GetALLMealFoodByMealDTO>>
    {
        public Guid MealId { get; set; }
    }
}