using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Monhealth.Domain;

namespace Monhealth.Core
{
    public class FoodCategory
    {
        [Key]
        public Guid FoodCategoryId { get; set; }
        [ForeignKey(nameof(FoodId))]
        public Guid FoodId { get; set; }
        public Food Food { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}