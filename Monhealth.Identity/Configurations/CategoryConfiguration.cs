using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var categoryList = new List<Category>();

            // Sinh 1000 records tự động
            for (int i = 1; i <= 1000; i++)
            {
                categoryList.Add(new Category
                {
                    CategoryId = Guid.NewGuid(),
                    CategoryName = $"Category {i}", // Tên động
                    CategoryDescription = $"Description for Category {i}", // Mô tả động
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
            }

            // Seed dữ liệu vào bảng Category
            builder.HasData(categoryList);
        }
    }
}