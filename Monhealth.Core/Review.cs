﻿using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Review : TimeEntity
    {
        [Key]
        public Guid ReviewId { get; set; }
        public Guid UserId { get; set; }
        public Guid ConsultantId { get; set; }
        public Guid BookingId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;

        [ForeignKey(nameof(BookingId))]
        public Booking Booking { get; set; }
        [ForeignKey(nameof(ConsultantId))]
        public Consultant Consultant { get; set; }
    }
}
