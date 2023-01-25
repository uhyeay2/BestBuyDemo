namespace BestBuyDemo.Domain.Models
{
    public class Product
    {
        public string Name { get; set; } = null!;
        
        public decimal Price { get; set; }

        public string Category { get; set; } = null!;

        public bool OnSale { get; set; }
        
        public int StockLevel { get; set; }
    }
}
