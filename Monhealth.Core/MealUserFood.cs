using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class MealUserFood : BaseEntity
    {
        [Key]
        public Guid MealUserFoodId { get; set; }
        public Guid MealId { get; set; }
       
        public string PortionSize { get; set; }
        

        [ForeignKey(nameof(MealId))]
        public Meal Meal { get; set; }

    }
}
