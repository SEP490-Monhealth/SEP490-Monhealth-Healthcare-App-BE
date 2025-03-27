using AutoMapper;
using Monhealth.Application.Features.Bank.Commands.CreateBank;
using Monhealth.Application.Features.Bank.Commands.UpdateBank;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class BankProfile : Profile
    {
        public BankProfile()
        {
            CreateMap<Bank, CreateBankDTO>().ReverseMap();
            CreateMap<Bank, UpdateBankDTO>().ReverseMap();
        }
    }
}
