﻿using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.ConsultantBank.Commands.UpdateConsultantBank
{
    public class UpdateConsultantBankDTO
    {
        [JsonPropertyName("number")]
        public string AccountNumber { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string AccountName { get; set; } = string.Empty;
    }
}
