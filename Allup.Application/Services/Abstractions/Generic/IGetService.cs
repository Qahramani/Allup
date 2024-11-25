namespace Allup.Application.Services.Abstractions.Generic;

public interface IGetService<TGetViewModel>
    where TGetViewModel : IViewModel
{
    Task<TGetViewModel> GetAsync(int id);
    Task<List<TGetViewModel>> GetAllAsync();
}
