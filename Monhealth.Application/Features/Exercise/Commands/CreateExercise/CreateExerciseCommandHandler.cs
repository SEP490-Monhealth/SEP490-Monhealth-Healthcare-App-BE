﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Exercise.Commands.CreateExercise
{
    public class CreateExerciseCommandHandler : IRequestHandler<CreateExerciseCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IExerciseRepository _exerciseRepository;
        private readonly ICategoryRepository _categoryRepository;
        public CreateExerciseCommandHandler(IMapper mapper, IExerciseRepository exerciseRepository, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _exerciseRepository = exerciseRepository;
            _categoryRepository = categoryRepository;
        }
        public async Task<Unit> Handle(CreateExerciseCommand request, CancellationToken cancellationToken)
        {
            var checkExerciseExisted = await _exerciseRepository.GetExerciseByNameAsync(request.CreateExerciseDTO.ExerciseName);
            if(checkExerciseExisted)
            {
                throw new Exception("Bài tập đã tồn tại.");
            }
            var category = await _categoryRepository.GetCategoryByCategoryName(request.CreateExerciseDTO.Category);
            if(category == null)
            {
                throw new Exception("Danh mục không tồn tại");
            }
            var newExercise = _mapper.Map<Domain.Exercise>(request.CreateExerciseDTO);
            newExercise.ExerciseId = Guid.NewGuid();
            newExercise.CategoryId = category.CategoryId;
            newExercise.Status = false;
            newExercise.CreatedAt = DateTime.Now;
            newExercise.UpdatedAt = DateTime.Now;
            _exerciseRepository.Add(newExercise);
            await _exerciseRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}
