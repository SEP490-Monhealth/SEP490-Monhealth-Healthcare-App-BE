using MediatR;

namespace Monhealth.Application.Features.Meal.Commands.CreateMeal
{
    public class CreateMealCommand : IRequest<Guid>
    {
        public CreateMealDTO CreateMeal;
        public CreateMealCommand(CreateMealDTO createMealDTO)
        {
            CreateMeal = createMealDTO;
        }
    }
}