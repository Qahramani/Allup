namespace Allup.Persistence.Repositories.Implementations;

internal class LanguageRepository : Repository<Language>, ILanguageRepository
{
    public LanguageRepository(AppDbContext context) : base(context)
    {
    }
}
