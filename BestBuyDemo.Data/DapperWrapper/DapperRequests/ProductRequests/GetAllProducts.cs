namespace BestBuyDemo.Data.DapperWrapper.DapperRequests.ProductRequests
{
    internal class GetAllProducts : BaseParameterlessRequest
    {
        public override string GenerateSql() => _sql;

        private const string _sql = "SELECT * FROM Product";
    }
}
