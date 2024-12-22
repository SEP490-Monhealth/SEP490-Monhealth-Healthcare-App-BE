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
             opt => opt.MapFrom(src => src.FoodCategories.Select(fc => fc.Category.CategoryName).ToList()));

            CreateMap<Food, FoodDetailByFoodTypeDTO>()
            .ForMember(dest => dest.Category,
            opt => opt.MapFrom(src => src.FoodCategories.Select(fc => fc.Category.CategoryName).ToList()));

            CreateMap<Food, GetFoodByIdDTO>()
            .ForMember(dest => dest.Category,
            opt => opt.MapFrom(src => src.FoodCategories.Select(fc => fc.Category.CategoryName).ToList()))
            .ForMember(dest => dest.FoodName, opt => opt.MapFrom(src => src.FoodName))
            .ForMember(dest => dest.FoodDescription, opt => opt.MapFrom(src => src.FoodDescription));


            CreateMap<Food, GetFoodByCategoryDTO>().ReverseMap();
        }
    }
}