using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Models;
using Monhealth.Application.ServiceForRecommend;
using Monhealth.Application.Services;



[ApiController]
[Route("api/v1/meal-suggestion")]
public class MealSuggestion : ControllerBase
{
    private readonly FoodFilterService _foodFilterService;
    private readonly GoalService _goalService;
    public MealSuggestion(
        FoodFilterService foodFilterService,
        GoalService goalService)
    {
        _foodFilterService = foodFilterService;
        _goalService = goalService;
    }
    [HttpGet]
    public async Task<IActionResult> GenerateDailyMenu(
    Guid userId,
    int pageNumber = 1,
    int pageSize = 10,
    [FromQuery] string? mealType = null,
    [FromQuery] string? dishType = null)
    {
        // Tách các giá trị từ chuỗi truyền vào (nếu có) thành danh sách
        var mealTypeList = !string.IsNullOrWhiteSpace(mealType)
            ? mealType.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim().ToLower()).ToList()
            : null;

        var dishTypeList = !string.IsNullOrWhiteSpace(dishType)
            ? dishType.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim().ToLower()).ToList()
            : null;

        // Gọi FoodFilterService với danh sách đã xử lý
        var foods = await _foodFilterService.GetFilterFoodAsync(userId, pageNumber, pageSize, mealTypeList, dishTypeList);

        return Ok(foods);
    }


    [HttpGet("user/{userId}/goal")]
    public async Task<ActionResult<ResultModel>> GetGoal(Guid userId)
    {
        // Gọi GoalService để lấy Goal từ repository
        var goal = await _goalService.GetMealAllocationByUserIdAsync(userId);

        return new ResultModel
        {
            Data = goal,
            Status = 200,
            Success = true,
        };
    }
}
