using Microsoft.AspNetCore.Identity;

namespace Allup.Domain.Entities;

public class AppUser : IdentityUser
{
    public string Fullname { get; set; } = null!;
    public List<WishlistItem> WishListItems { get; set; } = [];
}