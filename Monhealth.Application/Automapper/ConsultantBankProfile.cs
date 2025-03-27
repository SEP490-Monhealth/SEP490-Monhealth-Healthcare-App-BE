using AutoMapper;
using Monhealth.Application.Features.ConsultantBank.Commands.CreateConsultantBank;
using Monhealth.Application.Features.ConsultantBank.Commands.UpdateConsultantBank;
using Monhealth.Application.Features.ConsultantBank.Queries.GetAllConsultantBanks;
using Monhealth.Application.Features.ConsultantBank.Queries.GetConsultantBankByConsultantId;
using Monhealth.Application.Features.ConsultantBank.Queries.GetConsultantBankById;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class ConsultantBankProfile : Profile
    {
        public ConsultantBankProfile()
        {
            CreateMap<ConsultantBank, GetAllConsultantBanksDTO>()
                .ForMember(dest => dest.BankName, opt => opt.MapFrom(src => src.Bank.BankName));

            CreateMap<ConsultantBank, GetConsultantBankByIdDTO>()
            .ForMember(dest => dest.BankName, opt => opt.MapFrom(src => src.Bank.BankName));

            CreateMap<ConsultantBank, GetConsultantBankByConsultantIdDTO>()
                .ForMember(dest => dest.BankName, opt => opt.MapFrom(src => src.Bank.BankName));;

            CreateMap<ConsultantBank, CreateConsultantBankDTO>().ReverseMap();
            CreateMap<ConsultantBank, UpdateConsultantBankDTO>().ReverseMap();
        }
    }
}
