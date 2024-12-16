using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Category.UpdateCategory
{
    public class UpdateCategoryHandler : IRequestHandler<UpdateCategoryCommand, bool>
    {
        private readonly ICategoryRepository _categoryRepository;

        public UpdateCategoryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<bool> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            if (category == null) return false;
            var isCategoryExist = await _categoryRepository
           .AnyAsync(c => c.CategoryName == request.CategoryName);

            if (isCategoryExist)
            {
                throw new Exception("CategoryName already exists.");
            }
            category.CategoryName = request.CategoryName;
            category.Description = request.Description;
            category.UpdatedAt = DateTime.UtcNow;
            _categoryRepository.Update(category);
            await _categoryRepository.SaveChangeAsync();
            return true;
        }
    }
}