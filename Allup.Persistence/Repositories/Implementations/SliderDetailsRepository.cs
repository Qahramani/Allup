namespace Allup.Persistence.Repositories.Implementations;

internal class SliderDetailsRepository : Repository<SliderDetails>, ISliderDetailsRepository
{
    public SliderDetailsRepository(AppDbContext context) : base(context)
    {
    }
}
