using Allup.Application.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Allup.Presentation.Controllers;

public class WishlistController : LocalizerController
{
    private readonly IWishlistService _wishlistService;
    private readonly IHttpContextAccessor _httpContextAccessor;
    public WishlistController(ILanguageService languageService, IWishlistService wishlistService, IHttpContextAccessor httpContextAccessor) : base(languageService)
    {
        _wishlistService = wishlistService;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _wishlistService.GetWishlistItemsAsync(await GetLanguageAsync());

        return View(products);
    }
    [HttpPost]
    public async Task<IActionResult> ToggleToWishlist(int productId)
    {
        var result = await _wishlistService.ToggleToWishlistAsync(productId);

        var returUrl = _httpContextAccessor.HttpContext.Request.Headers["Referer"];

        return Json(result);
    }


}
