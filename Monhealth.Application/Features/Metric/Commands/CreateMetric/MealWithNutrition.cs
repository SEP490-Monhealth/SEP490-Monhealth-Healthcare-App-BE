using MealClass = Monhealth.Domain.Meal;

namespace Monhealth.Application.Features.Metric.Commands.CreateMetric
{
    public class MealWithNutrition
    {
        public MealClass Meal { get; set; }
        public double TotalCalories { get; set; }
        public double TotalProteins { get; set; }
        public double TotalCarbs { get; set; }
        public double TotalFats { get; set; }
        public double TotalFibers { get; set; }
        public double TotalSugars { get; set; }
    }
}
