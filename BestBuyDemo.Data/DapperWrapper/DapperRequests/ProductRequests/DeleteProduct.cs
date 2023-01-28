namespace BestBuyDemo.Data.DapperWrapper.DapperRequests.ProductRequests
{
    internal class DeleteProduct : IDapperRequest
    {
        public DeleteProduct(Guid guid) => Guid = guid;

        public Guid Guid { get; set; }

        object? IDapperRequest.GenerateParameters() => new { Guid };

        string IDapperRequest.GenerateSql() => "DELETE FROM Product WHERE Guid = @Guid";
    }
}
