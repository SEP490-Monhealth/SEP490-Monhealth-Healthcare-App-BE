﻿using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Schedule : BaseEntity
    {
        [Key]
        public Guid ScheduleId { get; set; } // PK 
        public Guid ConsultantId { get; set; } // FK 
        public DateOnly? Date { get; set; } // 
        public TimeOnly Time { get; set; } // 
        public string Status { get; set; } = string.Empty;
        [ForeignKey(nameof(ConsultantId))]
        public AppUser User { get; set; }
    }
}
