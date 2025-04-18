﻿using Monhealth.Core.Enum;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class UserSubscription : TimeEntity
    {
        [Key]
        public Guid UserSubscriptionId { get; set; }
        public Guid UserId { get; set; }
        public Guid SubscriptionId { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime ExpiresAt { get; set; }
        public int RemainingBookings { get; set; }
        public UserSubscriptionStatus Status { get; set; }

        [ForeignKey("UserId")]
        public AppUser User { get; set; }
        [ForeignKey("SubscriptionId")]
        public Subscription Subscription { get; set; }
        public ICollection<Transaction> Users { get; set; } = [];
    }
}