using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Meal : TimeEntity
    {
        [Key]
        public Guid MealId { get; set; }
        public Guid? DailyMealId { get; set; }
        public Guid UserId { get; set; }
        public string MealType { get; set; } = string.Empty;
        [ForeignKey(nameof(DailyMealId))]
        public DailyMeal DailyMeal { get; set; }
        public ICollection<MealFood> MealFoods { get; set; }
    }
}
