namespace BestBuyDemo.Data.Interfaces
{
    internal interface IDapperWrapper
    {
        internal Task<int> ExecuteAsync(IDapperRequest request);

        internal Task<TOutput> FetchAsync<TOutput>(IDapperRequest request);

        internal Task<IEnumerable<TOutput>> FetchListAsync<TOutput>(IDapperRequest request);
    }
}
