using MediatR;
using Monhealth.Application.Contracts.Persistence;


namespace Monhealth.Application.Features.Food.DeleteFood
{
    public class DeleteFoodHandler : IRequestHandler<DeleteFoodRequest, bool>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly INutritionRepository _nutritionRepository;

        public DeleteFoodHandler(IFoodRepository foodRepository,
        INutritionRepository nutritionRepository)
        {
            _foodRepository = foodRepository;
            _nutritionRepository = nutritionRepository;
        }

        public async Task<bool> Handle(DeleteFoodRequest request, CancellationToken cancellationToken)
        {
            var food = await _foodRepository.GetByIdAsync(request.FoodId);
            if (food == null) throw new Exception("Món ăn không tồn tại.");
            var nutritions = await _nutritionRepository.GetByFoodIdAsync(request.FoodId);
            if (nutritions.Any()) _nutritionRepository.RemoveRange(nutritions);
            _foodRepository.Remove(food);
            await _foodRepository.SaveChangesAsync();
            return true;
        }
    }
}