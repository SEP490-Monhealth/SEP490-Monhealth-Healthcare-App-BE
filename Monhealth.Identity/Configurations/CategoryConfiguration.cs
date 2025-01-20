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
            #region Category Food 1 
                new Category
                {
                    CategoryId = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                    CategoryName = "Hải sản",
                    CategoryType = "Food",
                    CategoryDescription = "Các món ăn từ tôm, cá, cua, mực, hàu, sò và các loại hải sản khác. Thích hợp cho những ai yêu thích hương vị biển cả",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcrab.png?alt=media&token=0cde2529-8e28-4b5e-80cf-660f27564de2",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },
            #endregion

            #region Category Food 2
                new Category
                {
                    CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                    CategoryName = "Thịt",
                    CategoryType = "Food",
                    CategoryDescription = "Bao gồm các món ăn từ thịt bò, thịt gà, thịt lợn, thịt vịt và các loại thịt khác. Là lựa chọn phổ biến trong bữa ăn chính",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fsteak.png?alt=media&token=dfffb9c2-2964-40cc-8712-e83b4200e7af",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },
            #endregion

            #region Category Food 3
                new Category
                {
                    CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                    CategoryName = "Rau củ",
                    CategoryType = "Food",
                    CategoryDescription = "Món ăn từ rau xanh, củ quả và nấm. Phù hợp cho những ai yêu thích thực phẩm tươi sạch, giàu dinh dưỡng",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbroccoli.png?alt=media&token=6746e0eb-bcf0-44d1-830a-79821f735f84",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },
            #endregion

            #region Category Food 4
                new Category
                {
                    CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                    CategoryName = "Ngũ cốc",
                    CategoryType = "Food",
                    CategoryDescription = "Gạo, mì, bánh mì, yến mạch, và các loại hạt ngũ cốc. Là nguồn cung cấp năng lượng chính trong ngày",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Frice.png?alt=media&token=1ef6ca23-003f-4415-9ce4-3a3f5cd8e65e",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },
            #endregion

            #region Category Food 5
                new Category
                {
                    CategoryId = Guid.Parse("fe3a3546-b294-4665-9c82-092d4ab5a187"),
                    CategoryName = "Hạt và đậu",
                    CategoryType = "Food",
                    CategoryDescription = "Các loại hạt (hạnh nhân, hạt chia, hạt điều) và đậu (đậu nành, đậu xanh, đậu đen). Giàu protein và chất xơ",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fgrain.png?alt=media&token=e224b22a-925e-4aa4-ab50-d74309ba71f4",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },

            #endregion

            #region Category Food 6
                new Category
                {
                    CategoryId = Guid.Parse("22ee062d-4904-4c64-a783-74b3e142aac7"),
                    CategoryName = "Món chay",
                    CategoryType = "Food",
                    CategoryDescription = "Các món ăn từ thực vật, đậu phụ, và nguyên liệu không sử dụng thịt, phù hợp với người ăn chay hoặc muốn đổi vị thanh đạm",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fradish.png?alt=media&token=c27e26f3-3f39-42ec-bf40-94c9abb074d5",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },

            #endregion

            #region Category Food 7
                new Category
                {
                    CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                    CategoryName = "Món ngọt",
                    CategoryType = "Food",
                    CategoryDescription = "Bánh ngọt, kẹo, kem, và các món tráng miệng ngọt ngào, lý tưởng cho những ai yêu thích đồ ngọt",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcupcake.png?alt=media&token=8721bd49-186f-4ccf-a85a-64008e4c8e38",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },

            #endregion

            #region Category Food 8
                new Category
                {
                    CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                    CategoryName = "Đồ uống",
                    CategoryType = "Food",
                    CategoryDescription = "Bao gồm nước ép, sinh tố, trà, cà phê, và các loại đồ uống giải khát khác",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcoffee-cup.png?alt=media&token=14155321-cd44-422b-a49f-3e34636d7f85",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },

            #endregion

            #region Category Food 9
                new Category
                {
                    CategoryId = Guid.Parse("fc7f66aa-8c09-46db-a679-be440e3ed91f"),
                    CategoryName = "Món lên men",
                    CategoryType = "Food",
                    CategoryDescription = "Kimchi, dưa chua, sữa chua, rượu vang và các món ăn lên men, tốt cho tiêu hóa và sức khỏe đường ruột",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fpickles.png?alt=media&token=2a078ceb-40a9-403d-a68c-9682faf1b97f",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },

            #endregion

            #region Category Food 10
                new Category
                {
                    CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                    CategoryName = "Trái cây",
                    CategoryType = "Food",
                    CategoryDescription = "Hoa quả tươi hoặc chế biến như salad trái cây, nước ép, sinh tố, cung cấp vitamin và khoáng chất",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fapple.png?alt=media&token=106a39ee-5c36-4c27-8bbe-c850ee19cb02",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },

            #endregion

            #region Category Food 11
                new Category
                {
                    CategoryId = Guid.Parse("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                    CategoryName = "Đồ ăn nhanh",
                    CategoryType = "Food",
                    CategoryDescription = "Pizza, burger, khoai tây chiên, gà rán, và các món ăn tiện lợi, phù hợp cho những ai bận rộn",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fburger.png?alt=media&token=66dd457f-64d3-4b66-851c-10eba13fdc7d",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },

            #endregion

            #region Category Food 12
                new Category
                {
                    CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                    CategoryName = "Bánh các loại",
                    CategoryType = "Food",
                    CategoryDescription = "Bánh mì, bánh ngọt, bánh mặn, bánh hấp, và các món bánh truyền thống hay hiện đại",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbread.png?alt=media&token=decd5d8c-994f-4a71-ab9e-2096209515fc",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },

            #endregion

            #region Category Food 13
                new Category
                {
                    CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                    CategoryName = "Đồ ăn vặt",
                    CategoryType = "Food",
                    CategoryDescription = "Snack, khô gà, khô bò, bim bim, và các món ăn nhẹ lý tưởng cho những lúc giải trí hay nghỉ ngơi",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fpopcorn.png?alt=media&token=8aecf5e1-071f-4b0f-8e55-a2c47b289def",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },

            #endregion

            // --------------------------------------------------------------
            #region Category Exercise 1
                new Category
                {
                    CategoryId = Guid.Parse("7780ccb5-aa16-4f88-a662-04971892dae0"),
                    CategoryName = "Yoga",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fyoga.png?alt=media&token=f8293538-82e7-44a2-9765-ca6e75d2f443",
                    CategoryType = "Exercise",
                    CategoryDescription = "Các bài tập tập trung vào việc cải thiện sự linh hoạt, thăng bằng, và giảm căng thẳng thông qua các tư thế và kỹ thuật thở. Phù hợp cho mọi lứa tuổi và thể trạng",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },
            #endregion

            #region Category Exercise 2
                new Category
                {
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    CategoryName = "Stretching",
                    CategoryType = "Exercise",
                    CategoryDescription = "Bài tập kéo giãn cơ giúp cải thiện biên độ chuyển động, giảm đau nhức cơ bắp, và tăng cường sự linh hoạt. Thường được sử dụng như phần khởi động hoặc thư giãn sau buổi tập",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fstretching.png?alt=media&token=b24dc2e8-9fc5-45f9-8cab-e4608cf7d94b",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },
            #endregion

            #region Category Exercise 3
                new Category
                {
                    CategoryId = Guid.Parse("045d39cf-5865-4e2a-9cd1-fd76628bdab4"),
                    CategoryName = "Cardio",
                    CategoryType = "Exercise",
                    CategoryDescription = "Các bài tập aerobic giúp tăng nhịp tim, cải thiện sức khỏe tim mạch, và đốt cháy calo nhanh. Thích hợp để giảm cân hoặc cải thiện thể lực tổng thể",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcardio.png?alt=media&token=48d97cab-feb1-4666-b230-fb0e46f85a52",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },
            #endregion

            #region Category Exercise 4
                new Category
                {
                    CategoryId = Guid.Parse("c440673d-c842-4aad-aa44-4a9b314529c4"),
                    CategoryName = "Core",
                    CategoryType = "Exercise",
                    CategoryDescription = "Các bài tập tăng cường sức mạnh cơ bụng, lưng dưới, và vùng thân trung tâm. Giúp cải thiện tư thế, thăng bằng, và giảm nguy cơ chấn thương",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fcore.png?alt=media&token=90645290-b62c-4155-ab49-2100b60ef2c0",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },
            #endregion

            #region Category Exercise 5
                new Category
                {
                    CategoryId = Guid.Parse("a1c1ef2d-6697-49d3-857b-882b288ffeef"),
                    CategoryName = "Breathing Exercises",
                    CategoryType = "Exercise",
                    CategoryDescription = "Các bài tập tập trung vào kỹ thuật thở sâu và có kiểm soát. Giúp thư giãn, giảm stress, và cải thiện khả năng hấp thụ oxy",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbreathing-exercises.png?alt=media&token=db3537f3-fcb5-41ff-9624-5ae8e9a09300",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },
            #endregion

            #region Category Exercise 6
                new Category
                {
                    CategoryId = Guid.Parse("d7c2a84c-2136-4f62-8d8e-4d70ec123f4f"),
                    CategoryName = "Balance Training",
                    CategoryType = "Exercise",
                    CategoryDescription = "Các bài tập giúp tăng cường khả năng thăng bằng và sự ổn định của cơ thể. Đặc biệt hữu ích cho người lớn tuổi hoặc những ai cần cải thiện khả năng giữ thăng bằng",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fbalance-training.png?alt=media&token=c3075070-d247-4e7d-be94-434977695c67",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },
            #endregion

            #region Category Exercise 7
                new Category
                {
                    CategoryId = Guid.Parse("cb81e687-8e2f-4814-99a6-808777410e02"),
                    CategoryName = "Pilates",
                    CategoryType = "Exercise",
                    CategoryDescription = "Bài tập kết hợp giữa các động tác chậm, có kiểm soát, tập trung vào sức mạnh cơ lõi, sự linh hoạt và tư thế. Phù hợp để cải thiện cơ bắp và giảm căng thẳng",
                    Image = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcategories%2Fpilates.png?alt=media&token=f4119977-0873-4ee8-bba2-497f6f403fd2",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                }
                #endregion
            );
        }
    }

}

