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
                 .ForMember(dest => dest.ConsultantId, opt => opt.MapFrom(src => src.Wallet.ConsultantId))
                 .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(src => src.Wallet.Consultant.AppUser.FullName))
                 .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(src => src.Wallet.Consultant.AppUser.Email))
                 .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(src => src.Wallet.Consultant.AppUser.PhoneNumber))
                 .ForPath(dest => dest.Consultant.AvatarUrl, opt => opt.MapFrom(src => src.Wallet.Consultant.AppUser.Avatar));

            CreateMap<Transaction, GetTransactionByIdDTO>()
                 .ForMember(dest => dest.ConsultantId, opt => opt.MapFrom(src => src.Wallet.ConsultantId))
                 .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(src => src.Wallet.Consultant.AppUser.FullName))
                 .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(src => src.Wallet.Consultant.AppUser.Email))
                 .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(src => src.Wallet.Consultant.AppUser.PhoneNumber))
                 .ForPath(dest => dest.Consultant.AvatarUrl, opt => opt.MapFrom(src => src.Wallet.Consultant.AppUser.Avatar));

            CreateMap<Transaction, GetTransactionByConsultantIdDTO>()
                 .ForMember(dest => dest.ConsultantId, opt => opt.MapFrom(src => src.Wallet.ConsultantId))
                 .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(src => src.Wallet.Consultant.AppUser.FullName))
                 .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(src => src.Wallet.Consultant.AppUser.Email))
                 .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(src => src.Wallet.Consultant.AppUser.PhoneNumber))
                 .ForPath(dest => dest.Consultant.AvatarUrl, opt => opt.MapFrom(src => src.Wallet.Consultant.AppUser.Avatar));

            CreateMap<Transaction, CreateTransactionDTO>().ReverseMap();
            CreateMap<Transaction, UpdateTransactionDTO>().ReverseMap();
        }
    }
}
