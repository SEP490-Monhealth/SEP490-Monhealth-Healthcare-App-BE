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
                .ForPath(dest => dest.Bank.ShortName, opt => opt.MapFrom(src => src.Bank.ShortName))
                .ForPath(dest => dest.Bank.LogoUrl, opt => opt.MapFrom(src => src.Bank.LogoUrl))
                .ForPath(dest => dest.Bank.BankName, opt => opt.MapFrom(src => src.Bank.BankName))
                ;
            CreateMap<ConsultantBank, GetConsultantBankByIdDTO>()
                .ForPath(dest => dest.Bank.ShortName, opt => opt.MapFrom(src => src.Bank.ShortName))
                .ForPath(dest => dest.Bank.LogoUrl, opt => opt.MapFrom(src => src.Bank.LogoUrl))
                .ForPath(dest => dest.Bank.BankName, opt => opt.MapFrom(src => src.Bank.BankName))
                ;
            CreateMap<ConsultantBank, GetConsultantBankByConsultantIdDTO>()
                .ForPath(dest => dest.Bank.ShortName, opt => opt.MapFrom(src => src.Bank.ShortName))
                .ForPath(dest => dest.Bank.LogoUrl, opt => opt.MapFrom(src => src.Bank.LogoUrl))
                .ForPath(dest => dest.Bank.BankName, opt => opt.MapFrom(src => src.Bank.BankName))
                ;

            CreateMap<ConsultantBank, CreateConsultantBankDTO>().ReverseMap();
            CreateMap<ConsultantBank, UpdateConsultantBankDTO>().ReverseMap();
        }
    }
}
