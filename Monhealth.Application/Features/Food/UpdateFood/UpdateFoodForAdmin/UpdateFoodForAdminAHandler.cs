using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Food.UpdateFood.UpdateFoodForAdmin
{
    public class UpdateFoodForAdminAHandler : IRequestHandler<UpdateFoodRequestAdminHandler, bool>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICategoryFoodRepository _categoryFoodRepository;

        public UpdateFoodForAdminAHandler(IFoodRepository foodRepository
        , ICategoryRepository categoryRepository,
        ICategoryFoodRepository categoryFoodRepository)
        {
            _foodRepository = foodRepository;
            _categoryRepository = categoryRepository;
            _categoryFoodRepository = categoryFoodRepository;

        }
        public async Task<bool> Handle(UpdateFoodRequestAdminHandler request, CancellationToken cancellationToken)
        {
            var food = await _foodRepository.GetFoodByIdAsync(request.FoodId);
            if (food == null) throw new Exception("Món ăn không tồn tại");
            var existingFood = await _foodRepository.GetFoodByNameAsync(request.RequestData.FoodName);
            if (existingFood != null) throw new Exception("Món ăn đã tồn tại");

            food.FoodName = request.RequestData.FoodName;
            food.FoodDescription = request.RequestData.FoodDescription;
            food.UpdatedAt = DateTime.Now;
            food.DishType = request.RequestData.DishType;
            food.MealType = request.RequestData.MealType;
            var categoryName = request.RequestData.Category;
            if (categoryName != null)
            {
                var category = await _categoryRepository.GetCategoryByCategoryName(categoryName);
                if (category == null)
                    throw new Exception($"Danh mục  không tồn tại");
                var categoryFood = await _categoryFoodRepository.GetByIdAsync(request.FoodId);
                if (categoryFood != null)
                {
                    categoryFood.CategoryId = category.CategoryId;
                }
            }

            await _foodRepository.SaveChangesAsync();

            return true;
        }
    }
}