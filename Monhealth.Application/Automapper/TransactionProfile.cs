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
                .ForPath(dest => dest.Consultant.AvatarUrl, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.Avatar));


            CreateMap<Transaction, GetTransactionByIdDTO>()
            .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.FullName))
                .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.Email))
                .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.PhoneNumber))
                .ForPath(dest => dest.Consultant.AvatarUrl, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.Avatar));

            ;
            CreateMap<Transaction, GetTransactionByConsultantIdDTO>()
            .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.FullName))
                .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.Email))
                .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.PhoneNumber))
                .ForPath(dest => dest.Consultant.AvatarUrl, opt => opt.MapFrom(opt => opt.Wallet.Consultant.AppUser.Avatar));
                ;
            .ForMember(dest => dest.UpdatedAt , ost => ost.MapFrom(ost 
            => ost.UpdatedAt))
            .ForMember(dest => dest.CreatedAt , ost => ost.MapFrom(ost 
            => ost.CreatedAt));
            CreateMap<Transaction, GetTransactionByIdDTO>().ReverseMap();
            CreateMap<Transaction, GetTransactionByConsultantIdDTO>().ReverseMap();

            CreateMap<Transaction, CreateTransactionDTO>().ReverseMap();
            CreateMap<Transaction, UpdateTransactionDTO>().ReverseMap();
        }
    }
}
