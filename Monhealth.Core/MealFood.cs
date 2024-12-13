using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class MealFood : BaseEntity
    {
        [Key]
        public Guid MealFoodId { get; set; }
        public Guid MealId { get; set; }
        public Guid FoodId { get; set; }
        public string PortionSize { get; set; } = string.Empty;
        [ForeignKey(nameof(FoodId))]
        public Food Food { get; set; }
        [ForeignKey(nameof(MealId))]
        public Meal Meal { get; set; }



    }
}
