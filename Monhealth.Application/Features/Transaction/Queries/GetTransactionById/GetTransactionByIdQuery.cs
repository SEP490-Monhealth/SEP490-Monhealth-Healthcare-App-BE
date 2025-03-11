using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionById
{
    public class GetTransactionByIdQuery : IRequest<GetTransactionByIdDTO>
    {
        public Guid TransactionId { get; set; }
    }
}
