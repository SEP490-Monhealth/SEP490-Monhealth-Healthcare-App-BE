using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class FoodPortion : BaseEntity
    {
        [Key]
        public Guid FoodPortionId { get; set; }
        public Guid FoodId { get; set; }
        public string PortionSize { get; set; } = string.Empty;
        public string PortionWeight { get; set; } = string.Empty;
        public string MeasurementUnit { get; set; } = string.Empty;

        [ForeignKey(nameof(FoodId))]
        public Food Food { get; set; }
    }
}
