using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Core.Enum;
using Monhealth.Domain;
namespace Monhealth.Identity.Configurations
{
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            var admin = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6");
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region Food 1
            new Food
            {
                FoodId = Guid.Parse("599cfc95-4108-4dcc-9c5a-077173251f8b"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cơm",
                FoodDescription = "Cơm là thức ăn chủ yếu trong bữa ăn Việt Nam, cung cấp tinh bột quan trọng. Cơm thường ăn kèm với các món mặn như thịt, cá và rau, tạo nên một bữa ăn đầy đủ dinh dưỡng, bổ sung năng lượng cho cơ thể",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2512381/nutrients",
                Views = 100,
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 2
            new Food
            {
                FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner, MealType.Snack],
                // DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Bánh mì",
                FoodDescription = "Bánh mì là thức ăn nhanh, phổ biến với lớp vỏ giòn và nhân phong phú như thịt nướng, pate, trứng. Đây là lựa chọn lý tưởng cho bữa sáng hoặc bữa ăn nhẹ, dễ dàng mang theo và rất tiện lợi",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/325871/nutrients",
                Views = 100,
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 3
            new Food
            {
                FoodId = Guid.Parse("a989c8db-7506-467f-8aba-dce042f68eea"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack],
                // DishType = [DishType.Dessert],
                FoodName = "Chuối",
                FoodDescription = "Chuối là trái cây ngọt, dễ ăn, cung cấp vitamin C và kali. Chuối rất tốt cho hệ tiêu hóa và tim mạch. Món này thường được ăn trực tiếp, làm sinh tố hoặc chế biến thành các món tráng miệng như chè",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/1105073/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 4
            new Food
            {
                FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish, DishType.MainDish],
                FoodName = "Trứng gà luộc",
                FoodDescription = "Trứng gà luộc là thức ăn đơn giản, giàu protein, vitamin B12 và khoáng chất. Trứng gà thường được ăn sáng hoặc dùng làm món phụ trong bữa ăn chính, giúp cung cấp năng lượng và duy trì sức khỏe",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/747997/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 5
            new Food
            {
                FoodId = Guid.Parse("021b651c-bb01-4965-95bc-3532fbacad3d"),
                // CategoryId = sweets,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack],
                // DishType = [DishType.Drink],
                FoodName = "Sữa tươi không đường",
                FoodDescription = "Sữa tươi không đường là nguồn cung cấp canxi và protein giúp xương chắc khỏe. Nó cũng hỗ trợ phát triển cơ bắp, cung cấp vitamin A và D. Sữa tươi là thức uống bổ dưỡng cho bữa sáng hoặc giữa các bữa ăn",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/sua-khong-duong-co-tac-dung-gi-uong-sua-khong-duong-co-beo-khong-67019.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 6
            new Food
            {
                FoodId = Guid.Parse("8fa26c41-16b2-49f8-a284-856024a5f947"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bún bò huế",
                FoodDescription = "Bún bò Huế là thức ăn nổi tiếng với nước dùng đậm đà từ xương bò, mắm ruốc, và gia vị đặc trưng. Món này kết hợp bún, thịt bò, giò heo và rau sống, tạo nên hương vị thơm ngon, hấp dẫn cho bữa ăn",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/bun-bo-bao-nhieu-calo-an-bun-bo-co-tang-can-khong-69310.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 7
            new Food
            {
                FoodId = Guid.Parse("1387c20d-27a6-495b-a3a0-efbb715f6430"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Táo",
                FoodDescription = "Táo là trái cây giàu vitamin C và chất xơ, tốt cho tiêu hóa và hệ tim mạch. Táo có thể ăn trực tiếp hoặc làm sinh tố, salad, giúp tăng cường sức khỏe và cung cấp năng lượng tự nhiên cho cơ thể",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/1750339/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 8
            new Food
            {
                FoodId = Guid.Parse("ab2117f7-9940-44cb-b191-2dfabefac8c8"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Bún",
                FoodDescription = "Bún là thức ăn phổ biến ở Việt Nam, được chế biến từ gạo. Bún có thể kết hợp với các loại thịt, cá, hoặc rau, tạo thành những món như bún riêu, bún chả, bún bò Huế, mang lại hương vị đặc trưng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/bun-bao-nhieu-calo-an-bun-co-beo-khong-69881.html",
                Views = 100,
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 9
            new Food
            {
                FoodId = Guid.Parse("455bb5ed-ed2c-4172-8831-2b8a08614198"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner, MealType.Snack],
                // DishType = [DishType.SideDish],
                FoodName = "Dưa chuột",
                FoodDescription = "Dưa chuột là rau quả tươi mát, giúp giải nhiệt và làm đẹp da. Dưa chuột có thể ăn sống, làm salad, hoặc chế biến thành món xào và canh, rất thích hợp trong các bữa ăn hằng ngày để thanh lọc cơ thể",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2346406/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 10
            new Food
            {
                FoodId = Guid.Parse("1140212e-cdb4-4f25-92f6-9b9407a71163"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack],
                // DishType = [DishType.Dessert],
                FoodName = "Chuối tây",
                FoodDescription = "Chuối tây là trái cây ngọt, dễ ăn, giàu kali và vitamin. Chuối tây thường được ăn trực tiếp hoặc làm tráng miệng, sinh tố, chè. Đây là thức ăn bổ dưỡng và dễ tiêu hóa, thích hợp cho mọi lứa tuổi",
                ReferenceUrl = "https://www.vinmec.com/vie/bai-viet/gia-tri-dinh-duong-trong-qua-chuoi-vi",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 11
            new Food
            {
                FoodId = Guid.Parse("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack],
                // DishType = [DishType.Dessert],
                FoodName = "Chuối tiêu",
                FoodDescription = "Chuối tiêu là trái cây ngọt nhẹ, giàu kali và vitamin C, giúp hỗ trợ tiêu hóa và cung cấp năng lượng. Chuối tiêu có thể ăn trực tiếp hoặc chế biến thành các món tráng miệng như chè chuối hấp",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/1105073/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 12
            new Food
            {
                FoodId = Guid.Parse("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack],
                // DishType = [DishType.Dessert],
                FoodName = "Ổi",
                FoodDescription = "Ổi là trái cây giàu vitamin C, giúp tăng cường hệ miễn dịch và làm đẹp da. Ổi có thể ăn trực tiếp hoặc làm sinh tố, nước ép, rất tốt cho sức khỏe, đặc biệt là trong việc hỗ trợ tiêu hóa",
                ReferenceUrl = "https://www.vinmec.com/vie/bai-viet/oi-co-giam-can-khong-vi",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 13
            new Food
            {
                FoodId = Guid.Parse("77fe5e06-7fee-486d-a1a7-c031f2065490"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cơm tấm sườn",
                FoodDescription = "Cơm tấm sườn là thức ăn phổ biến ở miền Nam Việt Nam, bao gồm cơm tấm mềm mịn ăn kèm với sườn nướng và các loại rau sống. Món này mang lại hương vị đậm đà và đầy đủ dinh dưỡng",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2514745/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 14
            new Food
            {
                FoodId = Guid.Parse("86d88717-df08-4de6-b86d-870210864b46"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack],
                // DishType = [DishType.Dessert],
                FoodName = "Thanh long",
                FoodDescription = "Thanh long là trái cây ngọt, mát, chứa nhiều vitamin C và khoáng chất, giúp tăng cường sức đề kháng và làm đẹp da. Thanh long có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng",
                ReferenceUrl = "https://vikinutri.com/thuc-pham/qua-trai-cay/thanh-long",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 15
            new Food
            {
                FoodId = Guid.Parse("a41a3bc6-0f34-409f-9045-0807fbb4469b"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bún riêu cua",
                FoodDescription = "Bún riêu cua là thức ăn nổi tiếng với nước dùng chua ngọt, kết hợp với cua, bún và các loại rau sống. Thức ăn này mang hương vị đặc trưng và bổ dưỡng, phù hợp cho bữa trưa hoặc tối",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/mot-to-bun-rieu-bao-nhieu-calo-an-nhieu-bun-rieu-co-tot-khong-69176.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 16
            new Food
            {
                FoodId = Guid.Parse("7378ca5f-f1a8-4c23-a019-50af3012526f"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bánh bao",
                FoodDescription = "Bánh bao là thức ăn đơn giản, với lớp vỏ mềm mịn và nhân thịt heo hoặc trứng. Đây là thức ăn nhanh gọn, thường được ăn sáng hoặc làm món phụ trong các bữa ăn chính",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/banh-bao-bao-nhieu-calo-cach-an-banh-bao-khong-so-beo-68066.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 17
            new Food
            {
                FoodId = Guid.Parse("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bún thịt nướng",
                FoodDescription = "Bún thịt nướng là thức ăn gồm bún mềm, thịt nướng thơm ngon và các loại rau sống. Món này có thể ăn kèm với nước mắm pha, tạo thành một bữa ăn vừa thanh mát vừa đầy đủ dinh dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/bun-thit-nuong-bao-nhieu-calo-an-bun-thit-nuong-co-tang-can-khong-70788.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 18
            new Food
            {
                FoodId = Guid.Parse("42883b21-4cbd-40ce-850f-b0723f1766fe"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Cà chua",
                FoodDescription = "Cà chua là thực phẩm giàu vitamin C và chất xơ, có tác dụng làm đẹp da và hỗ trợ tiêu hóa. Cà chua có thể ăn sống, làm salad, hoặc chế biến thành các món xào, canh",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/1999634/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 19
            new Food
            {
                FoodId = Guid.Parse("f6cf96c8-adc3-43e0-af5a-8b19623fed94"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch],
                // DishType = [DishType.MainDish],
                FoodName = "Xôi mặn",
                FoodDescription = "Xôi mặn là thức ăn từ gạo nếp, kết hợp với thịt, lạp xưởng hoặc trứng. Món này thường được ăn vào buổi sáng hoặc trong các dịp đặc biệt, rất bổ dưỡng và dễ ăn",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/xoi-man-bao-nhieu-calo-dang-giam-can-an-xoi-man-duoc-khong-68118.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 20
            new Food
            {
                FoodId = Guid.Parse("eac10b91-8509-4986-b689-7ee3a3757a18"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Dưa hấu",
                FoodDescription = "Dưa hấu là trái cây giải nhiệt, chứa nhiều nước và vitamin C. Đây là thức ăn lý tưởng trong mùa hè, giúp cung cấp nước và dưỡng chất cho cơ thể, có thể ăn trực tiếp hoặc làm sinh tố",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/746770/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 21
            new Food
            {
                FoodId = Guid.Parse("dca16637-cf90-402f-921f-5c60e99e4bfa"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Chả lụa",
                FoodDescription = "Chả lụa là thức ăn được làm từ thịt heo xay nhuyễn, cuộn chặt và hấp chín. Món này thường dùng trong các bữa ăn chính, bánh mì hoặc cơm, mang lại hương vị ngọt mềm, thơm ngon",
                ReferenceUrl = "https://www.pharmacity.vn/cha-lua-bao-nhieu-calo-luu-y-can-nho-khi-an-va-bao-quan.htm",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 22
            new Food
            {
                FoodId = Guid.Parse("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cơm gạo lức",
                FoodDescription = "Cơm gạo lức được làm từ gạo lức chưa xay xát hoàn toàn, giàu chất xơ và dinh dưỡng. Món này cung cấp năng lượng lâu dài, tốt cho sức khỏe và rất phổ biến trong các bữa ăn hàng ngày",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/1-bat-com-gao-lut-bao-nhieu-calo-nhung-loi-ich-cua-gao-lut-doi-voi-suc-khoe.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 23
            new Food
            {
                FoodId = Guid.Parse("85822a08-7189-4e08-8f55-25c73698af92"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Xúc xích",
                FoodDescription = "Xúc xích là thức ăn làm từ thịt xay (thường là thịt heo hoặc bò), tẩm gia vị và nhồi vào ruột lợn, sau đó luộc hoặc nướng. Xúc xích dễ dàng chế biến và là thức ăn nhanh gọn cho bữa sáng hoặc bữa phụ",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/746779/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 24
            new Food
            {
                FoodId = Guid.Parse("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Ức gà",
                FoodDescription = "Ức gà là phần thịt ít mỡ, giàu protein và dễ chế biến. Món ức gà có thể nướng, xào, hấp hoặc luộc, cung cấp năng lượng và dưỡng chất cho cơ thể, phù hợp với bữa trưa hoặc tối",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/331960/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 25
            new Food
            {
                FoodId = Guid.Parse("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast, MealType.Lunch],
                // DishType = [DishType.SideDish],
                FoodName = "Bắp luộc",
                FoodDescription = "Bắp luộc là thức ăn đơn giản nhưng bổ dưỡng, chứa nhiều chất xơ và vitamin. Bắp luộc có thể ăn trực tiếp hoặc làm thức ăn kèm trong bữa ăn, đặc biệt là vào mùa hè",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2710826/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 26
            new Food
            {
                FoodId = Guid.Parse("a17722bf-899e-40e9-8e54-ae2fc8a34f44"),
                // CategoryId = fermented,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Sữa chua",
                FoodDescription = "Sữa chua là thức ăn từ sữa lên men, chứa nhiều vi khuẩn có lợi cho hệ tiêu hóa. Sữa chua có thể ăn trực tiếp hoặc làm thành các món tráng miệng, bổ dưỡng và dễ tiêu hóa",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2647437/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 27
            new Food
            {
                FoodId = Guid.Parse("19bbab17-91c6-410f-b566-b509d067e76e"),
                // CategoryId = grains,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Đậu hũ",
                FoodDescription = "Đậu hũ là thức ăn được làm từ đậu nành, giàu protein thực vật. Đậu hũ có thể chế biến theo nhiều cách như chiên, nấu canh hoặc xào, mang lại hương vị thanh nhẹ và tốt cho sức khỏe",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/thanh-phan-dinh-duong-cua-dau-phu-co-tac-dung-gi-doi-voi-suc-khoe-70437.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 28
            new Food
            {
                FoodId = Guid.Parse("21a4b410-e26d-444b-8b99-bf8b490e5dcf"),
                // CategoryId = vegetarian,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bánh bao chay",
                FoodDescription = "Bánh bao chay là thức ăn làm từ bột mì, nhân là các loại rau củ, đậu hũ hoặc nấm. Đây là thức ăn phù hợp cho những người ăn chay, với hương vị nhẹ nhàng và bổ dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/banh-bao-chay-bao-nhieu-calo-an-nhieu-co-tot-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 29
            new Food
            {
                FoodId = Guid.Parse("de097440-db5c-4d91-bd55-76618d70599d"),
                // CategoryId = drinks,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack],
                // DishType = [DishType.Drink],
                FoodName = "Nước cam",
                FoodDescription = "Nước cam là thức uống từ cam tươi, cung cấp vitamin C và chất chống oxy hóa. Nước cam là lựa chọn tuyệt vời để giải khát và bổ sung dưỡng chất cho cơ thể, đặc biệt trong mùa lạnh",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2003591/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 30
            new Food
            {
                FoodId = Guid.Parse("74181cd5-4b0b-48a9-9042-16d8789483d4"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Cà rốt",
                FoodDescription = "Cà rốt là rau củ giàu vitamin A, giúp cải thiện thị lực và sức khỏe da. Cà rốt có thể ăn sống, làm salad, hoặc chế biến thành các món xào, canh hoặc nước ép",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2258587/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 31
            new Food
            {
                FoodId = Guid.Parse("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cháo lòng",
                FoodDescription = "Cháo lòng là thức ăn sáng phổ biến, được làm từ cháo gạo nấu với các loại nội tạng heo như lòng, gan, dồi. Món này có vị đậm đà, thường ăn kèm với hành lá, rau thơm và gia vị",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/chao-long-bao-nhieu-calo-an-nhieu-co-bi-tang-can-khong-70854.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 32
            new Food
            {
                FoodId = Guid.Parse("65c7b876-87e2-4307-ab76-c72ca277b78c"),
                // CategoryId = fastFood,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Snack],
                // DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Bánh mì sandwich",
                FoodDescription = "Bánh mì sandwich là thức ăn nhanh với lớp bánh mì mềm, nhân có thể là thịt, rau, trứng hoặc phô mai. Đây là lựa chọn lý tưởng cho bữa sáng hoặc bữa phụ, dễ dàng mang theo khi đi làm hoặc đi học",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/325871/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 33
            new Food
            {
                FoodId = Guid.Parse("a47b1646-3576-46f0-a3b6-763a9c3f889b"),
                // CategoryId = drinks,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Drink],
                FoodName = "Nước dừa",
                FoodDescription = "Nước dừa là thức uống mát từ nước bên trong quả dừa, giúp giải nhiệt và bổ sung khoáng chất. Nó cũng rất tốt cho làn da và hệ tiêu hóa, thích hợp để uống trong mùa hè",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/gia-tri-dinh-duong-cua-nuoc-dua-va-nhung-luu-y-khi-su-dung.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 34
            new Food
            {
                FoodId = Guid.Parse("a3074169-6441-49cc-9ea7-79e240f6dda3"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack],
                // DishType = [DishType.Dessert],
                FoodName = "Xoài",
                FoodDescription = "Xoài là trái cây ngọt, thơm, giàu vitamin C và chất xơ. Xoài có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2710834/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 35
            new Food
            {
                FoodId = Guid.Parse("0a47589f-d177-46f9-8a10-63fd6da9b611"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Rau muống",
                FoodDescription = "Rau muống là loại rau lá xanh phổ biến ở Việt Nam, có thể xào, luộc hoặc làm canh. Rau muống giàu vitamin, khoáng chất và chất xơ, giúp hỗ trợ tiêu hóa và giải nhiệt",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/1999632/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 36
            new Food
            {
                FoodId = Guid.Parse("48113ca0-a1e7-4181-85fa-be6538a70873"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bún chả",
                FoodDescription = "Bún chả là thức ăn đặc sản Hà Nội, gồm bún, thịt chả nướng, và rau sống. Thức ăn này có nước mắm pha chua ngọt, tạo thành bữa ăn ngon miệng, đậm đà và rất dễ ăn",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/bun-cha-bao-nhieu-calo-cach-lam-bun-cha-ngon-tai-nha-70611.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 37
            new Food
            {
                FoodId = Guid.Parse("f77e03de-4ed3-41ca-8fa1-0a4947c67384"),
                // CategoryId = drinks,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack],
                // DishType = [DishType.Drink],
                FoodName = "Sữa hộp milo",
                FoodDescription = "Sữa hộp Milo là thức uống bổ dưỡng chứa nhiều vitamin và khoáng chất, phù hợp cho trẻ em và người lớn. Milo có hương vị ngọt ngào, thường được uống vào bữa sáng hoặc giữa các bữa ăn",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/uong-milo-co-tang-can-khong-65802.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 38
            new Food
            {
                FoodId = Guid.Parse("d4df84f2-2d79-41e6-b313-28e89e3785ba"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bánh canh",
                FoodDescription = "Bánh canh là thức ăn nổi bật với nước dùng đậm đà, có thể làm từ bún hoặc bánh canh, ăn kèm với các loại thịt như cua, tôm, hoặc giò heo. Món này rất phổ biến ở miền Trung và Nam Việt Nam",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/banh-canh-bao-nhieu-calo-an-nhieu-co-beo-khong-70511.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 39
            new Food
            {
                FoodId = Guid.Parse("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Hủ tiếu",
                FoodDescription = "Hủ tiếu là thức ăn gồm mì hoặc bún ăn kèm với nước dùng thơm ngon và các loại thịt như tôm, gà, hoặc heo. Món này phổ biến ở miền Nam Việt Nam và rất dễ ăn, thích hợp cho bữa sáng hoặc bữa tối",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/mot-to-hu-tieu-bao-nhieu-calo-an-hu-tieu-co-beo-khong-62454.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 40
            new Food
            {
                FoodId = Guid.Parse("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"),
                // CategoryId = drinks,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack],
                // DishType = [DishType.Drink],
                FoodName = "Cà phê",
                FoodDescription = "Cà phê là thức uống quen thuộc, có thể uống đen hoặc thêm sữa, với hương vị đậm đà và kích thích tinh thần. Cà phê thường được uống vào buổi sáng hoặc trong suốt cả ngày để duy trì sự tỉnh táo",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/ban-co-biet-trong-cafe-co-nhung-chat-gi-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 41
            new Food
            {
                FoodId = Guid.Parse("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"),
                // CategoryId = drinks,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack],
                // DishType = [DishType.Drink],
                FoodName = "Cà phê sữa",
                FoodDescription = "Cà phê sữa là thức uống phổ biến ở Việt Nam, được pha chế từ cà phê đen đặc kết hợp với sữa đặc ngọt. Món này có vị đắng nhẹ kết hợp với ngọt béo, thích hợp để uống vào buổi sáng để khởi đầu ngày mới",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/mot-ly-cafe-sua-bao-nhieu-calo-meo-uong-cafe-sua-khong-lo-beo-70894.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 42
            new Food
            {
                FoodId = Guid.Parse("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"),
                // CategoryId = drinks,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack],
                // DishType = [DishType.Drink],
                FoodName = "Sữa đậu nành",
                FoodDescription = "Sữa đậu nành là thức uống từ đậu nành xay nhuyễn, giàu protein và vitamin. Đây là thức ăn sáng phổ biến, bổ dưỡng, có thể uống nóng hoặc lạnh, đặc biệt tốt cho người ăn chay và những người muốn bổ sung dưỡng chất từ thực vật",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2257044/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 43
            new Food
            {
                FoodId = Guid.Parse("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Thịt kho tiêu",
                FoodDescription = "Thịt kho tiêu là thức ăn đơn giản nhưng thơm ngon, thường làm từ thịt ba chỉ hoặc thịt heo kho với tiêu, nước dừa và gia vị. Món này có vị mặn ngọt đậm đà, ăn cùng với cơm trắng rất hợp",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/331897/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 44
            new Food
            {
                FoodId = Guid.Parse("77243d82-a633-4fe8-84c9-61a4b6cd4428"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bún xào",
                FoodDescription = "Bún xào là thức ăn ngon miệng với bún xào cùng các loại rau và thịt hoặc tôm. Món này thường được chế biến nhanh, có vị thơm, ngọt từ các nguyên liệu kết hợp, thường ăn vào bữa trưa hoặc tối",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/1-phan-bun-xao-chay-bao-nhieu-calo.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 45
            new Food
            {
                FoodId = Guid.Parse("3222413a-e385-4a0b-9d07-2af7b0cb4276"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Cải thìa",
                FoodDescription = "Cải thìa là loại rau xanh giàu vitamin và khoáng chất, có thể chế biến theo nhiều cách như xào, luộc hoặc nấu canh. Cải thìa giúp giải nhiệt và tốt cho hệ tiêu hóa, thường dùng trong các bữa ăn gia đình",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2685572/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 46
            new Food
            {
                FoodId = Guid.Parse("e0eec003-8384-412c-a307-b0185afdb0c7"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch],
                // DishType = [DishType.MainDish],
                FoodName = "Xôi bắp",
                FoodDescription = "Xôi bắp là thức ăn sáng đơn giản, được làm từ gạo nếp và bắp, có vị ngọt tự nhiên của ngô. Món này dễ ăn, cung cấp năng lượng cho cả ngày dài, thường được ăn kèm với thịt hoặc các món mặn khác",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/xoi-bao-nhieu-calo-an-xoi-co-bi-beo-khong-68999.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 47
            new Food
            {
                FoodId = Guid.Parse("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Phở bò tái",
                FoodDescription = "Phở bò tái là món phở nổi tiếng với nước dùng trong, đậm đà từ xương bò, ăn kèm với thịt bò tái và bánh phở mềm. Thức ăn này rất phổ biến vào buổi sáng ở Việt Nam, mang lại cảm giác ấm cúng và no lâu",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/pho-bo-bao-nhieu-calo-cach-nau-pho-bo-an-ngon-ma-khong-so-beo-71012.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 48
            new Food
            {
                FoodId = Guid.Parse("da89578e-9470-4b18-af4f-0bdcc011882f"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Phở gà",
                FoodDescription = "Phở gà là thức ăn nhẹ nhàng, nước dùng thơm từ gà, ăn kèm với bánh phở và thịt gà. Món này có thể ăn vào buổi sáng hoặc bữa tối, rất thanh đạm nhưng đầy đủ dinh dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/pho-bao-nhieu-calo-bi-quyet-an-pho-khong-lo-tang-can-70657.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 49
            new Food
            {
                FoodId = Guid.Parse("37a66f5c-437f-4520-90ec-4376e0093061"),
                // CategoryId = drinks,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack],
                // DishType = [DishType.Drink],
                FoodName = "Nước chanh",
                FoodDescription = "Nước chanh là thức uống giải khát tuyệt vời, giúp cung cấp vitamin C, giải nhiệt và làm đẹp da. Món này có thể uống vào bất kỳ thời gian nào trong ngày, đặc biệt là trong mùa hè",
                ReferenceUrl = "https://www.pharmacity.vn/gia-tri-dinh-duong-qua-chanh.htm",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 50
            new Food
            {
                FoodId = Guid.Parse("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bánh mì thịt trứng",
                FoodDescription = "Bánh mì thịt trứng là thức ăn nhanh, với bánh mì mềm, nhân thịt nướng và trứng chiên. Đây là thức ăn sáng phổ biến, đơn giản nhưng đầy đủ dinh dưỡng, dễ ăn và tiện lợi",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/thac-mac-banh-mi-trung-bao-nhieu-calo-70592.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 51
            new Food
            {
                FoodId = Guid.Parse("16bf44f2-711d-4b64-a409-995c6b0c13ce"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Quýt",
                FoodDescription = "Quýt là trái cây ngọt, chứa nhiều vitamin C và giúp tăng cường hệ miễn dịch. Quýt có thể ăn trực tiếp hoặc làm nước ép, rất tốt cho sức khỏe, đặc biệt là giúp giải nhiệt trong mùa hè",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/746771/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 52
            new Food
            {
                FoodId = Guid.Parse("fa445aa4-7b0d-4d47-8ba7-f919dd123637"),
                // CategoryId = sweets,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Sữa chua nha đam",
                FoodDescription = "Sữa chua nha đam là món tráng miệng được làm từ sữa chua và nha đam tươi, giúp làm đẹp da và hỗ trợ tiêu hóa. Món này mát, dễ ăn và rất tốt cho sức khỏe, đặc biệt là trong thời tiết nóng",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2259793/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            // #region Food 53
            // new Food
            // {
            //     FoodId = Guid.Parse("05cfce09-72b4-482d-adcd-c0718015be3d"),
            //     // CategoryId = meat,
            //     UserId = admin,
            //     MealType = [MealType.Lunch, MealType.Dinner],
            //     // DishType = [DishType.MainDish],
            //     FoodName = "Bánh xèo",
            //     FoodDescription = "Bánh xèo là thức ăn truyền thống với vỏ bánh giòn, nhân tôm, thịt heo, giá đỗ và các loại rau. Món này thường được ăn kèm với nước mắm chua ngọt và rau sống, tạo nên hương vị đậm đà, hấp dẫn",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            #region Food 54
            new Food
            {
                FoodId = Guid.Parse("58fe08ca-5c52-4847-800e-b9970c3782f0"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Ớt chuông",
                FoodDescription = "Ớt chuông là loại rau quả giàu vitamin C, giúp tăng cường sức khỏe và làm đẹp da. Ớt chuông có thể ăn sống, xào, hoặc làm salad, mang lại hương vị tươi mát và màu sắc đẹp mắt cho bữa ăn",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2258590/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 55
            new Food
            {
                FoodId = Guid.Parse("1d0feb2f-0735-4333-87ce-09e22304ad0d"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Nấm kim châm",
                FoodDescription = "Nấm kim châm là loại nấm có thân dài và mỏng, thường được dùng trong các món canh, xào hoặc salad. Nấm kim châm giàu chất xơ và khoáng chất, rất tốt cho sức khỏe, đặc biệt là hệ tiêu hóa",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2003600/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            // #region Food 56
            // new Food
            // {
            //     FoodId = Guid.Parse("a782e478-d5c5-4da6-b809-180b48ad08c3"),
            //     // CategoryId = meat,
            //     UserId = admin,
            //     MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
            //     // DishType = [DishType.SideDish, DishType.MainDish],
            //     FoodName = "Lòng đỏ trứng gà",
            //     FoodDescription = "Lòng đỏ trứng gà là phần chứa nhiều chất béo, protein và vitamin, rất tốt cho sự phát triển của cơ thể. Lòng đỏ trứng gà thường được sử dụng trong các thức ăn như trứng bác, bánh hoặc các thức ăn kèm",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            // #region Food 57
            // new Food
            // {
            //     FoodId = Guid.Parse("f41484a3-c7df-4530-b7d2-060390103985"),
            //     // CategoryId = meat,
            //     UserId = admin,
            //     MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
            //     // DishType = [DishType.SideDish, DishType.MainDish],
            //     FoodName = "Lòng trắng trứng gà",
            //     FoodDescription = "Lòng trắng trứng gà chứa nhiều protein và ít chất béo, rất tốt cho sức khỏe. Lòng trắng trứng có thể chế biến thành các món như trứng luộc, trứng chưng, hoặc làm nguyên liệu trong các thức ăn khác",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            #region Food 58
            new Food
            {
                FoodId = Guid.Parse("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Hoành thánh",
                FoodDescription = "Hoành thánh là thức ăn từ bột mì, nhân thịt hoặc tôm, thường được nấu trong nước dùng thơm ngon. Món này có thể ăn trong các bữa sáng hoặc bữa tối, mang lại cảm giác ấm cúng và bổ dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/1-to-hoanh-thanh-bao-nhieu-calo-an-nhieu-co-tang-can-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 59
            new Food
            {
                FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Tôm",
                FoodDescription = "Tôm là hải sản giàu protein, omega-3 và vitamin, rất tốt cho sức khỏe tim mạch. Tôm có thể chế biến thành nhiều thức ăn như xào, hấp, hoặc nấu canh, tạo hương vị tươi ngon cho bữa ăn",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2684443/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 60
            new Food
            {
                FoodId = Guid.Parse("40f03f23-9341-4343-9bf8-fdfdb3b9f236"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Đậu bắp",
                FoodDescription = "Đậu bắp là loại rau quả giàu vitamin C và chất xơ, giúp hỗ trợ tiêu hóa và làm đẹp da. Đậu bắp có thể ăn luộc, xào hoặc làm canh, là thức ăn bổ dưỡng cho các bữa ăn gia đình",
                ReferenceUrl = "https://www.pharmacity.vn/dau-bap-thanh-phan-dinh-duong-va-tac-dung-doi-voi-suc-khoe.htm",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 61
            new Food
            {
                FoodId = Guid.Parse("dfa879e8-d77d-4199-b07b-16b37f1cbde1"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bánh canh cua",
                FoodDescription = "Bánh canh cua là thức ăn đặc trưng với nước dùng đậm đà từ cua, ăn kèm với bánh canh mềm và các loại rau. Món này rất phổ biến ở miền Nam và mang lại hương vị thơm ngon, bổ dưỡng",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2684446/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 62
            new Food
            {
                FoodId = Guid.Parse("c16aac77-64ee-476d-a646-a3029da83e41"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bánh bèo",
                FoodDescription = "Bánh bèo là thức ăn dân dã của miền Trung, gồm bánh làm từ bột gạo, thường được phủ lên trên các loại tôm, thịt hoặc mỡ hành. Món này có thể ăn kèm với nước mắm chua ngọt",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/mot-phan-banh-beo-bao-nhieu-calo.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 63
            new Food
            {
                FoodId = Guid.Parse("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bún mắm",
                FoodDescription = "Bún mắm là thức ăn nổi bật với nước dùng từ mắm, kết hợp với bún và các loại hải sản như tôm, cá. Đây là thức ăn đặc sản của miền Tây, mang lại hương vị đậm đà và rất thơm ngon",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/333374/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 64
            new Food
            {
                FoodId = Guid.Parse("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Cải thảo",
                FoodDescription = "Cải thảo là loại rau xanh, thường được dùng trong các món xào, nấu canh hoặc làm gỏi. Cải thảo chứa nhiều vitamin và khoáng chất, giúp hỗ trợ tiêu hóa và cải thiện sức khỏe",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2346407/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 65
            new Food
            {
                FoodId = Guid.Parse("51061170-597d-4289-a021-1e7dde88331f"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Thịt vịt",
                FoodDescription = "Thịt vịt là nguồn protein giàu chất dinh dưỡng, có thể chế biến thành nhiều món như vịt nướng, vịt kho hoặc vịt luộc. Món thịt vịt thường có hương vị đặc trưng, đậm đà và thích hợp cho các bữa ăn gia đình",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/an-thit-vit-co-tac-dung-gi-kham-pha-gia-tri-dinh-duong-va-loi-ich-suc-khoe-bat-ngo.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 66
            new Food
            {
                FoodId = Guid.Parse("c137f014-34c2-4f0a-be52-7c2a5c64abae"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Thịt gà",
                FoodDescription = "Thịt gà là nguồn protein nhẹ nhàng, giàu dinh dưỡng. Thịt gà có thể chế biến thành nhiều món như gà kho, gà luộc, hoặc gà xào. Đây là lựa chọn phổ biến trong các bữa ăn hàng ngày",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/331960/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 67
            new Food
            {
                FoodId = Guid.Parse("5ff26461-880d-4b94-bfd0-e8badc77fe33"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Thịt kho trứng",
                FoodDescription = "Thịt kho trứng là thức ăn quen thuộc với thịt heo kho cùng trứng luộc, mang hương vị mặn ngọt đậm đà. Món này thường ăn kèm với cơm trắng, rất ngon miệng và bổ dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/hoc-cach-lam-thit-kho-tau-va-cach-an-de-giu-gin-voc-dang-68648.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 68
            new Food
            {
                FoodId = Guid.Parse("73016f70-ebb4-4583-aa12-7f3f4633ada4"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Sườn non",
                FoodDescription = "Sườn non là phần thịt heo mềm, có thể chế biến thành nhiều món như sườn nướng, sườn kho hoặc sườn xào chua ngọt. Món sườn non rất thích hợp cho các bữa cơm gia đình, có vị đậm đà và dễ ăn",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2646168/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 69
            new Food
            {
                FoodId = Guid.Parse("0455b535-2662-43aa-bca2-3e75595fb181"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Thịt heo bằm",
                FoodDescription = "Thịt heo bằm là nguyên liệu dễ chế biến, thường được dùng trong các món như thịt heo bằm xào rau, làm nhân cho các món bánh bao hoặc canh. Món này có hương vị mềm mại và giàu dinh dưỡng",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2514745/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 70
            new Food
            {
                FoodId = Guid.Parse("d30f804f-c59b-4a59-bf4c-5196b302d1ed"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cơm chiên trứng",
                FoodDescription = "Cơm chiên trứng là thức ăn đơn giản nhưng ngon miệng, được làm từ cơm nguội xào cùng trứng, có thể thêm các loại rau và thịt tùy thích. Món này phù hợp cho bữa trưa hoặc tối nhanh gọn và đầy đủ dinh dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/com-chien-trung-bao-nhieu-calo-an-com-chien-co-tang-can-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 71
            new Food
            {
                FoodId = Guid.Parse("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cháo sườn",
                FoodDescription = "Cháo sườn là thức ăn sáng phổ biến, với cháo mềm mịn kết hợp cùng sườn heo kho hoặc hầm. Món này có vị ngọt tự nhiên từ xương, thường ăn kèm với hành lá, rau thơm và gia vị",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/chao-bao-nhieu-calo-chi-so-calo-va-gia-tri-dinh-duong-cua-mot-so-mon-chao-69360.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 72
            new Food
            {
                FoodId = Guid.Parse("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bánh bột lọc",
                FoodDescription = "Bánh bột lọc là thức ăn đặc trưng của miền Trung, gồm vỏ bánh làm từ bột năng, nhân tôm hoặc thịt, sau đó hấp chín. Món này thường ăn kèm với nước mắm chua ngọt và rau sống",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/banh-bot-loc-bao-nhieu-calo-co-phu-hop-cho-nguoi-giam-can-khong-69239.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 73
            new Food
            {
                FoodId = Guid.Parse("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bánh bao xá xíu",
                FoodDescription = "Bánh bao xá xíu là món bánh mềm mịn, với nhân thịt heo xá xíu thơm ngon. Món này rất phổ biến trong các bữa sáng hoặc bữa ăn nhanh gọn, giàu protein và dễ tiêu hóa",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/banh-bao-bao-nhieu-calo-cach-an-banh-bao-khong-so-beo-68066.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 74
            new Food
            {
                FoodId = Guid.Parse("faf19891-525a-4308-9222-992e83de7ce7"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Cá hồi",
                FoodDescription = "Cá hồi là loại hải sản giàu omega-3, tốt cho sức khỏe tim mạch. Cá hồi có thể chế biến thành nhiều món như nướng, hấp, hoặc làm sushi, mang lại hương vị tươi ngon và bổ dưỡng",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2684441/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 75
            new Food
            {
                FoodId = Guid.Parse("30355638-a0e2-4126-93ae-beb7aa9b5758"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Khoai lang",
                FoodDescription = "Khoai lang là một loại củ giàu vitamin và chất xơ, có thể chế biến thành các món như khoai lang luộc, chiên, hoặc làm món xào. Món này cung cấp năng lượng và rất tốt cho sức khỏe",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2346404/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 76
            new Food
            {
                FoodId = Guid.Parse("8893c58d-06fd-4c34-9e77-2f50779642dd"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Khoai tây",
                FoodDescription = "Khoai tây là nguồn cung cấp tinh bột và vitamin C. Khoai tây có thể chế biến thành nhiều món như khoai tây chiên, luộc, nghiền hoặc nướng, rất phổ biến trong các bữa ăn gia đình",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2346403/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 77
            new Food
            {
                FoodId = Guid.Parse("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Hành tây",
                FoodDescription = "Hành tây là loại củ gia vị phổ biến, mang lại hương vị thơm ngon cho các món xào, canh hoặc salad. Hành tây có tác dụng tốt cho sức khỏe tim mạch và giúp cải thiện hệ tiêu hóa",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/1104962/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 78
            new Food
            {
                FoodId = Guid.Parse("80ba2672-d26a-4703-98f0-d246a50f92f1"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Bầu",
                FoodDescription = "Bầu là loại rau quả mát, chứa nhiều vitamin và khoáng chất. Bầu có thể chế biến thành các món canh, xào hoặc làm gỏi, giúp thanh nhiệt và hỗ trợ tiêu hóa",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/tac-dung-cua-qua-bau-doi-voi-suc-khoe-goi-y-mot-so-mon-an-bo-duong-tu-qua-bau.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 79
            new Food
            {
                FoodId = Guid.Parse("a53672e7-8593-4779-bd02-9f02ae81f915"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Mực",
                FoodDescription = "Mực là hải sản giàu protein và khoáng chất, có thể chế biến thành các món xào, hấp, hoặc nướng. Mực có vị ngọt tự nhiên, giúp bổ sung dinh dưỡng và rất dễ ăn",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/gia-tri-dinh-duong-cua-muc-va-loi-ich-doi-voi-suc-khoe.html",
                Views = 27,
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 80
            new Food
            {
                FoodId = Guid.Parse("98006e54-c44e-4a81-aa99-d4bb95bfb89d"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Đậu que",
                FoodDescription = "Đậu que là loại rau quả giàu vitamin và chất xơ, có thể chế biến thành các món xào, luộc hoặc nấu canh. Đậu que giúp tăng cường hệ tiêu hóa và cung cấp năng lượng cho cơ thể",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2346400/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 81
            new Food
            {
                FoodId = Guid.Parse("fb7d87aa-2bb8-4065-bd31-b54239057405"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch],
                // DishType = [DishType.MainDish],
                FoodName = "Bánh ướt",
                FoodDescription = "Bánh ướt là thức ăn nhẹ làm từ bột gạo, có kết cấu mềm mịn, thường được ăn kèm với thịt heo, chả lụa và rau sống. Món này có thể được rưới nước mắm chua ngọt, mang lại hương vị thơm ngon và thanh mát",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/tiet-lo-banh-uot-bao-nhieu-calo-68814.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 82
            new Food
            {
                FoodId = Guid.Parse("f0132626-5535-4f30-9af4-7e89e086aaaf"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch],
                // DishType = [DishType.MainDish],
                FoodName = "Bánh cuốn",
                FoodDescription = "Bánh cuốn là thức ăn làm từ bột gạo, nhân thường là thịt băm, nấm hoặc trứng. Bánh cuốn mềm mịn, ăn kèm với nước mắm và rau sống, thường được dùng trong bữa sáng hoặc bữa phụ",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/cung-tim-hieu-banh-cuon-bao-nhieu-calo-68425.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 83
            new Food
            {
                FoodId = Guid.Parse("7268b449-cb54-4f3d-9709-f42b9966d707"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Canh bún",
                FoodDescription = "Canh bún là thức ăn nổi bật với nước dùng ngọt từ xương, kết hợp với bún, thịt heo hoặc tôm. Món này thường ăn kèm với rau sống và gia vị, mang lại hương vị đậm đà và dễ ăn",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/bun-bao-nhieu-calo-an-bun-co-beo-khong-69881.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 84
            new Food
            {
                FoodId = Guid.Parse("7b8500af-d730-4138-9617-cba352faed4a"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Vải",
                FoodDescription = "Vải là trái cây ngọt, chứa nhiều vitamin C và khoáng chất. Vải có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng, đặc biệt trong mùa hè",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/an-vai-thieu-co-tot-khong-an-nhu-the-nao-tot-cho-suc-khoe.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 85
            new Food
            {
                FoodId = Guid.Parse("dd1482e7-b3dd-4b17-80f6-5618a640c671"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Cá khô",
                FoodDescription = "Cá khô là thức ăn truyền thống, có thể làm từ nhiều loại cá, chế biến bằng cách phơi khô. Cá khô có vị mặn, thơm, thường được ăn kèm với cơm trắng hoặc làm nguyên liệu cho các món canh",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/hoi-dap-giam-can-an-ca-kho-co-beo-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 86
            new Food
            {
                FoodId = Guid.Parse("628d87df-0bde-417d-b8b5-5f8f5536410b"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Nấm đùi gà",
                FoodDescription = "Nấm đùi gà có hình dạng giống đùi gà, thịt nấm mềm và thơm. Món này thường được dùng trong các món xào, nấu canh hoặc làm salad, rất giàu dinh dưỡng và dễ chế biến",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2003599/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 87
            new Food
            {
                FoodId = Guid.Parse("fc85f2de-9aae-4ff4-a829-e01662a42976"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Mướp",
                FoodDescription = "Mướp là loại rau quả mát, chứa nhiều nước và vitamin. Mướp có thể chế biến thành canh, xào hoặc làm món gỏi, giúp thanh nhiệt, giải độc và tốt cho hệ tiêu hóa",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/muop-bao-nhieu-calo-an-muop-co-giup-giam-can-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 88
            new Food
            {
                FoodId = Guid.Parse("ef8b0ee3-a4d5-4883-af63-33c83d102bea"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bánh bao trứng cút",
                FoodDescription = "Bánh bao trứng cút là món bánh bao với nhân thịt heo hoặc đậu xanh, kèm trứng cút. Bánh có vỏ mềm, nhân thơm ngon, thường được ăn sáng hoặc làm thức ăn phụ trong các bữa ăn chính",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/banh-bao-bao-nhieu-calo-cach-an-banh-bao-khong-so-beo-68066.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 89
            new Food
            {
                FoodId = Guid.Parse("9122357a-179f-45f4-9106-67eea24d48ab"),
                // CategoryId = drinks,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Drink],
                FoodName = "Trà tắc",
                FoodDescription = "Trà tắc là thức uống giải khát phổ biến, được làm từ trà xanh kết hợp với nước cốt chanh tươi và mật ong. Trà tắc giúp giải nhiệt, thanh lọc cơ thể và mang lại cảm giác sảng khoái",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/tra-tac-bao-nhieu-calo-cach-pha-tra-tac-tot-cho-suc-khoe.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 90
            new Food
            {
                FoodId = Guid.Parse("22d1cbad-a884-400c-b681-30b17d98bf1c"),
                // CategoryId = grains,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish, DishType.MainDish],
                FoodName = "Đậu hũ non",
                FoodDescription = "Đậu hũ non là thức ăn được làm từ đậu nành, có kết cấu mềm mịn. Đậu hũ non có thể chế biến thành các món xào, canh hoặc ăn kèm với siro, là thức ăn dễ tiêu hóa và rất bổ dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/cach-lam-tau-hu-non-don-gian-tai-nha-68906.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            // #region Food 91
            // new Food
            // {
            //     FoodId = Guid.Parse("c81a404a-ec10-428e-acec-dd56ec1d3607"),
            //     // CategoryId = fermented,
            //     UserId = admin,
            //     MealType = [MealType.Lunch, MealType.Dinner],
            //     // DishType = [DishType.MainDish, DishType.SideDish],
            //     FoodName = "Nem chua",
            //     FoodDescription = "Nem chua là thức ăn đặc sản, được làm từ thịt heo xay nhuyễn, gia vị và gói trong lá chuối, lên men tự nhiên. Món này có vị chua nhẹ, thơm ngon, thường ăn kèm với tỏi, ớt hoặc rau sống",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            #region Food 92
            new Food
            {
                FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Cá ngừ",
                FoodDescription = "Cá ngừ là loại hải sản giàu omega-3 và protein, có thể chế biến thành nhiều món như cá ngừ nướng, cá ngừ kho hoặc làm sushi. Món này rất bổ dưỡng và dễ dàng chế biến",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/334194/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 93
            new Food
            {
                FoodId = Guid.Parse("87225215-43af-49f2-a40b-a5ebb087d27b"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Phở bò viên",
                FoodDescription = "Phở bò viên là món phở nổi tiếng với nước dùng trong, đậm đà từ xương bò, ăn kèm với bánh phở mềm và bò viên. Món này mang lại hương vị thơm ngon, phổ biến cho bữa sáng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/pho-bo-bao-nhieu-calo-cach-nau-pho-bo-an-ngon-ma-khong-so-beo-71012.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 94
            new Food
            {
                FoodId = Guid.Parse("23443efa-dc06-4e7a-949c-5c823ee6e575"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Khoai lang luộc",
                FoodDescription = "Khoai lang luộc là thức ăn đơn giản nhưng giàu dinh dưỡng, cung cấp vitamin A, chất xơ và khoáng chất. Khoai lang có thể ăn trực tiếp hoặc dùng làm thức ăn kèm trong các bữa chính",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2346403/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 95
            new Food
            {
                FoodId = Guid.Parse("afe0a180-0077-4fdf-89e8-9513c6132f92"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack],
                // DishType = [DishType.Dessert],
                FoodName = "Đu đủ",
                FoodDescription = "Đu đủ là trái cây ngọt, giàu vitamin C và enzym papain, giúp tiêu hóa tốt. Đu đủ có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng, rất tốt cho sức khỏe và làn da",
                ReferenceUrl = "https://www.vinmec.com/vie/bai-viet/cac-tac-dung-cua-du-du-chin-voi-suc-khoe-vi",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 96
            new Food
            {
                FoodId = Guid.Parse("16066b9b-e61f-4354-803b-e2f9c9f5a5db"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cháo đậu đỏ",
                FoodDescription = "Cháo đậu đỏ là thức ăn nhẹ nhàng, làm từ đậu đỏ và gạo, có tác dụng bổ máu, thanh nhiệt. Món này có thể ăn vào buổi sáng hoặc tối, rất bổ dưỡng và dễ tiêu hóa",
                ReferenceUrl = "https://www.vinmec.com/vie/bai-viet/dau-do-co-tac-dung-gi-vi",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            // #region Food 97
            // new Food
            // {
            //     FoodId = Guid.Parse("8ebd5a6e-b0af-42b6-af58-b681fceac1ef"),
            //     // CategoryId = sweets,
            //     UserId = admin,
            //     MealType = [MealType.Snack, MealType.Breakfast],
            //     // DishType = [DishType.Dessert],
            //     FoodName = "Chè đậu đen",
            //     FoodDescription = "Chè đậu đen là món tráng miệng phổ biến, làm từ đậu đen nấu nhừ, kết hợp với đường và có thể thêm nước cốt dừa. Món này ngọt mát, giúp thanh nhiệt và rất tốt cho sức khỏe",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            #region Food 98
            new Food
            {
                FoodId = Guid.Parse("da85064b-e528-4bfa-8a64-1fbe704f9af5"),
                // CategoryId = fermented,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Dưa cải chua",
                FoodDescription = "Dưa cải chua là thức ăn lên men, được làm từ cải thảo hoặc cải bẹ, mang vị chua nhẹ. Món này thường ăn kèm với cơm, giúp hỗ trợ tiêu hóa và bổ sung lợi khuẩn cho hệ tiêu hóa",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/324653/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 99
            new Food
            {
                FoodId = Guid.Parse("86bcbac3-fc75-46ed-8d0e-18c8c4860692"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Ức gà nướng",
                FoodDescription = "Ức gà nướng là thức ăn ít mỡ, giàu protein, có thể được ướp gia vị và nướng chín. Món này thường được ăn kèm với rau củ hoặc cơm, là lựa chọn tốt cho bữa ăn nhẹ nhàng nhưng đầy đủ dinh dưỡng",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2646170/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 100
            new Food
            {
                FoodId = Guid.Parse("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Thịt bò nạc",
                FoodDescription = "Thịt bò nạc là phần thịt ít mỡ, giàu protein và sắt, có thể chế biến thành các món như bò xào, nướng hoặc làm súp. Thức ăn này cung cấp năng lượng và dưỡng chất cho cơ thể, thích hợp cho các bữa chính",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/746758/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 101
            new Food
            {
                FoodId = Guid.Parse("edb9d5d0-01f3-4607-a406-9e04bbff85fb"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cá hồi nướng",
                FoodDescription = "Cá hồi nướng là thức ăn bổ dưỡng, giàu omega-3 và protein, thường được ướp gia vị trước khi nướng. Món này có hương vị ngọt tự nhiên, thích hợp ăn kèm với rau sống hoặc cơm",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2684441/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 102
            new Food
            {
                FoodId = Guid.Parse("4d640470-857a-4765-905f-e49e98a281a1"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Tôm hấp",
                FoodDescription = "Tôm hấp là thức ăn đơn giản, dễ chế biến, giữ nguyên vị ngọt của tôm. Món này thường được ăn kèm với muối tiêu chanh hoặc nước mắm chua ngọt, thích hợp cho bữa ăn nhẹ",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2684443/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 103
            new Food
            {
                FoodId = Guid.Parse("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Thịt lợn nạc",
                FoodDescription = "Thịt lợn nạc là phần thịt ít mỡ, dễ chế biến thành các món như xào, kho hoặc nướng. Món này cung cấp protein và chất sắt, thường được ăn trong các bữa chính",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2646168/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 104
            new Food
            {
                FoodId = Guid.Parse("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cá thu nướng",
                FoodDescription = "Cá thu nướng là thức ăn thơm ngon, giàu protein và omega-3. Cá thu thường được ướp gia vị rồi nướng, tạo nên thức ăn đậm đà và bổ dưỡng cho bữa tối",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/gia-tri-dinh-duong-cua-thit-ca-thu-va-nhung-luu-y-khi-su-dung.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 105
            new Food
            {
                FoodId = Guid.Parse("3fa8cf38-d835-4279-a113-a8f44cd013e6"),
                // CategoryId = grains,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Đậu nành luộc",
                FoodDescription = "Đậu nành luộc là thức ăn nhẹ, giàu protein và vitamin. Đậu nành có thể ăn trực tiếp hoặc chế biến thành các món như đậu hũ, giúp bổ sung dinh dưỡng cho cơ thể",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/dau-nanh-tuoi-thanh-phan-dinh-duong-va-cong-dung-tot-cho-suc-khoe.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 106
            new Food
            {
                FoodId = Guid.Parse("d3392e5d-a48f-4b5a-968d-31b98bd47835"),
                // CategoryId = sweets,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Sữa chua Hy Lạp",
                FoodDescription = "Sữa chua Hy Lạp là loại sữa chua đặc, chứa nhiều probiotics giúp hỗ trợ tiêu hóa. Món này có thể ăn trực tiếp hoặc kết hợp với trái cây tươi, mang lại cảm giác ngon miệng và bổ dưỡng",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/330137/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 107
            new Food
            {
                FoodId = Guid.Parse("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Ức vịt nướng",
                FoodDescription = "Ức vịt nướng là thức ăn ngon miệng, thịt vịt mềm và mọng nước khi được ướp gia vị và nướng chín. Món này có thể ăn kèm với cơm hoặc rau sống, mang lại hương vị đậm đà",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/vit-quay-bao-nhieu-calo-cach-che-bien-vit-quay-it-beo.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 108
            new Food
            {
                FoodId = Guid.Parse("5ebbc839-81e6-496f-9e4d-8d90d732a906"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Cá ngừ đóng hộp",
                FoodDescription = "Cá ngừ đóng hộp là thức ăn tiện lợi, giàu protein và omega-3. Món này có thể ăn trực tiếp, làm salad hoặc kèm với cơm, rất dễ chế biến và thích hợp cho bữa ăn nhanh",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/334194/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 109
            new Food
            {
                FoodId = Guid.Parse("50c0adac-c878-4a21-8b5f-01478e7e4852"),
                // CategoryId = vegetarian,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish, DishType.MainDish],
                FoodName = "Đậu hũ chiên",
                FoodDescription = "Đậu hũ chiên là thức ăn phổ biến trong các bữa ăn chay, có kết cấu giòn bên ngoài và mềm mịn bên trong. Món này có thể ăn kèm với các loại nước chấm hoặc xào với rau củ",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/dau-hu-chien-bao-nhieu-calo-an-dau-chien-co-bi-beo-khong-70795.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 110
            new Food
            {
                FoodId = Guid.Parse("55bd2b96-0e5f-4be4-acae-25f5e3e25244"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bò bít tết",
                FoodDescription = "Bò bít tết là thức ăn từ thịt bò nạc, được nướng hoặc áp chảo đến độ chín vừa phải. Món này thường được ăn kèm với khoai tây chiên hoặc rau sống, mang lại hương vị đậm đà, rất thích hợp cho bữa tối",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2646175/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 111
            new Food
            {
                FoodId = Guid.Parse("a23f6c85-1a80-4255-a9a1-d08c1d60e753"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cá hồi hun khói",
                FoodDescription = "Cá hồi hun khói là thức ăn giàu omega-3, có hương vị đậm đà và thơm ngon từ quá trình hun khói. Món này thường được ăn kèm với bánh mì hoặc làm thành salad, rất bổ dưỡng và dễ ăn",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2684441/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            // #region Food 112
            // new Food
            // {
            //     FoodId = Guid.Parse("b0f051be-5972-4e7a-a77d-47ec28d58993"),
            //     // CategoryId = grains,
            //     UserId = admin,
            //     MealType = [MealType.Snack],
            //     // DishType = [DishType.Snack],
            //     FoodName = "Hạt hạnh nhân",
            //     FoodDescription = "Hạt hạnh nhân là loại hạt giàu chất béo lành mạnh, vitamin E và protein. Hạnh nhân có thể ăn trực tiếp, làm snack hoặc thêm vào các món salad, mang lại lợi ích cho sức khỏe tim mạch",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            #region Food 113
            new Food
            {
                FoodId = Guid.Parse("8da16f72-42a9-4da2-b217-811903e340c4"),
                // CategoryId = grains,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Đậu hũ sốt cà",
                FoodDescription = "Đậu hũ sốt cà là thức ăn chay nhẹ nhàng, với đậu hũ mềm mịn ăn kèm với sốt cà chua đậm đà. Món này cung cấp protein thực vật và rất dễ chế biến, phù hợp cho các bữa ăn chay hoặc ăn kiêng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/dau-hu-bao-nhieu-calo-an-dau-hu-co-beo-khong-67626.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 114
            new Food
            {
                FoodId = Guid.Parse("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Thịt lợn xông khói",
                FoodDescription = "Thịt lợn xông khói có vị mặn ngọt, được chế biến bằng cách xông khói để tạo hương vị đặc trưng. Món này có thể ăn kèm với cơm, salad hoặc làm nhân cho bánh mì",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/749420/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            // #region Food 115
            // new Food
            // {
            //     FoodId = Guid.Parse("59988378-901f-4ec4-bd6c-9fdc28ca97a1"),
            //     // CategoryId = grains,
            //     UserId = admin,
            //     MealType = [MealType.Snack],
            //     // DishType = [DishType.Snack],
            //     FoodName = "Hạt bí ngô",
            //     FoodDescription = "Hạt bí ngô là món snack bổ dưỡng, giàu magiê và kẽm, có thể ăn trực tiếp hoặc rắc lên salad. Món này giúp tăng cường hệ miễn dịch và rất tốt cho sức khỏe tim mạch",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            #region Food 116
            new Food
            {
                FoodId = Guid.Parse("b29dc622-e8ae-4471-8e22-5676aa5fa909"),
                // CategoryId = grains,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Đậu Hà Lan luộc",
                FoodDescription = "Đậu hà lan luộc là thức ăn giàu protein và chất xơ, có thể ăn trực tiếp hoặc chế biến thành salad. Món này có vị ngọt tự nhiên, rất bổ dưỡng và dễ chế biến",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2644291/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 117
            new Food
            {
                FoodId = Guid.Parse("0f7f47a1-f122-4f58-9e24-40ece9323520"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Thịt gà quay",
                FoodDescription = "Thịt gà quay là thức ăn có lớp da giòn, thịt mềm, được ướp gia vị rồi quay chín. Món này thường được ăn kèm với cơm hoặc rau sống, rất ngon miệng và dễ ăn",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2514746/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 118
            new Food
            {
                FoodId = Guid.Parse("98b3945a-9169-4581-b1a5-da82f2ebd8d4"),
                // CategoryId = drinks,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack],
                // DishType = [DishType.Drink],
                FoodName = "Sữa bò tươi",
                FoodDescription = "Sữa bò tươi là thức uống bổ dưỡng, cung cấp canxi, vitamin D và protein. Sữa bò có thể uống trực tiếp hoặc làm nguyên liệu cho các món sinh tố, mang lại nhiều lợi ích cho sức khỏe xương",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/746772/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 119
            new Food
            {
                FoodId = Guid.Parse("c46676b3-cbcc-49e9-ad44-7d450a481a19"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Snack],
                // DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Yến mạch",
                FoodDescription = "Yến mạch là ngũ cốc giàu chất xơ và vitamin, giúp giảm cholesterol và hỗ trợ tiêu hóa. Món yến mạch có thể nấu cháo hoặc làm sinh tố, thích hợp cho bữa sáng bổ dưỡng",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/2261421/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 120
            new Food
            {
                FoodId = Guid.Parse("597a11b3-31a0-4e70-8d2f-95465ee03e8b"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Cải bó xôi",
                FoodDescription = "Cải bó xôi là rau xanh giàu vitamin A, C và chất sắt. Món cải bó xôi có thể ăn sống trong salad, xào hoặc nấu canh, giúp tăng cường sức khỏe xương và cải thiện hệ miễn dịch",
                ReferenceUrl = "https://fdc.nal.usda.gov/food-details/1999632/nutrients",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            // #region Food 121
            // new Food
            // {
            //     FoodId = Guid.Parse("4e46f955-4413-496f-97b4-968a38ee3e11"),
            //     // CategoryId = grains,
            //     UserId = admin,
            //     MealType = [MealType.Snack],
            //     // DishType = [DishType.Snack],
            //     FoodName = "Hạt hướng dương",
            //     FoodDescription = "Hạt hướng dương là loại hạt giàu vitamin E, chất béo lành mạnh và protein. Hạt có thể ăn trực tiếp như món snack hoặc thêm vào salad, rất tốt cho sức khỏe tim mạch và giúp cung cấp năng lượng",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            #region Food 122
            new Food
            {
                FoodId = Guid.Parse("644f32b3-897e-45b1-b4d7-aa8b9585a262"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Rau mồng tơi",
                FoodDescription = "Rau mồng tơi là loại rau xanh giàu vitamin A và chất sắt, có thể chế biến thành các món xào, luộc hoặc canh. Món rau này giúp thanh nhiệt, giải độc và tốt cho hệ tiêu hóa",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/rau-mong-toi-co-tac-dung-gi-va-luu-y-khi-an.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 123
            new Food
            {
                FoodId = Guid.Parse("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Lê",
                FoodDescription = "Lê là trái cây ngọt mát, giàu vitamin C và chất xơ, giúp cải thiện hệ tiêu hóa và làm đẹp da. Lê có thể ăn trực tiếp hoặc làm sinh tố, chè, mang lại hương vị tươi mát và bổ dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/le-bao-nhieu-calo-an-nhieu-le-co-tot-khong-70900.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 124
            new Food
            {
                FoodId = Guid.Parse("2e641c82-56f7-480d-b216-63723b5a5e7d"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Dâu tây",
                FoodDescription = "Dâu tây là trái cây ngọt, chứa nhiều vitamin C và chất chống oxy hóa, giúp làm đẹp da và tăng cường sức đề kháng. Dâu tây có thể ăn trực tiếp, làm sinh tố, hoặc chế biến thành các món tráng miệng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/gia-tri-dinh-duong-cua-dau-tay-va-loi-ich-doi-voi-suc-khoe.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 125
            new Food
            {
                FoodId = Guid.Parse("a8de2767-4b0a-41db-b33b-2523f5be2e0c"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Mâm xôi",
                FoodDescription = "Mâm xôi là trái cây giàu vitamin C và chất chống oxy hóa, có tác dụng tốt cho hệ miễn dịch và làn da. Mâm xôi có thể ăn trực tiếp hoặc làm sinh tố, chè, tráng miệng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/qua-mam-xoi-den-co-tac-dung-gi-voi-suc-khoe.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 126
            new Food
            {
                FoodId = Guid.Parse("00333cd3-f43b-40af-855e-95aa8a636e4a"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Bí đỏ",
                FoodDescription = "Bí đỏ là loại rau quả giàu vitamin A và C, giúp cải thiện thị lực và sức khỏe da. Bí đỏ có thể chế biến thành các món canh, xào, hoặc làm sinh tố, là thức ăn bổ dưỡng cho cả gia đình",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/thanh-phan-dinh-duong-cua-bi-do-gom-nhung-gi-co-tot-cho-suc-khoe-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 127
            new Food
            {
                FoodId = Guid.Parse("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Khoai môn",
                FoodDescription = "Khoai môn là loại củ giàu tinh bột và vitamin C, có thể chế biến thành các món xào, luộc, làm chè hoặc làm nhân bánh. Món khoai môn rất bổ dưỡng và dễ tiêu hóa",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/tac-dung-cua-khoai-mon-la-gi-doi-tuong-khong-nen-an-khoai-mon.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 128
            new Food
            {
                FoodId = Guid.Parse("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Măng tây",
                FoodDescription = "Măng tây là loại rau giàu vitamin K và chất chống oxy hóa, tốt cho sức khỏe tim mạch và hệ xương. Măng tây có thể xào, nấu canh hoặc ăn sống, rất bổ dưỡng và dễ chế biến",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/tac-dung-cua-mang-tay-co-the-ban-chua-biet-64818.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 129
            new Food
            {
                FoodId = Guid.Parse("ff348fc8-cd36-41c4-984f-a5884171f367"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Bắp cải tím",
                FoodDescription = "Bắp cải tím là loại rau giàu vitamin C và chất xơ, có thể chế biến thành salad, xào hoặc nấu canh. Món bắp cải tím giúp giải độc, hỗ trợ tiêu hóa và tốt cho sức khỏe tim mạch",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/tim-hieu-an-bap-cai-tim-co-tot-khong-70956.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 130
            new Food
            {
                FoodId = Guid.Parse("7b3216ff-858e-423e-b8db-a85571aa5488"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Kiwi",
                FoodDescription = "Kiwi là trái cây giàu vitamin C, chất xơ và chất chống oxy hóa. Kiwi giúp cải thiện hệ tiêu hóa, tăng cường sức đề kháng và làm đẹp da. Món này có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/kiwi-co-tac-dung-gi-voi-suc-khoe-huong-dan-cach-an-qua-kiwi-dung-73284.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            // #region Food 131
            // new Food
            // {
            //     FoodId = Guid.Parse("68c8c4c4-e5d6-4e15-ad60-1c18f0c1cb4d"),
            //     // CategoryId = grains,
            //     UserId = admin,
            //     MealType = [MealType.Breakfast, MealType.Snack],
            //     // DishType = [DishType.Snack],
            //     FoodName = "Hạt kê",
            //     FoodDescription = "Hạt kê là loại hạt giàu protein, chất xơ và khoáng chất như sắt và magiê. Hạt kê có thể nấu cháo, làm bánh hoặc thêm vào các món salad, là lựa chọn bổ dưỡng cho các bữa ăn nhẹ",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            #region Food 132
            new Food
            {
                FoodId = Guid.Parse("35cad577-0748-469f-8909-7dc013cf1c55"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Măng khô",
                FoodDescription = "Măng khô là thức ăn được làm từ măng tươi phơi khô, có thể chế biến thành các món canh hoặc xào. Măng khô có vị ngọt tự nhiên, giòn và là thức ăn bổ dưỡng trong các bữa ăn gia đình",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/mang-kho-co-tac-dung-gi-co-nen-an-nhieu-mang-kho-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 133
            new Food
            {
                FoodId = Guid.Parse("575e8bca-57e3-4d16-b380-545a046c9a4e"),
                // CategoryId = fermented,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Rong biển khô",
                FoodDescription = "Rong biển khô là thực phẩm giàu vitamin, khoáng chất và chất xơ, rất tốt cho sức khỏe. Món rong biển có thể dùng làm salad, súp, hoặc làm nhân cho sushi, rất phổ biến trong ẩm thực châu Á",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/gia-tri-dinh-duong-cua-rong-bien-va-mot-so-luu-y-khi-dung.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 134
            new Food
            {
                FoodId = Guid.Parse("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Bông cải xanh",
                FoodDescription = "Bông cải xanh (súp lơ) là loại rau chứa nhiều vitamin C, vitamin K và chất chống oxy hóa. Bông cải xanh có thể xào, luộc hoặc làm món canh, là thức ăn bổ dưỡng giúp cải thiện sức khỏe",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/gia-tri-dinh-duong-cua-bong-cai-xanh-la-gi-ai-nen-tranh-an-bong-cai-xanh.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 135
            new Food
            {
                FoodId = Guid.Parse("9b98036c-2047-4700-bb13-b34a432bb999"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Gạo lứt",
                FoodDescription = "Gạo lứt là loại gạo nguyên hạt, giàu chất xơ, vitamin và khoáng chất. Món gạo lứt có thể ăn kèm với các món thịt hoặc rau, giúp duy trì năng lượng lâu dài và rất tốt cho hệ tiêu hóa",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/thanh-phan-dinh-duong-cua-gao-lut-co-gi-dac-biet-hon-gao-trang-63152.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 136
            new Food
            {
                FoodId = Guid.Parse("1aa49363-ab95-4565-9e27-1855702197fd"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Nho",
                FoodDescription = "Nho là trái cây ngọt, giàu vitamin C và chất chống oxy hóa, có tác dụng tăng cường sức đề kháng và làm đẹp da. Nho có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/an-nho-co-tac-dung-gi-nho-chua-thanh-phan-dinh-duong-nhu-the-nao-67080.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 137
            new Food
            {
                FoodId = Guid.Parse("98c908b5-dad8-4db4-8d60-c6157c53d2c0"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Rau cải bó xôi",
                FoodDescription = "Rau cải bó xôi là loại rau xanh chứa nhiều vitamin A, C và chất sắt. Món cải bó xôi có thể ăn sống trong salad, xào hoặc nấu canh, rất bổ dưỡng và tốt cho sức khỏe xương",
                ReferenceUrl = "https://www.pharmacity.vn/cai-bo-xoi-tac-dung-tuyet-voi-doi-voi-suc-khoe-va-nhung-luu-y-can-tranh-khi-an.htm",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            // #region Food 138
            // new Food
            // {
            //     FoodId = Guid.Parse("9349fefa-ecbc-4afc-89f4-62c2f67eb441"),
            //     // CategoryId = grains,
            //     UserId = admin,
            //     MealType = [MealType.Lunch, MealType.Dinner],
            //     // DishType = [DishType.SideDish, DishType.MainDish],
            //     FoodName = "Đậu đen",
            //     FoodDescription = "Đậu đen là nguồn cung cấp protein thực vật và chất xơ tuyệt vời, giúp cải thiện hệ tiêu hóa. Đậu đen có thể nấu cháo, chè hoặc làm các món xào, rất bổ dưỡng cho sức khỏe",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            #region Food 139
            new Food
            {
                FoodId = Guid.Parse("857b3565-b170-4162-a97b-c0184c4258aa"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Củ cải đường",
                FoodDescription = "Củ cải đường là loại củ chứa nhiều vitamin C và khoáng chất, giúp cải thiện sức khỏe tim mạch và huyết áp. Món củ cải đường có thể ăn sống, xào hoặc nấu canh, mang lại lợi ích cho cơ thể",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/thanh-phan/cu-cai-duong",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 140
            new Food
            {
                FoodId = Guid.Parse("7cd76708-7312-445e-a392-14f0e806a786"),
                // CategoryId = grains,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Đậu Hà Lan",
                FoodDescription = "Đậu Hà Lan là loại rau giàu vitamin, khoáng chất và chất xơ, giúp hỗ trợ hệ tiêu hóa và tăng cường miễn dịch. Đậu Hà Lan có thể ăn trực tiếp, làm salad hoặc nấu canh",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/dau-ha-lan-va-nhung-loi-ich-cua-dau-ha-lan-doi-voi-suc-khoe.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            // #region Food 141
            // new Food
            // {
            //     FoodId = Guid.Parse("642480b4-22c9-4350-a6ce-c052f99e60e3"),
            //     // CategoryId = cereal,
            //     UserId = admin,
            //     MealType = [MealType.Breakfast, MealType.Snack],
            //     // DishType = [DishType.SideDish],
            //     FoodName = "Lúa mạch",
            //     FoodDescription = "Lúa mạch là ngũ cốc giàu chất xơ và protein, có thể chế biến thành cháo, bánh hoặc thêm vào các món salad. Lúa mạch giúp cải thiện tiêu hóa và cung cấp năng lượng bền vững cho cơ thể",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            #region Food 142
            new Food
            {
                FoodId = Guid.Parse("10869d8c-14b9-4464-85ca-bf76fc4bf91d"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Rau dền đỏ",
                FoodDescription = "Rau dền đỏ là loại rau xanh giàu vitamin C và chất xơ, giúp hỗ trợ tiêu hóa và tăng cường miễn dịch. Rau dền đỏ có thể xào, nấu canh hoặc làm món gỏi, rất bổ dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/rau-den-do-cong-dung-voi-suc-khoe-va-cac-mon-an-ngon-68989.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 143
            new Food
            {
                FoodId = Guid.Parse("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Mì gạo lứt",
                FoodDescription = "Mì gạo lứt được làm từ gạo lứt nguyên hạt, giàu chất xơ và vitamin. Món mì này có thể chế biến thành các món xào, soup hoặc ăn kèm với thịt, rất tốt cho sức khỏe và giúp giảm cholesterol",
                ReferenceUrl = "https://www.vinmec.com/vie/bai-viet/gia-tri-dinh-duong-cua-gao-lut-vi",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 144
            new Food
            {
                FoodId = Guid.Parse("9979963d-5c37-4fa9-955c-d1ecb5814607"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Rau chân vịt",
                FoodDescription = "Rau chân vịt (cải bó xôi) là loại rau giàu vitamin A, C và chất sắt, giúp tăng cường sức khỏe xương và hỗ trợ miễn dịch. Rau chân vịt có thể ăn sống trong salad, xào hoặc nấu canh",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/an-rau-chan-vit-co-tac-dung-gi-rau-chan-vit-an-song-duoc-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 145
            new Food
            {
                FoodId = Guid.Parse("845454d0-967a-4e48-aef3-bd8458775500"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Củ cải trắng",
                FoodDescription = "Củ cải trắng là loại rau củ giàu vitamin C và chất xơ, giúp thanh nhiệt và giải độc cơ thể. Món củ cải trắng có thể ăn sống, xào hoặc nấu canh, mang lại hương vị thanh mát và bổ dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/100g-cu-cai-trang-bao-nhieu-calo-loi-ich-suc-khoe-cu-cai-trang-mang-lai.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 146
            new Food
            {
                FoodId = Guid.Parse("6a88b8cb-dc82-4751-a2e4-23e5516d850b"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.SideDish],
                FoodName = "Rau má",
                FoodDescription = "Rau má là loại rau mát, giúp thanh nhiệt, giải độc và làm đẹp da. Rau má có thể ăn sống trong salad hoặc nấu canh, rất tốt cho sức khỏe và có tác dụng làm dịu cơ thể trong mùa hè",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/rau-ma-co-tac-dung-gi-an-rau-ma-bao-nhieu-la-du-68008.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            // #region Food 147
            // new Food
            // {
            //     FoodId = Guid.Parse("7729551a-e475-4079-aaa0-07c02efde2a5"),
            //     // CategoryId = grains,
            //     UserId = admin,
            //     MealType = [MealType.Snack, MealType.Breakfast],
            //     DishType = [DishType.Snack],
            //     FoodName = "Hạt lanh",
            //     FoodDescription = "Hạt lanh là nguồn tuyệt vời cung cấp omega-3, chất xơ và lignans, giúp bảo vệ tim mạch và giảm viêm. Hạt lanh có thể thêm vào các món sinh tố, salad hoặc dùng để nướng bánh",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            // #region Food 148
            // new Food
            // {
            //     FoodId = Guid.Parse("404a286a-90c5-4c54-8e27-3ddeba55ada3"),
            //     // CategoryId = grains,
            //     UserId = admin,
            //     MealType = [MealType.Snack],
            //     // DishType = [DishType.Snack],
            //     FoodName = "Hạt dẻ cười",
            //     FoodDescription = "Hạt dẻ cười là loại hạt giàu chất béo lành mạnh, vitamin E và khoáng chất, giúp bảo vệ tim mạch và cung cấp năng lượng. Hạt dẻ cười có thể ăn trực tiếp hoặc thêm vào các món tráng miệng, salad",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            #region Food 149
            new Food
            {
                FoodId = Guid.Parse("49601ef1-2131-478f-a1de-f2e444602be3"),
                // CategoryId = drinks,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Drink],
                FoodName = "Dừa tươi",
                FoodDescription = "Dừa tươi là thức uống giải khát tuyệt vời, giàu vitamin C và khoáng chất. Nước dừa cung cấp độ ẩm và giúp thanh nhiệt, rất tốt cho làn da và sức khỏe hệ tiêu hóa",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/gia-tri-dinh-duong-cua-nuoc-dua-va-nhung-luu-y-khi-su-dung.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 150
            new Food
            {
                FoodId = Guid.Parse("d3c360a2-441e-4700-a6ec-4310b5976901"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cá thu",
                FoodDescription = "Cá thu là loại hải sản giàu omega-3 và protein, rất tốt cho sức khỏe tim mạch. Cá thu có thể nướng, chiên hoặc kho, mang lại hương vị thơm ngon và bổ dưỡng cho bữa ăn",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/gia-tri-dinh-duong-cua-thit-ca-thu-va-nhung-luu-y-khi-su-dung.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            // #region Food 151
            // new Food
            // {
            //     FoodId = Guid.Parse("731974ef-495e-4c08-ba95-20589d60c20c"),
            //     // CategoryId = grains,
            //     UserId = admin,
            //     MealType = [MealType.Snack],
            //     // DishType = [DishType.Snack],
            //     FoodName = "Hạt mắc ca",
            //     FoodDescription = "Hạt mắc ca là loại hạt giàu chất béo lành mạnh, vitamin E và khoáng chất, giúp cải thiện sức khỏe tim mạch. Hạt có thể ăn trực tiếp hoặc thêm vào salad, rất bổ dưỡng và dễ tiêu hóa",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            #region Food 152
            new Food
            {
                FoodId = Guid.Parse("cb693182-b5ff-4f2b-9a47-44ab84841843"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Hồng xiêm",
                FoodDescription = "Hồng xiêm là trái cây ngọt, có hương vị đặc trưng, giàu vitamin C và khoáng chất. Món này có thể ăn trực tiếp hoặc chế biến thành các món tráng miệng, sinh tố, rất tốt cho sức khỏe",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/hong-xiem-co-tac-dung-gi-khi-chua-nhieu-thanh-phan-dinh-duong-69985.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 153
            new Food
            {
                FoodId = Guid.Parse("aaeb8b86-48b3-454c-a299-ec5a627f7047"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Đào",
                FoodDescription = "Đào là trái cây ngọt, mọng nước, chứa nhiều vitamin C và chất chống oxy hóa. Món này có thể ăn trực tiếp, làm sinh tố hoặc chế biến thành các món tráng miệng, giúp tăng cường sức đề kháng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/an-dao-co-nong-khong-nhung-loi-ich-cua-qua-dao-ban-nen-biet-68319.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 154
            new Food
            {
                FoodId = Guid.Parse("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Lựu",
                FoodDescription = "Lựu là trái cây giàu vitamin C, chất chống oxy hóa và khoáng chất. Món này có thể ăn trực tiếp hoặc làm nước ép, giúp cải thiện hệ miễn dịch và làm đẹp da",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/mot-qua-luu-bao-nhieu-calo-an-nhieu-luu-co-beo-khong-70683.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 155
            new Food
            {
                FoodId = Guid.Parse("5f848972-c5ae-45fc-8ba2-103b24d8a23a"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Súp cua",
                FoodDescription = "Súp cua là thức ăn nhẹ với nước dùng từ cua, mang hương vị ngọt tự nhiên và bổ dưỡng. Món này thường được ăn vào bữa sáng hoặc bữa tối, rất giàu protein và khoáng chất",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/sup-cua-bao-nhieu-calo-nhung-luu-y-can-biet-khi-an-mon-sup-cua.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 156
            new Food
            {
                FoodId = Guid.Parse("2ae82bfd-34db-4928-bfee-b60f4aec4460"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh bí đỏ",
                FoodDescription = "Canh bí đỏ là thức ăn thanh mát, giàu vitamin A và C. Canh bí đỏ có thể nấu với thịt heo hoặc tôm, mang lại hương vị ngọt tự nhiên, bổ dưỡng và dễ tiêu hóa",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/an-canh-bi-do-co-tac-dung-gi-nhung-dieu-can-luu-y-khi-an-bi-do.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 157
            new Food
            {
                FoodId = Guid.Parse("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh rau củ",
                FoodDescription = "Canh rau củ là thức ăn nhẹ nhàng, giàu vitamin và chất xơ, thích hợp cho các bữa ăn dinh dưỡng. Các loại rau như cà rốt, khoai tây, đậu que được nấu chung tạo thành món canh thơm ngon, dễ ăn",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/diem-danh-cac-loai-rau-cu-co-nhieu-chat-dam.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 158
            new Food
            {
                FoodId = Guid.Parse("6487a532-ff5e-4b77-b408-46c789608de9"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh bí đao",
                FoodDescription = "Canh bí đao là món canh mát, giúp giải nhiệt và thanh lọc cơ thể. Bí đao có thể nấu với tôm, thịt heo hoặc cá, mang lại hương vị thanh đạm và rất bổ dưỡng cho sức khỏe",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/bi-xanh-thanh-phan-dinh-duong-va-cong-dung-doi-voi-suc-khoe.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 159
            new Food
            {
                FoodId = Guid.Parse("63045676-0e70-425f-aa96-e348a4e88c3a"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh cua mồng tơi",
                FoodDescription = "Canh cua mồng tơi là thức ăn dân dã, có vị ngọt từ cua và mồng tơi. Món này không chỉ thơm ngon mà còn rất bổ dưỡng, đặc biệt tốt cho hệ tiêu hóa và làn da",
                ReferenceUrl = "https://www.vinmec.com/vie/bai-viet/rau-mong-toi-co-tot-khong-vi",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 160
            new Food
            {
                FoodId = Guid.Parse("827829bf-71cd-4865-80af-1457e0091456"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh nấm",
                FoodDescription = "Canh nấm là thức ăn nhẹ, bổ dưỡng, giàu vitamin và chất xơ. Nấm có thể kết hợp với rau củ hoặc thịt để tạo ra món canh thơm ngon, rất phù hợp cho bữa ăn thanh đạm",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/cac-loai-nam-an-duoc-chua-nhieu-vitamin-tot-cho-suc-khoe-68377.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 161
            new Food
            {
                FoodId = Guid.Parse("c5e3e4ed-0164-4917-a1ce-99679b971a22"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cháo gà",
                FoodDescription = "Cháo gà là thức ăn nhẹ, với cháo mịn và thịt gà chín mềm, thường ăn kèm với hành lá, rau thơm và gia vị. Món này dễ tiêu hóa, phù hợp cho bữa sáng hoặc khi bạn cảm thấy mệt mỏi",
                ReferenceUrl = "https://www.nhathuocankhang.com/ban-tin-suc-khoe/chao-bao-nhieu-calo-an-chao-co-beo-khong-1541669",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 162
            new Food
            {
                FoodId = Guid.Parse("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cháo sườn non",
                FoodDescription = "Cháo sườn non là thức ăn thơm ngon, với cháo được nấu từ xương sườn heo, có vị ngọt tự nhiên từ xương. Món này thường được ăn kèm với hành phi và gia vị, thích hợp cho bữa sáng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/chao-bao-nhieu-calo-chi-so-calo-va-gia-tri-dinh-duong-cua-mot-so-mon-chao-69360.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 163
            new Food
            {
                FoodId = Guid.Parse("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cháo thịt bằm",
                FoodDescription = "Cháo thịt bằm là món cháo có thịt heo xay nhuyễn, nấu cùng với gạo và gia vị. Món này bổ dưỡng, dễ ăn và dễ tiêu hóa, thích hợp cho bữa sáng hoặc bữa ăn nhẹ",
                ReferenceUrl = "https://www.nhathuocankhang.com/ban-tin-suc-khoe/chao-bao-nhieu-calo-an-chao-co-beo-khong-1541669",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 164
            new Food
            {
                FoodId = Guid.Parse("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bún chả cá",
                FoodDescription = "Bún chả cá là thức ăn với bún, chả cá chiên hoặc hấp và nước dùng từ cá. Thức ăn này có vị ngọt tự nhiên từ cá, rất phổ biến ở miền Trung và Nam Việt Nam",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/1-bat-bun-ca-bao-nhieu-calo-thanh-phan-dinh-duong-co-trong-bun-ca.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 165
            new Food
            {
                FoodId = Guid.Parse("7167f942-dc89-4f29-8022-588373aef45e"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bún gà",
                FoodDescription = "Bún gà là thức ăn thanh mát với bún, thịt gà luộc hoặc xé nhỏ và nước dùng thơm ngon. Đây là thức ăn nhẹ nhàng, thích hợp cho bữa sáng hoặc bữa trưa",
                ReferenceUrl = "https://www.nhathuocankhang.com/ban-tin-suc-khoe/bun-bao-nhieu-calo-an-bun-co-beo-khong-cach-an-1535795",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 166
            new Food
            {
                FoodId = Guid.Parse("d65c7826-78c0-4991-b3b6-1e2b25437f61"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bún hải sản",
                FoodDescription = "Bún hải sản là thức ăn đậm đà với bún, nước dùng từ hải sản và các loại hải sản như tôm, cua, mực. Món này có hương vị đặc trưng và rất bổ dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/bun-thai-bao-nhieu-calo-meo-an-bun-thai-khong-anh-huong-den-can-nang.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 167
            new Food
            {
                FoodId = Guid.Parse("90099162-15e0-4ef0-b93e-59d409678b63"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bún ốc",
                FoodDescription = "Bún ốc là thức ăn nổi bật với nước dùng chua ngọt từ ốc và gia vị, kết hợp với bún và các loại rau sống. Món này có vị thơm ngon, thích hợp cho bữa trưa hoặc tối",
                ReferenceUrl = "https://vaas.vn/kienthuc/Caylua/12/32_bunoc.htm",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 168
            new Food
            {
                FoodId = Guid.Parse("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cháo vịt",
                FoodDescription = "Cháo vịt là món cháo nấu với thịt vịt, có vị ngọt tự nhiên từ thịt và xương vịt. Món này thường được ăn vào bữa sáng hoặc bữa tối, giúp cung cấp năng lượng và dưỡng chất",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/chao-vit-bao-nhieu-calo-va-cach-giam-can-hieu-qua-voi-chao.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 169
            new Food
            {
                FoodId = Guid.Parse("9669cdf4-c133-476f-b2bd-f3c091346c52"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bánh mì chả cá",
                FoodDescription = "Bánh mì chả cá là thức ăn sáng quen thuộc, với bánh mì mềm, nhân chả cá chiên thơm ngon và rau sống. Món này rất phổ biến ở Việt Nam, tiện lợi và dễ ăn",
                ReferenceUrl = "https://yhocquocte.com/banh-mi-cha-ca-bao-nhieu-calo-va-an-co-beo-khong/",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 170
            new Food
            {
                FoodId = Guid.Parse("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Mì quảng",
                FoodDescription = "Mì quảng là món đặc sản của miền Trung, gồm mì gạo, nước dùng đậm đà, tôm, thịt hoặc trứng, và rau sống. Thức ăn này có vị đặc trưng và rất thích hợp cho bữa sáng hoặc trưa",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/mi-quang-bao-nhieu-calo-an-mi-quang-nhieu-co-tang-can-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 171
            new Food
            {
                FoodId = Guid.Parse("af036922-79f3-45a7-b562-a6279520c0e6"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Miến gà",
                FoodDescription = "Miến gà là thức ăn nhẹ với miến mềm, nước dùng thơm ngon từ gà, ăn kèm với thịt gà xé nhỏ. Món này rất dễ ăn, thích hợp cho bữa sáng hoặc bữa trưa nhẹ nhàng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/mien-bao-nhieu-calo-an-mien-co-giup-giam-can-khong-69440.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 172
            new Food
            {
                FoodId = Guid.Parse("00bc33fe-4cd5-47df-bd94-15ac9f93648c"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Súp rau củ",
                FoodDescription = "Súp rau củ là món canh thanh đạm với các loại rau củ như cà rốt, khoai tây, đậu que, nấu trong nước dùng nhẹ nhàng. Món này bổ dưỡng, dễ tiêu hóa và thích hợp cho các bữa ăn thanh mát",
                ReferenceUrl = "https://www.vinmec.com/vie/bai-viet/sup-rat-tot-cho-ban-vi",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 173
            new Food
            {
                FoodId = Guid.Parse("7b3935fa-e426-4dcd-b59f-2dbe8960956b"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Súp bò hầm",
                FoodDescription = "Súp bò hầm là thức ăn có nước dùng đậm đà từ xương bò, với thịt bò mềm và rau củ đi kèm. Món này cung cấp năng lượng và dưỡng chất, rất phù hợp cho bữa tối",
                ReferenceUrl = "https://fptshop.com.vn/tin-tuc/dien-may/sup-bao-nhieu-calo-169499",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 174
            new Food
            {
                FoodId = Guid.Parse("3426c7e8-055b-414f-84a3-eb9afdb1d33e"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Súp gà nấm",
                FoodDescription = "Súp gà nấm là thức ăn nhẹ nhàng với nước dùng từ gà và nấm, giúp thanh nhiệt và dễ tiêu hóa. Món này thường ăn vào bữa sáng hoặc khi cần bồi bổ cơ thể",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/sup-ga-bao-nhieu-calo-lieu-an-sup-ga-co-lam-tang-can-hay-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 175
            new Food
            {
                FoodId = Guid.Parse("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Súp hải sản",
                FoodDescription = "Súp hải sản là thức ăn đậm đà với nước dùng từ hải sản như tôm, cua, mực, nấu cùng với rau củ và gia vị. Món này rất bổ dưỡng và thích hợp cho các bữa ăn chính",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/nhung-loi-ich-suc-khoe-khi-an-sup-cua.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 176
            new Food
            {
                FoodId = Guid.Parse("a988cc73-072e-4af1-9b53-55fbf0f4fe79"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Rau xào",
                FoodDescription = "Rau xào là thức ăn đơn giản với rau củ được xào nhanh với gia vị. Món này thường sử dụng các loại rau như cải thảo, cải ngọt, giúp cung cấp vitamin và khoáng chất cho cơ thể",
                ReferenceUrl = "https://sacngockhang.com/an-rau-xao-co-beo-khong/?srsltid=AfmBOoo107l5DYDxTk4Uj16QAc9hLDvUhJ0TMMTE6qLjTqqabEXU6__1",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 177
            new Food
            {
                FoodId = Guid.Parse("2ee163f7-4463-44ec-b9e2-8a409c112db4"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Rau luộc",
                FoodDescription = "Rau luộc là thức ăn thanh mát, giúp bổ sung vitamin và khoáng chất, rất tốt cho sức khỏe. Các loại rau như rau muống, rau ngót thường được luộc và ăn kèm với nước mắm hoặc gia vị",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/loi-ich-suc-khoe-khi-an-rau-luoc-va-goi-y-mot-so-loai-rau-luoc-giau-dinh-duong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 178
            new Food
            {
                FoodId = Guid.Parse("01e60ae4-ff69-44d6-b4fd-aaf916e3a7e5"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cơm gà xối mỡ",
                FoodDescription = "Cơm gà xối mỡ là thức ăn đặc trưng với cơm trắng ăn kèm thịt gà chiên giòn, đậm đà với lớp mỡ giòn rụm. Món này thường được ăn kèm với dưa leo và rau sống",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/com-ga-xoi-mo-bao-nhieu-calo-an-nhieu-com-ga-xoi-mo-co-anh-huong-den-suc-khoe-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 179
            new Food
            {
                FoodId = Guid.Parse("eec3d874-6331-4e33-bbe6-bf0cc4335b29"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Salad rau",
                FoodDescription = "Salad rau là thức ăn nhẹ, là sự kết hợp của các loại rau tươi như xà lách, cà chua, dưa leo, trộn với nước sốt chua ngọt hoặc dầu olive. Món này bổ dưỡng, giàu vitamin và chất xơ",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/rau-xa-lach-bao-nhieu-calo-loi-ich-cua-viec-an-rau-xa-lach.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 180
            new Food
            {
                FoodId = Guid.Parse("90a605b6-843d-4cc1-8fe7-a016c76ee29c"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Rau muống luộc",
                FoodDescription = "Rau muống luộc là thức ăn đơn giản, dễ làm, rất phổ biến ở Việt Nam. Rau muống luộc có thể ăn kèm với nước mắm tỏi ớt hoặc làm thức ăn phụ trong bữa cơm, giúp thanh nhiệt và bổ sung dưỡng chất",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/rau-muong-bao-nhieu-calo-an-nhieu-co-tot-khong-68063.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 181
            new Food
            {
                FoodId = Guid.Parse("56513d2d-2472-4fa4-80bc-2f54002b187f"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh chua cá",
                FoodDescription = "Canh chua cá là thức ăn đậm đà với nước dùng chua ngọt, thường làm từ cá và các loại rau như giá đỗ, ngò rí, ăn kèm với bún. Món này thanh mát, giải nhiệt và rất bổ dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/mon-canh-chua-bao-nhieu-calo-an-canh-chua-co-gay-tang-can-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 182
            new Food
            {
                FoodId = Guid.Parse("2d821db4-3e99-4877-b979-bc82d34b3b01"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch],
                // DishType = [DishType.MainDish],
                FoodName = "Bánh mì ốp la",
                FoodDescription = "Bánh mì ốp la là thức ăn sáng phổ biến với bánh mì giòn, nhân trứng ốp la và có thể kèm thịt, rau. Đây là thức ăn nhanh gọn, dễ dàng và bổ dưỡng",
                ReferenceUrl = "https://www.nhathuocankhang.com/ban-tin-suc-khoe/1-o-banh-mi-bao-nhieu-calo-an-banh-mi-co-tang-can-1501276#:~:text=B%C3%A1nh%20m%C3%AC%20%E1%BB%91p%20la%20(b%C3%A1nh,%E1%BB%9Bt%20c%C3%B9ng%20v%E1%BB%9Bi%20b%C3%A1nh%20m%C3%AC.",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 183
            new Food
            {
                FoodId = Guid.Parse("29dfb5da-8818-40ff-bf66-7553521c2161"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bò kho",
                FoodDescription = "Bò kho là thức ăn với thịt bò hầm mềm mịn, nước dùng đậm đà với gia vị thơm ngon. Món này thường ăn kèm với bánh mì hoặc bún, là bữa ăn đầy đủ và ấm áp",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/bo-kho-bao-nhieu-calo-loi-ich-khi-an-bo-kho-70522.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 184
            new Food
            {
                FoodId = Guid.Parse("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh rau ngót",
                FoodDescription = "Canh rau ngót là món canh thanh mát, có vị ngọt tự nhiên từ rau ngót. Món này thường được nấu với thịt hoặc tôm, giúp giải nhiệt và bổ sung dinh dưỡng cho cơ thể",
                ReferenceUrl = "http://trungtamyte.tanphu.hochiminhcity.gov.vn/truyen-thong/rau-ngot-rat-tot-nhung-co-nen-an-hang-ngay-khong-cmobile981-13339.aspx#:~:text=Rau%20ng%C3%B3t%20r%E1%BA%A5t%20t%E1%BB%91t%20cho,%2C%2010%25%20%C4%91%E1%BB%91i%20v%E1%BB%9Bi%20k%E1%BA%BDm.",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 185
            new Food
            {
                FoodId = Guid.Parse("4edcae53-7e30-42bb-8526-7686355f2268"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh cải xanh",
                FoodDescription = "Canh cải xanh là món canh nhẹ, giàu vitamin và khoáng chất, thường được nấu với thịt heo hoặc tôm. Đây là thức ăn bổ dưỡng, dễ tiêu hóa và thích hợp cho các bữa ăn thanh đạm",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/cai-be-xanh-mon-rau-vi-thuoc-tot-cho-suc-khoe-ngay-tet-68651.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 186
            new Food
            {
                FoodId = Guid.Parse("0292d477-d63b-4904-a83b-2cd8cac39c14"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh củ quả",
                FoodDescription = "Canh củ quả là món canh với nhiều loại rau củ như cà rốt, khoai tây, đậu hà lan, nấu trong nước dùng nhẹ nhàng. Món này cung cấp nhiều vitamin và chất xơ, rất tốt cho sức khỏe",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/diem-danh-cac-loai-rau-cu-co-nhieu-chat-dam.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 187
            new Food
            {
                FoodId = Guid.Parse("b80c562a-e1d4-4117-a317-c06b5bae8950"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Thịt heo kho",
                FoodDescription = "Thịt heo kho là thức ăn với thịt heo được kho mềm, thấm đẫm gia vị mặn ngọt. Món này thường ăn kèm với cơm trắng, tạo thành một bữa ăn đậm đà và bổ dưỡng",
                ReferenceUrl = "https://www.bachhoaxanh.com/kinh-nghiem-hay/thit-kho-tau-co-bao-nhieu-calo-an-thit-kho-tau-co-beo-khong-1389756?srsltid=AfmBOorSOVl_aWLVeiWIQaKmJaFW789ctrvtLU_6CcL2EVJe8iDYaTo8",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 188
            new Food
            {
                FoodId = Guid.Parse("99ec20c3-f2a7-4727-9d12-a30f92d256cd"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Rau muống xào tỏi",
                FoodDescription = "Rau muống xào tỏi là thức ăn phổ biến, với rau muống tươi xào cùng tỏi và gia vị. Món này có vị đậm đà, thơm ngon, rất thích hợp ăn kèm với cơm trắng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/rau-muong-xao-toi-bao-nhieu-calo-an-nhieu-co-beo-khong-71266.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 189
            new Food
            {
                FoodId = Guid.Parse("3dc2fa80-ab87-4e26-907b-3516611371b8"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh bầu",
                FoodDescription = "Canh bầu là món canh thanh mát, với bầu nấu cùng nước dùng nhẹ nhàng từ xương hoặc thịt. Món canh này có tác dụng giải nhiệt, rất thích hợp trong những ngày hè nóng bức",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/tac-dung-cua-qua-bau-doi-voi-suc-khoe-goi-y-mot-so-mon-an-bo-duong-tu-qua-bau.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 190
            new Food
            {
                FoodId = Guid.Parse("2c990331-b6ca-4642-893a-be68f0d398d5"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Rau cải xanh",
                FoodDescription = "Rau cải xanh là loại rau giàu vitamin A, C và chất xơ, có thể chế biến thành các món xào, luộc hoặc nấu canh. Món rau cải xanh cung cấp nhiều dưỡng chất và giúp thanh nhiệt cho cơ thể",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/loi-ich-cua-rau-cai-doi-voi-suc-khoe.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 191
            new Food
            {
                FoodId = Guid.Parse("f0e4a066-b920-4540-a035-1a5504ff1358"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Mận",
                FoodDescription = "Mận là trái cây ngọt, mọng nước, chứa nhiều vitamin C và chất chống oxy hóa, giúp tăng cường sức đề kháng và làm đẹp da. Mận có thể ăn trực tiếp hoặc làm sinh tố, chè",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/tac-dung-cua-trai-man-mien-nam-va-nhung-luu-y-can-thiet-khi-an-trai-man-mien-nam.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 192
            new Food
            {
                FoodId = Guid.Parse("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Chôm chôm",
                FoodDescription = "Chôm chôm là trái cây ngọt, có vỏ đỏ hoặc vàng, mọng nước và giàu vitamin C. Món này rất thích hợp trong mùa hè, giúp giải nhiệt và bổ sung dinh dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/chom-chom-bao-nhieu-calo-va-co-loi-ich-gi-doi-voi-suc-khoe-69583.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 193
            new Food
            {
                FoodId = Guid.Parse("982d8f3e-f517-4bd2-87a8-48329fc9eb91"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh cải ngọt",
                FoodDescription = "Canh cải ngọt là thức ăn nhẹ nhàng, với cải ngọt nấu trong nước dùng, có thể kết hợp với thịt heo hoặc tôm. Món canh này bổ dưỡng, dễ tiêu hóa và giúp thanh nhiệt",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/cong-dung-cua-rau-cai-ngot-doi-voi-suc-khoe-con-nguoi.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 194
            new Food
            {
                FoodId = Guid.Parse("43d635e2-6f0c-4385-83d8-fedfd479d356"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Thịt gà kho",
                FoodDescription = "Thịt gà kho là thức ăn đậm đà với thịt gà kho trong gia vị như nước mắm, tiêu, và gia vị khác. Món này có thể ăn kèm với cơm trắng, mang lại hương vị ngon miệng và bổ dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/100g-thit-ga-bao-nhieu-calo-an-bao-nhieu-thit-ga-moi-ngay-la-du-70893.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 195
            new Food
            {
                FoodId = Guid.Parse("8ed85dc2-7654-4c48-81f9-19946a73f71d"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Bắp cải luộc",
                FoodDescription = "Bắp cải luộc là thức ăn thanh mát, dễ làm, chứa nhiều vitamin và khoáng chất. Bắp cải luộc có thể ăn kèm với nước mắm hoặc làm thức ăn phụ trong bữa ăn chính",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/goc-giai-dap-an-bap-cai-luoc-co-giam-can-khong-70967.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 196
            new Food
            {
                FoodId = Guid.Parse("881ae045-1c9a-4e20-9160-0e8c14486be5"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh mùng tơi mướp",
                FoodDescription = "Canh mùng tơi mướp là món canh mát, giải nhiệt, giúp bổ sung dưỡng chất và hỗ trợ tiêu hóa. Món này thường được nấu với thịt hoặc tôm, mang lại hương vị thanh đạm và bổ dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/giai-dap-thac-mac-rau-mong-toi-bao-nhieu-calo.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 197
            new Food
            {
                FoodId = Guid.Parse("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh rau dền",
                FoodDescription = "Canh rau dền là thức ăn nhẹ nhàng, thanh mát, thường được nấu với thịt hoặc tôm. Rau dền chứa nhiều vitamin và khoáng chất, giúp cải thiện sức khỏe và hỗ trợ tiêu hóa",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/rau-den-co-bao-nhieu-calo-rau-den-co-tac-dung-gi-voi-suc-khoe.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 198
            new Food
            {
                FoodId = Guid.Parse("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cơm chiên",
                FoodDescription = "Cơm chiên là thức ăn phổ biến, được làm từ cơm nguội chiên cùng với thịt, trứng và rau củ. Món này thường ăn kèm với dưa leo hoặc salad, rất dễ ăn và tiện lợi",
                ReferenceUrl = "https://www.nhathuocankhang.com/ban-tin-suc-khoe/com-chien-bao-nhieu-calo-an-com-chien-co-beo-khong-1512626#:~:text=Gi%C3%A1%20tr%E1%BB%8B%20dinh%20d%C6%B0%E1%BB%A1ng%20trong%20c%C6%A1m%20chi%C3%AAn,-C%C6%A1m%20chi%C3%AAn%20l%C3%A0&text=N%C4%83ng%20l%C6%B0%E1%BB%A3ng%3A%20238%20kcal.,%3A%2015%25%20t%E1%BB%95ng%20n%C4%83ng%20l%C6%B0%E1%BB%A3ng.",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 199
            new Food
            {
                FoodId = Guid.Parse("e370081a-c0a6-4c00-b01c-7c52f953b7f1"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh mướp",
                FoodDescription = "Canh mướp là thức ăn thanh mát với mướp nấu trong nước dùng nhẹ nhàng từ xương hoặc thịt. Món canh này có tác dụng giải nhiệt, rất thích hợp vào mùa hè",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/muop-bao-nhieu-calo-an-muop-co-giup-giam-can-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 200
            new Food
            {
                FoodId = Guid.Parse("9acdf58c-c37d-4026-a3f9-40fda186184b"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.SideDish],
                FoodName = "Cải ngọt luộc",
                FoodDescription = "Cải ngọt luộc là món rau luộc đơn giản, dễ làm, giàu vitamin và chất xơ. Món này thường ăn kèm với nước mắm chua ngọt hoặc làm thức ăn phụ trong các bữa ăn chính",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/cay-cai-ngot-bao-nhieu-calo-va-cong-dung-cua-cay-cai-ngot.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 201
            new Food
            {
                FoodId = Guid.Parse("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cá kho",
                FoodDescription = "Cá kho là thức ăn đậm đà với cá kho trong nước mắm, tiêu và các gia vị khác. Món này có thể ăn kèm với cơm trắng, mang lại hương vị mặn ngọt và rất bổ dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/ca-kho-bao-nhieu-calo-an-nhieu-co-beo-khong-71217.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 202
            new Food
            {
                FoodId = Guid.Parse("8382816f-1beb-4804-9698-3b486798b20a"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bánh mì chả lụa",
                FoodDescription = "Bánh mì chả lụa là thức ăn sáng phổ biến, với bánh mì giòn và nhân chả lụa thơm ngon. Món này đơn giản, dễ ăn và thích hợp cho bữa sáng hoặc bữa phụ",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/banh-mi-cha-bao-nhieu-calo-an-banh-mi-co-tot-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 203
            new Food
            {
                FoodId = Guid.Parse("2405ffc3-524e-4331-9e68-47a411d7b9b8"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cơm chiên dương châu",
                FoodDescription = "Cơm chiên dương châu là món cơm chiên với các loại rau củ, tôm, thịt, trứng, mang đến hương vị đậm đà và đầy đủ dinh dưỡng. Món này thích hợp cho bữa trưa hoặc tối",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/com-chien-duong-chau-bao-nhieu-calo-va-lua-chon-lanh-manh-thay-the.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            // #region Food 204
            // new Food
            // {
            //     FoodId = Guid.Parse("a1ff09f1-9d02-40a8-84de-8da9aad67c58"),
            //     // CategoryId = cereal,
            //     UserId = admin,
            //     MealType = [MealType.Lunch, MealType.Dinner],
            //     // DishType = [DishType.MainDish],
            //     FoodName = "Cơm rang",
            //     FoodDescription = "Cơm rang là thức ăn phổ biến, làm từ cơm nguội chiên với gia vị và các nguyên liệu như thịt, rau, trứng. Món này nhanh gọn, dễ chế biến và có thể ăn kèm với dưa leo hoặc salad",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            #region Food 205
            new Food
            {
                FoodId = Guid.Parse("2146faae-2e7c-4460-8d81-38f5d313012c"),
                // CategoryId = sweets,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Cháo đậu xanh",
                FoodDescription = "Cháo đậu xanh là thức ăn nhẹ, dễ tiêu hóa, được làm từ đậu xanh và gạo, có tác dụng bổ máu và thanh nhiệt. Món này có thể ăn vào bữa sáng hoặc tối, rất bổ dưỡng",
                ReferenceUrl = "https://www.vinmec.com/vie/bai-viet/thanh-phan-dinh-duong-trong-dau-xanh-vi",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            // #region Food 206
            // new Food
            // {
            //     FoodId = Guid.Parse("7a253877-3c54-4fcf-bb05-d9f4e14d5b64"),
            //     // CategoryId = cereal,
            //     UserId = admin,
            //     MealType = [MealType.Lunch, MealType.Dinner],
            //     // DishType = [DishType.MainDish],
            //     FoodName = "Mì xào thập cẩm",
            //     FoodDescription = "Mì xào thập cẩm là thức ăn với mì, các loại rau củ và thịt, xào chung với gia vị đậm đà. Món này dễ chế biến và là bữa ăn nhanh gọn nhưng đầy đủ dưỡng chất",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            #region Food 207
            new Food
            {
                FoodId = Guid.Parse("a950000c-9837-4d1b-b1ae-b9db230f8f1f"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Súp khoai tây",
                FoodDescription = "Súp khoai tây là món canh ngon và bổ dưỡng, với khoai tây nấu mềm trong nước dùng nhẹ nhàng. Món này thích hợp cho bữa tối, mang lại cảm giác ấm áp và dễ tiêu hóa",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/cong-thuc-sup-khoai-tay-pho-mai-cho-be-an-dam-giau-dinh-duong-70286.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            // #region Food 208
            // new Food
            // {
            //     FoodId = Guid.Parse("30f9d9dc-1653-495c-99b7-b649c49f7930"),
            //     // CategoryId = cereal,
            //     UserId = admin,
            //     MealType = [MealType.Breakfast, MealType.Lunch],
            //     // DishType = [DishType.MainDish],
            //     FoodName = "Bánh cuốn thịt bằm",
            //     FoodDescription = "Bánh cuốn thịt bằm là thức ăn được làm từ bột gạo, nhân thịt bằm, mộc nhĩ và gia vị, ăn kèm với nước mắm chua ngọt và rau sống. Món này rất phổ biến ở miền Bắc Việt Nam",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            #region Food 209
            new Food
            {
                FoodId = Guid.Parse("a364353c-d589-4a94-9c3b-3038113ea249"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bò xào rau củ",
                FoodDescription = "Bò xào rau củ là thức ăn ngon với thịt bò thái mỏng xào nhanh với các loại rau củ như ớt, hành tây, cà rốt. Món này cung cấp nhiều vitamin và protein, thích hợp cho bữa tối bổ dưỡng",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/thanh-phan-dinh-duong-cua-thit-bo-la-gi-cach-xao-thit-bo-mem-ngon-chuan-vi.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            // #region Food 210
            // new Food
            // {
            //     FoodId = Guid.Parse("cf9ab10f-2094-496b-9018-96b9d2e1af76"),
            //     // CategoryId = meat,
            //     UserId = admin,
            //     MealType = [MealType.Lunch, MealType.Dinner],
            //     // DishType = [DishType.MainDish],
            //     FoodName = "Cơm gà",
            //     FoodDescription = "Cơm gà là thức ăn đơn giản với cơm trắng ăn kèm thịt gà luộc hoặc chiên, thường được dùng kèm với nước mắm, rau sống và canh. Món này ngon miệng, dễ chế biến và bổ dưỡng",
            // ReferenceUrl= "",    
            // IsPublic = true,
            //     Status = true,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            //     CreatedBy = admin,
            //     UpdatedBy = admin,
            // },
            // #endregion

            #region Food 211
            new Food
            {
                FoodId = Guid.Parse("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"),
                // CategoryId = cereal,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.MainDish],
                FoodName = "Bánh hỏi",
                FoodDescription = "Bánh hỏi là thức ăn với bánh phở mềm, thường được ăn kèm với thịt nướng hoặc chả, và nước mắm pha. Món này có vị thanh nhẹ, rất phổ biến trong các bữa ăn ở miền Trung",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/banh-hoi-bao-nhieu-calo-an-banh-hoi-co-bi-tang-can-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 212
            new Food
            {
                FoodId = Guid.Parse("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"),
                // CategoryId = vegetables,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh bí đỏ nấu tôm",
                FoodDescription = "Canh bí đỏ nấu tôm là món canh nhẹ, thanh mát, với bí đỏ nấu mềm kết hợp với tôm. Món canh này giàu vitamin A và protein, giúp bổ dưỡng và dễ tiêu hóa",
                ReferenceUrl = "https://huongdantapluyen.tdtt.gov.vn/dinh-duong/ID/13508/Tom-nau-voi-bi-do-duoc-khong",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 213
            new Food
            {
                FoodId = Guid.Parse("3d19d971-88d0-4108-a335-24ac9e1dec50"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Măng cụt",
                FoodDescription = "Măng cụt là trái cây ngọt, mọng nước, chứa nhiều vitamin C và khoáng chất. Món này có thể ăn trực tiếp hoặc làm nước ép, mang lại cảm giác giải nhiệt và bổ sung dinh dưỡng",
                ReferenceUrl = "https://www.vinmec.com/vie/bai-viet/thanh-phan-dinh-duong-cua-qua-mang-cut-vi",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 214
            new Food
            {
                FoodId = Guid.Parse("a504d882-4f38-413e-bb28-fae1f2787150"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Nhãn",
                FoodDescription = "Nhãn là trái cây ngọt, mọng nước, chứa nhiều vitamin C và giúp tăng cường sức đề kháng. Nhãn có thể ăn trực tiếp hoặc làm sinh tố, tráng miệng, rất tốt cho sức khỏe",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/an-nhan-co-beo-khong-gia-tri-va-loi-ich-dinh-duong-cua-nhan-68691.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 215
            new Food
            {
                FoodId = Guid.Parse("9f624258-a4ee-4879-a23f-b3d0479f2b1b"),
                // CategoryId = fruits,
                UserId = admin,
                MealType = [MealType.Snack, MealType.Breakfast],
                // DishType = [DishType.Dessert],
                FoodName = "Cam",
                FoodDescription = "Cam là trái cây giàu vitamin C, giúp tăng cường miễn dịch và làm đẹp da. Cam có thể ăn trực tiếp hoặc làm nước ép, giúp giải nhiệt và bổ sung dinh dưỡng cho cơ thể",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/moi-ngay-an-1-qua-cam-co-tac-dung-gi-dung-nhieu-cam-co-sao-khong.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 216
            new Food
            {
                FoodId = Guid.Parse("d034b7e9-b5a2-42d7-95b7-c0c30207293d"),
                // CategoryId = seafood,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh hẹ tôm",
                FoodDescription = "Canh hẹ tôm là món canh thanh mát, với tôm và hẹ nấu chung trong nước dùng thơm ngon. Món này giúp bổ sung protein và vitamin, rất dễ ăn và thích hợp cho các bữa ăn nhẹ",
                ReferenceUrl = "https://www.nhathuocankhang.com/ban-tin-suc-khoe/nhung-loi-ich-suc-khoe-cua-la-he-1476545",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Food 217
            new Food
            {
                FoodId = Guid.Parse("85e621ed-0e0c-4d20-8891-51d311cea4a3"),
                // CategoryId = meat,
                UserId = admin,
                MealType = [MealType.Lunch, MealType.Dinner],
                // DishType = [DishType.Soup],
                FoodName = "Canh thịt bò hầm",
                FoodDescription = "Canh thịt bò hầm là món canh đậm đà, với thịt bò hầm mềm cùng các gia vị và rau củ. Món này bổ dưỡng, cung cấp nhiều protein và khoáng chất, thích hợp cho bữa tối hoặc bữa chính",
                ReferenceUrl = "https://nhathuoclongchau.com.vn/bai-viet/thit-bo-bao-nhieu-calo-gia-tri-dinh-duong-trong-thit-bo-70780.html",
                IsPublic = true,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            }
            #endregion
            );
        }
    }
}