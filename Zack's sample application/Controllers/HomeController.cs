using Zacks_sample_application.Models;
using Zacks_sample_application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Zacks_sample_application.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDeckRepository _deckRepository;

        public HomeController(IDeckRepository deckRepository)
        {
            _deckRepository = deckRepository;
        }

        public ViewResult Index()
        {
            var decksOfTheWeek = _deckRepository.DecksofTheWeek;

            var homeViewModel = new HomeViewModel(decksOfTheWeek);

            return View(homeViewModel);
        }
    }
}
