namespace BestBuyDemo.Data.DapperWrapper.DapperRequests.ProductRequests
{
    public class GetProductByGuid : IDapperRequest
    {
        public GetProductByGuid(string guid) => Guid = Guid.TryParse(guid, out var g) ? g : Guid.Empty;

        public Guid Guid { get; set; }

        object? IDapperRequest.GenerateParameters() => new { Guid };

        string IDapperRequest.GenerateSql() => "SELECT * FROM Product WHERE Guid = @Guid";
    }
}
