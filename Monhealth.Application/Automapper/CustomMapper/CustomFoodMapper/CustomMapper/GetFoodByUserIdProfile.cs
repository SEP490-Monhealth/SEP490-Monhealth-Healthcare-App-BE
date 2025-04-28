using AutoMapper;
using Monhealth.Application.Automapper.CustomMapper.CustomFoodMapper.CustomResolver;
using Monhealth.Application.Features.Food.Queries.GetAllFoodsByUserId;
using Monhealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Automapper.CustomMapper.CustomFoodMapper.CustomMapper
{
    public class GetFoodByUserIdProfile : Profile
    {
        public GetFoodByUserIdProfile()
        {
            CreateMap<Food, FoodsByUserIdDTO>()
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.CategoryFoods.Select(cf => cf.Category.CategoryName)))
            .ForMember(dest => dest.Portion, opt => opt.MapFrom(src => src.FoodPortions.Select(fp => fp.Portion).FirstOrDefault()))
            .ForMember(dest => dest.Nutrition, opt => opt.MapFrom<GetAllFoodByUserIdCaloriesValueResolver>());

            CreateMap<Portion, GetPortionForGetFoodByUserDTO>()
                .ForMember(dest => dest.PortionSize, opt => opt.MapFrom(src => src.PortionSize))
                .ForMember(dest => dest.PortionWeight, opt => opt.MapFrom(src => src.PortionWeight))
                .ForMember(dest => dest.MeasurementUnit, opt => opt.MapFrom(src => src.MeasurementUnit));
        }
    }
}
