namespace Zacks_sample_application.Models
{
    public interface IDeckRepository
    {
        IEnumerable<Deck> AllDecks { get; }
        IEnumerable<Deck> DecksofTheWeek { get; }
        Deck? GetDeckById(int deckId);
    }
}
