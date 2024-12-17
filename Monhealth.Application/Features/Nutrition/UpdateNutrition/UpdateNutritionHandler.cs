using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

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
            if (nutrition == null) throw new Exception("Nutrition not found.");
            nutrition.Calories = request.Calories;
            nutrition.Carbs = request.Carbs;
            nutrition.DateModified = DateTime.Now;
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