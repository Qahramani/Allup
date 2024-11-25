namespace Allup.Persistence.Repositories.Implementations;

internal class ServiceDetailsRepository : Repository<ServiceDetails>, IServiceDetailsRepository
{
    public ServiceDetailsRepository(AppDbContext context) : base(context)
    {
    }
}