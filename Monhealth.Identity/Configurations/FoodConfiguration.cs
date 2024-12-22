using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
                new Food
                {
                    FoodId = Guid.Parse("b6fa82bc-715c-42da-af22-93290d3f2421"),
                    FoodName = "Cơm trắng",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Cơm là một món phổ biến trong ẩm thực Việt Nam, thường được ăn kèm với các món khác như cá, thịt, rau"
                },
                new Food
                {
                    FoodId = Guid.Parse("a3be942d-a225-44fb-9c98-22a109995145"),
                    FoodName = "Thịt heo nạc",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Thịt heo nạc mềm, ít mỡ, thường được dùng trong các món xào, kho hoặc nướng"
                }, new Food
                {
                    FoodId = Guid.Parse("f789601f-8026-499b-98cb-0f189926094a"),
                    FoodName = "Rau muống",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Rau muống thường được dùng để xào hoặc nấu canh, có vị ngọt, giòn và dễ chế biếnD"
                }, new Food
                {
                    FoodId = Guid.Parse("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db"),
                    FoodName = "Tôm biển",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Tôm biển ngọt, mềm, thường được chế biến thành các món canh, xào hoặc nướng"
                }, new Food
                {
                    FoodId = Guid.Parse("c82a256d-5573-4d27-b045-a411db42e694"),
                    FoodName = "Xúc xích",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Xúc xích là món ăn nhanh, thường được chế biến sẵn, có thể chiên, nướng hoặc ăn kèm trong các món salad"
                }, new Food
                {
                    FoodId = Guid.Parse("c567f8a9-71e4-4167-839d-a839ece79427"),
                    FoodName = "Bỏng ngô",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Bỏng ngô là món ăn vặt giòn nhẹ, phổ biến trong các buổi tiệc hoặc xem phim, có thể ăn trực tiếp hoặc kết hợp với gia vị"
                }, new Food
                {
                    FoodId = Guid.Parse("00a16b6c-9396-4389-95fd-205f72fe5164"),
                    FoodName = "Nem chua",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Nem chua là món ăn đặc trưng miền Bắc, được làm từ thịt heo lên men, có vị chua, cay, thường ăn kèm với rau sống"
                }, new Food
                {
                    FoodId = Guid.Parse("80c5e605-307f-4fef-bdf8-9967a800eab9"),
                    FoodName = "Mãng cầu",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Mãng cầu là trái cây có vị ngọt, chua nhẹ, thường được ăn tươi hoặc làm sinh tố giải nhiệt"
                }, new Food
                {
                    FoodId = Guid.Parse("d65bff7e-4a2d-498b-97b2-676d4dd92a90"),
                    FoodName = "Bắp luộc",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Bắp luộc là món ăn vặt phổ biến, ngọt và mềm, thường được ăn vào mùa hè, có thể ăn kèm với muối hoặc bơ"
                }, new Food
                {
                    FoodId = Guid.Parse("ced123e2-0b86-444b-ac83-7dba6860e354"),
                    FoodName = "Chả giò",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Chả giò là món ăn chiên giòn, nhân thịt, tôm, rau, thường được ăn kèm với nước chấm và rau sống"
                }, new Food

                {
                    FoodId = Guid.Parse("d4f8f2c7-5318-4f07-803d-2b093be4d6c7"),
                    FoodName = "Bưởi",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Bưởi có vị chua ngọt, thường được ăn tươi hoặc làm món tráng miệng, rất giàu vitamin C"
                }, new Food
                {
                    FoodId = Guid.Parse("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9"),
                    FoodName = "Giá đỗ",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Giá đỗ giòn, có thể ăn sống trong salad hoặc xào với thịt, là nguồn cung cấp vitamin rất tốt cho cơ thể"
                }, new Food
                {
                    FoodId = Guid.Parse("e1b0767d-4b3b-42ea-820f-2154f7883ab9"),
                    FoodName = "Nấm kim châm",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Nấm kim châm nhỏ, ngọt, dùng để xào, nấu canh hoặc ăn sống, bổ dưỡng và dễ chế biến"
                }, new Food
                {
                    FoodId = Guid.Parse("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552"),
                    FoodName = "Khoai tây",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Khoai tây là nguyên liệu phổ biến, có thể nấu canh, chiên hoặc nướng, chứa nhiều tinh bột và dinh dưỡng"
                }, new Food
                {
                    FoodId = Guid.Parse("dd918def-34c2-4f5c-b402-6d51d8a1c604"),
                    FoodName = "Bầu",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Bầu là một loại quả mềm, thường được dùng trong các món canh hoặc xào, có vị ngọt mát và thanh"
                }, new Food
                {
                    FoodId = Guid.Parse("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f"),
                    FoodName = "Đậu phộng",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Đậu phộng là món ăn vặt giòn, có thể ăn sống, rang muối hoặc dùng làm gia vị trong các món ăn"
                }, new Food
                {
                    FoodId = Guid.Parse("c4f9e44d-b7f6-4530-8b2e-b64c8f993f2a"),
                    FoodName = "Thịt bò",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Thịt bò có hương vị đặc trưng, mềm và giàu protein, thường được dùng trong các món xào, nướng hoặc làm súp"
                },
                new Food
                {
                    FoodId = Guid.Parse("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91"),
                    FoodName = "Chuối tây",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Chuối tây ngọt, mềm, dễ tiêu hóa, thường được ăn trực tiếp hoặc chế biến thành các món tráng miệng"
                }, new Food
                {
                    FoodId = Guid.Parse("3b372064-e2a9-4729-b725-635e54e11c5d"),
                    FoodName = "Bún tươi",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Bún tươi là món ăn phổ biến trong các bữa ăn miền Bắc và miền Nam, dùng với nước lèo, thịt, rau hoặc hải sản"
                }, new Food
                {
                    FoodId = Guid.Parse("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7"),
                    FoodName = "Sầu riêng",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                    FoodDescription = "Sầu riêng là trái cây đặc trưng của miền Nam, có mùi rất mạnh, ngọt béo, được yêu thích làm món tráng miệng"
                }
            );
        }
    }
}