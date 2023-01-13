namespace Zacks_sample_application.Models
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            ZacksSampleApplicationDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ZacksSampleApplicationDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Decks.Any())
            {
                context.AddRange
                (
                    new Deck { Name = "Alienworkshop OG Logo Deck", Price = 60.00M, ShortDescription = "The ultimate OG Skate deck!!", LongDescription = "This is a test long description used as a place holder currently!!", Category = Categories["Skateboard"], ImageUrl = "C:\\Users\\zackd\\Documents\\Skateboard decks images\\Alienworkshop OG Logo Deck.jpg", InStock = true, IsDeckofTheWeek = true, ImageThumbnailUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Alienworkshop OG Logo Deck.jpg\"" },
                    new Deck { Name = "Arbor Slater Longboard", Price = 80.00M, ShortDescription = "Looks so good!!", LongDescription = "This is a test long description used as a place holder currently!!", Category = Categories["Longboard"], ImageUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Arbor Slater Longboard.jfif\"", InStock = true, IsDeckofTheWeek = true, ImageThumbnailUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Arbor Slater Longboard.jfif\"" },
                    new Deck { Name = "Blind Skate Board Deck", Price = 45.00M, ShortDescription = "We're going nuts over this one", LongDescription = "This is a test long description used as a place holder currently!!", Category = Categories["Skateboard"], ImageUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Blind Skate Board Deck.jfif\"", InStock = true, IsDeckofTheWeek = true, ImageThumbnailUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Blind Skate Board Deck.jfif\"" },
                    new Deck { Name = "Chocolate Cursive Chunk Deck Anderson", Price = 35.99M, ShortDescription = "Can you handle it!", LongDescription = "This is a test long description used as a place holder currently!!", Category = Categories["Skateboard"], ImageUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Chocolate Cursive Chunk Deck Anderson.jpg\"", InStock = true, IsDeckofTheWeek = false, ImageThumbnailUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Chocolate Cursive Chunk Deck Anderson.jpg\"" },
                    new Deck { Name = "Connely Benz Wakesurf Board", Price = 59.99M, ShortDescription = "Catch a ride?!", LongDescription = "This is a test long description used as a place holder currently!!", Category = Categories["Wakesurfboard"], ImageUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Connelly Benz Wakesurf Board.jpg\"", InStock = true, IsDeckofTheWeek = false, ImageThumbnailUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Connelly Benz Wakesurf Board.jpg\"" },
                    new Deck { Name = "Element Escape From The Mind 838 Skateboard Deck", Price = 60.00M, ShortDescription = "Our famous Deck!", LongDescription = "This is a test long description used as a place holder currently!!", Category = Categories["Skateboard"], ImageUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\element escape from the mind 838 skateboard deck.jpg\"", InStock = true, IsDeckofTheWeek = false, ImageThumbnailUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\element escape from the mind 838 skateboard deck.jpg\"" },
                    new Deck { Name = "Element Forest Green Deck", Price = 60.00M, ShortDescription = "You'll love it!", LongDescription = "This is a test long description used as a place holder currently!!", Category = Categories["Skateboard"], ImageUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Element Forest Green Deck.jpg\"", InStock = true, IsDeckofTheWeek = false, ImageThumbnailUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Element Forest Green Deck.jpg\"" },
                    new Deck { Name = "Jeyo Classic Surfer Wake Surf Board", Price = 75.00M, ShortDescription = "Plain pleasure.", LongDescription = "This is a test long description used as a place holder currently!!", Category = Categories["Wakesufboard"], ImageUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Jeyo Classic Surfer Wake Surf Board.jfif\"", InStock = true, IsDeckofTheWeek = false, ImageThumbnailUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Jeyo Classic Surfer Wake Surf Board.jfif\"" },
                    new Deck { Name = "Liquid Force Doum Pro Wake Surf Board", Price = 79.00M, ShortDescription = "No doubt!", LongDescription = "This is a test long description used as a place holder currently!!", Category = Categories["Wakesurfboard"], ImageUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Liquid Force Doum Pro Wakesurf Board.jpg\"", InStock = true, IsDeckofTheWeek = false, ImageThumbnailUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Liquid Force Doum Pro Wakesurf Board.jpg\"" },
                    new Deck { Name = "Long Board Gold Coast Skateboard CO", Price = 65.00M, ShortDescription = "Feel it!", LongDescription = "This is a test long description used as a place holder currently!!", Category = Categories["Longboard"], ImageUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Long Board Gold Coast Skateboard CO.jpg\"", InStock = true, IsDeckofTheWeek = false, ImageThumbnailUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Long Board Gold Coast Skateboard CO.jpg\"" },
                    new Deck { Name = "Sector Longboard Wave", Price = 67.00M, ShortDescription = "A Christmas favorite", LongDescription = "This is a test long description used as a place holder currently!!", Category = Categories["Longboard"], ImageUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Sector long board wave.jpg\"", InStock = true, IsDeckofTheWeek = false, ImageThumbnailUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Sector long board wave.jpg\"" },
                    new Deck { Name = "Sector Nine Longboard", Price = 67.00M, ShortDescription = "Careful, she's fast!", LongDescription = "This is a test long description used as a place holder currently!!", Category = Categories["Longboard"], ImageUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Sector Nine Long Board.jpg\"", InStock = false, IsDeckofTheWeek = false, ImageThumbnailUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Sector Nine Long Board.jpg\"" },
                    new Deck { Name = "Supreme Skateboard Cheetah", Price = 70.00M, ShortDescription = "Premium Deck!", LongDescription = "This is a test long description used as a place holder currently!!", Category = Categories["Skateboard"], ImageUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Supreme Skateboard.jpg\"", InStock = true, IsDeckofTheWeek = false, ImageThumbnailUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Supreme Skateboard.jpg\"" },
                    new Deck { Name = "Symphony Skateboard", Price = 60.00M, ShortDescription = "My God, so sweet!", LongDescription = "This is a test long description used as a place holder currently!!", Category = Categories["Skateboard"], ImageUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Symphony Skateboard.jfif\"", InStock = true, IsDeckofTheWeek = false, ImageThumbnailUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Symphony Skateboard.jfif\"" },
                    new Deck { Name = "Toy Machine Skeleton Demon", Price = 60.00M, ShortDescription = "Dark, I can has?!", LongDescription = "This is a test long description used as a place holder currently!!", Category = Categories["Skateboard"], ImageUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Toy Machine Skeleton Demon.jfif\"", InStock = true, IsDeckofTheWeek = false, ImageThumbnailUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Toy Machine Skeleton Demon.jfif\"" },
                    new Deck { Name = "Zero Skateboard Deck", Price = 59.99M, ShortDescription = "You'll love it!", LongDescription = "This is a test long description used as a place holder currently!!", Category = Categories["Skateboard"], ImageUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Zero Skateboard Deck.jpg\"", InStock = false, IsDeckofTheWeek = false, ImageThumbnailUrl = "\"C:\\Users\\zackd\\Documents\\Skateboard decks images\\Zero Skateboard Deck.jpg\"" }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category>? categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Skateboard" },
                        new Category { CategoryName = "Longboard" },
                        new Category { CategoryName = "Wakesurfboard" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
