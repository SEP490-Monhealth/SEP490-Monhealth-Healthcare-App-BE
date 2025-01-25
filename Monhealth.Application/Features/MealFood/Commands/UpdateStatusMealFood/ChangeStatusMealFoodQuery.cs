using MediatR;

namespace Monhealth.Application.Features.MealFood.Commands.UpdateStatusMealFood
{
    public class ChangeStatusMealFoodQuery : IRequest<bool>
    {
        public Guid MealFoodId { get; set; }
    }
}