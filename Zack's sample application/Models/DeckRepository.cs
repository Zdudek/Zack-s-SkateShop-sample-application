using Microsoft.EntityFrameworkCore;

namespace Zacks_sample_application.Models
{
	public class DeckRepository: IDeckRepository
	{
		private readonly ZacksSampleApplicationDbContext _zacksSampleApplicationDbContext;

		public DeckRepository(ZacksSampleApplicationDbContext ZacksSampleApplicationDbContext)
		{
			_zacksSampleApplicationDbContext= ZacksSampleApplicationDbContext;
		}

		public IEnumerable<Deck> AllDecks
		{
			get
			{
				return _zacksSampleApplicationDbContext.Decks.Include(c => c.Category);
			}
		}

		public IEnumerable<Deck> DecksofTheWeek
		{
			get
			{
				return _zacksSampleApplicationDbContext.Decks.Include(c => c.Category).Where(p =>
				p.IsDeckofTheWeek);
			}
		}

		public Deck? GetDeckById(int deckId)
		{
			return _zacksSampleApplicationDbContext.Decks.FirstOrDefault(p => p.DeckId == deckId);


		}


	}
}
