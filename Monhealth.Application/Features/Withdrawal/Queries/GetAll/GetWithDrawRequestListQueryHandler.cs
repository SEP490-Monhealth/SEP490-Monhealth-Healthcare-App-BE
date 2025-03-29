using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;
using Monhealth.Domain;

namespace Monhealth.Application
{
    public class GetWithDrawRequestListQueryHandler(IWithdrawalRepository withdrawalRepository,
    IConsultantRepository consultantRepository)
    : IRequestHandler<GetWithdrawalRequestListQuery, PageResult<GetWithdrawalRequestDTO>>
    {
        public async Task<PageResult<GetWithdrawalRequestDTO>> Handle(GetWithdrawalRequestListQuery request, CancellationToken cancellationToken)
        {
            var queries = await withdrawalRepository.GetAllWithdrawalRequestAsync(request.Page, request.Limit, request.Status);
            var withdDrawList = new List<GetWithdrawalRequestDTO>();
            foreach (var wd in queries.Items)
            {
                var consultant = await consultantRepository.GetConsultantById(wd.ConsultantId);
                var withDrawDTO = new GetWithdrawalRequestDTO
                {
                    WithdrawalRequestId = wd.WithdrawalRequestId,
                    ConsultantId = wd.ConsultantId,
                    Description = wd.Description,
                    Amount = wd.Amount,
                    Status = wd.Status,
                    CreatedAt = wd.CreatedAt,
                    UpdatedAt = wd.UpdatedAt
                };
                var consultantDTO = new ConsultantDTO
                {
                    AvatarUrl = consultant.AppUser.Avatar,
                    Email = consultant.AppUser.Email,
                    FullName = consultant.AppUser.FullName,
                    PhoneNumber = consultant.AppUser.PhoneNumber
                };
                withDrawDTO.Consultant = consultantDTO;
                withdDrawList.Add(withDrawDTO);

            }
            return new PageResult<GetWithdrawalRequestDTO>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(queries.TotalCount / (double)request.Limit),
                TotalItems = queries.TotalCount,
                Items = withdDrawList
            };
        }
    }
}