using Monhealth.Domain.Common;

namespace Monhealth.Domain
{
    public class DishType : BaseEntity
    {   
        public Guid DishTypeId { get; set; }
        public string DishTypeName { get; set; } = null!;
        public ICollection<DishTypeFood> DishTypeFoods { get; set; } = [];
    }
}