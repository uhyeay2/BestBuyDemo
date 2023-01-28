namespace BestBuyDemo.Data.DapperWrapper.DapperRequests.CategoryRequests
{
    internal class GetCategoryById : IDapperRequest
    {
        public GetCategoryById(int id) => Id = id;

        public int Id { get; set; }

        object? IDapperRequest.GenerateParameters() => new { Id };

        string IDapperRequest.GenerateSql() => "SELECT * FROM Category WHERE Id = @Id";
    }
}
