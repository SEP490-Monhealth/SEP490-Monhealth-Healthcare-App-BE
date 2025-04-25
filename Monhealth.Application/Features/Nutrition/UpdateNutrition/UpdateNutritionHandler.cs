using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Nutrition.UpdateNutrition
{
    public class UpdateNutritionHandler : IRequestHandler<UpdateNutritionCommand, bool>
    {
        private readonly INutritionRepository _nutritionRepository;
        public UpdateNutritionHandler(INutritionRepository nutritionRepository)
        {
            _nutritionRepository = nutritionRepository;
        }

        public async Task<bool> Handle(UpdateNutritionCommand request, CancellationToken cancellationToken)
        {
            var nutrition = await _nutritionRepository.GetByIdAsync(request.NutritionId);
            if (nutrition == null) return false;
            nutrition.Calories = request.Calories;
            nutrition.Carbs = request.Carbs;
            nutrition.UpdatedAt = DateTime.UtcNow;
            nutrition.Fat = request.Fat;
            nutrition.Fiber = request.Fiber;
            nutrition.Sugar = request.Sugar;
            nutrition.Protein = request.Protein;
            _nutritionRepository.Update(nutrition);
            await _nutritionRepository.SaveChangeAsync();
            return true;
        }
    }
}