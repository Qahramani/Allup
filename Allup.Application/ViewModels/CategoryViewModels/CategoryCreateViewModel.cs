using Microsoft.AspNetCore.Http;

namespace Allup.Application.ViewModels;

public class CategoryGetViewModel : IViewModel
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public string? Name{ get; set; }
    public string? ImagePath { get; set; }
    public List<CategoryGetViewModel> SubCategories { get; set; } = [];
}

public class CategoryCreateViewModel : IViewModel
{
    public IFormFile? ImageFile { get; set; }
    public int? ParentId { get; set; }

}

public class CategoryUpdateViewModel : IViewModel
{
    public int Id { get; set; }
    public IFormFile? ImageFile { get; set; }
    public string? ImagePath { get; set; }
    public int? ParentId { get; set; }

}