using Zacks_sample_application.Models;

namespace Zacks_sample_application.ViewModels
{
	public class DeckListViewModel
	{
		public IEnumerable<Deck> Decks { get; set; }
		public string? CurrentCategory { get; set; }
		public DeckListViewModel(IEnumerable<Deck> decks, string? currentCategory)
		{
			Decks = decks;
			CurrentCategory = currentCategory;
		}
	}
}
