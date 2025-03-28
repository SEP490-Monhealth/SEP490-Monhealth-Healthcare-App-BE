﻿using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.ConsultantBank.Queries.GetAllConsultantBanks
{
    public class GetAllConsultantBanksDTO : TimeEntity
    {
        public Guid ConsultantBankId { get; set; }
        public string BankName { get; set; } = string.Empty;
        public Guid ConsultantId { get; set; }
        public Guid BankId { get; set; }
        public BankInfoDTO Bank { get; set; } = new BankInfoDTO();
        [JsonPropertyName("number")]
        public string AccountNumber { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string AccountName { get; set; } = string.Empty;
        public bool IsDefault { get; set; }
        public bool Status { get; set; }
    }
    public class BankInfoDTO
    {
        public string ShortName { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
    }
}
