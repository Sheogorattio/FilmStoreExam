namespace FilmStoreExam.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal RetailPrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<int>? ActorId { get; set; } = new List<int>();
        public List<Actor>? Actor { get; set; }
        public decimal Rating { get; set; }
        public string ImdbUrl { get; set; }
        public string ImageUrl { get; set; }
    }
}
