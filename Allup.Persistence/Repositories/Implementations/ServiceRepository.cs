namespace Allup.Persistence.Repositories.Implementations;

internal class ServiceRepository : Repository<Service>, IServiceRepository
{
    public ServiceRepository(AppDbContext context) : base(context)
    {
    }
}
