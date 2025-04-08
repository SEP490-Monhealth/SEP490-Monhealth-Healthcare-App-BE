using System.Text.Json.Serialization;

namespace Monhealth.Application
{
    public class HealthPlanResponseDto
    {
        public MealPlanDto MealPlan { get; set; } = null!;
        public List<WorkoutStageDto>? WorkoutRoutine { get; set; }
        [JsonPropertyName("generalAdvice")]
        public string GeneralAdvice { get; set; } = string.Empty;

        [JsonPropertyName("summaryConversation")]
        public string SummaryConversation { get; set; } = string.Empty;
        [JsonPropertyName("isHealthOrFitness")]
        public bool health_or_fitness { get; set; }
    }
    public class MealPlanDto
    {
        public MealDToAI Meal { get; set; } = null!;
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
        public Guid WorkoutId { get; set; }
        public string Stage { get; set; } = string.Empty;
        public List<ExerciseDToAi> Exercises { get; set; } = [];
    }
    public class BreakfastDTO
    {
        public List<FoodDtoAi> Items { get; set; } = [];

    }
    public class LunchDTO
    {
        public List<FoodDtoAi> Items { get; set; } = [];

    }
    public class DinnerDTO
    {
        public List<FoodDtoAi> Items { get; set; } = [];
    }
    public class SnackDTO
    {
        public List<FoodDtoAi> Items { get; set; } = new List<FoodDtoAi>();
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
    public class ExerciseDToAi
    {
        public string Name { get; set; } = string.Empty;
        public int Sets { get; set; }
        public int Reps { get; set; }
        public int Rest { get; set; }
        public int Duration { get; set; }
    }
}