using Allup.Application.UI.ViewModels;

namespace Allup.Application.UI.Services.Asbtarctions;

public interface IHomeService
{
    Task<HomeViewModel> GetHomeViewModel(int languageId = 1);
}
