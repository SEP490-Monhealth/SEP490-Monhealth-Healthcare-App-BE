﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;

namespace Monhealth.Domain
{
    public class DailyActivity : BaseEntity
    {
        public Guid DailyActivityId { get; set; }
        public Guid GoalId { get; set; }
        public Guid UserId { get; set; }
        public int TotalDuration { get; set; }
        public float TotalCaloriesBurned { get; set; }

        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        [ForeignKey(nameof(GoalId))]
        public Goal Goal { get; set; }

    }
}
