using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Identity.Configurations
{
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            var userId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6");
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region Exercise 1
            new Exercise
            {
                ExerciseId = Guid.Parse("6fe4dcc3-5262-470e-b043-0db293dda2fb"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Nhảy dang tay",
                Instructions =
                    "Đứng thẳng với hai tay đặt dọc theo thân người\n Nhảy lên đồng thời dang hai chân và đưa hai tay lên cao cho đến khi hai bàn tay chạm nhau trên đỉnh đầu\n Giữ tư thế này trong một giây\n Thực hiện cú nhảy thứ hai, lần này đưa tay và chân trở lại vị trí bắt đầu",
                CaloriesPerMinute = 9.2f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 2
            new Exercise
            {
                ExerciseId = Guid.Parse("68018365-010c-4ab8-81f4-05a5cbfcc24b"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Leo núi",
                Instructions =
                    "Bắt đầu ở tư thế plank\n Kéo một đầu gối vào gần ngực, sau đó đổi chân\n Giữ nhịp điệu ổn định",
                CaloriesPerMinute = 8.1f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 3
            new Exercise
            {
                ExerciseId = Guid.Parse("546e3f6d-16be-4d13-8c15-3947bcf15b1f"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Chéo chân năng động",
                Instructions =
                    "Nằm thẳng lưng với hai tay duỗi sang hai bên\n Nâng chân phải về phía tay trái\n Bây giờ nâng chân trái về phía tay phải\n Giữ lưng càng gần sàn càng tốt",
                CaloriesPerMinute = 5.3f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 4
            new Exercise
            {
                ExerciseId = Guid.Parse("3100278d-eee7-4b89-b726-4b76daefabde"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Lắc vòng",
                Instructions =
                    "Đứng thẳng với hai tay chống vào hông\n Thực hiện các chuyển động tròn bằng xương chậu\n Bài tập này cải thiện khả năng vận động của bạn",
                CaloriesPerMinute = 7.4f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 5
            new Exercise
            {
                ExerciseId = Guid.Parse("92ddccfd-7076-4dbc-b96b-9197cd4cc308"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Squats",
                Instructions =
                    "Đứng thẳng với hai chân rộng bằng vai và hai tay duỗi thẳng và thẳng hàng với bàn chân\n Hít vào và gập đầu gối cho đến khi đùi của bạn song song với sàn nhà\n Giữ ngực thẳng đứng và dành nhiều thời gian hơn để hạ mình xuống hơn là đứng lên",
                CaloriesPerMinute = 6.2f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 6
            new Exercise
            {
                ExerciseId = Guid.Parse("ee5b2085-e5d2-4236-8afb-6d1c33f97d30"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Nâng cao gối",
                Instructions =
                    "Đứng thẳng và chạy tại chỗ\n Giữ ngực thẳng và siết chặt và nâng đầu gối lên ngực",
                CaloriesPerMinute = 8.3f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 7
            new Exercise
            {
                ExerciseId = Guid.Parse("44f8a6a5-04ab-447a-9361-b0e545d12f42"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Xoay vòng tay",
                Instructions =
                    "Đứng thẳng và duỗi tay sang một bên với hai tay ngang tầm vai\n Thực hiện các vòng tròn nhỏ bằng cánh tay theo một hướng rồi đổi hướng. Điều này sẽ làm ấm vai của bạn",
                CaloriesPerMinute = 4.1f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 8
            new Exercise
            {
                ExerciseId = Guid.Parse("72206c5e-58f3-46f0-a8b1-031cbf599433"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Macarena",
                Instructions =
                    "Đứng thẳng lưng\n Nâng hai tay sang hai bên\n Thực hiện các chuyển động bắt chéo\n Tay phải của bạn vượt qua tay trái của bạn và ngược lại",
                CaloriesPerMinute = 5.2f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 9
            new Exercise
            {
                ExerciseId = Guid.Parse("d0dcad19-4c0c-447d-8e3c-092c6d4ad14c"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Đi bộ kiểu zombie",
                Instructions =
                    "Đứng thẳng, bước về phía trước với hai tay duỗi thẳng phía trước bạn, và nâng chân lên ngang tầm tay của bạn với mỗi bước\n Giữ ngực thẳng đứng và cơ bụng siết chặt",
                CaloriesPerMinute = 7.3f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 10
            new Exercise
            {
                ExerciseId = Guid.Parse("bd80fdd3-c46c-4410-b126-51a11a8a2f5b"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Chuông lắc",
                Instructions =
                    "Vào tư thế chống đẩy\n Đưa hai chân vào để chúng hơi cong với mông nâng lên trần nhà\n Đảm bảo lưng của bạn vẫn thẳng\n Đu chân phải của bạn sang bên phải, sau đó đưa nó trở lại vị trí bắt đầu\n Làm tương tự với chân trái của bạn",
                CaloriesPerMinute = 6.1f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 11
            new Exercise
            {
                ExerciseId = Guid.Parse("ae6eaaa1-c8c4-4f97-afa4-4ceeea19d4b3"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Lunge và xoay ngực",
                Instructions =
                    "Đứng thẳng và bước một bước lớn về phía trước bằng cách gập chân cho đến khi đầu gối của bạn cong 90 độ\n Khi bạn ở vị trí bước tới, hãy xoay ngực sang bên phải nếu chân phải của bạn ở phía trước\n Xoay ngực sang bên trái nếu chân trái của bạn ở phía trước\n Thực hiện vài lần lặp lại ở mỗi bên",
                CaloriesPerMinute = 6.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 12
            new Exercise
            {
                ExerciseId = Guid.Parse("e7a186ac-57ea-47c1-8656-7419571b8cb4"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Sâu đo",
                Instructions =
                    "Cúi xuống và đặt hai tay của bạn trên sàn nhà trước bàn chân của bạn, với mông hướng lên trần nhà\n Hơi cong đầu gối của bạn\n Sử dụng tay của bạn để di chuyển về phía trước cho đến khi bạn đạt đến vị trí plank\n Giữ ở vị trí này trong một giây trước khi di chuyển trở lại (bằng tay của bạn) về vị trí ban đầu, sau đó đứng thẳng\n Lặp lại",
                CaloriesPerMinute = 6f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 13
            new Exercise
            {
                ExerciseId = Guid.Parse("4e76715f-6578-41d8-8315-cdb23340fb5a"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Bước tới",
                Instructions =
                    "Đứng thẳng và bước một bước lớn về phía trước bằng cách gập chân cho đến khi đầu gối của bạn cong 90 độ\n Đứng lên trở lại, sau đó bước một bước lớn khác bằng chân còn lại\n Lặp lại\n Tiếp tục bước tới vài bước\n Trong mỗi bước tới, giữ ngực thẳng và thẳng\n Tập trung vào việc kéo giãn",
                CaloriesPerMinute = 6.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 14
            new Exercise
            {
                ExerciseId = Guid.Parse("5cbc396e-381a-4d9f-9ad6-42b764deee3e"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Đá mông",
                Instructions =
                    "Đứng thẳng và chạy tại chỗ\n Giữ ngực thẳng và siết chặt và đưa gót chân lên mông của bạn",
                CaloriesPerMinute = 7f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 15
            new Exercise
            {
                ExerciseId = Guid.Parse("1b2afb40-fb97-49ec-8fe3-81a17c6c9078"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Tư thế chiến binh",
                Instructions =
                    "Đứng thẳng và bước một bước lớn về phía trước bằng cách gập chân cho đến khi đầu gối của bạn cong 90 độ\n Đầu gối của chân sau của bạn không được chạm vào\n Nâng hai tay lên trên đầu\n Đảm bảo vai không chạm vào tai của bạn\n Giữ ở vị trí này trong vài giây\n Đổi chân",
                CaloriesPerMinute = 6.8f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 16
            new Exercise
            {
                ExerciseId = Guid.Parse("23842121-4834-4483-bfe2-2c244f5ecf76"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Trượt băng",
                Instructions =
                    "Đứng thẳng, sau đó gập đầu gối của bạn và bước nhanh, chéo về phía bên phải bằng chân trái của bạn\n Trở lại vị trí bắt đầu và ngay lập tức bước chéo về phía bên trái bằng chân phải của bạn\n Tiếp tục luân phiên các bước bằng chân của bạn\n Chuyển động của bạn nên năng động và giống như trượt băng\n Đảm bảo cơ bụng của bạn được siết chặt",
                CaloriesPerMinute = 7.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 17
            new Exercise
            {
                ExerciseId = Guid.Parse("faebde03-bab9-457b-9b45-a9fabd4760aa"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Burpee",
                Instructions =
                    "Bắt đầu bằng cách đứng, sau đó hạ xuống sàn nhà vào vị trí plank. Ngay lập tức thực hiện chống đẩy\n Đưa hai chân của bạn về phía trước vào tư thế squat\n Nhảy thẳng lên và giơ hai tay lên trên đầu\n Trở lại vị trí chống đẩy và lặp lại bài tập",
                CaloriesPerMinute = 8f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 18
            new Exercise
            {
                ExerciseId = Guid.Parse("c076c867-b379-4889-9428-5bc1ae76cbc7"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Squat kiểu sumo",
                Instructions =
                    "Đứng thẳng với hai chân rộng hơn vai một chút\n Hít vào và khuỵu gối xuống càng sâu càng tốt\n Đẩy hông và mông ra phía sau mà không cong lưng\n Đảm bảo giữ ngực thẳng và ưỡn",
                CaloriesPerMinute = 6.2f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 19
            new Exercise
            {
                ExerciseId = Guid.Parse("efbcb7f9-3585-4a1b-8700-871547b7e857"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Nhảy Squat",
                Instructions =
                    "Thực hiện một động tác squat\n Khi bạn đứng lên, hãy nhảy lên không trung bằng cách duỗi thẳng chân và đẩy tay lên trần nhà\n Trở lại tư thế squat và bắt đầu lại",
                CaloriesPerMinute = 7.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 20
            new Exercise
            {
                ExerciseId = Guid.Parse("9dac0527-8042-462b-8f23-7a6b503efc68"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Gập chân",
                Instructions =
                    "Bắt đầu bằng cách quấn tạ mắt cá chân quanh mắt cá chân của bạn\n Quỳ gối ở tư thế plank và nâng bàn chân lên về phía mông\n Nâng cho đến khi đầu gối của bạn thẳng hàng hoàn hảo với đầu của bạn",
                CaloriesPerMinute = 5.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 21
            new Exercise
            {
                ExerciseId = Guid.Parse("8fad349a-913c-42dd-8bba-c1bc267918e9"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Chào buổi sáng",
                Instructions =
                    "Đứng thẳng với hai tay chống vào eo\n Hai chân rộng bằng vai\n Nhẹ nhàng gập đầu gối trong khi giữ lưng thẳng hoặc hơi cong\n Hít một hơi thật sâu và thở ra trong khi nghiêng người về phía trước\n Đẩy hông ra phía sau để ngực hạ xuống vị trí nằm ngang, sau đó hít vào và trở lại vị trí thẳng đứng",
                CaloriesPerMinute = 5.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 22
            new Exercise
            {
                ExerciseId = Guid.Parse("30be3b2d-bf46-4e90-8139-41411971cefc"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Squat tĩnh",
                Instructions =
                    "Đứng thẳng với hai chân rộng bằng vai và hai tay duỗi thẳng và thẳng hàng với bàn chân\n Hít vào và gập đầu gối cho đến khi đùi của bạn song song với sàn nhà\n Giữ ở vị trí này",
                CaloriesPerMinute = 6f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 23
            new Exercise
            {
                ExerciseId = Guid.Parse("1ff0ef05-4387-4483-8de3-0ef6d7724afd"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Chống đẩy dốc",
                Instructions =
                    "Đặt tay của bạn trên ghế hoặc băng ghế để dễ dàng chống đẩy hơn\n Đảm bảo lưng của bạn vẫn đẹp và thẳng\n Khi bạn đi xuống, khuỷu tay của bạn không nên vuông góc mà hơi gần với cơ thể của bạn",
                CaloriesPerMinute = 5.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 24
            new Exercise
            {
                ExerciseId = Guid.Parse("0b702969-cd49-412a-94a1-4f0027ec77d7"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Nâng tay sang ngang",
                Instructions =
                    "Đứng thẳng và nắm một quả tạ ở mỗi tay\n Giữ lưng thẳng và bụng siết chặt\n Nâng tạ sang ngang\n Cổ tay của bạn không vượt quá chiều cao của vai trong khi nâng\n Hạ tạ xuống cẩn thận",
                CaloriesPerMinute = 4.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 25
            new Exercise
            {
                ExerciseId = Guid.Parse("7c38fc8f-8fd2-450e-8fa6-c4557f0e6e02"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Chặt gỗ bên phải",
                Instructions =
                    "Đặt một tay lên ghế hoặc băng ghế. Cúi người về phía trước cho đến khi ngực của bạn song song với sàn nhà, giữ lưng thẳng với đầu gối cong và lưng dưới hơi cong\n Nắm một quả tạ bằng tay kia với lòng bàn tay hướng vào cơ thể bạn\n Để tay cầm tạ hạ xuống sàn và thả lỏng vai của bạn\n Hít một hơi thật sâu và kéo tạ lên trên\n Tập trung vào việc kéo bằng vai và cơ lưng và nâng khuỷu tay của bạn càng cao càng tốt khi bạn thở ra\n Giữ tạ nâng lên trong một hoặc hai giây trước khi trở về vị trí bắt đầu\n Sau khi bạn hoàn thành một hiệp với một tay, hãy đổi bên và thực hiện một hiệp với tay kia",
                CaloriesPerMinute = 6f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 26
            new Exercise
            {
                ExerciseId = Guid.Parse("58878826-775e-4d4c-8e1b-d5c95afc214d"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Chặt gỗ bên trái",
                Instructions =
                    "Đặt một tay lên ghế hoặc băng ghế. Cúi người về phía trước cho đến khi ngực của bạn song song với sàn nhà, giữ lưng thẳng với đầu gối cong và lưng dưới hơi cong\n Nắm một quả tạ bằng tay kia với lòng bàn tay hướng vào cơ thể bạn\n Để tay cầm tạ hạ xuống sàn và thả lỏng vai của bạn\n Hít một hơi thật sâu và kéo tạ lên trên\n Tập trung vào việc kéo bằng vai và cơ lưng và nâng khuỷu tay của bạn càng cao càng tốt khi bạn thở ra\n Giữ tạ nâng lên trong một hoặc hai giây trước khi trở về vị trí bắt đầu\n Sau khi bạn hoàn thành một hiệp với một tay, hãy đổi bên và thực hiện một hiệp với tay kia",
                CaloriesPerMinute = 6f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 27
            new Exercise
            {
                ExerciseId = Guid.Parse("bd976f53-25f4-49ba-9943-4c92a2a7eb89"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Nhảy dây",
                Instructions =
                    "Nắm mỗi đầu của dây nhảy\n Vung dây và nhảy nhiều lần qua nó\n Nếu bạn không có dây nhảy, hãy bắt chước chuyển động bằng cổ tay của bạn",
                CaloriesPerMinute = 8f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 28
            new Exercise
            {
                ExerciseId = Guid.Parse("9ba29558-e51b-4a1a-a1c4-b747967e32fb"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Tư thế con thuyền",
                Instructions =
                    "Nằm ngửa với hai chân duỗi thẳng\n Nâng chân và ngực của bạn cho đến khi cơ thể bạn có hình chữ V\n Giữ lưng thẳng và ngực siết chặt\n Nếu bài tập quá khó, bạn có thể giữ chân bằng tay\n Nếu không, hãy giữ thẳng tay và nâng nhẹ lên khỏi mặt đất",
                CaloriesPerMinute = 6.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 29
            new Exercise
            {
                ExerciseId = Guid.Parse("407ff857-d218-44a8-8d0f-0bfa5d53bf03"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Gập bụng chéo",
                Instructions =
                    "Nằm thẳng lưng\n Giữ hai tay sau đầu để nâng đỡ cổ, nhưng không bao giờ kéo nó\n Nâng ngực lên và xoay sang bên phải, đưa khuỷu tay trái lên đầu gối phải đồng thời giữ chân trái thẳng\n Chân phải của bạn duỗi thẳng về phía ngực\n Đổi bên, đưa khuỷu tay phải lên đầu gối trái, chân này duỗi thẳng về phía ngực khi chân phải của bạn nằm thẳng\n Nhìn lên trần nhà để bạn vận động cơ bụng đúng cách và không làm căng cổ",
                CaloriesPerMinute = 7f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 30
            new Exercise
            {
                ExerciseId = Guid.Parse("0a9e1fb3-9abf-4775-a75e-2bb13009a29d"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Squat với tạ",
                Instructions =
                    "Đứng thẳng với hai bàn chân rộng bằng vai và các ngón chân hơi hướng ra ngoài\n Nắm một quả tạ giữa hai tay và nâng lên ngực với khuỷu tay cong\n Nhìn thẳng về phía trước, hít một hơi thật sâu và siết chặt cơ bụng đồng thời đẩy hông ra sau và gập đầu gối để bắt đầu squat\n Cột sống của bạn phải giữ ở vị trí trung lập\n Giữ lòng bàn chân đặt chắc chắn trên sàn và đảm bảo trọng lượng cơ thể và tạ được phân bổ đều trên bàn chân của bạn\n Trong khi squat, hạ mông xuống hơi quá điểm mà đùi của bạn song song với sàn nhà\n Ở dưới cùng của squat, khuỷu tay của bạn phải chạm vào bên trong đầu gối của bạn\n Đẩy gót chân để trở lại vị trí bắt đầu\n Thở ra trong phần cuối cùng của bài tập này",
                CaloriesPerMinute = 7.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 31
            new Exercise
            {
                ExerciseId = Guid.Parse("b2e62599-1f8c-4fc2-9ca7-8ab7aa571d4e"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Ép tạ qua đầu khi ngồi",
                Instructions =
                    "Nắm tạ ở mỗi tay\n Ngồi trên ghế hoặc băng ghế và đặt tạ lên đùi của bạn\n Tựa lưng vào ghế cực kỳ thẳng với vai ra sau và ngực ưỡn ra\n Bàn chân của bạn phải đặt trên sàn và chân của bạn phải hoàn toàn ổn định\n Nâng tạ cho đến khi tay của bạn ngang tầm với vai trên của bạn và khuỷu tay của bạn cong xuống và thẳng hàng với cơ thể của bạn\n Lòng bàn tay của bạn phải hướng về phía trước\n Bây giờ nâng tạ lên trên đầu với cánh tay duỗi thẳng và không khóa khuỷu tay\n Cẩn thận trở lại vị trí bắt đầu và hoàn thành hiệp của bạn\n Nhìn thẳng về phía trước trong suốt bài tập",
                CaloriesPerMinute = 5.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 32
            new Exercise
            {
                ExerciseId = Guid.Parse("3409fd0e-659a-4ee4-8157-60e2ba94350c"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Cuốn tay với dây kháng lực",
                Instructions =
                    "Đứng thẳng\n Nắm một đầu của dây kháng lực bằng cả hai tay (rộng bằng hông với lòng bàn tay hướng lên trên) và đặt đầu kia dưới chân của bạn\n Giữ ngực thẳng và thẳng\n Gập cánh tay của bạn để nâng dây về phía ngực của bạn",
                CaloriesPerMinute = 4.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 33
            new Exercise
            {
                ExerciseId = Guid.Parse("07a4dbcd-635a-4a76-92d4-8127de619e6d"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Plank ngôi sao",
                Instructions =
                    "Vị trí plank cổ điển: hai tay trên sàn, hai chân rộng bằng hông, đầu gối cong\n Nâng chân của bạn lên trần nhà mà không cong lưng",
                CaloriesPerMinute = 6.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 34
            new Exercise
            {
                ExerciseId = Guid.Parse("ca76bd88-8267-4e05-afce-8765546c20f5"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Xoay người kiểu Nga",
                Instructions =
                    "Nằm ngửa, nâng chân và ngực của bạn lên như thể bạn đang vào tư thế con thuyền\n Ngoại trừ ở đây, đầu gối của bạn không bị khóa mà hơi cong\n Xoay từ trái sang phải như thể bạn đang di chuyển một vật từ bên này cơ thể sang bên kia. Giữ lưng thẳng và ngực siết chặt",
                CaloriesPerMinute = 6f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 35
            new Exercise
            {
                ExerciseId = Guid.Parse("01dc4c46-e1ef-44bc-9f19-ecb283bf27ce"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Nâng chân sang ngang bên phải",
                Instructions =
                    "Đứng thẳng và quấn dây kháng lực quanh chân của bạn\n Giữ thẳng lưng và siết chặt cơ bụng, sau đó nâng chân sang ngang\n Thực hiện một hiệp đầy đủ với một chân, sau đó thực hiện một hiệp với chân kia",
                CaloriesPerMinute = 5.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 36
            new Exercise
            {
                ExerciseId = Guid.Parse("6badb5b5-ad99-4b89-80c6-e52d0f7cd7ba"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Nâng chân sang ngang bên trái",
                Instructions =
                    "Đứng thẳng và quấn dây kháng lực quanh chân của bạn\n Giữ thẳng lưng và siết chặt cơ bụng, sau đó nâng chân sang ngang\n Thực hiện một hiệp đầy đủ với một chân, sau đó thực hiện một hiệp với chân kia",
                CaloriesPerMinute = 5.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 37
            new Exercise
            {
                ExerciseId = Guid.Parse("2d7c513e-1dc6-46c8-82d6-9d39df8074e3"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Duỗi tay sau đầu bên phải",
                Instructions =
                    "Đứng thẳng\n Nắm một quả tạ bằng một tay. Giữ ngực thẳng và thẳng, và nhìn thẳng phía trước\n Gập khuỷu tay của bạn và nâng cánh tay lên trên đầu với cẳng tay và quả tạ treo phía sau bạn để khuỷu tay của bạn hướng thẳng lên trần nhà\n Ngón út của bạn phải chạm vào đỉnh tay cầm quả tạ\n Hít một hơi thật sâu và giữ cánh tay trên của bạn bất động\n Đẩy quả tạ lên trên cho đến khi cánh tay của bạn duỗi thẳng hoàn toàn\n Từ từ đưa quả tạ trở lại vị trí bắt đầu",
                CaloriesPerMinute = 4.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 38
            new Exercise
            {
                ExerciseId = Guid.Parse("bc06f6c3-3625-438b-9563-3406e50612ee"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Duỗi tay sau đầu bên trái",
                Instructions =
                    "Đứng thẳng\n Nắm một quả tạ bằng một tay. Giữ ngực thẳng và thẳng, và nhìn thẳng phía trước\n Gập khuỷu tay của bạn và nâng cánh tay lên trên đầu với cẳng tay và quả tạ treo phía sau bạn để khuỷu tay của bạn hướng thẳng lên trần nhà\n Ngón út của bạn phải chạm vào đỉnh tay cầm quả tạ\n Hít một hơi thật sâu và giữ cánh tay trên của bạn bất động\n Đẩy quả tạ lên trên cho đến khi cánh tay của bạn duỗi thẳng hoàn toàn\n Từ từ đưa quả tạ trở lại vị trí bắt đầu",
                CaloriesPerMinute = 4.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 39
            new Exercise
            {
                ExerciseId = Guid.Parse("93e22c77-001f-4825-8983-4ec5b643b7bb"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Nâng bắp chân",
                Instructions =
                    "Đứng thẳng với hai chân duỗi thẳng để bàn chân, hông và vai của bạn thẳng hàng\n Nhấc gót chân lên khỏi sàn nhiều lần liên tiếp\n Bạn sẽ cảm thấy hơi nóng rát ở bắp chân",
                CaloriesPerMinute = 4f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 40
            new Exercise
            {
                ExerciseId = Guid.Parse("439db970-c7c8-4b3b-9a35-127d31d920dc"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Plank nhảy",
                Instructions =
                    "Vị trí plank cổ điển: hai tay trên sàn, hai chân rộng bằng hông, đầu gối cong\n Di chuyển bàn chân sang hai bên bằng các động tác nhảy\n Trở lại vị trí plank và thực hiện số lần lặp lại mong muốn",
                CaloriesPerMinute = 7.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 41
            new Exercise
            {
                ExerciseId = Guid.Parse("0a280d32-de67-4a38-8f21-923243489eef"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Gập bụng và xoay người",
                Instructions =
                    "Nằm ngửa với hai chân cong và hơi tách rời\n Nâng ngực lên và xoay người khi bạn lên đến đỉnh\n Bạn có thể bắt đầu bằng cách xoay sang bên phải và sau đó đưa ngực trở lại xuống\n Khi bạn đi lên trở lại, hãy xoay sang bên trái, v.v\n Nhìn lên trần nhà và theo hướng bạn xoay người",
                CaloriesPerMinute = 6f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 42
            new Exercise
            {
                ExerciseId = Guid.Parse("235f7494-3e7d-45a5-a31a-6d5449b1322d"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Bước lùi",
                Instructions =
                    "Đứng thẳng và bước một bước lớn về phía sau bằng cách gập chân cho đến khi đầu gối của bạn cong 90°\n Trở lại vị trí bắt đầu\n Lặp lại\n Luân phiên giữa chân phải và chân trái",
                CaloriesPerMinute = 5.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 43
            new Exercise
            {
                ExerciseId = Guid.Parse("f51a195e-e5d3-4da9-9b6d-eba4f2856f14"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Đá chân sau với dây kháng lực bên phải",
                Instructions =
                    "Đứng thẳng và quấn dây kháng lực quanh chân của bạn.\n Giữ thẳng lưng và siết chặt cơ bụng, sau đó nâng chân ra phía sau.\n Thực hiện một hiệp đầy đủ với một chân, sau đó thực hiện một hiệp với chân kia.\n Cẩn thận không cong lưng",
                CaloriesPerMinute = 4.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 44
            new Exercise
            {
                ExerciseId = Guid.Parse("1ecc8327-e3b6-4a76-906a-d64b3fa3a9be"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Đá chân sau với dây kháng lực bên trái",
                Instructions =
                    "1. Stand up and wrap a resistance band around your legs\n 2. Straighten your back and engage your abs, then lift your leg backwards\n 3. Do a full set with one leg, then do a set with the other\n 4. Be careful not to arch your back",
                CaloriesPerMinute = 4.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 45
            new Exercise
            {
                ExerciseId = Guid.Parse("9fb83332-a8fc-4fcc-a015-2e784e2ab33b"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Squat với tạ",
                Instructions =
                    "Đứng thẳng với hai bàn chân rộng bằng vai và các ngón chân hơi hướng ra ngoài\n Nắm một quả tạ giữa hai tay và nâng lên ngực với khuỷu tay cong\n Nhìn thẳng về phía trước, hít một hơi thật sâu và siết chặt cơ bụng đồng thời đẩy hông ra sau và gập đầu gối để bắt đầu squat\n Cột sống của bạn phải giữ ở vị trí trung lập\n Giữ lòng bàn chân đặt chắc chắn trên sàn và đảm bảo trọng lượng cơ thể và tạ được phân bổ đều trên bàn chân của bạn\n Trong khi squat, hạ mông xuống hơi quá điểm mà đùi của bạn song song với sàn nhà\n Ở dưới cùng của squat, khuỷu tay của bạn phải chạm vào bên trong đầu gối của bạn\n Đẩy gót chân để trở lại vị trí bắt đầu\n Thở ra trong phần cuối cùng của bài tập này",
                CaloriesPerMinute = 7.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 46
            new Exercise
            {
                ExerciseId = Guid.Parse("8b93dbb2-fc2b-4627-b79a-3ec45a7c6238"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Đá mông bên phải",
                Instructions =
                    "Quỳ bốn chân và chống khuỷu tay với lưng thẳng, cổ thẳng hàng với cột sống và mắt hướng xuống đất\n Khi bạn thở ra, hãy nâng một chân lên và siết chặt mông của bạn\n Khi bạn hít vào, hãy hạ chân xuống mà không chạm đất\n Lặp lại\n Để khó hơn, hãy sử dụng tạ mắt cá chân",
                CaloriesPerMinute = 5.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 47
            new Exercise
            {
                ExerciseId = Guid.Parse("8619916d-a296-48a5-af89-f82a6a1cb26f"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Đá mông bên trái",
                Instructions =
                    "Quỳ bốn chân và chống khuỷu tay với lưng thẳng, cổ thẳng hàng với cột sống và mắt hướng xuống đất\n Khi bạn thở ra, hãy nâng một chân lên và siết chặt mông của bạn\n Khi bạn hít vào, hãy hạ chân xuống mà không chạm đất\n Lặp lại\n Để khó hơn, hãy sử dụng tạ mắt cá chân",
                CaloriesPerMinute = 5.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 48
            new Exercise
            {
                ExerciseId = Guid.Parse("d4ebca3a-83ef-485b-9178-83d4eab9694c"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Cây cầu",
                Instructions =
                    "Nằm ngửa với hai tay ở hai bên, hai chân cong và bàn chân đặt trên sàn\n Thở ra trong khi nâng mông lên khỏi sàn, đảm bảo không mở rộng quá mức lưng dưới của bạn\n Hít vào trong khi hạ xương chậu xuống, đảm bảo mông của bạn không chạm sàn",
                CaloriesPerMinute = 4.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 49
            new Exercise
            {
                ExerciseId = Guid.Parse("6749cbc6-0e28-4163-95e8-7fb2a27c54cf"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Chim bay",
                Instructions =
                    "Đối với bài tập này, hãy chọn một quả tạ tương đối nhẹ\n Ngồi xuống với ngực nghiêng về phía đầu gối\n Nắm một quả tạ ở mỗi tay với lòng bàn tay hướng xuống dưới\n Nâng tạ bằng cách dang rộng hai tay ra ngoài và giữ cho khuỷu tay vuông góc với cơ thể",
                CaloriesPerMinute = 5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 50
            new Exercise
            {
                ExerciseId = Guid.Parse("e6bf67b0-8f4e-4585-9669-4f205d0aaf8e"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Chống đẩy trên đầu gối",
                Instructions =
                    "Nằm sấp\n Đặt hai tay thẳng trên sàn sao cho thẳng hàng với vai và hơi rộng hơn vai một chút\n Giữ cho cơ thể thẳng\n Nâng cơ thể lên bằng cách duỗi thẳng tay, đồng thời giữ cho cơ thể thẳng\n Tránh cong lưng\n Chỉ có tay và đầu gối của bạn chạm sàn và cơ thể của bạn phải nằm trên một đường thẳng\n Không chạm sàn giữa các lần chống đẩy",
                CaloriesPerMinute = 4f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 51
            new Exercise
            {
                ExerciseId = Guid.Parse("2da27966-24d6-4159-9a70-968e20c4036d"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Ép tạ qua đầu khi ngồi",
                Instructions =
                    "Nắm một quả tạ ở mỗi tay\n Ngồi trên ghế hoặc băng ghế và đặt tạ lên đùi của bạn\n Tựa lưng vào tựa lưng hoặc giữ cho mình cực kỳ thẳng với vai ra sau và ngực ưỡn ra\n Bàn chân của bạn phải đặt trên sàn và chân của bạn phải hoàn toàn ổn định\n Nâng tạ cho đến khi tay của bạn ngang tầm với vai trên của bạn và khuỷu tay của bạn cong xuống và thẳng hàng với cơ thể của bạn\n Lòng bàn tay của bạn phải hướng về phía trước\n Bây giờ nâng tạ lên trên đầu với cánh tay duỗi thẳng và không khóa khuỷu tay\n Cẩn thận trở lại vị trí bắt đầu và hoàn thành hiệp của bạn\n Nhìn thẳng về phía trước trong suốt bài tập",
                CaloriesPerMinute = 5.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 52
            new Exercise
            {
                ExerciseId = Guid.Parse("3f674891-2d75-42bf-af35-a89dff24ab22"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Deadlift với dây kháng lực",
                Instructions =
                    "Đứng hai chân rộng bằng hông hoặc vai\n Đặt một đầu của dây kháng lực nhỏ dưới chân của bạn và nắm đầu kia bằng tay với lòng bàn tay hướng về phía bạn\n Hít một hơi thật sâu và thở ra trong khi nghiêng người về phía trước và đẩy hông ra phía sau\n Giữ lưng thẳng hoặc lưng dưới (thắt lưng) hơi cong bằng cách đẩy hông ra phía sau, và nghiêng người về phía trước cho đến khi ngực của bạn song song với mặt đất hoặc hơi cao hơn\n Giữ đầu của bạn thẳng hàng với cột sống của bạn và trở lại vị trí bắt đầu",
                CaloriesPerMinute = 6f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 53
            new Exercise
            {
                ExerciseId = Guid.Parse("a4c84cac-058f-472a-8b81-a00c025eace4"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Burpee dễ dàng",
                Instructions =
                    "Bắt đầu bằng cách đứng, sau đó vào vị trí plank bằng cách di chuyển từng chân ra phía sau\n Đưa hai chân về phía trước (từng chân một) vào tư thế squat\n Nhảy thẳng lên và giơ hai tay lên trên đầu\n Trở lại vị trí plank và lặp lại bài tập",
                CaloriesPerMinute = 7f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 54
            new Exercise
            {
                ExerciseId = Guid.Parse("0c011f92-425a-477c-84d4-3d6dc883119b"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Mở ngực",
                Instructions =
                    "Nằm ngửa với đầu, vai và mông chạm sàn\n Chân của bạn phải cong và bàn chân đặt trên sàn\n Nắm một quả tạ ở mỗi tay với lòng bàn tay hướng về phía bàn chân của bạn\n Nâng tạ trực tiếp lên trên ngực của bạn cho đến khi chúng chạm nhau\n Hít vào và giữ hơi thở của bạn trong khi hạ tạ xuống\n Khuỷu tay của bạn sẽ di chuyển ra ngoài khi tạ đến gần hai bên của bạn\n Lặp lại\n Thở ra trong phần khó nhất của động tác nâng",
                CaloriesPerMinute = 4.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 55
            new Exercise
            {
                ExerciseId = Guid.Parse("f06a6d9b-ed14-46cd-9e56-145cd1fd3d7c"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Chuyển động Arlaud",
                Instructions =
                    "Nằm sấp (trên thảm để thoải mái hơn) với hai tay duỗi thẳng và hai chân khép lại\n Ngực của bạn hơi nâng lên\n Hít một hơi thật sâu, sau đó nhẹ nhàng đưa hai tay ra phía sau trong khi thở ra\n Hai tay của bạn không được chạm sàn\n Cố gắng chạm vào mông của bạn\n Đưa hai tay trở lại vị trí bắt đầu và lặp lại",
                CaloriesPerMinute = 5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 56
            new Exercise
            {
                ExerciseId = Guid.Parse("4d4ca701-48a4-4385-a9b7-511cf07ef775"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Deadlift với tạ",
                Instructions =
                    "Đứng hai chân rộng bằng vai hoặc hông và nắm một quả tạ ở mỗi tay với lòng bàn tay hướng xuống dưới\n Hít một hơi thật sâu và thở ra trong khi nghiêng người về phía trước bằng hông của bạn\n Giữ lưng thẳng hoặc lưng dưới (thắt lưng) hơi cong bằng cách đẩy hông ra phía sau, và nghiêng người về phía trước cho đến khi ngực của bạn song song với mặt đất hoặc hơi thấp hơn\n Giữ đầu của bạn thẳng hàng với cột sống của bạn và đầu gối của bạn hơi cong\n Nếu lưng của bạn bắt đầu cong khi bạn nghiêng người về phía trước, hãy dừng bài tập ngay lập tức\n Khi bạn đạt đến vị trí thấp nhất, hãy giữ cho cột sống của bạn thẳng và nâng ngực lên trong khi hít vào và đẩy hông về phía trước",
                CaloriesPerMinute = 6.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 57
            new Exercise
            {
                ExerciseId = Guid.Parse("6ef8ed78-0d00-4271-bf9b-edf27a55ecab"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Đá tay sau với tạ bên phải",
                Instructions =
                    "Trong khi đứng, hạ ngực của bạn cho đến khi nó nằm ngang (hoặc gần như nằm ngang)\n Nếu nó giúp ích, bạn có thể sử dụng lưng ghế để hỗ trợ cánh tay không hoạt động\n Nắm một quả tạ bằng một tay với lòng bàn tay hướng vào cơ thể bạn\n Giữ cánh tay của bạn (cầm quả tạ) thẳng hàng với cơ thể của bạn\n Gập khuỷu tay của bạn để cẳng tay của bạn thẳng đứng\n Nâng quả tạ trong khi giữ cho cánh tay trên của bạn bất động\n Từ từ đưa quả tạ trở lại vị trí bắt đầu\n Khi cánh tay của bạn duỗi thẳng, nó phải thẳng hàng với ngực của bạn\n Tiếp tục với tốc độ vừa phải mà không giật quả tạ lên trên\n Sau khi bạn hoàn thành một hiệp với một tay, hãy đổi bên và thực hiện một hiệp với tay kia",
                CaloriesPerMinute = 5.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 58
            new Exercise
            {
                ExerciseId = Guid.Parse("0d816828-8a94-4dcb-a87c-b70b295a39b6"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Đá tay sau với tạ bên trái",
                Instructions =
                    "Trong khi đứng, hạ ngực của bạn cho đến khi nó nằm ngang (hoặc gần như nằm ngang)\n Nếu nó giúp ích, bạn có thể sử dụng lưng ghế để hỗ trợ cánh tay không hoạt động\n Nắm một quả tạ bằng một tay với lòng bàn tay hướng vào cơ thể bạn\n Giữ cánh tay của bạn (cầm quả tạ) thẳng hàng với cơ thể của bạn\n Gập khuỷu tay của bạn để cẳng tay của bạn thẳng đứng\n Nâng quả tạ trong khi giữ cho cánh tay trên của bạn bất động\n Từ từ đưa quả tạ trở lại vị trí bắt đầu\n Khi cánh tay của bạn duỗi thẳng, nó phải thẳng hàng với ngực của bạn\n Tiếp tục với tốc độ vừa phải mà không giật quả tạ lên trên\n Sau khi bạn hoàn thành một hiệp với một tay, hãy đổi bên và thực hiện một hiệp với tay kia",
                CaloriesPerMinute = 5.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 59
            new Exercise
            {
                ExerciseId = Guid.Parse("587228d2-b0a2-46d4-8f0b-e728a3726993"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Plank",
                Instructions =
                    "Cẳng tay và ngón chân trên thảm\n Cơ thể siết chặt và nằm trên một đường thẳng từ đầu đến chân\n Giữ vị trí này với chân, mông và bụng của bạn co lại",
                CaloriesPerMinute = 6.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 60
            new Exercise
            {
                ExerciseId = Guid.Parse("256e23fa-03b1-4328-a325-512f0860d9b0"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Nâng chân",
                Instructions =
                    "Nằm ngửa với hai chân duỗi thẳng và hai tay đặt dưới mông\n Cố gắng nâng chân của bạn để chúng tạo thành một góc vuông với cơ thể của bạn\n Từ từ đưa chân của bạn trở lại xuống mà không để chúng chạm sàn, sau đó nâng chúng lên một lần nữa\n Cực kỳ cẩn thận để bạn không mở rộng quá mức lưng của bạn",
                CaloriesPerMinute = 5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 61
            new Exercise
            {
                ExerciseId = Guid.Parse("d9d1c0b6-1d8d-42cf-aeca-8d9359e67ac8"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Bước tới",
                Instructions =
                    "Đứng thẳng và bước một bước lớn về phía trước bằng cách gập chân cho đến khi đầu gối của bạn cong 90°\n Trở lại vị trí bắt đầu\n Luân phiên giữa chân phải và chân trái",
                CaloriesPerMinute = 6f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 62
            new Exercise
            {
                ExerciseId = Guid.Parse("1c5d2078-a923-4953-9677-ff890977ffcd"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Squat nhịp nhàng",
                Instructions =
                    "Đứng thẳng với hai chân rộng bằng vai và hai tay duỗi thẳng và thẳng hàng với bàn chân\n Hít vào và gập đầu gối cho đến khi đùi của bạn song song với sàn nhà\n Gập đầu gối tới lui mà không đứng lên để bạn liên tục vận động cơ bắp của mình\n Đảm bảo giữ ngực thẳng và ưỡn",
                CaloriesPerMinute = 6f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 63
            new Exercise
            {
                ExerciseId = Guid.Parse("01e6141a-930e-4126-a2c6-7c32a2ccdd43"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Kéo vai bằng dây đàn hồi",
                Instructions =
                    "Đảm bảo bạn có dây kháng lực phù hợp với sức mạnh của mình\n Đứng thẳng và đặt một đầu của dây dưới chân của bạn và nắm đầu kia bằng tay của bạn\n Duỗi thẳng tay của bạn xuống đất với lòng bàn tay hướng xuống dưới\n Giữ hai tay của bạn với nhau và kéo dây về phía cằm của bạn\n Đảm bảo nới lỏng vai của bạn trước khi bắt đầu bài tập\n Giữ cho bụng của bạn siết chặt",
                CaloriesPerMinute = 5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 64
            new Exercise
            {
                ExerciseId = Guid.Parse("ac074f67-d4bf-4a7f-b7e3-d8d03bbb6704"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Cuốn tạ",
                Instructions =
                    "Đứng hoặc ngồi với hai bàn chân đủ rộng để giữ cho bạn ở một vị trí ổn định\n Nắm một quả tạ mỗi tay và giữ cánh tay của bạn ở hai bên với lòng bàn tay hướng vào trong về phía đùi của bạn\n Gập cánh tay của bạn lên trên trong khi giữ ngực thẳng và ưỡn\n Khi cánh tay của bạn cong 90°, hãy xoay cẳng tay của bạn để lòng bàn tay của bạn hướng lên trên\n Tiếp tục nâng cánh tay của bạn, sau đó trở lại vị trí bắt đầu bằng cách thực hiện các bước theo thứ tự ngược lại\n Luân phiên từ phải sang trái",
                CaloriesPerMinute = 5.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 65
            new Exercise
            {
                ExerciseId = Guid.Parse("4834f1ce-41dc-4161-ac51-e03ca78b62b8"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Superman tĩnh",
                Instructions =
                    "Nằm sấp trên sàn. Giữ cho chân của bạn thẳng và khép lại\n Duỗi thẳng tay của bạn lên trên đầu để cơ thể bạn tạo thành một đường thẳng\n Hít vào và nâng cánh tay, ngực và chân của bạn lên. Cơ thể của bạn phải tạo thành một vòng cung\n Giữ ở vị trí này với cơ bụng siết chặt và thở chậm",
                CaloriesPerMinute = 5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 66
            new Exercise
            {
                ExerciseId = Guid.Parse("3a5a57a3-3495-45ae-9ebe-708e4d513d0c"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Đi bộ gấu",
                Instructions =
                    "Quỳ bốn chân\n Bắt đầu với hai tay dưới vai, đầu gối dưới hông và lưng thẳng\n Bước về phía trước, luân phiên giữa tay và chân",
                CaloriesPerMinute = 6.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 67
            new Exercise
            {
                ExerciseId = Guid.Parse("d6b2c0d5-110f-4dff-9aa7-91da10a29dca"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Nâng hông với dây kháng lực",
                Instructions =
                    "Quấn dây kháng lực quanh chân của bạn, ngay trên đầu gối\n Tựa lưng trên của bạn vào mép ghế sofa, ghế tựa hoặc băng ghế\n Lưỡi vai dưới của bạn phải nằm trực tiếp trên mép\n Đầu gối của bạn phải thẳng hàng hoàn hảo với ngực trên của bạn\n Bàn chân của bạn phải thẳng hàng với đầu gối của bạn\n Giữ cho đầu gối của bạn cong, đẩy gót chân để nâng hông lên\n Nâng hông của bạn lên và xuống mà không để mông chạm sàn\n Phần dưới cơ thể của bạn - chứ không phải lưng của bạn - phải thực hiện công việc\n Không khóa đầu gối của bạn khi đi lên\n Tối đa hóa sức đề kháng của dây\n Đặt chân của bạn ở nhiều góc độ khác nhau để tìm vị trí phù hợp nhất với bạn",
                CaloriesPerMinute = 6f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 68
            new Exercise
            {
                ExerciseId = Guid.Parse("13ca014d-8b75-414f-afe3-3d378ef7fa97"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Bước lên",
                Instructions =
                    "Đứng trước một bậc thang như ghế đẩu, ghế hoặc băng ghế\n Đứng thẳng và siết chặt cơ bụng và ngực của bạn\n Bước lên vật thể, luân phiên chân",
                CaloriesPerMinute = 6f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 69
            new Exercise
            {
                ExerciseId = Guid.Parse("05c931df-c828-442e-aee1-56432cb772c7"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Plank ngược",
                Instructions =
                    "Mắt và cơ bụng hướng lên trần nhà\n Lòng bàn tay và gót chân trên thảm\n Cơ thể siết chặt và nằm trên một đường thẳng từ đầu đến chân\n Giữ vị trí này với chân, mông và cơ bụng của bạn co lại",
                CaloriesPerMinute = 6f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 70
            new Exercise
            {
                ExerciseId = Guid.Parse("a9629bb1-7d84-4e14-8898-c3bf6c932efb"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Gập bụng",
                Instructions =
                    "Nằm ngửa với hai chân hơi cong\n Nâng ngực lên cho đến khi bạn đang ngồi\n Nhìn lên trần nhà để bạn vận động cơ bụng đúng cách và không làm căng cổ",
                CaloriesPerMinute = 5.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 71
            new Exercise
            {
                ExerciseId = Guid.Parse("22af0171-257b-43bc-9013-8985472a8c84"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Gập bụng chéo bên phải",
                Instructions =
                    "Nằm ngửa với hai chân cong\n Nâng chân phải của bạn lên để nó vuông góc với chân trái của bạn\n Đặt chân phải của bạn lên đầu gối trái của bạn\n Nâng ngực của bạn và đưa khuỷu tay trái của bạn càng gần đầu gối phải của bạn càng tốt\n Nhìn lên trần nhà để bạn vận động cơ bụng đúng cách và không làm căng cổ\n Thực hiện một hiệp đầy đủ như thế này. sau đó đổi chân và thực hiện một hiệp trong khi đưa khuỷu tay phải của bạn lên đầu gối trái của bạn",
                CaloriesPerMinute = 6f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 72
            new Exercise
            {
                ExerciseId = Guid.Parse("6ffea500-ca35-4483-b049-d8593b2c8680"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Gập bụng chéo bên trái",
                Instructions =
                    "Nằm ngửa với hai chân cong\n Nâng chân trái của bạn lên để nó vuông góc với chân phải của bạn\n Đặt chân trái của bạn lên đầu gối phải của bạn\n Nâng ngực của bạn và đưa khuỷu tay phải của bạn càng gần đầu gối trái của bạn càng tốt\n Nhìn lên trần nhà để bạn vận động cơ bụng đúng cách và không làm căng cổ\n Thực hiện một hiệp đầy đủ như thế này. Sau đó đổi chân và thực hiện một hiệp trong khi đưa khuỷu tay trái của bạn lên đầu gối phải của bạn",
                CaloriesPerMinute = 6f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 73
            new Exercise
            {
                ExerciseId = Guid.Parse("6d6b06e1-5ade-4dae-b442-7aa200661760"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Plank bắt đầu",
                Instructions =
                    "Vị trí plank cổ điển: hai tay trên sàn, hai chân rộng bằng hông, đầu gối cong\n Nâng chân của bạn lên trần nhà mà không cong lưng",
                CaloriesPerMinute = 6.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 74
            new Exercise
            {
                ExerciseId = Guid.Parse("0d1e54fe-7a5f-4e0a-a59f-ee9f443718e0"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Chạm mũi chân khi đứng",
                Instructions =
                    "Đứng thẳng với cơ bụng siết chặt\n Nâng chân trái của bạn ra phía sau đến chiều cao của hông hoặc cao hơn, nếu có thể\n Bằng tay phải, chạm vào đỉnh bàn chân trái của bạn\n Trở lại vị trí bắt đầu và đổi chân",
                CaloriesPerMinute = 5.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 75
            new Exercise
            {
                ExerciseId = Guid.Parse("d3d944c4-947d-4910-bb6e-636390e5b8d5"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Plank nghiêng bên trái",
                Instructions =
                    "Vào vị trí plank nghiêng\n Cơ thể của bạn phải được nâng lên khỏi thảm và chỉ được hỗ trợ bởi cẳng tay và bàn chân của bạn\n Thở chậm và giữ cho cơ bụng của bạn siết chặt",
                CaloriesPerMinute = 6.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 76
            new Exercise
            {
                ExerciseId = Guid.Parse("f93d73ba-d1d6-4037-b51b-1fd005accff3"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Plank nghiêng bên phải",
                Instructions =
                    "Vào vị trí plank nghiêng\n Cơ thể của bạn phải được nâng lên khỏi thảm và chỉ được hỗ trợ bởi cẳng tay và bàn chân của bạn\n Thở chậm và giữ cho cơ bụng của bạn siết chặt",
                CaloriesPerMinute = 6.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 77
            new Exercise
            {
                ExerciseId = Guid.Parse("385f13f7-79bf-437b-acac-745b50485b9f"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Nâng tay phía trước",
                Instructions =
                    "Đứng thẳng và nắm một quả tạ ở mỗi tay\n Giữ lưng thẳng và cơ bụng siết chặt\n Nâng tạ trực tiếp về phía trước bạn\n Cổ tay của bạn không được vượt quá chiều cao của vai trong khi nâng",
                CaloriesPerMinute = 4.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 78
            new Exercise
            {
                ExerciseId = Guid.Parse("2e787245-7612-41bc-9b75-7a4857282350"),
                UserId = userId,
                ExerciseType = ExerciseType.Reps,
                ExerciseName = "Gập người lên và nâng hông",
                Instructions =
                    "Nằm thẳng lưng\n Hai tay của bạn phải duỗi thẳng ra sau đầu\n Thực hiện động tác gập người hoàn toàn\n Ngay lập tức vào tư thế bàn ngược bằng cách nâng hông của bạn lên trần nhà\n Trở lại vị trí bắt đầu và bắt đầu lại\n Giữ cho cơ bụng của bạn siết chặt trong suốt bài tập\n Chuyển động của bạn phải chính xác\n Giữ ánh mắt của bạn hướng lên trần nhà\n Vai của bạn phải thấp hơn tai",
                CaloriesPerMinute = 6.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise 79
            new Exercise
            {
                ExerciseId = Guid.Parse("2696db05-e815-4c8b-870d-23c338479e95"),
                UserId = userId,
                ExerciseType = ExerciseType.Time,
                ExerciseName = "Tựa lưng vào tường",
                Instructions =
                    "Tựa lưng vào tường\n Gập đầu gối của bạn để tạo thành một góc 90°\n Giữ tay của bạn ở hai bên hoặc phía trước cơ thể, hoặc trên đầu, nhưng không để chúng tựa vào chân của bạn\n Giữ ở vị trí này trong số giây yêu cầu",
                CaloriesPerMinute = 5.5f,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            }
            #endregion
            );
        }
    }
}
