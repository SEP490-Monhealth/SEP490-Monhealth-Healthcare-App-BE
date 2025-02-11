using AutoMapper;
using Monhealth.Application.Features.Workout.Commands.CreateWorkout;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class WorkoutProfile : Profile
    {
        public WorkoutProfile()
        {
            CreateMap<CreateWorkoutCommand, Workout>()
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(_ => DateTime.Now));
            CreateMap<CreateExcerciseDto, WorkoutExercise>()
                  .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(_ => DateTime.Now));
        }
    }
}
