namespace BestBuyDemo.Data.Extensions
{
    internal static class CategoryExtensions
    {
        public static string? GetNameById(this IEnumerable<CategoryDTO> categories, int id) => 
            categories?.FirstOrDefault(c => c.Id == id)?.Name;
    }
}
