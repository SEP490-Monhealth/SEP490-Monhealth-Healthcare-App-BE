﻿using AutoMapper;
using Monhealth.Application.Features.Workout.Commands.CreateWorkout;
using Monhealth.Application.Features.Workout.Queries.GetAllWorkoutQueries;
using Monhealth.Application.Features.Workout.Queries.GetWorkoutByUserIdQueries;
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

            //get
            CreateMap<Workout, WorkoutDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
                .ForMember(dest => dest.Exercises, opt => opt.MapFrom(src => src.WorkoutExercises.Count))
                .ForMember(dest => dest.DurationMinutes, opt => opt.MapFrom(src => src.WorkoutExercises.Sum(we => we.DurationSeconds + we.Reps * 2)))
                .ForMember(dest => dest.CaloriesBurned, opt => opt.MapFrom(src => src.WorkoutExercises.Sum(we => (we.Exercise.CaloriesPerMinute * (we.DurationSeconds / 60)) + we.Exercise.CaloriesPerMinute * (we.Reps * 2 / 60))));
            CreateMap<Workout, GetWorkoutByUserIdDTO>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
                .ForMember(dest => dest.Exercises, opt => opt.MapFrom(src => src.WorkoutExercises.Count));


        }
    }
}
