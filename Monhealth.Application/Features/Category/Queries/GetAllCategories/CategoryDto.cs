using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Category.Queries.GetAllCategories
{
    public class CategoryDto : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string CategoryDescription { get; set; } = string.Empty;
        public string CategoryImage { get; set; } = string.Empty;
    }
}