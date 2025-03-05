using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class MealFood : TimeEntity
    {
        [Key]
        public Guid MealFoodId { get; set; }
        public Guid MealId { get; set; }
        public Guid FoodId { get; set; }
        public Guid PortionId { get; set; }
        public int Quantity { get; set; }
        public bool IsRecommended { get; set; }
        public bool IsCompleted { get; set; }

        [ForeignKey(nameof(FoodId))]
        public Food Food { get; set; }
        [ForeignKey(nameof(MealId))]
        public Meal Meal { get; set; }
    }
}
