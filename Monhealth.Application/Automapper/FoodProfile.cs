using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Monhealth.Application.Features.Food.Queries.GetAllFoods;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class FoodProfile : Profile
    {
        public FoodProfile()
        {
            CreateMap<Food, FoodDTO>()
   .ForMember(dest => dest.CategoryName,
               opt => opt.MapFrom(src => src.FoodCategories.Select(fc => fc.Category.CategoryName).ToList()));
    
        }
    }
}