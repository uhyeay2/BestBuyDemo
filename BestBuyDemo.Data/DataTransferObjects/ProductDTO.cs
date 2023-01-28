namespace BestBuyDemo.Data.DataTransferObjects
{
    internal class ProductDTO
    {
        public ProductDTO() { }

        public ProductDTO(Guid guid, string name, decimal price, int categoryId, bool onSale, int stockLevel)
        {
            Guid = guid;
            Name = name;
            Price = price;
            CategoryId = categoryId;
            OnSale = onSale;
            StockLevel = stockLevel;
        }

        public int Id { get; set; }

        public Guid Guid { get; set; }

        public string Name { get; set; } = null!;
        
        public decimal Price { get; set; }
        
        public int CategoryId { get; set; }
        
        public bool OnSale { get; set; }
        
        public int StockLevel { get; set; }
    }
}
