using Monhealth.Core;
using Monhealth.Core.Enum;
using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Monhealth.Domain
{
        public class Category : TimeEntity
        {
                [Key]
                public Guid CategoryId { get; set; }
                public CategoryType CategoryType { get; set; }
                public string CategoryName { get; set; } = string.Empty;
                public string? CategoryDescription { get; set; } = string.Empty;
                public string? ImageUrl { get; set; } = string.Empty;

                public ICollection<CategoryFood> CategoryFoods { get; set; } = [];
                public ICollection<Workout> Workouts { get; set; } = [];
                public ICollection<UserCategory> UserCategories { get; set; } = [];
        }
}
