using BestBuyDemo.Data.DapperWrapper.DapperRequests;
using BestBuyDemo.Data.DataTransferObjects;
using BestBuyDemo.Data.Interfaces;
using BestBuyDemo.Domain.Interfaces;
using BestBuyDemo.Domain.Models;

namespace BestBuyDemo.Data.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        private readonly IDapperWrapper _dapper;

        public ProductRepository(IDapperWrapper dapper)
        {
            _dapper = dapper;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var products = await _dapper.FetchListAsync<ProductDTO>(new GetAllProducts());

            var categories = await _dapper.FetchListAsync<CategoryDTO>(new GetAllCategories());

            return products.Select(x => new Product()
            {
                Name = x.Name,
                Price = x.Price,
                OnSale = x.OnSale,
                StockLevel = x.StockLevel,
                Category = categories.FirstOrDefault(c => c.Id == x.Id)?.Name ?? string.Empty
            });
        }
    }
}
