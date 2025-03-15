using Monhealth.Domain.Common;

namespace Monhealth.Domain
{
    public class DishType : TimeEntity
    {
        public Guid DishTypeId { get; set; }
        public string DishTypeName { get; set; } = null!;

    }
}