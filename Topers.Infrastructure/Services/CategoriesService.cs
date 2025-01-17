using AutoMapper;
using Topers.Core.Abstractions;
using Topers.Core.Dtos;
using Topers.Core.Models;

namespace Topers.Infrastructure.Services;

public class CategoriesService : ICategoriesService
{
    private readonly ICategoriesRepository _categoriesRepository;
    private readonly IMapper _mapper;

    public CategoriesService(ICategoriesRepository categoriesRepository, IMapper mapper)
    {
        _categoriesRepository = categoriesRepository;
        _mapper = mapper;
    }

    public async Task<CategoryResponseDto> CreateCategoryAsync(Category category, CancellationToken cancellationToken = default)
    {
        var newCategoryIdentifier = await _categoriesRepository.CreateAsync(category);

        var newCategory = new CategoryResponseDto
        (
            newCategoryIdentifier,
            category.Name,
            category.Description
        );

        return newCategory;
    }

    public async Task<Guid> DeleteCategoryAsync(Guid categoryId, CancellationToken cancellationToken = default)
    {
        return await _categoriesRepository.DeleteAsync(categoryId);
    }

    public async Task<List<CategoryResponseDto>> GetAllCategoriesAsync(CancellationToken cancellationToken = default)
    {
        return _mapper.Map<List<CategoryResponseDto>>(await _categoriesRepository.GetAllAsync());
    }

    public async Task<CategoryResponseDto> GetCategoryByIdAsync(Guid categoryId, CancellationToken cancellationToken = default)
    {
        return _mapper.Map<CategoryResponseDto>(await _categoriesRepository.GetByIdAsync(categoryId));
    }

    public async Task<List<GoodResponseDto>> GetGoodsByCategoryIdAsync(Guid categoryId, CancellationToken cancellationToken = default)
    {
        return _mapper.Map<List<GoodResponseDto>>(await _categoriesRepository.GetGoodsByIdAsync(categoryId));
    }

    public async Task<Guid> UpdateCategoryAsync(Category category, CancellationToken cancellationToken = default)
    {
        return await _categoriesRepository.UpdateAsync(category);
    }
}