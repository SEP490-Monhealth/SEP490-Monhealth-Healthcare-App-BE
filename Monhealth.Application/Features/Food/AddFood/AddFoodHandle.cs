using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Food.AddFood
{
    public class AddFoodHandle : IRequestHandler<AddFoodRequest, bool>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly INutritionRepository _nutritionRepository;
        private readonly ICategoryFoodRepository _categoryFoodRepository;
        private readonly IDishTypeRepository _dishTypeRepository;
        public AddFoodHandle(IFoodRepository foodRepository,
        ICategoryRepository categoryRepository,
        IPortionRepository portionRepository,
        INutritionRepository nutritionRepository,
        ICategoryFoodRepository categoryFoodRepository,
        IDishTypeRepository dishTypeRepository)
        {
            _foodRepository = foodRepository;
            _categoryRepository = categoryRepository;
            _portionRepository = portionRepository;
            _nutritionRepository = nutritionRepository;
            _categoryFoodRepository = categoryFoodRepository;
            _dishTypeRepository = dishTypeRepository;
        }

        public async Task<bool> Handle(AddFoodRequest request, CancellationToken cancellationToken)
        {

            var existingFood = await _foodRepository.GetFoodByNameAsync(request.FoodName);
            if (existingFood != null) throw new Exception("Món ăn đã tồn tại. ");
            var category = await _categoryRepository.GetCategoryByCategoryName(request.Category);
            if (category == null)
                throw new Exception("Danh mục không tồn tại");
            List<DishType> dishTypes = await _dishTypeRepository
                .GetDishTypesByNames([.. request.DishType.Select(dt => dt.ToString())]);
            if (dishTypes.Count != request.DishType.Count)
            {
                // Dish Type is not fetched properly
                throw new Exception("");
            }
            Guid foodId = Guid.NewGuid();
            var food = new Monhealth.Domain.Food
            {
                UserId = request.UserId,
                FoodId = foodId,
                FoodName = request.FoodName,
                MealType = request.MealType,
                FoodDescription = request.FoodDescription,
                FoodPortions = new List<FoodPortion>(),
                Status = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                IsPublic = true,
                DishTypeFoods =
                    [.. dishTypes.Select(dt=>new DishTypeFood()
                    {
                        FoodId = foodId,
                        DishTypeFoodId = Guid.NewGuid(),
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        DishTypeId = dt.DishTypeId,
                    })],
            };
            var categoryFood = new CategoryFood
            {
                CategoryId = category.CategoryId,
                FoodId = foodId
            };
            _categoryFoodRepository.Add(categoryFood);
            _foodRepository.Add(food);
            await _foodRepository.SaveChangesAsync();
            var nutrition = new Monhealth.Domain.Nutrition
            {
                FoodId = food.FoodId,
                Calories = request.Nutrition.Calories,
                Carbs = request.Nutrition.Carbs,
                Fat = request.Nutrition.Fat,
                Fiber = request.Nutrition.Fiber,
                Protein = request.Nutrition.Protein,
                Sugar = request.Nutrition.Sugar,
                Calcium = request.Nutrition.Calcium,
                Cholesterol = request.Nutrition.Cholesterol,
                Iron = request.Nutrition.Iron,
                Potassium = request.Nutrition.Potassium,
                SaturatedFat = request.Nutrition.SaturatedFat,
                Sodium = request.Nutrition.Sodium,
                UnsaturatedFat = request.Nutrition.UnsaturatedFat,
                VitaminA = request.Nutrition.VitaminA,
                VitaminB1 = request.Nutrition.VitaminB1,
                VitaminB2 = request.Nutrition.VitaminB2,
                VitaminC = request.Nutrition.VitaminC,
                VitaminD = request.Nutrition.VitaminD,
                VitaminE = request.Nutrition.VitaminE,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _nutritionRepository.Add(nutrition);
            // Kiểm tra xem Portion đã tồn tại chưa
            var existingPortion = await _portionRepository.GetPortionAsync(
                request.Portion.MeasurementUnit,
                request.Portion.PortionSize,
                request.Portion.PortionWeight
            );

            Portion portion;
            if (existingPortion != null)
            {
                portion = existingPortion;
            }
            else
            {

                portion = new Portion
                {
                    PortionId = Guid.NewGuid(),
                    MeasurementUnit = request.Portion.MeasurementUnit,
                    PortionSize = request.Portion.PortionSize,
                    PortionWeight = request.Portion.PortionWeight,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                _portionRepository.Add(portion);
            }


            food.FoodPortions.Add(new FoodPortion
            {
                FoodId = food.FoodId,
                PortionId = portion.PortionId
            });

            await _foodRepository.SaveChangesAsync();
            return true;
        }


    }


}
