﻿using System.Text.Json.Serialization;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionByConsultantId
{
    public class GetTransactionByConsultantIdDTO
    {
        public Guid TransactionId { get; set; }
        public Guid WalletId { get; set; }
        public Guid ConsultantId { get; set; }
        public Guid BookingId { get; set; }
        [JsonPropertyName("type")]
        public TransactionType TransactionType { get; set; }
        public string? Description { get; set; }
        public float? Amount { get; set; }
        public StatusTransaction? Status { get; set; }
    }
}
