namespace BestBuyDemo.Data.DapperWrapper.DapperRequests.CategoryRequests
{
    internal class GetCategoryIdByName : IDapperRequest
    {
        public GetCategoryIdByName(string name) => Name = name;

        public string Name { get; set; }

        object? IDapperRequest.GenerateParameters() =>new { Name };

        string IDapperRequest.GenerateSql() => "SELECT Id FROM Category WHERE Name = @Name";
    }
}
