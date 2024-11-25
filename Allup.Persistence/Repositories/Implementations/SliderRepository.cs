namespace Allup.Persistence.Repositories.Implementations;

internal class SliderRepository : Repository<Slider>, ISliderRepository
{
    public SliderRepository(AppDbContext context) : base(context)
    {
    }
}
