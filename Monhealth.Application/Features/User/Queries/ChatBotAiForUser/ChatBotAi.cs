namespace Monhealth.Application
{
    public class ChatBotAi
    {
        public string UserName { get; set; } = string.Empty;
        public MetricDTO12 Metric { get; set; } = new MetricDTO12();
        public GoalDTO12 Goal { get; set; }
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
    public class GoalDTO12
    {
        public float WeightGoal { get; set; }
        public float CaloriesRatio { get; set; }
        public float CaloriesGoal { get; set; }
        public float ProteinGoal { get; set; }
        public float CarbsGoal { get; set; }
        public float FatGoal { get; set; }
        public float FiberGoal { get; set; }
        public float SugarGoal { get; set; }
        public float WorkoutDurationGoal { get; set; }
        public float CaloriesBurnedGoal { get; set; }

    }
    public class FoodDTO12
    {
        public List<Guid> FoodId { get; set; }
        public List<string> FoodName { get; set; }
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
    }

    public class WorkoutDTO12
    {
        public List<WorkoutDTOItem> Workouts { get; set; }
    }
    public class WorkoutDTOItem
    {
        public Guid WorkoutId { get; set; }       // hoặc kiểu dữ liệu phù hợp
        public string WorkoutName { get; set; }
    }
}