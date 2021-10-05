using Microsoft.AspNetCore.Mvc;
using RocketLeague.Website.Interactors;

namespace RocketLeague.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly RocketLeagueInteractor _rocketLeagueInteractor;

        public HomeController()
        {
            _rocketLeagueInteractor = new RocketLeagueInteractor();
        }

        public IActionResult Index()
        {
            var vm = _rocketLeagueInteractor.GetViewModel();
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
