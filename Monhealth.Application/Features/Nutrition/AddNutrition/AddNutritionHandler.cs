using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Nutrition.AddNutrition
{
    public class AddNutritionHandler : IRequestHandler<AddNutritionRequest, bool>
    {
        private readonly INutritionRepository _nutritionRepository;
        public AddNutritionHandler(INutritionRepository nutritionRepository)
        {
            _nutritionRepository = nutritionRepository;
        }

        public async Task<bool> Handle(AddNutritionRequest request, CancellationToken cancellationToken)
        {
            var model = new Monhealth.Domain.Nutrition
            {
                FoodId = request.FoodId,
                Calories = request.Calories,
                Carbs = request.Carbs,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Fat = request.Fat,
                Fiber = request.Fiber,
                Sugar = request.Sugar
            };
            _nutritionRepository.Add(model);
            await _nutritionRepository.SaveChangeAsync();
            return true;
        }
    }
}