namespace Allup.Application.UI.Services.Asbtarctions;

public interface ILayoutService
{
    Task<List<CategoryGetViewModel>> GetCategoriesAsync();
}
