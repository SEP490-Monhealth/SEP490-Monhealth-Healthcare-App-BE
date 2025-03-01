using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Activity.Commands.CreateActivity
{
    public class CreateActivityCommandHandler : IRequestHandler<CreateActivityCommand, Unit>
    {
        private readonly IActivityRepository _activityRepository;
        private readonly IDailyActivityRepository _dailyActivityRepository;
        private readonly IMapper _mapper;
        public CreateActivityCommandHandler(IActivityRepository activityRepository, IDailyActivityRepository dailyActivityRepository, IMapper mapper)
        {
            _activityRepository = activityRepository;
            _dailyActivityRepository = dailyActivityRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
        {
            var newActivity = _mapper.Map<Domain.Activity>(request.CreateActivityDTO);
            newActivity.ActivityId = Guid.NewGuid();
            newActivity.Status = false;
            newActivity.CreatedAt = DateTime.Now;
            newActivity.UpdatedAt = DateTime.Now;
            _activityRepository.Add(newActivity);
            await _activityRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}
