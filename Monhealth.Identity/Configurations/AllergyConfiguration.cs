using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Core;

namespace Monhealth.Identity.Configurations
{
    public class AllergyConfiguration : IEntityTypeConfiguration<Allergy>
    {
        public void Configure(EntityTypeBuilder<Allergy> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            new Allergy
            {
                AllergyId = Guid.NewGuid(),
                AllergyName = "Hải sản",
                AllergyDescription = "Dị ứng với hải sản như tôm, cua, sò, ốc, và các loại động vật biển khác.",
                CreatedAt = today,
                UpdatedAt = today,
            },

            new Allergy
            {
                AllergyId = Guid.NewGuid(),
                AllergyName = "Lúa mì",
                AllergyDescription = "Dị ứng với lúa mì, thường gặp ở những người không dung nạp gluten.",
                CreatedAt = today,
                UpdatedAt = today,
            },

            new Allergy
            {
                AllergyId = Guid.NewGuid(),
                AllergyName = "Đậu phộng",
                AllergyDescription = "Dị ứng với đậu phộng, một trong những nguyên nhân phổ biến nhất gây phản ứng dị ứng nghiêm trọng.",
                CreatedAt = today,
                UpdatedAt = today,
            },

            new Allergy
            {
                AllergyId = Guid.NewGuid(),
                AllergyName = "Sữa bò",
                AllergyDescription = "Dị ứng với protein trong sữa bò, khác với không dung nạp lactose.",
                CreatedAt = today,
                UpdatedAt = today,
            },

            new Allergy
            {
                AllergyId = Guid.NewGuid(),
                AllergyName = "Trứng",
                AllergyDescription = "Dị ứng với trứng gà hoặc trứng của các loài gia cầm khác.",
                CreatedAt = today,
                UpdatedAt = today,
            },

            new Allergy
            {
                AllergyId = Guid.NewGuid(),
                AllergyName = "Hạt cây",
                AllergyDescription = "Dị ứng với các loại hạt cây như hạt óc chó, hạt hạnh nhân, và hạt điều.",
                CreatedAt = today,
                UpdatedAt = today,
            },

            new Allergy
            {
                AllergyId = Guid.NewGuid(),
                AllergyName = "Đậu nành",
                AllergyDescription = "Dị ứng với đậu nành, thường gặp ở trẻ em nhưng cũng có thể xảy ra ở người lớn.",
                CreatedAt = today,
                UpdatedAt = today,
            },

            new Allergy
            {
                AllergyId = Guid.NewGuid(),
                AllergyName = "Vừng (mè)",
                AllergyDescription = "Dị ứng với hạt vừng(mè), thường gặp trong các món ăn châu Á và Trung Đông.",
                CreatedAt = today,
                UpdatedAt = today,
            },

            new Allergy
            {
                AllergyId = Guid.NewGuid(),
                AllergyName = "Cá",
                AllergyDescription = "Dị ứng với cá, bao gồm cả cá biển và cá nước ngọt.",
                CreatedAt = today,
                UpdatedAt = today,
            },

            new Allergy
            {
                AllergyId = Guid.NewGuid(),
                AllergyName = "Động vật có vỏ",
                AllergyDescription = "Dị ứng với các loại động vật có vỏ như tôm, cua, và sò.",
                CreatedAt = today,
                UpdatedAt = today,
            });
        }

    }
}