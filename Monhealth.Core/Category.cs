using Monhealth.Core;
using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Monhealth.Domain
{
    public class Category : BaseEntity
    {
        [Key]
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string CategoryDescription { get; set; } = string.Empty;

        public ICollection<FoodCategory> FoodCategories { get; set; } 

    }
}
