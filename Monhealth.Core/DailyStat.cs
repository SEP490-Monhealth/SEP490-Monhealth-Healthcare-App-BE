using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Monhealth.Domain
{
    public class DailyStat : BaseEntity
    {
        [Key]
        public Guid DailyStatId { get; set; }
        public Guid UserId { get; set; }
        public Guid MonthlyStatId { get; set; }
        public DateTime StartDate { get; set; }
        public float TotalCaloriesIntake { get; set; }
        public float TotalCaloriesBurned { get; set; }
        public float TotalWaterIntake { get; set; }
        public float TotalProteins { get; set; }
        public float TotalCarbs { get; set; }
        public float TotalFat { get; set; }

        public ICollection<DailyMeal> DailyMeals { get; set; }
    }
}
