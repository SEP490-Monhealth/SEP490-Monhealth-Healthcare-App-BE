using AutoMapper;
using Monhealth.Application.Features.Transaction.Commands.CreateTransaction;
using Monhealth.Application.Features.Transaction.Queries.GetAllTransactions;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionByConsultantId;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionByCreatedBy;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionById;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            CreateMap<Transaction, GetAllTransactionsDTO>()
                 .ForPath(
                        dest => dest.Consultant.FullName,
                        opt => opt.MapFrom(src =>
                        src.Consultant != null
                          && src.Consultant.AppUser != null
                            ? src.Consultant.AppUser.FullName
                         : string.Empty))

                 .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(src =>
                        src.Consultant != null
                          && src.Consultant.AppUser != null
                            ? src.Consultant.AppUser.Email
                         : string.Empty))
                  .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(src =>
                        src.Consultant != null
                          && src.Consultant.AppUser != null
                            ? src.Consultant.AppUser.PhoneNumber
                         : string.Empty))
                   .ForPath(dest => dest.Consultant.AvatarUrl, opt => opt.MapFrom(src =>
                        src.Consultant != null
                          && src.Consultant.AppUser != null
                            ? src.Consultant.AppUser.Avatar
                         : string.Empty))

                 .ForPath(dest => dest.Member.FullName, opt => opt.MapFrom(src => src.User != null ? src.User.FullName : string.Empty))
                 .ForPath(dest => dest.Member.Email, opt => opt.MapFrom(src => src.User != null ? src.User.Email : string.Empty))
                 .ForPath(dest => dest.Member.PhoneNumber, opt => opt.MapFrom(src => src.User != null ? src.User.PhoneNumber : string.Empty))
                 .ForPath(dest => dest.Member.AvatarUrl, opt => opt.MapFrom(src => src.User != null ? src.User.Avatar : string.Empty))
                 ;

            CreateMap<Transaction, GetTransactionByIdDTO>()
                .ForPath(
                        dest => dest.Consultant.FullName,
                        opt => opt.MapFrom(src =>
                        src.Consultant != null
                          && src.Consultant.AppUser != null
                            ? src.Consultant.AppUser.FullName
                         : string.Empty))

                 .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(src =>
                        src.Consultant != null
                          && src.Consultant.AppUser != null
                            ? src.Consultant.AppUser.Email
                         : string.Empty))
                  .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(src =>
                        src.Consultant != null
                          && src.Consultant.AppUser != null
                            ? src.Consultant.AppUser.PhoneNumber
                         : string.Empty))
                   .ForPath(dest => dest.Consultant.AvatarUrl, opt => opt.MapFrom(src =>
                        src.Consultant != null
                          && src.Consultant.AppUser != null
                            ? src.Consultant.AppUser.Avatar
                         : string.Empty))

                 .ForPath(dest => dest.Member.FullName, opt => opt.MapFrom(src => src.User != null ? src.User.FullName : string.Empty))
                 .ForPath(dest => dest.Member.Email, opt => opt.MapFrom(src => src.User != null ? src.User.Email : string.Empty))
                 .ForPath(dest => dest.Member.PhoneNumber, opt => opt.MapFrom(src => src.User != null ? src.User.PhoneNumber : string.Empty))
                 .ForPath(dest => dest.Member.AvatarUrl, opt => opt.MapFrom(src => src.User != null ? src.User.Avatar : string.Empty))
                 ;

            CreateMap<Transaction, GetTransactionByConsultantIdDTO>()
                  .ForPath(
                        dest => dest.Consultant.FullName,
                        opt => opt.MapFrom(src =>
                        src.Consultant != null
                          && src.Consultant.AppUser != null
                            ? src.Consultant.AppUser.FullName
                         : string.Empty))

                 .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(src =>
                        src.Consultant != null
                          && src.Consultant.AppUser != null
                            ? src.Consultant.AppUser.Email
                         : string.Empty))
                  .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(src =>
                        src.Consultant != null
                          && src.Consultant.AppUser != null
                            ? src.Consultant.AppUser.PhoneNumber
                         : string.Empty))
                   .ForPath(dest => dest.Consultant.AvatarUrl, opt => opt.MapFrom(src =>
                        src.Consultant != null
                          && src.Consultant.AppUser != null
                            ? src.Consultant.AppUser.Avatar
                         : string.Empty));

            CreateMap<Transaction, GetTransactionByCreatedByDTO>()
                .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(src => src.Wallet.Consultant.AppUser.FullName))
                .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(src => src.Wallet.Consultant.AppUser.Email))
                .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(src => src.Wallet.Consultant.AppUser.PhoneNumber))
                .ForPath(dest => dest.Consultant.AvatarUrl, opt => opt.MapFrom(src => src.Wallet.Consultant.AppUser.Avatar));
            CreateMap<Transaction, CreateTransactionDTO>().ReverseMap();
        }
    }
}
