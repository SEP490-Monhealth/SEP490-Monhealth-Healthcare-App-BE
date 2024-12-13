using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Monhealth.Domain
{
    public class UserFood : BaseEntity
    {
        [Key]
        public Guid UserFoodId { get; set; }
        public Guid UserId { get; set; }
        public string FoodName { get; set; } = string.Empty;
        public string PortionSize { get; set; } = string.Empty;
        public float PortionWeight { get; set; }
        public string MeasurementUnit { get; set; } = string.Empty;


        public Nutrition Nutrition { get; set; } //one to one 

        public ICollection<MealUserFood> MealUserFoods { get; set; }

    }
}
