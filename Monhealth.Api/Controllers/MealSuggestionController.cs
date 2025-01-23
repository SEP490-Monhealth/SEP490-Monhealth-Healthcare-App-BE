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
    public async Task<IActionResult> GenerateDailyMenu(Guid userId, int pageNumber = 1, int pageSize = 10)
    {
        var foods = await _foodFilterService.GetFilterFoodAsync(userId, pageNumber, pageSize);
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
