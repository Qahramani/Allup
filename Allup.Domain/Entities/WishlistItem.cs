namespace Allup.Domain.Entities;

public class WishlistItem :BaseEntity
{
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public string UserId { get; set; } = null!;
    public AppUser? AppUser { get; set; }
}

