using MediatR;

namespace Monhealth.Application.Features.Meal.Commands.CreateMeal
{
    public class CreateMealCommand : IRequest<Unit>
    {
        public CreateMealDTO CreateMeal;
        public CreateMealCommand(CreateMealDTO createMealDTO)
        {
            CreateMeal = createMealDTO;
        }
    }
}