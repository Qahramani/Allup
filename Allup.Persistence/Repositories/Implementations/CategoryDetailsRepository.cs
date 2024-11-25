namespace Allup.Persistence.Repositories.Implementations;

internal class CategoryDetailsRepository : Repository<CategoryDetails>, ICategoryDetailsRepository
{
    public CategoryDetailsRepository(AppDbContext context) : base(context)
    {
    }
}
