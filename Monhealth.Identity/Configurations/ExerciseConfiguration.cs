using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.HasData(
            #region Exercise 1
                new Exercise
                {
                    ExerciseId = Guid.Parse("c6717b09-eea8-4452-8900-2abd68494661"),
                    CategoryId = Guid.Parse("7780ccb5-aa16-4f88-a662-04971892dae0"),
                    ExerciseName = "Tư Thế Cây",
                    IntensityLevel = "Low",
                    Duration = 10,
                    CaloriesBurned = 5f,
                    Instructions = "1. Đứng thẳng 2. Đặt một chân lên đầu gối chân còn lại 3. Vươn hai tay lên cao và giữ tư thế trong vài giây",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 2
                new Exercise
                {
                    ExerciseId = Guid.Parse("1a8257c0-db6f-4a6b-ac06-dd88f98cd10b"),
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    ExerciseName = "Kéo Giãn Vai",
                    IntensityLevel = "Low",
                    Duration = 5,
                    CaloriesBurned = 4.0f,
                    Instructions = "1. Ngồi thẳng 2. Đưa tay phải qua vai trái 3. Kéo nhẹ tay bằng tay còn lại, giữ trong 10 giây và đổi bên",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 3
                new Exercise
                {
                    ExerciseId = Guid.Parse("4fca9170-932f-4985-8f6f-04f34c4ed80a"),
                    CategoryId = Guid.Parse("045d39cf-5865-4e2a-9cd1-fd76628bdab4"),
                    ExerciseName = "Nhảy Chụm Chân",
                    IntensityLevel = "Medium",
                    Duration = 10,
                    CaloriesBurned = 8.0f,
                    Instructions = "1. Đứng thẳng 2. Nhảy chụm hai chân lại, tay đưa lên cao 3. Lặp lại động tác trong 10 phút",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 4
                new Exercise
                {
                    ExerciseId = Guid.Parse("7f51e931-9f04-4ff6-a383-51cfce5398e9"),
                    CategoryId = Guid.Parse("a1c1ef2d-6697-49d3-857b-882b288ffeef"),
                    ExerciseName = "Thở Bụng",
                    IntensityLevel = "Low",
                    Duration = 5,
                    CaloriesBurned = 2.0f,
                    Instructions = "1. Ngồi thoải mái 2. Đặt tay lên bụng 3. Hít sâu bằng mũi và thở ra bằng miệng, cảm nhận sự phồng lên của bụng",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 5
                new Exercise
                {
                    ExerciseId = Guid.Parse("f4c8fd3c-fc3e-45cb-b468-4acf0ae87266"),
                    CategoryId = Guid.Parse("045d39cf-5865-4e2a-9cd1-fd76628bdab4"),
                    ExerciseName = "Chạy Nâng High Đùi",
                    IntensityLevel = "High",
                    Duration = 15,
                    CaloriesBurned = 10.0f,
                    Instructions = "1. Đứng thẳng 2. Nâng cao đùi một chân đến ngang hông, sau đó đổi chân 3. Lặp lại động tác với tốc độ tăng dần",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 6
                new Exercise
                {
                    ExerciseId = Guid.Parse("ccd35e18-4679-4bfb-b9df-2eaaa3f4d9a8"),
                    CategoryId = Guid.Parse("7780ccb5-aa16-4f88-a662-04971892dae0"),
                    ExerciseName = "Tư Thế Tam Giác",
                    IntensityLevel = "Medium",
                    Duration = 12,
                    CaloriesBurned = 5.83f,
                    Instructions = "1. Đứng thẳng, hai chân mở rộng 2. Gập người sang bên, tay chạm vào gót chân 3. Giữ tư thế và lặp lại ở bên còn lại",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 7
                new Exercise
                {
                    ExerciseId = Guid.Parse("f05d362a-3b43-4451-9857-025a170ec0e2"),
                    CategoryId = Guid.Parse("c440673d-c842-4aad-aa44-4a9b314529c4"),
                    ExerciseName = "Gập Bụng",
                    IntensityLevel = "Medium",
                    Duration = 10,
                    CaloriesBurned = 10.0f,
                    Instructions = "1. Nằm ngửa, đầu gối co lại 2. Đặt hai tay sau đầu, nâng người lên 3. Hạ xuống từ từ và lặp lại",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 8
                new Exercise
                {
                    ExerciseId = Guid.Parse("e3eeb6c5-aa62-4f2e-8ab1-b856c208d448"),
                    CategoryId = Guid.Parse("045d39cf-5865-4e2a-9cd1-fd76628bdab4"),
                    ExerciseName = "Đi Bộ Tại Chỗ",
                    IntensityLevel = "Low",
                    Duration = 15,
                    CaloriesBurned = 4.67f,
                    Instructions = "1. Đứng thẳng 2. Bắt đầu đi bộ tại chỗ, nâng đùi nhẹ nhàng 3. Giữ tốc độ đều đặn",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 9
                new Exercise
                {
                    ExerciseId = Guid.Parse("104ed03c-0460-48d2-890e-7acd517e129b"),
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    ExerciseName = "Kéo Giãn Cột Sống",
                    IntensityLevel = "Low",
                    Duration = 8,
                    CaloriesBurned = 3.75f,
                    Instructions = "1. Đứng thẳng 2. Gập người nhẹ về phía trước 3. Dùng tay chạm sàn, giữ vài giây rồi trở lại tư thế ban đầu",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 10
                new Exercise
                {
                    ExerciseId = Guid.Parse("6ca587eb-e1f3-4266-be80-af02b42a8545"),
                    CategoryId = Guid.Parse("c440673d-c842-4aad-aa44-4a9b314529c4"),
                    ExerciseName = "Plank",
                    IntensityLevel = "High",
                    Duration = 5,
                    CaloriesBurned = 10.0f,
                    Instructions = "1. Chống hai khuỷu tay xuống sàn 2. Giữ lưng thẳng và cơ bụng siết chặt 3. Giữ tư thế trong vòng 30 giây đến 1 phút",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 11
                new Exercise
                {
                    ExerciseId = Guid.Parse("6e2ffe73-18da-42e6-ab89-0d3ecf254a52"),
                    CategoryId = Guid.Parse("7780ccb5-aa16-4f88-a662-04971892dae0"),
                    ExerciseName = "Chào Mặt Trời",
                    IntensityLevel = "Low",
                    Duration = 15,
                    CaloriesBurned = 5.0f,
                    Instructions = "1. Đứng thẳng 2. Đưa hai tay lên cao 3. Cúi gập người và thực hiện các tư thế yoga liên tiếp",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 12
                new Exercise
                {
                    ExerciseId = Guid.Parse("2d8dd512-b871-4e4e-955c-cf15a50a8ef7"),
                    CategoryId = Guid.Parse("cb81e687-8e2f-4814-99a6-808777410e02"),
                    ExerciseName = "Cuộn Người",
                    IntensityLevel = "Low",
                    Duration = 10,
                    CaloriesBurned = 4.0f,
                    Instructions = "1. Nằm ngửa 2. Duỗi thẳng hai tay qua đầu 3. Từ từ cuộn người lên",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 13
                new Exercise
                {
                    ExerciseId = Guid.Parse("97dd1375-9217-43b9-9c9d-c14128158ef0"),
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    ExerciseName = "Kéo Giãn Đùi Sau",
                    IntensityLevel = "Low",
                    Duration = 8,
                    CaloriesBurned = 3.75f,
                    Instructions = "1. Ngồi trên sàn 2. Duỗi một chân thẳng 3. Vươn tay về phía ngón chân của chân duỗi",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 14
                new Exercise
                {
                    ExerciseId = Guid.Parse("8c6e4c94-b58e-4d9c-8698-98c7db4021cc"),
                    CategoryId = Guid.Parse("045d39cf-5865-4e2a-9cd1-fd76628bdab4"),
                    ExerciseName = "Chạy Bộ Nhẹ",
                    IntensityLevel = "Medium",
                    Duration = 20,
                    CaloriesBurned = 6.0f,
                    Instructions = "1. Đứng thẳng 2. Bắt đầu chạy bộ nhẹ nhàng 3. Duy trì tốc độ đều trong 20 phút",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 15
                new Exercise
                {
                    ExerciseId = Guid.Parse("222df2e6-90a1-4a5b-8b63-cd7b73f012bb"),
                    CategoryId = Guid.Parse("d7c2a84c-2136-4f62-8d8e-4d70ec123f4f"),
                    ExerciseName = "Đứng Một Chân",
                    IntensityLevel = "Medium",
                    Duration = 10,
                    CaloriesBurned = 5.0f,
                    Instructions = "1. Đứng thẳng 2. Nâng một chân lên và giữ thăng bằng 3. Đổi bên sau 10 giây",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 16
                new Exercise
                {
                    ExerciseId = Guid.Parse("3b17291f-8c4c-494c-bcbe-3adde745cbca"),
                    CategoryId = Guid.Parse("a1c1ef2d-6697-49d3-857b-882b288ffeef"),
                    ExerciseName = "Ngồi Thiền",
                    IntensityLevel = "Low",
                    Duration = 10,
                    CaloriesBurned = 2.0f,
                    Instructions = "1. Ngồi thoải mái 2. Nhắm mắt và tập trung vào nhịp thở 3. Thở đều trong 10 phút",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 17
                new Exercise
                {
                    ExerciseId = Guid.Parse("c54c743d-4956-4b88-94ff-c4467f463a41"),
                    CategoryId = Guid.Parse("7780ccb5-aa16-4f88-a662-04971892dae0"),
                    ExerciseName = "Chó Úp Mặt",
                    IntensityLevel = "Low",
                    Duration = 12,
                    CaloriesBurned = 5.0f,
                    Instructions = "1. Bắt đầu ở tư thế bò 2. Nâng hông cao để tạo thành chữ V ngược 3. Giữ tư thế trong vài giây",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 18
                new Exercise
                {
                    ExerciseId = Guid.Parse("8918e071-56ca-4212-bd09-c338d2b0db8a"),
                    CategoryId = Guid.Parse("045d39cf-5865-4e2a-9cd1-fd76628bdab4"),
                    ExerciseName = "Bật Nhảy Tại Chỗ",
                    IntensityLevel = "Medium",
                    Duration = 15,
                    CaloriesBurned = 10.0f,
                    Instructions = "1. Đứng thẳng 2. Nhảy cao và đưa tay lên trời 3. Tiếp đất nhẹ nhàng",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 19
                new Exercise
                {
                    ExerciseId = Guid.Parse("fcbc0f6c-bfda-430d-a7b0-ad48391327b4"),
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    ExerciseName = "Nhún Gối",
                    IntensityLevel = "Low",
                    Duration = 8,
                    CaloriesBurned = 5.0f,
                    Instructions = "1. Đứng thẳng 2. Gập đầu gối nhẹ nhàng xuống 3. Trở về tư thế ban đầu và lặp lại",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 20
                new Exercise
                {
                    ExerciseId = Guid.Parse("c8c75216-1952-41c7-88d1-2e21e50a4bf7"),
                    CategoryId = Guid.Parse("7780ccb5-aa16-4f88-a662-04971892dae0"),
                    ExerciseName = "Đứng Gập Người",
                    IntensityLevel = "Low",
                    Duration = 12,
                    CaloriesBurned = 5.83f,
                    Instructions = "1. Đứng thẳng 2. Cúi gập người, tay chạm sàn 3. Giữ tư thế vài giây và trở lại vị trí ban đầu",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 21
                new Exercise
                {
                    ExerciseId = Guid.Parse("e3f3c590-fb64-4187-9375-db45a3bc5f26"),
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    ExerciseName = "Đứng Kiễng Chân",
                    IntensityLevel = "Low",
                    Duration = 8,
                    CaloriesBurned = 5.0f,
                    Instructions = "1. Đứng thẳng, chân chụm lại 2. Nâng gót chân lên cao 3. Giữ vài giây và hạ xuống",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 22
                new Exercise
                {
                    ExerciseId = Guid.Parse("a98a4e19-3ccf-4e3f-90fa-a9f866230bd2"),
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    ExerciseName = "Kéo Giãn Hông",
                    IntensityLevel = "Low",
                    Duration = 10,
                    CaloriesBurned = 5.0f,
                    Instructions = "1. Đứng thẳng 2. Đưa một chân ra phía trước, gập nhẹ gối 3. Giữ tư thế và đổi bên",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 23
                new Exercise
                {
                    ExerciseId = Guid.Parse("cb7a4531-62f7-4209-9489-2ef6e3a8571a"),
                    CategoryId = Guid.Parse("c440673d-c842-4aad-aa44-4a9b314529c4"),
                    ExerciseName = "Gập Gối Ngồi",
                    IntensityLevel = "Medium",
                    Duration = 12,
                    CaloriesBurned = 8.33f,
                    Instructions = "1. Ngồi xuống, hai chân mở rộng 2. Gập gối và đưa thân người xuống gần gối 3. Trở lại tư thế ban đầu",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 24
                new Exercise
                {
                    ExerciseId = Guid.Parse("642766b0-99d6-45b8-a1ad-e2d3c1ad8c51"),
                    CategoryId = Guid.Parse("7780ccb5-aa16-4f88-a662-04971892dae0"),
                    ExerciseName = "Tư Thế Em Bé",
                    IntensityLevel = "Low",
                    Duration = 10,
                    CaloriesBurned = 4.0f,
                    Instructions = "1. Ngồi quỳ, gập người về phía trước 2. Duỗi hai tay ra trước mặt 3. Giữ trong 10 giây",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 25
                new Exercise
                {
                    ExerciseId = Guid.Parse("3a737328-37a9-415f-b52c-71480118d431"),
                    CategoryId = Guid.Parse("045d39cf-5865-4e2a-9cd1-fd76628bdab4"),
                    ExerciseName = "Nhảy Sang Ngang",
                    IntensityLevel = "Medium",
                    Duration = 15,
                    CaloriesBurned = 8.67f,
                    Instructions = "1. Đứng thẳng, chân chụm lại 2. Nhảy sang bên trái và phải liên tục 3. Duy trì tốc độ đều",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 26
                new Exercise
                {
                    ExerciseId = Guid.Parse("e051611d-806d-4d70-81da-da1277c404a1"),
                    CategoryId = Guid.Parse("a1c1ef2d-6697-49d3-857b-882b288ffeef"),
                    ExerciseName = "Thở Sâu",
                    IntensityLevel = "Low",
                    Duration = 5,
                    CaloriesBurned = 2.0f,
                    Instructions = "1. Ngồi thẳng lưng 2. Hít vào chậm rãi qua mũi 3. Thở ra từ từ qua miệng",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 27
                new Exercise
                {
                    ExerciseId = Guid.Parse("b25e6da5-a48d-414d-9d94-34fc08421eb5"),
                    CategoryId = Guid.Parse("c440673d-c842-4aad-aa44-4a9b314529c4"),
                    ExerciseName = "Tư Thế Thuyền",
                    IntensityLevel = "High",
                    Duration = 12,
                    CaloriesBurned = 7.5f,
                    Instructions = "1. Ngồi trên sàn, chân co gối lên 2. Nâng thân người và chân lên tạo hình chữ V 3. Giữ vài giây rồi hạ xuống",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 28
                new Exercise
                {
                    ExerciseId = Guid.Parse("8c34f630-f594-48ad-8db9-1e0c90439da7"),
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    ExerciseName = "Gập Lưng Dưới",
                    IntensityLevel = "Low",
                    Duration = 8,
                    CaloriesBurned = 5.0f,
                    Instructions = "1. Nằm ngửa 2. Co gối và gập thân người về phía trước 3. Hạ xuống và lặp lại",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 29
                new Exercise
                {
                    ExerciseId = Guid.Parse("8bf642c5-edd8-4998-9385-c7b753f8eb16"),
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    ExerciseName = "Đứng Vặn Mình",
                    IntensityLevel = "Low",
                    Duration = 10,
                    CaloriesBurned = 5.0f,
                    Instructions = "1. Đứng thẳng, hai tay chống hông 2. Vặn mình sang trái, giữ vài giây 3. Đổi bên và lặp lại",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 30
                new Exercise
                {
                    ExerciseId = Guid.Parse("a97fb729-878b-413e-af0f-086e524874bb"),
                    CategoryId = Guid.Parse("7780ccb5-aa16-4f88-a662-04971892dae0"),
                    ExerciseName = "Tư Thế Cá Heo",
                    IntensityLevel = "Medium",
                    Duration = 12,
                    CaloriesBurned = 5.83f,
                    Instructions = "1. Bắt đầu ở tư thế bò 2. Chống hai khuỷu tay và nâng hông lên 3. Giữ tư thế và hít thở đều",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 31
                new Exercise
                {
                    ExerciseId = Guid.Parse("2f862941-2b92-4210-bf02-efb91feed6e4"),
                    CategoryId = Guid.Parse("045d39cf-5865-4e2a-9cd1-fd76628bdab4"),
                    ExerciseName = "Đi Bộ Nâng Cao Gối",
                    IntensityLevel = "Medium",
                    Duration = 15,
                    CaloriesBurned = 10.0f,
                    Instructions = "1. Đứng thẳng 2. Bắt đầu đi bộ tại chỗ, nâng gối cao ngang hông 3. Lặp lại liên tục",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 32
                new Exercise
                {
                    ExerciseId = Guid.Parse("afbf282b-5a75-4b98-94a1-c1d3dece6b25"),
                    CategoryId = Guid.Parse("c440673d-c842-4aad-aa44-4a9b314529c4"),
                    ExerciseName = "Chống Đẩy Đầu Gối",
                    IntensityLevel = "Low",
                    Duration = 10,
                    CaloriesBurned = 5.0f,
                    Instructions = "1. Nằm úp 2. Chống hai tay và đầu gối xuống sàn 3. Nâng người lên và hạ xuống từ từ",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 33
                new Exercise
                {
                    ExerciseId = Guid.Parse("cdb6b8b0-e24d-488a-b2ac-6e38c7269b08"),
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    ExerciseName = "Kéo Cánh Tay",
                    IntensityLevel = "Low",
                    Duration = 5,
                    CaloriesBurned = 4.0f,
                    Instructions = "1. Đứng thẳng 2. Đưa tay phải sang vai trái 3. Kéo nhẹ tay và giữ vài giây, sau đó đổi bên",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 34
                new Exercise
                {
                    ExerciseId = Guid.Parse("165cfd11-a6ee-420f-b18e-821768917488"),
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    ExerciseName = "Đứng Gập Đầu",
                    IntensityLevel = "Low",
                    Duration = 8,
                    CaloriesBurned = 4.38f,
                    Instructions = "1. Đứng thẳng 2. Cúi gập đầu và thân người xuống 3. Thư giãn cổ và giữ trong vài giây",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 35
                new Exercise
                {
                    ExerciseId = Guid.Parse("1cf971f5-5c43-44de-baec-782a473fc49e"),
                    CategoryId = Guid.Parse("045d39cf-5865-4e2a-9cd1-fd76628bdab4"),
                    ExerciseName = "Bật Nhảy Hai Chân",
                    IntensityLevel = "High",
                    Duration = 12,
                    CaloriesBurned = 10.0f,
                    Instructions = "1. Đứng thẳng 2. Nhảy bật hai chân lên cao, tay chạm gối 3. Lặp lại liên tục",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 36
                new Exercise
                {
                    ExerciseId = Guid.Parse("d622220c-af21-47bb-8540-90e01c5b63be"),
                    CategoryId = Guid.Parse("a1c1ef2d-6697-49d3-857b-882b288ffeef"),
                    ExerciseName = "Thở Hít Lâu",
                    IntensityLevel = "Low",
                    Duration = 5,
                    CaloriesBurned = 3.0f,
                    Instructions = "1. Ngồi thoải mái 2. Hít vào sâu trong 5 giây 3. Thở ra chậm trong 7 giây",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 37
                new Exercise
                {
                    ExerciseId = Guid.Parse("4a9ca2b5-78d0-42ea-870e-b0bc76c72d9e"),
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    ExerciseName = "Ngồi Mở Rộng Eo",
                    IntensityLevel = "Low",
                    Duration = 8,
                    CaloriesBurned = 3.75f,
                    Instructions = "1. Ngồi thẳng lưng, chân duỗi ra 2. Đưa hai tay lên cao 3. Nghiêng người sang bên trái và đổi bên",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 38
                new Exercise
                {
                    ExerciseId = Guid.Parse("507ca0f0-4d34-4e62-9a6a-48c12341a4d1"),
                    CategoryId = Guid.Parse("c440673d-c842-4aad-aa44-4a9b314529c4"),
                    ExerciseName = "Gập Lưng Trên",
                    IntensityLevel = "High",
                    Duration = 10,
                    CaloriesBurned = 9.0f,
                    Instructions = "1. Nằm ngửa 2. Nâng thân trên lên về phía đầu gối 3. Hạ xuống từ từ và lặp lại",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 39
                new Exercise
                {
                    ExerciseId = Guid.Parse("7717a4d8-d310-466f-afeb-0fb7272dcf0b"),
                    CategoryId = Guid.Parse("7780ccb5-aa16-4f88-a662-04971892dae0"),
                    ExerciseName = "Tư Thế Chiến Binh II",
                    IntensityLevel = "Medium",
                    Duration = 12,
                    CaloriesBurned = 6.67f,
                    Instructions = "1. Đứng thẳng, chân mở rộng 2. Đưa hai tay sang ngang, gập một gối 3. Giữ tư thế trong vài giây",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 40
                new Exercise
                {
                    ExerciseId = Guid.Parse("92319d32-4758-49d2-bdd1-360f0b119a05"),
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    ExerciseName = "Ngồi Vặn Mình",
                    IntensityLevel = "Low",
                    Duration = 10,
                    CaloriesBurned = 5.0f,
                    Instructions = "1. Ngồi thẳng lưng, chân duỗi thẳng 2. Xoay thân người sang trái, tay chạm đầu gối 3. Đổi bên và lặp lại",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 41
                new Exercise
                {
                    ExerciseId = Guid.Parse("523a65a8-53ac-4577-b318-0dbd370ceedf"),
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    ExerciseName = "Đá Chân Ra Sau",
                    IntensityLevel = "Low",
                    Duration = 10,
                    CaloriesBurned = 5.0f,
                    Instructions = "1. Đứng thẳng 2. Đá chân phải ra sau, giữ thăng bằng 3. Đổi chân và lặp lại",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 42
                new Exercise
                {
                    ExerciseId = Guid.Parse("769af12c-7398-4803-9a78-7a1ad54047b1"),
                    CategoryId = Guid.Parse("c440673d-c842-4aad-aa44-4a9b314529c4"),
                    ExerciseName = "Tư Thế Cây Cầu",
                    IntensityLevel = "Medium",
                    Duration = 12,
                    CaloriesBurned = 6.67f,
                    Instructions = "1. Nằm ngửa 2. Co chân, nâng hông lên cao 3. Hạ xuống từ từ và lặp lại",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 43
                new Exercise
                {
                    ExerciseId = Guid.Parse("486237f0-a55b-495e-b09a-65bf36260a1e"),
                    CategoryId = Guid.Parse("045d39cf-5865-4e2a-9cd1-fd76628bdab4"),
                    ExerciseName = "Bật Nhảy Chéo",
                    IntensityLevel = "Medium",
                    Duration = 15,
                    CaloriesBurned = 10.0f,
                    Instructions = "1. Đứng thẳng 2. Nhảy chéo chân và tay 3. Lặp lại với tốc độ tăng dần",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 44
                new Exercise
                {
                    ExerciseId = Guid.Parse("9fbbaf75-bece-48ff-975f-28ab6204516b"),
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    ExerciseName = "Nâng Tay Kéo Dài",
                    IntensityLevel = "Low",
                    Duration = 8,
                    CaloriesBurned = 5.0f,
                    Instructions = "1. Đứng thẳng 2. Đưa một tay lên cao và kéo dài 3. Đổi tay và lặp lại",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 45
                new Exercise
                {
                    ExerciseId = Guid.Parse("c05e4fd1-6546-4283-bace-4cbf8affd86a"),
                    CategoryId = Guid.Parse("7780ccb5-aa16-4f88-a662-04971892dae0"),
                    ExerciseName = "Tư Thế Mèo - Bò",
                    IntensityLevel = "Low",
                    Duration = 10,
                    CaloriesBurned = 6.0f,
                    Instructions = "1. Bắt đầu ở tư thế bò 2. Cong lưng và nâng đầu lên 3. Cúi đầu và gập lưng xuống",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 46
                new Exercise
                {
                    ExerciseId = Guid.Parse("7a102c6e-b15c-4260-a846-203b090603a5"),
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    ExerciseName = "Vặn Người Đứng",
                    IntensityLevel = "Low",
                    Duration = 8,
                    CaloriesBurned = 3.75f,
                    Instructions = "1. Đứng thẳng 2. Xoay người nhẹ sang bên trái, tay chạm eo 3. Đổi bên và lặp lại",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 47
                new Exercise
                {
                    ExerciseId = Guid.Parse("2fdafe44-34cb-40bf-8b68-1e9f79a3aa38"),
                    CategoryId = Guid.Parse("045d39cf-5865-4e2a-9cd1-fd76628bdab4"),
                    ExerciseName = "Nhảy Nâng Đùi Xen Kẽ",
                    IntensityLevel = "High",
                    Duration = 15,
                    CaloriesBurned = 10.67f,
                    Instructions = "1. Đứng thẳng 2. Nhảy nâng đùi xen kẽ, tay đưa lên cao 3. Lặp lại liên tục",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 48
                new Exercise
                {
                    ExerciseId = Guid.Parse("e400f9d2-1f60-4494-b5bc-73085d215043"),
                    CategoryId = Guid.Parse("8d95160a-e5c0-49b7-b016-b97e3479c54b"),
                    ExerciseName = "Kéo Gối Chạm Ngực",
                    IntensityLevel = "Low",
                    Duration = 10,
                    CaloriesBurned = 5.0f,
                    Instructions = "1. Nằm ngửa 2. Kéo gối phải lên chạm ngực 3. Đổi bên và lặp lại",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 49
                new Exercise
                {
                    ExerciseId = Guid.Parse("6330da83-d0d8-4031-9459-ceccd41a3ac1"),
                    CategoryId = Guid.Parse("7780ccb5-aa16-4f88-a662-04971892dae0"),
                    ExerciseName = "Tư Thế Thư Giãn",
                    IntensityLevel = "Low",
                    Duration = 12,
                    CaloriesBurned = 5.0f,
                    Instructions = "1. Nằm thẳng, tay và chân thả lỏng 2. Hít thở đều và thư giãn trong vài phút",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                },
            #endregion

            #region Exercise 50
                new Exercise
                {
                    ExerciseId = Guid.Parse("af983757-d7a8-412c-87e1-9f8a3a09e92f"),
                    CategoryId = Guid.Parse("7780ccb5-aa16-4f88-a662-04971892dae0"),
                    ExerciseName = "Tư Thế Con Quạ",
                    IntensityLevel = "High",
                    Duration = 10,
                    CaloriesBurned = 9.0f,
                    Instructions = "1. Ngồi xổm, đặt hai tay xuống sàn 2. Nâng hai chân lên khỏi sàn, giữ thăng bằng 3. Giữ tư thế trong vài giây",
                    Status = true,
                    CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
                }
                #endregion
                );
        }
    }
}
