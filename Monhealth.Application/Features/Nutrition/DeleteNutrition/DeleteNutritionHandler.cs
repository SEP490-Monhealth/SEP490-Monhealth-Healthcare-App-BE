using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Nutrition.DeleteNutrition
{
    public class DeleteNutritionHandler : IRequestHandler<DeleteNutritionRequest, bool>
    {
        private readonly INutritionRepository _nutritionRepository;

        public DeleteNutritionHandler(INutritionRepository nutritionRepository)
        {
            _nutritionRepository = nutritionRepository;
        }

        public async Task<bool> Handle(DeleteNutritionRequest request, CancellationToken cancellationToken)
        {
            var nutrition = await _nutritionRepository.GetByIdAsync(request.NutritionId);
            if (nutrition == null) return false;
            _nutritionRepository.Remove(nutrition);
            await _nutritionRepository.SaveChangeAsync();
            return true;
        }
    }
}