using MediatR;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoodsByFoodType
{
    public class GetFoodDetailByFoodTypeQuery : IRequest<List<FoodDetailByFoodTypeDTO>>
    {
        public string foodType { get; set; }
        
    }
}