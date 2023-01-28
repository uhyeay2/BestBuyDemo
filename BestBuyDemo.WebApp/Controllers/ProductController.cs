using BestBuyDemo.Domain.Interfaces;
using BestBuyDemo.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BestBuyDemo.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepo;

        public ProductController(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<IActionResult> Index() => View(await _productRepo.GetAllProductsAsync());

        public async Task<IActionResult> ViewProduct(string id) => View(await _productRepo.GetProductAsync(id));

        public async Task<IActionResult> InsertProductForm() => View(new InsertProductViewModel(await _productRepo.GetAllCategoryNames()));

        public async Task<IActionResult> InsertProduct(Product productToInsert)
        {
            productToInsert.Guid = Guid.NewGuid();

            var product = await _productRepo.InsertProductAsync(productToInsert);

            return RedirectToAction(nameof(ViewProduct), new {id = product!.Guid} );
        }            

        public async Task<IActionResult> UpdateProductForm(string id)
        {
            var product = await _productRepo.GetProductAsync(id);

            if (product == null) return NotFound();

            return View(new UpdateProductViewModel(product, await _productRepo.GetAllCategoryNames()));
        }

        public async Task<IActionResult> UpdateProduct(Product product)
        {
            var updatedProduct = await _productRepo.UpdateProductAsync(product);

            if (updatedProduct == null) return NotFound();

            return RedirectToAction(nameof(ViewProduct), new { id = updatedProduct.Guid }); 
        }

        public async Task<IActionResult> DeleteProduct(Guid guid)
        {
            await _productRepo.DeleteProductAsync(guid);

            return RedirectToAction(nameof(Index));
        }

    }
}
