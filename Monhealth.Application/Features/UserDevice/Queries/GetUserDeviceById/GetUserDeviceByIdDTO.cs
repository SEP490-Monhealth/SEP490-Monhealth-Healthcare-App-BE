﻿using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.UserDevice.Queries.GetUserDeviceById
{
    public class GetUserDeviceByIdDTO : TimeEntity
    {
        public Guid UserDeviceId { get; set; }
        public Guid UserId { get; set; }
        public string ExpoPushToken { get; set; } = string.Empty;
    }
}
