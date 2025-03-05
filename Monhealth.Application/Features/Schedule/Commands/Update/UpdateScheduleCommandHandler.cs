using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Schedule.Commands.Update
{
    public class UpdateScheduleCommandHandler : IRequestHandler<UpdateScheduleCommand, bool>
    {
        private readonly IScheduleRepository _scheduleRepository;

        public UpdateScheduleCommandHandler(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        public async Task<bool> Handle(UpdateScheduleCommand request, CancellationToken cancellationToken)
        {
            //var schedule = await _scheduleRepository.GetByIdAsync(request.ScheduleId);
            //if (schedule == null) throw new BadRequestException("Không tìm thấy lịch");
            //// Chỉ cập nhật nếu có thay đổi
            //if (schedule.Date != request.Request.Date)
            //{
            //    schedule.Date = request.Request.Date;
            //}

            //if (schedule.Time != request.Request.Time)
            //{
            //    schedule.Time = request.Request.Time;
            //}
            //if (schedule.ConsultantId != request.Request.ConsultantId)
            //{
            //    schedule.ConsultantId = request.Request.ConsultantId;
            //}
            await _scheduleRepository.SaveChangeAsync();
            return true;
        }
    }
}