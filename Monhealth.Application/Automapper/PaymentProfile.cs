using AutoMapper;
using Monhealth.Application.Features.Payment.Queries.GetBySubcriptionId;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class PaymentProfile : Profile
    {
        public PaymentProfile()
        {
            CreateMap<Payment, GetPaymentBySubscriptionIdDTO>().ReverseMap();
        }
    }
}
