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
            CreateMap<ConsultantBank, GetAllConsultantBanksDTO>().ReverseMap();
            CreateMap<ConsultantBank, GetConsultantBankByIdDTO>().ReverseMap();
            CreateMap<ConsultantBank, GetConsultantBankByConsultantIdDTO>().ReverseMap();

            CreateMap<ConsultantBank, CreateConsultantBankDTO>().ReverseMap();
            CreateMap<ConsultantBank, UpdateConsultantBankDTO>().ReverseMap();
        }
    }
}
