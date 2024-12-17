using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Nutrition.UpdateNutrition
{
    public class UpdateNutritionCommand : IRequest<bool>
    {
        public Guid NutritionId;
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Fiber { get; set; }
        public float Sugar { get; set; }

        public UpdateNutritionCommand(Guid nutritionId, UpdateNutritionRequest request)
        {
            NutritionId = nutritionId;
            Calories = request.Calories;
            Protein = request.Protein;
            Carbs = request.Carbs;
            Fat = request.Fat;
            Fiber = request.Fiber;
            Sugar = request.Sugar;
        }
    }
}