using Monhealth.Domain;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Exercise.Commands.UpdateExercise
{
    public class UpdateExerciseCommandHandler : IRequestHandler<UpdateExerciseCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IExerciseRepository _exerciseRepository;
        private readonly ICategoryRepository _categoryRepository;
        public UpdateExerciseCommandHandler(IMapper mapper, IExerciseRepository exerciseRepository, ICategoryRepository categoryRepository)
        {
            _exerciseRepository = exerciseRepository;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }
        public async Task<bool> Handle(UpdateExerciseCommand request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetCategoryByCategoryName(request.UpdateExerciseDTO.Category);
            if (category == null)
            {
                throw new Exception("Danh mục không tồn tại");
            }
            var checkExerciseExisted = await _exerciseRepository.GetExerciseByNameAsync(request.UpdateExerciseDTO.ExerciseName);
            if (checkExerciseExisted != null)
            {
                throw new Exception("Bài tập đã tồn tại.");
            }
            var existingExercise = await _exerciseRepository.GetByIdAsync(request.ExerciseId);
            if (existingExercise == null)
            {
                throw new Exception("Bài tập không tồn tại.");
            }
            var updateExercise = _mapper.Map(request.UpdateExerciseDTO, existingExercise);
            updateExercise.CategoryId = category.CategoryId;
            updateExercise.UpdatedAt = DateTime.Now;
            _exerciseRepository.Update(updateExercise);
            await _exerciseRepository.SaveChangeAsync();
            return true;
        }
    }
}
