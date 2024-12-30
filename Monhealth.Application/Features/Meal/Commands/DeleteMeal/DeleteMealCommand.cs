using MediatR;

namespace Monhealth.Application.Features.Meal.Commands.DeleteMeal
{
    public class DeleteMealCommand : IRequest<bool>
    {
        public Guid MealId { get; set; }
        public DeleteMealCommand(Guid mealId)
        {
            MealId = mealId;
        }

    }
}