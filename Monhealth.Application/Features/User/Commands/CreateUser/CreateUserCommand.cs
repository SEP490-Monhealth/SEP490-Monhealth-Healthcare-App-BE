﻿using MediatR;

namespace Monhealth.Application.Features.User.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<Unit>
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AvatarUrl { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }

    }
}
