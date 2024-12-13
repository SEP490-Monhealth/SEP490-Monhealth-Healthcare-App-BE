﻿using AutoMapper;
using Monhealth.Application.Features.Metric.Queries.GetAllMetric;
using Monhealth.Application.Features.Metric.Queries.GetMetricDetail;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class MetricProfile : Profile
    {
        public MetricProfile()
        {
            CreateMap<Metric, MetricDto>().ReverseMap();
            CreateMap<Metric, MetricDetailDto>().ReverseMap();
        }
    }
}
