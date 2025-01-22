using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.ServiceForRecommend;


[ApiController]
[Route("api/v1/meal-suggestion")]
public class MealSuggestion : ControllerBase
{
    private readonly FoodFilterService _foodFilterService;

    public MealSuggestion(
        FoodFilterService foodFilterService)
    {
        _foodFilterService = foodFilterService;
    }
    [HttpGet]
    public async Task<IActionResult> GenerateDailyMenu(Guid userId, int pageNumber = 1, int pageSize = 10)
    {
        var foods = await _foodFilterService.GetFilterFoodAsync(userId, pageNumber, pageSize);
        return Ok(foods);

    }

}
