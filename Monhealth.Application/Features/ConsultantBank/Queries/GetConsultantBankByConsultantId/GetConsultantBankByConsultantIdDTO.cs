﻿using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.ConsultantBank.Queries.GetConsultantBankByConsultantId
{
    public class GetConsultantBankByConsultantIdDTO : TimeEntity
    {
        public Guid ConsultantBankId { get; set; }
        public Guid BankId { get; set; }
        public string AccountNumber { get; set; } = string.Empty;
        public string AccountName { get; set; } = string.Empty;
        public bool IsDefault { get; set; }
        public bool Status { get; set; }
    }
}
