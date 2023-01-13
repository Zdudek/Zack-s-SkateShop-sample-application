using Microsoft.EntityFrameworkCore;

namespace Zacks_sample_application.Models
{
	public class ZacksSampleApplicationDbContext: DbContext
	{
		public ZacksSampleApplicationDbContext(DbContextOptions<ZacksSampleApplicationDbContext>
			options) : base(options)
		{
		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<Deck> Decks { get; set; }
	}
}
