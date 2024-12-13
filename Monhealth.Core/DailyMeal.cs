using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class DailyMeal : BaseEntity
    {
        [Key]
        public Guid DailyMealId { get; set; }
        public Guid UserId { get; set; }
        public Guid ScheduleId { get; set; }
        public Guid DailyStatId { get; set; }
        public DateTime MealDate { get; set; }
        public float TotalCalories { get; set; }
        public float TotalCarbs { get; set; }
        public float TotalProteins { get; set; }
        public float TotalFats { get; set; }
        [ForeignKey(nameof(DailyStatId))]
        public DailyStat DailyStat { get; set; }
        public ICollection<Meal> Meals { get; set; }
    }
}
