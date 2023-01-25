using BestBuyDemo.Domain.Models;

namespace BestBuyDemo.Domain.Interfaces
{
    public interface IProductRepository
    {
        public Task<IEnumerable<Product>> GetProductsAsync();
    }
}
