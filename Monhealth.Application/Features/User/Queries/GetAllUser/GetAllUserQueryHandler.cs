using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Features.User.Queries.GetAllUser
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, PageResult<UserDto>>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly UserManager<AppUser> _userManager;
        public GetAllUserQueryHandler(IMapper mapper,
IUserRepository userRepository,
UserManager<AppUser> userManager)
        {

            _mapper = mapper;
            _userRepository = userRepository;
            _userManager = userManager;
        }

        public async Task<PageResult<UserDto>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {

            var paginatedUser = await _userRepository.GetAllUserAsync(request.Page, request.Limit, request.Search, request.Role, request.Sort, request.Order, request.Status);
            var userList = paginatedUser.Items.ToList();
            var userDtoList = _mapper.Map<List<UserDto>>(userList);
            //add Role
            for (int i = 0; i < userList.Count(); i++)
            {
                var roles = await _userManager.GetRolesAsync(userList[i]);
                userDtoList[i].Role = roles.FirstOrDefault();
            }
            return new PageResult<UserDto>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(paginatedUser.TotalCount / (double)request.Limit),
                TotalItems = paginatedUser.TotalCount,
                Items = userDtoList
            };

        }

    }
}
