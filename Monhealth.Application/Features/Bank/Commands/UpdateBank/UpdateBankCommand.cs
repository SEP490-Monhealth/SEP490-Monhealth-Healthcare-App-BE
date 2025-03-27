using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Bank.Commands.UpdateBank
{
    public class UpdateBankCommand : IRequest<bool>
    {
        public Guid BankId { get; set; }
        public UpdateBankDTO UpdateBankDTO { get; set; }
        public UpdateBankCommand(Guid bankId, UpdateBankDTO updateBankDTO)
        {
            BankId = bankId;
            UpdateBankDTO = updateBankDTO;
        }
    }
}
