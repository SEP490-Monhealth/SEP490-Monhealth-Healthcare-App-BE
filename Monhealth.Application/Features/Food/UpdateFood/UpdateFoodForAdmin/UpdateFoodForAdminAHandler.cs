using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity;

namespace Monhealth.Application.Features.Food.UpdateFood.UpdateFoodForAdmin
{
    public class UpdateFoodForAdminAHandler : IRequestHandler<UpdateFoodRequestAdminHandler, bool>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICategoryFoodRepository _categoryFoodRepository;
        private readonly IDishTypeRepository _dishTypeRepository;
        private readonly IDishTypeFoodRepository _dishTypeFoodRepository;
        public UpdateFoodForAdminAHandler(IFoodRepository foodRepository
        , ICategoryRepository categoryRepository,
        ICategoryFoodRepository categoryFoodRepository,
        IDishTypeRepository dishTypeRepository,
        IDishTypeFoodRepository dishTypeFoodRepository)
        {
            _foodRepository = foodRepository;
            _categoryRepository = categoryRepository;
            _categoryFoodRepository = categoryFoodRepository;
            _dishTypeRepository = dishTypeRepository;
            _dishTypeFoodRepository = dishTypeFoodRepository;

        }
        public async Task<bool> Handle(UpdateFoodRequestAdminHandler request, CancellationToken cancellationToken)
        {
            var food = await _foodRepository.GetFoodByIdAsync(request.FoodId);
            if (food == null) throw new Exception("Món ăn không tồn tại");
            var existingFood = await _foodRepository.GetFoodByNameAsync(request.RequestData.FoodName);
            if (existingFood != null) throw new Exception("Món ăn đã tồn tại");


            List<DishType> dishTypes = await _dishTypeRepository
                .GetDishTypesByNames([.. request.RequestData.DishType.Select(dt => dt.ToString())]);


            if (dishTypes.Count != request.RequestData.DishType.Count)
            {
                // Dish Type is not fetched properly
                throw new Exception("");
            }
            await _dishTypeRepository.DeleteDishTypeFoods(food.FoodId);
            food.FoodName = request.RequestData.FoodName;
            food.FoodDescription = request.RequestData.FoodDescription;
            food.UpdatedAt = DateTime.Now;
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
            _dishTypeFoodRepository.AddRange(dishTypes.Select(
                dt => new DishTypeFood
                {
                    FoodId = food.FoodId,
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dt.DishTypeId

                }
            ));
      

            await _foodRepository.SaveChangesAsync();

            return true;
        }
    }
}