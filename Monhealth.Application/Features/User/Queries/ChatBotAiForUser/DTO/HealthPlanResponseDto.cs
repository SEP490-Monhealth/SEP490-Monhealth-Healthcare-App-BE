using System.Text.Json.Serialization;

namespace Monhealth.Application
{
    public class HealthPlanResponseDto
    {
        public MealPlanDto MealPlan { get; set; } = null!;
        public List<WorkoutStageDto>? WorkoutRoutine { get; set; }
        [JsonPropertyName("GeneralAdvice")]
        public string GeneralAdvice { get; set; } = string.Empty;

        [JsonPropertyName("SummaryConversation")]
        public string SummaryConversation { get; set; } = string.Empty;
        public bool health_or_fitness { get; set; }
    }
    public class MealPlanDto
    {
        public MealDToAI Meal { get; set; } = null!;
        public float TotalCalories { get; set; }
        public float TotalProtein { get; set; }
        public float TotalCarbs { get; set; }
        public float TotalFat { get; set; }
        public string Detail { get; set; } = string.Empty;
    }
    public class MealDToAI
    {
        public BreakfastDTO Breakfast { get; set; } = null!;
        public LunchDTO Lunch { get; set; } = null!;
        public DinnerDTO Dinner { get; set; } = null!;
        public SnackDTO Snack { get; set; } = null!;
    }

    public class WorkoutStageDto
    {
        public string Stage { get; set; } = string.Empty;
        public List<string> Exercises { get; set; } = [];
        public int Duration { get; set; }
    }
    public class BreakfastDTO
    {
        public List<FoodDtoAi> FoodItems { get; set; } = [];

    }
    public class LunchDTO
    {
        public List<FoodDtoAi> FoodItems { get; set; } = [];

    }
    public class DinnerDTO
    {
        public List<FoodDtoAi> FoodItems { get; set; } = [];
    }
    public class SnackDTO
    {
        public List<FoodDtoAi> FoodItems { get; set; } = new List<FoodDtoAi>();
    }
    public class FoodDtoAi
    {
        public Guid FoodId { get; set; }
        public string Name { get; set; } = string.Empty;
        public PortionDtoAi Portion { get; set; } = null!;
        public NutritionDtoAi Nutrition { get; set; } = null!;

    }
    public class PortionDtoAi
    {
        public string Size { get; set; } = string.Empty;
        public float Weight { get; set; }
        public string Unit { get; set; } = string.Empty;

    }
    public class NutritionDtoAi
    {
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }

    }
}