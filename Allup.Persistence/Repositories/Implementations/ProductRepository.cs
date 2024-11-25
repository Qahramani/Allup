namespace Allup.Persistence.Repositories.Implementations;

internal class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context)
    {
    }
}
