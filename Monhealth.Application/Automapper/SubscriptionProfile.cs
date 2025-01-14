using AutoMapper;
using Monhealth.Application.Features.Subscription.Queries.GetAll;
using Monhealth.Application.Features.Subscription.Queries.GetByUser;
using Monhealth.Application.Features.Subscription.Queries.GetDetail;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class SubscriptionProfile : Profile
    {
        public SubscriptionProfile()
        {
            CreateMap<SubscriptionDTO, Subscription>().ReverseMap();
            CreateMap<SubscriptionDetailDTO, Subscription>().ReverseMap();
            CreateMap<SubscriptionByUserDTO, Subscription>().ReverseMap();
        }
    }
}