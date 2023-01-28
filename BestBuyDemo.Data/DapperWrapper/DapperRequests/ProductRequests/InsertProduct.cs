namespace BestBuyDemo.Data.DapperWrapper.DapperRequests.ProductRequests
{
    internal class InsertProduct : IDapperRequest
    {
        public ProductDTO Product { get; set; }

        public InsertProduct(Guid guid, string name, decimal price, int categoryId, bool onSale, int stockLevel) => 
            Product = new(guid, name, price, categoryId, onSale, stockLevel);

        string IDapperRequest.GenerateSql() =>
            @"
                INSERT INTO Product (Guid, Name, Price, CategoryId, OnSale, StockLevel)
                             VALUES (@Guid, @Name, @Price, @CategoryId, @OnSale, @StockLevel)
            ";

        object? IDapperRequest.GenerateParameters() =>
            new { Product.Guid, Product.Name, Product.Price, Product.CategoryId, Product.OnSale, Product.StockLevel };
    }
}
