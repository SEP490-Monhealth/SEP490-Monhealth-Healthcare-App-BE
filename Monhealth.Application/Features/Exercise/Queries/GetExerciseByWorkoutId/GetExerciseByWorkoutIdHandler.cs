using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Exercise.Queries.GetExerciseByWorkoutId
{
    public class GetExerciseByWorkoutIdHandler(IWorkoutRepository workoutRepository, IMapper mapper,
                IExerciseRepository exerciseRepository
        ) : IRequestHandler<GetExerciseByWorkoutIdQuery, GetExerciseByWorkoutIdDto>
    {
        public async Task<GetExerciseByWorkoutIdDto> Handle(GetExerciseByWorkoutIdQuery request, CancellationToken cancellationToken)
        {
            var workout = await workoutRepository.GetWorkoutByIdAsync(request.WorkoutId);
            if (workout == null) throw new Exception("Không tìm thấy bài tập");
            var exerciseLists = new List<string>();
            if (workout.WorkoutType == Core.Enum.WorkoutType.FullBody)
            {
                exerciseLists = new List<string>
                {
                    "6fe4dcc3-5262-470e-b043-0db293dda2fb",
                    "90ce2a9f-d0be-4ca0-b3ca-8b6947a6b266",
                    "546e3f6d-16be-4d13-8c15-3947bcf15b1f"
                };
            }
            else if (workout.WorkoutType == Core.Enum.WorkoutType.UpperBody)
            {
                exerciseLists = new List<string>
                {
                    "bd976f53-25f4-49ba-9943-4c92a2a7eb89",
                    "44f8a6a5-04ab-447a-9361-b0e545d12f42",
                    "72206c5e-58f3-46f0-a8b1-031cbf599433"
                };
            }
            else if (workout.WorkoutType == Core.Enum.WorkoutType.LowerBody)
            {
                exerciseLists = new List<string>
                {
                    "6fe4dcc3-5262-470e-b043-0db293dda2fb",
                    "3100278d-eee7-4b89-b726-4b76daefabde",
                    "92ddccfd-7076-4dbc-b96b-9197cd4cc308",
                    "ee5b2085-e5d2-4236-8afb-6d1c33f97d30"
                };
            }
            else
            {
                exerciseLists = new List<string>
                {
                    "6fe4dcc3-5262-470e-b043-0db293dda2fb",
                    "44f8a6a5-04ab-447a-9361-b0e545d12f42",
                    "72206c5e-58f3-46f0-a8b1-031cbf599433"
                };
            }
            List<Guid> exerciseList = exerciseLists.Select(Guid.Parse).ToList();
            var exerciseWramupList = await exerciseRepository.GetExercisesByListId(exerciseList);
            var exercises = await exerciseRepository.GetExercisesByWorkoutIdAsync(request.WorkoutId);
            var response = new GetExerciseByWorkoutIdDto
            {
                Warmup = mapper.Map<List<ExerciseDto>>(exerciseWramupList.ToList()),
                Workout = mapper.Map<List<ExerciseDto>>(exercises.ToList())
            };
            return response;
        }
    }
}
