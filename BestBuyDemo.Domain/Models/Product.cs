namespace BestBuyDemo.Domain.Models
{
    public class Product
    {
        #region Constructors

        public Product() { }

        public Product(Guid guid, string name, decimal price, string? category, bool onSale, int stockLevel)
        {
            Guid = guid;
            Name = name;
            Price = price;
            Category = category ?? "CategoryNotFound";
            OnSale = onSale;
            StockLevel = stockLevel;
        }

        #endregion

        #region Properties

        public Guid Guid { get; set; }

        public string Name { get; set; } = null!;
        
        public decimal Price { get; set; }

        public string Category { get; set; } = null!;

        public bool OnSale { get; set; }

        public int StockLevel { get; set; }

        #endregion
    }
}
