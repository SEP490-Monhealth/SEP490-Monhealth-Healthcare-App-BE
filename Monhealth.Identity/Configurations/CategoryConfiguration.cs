using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
    new Category
    {
        CategoryId = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
        CategoryName = "Fast food",
        CategoryDescription = "Các bữa ăn nhanh, tiện lợi, thường được phục vụ trong môi trường nhịp độ nhanh.",
        CreatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null)
    },
    new Category
    {
        CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
        CategoryName = "Nhiều carbs",
        CategoryDescription = "Thức ăn nhiều carbohydrate (carb) thường là những thực phẩm chứa hàm lượng tinh bột hoặc đường cao.",
        CreatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null)
    },
    new Category
    {
        CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
        CategoryName = "Nhiều gia vị",
        CategoryDescription = "Các món ăn đậm đà, cay nóng, thường được tăng cường với ớt và gia vị.",
        CreatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null)
    },
    new Category
    {
        CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
        CategoryName = "Đồ ăn chay",
        CategoryDescription = "Các bữa ăn không có thịt hoặc cá, tập trung vào rau củ và ngũ cốc.",
        CreatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null)
    },
    new Category
    {
        CategoryId = Guid.Parse("fe3a3546-b294-4665-9c82-092d4ab5a187"),
        CategoryName = "Hải sản",
        CategoryDescription = "Cá tươi, động vật có vỏ, và các sinh vật biển khác, mang lại hương vị đậm đà của đại dương.",
        CreatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null)
    },

    new Category
    {
        CategoryId = Guid.Parse("22ee062d-4904-4c64-a783-74b3e142aac7"),
        CategoryName = "Giàu protein",
        CategoryDescription = "Thực phẩm giàu protein, bao gồm thịt, đậu, trứng, và các loại hạt, cần thiết cho việc xây dựng và sửa chữa cơ bắp.",
        CreatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null)
    },
    new Category
    {
        CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
        CategoryName = "Ít calo",
        CategoryDescription = "Thực phẩm có hàm lượng năng lượng (calo) thấp, thường được thiết kế để hỗ trợ kiểm soát cân nặng hoặc duy trì sức khỏe.",
        CreatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null)
    },
    new Category
    {
        CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
        CategoryName = "Giàu chất xơ",
        CategoryDescription = "Thực phẩm giàu chất xơ, giúp thúc đẩy sức khỏe tiêu hóa, chẳng hạn như trái cây, rau và ngũ cốc nguyên hạt.",
        CreatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null)
    },
    new Category
    {
        CategoryId = Guid.Parse("fc7f66aa-8c09-46db-a679-be440e3ed91f"),
        CategoryName = "Đồ ngọt",
        CategoryDescription = "Món tráng miệng hoặc đồ ăn giàu đường, mang lại hương vị ngọt ngào, thỏa mãn.",
        CreatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null)
    },
    new Category
    {
        CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
        CategoryName = "Lên men",
        CategoryDescription = "Thực phẩm đã qua quá trình lên men, mang lại hương vị độc đáo và chứa probiotics, như kim chi hoặc sữa chua.",
        CreatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null)
    },
    new Category
    {
        CategoryId = Guid.Parse("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
        CategoryName = "Hữu cơ",
        CategoryDescription = "Thực phẩm được trồng mà không sử dụng thuốc trừ sâu tổng hợp hoặc phân bón, tập trung vào tính bền vững và sức khỏe.",
        CreatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null)
    },
    new Category
    {
        CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
        CategoryName = "Chế biến sẵn",
        CategoryDescription = "Thực phẩm đã qua xử lý để thay đổi trạng thái tự nhiên của chúng thông qua các phương pháp như đóng hộp, đông lạnh hoặc thêm chất bảo quản.",
        CreatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("18-05-2024", "dd-MM-yyyy", null)
    }
                      );
        }
    }
}