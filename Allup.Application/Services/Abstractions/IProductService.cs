using Allup.Application.Services.Abstractions.Generic;

namespace Allup.Application.Services.Abstractions;

public interface IProductService : IGetWithLanguagesService<ProductGetViewModel>
{
    Task<bool> IsProductExist(int id);
}
