using Allup.Application.Services.Abstractions.Generic;
using Allup.Application.ViewModels;

namespace Allup.Application.Services.Abstractions;

public interface ICategoryService : IModifyService<CategoryCreateViewModel, CategoryUpdateViewModel>,IGetWithLanguagesService<CategoryGetViewModel>
{
}
