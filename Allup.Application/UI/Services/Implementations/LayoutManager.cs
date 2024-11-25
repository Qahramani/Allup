
using Allup.Application.UI.ViewModels;

namespace Allup.Application.UI.Services.Implementations;

internal class LayoutManager : ILayoutService
{
    private readonly ICategoryService _categoryService;

    public LayoutManager(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public async Task<List<CategoryGetViewModel>> GetCategoriesAsync()
    {
        var categories = await _categoryService.GetAllAsync();

        return categories;
    }
}
