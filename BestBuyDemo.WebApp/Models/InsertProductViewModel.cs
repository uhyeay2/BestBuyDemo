namespace BestBuyDemo.WebApp.Models
{
    public class InsertProductViewModel
    {
        public InsertProductViewModel()
        {
            Product = new() { Guid = Guid.NewGuid() };
        }

        public InsertProductViewModel(IEnumerable<string> categoryNames) : this()
        {
            CategoryNames = categoryNames;
        }

        public Product Product { get; set; }

        public IEnumerable<string> CategoryNames { get; set; } = Enumerable.Empty<string>();    
    }
}
