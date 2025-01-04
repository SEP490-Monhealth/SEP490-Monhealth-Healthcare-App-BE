using MediatR;

namespace Monhealth.Application.Features.MealFood.Commands.UpdateMealFood
{
    public class MealFoodCommand : IRequest<bool>
    {
        public Guid MealFoodId { get; set; }
        public int Quantity { get; set; }
        public MealFoodCommand(Guid mealFoodId, int quantity)
        {
            MealFoodId = mealFoodId;
            Quantity = quantity;
        }
    }
}