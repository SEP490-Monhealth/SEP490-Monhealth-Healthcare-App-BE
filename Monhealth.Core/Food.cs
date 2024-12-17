using Monhealth.Core;
using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Food : BaseEntity
    {
        [Key]
        public Guid FoodId { get; set; }
        
        public string FoodName { get; set; } = string.Empty;

        public Nutrition Nutrition { get; set; } //one to one 

        public ICollection<FoodCategory> FoodCategories { get; set; }

        public ICollection<FoodPortion> FoodPortions { get; set; }

        public ICollection<MealFood> MealFoods { get; set; }

    }
}
