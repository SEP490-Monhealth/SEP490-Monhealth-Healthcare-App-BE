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

            builder.HasData(

            #region Allergy 1
            new Allergy
            {
                AllergyId = Guid.Parse("99b9eae6-f5e8-4b41-9394-6a8f2ca1062b"),
                AllergyName = "Đậu phộng",
                AllergyDescription = "Dị ứng với đậu phộng khá phổ biến và có thể gây phản ứng nghiêm trọng như sưng tấy, phát ban, khó thở, hoặc sốc phản vệ.",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Allergy 2
            new Allergy
            {
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8"),
                AllergyName = "Hải sản có vỏ",
                AllergyDescription = "Dị ứng với hải sản có vỏ như tôm, cua, sò, nghêu rất phổ biến ở Việt Nam và có thể gây phản ứng dị ứng nặng, từ phát ban đến khó thở",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion
            #region Allergy 3
            new Allergy
            {
                AllergyId = Guid.Parse("b52d2f0a-e728-42dc-90c6-bd0310bc0de6"),
                AllergyName = "Sữa",
                AllergyDescription = "Dị ứng sữa có thể gây ngứa, phát ban, hoặc tiêu chảy ở một số người, đặc biệt là trẻ em",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Allergy 4
            new Allergy
            {
                AllergyId = Guid.Parse("ea406418-19d1-43dc-96a2-9abf97b9d2a5"),
                AllergyName = "Trứng",
                AllergyDescription = "Dị ứng trứng là một trong những dị ứng thực phẩm phổ biến, đặc biệt là ở trẻ em. Triệu chứng có thể bao gồm phát ban, ngứa, hoặc khó thở",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Allergy 5
            new Allergy
            {
                AllergyId = Guid.Parse("1ada29ad-354a-44aa-b402-3f8a9c854e56"),
                AllergyName = "Lúa mì",
                AllergyDescription = "Dị ứng với lúa mì, thường gặp ở những người không dung nạp gluten",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Allergy 6
            new Allergy
            {
                AllergyId = Guid.Parse("9e356dc9-ab35-4b54-aa35-37e35d2cc41f"),
                AllergyName = "Cá",
                AllergyDescription = "Dị ứng cá cũng khá phổ biến và có thể gây ra các phản ứng nghiêm trọng như phát ban, sưng, hoặc khó thở",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Allergy 7
            new Allergy
            {
                AllergyId = Guid.Parse("0eec9d43-391c-43c6-9635-01ca2d6fc66c"),
                AllergyName = "Các loại hạt",
                AllergyDescription = "Dị ứng với các loại hạt như hạt điều, hạt hạnh nhân cũng có thể gây ra phản ứng mạnh, đặc biệt là đối với những người có cơ địa nhạy cảm",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Allergy 8
            new Allergy
            {
                AllergyId = Guid.Parse("c87bd979-3dde-4a47-9f1c-7eef88c6c041"),
                AllergyName = "Đậu nành",
                AllergyDescription = "Dị ứng với đậu nành khá phổ biến và có thể gây phát ban, ngứa, hoặc khó thở. Đậu nành là thành phần chính trong nhiều món ăn và thực phẩm chế biến sẵn tại Việt Nam",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Allergy 9
            new Allergy
            {
                AllergyId = Guid.Parse("4d6270d3-69c6-4b9f-9c11-125369139775"),
                AllergyName = "Hạt vừng",
                AllergyDescription = "Dị ứng với hạt vừng (mè) có thể gây phát ban, ngứa, và có thể nghiêm trọng nếu không được kiểm soát",
                CreatedAt = today,
                UpdatedAt = today,
            }
            #endregion
            );
        }
    }
}