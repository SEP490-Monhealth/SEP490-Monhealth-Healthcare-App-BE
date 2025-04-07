using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserDevice.Commands.DeleteUserDevice
{
    public class DeleteUserDeviceCommandHandler(IUserDeviceRepository userDeviceRepository, IMapper mapper) : IRequestHandler<DeleteUserDeviceCommand, bool>
    {
        public async Task<bool> Handle(DeleteUserDeviceCommand request, CancellationToken cancellationToken)
        {
            var userDevice = await userDeviceRepository.GetByIdAsync(request.UserDeviceId);
            if (userDevice == null)
            {
                return false;
            }
            userDeviceRepository.Remove(userDevice);
            await userDeviceRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
