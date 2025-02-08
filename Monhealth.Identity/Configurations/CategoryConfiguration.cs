using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Core.Enum;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region Category Food 1 
            new Category
            {
                CategoryId = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                CategoryName = "Hải sản",
                CategoryType = 0,
                CategoryDescription = "Các món ăn từ tôm, cá, cua, mực, hàu, sò và các loại hải sản khác. Thích hợp cho những ai yêu thích hương vị biển cả",
                Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcrab.png?alt=media&token=0cde2529-8e28-4b5e-80cf-660f27564de2",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Category Food 2
            new Category
            {
                CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                CategoryName = "Thịt",
                CategoryType = 0,
                CategoryDescription = "Bao gồm các món ăn từ thịt bò, thịt gà, thịt lợn, thịt vịt và các loại thịt khác. Là lựa chọn phổ biến trong bữa ăn chính",
                Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fsteak.png?alt=media&token=dfffb9c2-2964-40cc-8712-e83b4200e7af",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Category Food 3
            new Category
            {
                CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                CategoryName = "Rau củ",
                CategoryType = 0,
                CategoryDescription = "Món ăn từ rau xanh, củ quả và nấm. Phù hợp cho những ai yêu thích thực phẩm tươi sạch, giàu dinh dưỡng",
                Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbroccoli.png?alt=media&token=6746e0eb-bcf0-44d1-830a-79821f735f84",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Category Food 4
            new Category
            {
                CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                CategoryName = "Ngũ cốc",
                CategoryType = 0,
                CategoryDescription = "Gạo, mì, bánh mì, yến mạch, và các loại hạt ngũ cốc. Là nguồn cung cấp năng lượng chính trong ngày",
                Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Frice.png?alt=media&token=1ef6ca23-003f-4415-9ce4-3a3f5cd8e65e",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Category Food 5
            new Category
            {
                CategoryId = Guid.Parse("fe3a3546-b294-4665-9c82-092d4ab5a187"),
                CategoryName = "Hạt và đậu",
                CategoryType = 0,
                CategoryDescription = "Các loại hạt (hạnh nhân, hạt chia, hạt điều) và đậu (đậu nành, đậu xanh, đậu đen). Giàu protein và chất xơ",
                Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fgrain.png?alt=media&token=e224b22a-925e-4aa4-ab50-d74309ba71f4",
                CreatedAt = today,
                UpdatedAt = today,
            },

            #endregion

            #region Category Food 6
            new Category
            {
                CategoryId = Guid.Parse("22ee062d-4904-4c64-a783-74b3e142aac7"),
                CategoryName = "Món chay",
                CategoryType = 0,
                CategoryDescription = "Các món ăn từ thực vật, đậu phụ, và nguyên liệu không sử dụng thịt, phù hợp với người ăn chay hoặc muốn đổi vị thanh đạm",
                Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fradish.png?alt=media&token=c27e26f3-3f39-42ec-bf40-94c9abb074d5",
                CreatedAt = today,
                UpdatedAt = today,
            },

            #endregion

            #region Category Food 7
            new Category
            {
                CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                CategoryName = "Món ngọt",
                CategoryType = 0,
                CategoryDescription = "Bánh ngọt, kẹo, kem, và các món tráng miệng ngọt ngào, lý tưởng cho những ai yêu thích đồ ngọt",
                Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcupcake.png?alt=media&token=8721bd49-186f-4ccf-a85a-64008e4c8e38",
                CreatedAt = today,
                UpdatedAt = today,
            },

            #endregion

            #region Category Food 8
            new Category
            {
                CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                CategoryName = "Đồ uống",
                CategoryType = 0,
                CategoryDescription = "Bao gồm nước ép, sinh tố, trà, cà phê, và các loại đồ uống giải khát khác",
                Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcoffee-cup.png?alt=media&token=14155321-cd44-422b-a49f-3e34636d7f85",
                CreatedAt = today,
                UpdatedAt = today,
            },

            #endregion

            #region Category Food 9
            new Category
            {
                CategoryId = Guid.Parse("fc7f66aa-8c09-46db-a679-be440e3ed91f"),
                CategoryName = "Món lên men",
                CategoryType = 0,
                CategoryDescription = "Kimchi, dưa chua, sữa chua, rượu vang và các món ăn lên men, tốt cho tiêu hóa và sức khỏe đường ruột",
                Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fpickles.png?alt=media&token=2a078ceb-40a9-403d-a68c-9682faf1b97f",
                CreatedAt = today,
                UpdatedAt = today,
            },

            #endregion

            #region Category Food 10
            new Category
            {
                CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                CategoryName = "Trái cây",
                CategoryType = 0,
                CategoryDescription = "Hoa quả tươi hoặc chế biến như salad trái cây, nước ép, sinh tố, cung cấp vitamin và khoáng chất",
                Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fapple.png?alt=media&token=106a39ee-5c36-4c27-8bbe-c850ee19cb02",
                CreatedAt = today,
                UpdatedAt = today,
            },

            #endregion

            #region Category Food 11
            new Category
            {
                CategoryId = Guid.Parse("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                CategoryName = "Đồ ăn nhanh",
                CategoryType = 0,
                CategoryDescription = "Pizza, burger, khoai tây chiên, gà rán, và các món ăn tiện lợi, phù hợp cho những ai bận rộn",
                Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fburger.png?alt=media&token=66dd457f-64d3-4b66-851c-10eba13fdc7d",
                CreatedAt = today,
                UpdatedAt = today,
            },

            #endregion

            #region Category Food 12
            new Category
            {
                CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                CategoryName = "Bánh các loại",
                CategoryType = 0,
                CategoryDescription = "Bánh mì, bánh ngọt, bánh mặn, bánh hấp, và các món bánh truyền thống hay hiện đại",
                Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbread.png?alt=media&token=decd5d8c-994f-4a71-ab9e-2096209515fc",
                CreatedAt = today,
                UpdatedAt = today,
            },

            #endregion

            #region Category Food 13
            new Category
            {
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                CategoryName = "Đồ ăn vặt",
                CategoryType = 0,
                CategoryDescription = "Snack, khô gà, khô bò, bim bim, và các món ăn nhẹ lý tưởng cho những lúc giải trí hay nghỉ ngơi",
                Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fpopcorn.png?alt=media&token=8aecf5e1-071f-4b0f-8e55-a2c47b289def",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Category Workout 1
            new Category
            {
                CategoryId = Guid.Parse("fccb0ebd-ff54-401b-a1ec-0e9f63804bb9"),
                CategoryName = "Warm up",
                CategoryType = (CategoryType)1,
                CategoryDescription = "Bài tập khởi động nhẹ giúp làm nóng cơ bắp, tăng lưu thông máu và chuẩn bị cơ thể trước khi bước vào tập luyện.",
                Image = "",
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Category Workout 2
            new Category
            {
                CategoryId = Guid.Parse("036a94f2-013a-4375-a685-76ff6ffcc24e"),
                CategoryName = "Workout",
                CategoryType = (CategoryType)1,
                CategoryDescription = "Bài tập chính với các động tác cường độ cao hoặc tập trung vào nhóm cơ nhất định, giúp phát triển sức mạnh và cải thiện thể lực.",
                Image = "",
                CreatedAt = today,
                UpdatedAt = today,
            }
            #endregion


            // #region Category Exercise 1
            // new Category
            // {
            //     CategoryId = Guid.Parse("fb5f24c1-cadf-4b21-88a7-f12d5dfc4720"),
            //     CategoryType = (CategoryType)1,
            //     CategoryName = "Core",
            //     CategoryDescription = "Tập trung vào cơ vùng bụng và lưng dưới, giúp cải thiện sức mạnh và sự ổn định.",
            //     Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcore.png?alt=media&token=b3152e12-16dd-4ec4-944f-bf2c3434954b",
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            // #region Category Exercise 2
            // new Category
            // {
            //     CategoryId = Guid.Parse("7d730669-e718-4c17-ae6e-529636932e62"),
            //     CategoryType = (CategoryType)1,
            //     CategoryName = "Lower Body",
            //     CategoryDescription = "Tăng cường sức mạnh cho chân, đùi và mông, cải thiện khả năng di chuyển và sự bền bỉ.",
            //     Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Flower-body.png?alt=media&token=c5a737bf-767e-4db9-8c80-0c04812e11dd",
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            // #region Category Exercise 3
            // new Category
            // {
            //     CategoryId = Guid.Parse("462eddbb-989c-4c39-8904-d9a54950f81b"),
            //     CategoryType = (CategoryType)1,
            //     CategoryName = "Upper Body",
            //     CategoryDescription = "Cải thiện sức mạnh và hình dáng cơ tay, vai và lưng trên.",
            //     Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fupper-body.png?alt=media&token=4010483d-fb22-4613-9070-0a2b2d57ce6a",
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            // #region Category Exercise 4
            // new Category
            // {
            //     CategoryId = Guid.Parse("983aabc5-29c7-48a9-9623-4cd37b9a5828"),
            //     CategoryType = (CategoryType)1,
            //     CategoryName = "Cardio",
            //     CategoryDescription = "Cải thiện hệ tim mạch, đốt cháy calo và tăng cường sức bền.",
            //     Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcardio.png?alt=media&token=6c6c115c-db1f-4af2-96e0-188f38944f36",
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            // #region Category Exercise 5
            // new Category
            // {
            //     CategoryId = Guid.Parse("aa7ac7df-8edb-431a-9fae-5b8520d7630d"),
            //     CategoryType = (CategoryType)1,
            //     CategoryName = "Balance",
            //     CategoryDescription = "Cải thiện khả năng thăng bằng và tăng cường sự ổn định của cơ thể.",
            //     Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbalance.png?alt=media&token=58094819-44bf-4d32-8075-5bccfd957201",
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            // #region Category Exercise 6
            // new Category
            // {
            //     CategoryId = Guid.Parse("80b51d77-fb33-4294-9903-7a151f12bcf0"),
            //     CategoryType = (CategoryType)1,
            //     CategoryName = "Flexibility",
            //     CategoryDescription = "Kết hợp thăng bằng và sự dẻo dai, hỗ trợ kiểm soát cơ thể và giảm nguy cơ chấn thương.",
            //     Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fflexibility.png?alt=media&token=1850a9fe-7412-49b3-8660-81ef76194685",
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            // #region Category Exercise 7
            // new Category
            // {
            //     CategoryId = Guid.Parse("c3bff830-dad0-4489-95df-1d6ac52d5b3e"),
            //     CategoryType = (CategoryType)1,
            //     CategoryName = "Mobility",
            //     CategoryDescription = "Tăng cường khả năng di chuyển của khớp và cơ, giúp cơ thể linh hoạt hơn.",
            //     Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fmobility.png?alt=media&token=27e9733a-292e-4f15-9bfc-a37d9b7ea575",
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // }
            // #endregion
            );
        }
    }
}

