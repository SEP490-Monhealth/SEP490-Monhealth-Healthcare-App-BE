using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Models;
using Monhealth.Application.ServiceForRecommend;
using Monhealth.Application.Services;

[ApiController]
[Route("api/v1/meal-suggestions")]
public class MealSuggestion : ControllerBase
{
    private readonly FoodFilterService _foodFilterService;
    private readonly GoalService _goalService;
    private readonly FoodRandomService _foodRandomService;
    public MealSuggestion(
        FoodFilterService foodFilterService,
        GoalService goalService,
        FoodRandomService foodRandomService)
    {
        _foodFilterService = foodFilterService;
        _goalService = goalService;
        _foodRandomService = foodRandomService;
    }
    [HttpGet]
    [Route("{userId:guid}")]
    public async Task<IActionResult> GenerateDailyMenu(
    [Required] Guid userId,
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
    // [HttpGet("user/{userId}/random-meal")]
    // public async Task<ActionResult<ResultModel>> GetRandomMealPlan(Guid userId)
    // {
    //     var randomMealPlan = await _foodRandomService.GetMealPlanWithAllocationAsync(userId);

    //     if (randomMealPlan == null)
    //     {
    //         return NotFound(new { Message = "Could not generate a random meal plan for the user." });
    //     }

    //     return new ResultModel
    //     {
    //         Data = randomMealPlan,
    //         Status = 200,
    //         Success = true
    //     };
    // }
}
