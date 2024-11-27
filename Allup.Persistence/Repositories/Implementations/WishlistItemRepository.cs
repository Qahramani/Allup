namespace Allup.Persistence.Repositories.Implementations;

internal class WishlistItemRepository : Repository<WishlistItem>, IWishlistRepository
{
    public WishlistItemRepository(AppDbContext context) : base(context)
    {
    }
}
