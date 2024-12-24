using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class FoodPortion
    {
        [Key]
        public Guid FoodPortionId { get; set; }
        public Guid FoodId { get; set; }
        public Guid PortionId { get; set; }
        [ForeignKey(nameof(FoodId))]
        public Food Food { get; set; }
        [ForeignKey(nameof(PortionId))]
        public Portion Portion { get; set; }
    }
}
