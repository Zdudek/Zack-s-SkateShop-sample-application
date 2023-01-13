namespace Zacks_sample_application.Models
{
	public class CategoryRepository: ICategoryRepository
	{
		private readonly ZacksSampleApplicationDbContext _zacksSampleApplicationDbContext;

		public CategoryRepository(ZacksSampleApplicationDbContext zacksSampleApplicationDbContext)
		{ 
			_zacksSampleApplicationDbContext = zacksSampleApplicationDbContext;
		}

		public IEnumerable<Category> AllCategories =>
			_zacksSampleApplicationDbContext.Categories.OrderBy(p => p.CategoryName);
	}
}
