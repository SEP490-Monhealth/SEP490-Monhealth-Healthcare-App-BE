using AutoMapper;
using Monhealth.Application.Automapper.CustomFoodMapper.CustomResolver;
using Monhealth.Application.Features.Food.Queries.GetAllFoods;
using Monhealth.Application.Features.Food.Queries.GetAllFoodsByFoodType;
using Monhealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Automapper.CustomFoodMapper.CustomMapper
{
    public class GetAllFoodProfile : Profile
    {
        public GetAllFoodProfile()
        {
            CreateMap<Food, FoodDetailByFoodTypeDTO>()
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.CategoryName))
            .ForMember(dest => dest.Portion, opt => opt.MapFrom(src => src.FoodPortions.Select(fp => fp.Portion).FirstOrDefault()))
            .ForMember(dest => dest.Nutrition, opt => opt.MapFrom<GetFoodByFoodTypeValueResolver>());

            CreateMap<Portion, GetPortionForGetTypeFoodDTO>()
                .ForMember(dest => dest.PortionSize, opt => opt.MapFrom(src => src.PortionSize))
                .ForMember(dest => dest.PortionWeight, opt => opt.MapFrom(src => src.PortionWeight))
                .ForMember(dest => dest.MeasurementUnit, opt => opt.MapFrom(src => src.MeasurementUnit));
        }
    }
}
