using System.Text.Json.Serialization;

namespace Monhealth.Application
{
    public class HealthPlanResponseDto
    {
        public MealPlanDto MealPlan { get; set; } = null!;
        public List<WorkoutStageDto>? WorkoutRoutine { get; set; }
        [JsonPropertyName("Tư vấn tổng quan từ AI")]
        public string TuVanTongQuanTuAI { get; set; } = string.Empty;

        [JsonPropertyName("Summary Conversation")]
        public string SummaryConversation { get; set; } = string.Empty;
        public bool health_or_fitness { get; set; }
    }
    public class MealPlanDto
    {
        public string Breakfast { get; set; } = string.Empty;
        public string Lunch { get; set; } = string.Empty;
        public string Dinner { get; set; } = string.Empty;
        public string? Snack { get; set; } = string.Empty;
        public int TotalCalories { get; set; }
        public string Detail { get; set; } = string.Empty;
    }

    public class WorkoutStageDto
    {
        public string Stage { get; set; } = string.Empty;
        public List<string> Exercises { get; set; } = [];
        public int Duration { get; set; }
    }
}