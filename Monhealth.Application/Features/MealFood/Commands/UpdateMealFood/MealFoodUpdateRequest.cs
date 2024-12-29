using MediatR;


namespace Monhealth.Application.Features.MealFood.Commands.UpdateMealFood
{
    public class MealFoodUpdateRequest : IRequest<bool>
    {
        public int Quantity { get; set; }
    }
}