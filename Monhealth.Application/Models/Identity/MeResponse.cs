﻿namespace Monhealth.Application.Models.Identity
{
    public class MeResponse
    {
        public Guid UserId { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
    }
}
