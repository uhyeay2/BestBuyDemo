namespace BestBuyDemo.WebApp.Models
{
    public class UpdateProductViewModel
    {
        public UpdateProductViewModel()
        {
        }

        public UpdateProductViewModel(Product product, IEnumerable<string> categoryNames) : this()
        {
            Product = product;
            CategoryNames = categoryNames;
        }

        public Product Product { get; set; } = null!;

        public IEnumerable<string> CategoryNames { get; set; } = Enumerable.Empty<string>();
    }
}
