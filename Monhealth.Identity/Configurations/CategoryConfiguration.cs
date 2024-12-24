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
                    CategoryName = "Hải sản",
                    CategoryDescription = "Các món ăn từ tôm, cá, cua, mực, hàu, sò và các loại hải sản khác. Thích hợp cho những ai yêu thích hương vị biển cả",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    CategoryImage = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcrab.png?alt=media&token=0cde2529-8e28-4b5e-80cf-660f27564de2"
                },
                new Category
                {
                    CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                    CategoryName = "Thịt",
                    CategoryDescription = "Bao gồm các món ăn từ thịt bò, thịt gà, thịt lợn, thịt vịt và các loại thịt khác. Là lựa chọn phổ biến trong bữa ăn chính",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    CategoryImage = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fsteak.png?alt=media&token=dfffb9c2-2964-40cc-8712-e83b4200e7af"
                },
                new Category
                {
                    CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                    CategoryName = "Rau củ",
                    CategoryDescription = "Món ăn từ rau xanh, củ quả và nấm. Phù hợp cho những ai yêu thích thực phẩm tươi sạch, giàu dinh dưỡng",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    CategoryImage = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbroccoli.png?alt=media&token=6746e0eb-bcf0-44d1-830a-79821f735f84"
                },
                new Category
                {
                    CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                    CategoryName = "Ngũ cốc",
                    CategoryDescription = "Gạo, mì, bánh mì, yến mạch, và các loại hạt ngũ cốc. Là nguồn cung cấp năng lượng chính trong ngày",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    CategoryImage = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Frice.png?alt=media&token=1ef6ca23-003f-4415-9ce4-3a3f5cd8e65e"
                },
                new Category
                {
                    CategoryId = Guid.Parse("fe3a3546-b294-4665-9c82-092d4ab5a187"),
                    CategoryName = "Hạt và đậu",
                    CategoryDescription = "Các loại hạt (hạnh nhân, hạt chia, hạt điều) và đậu (đậu nành, đậu xanh, đậu đen). Giàu protein và chất xơ",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    CategoryImage = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fgrain.png?alt=media&token=e224b22a-925e-4aa4-ab50-d74309ba71f4"
                },
                new Category
                {
                    CategoryId = Guid.Parse("22ee062d-4904-4c64-a783-74b3e142aac7"),
                    CategoryName = "Món chay",
                    CategoryDescription = "Các món ăn từ thực vật, đậu phụ, và nguyên liệu không sử dụng thịt, phù hợp với người ăn chay hoặc muốn đổi vị thanh đạm",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    CategoryImage = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fradish.png?alt=media&token=c27e26f3-3f39-42ec-bf40-94c9abb074d5"
                },
                new Category
                {
                    CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                    CategoryName = "Món ngọt",
                    CategoryDescription = "Bánh ngọt, kẹo, kem, và các món tráng miệng ngọt ngào, lý tưởng cho những ai yêu thích đồ ngọt",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    CategoryImage = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcupcake.png?alt=media&token=8721bd49-186f-4ccf-a85a-64008e4c8e38"
                },
                new Category
                {
                    CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                    CategoryName = "Đồ uống",
                    CategoryDescription = "Bao gồm nước ép, sinh tố, trà, cà phê, và các loại đồ uống giải khát khác",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    CategoryImage = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcoffee-cup.png?alt=media&token=14155321-cd44-422b-a49f-3e34636d7f85"
                },
                new Category
                {
                    CategoryId = Guid.Parse("fc7f66aa-8c09-46db-a679-be440e3ed91f"),
                    CategoryName = "Món lên men",
                    CategoryDescription = "Kimchi, dưa chua, sữa chua, rượu vang và các món ăn lên men, tốt cho tiêu hóa và sức khỏe đường ruột",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    CategoryImage = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fpickles.png?alt=media&token=2a078ceb-40a9-403d-a68c-9682faf1b97f"
                },
                new Category
                {
                    CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                    CategoryName = "Trái cây",
                    CategoryDescription = "Hoa quả tươi hoặc chế biến như salad trái cây, nước ép, sinh tố, cung cấp vitamin và khoáng chất",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    CategoryImage = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fapple.png?alt=media&token=106a39ee-5c36-4c27-8bbe-c850ee19cb02"
                },
                new Category
                {
                    CategoryId = Guid.Parse("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                    CategoryName = "Đồ ăn nhanh",
                    CategoryDescription = "Pizza, burger, khoai tây chiên, gà rán, và các món ăn tiện lợi, phù hợp cho những ai bận rộn",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    CategoryImage = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fburger.png?alt=media&token=66dd457f-64d3-4b66-851c-10eba13fdc7d"
                },
                new Category
                {
                    CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                    CategoryName = "Bánh các loại",
                    CategoryDescription = "Bánh mì, bánh ngọt, bánh mặn, bánh hấp, và các món bánh truyền thống hay hiện đại",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    CategoryImage = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbread.png?alt=media&token=decd5d8c-994f-4a71-ab9e-2096209515fc"
                },
                new Category
                {
                    CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                    CategoryName = "Đồ ăn vặt",
                    CategoryDescription = "Snack, khô gà, khô bò, bim bim, và các món ăn nhẹ lý tưởng cho những lúc giải trí hay nghỉ ngơi",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    CategoryImage = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fpopcorn.png?alt=media&token=8aecf5e1-071f-4b0f-8e55-a2c47b289def"
                }
            );
        }
    }

}