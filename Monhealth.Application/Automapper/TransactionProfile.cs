using AutoMapper;
using Monhealth.Application.Features.Transaction.Commands.CreateTransaction;
using Monhealth.Application.Features.Transaction.Commands.UpdateTransaction;
using Monhealth.Application.Features.Transaction.Queries.GetAllTransactions;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionByConsultantId;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionById;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            CreateMap<Transaction, GetAllTransactionsDTO>()
                .ForMember(dest => dest.ConsultantId, opt => opt.MapFrom(src => src.Wallet.ConsultantId));
            CreateMap<Transaction, GetTransactionByIdDTO>()
                .ForMember(dest => dest.ConsultantId, opt => opt.MapFrom(src => src.Wallet.ConsultantId));
            CreateMap<Transaction, GetTransactionByConsultantIdDTO>()
                .ForMember(dest => dest.ConsultantId, opt => opt.MapFrom(src => src.Wallet.ConsultantId));

            CreateMap<Transaction, CreateTransactionDTO>().ReverseMap();
            CreateMap<Transaction, UpdateTransactionDTO>().ReverseMap();
        }
    }
}
