using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Food.UpdateFood.UpdateFoodForUser
{
    public class UpdateFoodForUserHandler : IRequestHandler<UpdateFoodRequestUserHandler, bool>
    {
        private readonly IFoodRepository _foodRepository;
        public UpdateFoodForUserHandler(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public async Task<bool> Handle(UpdateFoodRequestUserHandler request, CancellationToken cancellationToken)
        {
            var food = await _foodRepository.GetFoodByIdAsync(request.FoodId);
            if (food == null) throw new Exception("Món ăn không tồn tại");
            var existingFood = await _foodRepository.GetFoodByNameAsync(request.RequestData.FoodName);
            if (existingFood != null) throw new Exception("Món ăn đã tồn tại");
            food.DishType = request.RequestData.DishType;
            food.MealType = request.RequestData.MealType;
            food.FoodType = request.RequestData.FoodType;
            food.FoodName = request.RequestData.FoodName;
            food.FoodDescription = request.RequestData.FoodDescription;
            food.UpdatedAt = DateTime.Now;
            food.IsPublic = request.RequestData.IsPublic;
            await _foodRepository.SaveChangesAsync();

            return true;
        }
    }
}