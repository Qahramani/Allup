using Allup.Application.Services.Abstractions;
using Allup.Application.UI.Services.Asbtarctions;
using Microsoft.AspNetCore.Mvc;

namespace Allup.Presentation.Controllers
{
    public class HomeController : LocalizerController
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService, ILanguageService languageService) : base(languageService) 
        {
            _homeService = homeService;
        }

        public async Task<IActionResult> Index()
        {
            var homeViewModel = await _homeService.GetHomeViewModel(await GetLanguageAsync());

            return View(homeViewModel);
        }
    }
}
