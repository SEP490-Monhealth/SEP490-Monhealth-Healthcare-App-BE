using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class InterestFood : BaseEntity
    {
        [Key]
        public Guid InterestFoodId { get; set; }
        public Guid UserId { get; set; }
        public string Categories { get; set; }
        public string Foods { get; set; }
        public string Nutrition { get; set; }
        public string Allergies { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
    }
}
