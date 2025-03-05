using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class ExpertiseConfiguration : IEntityTypeConfiguration<Expertise>
    {
        public void Configure(EntityTypeBuilder<Expertise> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region Expertise 1
            new Expertise
            {
                ExpertiseId = Guid.Parse("7a61f09f-f999-44fd-8973-105e22df1401"),
                ExpertiseName = "Dinh dưỡng lâm sàng",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Expertise 2
            new Expertise
            {
                ExpertiseId = Guid.Parse("44d9ffb3-a8b8-407b-975c-99e6f6146bc9"),
                ExpertiseName = "Dinh dưỡng thể thao",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Expertise 3
            new Expertise
            {
                ExpertiseId = Guid.Parse("63100127-6781-4385-a1df-b21cae459bdb"),
                ExpertiseName = "Dinh dưỡng tiền sản và sau sinh",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Expertise 4
            new Expertise
            {
                ExpertiseId = Guid.Parse("c5d7a490-e25e-4ae6-a6db-2d637e6630de"),
                ExpertiseName = "Tiểu đường",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Expertise 5
            new Expertise
            {
                ExpertiseId = Guid.Parse("67188399-9f09-4b74-9eb3-31ff82734850"),
                ExpertiseName = "Tim mạch",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Expertise 6
            new Expertise
            {
                ExpertiseId = Guid.Parse("d762370d-3b36-45f6-ae15-bbe4c2b9bf8a"),
                ExpertiseName = "Ung thư",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Expertise 7
            new Expertise
            {
                ExpertiseId = Guid.Parse("c32b7429-13df-4aa0-b32d-705d1050de5f"),
                ExpertiseName = "Phục hồi sau phẫu thuật/chấn thương",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Expertise 8
            new Expertise
            {
                ExpertiseId = Guid.Parse("6c6a7d90-1c16-44ae-9b2a-b3addfe55dbc"),
                ExpertiseName = "Vật lý trị liệu",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Expertise 9
            new Expertise
            {
                ExpertiseId = Guid.Parse("fdb9b159-8cd5-4a4b-9879-1a140365c207"),
                ExpertiseName = "Stress & Lo âu",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Expertise 10
            new Expertise
            {
                ExpertiseId = Guid.Parse("8ad55299-b566-47e8-a9a0-1997e893e153"),
                ExpertiseName = "Trầm cảm",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Expertise 11
            new Expertise
            {
                ExpertiseId = Guid.Parse("5912320d-f6ab-493a-8631-891048f965e7"),
                ExpertiseName = "Rối loạn giấc ngủ",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Expertise 12
            new Expertise
            {
                ExpertiseId = Guid.Parse("82e1e76a-99fb-43b4-84e1-d11376b487b8"),
                ExpertiseName = "Huấn luyện cá nhân",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Expertise 13
            new Expertise
            {
                ExpertiseId = Guid.Parse("939cf420-f669-464e-bb2d-74a2c61b1d6f"),
                ExpertiseName = "Yoga/Pilates",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Expertise 14
            new Expertise
            {
                ExpertiseId = Guid.Parse("5fa7d647-9ede-4180-99d3-fc10f54dd459"),
                ExpertiseName = "Giảm cân",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Expertise 15
            new Expertise
            {
                ExpertiseId = Guid.Parse("f28d1cdc-925e-4ff5-b6db-520de542bc0a"),
                ExpertiseName = "Tăng cân lành mạnh",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Expertise 16
            new Expertise
            {
                ExpertiseId = Guid.Parse("768178b4-2241-4914-9309-74f89462eddc"),
                ExpertiseName = "Cai thuốc lá/rượu",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Expertise 17
            new Expertise
            {
                ExpertiseId = Guid.Parse("0131b574-2c27-477b-af1f-5abbb7dd08a4"),
                ExpertiseName = "Quản lý giấc ngủ",
                CreatedAt = today,
                UpdatedAt = today,
            }
            #endregion
            );
        }
    }
}