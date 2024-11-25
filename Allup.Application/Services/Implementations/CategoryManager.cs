using Allup.Application.Services.Abstractions;
using Allup.Persistence.Repositories.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace Allup.Application.Services.Implementations;

internal class CategoryManager : ICategoryService
{
    private readonly ICategoryRepository _repository;
    private readonly IMapper _mapper;

    public CategoryManager(ICategoryRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public Task<int> CreateAsync(CategoryCreateViewModel model, ModelStateDictionary ModelState)
    {
        throw new NotImplementedException();
    }

    public Task DeleteASync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<CategoryGetViewModel>> GetAllAsync(Languages language = Languages.Azerbaijan)
    {
        var categories = await _repository.GetAll(x => x.Include(x => x.CategoryDetails.Where(x => x.LanguageId == (int)language)).Include(x => x.SubCategories)).OrderByDescending(x =>x.SubCategories.Count).ToListAsync();

        var viewModels = _mapper.Map<List<CategoryGetViewModel>>(categories);

        return viewModels;
    }

    public Task<CategoryGetViewModel> GetAsync(int id, Languages languages = Languages.Azerbaijan)
    {
        throw new NotImplementedException();
    }

    public Task<CategoryUpdateViewModel> GetUpdateViewModelAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateAsync(CategoryUpdateViewModel model, ModelStateDictionary ModelState)
    {
        throw new NotImplementedException();
    }
}
