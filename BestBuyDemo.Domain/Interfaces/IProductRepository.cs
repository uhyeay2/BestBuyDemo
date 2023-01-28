using BestBuyDemo.Domain.Models;

namespace BestBuyDemo.Domain.Interfaces
{
    public interface IProductRepository
    {
        public Task<IEnumerable<Product>> GetAllProductsAsync();

        public Task<Product?> GetProductAsync(string productGuid);

        public Task<Product?> UpdateProductAsync(Product product);

        public Task<Product?> InsertProductAsync(Product product);

        public Task<int> DeleteProductAsync(Guid productGuid);

        public Task<IEnumerable<string>> GetAllCategoryNames();
    }
}
