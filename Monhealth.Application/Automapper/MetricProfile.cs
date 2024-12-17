using AutoMapper;
using Monhealth.Application.Features.Category.Queries.GetAllCategories;
using Monhealth.Application.Features.Category.Queries.GetCategoryDetail;
using Monhealth.Application.Features.Metric.Queries.GetAllMetric;
using Monhealth.Application.Features.Metric.Queries.GetMetricDetail;
using Monhealth.Application.Features.Nutrition.Queries.GetAllNutrition;
using Monhealth.Application.Features.Nutrition.Queries.GetNutritionDetail;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class MetricProfile : Profile
    {
        public MetricProfile()
        {
            CreateMap<Metric, MetricDto>().ReverseMap();
            CreateMap<Metric, MetricDetailDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryDetailDto>().ReverseMap();
            CreateMap<Nutrition, NutritionDto>().ReverseMap();
            CreateMap<Nutrition, NutritionDetailDto>().ForMember(dest => dest.FoodId,
            opt => opt.MapFrom(src => src.FoodId))
            .ReverseMap();
            CreateMap<Nutrition, NutritionByFoodIdDto>().ReverseMap();
        }
    }
}
