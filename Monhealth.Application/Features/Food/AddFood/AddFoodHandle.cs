using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Food.AddFood
{
    public class AddFoodHandle : IRequestHandler<AddFoodRequest, bool>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPortionRepository _portionRepository;
        public AddFoodHandle(IFoodRepository foodRepository,
        ICategoryRepository categoryRepository,
        IPortionRepository portionRepository)
        {
            _foodRepository = foodRepository;
            _categoryRepository = categoryRepository;
            _portionRepository = portionRepository;
        }

        public async Task<bool> Handle(AddFoodRequest request, CancellationToken cancellationToken)
        {
            // Tạo thực thể Food
            var food = new Monhealth.Domain.Food
            {
                UserId = request.UserId,
                FoodName = request.FoodName,
                FoodType = request.FoodType,
                FoodDescription = request.FoodDescription,
                FoodCategories = new List<FoodCategory>(),
                FoodPortions = new List<FoodPortion>(),
                Nutrition = new Monhealth.Domain.Nutrition
                {
                    Calories = request.Calories,
                    Carbs = request.Carbs,
                    Fat = request.Fat,
                    Fiber = request.Fiber,
                    Protein = request.Protein,
                    Sugar = request.Sugar,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                Status = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            // Xử lý danh mục (CategoryName)
            foreach (var categoryName in request.CategoryName)
            {
                var category = await _categoryRepository.GetCategoryByCategoryName(categoryName);
                if (category == null)
                {

                    return false;
                }

                food.FoodCategories.Add(new FoodCategory
                {
                    FoodId = food.FoodId,
                    CategoryId = category.CategoryId
                });
            }

            var portion = new Portion
            {
                PortionId = Guid.NewGuid(),
                MeasurementUnit = request.MeasurementUnit,
                PortionSize = request.PortionSize,
                PortionWeight = request.PortionWeight,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _portionRepository.Add(portion); // Thêm Portion vào DB

            food.FoodPortions.Add(new FoodPortion
            {
                FoodId = food.FoodId,
                PortionId = portion.PortionId
            });
            _foodRepository.Add(food);
            await _foodRepository.SaveChangesAsync();
            return true;
        }


    }


}
