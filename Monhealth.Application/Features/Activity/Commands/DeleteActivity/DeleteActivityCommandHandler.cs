using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Activity.Commands.DeleteActivity
{
    public class DeleteActivityCommandHandler(IActivityRepository activityRepository, IMapper mapper) : IRequestHandler<DeleteActivityCommand, bool>
    {
        public async Task<bool> Handle(DeleteActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await activityRepository.GetByIdAsync(request.ActivityId);
            if (activity == null)
            {
                return false;
            }
            activityRepository.Remove(activity);
            await activityRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
