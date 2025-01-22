using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

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
                DishType = food.DishType, // Chuyển từ chuỗi sang danh sách
                FoodDescription = food.FoodDescription,
                Category = food.Category?.CategoryName, // Nếu có quan hệ với Category
                Portion = food.FoodPortions.Select(fp => new GetPortionForGetFoodByUserDTO
                {
                    PortionSize = fp.Portion.PortionSize,
                    PortionWeight = fp.Portion.PortionWeight,
                    MeasurementUnit = fp.Portion.MeasurementUnit
                }).FirstOrDefault(),
                Nutrition = food.Nutrition != null
          ? new GetNutritionForGetFoodByUserDTO
          {
              Calories = food.Nutrition.Calories
          }
          : null,
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