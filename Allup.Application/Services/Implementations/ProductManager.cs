using Allup.Persistence.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Allup.Application.Services.Implementations;

internal class ProductManager : IProductService
{
    private readonly IProductRepository _repository;
    private readonly IMapper _mapper;

    public ProductManager(IProductRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ProductGetViewModel>> GetAllAsync(int languageId = 1)
    {
        var products = await _repository.GetAll(x => x.Include(x => x.ProductDetails.Where(x => x.LanguageId == languageId)).Include(x => x.ProductImages).Include(x => x.Category)).ToListAsync();

        var viewModels = _mapper.Map<List<ProductGetViewModel>>(products);

        return viewModels;
    }

    public Task<ProductGetViewModel> GetAsync(int id, int languageId = 1)
    {
        throw new NotImplementedException();
    }
}
