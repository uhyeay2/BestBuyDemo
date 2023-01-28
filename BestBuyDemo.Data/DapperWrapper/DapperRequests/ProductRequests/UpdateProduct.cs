namespace BestBuyDemo.Data.DapperWrapper.DapperRequests.ProductRequests
{
    internal class UpdateProduct : IDapperRequest
    {
        public ProductDTO Product { get; set; }

        public UpdateProduct(Guid guid, string name, decimal price, int categoryId, bool onSale, int stockLevel) =>
            Product = new(guid, name, price, categoryId, onSale, stockLevel);

        object? IDapperRequest.GenerateParameters() =>
            new { Product.Guid, Product.Name, Product.Price, Product.CategoryId, Product.OnSale, Product.StockLevel };

        string IDapperRequest.GenerateSql() =>
            @" UPDATE Product SET 
                    Name = COALESCE (@Name, Name),
                    Price = COALESCE (@Price, Price),
                    CategoryId = COALESCE (@CategoryId, CategoryId),
                    OnSale = COALESCE (@OnSale, OnSale),
                    StockLevel = COALESCE (@StockLevel, StockLevel)
                WHERE Guid = @Guid
            ";
    }
}
