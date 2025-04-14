﻿using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Monhealth.Domain
{
    public class Transaction : BaseEntity
    {
        [Key]
        public Guid TransactionId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? WalletId { get; set; }
        public Guid? BookingId { get; set; }
        public Guid? WithdrawalRequestId { get; set; }
        public Guid? SubscriptionId { get; set; }
        [JsonPropertyName("subscription")]
        public string SubscriptionName { get; set; } = string.Empty;
        public Guid? UserSubscriptionId { get; set; }
        public TransactionType TransactionType { get; set; }
        public string? Description { get; set; }
        public float? Amount { get; set; }
        public long? OrderCode { get; set; }
        public StatusTransaction? Status { get; set; }

        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; }

        [ForeignKey(nameof(BookingId))]
        public Booking? Booking { get; set; }

        [ForeignKey(nameof(WithdrawalRequestId))]
        public WithdrawalRequest? WithdrawalRequest { get; set; }

        [ForeignKey(nameof(WalletId))]
        public Wallet Wallet { get; set; } = null!;

        [ForeignKey(nameof(UserSubscriptionId))]
        public UserSubscription? UserSubscription { get; set; }


    }
}
