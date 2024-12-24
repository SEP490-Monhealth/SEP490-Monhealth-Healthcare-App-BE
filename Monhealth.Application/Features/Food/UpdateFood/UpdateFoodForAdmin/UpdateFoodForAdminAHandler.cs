using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Food.UpdateFood.UpdateFoodForAdmin
{
    public class UpdateFoodForAdminAHandler : IRequestHandler<UpdateFoodRequestAdminHandler, bool>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly INutritionRepository _nutritionRepository;
        private readonly IPortionRepository _portionRepository;

        public UpdateFoodForAdminAHandler(IFoodRepository foodRepository
        , ICategoryRepository categoryRepository,
        INutritionRepository nutritionRepository,
        IPortionRepository portionRepository)
        {
            _foodRepository = foodRepository;
            _categoryRepository = categoryRepository;
            _nutritionRepository = nutritionRepository;
            _portionRepository = portionRepository;
        }
        public async Task<bool> Handle(UpdateFoodRequestAdminHandler request, CancellationToken cancellationToken)
        {
         

            var food = await _foodRepository.GetFoodByIdAsync(request.FoodId);
            if (food == null) throw new Exception("Món ăn không tồn tại.");
            var existingFood = await _foodRepository.GetFoodByNameAsync(request.RequestData.FoodName);
            if (existingFood != null) throw new Exception("Món ăn đã tồn tại.");

            food.FoodName = request.RequestData.FoodName;
            food.FoodDescription = request.RequestData.FoodDescription;
            food.UpdatedAt = DateTime.Now;
            food.CategoryId = null;
            var categoryName = request.RequestData.Category; 
            if (categoryName != null)
            {
                var category = await _categoryRepository.GetCategoryByCategoryName(categoryName);
                if (category == null)
                    throw new Exception($"Danh mục  không tồn tại.");

                food.CategoryId = category.CategoryId; // Gán danh mục mới
            }

            await _foodRepository.SaveChangesAsync();

            return true;
        }

    }
}