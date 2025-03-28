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
                .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.FullName))
                .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.Email))
                .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.PhoneNumber))
                .ForPath(dest => dest.Consultant.AvatarUrl, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.Avatar))
                .ForPath(dest => dest.CreatedAt, opt => opt.MapFrom(opt => opt.CreatedAt))
                .ForPath(dest => dest.UpdatedAt, opt => opt.MapFrom(opt => opt.UpdatedAt));


            CreateMap<Transaction, GetTransactionByIdDTO>()
            .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.FullName))
                .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.Email))
                .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.PhoneNumber))
                .ForPath(dest => dest.Consultant.AvatarUrl, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.Avatar))
                .ForPath(dest => dest.CreatedAt, opt => opt.MapFrom(opt => opt.CreatedAt))
                .ForPath(dest => dest.UpdatedAt, opt => opt.MapFrom(opt => opt.UpdatedAt));

            ;
            CreateMap<Transaction, GetTransactionByConsultantIdDTO>()
            .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.FullName))
                .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.Email))
                .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.PhoneNumber))
                .ForPath(dest => dest.Consultant.AvatarUrl, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.Avatar))
                .ForPath(dest => dest.CreatedAt, opt => opt.MapFrom(opt => opt.CreatedAt))
                .ForPath(dest => dest.UpdatedAt, opt => opt.MapFrom(opt => opt.UpdatedAt));



            CreateMap<Transaction, GetTransactionByIdDTO>()
               .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.FullName))
                .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.Email))
                .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.PhoneNumber))
                .ForPath(dest => dest.Consultant.AvatarUrl, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.Avatar))
                .ForPath(dest => dest.CreatedAt, opt => opt.MapFrom(opt => opt.CreatedAt))
                .ForPath(dest => dest.UpdatedAt, opt => opt.MapFrom(opt => opt.UpdatedAt));

            CreateMap<Transaction, CreateTransactionDTO>().ReverseMap();
            CreateMap<Transaction, UpdateTransactionDTO>().ReverseMap();
        }
    }
}
