using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Monhealth.Application.Features.Transaction.Commands.CreateTransaction;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            CreateMap<Transaction, CreateTransactionDTO>().ReverseMap();
        }
    }
}
