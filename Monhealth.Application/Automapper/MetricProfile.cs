using AutoMapper;
using Monhealth.Application.Features.Category.Queries.GetAllCategories;
using Monhealth.Application.Features.Category.Queries.GetAllCategoriesByType;
using Monhealth.Application.Features.Category.Queries.GetCategoryDetail;
using Monhealth.Application.Features.Metric.Commands.CreateMetric;
using Monhealth.Application.Features.Metric.Commands.UpdateMetric;
using Monhealth.Application.Features.Metric.Queries.GetAllMetric;
using Monhealth.Application.Features.Metric.Queries.GetMetricByUserId;
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
            CreateMap<Metric, MetricDetailDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryDetailDTO>().ReverseMap();
            CreateMap<Category,CategoryByTypeDTO>().ReverseMap();
            CreateMap<Nutrition, NutritionDto>().ReverseMap();
            CreateMap<Nutrition, NutritionDetailDto>().ForMember(dest => dest.FoodId,
            opt => opt.MapFrom(src => src.FoodId))
            .ReverseMap();
            
            CreateMap<Nutrition, NutritionByFoodIdDto>().ReverseMap();
            CreateMap<Metric, UpdateMetricDTO>().ReverseMap();
            CreateMap<CreateMetricDTO, Metric>().ReverseMap();
            CreateMap<UpdateMetricDTO, Metric>().ReverseMap();            
            CreateMap<Metric, GetMetricByUserIdDTO>().ReverseMap();
        }
    }
}
