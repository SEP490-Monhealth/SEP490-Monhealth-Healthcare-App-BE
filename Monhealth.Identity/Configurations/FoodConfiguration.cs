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
            #region Food 1
                new Food
                {
                    FoodId = Guid.Parse("599cfc95-4108-4dcc-9c5a-077173251f8b"),
                    CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                    UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),
                    FoodName = "Cơm",
                    FoodDescription = "Gạo nấu chín, món ăn cơ bản trong bữa cơm hàng ngày của người Việt Nam",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 2
                new Food
                {
                    FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"),
                    CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                    UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),
                    FoodName = "Bánh mì",
                    FoodDescription = "Bánh vỏ giòn, ruột mềm, dùng kèm nhiều loại nhân như thịt, trứng, rau",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 3
                new Food
                {
                    FoodId = Guid.Parse("a989c8db-7506-467f-8aba-dce042f68eea"),
                    CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                    UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),
                    FoodName = "Chuối",
                    FoodDescription = "Trái cây ngọt, giàu năng lượng và chất dinh dưỡng, dễ dàng mang theo",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 4
                new Food
                {
                    FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),
                    CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                    UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),
                    FoodName = "Trứng gà luộc",
                    FoodDescription = "Món ăn giàu protein, dễ chế biến, thường dùng trong bữa sáng hoặc ăn vặt",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 5
                new Food
                {
                    FoodId = Guid.Parse("021b651c-bb01-4965-95bc-3532fbacad3d"),
                    CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                                        UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

                    FoodName = "Sữa tươi không đường",
                    FoodDescription = "Thức uống giàu dinh dưỡng, bổ sung canxi, tốt cho sức khỏe xương và răng",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 6
                new Food
                {
                    FoodId = Guid.Parse("8fa26c41-16b2-49f8-a284-856024a5f947"),
                    CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                                        UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

                    FoodName = "Bún bò huế",
                    FoodDescription = "Món bún nước đậm đà từ Huế, nổi bật với hương sả, ớt, thịt bò",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 7
                new Food
                {
                    FoodId = Guid.Parse("1387c20d-27a6-495b-a3a0-efbb715f6430"),
                    CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                                        UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

                    FoodName = "Táo",
                    FoodDescription = "Trái cây giòn, ngọt, nhiều chất xơ và vitamin, tốt cho hệ tiêu hóa",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 8
                new Food
                {
                    FoodId = Guid.Parse("ab2117f7-9940-44cb-b191-2dfabefac8c8"),
                    CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                                        UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

                    FoodName = "Bún",
                    FoodDescription = "Sợi bún mềm, thường dùng trong các món nước hoặc xào",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 9
                new Food
                {
                    FoodId = Guid.Parse("455bb5ed-ed2c-4172-8831-2b8a08614198"),
                    CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                                        UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

                    FoodName = "Dưa chuột",
                    FoodDescription = "Rau quả mát, nhiều nước, thường ăn sống hoặc làm gỏi",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 10
                new Food
                {
                    FoodId = Guid.Parse("1140212e-cdb4-4f25-92f6-9b9407a71163"),
                    CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                                        UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

                    FoodName = "Chuối tây",
                    FoodDescription = "Chuối nhỏ, vị ngọt nhẹ, thường dùng làm món ăn nhẹ hoặc nấu chè",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 11
                new Food
                {
                    FoodId = Guid.Parse("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"),
                    CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                                        UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

                    FoodName = "Chuối tiêu",
                    FoodDescription = "Loại chuối phổ biến, vỏ vàng, thơm, ngọt, dùng làm món tráng miệng",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 12
                new Food
                {
                    FoodId = Guid.Parse("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"),
                    CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                                        UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

                    FoodName = "Ổi",
                    FoodDescription = "Trái cây nhiều vitamin C, giòn, ngọt hoặc chua nhẹ, ăn cả vỏ",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 13
                new Food
                {
                    FoodId = Guid.Parse("77fe5e06-7fee-486d-a1a7-c031f2065490"),
                    CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                                        UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

                    FoodName = "Cơm tấm sườn",
                    FoodDescription = "Món cơm từ gạo tấm, ăn kèm sườn nướng, đồ chua, và nước mắm",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 14
                new Food
                {
                    FoodId = Guid.Parse("86d88717-df08-4de6-b86d-870210864b46"),
                    CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                                        UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

                    FoodName = "Thanh long",
                    FoodDescription = "Trái cây mọng nước, thịt trắng hoặc đỏ, vị ngọt thanh mát",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 15
                new Food
                {
                    FoodId = Guid.Parse("a41a3bc6-0f34-409f-9045-0807fbb4469b"),
                    CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                                        UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

                    FoodName = "Bún riêu cua",
                    FoodDescription = "Món bún với nước lèo cua đồng, ăn kèm rau sống và mắm tôm",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 16
                new Food
                {
                    FoodId = Guid.Parse("7378ca5f-f1a8-4c23-a019-50af3012526f"),
                    CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                                        UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

                    FoodName = "Bánh bao",
                    FoodDescription = "Bánh hấp có nhân thịt, trứng, hoặc rau củ, mềm và thơm",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 17
                new Food
                {
                    FoodId = Guid.Parse("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"),
                    CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                                        UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

                    FoodName = "Bún thịt nướng",
                    FoodDescription = "Bún tươi kết hợp thịt nướng, rau sống, và nước mắm chua ngọt",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 18
                new Food
                {
                    FoodId = Guid.Parse("42883b21-4cbd-40ce-850f-b0723f1766fe"),
                    CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                                        UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

                    FoodName = "Cà chua",
                    FoodDescription = "Loại quả đỏ mọng, thường dùng làm nước sốt, canh, hoặc ăn sống",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 19
                new Food
                {
                    FoodId = Guid.Parse("f6cf96c8-adc3-43e0-af5a-8b19623fed94"),
                    CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                                        UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

                    FoodName = "Xôi mặn",
                    FoodDescription = "Món xôi từ gạo nếp, ăn kèm thịt, trứng, chả, và hành phi",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 20
                new Food
                {
                    FoodId = Guid.Parse("f44fd111-2744-406a-a706-abc9c0494502"),
                    CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                                        UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

                    FoodName = "Mật ong",
                    FoodDescription = "Chất ngọt tự nhiên từ ong, có lợi cho sức khỏe và làm đẹp",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
                },
            #endregion

            #region Food 21
    new Food
    {
        FoodId = Guid.Parse("eac10b91-8509-4986-b689-7ee3a3757a18"),
        CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Dưa hấu",
        FoodDescription = "Trái cây nhiều nước, vị ngọt mát, thích hợp trong ngày nóng",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 22
    new Food
    {
        FoodId = Guid.Parse("dca16637-cf90-402f-921f-5c60e99e4bfa"),
        CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Chả lụa",
        FoodDescription = "Giò heo hấp chín, mềm, thơm, thường dùng trong bánh mì, bánh cuốn",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 23
    new Food
    {
        FoodId = Guid.Parse("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"),
        CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Cơm gạo lức",
        FoodDescription = "Cơm từ gạo lức, giàu chất xơ, tốt cho sức khỏe tim mạch",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 24
    new Food
    {
        FoodId = Guid.Parse("85822a08-7189-4e08-8f55-25c73698af92"),
        CategoryId = Guid.Parse("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Xúc xích",
        FoodDescription = "Món ăn nhanh từ thịt xay nhuyễn, thích hợp cho bữa ăn nhẹ",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 25
    new Food
    {
        FoodId = Guid.Parse("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"),
        CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Ức gà",
        FoodDescription = "Phần thịt gà trắng, giàu đạm, ít béo, tốt cho người tập gym",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 26
    new Food
    {
        FoodId = Guid.Parse("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"),
        CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bắp luộc",
        FoodDescription = "Món bắp nấu chín, ngọt tự nhiên, thích hợp ăn sáng hoặc ăn vặt",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 27
    new Food
    {
        FoodId = Guid.Parse("a17722bf-899e-40e9-8e54-ae2fc8a34f44"),
        CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Sữa chua",
        FoodDescription = "Món ăn lên men từ sữa, giúp hỗ trợ tiêu hóa và làm đẹp da",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 28
    new Food
    {
        FoodId = Guid.Parse("19bbab17-91c6-410f-b566-b509d067e76e"),
        CategoryId = Guid.Parse("fe3a3546-b294-4665-9c82-092d4ab5a187"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Đậu hũ",
        FoodDescription = "Sản phẩm từ đậu nành, giàu protein thực vật, dùng trong nhiều món chay",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 29
    new Food
    {
        FoodId = Guid.Parse("21a4b410-e26d-444b-8b99-bf8b490e5dcf"),
        CategoryId = Guid.Parse("22ee062d-4904-4c64-a783-74b3e142aac7"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bánh bao chay",
        FoodDescription = "Bánh bao không nhân thịt, nhân rau củ hoặc đậu xanh",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 30
    new Food
    {
        FoodId = Guid.Parse("de097440-db5c-4d91-bd55-76618d70599d"),
        CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Nước cam",
        FoodDescription = "Thức uống tươi mát từ cam, cung cấp vitamin C tăng sức đề kháng",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 31
    new Food
    {
        FoodId = Guid.Parse("74181cd5-4b0b-48a9-9042-16d8789483d4"),
        CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Cà rốt",
        FoodDescription = "Rau củ màu cam, giàu vitamin A, tốt cho mắt và sức khỏe da",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 32
    new Food
    {
        FoodId = Guid.Parse("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"),
        CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Cháo lòng",
        FoodDescription = "Cháo gạo nấu với lòng heo, thơm béo, ăn kèm rau thơm",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 33
    new Food
    {
        FoodId = Guid.Parse("65c7b876-87e2-4307-ab76-c72ca277b78c"),
        CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bánh mì sandwich",
        FoodDescription = "Bánh mì lát, dễ ăn, thích hợp cho bữa sáng nhanh",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 34
    new Food
    {
        FoodId = Guid.Parse("a47b1646-3576-46f0-a3b6-763a9c3f889b"),
        CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Nước dừa",
        FoodDescription = "Thức uống giải khát tự nhiên, giàu khoáng chất",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 35
    new Food
    {
        FoodId = Guid.Parse("a3074169-6441-49cc-9ea7-79e240f6dda3"),
        CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Xoài",
        FoodDescription = "Trái cây nhiệt đới, thịt vàng, ngọt hoặc chua tùy giống",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 36
    new Food
    {
        FoodId = Guid.Parse("0a47589f-d177-46f9-8a10-63fd6da9b611"),
        CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Rau muống",
        FoodDescription = "Rau xanh thường luộc, xào hoặc làm gỏi, giàu chất xơ",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 37
    new Food
    {
        FoodId = Guid.Parse("48113ca0-a1e7-4181-85fa-be6538a70873"),
        CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bún chả",
        FoodDescription = "Món bún ăn kèm thịt nướng, rau sống, và nước chấm chua ngọt",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 38
    new Food
    {
        FoodId = Guid.Parse("f77e03de-4ed3-41ca-8fa1-0a4947c67384"),
        CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Sữa hộp milo",
        FoodDescription = "Thức uống ca cao bổ dưỡng, thích hợp cho trẻ em",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 39
    new Food
    {
        FoodId = Guid.Parse("d4df84f2-2d79-41e6-b313-28e89e3785ba"),
        CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bánh canh",
        FoodDescription = "Món ăn với sợi bánh dày, ăn cùng nước lèo đậm đà",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 40
    new Food
    {
        FoodId = Guid.Parse("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"),
        CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Hủ tíu",
        FoodDescription = "Món ăn miền Nam với sợi hủ tíu mềm, nước lèo thanh ngọt",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 41
    new Food
    {
        FoodId = Guid.Parse("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"),
        CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Cà phê",
        FoodDescription = "Thức uống đậm đà, kích thích tinh thần, uống nóng hoặc đá",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 42
    new Food
    {
        FoodId = Guid.Parse("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"),
        CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Cà phê sữa",
        FoodDescription = "Cà phê kết hợp sữa đặc, vị ngọt béo hấp dẫn",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 43
    new Food
    {
        FoodId = Guid.Parse("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"),
        CategoryId = Guid.Parse("22ee062d-4904-4c64-a783-74b3e142aac7"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Sữa đậu nành (không đường)",
        FoodDescription = "Thức uống từ đậu nành, ít ngọt, tốt cho sức khỏe",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 44
    new Food
    {
        FoodId = Guid.Parse("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"),
        CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Thịt kho tiêu",
        FoodDescription = "Món thịt heo nấu tiêu, nước mắm, thơm nồng, đậm đà",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 45
    new Food
    {
        FoodId = Guid.Parse("77243d82-a633-4fe8-84c9-61a4b6cd4428"),
        CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bún xào",
        FoodDescription = "Món bún xào cùng rau củ và thịt, thơm ngon, dễ ăn",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 46
    new Food
    {
        FoodId = Guid.Parse("3222413a-e385-4a0b-9d07-2af7b0cb4276"),
        CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Cải thìa",
        FoodDescription = "Loại rau xanh thường dùng trong món xào hoặc luộc",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 47
    new Food
    {
        FoodId = Guid.Parse("e0eec003-8384-412c-a307-b0185afdb0c7"),
        CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Xôi bắp",
        FoodDescription = "Xôi gạo nếp kết hợp bắp vàng ngọt, ăn kèm hành phi thơm",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 48
    new Food
    {
        FoodId = Guid.Parse("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"),
        CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Phở bò tái",
        FoodDescription = "Món phở với nước dùng đậm đà, thịt bò tái mềm ngon",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 49
    new Food
    {
        FoodId = Guid.Parse("da89578e-9470-4b18-af4f-0bdcc011882f"),
        CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Phở gà",
        FoodDescription = "Phở nước lèo thanh ngọt, ăn kèm thịt gà và rau thơm",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 50
    new Food
    {
        FoodId = Guid.Parse("27dd8629-4564-478a-b049-6c4b81ee3cf1"),
        CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Trứng vịt lộn",
        FoodDescription = "Trứng vịt luộc, chứa phôi phát triển, ăn kèm rau răm và muối tiêu",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 51
    new Food
    {
        FoodId = Guid.Parse("37a66f5c-437f-4520-90ec-4376e0093061"),
        CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Nước chanh",
        FoodDescription = "Thức uống giải khát, làm từ chanh tươi, cung cấp nhiều vitamin C",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 52
    new Food
    {
        FoodId = Guid.Parse("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"),
        CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bánh mì thịt trứng",
        FoodDescription = "Bánh mì giòn kẹp thịt, trứng và rau, ăn sáng nhanh tiện lợi",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 53
    new Food
    {
        FoodId = Guid.Parse("d9fa8f03-5825-4e83-88d3-1a7c49e39a7d"),
        CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bánh chưng",
        FoodDescription = "Món bánh truyền thống từ gạo nếp, thịt mỡ, đậu xanh",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 54
    new Food
    {
        FoodId = Guid.Parse("16bf44f2-711d-4b64-a409-995c6b0c13ce"),
        CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Quả quýt",
        FoodDescription = "Trái cây nhỏ, vị ngọt thanh, dễ bóc vỏ, giàu vitamin C",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 55
    new Food
    {
        FoodId = Guid.Parse("fa445aa4-7b0d-4d47-8ba7-f919dd123637"),
        CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Sữa chua nha đam",
        FoodDescription = "Sữa chua mịn kết hợp nha đam giòn, tốt cho tiêu hóa",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 56
    new Food
    {
        FoodId = Guid.Parse("f412d88d-ce7e-4006-bc11-75af61438491"),
        CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bánh tiêu",
        FoodDescription = "Loại bánh chiên phồng, thơm mùi mè, ngọt nhẹ",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 57
    new Food
    {
        FoodId = Guid.Parse("05cfce09-72b4-482d-adcd-c0718015be3d"),
        CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bánh xèo",
        FoodDescription = "Món bánh bột vàng giòn, nhân thịt, tôm, ăn kèm rau sống",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 58
    new Food
    {
        FoodId = Guid.Parse("58fe08ca-5c52-4847-800e-b9970c3782f0"),
        CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Ớt chuông",
        FoodDescription = "Rau quả màu sắc, giòn ngọt, giàu vitamin, thường dùng làm salad",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 59
    new Food
    {
        FoodId = Guid.Parse("1d0feb2f-0735-4333-87ce-09e22304ad0d"),
        CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Nấm kim châm",
        FoodDescription = "Loại nấm nhỏ dài, thơm ngon, thường dùng trong lẩu hoặc xào",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 60
    new Food
    {
        FoodId = Guid.Parse("a782e478-d5c5-4da6-b809-180b48ad08c3"),
        CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Lòng đỏ trứng gà",
        FoodDescription = "Phần trứng vàng, giàu dinh dưỡng và chất béo",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 61
    new Food
    {
        FoodId = Guid.Parse("f41484a3-c7df-4530-b7d2-060390103985"),
        CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Lòng trắng trứng gà",
        FoodDescription = "Phần trứng trắng, ít béo, giàu protein, thích hợp cho người ăn kiêng",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 62
    new Food
    {
        FoodId = Guid.Parse("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"),
        CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Hoành thánh",
        FoodDescription = "Món bột mỏng nhân thịt, hấp hoặc chiên, thường ăn kèm nước lèo",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 63
    new Food
    {
        FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"),
        CategoryId = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Tôm",
        FoodDescription = "Hải sản giàu đạm, chế biến đa dạng: hấp, chiên, xào, hoặc nướng",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 64
    new Food
    {
        FoodId = Guid.Parse("40f03f23-9341-4343-9bf8-fdfdb3b9f236"),
        CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Đậu bắp",
        FoodDescription = "Rau quả giòn, nhiều nhớt, thường dùng nấu canh hoặc luộc",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 65
    new Food
    {
        FoodId = Guid.Parse("dfa879e8-d77d-4199-b07b-16b37f1cbde1"),
        CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bánh canh cua",
        FoodDescription = "Món bánh canh với thịt cua, nước lèo đậm đà",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 66
    new Food
    {
        FoodId = Guid.Parse("a84ec8cd-f9d8-4723-8b9e-4ff4eee1685e"),
        CategoryId = Guid.Parse("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Cá viên chiên",
        FoodDescription = "Món ăn vặt từ cá xay, chiên giòn, chấm kèm tương ớt",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 67
    new Food
    {
        FoodId = Guid.Parse("46b9f487-dc6d-4c1d-9729-9f707ac28202"),
        CategoryId = Guid.Parse("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Hamburger",
        FoodDescription = "Bánh mì tròn kẹp thịt, phô mai, rau, và nước sốt",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 68
    new Food
    {
        FoodId = Guid.Parse("c16aac77-64ee-476d-a646-a3029da83e41"),
        CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bánh bèo",
        FoodDescription = "Món bánh bột gạo nhỏ, ăn kèm tôm cháy và nước mắm",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 69
    new Food
    {
        FoodId = Guid.Parse("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"),
        CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bún mắm",
        FoodDescription = "Món bún với nước lèo mắm cá, đậm đà, ăn kèm hải sản và rau",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 70
    new Food
    {
        FoodId = Guid.Parse("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"),
        CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Cải thảo",
        FoodDescription = "Rau xanh giòn, thường dùng làm kim chi hoặc xào",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 71
    new Food
    {
        FoodId = Guid.Parse("51061170-597d-4289-a021-1e7dde88331f"),
        CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Thịt vịt",
        FoodDescription = "Loại thịt mềm, ngọt, chế biến thành món quay, hấp, hoặc nấu cháo",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 72
    new Food
    {
        FoodId = Guid.Parse("c137f014-34c2-4f0a-be52-7c2a5c64abae"),
        CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Thịt gà",
        FoodDescription = "Thịt gia cầm phổ biến, dùng trong nhiều món nướng, luộc, hầm",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 73
    new Food
    {
        FoodId = Guid.Parse("5ff26461-880d-4b94-bfd0-e8badc77fe33"),
        CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Thịt kho trứng",
        FoodDescription = "Món thịt nấu cùng trứng và nước mắm, vị ngọt mặn hấp dẫn",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 74
    new Food
    {
        FoodId = Guid.Parse("73016f70-ebb4-4583-aa12-7f3f4633ada4"),
        CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Sườn non",
        FoodDescription = "Phần sườn heo mềm, ngon, thích hợp nấu canh hoặc kho",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 75
    new Food
    {
        FoodId = Guid.Parse("0455b535-2662-43aa-bca2-3e75595fb181"),
        CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Thịt heo bằm",
        FoodDescription = "Thịt heo xay nhuyễn, dùng nấu canh, xào, hoặc làm nhân",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 76
    new Food
    {
        FoodId = Guid.Parse("d30f804f-c59b-4a59-bf4c-5196b302d1ed"),
        CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Cơm chiên trứng",
        FoodDescription = "Cơm chiên vàng với trứng gà, thêm hành phi thơm ngon",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 77
    new Food
    {
        FoodId = Guid.Parse("3965d7c0-e550-497d-9b41-ea382c2bb83e"),
        CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Sting",
        FoodDescription = "Nước tăng lực vị dâu, ngọt và kích thích tinh thần",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 78
    new Food
    {
        FoodId = Guid.Parse("c60b8720-2ced-426c-b39b-606757200893"),
        CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Pepsi",
        FoodDescription = "Nước ngọt có ga, vị cola đặc trưng, dùng kèm bữa ăn nhanh",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 79
    new Food
    {
        FoodId = Guid.Parse("dc49c7a4-cf6a-4b85-a5e0-5f923730464a"),
        CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Coca cola",
        FoodDescription = "Thức uống giải khát có ga, vị ngọt thanh",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 80
    new Food
    {
        FoodId = Guid.Parse("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"),
        CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Cháo sườn",
        FoodDescription = "Cháo gạo trắng nấu nhuyễn, thêm sườn heo mềm ngọt",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 81
    new Food
    {
        FoodId = Guid.Parse("81af247b-f112-4b7c-981c-d1ba1c3a3644"),
        CategoryId = Guid.Parse("fc7f66aa-8c09-46db-a679-be440e3ed91f"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Kim chi",
        FoodDescription = "Rau cải thảo lên men, cay nồng, thường ăn kèm món nướng",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 82
    new Food
    {
        FoodId = Guid.Parse("face3a50-e5e6-41e3-83e8-f96e7c8c98d4"),
        CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bánh đúc",
        FoodDescription = "Bánh bột gạo mềm, ăn kèm mắm tôm, thịt bằm",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 83
    new Food
    {
        FoodId = Guid.Parse("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"),
        CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bánh bột lọc",
        FoodDescription = "Món bánh trong suốt, nhân tôm thịt, thường hấp hoặc luộc",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 84
    new Food
    {
        FoodId = Guid.Parse("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"),
        CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bánh bao xá xíu",
        FoodDescription = "Bánh hấp nhân thịt xá xíu, mềm, thơm ngọt",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 85
    new Food
    {
        FoodId = Guid.Parse("faf19891-525a-4308-9222-992e83de7ce7"),
        CategoryId = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Cá hồi",
        FoodDescription = "Loại cá béo, giàu omega-3, thường ăn sống hoặc nướng",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 86
    new Food
    {
        FoodId = Guid.Parse("30355638-a0e2-4126-93ae-beb7aa9b5758"),
        CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Khoai lang",
        FoodDescription = "Loại củ ngọt tự nhiên, dùng luộc, nướng hoặc chiên",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 87
    new Food
    {
        FoodId = Guid.Parse("8893c58d-06fd-4c34-9e77-2f50779642dd"),
        CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Khoai tây",
        FoodDescription = "Loại củ mềm, dùng làm khoai chiên, nghiền hoặc hầm",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 88
    new Food
    {
        FoodId = Guid.Parse("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"),
        CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Hành tây",
        FoodDescription = "Loại rau củ thơm, thường dùng làm gia vị hoặc ăn sống",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 89
    new Food
    {
        FoodId = Guid.Parse("80ba2672-d26a-4703-98f0-d246a50f92f1"),
        CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bầu",
        FoodDescription = "Loại quả dài, xanh, dùng nấu canh hoặc xào",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 90
    new Food
    {
        FoodId = Guid.Parse("c5822776-96df-4208-82b2-02f22594063b"),
        CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bánh cam",
        FoodDescription = "Bánh tròn chiên giòn, nhân đậu xanh, ngọt thanh",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 91
    new Food
    {
        FoodId = Guid.Parse("a53672e7-8593-4779-bd02-9f02ae81f915"),
        CategoryId = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Mực",
        FoodDescription = "Hải sản giòn, ngọt, chế biến nướng, hấp, hoặc chiên",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 92
    new Food
    {
        FoodId = Guid.Parse("ede931f5-092e-4e41-8ce1-5a95bff2772a"),
        CategoryId = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Cua",
        FoodDescription = "Hải sản vỏ cứng, thịt ngọt, thường hấp hoặc nấu lẩu",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 93
    new Food
    {
        FoodId = Guid.Parse("98006e54-c44e-4a81-aa99-d4bb95bfb89d"),
        CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Đậu que",
        FoodDescription = "Rau xanh giòn, thích hợp luộc, xào hoặc nấu canh",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 94
    new Food
    {
        FoodId = Guid.Parse("fb7d87aa-2bb8-4065-bd31-b54239057405"),
        CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bánh ướt",
        FoodDescription = "Bánh bột gạo tráng mỏng, ăn kèm chả, nước mắm",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 95
    new Food
    {
        FoodId = Guid.Parse("f0132626-5535-4f30-9af4-7e89e086aaaf"),
        CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bánh cuốn",
        FoodDescription = "Bánh tráng mỏng cuộn nhân thịt, mộc nhĩ, ăn kèm nước mắm",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 96
    new Food
    {
        FoodId = Guid.Parse("7268b449-cb54-4f3d-9709-f42b9966d707"),
        CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Canh bún",
        FoodDescription = "Món bún nước dùng từ cua đồng, ăn kèm rau muống",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 97
    new Food
    {
        FoodId = Guid.Parse("7b8500af-d730-4138-9617-cba352faed4a"),
        CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Vải",
        FoodDescription = "Trái cây nhỏ, ngọt, mọng nước, vỏ đỏ, hạt to",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 98
    new Food
    {
        FoodId = Guid.Parse("dd1482e7-b3dd-4b17-80f6-5618a640c671"),
        CategoryId = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Cá khô",
        FoodDescription = "Cá phơi khô, dùng nướng, chiên hoặc làm gỏi",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 99
    new Food
    {
        FoodId = Guid.Parse("628d87df-0bde-417d-b8b5-5f8f5536410b"),
        CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Nấm đùi gà",
        FoodDescription = "Loại nấm to, thơm ngon, thích hợp xào hoặc nấu canh",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 100
    new Food
    {
        FoodId = Guid.Parse("fc85f2de-9aae-4ff4-a829-e01662a42976"),
        CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Mướp",
        FoodDescription = "Loại quả xanh, mềm, thường nấu canh hoặc xào",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 101
    new Food
    {
        FoodId = Guid.Parse("ef8b0ee3-a4d5-4883-af63-33c83d102bea"),
        CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bánh bao trứng cút",
        FoodDescription = "Bánh hấp nhân thịt, trứng cút, ăn sáng tiện lợi",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 102
    new Food
    {
        FoodId = Guid.Parse("9122357a-179f-45f4-9106-67eea24d48ab"),
        CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Trà tắc",
        FoodDescription = "Nước trà kết hợp tắc, vị chua ngọt, giải khát",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 103
    new Food
    {
        FoodId = Guid.Parse("22d1cbad-a884-400c-b681-30b17d98bf1c"),
        CategoryId = Guid.Parse("fe3a3546-b294-4665-9c82-092d4ab5a187"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Đậu hũ non",
        FoodDescription = "Đậu hũ mềm mịn, thường dùng làm canh hoặc món tráng miệng",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 104
    new Food
    {
        FoodId = Guid.Parse("c81a404a-ec10-428e-acec-dd56ec1d3607"),
        CategoryId = Guid.Parse("fc7f66aa-8c09-46db-a679-be440e3ed91f"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Nem chua",
        FoodDescription = "Thịt chua lên men, thường ăn kèm lá ổi và tương ớt",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 105
    new Food
    {
        FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),
        CategoryId = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Cá ngừ",
        FoodDescription = "Loại cá giàu dinh dưỡng, thường làm salad hoặc áp chảo",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 106
    new Food
    {
        FoodId = Guid.Parse("01708b02-6cc1-41f6-ae4a-95c4085e1839"),
        CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Gỏi cuốn",
        FoodDescription = "Cuốn bánh tráng với thịt, tôm, rau, chấm nước mắm chua ngọt",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 107
    new Food
    {
        FoodId = Guid.Parse("436d8364-15fd-47a2-9b72-c3841db0da2e"),
        CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Bông lan trứng muối",
        FoodDescription = "Bánh bông lan mềm, nhân trứng muối và chà bông",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 108
    new Food
    {
        FoodId = Guid.Parse("87225215-43af-49f2-a40b-a5ebb087d27b"),
        CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Phở bò viên",
        FoodDescription = "Phở bò kết hợp bò viên dai ngon, nước lèo đậm đà",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 109
    new Food
    {
        FoodId = Guid.Parse("23443efa-dc06-4e7a-949c-5c823ee6e575"),
        CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Khoai lang luộc",
        FoodDescription = "Khoai lang luộc chín, ngọt bùi, giàu chất xơ",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 110
    new Food
    {
        FoodId = Guid.Parse("afe0a180-0077-4fdf-89e8-9513c6132f92"),
        CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Đu đủ",
        FoodDescription = "Trái cây ngọt mềm, màu cam, giàu vitamin A và chất xơ",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 111
    new Food
    {
        FoodId = Guid.Parse("16066b9b-e61f-4354-803b-e2f9c9f5a5db"),
        CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Cháo đậu đỏ",
        FoodDescription = "Cháo từ đậu đỏ, ngọt dịu, bổ máu và mát gan",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 112
    new Food
    {
        FoodId = Guid.Parse("8ebd5a6e-b0af-42b6-af58-b681fceac1ef"),
        CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Chè đậu đen",
        FoodDescription = "Món chè ngọt làm từ đậu đen nấu mềm, nước cốt dừa thơm",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    },
            #endregion

            #region Food 113
    new Food
    {
        FoodId = Guid.Parse("da85064b-e528-4bfa-8a64-1fbe704f9af5"),
        CategoryId = Guid.Parse("fc7f66aa-8c09-46db-a679-be440e3ed91f"),
                            UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),

        FoodName = "Dưa cải chua",
        FoodDescription = "Rau cải muối lên men, chua nhẹ, ăn kèm món kho",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null)
    }
    #endregion
                );
        }
    }
}