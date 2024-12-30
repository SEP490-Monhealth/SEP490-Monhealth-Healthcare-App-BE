using MediatR;

namespace Monhealth.Application.Features.MealFood.Queries
{
    public class GetMealFoodByMealIdQuery : IRequest<List<GetMealFoodByMealIdDTO>>
    {
        public Guid MealId { get; set; }
    }
}