using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core;
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
            if (request.RequestData.FoodType != "User" && request.RequestData.FoodType != "Public")
            {
                throw new Exception("FoodType chỉ được phép là 'User' hoặc 'Public'.");
            }

            var food = await _foodRepository.GetByIdWithCategoriesAsync(request.FoodId);
            if (food == null)
                throw new Exception("Thức ăn không tồn tại.");
            var existingFood = await _foodRepository.GetFoodByNameAsync(request.RequestData.FoodName);
            if (existingFood != null) throw new Exception("Thức ăn đã tồn tại.");

            food.FoodName = request.RequestData.FoodName;
            food.FoodType = request.RequestData.FoodType;
            food.FoodDescription = request.RequestData.FoodDescription;
            food.UpdatedAt = DateTime.Now;
            _foodRepository.Update(food);

            var existingCategories = food.FoodCategories.ToList();
            foreach (var category in existingCategories)
            {
                food.FoodCategories.Remove(category);
            }

            // Thêm các danh mục mới
            foreach (var categoryName in request.RequestData.Category)
            {
                var category = await _categoryRepository.GetCategoryByCategoryName(categoryName);
                if (category == null)
                    throw new Exception($"Danh mục  không tồn tại.");

                food.FoodCategories.Add(new FoodCategory
                {
                    FoodId = food.FoodId,
                    CategoryId = category.CategoryId
                });
            }

            await _foodRepository.SaveChangesAsync();

            return true;
        }

    }
}