using Allup.Application.Services.Abstractions;
using Allup.Application.UI.Services.Asbtarctions;
using Allup.Application.UI.ViewModels;

namespace Allup.Application.UI.Services.Implementations;

internal class HomeManager : IHomeService
{
    private readonly ICategoryService _categoryService;
    private readonly IProductService _productService;

    public HomeManager(ICategoryService categoryService, IProductService productService)
    {
        _categoryService = categoryService;
        _productService = productService;
    }

    public async Task<HomeViewModel> GetHomeViewModel(int languageId = 1)
    {
        var categories = await _categoryService.GetAllAsync(languageId);
        var products = await _productService.GetAllAsync(languageId);

        HomeViewModel vm = new ()
        {
            Categories = categories,
            Products = products
        };

        return vm;
    }
}
