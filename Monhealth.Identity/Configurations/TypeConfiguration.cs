using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class TypeConfiguration : IEntityTypeConfiguration<Domain.Type>
    {
        public void Configure(EntityTypeBuilder<Domain.Type> builder)
        {
            builder.HasData(
            #region Type 1
                new Domain.Type
                {
                    TypeId = Guid.Parse("7780ccb5-aa16-4f88-a662-04971892dae0"),
                    TypeName = "Yoga",
                    TypeDescription = "Các bài tập tập trung vào việc cải thiện sự linh hoạt, thăng bằng, và giảm căng thẳng thông qua các tư thế và kỹ thuật thở. Phù hợp cho mọi lứa tuổi và thể trạng",
                    TypeImage = "",
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Type 2
                new Domain.Type
                {
                    TypeId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    TypeName = "Stretching",
                    TypeDescription = "Bài tập kéo giãn cơ giúp cải thiện biên độ chuyển động, giảm đau nhức cơ bắp, và tăng cường sự linh hoạt. Thường được sử dụng như phần khởi động hoặc thư giãn sau buổi tập",
                    TypeImage = "",
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Type 3
                new Domain.Type
                {
                    TypeId = Guid.Parse("045d39cf-5865-4e2a-9cd1-fd76628bdab4"),
                    TypeName = "Cardio",
                    TypeDescription = "Các bài tập aerobic giúp tăng nhịp tim, cải thiện sức khỏe tim mạch, và đốt cháy calo nhanh. Thích hợp để giảm cân hoặc cải thiện thể lực tổng thể",
                    TypeImage = "",
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Type 4
                new Domain.Type
                {
                    TypeId = Guid.Parse("c440673d-c842-4aad-aa44-4a9b314529c4"),
                    TypeName = "Core",
                    TypeDescription = "Các bài tập tăng cường sức mạnh cơ bụng, lưng dưới, và vùng thân trung tâm. Giúp cải thiện tư thế, thăng bằng, và giảm nguy cơ chấn thương",
                    TypeImage = "",
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Type 5
                new Domain.Type
                {
                    TypeId = Guid.Parse("a1c1ef2d-6697-49d3-857b-882b288ffeef"),
                    TypeName = "Breathing Exercises",
                    TypeDescription = "Các bài tập tập trung vào kỹ thuật thở sâu và có kiểm soát. Giúp thư giãn, giảm stress, và cải thiện khả năng hấp thụ oxy",
                    TypeImage = "",
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Type 6
                new Domain.Type
                {
                    TypeId = Guid.Parse("d7c2a84c-2136-4f62-8d8e-4d70ec123f4f"),
                    TypeName = "Balance Training",
                    TypeDescription = "Các bài tập giúp tăng cường khả năng thăng bằng và sự ổn định của cơ thể. Đặc biệt hữu ích cho người lớn tuổi hoặc những ai cần cải thiện khả năng giữ thăng bằng",
                    TypeImage = "",
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Type 7
                new Domain.Type
                {
                    TypeId = Guid.Parse("cb81e687-8e2f-4814-99a6-808777410e02"),
                    TypeName = "Pilates",
                    TypeDescription = "Bài tập kết hợp giữa các động tác chậm, có kiểm soát, tập trung vào sức mạnh cơ lõi, sự linh hoạt và tư thế. Phù hợp để cải thiện cơ bắp và giảm căng thẳng",
                    TypeImage = "",
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                }
            #endregion

                );
        }
    }
}
