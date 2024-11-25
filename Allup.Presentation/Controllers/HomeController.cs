using Allup.Application.UI.Services.Asbtarctions;
using Microsoft.AspNetCore.Mvc;

namespace Allup.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public async Task<IActionResult> Index()
        {
            var homeViewModel = await _homeService.GetHomeViewModel();

            return View(homeViewModel);
        }
    }
}
