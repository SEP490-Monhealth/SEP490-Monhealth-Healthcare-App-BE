﻿using Monhealth.Domain.Common;
using Monhealth.Domain.CommonKey;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Consultant : TimeEntity, ISender
    {
        [Key]
        public Guid Id { get; set; }
        //public Guid ConsultantId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ExpertiseId { get; set; }
        public string Bio { get; set; } = string.Empty;
        public int Views { get; set; }
        public int Experience { get; set; }
        public int BookingCount { get; set; }
        public double RatingCount { get; set; }
        public double AverageRating { get; set; }
        public bool IsVerified { get; set; } = false;
        public bool Status { get; set; } = false;

        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        [ForeignKey(nameof(ExpertiseId))]
        public Expertise? Expertise { get; set; }
        public Wallet? Wallet { get; set; }
        public ICollection<Chat> Chats { get; set; } = [];
        public ICollection<WithdrawalRequest> WithdrawalRequests { get; set; } = [];
        public ICollection<ConsultantBank> ConsultantBanks { get; set; } = [];
        public ICollection<Schedule> Schedules { get; set; } = [];
    }
}
