using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain;
public class CategoryFood : TimeEntity
{
    public Guid CategoryFoodId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid FoodId { get; set; }

    [ForeignKey(nameof(CategoryId))]
    public Category Category { get; set; }
    [ForeignKey(nameof(FoodId))]
    public Food Food { get; set; }
}