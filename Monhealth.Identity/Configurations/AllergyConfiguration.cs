using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class AllergyConfiguration : IEntityTypeConfiguration<Allergy>
    {
        public void Configure(EntityTypeBuilder<Allergy> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);
            var user = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B");
            
            builder.HasData(

            #region Allergy 1
            new Allergy
            {
                AllergyId = Guid.Parse("99b9eae6-f5e8-4b41-9394-6a8f2ca1062b"),
                AllergyName = "Đậu phộng",
                AllergyDescription = "Bánh kẹo chứa đậu phộng, nước sốt satay, đậu phộng rang",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = user,
                UpdatedBy = user
            },
            #endregion

            #region Allergy 2
            new Allergy
            {
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8"),
                AllergyName = "Hải sản có vỏ",
                AllergyDescription = "Tôm, cua, sò, nghêu, hàu, mực",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = user,
                UpdatedBy = user
            },
            #endregion
            #region Allergy 3
            new Allergy
            {
                AllergyId = Guid.Parse("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"),
                AllergyName = "Sữa",
                AllergyDescription = "Sữa bò, phô mai, bơ, kem, bánh ngọt có sữa",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = user,
                UpdatedBy = user
            },
            #endregion

            #region Allergy 4
            new Allergy
            {
                AllergyId = Guid.Parse("ea406418-19d1-43dc-96a2-9abf97b9d2a5"),
                AllergyName = "Trứng",
                AllergyDescription = "Trứng gà, trứng vịt, bánh trứng, mayonnaise",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = user,
                UpdatedBy = user
            },
            #endregion

            #region Allergy 5
            new Allergy
            {
                AllergyId = Guid.Parse("1ada29ad-354a-44aa-b402-3f8a9c854e56"),
                AllergyName = "Lúa mì",
                AllergyDescription = "Bánh mì, mì sợi, bánh quy, ngũ cốc có chứa gluten",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = user,
                UpdatedBy = user
            },
            #endregion

            #region Allergy 6
            new Allergy
            {
                AllergyId = Guid.Parse("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"),
                AllergyName = "Cá",
                AllergyDescription =  "Cá ngừ, cá hồi, cá basa, nước mắm, chả cá",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = user,
                UpdatedBy = user
            },
            #endregion

            #region Allergy 7
            new Allergy
            {
                AllergyId = Guid.Parse("0eec9d43-391c-43c6-9635-01ca2d6fc66c"),
                AllergyName = "Các loại hạt",
                AllergyDescription =  "Hạt điều, hạnh nhân, óc chó, hạt dẻ, hạt hồ trăn",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = user,
                UpdatedBy = user
            },
            #endregion

            #region Allergy 8
            new Allergy
            {
                AllergyId = Guid.Parse("c87bd979-3dde-4a47-9f1c-7eef88c6c041"),
                AllergyName = "Đậu nành",
                AllergyDescription = "Đậu phụ, sữa đậu nành, nước tương, bột đậu nành",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = user,
                UpdatedBy = user
            },
            #endregion

            #region Allergy 9
            new Allergy
            {
                AllergyId = Guid.Parse("4d6270d3-69c6-4b9f-9c11-125369139775"),
                AllergyName = "Hạt vừng",
                AllergyDescription = "Bánh mì vừng, muối vừng, dầu mè, món ăn rắc mè",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = user,
                UpdatedBy = user
            }
            #endregion
            );
        }
    }
}