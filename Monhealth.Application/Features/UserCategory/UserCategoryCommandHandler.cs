using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core;
using Monteith.Application.Contracts.Persistence;

namespace Monhealth.Application.Features
{
    public class UserCategoryCommandHandler : IRequestHandler<CreateUserCategoryRequest, Unit>
    {
        private readonly IUserCategoryRepository _userCategoryRepository;
        private readonly ICategoryRepository _categoryRepository;
        public UserCategoryCommandHandler(IUserCategoryRepository userCategoryRepository,
        ICategoryRepository categoryRepository)
        {
            _userCategoryRepository = userCategoryRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<Unit> Handle(CreateUserCategoryRequest request, CancellationToken cancellationToken)
        {
            var CategoryName = await _categoryRepository.GetCategoriesByList(request.Categories);
            if (CategoryName.Count() != request.Categories.Count()) return Unit.Value;
            _userCategoryRepository.AddRange(CategoryName.Select(c => new UserCategory(
            )
            {
                CategoryId = c.CategoryId,
                UserCategoryId = Guid.NewGuid(),
                UserId = request.UserId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            }));
            await _userCategoryRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}