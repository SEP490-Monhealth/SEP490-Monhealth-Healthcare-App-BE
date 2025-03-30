using AutoMapper;
using Monhealth.Application.Features.Payment.Queries.GetBySubcriptionId;
using Monhealth.Application.Features.Payment.Queries.GetByUserId;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class PaymentProfile : Profile
    {
        public PaymentProfile()
        {
            CreateMap<Payment, GetPaymentByUserIdDTO>().ReverseMap();
            CreateMap<Payment, GetpaymentBySubcriptionIdDTO>().ReverseMap();
        }
    }
}
