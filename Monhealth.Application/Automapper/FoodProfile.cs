using AutoMapper;
using Monhealth.Application.Features.Food.Queries.GetAllFoods;
using Monhealth.Application.Features.Food.Queries.GetAllFoodsByFoodType;
using Monhealth.Application.Features.Food.Queries.GetFoodById;
using Monhealth.Application.Features.Food.Queries.GetFoodsByCategory;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class FoodProfile : Profile
    {
        public FoodProfile()
        {
            CreateMap<Food, FoodDTO>()

       .ForMember(dest => dest.Category,
        opt => opt.MapFrom(src => src.Category.CategoryName)).ForMember(dest => dest.Portion,
        opt => opt.MapFrom(src => src.FoodPortions.Select(fp => new GetPortionForGetAllFoodDTO
        {
            PortionSize = fp.Portion.PortionSize,
            PortionWeight = fp.Portion.PortionWeight,
            MeasurementUnit = fp.Portion.MeasurementUnit
        }).FirstOrDefault()))


       .ForMember(dest => dest.Nutrition,
        opt => opt.MapFrom(src => src.Nutrition != null
            ? new GetNutritionForGetAllFoodDTO
            {
                Calories = src.Nutrition.Calories,

            }
            : null));

            CreateMap<Food, FoodDetailByFoodTypeDTO>()
            .ForMember(dest => dest.Category,
            opt => opt.MapFrom(src => src.Category.CategoryName));

            CreateMap<Food, GetFoodByIdDTO>()
            .ForMember(dest => dest.Category,
            opt => opt.MapFrom(src => src.Category.CategoryName))
            .ForMember(dest => dest.FoodName, opt => opt.MapFrom(src => src.FoodName))
            .ForMember(dest => dest.FoodDescription, opt => opt.MapFrom(src => src.FoodDescription));


            CreateMap<Food, GetFoodByCategoryDTO>().ReverseMap();
        }
    }
}