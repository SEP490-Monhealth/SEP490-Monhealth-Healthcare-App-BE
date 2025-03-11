using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Transaction.Commands.CreateTransaction
{
    public class CreateTransactionCommand : IRequest<Unit>
    {
        public CreateTransactionDTO CreateTransactionDTO { get; set; }
        public CreateTransactionCommand(CreateTransactionDTO createTransactionDTO)
        {
            CreateTransactionDTO = createTransactionDTO;
        }
    }
}
