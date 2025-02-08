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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
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
                CaloriesPerMinute = 0,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion

            #region Exercise ???
            new Exercise
            {
                ExerciseId = Guid.Parse(""),
                UserId = userId,
                ExerciseType = ExerciseType.,
                ExerciseName = "",
                Instructions =
                    "",
                CaloriesPerMinute = 0,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId
            },
            #endregion
            );
        }
    }
}
