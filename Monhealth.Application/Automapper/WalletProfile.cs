using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Monhealth.Application.Features.Wallet.Queries.GetAllWallets;
using Monhealth.Application.Features.Wallet.Queries.GetWalletByConsultantId;
using Monhealth.Application.Features.Wallet.Queries.GetWalletById;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class WalletProfile : Profile
    {
        public WalletProfile()
        {
            CreateMap<Wallet, GetAllWalletsDTO>().ReverseMap();
            CreateMap<Wallet, GetWalletByIdDTO>().ReverseMap();
            CreateMap<Wallet, GetWalletByConsultantIdDTO>().ReverseMap();
        }
    }
}
