using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class UserFood : BaseEntity
    {
        [Key]
        public Guid FoodId { get; set; }
        public Guid UserId { get; set; }
        public string FoodName { get; set; } = string.Empty;
        public string PortionSize { get; set; } = string.Empty;
        public float PortionWeight { get; set; }
        public string MeasurementUnit { get; set; } = string.Empty;


        public Nutrition Nutrition { get; set; } //one to one 
        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        public ICollection<MealUserFood> MealUserFoods { get; set; }

    }
}
