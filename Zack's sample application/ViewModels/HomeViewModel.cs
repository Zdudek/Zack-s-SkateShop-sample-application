using Zacks_sample_application.Models;

namespace Zacks_sample_application.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Deck> DecksOfTheWeek { get; }

        public HomeViewModel(IEnumerable<Deck> decksfTheWeek)
        {
            DecksOfTheWeek = decksfTheWeek;
        }
    }
}
