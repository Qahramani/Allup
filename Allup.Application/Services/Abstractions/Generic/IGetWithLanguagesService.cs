namespace Allup.Application.Services.Abstractions.Generic;

public interface IGetWithLanguagesService<TGetViewModel>
    where TGetViewModel : IViewModel
{
    Task<TGetViewModel> GetAsync(int id, int languageId = 1);
    Task<List<TGetViewModel>> GetAllAsync(int languageId = 1);
}
