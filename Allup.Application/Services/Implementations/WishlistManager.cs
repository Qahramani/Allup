
using Allup.Domain.Entities;
using Allup.Persistence.Repositories.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Security.Claims;

namespace Allup.Application.Services.Implementations;

internal class WishlistManager : IWishlistService
{
    private readonly IProductService _productService;
    private readonly IHttpContextAccessor _contextAccessor;
    private const string WISHLIST_COOKIE_KEY = "AllupWishlist";
    private readonly IWishlistRepository _repository;
    private readonly IMapper _mapper;

    public WishlistManager(IProductService productService, IHttpContextAccessor httpContext, IWishlistRepository repository, IMapper mapper)
    {
        _productService = productService;
        _contextAccessor = httpContext;
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<bool> ToggleToWishlistAsync(int productId)
    {
        var isProductExist = await _productService.IsProductExist(productId);

        if (!isProductExist)
            return false;

        if (_contextAccessor.HttpContext.User.Identity?.IsAuthenticated ?? false)
        {
            var userId = _contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "";

            var existItem = await _repository.GetAsync(x => x.ProductId == productId && x.UserId == userId);

            if (existItem != null)
            {
                _repository.Delete(existItem);
                await _repository.SaveChangesAsync();
                return true;
            }

            WishlistItem newWishlistItem = new()
            {
                ProductId = productId,
                UserId = userId
            };

            await _repository.CreateAsync(newWishlistItem);
            await _repository.SaveChangesAsync();
            return true;
        }
        else
        {
            var wishlistItems = _readFromCookies();

            if (wishlistItems.Contains(productId))
                wishlistItems.Remove(productId);
            else
            {
                wishlistItems.Add(productId);
            }
            _writeToCookies(wishlistItems);
            return true;
        }
    }

    private void _writeToCookies(List<int> wishlistItems)
    {
        var json = JsonConvert.SerializeObject(wishlistItems);

        _contextAccessor.HttpContext.Response.Cookies.Append(WISHLIST_COOKIE_KEY, json);
    }

    private List<int> _readFromCookies()
    {
        var json = _contextAccessor.HttpContext.Request.Cookies[WISHLIST_COOKIE_KEY] ?? "";

        var wishlistItems = JsonConvert.DeserializeObject<List<int>>(json) ?? [];

        return wishlistItems;
    }

    public async Task<List<WishlistItemGetViewModel>> GetWishlistItemsAsync(int languageId)
    {
        List<WishlistItemGetViewModel> wishlistItems = new List<WishlistItemGetViewModel>();

        if (_contextAccessor.HttpContext.User.Identity?.IsAuthenticated ?? false)
        {
            var userId = _contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "";

            var products = _repository.GetFilter(x => x.UserId == userId, x => x.Include(x => x.Product).ThenInclude(x => x!.ProductDetails.Where(x => x.LanguageId == languageId)));

            wishlistItems = _mapper.Map<List<WishlistItemGetViewModel>>(products);

            return wishlistItems;
        }
        else
        {
            var productIds = _readFromCookies();

            var allProducts = await _productService.GetAllAsync(languageId);

            foreach (var prod in allProducts)
            {
                if (productIds.Contains(prod.Id))
                {
                    WishlistItemGetViewModel item = new()
                    {
                        Id = prod.Id,
                        Name = prod.Name,
                        Description = prod.Description,
                        MainImagePath = prod.MainImagePath,
                        Price = prod.Price
                    };
                    wishlistItems.Add(item);
                }
            }
                return wishlistItems;
        }
    }
}
