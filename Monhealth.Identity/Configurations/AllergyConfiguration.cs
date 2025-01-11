using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Core;

namespace Monhealth.Identity.Configurations
{
    public class AllergyConfiguration : IEntityTypeConfiguration<Allergy>
    {
        public void Configure(EntityTypeBuilder<Allergy> builder)
        {
            builder.HasData(
                new Allergy
                {
                    AllergyId = Guid.Parse("b8f6417e-2aac-442e-aac4-de4d809c572c"),
                    AllergyName = "Hải sản",
                    AllergyDescription = "Dị ứng với hải sản như tôm, cua, sò, ốc, và các loại động vật biển khác."
                },
                new Allergy
                {
                    AllergyId = Guid.Parse("16acfb07-feee-4bb9-ad2b-05e5b93d18e6"),
                    AllergyName = "Lúa mì",
                    AllergyDescription = "Dị ứng với lúa mì, thường gặp ở những người không dung nạp gluten."
                },
                new Allergy
                {
                    AllergyId = Guid.Parse("b82f4697-2ad0-4777-a29b-094c99f46d10"),
                    AllergyName = "Đậu phộng",
                    AllergyDescription = "Dị ứng với đậu phộng, một trong những nguyên nhân phổ biến nhất gây phản ứng dị ứng nghiêm trọng."
                },
                new Allergy
                {
                    AllergyId = Guid.Parse("d0127ea2-7f55-4515-b5ea-3db55af5774e"),
                    AllergyName = "Sữa bò",
                    AllergyDescription = "Dị ứng với protein trong sữa bò, khác với không dung nạp lactose."
                },
                new Allergy
                {
                    AllergyId = Guid.Parse("70fef89b-5b02-4d6c-81e0-40592eefcb2a"),
                    AllergyName = "Trứng",
                    AllergyDescription = "Dị ứng với trứng gà hoặc trứng của các loài gia cầm khác."
                },
                new Allergy
                {
                    AllergyId = Guid.Parse("13008773-dadd-4053-b64c-500b6050b2aa"),
                    AllergyName = "Hạt cây",
                    AllergyDescription = "Dị ứng với các loại hạt cây như hạt óc chó, hạt hạnh nhân, và hạt điều."
                },
                new Allergy
                {
                    AllergyId = Guid.Parse("3cd5347e-d38d-425c-af19-e9c4ba2646c6"),
                    AllergyName = "Đậu nành",
                    AllergyDescription = "Dị ứng với đậu nành, thường gặp ở trẻ em nhưng cũng có thể xảy ra ở người lớn."
                },
                new Allergy
                {
                    AllergyId = Guid.Parse("10127b02-786f-462b-8ee6-3df465903645"),
                    AllergyName = "Vừng(mè)",
                    AllergyDescription = "Dị ứng với hạt vừng(mè), thường gặp trong các món ăn châu Á và Trung Đông."
                },
                new Allergy
                {
                    AllergyId = Guid.Parse("eb5cadbb-94e2-4bf9-8764-ddef8779ebd8"),
                    AllergyName = "Cá",
                    AllergyDescription = "Dị ứng với cá, bao gồm cả cá biển và cá nước ngọt."
                },
                new Allergy
                {
                    AllergyId = Guid.Parse("0d352b08-ada9-40f6-a23e-6f6f170a9cd4"),
                    AllergyName = "Động vật có vỏ",
                    AllergyDescription = "Dị ứng với các loại động vật có vỏ như tôm, cua, và sò."
                }
            );
        }

    }
}