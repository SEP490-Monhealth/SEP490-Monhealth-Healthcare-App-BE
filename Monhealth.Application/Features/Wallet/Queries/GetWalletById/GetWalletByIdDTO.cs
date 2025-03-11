using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Wallet.Queries.GetWalletById
{
    public class GetWalletByIdDTO
    {
        public Guid ConsultantId { get; set; }
        public float Balance { get; set; }
        public bool Status { get; set; }
    }
}
