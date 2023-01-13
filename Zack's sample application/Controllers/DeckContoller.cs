using Microsoft.AspNetCore.Mvc;
using Zacks_sample_application.Models;
using Zacks_sample_application.ViewModels;

namespace Zacks_sample_application.Controllers
{
    public class DeckContoller : Controller
    {
        private readonly IDeckRepository _deckRepository;
        private readonly ICategoryRepository _categoryRepository;

        public DeckContoller
            (IDeckRepository deckRepository, ICategoryRepository categoryRepository)
        {
            _deckRepository = deckRepository;
            _categoryRepository = categoryRepository;
        }

		public ViewResult List(string category)
        {
			IEnumerable<Deck> decks;
			string? currentCategory;

			if (string.IsNullOrEmpty(category))
			{
				decks = _deckRepository.AllDecks.OrderBy(p => p.DeckId);
				currentCategory = "All decks";
			}
			else
			{
				decks = _deckRepository.AllDecks.Where(p => p.Category.CategoryName == category)
					.OrderBy(p => p.DeckId);
				currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
			}

			return View(new DeckListViewModel(decks, currentCategory));
		}
		public IActionResult Details(int id)
        {
            var deck = _deckRepository.GetDeckById(id);
            if (deck == null)
                return NotFound();
            return View(deck);
        }
    }
}
