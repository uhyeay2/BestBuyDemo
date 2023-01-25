namespace BestBuyDemo.Domain.Models
{
    public class Department
    {
        public string Name { get; set; } = null!;

        public IEnumerable<Category> Categories { get; set; } = Enumerable.Empty<Category>();

    }
}
