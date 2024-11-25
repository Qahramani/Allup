using Allup.Application.Services.Abstractions;
using Allup.Application.UI.Services.Asbtarctions;
using Allup.Application.UI.ViewModels;

namespace Allup.Application.UI.Services.Implementations;

internal class HomeManager : IHomeService
{
    private readonly ICategoryService _categoryService;

    public HomeManager(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public async Task<HomeViewModel> GetHomeViewModel(Languages language = Languages.Azerbaijan)
    {
        var categories = await _categoryService.GetAllAsync(language);

        HomeViewModel vm = new ()
        {
            Categories = categories
        };

        return vm;
    }
}
