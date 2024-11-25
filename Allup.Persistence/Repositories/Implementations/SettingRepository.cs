namespace Allup.Persistence.Repositories.Implementations;

internal class SettingRepository : Repository<Setting>, ISettingRepository
{
    public SettingRepository(AppDbContext context) : base(context)
    {
    }
}
