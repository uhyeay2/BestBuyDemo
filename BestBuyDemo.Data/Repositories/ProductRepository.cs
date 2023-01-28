using BestBuyDemo.Data.DapperWrapper.DapperRequests.CategoryRequests;
using BestBuyDemo.Data.DapperWrapper.DapperRequests.ProductRequests;
using BestBuyDemo.Data.Extensions;
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

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            var products = await _dapper.FetchListAsync<ProductDTO>(new GetAllProducts());

            var categories = await _dapper.FetchListAsync<CategoryDTO>(new GetAllCategories());

            return products.Select(x => 
                new Product(x.Guid, x.Name, x.Price, categories.GetNameById(x.CategoryId), x.OnSale, x.StockLevel));
        }

        public async Task<Product?> GetProductAsync(string productGuid)
        {
            var product = await _dapper.FetchAsync<ProductDTO>(new GetProductByGuid(productGuid));

            if (product == null) return null;

            var category = await _dapper.FetchAsync<CategoryDTO>(new GetCategoryById(product.CategoryId));

            return new Product(product.Guid, product.Name, product.Price, category?.Name, product.OnSale, product.StockLevel);
        }

        public async Task<Product?> InsertProductAsync(Product product)
        {            
            var categoryId = await _dapper.FetchAsync<int>(new GetCategoryIdByName(product.Category));

            await _dapper.ExecuteAsync(new InsertProduct(product.Guid, product.Name, product.Price, categoryId, product.OnSale, product.StockLevel));

            return await GetProductAsync(product.Guid.ToString());
        }

        public async Task<Product?> UpdateProductAsync(Product product)
        {
            var categoryId = await _dapper.FetchAsync<int>(new GetCategoryIdByName(product.Category));

            await _dapper.ExecuteAsync(new UpdateProduct(product.Guid, product.Name, product.Price, categoryId, product.OnSale, product.StockLevel));

            return await GetProductAsync(product.Guid.ToString());
        }

        public async Task<int> DeleteProductAsync(Guid productGuid) => await _dapper.ExecuteAsync(new DeleteProduct(productGuid));

        public async Task<IEnumerable<string>> GetAllCategoryNames() => (await _dapper.FetchListAsync<CategoryDTO>(new GetAllCategories())).Select(x => x.Name);
    }
}
