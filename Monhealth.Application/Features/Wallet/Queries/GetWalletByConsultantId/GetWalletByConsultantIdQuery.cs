using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Wallet.Queries.GetWalletByConsultantId
{
    public class GetWalletByConsultantIdQuery : IRequest<GetWalletByConsultantIdDTO>
    {
        public Guid ConsultantId { get; set; }
    }
}
