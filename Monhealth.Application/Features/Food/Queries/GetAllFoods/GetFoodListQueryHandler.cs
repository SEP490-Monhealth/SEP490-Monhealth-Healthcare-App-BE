using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;
using Monhealth.Core.Enum;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoods
{
    public class GetFoodListQueryHandler : IRequestHandler<GetFoodListQuery, PageResult<FoodDTO>>
    {
        private readonly IFoodRepository _foodRepository;
        public GetFoodListQueryHandler(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public async Task<PageResult<FoodDTO>> Handle(GetFoodListQuery request, CancellationToken cancellationToken)
        {
            var paginatedFood = await _foodRepository.GetAllFoodAsync
            (request.Page, request.Limit, request.Search, request.Status, request.CategoryName, request.Popular, request.IsPublic);
            var foodDtoList = paginatedFood.Items.Select(food => new FoodDTO
            {
                FoodId = food.FoodId,
                UserId = food.UserId,
                FoodName = food.FoodName,
                MealType = food.MealType, // Chuyển từ chuỗi sang danh sách
                FoodDescription = food.FoodDescription,
                ReferenceUrl = food.ReferenceUrl,
                Allergies = food.FoodAllergies?
               .Where(f => f.Allergy != null)
               .Select(f => f.Allergy.AllergyName).ToList() ?? [],

                DishType = [..
                    food.DishTypeFoods?.Select(dtf => dtf.DishType.DishTypeName).ToList()
                    .Select(n=>(DishTypeEnum)Enum.Parse(typeof(DishTypeEnum),n)) ??[]
                    ],
                Category = food.CategoryFoods.Select(x => x.Category.CategoryName).FirstOrDefault() ?? "", // Nếu có quan hệ với Category
                Portion = food.FoodPortions.Select(fp => new GetPortionForGetAllFoodDTO
                {
                    PortionSize = fp.Portion.PortionSize,
                    PortionWeight = fp.Portion.PortionWeight,
                    MeasurementUnit = fp.Portion.MeasurementUnit
                }).FirstOrDefault() ?? null!,
                Nutrition = food.Nutrition != null
         ? new GetNutritionForGetAllFoodDTO
         {
             Calories = food.Nutrition.Calories
         }
         : null!,
                Status = food.Status,
                IsPublic = food.IsPublic,
                CreatedAt = food.CreatedAt,
                UpdatedAt = food.UpdatedAt,
                UpdatedBy = food.UpdatedBy,
                CreatedBy = food.CreatedBy
            }).ToList();

            // Tạo kết quả phân trang
            return new PageResult<FoodDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(paginatedFood.TotalCount / (double)request.Limit),
                TotalItems = paginatedFood.TotalCount,
                Items = foodDtoList
            };
        }
    }
}