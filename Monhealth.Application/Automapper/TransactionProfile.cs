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
            CreateMap<Transaction, GetAllTransactionsDTO>().ReverseMap();
            CreateMap<Transaction, GetTransactionByIdDTO>().ReverseMap();
            CreateMap<Transaction, GetTransactionByConsultantIdDTO>().ReverseMap();

            CreateMap<Transaction, CreateTransactionDTO>().ReverseMap();
            CreateMap<Transaction, UpdateTransactionDTO>().ReverseMap();
        }
    }
}
