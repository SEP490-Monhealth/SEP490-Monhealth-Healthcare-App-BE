using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Bank.Commands.CreateBank
{
    public class CreateBankDTO
    {
        public string BankCode { get; set; } = string.Empty;
        public string BankName { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
    }
}
