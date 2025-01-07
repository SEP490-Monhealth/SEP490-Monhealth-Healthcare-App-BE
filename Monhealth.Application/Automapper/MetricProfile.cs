using AutoMapper;
using Monhealth.Application.Features.Category.Queries.GetAllCategories;
using Monhealth.Application.Features.Category.Queries.GetCategoryDetail;
using Monhealth.Application.Features.Metric.Commands.CreateMetric;
using Monhealth.Application.Features.Metric.Commands.UpdateMetric;
using Monhealth.Application.Features.Metric.Queries.GetAllMetric;
using Monhealth.Application.Features.Metric.Queries.GetMetricByUserId;
using Monhealth.Application.Features.Metric.Queries.GetMetricDetail;
using Monhealth.Application.Features.Nutrition.Queries.GetAllNutrition;
using Monhealth.Application.Features.Nutrition.Queries.GetNutritionDetail;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

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
            CreateMap<Metric, UpdateMetricDto>().ReverseMap();
            CreateMap<CreateMetricDto, Metric>()
            .ForMember(
                dest => dest.Gender,
                opt => opt.MapFrom(
                    (src, dest) => Enum.TryParse(src.Gender ?? string.Empty, out Gender gender) ? gender : Gender.Male)
                );
            CreateMap<UpdateMetricDto, Metric>()
            .ForMember(
                dest => dest.Gender,
                opt => opt.MapFrom(
                    (src, dest) => Enum.TryParse(src.Gender ?? string.Empty, out Gender gender) ? gender : Gender.Male)
                );
            CreateMap<Metric, GetMetricByUserIdDTO>().ReverseMap();
        }
    }
}
