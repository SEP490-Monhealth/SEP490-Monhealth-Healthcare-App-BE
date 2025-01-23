using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Monhealth.Application.Features.Exercise.Commands.CreateExercise;
using Monhealth.Application.Features.Exercise.Commands.UpdateExercise;
using Monhealth.Application.Features.Exercise.Queries.GetAllExercises;
using Monhealth.Application.Features.Exercise.Queries.GetExerciseById;
using Monhealth.Application.Features.Exercise.Queries.GetExerciseByUserId;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class ExerciseProfile : Profile
    {
        public ExerciseProfile()
        {
            CreateMap<Exercise, GetAllExercisesDTO>()
            .ForMember(dest => dest.CategoryName , opt => opt.MapFrom(src => src.Category.CategoryName)).ReverseMap();

            CreateMap<Exercise, GetExerciseByIdDTO>()
            .ForMember(dest => dest.CategoryName , opt => opt.MapFrom(src => src.Category.CategoryName)).ReverseMap();

            CreateMap<Exercise, GetExerciseByUserIdDTO>()
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName)).ReverseMap();


            CreateMap<CreateExerciseDTO, Exercise>()
            .ForMember(dest => dest.CategoryId, opt => opt.Ignore()) // Bỏ qua ánh xạ mặc định cho CategoryId
            .ForMember(dest => dest.Category, opt => opt.Ignore()); // Bỏ qua ánh xạ Category (khóa ngoại)

            CreateMap<UpdateExerciseDTO, Exercise>()
            .ForMember(dest => dest.CategoryId, opt => opt.Ignore()) // Bỏ qua ánh xạ mặc định cho CategoryId
            .ForMember(dest => dest.Category, opt => opt.Ignore()); // Bỏ qua ánh xạ Category (khóa ngoại)
        }
    }
}
