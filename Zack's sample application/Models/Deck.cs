namespace Zacks_sample_application.Models
{
    public class Deck
    {
        public int DeckId { get; set; }
        public string Name { get; set;} = string .Empty;
        public string? ShortDescription { get; set;}
        public string? LongDescription { get; set;}
        public string? Manufacturer { get; set;}
        public decimal Price { get; set;}
        public string? ImageUrl { get; set;}
        public string? ImageThumbnailUrl{ get; set;}
        public bool IsDeckofTheWeek { get; set;}
        public bool? InStock { get; set;}

        public int CategoryId { get; set;}
        public Category Category { get; set; } = default!;


    }
}
