namespace Allup.Application.Services.Abstractions;

public interface IWishlistService
{
    Task<bool> ToggleToWishlistAsync(int productId);
    Task<List<WishlistItemGetViewModel>> GetWishlistItemsAsync(int languageId);
}
