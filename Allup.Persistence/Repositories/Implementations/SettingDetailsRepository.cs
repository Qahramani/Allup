namespace Allup.Persistence.Repositories.Implementations;

internal class SettingDetailsRepository : Repository<SettingDetails>, ISettingDetailsRepository
{
    public SettingDetailsRepository(AppDbContext context) : base(context)
    {
    }
}
