namespace Allup.Persistence.Repositories.Implementations;

internal class ProductDetailsRepository : Repository<ProductDetails>, IProductDetailsRepository
{
    public ProductDetailsRepository(AppDbContext context) : base(context)
    {
    }
}
