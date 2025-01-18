using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Domain;
using Monhealth.Domain.Common;
namespace Monhealth.Core
{
    public class FoodAllergy : TimeEntity
    {
        [Key]
        public Guid FoodAllergyId { get; set; }
        public Guid FoodId { get; set; }
        [ForeignKey(nameof(FoodId))]
        public Food Food { get; set; }
        public Guid AllergyId { get; set; }
        [ForeignKey(nameof(AllergyId))]
        public Allergy Allergy { get; set; }
    }
}