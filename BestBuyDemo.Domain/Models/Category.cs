namespace BestBuyDemo.Domain.Models
{
    public class Category
    {
        public string Name { get; set; } = null!;

        public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();
    }
}
