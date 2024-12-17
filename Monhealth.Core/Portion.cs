using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Portion : BaseEntity
    {
        [Key]
        public Guid PortionId { get; set; }
        public string PortionSize { get; set; } = string.Empty;
        public string PortionWeight { get; set; } = string.Empty;
        public string MeasurementUnit { get; set; } = string.Empty;
        public ICollection<FoodPortion> FoodPortions { get; set; }
    }
}
