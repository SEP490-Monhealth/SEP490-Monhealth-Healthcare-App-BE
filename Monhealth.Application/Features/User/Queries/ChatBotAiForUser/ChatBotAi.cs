namespace Monhealth.Application
{
    public class ChatBotAi
    {
        public string UserName { get; set; } = string.Empty;
        public MetricDTO12 Metric { get; set; } = new MetricDTO12();
        public IEnumerable<FoodDTO12> Foods { get; set; }
        public WorkoutDTO12 Workouts { get; set; }
    }
    public class MetricDTO12
    {
        public float Height { get; set; }
        public float Weight { get; set; }
        public float Bmi { get; set; }
        public float Bmr { get; set; }
        public float Tdee { get; set; }
        public float Ibw { get; set; }
    }
    public class FoodDTO12
    {
        public List<string> FoodName { get; set; }
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
    }
   
    public class WorkoutDTO12
    {
        public List<string> WorkoutName { get; set; }
    }
}