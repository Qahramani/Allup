using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Allup.Application.Services.Abstractions.Generic;

public interface IModifyService<ICreateViewModel, IUpdateViewModel>
    where ICreateViewModel : IViewModel
    where IUpdateViewModel : IViewModel
{
    Task<int> CreateAsync(ICreateViewModel model, ModelStateDictionary ModelState);
    Task<int> UpdateAsync(IUpdateViewModel model, ModelStateDictionary ModelState);
    Task<IUpdateViewModel> GetUpdateViewModelAsync(int id);
    Task DeleteASync(int id);
}
