using Allup.Application.ViewModels;

namespace Allup.Application.UI.ViewModels;

public class HomeViewModel
{
    public List<CategoryGetViewModel> Categories { get; set; } = [];
    public List<ProductGetViewModel> Products { get; set; } = [];
}

public class LayoutViewModel
{
    public List<CategoryGetViewModel>? Categories { get; set; }
}
