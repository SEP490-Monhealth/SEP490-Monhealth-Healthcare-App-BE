using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Services;

[ApiController]
[Route("api/v1/meal-suggestion")]
public class MealSuggestion : ControllerBase
{
    private readonly GenerateDailyMenuService _dailyMenuService;

    public MealSuggestion(
        GenerateDailyMenuService dailyMenuService)
    {
        _dailyMenuService = dailyMenuService;
    }

    [HttpGet]
    public async Task<IActionResult> GenerateDailyMenu(Guid userId, double tdee, string goal)
    {
        try
        {
            var dailyMeal = await _dailyMenuService.GenerateDailyMealAsync(userId, tdee, goal);
            return Ok(dailyMeal);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error: {ex.Message}");
        }
    }
}
