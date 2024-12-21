using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Nutrition : BaseEntity
    {
        [Key]
        public Guid NutritionId { get; set; }
        public Guid? FoodId { get; set; }
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Fiber { get; set; }
        public float Sugar { get; set; }

        [ForeignKey(nameof(FoodId))]
        public Food Food { get; set; }

       
    }
}
