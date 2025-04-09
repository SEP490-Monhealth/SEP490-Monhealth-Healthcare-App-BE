using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserDevice.Commands.DeleteUserDevice
{
    public class DeleteDeviceCommandHandler(IDeviceRepository deviceRepository, IMapper mapper) : IRequestHandler<DeleteDeviceCommand, bool>
    {
        public async Task<bool> Handle(DeleteDeviceCommand request, CancellationToken cancellationToken)
        {
            var userDevice = await deviceRepository.GetByIdAsync(request.DeviceId);
            if (userDevice == null)
            {
                return false;
            }
            deviceRepository.Remove(userDevice);
            await deviceRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
