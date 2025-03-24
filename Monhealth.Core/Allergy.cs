using System.ComponentModel.DataAnnotations;
using Monhealth.Domain.Common;

namespace Monhealth.Domain
{
    public class Allergy : BaseEntity
    {
        [Key]
        public Guid AllergyId { get; set; }
        public string AllergyName { get; set; } = string.Empty;
        public string? AllergyDescription { get; set; } = string.Empty;

        public ICollection<UserAllergy> UserAllergies { get; set; }
        public ICollection<FoodAllergy> FoodAllergies { get; set; }
    }
}