using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;
using Monhealth.Core.Enum;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoodsByUserId
{
    public class GetFoodsByUserHandler : IRequestHandler<GetFoodListByUserIdQuery, PageResult<FoodsByUserIdDTO>>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;

        public GetFoodsByUserHandler(IFoodRepository foodRepository,
        IMapper mapper)
        {
            _foodRepository = foodRepository;
            _mapper = mapper;
        }

        public async Task<PageResult<FoodsByUserIdDTO>> Handle(GetFoodListByUserIdQuery request, CancellationToken cancellationToken)
        {
            var paginatedFood = await _foodRepository.GetFoodByUserId(request.Page, request.Limit, request.UserId);
            var foodDtoList = paginatedFood.Items.Select(food => new FoodsByUserIdDTO
            {
                FoodId = food.FoodId,
                FoodName = food.FoodName,
                MealType = food.MealType, // Chuyển từ chuỗi sang danh sách
                FoodDescription = food.FoodDescription,
                Allergies = food.FoodAllergies?.Select(fa => fa.Allergy.AllergyName).ToList() ?? [],
                Category = food.CategoryFoods.Select(x => x.Category.CategoryName).FirstOrDefault() ?? null!, // Nếu có quan hệ với Category

                DishType = [..
                    food.DishTypeFoods?.Select(dtf => dtf.DishType.DishTypeName).ToList()
                    .Select(n=>(DishTypeEnum)Enum.Parse(typeof(DishTypeEnum),n)) ??[]
                    ],
                Portion = food.FoodPortions.Select(fp => new GetPortionForGetFoodByUserDTO
                {
                    PortionSize = fp.Portion.PortionSize,
                    PortionWeight = fp.Portion.PortionWeight,
                    MeasurementUnit = fp.Portion.MeasurementUnit
                }).FirstOrDefault() ?? null!,
                Nutrition = food.Nutrition != null
          ? new GetNutritionForGetFoodByUserDTO
          {
              Calories = food.Nutrition.Calories
          }
          : null!,
                Status = food.Status,
                IsPublic = food.IsPublic,
                CreatedAt = food.CreatedAt,
                UpdatedAt = food.UpdatedAt
            }).ToList();

            // Tạo kết quả phân trang
            return new PageResult<FoodsByUserIdDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(paginatedFood.TotalCount / (double)request.Limit),
                TotalItems = paginatedFood.TotalCount,
                Items = foodDtoList
            };
        }
    }
}