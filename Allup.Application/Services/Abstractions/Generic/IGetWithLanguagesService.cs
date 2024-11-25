namespace Allup.Application.Services.Abstractions.Generic;

public interface IGetWithLanguagesService<TGetViewModel>
    where TGetViewModel : IViewModel
{
    Task<TGetViewModel> GetAsync(int id, Languages language = Languages.Azerbaijan);
    Task<List<TGetViewModel>> GetAllAsync(Languages language = Languages.Azerbaijan);
}
