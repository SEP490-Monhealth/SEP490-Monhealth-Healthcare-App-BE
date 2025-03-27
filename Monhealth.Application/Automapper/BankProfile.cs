using AutoMapper;
using Monhealth.Application.Features.Bank.Commands.CreateBank;
using Monhealth.Application.Features.Bank.Commands.UpdateBank;
using Monhealth.Application.Features.Bank.Queries.GetAllBanks;
using Monhealth.Application.Features.Bank.Queries.GetBankById;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class BankProfile : Profile
    {
        public BankProfile()
        {
            CreateMap<Bank, GetAllBanksDTO>().ReverseMap();
            CreateMap<Bank, GetBankByIdDTO>().ReverseMap();

            CreateMap<Bank, CreateBankDTO>().ReverseMap();
            CreateMap<Bank, UpdateBankDTO>().ReverseMap();
        }
    }
}
