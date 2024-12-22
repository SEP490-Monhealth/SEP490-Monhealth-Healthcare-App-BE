using MediatR;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoods
{
    public class GetFoodListQuery : IRequest<List<FoodDTO>>
    {
        
    }
}