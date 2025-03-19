using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Domain.Common;

namespace Monhealth.Domain
{
    public class DishTypeFood : TimeEntity
    {
        public Guid DishTypeFoodId { get; set; }
        public Guid DishTypeId { get; set; }
        public Guid FoodId { get; set; }

        [ForeignKey(nameof(FoodId))]
        public Food Food { get; set; } = null!;
        [ForeignKey(nameof(DishTypeId))]
        public DishType DishType { get; set; } = null!;
    }
}