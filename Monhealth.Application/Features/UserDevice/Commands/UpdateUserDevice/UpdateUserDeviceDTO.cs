﻿namespace Monhealth.Application.Features.UserDevice.Commands.UpdateUserDevice
{
    public class UpdateUserDeviceDTO
    {
        public Guid UserId { get; set; }
        public string ExpoPushToken { get; set; } = string.Empty;

    }
}
