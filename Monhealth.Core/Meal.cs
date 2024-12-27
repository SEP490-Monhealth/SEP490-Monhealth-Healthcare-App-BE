using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Meal : BaseEntity
    {
        [Key]
        public Guid MealId { get; set; }
        public Guid? DailyMealId { get; set; }
        public Guid UserId { get; set; }
        public string MealType { get; set; } = string.Empty;
        [ForeignKey(nameof(DailyMealId))]
        public DailyMeal DailyMeal { get; set; }
        public ICollection<MealFood> MealFoods { get; set; }
        public ICollection<MealUserFood> MealUserFoods { get; set; }

    }
}
