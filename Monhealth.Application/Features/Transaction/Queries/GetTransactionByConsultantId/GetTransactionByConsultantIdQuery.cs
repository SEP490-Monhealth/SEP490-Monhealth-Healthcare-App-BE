using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionByConsultantId
{
    public class GetTransactionByConsultantIdQuery : IRequest<List<GetTransactionByConsultantIdDTO>>
    {
        public Guid ConsultantId { get; set; }
    }
}
